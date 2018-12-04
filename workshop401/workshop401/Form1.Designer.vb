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
        Me.LisBoxMenu = New System.Windows.Forms.ListBox()
        Me.LisBoxOrder = New System.Windows.Forms.ListBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonOut = New System.Windows.Forms.Button()
        Me.ButtonOrder = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LisBoxMenu
        '
        Me.LisBoxMenu.FormattingEnabled = True
        Me.LisBoxMenu.Location = New System.Drawing.Point(55, 67)
        Me.LisBoxMenu.Name = "LisBoxMenu"
        Me.LisBoxMenu.Size = New System.Drawing.Size(186, 212)
        Me.LisBoxMenu.TabIndex = 0
        '
        'LisBoxOrder
        '
        Me.LisBoxOrder.FormattingEnabled = True
        Me.LisBoxOrder.Location = New System.Drawing.Point(364, 67)
        Me.LisBoxOrder.Name = "LisBoxOrder"
        Me.LisBoxOrder.Size = New System.Drawing.Size(186, 212)
        Me.LisBoxOrder.TabIndex = 1
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(259, 112)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(87, 44)
        Me.ButtonAdd.TabIndex = 2
        Me.ButtonAdd.Text = "เพิ่ม >"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonOut
        '
        Me.ButtonOut.Location = New System.Drawing.Point(259, 171)
        Me.ButtonOut.Name = "ButtonOut"
        Me.ButtonOut.Size = New System.Drawing.Size(87, 44)
        Me.ButtonOut.TabIndex = 3
        Me.ButtonOut.Text = "< ออก"
        Me.ButtonOut.UseVisualStyleBackColor = True
        '
        'ButtonOrder
        '
        Me.ButtonOrder.Location = New System.Drawing.Point(575, 67)
        Me.ButtonOrder.Name = "ButtonOrder"
        Me.ButtonOrder.Size = New System.Drawing.Size(87, 44)
        Me.ButtonOrder.TabIndex = 4
        Me.ButtonOrder.Text = "สั่งอาหาร"
        Me.ButtonOrder.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(575, 135)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(87, 44)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "ยกเลิก"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "เมนูทางร้าน:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "เมนูทางที่เลือก:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOrder)
        Me.Controls.Add(Me.ButtonOut)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.LisBoxOrder)
        Me.Controls.Add(Me.LisBoxMenu)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LisBoxMenu As ListBox
    Friend WithEvents LisBoxOrder As ListBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonOut As Button
    Friend WithEvents ButtonOrder As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
