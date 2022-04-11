Imports MySql.Data.MySqlClient
Public Class UpdateQuantity1

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            Dim sql As String = "update products set Quantity = Quantity + '" & txtQuantity.Text & "' where ProductName ='" & cboProductName.Text & "'"


            Dim cmd As New MySqlCommand(sql, Conn)

            Conn.Open()

            cmd.ExecuteNonQuery()
            MsgBox("Quantity Updated")

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub UpdateQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"
            Dim adaptor As New MySqlDataAdapter("select * from products", Conn)

            Conn.Open()

            Dim table As New DataTable()

            adaptor.Fill(table)
            cboProductName.DataSource = table
            cboProductName.DisplayMember = "ProductName"
            cboProductName.ValueMember = "ProductId"


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()

        End Try
    End Sub
End Class