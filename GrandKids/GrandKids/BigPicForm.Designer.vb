<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BigPicForm
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
        Me.picBig = New System.Windows.Forms.PictureBox()
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBig
        '
        Me.picBig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBig.Location = New System.Drawing.Point(0, 0)
        Me.picBig.Name = "picBig"
        Me.picBig.Size = New System.Drawing.Size(426, 439)
        Me.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBig.TabIndex = 0
        Me.picBig.TabStop = False
        '
        'BigPicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 439)
        Me.ControlBox = False
        Me.Controls.Add(Me.picBig)
        Me.Name = "BigPicForm"
        Me.Text = "BigPicForm"
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBig As System.Windows.Forms.PictureBox
End Class
