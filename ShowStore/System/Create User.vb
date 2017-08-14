Imports System.Data.SqlClient

Public Class frmNewUser

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Try
            txtUserName.Text = ""
            txtFullName.Text = ""
            txtPassword.Text = ""
            txtConfirm.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim trans As SqlTransaction = conn.BeginTransaction
            Try 'SELECT UserInfo,FullName,ShopName,UserName,SetPassword
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.Transaction = trans
                If txtPassword.Text = txtConfirm.Text Then
                    cmd.CommandText = "insert into UserInfo(FullName,UserName,SetPassword)values('" & Trim(txtFullName.Text) & "','" & Trim(txtUserName.Text) & "'," & Val(txtPassword.Text) & ")"
                    ' cmd.CommandText = "insert into UserInfo values('" & Trim(txtName.Text) & "','" & Trim(txtFullName.Text) & "','" & Val(txtPassword.Text) & "','" & Trim(cboGroup.Text) & "'"
                Else
                    MessageBox.Show("Your Set Password & Confirm Password Is not same. Please enter same Password in Confirm Password box.", "Save..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'txtName.Text = ""
                    'txtFullName.Text = ""
                    'txtPassword.Text = ""
                    'txtConfirm.Text = ""
                    Exit Sub
                End If
                cmd.ExecuteNonQuery()
                trans.Commit()
                txtUserName.Text = ""
                txtFullName.Text = ""
                txtPassword.Text = ""
                txtConfirm.Text = ""

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFullName.Focus()
    End Sub

    Private Sub txtFullName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFullName.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                txtUserName.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
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
                txtConfirm.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtConfirm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirm.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                cmdSave.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class