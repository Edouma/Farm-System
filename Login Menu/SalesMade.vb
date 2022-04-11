Imports MySql.Data.MySqlClient
Public Class SalesMade
    Private Sub SalesMade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"
            Dim sql As String = " SELECT * FROM makepurchase"

            Dim da As New MySqlDataAdapter(sql, Conn)
            Dim ds As New DataSet

            da.Fill(ds, "orders")
            DataGridView1.DataSource = ds.Tables("orders")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub
End Class