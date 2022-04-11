Public Class SalesModule
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MakePurchase.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        CheckStock.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SalesMade.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class