<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVirtualChangemachine
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.picChangeMachine = New System.Windows.Forms.PictureBox()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picChangeMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(162, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(307, 27)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Virtual Change Machine"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(73, 113)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(191, 20)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Input Amount of Pennies:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(270, 115)
        Me.txtAmount.MaxLength = 5
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(46, 20)
        Me.txtAmount.TabIndex = 2
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(489, 110)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert Pennies"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'picChangeMachine
        '
        Me.picChangeMachine.Image = Global.VirtualChangeMachine.My.Resources.Resources.Change_Machine
        Me.picChangeMachine.Location = New System.Drawing.Point(47, 169)
        Me.picChangeMachine.Name = "picChangeMachine"
        Me.picChangeMachine.Size = New System.Drawing.Size(269, 334)
        Me.picChangeMachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChangeMachine.TabIndex = 4
        Me.picChangeMachine.TabStop = False
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollars.Location = New System.Drawing.Point(357, 169)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(61, 20)
        Me.lblDollars.TabIndex = 5
        Me.lblDollars.Text = "Dollars:"
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(357, 210)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(76, 20)
        Me.lblQuarters.TabIndex = 6
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimes.Location = New System.Drawing.Point(358, 251)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(56, 20)
        Me.lblDimes.TabIndex = 7
        Me.lblDimes.Text = "Dimes:"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickels.Location = New System.Drawing.Point(358, 292)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(64, 20)
        Me.lblNickels.TabIndex = 8
        Me.lblNickels.Text = "Nickels:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennies.Location = New System.Drawing.Point(357, 333)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(69, 20)
        Me.lblPennies.TabIndex = 9
        Me.lblPennies.Text = "Pennies:"
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(361, 479)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(489, 479)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmVirtualChangemachine
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(631, 580)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.picChangeMachine)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmVirtualChangemachine"
        Me.Text = "VCM"
        CType(Me.picChangeMachine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents picChangeMachine As System.Windows.Forms.PictureBox
    Friend WithEvents lblDollars As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
