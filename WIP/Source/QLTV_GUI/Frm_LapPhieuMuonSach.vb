Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_LapPhieuMuonSach
    Private PhieuMuonSachBus As PhieuMuonSach_BUS
    Private DocGiaBus As DocGiaBUS
    Private SachBus As Sach_BUS
    Private ChiTietPhieuMuonSachBUS As ChiTietPhieuMuonSach_BUS
    Private listChiTietPhieuMuonSach As List(Of ChiTietPhieuMuonSach_DTO)
    Private listChiTietPhieuMuonSach1 As List(Of ChiTietPhieuMuonSach_DTO)
    Private Sub Frm_LapPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PhieuMuonSachBus = New PhieuMuonSach_BUS()
        DocGiaBus = New DocGiaBUS()
        SachBus = New Sach_BUS()
        ChiTietPhieuMuonSachBUS = New ChiTietPhieuMuonSach_BUS()
        listChiTietPhieuMuonSach = New List(Of ChiTietPhieuMuonSach_DTO)
        listChiTietPhieuMuonSach1 = New List(Of ChiTietPhieuMuonSach_DTO)
        Dim listSach = New List(Of Sach_DTO)

        'Dim listPhieuMuonSach = New List(Of PhieuMuonSach_DTO)

        'Dim result As Result
        'result = PhieuMuonSach.selectAll(listPhieuMuonSach)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If
        'cb_MaDocGia.DataSource = New BindingSource(listPhieuMuonSach, String.Empty)
        'cb_MaDocGia.DisplayMember = "HoVaTen"
        'cb_MaDocGia.ValueMember = "MaDocGia"
        ''Txt_HoVaTen.DataBindings = New BindingSource(listPhieuMuonSach, String.Empty)


        ''lấy ls
        'Dim listDocGia = New List(Of DocGiaDTO)

        ''Dim result As Result
        'result = DocGia.selectAll(listDocGia)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If
        'cb_MaDocGia.DataSource = New BindingSource(listDocGia, String.Empty)
        'cb_MaDocGia.DisplayMember = "MaDocGia"
        'cb_MaDocGia.ValueMember = "HoVaTen"





        Dim result As Result
        'set MSSH auto
        Dim nextMaPhieuMuonSach = "1"
        result = PhieuMuonSachBus.getNextID(nextMaPhieuMuonSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaPhieuMuonSach.Text = nextMaPhieuMuonSach
    End Sub
    Private Sub loadListDocGia(ByRef MaDocGia As Integer)
        Dim Dg As DocGiaDTO
        Dg = New DocGiaDTO()

        Dim result As Result
        result = DocGiaBus.selecthovaten(MaDocGia, Dg)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        'DocGia.isValidHethan(Dg)
        If (DocGiaBus.isValidHethan(Dg) = False) Then
            Txt_TinhTrangThe.Text = "Hết Hạn"
        Else Txt_TinhTrangThe.Text = "Còn Hạn"
        End If
        If Dg.HoVaTen = "" Then
            MessageBox.Show("Không tồn tại mã độc giả.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            Dim Cl_MaSach1 = New DataGridViewTextBoxColumn()
            Cl_MaSach1.Name = "Cl_MaSach"
            Cl_MaSach1.HeaderText = "Mã Sách"
            Cl_MaSach1.DataPropertyName = "MaSach"
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_MaSach1)


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
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_TenSach1)


            Dim Cl_TheLoaiSach1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TheLoaiSach1.Name = "Cl_TheLoaiSach"
            Cl_TheLoaiSach1.HeaderText = "Thể Loại Sách"
            Cl_TheLoaiSach1.DataPropertyName = "TheLoaiSach"
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_TheLoaiSach1)

            Dim Cl_TenTacGia1 = New DataGridViewTextBoxColumn()
            Cl_TenTacGia1.Name = "Cl_TenTacGia"
            Cl_TenTacGia1.HeaderText = "Tên Tác Giả"
            Cl_TenTacGia1.DataPropertyName = "TenTacGia"
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_TenTacGia1)

            Dim Cl_TinhTrang1 = New DataGridViewTextBoxColumn()
            Cl_TinhTrang1.Name = "Cl_TinhTrang "
            Cl_TinhTrang1.HeaderText = "Tình Trạng"
            Cl_TinhTrang1.DataPropertyName = "TinhTrang"
            Dgv_ListPhieuMuonSach1.Columns.Add(Cl_TinhTrang1)




            Dim Cl_NgayDuKienTra = New DataGridViewTextBoxColumn()
                Cl_NgayDuKienTra.Name = "Cl_NgayDuKienTra "
                Cl_NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả"
                Cl_NgayDuKienTra.DataPropertyName = "NgayDuKienTra"
                Dgv_ListPhieuMuonSach1.Columns.Add(Cl_NgayDuKienTra)


            'listChiTietPhieuMuonSach.Clear()
            For Each x As DataGridViewRow In Dgv_ListPhieuMuonSach1.Rows
                If (Dgv_ListPhieuMuonSach1.Item(4, x.Index).Value = "Đã Quá Hạn") Then
                    x.DefaultCellStyle.BackColor = Color.Pink
                End If
                If (Dgv_ListPhieuMuonSach1.Item(4, x.Index).Value = "DangMuon") Then
                    x.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next

        End If
        ' Dgv_ListPhieuMuonSach.Rows.Add()
        'listChiTietPhieuMuonSach.Clear()
    End Sub

    'Private Sub loadListSach(MaSach As String)
    '    Dim tensach As String
    '    tensach = ""

    '    Dim theloai As String
    '    theloai = ""

    '    Dim tacgia As String
    '    tacgia = ""


    '    Dim result As Result
    '    result = Sach.select_ByMaSach(MaSach, tensach, theloai, tacgia)
    '    If (result.FlagResult = False) Then
    '        MessageBox.Show("Lấy danh sách độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '        Return
    '    End If




    'End Sub

    'Private Sub Cb_MaDocGia_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Try
    '        Dim MaDocGia = cb_MaDocGia.Text
    '        loadListDocGia(MaDocGia)

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub Dgv_ListPhieuMuonSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim currentRowIndex As Integer = Dgv_ListPhieuMuonSach.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListPhieuMuonSach.RowCount) Then
            Try

            Catch ex As Exception
            End Try
        End If
        If e.ColumnIndex = 1 And e.RowIndex = currentRowIndex Then
            'Do any thing
            If (-1 < currentRowIndex And currentRowIndex < Dgv_ListPhieuMuonSach.RowCount) Then
                Try
                    MsgBox("yes")

                Catch ex As Exception
                End Try
            End If

        End If


        'Try
        '    Dim MaSach = Cl_MaSach.ValueMember

        '    loadListSach(MaSach)

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Txt_MaDocGia_TextChanged(sender As Object, e As EventArgs) Handles Txt_MaDocGia.TextChanged
        Dim MaDocGia As String
        'listChiTietPhieuMuonSach.Clear()
        'Dgv_ListPhieuMuonSach.DataSource = Nothing
        'Dgv_ListPhieuMuonSach.Refresh()

        If Txt_MaDocGia.Text <> "" Then
            MaDocGia = Txt_MaDocGia.Text
            loadListDocGia(MaDocGia)
        End If

    End Sub



    Private Sub Dgv_ListPhieuMuonSach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListPhieuMuonSach.CellValueChanged
        If (e.RowIndex <> -1 And e.ColumnIndex = 1) Then
            SachBus = New Sach_BUS()
            Dim a, b, c As String
            Dim d As DateTime
            a = ""
            b = ""
            c = ""

            Dim x = Dgv_ListPhieuMuonSach.Rows(e.RowIndex).Cells(1).Value


            Dim Sach1 = New Sach_DTO()
            Dim result As Result
            result = SachBus.selectALL_ByMaSach(x, a, b, c, d)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sach các sách theo mã không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)

                Return
            End If
            If a = "" Then
                MessageBox.Show("Không tồn tại mã độc giả.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'x = Dgv_ListPhieuMuonSach.Rows(e.RowIndex).Cells(1).Value
                Dgv_ListPhieuMuonSach.Focus()
            Else

                Dgv_ListPhieuMuonSach.Item("Cl_TenSach", e.RowIndex).Value = a
                Dgv_ListPhieuMuonSach.Item("Cl_TheLoai", e.RowIndex).Value = b
                Dgv_ListPhieuMuonSach.Item("Cl_TacGia", e.RowIndex).Value = c
                Dgv_ListPhieuMuonSach.Item("Cl_NgayDuKienTra", e.RowIndex).Value = d
                Dgv_ListPhieuMuonSach.Item("Cl_STT", e.RowIndex).Value = e.RowIndex + 1
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


        '1. Mapping data from GUI control
        PhieuMuonSach.MaPhieuMuonSach = Txt_MaPhieuMuonSach.Text
        PhieuMuonSach.MaDocGia = Txt_MaDocGia.Text
        PhieuMuonSach.NgayMuon = Dtp_NgayMuon.Value
        PhieuMuonSach.NgayDuKienTra = Dtp_NgayMuon.Value.AddDays(4)

        '2. Business .....





        '3. Insert to DB
        Dim result As Result
        result = PhieuMuonSachBus.insert(PhieuMuonSach, listChiTietPhieuMuonSach1)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu Mượn Sách  thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set Madocgia auto
            Dim nextMaPhieuMuonSach = "1"
            result = PhieuMuonSachBus.getNextID(nextMaPhieuMuonSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy tự động Mã Phiếu Mượn Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Thêm Phiếu Mượn Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class