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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLondon = New System.Windows.Forms.PictureBox()
        Me.picDublin = New System.Windows.Forms.PictureBox()
        Me.btnLondon = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnDublin = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picLondon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDublin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(82, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(245, 27)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Select a Hostel Location"
        '
        'picLondon
        '
        Me.picLondon.Image = CType(resources.GetObject("picLondon.Image"), System.Drawing.Image)
        Me.picLondon.Location = New System.Drawing.Point(12, 61)
        Me.picLondon.Name = "picLondon"
        Me.picLondon.Size = New System.Drawing.Size(176, 105)
        Me.picLondon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLondon.TabIndex = 1
        Me.picLondon.TabStop = False
        '
        'picDublin
        '
        Me.picDublin.Image = CType(resources.GetObject("picDublin.Image"), System.Drawing.Image)
        Me.picDublin.Location = New System.Drawing.Point(221, 61)
        Me.picDublin.Name = "picDublin"
        Me.picDublin.Size = New System.Drawing.Size(176, 105)
        Me.picDublin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDublin.TabIndex = 2
        Me.picDublin.TabStop = False
        '
        'btnLondon
        '
        Me.btnLondon.Location = New System.Drawing.Point(12, 189)
        Me.btnLondon.Name = "btnLondon"
        Me.btnLondon.Size = New System.Drawing.Size(116, 29)
        Me.btnLondon.TabIndex = 3
        Me.btnLondon.Text = "London Hostel"
        Me.btnLondon.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(147, 189)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(116, 29)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select Location"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnDublin
        '
        Me.btnDublin.Location = New System.Drawing.Point(281, 189)
        Me.btnDublin.Name = "btnDublin"
        Me.btnDublin.Size = New System.Drawing.Size(116, 29)
        Me.btnDublin.TabIndex = 5
        Me.btnDublin.Text = "Dublin Hostel"
        Me.btnDublin.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(92, 256)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(224, 13)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Identify your choice and then select a location"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Location = New System.Drawing.Point(112, 290)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(176, 13)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "You have selected a hostel location"
        Me.lblConfirmation.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(167, 338)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 379)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnDublin)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnLondon)
        Me.Controls.Add(Me.picDublin)
        Me.Controls.Add(Me.picLondon)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "European Hostel"
        CType(Me.picLondon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDublin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLondon As System.Windows.Forms.PictureBox
    Friend WithEvents picDublin As System.Windows.Forms.PictureBox
    Friend WithEvents btnLondon As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnDublin As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
