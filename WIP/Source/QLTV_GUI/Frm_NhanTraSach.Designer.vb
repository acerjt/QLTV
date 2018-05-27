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
        Me.Dgv_ListSachDangMuon = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_MaDocGia = New System.Windows.Forms.TextBox()
        Me.Dtp_NgayTra = New System.Windows.Forms.DateTimePicker()
        Me.Dgv_ListSachTra = New System.Windows.Forms.DataGridView()
        Me.Cl_MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_HoVaTen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_MaPhieuTraSach = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_NhanTraSach = New System.Windows.Forms.Button()
        CType(Me.Dgv_ListSachDangMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListSachTra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_ListSachDangMuon
        '
        Me.Dgv_ListSachDangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListSachDangMuon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Dgv_ListSachDangMuon.Location = New System.Drawing.Point(69, 143)
        Me.Dgv_ListSachDangMuon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgv_ListSachDangMuon.Name = "Dgv_ListSachDangMuon"
        Me.Dgv_ListSachDangMuon.RowTemplate.Height = 28
        Me.Dgv_ListSachDangMuon.Size = New System.Drawing.Size(1088, 152)
        Me.Dgv_ListSachDangMuon.TabIndex = 31
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mã Sách"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tên Sách"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Thể Loại"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tác Giả"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tình Trạng"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ngày Dự Kiến Trả"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Txt_MaDocGia
        '
        Me.Txt_MaDocGia.Location = New System.Drawing.Point(157, 85)
        Me.Txt_MaDocGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_MaDocGia.Name = "Txt_MaDocGia"
        Me.Txt_MaDocGia.Size = New System.Drawing.Size(185, 22)
        Me.Txt_MaDocGia.TabIndex = 28
        '
        'Dtp_NgayTra
        '
        Me.Dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayTra.Location = New System.Drawing.Point(556, 33)
        Me.Dtp_NgayTra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dtp_NgayTra.Name = "Dtp_NgayTra"
        Me.Dtp_NgayTra.Size = New System.Drawing.Size(178, 22)
        Me.Dtp_NgayTra.TabIndex = 27
        '
        'Dgv_ListSachTra
        '
        Me.Dgv_ListSachTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListSachTra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_MaSach, Me.Cl_TenSach, Me.Cl_TheLoai, Me.Cl_TacGia, Me.Cl_TinhTrang})
        Me.Dgv_ListSachTra.Location = New System.Drawing.Point(69, 322)
        Me.Dgv_ListSachTra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgv_ListSachTra.Name = "Dgv_ListSachTra"
        Me.Dgv_ListSachTra.RowTemplate.Height = 28
        Me.Dgv_ListSachTra.Size = New System.Drawing.Size(1088, 248)
        Me.Dgv_ListSachTra.TabIndex = 26
        '
        'Cl_MaSach
        '
        Me.Cl_MaSach.HeaderText = "Mã Sách"
        Me.Cl_MaSach.Name = "Cl_MaSach"
        Me.Cl_MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cl_MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(464, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Ngày Trả "
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(556, 85)
        Me.Txt_HoVaTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.ReadOnly = True
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(178, 22)
        Me.Txt_HoVaTen.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Họ và Tên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Mã Độc Giả"
        '
        'Txt_MaPhieuTraSach
        '
        Me.Txt_MaPhieuTraSach.Location = New System.Drawing.Point(157, 38)
        Me.Txt_MaPhieuTraSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_MaPhieuTraSach.Name = "Txt_MaPhieuTraSach"
        Me.Txt_MaPhieuTraSach.ReadOnly = True
        Me.Txt_MaPhieuTraSach.Size = New System.Drawing.Size(185, 22)
        Me.Txt_MaPhieuTraSach.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Mã Phiếu"
        '
        'Btn_NhanTraSach
        '
        Me.Btn_NhanTraSach.Location = New System.Drawing.Point(168, 597)
        Me.Btn_NhanTraSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_NhanTraSach.Name = "Btn_NhanTraSach"
        Me.Btn_NhanTraSach.Size = New System.Drawing.Size(196, 33)
        Me.Btn_NhanTraSach.TabIndex = 32
        Me.Btn_NhanTraSach.Text = "Đồng Ý"
        Me.Btn_NhanTraSach.UseVisualStyleBackColor = True
        '
        'Frm_NhanTraSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 660)
        Me.Controls.Add(Me.Btn_NhanTraSach)
        Me.Controls.Add(Me.Dgv_ListSachDangMuon)
        Me.Controls.Add(Me.Txt_MaDocGia)
        Me.Controls.Add(Me.Dtp_NgayTra)
        Me.Controls.Add(Me.Dgv_ListSachTra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaPhieuTraSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_NhanTraSach"
        Me.Text = "Frm_NhanTraSach"
        CType(Me.Dgv_ListSachDangMuon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListSachTra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_ListSachDangMuon As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Txt_MaDocGia As TextBox
    Friend WithEvents Dtp_NgayTra As DateTimePicker
    Friend WithEvents Dgv_ListSachTra As DataGridView
    Friend WithEvents Cl_MaSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TacGia As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TinhTrang As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_HoVaTen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_MaPhieuTraSach As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_NhanTraSach As Button
End Class
