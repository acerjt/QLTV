Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_ThemTacGia


    Private TacGiaBUS As TacGia_BUS
    Private qdBus As QuyDinh_BUS
    Dim frm_Infor = New Frm_Information()
    Private Sub Frm_ThemTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TacGiaBUS = New TacGia_BUS()

        Dim Result As Result

        Dim nextMaTacGia = "1"
        Result = TacGiaBUS.buildMaTacGia(nextMaTacGia)
        If (Result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy tự động mã sách không thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Lấy tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaTacGia.Text = nextMaTacGia
    End Sub

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click

        Dim TacGia As TacGia_DTO
        TacGia = New TacGia_DTO()

        Dim quydinh As QuyDinh_DTO
        quydinh = New QuyDinh_DTO()

        qdBus = New QuyDinh_BUS()
        Dim result As Result
        result = qdBus.GetQuyDinh(quydinh)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy Quy Định từ database không thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("lấy quy định từ database không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        '1. Mapping data from GUI control
        TacGia.TenTacGia = Txt_TenTacGia.Text
        TacGia.MaTacGia = Txt_MaTacGia.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        If (TacGiaBUS.isValidTenTacGia(TacGia) = False) Then
            Frm_Information.m.Text = "Tên Tác Giả không hợp lệ"
            Frm_Information.ShowDialog()

            Return
        End If
        If (TacGiaBUS.isValidInsertTacGia(TacGia, quydinh) = False) Then
            Frm_Information.m.Text = "Đã đủ số tác giả quy định."
            Frm_Information.ShowDialog()

            Return
        End If
        '3. Insert to DB
        ' Dim result As Result
        result = TacGiaBUS.insert(TacGia)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Thêm tác giả thành công."
            Frm_Information.ShowDialog()
            'set MSSH auto
            Dim nextMaTacGia = "1"
            result = TacGiaBUS.buildMaTacGia(nextMaTacGia)
            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Lấy tự động mã tác giả không thành công."
                Frm_Information.ShowDialog()
                Me.Close()
                Return
            End If
            Txt_MaTacGia.Text = nextMaTacGia
            Txt_TenTacGia.Text = String.Empty
        Else
            Frm_Information.m.Text = "Thêm tác giả không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_NhapVaDong_Click(sender As Object, e As EventArgs) Handles Btn_NhapVaDong.Click
        Dim TacGia As TacGia_DTO
        TacGia = New TacGia_DTO()

        Dim quydinh As QuyDinh_DTO
        quydinh = New QuyDinh_DTO()

        qdBus = New QuyDinh_BUS()
        Dim result As Result
        result = qdBus.GetQuyDinh(quydinh)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy Quy Định từ database không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        '1. Mapping data from GUI control
        TacGia.TenTacGia = Txt_TenTacGia.Text
        TacGia.MaTacGia = Txt_MaTacGia.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        If (TacGiaBUS.isValidTenTacGia(TacGia) = False) Then
            Frm_Information.m.Text = "Tên Tác Giả không hợp lệ"
            Frm_Information.ShowDialog()

            Return
        End If
        If (TacGiaBUS.isValidInsertTacGia(TacGia, quydinh) = False) Then
            Frm_Information.m.Text = "Đã đủ số Tác Giả quy định."
            Frm_Information.ShowDialog()
            Me.Close()
            Return
        End If
        '3. Insert to DB
        'Dim result As Result
        result = TacGiaBUS.insert(TacGia)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Thêm Tác Giả thành công."
            Frm_Information.ShowDialog()
            Me.Close()
        Else
            Frm_Information.m.Text = "Thêm Tác Giả thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub Txt_TenTacGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TenTacGia.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then

            e.Handled = True
            Frm_Information.m.Text = "Vui lòng không nhập kí tự đặc biệt."
            Frm_Information.ShowDialog()
        End If
    End Sub
End Class