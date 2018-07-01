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
            Frm_Information.m.Text = "Lấy thông tin Quy Định không thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        quydinh = listQuyDinh(0)
        Txt_TuoiToiThieu.Text = quydinh.TuoiToiThieu
        Txt_TuoiToiDa.Text = quydinh.TuoiToiDa
        Txt_ThoiGianSuDung.Text = quydinh.ThoiGianSuDung
        Txt_SoTheLoaiSachToiDa.Text = quydinh.SoTheLoaiSachToiDa
        Txt_SoTacGiaToiDa.Text = quydinh.SoTacGiaToiDa
        Txt_KhoangCachNamXuatBan.Text = quydinh.KhoangCachNamXuatBan
        Txt_SoLuongSachMuonToiDa.Text = quydinh.SoLuongSachMuonToiDa
        Txt_SoNgayMuonToiDa.Text = quydinh.SoNgayMuonToiDa

    End Sub

    Private Sub Btn_CapNhat_Click(sender As Object, e As EventArgs) Handles Btn_CapNhap.Click
        Try
            quydinh.TuoiToiThieu = Integer.Parse(Txt_TuoiToiThieu.Text)
            quydinh.TuoiToiDa = Integer.Parse(Txt_TuoiToiDa.Text)
            quydinh.ThoiGianSuDung = Integer.Parse(Txt_ThoiGianSuDung.Text)
            quydinh.SoTheLoaiSachToiDa = Integer.Parse(Txt_SoTheLoaiSachToiDa.Text)
            quydinh.SoTacGiaToiDa = Integer.Parse(Txt_SoTacGiaToiDa.Text)
            quydinh.KhoangCachNamXuatBan = Integer.Parse(Txt_KhoangCachNamXuatBan.Text)
            quydinh.SoLuongSachMuonToiDa = Integer.Parse(Txt_SoLuongSachMuonToiDa.Text)
            quydinh.SoNgayMuonToiDa = Integer.Parse(Txt_SoNgayMuonToiDa.Text)

            Dim result = qdBus.update(quydinh)
            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Cập nhật Quy Định không thành công."
                Frm_Information.ShowDialog()
                'MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            Frm_Information.m.Text = "Cập nhật Quy Định thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub


#Region "Kiểm tra điều kiện nhập"
    Private Function check(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
            Frm_Information.m.Text = "Vui lòng chỉ nhập kí tự số."
            Frm_Information.ShowDialog()
        End If
        Return 0
    End Function
    Private Sub Txt_ThoiGianSuDung_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ThoiGianSuDung.KeyPress
        check(sender, e)
    End Sub

    Private Sub Txt_KhoangCachNamXuatBan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_KhoangCachNamXuatBan.KeyPress
        check(sender, e)
    End Sub


    Private Sub Txt_TuoiToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TuoiToiDa.KeyPress
        check(sender, e)
    End Sub

    Private Sub Txt_TuoiToiThieu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TuoiToiThieu.KeyPress
        check(sender, e)
    End Sub


    Private Sub Txt_SoLuongSachMuonToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SoLuongSachMuonToiDa.KeyPress
        check(sender, e)
    End Sub

    Private Sub Txt_SoNgayMuonToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SoNgayMuonToiDa.KeyPress
        check(sender, e)
    End Sub
    Private Sub Txt_SoTacGiaToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SoTacGiaToiDa.KeyPress
        check(sender, e)
    End Sub

    Private Sub Txt_SoTheLoaiSachToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SoTheLoaiSachToiDa.KeyPress
        check(sender, e)
    End Sub

#End Region

End Class


