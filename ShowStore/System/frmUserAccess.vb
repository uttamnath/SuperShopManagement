Imports System.Data.SqlClient

Public Class frmUserAccess

    Private Sub cmdPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPopulate.Click
        If Trim(cboUser.Text) = "" Then
            MessageBox.Show("Please select an user.", "User Required...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboUser.Focus()
            Exit Sub
        End If
        Dim intCounter As Short
        'Dim nodX As TreeNode  ' Declare Node variable.
        'Dim strRootTag, strRootCaption As String
        'Dim strChildTag As String
        'Dim intPosition As Short
        Dim pfrmMain As New MDIMain

        Dim pnodNodes As TreeNode
       TreMenu.Nodes.Clear()

        For intCounter = 0 To pfrmMain.MenuStrip.Items.Count - 1
            'Add Main Menus
            TreMenu.Nodes.Add(pfrmMain.MenuStrip.Items(intCounter).Text)
            pnodNodes = TreMenu.Nodes(intCounter)
            Dim mnuMain As ToolStripMenuItem = CType(pfrmMain.MenuStrip.Items(intCounter), ToolStripMenuItem)
            'Add Sub Menus
            Dim i As Integer
            For i = 0 To mnuMain.DropDownItems.Count - 1 'pfrmMain.Menu.GetMainMenu.MenuItems(intCounter).MenuItems.Count - 1
                If mnuMain.DropDownItems(i).Text <> "" Then
                    pnodNodes.Nodes.Add(mnuMain.DropDownItems(i).Text)
                End If
            Next
        Next
        For i As Short = 0 To pfrmMain.ToolStrip.Items.Count - 1
            If pfrmMain.ToolStrip.Items(i).Text <> "" Then
                TreMenu.Nodes.Add(pfrmMain.ToolStrip.Items(i).Text)
            End If
        Next
        udpCheckAccessMenu(cboUser.Text)
    End Sub

    Private Sub frmUserAccess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStripFind()
    End Sub
    Public Sub MenuStripFind()
        Try
            cboUser.Items.Clear()
            cboUser.Items.Add(" ")
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "select username from UserInfo order by UserName"
            Dim sqlreader As SqlDataReader = cmd.ExecuteReader
            While sqlreader.Read = True
                cboUser.Items.Add(sqlreader("UserName").ToString)
            End While
            sqlreader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try

        Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            Dim pdsUserSec As New Data.DataSet
            Dim pnodMenu As TreeNode, pnodSub As TreeNode
            cmdOk.Enabled = False
            For Each pnodMenu In TreMenu.Nodes
                If pnodMenu.Checked = True Then
                    PopDataSet(pdsUserSec, "select * from UserSec where UserId='" & Trim(cboUser.Text) & "' and MenuName='" & pnodMenu.Text & "' and mainmenu is null", gstrConnection)
                    If pdsUserSec.Tables(0).Rows.Count = 0 Then
                        cmd.CommandText = "insert into UserSec (userid, menuname) values('" & Trim(cboUser.Text) & "','" & Trim(pnodMenu.Text) & "')"
                        cmd.ExecuteNonQuery()
                    End If
                Else
                    cmd.CommandText = "delete from UserSec where UserId='" & Trim(cboUser.Text) & "' and MenuName='" & pnodMenu.Text & "' and mainmenu is null"
                    cmd.ExecuteNonQuery()
                End If
                For Each pnodSub In pnodMenu.Nodes
                    If pnodSub.Checked = True Then
                        PopDataSet(pdsUserSec, "select * from usersec where UserId='" & Trim(cboUser.Text) & "' and MenuName='" & pnodSub.Text & "' and mainmenu ='" & Trim(pnodMenu.Text) & "'", gstrConnection)
                        If pdsUserSec.Tables(0).Rows.Count = 0 Then
                            cmd.CommandText = "insert into usersec (UserId, menuname, mainmenu) values('" & Trim(cboUser.Text) & "','" & Trim(pnodSub.Text) & "','" & Trim(pnodMenu.Text) & "')"
                            cmd.ExecuteNonQuery()
                        End If
                    Else
                        cmd.CommandText = "delete from usersec where UserId='" & Trim(cboUser.Text) & "' and MenuName='" & pnodSub.Text & "' and mainmenu='" & Trim(pnodMenu.Text) & "'"
                        cmd.ExecuteNonQuery()
                    End If

                Next

            Next
            cmdOk.Enabled = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub udpCheckAccessMenu(ByVal pstrUser As String)
        Dim pdsUserSec As New Data.DataSet
        Dim pnodMenu As TreeNode, pnodSub As TreeNode
        For Each pnodMenu In TreMenu.Nodes

            PopDataSet(pdsUserSec, "select * from usersec where UserId='" & Trim(pstrUser) & "' and menuname='" & Trim(pnodMenu.Text) & "'", gstrConnection)
            If pdsUserSec.Tables(0).Rows.Count = 1 Then
                pnodMenu.Checked = True
            Else
                pnodMenu.Checked = False
            End If
            For Each pnodSub In pnodMenu.Nodes
                PopDataSet(pdsUserSec, "select * from usersec where UserId='" & Trim(pstrUser) & "' and mainmenu='" & Trim(pnodMenu.Text) & "' and menuname='" & Trim(pnodSub.Text) & "'", gstrConnection)
                If pdsUserSec.Tables(0).Rows.Count = 1 Then
                    pnodSub.Checked = True
                Else
                    pnodSub.Checked = False
                End If

            Next
        Next
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class