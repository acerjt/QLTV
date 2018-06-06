<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ThemSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ThemSach))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gdf = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ad = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.sa = New System.Windows.Forms.Label()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Dtp_NgayNhap = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Btn_Nhap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_NhapVaDong = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Txt_TenSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_MaSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Cb_Theloai = New System.Windows.Forms.ComboBox()
        Me.Cb_TenTacGia = New System.Windows.Forms.ComboBox()
        Me.Txt_TriGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_NhaXuatBan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_NamXuatBan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(172, 549)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 35)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Trị Giá"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label7.Location = New System.Drawing.Point(172, 482)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(267, 45)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Ngày Nhập"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(172, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 35)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Mã Sách"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gdf
        '
        Me.gdf.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gdf.ForeColor = System.Drawing.Color.SeaGreen
        Me.gdf.Location = New System.Drawing.Point(172, 423)
        Me.gdf.Name = "gdf"
        Me.gdf.Size = New System.Drawing.Size(267, 35)
        Me.gdf.TabIndex = 44
        Me.gdf.Text = "Nhà Xuất Bản"
        Me.gdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(172, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 35)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Tên Sách"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ad
        '
        Me.ad.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad.ForeColor = System.Drawing.Color.SeaGreen
        Me.ad.Location = New System.Drawing.Point(172, 359)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(267, 35)
        Me.ad.TabIndex = 42
        Me.ad.Text = "Năm Xuất Bản"
        Me.ad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label
        '
        Me.Label.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label.Location = New System.Drawing.Point(172, 234)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(258, 35)
        Me.Label.TabIndex = 38
        Me.Label.Text = "Thể Loại Sách"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sa
        '
        Me.sa.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sa.ForeColor = System.Drawing.Color.SeaGreen
        Me.sa.Location = New System.Drawing.Point(172, 295)
        Me.sa.Name = "sa"
        Me.sa.Size = New System.Drawing.Size(267, 35)
        Me.sa.TabIndex = 40
        Me.sa.Text = "Tên Tác Giả"
        Me.sa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(834, 22)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 57
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 70)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Thêm Sách"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(12, 58)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(877, 54)
        Me.BunifuSeparator1.TabIndex = 56
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Dtp_NgayNhap
        '
        Me.Dtp_NgayNhap.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayNhap.BorderRadius = 0
        Me.Dtp_NgayNhap.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayNhap.FormatCustom = Nothing
        Me.Dtp_NgayNhap.Location = New System.Drawing.Point(433, 480)
        Me.Dtp_NgayNhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp_NgayNhap.Name = "Dtp_NgayNhap"
        Me.Dtp_NgayNhap.Size = New System.Drawing.Size(282, 37)
        Me.Dtp_NgayNhap.TabIndex = 63
        Me.Dtp_NgayNhap.Value = New Date(2018, 5, 28, 14, 6, 57, 11)
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Nhap.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Nhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Nhap.BorderRadius = 7
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
        Me.Btn_Nhap.Location = New System.Drawing.Point(125, 621)
        Me.Btn_Nhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Nhap.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Nhap.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Nhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Nhap.selected = False
        Me.Btn_Nhap.Size = New System.Drawing.Size(279, 74)
        Me.Btn_Nhap.TabIndex = 67
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
        Me.Btn_NhapVaDong.BorderRadius = 7
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
        Me.Btn_NhapVaDong.Location = New System.Drawing.Point(446, 621)
        Me.Btn_NhapVaDong.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_NhapVaDong.Name = "Btn_NhapVaDong"
        Me.Btn_NhapVaDong.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_NhapVaDong.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_NhapVaDong.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_NhapVaDong.selected = False
        Me.Btn_NhapVaDong.Size = New System.Drawing.Size(341, 74)
        Me.Btn_NhapVaDong.TabIndex = 66
        Me.Btn_NhapVaDong.Text = "NHẬP VÀ ĐÓNG"
        Me.Btn_NhapVaDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_NhapVaDong.Textcolor = System.Drawing.Color.White
        Me.Btn_NhapVaDong.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Txt_TenSach
        '
        Me.Txt_TenSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TenSach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TenSach.Location = New System.Drawing.Point(433, 161)
        Me.Txt_TenSach.Multiline = True
        Me.Txt_TenSach.Name = "Txt_TenSach"
        Me.Txt_TenSach.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TenSach.TabIndex = 93
        '
        'Txt_MaSach
        '
        Me.Txt_MaSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaSach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaSach.Location = New System.Drawing.Point(433, 97)
        Me.Txt_MaSach.Multiline = True
        Me.Txt_MaSach.Name = "Txt_MaSach"
        Me.Txt_MaSach.ReadOnly = True
        Me.Txt_MaSach.Size = New System.Drawing.Size(282, 44)
        Me.Txt_MaSach.TabIndex = 92
        '
        'Cb_Theloai
        '
        Me.Cb_Theloai.DropDownWidth = 269
        Me.Cb_Theloai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Theloai.FormattingEnabled = True
        Me.Cb_Theloai.IntegralHeight = False
        Me.Cb_Theloai.ItemHeight = 27
        Me.Cb_Theloai.Location = New System.Drawing.Point(433, 234)
        Me.Cb_Theloai.Name = "Cb_Theloai"
        Me.Cb_Theloai.Size = New System.Drawing.Size(282, 35)
        Me.Cb_Theloai.TabIndex = 125
        '
        'Cb_TenTacGia
        '
        Me.Cb_TenTacGia.DropDownWidth = 269
        Me.Cb_TenTacGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TenTacGia.FormattingEnabled = True
        Me.Cb_TenTacGia.IntegralHeight = False
        Me.Cb_TenTacGia.ItemHeight = 27
        Me.Cb_TenTacGia.Location = New System.Drawing.Point(433, 295)
        Me.Cb_TenTacGia.Name = "Cb_TenTacGia"
        Me.Cb_TenTacGia.Size = New System.Drawing.Size(282, 35)
        Me.Cb_TenTacGia.TabIndex = 126
        '
        'Txt_TriGia
        '
        Me.Txt_TriGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TriGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TriGia.Location = New System.Drawing.Point(433, 540)
        Me.Txt_TriGia.Multiline = True
        Me.Txt_TriGia.Name = "Txt_TriGia"
        Me.Txt_TriGia.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TriGia.TabIndex = 127
        '
        'Txt_NhaXuatBan
        '
        Me.Txt_NhaXuatBan.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_NhaXuatBan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NhaXuatBan.Location = New System.Drawing.Point(433, 414)
        Me.Txt_NhaXuatBan.Multiline = True
        Me.Txt_NhaXuatBan.Name = "Txt_NhaXuatBan"
        Me.Txt_NhaXuatBan.Size = New System.Drawing.Size(282, 44)
        Me.Txt_NhaXuatBan.TabIndex = 128
        '
        'Txt_NamXuatBan
        '
        Me.Txt_NamXuatBan.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_NamXuatBan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NamXuatBan.Location = New System.Drawing.Point(433, 350)
        Me.Txt_NamXuatBan.Multiline = True
        Me.Txt_NamXuatBan.Name = "Txt_NamXuatBan"
        Me.Txt_NamXuatBan.Size = New System.Drawing.Size(282, 44)
        Me.Txt_NamXuatBan.TabIndex = 129
        '
        'Frm_ThemSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(911, 720)
        Me.Controls.Add(Me.Txt_NamXuatBan)
        Me.Controls.Add(Me.Txt_NhaXuatBan)
        Me.Controls.Add(Me.Txt_TriGia)
        Me.Controls.Add(Me.Cb_TenTacGia)
        Me.Controls.Add(Me.Cb_Theloai)
        Me.Controls.Add(Me.Txt_TenSach)
        Me.Controls.Add(Me.Txt_MaSach)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.Btn_NhapVaDong)
        Me.Controls.Add(Me.Dtp_NgayNhap)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gdf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ad)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.sa)
        Me.ForeColor = System.Drawing.Color.SeaGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ThemSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ThemSach"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gdf As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ad As Label
    Friend WithEvents Label As Label
    Friend WithEvents sa As Label
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Dtp_NgayNhap As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Btn_Nhap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_NhapVaDong As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Txt_TenSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_MaSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Cb_TenTacGia As ComboBox
    Friend WithEvents Cb_Theloai As ComboBox
    Friend WithEvents Txt_NamXuatBan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_NhaXuatBan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_TriGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
