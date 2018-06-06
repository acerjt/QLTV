<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_UserName = New System.Windows.Forms.TextBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Txt_PassWord = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserName"
        '
        'Txt_UserName
        '
        Me.Txt_UserName.Location = New System.Drawing.Point(140, 28)
        Me.Txt_UserName.Name = "Txt_UserName"
        Me.Txt_UserName.Size = New System.Drawing.Size(185, 22)
        Me.Txt_UserName.TabIndex = 1
        '
        'Btn_Login
        '
        Me.Btn_Login.Location = New System.Drawing.Point(63, 125)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(94, 41)
        Me.Btn_Login.TabIndex = 2
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Txt_PassWord
        '
        Me.Txt_PassWord.Location = New System.Drawing.Point(140, 70)
        Me.Txt_PassWord.Name = "Txt_PassWord"
        Me.Txt_PassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.Txt_PassWord.Size = New System.Drawing.Size(185, 22)
        Me.Txt_PassWord.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 270)
        Me.Controls.Add(Me.Txt_PassWord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Txt_UserName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Login"
        Me.Text = "Frm_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_UserName As TextBox
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Txt_PassWord As TextBox
    Friend WithEvents Label2 As Label
End Class
