Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility


Public Class Frm_ThemListSach
    Private SachBUS As Sach_BUS
    Private TheLoaiSachBUS As TheLoaiSach_BUS
    Private TacGiaBUS As TacGia_BUS
    Private QuyDinhBUS As QuyDinh_BUS
    Private listSach As List(Of Sach_DTO)

    'Private dtp As DateTimePicker
    'Private rect As Rectangle
    Private Sub Frm_ThemListSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SachBUS = New Sach_BUS()
        TheLoaiSachBUS = New TheLoaiSach_BUS()
        TacGiaBUS = New TacGia_BUS()
        QuyDinhBUS = New QuyDinh_BUS()
        listSach = New List(Of Sach_DTO)
        'dtp = New DateTimePicker()
        'BunifuCustomDataGrid1.Controls.Add(dtp)
        'dtp.Visible = False
        'dtp.Format = DateTimePickerFormat.Custom
        'dtp.TextChanged += New EventHandler(dtp_TextChange)

        'dtp


        Dim listTheLoaiSach = New List(Of TheLoaiSach_DTO)
        Dim result As Result
        result = TheLoaiSachBUS.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cl_TheLoaiSach.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cl_TheLoaiSach.DisplayMember = "TenTheLoaiSach"
        Cl_TheLoaiSach.ValueMember = "MaTheLoaiSach"



        Dim listTacGia = New List(Of TacGia_DTO)
        'Dim result1 As Result
        result = TacGiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cl_TacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        Cl_TacGia.DisplayMember = "TenTacGia"
        Cl_TacGia.ValueMember = "MaTacGia"

        'set MSSH auto
        Dim nextMaSach = "1"
        result = SachBUS.buildMaSach(nextMaSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        BunifuCustomDataGrid1.Rows(0).Cells(0).Value = nextMaSach

        'Dim dt = New DataTable()
        'dt.Columns.Add("Date", GetType(DateTime))
        'dt.Rows.Add(DateTime.Now)
        'dt.Rows.Add(DateTime.Now)
        'Cl_NamXuatBan.DefaultCellStyle.Format = "yyyy/MM/dd h:mm:ss tt"

        'BunifuCustomDataGrid1.DataSource = dt
        'DateTimePicker1.DataBindings.Add(New Binding("Value", BunifuCustomDataGrid1, "Cl_NgayNhap"))




    End Sub

    Private Sub BunifuCustomDataGrid1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.RowEnter

        If (e.RowIndex > 0) Then
            '    Dim MaSach = BunifuCustomDataGrid1.Item("Cl_MaSach", e.RowIndex - 1).Value
            '    Dim TenSach = BunifuCustomDataGrid1.Item("Cl_TenSach", e.RowIndex - 1).Value
            '    Dim TheLoai = BunifuCustomDataGrid1.Item("Cl_TheLoaiSach", e.RowIndex - 1).Value
            '    Dim TacGia = BunifuCustomDataGrid1.Item("Cl_TacGia", e.RowIndex - 1).Value
            '    Dim NamXuatBan = BunifuCustomDataGrid1.Item("Cl_NamXuatBan", e.RowIndex - 1).Value
            '    Dim NhaXuatBan = BunifuCustomDataGrid1.Item("Cl_NhaXuatBan", e.RowIndex - 1).Value
            '    Dim TriGia = BunifuCustomDataGrid1.Item("Cl_TriGia", e.RowIndex - 1).Value
            '    Dim TinhTrang = ""
            '    Dim NgayNhap As DateTime = MetroDateTime1.Value
            '    'If (e.RowIndex > 1) Then
            '    '    listSach.RemoveAt(e.RowIndex - 1)
            '    'End If
            '    listSach.Add(New Sach_DTO(MaSach, TenSach, TheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia, TinhTrang))
            BunifuCustomDataGrid1.Rows(e.RowIndex).Cells(0).Value = BunifuCustomDataGrid1.Rows(e.RowIndex - 1).Cells(0).Value + 1
            'Else
            '    If (e.RowIndex > 0 And (e.RowIndex = listSach.Count Or e.RowIndex < listSach.Count)) Then


            '        listSach.RemoveAt(e.RowIndex - 1)
            '        Dim MaSach = BunifuCustomDataGrid1.Item("Cl_MaSach", e.RowIndex - 1).Value
            '        Dim TenSach = BunifuCustomDataGrid1.Item("Cl_TenSach", e.RowIndex - 1).Value
            '        Dim TheLoai = BunifuCustomDataGrid1.Item("Cl_TheLoaiSach", e.RowIndex - 1).Value
            '        Dim TacGia = BunifuCustomDataGrid1.Item("Cl_TacGia", e.RowIndex - 1).Value
            '        Dim NamXuatBan = BunifuCustomDataGrid1.Item("Cl_NamXuatBan", e.RowIndex - 1).Value
            '        Dim NhaXuatBan = BunifuCustomDataGrid1.Item("Cl_NhaXuatBan", e.RowIndex - 1).Value
            '        Dim TriGia = BunifuCustomDataGrid1.Item("Cl_TriGia", e.RowIndex - 1).Value
            '        Dim TinhTrang = ""
            '        Dim NgayNhap As DateTime = MetroDateTime1.Value
            '        listSach.Add(New Sach_DTO(MaSach, TenSach, TheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia, TinhTrang))
            '        BunifuCustomDataGrid1.Rows(e.RowIndex).Cells(0).Value = BunifuCustomDataGrid1.Rows(e.RowIndex - 1).Cells(0).Value + 1

            '    End If
        End If



        'listSach.Add(New Sach_DTO(MaSach, TenSach, TheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia, TinhTrang))
    End Sub

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click

        Dim r = BunifuCustomDataGrid1.Rows.Count
        For Each x As DataGridViewRow In BunifuCustomDataGrid1.Rows
            If x.Index = BunifuCustomDataGrid1.Rows.Count - 1 Then
                Exit For
            End If
            Dim Sach As Sach_DTO
            Sach = New Sach_DTO
            Sach.MaSach = BunifuCustomDataGrid1.Rows(x.Index).Cells(0).Value
            Sach.TenSach = BunifuCustomDataGrid1.Rows(x.Index).Cells(1).Value
            Sach.TheLoai = BunifuCustomDataGrid1.Rows(x.Index).Cells(2).Value
            Sach.TenTacGia = BunifuCustomDataGrid1.Rows(x.Index).Cells(3).Value
            Sach.NamXuatBan = BunifuCustomDataGrid1.Rows(x.Index).Cells(4).Value
            Sach.NhaXuatBan = BunifuCustomDataGrid1.Rows(x.Index).Cells(5).Value
            Sach.NgayNhap = MetroDateTime1.Value
            Sach.TriGia = BunifuCustomDataGrid1.Rows(x.Index).Cells(6).Value
            Sach.TinhTrang = " "
            Dim quydinh As QuyDinh_DTO
            quydinh = New QuyDinh_DTO()
            QuyDinhBUS.GetQuyDinh(quydinh)
            If (SachBUS.isValidNamXuatBan(Sach, quydinh) = False) Then
                MessageBox.Show("Chỉ nhận sách có năm xuất bản theo quy định")
                Return
            End If

            If (SachBUS.isValidTacGia(Sach) = False) Then
                MessageBox.Show("Tác giả chưa có trong cơ sở dữ liệu")
                'Cb_TenTacGia.Focus()
                Return
            End If
            If (SachBUS.isValidTheLoai(Sach) = False) Then
                MessageBox.Show("Thể loại không hợp lệ")
                'Cb_Theloai.Focus()
                Return
            End If
            listSach.Add(Sach)
        Next


        ''1. Mapping data from GUI control
        'Sach.MaSach = Txt_MaSach.Text
        'Sach.TenSach = Txt_TenSach.Text
        'Sach.NamXuatBan = Txt_NamXuatBan.Text
        'Sach.NhaXuatBan = Txt_NhaXuatBan.Text
        'Sach.NgayNhap = Dtp_NgayNhap.Value
        'Sach.TheLoai = Convert.ToInt32(Cb_Theloai.SelectedValue)
        'Sach.TenTacGia = Convert.ToInt32(Cb_TenTacGia.SelectedValue)
        'Sach.TriGia = Txt_TriGia.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        ''2. Business .....



        '3. Insert to DB
        Dim result As Result
        result = SachBUS.insert1(listSach)
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
            'Txt_MaSach.Text = nextMaSach
            'Txt_TenSach.Text = String.Empty
            'Txt_NamXuatBan.Text = String.Empty
            'Txt_NhaXuatBan.Text = String.Empty
            'Txt_TriGia.Text = String.Empty
        Else
            MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    'Private Sub BunifuCustomDataGrid1_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.RowLeave
    '    If (e.RowIndex > -1 And e.RowIndex = listSach.Count) Then
    '        Dim MaSach = BunifuCustomDataGrid1.Item("Cl_MaSach", e.RowIndex).Value
    '        Dim TenSach = BunifuCustomDataGrid1.Item("Cl_TenSach", e.RowIndex).Value
    '        Dim TheLoai = BunifuCustomDataGrid1.Item("Cl_TheLoaiSach", e.RowIndex).Value
    '        Dim TacGia = BunifuCustomDataGrid1.Item("Cl_TacGia", e.RowIndex).Value
    '        Dim NamXuatBan = BunifuCustomDataGrid1.Item("Cl_NamXuatBan", e.RowIndex).Value
    '        Dim NhaXuatBan = BunifuCustomDataGrid1.Item("Cl_NhaXuatBan", e.RowIndex).Value
    '        Dim TriGia = BunifuCustomDataGrid1.Item("Cl_TriGia", e.RowIndex).Value.ToString
    '        Dim TinhTrang = ""
    '        Dim NgayNhap As DateTime = MetroDateTime1.Value
    '        'If (e.RowIndex > 1) Then
    '        '    listSach.RemoveAt(e.RowIndex - 1)
    '        'End If
    '        listSach.Add(New Sach_DTO(MaSach, TenSach, TheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia, TinhTrang))
    '    Else
    '            If (e.RowIndex > -1 And e.RowIndex < listSach.Count) Then


    '            listSach.RemoveAt(e.RowIndex)
    '            Dim MaSach = BunifuCustomDataGrid1.Item("Cl_MaSach", e.RowIndex).Value
    '            Dim TenSach = BunifuCustomDataGrid1.Item("Cl_TenSach", e.RowIndex).Value
    '            Dim TheLoai = BunifuCustomDataGrid1.Item("Cl_TheLoaiSach", e.RowIndex).Value
    '            Dim TacGia = BunifuCustomDataGrid1.Item("Cl_TacGia", e.RowIndex).Value
    '            Dim NamXuatBan = BunifuCustomDataGrid1.Item("Cl_NamXuatBan", e.RowIndex).Value
    '            Dim NhaXuatBan = BunifuCustomDataGrid1.Item("Cl_NhaXuatBan", e.RowIndex).Value
    '            Dim TriGia = BunifuCustomDataGrid1.Item("Cl_TriGia", e.RowIndex).Value
    '            Dim TinhTrang = ""
    '            Dim NgayNhap As DateTime = MetroDateTime1.Value
    '            listSach.Add(New Sach_DTO(MaSach, TenSach, TheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia, TinhTrang))
    '            'BunifuCustomDataGrid1.Rows(e.RowIndex).Cells(0).Value = BunifuCustomDataGrid1.Rows(e.RowIndex - 1).Cells(0).Value + 1

    '        End If
    '    End If

    'End Sub







    'Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
    '    If BunifuCustomDataGrid1.Item("Cl_NgayNhap", e.RowIndex).Selected = True Then
    '        'dtp.Visible = False
    '        rect = BunifuCustomDataGrid1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
    '        dtp.Size = New Size(rect.Width, rect.Height)
    '        dtp.Location = New Point(rect.X, rect.Y)
    '        dtp.Visible = True
    '        'BunifuCustomDataGrid1.CurrentCell.Value = dtp.t

    '    End If
    '    'dtp.Visible = False
    'End Sub



    'Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click


    '    Dim quydinh As QuyDinh_DTO
    '    quydinh = New QuyDinh_DTO()
    '    '1. Mapping data from GUI control
    '    Sach.MaSach = Txt_MaSach.Text
    '    Sach.TenSach = Txt_TenSach.Text
    '    Sach.NamXuatBan = Txt_NamXuatBan.Text
    '    Sach.NhaXuatBan = Txt_NhaXuatBan.Text
    '    Sach.NgayNhap = Dtp_NgayNhap.Value
    '    Sach.TheLoai = Convert.ToInt32(Cb_Theloai.SelectedValue)
    '    Sach.TenTacGia = Convert.ToInt32(Cb_TenTacGia.SelectedValue)
    '    Sach.TriGia = Txt_TriGia.Text
    '    'TacGia.TenTacGia = Sach.TenTacGia
    '    '2. Business .....
    '    QuyDinhBUS.GetQuyDinh(quydinh)

    '    If (SachBUS.isValidNamXuatBan(Sach, quydinh) = False) Then
    '        MessageBox.Show("Chỉ nhận sách có năm xuất bản theo quy định")
    '        Txt_NamXuatBan.Clear()
    '        Return
    '    End If

    '    If (SachBUS.isValidTacGia(Sach) = False) Then
    '        MessageBox.Show("Tác giả chưa có trong cơ sở dữ liệu")
    '        Cb_TenTacGia.Focus()
    '        Return
    '    End If
    '    If (SachBUS.isValidTheLoai(Sach) = False) Then
    '        MessageBox.Show("Thể loại không hợp lệ")
    '        Cb_Theloai.Focus()
    '        Return
    '    End If
    '    '3. Insert to DB
    '    Dim result As Result
    '    result = SachBUS.insert(Sach)
    '    If (result.FlagResult = True) Then
    '        MessageBox.Show("Thêm Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        'set MSSH auto
    '        Dim nextMaSach = "1"
    '        result = SachBUS.buildMaSach(nextMaSach)
    '        If (result.FlagResult = False) Then
    '            MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Me.Close()
    '            Return
    '        End If
    '    Else
    '        MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '    End If
    'End Sub
End Class