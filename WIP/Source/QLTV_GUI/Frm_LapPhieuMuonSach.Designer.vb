<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_LapPhieuMuonSach
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_MaPhieuMuonSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_HoVaTen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dgv_ListPhieuMuonSach = New System.Windows.Forms.DataGridView()
        Me.Cl_STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_NgayDuKienTra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dtp_NgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.Txt_MaDocGia = New System.Windows.Forms.TextBox()
        Me.Txt_TinhTrangThe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Dgv_ListPhieuMuonSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu"
        '
        'Txt_MaPhieuMuonSach
        '
        Me.Txt_MaPhieuMuonSach.Location = New System.Drawing.Point(151, 79)
        Me.Txt_MaPhieuMuonSach.Name = "Txt_MaPhieuMuonSach"
        Me.Txt_MaPhieuMuonSach.ReadOnly = True
        Me.Txt_MaPhieuMuonSach.Size = New System.Drawing.Size(208, 26)
        Me.Txt_MaPhieuMuonSach.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Độc Giả"
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(517, 138)
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.ReadOnly = True
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(200, 26)
        Me.Txt_HoVaTen.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Họ và Tên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ngày Mượn"
        '
        'Dgv_ListPhieuMuonSach
        '
        Me.Dgv_ListPhieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListPhieuMuonSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_STT, Me.Txt_MaSach, Me.Cl_TenSach, Me.Cl_TheLoai, Me.Cl_TacGia, Me.Cl_TinhTrang, Me.Cl_NgayDuKienTra})
        Me.Dgv_ListPhieuMuonSach.Location = New System.Drawing.Point(52, 257)
        Me.Dgv_ListPhieuMuonSach.Name = "Dgv_ListPhieuMuonSach"
        Me.Dgv_ListPhieuMuonSach.RowTemplate.Height = 28
        Me.Dgv_ListPhieuMuonSach.Size = New System.Drawing.Size(1224, 310)
        Me.Dgv_ListPhieuMuonSach.TabIndex = 12
        '
        'Cl_STT
        '
        Me.Cl_STT.HeaderText = "STT"
        Me.Cl_STT.Name = "Cl_STT"
        Me.Cl_STT.ReadOnly = True
        '
        'Txt_MaSach
        '
        Me.Txt_MaSach.HeaderText = "Mã Sách"
        Me.Txt_MaSach.Name = "Txt_MaSach"
        Me.Txt_MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Txt_MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Cl_TenSach
        '
        Me.Cl_TenSach.HeaderText = "Tên Sách"
        Me.Cl_TenSach.Name = "Cl_TenSach"
        Me.Cl_TenSach.ReadOnly = True
        '
        'Cl_TheLoai
        '
        Me.Cl_TheLoai.HeaderText = "Thể Loại"
        Me.Cl_TheLoai.Name = "Cl_TheLoai"
        Me.Cl_TheLoai.ReadOnly = True
        '
        'Cl_TacGia
        '
        Me.Cl_TacGia.HeaderText = "Tác Giả"
        Me.Cl_TacGia.Name = "Cl_TacGia"
        Me.Cl_TacGia.ReadOnly = True
        '
        'Cl_TinhTrang
        '
        Me.Cl_TinhTrang.HeaderText = "Tình Trạng"
        Me.Cl_TinhTrang.Name = "Cl_TinhTrang"
        Me.Cl_TinhTrang.ReadOnly = True
        '
        'Cl_NgayDuKienTra
        '
        Me.Cl_NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả"
        Me.Cl_NgayDuKienTra.Name = "Cl_NgayDuKienTra"
        Me.Cl_NgayDuKienTra.ReadOnly = True
        '
        'Dtp_NgayMuon
        '
        Me.Dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayMuon.Location = New System.Drawing.Point(517, 72)
        Me.Dtp_NgayMuon.Name = "Dtp_NgayMuon"
        Me.Dtp_NgayMuon.Size = New System.Drawing.Size(200, 26)
        Me.Dtp_NgayMuon.TabIndex = 14
        '
        'Txt_MaDocGia
        '
        Me.Txt_MaDocGia.Location = New System.Drawing.Point(151, 138)
        Me.Txt_MaDocGia.Name = "Txt_MaDocGia"
        Me.Txt_MaDocGia.Size = New System.Drawing.Size(208, 26)
        Me.Txt_MaDocGia.TabIndex = 15
        '
        'Txt_TinhTrangThe
        '
        Me.Txt_TinhTrangThe.Location = New System.Drawing.Point(960, 138)
        Me.Txt_TinhTrangThe.Name = "Txt_TinhTrangThe"
        Me.Txt_TinhTrangThe.ReadOnly = True
        Me.Txt_TinhTrangThe.Size = New System.Drawing.Size(200, 26)
        Me.Txt_TinhTrangThe.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(820, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tình Trạng Thẻ"
        '
        'Frm_LapPhieuMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 659)
        Me.Controls.Add(Me.Txt_TinhTrangThe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_MaDocGia)
        Me.Controls.Add(Me.Dtp_NgayMuon)
        Me.Controls.Add(Me.Dgv_ListPhieuMuonSach)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaPhieuMuonSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_LapPhieuMuonSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phiếu Mượn Sách"
        CType(Me.Dgv_ListPhieuMuonSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_MaPhieuMuonSach As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_HoVaTen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Dgv_ListPhieuMuonSach As DataGridView
    Friend WithEvents Dtp_NgayMuon As DateTimePicker
    Friend WithEvents Cl_STT As DataGridViewTextBoxColumn
    Friend WithEvents Txt_MaSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TacGia As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TinhTrang As DataGridViewTextBoxColumn
    Friend WithEvents Cl_NgayDuKienTra As DataGridViewTextBoxColumn
    Friend WithEvents Txt_MaDocGia As TextBox
    Friend WithEvents Txt_TinhTrangThe As TextBox
    Friend WithEvents Label5 As Label
End Class
