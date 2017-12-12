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
        Me.picDandelium = New System.Windows.Forms.PictureBox()
        Me.picDethklok = New System.Windows.Forms.PictureBox()
        Me.picNightwish = New System.Windows.Forms.PictureBox()
        Me.lblDandelium = New System.Windows.Forms.Label()
        Me.lblDethklok = New System.Windows.Forms.Label()
        Me.lblNightwish = New System.Windows.Forms.Label()
        Me.btnSymphonic = New System.Windows.Forms.Button()
        Me.btnDeath = New System.Windows.Forms.Button()
        Me.btnGothic = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblVoted = New System.Windows.Forms.Label()
        CType(Me.picDandelium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDethklok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNightwish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(178, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(176, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "#1 Song Voting"
        '
        'picDandelium
        '
        Me.picDandelium.Image = CType(resources.GetObject("picDandelium.Image"), System.Drawing.Image)
        Me.picDandelium.Location = New System.Drawing.Point(13, 58)
        Me.picDandelium.Name = "picDandelium"
        Me.picDandelium.Size = New System.Drawing.Size(161, 152)
        Me.picDandelium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDandelium.TabIndex = 1
        Me.picDandelium.TabStop = False
        Me.picDandelium.Visible = False
        '
        'picDethklok
        '
        Me.picDethklok.Image = CType(resources.GetObject("picDethklok.Image"), System.Drawing.Image)
        Me.picDethklok.Location = New System.Drawing.Point(186, 58)
        Me.picDethklok.Name = "picDethklok"
        Me.picDethklok.Size = New System.Drawing.Size(161, 152)
        Me.picDethklok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDethklok.TabIndex = 2
        Me.picDethklok.TabStop = False
        Me.picDethklok.Visible = False
        '
        'picNightwish
        '
        Me.picNightwish.Image = CType(resources.GetObject("picNightwish.Image"), System.Drawing.Image)
        Me.picNightwish.Location = New System.Drawing.Point(359, 58)
        Me.picNightwish.Name = "picNightwish"
        Me.picNightwish.Size = New System.Drawing.Size(161, 152)
        Me.picNightwish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNightwish.TabIndex = 3
        Me.picNightwish.TabStop = False
        Me.picNightwish.Visible = False
        '
        'lblDandelium
        '
        Me.lblDandelium.AutoSize = True
        Me.lblDandelium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDandelium.Location = New System.Drawing.Point(26, 213)
        Me.lblDandelium.Name = "lblDandelium"
        Me.lblDandelium.Size = New System.Drawing.Size(134, 20)
        Me.lblDandelium.TabIndex = 4
        Me.lblDandelium.Text = "The Lost Element"
        Me.lblDandelium.Visible = False
        '
        'lblDethklok
        '
        Me.lblDethklok.AutoSize = True
        Me.lblDethklok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDethklok.Location = New System.Drawing.Point(217, 213)
        Me.lblDethklok.Name = "lblDethklok"
        Me.lblDethklok.Size = New System.Drawing.Size(98, 20)
        Me.lblDethklok.TabIndex = 5
        Me.lblDethklok.Text = "Metal Snake"
        Me.lblDethklok.Visible = False
        '
        'lblNightwish
        '
        Me.lblNightwish.AutoSize = True
        Me.lblNightwish.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNightwish.Location = New System.Drawing.Point(414, 213)
        Me.lblNightwish.Name = "lblNightwish"
        Me.lblNightwish.Size = New System.Drawing.Size(51, 20)
        Me.lblNightwish.TabIndex = 6
        Me.lblNightwish.Text = "Nemo"
        Me.lblNightwish.Visible = False
        '
        'btnSymphonic
        '
        Me.btnSymphonic.Location = New System.Drawing.Point(31, 269)
        Me.btnSymphonic.Name = "btnSymphonic"
        Me.btnSymphonic.Size = New System.Drawing.Size(120, 35)
        Me.btnSymphonic.TabIndex = 7
        Me.btnSymphonic.Text = "Symphonic Metal"
        Me.btnSymphonic.UseVisualStyleBackColor = True
        '
        'btnDeath
        '
        Me.btnDeath.Location = New System.Drawing.Point(206, 269)
        Me.btnDeath.Name = "btnDeath"
        Me.btnDeath.Size = New System.Drawing.Size(120, 35)
        Me.btnDeath.TabIndex = 8
        Me.btnDeath.Text = "Death Metal"
        Me.btnDeath.UseVisualStyleBackColor = True
        '
        'btnGothic
        '
        Me.btnGothic.Location = New System.Drawing.Point(381, 269)
        Me.btnGothic.Name = "btnGothic"
        Me.btnGothic.Size = New System.Drawing.Size(120, 35)
        Me.btnGothic.TabIndex = 9
        Me.btnGothic.Text = "Gothic Metal"
        Me.btnGothic.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(183, 349)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(167, 16)
        Me.lblInfo.TabIndex = 10
        Me.lblInfo.Text = "Select your favorite Song"
        '
        'btnVote
        '
        Me.btnVote.Enabled = False
        Me.btnVote.Location = New System.Drawing.Point(164, 405)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(205, 31)
        Me.btnVote.TabIndex = 11
        Me.btnVote.Text = "Vote Now"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(381, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 35)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblVoted
        '
        Me.lblVoted.Location = New System.Drawing.Point(195, 439)
        Me.lblVoted.Name = "lblVoted"
        Me.lblVoted.Size = New System.Drawing.Size(143, 35)
        Me.lblVoted.TabIndex = 13
        Me.lblVoted.Text = "Thank you for Voting!      We appreciate your opinion"
        Me.lblVoted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblVoted.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(532, 528)
        Me.Controls.Add(Me.lblVoted)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnGothic)
        Me.Controls.Add(Me.btnDeath)
        Me.Controls.Add(Me.btnSymphonic)
        Me.Controls.Add(Me.lblNightwish)
        Me.Controls.Add(Me.lblDethklok)
        Me.Controls.Add(Me.lblDandelium)
        Me.Controls.Add(Me.picNightwish)
        Me.Controls.Add(Me.picDethklok)
        Me.Controls.Add(Me.picDandelium)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "Best of Music"
        CType(Me.picDandelium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDethklok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNightwish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picDandelium As System.Windows.Forms.PictureBox
    Friend WithEvents picDethklok As System.Windows.Forms.PictureBox
    Friend WithEvents picNightwish As System.Windows.Forms.PictureBox
    Friend WithEvents lblDandelium As System.Windows.Forms.Label
    Friend WithEvents lblDethklok As System.Windows.Forms.Label
    Friend WithEvents lblNightwish As System.Windows.Forms.Label
    Friend WithEvents btnSymphonic As System.Windows.Forms.Button
    Friend WithEvents btnDeath As System.Windows.Forms.Button
    Friend WithEvents btnGothic As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnVote As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblVoted As System.Windows.Forms.Label

End Class
