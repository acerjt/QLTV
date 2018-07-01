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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txt_Username = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Btn_Login = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Txt_Password = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Exit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 443)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 68)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "The Secret"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.QLTV_GUI.My.Resources.Resources.biblioteki_buro247_ru
        Me.PictureBox2.Location = New System.Drawing.Point(11, 215)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(338, 198)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLTV_GUI.My.Resources.Resources.icons8_lion_head_filled_100
        Me.PictureBox1.Location = New System.Drawing.Point(124, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Txt_Username
        '
        Me.Txt_Username.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_Username.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Username.Location = New System.Drawing.Point(607, 102)
        Me.Txt_Username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Username.Multiline = True
        Me.Txt_Username.Name = "Txt_Username"
        Me.Txt_Username.Size = New System.Drawing.Size(256, 36)
        Me.Txt_Username.TabIndex = 96
        Me.Txt_Username.Text = "Ton"
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(863, 20)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(76, 38)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 95
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(399, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 35)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Username"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(375, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 68)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Login"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(367, 55)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(559, 43)
        Me.BunifuSeparator1.TabIndex = 92
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Btn_Login
        '
        Me.Btn_Login.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Login.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Login.BorderRadius = 7
        Me.Btn_Login.ButtonText = "Log in"
        Me.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Login.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Login.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Login.Iconimage = CType(resources.GetObject("Btn_Login.Iconimage"), System.Drawing.Image)
        Me.Btn_Login.Iconimage_right = Nothing
        Me.Btn_Login.Iconimage_right_Selected = Nothing
        Me.Btn_Login.Iconimage_Selected = Nothing
        Me.Btn_Login.IconMarginLeft = 0
        Me.Btn_Login.IconMarginRight = 0
        Me.Btn_Login.IconRightVisible = True
        Me.Btn_Login.IconRightZoom = 0R
        Me.Btn_Login.IconVisible = False
        Me.Btn_Login.IconZoom = 90.0R
        Me.Btn_Login.IsTab = False
        Me.Btn_Login.Location = New System.Drawing.Point(568, 277)
        Me.Btn_Login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Login.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Login.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Login.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Login.selected = False
        Me.Btn_Login.Size = New System.Drawing.Size(216, 59)
        Me.Btn_Login.TabIndex = 98
        Me.Btn_Login.Text = "Log in"
        Me.Btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Login.Textcolor = System.Drawing.Color.White
        Me.Btn_Login.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Txt_Password
        '
        Me.Txt_Password.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_Password.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Password.Location = New System.Drawing.Point(607, 163)
        Me.Txt_Password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Password.Multiline = True
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Password.Size = New System.Drawing.Size(256, 36)
        Me.Txt_Password.TabIndex = 97
        Me.Txt_Password.Text = "02101998"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(399, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 35)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Exit.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Exit.BorderRadius = 7
        Me.Btn_Exit.ButtonText = "Exit"
        Me.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Exit.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Exit.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Exit.Iconimage = CType(resources.GetObject("Btn_Exit.Iconimage"), System.Drawing.Image)
        Me.Btn_Exit.Iconimage_right = Nothing
        Me.Btn_Exit.Iconimage_right_Selected = Nothing
        Me.Btn_Exit.Iconimage_Selected = Nothing
        Me.Btn_Exit.IconMarginLeft = 0
        Me.Btn_Exit.IconMarginRight = 0
        Me.Btn_Exit.IconRightVisible = True
        Me.Btn_Exit.IconRightZoom = 0R
        Me.Btn_Exit.IconVisible = False
        Me.Btn_Exit.IconZoom = 90.0R
        Me.Btn_Exit.IsTab = False
        Me.Btn_Exit.Location = New System.Drawing.Point(568, 354)
        Me.Btn_Exit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Exit.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Exit.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Exit.selected = False
        Me.Btn_Exit.Size = New System.Drawing.Size(216, 59)
        Me.Btn_Exit.TabIndex = 100
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Exit.Textcolor = System.Drawing.Color.White
        Me.Btn_Exit.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(949, 443)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Txt_Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Txt_Username)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Username As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Txt_Password As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Login As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_Exit As Bunifu.Framework.UI.BunifuFlatButton
End Class
