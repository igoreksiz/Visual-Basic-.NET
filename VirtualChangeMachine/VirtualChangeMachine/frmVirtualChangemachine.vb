Public Class frmVirtualChangemachine

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        'If String.IsNullOrEmpty(txtAmount.Text) Then

        ' ElseIf Integer.TryParse(txtAmount.Text) Then


        Dim intUserInput As Integer
        Dim LeftOvers As Integer

        intUserInput = Convert.ToInt32(txtAmount.Text)
        LeftOvers = intUserInput Mod 100
        lblDollars.Text = "Dollars: " & (intUserInput - (intUserInput Mod 100)) / 100

        lblQuarters.Text = "Quarters: " & (LeftOvers - (LeftOvers Mod 25)) / 25
        LeftOvers = LeftOvers Mod 25
        ' 
        lblDimes.Text = "Dimes: " & (LeftOvers - (LeftOvers Mod 10)) / 10
        LeftOvers = LeftOvers Mod 10
        '
        lblNickels.Text = "Nickles: " & (LeftOvers - (LeftOvers Mod 5)) / 5
        LeftOvers = LeftOvers Mod 5
        lblPennies.Text = "Pennies: " & LeftOvers
        ' End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Clear()
        lblDollars.Text = "Dollars: "
        lblQuarters.Text = "Quarters: "
        lblDimes.Text = "Dimes: "
        lblNickels.Text = "Nickles: "
        lblPennies.Text = "Pennies: "
        btnClear.Enabled = False
        txtAmount.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If String.IsNullOrEmpty(txtAmount.Text) Then
            btnClear.Enabled = False
            lblDollars.Text = "Dollars: "
            lblQuarters.Text = "Quarters: "
            lblDimes.Text = "Dimes: "
            lblNickels.Text = "Nickles: "
            lblPennies.Text = "Pennies: "
            btnClear.Enabled = False
        Else
            btnClear.Enabled = True
        End If

    End Sub
End Class
