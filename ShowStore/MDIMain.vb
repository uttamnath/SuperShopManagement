Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class MDIMain

    Private Sub CreateUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim objmenu As New frmNewUser
            objmenu.MdiParent = Me
            objmenu.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objmenu As New frmDeleteUser
        objmenu.MdiParent = Me
        objmenu.Show()
    End Sub
    Private Sub CreateUserToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateUserToolStripMenuItem.Click
        Dim objmenu As New frmNewUser
        objmenu.MdiParent = Me
        objmenu.Show()
    End Sub
    Private Sub DeleteUserToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click
        Dim objmenu As New frmDeleteUser
        objmenu.MdiParent = Me
        objmenu.Show()
    End Sub
    Private Sub UserAccessabilityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccessabilityToolStripMenuItem.Click
        Dim objmenu As New frmUserAccess
        objmenu.MdiParent = Me
        objmenu.Show()
    End Sub
    Private Sub DeleteUserToolStripMenuItem_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Disposed
        'End
    End Sub
    Sub udpSetMenuAccess(ByVal pstrUser As String)
        Try
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            Dim blnFirstTSBtnVisible, imediateSeparator1 As Boolean
            Dim dsTStripItems As New DataSet
            For i As Short = 0 To Me.ToolStrip.Items.Count - 1
                Dim TStripMnuText$ = ToolStrip.Items(i).Text
                If TStripMnuText = "" Then
                    If blnFirstTSBtnVisible = True And imediateSeparator1 = False Then
                        ToolStrip.Items(i).Visible = True
                        imediateSeparator1 = True
                    Else
                        ToolStrip.Items(i).Visible = False
                    End If
                Else
                    Dim strSQLTStripMenu$ = "select * from usersec where UserId='" & Trim(pstrUser) & "' and menuname='" & TStripMnuText & "'"
                    PopDataSet(dsTStripItems, strSQLTStripMenu, gstrConnection)
                    If dsTStripItems.Tables(0).Rows.Count > 0 Then
                        ToolStrip.Items(i).Visible = True
                        blnFirstTSBtnVisible = True
                        imediateSeparator1 = False
                    Else
                        ToolStrip.Items(i).Visible = False
                    End If
                End If

            Next
            Dim blnFirstSubItemVisible, imediateSeparator As Boolean
            Dim intCounter, imediateSeparatorIndex As Short, pintCounterSub As Integer
            Dim pdsUserSec As New Data.DataSet
            For intCounter = 0 To Me.MenuStrip.Items.Count - 1 'Me.Menu.GetMainMenu.MenuItems.Count - 1
                Dim mainmnuText$ = MenuStrip.Items(intCounter).Text 'Me.Menu.GetMainMenu.MenuItems(intCounter).Text
                Dim strSQLMainMenu As String = "select * from usersec where UserId='" & Trim(pstrUser) & "' and menuname='" & mainmnuText & "'"
                PopDataSet(pdsUserSec, strSQLMainMenu, gstrConnection)
                If pdsUserSec.Tables(0).Rows.Count = 1 Then
                    'Me.Menu.GetMainMenu.MenuItems(intCounter).Enabled = True
                    MenuStrip.Items(intCounter).Visible = True
                    Dim mnuMain As ToolStripMenuItem = CType(MenuStrip.Items(intCounter), ToolStripMenuItem)
                    Dim intTotalSubmnu As Integer = mnuMain.DropDownItems.Count 'Me.Menu.GetMainMenu.MenuItems(intCounter).MenuItems.Count
                    If intTotalSubmnu > 0 Then
                        For pintCounterSub = 0 To intTotalSubmnu - 1
                            Dim itemtext$ = mnuMain.DropDownItems(pintCounterSub).Text

                            If itemtext = "" Then
                                If blnFirstSubItemVisible = True Then

                                    mnuMain.DropDownItems(pintCounterSub).Visible = True
                                    imediateSeparatorIndex = pintCounterSub
                                    imediateSeparator = True
                                    blnFirstSubItemVisible = False
                                Else
                                    mnuMain.DropDownItems(pintCounterSub).Visible = False
                                End If

                            Else
                                Dim strSQLSubMenu As String = "select * from usersec where UserId='" & Trim(pstrUser) & _
                                                            "' and mainmenu='" & mnuMain.Text & _
                                                            "' and menuname='" & itemtext & "'"

                                PopDataSet(pdsUserSec, strSQLSubMenu, gstrConnection)

                                If pdsUserSec.Tables(0).Rows.Count = 1 Then
                                    'Me.Menu.GetMainMenu.MenuItems(intCounter).MenuItems(pintCounterSub).Enabled = True
                                    mnuMain.DropDownItems(pintCounterSub).Visible = True
                                    blnFirstSubItemVisible = True
                                    'imediateSeparator = False
                                Else
                                    'Me.Menu.GetMainMenu.MenuItems(intCounter).MenuItems(pintCounterSub).Enabled = False
                                    mnuMain.DropDownItems(pintCounterSub).Visible = False
                                End If
                                If pintCounterSub = intTotalSubmnu - 1 And blnFirstSubItemVisible = False And imediateSeparator = True Then
                                    mnuMain.DropDownItems(imediateSeparatorIndex).Visible = False
                                    'imediateSeparatorIndex = 0
                                End If
                            End If

                        Next pintCounterSub
                    End If
                Else
                    'Me.Menu.GetMainMenu.MenuItems(intCounter).Enabled = False
                    MenuStrip.Items(intCounter).Visible = False
                End If

                blnFirstSubItemVisible = False
                imediateSeparator = False
            Next intCounter
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MDIMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    'Private Sub MDIMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    'TextBox1.Text = Panel1.Width & "," & Panel1.Height
    'End Sub

    Private Sub MDIMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If shopName = "Rawshann Computer" Then
        '    strCompanyName = "Rawshann Computer"
        '    strCompanyAddress = "310(3rd Floor), Hazipara,Singapore Market,Access Road,Agrabad,CTG."
        '    strCompanyPhone = "Hello: +8801678770828,+8801813173382"
        '    strCompanyEmail = "Email: rawshanncomputer@gmail.com, facebook/rcctg "
        'ElseIf shopName = "Genuine Computer" Then
        '    strCompanyName = "Genuine Computer"
        '    strCompanyAddress = "305(2rd Floor), Hazipara,Singapore Market,Access Road,Agrabad,CTG."
        '    strCompanyPhone = "Hello: 031-712204, +8801914753115,+8801737396600"
        '    strCompanyEmail = "Email: genuinecomputerctg@gmail.com"
        'Else
        '    MessageBox.Show("New Shop Name Does not allowed", "Talk to software provider..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        strCompanyName = "Sobuj Mama Show Store"
        strCompanyAddress = "Chodhury Hat,Hathazary, Chittagong"
        strCompanyPhone = "Hello: +8801712021093"

        'Dim conn As New SqlConnection(gstrConnection)
        'conn.Open()
        'Dim cmd As New SqlCommand
        'cmd.Connection = conn
        'cmd.CommandText = "select * from YearInfo where status=1"
        'Dim sqlReader As SqlDataReader = cmd.ExecuteReader
        'udpCurrentYearValues()

    End Sub

    Private Sub SupplierEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierEntryToolStripMenuItem.Click
        Try
            Dim objSupplier_Entry As New frmSupplier_Entry
            objSupplier_Entry.MdiParent = Me
            objSupplier_Entry.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ProductEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductEntryToolStripMenuItem1.Click
        Try
            Dim objProducItem As New frmProducItem
            objProducItem.MdiParent = Me
            objProducItem.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Application.Restart()
    End Sub

    Private Sub ProductIngredientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductIngredientsToolStripMenuItem.Click
        Try
            Dim objReceivedEntry As New frmReceivedEntry
            objReceivedEntry.MdiParent = Me
            objReceivedEntry.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ProductMovementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductMovementToolStripMenuItem.Click
        Try
            Dim objSaleEntry As New frmSaleEntry
            objSaleEntry.MdiParent = Me
            objSaleEntry.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ChartOfAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartOfAccountsToolStripMenuItem.Click
        Try
            Dim objChartofAllAccount As New frmChartofAllAccount
            objChartofAllAccount.MdiParent = Me
            objChartofAllAccount.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnmnuSaleEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmnuSaleEntry.Click
        Try
            Dim objSaleEntry As New frmSaleEntry
            objSaleEntry.MdiParent = Me
            objSaleEntry.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnmnuSaleView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmnuSaleView.Click
        Try
            Dim objSaleRpt As New frmSaleRpt
            objSaleRpt.MdiParent = Me
            objSaleRpt.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DailyVoutcherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyVoutcherToolStripMenuItem.Click
        Try
            Dim objDailyExpence As New frmDailyExpence
            objDailyExpence.MdiParent = Me
            objDailyExpence.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
