Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_ThemSach

    Private SachBUS As Sach_BUS
    Private TheLoaiSachBUS As TheLoaiSach_BUS
    Private TacGiaBUS As TacGia_BUS
    Private QuyDinhBUS As QuyDinh_BUS
    Private Sub Frm_ThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SachBUS = New Sach_BUS()
        TheLoaiSachBUS = New TheLoaiSach_BUS()
        TacGiaBUS = New TacGia_BUS()
        QuyDinhBUS = New QuyDinh_BUS()
        ' Load LoaiHocSinh list


        Dim listTheLoaiSach = New List(Of TheLoaiSach_DTO)
        Dim result As Result
        result = TheLoaiSachBUS.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cb_Theloai.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cb_Theloai.DisplayMember = "TenTheLoaiSach"
        Cb_Theloai.ValueMember = "MaTheLoaiSach"



        Dim listTacGia = New List(Of TacGia_DTO)
        'Dim result1 As Result
        result = TacGiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cb_TenTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        Cb_TenTacGia.DisplayMember = "TenTacGia"
        Cb_TenTacGia.ValueMember = "MaTacGia"

        'set MSSH auto
        Dim nextMaSach = "1"
        result = SachBUS.buildMaSach(nextMaSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaSach.Text = nextMaSach

    End Sub

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click
        Dim Sach As Sach_DTO
        Sach = New Sach_DTO()

        Dim quydinh As QuyDinh_DTO
        quydinh = New QuyDinh_DTO()

        '1. Mapping data from GUI control
        Sach.MaSach = Txt_MaSach.Text
        Sach.TenSach = Txt_TenSach.Text
        Sach.NamXuatBan = Txt_NamXuatBan.Text
        Sach.NhaXuatBan = Txt_NhaXuatBan.Text
        Sach.NgayNhap = Dtp_NgayNhap.Value
        Sach.TheLoai = Convert.ToInt32(Cb_Theloai.SelectedValue)
        Sach.TenTacGia = Convert.ToInt32(Cb_TenTacGia.SelectedValue)
        Sach.TriGia = Txt_TriGia.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        QuyDinhBUS.GetQuyDinh(quydinh)

        If (SachBUS.isValidNamXuatBan(Sach, quydinh) = False) Then
            MessageBox.Show("Chỉ nhận sách có năm xuất bản theo quy định")
            Txt_NamXuatBan.Clear()
            Return
        End If

        If (SachBUS.isValidTacGia(Sach) = False) Then
            MessageBox.Show("Tác giả chưa có trong cơ sở dữ liệu")
            Cb_TenTacGia.Focus()
            Return
        End If
        If (SachBUS.isValidTheLoai(Sach) = False) Then
            MessageBox.Show("Thể loại không hợp lệ")
            Cb_Theloai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = SachBUS.insert(Sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaSach = "1"
            result = SachBUS.buildMaSach(nextMaSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaSach.Text = nextMaSach
            Txt_TenSach.Text = String.Empty
            Txt_NamXuatBan.Text = String.Empty
            Txt_NhaXuatBan.Text = String.Empty
            Txt_TriGia.Text = String.Empty
        Else
            MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub Btn_NhapVaDong_Click(sender As Object, e As EventArgs) Handles Btn_NhapVaDong.Click
        Dim Sach As Sach_DTO
        Sach = New Sach_DTO()

        Dim quydinh As QuyDinh_DTO
        quydinh = New QuyDinh_DTO()

        '1. Mapping data from GUI control
        Sach.MaSach = Txt_MaSach.Text
        Sach.TenSach = Txt_TenSach.Text
        Sach.NamXuatBan = Txt_NamXuatBan.Text
        Sach.NhaXuatBan = Txt_NhaXuatBan.Text
        Sach.NgayNhap = Dtp_NgayNhap.Value
        Sach.TheLoai = Convert.ToInt32(Cb_Theloai.SelectedValue)
        Sach.TenTacGia = Convert.ToInt32(Cb_TenTacGia.SelectedValue)
        Sach.TriGia = Txt_TriGia.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        QuyDinhBUS.GetQuyDinh(quydinh)

        If (SachBUS.isValidNamXuatBan(Sach, quydinh) = False) Then
            MessageBox.Show("Chỉ nhận sách có năm xuất bản theo quy định")
            Txt_NamXuatBan.Clear()
            Return
        End If

        If (SachBUS.isValidTacGia(Sach) = False) Then
            MessageBox.Show("Tác giả chưa có trong cơ sở dữ liệu")
            Cb_TenTacGia.Focus()
            Return
        End If
        If (SachBUS.isValidTheLoai(Sach) = False) Then
            MessageBox.Show("Thể loại không hợp lệ")
            Cb_Theloai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = SachBUS.insert(Sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    'Check keypress letter
    Private Function Check_KeyPress_letter(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then

            e.Handled = True
            MessageBox.Show("Vui lòng không nhập kí tự đặc biệt, kí tự số.")
        End If
        Return 0
    End Function
    Private Sub TxtTenSach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TenSach.KeyPress
        Check_KeyPress_letter(sender, e)
    End Sub

    Private Sub Txt_NhaXuatBan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NhaXuatBan.KeyPress
        Check_KeyPress_letter(sender, e)
    End Sub

    ' check Key Press number
    Private Function Check_KeyPress_number(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If (Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then

            e.Handled = True
            MessageBox.Show("Vui lòng nhập số.")
        End If
        Return 0
    End Function
    Private Sub Txt_NamXuatBan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NamXuatBan.KeyPress
        Check_KeyPress_number(sender, e)
    End Sub

    Private Sub Txt_TriGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TriGia.KeyPress
        Check_KeyPress_number(sender, e)
    End Sub


End Class