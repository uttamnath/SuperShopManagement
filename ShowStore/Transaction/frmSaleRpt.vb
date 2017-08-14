Public Class frmSaleRpt
    Dim arryListMenuID As New ArrayList

    Private Sub frmSaleRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            optTotalSale.Checked = True
            Dim strClientList As String = "select CostName from SaleMaster where CostName!=''"
            Dim dsClientList As New DataSet
            PopDataSet(dsClientList, strClientList, gstrConnection)
            If dsClientList.Tables(0).Rows.Count > 0 Then
                For x As Short = 0 To dsClientList.Tables(0).Rows.Count - 1
                    cboCustomer.Items.Add(dsClientList.Tables(0).Rows(x).Item(0))
                Next
            End If
            dsClientList.Dispose()

            Dim strMenuItems As String = "SELECT ProductID,ProductName FROM ProductEntry ORDER BY ProductName"
            Dim dsMenuItems As New DataSet
            PopDataSet(dsMenuItems, strMenuItems, gstrConnection)

            If dsMenuItems.Tables(0).Rows.Count > 0 Then
                For j As Short = 0 To dsMenuItems.Tables(0).Rows.Count - 1
                    cboItemWise.Items.Add(dsMenuItems.Tables(0).Rows(j).Item(1))
                    arryListMenuID.Add(dsMenuItems.Tables(0).Rows(j).Item(0))
                Next
            End If
            dsMenuItems.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            Dim frmViewer As New frmRptViewer
            Dim objSaleReport As CrystalDecisions.CrystalReports.Engine.ReportClass = Nothing
            Dim strDateRange As String = ""
            Dim strDateRange2 As String = ""
            udpCurrentYearValues()
            'objSaleReport = New crptSaleFakeForNRB

            If chkDateRange.Checked = True Then
                If Date.Compare(dtpFrom.Value.Date, dtpTo.Value.Date) > 0 Then
                    MessageBox.Show("From date must be less than To date", "Report...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpFrom.Focus()
                    Exit Sub
                End If
                strDateRange2 = "{Vouchar.Date}>=" & DateForCrpt(dtpFrom.Value.Date) & " AND {Vouchar.Date}<=" & DateForCrpt(dtpTo.Value.Date)
                strDateRange = "{SaleMaster.SaleDate}>=" & DateForCrpt(dtpFrom.Value.Date) & " AND {SaleMaster.SaleDate}<=" & DateForCrpt(dtpTo.Value.Date)
            Else
                strDateRange = "{SaleMaster.SaleDate}>=" & DateForCrpt(gdatStartDate.Date) & " AND {SaleMaster.SaleDate}<=" & DateForCrpt(Today.Date)
                strDateRange2 = "{Vouchar.Date}>=" & DateForCrpt(gdatStartDate.Date) & " AND {Vouchar.Date}<=" & DateForCrpt(Today.Date)
            End If
            If optTotalSale.Checked = True Then
                objSaleReport = New crptTotal
                ' objAllEmployeInfo.DataDefinition.FormulaFields("fTitle").Text = "'All Employee List'"
                objSaleReport.RecordSelectionFormula = strDateRange
            ElseIf optTotalExpense.Checked = True Then
                objSaleReport = New crptdailyexpense
                objSaleReport.RecordSelectionFormula = strDateRange2
            ElseIf optReceiptWise.Checked = True Then
                objSaleReport = New crptTotal
                objSaleReport.RecordSelectionFormula = "{SaleMaster.ReceiptNo}=" & Val(txtReceiptWise.Text)
                'objAllEmployeInfo.DataDefinition.FormulaFields("fTitle").Text = "'All Active Employee List'"
            ElseIf optVoutcherWise.Checked = True Then
                objSaleReport = New crptdailyexpense
                objSaleReport.RecordSelectionFormula = "{Vouchar.VID}=" & Val(txtVoutcherwise.Text)
            ElseIf optItemWise.Checked = True Then
                If cboItemWise.Text = "" Then
                    objSaleReport = New crptItemwiseSale
                Else
                    objSaleReport = New crptItemwiseSale
                    objSaleReport.RecordSelectionFormula = "{SaleDetails.ItemCode}=" & arryListMenuID(cboItemWise.SelectedIndex) & " And " & strDateRange
                End If
                ' objAllEmployeInfo.DataDefinition.FormulaFields("fTitle").Text = "'All Inactive Employee List'"
            ElseIf optCusWiseSale.Checked = True Then
                If cboCustomer.Text = "" Then
                    ' objSaleReport = New crptCustomerWiseSale
                Else
                    ' objSaleReport = New crptCustomerWiseSale
                    objSaleReport.RecordSelectionFormula = "{SaleMaster.CostName}='" & cboCustomer.SelectedText & "' And " & strDateRange
                End If
            End If
            'objSaleReport.DataDefinition.FormulaFields("fCompany").Text = "'" & strCompanyName & "'"
            'objSaleReport.DataDefinition.FormulaFields("fAddress").Text = "'" & strCompanyAddress & "'"
            'objSaleReport.DataDefinition.FormulaFields("fPhone").Text = "'" & strCompanyPhone & "'"
            SetReportLogInfo(objSaleReport)
            frmViewer.CrystalReportViewer3.ReportSource = objSaleReport
            frmViewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkDateRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDateRange.CheckedChanged
        Try
            If chkDateRange.Checked = True Then
                dtpFrom.Visible = True
                dtpTo.Visible = True
                Label1.Visible = True
                Label2.Visible = True
            Else
                dtpFrom.Visible = False
                dtpTo.Visible = False
                Label1.Visible = False
                Label2.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub optReceiptWise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optReceiptWise.CheckedChanged
        Try
            If optReceiptWise.Checked = True Then
                txtReceiptWise.Visible = True
            Else
                txtReceiptWise.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub optItemWise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optItemWise.CheckedChanged
        Try
            If optItemWise.Checked = True Then
                cboItemWise.Visible = True
                cboItemWise.SelectedIndex = -1
                cboItemWise.Focus()
            Else
                cboItemWise.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub optCusWiseSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCusWiseSale.CheckedChanged
        Try
            If optCusWiseSale.Checked = True Then
                cboCustomer.Visible = True
                cboCustomer.SelectedIndex = -1
            Else
                cboCustomer.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub optTotalSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTotalSale.CheckedChanged
        If optTotalSale.Checked = True Then
            txtReceiptWise.Visible = False
            txtVoutcherwise.Visible = False
        End If
    End Sub

    Private Sub optVoutcherWise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVoutcherWise.CheckedChanged
        Try
            If optVoutcherWise.Checked = True Then
                txtVoutcherwise.Visible = True
            Else
                txtVoutcherwise.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class