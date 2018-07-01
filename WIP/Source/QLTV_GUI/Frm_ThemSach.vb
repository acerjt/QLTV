Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_ThemSach


    Private SachBUS As Sach_BUS
    Private TheLoaiSachBUS As TheLoaiSach_BUS
    Private TacGiaBUS As TacGia_BUS
    Private QuyDinhBUS As QuyDinh_BUS
    Private listSach As List(Of Sach_DTO)
    Dim frm_Infor = New Frm_Information()


    Private Sub Frm_ThemListSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SachBUS = New Sach_BUS()
        TheLoaiSachBUS = New TheLoaiSach_BUS()
        TacGiaBUS = New TacGia_BUS()
        QuyDinhBUS = New QuyDinh_BUS()
        listSach = New List(Of Sach_DTO)

        Dim listTheLoaiSach = New List(Of TheLoaiSach_DTO)
        Dim result As Result
        result = TheLoaiSachBUS.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy danh sách Thể Loại Sách không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cl_TheLoaiSach.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cl_TheLoaiSach.DisplayMember = "TenTheLoaiSach"
        Cl_TheLoaiSach.ValueMember = "MaTheLoaiSach"

        Dtp_NgayNhap.Value = DateTime.Now

        Dim listTacGia = New List(Of TacGia_DTO)
        'Dim result1 As Result
        result = TacGiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy danh sách Tác Giả không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cl_TacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        Cl_TacGia.DisplayMember = "TenTacGia"
        Cl_TacGia.ValueMember = "MaTacGia"

        'set MSSH auto
        Dim nextMaSach = "1"
        result = SachBUS.buildMaSach(nextMaSach)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy tự động mã sách không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        Dgv_ThemListSach.Rows(0).Cells(0).Value = nextMaSach
    End Sub

    Private Sub Dgv_ThemListSach_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ThemListSach.RowEnter
        If (e.RowIndex > 0) Then
            Dgv_ThemListSach.Rows(e.RowIndex).Cells(0).Value = Dgv_ThemListSach.Rows(e.RowIndex - 1).Cells(0).Value + 1

        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click
        Dim r = Dgv_ThemListSach.Rows.Count
        Dim quydinh As QuyDinh_DTO
        quydinh = New QuyDinh_DTO()
        Dim Sach As Sach_DTO

        For Each x As DataGridViewRow In Dgv_ThemListSach.Rows
            If x.Index = Dgv_ThemListSach.Rows.Count - 1 Then
                Exit For
            End If
            Sach = New Sach_DTO
            Sach.MaSach = Dgv_ThemListSach.Rows(x.Index).Cells(0).Value
            Sach.TenSach = Dgv_ThemListSach.Rows(x.Index).Cells(1).Value
            Sach.TheLoai = Dgv_ThemListSach.Rows(x.Index).Cells(2).Value
            Sach.TenTacGia = Dgv_ThemListSach.Rows(x.Index).Cells(3).Value
            Sach.NamXuatBan = Dgv_ThemListSach.Rows(x.Index).Cells(4).Value
            Sach.NhaXuatBan = Dgv_ThemListSach.Rows(x.Index).Cells(5).Value
            Sach.NgayNhap = Dtp_NgayNhap.Value
            Sach.TriGia = Dgv_ThemListSach.Rows(x.Index).Cells(6).Value
            Sach.TinhTrang = " "

            If (Sach.TenSach = "") Then
                Frm_Information.m.Text = "Tên Sách không được trống."
                Frm_Information.ShowDialog()
                Return
            End If

            If (SachBUS.isValidTenSach(Sach) = False) Then
                Frm_Information.m.Text = "Tên Sách không hợp lệ."
                Frm_Information.ShowDialog()
                Return
            End If
            If (SachBUS.isValidTheLoai(Sach) = False) Then
                Frm_Information.m.Text = "Thể loại không hợp lệ."
                Frm_Information.ShowDialog()
                Return
            End If


            If (SachBUS.isValidTacGia(Sach) = False) Then
                Frm_Information.m.Text = "Tác giả chưa có trong cơ sở dữ liệu."
                Frm_Information.ShowDialog()
                Return
            End If
            QuyDinhBUS.GetQuyDinh(quydinh)
            If (SachBUS.isValidNamXuatBan(Sach, quydinh) = False) Then
                Frm_Information.m.Text = "Chỉ nhận sách có Năm Xuất Bản theo quy định."
                Frm_Information.ShowDialog()
                Return
            End If


            listSach.Add(Sach)
        Next
        If Dgv_ThemListSach.Rows.Count = 1 Then
            Frm_Information.m.Text = "Tên Sách không được trống."
            Frm_Information.ShowDialog()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = SachBUS.insert1(listSach)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Thêm Sách thành công."
            Frm_Information.ShowDialog()
            Dgv_ThemListSach.Rows.Clear()
            'set MSSH auto
            Dim nextMaSach = "1"
            result = SachBUS.buildMaSach(nextMaSach)


            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Lấy tự động Mã Sách không thành công."
                Frm_Information.ShowDialog()
                Me.Close()
                Return
            Else
                Dgv_ThemListSach.Rows(0).Cells(0).Value = nextMaSach
                listSach.Clear()
            End If

        Else
            Frm_Information.m.Text = "Thêm Sách không thành công."
            listSach.Clear()
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If


    End Sub

    Private Sub Dgv_ThemListSach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Dgv_ThemListSach.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
            Frm_Information.m.Text = "Vui lòng không nhập kí tự đặc biệt."
            Frm_Information.ShowDialog()
        End If
    End Sub


End Class