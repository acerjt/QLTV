Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_LapPhieuMuonSach
    Private PhieuMuonSachBus As PhieuMuonSach_BUS
    Private DocGiaBus As DocGia_BUS
    Private SachBus As Sach_BUS
    Private QuyDinhBUS As QuyDinh_BUS
    Private ChiTietPhieuMuonSachBUS As ChiTietPhieuMuonSach_BUS
    Private listChiTietPhieuMuonSach As List(Of Sach_DTO)
    Private listChiTietPhieuMuonSach1 As List(Of ChiTietPhieuMuonSach_DTO)
    Private Sub Frm_LapPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PhieuMuonSachBus = New PhieuMuonSach_BUS()
        DocGiaBus = New DocGia_BUS()
        SachBus = New Sach_BUS()
        QuyDinhBUS = New QuyDinh_BUS()
        ChiTietPhieuMuonSachBUS = New ChiTietPhieuMuonSach_BUS()
        listChiTietPhieuMuonSach = New List(Of Sach_DTO)
        listChiTietPhieuMuonSach1 = New List(Of ChiTietPhieuMuonSach_DTO)
        Dim listSach = New List(Of Sach_DTO)

        Dtp_NgayMuon.Value = DateTime.Now
        Dim result As Result
        'set MSSH auto
        Dim nextMaPhieuMuonSach = "1"
        result = PhieuMuonSachBus.getNextID(nextMaPhieuMuonSach)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy tự động Mã Phiếu Mượn Sách không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaPhieuMuonSach.Text = nextMaPhieuMuonSach
    End Sub
    Private Sub loadListDocGia(ByRef MaDocGia As Integer)
        Dim Dg As DocGia_DTO
        Dg = New DocGia_DTO()

        Dim result As Result
        result = DocGiaBus.selecthovaten(MaDocGia, Dg)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy thông tin Độc Giả theo Mã không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        'DocGia.isValidHethan(Dg)
        If (DocGiaBus.isValidHethan(Dg) = False) Then
            Txt_TinhTrangThe.Text = "Hết Hạn"
            Txt_TinhTrangThe.BackColor = Color.Pink

        Else
            Txt_TinhTrangThe.Text = "Còn Hạn"
            Txt_TinhTrangThe.BackColor = Color.LightBlue

        End If
        If Dg.HoVaTen = "" Then
            Frm_Information.m.Text = "Không tồn tại mã độc giả."
            Frm_Information.ShowDialog()
            Txt_TinhTrangThe.Text = ""
        End If
        Txt_HoVaTen.Text = Dg.HoVaTen
        result = ChiTietPhieuMuonSachBUS.selectSachDaMuon(MaDocGia, listChiTietPhieuMuonSach)
        If (result.FlagResult = True) Then

            'Dgv_ListPhieuMuonSach.Columns.Clear()
            'Dgv_ListPhieuMuonSach.DataSource = Nothing

            'Dgv_ListPhieuMuonSach.AutoGenerateColumns = False
            Dgv_ListPhieuMuonSach1.Columns.Clear()
            Dgv_ListPhieuMuonSach1.DataSource = Nothing

            Dgv_ListPhieuMuonSach1.AutoGenerateColumns = False
            Dgv_ListPhieuMuonSach1.AllowUserToAddRows = False
            Dgv_ListPhieuMuonSach1.DataSource = listChiTietPhieuMuonSach
            'Dgv_ListPhieuMuonSach1.ColumnHeadersHeight = 70

            Dim Cl_MaSach1 = New DataGridViewTextBoxColumn()
            Cl_MaSach1.Name = "Cl_MaSach"
            Cl_MaSach1.HeaderText = "Mã Sách"
            Cl_MaSach1.DataPropertyName = "MaSach"
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_MaSach1)


            Dim Cl_TenSach1 = New DataGridViewTextBoxColumn()
            Cl_TenSach1.Name = "Cl_TenSach"
            Cl_TenSach1.HeaderText = "Tên Sách"
            Cl_TenSach1.DataPropertyName = "TenSach"
            Cl_TenSach1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_TenSach1)


            Dim Cl_TheLoaiSach1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TheLoaiSach1.Name = "Cl_TheLoaiSach"
            Cl_TheLoaiSach1.HeaderText = "Thể Loại Sách"
            Cl_TheLoaiSach1.DataPropertyName = "TheLoai"
            Cl_TheLoaiSach1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_TheLoaiSach1)

            Dim Cl_TenTacGia1 = New DataGridViewTextBoxColumn()
            Cl_TenTacGia1.Name = "Cl_TenTacGia"
            Cl_TenTacGia1.HeaderText = "Tên Tác Giả"
            Cl_TenTacGia1.DataPropertyName = "TenTacGia"
            Cl_TenTacGia1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_TenTacGia1)

            Dim Cl_TinhTrang1 = New DataGridViewTextBoxColumn()
            Cl_TinhTrang1.Name = "Cl_TinhTrang "
            Cl_TinhTrang1.HeaderText = "Tình Trạng"
            Cl_TinhTrang1.DataPropertyName = "TinhTrang"
            Cl_TinhTrang1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_TinhTrang1)




            Dim Cl_NgayDuKienTra = New DataGridViewTextBoxColumn()
            Cl_NgayDuKienTra.Name = "Cl_NgayDuKienTra "
            Cl_NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả"
            Cl_NgayDuKienTra.DataPropertyName = "NgayDuKien"
            Cl_NgayDuKienTra.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_NgayDuKienTra)


            'listChiTietPhieuMuonSach.Clear()
            For Each x As DataGridViewRow In Dgv_ListPhieuMuonSach1.Rows
                If (Dgv_ListPhieuMuonSach1.Item(4, x.Index).Value = "Đã Quá Hạn") Then
                    x.DefaultCellStyle.BackColor = Color.Pink
                End If
                If (Dgv_ListPhieuMuonSach1.Item(4, x.Index).Value = "Đang Mượn") Then
                    x.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next

        End If

    End Sub

    Private Sub Dgv_ListPhieuMuonSach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Dgv_ListPhieuMuonSach.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then

            e.Handled = True
            Frm_Information.m.Text = "Vui lòng chỉ nhập kí tự số."
            Frm_Information.ShowDialog()
        End If
    End Sub


    Private Sub Txt_MaDocGia_TextChanged(sender As Object, e As EventArgs) Handles Txt_MaDocGia.TextChanged
        Dim MaDocGia As String
        'listChiTietPhieuMuonSach.Clear()
        'Dgv_ListPhieuMuonSach.DataSource = Nothing
        'Dgv_ListPhieuMuonSach.Refresh()
        Txt_TinhTrangThe.Text = String.Empty

        Txt_TinhTrangThe.BackColor = Color.White
        Txt_HoVaTen.Text = String.Empty
        Dgv_ListPhieuMuonSach1.DataSource = Nothing
        Dgv_ListPhieuMuonSach.Rows.Clear()
        If Txt_MaDocGia.Text <> "" Then
            MaDocGia = Txt_MaDocGia.Text
            loadListDocGia(MaDocGia)
        End If


        For Each x As DataGridViewRow In Dgv_ListPhieuMuonSach1.Rows
            If (Dgv_ListPhieuMuonSach1.Item(4, x.Index).Value = "Đã Quá Hạn") Then
                x.DefaultCellStyle.BackColor = Color.Pink
            End If
            If (Dgv_ListPhieuMuonSach1.Item(4, x.Index).Value = "Đang Mượn") Then
                x.DefaultCellStyle.BackColor = Color.LightBlue
            End If
        Next
    End Sub

    Private Sub Dgv_ListPhieuMuonSach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListPhieuMuonSach.CellValueChanged
        If (e.RowIndex <> -1 And e.ColumnIndex = 0) Then

            For Each z As DataGridViewRow In Dgv_ListPhieuMuonSach1.Rows
                If (Dgv_ListPhieuMuonSach1.Item(0, z.Index).Value = Dgv_ListPhieuMuonSach.Rows(e.RowIndex).Cells(0).Value) Then
                    Frm_Information.m.Text = "Sách chưa được trả."
                    Frm_Information.ShowDialog()
                    Dgv_ListPhieuMuonSach.Rows.RemoveAt(e.RowIndex)
                    Dgv_ListPhieuMuonSach.Focus()
                    Return
                End If
            Next

            For Each y As DataGridViewRow In Dgv_ListPhieuMuonSach.Rows
                If e.RowIndex = 0 Then
                    Exit For
                Else
                    If (Dgv_ListPhieuMuonSach.Item(0, y.Index).Value = Dgv_ListPhieuMuonSach.Rows(e.RowIndex).Cells(0).Value And y.Index <> e.RowIndex) Then
                        Frm_Information.m.Text = "Sách đã được chọn ở trên."
                        Frm_Information.ShowDialog()
                        Dgv_ListPhieuMuonSach.Rows.RemoveAt(e.RowIndex)
                        Return
                        'Dgv_ListPhieuMuonSach.Focus()
                    End If
                End If
            Next


            SachBus = New Sach_BUS()
            Dim Chitietphieumuonsach As Sach_DTO
            Chitietphieumuonsach = New Sach_DTO()

            Dim Quydinh As QuyDinh_DTO
            Quydinh = New QuyDinh_DTO()
            QuyDinhBUS.GetQuyDinh(Quydinh)

            If Dgv_ListPhieuMuonSach.Rows.Count + Dgv_ListPhieuMuonSach1.Rows.Count > Quydinh.SoLuongSachMuonToiDa + 1 Then
                Frm_Information.m.Text = "Chỉ được mượn số lượng Sách theo Quy Định"
                Frm_Information.ShowDialog()
                Dgv_ListPhieuMuonSach.Rows.RemoveAt(e.RowIndex)
                Return
            End If


            Dim x = Dgv_ListPhieuMuonSach.Rows(e.RowIndex).Cells(0).Value


            Dim Sach1 = New Sach_DTO()
            Dim result As Result
            result = SachBus.selectALL_ByMaSach(x, Chitietphieumuonsach)
            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Lấy danh sach các Sách theo Mã không thành công."
                Frm_Information.ShowDialog()
                System.Console.WriteLine(result.SystemMessage)

                Return
            End If
            If Chitietphieumuonsach.TenSach = "" Then
                Frm_Information.m.Text = "Không tồn tại sách có mã này."
                Frm_Information.ShowDialog()
                Dgv_ListPhieuMuonSach.Rows.RemoveAt(e.RowIndex)
                Dgv_ListPhieuMuonSach.Focus()
            Else

                Dgv_ListPhieuMuonSach.Item("Cl_TenSach", e.RowIndex).Value = Chitietphieumuonsach.TenSach
                Dgv_ListPhieuMuonSach.Item("Cl_TheLoai", e.RowIndex).Value = Chitietphieumuonsach.TheLoai
                Dgv_ListPhieuMuonSach.Item("Cl_TinhTrang", e.RowIndex).Value = Chitietphieumuonsach.TinhTrang
                Dgv_ListPhieuMuonSach.Item("Cl_TacGia", e.RowIndex).Value = Chitietphieumuonsach.TenTacGia
                If Dgv_ListPhieuMuonSach.Item("Cl_TinhTrang", e.RowIndex).Value = "Đang Mượn" Then
                    Dgv_ListPhieuMuonSach.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
                Else
                    Dgv_ListPhieuMuonSach.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White

                End If
                'Dgv_ListPhieuMuonSach.Item("Cl_NgayDuKienTra", e.RowIndex).Value = Chitietphieumuonsach.NgayDuKien
                ' Dgv_ListPhieuMuonSach.Item("Cl_STT", e.RowIndex).Value = e.RowIndex + 1
                If (listChiTietPhieuMuonSach1.Count() = e.RowIndex) Then
                        listChiTietPhieuMuonSach1.Add(New ChiTietPhieuMuonSach_DTO(Txt_MaPhieuMuonSach.Text, x))
                    Else
                        If (listChiTietPhieuMuonSach1.Count() > e.RowIndex) Then
                            listChiTietPhieuMuonSach1.RemoveAt(e.RowIndex)
                            listChiTietPhieuMuonSach1.Add(New ChiTietPhieuMuonSach_DTO(Txt_MaPhieuMuonSach.Text, x))
                        End If
                    End If
                End If
            End If



    End Sub

    Private Sub Btn_LapPhieu_Click(sender As Object, e As EventArgs) Handles Btn_LapPhieu.Click

        Dim PhieuMuonSach As PhieuMuonSach_DTO
        PhieuMuonSach = New PhieuMuonSach_DTO()

        Dim Quydinh As QuyDinh_DTO
        Quydinh = New QuyDinh_DTO()
        QuyDinhBUS.GetQuyDinh(Quydinh)

        '1. Mapping data from GUI control
        PhieuMuonSach.MaPhieuMuonSach = Txt_MaPhieuMuonSach.Text
        If Txt_MaDocGia.Text = "" Then
            Frm_Information.m.Text = "Mã độc giả không được trống."
            Frm_Information.ShowDialog()
            Txt_MaDocGia.Focus()
            Return
        End If
        PhieuMuonSach.MaDocGia = Txt_MaDocGia.Text
        PhieuMuonSach.NgayMuon = Dtp_NgayMuon.Value
        PhieuMuonSach.NgayDuKienTra = Dtp_NgayMuon.Value.AddDays(Quydinh.SoNgayMuonToiDa)

        '2. Business .....
        If (PhieuMuonSachBus.isValidMaDocGia(PhieuMuonSach) = False) Then
            Frm_Information.m.Text = "Mã độc giả không được trống."
            Frm_Information.ShowDialog()
            Txt_MaDocGia.Focus()
            Return
        End If

        If (Txt_TinhTrangThe.Text = "Hết Hạn") Then
            Frm_Information.m.Text = "Thẻ Độc Giả đã hết hạn."
            Frm_Information.ShowDialog()
            Return
        End If

        If Dgv_ListPhieuMuonSach.Rows.Count = 1 Then
            Frm_Information.m.Text = "Chưa nhập sách mượn."
            Frm_Information.ShowDialog()
            Return
        End If



        For Each x As DataGridViewRow In Dgv_ListPhieuMuonSach1.Rows

            If (Dgv_ListPhieuMuonSach1.Item(4, x.Index).Value = "Đã Quá Hạn") Then
                Frm_Information.m.Text = "Có Sách đã 'quá hạn' chưa được trả."
                Frm_Information.ShowDialog()
                Return
            End If
        Next


        For Each x As DataGridViewRow In Dgv_ListPhieuMuonSach.Rows

            If (Dgv_ListPhieuMuonSach.Item(4, x.Index).Value = "Đang Mượn") Then
                Frm_Information.m.Text = "Sách hiện đang có người mượn."
                Frm_Information.ShowDialog()
                Return
            End If

            If (Dgv_ListPhieuMuonSach.Item(2, x.Index).Value = "") And Dgv_ListPhieuMuonSach.Rows.Count - 1 <> x.Index Then
                Frm_Information.m.Text = "Error! Vui lòng kiểm tra đầy đủ thông tin của sách."
                Frm_Information.ShowDialog()
                Return
            End If
        Next

        '3. Insert to DB
        Dim result As Result
        result = PhieuMuonSachBus.insert(PhieuMuonSach, listChiTietPhieuMuonSach1)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Thêm Phiếu Mượn Sách  thành công."
            Frm_Information.ShowDialog()
            'set Madocgia auto
            Dim nextMaPhieuMuonSach = "1"
            result = PhieuMuonSachBus.getNextID(nextMaPhieuMuonSach)
            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Lấy tự động Mã Phiếu Mượn Sách không thành công."
                Frm_Information.ShowDialog()
                Me.Close()
                Return
            End If
            Txt_MaPhieuMuonSach.Text = nextMaPhieuMuonSach
            ' Dtp_NgayMuon.Value = ""   
            Txt_MaDocGia.Text = String.Empty
            Txt_TinhTrangThe.Text = String.Empty
            Txt_HoVaTen.Text = String.Empty
            listChiTietPhieuMuonSach1.Clear()
            listChiTietPhieuMuonSach1.Clear()
            Dgv_ListPhieuMuonSach.Rows.Clear()
        Else
            Frm_Information.m.Text = "Thêm Phiếu Mượn Sách không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Txt_MaDocGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_MaDocGia.KeyPress

        If (Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
            Frm_Information.m.Text = "Vui lòng nhập chỉ nhập mã số."
            Frm_Information.ShowDialog()
        End If

    End Sub

    Private Sub Control_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
            Frm_Information.m.Text = "Vui lòng nhập chỉ nhập mã số."
            Frm_Information.ShowDialog()
        End If
    End Sub

    Private Sub Dgv_ListPhieuMuonSach_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Dgv_ListPhieuMuonSach.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Control_KeyPress
        AddHandler e.Control.KeyPress, AddressOf Control_KeyPress
    End Sub


End Class