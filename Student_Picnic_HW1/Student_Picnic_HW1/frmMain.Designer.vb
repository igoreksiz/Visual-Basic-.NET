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
        Me.picPicnic = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAdmission = New System.Windows.Forms.Label()
        Me.btnViewInfo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        CType(Me.picPicnic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPicnic
        '
        Me.picPicnic.Image = CType(resources.GetObject("picPicnic.Image"), System.Drawing.Image)
        Me.picPicnic.Location = New System.Drawing.Point(13, 13)
        Me.picPicnic.Name = "picPicnic"
        Me.picPicnic.Size = New System.Drawing.Size(186, 373)
        Me.picPicnic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPicnic.TabIndex = 0
        Me.picPicnic.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(227, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(172, 59)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Annual Spring Fling Picnic"
        '
        'lblAdmission
        '
        Me.lblAdmission.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmission.Location = New System.Drawing.Point(217, 87)
        Me.lblAdmission.Name = "lblAdmission"
        Me.lblAdmission.Size = New System.Drawing.Size(198, 23)
        Me.lblAdmission.TabIndex = 2
        Me.lblAdmission.Text = "All Students are Welcome"
        '
        'btnViewInfo
        '
        Me.btnViewInfo.BackColor = System.Drawing.Color.YellowGreen
        Me.btnViewInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewInfo.Location = New System.Drawing.Point(232, 136)
        Me.btnViewInfo.Name = "btnViewInfo"
        Me.btnViewInfo.Size = New System.Drawing.Size(152, 34)
        Me.btnViewInfo.TabIndex = 3
        Me.btnViewInfo.Text = "View Picnic Information"
        Me.btnViewInfo.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.YellowGreen
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(232, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(218, 173)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(181, 176)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Text = "April 17, 2015 Located in the Quad in front of the ""Barnard Building"""
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInfo.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(427, 419)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnViewInfo)
        Me.Controls.Add(Me.lblAdmission)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picPicnic)
        Me.Name = "frmMain"
        Me.Text = "Student Picnic"
        CType(Me.picPicnic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picPicnic As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAdmission As System.Windows.Forms.Label
    Friend WithEvents btnViewInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label

End Class
