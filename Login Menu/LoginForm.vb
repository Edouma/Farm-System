
Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.ConnectionString = "server=localhost;user id=root;port=3306;pasword=;database=farm"
        PictureBoxLogin.ImageLocation = "../../myImages/LoginProfile.png"
    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged

        If TextBoxPassword.UseSystemPasswordChar Then
            'hide password
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            'show password
            TextBoxPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles BTlogin.Click
        Try
            sql = "SELECT Username, Password From login WHERE username= '" & TextBoxUsername.Text & "' AND password = '" & TextBoxPassword.Text & "' "
            connect()

            If dr.Read Then

                MsgBox("Login Succefully")
                Me.Hide()
                TextBoxUsername.Clear()
                TextBoxPassword.Clear()

                MainForm.Show()

            Else

                MsgBox("Invalid Username or Password")
                TextBoxUsername.Clear()
                TextBoxPassword.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conn.Close()

        End Try

    End Sub

End Class