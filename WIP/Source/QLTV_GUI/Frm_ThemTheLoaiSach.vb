Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_ThemTheLoaiSach

    Private TheLoaiSachBUS As TheLoaiSach_BUS
    Private qdBus As QuyDinh_BUS
    Dim frm_Infor = New Frm_Information()
    Private Sub Frm_ThemTheLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TheLoaiSachBUS = New TheLoaiSach_BUS()
        qdBus = New QuyDinh_BUS()
        Dim Result As Result

        Dim nextMaTheLoaisach = "1"
        Result = TheLoaiSachBUS.getNextID(nextMaTheLoaisach)
        If (Result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy danh tự động mã thể loại sách không thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Lấy danh tự động mã thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaTheLoaiSach.Text = nextMaTheLoaisach
    End Sub

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click
        Dim TheLoaiSach As TheLoaiSach_DTO
        TheLoaiSach = New TheLoaiSach_DTO()

        Dim QuyDinh As QuyDinh_DTO
        QuyDinh = New QuyDinh_DTO()


        '1. Mapping data from GUI control
        TheLoaiSach.MaTheLoaiSach = Txt_MaTheLoaiSach.Text
        TheLoaiSach.TenTheLoaiSach = Txt_TenTheLoaiSach.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        'Dim Count As Integer
        ' TheLoaiSachBUS.CountSoLuongTheLoai(Count)

        qdBus = New QuyDinh_BUS()
        Dim result As Result
        result = qdBus.GetQuyDinh(QuyDinh)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy Quy Định từ database không thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("lấy quy định từ database không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        If (TheLoaiSachBUS.isValidName(TheLoaiSach) = False) Then
            Frm_Information.m.Text = "Tên Thể Loại Sách không đúng."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Tên Thể Loại Sách không đúng")
            Txt_TenTheLoaiSach.Focus()
            Return
        End If

        If (TheLoaiSachBUS.isValidInSertTheLoaiSach(TheLoaiSach, QuyDinh) = False) Then
            Frm_Information.m.Text = "Đã đủ Thể Loại Sách qui định."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Đã đủ Thể Loại Sách qui định")
            Txt_TenTheLoaiSach.Clear()
            'Me.Close()
            Return
        End If
        '3. Insert to DB
        'Dim result As Result
        result = TheLoaiSachBUS.insert(TheLoaiSach)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Thêm Thể Loại Sách thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Thêm Thể Loại Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaTheLoaiSach = "1"
            result = TheLoaiSachBUS.getNextID(nextMaTheLoaiSach)
            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Lấy danh tự động mã Thể Loại Sách không thành công."
                Frm_Information.ShowDialog()
                'MessageBox.Show("Lấy danh tự động mã Thể Loại Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaTheLoaiSach.Text = nextMaTheLoaiSach
            Txt_TenTheLoaiSach.Text = String.Empty
        Else
            Frm_Information.m.Text = "Thêm Thể Loại Sách không thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Thêm Thể Loại Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_NhapVaDong_Click(sender As Object, e As EventArgs) Handles Btn_NhapVaDong.Click
        Dim TheLoaiSach As TheLoaiSach_DTO
        TheLoaiSach = New TheLoaiSach_DTO()

        Dim QuyDinh As QuyDinh_DTO
        QuyDinh = New QuyDinh_DTO()


        '1. Mapping data from GUI control
        TheLoaiSach.MaTheLoaiSach = Txt_MaTheLoaiSach.Text
        TheLoaiSach.TenTheLoaiSach = Txt_TenTheLoaiSach.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        'Dim Count As Integer
        ' TheLoaiSachBUS.CountSoLuongTheLoai(Count)

        qdBus = New QuyDinh_BUS()
        Dim result As Result
        result = qdBus.GetQuyDinh(QuyDinh)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy Quy Định từ database không thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("lấy quy định từ database không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        If (TheLoaiSachBUS.isValidName(TheLoaiSach) = False) Then
            Frm_Information.m.Text = "Tên Thể Loại Sách không đúng."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Tên Thể Loại Sách không đúng")
            Txt_TenTheLoaiSach.Focus()
            Return
        End If

        If (TheLoaiSachBUS.isValidInSertTheLoaiSach(TheLoaiSach, QuyDinh) = False) Then
            Frm_Information.m.Text = "Đã đủ Thể Loại Sách theo qui định."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Đã đủ Thể Loại Sách theo qui định")
            Txt_TenTheLoaiSach.Clear()
            Return
        End If
        '3. Insert to DB
        'Dim result As Result
        result = TheLoaiSachBUS.insert(TheLoaiSach)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Thêm Thể Loại Sách thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Thêm Thể Loại Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            Frm_Information.m.Text = "Thêm Thể Loại Sách không thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Thêm Thể Loại Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub TxtTenTheLoaiSach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TenTheLoaiSach.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then

            e.Handled = True
            Frm_Information.m.Text = "Vui lòng không nhập kí tự đặc biệt."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Vui lòng không nhập kí tự đặc biệt, kí tự số.")
        End If
    End Sub
End Class
