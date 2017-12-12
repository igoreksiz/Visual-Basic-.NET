Public Class frmMain

    Private Sub btnEmery_Click(sender As Object, e As EventArgs) Handles btnEmery.Click
        picMain.Image = My.Resources.Emery
    End Sub

    Private Sub btnLucas_Click(sender As Object, e As EventArgs) Handles btnLucas.Click
        picMain.Image = My.Resources.lucas
    End Sub

    Private Sub btnZoe_Click(sender As Object, e As EventArgs) Handles btnZoe.Click
        picMain.Image = My.Resources.zoe
    End Sub

    Private Sub picMain_Click(sender As Object, e As EventArgs) Handles picMain.Click
        If picMain.Image Is Nothing Then

        Else
            'MessageBox.Show("", "")
            BigPicForm.ShowDialog()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
    End Sub
End Class
