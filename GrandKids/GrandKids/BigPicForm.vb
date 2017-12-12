Public Class BigPicForm


    Private Sub picBig_Click(sender As Object, e As EventArgs) Handles picBig.Click
        frmMain.picMain.Image = Nothing
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub BigPicForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.Hide()
        picBig.Image = frmMain.picMain.Image
    End Sub
End Class