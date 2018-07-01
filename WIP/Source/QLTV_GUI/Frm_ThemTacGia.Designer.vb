<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ThemTacGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ThemTacGia))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.Btn_Nhap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_NhapVaDong = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_TenTacGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_MaTacGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(13, 47)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(885, 54)
        Me.BunifuSeparator1.TabIndex = 32
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(205, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 44)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Tên Tác Giả"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd
        '
        Me.d.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.ForeColor = System.Drawing.Color.SeaGreen
        Me.d.Location = New System.Drawing.Point(205, 123)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(207, 44)
        Me.d.TabIndex = 40
        Me.d.Text = "Mã Tác Giả"
        Me.d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Nhap.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Nhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Nhap.BorderRadius = 0
        Me.Btn_Nhap.ButtonText = "NHẬP"
        Me.Btn_Nhap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Nhap.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Nhap.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Nhap.Iconimage = CType(resources.GetObject("Btn_Nhap.Iconimage"), System.Drawing.Image)
        Me.Btn_Nhap.Iconimage_right = Nothing
        Me.Btn_Nhap.Iconimage_right_Selected = Nothing
        Me.Btn_Nhap.Iconimage_Selected = Nothing
        Me.Btn_Nhap.IconMarginLeft = 0
        Me.Btn_Nhap.IconMarginRight = 0
        Me.Btn_Nhap.IconRightVisible = True
        Me.Btn_Nhap.IconRightZoom = 0R
        Me.Btn_Nhap.IconVisible = False
        Me.Btn_Nhap.IconZoom = 90.0R
        Me.Btn_Nhap.IsTab = False
        Me.Btn_Nhap.Location = New System.Drawing.Point(117, 286)
        Me.Btn_Nhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Nhap.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Nhap.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Nhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Nhap.selected = False
        Me.Btn_Nhap.Size = New System.Drawing.Size(283, 74)
        Me.Btn_Nhap.TabIndex = 92
        Me.Btn_Nhap.Text = "NHẬP"
        Me.Btn_Nhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Nhap.Textcolor = System.Drawing.Color.White
        Me.Btn_Nhap.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_NhapVaDong
        '
        Me.Btn_NhapVaDong.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_NhapVaDong.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_NhapVaDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_NhapVaDong.BorderRadius = 0
        Me.Btn_NhapVaDong.ButtonText = "NHẬP VÀ ĐÓNG"
        Me.Btn_NhapVaDong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NhapVaDong.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_NhapVaDong.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_NhapVaDong.Iconimage = CType(resources.GetObject("Btn_NhapVaDong.Iconimage"), System.Drawing.Image)
        Me.Btn_NhapVaDong.Iconimage_right = Nothing
        Me.Btn_NhapVaDong.Iconimage_right_Selected = Nothing
        Me.Btn_NhapVaDong.Iconimage_Selected = Nothing
        Me.Btn_NhapVaDong.IconMarginLeft = 0
        Me.Btn_NhapVaDong.IconMarginRight = 0
        Me.Btn_NhapVaDong.IconRightVisible = True
        Me.Btn_NhapVaDong.IconRightZoom = 0R
        Me.Btn_NhapVaDong.IconVisible = False
        Me.Btn_NhapVaDong.IconZoom = 90.0R
        Me.Btn_NhapVaDong.IsTab = False
        Me.Btn_NhapVaDong.Location = New System.Drawing.Point(499, 286)
        Me.Btn_NhapVaDong.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_NhapVaDong.Name = "Btn_NhapVaDong"
        Me.Btn_NhapVaDong.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_NhapVaDong.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_NhapVaDong.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_NhapVaDong.selected = False
        Me.Btn_NhapVaDong.Size = New System.Drawing.Size(283, 74)
        Me.Btn_NhapVaDong.TabIndex = 93
        Me.Btn_NhapVaDong.Text = "NHẬP VÀ ĐÓNG"
        Me.Btn_NhapVaDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_NhapVaDong.Textcolor = System.Drawing.Color.White
        Me.Btn_NhapVaDong.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(828, 12)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 38
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 70)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Thêm Tác Giả"
        '
        'Txt_TenTacGia
        '
        Me.Txt_TenTacGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TenTacGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TenTacGia.Location = New System.Drawing.Point(418, 186)
        Me.Txt_TenTacGia.Multiline = True
        Me.Txt_TenTacGia.Name = "Txt_TenTacGia"
        Me.Txt_TenTacGia.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TenTacGia.TabIndex = 91
        '
        'Txt_MaTacGia
        '
        Me.Txt_MaTacGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaTacGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaTacGia.Location = New System.Drawing.Point(418, 123)
        Me.Txt_MaTacGia.Multiline = True
        Me.Txt_MaTacGia.Name = "Txt_MaTacGia"
        Me.Txt_MaTacGia.ReadOnly = True
        Me.Txt_MaTacGia.Size = New System.Drawing.Size(282, 44)
        Me.Txt_MaTacGia.TabIndex = 90
        '
        'Frm_ThemTacGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(911, 424)
        Me.Controls.Add(Me.Txt_TenTacGia)
        Me.Controls.Add(Me.Txt_MaTacGia)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_NhapVaDong)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(262, 80)
        Me.Name = "Frm_ThemTacGia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ThemTacGia"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label4 As Label
    Friend WithEvents d As Label
    Friend WithEvents Btn_Nhap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_NhapVaDong As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_TenTacGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_MaTacGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
