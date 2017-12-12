Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLondon_Click(sender As Object, e As EventArgs) Handles btnLondon.Click
        picLondon.Visible = True
        picDublin.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnDublin_Click(sender As Object, e As EventArgs) Handles btnDublin.Click
        picDublin.Visible = True
        picLondon.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        btnDublin.Enabled = False
        btnLondon.Enabled = False
        btnSelect.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
