Imports MySql.Data.MySqlClient
Public Class FarmerForm
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If txtAddress.Text = "" Or txtName.Text = "" Or txtAddress.Text = "" Or txtContact.Text = "" Then
            MessageBox.Show("Please Fill in the Empty Text Fields")
        Else
            Try
                Dim sql As String = "insert into Farmers(FarmerName, Address, Contact)values('" & txtName.Text & "','" & txtAddress.Text & "','" & txtContact.Text & "')"
                Dim cmd = New MySqlCommand(sql, Conn)

                Conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("New Farmer Added")



            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Conn.Close()
                GridData()
            End Try
        End If


    End Sub

    Private Sub ButtonModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Try
            Dim sql As String = "update Farmers set FarmerName ='" & txtName.Text & "', Address='" & txtAddress.Text & "', Contact ='" & txtContact.Text & "' where FarmerId ='" & txtFarmerId.Text & "'"
            Dim cmd = New MySqlCommand(sql, Conn)

            Conn.Open()

            cmd.ExecuteNonQuery()
            MsgBox("Record Updated")



        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Conn.Close()
            GridData()
        End Try
    End Sub
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridData()
    End Sub

    Public Sub GridData()
        Try
            Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"
            Dim sql As String = " SELECT * FROM Farmers"

            Dim da As New MySqlDataAdapter(sql, Conn)
            Dim ds As New DataSet

            da.Fill(ds, "orders")
            DataGridViewCustomerOrder.DataSource = ds.Tables("orders")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub DataGridViewCustomerOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCustomerOrder.CellContentClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = Me.DataGridViewCustomerOrder.Rows(e.RowIndex)

            txtFarmerId.Text = row.Cells("FarmerId").Value.ToString()
            txtName.Text = row.Cells("FarmerName").Value.ToString()
            txtAddress.Text = row.Cells("Address").Value.ToString()
            txtContact.Text = row.Cells("Contact").Value.ToString()

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtFarmerId.Text = ""
        txtAddress.Text = ""
        txtName.Text = ""
        txtContact.Text = ""

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you Really wanted to deleted the record?", "Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM Farmers where FarmerId ='" & txtFarmerId.Text & "'"
                Dim cmd = New MySqlCommand(sql, Conn)

                Conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Record Deleted")



            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Conn.Close()
                GridData()
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do you want to close Form?", "Close", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        GridData()
    End Sub
End Class