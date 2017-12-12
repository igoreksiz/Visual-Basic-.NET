<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPizzas = New System.Windows.Forms.TextBox()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkAnchovy = New System.Windows.Forms.CheckBox()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.radDelivery = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSize.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PizzaOrderQuiz.My.Resources.Resources.PizzaLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(542, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 212)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of pizzaz to be ordered: "
        '
        'txtPizzas
        '
        Me.txtPizzas.Location = New System.Drawing.Point(332, 209)
        Me.txtPizzas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPizzas.Name = "txtPizzas"
        Me.txtPizzas.Size = New System.Drawing.Size(70, 21)
        Me.txtPizzas.TabIndex = 2
        '
        'grpSize
        '
        Me.grpSize.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpSize.Controls.Add(Me.radLarge)
        Me.grpSize.Controls.Add(Me.radMedium)
        Me.grpSize.Controls.Add(Me.radSmall)
        Me.grpSize.Location = New System.Drawing.Point(14, 246)
        Me.grpSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSize.Size = New System.Drawing.Size(154, 152)
        Me.grpSize.TabIndex = 3
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Select Pizza Size"
        '
        'grpToppings
        '
        Me.grpToppings.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpToppings.Controls.Add(Me.chkAnchovy)
        Me.grpToppings.Controls.Add(Me.chkPepperoni)
        Me.grpToppings.Controls.Add(Me.chkSausage)
        Me.grpToppings.Location = New System.Drawing.Point(354, 246)
        Me.grpToppings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpToppings.Size = New System.Drawing.Size(172, 152)
        Me.grpToppings.TabIndex = 4
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Select Toppings"
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(8, 50)
        Me.radSmall.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(57, 19)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(8, 76)
        Me.radMedium.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(71, 19)
        Me.radMedium.TabIndex = 1
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(7, 103)
        Me.radLarge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(57, 19)
        Me.radLarge.TabIndex = 2
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Location = New System.Drawing.Point(7, 50)
        Me.chkSausage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(75, 19)
        Me.chkSausage.TabIndex = 0
        Me.chkSausage.Text = "Sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(7, 76)
        Me.chkPepperoni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(83, 19)
        Me.chkPepperoni.TabIndex = 1
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkAnchovy
        '
        Me.chkAnchovy.AutoSize = True
        Me.chkAnchovy.Location = New System.Drawing.Point(7, 103)
        Me.chkAnchovy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAnchovy.Name = "chkAnchovy"
        Me.chkAnchovy.Size = New System.Drawing.Size(70, 19)
        Me.chkAnchovy.TabIndex = 2
        Me.chkAnchovy.Text = "Anchovy"
        Me.chkAnchovy.UseVisualStyleBackColor = True
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Checked = True
        Me.radPickup.Location = New System.Drawing.Point(137, 427)
        Me.radPickup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(67, 19)
        Me.radPickup.TabIndex = 5
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pick Up"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'radDelivery
        '
        Me.radDelivery.AutoSize = True
        Me.radDelivery.Location = New System.Drawing.Point(328, 427)
        Me.radDelivery.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radDelivery.Name = "radDelivery"
        Me.radDelivery.Size = New System.Drawing.Size(68, 19)
        Me.radDelivery.TabIndex = 6
        Me.radDelivery.Text = "Delivery"
        Me.radDelivery.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 463)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Order Price: "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(253, 463)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(2, 17)
        Me.lblTotal.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(69, 508)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 26)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate Price"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(216, 508)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 26)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 508)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 26)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 575)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radDelivery)
        Me.Controls.Add(Me.radPickup)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.txtPizzas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "Mac's Pizza Order"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPizzas As System.Windows.Forms.TextBox
    Friend WithEvents grpSize As System.Windows.Forms.GroupBox
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radSmall As System.Windows.Forms.RadioButton
    Friend WithEvents grpToppings As System.Windows.Forms.GroupBox
    Friend WithEvents chkAnchovy As System.Windows.Forms.CheckBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chkSausage As System.Windows.Forms.CheckBox
    Friend WithEvents radPickup As System.Windows.Forms.RadioButton
    Friend WithEvents radDelivery As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
