Public Class frmChangeForDollar
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim amount, cents25, cents10, cents5, cents1 As Double 'here we are using Double because the way we're going to calculate it is to use the conversion between Double to Integer to our advantage

        amount = CDbl(txtAmount.Text) 'gives us the amount of cents the user enters

        'calculate the coins we need in descending denominations
        cents25 = Int(amount / 25) 'we only want the Integer portion so it it gives us just the integer instead of rounding up, leaving us the remainder we can use to calculate the rest of the denominations; so .99/25 = 3.96, giving us only 3
        txt25c.Text = cents25
        amount = amount - (25 * cents25)

        cents10 = Int(amount / 10)
        txt10c.Text = cents10
        amount = amount - (10 * cents10)

        cents5 = Int(amount / 5)
        txt5c.Text = cents5
        amount = amount - (5 * cents5)

        cents1 = amount
        txt1c.Text = cents1

    End Sub
End Class
