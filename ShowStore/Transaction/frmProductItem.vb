Imports System.Data.SqlClient
Public Class frmProducItem
    Dim alistMenuCat As New ArrayList
    Dim alistSubCat As New ArrayList
    Dim UpdatableID As Long
    Dim price As Integer = 0
    Private Sub frmMenuItem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtName.Focus()
    End Sub
    Private Sub frmMenuItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            udpMaxMenuID()
            udplvDataPopu()
           
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub udpMaxMenuID()
        Try
            Dim dsMaxMenuID As New Data.DataSet
            Dim strMaxMenuID As String
            strMaxMenuID = "SELECT MAX(ProductID) FROM ProductEntry"
            PopDataSet(dsMaxMenuID, strMaxMenuID, gstrConnection)
            If IIf(IsDBNull(dsMaxMenuID.Tables(0).Rows(0).Item(0)), 0, dsMaxMenuID.Tables(0).Rows(0).Item(0)) > 0 Then
                txtID.Text = dsMaxMenuID.Tables(0).Rows(0).Item(0) + 1
            Else
                txtID.Text = 1005
            End If
           
            dsMaxMenuID.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub udplvDataPopu()
        Try
            lvMenuItem.Items.Clear() '[ProductID,ProductName,Code,Quantity]
            Dim strProductName$ = "SELECT * FROM ProductEntry ORDER BY ProductID"
            Dim dsProductIDCheck As New DataSet
            PopDataSet(dsProductIDCheck, strProductName$, gstrConnection)
            If dsProductIDCheck.Tables(0).Rows.Count > 0 Then
                lvMenuItem.View = View.Details
                For i As Short = 0 To dsProductIDCheck.Tables(0).Rows.Count - 1
                    'Dim strProductDetails$ = "select * from ProductOpening where ProductID=" & dsProductIDCheck.Tables(0).Rows(i).Item("ProductID")
                    'Dim dsProductDetails As New DataSet
                    'PopDataSet(dsProductDetails, strProductDetails$, gstrConnection)
                  
                   'If dsItemName.Tables(0).Rows(0).Item = "" Then
                    '    dsItemName.Tables.Add("Un Name")
                    'End If
                    Dim lvItem As New ListViewItem
                    lvItem.SubItems.Add(dsProductIDCheck.Tables(0).Rows(i).Item("ProductID"))
                    lvItem.SubItems.Add(dsProductIDCheck.Tables(0).Rows(i).Item("ProductName"))
                    lvItem.SubItems.Add(dsProductIDCheck.Tables(0).Rows(i).Item("Quantity"))
                    'lvItem.SubItems.Add(dsProductDetails.Tables(0).Rows(0).Item("QUnit"))
                    'lvItem.SubItems.Add(Format(dsProductDetails.Tables(0).Rows(0).Item("Rate"), "#0.00"))
                    'lvItem.SubItems.Add(dsProductDetails.Tables(0).Rows(0).Item("RUnit"))
                    
                    lvItem.SubItems.Add(dsProductIDCheck.Tables(0).Rows(i).Item("Code"))
                    lvMenuItem.Items.Add(lvItem)
                    
                    'dsProductDetails.Dispose()
                    ' dsItemName.Tables(0).Rows(0).Item("NAME"),
                Next
            End If
            dsProductIDCheck.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try

            If Trim(txtName.Text) = "" Then
                MessageBox.Show("Please enter the name of item.", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtName.Focus()
                Exit Sub
            End If

            If Trim(txtQty.Text) = "" Then
                MessageBox.Show("Please enter the Quantity of item.", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtQty.Focus()
                Exit Sub
            End If
            If Trim(txtPrice.Text) = "" Then
                MessageBox.Show("Please enter the Code.", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrice.Focus()
                Exit Sub
            End If

            ''udpSingleDateYearValues(Today)
            If cmdEdit.Enabled = True Then

                Dim strMenuSave As String '[ProductID,ProductName,Code,Quantity]
                strMenuSave = "INSERT INTO ProductEntry(ProductID,ProductName,Code,Price,Quantity) VALUES(" & _
                               Val(txtID.Text) & ",'" & Trim(MakeApostrphe(txtName.Text)) & _
                                "','" & (lblcode.Text) & "'," & Val(txtPrice.Text) & "," & Val(txtQty.Text) & ")"
                CreateMySqlCommand(strMenuSave, gstrConnection)
                'strMenuSave = "Insert Into ProductOpening(ProductID,OpeningQty,QUnit,Rate,YearCode)VALUES(" & Val(txtID.Text) & _
                '"," & Val(txtQty.Text) & ",'" & cboQUnit.Text & "'," & Val(txtPrice.Text) & "," & intYCode & ")"
                'CreateMySqlCommand(strMenuSave, gstrConnection)

                'price = Val(txtPrice.Text) * Val(cboQUnit.Text)

                'strMenuSave = "update account set Money=Money+" & price & " where AccountName='Product'"
                'CreateMySqlCommand(strMenuSave, gstrConnection)
                'price = 0

            Else '[ProductID,ProductName,Code,Quantity]
                Dim strMenuEdit As String
                strMenuEdit = "UPDATE ProductEntry SET ProductName='" & Trim(MakeApostrphe(txtName.Text)) & _
                              "',Code='" & (lblcode.Text) & "',Price=" & Val(txtPrice.Text) & ", Quantity=" & Val(txtQty.Text) & " WHERE ProductID=" & UpdatableID
                CreateMySqlCommand(strMenuEdit, gstrConnection)
                'strMenuEdit = "UPDATE ProductOpening set OpeningQty=" & Val(txtQty.Text) & ",Qunit='" & cboQUnit.Text & _
                '              "',Rate=" & Val(txtPrice.Text) & " Where ProductID=" & UpdatableID
                'CreateMySqlCommand(strMenuEdit, gstrConnection)
                'strMenuEdit = "update account set Money=Money-" & price & " where AccountName='Product'"
                'CreateMySqlCommand(strMenuEdit, gstrConnection)

                'price = 0
                'strMenuEdit = "update account set Money=Money+" & (Val(txtPrice.Text) * Val(txtQty.Text)) & " where AccountName='Product'"
                'CreateMySqlCommand(strMenuEdit, gstrConnection)
                cmdEdit.Enabled = True
            End If
            udpAfterSaveOrEdit()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub udpAfterSaveOrEdit()
        udplvDataPopu()
        udpMaxMenuID()
        txtQty.Text = ""
        txtName.Text = ""
        txtPrice.Text = ""
        txtName.Focus()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If cmdExit.Text = "&Cancel" Then
            udpAfterSaveOrEdit()
            cmdEdit.Enabled = True
        Else
            Me.Close()
        End If


    End Sub
    Private Sub cboSubCat_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            udpMaxMenuID()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try

            If lvMenuItem.SelectedItems.Count > 0 Then
                Dim lvitem As New ListViewItem
                lvitem = lvMenuItem.SelectedItems(0)

                txtID.Text = lvitem.SubItems(1).Text
                UpdatableID = Val(lvitem.SubItems(1).Text)
                txtName.Text = lvitem.SubItems(2).Text
                txtQty.Text = lvitem.SubItems(3).Text
                txtPrice.Text = lvitem.SubItems(4).Text

                'Dim strItemType$ = "SELECT ITEM_TYPE FROM ProductEntry WHERE ProductID=" & Val(lvitem.SubItems(1).Text)
                'Dim dsItemType As New DataSet
                'PopDataSet(dsItemType, strItemType, gstrConnection)

                'price = Val(lvitem.SubItems(5).Text) * Val(lvitem.SubItems(3).Text)
                'dsItemType.Dispose()

                cmdEdit.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If lvMenuItem.SelectedItems.Count > 0 Then '[ProductID,ProductName,Code,Quantity]
                If MessageBox.Show("Are you sure to delete this selected item?", "Delete Item...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim lvitem As New ListViewItem
                    lvitem = lvMenuItem.SelectedItems(0)
                    Dim strMenuItemDel As String
                    strMenuItemDel = "DELETE FROM ProductEntry WHERE ProductID=" & Val(lvitem.SubItems(1).Text)
                    CreateMySqlCommand(strMenuItemDel, gstrConnection)
                    'strMenuItemDel = "DELETE FROM ProductOpening WHERE ProductID=" & Val(lvitem.SubItems(1).Text)
                    'CreateMySqlCommand(strMenuItemDel, gstrConnection)
                    lvMenuItem.Items.Remove(lvitem)
                    'price = Val(lvitem.SubItems(5).Text) * Val(lvitem.SubItems(3).Text)


                    'strMenuItemDel = "update account set Money=Money-" & price & " where AccountName='Product'"
                    'CreateMySqlCommand(strMenuItemDel, gstrConnection)
                    'price = 0
                    cmdEdit.Enabled = True
                    udpAfterSaveOrEdit()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtQty.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtPrice.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                cmdSave.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit.EnabledChanged
        If cmdEdit.Enabled = True Then
            cmdExit.Text = "&Exit"
        Else
            cmdExit.Text = "&Cancel"
        End If
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        Dim code As String() = {"Z", "D", "T", "X", "R", "P", "K", "S", "E", "B"}
        If txtPrice.Text <> "" Then
            Dim pricecode As String = Val(txtPrice.Text)
            Dim price As String = ""
            For i As Integer = 0 To pricecode.Length - 1
                Dim index As String = pricecode(i)
                price = price & code(index)
                lblcode.Text = price
            Next
        Else
            lblcode.Text = ""
        End If
    End Sub
End Class