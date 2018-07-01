Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_TraCuuSach

    Private SachBUS As Sach_BUS

    Private Sub Frm_TraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SachBUS = New Sach_BUS()
    End Sub
    Private Sub Btn_TraCuu_Click(sender As Object, e As EventArgs) Handles Btn_TraCuu.Click
            Dim ChiTietSach As List(Of Sach_DTO)
            ChiTietSach = New List(Of Sach_DTO)
            Dim Result As Result
            Result = SachBUS.search_ByTen(Txt_TenSach.Text, ChiTietSach)
        If (Result.FlagResult = True) Then

            'Dgv_ListPhieuMuonSach.AutoGenerateColumns = False
            Dgv_ListTraCuu.Columns.Clear()
            Dgv_ListTraCuu.DataSource = Nothing

            Dgv_ListTraCuu.AutoGenerateColumns = False
            Dgv_ListTraCuu.AllowUserToAddRows = False
            Dgv_ListTraCuu.DataSource = ChiTietSach

            Dim Cl_MaSach1 = New DataGridViewTextBoxColumn()
            Cl_MaSach1.Name = "Cl_MaSach"
            Cl_MaSach1.HeaderText = "Mã Sách"
            Cl_MaSach1.DataPropertyName = "MaSach"
            Cl_MaSach1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListTraCuu.Columns.Add(Cl_MaSach1)


            Dim Cl_TenSach1 = New DataGridViewTextBoxColumn()
            Cl_TenSach1.Name = "Cl_TenSach"
            Cl_TenSach1.HeaderText = "Tên Sách"
            Cl_TenSach1.DataPropertyName = "TenSach"
            Cl_TenSach1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Dgv_ListTraCuu.Columns.Add(Cl_TenSach1)


            Dim Cl_TheLoaiSach1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TheLoaiSach1.Name = "Cl_TheLoaiSach"
            Cl_TheLoaiSach1.HeaderText = "Thể Loại"
            Cl_TheLoaiSach1.DataPropertyName = "TheLoai"
            Cl_TheLoaiSach1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListTraCuu.Columns.Add(Cl_TheLoaiSach1)

            Dim Cl_TenTacGia1 = New DataGridViewTextBoxColumn()
            Cl_TenTacGia1.Name = "Cl_TenTacGia"
            Cl_TenTacGia1.HeaderText = "Tên Tác Giả"
            Cl_TenTacGia1.DataPropertyName = "TenTacGia"
            Cl_TenTacGia1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dgv_ListTraCuu.Columns.Add(Cl_TenTacGia1)

            Dim Cl_TinhTrang1 = New DataGridViewTextBoxColumn()
            Cl_TinhTrang1.Name = "Cl_TinhTrang "
            Cl_TinhTrang1.HeaderText = "Tình Trạng"
            Cl_TinhTrang1.DataPropertyName = "TinhTrang"
            Cl_TinhTrang1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dgv_ListTraCuu.Columns.Add(Cl_TinhTrang1)


            Dim Cl_NgayDuKienTra = New DataGridViewTextBoxColumn()
            Cl_NgayDuKienTra.Name = "Cl_NgayDuKienTra "
            Cl_NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả"
            Cl_NgayDuKienTra.DataPropertyName = "NgayDuKien"
            Cl_NgayDuKienTra.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dgv_ListTraCuu.Columns.Add(Cl_NgayDuKienTra)



            For Each x As DataGridViewRow In Dgv_ListTraCuu.Rows

                If (Dgv_ListTraCuu.Rows(x.Index).Cells(4).Value = "Đang Mượn") Then
                    x.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next

        End If

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

End Class