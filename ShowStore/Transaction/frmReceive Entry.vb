Imports System.Data.SqlClient

Public Class frmReceivedEntry
    Dim arryListCategoryID As New ArrayList
    Dim arryListSubCategoryID As New ArrayList
    Dim al As New ArrayList
    Dim intSeltdRowIndex As Integer
    Dim SeltdRow As DataGridViewSelectedRowCollection
    Dim arryListCustomerID As New ArrayList
    Dim maxTranID As Integer, PaidAmount As Integer
    Dim arryListSupplierID As New ArrayList
    Private Sub udpMaxMemoNo()
        Try
            Dim conn As New SqlConnection(gstrConnection)
            Dim sqlquery As String
            Dim cmd As SqlCommand
            Dim dr As SqlDataReader
            Dim a As Integer
            conn.Open()
            sqlquery = "select isnull(max(TransCode),0) maxCode from ProductMaster"
            cmd = New SqlCommand(sqlquery, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                a = dr("maxCode")
            End While
            txtTransID.Text = a + 1
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
   
    Private Sub frmProductionEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
          txtQty.Focus()
        allProductList()
        udpMaxMemoNo()
        SupplierSelect()
    End Sub
    Public Sub SupplierSelect()
        Try
            cboSupplierName.Items.Clear()
            cboSupplierName.Items.Add(" ")
            arryListSupplierID.Add(0)
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "Select Supplier_Name,Id from Supplier_Entry order by Supplier_Name"
            Dim sqlreader As SqlDataReader = cmd.ExecuteReader
            While sqlreader.Read = True
                cboSupplierName.Items.Add(sqlreader("Supplier_Name").ToString)
                arryListSupplierID.Add(sqlreader("ID").ToString)
            End While
            sqlreader.Close()
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub allProductList()
        Try
            al.Clear()
            lstItem.Items.Clear()
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn 'ProductID,ProductName,Code,Quantity,ProductEntry]
            cmd.CommandText = "select * from ProductEntry order by ProductID"
            Dim sqlReader As SqlDataReader = cmd.ExecuteReader
            While sqlReader.Read = True
                lstItem.Items.Add(sqlReader("ProductID").ToString & "-" & sqlReader("ProductName").ToString & "-" & sqlReader("Code").ToString)
                al.Add(CInt(sqlReader("ProductID")))
            End While
            sqlReader.Close()
            conn.Close()
            If lstItem.Items.Count > 0 Then
                lstItem.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If Trim(txtProductName.Text) = "" Then
                MessageBox.Show("There is no item to add in list.", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lstItem.Focus()
                Exit Sub
            End If
            If Val(txtQty.Text) = 0 Or txtQty.Text = "" Then
                MsgBox("Please input Quantity.", MsgBoxStyle.Critical)
                txtQty.Focus()
                Exit Sub
            End If
            If Val(txtRate.Text) < 1 Or txtRate.Text = "" Or Val(txtRate.Text) = 0 Then
                MessageBox.Show("Rate must be greater then zero.", "Valid Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim strItemName As String
            strItemName = txtProductName.Text 'Mid(txtMenuItemName.Text, InStr(1, txtMenuItemName.Text, "-") + 1)
            ' strItemName = txtMenuItemName.Text
            'Dim strItemID As  = Mid(txtMenuItemName.Text, 1, InStr(1, txtMenuItemName.Text, "-") - 1)

            If dgvPurchase.Enabled = True Then
                For i = 0 To dgvPurchase.Rows.Count - 1
                    If txtProductName.Tag = dgvPurchase.Rows(i).Cells(6).Value Then
                        MessageBox.Show("This item is already add in list. Plz make sure  ", "Valide Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
                Dim NewRow As String() = New String() _
                {dgvPurchase.Rows.Count + 1, txtProductName.Text, Val(txtQty.Text), _
               Val(txtRate.Text), Trim(txtCode.Text), Val(txtAmt.Text), txtProductName.Tag}
                dgvPurchase.Rows.Add(NewRow)

                'dgvPurchase.Enabled = True
            Else
                ' arryListDGVItemCode(intSeltdRowIndex) = alItemID
                dgvPurchase.Rows(intSeltdRowIndex).Cells(1).Value = txtProductName.Text
                dgvPurchase.Rows(intSeltdRowIndex).Cells(2).Value = Val(txtQty.Text)
                dgvPurchase.Rows(intSeltdRowIndex).Cells(3).Value = Val(txtRate.Text)
                dgvPurchase.Rows(intSeltdRowIndex).Cells(4).Value = Trim(txtCode.Text)
                dgvPurchase.Rows(intSeltdRowIndex).Cells(5).Value = Val(txtAmt.Text)
                dgvPurchase.Rows(intSeltdRowIndex).Cells(6).Value = Val(txtProductName.Tag)

                dgvPurchase.Enabled = True
            End If

            Dim intTotalAmt As Integer = 0
            For i As Short = 0 To dgvPurchase.Rows.Count - 1
                intTotalAmt = intTotalAmt + Val(dgvPurchase.Rows(i).Cells(5).Value)
            Next
            txtTotalAmt.Text = intTotalAmt
            'lblDueAmt.Text = intTotalAmt - Val(txtPaidAmt.Text)
            'If dgvPurchase.Rows.Count > 0 Then
            '    pnlCashCredit.Enabled = False
            'End If
            txtProductName.Text = ""
            txtAmt.Text = ""
            txtRate.Text = ""
            txtQty.Text = ""
            txtCode.Text = ""
            txtProductName.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            If dgvPurchase.SelectedRows.Count > 0 Then
                SeltdRow = dgvPurchase.SelectedRows
                Dim intSeltdRowIndex As Integer
                intSeltdRowIndex = SeltdRow.Item(0).Index

                dgvPurchase.Rows.RemoveAt(intSeltdRowIndex)

                Dim intTotalAmt As Integer = 0
                For i As Short = 0 To dgvPurchase.Rows.Count - 1
                    dgvPurchase.Rows(i).Cells(0).Value = i + 1
                    intTotalAmt = intTotalAmt + Val(dgvPurchase.Rows(i).Cells(5).Value)
                Next
                txtTotalAmt.Text = intTotalAmt
            Else
                txtTotalAmt.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If dgvPurchase.Rows.Count < 1 Then
                MessageBox.Show("There is no purchase to save.", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If txtDueAmount.Text > 0 And cboSupplierName.Text = "" Then
                MessageBox.Show("Select The Supplier Name.", "Supplier Name Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboSupplierName.Focus()
                Exit Sub
            End If
            'If optCredit.Checked = True And cboSupplierName.Text = "" Then
            '    MessageBox.Show("Select a vendor first.", "Save...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    cboSupplierName.Focus()
            '    Exit Sub
            'End If
            Dim strCashCredit As String = ""
            Dim lngVendorID As Long
            If cboSupplierName.SelectedIndex = -1 Or Trim(cboSupplierName.Text) = "" Then
                lngVendorID = 0
            Else
                lngVendorID = arryListSupplierID(cboSupplierName.SelectedIndex)
            End If
            Dim accountName As String = ""
            'If optCash.Checked = True Then
            '    strCashCredit = 1
            '    accountName = "CashInHand"
            'ElseIf optCredit.Checked = True Then
            '    strCashCredit = 2
            '    accountName = "CashInHand"
            'ElseIf optBank.Checked = True Then
            '    strCashCredit = 3
            '    accountName = "CashInBank"
            'End If
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim trans As SqlTransaction = conn.BeginTransaction
            Try
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.Transaction = trans
                If btnEdit.Enabled = True Then
                    cmd.CommandText = "insert into ProductMaster(TransCode,TransDate,SupplierId,Amount,UserId,PaidAmount,DueAmount)values(" & _
                                            Val(txtTransID.Text) & ",'" & dtpTransDate.Value.Date.ToString("yyyy-MM-dd") & "'," & lngVendorID & _
                                            "," & Val(txtTotalAmt.Text) & ",'" & user & "'," & Val(txtPaidAmount.Text) & "," & Val(txtDueAmount.Text) & ")"
                    cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money-" & Val(txtPaidAmount.Text) & " where AccountName='" & accountName & "'"
                    'cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money+" & Val(txtDueAmount.Text) & " where AccountName='PayAbleDue'"
                    'cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money+" & Val(txtPaidAmount.Text) & " where AccountName='Product'"
                    'cmd.ExecuteNonQuery()

                    cmd.CommandText = "Select Max(transID) maxid from ProductMaster"
                    Dim reader As SqlDataReader = cmd.ExecuteReader

                    If reader.Read = True Then
                        maxTranID = CInt(reader("maxid"))

                    End If
                    reader.Close()
                ElseIf btnEdit.Enabled = False Then
                    cmd.CommandText = "Update ProductMaster set transDate='" & dtpTransDate.Value.Date.ToString("yyyy-MM-dd") & _
                    "',PaidAmount=" & Val(txtPaidAmount.Text) & ",DueAmount=" & Val(txtDueAmount.Text) & ",Amount=" & Val(txtTotalAmt.Text) & _
                    " where TransCode=" & Val(txtTransID.Text) & ""
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "Delete from ProductDetails where TransID=" & maxTranID

                    cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money+" & PaidAmount & " where AccountName='" & accountName & "'"
                    'cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money-" & Val(txtDueAmount.Text) & " where AccountName='PayAbleDue'"
                    'cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money-" & PaidAmount & " where AccountName='Product'"
                    'cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money-" & Val(txtPaidAmount.Text) & " where AccountName='" & accountName & "'"
                    'cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money+" & Val(txtDueAmount.Text) & " where AccountName='PayAbleDue'"
                    'cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money+" & Val(txtPaidAmount.Text) & " where AccountName='Product'"
                    'cmd.ExecuteNonQuery()
                End If

                For i As Short = 0 To dgvPurchase.Rows.Count - 1
                    cmd.CommandText = "INSERT INTO ProductDetails(TransID,SlNo,ItemCode,Qty,Rate,Code,Amount,YearCode)VALUES(" & maxTranID & _
                    "," & dgvPurchase.Rows(i).Cells(0).Value & _
                    "," & dgvPurchase.Rows(i).Cells(6).Value & _
                    "," & dgvPurchase.Rows(i).Cells(2).Value & _
                    ",'" & dgvPurchase.Rows(i).Cells(3).Value & _
                    "','" & dgvPurchase.Rows(i).Cells(4).Value & _
                    "'," & dgvPurchase.Rows(i).Cells(5).Value & "," & gCurYearCode & ")"
                    cmd.ExecuteNonQuery()
                Next
                trans.Commit()
                cboSupplierName.SelectedIndex = 0
                udpAfterSaveOrUpdate()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                trans.Rollback()
            End Try
            btnEdit.Enabled = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub udpAfterSaveOrUpdate()
        Try
            txtTotalAmt.Text = ""
            dgvPurchase.Rows.Clear()
            udpMaxMemoNo()
            txtQty.Focus()
            txtPaidAmount.Text = ""
            txtDueAmount.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            btnSearch.Text = "Delete"
            pnlSearch.Visible = True
            Panel1.Enabled = False
            dgvPurchase.Enabled = False
            pnlCashCredit.Enabled = False
            txtTotalAmt.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
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
                MessageBox.Show("Plz Input any Transgection No in this text box...", "Transgection code Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If btnSearch.Text = "Search" Then
                cmd.CommandText = "Select * from ProductMaster where TransCode=" & Val(txtSearchTransNo.Text) & ""
                Dim sqlReader1 As SqlDataReader = cmd.ExecuteReader
                If sqlReader1.Read = True Then
                    maxTranID = CInt(sqlReader1("TransID"))
                    cboSupplierName.SelectedIndex = sqlReader1("SupplierId").ToString
                    txtTotalAmt.Text = Format(CDbl(sqlReader1("Amount")), "#0.00")
                    txtPaidAmount.Text = Format(CDbl(sqlReader1("PaidAmount")), "#0.00")
                    txtDueAmount.Text = Format(CDbl(sqlReader1("DueAmount")), "#0.00")
                    dtpTransDate.Value = CDate(sqlReader1("TransDate").ToString)
                    txtTransID.Text = CInt(sqlReader1("TransCode"))
                    PaidAmount = Format(CDbl(sqlReader1("PaidAmount")), "#0.00")
                    'If CInt(sqlReader1("PaymentType")) = 1 Then
                    '    optCash.Checked = True
                    '    accountName = "CashInHand"
                    'ElseIf CInt(sqlReader1("PaymentType")) = 2 Then
                    '    optCredit.Checked = True
                    '    accountName = "CashInHand"
                    'ElseIf CInt(sqlReader1("PaymentType")) = 3 Then
                    '    optBank.Checked = True
                    '    accountName = "CashInBank"
                    'End If
                Else
                    MessageBox.Show("Data does not exist against this transgection. Plz be sure your input...", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                sqlReader1.Close()
                cmd.CommandText = "Select TD.*,Rinfo.ProductName from ProductDetails TD,ProductEntry RInfo where TD.ItemCode=RInfo.ProductID and TransId=" & maxTranID
                dgvPurchase.Rows.Clear()
                Dim sqlReader As SqlDataReader = cmd.ExecuteReader
                Dim lvItem As New ListViewItem
                While sqlReader.Read = True
                    Dim NewRow As String() = New String() _
                   {sqlReader("SLNO").ToString, sqlReader("ProductName").ToString, sqlReader("Qty").ToString, _
                   Format(CDbl(sqlReader("Rate")), "#0.00"), sqlReader("Code").ToString, Format(CDbl(sqlReader("Amount")), _
                   "#0.00"), sqlReader("ItemCode").ToString}
                    dgvPurchase.Rows.Add(NewRow)
                End While
                sqlReader.Close()
                pnlSearch.Visible = False
                Panel1.Enabled = True
                dgvPurchase.Enabled = True
                pnlCashCredit.Enabled = True
                txtTotalAmt.Enabled = True
                txtSearchTransNo.Text = ""
                btnEdit.Enabled = False
                Exit Sub
            End If
            If btnSearch.Text = "Delete" Then
                cmd.CommandText = "Select * from ProductMaster where TransCode=" & Val(txtSearchTransNo.Text) & " "
                Dim sqlReader1 As SqlDataReader = cmd.ExecuteReader

                If sqlReader1.Read = True Then
                    maxTranID = CInt(sqlReader1("TransID"))
                    cboSupplierName.SelectedIndex = arryListSupplierID.IndexOf(sqlReader1("SupplierId"))
                    txtTotalAmt.Text = Format(CDbl(sqlReader1("Amount")), "#0.00")
                    txtPaidAmount.Text = Format(CDbl(sqlReader1("PaidAmount")), "#0.00")
                    txtDueAmount.Text = Format(CDbl(sqlReader1("DueAmount")), "#0.00")
                    dtpTransDate.Value = CDate(sqlReader1("TransDate").ToString)



                    'If CInt(sqlReader1("PaymentType")) = 1 Then
                    '    optCash.Checked = True
                    '    accountName = "CashInHand"
                    'ElseIf CInt(sqlReader1("PaymentType")) = 2 Then
                    '    optCredit.Checked = True
                    '    accountName = "CashInHand"
                    'ElseIf CInt(sqlReader1("PaymentType")) = 3 Then
                    '    optBank.Checked = True
                    '    accountName = "CashInBank"
                    'End If


                Else
                    MessageBox.Show("Data does not exist against this transgection. Plz be sure your input...", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                sqlReader1.Close()
                cmd.CommandText = "Select TD.*,Rinfo.ProductName from ProductDetails TD,ProductEntry RInfo where TD.ItemCode=RInfo.ProductID and TransId=" & maxTranID
                dgvPurchase.Rows.Clear()
                Dim sqlReader As SqlDataReader = cmd.ExecuteReader
                Dim lvItem As New ListViewItem
                While sqlReader.Read = True
                    Dim NewRow As String() = New String() _
                  {sqlReader("SLNO").ToString, sqlReader("ProductName").ToString, sqlReader("Qty").ToString, _
                   Format(CDbl(sqlReader("Rate")), "#0.00"), sqlReader("Code").ToString, Format(CDbl(sqlReader("Amount")), _
                   "#0.00"), sqlReader("ItemCode").ToString}
                    dgvPurchase.Rows.Add(NewRow)
                End While
                sqlReader.Close()
                If MsgBox("Are you sure to delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Caution") = MsgBoxResult.Yes Then
                    Dim delete As Integer
                    cmd.CommandText = "select transid from ProductMaster where TransCode=" & Val(txtSearchTransNo.Text) & ""

                    Dim sqlReader2 As SqlDataReader = cmd.ExecuteReader
                    If sqlReader2.Read = True Then
                        delete = CInt(sqlReader2("transid"))
                    End If
                    sqlReader2.Close()
                    cmd.CommandText = "delete from ProductDetails where transid=" & delete
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "delete from ProductMaster where TransCode=" & Val(txtSearchTransNo.Text) & ""
                    cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money-" & Val(txtPaidAmount.Text) & " where AccountName='" & accountName & "'"
                    'cmd.ExecuteNonQuery()

                    'cmd.CommandText = "update account set Money=Money-" & Val(txtDueAmount.Text) & " where AccountName='PayAbleDue'"
                    'cmd.ExecuteNonQuery()

                End If
            End If
            conn.Close()
            pnlSearch.Visible = False
            Panel1.Enabled = True
            dgvPurchase.Enabled = True
            pnlCashCredit.Enabled = True
            txtTotalAmt.Enabled = True
            udpAfterSaveOrUpdate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvPurchase_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPurchase.CellDoubleClick
        Try
            Dim productid As Integer
            intSeltdRowIndex = dgvPurchase.SelectedRows(0).Index
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim transId1 As Integer
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "select transid from ProductMaster where Transcode=" & Val(txtTransID.Text) & ""
            Dim sqlReader As SqlDataReader = cmd.ExecuteReader
            If sqlReader.Read = True Then
                transId1 = sqlReader("TransId").ToString
            End If
            sqlReader.Close()
            cmd.CommandText = "select * from ProductDetails where TransID=" & transId1 & " and SlNo=" & dgvPurchase.Rows(intSeltdRowIndex).Cells(0).Value
            Dim sqlreader1 As SqlDataReader = cmd.ExecuteReader
            If sqlreader1.Read = True Then
                txtQty.Text = sqlreader1("Qty").ToString
                txtRate.Text = sqlreader1("Rate").ToString
                productid = sqlreader1("ItemCode").ToString
                txtCode.Text = sqlreader1("Code").ToString
            End If
            sqlreader1.Close()
            cmd.CommandText = "select ProductName,ProductID from ProductEntry where ProductID=" & productid
            Dim sqlReader2 As SqlDataReader = cmd.ExecuteReader
            If sqlReader2.Read = True Then
                txtProductName.Text = sqlReader2("ProductName").ToString
                txtProductName.Tag = sqlReader2("ProductID").ToString
            End If
            sqlReader2.Close()
            dgvPurchase.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            'SupplierSelect()
            udpMaxMemoNo()
            cboSupplierName.Enabled = False
            txtAmt.Text = ""
            txtProductName.Text = ""
            txtQty.Text = ""
            txtRate.Text = ""
            txtSearchTransNo.Text = ""
            txtTotalAmt.Text = ""
            udpAfterSaveOrUpdate()
            btnEdit.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        pnlSearch.Visible = False
        Panel1.Enabled = True
        dgvPurchase.Enabled = True
        pnlCashCredit.Enabled = True
        txtTotalAmt.Enabled = True
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtRate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                btnAdd.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtSearchTransNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchTransNo.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                btnSearch.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            txtSearchTransNo.Focus()
            pnlSearch.Visible = True
            btnSearch.Text = "Search"
            Panel1.Enabled = False
            dgvPurchase.Enabled = False
            pnlCashCredit.Enabled = False
            txtTotalAmt.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged


        Try
            Dim code As String() = {"Z", "D", "T", "X", "R", "P", "K", "S", "E", "B"}
            If txtRate.Text <> "" Then
                Dim pricecode As String = Val(txtRate.Text)
                Dim price As String = ""
                For i As Integer = 0 To pricecode.Length - 1
                    Dim index As String = pricecode(i)
                    price = price & code(index)
                    txtCode.Text = price
                Next
            Else
                txtCode.Text = ""
            End If
            txtAmt.Text = Val(txtRate.Text) * Val(txtQty.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        Try
            txtAmt.Text = Val(txtRate.Text) * Val(txtQty.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtTotalAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAmt.TextChanged
        txtDueAmount.Text = Val(txtTotalAmt.Text) - Val(txtPaidAmount.Text)
    End Sub

    Private Sub txtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaidAmount.TextChanged
        txtDueAmount.Text = Val(txtTotalAmt.Text) - Val(txtPaidAmount.Text)
    End Sub

    Private Sub txtDueAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDueAmount.TextChanged
        txtDueAmount.Text = Val(txtTotalAmt.Text) - Val(txtPaidAmount.Text)
    End Sub

    Private Sub lstItem_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstItem.MouseDoubleClick
        Try
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn 'select * from ProductEntry
            cmd.CommandText = "select * from ProductEntry where ProductID=" & al(lstItem.SelectedIndex)
            Dim sqlReader As SqlDataReader = cmd.ExecuteReader
            If sqlReader.Read() = True Then
                txtProductName.Text = sqlReader("ProductName").ToString
                txtProductName.Tag = sqlReader("ProductID").ToString
            End If
            txtQty.Focus()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class