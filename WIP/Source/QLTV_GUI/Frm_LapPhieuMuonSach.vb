Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_LapPhieuMuonSach
    Private PhieuMuonSachBus As PhieuMuonSach_BUS
    Private DocGiaBus As DocGia_BUS
    Private SachBus As Sach_BUS
    Private ChiTietPhieuMuonSachBUS As ChiTietPhieuMuonSach_BUS
    Private listChiTietPhieuMuonSach As List(Of Sach_DTO)
    Private listChiTietPhieuMuonSach1 As List(Of ChiTietPhieuMuonSach_DTO)
    Private Sub Frm_LapPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PhieuMuonSachBus = New PhieuMuonSach_BUS()
        DocGiaBus = New DocGia_BUS()
        SachBus = New Sach_BUS()
        ChiTietPhieuMuonSachBUS = New ChiTietPhieuMuonSach_BUS()
        listChiTietPhieuMuonSach = New List(Of Sach_DTO)
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
        Dim Dg As DocGia_DTO
        Dg = New DocGia_DTO()

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
            Cl_TheLoaiSach1.DataPropertyName = "TheLoai"
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
            Cl_NgayDuKienTra.DataPropertyName = "NgayDuKien"
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
            If (Dgv_ListPhieuMuonSach1.Item(4, x.Index).Value = "DangMuon") Then
                x.DefaultCellStyle.BackColor = Color.LightBlue
            End If
        Next
    End Sub



    Private Sub Dgv_ListPhieuMuonSach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListPhieuMuonSach.CellValueChanged
        If (e.RowIndex <> -1 And e.ColumnIndex = 0) Then
            'Dim y As PhieuMuonSach_DTO
            'y = New PhieuMuonSach_DTO()
            'If (PhieuMuonSachBus.isValidMaDocGia(y) = False) Then
            '    MessageBox.Show("Mã độc giả không được trống")
            '    Txt_MaDocGia.Focus()
            '    Return
            'End If


            For Each z As DataGridViewRow In Dgv_ListPhieuMuonSach1.Rows
                If (Dgv_ListPhieuMuonSach1.Item(0, z.Index).Value = Dgv_ListPhieuMuonSach.Rows(e.RowIndex).Cells(0).Value) Then

                    MessageBox.Show("Sách chưa được trả.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                        MessageBox.Show("Sách đã được chọn ở trên.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Dgv_ListPhieuMuonSach.Rows.RemoveAt(e.RowIndex)
                        Return
                        'Dgv_ListPhieuMuonSach.Focus()
                    End If
                End If
            Next



            SachBus = New Sach_BUS()
            Dim Chitietphieumuonsach As Sach_DTO
            Chitietphieumuonsach = New Sach_DTO()


            If Dgv_ListPhieuMuonSach.Rows.Count + Dgv_ListPhieuMuonSach1.Rows.Count > 6 Then
                'Dgv_ListPhieuMuonSach1.AllowUserToDeleteRows = True
                MessageBox.Show("Chỉ mượn tối đa 5 quyển trong 4 ngày.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dgv_ListPhieuMuonSach.Rows.RemoveAt(e.RowIndex)
                Return
            End If


            Dim x = Dgv_ListPhieuMuonSach.Rows(e.RowIndex).Cells(0).Value


            Dim Sach1 = New Sach_DTO()
            Dim result As Result
            result = SachBus.selectALL_ByMaSach(x, Chitietphieumuonsach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sach các sách theo mã không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)

                Return
            End If
            If Chitietphieumuonsach.TenSach = "" Then
                MessageBox.Show("Không tồn tại sách có mã này.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dgv_ListPhieuMuonSach.Rows.RemoveAt(e.RowIndex)
                Dgv_ListPhieuMuonSach.Focus()
            Else

                Dgv_ListPhieuMuonSach.Item("Cl_TenSach", e.RowIndex).Value = Chitietphieumuonsach.TenSach
                Dgv_ListPhieuMuonSach.Item("Cl_TheLoai", e.RowIndex).Value = Chitietphieumuonsach.TheLoai
                Dgv_ListPhieuMuonSach.Item("Cl_TinhTrang", e.RowIndex).Value = Chitietphieumuonsach.TinhTrang
                Dgv_ListPhieuMuonSach.Item("Cl_TacGia", e.RowIndex).Value = Chitietphieumuonsach.TenTacGia
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


        '1. Mapping data from GUI control
        PhieuMuonSach.MaPhieuMuonSach = Txt_MaPhieuMuonSach.Text
        PhieuMuonSach.MaDocGia = Txt_MaDocGia.Text
        PhieuMuonSach.NgayMuon = Dtp_NgayMuon.Value
        PhieuMuonSach.NgayDuKienTra = Dtp_NgayMuon.Value.AddDays(4)

        '2. Business .....
        If (PhieuMuonSachBus.isValidMaDocGia(PhieuMuonSach) = False) Then
            MessageBox.Show("Mã độc giả không được trống")
            Txt_MaDocGia.Focus()
            Return
        End If

        If (Txt_TinhTrangThe.Text = "Hết Hạn") Then
            MessageBox.Show("Thẻ đã hết hạn")
            Return
        End If

        For Each x As DataGridViewRow In Dgv_ListPhieuMuonSach1.Rows

            If (Dgv_ListPhieuMuonSach1.Item(4, x.Index).Value = "Đã Quá Hạn") Then
                MessageBox.Show("Có sách quá hạn chưa được trả")
                Return
            End If
        Next



        For Each x As DataGridViewRow In Dgv_ListPhieuMuonSach.Rows

            If (Dgv_ListPhieuMuonSach.Item(4, x.Index).Value = "DangMuon") Then
                MessageBox.Show("Sách đã có người mượn")
                Return
            End If
        Next




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