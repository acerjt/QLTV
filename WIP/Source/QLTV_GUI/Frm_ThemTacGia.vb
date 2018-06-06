Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_ThemTacGia


    Private TacGiaBUS As TacGia_BUS
    Private qdBus As QuyDinh_BUS
    Private Sub Frm_ThemTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TacGiaBUS = New TacGia_BUS()

        Dim Result As Result

        Dim nextMaTacGia = "1"
        Result = TacGiaBUS.buildMaTacGia(nextMaTacGia)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("lấy quy định từ database không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        '1. Mapping data from GUI control
        TacGia.TenTacGia = Txt_TenTacGia.Text
        TacGia.MaTacGia = Txt_MaTacGia.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        If (TacGiaBUS.isValidInsertTacGia(TacGia, quydinh) = False) Then
            MessageBox.Show("Đã đủ số tác giả quy định")
            ' Me.Close()
            Return
        End If
        '3. Insert to DB
        ' Dim result As Result
        result = TacGiaBUS.insert(TacGia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaTacGia = "1"
            result = TacGiaBUS.buildMaTacGia(nextMaTacGia)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaTacGia.Text = nextMaTacGia
            Txt_TenTacGia.Text = String.Empty
        Else
            MessageBox.Show("Thêm tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("lấy quy định từ database không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            'Me.Close()
            Return
        End If

        '1. Mapping data from GUI control
        TacGia.TenTacGia = Txt_TenTacGia.Text
        TacGia.MaTacGia = Txt_MaTacGia.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        If (TacGiaBUS.isValidInsertTacGia(TacGia, quydinh) = False) Then
            MessageBox.Show("Đã đủ số tác giả quy định")
            Me.Close()
            Return
        End If
        '3. Insert to DB
        'Dim result As Result
        result = TacGiaBUS.insert(TacGia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub Txt_TenTacGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TenTacGia.KeyPress
        'Dim a = {"W", "F", "z", "Z", "J"}
        'For Each x As Char In a
        '    If (e.KeyChar = x) Then
        '        e.Handled = True
        '        MessageBox.Show("Kí Tự Không Hợp Lệ.")
        '    End If
        'Next
        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then

            e.Handled = True
            MessageBox.Show("Vui lòng không nhập kí tự đặc biệt.")
        End If
    End Sub
End Class