Imports MySql.Data.MySqlClient
Public Class AddUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please Fill in the Empty Text Fields")
        Else
            Try
                Dim sql As String = "insert into Login(Username, Password)values('" & txtUsername.Text & "','" & txtPassword.Text & "')"
                Dim cmd = New MySqlCommand(sql, Conn)

                Conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("New User Added")



            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Conn.Close()

            End Try
        End If
    End Sub
End Class