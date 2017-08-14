Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            gstrUserId = LCase(txtName.Text)
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn 'SELECT UserInfo,FullName,ShopName,UserName,SetPasswor
            cmd.CommandText = "Select * from UserInfo where UserName='" & Trim(txtName.Text) & "' and SetPassword=" & Val(txtPassword.Text) & ""
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.Read = True Then
                user = reader("UserName").ToString
                 objMDIMain.udpSetMenuAccess(gstrUserId)
                objMDIMain.Show()
                Me.Hide()
            Else
                MsgBox("Invalid Password & User Name. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Logon Failed")
                txtPassword.Focus()
            End If
            reader.Close()
            cmd.CommandText = "select MAX(YearCode)CurrentYear from YearInfo"
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                gCurYearCode = Int(reader("CurrentYear"))
            Else

            End If
            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ' Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Dim img As Image = Image.FromFile(Application.StartupPath & "\complogo.jpg")
            ' Dim img As Image = Image.FromFile(My.Application.Info.DirectoryPath & "\complogo.jpg")
            ' PBoxLogIn.Image = udfImgwithPicBoxSize(img, PBoxLogIn)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'txtName.Text = ""
        'txtPassword.Text = ""
        End
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtPassword.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
