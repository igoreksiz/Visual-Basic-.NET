Public Class frmMain

    Private Sub btnSymphonic_Click(sender As Object, e As EventArgs) Handles btnSymphonic.Click
        picDandelium.Visible = True
        lblDandelium.Visible = True

        picDethklok.Visible = False
        lblDethklok.Visible = False

        picNightwish.Visible = False
        lblNightwish.Visible = False

        btnVote.Enabled = True
    End Sub

    Private Sub btnDeath_Click(sender As Object, e As EventArgs) Handles btnDeath.Click
        picDandelium.Visible = False
        lblDandelium.Visible = False

        picDethklok.Visible = True
        lblDethklok.Visible = True

        picNightwish.Visible = False
        lblNightwish.Visible = False

        btnVote.Enabled = True
    End Sub

    Private Sub btnGothic_Click(sender As Object, e As EventArgs) Handles btnGothic.Click
        picDandelium.Visible = False
        lblDandelium.Visible = False

        picDethklok.Visible = False
        lblDethklok.Visible = False

        picNightwish.Visible = True
        lblNightwish.Visible = True

        btnVote.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        btnDeath.Enabled = False
        btnGothic.Enabled = False
        btnSymphonic.Enabled = False
        btnVote.Enabled = False

        lblInfo.Visible = False
        lblVoted.Visible = True
    End Sub
End Class
