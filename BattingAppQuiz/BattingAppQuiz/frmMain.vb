'Batting Quiz
'Evgeniy Petin
'CSIT-808

Public Class frmMain

    Dim Input As String
    Dim Name As String
    Dim TotalHits, TotalBats, AtBats, AtHits, Average As Decimal
    
    Dim Hits, Bats As Integer
    Const NumOfPlayers As Integer = 9
    Dim IntCounter As Integer = 1

    Dim Valid As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAverage.Text = "0.000"
        btnEnterData.Enabled = True
        TotalHits = 0
        TotalBats = 0
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lstAtBats.Items.Clear()
        lstAverage.Items.Clear()
        lstHits.Items.Clear()
        lstName.Items.Clear()
        lblAverage.Text = "0.000"
        btnEnterData.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnEnterData_Click(sender As Object, e As EventArgs) Handles btnEnterData.Click
        For var As Integer = 0 To 8
            Name = InputBox("Enter Player's Name: ", "Player's Name")

            Do
                Input = InputBox("Enter At Bats: ", "At Bats")
                If IsNumeric(Input) Then
                    If Convert.ToInt32(Input) > 0 Then
                        Valid = True
                        AtBats = Input
                    Else
                        MessageBox.Show("Please Enter Valid Positive Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Please Enter Valid Positive Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Loop While Not Valid

            Valid = False

            Do
                Input = InputBox("Enter Hits: ", "Hits")
                If IsNumeric(Input) Then
                    If Convert.ToInt32(Input) > 0 Then
                        Valid = True
                        Hits = Input
                    Else
                        MessageBox.Show("Please Enter Valid Positive Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Please Enter Valid Positive Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Loop While Not Valid
            Valid = False
            'AtBats = InputBox("Enter At Bats: ", "At Bats")
            ' Hits = InputBox("Enter Hits: ", "Hits")
            lstName.Items.Add(Name)
            lstAtBats.Items.Add(AtBats)
            lstHits.Items.Add(Hits)
            lstAverage.Items.Add((Hits / AtBats).ToString("f3"))
            TotalHits += Hits
            TotalBats += AtBats
            lblAverage.Text = (TotalHits / TotalBats).ToString("f3")
        Next
        btnEnterData.Enabled = False
    End Sub

    
End Class
