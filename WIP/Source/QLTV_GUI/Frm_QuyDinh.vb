Imports QLTV_BUS
Imports QLTV_DTO
Public Class Frm_QuyDinh
    Dim qdBus As QuyDinhBUS
    Dim quydinh As QuyDinhDTO

    Private Sub Frm_QuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New QuyDinhBUS()
        Dim listQuyDinh = New List(Of QuyDinhDTO)
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
    End Sub

    Private Sub Btn_CapNhat_Click(sender As Object, e As EventArgs) Handles Btn_CapNhap.Click
        Try
            quydinh.TuoiToiThieu = Integer.Parse(Txt_TuoiToiThieu.Text)
            quydinh.TuoiToiDa = Integer.Parse(Txt_TuoiToiDa.Text)
            quydinh.ThoiGianSuDung = Integer.Parse(Txt_ThoiGianSuDung.Text)
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