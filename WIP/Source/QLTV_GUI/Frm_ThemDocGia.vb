Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_ThemDocGia

    Private dgBus As DocGia_BUS
    Private ldgBus As LoaiDocGia_BUS
    Private qd As QuyDinh_BUS
    Dim frm_Infor = New Frm_Information()

    Private Sub Frm_ThemDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgBus = New DocGia_BUS()
        ldgBus = New LoaiDocGia_BUS()

        ' Load LoaiDocGia list
        Dim listLoaiDocGia = New List(Of LoaiDocGia_DTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy danh sách loại độc giả không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        Dtp_NgayLap.Value = DateTime.Now
        Dtp_NgaySinh.Value = DateTime.Now

        Cb_LoaiDocGia.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        Cb_LoaiDocGia.DisplayMember = "TenLoaiDocGia"
        Cb_LoaiDocGia.ValueMember = "MaLoaiDocGia"

        'set MaDocgIA auto
        Dim nextMaDocGia = "1"
        result = dgBus.buildMaDocGia(nextMaDocGia)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy tự động Mã Độc Giả không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaDocGia.Text = nextMaDocGia


    End Sub
    Private Sub Btn_NhapVaDong_Click(sender As Object, e As EventArgs) Handles Btn_NhapVaDong.Click
        Dim docgia As DocGia_DTO
        docgia = New DocGia_DTO()
        Dim quydinh As QuyDinh_DTO
        quydinh = New QuyDinh_DTO()

        'lấy tham số từ database
        Dim qd As QuyDinh_BUS
        qd = New QuyDinh_BUS()


        Dim result As Result
        result = qd.GetQuyDinh(quydinh)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy Quy Định không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If


        '1. Mapping data from GUI control
        docgia.MaDocGia = Txt_MaDocGia.Text
        docgia.HoVaTen = Txt_HoVaTen.Text
        docgia.LoaiDocGia = Convert.ToInt32(Cb_LoaiDocGia.SelectedValue)
        docgia.NgaySinh = Dtp_NgaySinh.Value
        docgia.DiaChi = Txt_DiaChi.Text
        docgia.Email = Txt_Email.Text
        docgia.NgayLap = Dtp_NgayLap.Value
        docgia.NgayHetHan = docgia.NgayLap.AddMonths(quydinh.ThoiGianSuDung)

        '2. Business .....
        If (dgBus.isValidName(docgia) = False) Then
            Frm_Information.m.Text = "Tên Độc Giả không hợp lệ."
            Frm_Information.ShowDialog()
            Txt_HoVaTen.Focus()
            Return
        End If

        If (dgBus.isValidAge(docgia, quydinh) = False) Then
            Frm_Information.m.Text = "Tuổi Độc Giả không hợp lệ."
            Frm_Information.ShowDialog()
            Dtp_NgaySinh.Focus()
            Return
        End If
        '3. Insert to DB
        'Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Thêm Độc Giả thành công!"
            Frm_Information.ShowDialog()
            Me.Close()
        Else
            Frm_Information.m.Text = "Thêm Độc Giả không thành công!"
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Nhap_Click_1(sender As Object, e As EventArgs) Handles Btn_Nhap.Click

        Dim docgia As DocGia_DTO
        docgia = New DocGia_DTO()

        'get thamso từ database
        Dim quydinh As QuyDinh_DTO
        quydinh = New QuyDinh_DTO()

        qd = New QuyDinh_BUS()

        ' lấy tham số từ database
        Dim result As Result
        result = qd.GetQuyDinh(quydinh)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy Quy Định không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        '1. Mapping data from GUI control
        docgia.MaDocGia = Txt_MaDocGia.Text
        docgia.HoVaTen = Txt_HoVaTen.Text
        docgia.LoaiDocGia = Convert.ToInt32(Cb_LoaiDocGia.SelectedValue)
        docgia.NgaySinh = Dtp_NgaySinh.Value
        docgia.DiaChi = Txt_DiaChi.Text
        docgia.Email = Txt_Email.Text
        docgia.NgayLap = Dtp_NgayLap.Value
        docgia.NgayHetHan = docgia.NgayLap.AddMonths(quydinh.ThoiGianSuDung) '.ToString


        '2. Business .....
        If (dgBus.isValidName(docgia) = False) Then
            Frm_Information.m.Text = "Tên Độc Giả không hợp lệ."
            Frm_Information.ShowDialog()
            Txt_HoVaTen.Focus()
            Return
        End If

        If (dgBus.isValidAge(docgia, quydinh) = False) Then
            Frm_Information.m.Text = "Tuôi Độc Giả không hợp lệ."
            Frm_Information.ShowDialog()
            Dtp_NgaySinh.Focus()
            Return
        End If

        '3. Insert to DB

        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            frm_Infor.m.Text = "Thêm Độc Giả thành công."
            frm_Infor.ShowDialog()
            Dim nextMaDocGia = "1"
            result = dgBus.buildMaDocGia(nextMaDocGia)
            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Lấy tự động Mã Độc Giả không thành công."
                Frm_Information.ShowDialog()
                Me.Close()
                Return
            End If
            Txt_MaDocGia.Text = nextMaDocGia
            Txt_DiaChi.Text = String.Empty
            Txt_HoVaTen.Text = String.Empty

        Else
            frm_Infor.m.Text = "Thêm Độc Giả không thành công."
            frm_Infor.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub


    Private Sub TxtHovaTen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_HoVaTen.KeyPress

        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
            frm_Infor.m.Text = "Vui lòng không nhập kí tự đặc biệt."
            frm_Infor.ShowDialog()

        End If
    End Sub
End Class
