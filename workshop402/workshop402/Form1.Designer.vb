<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ComboBoxFaculty = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMajor = New System.Windows.Forms.ComboBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(159, 51)
        Me.TextBoxId.MaxLength = 13
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxId.TabIndex = 0
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(159, 105)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxName.TabIndex = 1
        '
        'ComboBoxFaculty
        '
        Me.ComboBoxFaculty.FormattingEnabled = True
        Me.ComboBoxFaculty.Location = New System.Drawing.Point(159, 164)
        Me.ComboBoxFaculty.Name = "ComboBoxFaculty"
        Me.ComboBoxFaculty.Size = New System.Drawing.Size(249, 21)
        Me.ComboBoxFaculty.TabIndex = 2
        '
        'ComboBoxMajor
        '
        Me.ComboBoxMajor.FormattingEnabled = True
        Me.ComboBoxMajor.Location = New System.Drawing.Point(160, 221)
        Me.ComboBoxMajor.Name = "ComboBoxMajor"
        Me.ComboBoxMajor.Size = New System.Drawing.Size(249, 21)
        Me.ComboBoxMajor.TabIndex = 3
        '
        'ButtonOK
        '
        Me.ButtonOK.Enabled = False
        Me.ButtonOK.Location = New System.Drawing.Point(42, 290)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(157, 44)
        Me.ButtonOK.TabIndex = 4
        Me.ButtonOK.Text = "ยืนยัน"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Enabled = False
        Me.ButtonReset.Location = New System.Drawing.Point(251, 290)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(157, 44)
        Me.ButtonReset.TabIndex = 5
        Me.ButtonReset.Text = "ล้างข้อมูล"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "เลขบัตรประชาชน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ชื่อ - นามสกุล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "คณะที่เลือก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "สาขาวิชา"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 363)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ComboBoxMajor)
        Me.Controls.Add(Me.ComboBoxFaculty)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxId)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ComboBoxFaculty As ComboBox
    Friend WithEvents ComboBoxMajor As ComboBox
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
