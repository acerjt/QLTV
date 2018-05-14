Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_ThemDocGia


    Private dgBus As DocGiaBUS
    Private ldgBus As LoaiDocGia_BUS
    Private qd As QuyDinhBUS


    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click

        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        'get thamso từ database
        Dim quydinh As QuyDinhDTO
        quydinh = New QuyDinhDTO()
        Dim qd As QuyDinhBUS
        qd = New QuyDinhBUS()

        Dim GetTuoiToiDa = 0
        Dim GetTuoiToiThieu = 0
        Dim GetThoiGianSuDung = 0

        ' lấy tham số từ database
        Dim result1 As Result
        result1 = qd.GetQuyDinh(GetTuoiToiThieu, GetTuoiToiDa, GetThoiGianSuDung)
        If (result1.FlagResult = False) Then
            MessageBox.Show("lấy tham số từ database không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        quydinh.TuoiToiThieu = GetTuoiToiThieu
        quydinh.TuoiToiDa = GetTuoiToiDa
        quydinh.ThoiGianSuDung = GetThoiGianSuDung
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
            MessageBox.Show("Họ tên độc giả không đúng")
            Txt_HoVaTen.Focus()
            Return
        End If

        If (dgBus.isValidAge(docgia, quydinh) = False) Then
            MessageBox.Show("Tuổi Độc Giả không hợp lệ")
            Dtp_NgaySinh.Focus()
            Return
        End If


        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Độc Giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set Madocgia auto
            Dim nextMaDocGia = "1"
            result = dgBus.buildMaDocGia(nextMaDocGia)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaDocGia.Text = nextMaDocGia
            Txt_DiaChi.Text = String.Empty
            Txt_HoVaTen.Text = String.Empty

        Else
            MessageBox.Show("Thêm Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub Frm_ThemDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgBus = New DocGiaBUS()
        ldgBus = New LoaiDocGia_BUS()

        ' Load LoaiDocGia list
        Dim listLoaiDocGia = New List(Of LoaiDocGia_DTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cb_LoaiDocGia.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        Cb_LoaiDocGia.DisplayMember = "TenLoaiDocGia"
        Cb_LoaiDocGia.ValueMember = "MaLoaiDocGia"

        'set MaDocgIA auto
        Dim nextMaDocGia = "1"
        result = dgBus.buildMaDocGia(nextMaDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaDocGia.Text = nextMaDocGia


    End Sub
    Private Sub Btn_NhapVaDong_Click(sender As Object, e As EventArgs) Handles Btn_NhapVaDong.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()
        Dim quydinh As QuyDinhDTO
        quydinh = New QuyDinhDTO()

        'lấy tham số từ database
        Dim qd As QuyDinhBUS
        qd = New QuyDinhBUS()

        Dim GetTuoiToiDa = 0
        Dim GetTuoiToiThieu = 0
        Dim GetThoiGianSuDung = 0
        Dim result As Result
        result = qd.GetQuyDinh(GetTuoiToiThieu, GetTuoiToiDa, GetThoiGianSuDung)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        quydinh.TuoiToiThieu = GetTuoiToiThieu
        quydinh.TuoiToiDa = GetTuoiToiDa
        quydinh.ThoiGianSuDung = GetThoiGianSuDung

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
            MessageBox.Show("Họ tên Độc Gỉa không đúng")
            Txt_HoVaTen.Focus()
            Return
        End If

        If (dgBus.isValidAge(docgia, quydinh) = False) Then
            MessageBox.Show("Tuổi Độc Giả không hợp lệ")
            Dtp_NgaySinh.Focus()
            Return
        End If
        '3. Insert to DB
        'Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Độc Gỉa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub


End Class