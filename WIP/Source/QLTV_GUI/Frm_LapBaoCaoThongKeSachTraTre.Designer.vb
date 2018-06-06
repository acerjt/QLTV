<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_LapBaoCaoThongKeSachTraTre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_LapBaoCaoThongKeSachTraTre))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_TongSoLuotMuon = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Cb_Thang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.d = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Dgv_ListLapBaoCaoThongKe = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dgv_ListBaoCaoThongKe = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.dsfd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dfs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fsd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TinhTrangg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_MaLapBaoCao = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Dtp_NgayLap = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Txt_Nam = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Btn_LapBaoCao = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_NgayMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_SoNgayTraTre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_ListLapBaoCaoThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv_ListBaoCaoThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(739, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 44)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Ngày Lập"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(226, 670)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 44)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Tổng Số Lượt Mượn"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(46, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 44)
        Me.Label4.TabIndex = 203
        Me.Label4.Text = "Năm"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_TongSoLuotMuon
        '
        Me.Txt_TongSoLuotMuon.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TongSoLuotMuon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TongSoLuotMuon.Location = New System.Drawing.Point(497, 670)
        Me.Txt_TongSoLuotMuon.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_TongSoLuotMuon.Multiline = True
        Me.Txt_TongSoLuotMuon.Name = "Txt_TongSoLuotMuon"
        Me.Txt_TongSoLuotMuon.ReadOnly = True
        Me.Txt_TongSoLuotMuon.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TongSoLuotMuon.TabIndex = 202
        '
        'Cb_Thang
        '
        Me.Cb_Thang.DropDownWidth = 269
        Me.Cb_Thang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Thang.FormattingEnabled = True
        Me.Cb_Thang.IntegralHeight = False
        Me.Cb_Thang.ItemHeight = 27
        Me.Cb_Thang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.Cb_Thang.Location = New System.Drawing.Point(934, 148)
        Me.Cb_Thang.Name = "Cb_Thang"
        Me.Cb_Thang.Size = New System.Drawing.Size(282, 35)
        Me.Cb_Thang.TabIndex = 201
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(-1, -3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(741, 70)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Báo Cáo Thống Kê Sách Trả Trễ"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me
        '
        'd
        '
        Me.d.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.ForeColor = System.Drawing.Color.SeaGreen
        Me.d.Location = New System.Drawing.Point(46, 96)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(265, 44)
        Me.d.TabIndex = 194
        Me.d.Text = "Mã Lập Báo Cáo"
        Me.d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(12, 52)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1567, 39)
        Me.BunifuSeparator1.TabIndex = 192
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Dgv_ListLapBaoCaoThongKe
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListLapBaoCaoThongKe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_ListLapBaoCaoThongKe.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListLapBaoCaoThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListLapBaoCaoThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListLapBaoCaoThongKe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ListLapBaoCaoThongKe.ColumnHeadersHeight = 50
        Me.Dgv_ListLapBaoCaoThongKe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_TenSach, Me.Cl_NgayMuon, Me.Cl_SoNgayTraTre})
        Me.Dgv_ListLapBaoCaoThongKe.DoubleBuffered = True
        Me.Dgv_ListLapBaoCaoThongKe.EnableHeadersVisualStyles = False
        Me.Dgv_ListLapBaoCaoThongKe.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListLapBaoCaoThongKe.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListLapBaoCaoThongKe.Location = New System.Drawing.Point(32, 43)
        Me.Dgv_ListLapBaoCaoThongKe.Name = "Dgv_ListLapBaoCaoThongKe"
        Me.Dgv_ListLapBaoCaoThongKe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_ListLapBaoCaoThongKe.RowHeadersWidth = 60
        Me.Dgv_ListLapBaoCaoThongKe.RowTemplate.Height = 28
        Me.Dgv_ListLapBaoCaoThongKe.Size = New System.Drawing.Size(663, 358)
        Me.Dgv_ListLapBaoCaoThongKe.TabIndex = 147
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dgv_ListBaoCaoThongKe)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox2.Location = New System.Drawing.Point(817, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(727, 407)
        Me.GroupBox2.TabIndex = 200
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Báo Cáo Đã Lập"
        '
        'Dgv_ListBaoCaoThongKe
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListBaoCaoThongKe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ListBaoCaoThongKe.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListBaoCaoThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListBaoCaoThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListBaoCaoThongKe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ListBaoCaoThongKe.ColumnHeadersHeight = 30
        Me.Dgv_ListBaoCaoThongKe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dsfd, Me.dfs, Me.fsd, Me.dsf, Me.Cl_TinhTrangg})
        Me.Dgv_ListBaoCaoThongKe.DoubleBuffered = True
        Me.Dgv_ListBaoCaoThongKe.EnableHeadersVisualStyles = False
        Me.Dgv_ListBaoCaoThongKe.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListBaoCaoThongKe.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListBaoCaoThongKe.Location = New System.Drawing.Point(41, 43)
        Me.Dgv_ListBaoCaoThongKe.Name = "Dgv_ListBaoCaoThongKe"
        Me.Dgv_ListBaoCaoThongKe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_ListBaoCaoThongKe.RowHeadersWidth = 50
        Me.Dgv_ListBaoCaoThongKe.RowTemplate.Height = 28
        Me.Dgv_ListBaoCaoThongKe.Size = New System.Drawing.Size(680, 358)
        Me.Dgv_ListBaoCaoThongKe.TabIndex = 164
        '
        'dsfd
        '
        Me.dsfd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dsfd.HeaderText = "Tên Thể Loại"
        Me.dsfd.Name = "dsfd"
        Me.dsfd.Width = 218
        '
        'dfs
        '
        Me.dfs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.dfs.HeaderText = "Số Lượt Mượn"
        Me.dfs.Name = "dfs"
        Me.dfs.Width = 238
        '
        'fsd
        '
        Me.fsd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fsd.HeaderText = "Tỉ Lệ"
        Me.fsd.Name = "fsd"
        Me.fsd.Width = 118
        '
        'dsf
        '
        Me.dsf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dsf.HeaderText = "Tháng"
        Me.dsf.Name = "dsf"
        Me.dsf.Width = 127
        '
        'Cl_TinhTrangg
        '
        Me.Cl_TinhTrangg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cl_TinhTrangg.HeaderText = "Năm"
        Me.Cl_TinhTrangg.Name = "Cl_TinhTrangg"
        Me.Cl_TinhTrangg.Width = 109
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv_ListLapBaoCaoThongKe)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox1.Location = New System.Drawing.Point(52, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 407)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lập Báo Cáo Mới"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(740, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 44)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Tháng"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_MaLapBaoCao
        '
        Me.Txt_MaLapBaoCao.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaLapBaoCao.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaLapBaoCao.Location = New System.Drawing.Point(336, 96)
        Me.Txt_MaLapBaoCao.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_MaLapBaoCao.Multiline = True
        Me.Txt_MaLapBaoCao.Name = "Txt_MaLapBaoCao"
        Me.Txt_MaLapBaoCao.ReadOnly = True
        Me.Txt_MaLapBaoCao.Size = New System.Drawing.Size(282, 44)
        Me.Txt_MaLapBaoCao.TabIndex = 195
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me
        '
        'Dtp_NgayLap
        '
        Me.Dtp_NgayLap.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayLap.BorderRadius = 0
        Me.Dtp_NgayLap.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayLap.FormatCustom = Nothing
        Me.Dtp_NgayLap.Location = New System.Drawing.Point(934, 96)
        Me.Dtp_NgayLap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp_NgayLap.Name = "Dtp_NgayLap"
        Me.Dtp_NgayLap.Size = New System.Drawing.Size(282, 44)
        Me.Dtp_NgayLap.TabIndex = 205
        Me.Dtp_NgayLap.Value = New Date(2018, 5, 28, 14, 6, 57, 11)
        '
        'Txt_Nam
        '
        Me.Txt_Nam.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_Nam.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nam.Location = New System.Drawing.Point(336, 147)
        Me.Txt_Nam.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_Nam.Multiline = True
        Me.Txt_Nam.Name = "Txt_Nam"
        Me.Txt_Nam.Size = New System.Drawing.Size(282, 44)
        Me.Txt_Nam.TabIndex = 196
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1524, 9)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 193
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Btn_LapBaoCao
        '
        Me.Btn_LapBaoCao.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_LapBaoCao.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_LapBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_LapBaoCao.BorderRadius = 7
        Me.Btn_LapBaoCao.ButtonText = "LẬP BÁO CÁO"
        Me.Btn_LapBaoCao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_LapBaoCao.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_LapBaoCao.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_LapBaoCao.Iconimage = CType(resources.GetObject("Btn_LapBaoCao.Iconimage"), System.Drawing.Image)
        Me.Btn_LapBaoCao.Iconimage_right = Nothing
        Me.Btn_LapBaoCao.Iconimage_right_Selected = Nothing
        Me.Btn_LapBaoCao.Iconimage_Selected = Nothing
        Me.Btn_LapBaoCao.IconMarginLeft = 0
        Me.Btn_LapBaoCao.IconMarginRight = 0
        Me.Btn_LapBaoCao.IconRightVisible = True
        Me.Btn_LapBaoCao.IconRightZoom = 0R
        Me.Btn_LapBaoCao.IconVisible = False
        Me.Btn_LapBaoCao.IconZoom = 90.0R
        Me.Btn_LapBaoCao.IsTab = False
        Me.Btn_LapBaoCao.Location = New System.Drawing.Point(667, 737)
        Me.Btn_LapBaoCao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_LapBaoCao.Name = "Btn_LapBaoCao"
        Me.Btn_LapBaoCao.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_LapBaoCao.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_LapBaoCao.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_LapBaoCao.selected = False
        Me.Btn_LapBaoCao.Size = New System.Drawing.Size(321, 74)
        Me.Btn_LapBaoCao.TabIndex = 198
        Me.Btn_LapBaoCao.Text = "LẬP BÁO CÁO"
        Me.Btn_LapBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_LapBaoCao.Textcolor = System.Drawing.Color.White
        Me.Btn_LapBaoCao.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Cl_TenSach
        '
        Me.Cl_TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_TenSach.HeaderText = "Tên Sách"
        Me.Cl_TenSach.Name = "Cl_TenSach"
        Me.Cl_TenSach.ReadOnly = True
        Me.Cl_TenSach.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cl_TenSach.Width = 166
        '
        'Cl_NgayMuon
        '
        Me.Cl_NgayMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_NgayMuon.HeaderText = "Ngày Mượn"
        Me.Cl_NgayMuon.Name = "Cl_NgayMuon"
        Me.Cl_NgayMuon.Width = 201
        '
        'Cl_SoNgayTraTre
        '
        Me.Cl_SoNgayTraTre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_SoNgayTraTre.HeaderText = "Số Ngày Trả Trễ"
        Me.Cl_SoNgayTraTre.Name = "Cl_SoNgayTraTre"
        Me.Cl_SoNgayTraTre.Width = 258
        '
        'Frm_LapBaoCaoThongKeSachTraTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1670, 843)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_TongSoLuotMuon)
        Me.Controls.Add(Me.Cb_Thang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_LapBaoCao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaLapBaoCao)
        Me.Controls.Add(Me.Dtp_NgayLap)
        Me.Controls.Add(Me.Txt_Nam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_LapBaoCaoThongKeSachTraTre"
        Me.Text = "Frm_LapBaoCaoThongKeSachTraTre"
        CType(Me.Dgv_ListLapBaoCaoThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgv_ListBaoCaoThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_TongSoLuotMuon As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Cb_Thang As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents d As Label
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Dgv_ListBaoCaoThongKe As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dsfd As DataGridViewTextBoxColumn
    Friend WithEvents dfs As DataGridViewTextBoxColumn
    Friend WithEvents fsd As DataGridViewTextBoxColumn
    Friend WithEvents dsf As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TinhTrangg As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Dgv_ListLapBaoCaoThongKe As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Btn_LapBaoCao As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_MaLapBaoCao As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Dtp_NgayLap As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Txt_Nam As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_NgayMuon As DataGridViewTextBoxColumn
    Friend WithEvents Cl_SoNgayTraTre As DataGridViewTextBoxColumn
End Class
