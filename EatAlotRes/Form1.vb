Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub bttnExit_Click(sender As Object, e As EventArgs) Handles bttnExit.Click
        Me.Close()
    End Sub

    Private Sub bttnResult_Click(sender As Object, e As EventArgs) Handles bttnResult.Click
        Dim weight As Decimal
        Dim price As Decimal
        If Decimal.TryParse(txtWeight.Text, weight) Then
            weight = (Math.Round(weight, 2) - 1.05)
            Dim wvalue As String = weight.ToString()
            lblResult.Text = weight.ToString() + "kg"
            weight = weight * 1000
            price = Math.Round(7.35 * ((weight) / 100), 2)
            lblName.Text = "Receipt for " + txtName.Text
            lblPrice.Text = "R" + price.ToString()
        Else
            lblResult.Text = "Please enter valid weight value"
        End If
    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtWeight.Clear()
        txtName.Clear()
        lblResult.Text = "0 kg"
        lblPrice.Text = "R 0"
        lblName.Text = ""
    End Sub
End Class
