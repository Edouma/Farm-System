Imports MySql.Data.MySqlClient
Public Class CheckStock
    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub CheckStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"
            Dim sql As String = " SELECT *FROM products"

            Dim da As New MySqlDataAdapter(sql, Conn)
            Dim ds As New DataSet

            da.Fill(ds, "products")
            DataGridView1.DataSource = ds.Tables("products")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub
End Class