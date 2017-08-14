Imports System.Data.SqlClient

Public Class frmSaleEntry
    Dim maxReceptNo As Integer
    Dim maxSaleID As Integer
    Dim SeltdRow As DataGridViewSelectedRowCollection
    Dim blnChangeDisable As Boolean
    Dim intSeltdRowIndex As Integer, intDiscountAmt As Integer = 0, intPrice As Integer = 0, intDue As Integer = 0, accountName As String = ""
    Private Sub frmSaleEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        receiptNo()
        ' dtpSaleDate.Value = DateTime.Now
        If user = "uttam" Then
            btnDelete.Enabled = True
        Else
            btnDelete.Enabled = False
        End If
        cboProductID.Focus()
    End Sub
    Private Sub receiptNo()
        Try
            Dim conn As New SqlConnection(gstrConnection)
            Dim sqlquery As String
            Dim cmd As SqlCommand
            Dim dr As SqlDataReader
            Dim a As Integer
            conn.Open()
            sqlquery = "select isnull(max(ReceiptNo),0) maxid from SaleMaster"

            cmd = New SqlCommand(sqlquery, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                a = dr("maxid")
            End While
            If a = 0 Then
                txtReceptNo.Text = 101
            Else
                txtReceptNo.Text = a + 1
            End If
            maxReceptNo = a
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboProductID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProductID.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
            Else
                If Asc(e.KeyChar) <> 8 Then
                    Dim str As String = cboProductID.Text & e.KeyChar '//string which exist in combobox
                    Dim conn As New SqlConnection(gstrConnection)
                    conn.Open()
                    Dim cmd As New SqlCommand
                    cmd.Connection = conn

                    cmd.CommandText = "Select ProductID from productEntry where ProductID like '" & str & "%' order by ProductID"

                    Dim reader As SqlDataReader = cmd.ExecuteReader
                    cboProductID.Items.Clear()
                    While reader.Read = True
                        cboProductID.Items.Add(reader("ProductID").ToString)
                        'alProductID.Add(CInt(reader("ProductID")))
                    End While
                    cboProductID.DroppedDown = True
                    cboProductID.SelectionStart = Len(cboProductID.Text)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboProductID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProductID.SelectedIndexChanged
        Try
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "select * from ProductEntry where ProductID=" & cboProductID.Text
            Dim sqlReader As SqlDataReader = cmd.ExecuteReader
            Dim opening As Double, quantity As Double, rate As Double
            If sqlReader.Read = True Then
                txtProductName.Text = sqlReader("ProductName").ToString
                cboProductID.Text = sqlReader("ProductID").ToString
                opening = CDbl(sqlReader("Quantity"))
                txtbasepricecode.Text = sqlReader("Code").ToString
            End If
            sqlReader.Close()
            'select sum(Qty)qty, MAX(Rate)rate from ProductDetails where ItemCode= 1005  group by ItemCode
            cmd.CommandText = "select sum(Qty)qty, MAX(Rate)rate from ProductDetails where ItemCode=" & cboProductID.Text & " and YearCode=" & gCurYearCode & " group by ItemCode"
            'Dim opening As Double, openRate As Double
            sqlReader = cmd.ExecuteReader
            If sqlReader.Read = True Then
                quantity = CDbl(sqlReader("qty"))
                rate = CDbl(sqlReader("rate"))
            End If 'Select isnull(sum(qty),0) qty from SaleDetails where ItemCode=1005 and YearCode = 2017 group by ItemCode order by ItemCode
            sqlReader.Close()
            cmd.CommandText = "Select isnull(sum(qty),0) qty from SaleDetails where ItemCode=" & cboProductID.Text & " and YearCode=" & gCurYearCode & " group by ItemCode order by ItemCode"
            sqlReader = cmd.ExecuteReader
            If sqlReader.Read = True Then
                quantity = quantity - CDbl(sqlReader("qty"))
            End If
            sqlReader.Close()
            conn.Close()
            txtQty.Focus()
            
            txtStock.Text = (quantity + opening)
            txtRate.Text = rate
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'If Trim(cboProductName.Text) = "" Then
            '    MessageBox.Show("There is no Product item to add in list.", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    cboProductName.Focus()
            '    Exit Sub
            'End If
            If Val(txtQty.Text) = 0 Or txtQty.Text = "" Then
                MsgBox("Quantity must be greater then zero.", MsgBoxStyle.Critical)
                txtQty.Focus()
                Exit Sub
            End If
            If dgvSaleEntry.Enabled = True Then
                If Val(txtStock.Text) < Val(txtQty.Text) Then
                    MessageBox.Show("Quentity must be less then Stock . Plz make sure  ", "Valide Quentity Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtQty.Text = ""
                    txtQty.Focus()
                    Exit Sub
                End If
            End If
            If Val(txtTk.Text) < 1 Or txtTk.Text = "" Or Val(txtTk.Text) = 0 Then
                MessageBox.Show("Tk must be greater then zero.", "Valid anount Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'Dim strItemName As String
            Dim amount As Integer
            amount = Val(txtQty.Text) * Val(txtTk.Text)
            'strItemName = cboProductName.Text 'Mid(cboProductName.Text, InStr(1, cboProductName.Text, "-") + 1)
            '' strItemName = cboProductName.Text
            ''Dim strItemID As  = Mid(cboProductName.Text, 1, InStr(1, cboProductName.Text, "-") - 1)
            If dgvSaleEntry.Enabled = True Then
                For i = 0 To dgvSaleEntry.Rows.Count - 1
                    If cboProductID.Text = dgvSaleEntry.Rows(i).Cells(7).Value Then
                        MessageBox.Show(cboProductID.Text & " is already add in list. Plz make sure  ", "Valide Product Code Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
                Dim NewRow As String() = New String() _
                {dgvSaleEntry.Rows.Count + 1, txtProductName.Text, Val(txtRate.Text), Val(txtQty.Text), _
                Val(txtTk.Text), txtSaleCode.Text, amount, cboProductID.Text, txtTk.Tag}
                dgvSaleEntry.Rows.Add(NewRow)
                'dgvSaleEntry.Enabled = True
            Else
                ' arryListDGVItemCode(intSeltdRowIndex) = alItemID
                dgvSaleEntry.Rows(intSeltdRowIndex).Cells(1).Value = txtProductName.Text
                dgvSaleEntry.Rows(intSeltdRowIndex).Cells(2).Value = Val(txtRate.Text)
                dgvSaleEntry.Rows(intSeltdRowIndex).Cells(3).Value = Val(txtQty.Text)
                dgvSaleEntry.Rows(intSeltdRowIndex).Cells(4).Value = Val(txtTk.Text)
                dgvSaleEntry.Rows(intSeltdRowIndex).Cells(5).Value = txtSaleCode.Text
                dgvSaleEntry.Rows(intSeltdRowIndex).Cells(6).Value = amount
                dgvSaleEntry.Rows(intSeltdRowIndex).Cells(7).Value = cboProductID.Text
                dgvSaleEntry.Rows(intSeltdRowIndex).Cells(8).Value = txtTk.Tag

                dgvSaleEntry.Enabled = True
            End If

            TotalCalculation()
            'lblDueAmt.Text = intTotalAmt - Val(txtPaidAmt.Te
            'If dgvSaleEntry.Rows.Count > 0 Then
            '    pnlCashCredit.Enabled = False
            'End If
            txtProductName.Text = ""
            txtStock.Text = ""
            txtRate.Text = ""
            txtQty.Text = ""
            txtTk.Text = ""
            txtSaleCode.Text = ""
            txtReceiveAmt.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TotalCalculation()
        Dim intTotalAmt As Integer = 0, intNetAmt As Integer = 0

        For i As Short = 0 To dgvSaleEntry.Rows.Count - 1
            intTotalAmt = intTotalAmt + Val(dgvSaleEntry.Rows(i).Cells(6).Value)
            If intTotalAmt > 0 Then
                dgvSaleEntry.Rows(i).Cells(6).Value = dgvSaleEntry.Rows(i).Cells(4).Value * dgvSaleEntry.Rows(i).Cells(3).Value
            End If
            intNetAmt = intNetAmt + dgvSaleEntry.Rows(i).Cells(6).Value
        Next

        txtGrossAmt.Text = intTotalAmt
        txtNetAmt.Text = intNetAmt - intDiscountAmt
        ' txtDiscount.Text = intDiscountAmt
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            If dgvSaleEntry.SelectedRows.Count > 0 Then
                SeltdRow = dgvSaleEntry.SelectedRows
                Dim intSeltdRowIndex As Integer
                intSeltdRowIndex = SeltdRow.Item(0).Index

                dgvSaleEntry.Rows.RemoveAt(intSeltdRowIndex)
                TotalCalculation()

            Else
                txtGrossAmt.Text = ""
                txtNetAmt.Text = ""
                txtDiscount.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            GroupBox1.Enabled = False
            dgvSaleEntry.Enabled = False
            pnlSearch.Visible = True
            btnSearch.Text = "Search"
            btnAdd.Enabled = False
            btnRemove.Enabled = False
           txtSearchTransNo.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnInvoicePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoicePrint.Click
        Try
            pnlPrint.Visible = True
            txtprint.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            GroupBox1.Enabled = False
            dgvSaleEntry.Enabled = False
            pnlSearch.Visible = True
            btnSearch.Text = "Delete"
            btnAdd.Enabled = False
            btnRemove.Enabled = False
            txtSearchTransNo.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        udpAfterSaveOrUpdate()
    End Sub
    Private Sub udpAfterSaveOrUpdate()
        Try
            dgvSaleEntry.Rows.Clear()
            txtGrossAmt.Text = ""
            txtQty.Text = ""
            txtReceiveAmt.Text = ""
            txtChangeAmt.Text = ""
            txtDiscount.Text = ""
            txtDueAmount.Text = ""
            txtNetAmt.Text = ""
            btnEdit.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            txtQty.Focus()
            btnAdd.Enabled = True
            btnRemove.Enabled = True
            GroupBox1.Enabled = True
            cboProductID.Text = ""
            receiptNo()
            txtAddress.Text = ""
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrintCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCancel.Click
        Try
            If txtprint.Text <> "" Then
                txtprint.Text = ""
            Else
                pnlPrint.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        GroupBox1.Enabled = True
        dgvSaleEntry.Enabled = True
        pnlSearch.Visible = False
        txtSearchTransNo.Text = ""
        btnAdd.Enabled = True
        btnRemove.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Val(txtReceiveAmt.Text) < Val(txtNetAmt.Text) Then
                If txtCustomerName.Text = "" Then
                    MessageBox.Show("Please write a customer name.", "Customer Name Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            If Val(txtDueAmount.Text) < 1 Then
                accountName = "CashInHand"
            Else
                accountName = "ReceiveAbleDue"
            End If
            If dgvSaleEntry.Rows.Count < 1 Then
                MessageBox.Show("There is no Sale to save.", "Data Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim trans As SqlTransaction = conn.BeginTransaction
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.Transaction = trans
            Try 'SaleID,,,,,,,,,,,UserID,EntryTime,SaleMaster
                If btnEdit.Enabled = False Then '
                    cmd.CommandText = "update SaleMaster set SaleDate='" & dtpSaleDate.Value.Date.ToString("yyyy-MM-dd") & "',PaymentType='" & accountName & _
                    "',CostName='" & txtCustomerName.Text & "',Address='" & Trim(txtAddress.Text) & "',GrossAmt=" & Val(txtGrossAmt.Text) & _
                    ",Discount=" & Val(txtDiscount.Text) & ",NetAmt=" & Val(txtNetAmt.Text) & ",ReciveAmt=" & Val(txtReceiveAmt.Text) & _
                    ",DueAmt=" & Val(txtDueAmount.Text) & ",EntryTime='" & dtpSaleDate.Value.ToString("HH:mm tt") & "'where ReceiptNo=" & Val(txtReceptNo.Text) & _
                    " and SaleID=" & maxSaleID
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "Delete from SaleDetails where SaleID=" & maxSaleID
                    cmd.ExecuteNonQuery() 'SLNO,SaleID,Qty,Rate,Amount,ItemCode,YearCode,SaleDetails
                    For i As Short = 0 To dgvSaleEntry.Rows.Count - 1
                        cmd.CommandText = "INSERT INTO SaleDetails(SaleID,SlNo,Rate,Qty,Tk,RateCode,Amount,ItemCode,YearCode,profit)VALUES(" & maxSaleID & _
                        "," & dgvSaleEntry.Rows(i).Cells(0).Value & _
                       "," & dgvSaleEntry.Rows(i).Cells(2).Value & _
                       "," & dgvSaleEntry.Rows(i).Cells(3).Value & _
                       "," & dgvSaleEntry.Rows(i).Cells(4).Value & _
                       ",'" & dgvSaleEntry.Rows(i).Cells(5).Value & _
                        "'," & dgvSaleEntry.Rows(i).Cells(6).Value & _
                         "," & dgvSaleEntry.Rows(i).Cells(7).Value & "," & gCurYearCode & "," & dgvSaleEntry.Rows(i).Cells(8).Value & ")"
                        cmd.ExecuteNonQuery()
                    Next
                    Dim strMenuEdit As String = "update account set Money=Money-" & intPrice & " where AccountName='CashInHand'"
                    CreateMySqlCommand(strMenuEdit, gstrConnection)
                    strMenuEdit = "update account set Money=Money-" & Val(txtDueAmount.Text) & " where AccountName='ReceiveAbleDue'"
                    CreateMySqlCommand(strMenuEdit, gstrConnection)
                    strMenuEdit = "update account set Money=Money+" & intPrice & " where AccountName='Product'"
                    CreateMySqlCommand(strMenuEdit, gstrConnection)

                    intPrice = 0
                    intDue = 0
                    strMenuEdit = "update account set Money=Money+" & Val(txtNetAmt.Text) & " where AccountName='CashInHand'"
                    CreateMySqlCommand(strMenuEdit, gstrConnection)
                    strMenuEdit = "update account set Money=Money+" & Val(txtDueAmount.Text) & " where AccountName='ReceiveAbleDue'"
                    CreateMySqlCommand(strMenuEdit, gstrConnection)
                    strMenuEdit = "update account set Money=Money-" & Val(txtNetAmt.Text) & " where AccountName='Product'"
                    CreateMySqlCommand(strMenuEdit, gstrConnection)
                    'SaleID,ReceiptNo,SaleDate,PaymentType,CostName,Address,GrossAmt,Discount,NetAmt,ReciveAmt,DueAmt,UserID,EntryTime,SaleMaster
                Else 'SaleID,ReceiptNo,SaleDate,PaymentType,CostName,Address,GrossAmt,Discount,NetAmt,ReciveAmt,DueAmt,UserID,EntryTime,SaleMaster
                    cmd.CommandText = "insert into SaleMaster(ReceiptNo,SaleDate,PaymentType,CostName,Address,GrossAmt,Discount,NetAmt,ReciveAmt,DueAmt,UserID,EntryTime)values(" & _
                    txtReceptNo.Text & ",'" & dtpSaleDate.Value.Date.ToString("yyyy-MM-dd") & "','" & accountName & "','" & Trim(txtCustomerName.Text) & "','" & _
                    Trim(txtAddress.Text) & "'," & Val(txtGrossAmt.Text) & "," & Val(txtDiscount.Text) & "," & Val(txtNetAmt.Text) & "," & _
                    Val(txtReceiveAmt.Text) & "," & Val(txtDueAmount.Text) & " ,'" & user & "','" & dtpSaleDate.Value.ToString("HH:mm tt") & "')"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "Select Max(SaleID) maxid from SaleMaster"
                    Dim reader As SqlDataReader = cmd.ExecuteReader
                    If reader.Read = True Then
                        maxSaleID = CInt(reader("maxid"))
                    End If
                    reader.Close() '[SLNO,SaleID,Rate,Qty,Tk,RateCode,Amount,ItemCode,YearCode,SaleDetails]
                    For i As Short = 0 To dgvSaleEntry.Rows.Count - 1
                        cmd.CommandText = "INSERT INTO SaleDetails(SaleID,SlNo,Rate,Qty,Tk,RateCode,Amount,ItemCode,YearCode,profit)VALUES(" & maxSaleID & _
                       "," & dgvSaleEntry.Rows(i).Cells(0).Value & _
                       "," & dgvSaleEntry.Rows(i).Cells(2).Value & _
                       "," & dgvSaleEntry.Rows(i).Cells(3).Value & _
                       "," & dgvSaleEntry.Rows(i).Cells(4).Value & _
                       ",'" & dgvSaleEntry.Rows(i).Cells(5).Value & _
                        "'," & dgvSaleEntry.Rows(i).Cells(6).Value & _
                         "," & dgvSaleEntry.Rows(i).Cells(7).Value & "," & gCurYearCode & "," & dgvSaleEntry.Rows(i).Cells(8).Value & ")"
                        cmd.ExecuteNonQuery()
                    Next
                    cmd.CommandText = "update Account set Money=Money+" & Val(txtNetAmt.Text) & " where AccountName='CashInHand'"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "update Account set Money=Money+" & Val(txtDueAmount.Text) & " where AccountName='ReceiveAbleDue'"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "update account set Money=Money+" & Val(txtNetAmt.Text) & " where AccountName='Product'"
                    cmd.ExecuteNonQuery()
                    ' MsgBox("Are you sure to Save this Sale?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Caution") = MsgBoxResult.Yes Then

                    MessageBox.Show("Save Successfully")
                End If

                trans.Commit()
                conn.Close()

                Try
                    Dim frmViewer As New frmRptViewer
                    Dim objPurchaseReport As CrystalDecisions.CrystalReports.Engine.ReportClass = Nothing
                    Dim strDateRange As String = ""

                    objPurchaseReport = New crptBillPrint
                    objPurchaseReport.RecordSelectionFormula = "{SaleMaster.ReceiptNo}=" & Val(txtReceptNo.Text)

                    SetReportLogInfo(objPurchaseReport)
                    frmViewer.CrystalReportViewer3.ReportSource = objPurchaseReport
                    frmViewer.Show()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                udpAfterSaveOrUpdate()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPrintOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintOK.Click
        Try
            Dim frmViewer As New frmRptViewer
            Dim objPurchaseReport As CrystalDecisions.CrystalReports.Engine.ReportClass = Nothing
            Dim strDateRange As String = ""
           
            objPurchaseReport = New crptBillPrint
            objPurchaseReport.RecordSelectionFormula = "{SaleMaster.ReceiptNo}=" & Val(txtprint.Text)
            
            SetReportLogInfo(objPurchaseReport)
            frmViewer.CrystalReportViewer3.ReportSource = objPurchaseReport
            frmViewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            If txtSearchTransNo.Text = "" Then
                MessageBox.Show("Plz Input any Receipt No in this text box...", "Receipt No Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            blnChangeDisable = True
            ',,,PaymentType,,,,,,,,,EntryTime,SaleMaster
            If btnSearch.Text = "Search" Then
                cmd.CommandText = "Select * from Salemaster where ReceiptNo=" & Val(txtSearchTransNo.Text)
                Dim sqlReader1 As SqlDataReader = cmd.ExecuteReader

                If sqlReader1.Read = True Then
                    maxSaleID = CInt(sqlReader1("SaleID"))
                    dtpSaleDate.Value = sqlReader1("SaleDate").ToString
                    txtGrossAmt.Text = Format(CDbl(sqlReader1("GrossAmt")), "#0.00")
                    txtDiscount.Text = Format(CDbl(sqlReader1("Discount")), "#0.00")
                    txtNetAmt.Text = Format(CDbl(sqlReader1("NetAmt")), "#0.00")
                    intPrice = Val(txtNetAmt.Text)
                    intDue = Format(CDbl(sqlReader1("DueAmt")), "#0.00")
                    If sqlReader1("PaymentType") = "Cash" Then
                        'cboPaymentMethod.SelectedItem = "Cash"
                    Else
                        ' cboPaymentMethod.SelectedItem = "Check"
                    End If
                    'txtCell.Text = sqlReader1("cell").ToString
                    txtAddress.Text = sqlReader1("Address").ToString
                    txtReceiveAmt.Text = Format(CDbl(sqlReader1("ReciveAmt")), "#0.00")
                    txtDueAmount.Text = Format(CDbl(sqlReader1("DueAmt")), "#0.00")
                    txtCustomerName.Text = sqlReader1("CostName").ToString
                    user = sqlReader1("UserID").ToString
                    txtReceptNo.Text = sqlReader1("ReceiptNo").ToString
                    ' txtServiceCharge.Text = Format(CDbl(sqlReader1("servicecharge")), "#0.00")
                    ' GroupBox2.Enabled = False
                Else
                    MessageBox.Show("Data does not exist in to this Receipt No. Plz be sure your input...", "Valid Receipt No. Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If 'SLNO,SaleID,Rate,Qty,Tk,RateCode,Amount,ItemCode,YearCode,profit,SaleDetails]
                sqlReader1.Close()
                cmd.CommandText = "Select SD.*,PEntry.ProductName from Saledetails SD,ProductEntry PEntry where SD.ItemCode=PEntry.ProductID and SD.SaleID=" & maxSaleID
                dgvSaleEntry.Rows.Clear()
                Dim sqlReader As SqlDataReader = cmd.ExecuteReader
                Dim lvItem As New ListViewItem
                While sqlReader.Read = True 'SLNO, SaleID,,,,,,YearCode,, 
                    Dim NewRow As String() = New String() _
                   {dgvSaleEntry.Rows.Count + 1, sqlReader("ProductName").ToString, _
                    Format(CDbl(sqlReader("Rate")), "#0.00"), sqlReader("Qty").ToString, _
                     Format(CDbl(sqlReader("Tk")), "#0.00"), sqlReader("RateCode").ToString, _
                   Format(CDbl(sqlReader("Amount")), "#0.00"), _
                  sqlReader("ItemCode").ToString, Format(CDbl(sqlReader("profit")), "#0.00")}
                    dgvSaleEntry.Rows.Add(NewRow)
                End While

                sqlReader.Close()
                blnChangeDisable = False

                pnlSearch.Visible = False
                GroupBox1.Enabled = False
                ' GroupBox2.Enabled = False
                dgvSaleEntry.Enabled = True
                pnlSearch.Visible = False
                btnEdit.Enabled = False
                GroupBox1.Enabled = True
                dgvSaleEntry.Enabled = True
                pnlSearch.Visible = False
                '  GroupBox2.Enabled = True
                txtSearchTransNo.Text = ""
                btnAdd.Enabled = True
                btnRemove.Enabled = True
                conn.Close()
                Exit Sub
            End If
            If btnSearch.Text = "Delete" Then
                cmd.CommandText = "Select * from Salemaster where ReceiptNo=" & Val(txtSearchTransNo.Text)
                Dim sqlReader1 As SqlDataReader = cmd.ExecuteReader

                If sqlReader1.Read = True Then
                    maxSaleID = CInt(sqlReader1("SaleID"))
                    dtpSaleDate.Value = sqlReader1("SaleDate").ToString
                    txtGrossAmt.Text = Format(CDbl(sqlReader1("GrossAmt")), "#0.00")
                    txtDiscount.Text = Format(CDbl(sqlReader1("Discount")), "#0.00")
                    txtNetAmt.Text = Format(CDbl(sqlReader1("NetAmt")), "#0.00")
                    intPrice = Val(txtNetAmt.Text)
                    intDue = Format(CDbl(sqlReader1("DueAmt")), "#0.00")
                    If sqlReader1("PaymentType") = "Cash" Then
                        'cboPaymentMethod.SelectedItem = "Cash"
                    Else
                        ' cboPaymentMethod.SelectedItem = "Check"
                    End If
                    'txtCell.Text = sqlReader1("cell").ToString
                    txtAddress.Text = sqlReader1("Address").ToString
                    txtReceiveAmt.Text = Format(CDbl(sqlReader1("ReciveAmt")), "#0.00")
                    txtDueAmount.Text = Format(CDbl(sqlReader1("DueAmt")), "#0.00")
                    txtCustomerName.Text = sqlReader1("CostName").ToString
                    user = sqlReader1("UserID").ToString
                    txtReceptNo.Text = sqlReader1("ReceiptNo").ToString
                    ' txtServiceCharge.Text = Format(CDbl(sqlReader1("servicecharge")), "#0.00")
                    ' GroupBox2.Enabled = False
                Else
                    MessageBox.Show("Data does not exist in to this Receipt No. Plz be sure your input...", "Valid Receipt No. Required...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If 'SLNO,SaleID,Rate,Qty,Tk,RateCode,Amount,ItemCode,YearCode,profit,SaleDetails]
                sqlReader1.Close()
                cmd.CommandText = "Select SD.*,PEntry.ProductName from Saledetails SD,ProductEntry PEntry where SD.ItemCode=PEntry.ProductID and SD.SaleID=" & maxSaleID
                dgvSaleEntry.Rows.Clear()
                Dim sqlReader As SqlDataReader = cmd.ExecuteReader
                Dim lvItem As New ListViewItem
                While sqlReader.Read = True 'SLNO, SaleID,,,,,,YearCode,, 
                    Dim NewRow As String() = New String() _
                   {dgvSaleEntry.Rows.Count + 1, sqlReader("ProductName").ToString, _
                    Format(CDbl(sqlReader("Rate")), "#0.00"), sqlReader("Qty").ToString, _
                     Format(CDbl(sqlReader("Tk")), "#0.00"), sqlReader("RateCode").ToString, _
                   Format(CDbl(sqlReader("Amount")), "#0.00"), _
                  sqlReader("ItemCode").ToString, Format(CDbl(sqlReader("profit")), "#0.00")}
                    dgvSaleEntry.Rows.Add(NewRow)
                End While

                sqlReader.Close()
                pnlSearch.Visible = False
                GroupBox1.Enabled = False

                dgvSaleEntry.Enabled = True
                pnlSearch.Visible = False
                btnEdit.Enabled = False
                btnAdd.Enabled = True
                btnRemove.Enabled = True
                If MsgBox("Are you sure to delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Caution") = MsgBoxResult.Yes Then
                    Dim Masterdelete As Integer
                    cmd.CommandText = "select SaleID from SaleMaster where ReceiptNo=" & Val(txtReceptNo.Text)
                    Dim sqlReader2 As SqlDataReader = cmd.ExecuteReader
                    If sqlReader2.Read = True Then
                        Masterdelete = CInt(sqlReader2("SaleID"))
                    End If
                    sqlReader2.Close()
                    cmd.CommandText = "delete from SaleDetails where SaleID=" & Masterdelete
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "delete from SaleMaster where ReceiptNo=" & Val(txtReceptNo.Text)
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "update account set Money=Money-" & Val(txtNetAmt.Text) & " where AccountName='" & accountName & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "update account set Money=Money-" & Val(txtDueAmount.Text) & " where AccountName='ReceiveAbleDue'"
                    cmd.ExecuteNonQuery()
                End If
            End If
            conn.Close()
            pnlSearch.Visible = False
            GroupBox1.Enabled = True
           dgvSaleEntry.Enabled = True
            pnlSearch.Visible = False
            GroupBox1.Enabled = True
            dgvSaleEntry.Enabled = True
            pnlSearch.Visible = False
            txtSearchTransNo.Text = ""
            udpAfterSaveOrUpdate()
            btnEdit.Enabled = True
            txtSearchTransNo.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtTk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTk.TextChanged
        txtTk.Tag = Val(txtTk.Text) - Val(txtRate.Text)
        txtTk.Tag = Val(txtTk.Tag) * Val(txtQty.Text)
        Dim code As String() = {"Z", "D", "T", "X", "R", "P", "K", "S", "E", "B"}
        If txtTk.Text <> "" Then
            Dim pricecode As String = Val(txtTk.Text)
            Dim price As String = ""
            For i As Integer = 0 To pricecode.Length - 1
                Dim index As String = pricecode(i)
                price = price & code(index)
                txtSaleCode.Text = price
            Next
        Else
            txtSaleCode.Text = ""
        End If
    End Sub

    Private Sub txtReceiveAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiveAmt.TextChanged
        If Val(txtReceiveAmt.Text) < Val(txtNetAmt.Text) Then
            txtDueAmount.Text = Val(txtNetAmt.Text) - Val(txtReceiveAmt.Text)
            txtChangeAmt.Text = 0 'Val(txtNetAmt.Text) - Val(txtReceiveAmt.Text)
        Else
            txtDueAmount.Text = 0
            txtChangeAmt.Text = Val(txtNetAmt.Text) - Val(txtReceiveAmt.Text)
        End If
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtTk.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtTk_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTk.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtCustomerName.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCustomerName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerName.KeyPress
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
                btnAdd.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtReceiveAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReceiveAmt.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                btnSave.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdd.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtReceiveAmt.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class