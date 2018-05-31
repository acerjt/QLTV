Imports QLTV_BUS
Imports QLTV_DTO
Public Class Frm_QuyDinh

    Dim qdBus As QuyDinh_BUS
    Dim quydinh As QuyDinh_DTO

    Private Sub Frm_QuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New QuyDinh_BUS()
        quydinh = New QuyDinh_DTO()

        Dim listQuyDinh = New List(Of QuyDinh_DTO)
        Dim result = qdBus.selectALL(listQuyDinh)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        quydinh = listQuyDinh(0)
        Txt_TuoiToiThieu.Text = quydinh.TuoiToiThieu
        Txt_TuoiToiDa.Text = quydinh.TuoiToiDa
        Txt_ThoiGianSuDung.Text = quydinh.ThoiGianSuDung
        Txt_SoTheLoaiSachToiDa.Text = quydinh.SoTheLoaiSachToiDa
        Txt_Sotacgiatoida.Text = quydinh.SoTacGiaToiDa
        Txt_KhoangCachNamXuatBan.Text = quydinh.KhoangCachNamXuatBan
        Txt_Soluongsachmuontoida.Text = quydinh.SoLuongSachMuonToiDa
        Txt_SoNgayMuonToiDa.Text = quydinh.SoNgayMuonToiDa

    End Sub

    Private Sub Btn_CapNhat_Click(sender As Object, e As EventArgs) Handles Btn_CapNhap.Click
        Try
            quydinh.TuoiToiThieu = Integer.Parse(Txt_TuoiToiThieu.Text)
            quydinh.TuoiToiDa = Integer.Parse(Txt_TuoiToiDa.Text)
            quydinh.ThoiGianSuDung = Integer.Parse(Txt_ThoiGianSuDung.Text)
            quydinh.SoTheLoaiSachToiDa = Integer.Parse(Txt_SoTheLoaiSachToiDa.Text)
            quydinh.SoTacGiaToiDa = Integer.Parse(Txt_Sotacgiatoida.Text)
            quydinh.KhoangCachNamXuatBan = Integer.Parse(Txt_KhoangCachNamXuatBan.Text)
            quydinh.SoLuongSachMuonToiDa = Integer.Parse(Txt_Soluongsachmuontoida.Text)
            quydinh.SoNgayMuonToiDa = Integer.Parse(Txt_SoNgayMuonToiDa.Text)

            Dim result = qdBus.update(quydinh)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub





End Class


