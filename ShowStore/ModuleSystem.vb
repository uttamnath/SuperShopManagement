Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module ModuleSystem
    'Private Const strDataSource = "VbNet-PC"
    Private Const strDataSource = ""
    Private Const strDataBase = "ShowStore"
    'Private Const strDBUser = "sa"
    'Private Const strDBPass = "123"
    'Data Source=Sajib-PC;Database=AccINv;User ID=sa;Password=123;Asynchronous Processing=true;
    Public Const gstrConnection = "Data Source=" & strDataSource & ";Database=" & strDataBase & ";Integrated Security=True ;" 'Intrigrited Security=True User ID=" & strDBUser & ";Password=" & strDBPass & ";Asynchronous Processing=true;"

    Public objLogin As New frmLogin
    Public objMDIMain As New MDIMain
    Public shopName As String = ""
    Public user As String
    Public userType As String
    Public gstrPasswordFileName As String ' for user change
    Public gstrUserId As String
    Public strCompanyName As String
    Public strCompanyAddress As String
    Public strCompanyPhone As String
    Public strCompanyEmail As String
    Public gintDepth As Integer
    Public gdatStartDate As Date
    Public gdatEndDate As Date
    Public gCurYearCode As Integer = 0
    Public intYCode As Integer
    'Public Const "yyyy-MM-dd" = "yyyy-MMM-dd"
    Public Const gstrDATE_FORMAT As String = "dd/MM/yyyy"
    Public gintCODE_NAME As Short '0 for Code First, 1 for Name First
    'Public Const "yyyy-MM-dd" = "dd-MMM-yyyy"
    Public glngCashAccId As Long = 11001000  'Code of Cash
    Public glngBankAccId As Long = 11002000  'Code of Bank
    Public Sub PopulateCombo(ByRef pcboCombo As ComboBox, ByVal pstrSQL As String)
        Dim pdsDataSet As New Data.DataSet, plngCounter As Long
        PopDataSet(pdsDataSet, pstrSQL, gstrConnection)
        For plngCounter = 0 To pdsDataSet.Tables(0).Rows.Count - 1
            pcboCombo.Items.Add(pdsDataSet.Tables(0).Rows(plngCounter).Item(0))
        Next
    End Sub
    Public Function ReplaceApostrphe(ByVal strString As String) As Object
        Dim i As Short
        ReplaceApostrphe = ""
        For i = 1 To Len(strString)
            If Mid(strString, i, 1) = "'" Then
                ReplaceApostrphe = ReplaceApostrphe & Chr(146)
            Else
                ReplaceApostrphe = ReplaceApostrphe & Mid(strString, i, 1)
            End If
        Next
    End Function
    Public Function MakeApostrphe(ByVal strString As String) As Object
        Dim i As Short
        MakeApostrphe = Nothing
        For i = 1 To Len(strString)
            MakeApostrphe = MakeApostrphe & Mid(strString, i, 1)
            If Mid(strString, i, 1) = "'" Then
                MakeApostrphe = MakeApostrphe & "'"
            End If
        Next
    End Function

    Public Sub PopDataSet(ByRef pobjDS As Data.DataSet, ByVal pstrSQL As String, ByVal pstrConnString As String)
        Dim pobjDATemp As SqlDataAdapter
        Dim pobjDStemp As New Data.DataSet
        pobjDATemp = New SqlDataAdapter(pstrSQL, pstrConnString)
        pobjDATemp.Fill(pobjDStemp)
        pobjDS = pobjDStemp
    End Sub
    Public Sub CreateMySqlCommand(ByVal myExecuteQuery As String, ByVal myConnectionString As String)
        Dim myConnection As New SqlConnection(myConnectionString)
        Dim myCommand As New SqlCommand(myExecuteQuery, myConnection)
        myCommand.Connection.Open()
        myCommand.ExecuteNonQuery()
        myConnection.Close()
    End Sub
    Public Sub SetReportLogInfo(ByRef Report As CrystalDecisions.CrystalReports.Engine.ReportClass)
        'Dim tbCurrent As CrystalDecisions.CrystalReports.Engine.Table
        'Dim tliCurrent As CrystalDecisions.Shared.TableLogOnInfo

        Dim crTableLogOnInfo As TableLogOnInfo

        Dim crConnectionInfo As New ConnectionInfo

        crConnectionInfo.ServerName = strDataSource

        crConnectionInfo.DatabaseName = strDataBase
        'crConnectionInfo.UserID = strDBUser
        'crConnectionInfo.Password = strDBPass

        For Each crTable As Table In Report.Database.Tables
            crTableLogOnInfo = crTable.LogOnInfo
            crTableLogOnInfo.ConnectionInfo = crConnectionInfo
            crTable.ApplyLogOnInfo(crTableLogOnInfo)
        Next

        '' Set the connection information for all the tables used in the report
        '' Leave UserID and Password blank for trusted connection
        'For Each tbCurrent In Report.Database.Tables
        '    tliCurrent = tbCurrent.LogOnInfo
        '    With tliCurrent.ConnectionInfo
        '        .ServerName = ""
        '        .UserID = "sa"
        '        .Password = "123"
        '        .DatabaseName = "AccInventory"
        '    End With
        '    tbCurrent.ApplyLogOnInfo(tliCurrent)
        'Next tbCurrent
    End Sub
    Public Function DateForCrpt(ByRef dtmDate As Date) As String 'Updated for .NET
        Dim intYear, intMonth As Object
        Dim intDay As Short
        intYear = Year(dtmDate)
        intMonth = Month(dtmDate)
        intDay = Microsoft.VisualBasic.Day(dtmDate)
        DateForCrpt = "Date (" & intYear & "," & intMonth & "," & intDay & ")"
    End Function
    Public Sub udpSingleDateYearValues(ByVal dt As Date)
        Dim dsYearInfo As New DataSet

        PopDataSet(dsYearInfo, "select * from yearinfo where '" & Format(dt, "yyyy-MM-dd") & "' between StartDate and EndDate", gstrConnection)

        gdatStartDate = dsYearInfo.Tables(0).Rows(0).Item("StartDate")
        gdatEndDate = dsYearInfo.Tables(0).Rows(0).Item("EndDate")
        intYCode = dsYearInfo.Tables(0).Rows(0).Item("YearCode")
        dsYearInfo.Dispose()
    End Sub
    Public Function udfImgwithPicBoxSize(ByVal img As Image, ByVal picbox As PictureBox) As Image
        Dim imgdest As New Bitmap(img, picbox.Width, picbox.Height)
        Return imgdest
    End Function
    Public Sub udpCurrentYearValues()
        Dim dsYearInfo As New DataSet
        PopDataSet(dsYearInfo, "select max(yearcode) from yearinfo", gstrConnection)
        Dim shtMaxYearcode As Short
        If dsYearInfo.Tables(0).Rows(0).Item(0) > 0 Then
            shtMaxYearcode = dsYearInfo.Tables(0).Rows(0).Item(0)
        End If

        dsYearInfo.Tables.RemoveAt(0)

        PopDataSet(dsYearInfo, "select * from yearinfo where yearcode=" & shtMaxYearcode, gstrConnection)

        gdatStartDate = dsYearInfo.Tables(0).Rows(0).Item("StartDate")
        gdatEndDate = dsYearInfo.Tables(0).Rows(0).Item("EndDate")
        gCurYearCode = shtMaxYearcode
        dsYearInfo.Dispose()
    End Sub

End Module
