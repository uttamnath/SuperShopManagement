Imports System.Data.SqlClient

Public Class frmDeleteUser

    Private Sub frmDeleteUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DeleteCobo()
    End Sub
    Public Sub DeleteCobo()
        Try
            cboUserID.Items.Clear()
            cboUserID.Items.Add(" ")
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "select username from UserInfo order by UserName"
            Dim sqlreader As SqlDataReader = cmd.ExecuteReader
            While sqlreader.Read = True
                cboUserID.Items.Add(sqlreader("UserName").ToString)
            End While
            sqlreader.Close()
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            If MessageBox.Show("Are you sure to delete the selected user?", "Delete...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "delete  from UserSec where UserId='" & Trim(cboUserID.Text) & "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "delete from UserInfo where UserName='" & Trim(cboUserID.Text) & "'"
                cmd.ExecuteNonQuery()
            End If

            conn.Close()
            DeleteCobo()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboUserID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboUserID.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                btnDelete.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class