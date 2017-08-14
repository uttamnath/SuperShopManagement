Imports System.Data.SqlClient
Public Class frmChartofAllAccount
    Private Sub frmChartofAllAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lstHeadList.Items.Clear()
            Dim conn As New SqlConnection(gstrConnection)
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = conn '[AccountName,Money,Account]
            cmd.CommandText = "select * from Account"
            Dim sqlReader As SqlDataReader = cmd.ExecuteReader '

            While sqlReader.Read = True
                lstHeadList.Items.Add(sqlReader("AccountName").ToString & " -- " & Format(CDbl(sqlReader("Money")), "#0.00"))
                 End While
            sqlReader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class