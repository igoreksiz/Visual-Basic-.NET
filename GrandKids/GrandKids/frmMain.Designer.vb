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
        Me.btnEmery = New System.Windows.Forms.Button()
        Me.btnLucas = New System.Windows.Forms.Button()
        Me.btnZoe = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picMain = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmery
        '
        Me.btnEmery.Location = New System.Drawing.Point(13, 217)
        Me.btnEmery.Name = "btnEmery"
        Me.btnEmery.Size = New System.Drawing.Size(75, 23)
        Me.btnEmery.TabIndex = 1
        Me.btnEmery.Text = "Emery"
        Me.btnEmery.UseVisualStyleBackColor = True
        '
        'btnLucas
        '
        Me.btnLucas.Location = New System.Drawing.Point(103, 217)
        Me.btnLucas.Name = "btnLucas"
        Me.btnLucas.Size = New System.Drawing.Size(75, 23)
        Me.btnLucas.TabIndex = 2
        Me.btnLucas.Text = "Lucas"
        Me.btnLucas.UseVisualStyleBackColor = True
        '
        'btnZoe
        '
        Me.btnZoe.Location = New System.Drawing.Point(193, 217)
        Me.btnZoe.Name = "btnZoe"
        Me.btnZoe.Size = New System.Drawing.Size(75, 23)
        Me.btnZoe.TabIndex = 3
        Me.btnZoe.Text = "Zoe"
        Me.btnZoe.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GrandKids.My.Resources.Resources.zoe
        Me.PictureBox3.Location = New System.Drawing.Point(193, 246)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 90)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GrandKids.My.Resources.Resources.lucas
        Me.PictureBox2.Location = New System.Drawing.Point(103, 246)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GrandKids.My.Resources.Resources.Emery
        Me.PictureBox1.Location = New System.Drawing.Point(15, 246)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'picMain
        '
        Me.picMain.Location = New System.Drawing.Point(12, 12)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(256, 199)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 358)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnZoe)
        Me.Controls.Add(Me.btnLucas)
        Me.Controls.Add(Me.btnEmery)
        Me.Controls.Add(Me.picMain)
        Me.Name = "frmMain"
        Me.Text = "GrandKids Quiz"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents btnEmery As System.Windows.Forms.Button
    Friend WithEvents btnLucas As System.Windows.Forms.Button
    Friend WithEvents btnZoe As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
