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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnHoliday = New System.Windows.Forms.Button()
        Me.picSpecialDaily = New System.Windows.Forms.PictureBox()
        Me.picSpecialWeekly = New System.Windows.Forms.PictureBox()
        Me.picSpecialHoliday = New System.Windows.Forms.PictureBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picSpecialDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpecialWeekly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpecialHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(171, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Online Store Special"
        '
        'btnDaily
        '
        Me.btnDaily.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaily.Location = New System.Drawing.Point(82, 102)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(106, 34)
        Me.btnDaily.TabIndex = 1
        Me.btnDaily.Text = "Daily"
        Me.btnDaily.UseVisualStyleBackColor = True
        '
        'btnWeekly
        '
        Me.btnWeekly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeekly.Location = New System.Drawing.Point(259, 102)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(106, 34)
        Me.btnWeekly.TabIndex = 2
        Me.btnWeekly.Text = "Weekly"
        Me.btnWeekly.UseVisualStyleBackColor = True
        '
        'btnHoliday
        '
        Me.btnHoliday.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoliday.Location = New System.Drawing.Point(436, 102)
        Me.btnHoliday.Name = "btnHoliday"
        Me.btnHoliday.Size = New System.Drawing.Size(106, 34)
        Me.btnHoliday.TabIndex = 3
        Me.btnHoliday.Text = "Holiday"
        Me.btnHoliday.UseVisualStyleBackColor = True
        '
        'picSpecialDaily
        '
        Me.picSpecialDaily.Location = New System.Drawing.Point(60, 155)
        Me.picSpecialDaily.Name = "picSpecialDaily"
        Me.picSpecialDaily.Size = New System.Drawing.Size(150, 188)
        Me.picSpecialDaily.TabIndex = 4
        Me.picSpecialDaily.TabStop = False
        '
        'picSpecialWeekly
        '
        Me.picSpecialWeekly.Location = New System.Drawing.Point(237, 154)
        Me.picSpecialWeekly.Name = "picSpecialWeekly"
        Me.picSpecialWeekly.Size = New System.Drawing.Size(150, 188)
        Me.picSpecialWeekly.TabIndex = 5
        Me.picSpecialWeekly.TabStop = False
        '
        'picSpecialHoliday
        '
        Me.picSpecialHoliday.Location = New System.Drawing.Point(414, 155)
        Me.picSpecialHoliday.Name = "picSpecialHoliday"
        Me.picSpecialHoliday.Size = New System.Drawing.Size(150, 188)
        Me.picSpecialHoliday.TabIndex = 6
        Me.picSpecialHoliday.TabStop = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(250, 363)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(125, 18)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Select a special"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(231, 399)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(162, 34)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add to shopping cart"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(231, 450)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 34)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 499)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.picSpecialHoliday)
        Me.Controls.Add(Me.picSpecialWeekly)
        Me.Controls.Add(Me.picSpecialDaily)
        Me.Controls.Add(Me.btnHoliday)
        Me.Controls.Add(Me.btnWeekly)
        Me.Controls.Add(Me.btnDaily)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "Online Store Specials"
        CType(Me.picSpecialDaily, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpecialWeekly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpecialHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnDaily As System.Windows.Forms.Button
    Friend WithEvents btnWeekly As System.Windows.Forms.Button
    Friend WithEvents btnHoliday As System.Windows.Forms.Button
    Friend WithEvents picSpecialDaily As System.Windows.Forms.PictureBox
    Friend WithEvents picSpecialWeekly As System.Windows.Forms.PictureBox
    Friend WithEvents picSpecialHoliday As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
