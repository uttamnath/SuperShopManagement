Imports System.Data.SqlClient

Public Class frmSupplier_Entry
    Dim mintSaveEditFlag As Short
    Protected Friend blnInstantEntry As Boolean

    Private Sub frmSupplier_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Focus()
        supplierid()
        Supplierfind()
        mintSaveEditFlag = 1
    End Sub
    Public Sub supplierid()
        Try
            Dim conn As New SqlConnection(gstrConnection)
            Dim sqlquery As String
            Dim cmd As SqlCommand
            Dim dr As SqlDataReader
            Dim a As Integer
            conn.Open()
            sqlquery = "select isnull(max(Id),0) maxid from Supplier_Entry"

            cmd = New SqlCommand(sqlquery, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                a = dr("maxid")
            End While

            txtID.Text = a + 1
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If (txtName.Text) = "" Then
                MessageBox.Show("Please enter valid Info.", "Save..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim translation As SqlTransaction = conn.BeginTransaction
            Try
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.Transaction = translation
                If mintSaveEditFlag = 1 Then
                    cmd.CommandText = "insert into Supplier_Entry (Id,Supplier_Name,Address,Mobile,OpenDate,OpeningBalance)values(" & _
                    Val(txtID.Text) & ",'" & (txtName.Text) & "','" & (txtAddress.Text) & "','" & (txtMobileNo.Text) & "','" & _
                    dtpDate.Value.Date.ToString("yyyy-MM-dd") & "'," & (txtOpnBal.Text) & ")"
                ElseIf mintSaveEditFlag = 2 Then
                    cmd.CommandText = "update Supplier_Entry set Supplier_Name='" & Trim(txtName.Text) & "',Address='" & Trim(txtAddress.Text) & _
                    "',Mobile='" & Val(txtMobileNo.Text) & "',OpeningBalance=" & Val(txtOpnBal.Text) & " where Id=" & Val(txtID.Text)
                End If
               
                cmd.ExecuteNonQuery()
                translation.Commit()
                conn.Close()
                txtName.Text = ""
                txtAddress.Text = ""
                txtMobileNo.Text = ""
                txtOpnBal.Text = ""

                dtpDate.Value = Today
                mintSaveEditFlag = 1
                cmdEdit.Enabled = True
                supplierid()
                Supplierfind()
                ' vendorSelect()
                If blnInstantEntry = True Then
                    blnInstantEntry = False
                    Me.Close()
                End If
            Catch ex As Exception
                translation.Rollback()
                conn.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            If lvSupplierEntry.SelectedItems.Count > 0 Then
                Dim shtRowindex As Short = lvSupplierEntry.SelectedItems(0).Index

                Dim conn As New SqlConnection(gstrConnection)
                conn.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "select * from Supplier_Entry where Id =" & lvSupplierEntry.Items(shtRowindex).SubItems(1).Text
                Dim sqlReader As SqlDataReader = cmd.ExecuteReader
                If sqlReader.Read = True Then
                    txtID.Text = sqlReader("ID").ToString
                    txtName.Text = sqlReader("Supplier_Name").ToString
                    txtAddress.Text = sqlReader("Address").ToString
                    dtpDate.Value = CDate(sqlReader("OpenDate").ToString)
                    txtMobileNo.Text = sqlReader("Mobile").ToString
                   txtOpnBal.Text = sqlReader("OpeningBalance").ToString
                    cmdEdit.Enabled = False
                    mintSaveEditFlag = 2 'For Edit
                Else
                    MessageBox.Show("Data does not exist.", "Edit..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please Select a supplier first.", "Edit..", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If MsgBox("Are you sure to delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Caution") = MsgBoxResult.Yes Then
                Dim shtRowindex As Short = lvSupplierEntry.SelectedItems(0).Index
                Dim conn As New SqlConnection(gstrConnection)
                conn.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "select * from ProductMaster where SupplierId =" & lvSupplierEntry.Items(shtRowindex).SubItems(1).Text
                Dim sqlReader1 As SqlDataReader = cmd.ExecuteReader
                If sqlReader1.Read = True Then
                    MessageBox.Show("You can't delete this supplire name.", "Forbidden..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sqlReader1.Close()
                Else
                    sqlReader1.Close()
                    cmd.CommandText = "delete from Supplier_Entry where Id =" & lvSupplierEntry.Items(shtRowindex).SubItems(1).Text
                    cmd.ExecuteNonQuery()
                End If

                conn.Close()
                cmdEdit.Enabled = True
                txtName.Text = ""
                txtAddress.Text = ""
                txtMobileNo.Text = ""
                txtOpnBal.Text = ""

                dtpDate.Value = Today
                mintSaveEditFlag = 1
                supplierid()
                Supplierfind()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Public Sub Supplierfind()
        Try
            lvSupplierEntry.Items.Clear()
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "select ID,Supplier_Name,Address,Mobile from Supplier_Entry order by Id"
            Dim sqlReader As SqlDataReader = cmd.ExecuteReader
            While sqlReader.Read = True
                Dim lvItem As New ListViewItem
                lvItem.SubItems.Add(sqlReader("ID").ToString)
                lvItem.SubItems.Add(sqlReader("Supplier_Name").ToString)
                lvItem.SubItems.Add(sqlReader("Address").ToString)
                lvItem.SubItems.Add(sqlReader("Mobile").ToString)
                lvSupplierEntry.Items.Add(lvItem)

            End While

            sqlReader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtAddress.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                dtpDate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtOpnBal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpnBal.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                cmdSave.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpDate.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtMobileNo.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtMobileNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileNo.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtOpnBal.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class