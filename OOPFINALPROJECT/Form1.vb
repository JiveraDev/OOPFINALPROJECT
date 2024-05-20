Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim connection As SqlConnection = New SqlConnection()
            connection.ConnectionString = "Data Source=Promiseland; Initial Catalog=StudentRecord; Integrated Security=True"
            connection.Open()
            Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from StudentRecordtable", connection)
            Dim ds As DataSet = New DataSet()
            adp.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Error Complication on the code!")
        End Try
    End Sub
End Class
