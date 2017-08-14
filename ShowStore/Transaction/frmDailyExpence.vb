Imports System.Data.SqlClient

Public Class frmDailyExpence
    Dim intSeltdRowIndex As Integer
    Private Sub cmdEntryOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntryOk.Click
        Try
            If Trim(txtParticulars.Text) = "" Then
                MessageBox.Show("There is no PArticular to add in list.", "Particular Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtParticulars.Focus()
                Exit Sub
            End If
            If Val(txtAmount.Text) = 0 Or txtAmount.Text = "" Then
                MsgBox("Please input TK.", MsgBoxStyle.Critical)
                txtAmount.Focus()
                Exit Sub
            End If

            If dgvVoucherEntry.Enabled = True Then

                Dim NewRow As String() = New String() _
                {dgvVoucherEntry.Rows.Count + 1, txtParticulars.Text, Val(txtAmount.Text)}
                dgvVoucherEntry.Rows.Add(NewRow)
            Else
                dgvVoucherEntry.Rows(intSeltdRowIndex).Cells(1).Value = txtParticulars.Text
                dgvVoucherEntry.Rows(intSeltdRowIndex).Cells(2).Value = Val(txtAmount.Text)
                dgvVoucherEntry.Enabled = True
            End If

            txtParticulars.Text = ""
            txtAmount.Text = ""

            txtParticulars.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdEntryCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntryCancel.Click
        txtAmount.Text = CStr(0.0#)
        txtParticulars.Text = ""
    End Sub
    Private Sub voutcherID()
        Try
            Dim conn As New SqlConnection(gstrConnection)
            Dim sqlquery As String
            Dim cmd As SqlCommand
            Dim dr As SqlDataReader
            Dim a As Integer
            conn.Open()
            sqlquery = "select isnull(max(VID),0) maxVoutcherID from Vouchar"
            cmd = New SqlCommand(sqlquery, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                a = dr("maxVoutcherID")
            End While
            txtVoucherNo.Text = a + 1
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmDailyExpence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        voutcherID()
    End Sub

    Private Sub cmdSaveEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveEntry.Click
        Try
            If dgvVoucherEntry.Rows.Count < 1 Then
                MessageBox.Show("There is no expence to save.", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
           
           
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim trans As SqlTransaction = conn.BeginTransaction
            Try
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.Transaction = trans
                If cmdEdit.Enabled = True Then 'VID,Serial,Date,Particular,Amt,Vouchar
                    For i As Short = 0 To dgvVoucherEntry.Rows.Count - 1
                        cmd.CommandText = "INSERT INTO Vouchar(VID,Serial,Date,Particular,Amt)VALUES(" & Val(txtVoucherNo.Text) & _
                         "," & dgvVoucherEntry.Rows(i).Cells(0).Value & _
                         ",'" & dtpSaleDate.Value.Date.ToString("yyyy-MM-dd") & _
                         "','" & dgvVoucherEntry.Rows(i).Cells(1).Value & _
                         "'," & dgvVoucherEntry.Rows(i).Cells(2).Value & ")"
                        cmd.ExecuteNonQuery()
                    Next
                    trans.Commit()
                    dgvVoucherEntry.Rows.Clear()
                ElseIf cmdEdit.Enabled = False Then
                    cmd.CommandText = "Delete from Vouchar where VID=" & Val(txtVoucherNo.Text)

                    cmd.ExecuteNonQuery()
                    For i As Short = 0 To dgvVoucherEntry.Rows.Count - 1
                        cmd.CommandText = "INSERT INTO Vouchar(VID,Serial,Date,Particular,Amt)VALUES(" & Val(txtVoucherNo.Text) & _
                        "," & dgvVoucherEntry.Rows(i).Cells(0).Value & _
                        ",'" & dtpSaleDate.Value.Date.ToString("yyyy-MM-dd") & _
                        "','" & dgvVoucherEntry.Rows(i).Cells(1).Value & _
                        "'," & dgvVoucherEntry.Rows(i).Cells(2).Value & ")"
                        cmd.ExecuteNonQuery()
                    Next
                    trans.Commit()
                    dgvVoucherEntry.Rows.Clear()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                trans.Rollback()
            End Try
            cmdEdit.Enabled = True
            conn.Close()
            voutcherID()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
           pnlSearch.Visible = True
            btnSearch.Text = "Search"
            Panel1.Enabled = False
            dgvVoucherEntry.Enabled = False
            txtSearchTransNo.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdVDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVDelete.Click
        Try
            btnSearch.Text = "Delete"
            pnlSearch.Visible = True
            Panel1.Enabled = False
            dgvVoucherEntry.Enabled = False
            txtSearchTransNo.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancelEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelEntry.Click
        Try
            dgvVoucherEntry.Rows.Clear()
            voutcherID()
            txtAmount.Text = ""
            txtParticulars.Text = ""
            txtSearchTransNo.Text = ""
            cmdEdit.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdCloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseForm.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim accountName As String = ""
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            If txtSearchTransNo.Text = "" Then
                MessageBox.Show("Plz Input any Voutcher No in this text box...", "Voutcher No Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If btnSearch.Text = "Search" Then 'VID,Serial,Date,Particular,Amt,Vouchar
                dgvVoucherEntry.Rows.Clear()
                cmd.CommandText = "Select * from Vouchar where VID=" & Val(txtSearchTransNo.Text) & ""
                Dim sqlReader As SqlDataReader = cmd.ExecuteReader
                If sqlReader.Read = True Then
                    dtpSaleDate.Value = CDate(sqlReader("Date").ToString)
                    txtVoucherNo.Text = CInt(sqlReader("VID"))
                Else
                    MessageBox.Show("Data does not exist against this Voutcher no. Plz be sure your input...", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sqlReader.Close()
                    Exit Sub
                End If
                sqlReader.Close()
                cmd.CommandText = "Select * from Vouchar where VID=" & Val(txtSearchTransNo.Text) & ""
                Dim sqlReader1 As SqlDataReader = cmd.ExecuteReader
                While sqlReader1.Read = True

                    Dim NewRow As String() = New String() _
                   {sqlReader1("Serial").ToString, sqlReader1("Particular").ToString, Format(CDbl(sqlReader1("Amt")), "#0.00")}
                    dgvVoucherEntry.Rows.Add(NewRow)
                End While
                sqlReader1.Close()

                pnlSearch.Visible = False
                Panel1.Enabled = True
                dgvVoucherEntry.Enabled = True
                txtSearchTransNo.Text = ""
                cmdEdit.Enabled = False

            End If
            If btnSearch.Text = "Delete" Then
                dgvVoucherEntry.Rows.Clear()
                cmd.CommandText = "Select * from Vouchar where VID=" & Val(txtSearchTransNo.Text) & ""
                Dim sqlReader As SqlDataReader = cmd.ExecuteReader
                If sqlReader.Read = True Then
                    dtpSaleDate.Value = CDate(sqlReader("Date").ToString)
                    txtVoucherNo.Text = CInt(sqlReader("VID"))
                Else
                    MessageBox.Show("Data does not exist against this Voutcher no. Plz be sure your input...", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sqlReader.Close()
                    Exit Sub
                End If
                sqlReader.Close()
                cmd.CommandText = "Select * from Vouchar where VID=" & Val(txtSearchTransNo.Text) & ""
                Dim sqlReader1 As SqlDataReader = cmd.ExecuteReader
                While sqlReader1.Read = True

                    Dim NewRow As String() = New String() _
                   {sqlReader1("Serial").ToString, sqlReader1("Particular").ToString, Format(CDbl(sqlReader1("Amt")), "#0.00")}
                    dgvVoucherEntry.Rows.Add(NewRow)
                End While
                sqlReader1.Close()

                pnlSearch.Visible = False
                Panel1.Enabled = True
                dgvVoucherEntry.Enabled = True
                txtSearchTransNo.Text = ""
                cmdEdit.Enabled = True

                If MsgBox("Are you sure to delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Caution") = MsgBoxResult.Yes Then
                    'VID,Serial,Date,Particular,Amt,Vouchar
                    cmd.CommandText = "delete from Vouchar where VID=" & Val(txtVoucherNo.Text)
                    cmd.ExecuteNonQuery()
                    dgvVoucherEntry.Rows.Clear()
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        pnlSearch.Visible = False
        Panel1.Enabled = True
        dgvVoucherEntry.Enabled = True
        txtParticulars.Text = ""
        txtAmount.Enabled = True
    End Sub
End Class