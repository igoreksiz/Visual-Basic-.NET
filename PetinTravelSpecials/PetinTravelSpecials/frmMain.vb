Imports System.IO

Public Class frmMain
    Dim Prices = New Integer() {199, 219, 320, 519, 728}
    Dim WebS = New String() {"www.TripLas-VegasToday.com",
                             "www.LA.com",
                             "www.NY.com",
                             "www.Seattle.org",
                            "www.DetroitAuto.org"}
    'Prices(5) = 199,219,320,519,728

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSpecials.SelectedIndex = 0
        'For Each String in VarList
        'For i As Integer = 0 To lstSpecials.Items.Count
        ' lstSpecials.Items.Item(i)
        ' Next
    End Sub

    Private Sub lstSpecials_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSpecials.SelectedIndexChanged
        'lstSpecials.SelectedItem
        '//picDestination.Load(
        'MessageBox.Show()

        lblPrice.Text = "Price: $" + Prices(lstSpecials.SelectedIndex).ToString()
        Dim location As String = Directory.GetCurrentDirectory()
        location += "\Cities\" + lstSpecials.SelectedItem + ".jpg"
        'MessageBox.Show(location)
        picDestination.ImageLocation = location
        picDestination.Load()
        lnkWeb.Text = WebS(lstSpecials.SelectedIndex())
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
