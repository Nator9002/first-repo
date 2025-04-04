Public Class Form1
    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub bttnConfirm_Click(sender As Object, e As EventArgs) Handles bttnConfirm.Click
        Dim saved As Decimal
        Dim tax As Decimal
        Dim annualInt As Decimal
        If Decimal.TryParse(txtAmount.Text, saved) Then
            saved = Math.Round(saved, 2)
            annualInt = saved * (9.5 / 100)
            If annualInt > 0 And annualInt < 1000 Then
                tax = 0
                MessageBox.Show($"You have earned R{annualInt} interest and R{tax} tax due.")
            ElseIf annualInt >= 1000 And annualInt < 1100 Then
                tax = annualInt * (7.5 / 100)
                MessageBox.Show($"You have earned R{annualInt} interest and R{tax} tax due.")
            ElseIf annualInt >= 1100 Then
                tax = annualInt * (9.5 / 100)
                MessageBox.Show($"You have earned R{annualInt} interest and R{tax} tax due.")
            End If
        Else
            MessageBox.Show("Invalid input! Please enter a valid weight in kg.")
        End If
    End Sub
End Class
