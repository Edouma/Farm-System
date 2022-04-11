Imports MySql.Data.MySqlClient
Public Class CustomerForm
    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"

        GridData()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAddress.Text = "" Or txtContacts.Text = "" Or txtLocation.Text = "" Or txtName.Text = "" Then
            MessageBox.Show("Please Fill in the Empty Text Fields")

        Else
            Try
                Dim sql As String = "insert into customers(Name, Address, Location, Contacts)values('" & txtName.Text & "','" & txtAddress.Text & "','" & txtLocation.Text & "','" & txtContacts.Text & "')"
                Dim cmd = New MySqlCommand(sql, Conn)

                Conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("New Customer Added")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Conn.Close()
                GridData()
            End Try

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            txtId.Text = row.Cells("Id").Value.ToString()
            txtName.Text = row.Cells("Name").Value.ToString()
            txtAddress.Text = row.Cells("Address").Value.ToString()
            txtLocation.Text = row.Cells("Location").Value.ToString()
            txtContacts.Text = row.Cells("Contacts").Value.ToString()
        End If




    End Sub
    Public Sub GridData()
        Try
            Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"
            Dim sql As String = " SELECT Id, Name, Address, Location, Contacts FROM customers"

            Dim da As New MySqlDataAdapter(sql, Conn)
            Dim ds As New DataSet

            da.Fill(ds, "customers")
            DataGridView1.DataSource = ds.Tables("customers")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        txtId.Text = ""
        txtName.Text = ""
        txtLocation.Text = ""
        txtContacts.Text = ""
        txtAddress.Text = ""
    End Sub

    Private Sub ButtonModify_Click(sender As Object, e As EventArgs) Handles ButtonModify.Click
        Try
            Dim sql As String = "update customers set Name ='" & txtName.Text & "', Address='" & txtAddress.Text & "', Location ='" & txtLocation.Text & "', Contacts ='" & txtContacts.Text & "' where Id ='" & txtId.Text & "'"
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

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        If MessageBox.Show("Do you Really wanted to deleted the record?", "Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM customers where Id ='" & txtId.Text & "'"
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

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        If MessageBox.Show("Do you want to close Form?", "Close", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        GridData()
    End Sub
End Class