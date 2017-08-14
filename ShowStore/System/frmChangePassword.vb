Public Class frmChangePassword
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Private Sub frmEditPWDeleteUser_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cboUser.Focus()
    End Sub

    Private Sub frmEditDelUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim pdsusername As New Data.DataSet
            Dim strusername As String
            strusername = "select UserName from UserInfo order by UserName"
            PopDataSet(pdsusername, strusername, gstrConnection)
            Dim plngconter As Integer
            cboUser.Items.Clear()
            For plngconter = 0 To pdsusername.Tables(0).Rows.Count - 1
                cboUser.Items.Add(pdsusername.Tables(0).Rows(plngconter).Item("UserName"))
            Next
            'udpReadUsers()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub udpReadUsers()
        Try
            Dim TristateFalse As Object = Nothing

            'Reading users' name from Password File
            Const ForReading As Short = 1
            'Const ForWriting As Short = 2
            'Const ForAppending As Short = 3
            Dim fs, f As Object

            fs = CreateObject("Scripting.FileSystemObject")
            f = fs.OpenTextFile(gstrPasswordFileName, ForReading, TristateFalse)
            Dim strUser As String

            Do While Not f.AtEndOfStream
                strUser = f.readline()
                If Microsoft.VisualBasic.Left(strUser, 1) = "[" Then
                    strUser = Mid(strUser, 2, InStr(strUser, "]") - 2)
                    cboUser.Items.Add(strUser)
                End If
            Loop
            f.Close()
            cboUser.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnxit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxit.Click
        Me.Close()
    End Sub
    Private Function udfPWCheck() As Boolean
        Dim strRemianderPortion As String
        Dim gstrGroup As String
        Dim userID As String
        userID = LCase(cboUser.Text)
        'Dim strEncryptPassword As String
        Dim strDivPortion As String
        'Dim strRemainderPortion As String
        Dim strPassword As String
        strPassword = Space(255)
        If GetPrivateProfileString(LCase(cboUser.Text), "SetPassword", "Ultimate", strPassword, 255, gstrPasswordFileName) > 0 Then
            strPassword = Trim(strPassword)
        End If

        gstrGroup = Space(255)
        If GetPrivateProfileString(LCase(cboUser.Text), "Group", "Admin", gstrGroup, 255, gstrPasswordFileName) > 0 Then
            gstrGroup = Trim(gstrGroup)
        End If

        strDivPortion = Microsoft.VisualBasic.Left(strPassword, InStr(strPassword, ".") - 1)
        strPassword = Microsoft.VisualBasic.Right(strPassword, Len(strPassword) - InStr(strPassword, "."))
        strRemianderPortion = Microsoft.VisualBasic.Left(strPassword, InStr(strPassword, ".") - 1)
        strPassword = Microsoft.VisualBasic.Right(strPassword, Len(strPassword) - InStr(strPassword, "."))
        strPassword = strDecryptPassword(strPassword, Val(strDivPortion))

        If strPassword = txtOldPW.Text Then
            Return True
        Else
            Return False
        End If
    End Function
    Overridable Function strDecryptPassword(ByRef strEncryptPassword As String, ByRef intAddvalue As Short) As String
        Dim i As Short
        strDecryptPassword = ""
        For i = 1 To Len(strEncryptPassword) - 1
            strDecryptPassword = strDecryptPassword + Chr(Asc(Mid(strEncryptPassword, i, 1)) - intAddvalue)
        Next i
    End Function

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim pdspassword As New Data.DataSet
            Dim strpassword As String
            strpassword = "select * from UserInfo where username='" & cboUser.Text & "'"
            PopDataSet(pdspassword, strpassword, gstrConnection)
            If pdspassword.Tables(0).Rows.Count > 0 Then
                If pdspassword.Tables(0).Rows(0).Item("SetPassword") <> txtOldPW.Text Then
                    MsgBox("Old password doesn't match. Please input correct password.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Message")
                    txtOldPW.Focus()
                    Exit Sub
                End If
                If Trim(txtNewPW.Text) = Trim(txtConfirmPW.Text) Then
                    CreateMySqlCommand("update UserInfo set SetPassword='" & Trim(txtNewPW.Text) & "' where username='" & cboUser.Text & "' ", gstrConnection)
                    MsgBox("Password has been changed", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Message")
                    txtConfirmPW.Text = ""
                    txtNewPW.Text = ""
                    txtOldPW.Text = ""
                    'Me.Close()
                    ' frmCompanyList.DefInstance.Show()
                Else
                    MsgBox("Password Confirmation Failed", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End If
            Else
                MsgBox("Select User", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End If
            'If udfPWCheck() = True Then
            '    If Trim(txtConfirmPW.Text) <> Trim(txtNewPW.Text) Then
            '        MessageBox.Show("Confirm password does not match with new password.Please try again.", "RPOS...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '        txtConfirmPW.Text = ""
            '        txtConfirmPW.Focus()
            '        Exit Sub
            '    End If

            '    txtNewPW.Text = strEncryptPassword(cboUser.Text, txtNewPW.Text)
            '    WritePassword(cboUser.Text, txtNewPW.Text)
            'Dim theFile As FileStream = File.Open(gstrPasswordFileName, FileMode.Open, FileAccess.ReadWrite)
            'Dim srd As StreamReader = New StreamReader(theFile)
            'Dim strUsr As String
            'Dim oldpass As String
            'Do While Not srd.EndOfStream
            '    Dim swr As StreamWriter = New StreamWriter(theFile)
            '    strUsr = srd.ReadLine
            '    If strUsr = "[sajib]" Then
            '        srd.ReadLine()
            '        srd.ReadLine()
            '        srd.ReadLine()
            '        oldpass = srd.ReadLine()

            '        swr.WriteLine(oldpass, txtNewPW.Text)



            '    End If
            'Loop
            'Else
            'MessageBox.Show("Old password invalid.Please try again.", "RPOS...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'txtOldPW.Focus()
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub WritePassword(ByVal strName As String, ByVal strPassword As String)
        WritePrivateProfileString(LCase(strName), "Password", strPassword, gstrPasswordFileName)
    End Sub
    Private Function strEncryptPassword(ByVal strName As String, ByVal strPassword As String) As String
        strName = LCase(strName)
        Dim intIncrement As Object
        Dim intNameNumber As Object = Nothing
        Dim intAddvalue As Short
        Dim strDivPortion As Object
        Dim strRemainderPortion As String
        For intIncrement = 1 To Len(strName)

            intNameNumber = intNameNumber + Asc(CStr(InStr(intIncrement, strName, CStr(1))))
        Next intIncrement
        'UPGRADE_WARNING: Couldn't resolve default property of object intNameNumber. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Couldn't resolve default property of object strDivPortion. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
        strDivPortion = Trim(Str((Int(intNameNumber / 255)) + 100))
        'UPGRADE_WARNING: Couldn't resolve default property of object intNameNumber. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
        intAddvalue = Int(intNameNumber / 255) + 100
        'UPGRADE_WARNING: Couldn't resolve default property of object intNameNumber. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Mod has a new behavior. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1041"'
        strRemainderPortion = Trim(Str(intNameNumber Mod 255))

        Dim strpassword1 As String = ""
        For intIncrement = 1 To Len(strPassword)
            'UPGRADE_WARNING: Couldn't resolve default property of object intIncrement. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
            strpassword1 = strpassword1 & strCharacterEncrypt(Mid(strPassword, intIncrement, 1), intAddvalue)
        Next intIncrement
        'UPGRADE_WARNING: Couldn't resolve default property of object strDivPortion. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
        strEncryptPassword = strDivPortion + "." + strRemainderPortion + "." + strpassword1
    End Function
    Private Function strCharacterEncrypt(ByVal strChar As String, ByVal intAddvalue As Short) As String
        strCharacterEncrypt = Chr(CInt(Str(Asc(strChar) + intAddvalue)))
    End Function

    Private Sub cboUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboUser.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtOldPW.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtOldPW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOldPW.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtNewPW.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtNewPW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewPW.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtConfirmPW.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtConfirmPW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmPW.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                btnUpdate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class