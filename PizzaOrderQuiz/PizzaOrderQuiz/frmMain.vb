'Evgeniy Petin
'CSIT-808
'Pizza Order Quiz
'04/22/2015


Public Class frmMain
    Dim NumOfPizzas As Integer

    Const SMALL As Double = 5.0
    Const MEDIUM As Double = 7.5
    Const LARGE As Double = 9.0

    Dim Total As Double

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPizzas.Clear()
        radSmall.Checked = True

        chkAnchovy.Checked = False
        chkPepperoni.Checked = False
        chkSausage.Checked = False

        lblTotal.Text = ""

        txtPizzas.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If IsNumeric(txtPizzas.Text) Then
            NumOfPizzas = Convert.ToInt32(txtPizzas.Text)

            If NumOfPizzas > 0 Then

                If radSmall.Checked = True Then
                    Total = SMALL * NumOfPizzas
                ElseIf radMedium.Checked = True Then
                    Total = MEDIUM * NumOfPizzas
                ElseIf radLarge.Checked = True Then
                    Total = LARGE * NumOfPizzas
                End If

                If chkAnchovy.Checked = True Then
                    Total += 1.5
                End If

                If chkPepperoni.Checked = True Then
                    Total += 1.5
                End If

                If chkSausage.Checked = True Then
                    Total += 1.5
                End If

                If radDelivery.Checked = True Then
                    Total += 2.0
                End If

                If chkAnchovy.Checked = True And chkPepperoni.Checked And chkSausage.Checked Then
                    Total -= NumOfPizzas
                End If

                lblTotal.Text = Total.ToString("c")
                txtPizzas.Focus()
                txtPizzas.SelectAll()

            Else
                MessageBox.Show("Please Enter Positive Value", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'MsgBox("Please Enter Positive Value")
                txtPizzas.Focus()
                txtPizzas.SelectAll()
            End If
        Else
            'MsgBox("Please Enter Numeric Value")
            MessageBox.Show("Please Enter Numeric Value", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPizzas.Focus()
            txtPizzas.SelectAll()
        End If
    End Sub
End Class
