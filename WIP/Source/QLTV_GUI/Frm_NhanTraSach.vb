Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility


Public Class Frm_NhanTraSach
    Private PhieuTraSachBus As NhanTraSach_BUS
    Private DocGiaBus As DocGia_BUS
    Private SachBus As Sach_BUS
    Private ChiTietPhieuTraSachBUS As ChiTietPhieuTraSach_BUS
    Private listChiTietPhieuMuonSach As List(Of Sach_DTO)
    Private listChiTietPhieuTraSach As List(Of ChiTietPhieuTraSach_DTO)
    Private Sub Frm_NhanTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PhieuTraSachBus = New NhanTraSach_BUS()
        DocGiaBus = New DocGia_BUS()
        SachBus = New Sach_BUS()
        ChiTietPhieuTraSachBUS = New ChiTietPhieuTraSach_BUS()
        listChiTietPhieuMuonSach = New List(Of Sach_DTO)
        listChiTietPhieuTraSach = New List(Of ChiTietPhieuTraSach_DTO)
        Dim listSach = New List(Of Sach_DTO)

        Dim result As Result
        'set MSSH auto
        Dim nextMaPhieuTraSach = "1"
        result = PhieuTraSachBus.getNextID(nextMaPhieuTraSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dgv_ListSachTra.Rows.Clear()
        If Txt_MaDocGia.Text <> "" Then
            MaDocGia = Txt_MaDocGia.Text
            loadListDocGia(MaDocGia)
        End If


        For Each x As DataGridViewRow In Dgv_ListSachDangMuon.Rows
            If (Dgv_ListSachDangMuon.Item(5, x.Index).Value = "Đã Quá Hạn") Then
                x.DefaultCellStyle.BackColor = Color.Pink
            End If
            If (Dgv_ListSachDangMuon.Item(5, x.Index).Value = "DangMuon") Then
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
            MessageBox.Show("Lấy danh sách độc giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        'DocGia.isValidHethan(Dg)
        'If (DocGiaBus.isValidHethan(Dg) = False) Then
        '    Txt_TinhTrangThe.Text = "Hết Hạn"
        'Else Txt_TinhTrangThe.Text = "Còn Hạn"
        'End If
        If Dg.HoVaTen = "" Then
            MessageBox.Show("Không tồn tại mã độc giả.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Txt_TinhTrangThe.Text = ""
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
            Dgv_ListSachDangMuon.DataSource = listChiTietPhieuMuonSach

            Dim Cl_MaSach1 = New DataGridViewTextBoxColumn()
            Cl_MaSach1.Name = "Cl_MaSach"
            Cl_MaSach1.HeaderText = "Mã Sách"
            Cl_MaSach1.DataPropertyName = "MaSach"
            Dgv_ListSachDangMuon.Columns.Add(Cl_MaSach1)

            Dim Cl_MaPhieuTraSach1 = New DataGridViewTextBoxColumn()
            Cl_MaPhieuTraSach1.Name = "Cl_MaPhieuTraSach1"
            Cl_MaPhieuTraSach1.HeaderText = "Mã Phiếu Mượn Sách"
            Cl_MaPhieuTraSach1.DataPropertyName = "MaPhieuMuonSach"
            Dgv_ListSachDangMuon.Columns.Add(Cl_MaPhieuTraSach1)

            'Dim Cl_TheLoaiSach = New DataGridView()
            'Dim clLoaiHS = New DataGridView()
            'clLoaiHS.Name = "LoaiHS"
            'clLoaiHS.HeaderText = "Tên Loại"
            'clLoaiHS.DataPropertyName = "LoaiHS"
            'dgvListHS.Columns.Add(clLoaiHS)

            Dim Cl_TenSach1 = New DataGridViewTextBoxColumn()
            Cl_TenSach1.Name = "Cl_TenSach"
            Cl_TenSach1.HeaderText = "Tên Sách"
            Cl_TenSach1.DataPropertyName = "TenSach"
            Dgv_ListSachDangMuon.Columns.Add(Cl_TenSach1)


            Dim Cl_TheLoaiSach1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TheLoaiSach1.Name = "Cl_TheLoaiSach"
            Cl_TheLoaiSach1.HeaderText = "Thể Loại Sách"
            Cl_TheLoaiSach1.DataPropertyName = "TheLoai"
            Dgv_ListSachDangMuon.Columns.Add(Cl_TheLoaiSach1)

            Dim Cl_TenTacGia1 = New DataGridViewTextBoxColumn()
            Cl_TenTacGia1.Name = "Cl_TenTacGia"
            Cl_TenTacGia1.HeaderText = "Tên Tác Giả"
            Cl_TenTacGia1.DataPropertyName = "TenTacGia"
            Dgv_ListSachDangMuon.Columns.Add(Cl_TenTacGia1)

            Dim Cl_TinhTrang1 = New DataGridViewTextBoxColumn()
            Cl_TinhTrang1.Name = "Cl_TinhTrang "
            Cl_TinhTrang1.HeaderText = "Tình Trạng"
            Cl_TinhTrang1.DataPropertyName = "TinhTrang"
            Dgv_ListSachDangMuon.Columns.Add(Cl_TinhTrang1)




            Dim Cl_NgayDuKienTra = New DataGridViewTextBoxColumn()
            Cl_NgayDuKienTra.Name = "Cl_NgayDuKienTra "
            Cl_NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả"
            Cl_NgayDuKienTra.DataPropertyName = "NgayDuKien"
            Dgv_ListSachDangMuon.Columns.Add(Cl_NgayDuKienTra)


            'listChiTietPhieuMuonSach.Clear()
            For Each x As DataGridViewRow In Dgv_ListSachDangMuon.Rows
                If (Dgv_ListSachDangMuon.Item(5, x.Index).Value = "Đã Quá Hạn") Then
                    x.DefaultCellStyle.BackColor = Color.Pink
                End If
                If (Dgv_ListSachDangMuon.Item(5, x.Index).Value = "DangMuon") Then
                    x.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next

        End If
    End Sub

    'Private Sub Dgv_ListSachDangMuon_SelectionChanged(sender As Object, e As EventArgs) Handles Dgv_ListSachDangMuon.SelectionChanged
    '    Dim currentRowIndex As Integer = Dgv_ListSachDangMuon.CurrentCellAddress.Y 'current row selected
    '    'Dim x As Integer = Dgv_ListDocGia.CurrentCellAddress.X 'curent column selected
    '    'Dim x As Integer = Dgv_ListDocGia.CurrentCell.Selected
    '    ' Write coordinates to console for debugging
    '    'Console.WriteLine(y.ToString + " " + x.ToString)
    '    'listChiTietPhieuMuonSach.a
    '    'Verify that indexing OK
    '    If (-1 < currentRowIndex And currentRowIndex < Dgv_ListSachDangMuon.RowCount) Then
    '        Try
    '            Dim ctpts = CType(Dgv_ListSachDangMuon.Rows(currentRowIndex).DataBoundItem, ChiTietPhieuMuonSach_DTO)
    '            'Txt_MaDocGia.Text = dg.MaDocGia
    '            'Txt_HoVaTen.Text = dg.HoVaTen
    '            'Txt_DiaChi.Text = dg.DiaChi
    '            'Dtp_NgaySinh.Value = dg.NgaySinh
    '            'Txt_Email.Text = dg.Email
    '            'Dtp_NgayLap.Value = dg.NgayLap
    '            'Txt_NgayHetHan.Text = dg.NgayHetHan
    '            Dgv_ListSachTra.Item("Cl_MaSach", currentRowIndex).Value = ctpts.MaSach
    '            Dgv_ListSachTra.Item("Cl_TenSach", currentRowIndex).Value = ctpts.TenSach
    '            Dgv_ListSachTra.Item("Cl_TheLoai", currentRowIndex).Value = ctpts.TenTheLoaiSach
    '            Dgv_ListSachTra.Item("Cl_TinhTrang", currentRowIndex).Value = ctpts.TinhTrang
    '            Dgv_ListSachTra.Item("Cl_TacGia", currentRowIndex).Value = ctpts.TenTacGia


    '            'Dim ThoiGian = DateTime.Now
    '            'If (dg.NgayLap.AddMonths(6) >= ThoiGian) Then
    '            '    Txt_TinhTrangThe.Text = "Còn Hạn"
    '            'Else Txt_TinhTrangThe.Text = " Hết Hạn rồi đó"

    '            'If (dgBus.isValidHethan(dg) = False) Then
    '            '    Txt_TinhTrangThe.Text = "Hết Hạn"
    '            'Else Txt_TinhTrangThe.Text = "Còn Hạn"

    '            'End If


    '            'Cb_LoaiDocGiaCapNhap.SelectedIndex = Cb_LoaiDocGia.SelectedIndex
    '        Catch ex As Exception
    '            Console.WriteLine(ex.StackTrace)
    '        End Try

    '    End If



    'End Sub

    Private Sub Dgv_ListSachTra_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListSachTra.CellValueChanged

        If (e.RowIndex <> -1 And e.ColumnIndex = 0) Then
            'Dim y As PhieuMuonSach_DTO
            'y = New PhieuMuonSach_DTO()
            'If (PhieuMuonSachBus.isValidMaDocGia(y) = False) Then
            '    MessageBox.Show("Mã độc giả không được trống")
            '    Txt_MaDocGia.Focus()
            '    Return
            'End If
            If Dgv_ListSachDangMuon.Rows.Count = 0 Then
                MessageBox.Show("Độc giả này không mượn sách nào cả")
                Dgv_ListSachTra.Rows.RemoveAt(e.RowIndex)
                Return
            End If
            If Txt_MaDocGia.Text = "" Then
                MessageBox.Show("Vui lòng nhập mã độc giả.")
                Dgv_ListSachTra.Rows.RemoveAt(e.RowIndex)
                Return
            End If

            For Each z As DataGridViewRow In Dgv_ListSachDangMuon.Rows
                If (Dgv_ListSachDangMuon.Item(0, z.Index).Value <> Dgv_ListSachTra.Rows(e.RowIndex).Cells(0).Value And (z.Index + 1) = Dgv_ListSachDangMuon.Rows.Count) Then

                    MessageBox.Show("Độc giả không mượn sách này.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                        MessageBox.Show("Sách đã được chọn ở trên.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Dgv_ListSachTra.Rows.RemoveAt(e.RowIndex)
                        Return
                        'Dgv_ListPhieuMuonSach.Focus()
                    End If
                End If
            Next





            SachBus = New Sach_BUS()
            Dim Chitietphieumuonsach As Sach_DTO
            Chitietphieumuonsach = New Sach_DTO()


            'If Dgv_ListPhieuMuonSach.Rows.Count + Dgv_ListPhieuMuonSach1.Rows.Count > 6 Then
            '    'Dgv_ListPhieuMuonSach1.AllowUserToDeleteRows = True
            '    MessageBox.Show("Chỉ mượn tối đa 5 quyển trong 4 ngày.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Dgv_ListPhieuMuonSach.Rows.RemoveAt(e.RowIndex)
            '    Return
            'End If


            Dim x = Dgv_ListSachTra.Rows(e.RowIndex).Cells(0).Value


            Dim Sach1 = New Sach_DTO()
            Dim result As Result
            result = SachBus.selectALL_ByMaSach(x, Chitietphieumuonsach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sach các sách theo mã không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)

                Return
            End If
            If Chitietphieumuonsach.TenSach = "" Then
                MessageBox.Show("Không tồn tại mã sách.")
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
                If (Chitietphieumuonsach.TinhTrang = "DangMuon") Then
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
        Dim PhieuTraSach As NhanTraSach_DTO
        PhieuTraSach = New NhanTraSach_DTO()


        '1. Mapping data from GUI control
        PhieuTraSach.MaTraSach = Txt_MaPhieuTraSach.Text
        PhieuTraSach.MaDocGia = Txt_MaDocGia.Text
        PhieuTraSach.NgayTra = Dtp_NgayTra.Value
        'PhieuMuonSach.NgayDuKienTra = Dtp_NgayMuon.Value.AddDays(4)

        '2. Business .....

        If (PhieuTraSachBus.isValidMaDocGia(PhieuTraSach) = False) Then
            MessageBox.Show("Mã độc giả không được trống")
            Txt_MaDocGia.Focus()
            Return
        End If

        'If (Txt_TinhTrangThe.Text = "Hết Hạn") Then
        '    MessageBox.Show("Thẻ đã hết hạn")
        '    Return
        'End If

        'For Each x As DataGridViewRow In Dgv_ListSachTra.Rows

        '    For Each z As DataGridViewRow In Dgv_ListSachDangMuon.Rows
        '        If (Dgv_ListSachTra.Item(0, x.Index).Value <> Dgv_ListSachDangMuon(0, z.Index).Value) Then
        '            MessageBox.Show("Độc giả không mượn một trong số những sách này")
        '        Else
        '            Exit For
        '        End If
        '    Next

        'Next



        For Each x As DataGridViewRow In Dgv_ListSachTra.Rows

            If (Dgv_ListSachTra.Item(4, x.Index).Value = " ") Then
                MessageBox.Show("Có sách độc giả không mượn")
                Return
            End If
        Next




        '3. Insert to DB
        Dim result As Result
        result = PhieuTraSachBus.insert(PhieuTraSach, listChiTietPhieuTraSach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu Mượn Sách  thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set Madocgia auto
            Dim nextMaPhieuTraSach = "1"
            result = PhieuTraSachBus.getNextID(nextMaPhieuTraSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy tự động Mã Phiếu Mượn Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Dgv_ListSachTra.Rows.Clear()
            'Dgv_ListSachDangMuon.Rows.Clear()

        Else
            MessageBox.Show("Thêm Phiếu Mượn Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class