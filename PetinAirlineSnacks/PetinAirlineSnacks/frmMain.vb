Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDoritos_Click(sender As Object, e As EventArgs) Handles btnDoritos.Click
        btnConfirm.Enabled = True
        lblRuffles.Enabled = False
        lblLays.Enabled = False
        lblPringles.Enabled = False
        lblDoritos.Enabled = True
        lblConfirmation.Text = "Please wait to be served! You have ordered: Doritos"
    End Sub

    Private Sub btnPringles_Click(sender As Object, e As EventArgs) Handles btnPringles.Click
        btnConfirm.Enabled = True
        lblRuffles.Enabled = False
        lblLays.Enabled = False
        lblDoritos.Enabled = False
        lblPringles.Enabled = True
        lblConfirmation.Text = "Please wait to be served! You have ordered: Pringles"
    End Sub

    Private Sub btnRuffles_Click(sender As Object, e As EventArgs) Handles btnRuffles.Click
        btnConfirm.Enabled = True
        lblRuffles.Enabled = True
        lblLays.Enabled = False
        lblDoritos.Enabled = False
        lblPringles.Enabled = False
        lblConfirmation.Text = "Please wait to be served! You have ordered: Ruffles"
    End Sub

    Private Sub btnLays_Click(sender As Object, e As EventArgs) Handles btnLays.Click
        btnConfirm.Enabled = True
        lblRuffles.Enabled = False
        lblLays.Enabled = True
        lblDoritos.Enabled = False
        lblPringles.Enabled = False
        lblConfirmation.Text = "Please wait to be served! You have ordered: Lays"
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnConfirm.Enabled = False
        btnDoritos.Enabled = False
        btnLays.Enabled = False
        btnPringles.Enabled = False
        btnRuffles.Enabled = False
    End Sub
End Class
