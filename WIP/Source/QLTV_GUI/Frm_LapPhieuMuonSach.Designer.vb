<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_LapPhieuMuonSach
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_LapPhieuMuonSach))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Dgv_ListPhieuMuonSach1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Cl_MaSach1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TenSach1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_theloai1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tacgia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_MaDocGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_MaPhieuMuonSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Dtp_NgayMuon = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.Txt_TinhTrangThe = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_HoVaTen = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dgv_ListPhieuMuonSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Btn_LapPhieu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cl_MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_ListPhieuMuonSach1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListPhieuMuonSach, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(1, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(365, 60)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Phiếu Mượn Sách"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-6, 41)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1544, 43)
        Me.BunifuSeparator1.TabIndex = 99
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Dgv_ListPhieuMuonSach1
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListPhieuMuonSach1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_ListPhieuMuonSach1.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListPhieuMuonSach1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListPhieuMuonSach1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListPhieuMuonSach1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ListPhieuMuonSach1.ColumnHeadersHeight = 40
        Me.Dgv_ListPhieuMuonSach1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_MaSach1, Me.Cl_TenSach1, Me.Cl_theloai1, Me.Tacgia, Me.a, Me.sda})
        Me.Dgv_ListPhieuMuonSach1.DoubleBuffered = True
        Me.Dgv_ListPhieuMuonSach1.EnableHeadersVisualStyles = False
        Me.Dgv_ListPhieuMuonSach1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListPhieuMuonSach1.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListPhieuMuonSach1.Location = New System.Drawing.Point(28, 34)
        Me.Dgv_ListPhieuMuonSach1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgv_ListPhieuMuonSach1.Name = "Dgv_ListPhieuMuonSach1"
        Me.Dgv_ListPhieuMuonSach1.ReadOnly = True
        Me.Dgv_ListPhieuMuonSach1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_ListPhieuMuonSach1.RowHeadersWidth = 20
        Me.Dgv_ListPhieuMuonSach1.RowTemplate.Height = 28
        Me.Dgv_ListPhieuMuonSach1.Size = New System.Drawing.Size(1433, 166)
        Me.Dgv_ListPhieuMuonSach1.TabIndex = 6
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
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label10.Location = New System.Drawing.Point(815, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 35)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = "Ngày Mượn"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_MaDocGia
        '
        Me.Txt_MaDocGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaDocGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaDocGia.Location = New System.Drawing.Point(475, 129)
        Me.Txt_MaDocGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_MaDocGia.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_MaDocGia.Multiline = True
        Me.Txt_MaDocGia.Name = "Txt_MaDocGia"
        Me.Txt_MaDocGia.Size = New System.Drawing.Size(251, 36)
        Me.Txt_MaDocGia.TabIndex = 2
        '
        'Txt_MaPhieuMuonSach
        '
        Me.Txt_MaPhieuMuonSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaPhieuMuonSach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaPhieuMuonSach.Location = New System.Drawing.Point(475, 88)
        Me.Txt_MaPhieuMuonSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_MaPhieuMuonSach.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_MaPhieuMuonSach.Multiline = True
        Me.Txt_MaPhieuMuonSach.Name = "Txt_MaPhieuMuonSach"
        Me.Txt_MaPhieuMuonSach.ReadOnly = True
        Me.Txt_MaPhieuMuonSach.Size = New System.Drawing.Size(251, 36)
        Me.Txt_MaPhieuMuonSach.TabIndex = 1
        '
        'Dtp_NgayMuon
        '
        Me.Dtp_NgayMuon.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayMuon.BorderRadius = 0
        Me.Dtp_NgayMuon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_NgayMuon.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayMuon.FormatCustom = Nothing
        Me.Dtp_NgayMuon.Location = New System.Drawing.Point(1026, 88)
        Me.Dtp_NgayMuon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dtp_NgayMuon.Name = "Dtp_NgayMuon"
        Me.Dtp_NgayMuon.Size = New System.Drawing.Size(251, 35)
        Me.Dtp_NgayMuon.TabIndex = 4
        Me.Dtp_NgayMuon.Value = New Date(2018, 6, 25, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(217, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 35)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Mã Độc Giả"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd
        '
        Me.d.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.ForeColor = System.Drawing.Color.SeaGreen
        Me.d.Location = New System.Drawing.Point(217, 88)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(272, 35)
        Me.d.TabIndex = 153
        Me.d.Text = "Mã Mượn Trả Sách"
        Me.d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_TinhTrangThe
        '
        Me.Txt_TinhTrangThe.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TinhTrangThe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TinhTrangThe.Location = New System.Drawing.Point(1026, 130)
        Me.Txt_TinhTrangThe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_TinhTrangThe.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_TinhTrangThe.Multiline = True
        Me.Txt_TinhTrangThe.Name = "Txt_TinhTrangThe"
        Me.Txt_TinhTrangThe.ReadOnly = True
        Me.Txt_TinhTrangThe.Size = New System.Drawing.Size(251, 36)
        Me.Txt_TinhTrangThe.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(815, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 35)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Tình Trạng Thẻ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_HoVaTen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(475, 169)
        Me.Txt_HoVaTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_HoVaTen.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_HoVaTen.Multiline = True
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.ReadOnly = True
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(251, 36)
        Me.Txt_HoVaTen.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(217, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 35)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Họ và Tên"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dgv_ListPhieuMuonSach
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListPhieuMuonSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ListPhieuMuonSach.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListPhieuMuonSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListPhieuMuonSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListPhieuMuonSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ListPhieuMuonSach.ColumnHeadersHeight = 40
        Me.Dgv_ListPhieuMuonSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_MaSach, Me.Cl_TenSach, Me.Cl_TheLoai, Me.Cl_TacGia, Me.Cl_TinhTrang})
        Me.Dgv_ListPhieuMuonSach.DoubleBuffered = True
        Me.Dgv_ListPhieuMuonSach.EnableHeadersVisualStyles = False
        Me.Dgv_ListPhieuMuonSach.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListPhieuMuonSach.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListPhieuMuonSach.Location = New System.Drawing.Point(28, 34)
        Me.Dgv_ListPhieuMuonSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgv_ListPhieuMuonSach.Name = "Dgv_ListPhieuMuonSach"
        Me.Dgv_ListPhieuMuonSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_ListPhieuMuonSach.RowHeadersWidth = 20
        Me.Dgv_ListPhieuMuonSach.RowTemplate.Height = 28
        Me.Dgv_ListPhieuMuonSach.Size = New System.Drawing.Size(1207, 180)
        Me.Dgv_ListPhieuMuonSach.TabIndex = 7
        '
        'Btn_LapPhieu
        '
        Me.Btn_LapPhieu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_LapPhieu.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_LapPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_LapPhieu.BorderRadius = 7
        Me.Btn_LapPhieu.ButtonText = "LẬP PHIẾU"
        Me.Btn_LapPhieu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_LapPhieu.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_LapPhieu.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_LapPhieu.Iconimage = CType(resources.GetObject("Btn_LapPhieu.Iconimage"), System.Drawing.Image)
        Me.Btn_LapPhieu.Iconimage_right = Nothing
        Me.Btn_LapPhieu.Iconimage_right_Selected = Nothing
        Me.Btn_LapPhieu.Iconimage_Selected = Nothing
        Me.Btn_LapPhieu.IconMarginLeft = 0
        Me.Btn_LapPhieu.IconMarginRight = 0
        Me.Btn_LapPhieu.IconRightVisible = True
        Me.Btn_LapPhieu.IconRightZoom = 0R
        Me.Btn_LapPhieu.IconVisible = False
        Me.Btn_LapPhieu.IconZoom = 90.0R
        Me.Btn_LapPhieu.IsTab = False
        Me.Btn_LapPhieu.Location = New System.Drawing.Point(654, 740)
        Me.Btn_LapPhieu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_LapPhieu.Name = "Btn_LapPhieu"
        Me.Btn_LapPhieu.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_LapPhieu.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_LapPhieu.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_LapPhieu.selected = False
        Me.Btn_LapPhieu.Size = New System.Drawing.Size(202, 59)
        Me.Btn_LapPhieu.TabIndex = 8
        Me.Btn_LapPhieu.Text = "LẬP PHIẾU"
        Me.Btn_LapPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_LapPhieu.Textcolor = System.Drawing.Color.White
        Me.Btn_LapPhieu.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1496, 10)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(49, 38)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 100
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv_ListPhieuMuonSach1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox1.Location = New System.Drawing.Point(71, 216)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1467, 229)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách các SÁCH đã mượn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dgv_ListPhieuMuonSach)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox2.Location = New System.Drawing.Point(145, 477)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1347, 230)
        Me.GroupBox2.TabIndex = 168
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh sách các SÁCH cần mượn:"
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
        Me.Cl_TenSach.ReadOnly = True
        Me.Cl_TenSach.Width = 143
        '
        'Cl_TheLoai
        '
        Me.Cl_TheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_TheLoai.HeaderText = "Thể Loại"
        Me.Cl_TheLoai.Name = "Cl_TheLoai"
        Me.Cl_TheLoai.ReadOnly = True
        Me.Cl_TheLoai.Width = 139
        '
        'Cl_TacGia
        '
        Me.Cl_TacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cl_TacGia.HeaderText = "Tác Giả"
        Me.Cl_TacGia.Name = "Cl_TacGia"
        Me.Cl_TacGia.ReadOnly = True
        Me.Cl_TacGia.Width = 126
        '
        'Cl_TinhTrang
        '
        Me.Cl_TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cl_TinhTrang.HeaderText = "Tình Trạng"
        Me.Cl_TinhTrang.Name = "Cl_TinhTrang"
        Me.Cl_TinhTrang.ReadOnly = True
        Me.Cl_TinhTrang.Width = 161
        '
        'Frm_LapPhieuMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1568, 838)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_LapPhieu)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_TinhTrangThe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_MaDocGia)
        Me.Controls.Add(Me.Txt_MaPhieuMuonSach)
        Me.Controls.Add(Me.Dtp_NgayMuon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_LapPhieuMuonSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_LapPhieuMuonSach"
        CType(Me.Dgv_ListPhieuMuonSach1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListPhieuMuonSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Dgv_ListPhieuMuonSach1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_MaDocGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_MaPhieuMuonSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents d As Label
    Friend WithEvents Txt_HoVaTen As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_TinhTrangThe As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_LapPhieu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Dgv_ListPhieuMuonSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Cl_MaSach1 As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TenSach1 As DataGridViewTextBoxColumn
    Friend WithEvents Cl_theloai1 As DataGridViewTextBoxColumn
    Friend WithEvents Tacgia As DataGridViewTextBoxColumn
    Friend WithEvents a As DataGridViewTextBoxColumn
    Friend WithEvents sda As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Dtp_NgayMuon As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Cl_MaSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TacGia As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TinhTrang As DataGridViewTextBoxColumn
End Class
