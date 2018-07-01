Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_ThemLoaiDocGia

    Private ldgBus As LoaiDocGia_BUS
    Private qdBus As QuyDinh_BUS
    Dim frm_Infor = New Frm_Information()
    Private Sub Frm_LoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ldgBus = New LoaiDocGia_BUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = ldgBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            Txt_MaLoaiDocGia.Text = nextID.ToString()
        Else
            Frm_Information.m.Text = "Lấy ID kế tiếp của Loại Độc Giả không thành công."
            Frm_Information.ShowDialog()

            'MessageBox.Show("Lấy ID kế tiếp của Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_NhapVaDong_Click_1(sender As Object, e As EventArgs) Handles Btn_NhapVaDong.Click
        Dim ldg As LoaiDocGia_DTO
        ldg = New LoaiDocGia_DTO()

        Dim quydinh As QuyDinh_DTO
        quydinh = New QuyDinh_DTO()

        qdBus = New QuyDinh_BUS()

        '1. Mapping data from GUI control
        ldg.MaLoaiDocGia = Convert.ToInt32(Txt_MaLoaiDocGia.Text)
        ldg.TenLoaiDocGia = Txt_TenLoaiDocGia.Text

        '2. Business .....
        If (ldgBus.isValidName(ldg) = False) Then
            Frm_Information.m.Text = "Tên Loại Độc Giả không hợp lệ."
            Frm_Information.ShowDialog()
            Txt_TenLoaiDocGia.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = ldgBus.insert(ldg)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Thêm loại độc giả thành công."
            Frm_Information.ShowDialog()
            Me.Close()
        Else
            Frm_Information.m.Text = "Thêm Loại Độc Giả không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click

        Dim ldg As LoaiDocGia_DTO
        ldg = New LoaiDocGia_DTO()

        '1. Mapping data from GUI control
        ldg.MaLoaiDocGia = Convert.ToInt32(Txt_MaLoaiDocGia.Text)
        ldg.TenLoaiDocGia = Txt_TenLoaiDocGia.Text

        '2. Business .....
        If (ldgBus.isValidName(ldg) = False) Then
            Frm_Information.m.Text = "Tên Loại Độc Giả không hợp lệ."
            Frm_Information.ShowDialog()
            Txt_TenLoaiDocGia.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = ldgBus.insert(ldg)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Thêm loại độc giả thành công."
            Frm_Information.ShowDialog()
            Txt_TenLoaiDocGia.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = ldgBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                Txt_MaLoaiDocGia.Text = nextID.ToString()
            Else
                Frm_Information.m.Text = "Lấy ID kế tiếp của Loại độc giả không thành công."
                Frm_Information.ShowDialog()
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            Frm_Information.m.Text = "Thêm loại độc giả không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub Txt_TenLoaiDocGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TenLoaiDocGia.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
            Frm_Information.m.Text = "Vui lòng không nhập kí tự đặc biệt."
            Frm_Information.ShowDialog()
        End If
    End Sub
End Class