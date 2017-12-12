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
        Me.picDoritos = New System.Windows.Forms.PictureBox()
        Me.picLays = New System.Windows.Forms.PictureBox()
        Me.picPringles = New System.Windows.Forms.PictureBox()
        Me.picRuffles = New System.Windows.Forms.PictureBox()
        Me.lblDoritos = New System.Windows.Forms.Label()
        Me.lblPringles = New System.Windows.Forms.Label()
        Me.lblRuffles = New System.Windows.Forms.Label()
        Me.lblLays = New System.Windows.Forms.Label()
        Me.btnDoritos = New System.Windows.Forms.Button()
        Me.btnPringles = New System.Windows.Forms.Button()
        Me.btnRuffles = New System.Windows.Forms.Button()
        Me.btnLays = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picDoritos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPringles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRuffles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(161, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "---Airline Snacks---"
        '
        'picDoritos
        '
        Me.picDoritos.Image = CType(resources.GetObject("picDoritos.Image"), System.Drawing.Image)
        Me.picDoritos.Location = New System.Drawing.Point(55, 120)
        Me.picDoritos.Name = "picDoritos"
        Me.picDoritos.Size = New System.Drawing.Size(120, 120)
        Me.picDoritos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDoritos.TabIndex = 1
        Me.picDoritos.TabStop = False
        '
        'picLays
        '
        Me.picLays.Image = CType(resources.GetObject("picLays.Image"), System.Drawing.Image)
        Me.picLays.Location = New System.Drawing.Point(55, 498)
        Me.picLays.Name = "picLays"
        Me.picLays.Size = New System.Drawing.Size(120, 120)
        Me.picLays.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLays.TabIndex = 2
        Me.picLays.TabStop = False
        '
        'picPringles
        '
        Me.picPringles.Image = CType(resources.GetObject("picPringles.Image"), System.Drawing.Image)
        Me.picPringles.Location = New System.Drawing.Point(55, 246)
        Me.picPringles.Name = "picPringles"
        Me.picPringles.Size = New System.Drawing.Size(120, 120)
        Me.picPringles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPringles.TabIndex = 3
        Me.picPringles.TabStop = False
        '
        'picRuffles
        '
        Me.picRuffles.Image = CType(resources.GetObject("picRuffles.Image"), System.Drawing.Image)
        Me.picRuffles.Location = New System.Drawing.Point(55, 372)
        Me.picRuffles.Name = "picRuffles"
        Me.picRuffles.Size = New System.Drawing.Size(120, 120)
        Me.picRuffles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRuffles.TabIndex = 4
        Me.picRuffles.TabStop = False
        '
        'lblDoritos
        '
        Me.lblDoritos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoritos.Location = New System.Drawing.Point(182, 120)
        Me.lblDoritos.Name = "lblDoritos"
        Me.lblDoritos.Size = New System.Drawing.Size(194, 120)
        Me.lblDoritos.TabIndex = 5
        Me.lblDoritos.Text = "Doritos"
        Me.lblDoritos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPringles
        '
        Me.lblPringles.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPringles.Location = New System.Drawing.Point(182, 246)
        Me.lblPringles.Name = "lblPringles"
        Me.lblPringles.Size = New System.Drawing.Size(194, 120)
        Me.lblPringles.TabIndex = 6
        Me.lblPringles.Text = "Pringles"
        Me.lblPringles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRuffles
        '
        Me.lblRuffles.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuffles.Location = New System.Drawing.Point(182, 378)
        Me.lblRuffles.Name = "lblRuffles"
        Me.lblRuffles.Size = New System.Drawing.Size(194, 120)
        Me.lblRuffles.TabIndex = 7
        Me.lblRuffles.Text = "Ruffles"
        Me.lblRuffles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLays
        '
        Me.lblLays.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLays.Location = New System.Drawing.Point(182, 498)
        Me.lblLays.Name = "lblLays"
        Me.lblLays.Size = New System.Drawing.Size(194, 120)
        Me.lblLays.TabIndex = 8
        Me.lblLays.Text = "Lays"
        Me.lblLays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDoritos
        '
        Me.btnDoritos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoritos.Location = New System.Drawing.Point(418, 170)
        Me.btnDoritos.Name = "btnDoritos"
        Me.btnDoritos.Size = New System.Drawing.Size(150, 32)
        Me.btnDoritos.TabIndex = 9
        Me.btnDoritos.Text = "Order"
        Me.btnDoritos.UseVisualStyleBackColor = True
        '
        'btnPringles
        '
        Me.btnPringles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPringles.Location = New System.Drawing.Point(418, 296)
        Me.btnPringles.Name = "btnPringles"
        Me.btnPringles.Size = New System.Drawing.Size(150, 32)
        Me.btnPringles.TabIndex = 10
        Me.btnPringles.Text = "Order"
        Me.btnPringles.UseVisualStyleBackColor = True
        '
        'btnRuffles
        '
        Me.btnRuffles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuffles.Location = New System.Drawing.Point(418, 428)
        Me.btnRuffles.Name = "btnRuffles"
        Me.btnRuffles.Size = New System.Drawing.Size(150, 32)
        Me.btnRuffles.TabIndex = 11
        Me.btnRuffles.Text = "Order"
        Me.btnRuffles.UseVisualStyleBackColor = True
        '
        'btnLays
        '
        Me.btnLays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLays.Location = New System.Drawing.Point(418, 548)
        Me.btnLays.Name = "btnLays"
        Me.btnLays.Size = New System.Drawing.Size(150, 32)
        Me.btnLays.TabIndex = 12
        Me.btnLays.Text = "Order"
        Me.btnLays.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(107, 46)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(408, 17)
        Me.lblInstructions.TabIndex = 13
        Me.lblInstructions.Text = "Order corresponding snack and press ""Place Order"" to confirm "
        '
        'btnConfirm
        '
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(367, 633)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(201, 40)
        Me.btnConfirm.TabIndex = 14
        Me.btnConfirm.Text = "Place Order"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(168, 75)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(287, 17)
        Me.lblConfirmation.TabIndex = 15
        Me.lblConfirmation.Text = "Please wait to be served! You have ordered:"
        Me.lblConfirmation.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(55, 633)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(201, 40)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(622, 685)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnLays)
        Me.Controls.Add(Me.btnRuffles)
        Me.Controls.Add(Me.btnPringles)
        Me.Controls.Add(Me.btnDoritos)
        Me.Controls.Add(Me.lblLays)
        Me.Controls.Add(Me.lblRuffles)
        Me.Controls.Add(Me.lblPringles)
        Me.Controls.Add(Me.lblDoritos)
        Me.Controls.Add(Me.picRuffles)
        Me.Controls.Add(Me.picPringles)
        Me.Controls.Add(Me.picLays)
        Me.Controls.Add(Me.picDoritos)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "Petin Airline Snacks"
        CType(Me.picDoritos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPringles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRuffles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picDoritos As System.Windows.Forms.PictureBox
    Friend WithEvents picLays As System.Windows.Forms.PictureBox
    Friend WithEvents picPringles As System.Windows.Forms.PictureBox
    Friend WithEvents picRuffles As System.Windows.Forms.PictureBox
    Friend WithEvents lblDoritos As System.Windows.Forms.Label
    Friend WithEvents lblPringles As System.Windows.Forms.Label
    Friend WithEvents lblRuffles As System.Windows.Forms.Label
    Friend WithEvents lblLays As System.Windows.Forms.Label
    Friend WithEvents btnDoritos As System.Windows.Forms.Button
    Friend WithEvents btnPringles As System.Windows.Forms.Button
    Friend WithEvents btnRuffles As System.Windows.Forms.Button
    Friend WithEvents btnLays As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
