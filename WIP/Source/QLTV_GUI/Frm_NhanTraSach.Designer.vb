<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NhanTraSach
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_NhanTraSach))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Dgv_ListSachTra = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Cl_MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_HoVaTen = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_MaDocGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_MaPhieuTraSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Dtp_NgayTra = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.d = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dgv_ListSachDangMuon = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Cl_MaSach1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TenSach1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_theloai1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tacgia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Btn_NhanTraSach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.Dgv_ListSachTra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListSachDangMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Dgv_ListSachTra
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListSachTra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ListSachTra.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListSachTra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListSachTra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListSachTra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ListSachTra.ColumnHeadersHeight = 30
        Me.Dgv_ListSachTra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_MaSach, Me.Cl_TenSach, Me.Cl_TheLoai, Me.Cl_TacGia, Me.Cl_TinhTrang})
        Me.Dgv_ListSachTra.DoubleBuffered = True
        Me.Dgv_ListSachTra.EnableHeadersVisualStyles = False
        Me.Dgv_ListSachTra.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListSachTra.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListSachTra.Location = New System.Drawing.Point(42, 65)
        Me.Dgv_ListSachTra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgv_ListSachTra.Name = "Dgv_ListSachTra"
        Me.Dgv_ListSachTra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_ListSachTra.RowHeadersWidth = 50
        Me.Dgv_ListSachTra.RowTemplate.Height = 28
        Me.Dgv_ListSachTra.Size = New System.Drawing.Size(1268, 154)
        Me.Dgv_ListSachTra.TabIndex = 182
        '
        'Cl_MaSach
        '
        Me.Cl_MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_MaSach.HeaderText = "Mã Sách"
        Me.Cl_MaSach.Name = "Cl_MaSach"
        Me.Cl_MaSach.Width = 137
        '
        'Cl_TenSach
        '
        Me.Cl_TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cl_TenSach.HeaderText = "Tên Sách"
        Me.Cl_TenSach.Name = "Cl_TenSach"
        Me.Cl_TenSach.Width = 143
        '
        'Cl_TheLoai
        '
        Me.Cl_TheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cl_TheLoai.HeaderText = "Thể Loại"
        Me.Cl_TheLoai.Name = "Cl_TheLoai"
        Me.Cl_TheLoai.Width = 139
        '
        'Cl_TacGia
        '
        Me.Cl_TacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cl_TacGia.HeaderText = "Tác Giả"
        Me.Cl_TacGia.Name = "Cl_TacGia"
        Me.Cl_TacGia.Width = 126
        '
        'Cl_TinhTrang
        '
        Me.Cl_TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cl_TinhTrang.HeaderText = "Tình Trạng"
        Me.Cl_TinhTrang.Name = "Cl_TinhTrang"
        Me.Cl_TinhTrang.Width = 161
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_HoVaTen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(1013, 130)
        Me.Txt_HoVaTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_HoVaTen.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_HoVaTen.Multiline = True
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.ReadOnly = True
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(251, 36)
        Me.Txt_HoVaTen.TabIndex = 180
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(814, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 35)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Họ và Tên"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label10.Location = New System.Drawing.Point(814, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 35)
        Me.Label10.TabIndex = 176
        Me.Label10.Text = "Ngày Trả"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_MaDocGia
        '
        Me.Txt_MaDocGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaDocGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaDocGia.Location = New System.Drawing.Point(254, 130)
        Me.Txt_MaDocGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_MaDocGia.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_MaDocGia.Multiline = True
        Me.Txt_MaDocGia.Name = "Txt_MaDocGia"
        Me.Txt_MaDocGia.Size = New System.Drawing.Size(251, 36)
        Me.Txt_MaDocGia.TabIndex = 175
        '
        'Txt_MaPhieuTraSach
        '
        Me.Txt_MaPhieuTraSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaPhieuTraSach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaPhieuTraSach.Location = New System.Drawing.Point(254, 83)
        Me.Txt_MaPhieuTraSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_MaPhieuTraSach.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_MaPhieuTraSach.Multiline = True
        Me.Txt_MaPhieuTraSach.Name = "Txt_MaPhieuTraSach"
        Me.Txt_MaPhieuTraSach.ReadOnly = True
        Me.Txt_MaPhieuTraSach.Size = New System.Drawing.Size(251, 36)
        Me.Txt_MaPhieuTraSach.TabIndex = 174
        '
        'Dtp_NgayTra
        '
        Me.Dtp_NgayTra.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayTra.BorderRadius = 0
        Me.Dtp_NgayTra.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_NgayTra.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayTra.FormatCustom = Nothing
        Me.Dtp_NgayTra.Location = New System.Drawing.Point(1013, 83)
        Me.Dtp_NgayTra.Margin = New System.Windows.Forms.Padding(4)
        Me.Dtp_NgayTra.Name = "Dtp_NgayTra"
        Me.Dtp_NgayTra.Size = New System.Drawing.Size(251, 35)
        Me.Dtp_NgayTra.TabIndex = 173
        Me.Dtp_NgayTra.Value = New Date(2018, 5, 30, 20, 45, 16, 234)
        '
        'd
        '
        Me.d.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.ForeColor = System.Drawing.Color.SeaGreen
        Me.d.Location = New System.Drawing.Point(55, 83)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(194, 35)
        Me.d.TabIndex = 171
        Me.d.Text = "Mã Phiếu"
        Me.d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(55, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 35)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Mã Độc Giả"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dgv_ListSachDangMuon
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListSachDangMuon.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_ListSachDangMuon.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListSachDangMuon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListSachDangMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListSachDangMuon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ListSachDangMuon.ColumnHeadersHeight = 60
        Me.Dgv_ListSachDangMuon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_MaSach1, Me.Cl_TenSach1, Me.Cl_theloai1, Me.Tacgia, Me.a, Me.sda})
        Me.Dgv_ListSachDangMuon.DoubleBuffered = True
        Me.Dgv_ListSachDangMuon.EnableHeadersVisualStyles = False
        Me.Dgv_ListSachDangMuon.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListSachDangMuon.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListSachDangMuon.Location = New System.Drawing.Point(42, 49)
        Me.Dgv_ListSachDangMuon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgv_ListSachDangMuon.Name = "Dgv_ListSachDangMuon"
        Me.Dgv_ListSachDangMuon.ReadOnly = True
        Me.Dgv_ListSachDangMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_ListSachDangMuon.RowHeadersWidth = 50
        Me.Dgv_ListSachDangMuon.RowTemplate.Height = 28
        Me.Dgv_ListSachDangMuon.Size = New System.Drawing.Size(1268, 166)
        Me.Dgv_ListSachDangMuon.TabIndex = 170
        '
        'Cl_MaSach1
        '
        Me.Cl_MaSach1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_MaSach1.HeaderText = "Mã Sách"
        Me.Cl_MaSach1.Name = "Cl_MaSach1"
        Me.Cl_MaSach1.ReadOnly = True
        Me.Cl_MaSach1.Width = 137
        '
        'Cl_TenSach1
        '
        Me.Cl_TenSach1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_TenSach1.HeaderText = "Tên Sách"
        Me.Cl_TenSach1.Name = "Cl_TenSach1"
        Me.Cl_TenSach1.ReadOnly = True
        Me.Cl_TenSach1.Width = 143
        '
        'Cl_theloai1
        '
        Me.Cl_theloai1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_theloai1.HeaderText = "Thể Loại"
        Me.Cl_theloai1.Name = "Cl_theloai1"
        Me.Cl_theloai1.ReadOnly = True
        Me.Cl_theloai1.Width = 139
        '
        'Tacgia
        '
        Me.Tacgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Tacgia.HeaderText = "Tác Giả"
        Me.Tacgia.Name = "Tacgia"
        Me.Tacgia.ReadOnly = True
        Me.Tacgia.Width = 126
        '
        'a
        '
        Me.a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.a.HeaderText = "Tình Trạng"
        Me.a.Name = "a"
        Me.a.ReadOnly = True
        Me.a.Width = 161
        '
        'sda
        '
        Me.sda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.sda.HeaderText = "Ngày Dự Kiến Trả"
        Me.sda.Name = "sda"
        Me.sda.ReadOnly = True
        Me.sda.Width = 240
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 60)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Phiếu Trả Sách"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-4, 47)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1416, 43)
        Me.BunifuSeparator1.TabIndex = 168
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me
        '
        'Btn_NhanTraSach
        '
        Me.Btn_NhanTraSach.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_NhanTraSach.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_NhanTraSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_NhanTraSach.BorderRadius = 7
        Me.Btn_NhanTraSach.ButtonText = "Trả Sách"
        Me.Btn_NhanTraSach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NhanTraSach.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_NhanTraSach.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_NhanTraSach.Iconimage = CType(resources.GetObject("Btn_NhanTraSach.Iconimage"), System.Drawing.Image)
        Me.Btn_NhanTraSach.Iconimage_right = Nothing
        Me.Btn_NhanTraSach.Iconimage_right_Selected = Nothing
        Me.Btn_NhanTraSach.Iconimage_Selected = Nothing
        Me.Btn_NhanTraSach.IconMarginLeft = 0
        Me.Btn_NhanTraSach.IconMarginRight = 0
        Me.Btn_NhanTraSach.IconRightVisible = True
        Me.Btn_NhanTraSach.IconRightZoom = 0R
        Me.Btn_NhanTraSach.IconVisible = False
        Me.Btn_NhanTraSach.IconZoom = 90.0R
        Me.Btn_NhanTraSach.IsTab = False
        Me.Btn_NhanTraSach.Location = New System.Drawing.Point(428, 754)
        Me.Btn_NhanTraSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_NhanTraSach.Name = "Btn_NhanTraSach"
        Me.Btn_NhanTraSach.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_NhanTraSach.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_NhanTraSach.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_NhanTraSach.selected = False
        Me.Btn_NhanTraSach.Size = New System.Drawing.Size(202, 59)
        Me.Btn_NhanTraSach.TabIndex = 181
        Me.Btn_NhanTraSach.Text = "Trả Sách"
        Me.Btn_NhanTraSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_NhanTraSach.Textcolor = System.Drawing.Color.White
        Me.Btn_NhanTraSach.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1363, 11)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(49, 38)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 169
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv_ListSachDangMuon)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox1.Location = New System.Drawing.Point(70, 200)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1342, 229)
        Me.GroupBox1.TabIndex = 185
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách các SÁCH đã mượn:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dgv_ListSachTra)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox2.Location = New System.Drawing.Point(70, 475)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1342, 235)
        Me.GroupBox2.TabIndex = 186
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh sách các SÁCH trả:"
        '
        'Frm_NhanTraSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1462, 838)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_NhanTraSach)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_MaDocGia)
        Me.Controls.Add(Me.Txt_MaPhieuTraSach)
        Me.Controls.Add(Me.Dtp_NgayTra)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Btn_Close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_NhanTraSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_NhanTraSach"
        CType(Me.Dgv_ListSachTra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListSachDangMuon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Dgv_ListSachTra As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Cl_MaSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TacGia As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TinhTrang As DataGridViewTextBoxColumn
    Friend WithEvents Btn_NhanTraSach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Txt_HoVaTen As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_MaDocGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_MaPhieuTraSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Dtp_NgayTra As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents d As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Dgv_ListSachDangMuon As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Cl_MaSach1 As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TenSach1 As DataGridViewTextBoxColumn
    Friend WithEvents Cl_theloai1 As DataGridViewTextBoxColumn
    Friend WithEvents Tacgia As DataGridViewTextBoxColumn
    Friend WithEvents a As DataGridViewTextBoxColumn
    Friend WithEvents sda As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
