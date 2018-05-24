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
        Me.Dtp_NgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.Txt_MaDocGia = New System.Windows.Forms.TextBox()
        Me.Txt_TinhTrangThe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_LapPhieu = New System.Windows.Forms.Button()
        Me.Dgv_ListPhieuMuonSach1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_ListPhieuMuonSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListPhieuMuonSach1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu"
        '
        'Txt_MaPhieuMuonSach
        '
        Me.Txt_MaPhieuMuonSach.Location = New System.Drawing.Point(134, 63)
        Me.Txt_MaPhieuMuonSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_MaPhieuMuonSach.Name = "Txt_MaPhieuMuonSach"
        Me.Txt_MaPhieuMuonSach.ReadOnly = True
        Me.Txt_MaPhieuMuonSach.Size = New System.Drawing.Size(185, 22)
        Me.Txt_MaPhieuMuonSach.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Độc Giả"
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(460, 110)
        Me.Txt_HoVaTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.ReadOnly = True
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(178, 22)
        Me.Txt_HoVaTen.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Họ và Tên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ngày Mượn"
        '
        'Dgv_ListPhieuMuonSach
        '
        Me.Dgv_ListPhieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListPhieuMuonSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_MaSach, Me.Cl_TenSach, Me.Cl_TheLoai, Me.Cl_TacGia, Me.Cl_TinhTrang})
        Me.Dgv_ListPhieuMuonSach.Location = New System.Drawing.Point(46, 347)
        Me.Dgv_ListPhieuMuonSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgv_ListPhieuMuonSach.Name = "Dgv_ListPhieuMuonSach"
        Me.Dgv_ListPhieuMuonSach.RowTemplate.Height = 28
        Me.Dgv_ListPhieuMuonSach.Size = New System.Drawing.Size(1088, 248)
        Me.Dgv_ListPhieuMuonSach.TabIndex = 12
        '
        'Dtp_NgayMuon
        '
        Me.Dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayMuon.Location = New System.Drawing.Point(460, 58)
        Me.Dtp_NgayMuon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dtp_NgayMuon.Name = "Dtp_NgayMuon"
        Me.Dtp_NgayMuon.Size = New System.Drawing.Size(178, 22)
        Me.Dtp_NgayMuon.TabIndex = 14
        '
        'Txt_MaDocGia
        '
        Me.Txt_MaDocGia.Location = New System.Drawing.Point(134, 110)
        Me.Txt_MaDocGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_MaDocGia.Name = "Txt_MaDocGia"
        Me.Txt_MaDocGia.Size = New System.Drawing.Size(185, 22)
        Me.Txt_MaDocGia.TabIndex = 15
        '
        'Txt_TinhTrangThe
        '
        Me.Txt_TinhTrangThe.Location = New System.Drawing.Point(853, 110)
        Me.Txt_TinhTrangThe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_TinhTrangThe.Name = "Txt_TinhTrangThe"
        Me.Txt_TinhTrangThe.ReadOnly = True
        Me.Txt_TinhTrangThe.Size = New System.Drawing.Size(178, 22)
        Me.Txt_TinhTrangThe.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(729, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tình Trạng Thẻ"
        '
        'Btn_LapPhieu
        '
        Me.Btn_LapPhieu.Location = New System.Drawing.Point(182, 626)
        Me.Btn_LapPhieu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_LapPhieu.Name = "Btn_LapPhieu"
        Me.Btn_LapPhieu.Size = New System.Drawing.Size(196, 33)
        Me.Btn_LapPhieu.TabIndex = 18
        Me.Btn_LapPhieu.Text = "Lập Phiếu"
        Me.Btn_LapPhieu.UseVisualStyleBackColor = True
        '
        'Dgv_ListPhieuMuonSach1
        '
        Me.Dgv_ListPhieuMuonSach1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListPhieuMuonSach1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Dgv_ListPhieuMuonSach1.Location = New System.Drawing.Point(46, 168)
        Me.Dgv_ListPhieuMuonSach1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgv_ListPhieuMuonSach1.Name = "Dgv_ListPhieuMuonSach1"
        Me.Dgv_ListPhieuMuonSach1.RowTemplate.Height = 28
        Me.Dgv_ListPhieuMuonSach1.Size = New System.Drawing.Size(1088, 152)
        Me.Dgv_ListPhieuMuonSach1.TabIndex = 19
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
        'Frm_LapPhieuMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 684)
        Me.Controls.Add(Me.Dgv_ListPhieuMuonSach1)
        Me.Controls.Add(Me.Btn_LapPhieu)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_LapPhieuMuonSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phiếu Mượn Sách"
        CType(Me.Dgv_ListPhieuMuonSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListPhieuMuonSach1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Txt_MaDocGia As TextBox
    Friend WithEvents Txt_TinhTrangThe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_LapPhieu As Button
    Friend WithEvents Dgv_ListPhieuMuonSach1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Cl_MaSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TacGia As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TinhTrang As DataGridViewTextBoxColumn
End Class
