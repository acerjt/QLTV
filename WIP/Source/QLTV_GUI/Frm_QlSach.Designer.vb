<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_QLSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_QLSach))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_TenTacGia = New System.Windows.Forms.ComboBox()
        Me.Dtp_NgayNhap = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_MaSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_TriGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_NhaXuatBan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_NamXuatBan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_TenSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Xoa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_CapNhat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Cb_TheLoaiSach = New System.Windows.Forms.ComboBox()
        Me.Cb_TheLoaiSachCapNhat = New System.Windows.Forms.ComboBox()
        Me.Cb_TenTacGiaCapNhat = New System.Windows.Forms.ComboBox()
        Me.Dgv_ListSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(316, 614)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 44)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Tên Sách"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd
        '
        Me.d.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.ForeColor = System.Drawing.Color.SeaGreen
        Me.d.Location = New System.Drawing.Point(316, 551)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(218, 44)
        Me.d.TabIndex = 99
        Me.d.Text = "Mã Sách"
        Me.d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(-3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 70)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Quản Lí Sách"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-8, 62)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1795, 54)
        Me.BunifuSeparator1.TabIndex = 96
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1732, 22)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 97
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(914, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 44)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Tên Tác Giả"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_TenTacGia
        '
        Me.Cb_TenTacGia.DropDownWidth = 269
        Me.Cb_TenTacGia.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TenTacGia.FormattingEnabled = True
        Me.Cb_TenTacGia.IntegralHeight = False
        Me.Cb_TenTacGia.ItemHeight = 33
        Me.Cb_TenTacGia.Location = New System.Drawing.Point(1189, 107)
        Me.Cb_TenTacGia.Name = "Cb_TenTacGia"
        Me.Cb_TenTacGia.Size = New System.Drawing.Size(282, 41)
        Me.Cb_TenTacGia.TabIndex = 2
        '
        'Dtp_NgayNhap
        '
        Me.Dtp_NgayNhap.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayNhap.BorderRadius = 0
        Me.Dtp_NgayNhap.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_NgayNhap.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayNhap.FormatCustom = Nothing
        Me.Dtp_NgayNhap.Location = New System.Drawing.Point(1116, 667)
        Me.Dtp_NgayNhap.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Dtp_NgayNhap.Name = "Dtp_NgayNhap"
        Me.Dtp_NgayNhap.Size = New System.Drawing.Size(282, 54)
        Me.Dtp_NgayNhap.TabIndex = 10
        Me.Dtp_NgayNhap.Value = New Date(2018, 5, 30, 20, 45, 16, 234)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(316, 673)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 44)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Thể Loại Sách"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label6.Location = New System.Drawing.Point(316, 727)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 44)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Tên Tác Giả"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label7.Location = New System.Drawing.Point(885, 551)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(233, 44)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Năm Xuất Bản"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_MaSach
        '
        Me.Txt_MaSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaSach.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaSach.Location = New System.Drawing.Point(540, 551)
        Me.Txt_MaSach.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_MaSach.Multiline = True
        Me.Txt_MaSach.Name = "Txt_MaSach"
        Me.Txt_MaSach.ReadOnly = True
        Me.Txt_MaSach.Size = New System.Drawing.Size(282, 44)
        Me.Txt_MaSach.TabIndex = 4
        '
        'Txt_TriGia
        '
        Me.Txt_TriGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TriGia.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TriGia.Location = New System.Drawing.Point(1116, 727)
        Me.Txt_TriGia.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_TriGia.Multiline = True
        Me.Txt_TriGia.Name = "Txt_TriGia"
        Me.Txt_TriGia.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TriGia.TabIndex = 11
        '
        'Txt_NhaXuatBan
        '
        Me.Txt_NhaXuatBan.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_NhaXuatBan.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NhaXuatBan.Location = New System.Drawing.Point(1116, 614)
        Me.Txt_NhaXuatBan.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_NhaXuatBan.Multiline = True
        Me.Txt_NhaXuatBan.Name = "Txt_NhaXuatBan"
        Me.Txt_NhaXuatBan.Size = New System.Drawing.Size(282, 44)
        Me.Txt_NhaXuatBan.TabIndex = 9
        '
        'Txt_NamXuatBan
        '
        Me.Txt_NamXuatBan.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_NamXuatBan.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NamXuatBan.Location = New System.Drawing.Point(1116, 551)
        Me.Txt_NamXuatBan.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_NamXuatBan.Multiline = True
        Me.Txt_NamXuatBan.Name = "Txt_NamXuatBan"
        Me.Txt_NamXuatBan.Size = New System.Drawing.Size(282, 44)
        Me.Txt_NamXuatBan.TabIndex = 8
        '
        'Txt_TenSach
        '
        Me.Txt_TenSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TenSach.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TenSach.Location = New System.Drawing.Point(540, 614)
        Me.Txt_TenSach.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_TenSach.Multiline = True
        Me.Txt_TenSach.Name = "Txt_TenSach"
        Me.Txt_TenSach.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TenSach.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label8.Location = New System.Drawing.Point(885, 614)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 44)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Nhà Xuất Bản"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label9.Location = New System.Drawing.Point(885, 727)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(207, 44)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Trị Giá"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label10.Location = New System.Drawing.Point(885, 673)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 44)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "Ngày Nhập"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(211, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 44)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Thể Loại Sách"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Xoa
        '
        Me.Btn_Xoa.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Xoa.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Xoa.BorderRadius = 7
        Me.Btn_Xoa.ButtonText = "XÓA"
        Me.Btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Xoa.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Xoa.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Xoa.Iconimage = CType(resources.GetObject("Btn_Xoa.Iconimage"), System.Drawing.Image)
        Me.Btn_Xoa.Iconimage_right = Nothing
        Me.Btn_Xoa.Iconimage_right_Selected = Nothing
        Me.Btn_Xoa.Iconimage_Selected = Nothing
        Me.Btn_Xoa.IconMarginLeft = 0
        Me.Btn_Xoa.IconMarginRight = 0
        Me.Btn_Xoa.IconRightVisible = True
        Me.Btn_Xoa.IconRightZoom = 0R
        Me.Btn_Xoa.IconVisible = False
        Me.Btn_Xoa.IconZoom = 90.0R
        Me.Btn_Xoa.IsTab = False
        Me.Btn_Xoa.Location = New System.Drawing.Point(947, 820)
        Me.Btn_Xoa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Xoa.Name = "Btn_Xoa"
        Me.Btn_Xoa.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Xoa.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Xoa.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Xoa.selected = False
        Me.Btn_Xoa.Size = New System.Drawing.Size(253, 74)
        Me.Btn_Xoa.TabIndex = 13
        Me.Btn_Xoa.Text = "XÓA"
        Me.Btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Xoa.Textcolor = System.Drawing.Color.White
        Me.Btn_Xoa.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_CapNhat
        '
        Me.Btn_CapNhat.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_CapNhat.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_CapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_CapNhat.BorderRadius = 7
        Me.Btn_CapNhat.ButtonText = "CẬP NHẬT"
        Me.Btn_CapNhat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CapNhat.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_CapNhat.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_CapNhat.Iconimage = CType(resources.GetObject("Btn_CapNhat.Iconimage"), System.Drawing.Image)
        Me.Btn_CapNhat.Iconimage_right = Nothing
        Me.Btn_CapNhat.Iconimage_right_Selected = Nothing
        Me.Btn_CapNhat.Iconimage_Selected = Nothing
        Me.Btn_CapNhat.IconMarginLeft = 0
        Me.Btn_CapNhat.IconMarginRight = 0
        Me.Btn_CapNhat.IconRightVisible = True
        Me.Btn_CapNhat.IconRightZoom = 0R
        Me.Btn_CapNhat.IconVisible = False
        Me.Btn_CapNhat.IconZoom = 90.0R
        Me.Btn_CapNhat.IsTab = False
        Me.Btn_CapNhat.Location = New System.Drawing.Point(537, 820)
        Me.Btn_CapNhat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_CapNhat.Name = "Btn_CapNhat"
        Me.Btn_CapNhat.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_CapNhat.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_CapNhat.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_CapNhat.selected = False
        Me.Btn_CapNhat.Size = New System.Drawing.Size(247, 74)
        Me.Btn_CapNhat.TabIndex = 12
        Me.Btn_CapNhat.Text = "CẬP NHẬT"
        Me.Btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_CapNhat.Textcolor = System.Drawing.Color.White
        Me.Btn_CapNhat.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Cb_TheLoaiSach
        '
        Me.Cb_TheLoaiSach.DropDownWidth = 269
        Me.Cb_TheLoaiSach.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TheLoaiSach.FormattingEnabled = True
        Me.Cb_TheLoaiSach.IntegralHeight = False
        Me.Cb_TheLoaiSach.ItemHeight = 33
        Me.Cb_TheLoaiSach.Location = New System.Drawing.Point(502, 107)
        Me.Cb_TheLoaiSach.Name = "Cb_TheLoaiSach"
        Me.Cb_TheLoaiSach.Size = New System.Drawing.Size(282, 41)
        Me.Cb_TheLoaiSach.TabIndex = 1
        '
        'Cb_TheLoaiSachCapNhat
        '
        Me.Cb_TheLoaiSachCapNhat.DropDownWidth = 269
        Me.Cb_TheLoaiSachCapNhat.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TheLoaiSachCapNhat.FormattingEnabled = True
        Me.Cb_TheLoaiSachCapNhat.IntegralHeight = False
        Me.Cb_TheLoaiSachCapNhat.ItemHeight = 33
        Me.Cb_TheLoaiSachCapNhat.Location = New System.Drawing.Point(540, 673)
        Me.Cb_TheLoaiSachCapNhat.Name = "Cb_TheLoaiSachCapNhat"
        Me.Cb_TheLoaiSachCapNhat.Size = New System.Drawing.Size(282, 41)
        Me.Cb_TheLoaiSachCapNhat.TabIndex = 6
        '
        'Cb_TenTacGiaCapNhat
        '
        Me.Cb_TenTacGiaCapNhat.DropDownWidth = 269
        Me.Cb_TenTacGiaCapNhat.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TenTacGiaCapNhat.FormattingEnabled = True
        Me.Cb_TenTacGiaCapNhat.IntegralHeight = False
        Me.Cb_TenTacGiaCapNhat.ItemHeight = 33
        Me.Cb_TenTacGiaCapNhat.Location = New System.Drawing.Point(540, 725)
        Me.Cb_TenTacGiaCapNhat.Name = "Cb_TenTacGiaCapNhat"
        Me.Cb_TenTacGiaCapNhat.Size = New System.Drawing.Size(282, 41)
        Me.Cb_TenTacGiaCapNhat.TabIndex = 7
        '
        'Dgv_ListSach
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ListSach.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ListSach.ColumnHeadersHeight = 40
        Me.Dgv_ListSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_ListSach.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_ListSach.DoubleBuffered = True
        Me.Dgv_ListSach.EnableHeadersVisualStyles = False
        Me.Dgv_ListSach.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListSach.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListSach.Location = New System.Drawing.Point(57, 189)
        Me.Dgv_ListSach.Name = "Dgv_ListSach"
        Me.Dgv_ListSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ListSach.RowHeadersWidth = 20
        Me.Dgv_ListSach.RowTemplate.Height = 28
        Me.Dgv_ListSach.Size = New System.Drawing.Size(1703, 320)
        Me.Dgv_ListSach.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "Mã Sách"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 147
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column2.HeaderText = "Tên Sách"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 152
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column3.HeaderText = "Thể Loại Sách"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 209
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column4.HeaderText = "Tên Tác Giả"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 183
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column5.HeaderText = "Năm Xuất Bản"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 214
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column6.HeaderText = "Nhà Xuất Bản"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 208
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column7.HeaderText = "Ngày Nhập"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 174
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column8.HeaderText = "Trị Giá"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 127
        '
        'Frm_QLSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1820, 940)
        Me.Controls.Add(Me.Dgv_ListSach)
        Me.Controls.Add(Me.Cb_TenTacGiaCapNhat)
        Me.Controls.Add(Me.Cb_TheLoaiSachCapNhat)
        Me.Controls.Add(Me.Cb_TheLoaiSach)
        Me.Controls.Add(Me.Btn_Xoa)
        Me.Controls.Add(Me.Btn_CapNhat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txt_TenSach)
        Me.Controls.Add(Me.Txt_NamXuatBan)
        Me.Controls.Add(Me.Txt_NhaXuatBan)
        Me.Controls.Add(Me.Txt_TriGia)
        Me.Controls.Add(Me.Txt_MaSach)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Dtp_NgayNhap)
        Me.Controls.Add(Me.Cb_TenTacGia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.Name = "Frm_QLSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_QLSach"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label4 As Label
    Friend WithEvents d As Label
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Cb_TenTacGia As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Dtp_NgayNhap As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_MaSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_TenSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_NamXuatBan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_NhaXuatBan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_TriGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Xoa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_CapNhat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Cb_TheLoaiSach As ComboBox
    Friend WithEvents Cb_TenTacGiaCapNhat As ComboBox
    Friend WithEvents Cb_TheLoaiSachCapNhat As ComboBox
    Friend WithEvents Dgv_ListSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
