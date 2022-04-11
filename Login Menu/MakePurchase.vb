Imports MySql.Data.MySqlClient
Public Class MakePurchase
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles LabelCropEntriesSellingPrice.Click

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        txtFarmerId.Clear()
        txtProductId.Clear()
        txtPurchaseNo.Clear()
        txtQuantity.Clear()
        txtUnitPrice.Clear()

    End Sub
    Public Sub updataData()
        Try


            Dim sql As String = "update products set Quantity = Quantity - '" & txtQuantity.Text & "' where ProductName ='" & cboProduct.Text & "'"

            Dim cmd As New MySqlCommand(sql, Conn)

            Conn.Open()


            cmd.ExecuteNonQuery()
            MsgBox("Quantity Updated")



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
            GridData1()

        End Try
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        If txtFarmerId.Text = "" Or txtProductId.Text = "" Or txtQuantity.Text = "" Or txtUnitPrice.Text = "" Then
            MessageBox.Show("Please Fill in the Empty Text Fields")
        Else
            Try
                Dim total As Integer
                total = txtUnitPrice.Text * txtQuantity.Text
                txtTotal.Text = total

                Dim sql As String = "insert into makepurchase(Date, Product, unitPrice, productId, Quantity, FarmerId, Total)
                 values('" & DateTimePickerProductOrderDate.Text & "','" & cboProduct.Text & "','" & txtUnitPrice.Text & "','" & txtProductId.Text & "' ,'" & txtQuantity.Text & "', '" & txtFarmerId.Text & "' , '" & txtTotal.Text & "')"
                Dim cmd = New MySqlCommand(sql, Conn)

                Conn.Open()

                cmd.ExecuteNonQuery()
                MsgBox("Sale Made")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Conn.Close()
                GridData()
                GridData1()


            End Try

        End If

    End Sub

    Private Sub MakePurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"
            Dim adaptor As New MySqlDataAdapter("select * from products", Conn)

            Conn.Open()

            Dim table As New DataTable()

            adaptor.Fill(table)
            cboProduct.DataSource = table
            cboProduct.DisplayMember = "ProductName"
            cboProduct.ValueMember = "ProductId"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()

        End Try
        GridData()
        GridData1()
    End Sub

    Public Sub GridData()
        Try
            Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"
            Dim sql As String = " SELECT * FROM Farmers"

            Dim da As New MySqlDataAdapter(sql, Conn)
            Dim ds As New DataSet

            da.Fill(ds, "orders")
            DataGridView2.DataSource = ds.Tables("orders")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Public Sub GridData1()
        Try
            Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"
            Dim sql As String = " SELECT * FROM products"

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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updataData()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub DateTimePickerProductOrderDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerProductOrderDate.ValueChanged
        DateTimePickerProductOrderDate.MinDate = Today()
    End Sub
End Class
