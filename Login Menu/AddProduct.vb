Imports MySql.Data.MySqlClient
Public Class AddProduct
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPrice.Text = "" Or txtProductName.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please Fill in the Empty Text Fields")
        Else
            Try
                Dim sql As String = "insert into products(ProductName, Quantity, Unit_Price)values('" & txtProductName.Text & "', '" & txtQuantity.Text & "','" & txtPrice.Text & "')"
                Dim cmd = New MySqlCommand(sql, Conn)

                Conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Product Added")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPrice.Text = ""
        'txtProductId.Clear()
        txtProductName.Clear()

    End Sub
End Class