Imports MySql.Data.MySqlClient
Public Class PaymentForm
    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Dim sql As String = "insert into payments(Status, Amount, TransactionDate, Remarks, OrderId, Total, OtherCharges, GrandTotal)values('" & ComboBoxPaymentStatus.Text & "','" & TextBoxPaymentAmount.Text & "','" & DateTimePickerPaymentTransDate.Text & "','" & TextBoxPaymentRemarks.Text & "','" & TextBoxPaymentOrderID.Text & "' ,'" & TextBoxPaymentTotal.Text & "','" & TextBoxPaymentOtherChanges.Text & "','" & TextBoxPaymentGrandTotal.Text & "')"
            Dim cmd = New MySqlCommand(sql, Conn)

            Conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Payment Made")


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub
End Class