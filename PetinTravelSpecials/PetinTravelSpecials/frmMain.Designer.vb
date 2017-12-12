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
        Me.lstSpecials = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picDestination = New System.Windows.Forms.PictureBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lnkWeb = New System.Windows.Forms.LinkLabel()
        CType(Me.picDestination, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstSpecials
        '
        Me.lstSpecials.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpecials.FormattingEnabled = True
        Me.lstSpecials.ItemHeight = 20
        Me.lstSpecials.Items.AddRange(New Object() {"Las Vegas", "Los Angeles", "New York", "Seattle", "Detroit"})
        Me.lstSpecials.Location = New System.Drawing.Point(47, 93)
        Me.lstSpecials.Name = "lstSpecials"
        Me.lstSpecials.Size = New System.Drawing.Size(126, 124)
        Me.lstSpecials.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(137, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(218, 36)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Travel Specials"
        '
        'picDestination
        '
        Me.picDestination.Location = New System.Drawing.Point(243, 93)
        Me.picDestination.Name = "picDestination"
        Me.picDestination.Size = New System.Drawing.Size(203, 124)
        Me.picDestination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDestination.TabIndex = 2
        Me.picDestination.TabStop = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(99, 239)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 26)
        Me.lblPrice.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Book"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(340, 310)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lnkWeb
        '
        Me.lnkWeb.Location = New System.Drawing.Point(47, 277)
        Me.lnkWeb.Name = "lnkWeb"
        Me.lnkWeb.Size = New System.Drawing.Size(287, 76)
        Me.lnkWeb.TabIndex = 6
        Me.lnkWeb.TabStop = True
        Me.lnkWeb.Text = "LinkLabel1"
        Me.lnkWeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 379)
        Me.Controls.Add(Me.lnkWeb)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.picDestination)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstSpecials)
        Me.Name = "frmMain"
        Me.Text = "Travel Specials"
        CType(Me.picDestination, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSpecials As System.Windows.Forms.ListBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picDestination As System.Windows.Forms.PictureBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lnkWeb As System.Windows.Forms.LinkLabel

End Class
