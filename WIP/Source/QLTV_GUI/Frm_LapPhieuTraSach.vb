Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_LapPhieuTraSach
    Private PhieuTraSachBus As PhieuTraSach_BUS
    Private DocGiaBus As DocGia_BUS
    Private SachBus As Sach_BUS
    Private QuyDinhBus As QuyDinh_BUS
    Private ChiTietPhieuTraSachBUS As ChiTietPhieuTraSach_BUS
    Private listChiTietPhieuMuonSach As List(Of Sach_DTO)
    Private listChiTietPhieuTraSach As List(Of ChiTietPhieuTraSach_DTO)
    Dim frm_Infor = New Frm_Information()
    Private Sub Frm_NhanTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PhieuTraSachBus = New PhieuTraSach_BUS()
        DocGiaBus = New DocGia_BUS()
        SachBus = New Sach_BUS()
        QuyDinhBus = New QuyDinh_BUS()

        ChiTietPhieuTraSachBUS = New ChiTietPhieuTraSach_BUS()
        listChiTietPhieuMuonSach = New List(Of Sach_DTO)
        listChiTietPhieuTraSach = New List(Of ChiTietPhieuTraSach_DTO)
        Dim listSach = New List(Of Sach_DTO)

        Dtp_NgayTra.Value = DateTime.Now

        Dim result As Result
        'set MSSH auto
        Dim nextMaPhieuTraSach = "1"
        result = PhieuTraSachBus.getNextID(nextMaPhieuTraSach)
        If (result.FlagResult = False) Then
            frm_Infor.m.Text = "Lấy tự động Mã Phiếu Trả sách không thành công."
            frm_Infor.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaPhieuTraSach.Text = nextMaPhieuTraSach
    End Sub

    Private Sub Txt_MaDocGia_TextChanged(sender As Object, e As EventArgs) Handles Txt_MaDocGia.TextChanged
        Dim MaDocGia As String
        'listChiTietPhieuMuonSach.Clear()
        'Dgv_ListPhieuMuonSach.DataSource = Nothing
        'Dgv_ListPhieuMuonSach.Refresh()
        Txt_HoVaTen.Text = String.Empty
        Dgv_ListSachTra.Rows.Clear()
        If Txt_MaDocGia.Text <> "" Then
            MaDocGia = Txt_MaDocGia.Text
            loadListDocGia(MaDocGia)
        End If

        For Each x As DataGridViewRow In Dgv_ListSachDangMuon.Rows
            If (Dgv_ListSachDangMuon.Item(5, x.Index).Value = "Đã Quá Hạn") Then
                x.DefaultCellStyle.BackColor = Color.Pink
            End If
            If (Dgv_ListSachDangMuon.Item(5, x.Index).Value = "Đang Mượn") Then
                x.DefaultCellStyle.BackColor = Color.LightBlue
            End If
        Next
    End Sub

    Private Sub loadListDocGia(maDocGia As String)
        Dim Dg As DocGia_DTO
        Dg = New DocGia_DTO()

        Dim result As Result
        result = DocGiaBus.selecthovaten(maDocGia, Dg)
        If (result.FlagResult = False) Then
            frm_Infor.m.Text = "Lấy danh sách Độc Giả không thành công."
            frm_Infor.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        If Dg.HoVaTen = "" Then
            frm_Infor.m.Text = "Không tồn tại Mã Độc Giả."
            frm_Infor.ShowDialog()
        End If
        Txt_HoVaTen.Text = Dg.HoVaTen
        result = ChiTietPhieuTraSachBUS.selectSachDaMuon(maDocGia, listChiTietPhieuMuonSach)
        If (result.FlagResult = True) Then

            'Dgv_ListPhieuMuonSach.Columns.Clear()
            'Dgv_ListPhieuMuonSach.DataSource = Nothing

            'Dgv_ListPhieuMuonSach.AutoGenerateColumns = False
            Dgv_ListSachDangMuon.Columns.Clear()
            Dgv_ListSachDangMuon.DataSource = Nothing

            Dgv_ListSachDangMuon.AutoGenerateColumns = False
            Dgv_ListSachDangMuon.AllowUserToAddRows = False
            Dgv_ListSachDangMuon.ColumnHeadersHeight = 80
            Dgv_ListSachDangMuon.DataSource = listChiTietPhieuMuonSach


            Dim Cl_MaSach1 = New DataGridViewTextBoxColumn()
            Cl_MaSach1.Name = "Cl_MaSach"
            Cl_MaSach1.HeaderText = "Mã Sách"
            Cl_MaSach1.DataPropertyName = "MaSach"
            Cl_MaSach1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListSachDangMuon.Columns.Add(Cl_MaSach1)

            Dim Cl_MaPhieuTraSach1 = New DataGridViewTextBoxColumn()
            Cl_MaPhieuTraSach1.Name = "Cl_MaPhieuTraSach1"
            Cl_MaPhieuTraSach1.HeaderText = "Mã Phiếu Mượn Sách"
            Cl_MaPhieuTraSach1.DataPropertyName = "MaPhieuMuonSach"
            Cl_MaPhieuTraSach1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListSachDangMuon.Columns.Add(Cl_MaPhieuTraSach1)

            Dim Cl_TenSach1 = New DataGridViewTextBoxColumn()
            Cl_TenSach1.Name = "Cl_TenSach"
            Cl_TenSach1.HeaderText = "Tên Sách"
            Cl_TenSach1.DataPropertyName = "TenSach"
            Cl_TenSach1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Dgv_ListSachDangMuon.Columns.Add(Cl_TenSach1)


            Dim Cl_TheLoaiSach1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TheLoaiSach1.Name = "Cl_TheLoaiSach"
            Cl_TheLoaiSach1.HeaderText = "Thể Loại Sách"
            Cl_TheLoaiSach1.DataPropertyName = "TheLoai"
            Cl_TheLoaiSach1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dgv_ListSachDangMuon.Columns.Add(Cl_TheLoaiSach1)

            Dim Cl_TenTacGia1 = New DataGridViewTextBoxColumn()
            Cl_TenTacGia1.Name = "Cl_TenTacGia"
            Cl_TenTacGia1.HeaderText = "Tên Tác Giả"
            Cl_TenTacGia1.DataPropertyName = "TenTacGia"
            Cl_TenTacGia1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Dgv_ListSachDangMuon.Columns.Add(Cl_TenTacGia1)

            Dim Cl_TinhTrang1 = New DataGridViewTextBoxColumn()
            Cl_TinhTrang1.Name = "Cl_TinhTrang "
            Cl_TinhTrang1.HeaderText = "Tình Trạng"
            Cl_TinhTrang1.DataPropertyName = "TinhTrang"
            Cl_TinhTrang1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Dgv_ListSachDangMuon.Columns.Add(Cl_TinhTrang1)




            Dim Cl_NgayDuKienTra = New DataGridViewTextBoxColumn()
            Cl_NgayDuKienTra.Name = "Cl_NgayDuKienTra "
            Cl_NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả"
            Cl_NgayDuKienTra.DataPropertyName = "NgayDuKien"
            Cl_NgayDuKienTra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Dgv_ListSachDangMuon.Columns.Add(Cl_NgayDuKienTra)


            'listChiTietPhieuMuonSach.Clear()
            For Each x As DataGridViewRow In Dgv_ListSachDangMuon.Rows
                If (Dgv_ListSachDangMuon.Item(5, x.Index).Value = "Đã Quá Hạn") Then
                    x.DefaultCellStyle.BackColor = Color.Pink
                End If
                If (Dgv_ListSachDangMuon.Item(5, x.Index).Value = "Đang Mượn") Then
                    x.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next

        End If
    End Sub


    Private Sub Dgv_ListSachTra_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListSachTra.CellValueChanged

        If (e.RowIndex <> -1 And e.ColumnIndex = 0) Then

            If Dgv_ListSachDangMuon.Rows.Count = 0 Then
                frm_Infor.m.Text = "Độc giả này hiện không mượn sách."
                frm_Infor.ShowDialog()
                Dgv_ListSachTra.Rows.RemoveAt(e.RowIndex)
                Return
            End If
            If Txt_MaDocGia.Text = "" Then
                frm_Infor.m.Text = "Vui lòng nhập mã độc giả."
                frm_Infor.ShowDialog()
                Dgv_ListSachTra.Rows.RemoveAt(e.RowIndex)
                Return
            End If

            For Each z As DataGridViewRow In Dgv_ListSachDangMuon.Rows
                If (Dgv_ListSachDangMuon.Item(0, z.Index).Value <> Dgv_ListSachTra.Rows(e.RowIndex).Cells(0).Value And (z.Index + 1) = Dgv_ListSachDangMuon.Rows.Count) Then
                    frm_Infor.m.Text = "Độc giả không mượn sách này."
                    frm_Infor.ShowDialog()
                    Dgv_ListSachTra.Rows.RemoveAt(e.RowIndex)
                    'Dgv_ListSachTra.Focus()
                    Return
                Else
                    If (Dgv_ListSachDangMuon.Item(0, z.Index).Value = Dgv_ListSachTra.Rows(e.RowIndex).Cells(0).Value) Then
                        Exit For
                    End If
                End If
            Next

            For Each y As DataGridViewRow In Dgv_ListSachTra.Rows
                If e.RowIndex = 0 Then
                    Exit For
                Else
                    If (Dgv_ListSachTra.Item(0, y.Index).Value = Dgv_ListSachTra.Rows(e.RowIndex).Cells(0).Value And y.Index <> e.RowIndex) Then
                        frm_Infor.m.Text = "Sách đã được chọn ở trên."
                        frm_Infor.ShowDialog()
                        Dgv_ListSachTra.Rows.RemoveAt(e.RowIndex)
                        Return
                        'Dgv_ListPhieuMuonSach.Focus()
                    End If
                End If
            Next


            SachBus = New Sach_BUS()
            Dim Chitietphieumuonsach As Sach_DTO
            Chitietphieumuonsach = New Sach_DTO()


            Dim x = Dgv_ListSachTra.Rows(e.RowIndex).Cells(0).Value


            Dim Sach1 = New Sach_DTO()
            Dim result As Result
            result = SachBus.selectALL_ByMaSach(x, Chitietphieumuonsach)
            If (result.FlagResult = False) Then
                frm_Infor.m.Text = "Lấy danh sách các Sách theo mã không thành công."
                frm_Infor.ShowDialog()
                System.Console.WriteLine(result.SystemMessage)

                Return
            End If
            If Chitietphieumuonsach.TenSach = "" Then
                frm_Infor.m.Text = "Không tồn tại mã sách."
                frm_Infor.ShowDialog()
                Dgv_ListSachTra.Rows.RemoveAt(e.RowIndex)
                Dgv_ListSachTra.Focus()
            Else

                Dgv_ListSachTra.Item("Cl_TenSach", e.RowIndex).Value = Chitietphieumuonsach.TenSach
                Dgv_ListSachTra.Item("Cl_TheLoai", e.RowIndex).Value = Chitietphieumuonsach.TheLoai
                Dgv_ListSachTra.Rows.Item(e.RowIndex).DefaultCellStyle.BackColor = Color.LightBlue

                For Each t As DataGridViewRow In Dgv_ListSachDangMuon.Rows
                    If (Dgv_ListSachDangMuon.Item(0, t.Index).Value = Dgv_ListSachTra.Item(0, e.RowIndex).Value) Then
                        Chitietphieumuonsach.MaPhieuMuonSach = Dgv_ListSachDangMuon.Item(1, t.Index).Value
                        If (Dgv_ListSachDangMuon.Item(5, t.Index).Value = "Đã Quá Hạn") Then
                            Chitietphieumuonsach.TinhTrang = "Đã Quá Hạn"
                            Dgv_ListSachTra.Rows.Item(e.RowIndex).DefaultCellStyle.BackColor = Color.Pink
                        End If
                    End If

                Next

                Dgv_ListSachTra.Item("Cl_TinhTrang", e.RowIndex).Value = Chitietphieumuonsach.TinhTrang
                Dgv_ListSachTra.Item("Cl_TacGia", e.RowIndex).Value = Chitietphieumuonsach.TenTacGia
                Dim z As String
                z = ""
                If (Chitietphieumuonsach.TinhTrang = "Đang Mượn") Then
                    z = " "
                Else
                    If (Chitietphieumuonsach.TinhTrang = "Đã Quá Hạn") Then
                        z = "Trả Trễ"
                    End If
                End If

                'Dgv_ListPhieuMuonSach.Item("Cl_NgayDuKienTra", e.RowIndex).Value = Chitietphieumuonsach.NgayDuKienTra
                ' Dgv_ListPhieuMuonSach.Item("Cl_STT", e.RowIndex).Value = e.RowIndex + 1
                If (listChiTietPhieuTraSach.Count() = e.RowIndex) Then
                    listChiTietPhieuTraSach.Add(New ChiTietPhieuTraSach_DTO(Txt_MaPhieuTraSach.Text, x, z, Chitietphieumuonsach.MaPhieuMuonSach)) ', d))
                Else
                    If (listChiTietPhieuTraSach.Count() > e.RowIndex) Then
                        listChiTietPhieuTraSach.RemoveAt(e.RowIndex)
                        listChiTietPhieuTraSach.Add(New ChiTietPhieuTraSach_DTO(Txt_MaPhieuTraSach.Text, x, z, Chitietphieumuonsach.MaPhieuMuonSach)) ', d))
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub Btn_NhanTraSach_Click(sender As Object, e As EventArgs) Handles Btn_NhanTraSach.Click
        Dim PhieuTraSach As PhieuTraSach_DTO
        PhieuTraSach = New PhieuTraSach_DTO()

        Dim QuyDinh As QuyDinh_DTO
        QuyDinh = New QuyDinh_DTO()

        '1. Mapping data from GUI control
        PhieuTraSach.MaTraSach = Txt_MaPhieuTraSach.Text
        If Txt_MaDocGia.Text = "" Then
            Frm_Information.m.Text = "Mã độc giả không được trống."
            Frm_Information.ShowDialog()
            Txt_MaDocGia.Focus()
            Return
        End If
        PhieuTraSach.MaDocGia = Txt_MaDocGia.Text


        PhieuTraSach.NgayTra = Dtp_NgayTra.Value
        'PhieuMuonSach.NgayDuKienTra = Dtp_NgayMuon.Value.AddDays(4)

        '2. Business .....

        If (PhieuTraSachBus.isValidMaDocGia(PhieuTraSach) = False) Then
            frm_Infor.m.Text = "Mã độc giả không được trống."
            frm_Infor.ShowDialog()
            Txt_MaDocGia.Focus()
            Return
        End If

        'If (Phie) Then
        If (Dtp_NgayTra.Value >= DateTime.Now) Then
            frm_Infor.m.Text = "Ngày Trả phải nhỏ hơn hoặc bằng Ngày Hiện Tại."
            frm_Infor.ShowDialog()
            Return
        End If

        QuyDinhBus.GetQuyDinh(QuyDinh)

        For Each z As Sach_DTO In listChiTietPhieuMuonSach
            For Each y As ChiTietPhieuTraSach_DTO In listChiTietPhieuTraSach
                Dim t = z.NgayDuKien.AddDays(-(QuyDinh.SoNgayMuonToiDa))
                If (t > PhieuTraSach.NgayTra) And (z.MaSach = y.MaSach) Then
                    frm_Infor.m.Text = "Có Sách mà Ngày Trả nhỏ hơn Ngày Mượn."
                    frm_Infor.ShowDialog()
                    Return
                End If
            Next

        Next
        If Dgv_ListSachTra.Rows.Count = 1 Then
            Frm_Information.m.Text = "Chưa nhập sách trả."
            Frm_Information.ShowDialog()
            Return
        End If

        For Each x As DataGridViewRow In Dgv_ListSachTra.Rows

            If (Dgv_ListSachTra.Item(4, x.Index).Value = " ") Then
                frm_Infor.m.Text = "Có sách Độc Giả không mượn."
                frm_Infor.ShowDialog()
                Return
            End If

            If (Dgv_ListSachTra.Item(2, x.Index).Value = "") And Dgv_ListSachTra.Rows.Count - 1 <> x.Index Then
                Frm_Information.m.Text = "Error! Vui lòng kiểm tra đầy đủ thông tin của sách."
                Frm_Information.ShowDialog()
                Return
            End If
        Next

        '3. Insert to DB
        Dim result As Result
        result = PhieuTraSachBus.insert(PhieuTraSach, listChiTietPhieuTraSach)
        If (result.FlagResult = True) Then
            frm_Infor.m.Text = "Trả sách thành công."
            frm_Infor.ShowDialog()
            'set Madocgia auto

            Dim nextMaPhieuTraSach = "1"
            result = PhieuTraSachBus.getNextID(nextMaPhieuTraSach)
            If (result.FlagResult = False) Then
                frm_Infor.m.Text = "Lấy tự động Mã Phiếu Mượn Sách không thành công."
                frm_Infor.ShowDialog()
                Me.Close()
                Return
            End If
            Txt_MaPhieuTraSach.Text = nextMaPhieuTraSach
            ' Dtp_NgayMuon.Value = ""   
            Txt_MaDocGia.Text = String.Empty
            'Txt_TinhTrangThe.Text = String.Empty
            Txt_HoVaTen.Text = String.Empty
            listChiTietPhieuTraSach.Clear()
            'listChiTietPhieuMuonSach.Clear()
            'listChiTietPhieuMuonSach.RemoveAt()
            Dgv_ListSachDangMuon.DataSource = Nothing
            Dgv_ListSachTra.Rows.Clear()


            'Dgv_ListSachDangMuon.Rows.Clear()

        Else
            frm_Infor.m.Text = "Trả Sách không thành công."
            frm_Infor.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Txt_MaDocGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_MaDocGia.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then

            e.Handled = True
            frm_Infor.m.Text = "Vui lòng nhập mã số."
            frm_Infor.ShowDialog()
        End If

    End Sub
    Private Sub Control_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
            frm_Infor.m.Text = "Vui lòng nhập mã số."
            frm_Infor.ShowDialog()
        End If
    End Sub


    Private Sub Dgv_ListSachTra_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Dgv_ListSachTra.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Control_KeyPress
        AddHandler e.Control.KeyPress, AddressOf Control_KeyPress
    End Sub
End Class