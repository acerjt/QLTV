<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QlSach
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv_ListSach = New System.Windows.Forms.DataGridView()
        Me.Txt_TenSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_NamXuatBan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_NhaXuatBan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_TriGia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cb_TheLoaiSach = New System.Windows.Forms.ComboBox()
        Me.Cb_TenTacGia = New System.Windows.Forms.ComboBox()
        Me.Cb_TheLoaiSachCapNhat = New System.Windows.Forms.ComboBox()
        Me.CB_TenTacGiaCapNhat = New System.Windows.Forms.ComboBox()
        Me.Btn_CapNhat = New System.Windows.Forms.Button()
        Me.Btn_Xoa = New System.Windows.Forms.Button()
        Me.Dtp_NgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.Txt_MaSach = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.Dgv_ListSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thể Loại Sách"
        '
        'Dgv_ListSach
        '
        Me.Dgv_ListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListSach.Location = New System.Drawing.Point(70, 99)
        Me.Dgv_ListSach.Name = "Dgv_ListSach"
        Me.Dgv_ListSach.RowTemplate.Height = 24
        Me.Dgv_ListSach.Size = New System.Drawing.Size(985, 285)
        Me.Dgv_ListSach.TabIndex = 2
        '
        'Txt_TenSach
        '
        Me.Txt_TenSach.Location = New System.Drawing.Point(466, 467)
        Me.Txt_TenSach.Name = "Txt_TenSach"
        Me.Txt_TenSach.Size = New System.Drawing.Size(309, 22)
        Me.Txt_TenSach.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên Sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 511)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Thể Loại Sách"
        '
        'Txt_NamXuatBan
        '
        Me.Txt_NamXuatBan.Location = New System.Drawing.Point(466, 595)
        Me.Txt_NamXuatBan.Name = "Txt_NamXuatBan"
        Me.Txt_NamXuatBan.Size = New System.Drawing.Size(309, 22)
        Me.Txt_NamXuatBan.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 595)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Năm Xuất Bản"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 551)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tên Tác Giả"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 677)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ngày Nhập"
        '
        'Txt_NhaXuatBan
        '
        Me.Txt_NhaXuatBan.Location = New System.Drawing.Point(466, 633)
        Me.Txt_NhaXuatBan.Name = "Txt_NhaXuatBan"
        Me.Txt_NhaXuatBan.Size = New System.Drawing.Size(309, 22)
        Me.Txt_NhaXuatBan.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(343, 633)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nhà Xuất Bản"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(720, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tác giả"
        '
        'Txt_TriGia
        '
        Me.Txt_TriGia.Location = New System.Drawing.Point(466, 717)
        Me.Txt_TriGia.Name = "Txt_TriGia"
        Me.Txt_TriGia.Size = New System.Drawing.Size(309, 22)
        Me.Txt_TriGia.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(343, 717)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Trị Giá"
        '
        'Cb_TheLoaiSach
        '
        Me.Cb_TheLoaiSach.FormattingEnabled = True
        Me.Cb_TheLoaiSach.Location = New System.Drawing.Point(176, 53)
        Me.Cb_TheLoaiSach.Name = "Cb_TheLoaiSach"
        Me.Cb_TheLoaiSach.Size = New System.Drawing.Size(218, 24)
        Me.Cb_TheLoaiSach.TabIndex = 19
        '
        'Cb_TenTacGia
        '
        Me.Cb_TenTacGia.FormattingEnabled = True
        Me.Cb_TenTacGia.Location = New System.Drawing.Point(781, 56)
        Me.Cb_TenTacGia.Name = "Cb_TenTacGia"
        Me.Cb_TenTacGia.Size = New System.Drawing.Size(274, 24)
        Me.Cb_TenTacGia.TabIndex = 20
        '
        'Cb_TheLoaiSachCapNhat
        '
        Me.Cb_TheLoaiSachCapNhat.FormattingEnabled = True
        Me.Cb_TheLoaiSachCapNhat.Location = New System.Drawing.Point(466, 511)
        Me.Cb_TheLoaiSachCapNhat.Name = "Cb_TheLoaiSachCapNhat"
        Me.Cb_TheLoaiSachCapNhat.Size = New System.Drawing.Size(309, 24)
        Me.Cb_TheLoaiSachCapNhat.TabIndex = 21
        '
        'CB_TenTacGiaCapNhat
        '
        Me.CB_TenTacGiaCapNhat.FormattingEnabled = True
        Me.CB_TenTacGiaCapNhat.Location = New System.Drawing.Point(466, 551)
        Me.CB_TenTacGiaCapNhat.Name = "CB_TenTacGiaCapNhat"
        Me.CB_TenTacGiaCapNhat.Size = New System.Drawing.Size(309, 24)
        Me.CB_TenTacGiaCapNhat.TabIndex = 22
        '
        'Btn_CapNhat
        '
        Me.Btn_CapNhat.Location = New System.Drawing.Point(466, 763)
        Me.Btn_CapNhat.Name = "Btn_CapNhat"
        Me.Btn_CapNhat.Size = New System.Drawing.Size(106, 49)
        Me.Btn_CapNhat.TabIndex = 23
        Me.Btn_CapNhat.Text = "Cập Nhật"
        Me.Btn_CapNhat.UseVisualStyleBackColor = True
        '
        'Btn_Xoa
        '
        Me.Btn_Xoa.Location = New System.Drawing.Point(669, 763)
        Me.Btn_Xoa.Name = "Btn_Xoa"
        Me.Btn_Xoa.Size = New System.Drawing.Size(106, 49)
        Me.Btn_Xoa.TabIndex = 24
        Me.Btn_Xoa.Text = "Xoá"
        Me.Btn_Xoa.UseVisualStyleBackColor = True
        '
        'Dtp_NgayNhap
        '
        Me.Dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayNhap.Location = New System.Drawing.Point(466, 672)
        Me.Dtp_NgayNhap.Name = "Dtp_NgayNhap"
        Me.Dtp_NgayNhap.Size = New System.Drawing.Size(309, 22)
        Me.Dtp_NgayNhap.TabIndex = 25
        '
        'Txt_MaSach
        '
        Me.Txt_MaSach.Location = New System.Drawing.Point(466, 425)
        Me.Txt_MaSach.Name = "Txt_MaSach"
        Me.Txt_MaSach.ReadOnly = True
        Me.Txt_MaSach.Size = New System.Drawing.Size(309, 22)
        Me.Txt_MaSach.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(343, 425)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Mã Sách"
        '
        'Frm_QlSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 945)
        Me.Controls.Add(Me.Txt_MaSach)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Dtp_NgayNhap)
        Me.Controls.Add(Me.Btn_Xoa)
        Me.Controls.Add(Me.Btn_CapNhat)
        Me.Controls.Add(Me.CB_TenTacGiaCapNhat)
        Me.Controls.Add(Me.Cb_TheLoaiSachCapNhat)
        Me.Controls.Add(Me.Cb_TenTacGia)
        Me.Controls.Add(Me.Cb_TheLoaiSach)
        Me.Controls.Add(Me.Txt_TriGia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_NhaXuatBan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_NamXuatBan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_TenSach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dgv_ListSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_QlSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lí Sách"
        CType(Me.Dgv_ListSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Dgv_ListSach As DataGridView
    Friend WithEvents Txt_TenSach As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_NamXuatBan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_NhaXuatBan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_TriGia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Cb_TheLoaiSach As ComboBox
    Friend WithEvents Cb_TenTacGia As ComboBox
    Friend WithEvents Cb_TheLoaiSachCapNhat As ComboBox
    Friend WithEvents CB_TenTacGiaCapNhat As ComboBox
    Friend WithEvents Btn_CapNhat As Button
    Friend WithEvents Btn_Xoa As Button
    Friend WithEvents Dtp_NgayNhap As DateTimePicker
    Friend WithEvents Txt_MaSach As TextBox
    Friend WithEvents Label10 As Label
End Class
