Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility


Public Class Frm_LapBaoCaoThongKeMuonSachTheoTheLoai
    Private listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)
    Private listChiTiet1 As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)
    Private BaoCaoThongKeMuonSachBUS As BaoCaoMuonSachTheoThang_BUS
    Private TheLoaiBUS As TheLoaiSach_BUS
    Private ChiTietBUS As ChiTietBaoCaoMuonSachTheoThang_BUS
    Private Sub Frm_LapBaoCaoThongKeMuonSachTheoTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaoCaoThongKeMuonSachBUS = New BaoCaoMuonSachTheoThang_BUS()
        TheLoaiBUS = New TheLoaiSach_BUS()
        ChiTietBUS = New ChiTietBaoCaoMuonSachTheoThang_BUS()
        listChiTiet = New List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)
        listChiTiet1 = New List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)
        ' Load LoaiDocGia list
        Dim listTheLoaiSach = New List(Of TheLoaiSach_DTO)

        Dim result As Result
        'set MSSH auto
        Dim nextMaBaoCaoThongKeMuonSachTheoTheLoai = "1"
        result = BaoCaoThongKeMuonSachBUS.getNextID(nextMaBaoCaoThongKeMuonSachTheoTheLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã báo cáo thống kê mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaLapBaoCao.Text = nextMaBaoCaoThongKeMuonSachTheoTheLoai
        result = TheLoaiBUS.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If


        'Dgv_ListBaoCaoThongKe.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cl_TenTheLoai.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cl_TenTheLoai.DisplayMember = "TenTheLoaiSach"
        Cl_TenTheLoai.ValueMember = "MaTheLoaiSach"

        'result = ChiTietBUS.SelectAll(listChiTiet1)

        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy tất cả báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'Else
        '    Dgv_ListBaoCaoThongKe.Columns.Clear()
        '    Dgv_ListBaoCaoThongKe.DataSource = Nothing

        '    Dgv_ListBaoCaoThongKe.AutoGenerateColumns = False
        '    Dgv_ListBaoCaoThongKe.AllowUserToAddRows = False
        '    Dgv_ListBaoCaoThongKe.DataSource = listChiTiet1

        '    Dim Cl_TenTheLoai1 = New DataGridViewTextBoxColumn()
        '    Cl_TenTheLoai1.Name = "Cl_TenTheLoai1"
        '    Cl_TenTheLoai1.HeaderText = "Tên Thể Loại"
        '    Cl_TenTheLoai1.DataPropertyName = "TheLoai"
        '    Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TenTheLoai1)


        '    'Dim Cl_TheLoaiSach = New DataGridView()
        '    'Dim clLoaiHS = New DataGridView()
        '    'clLoaiHS.Name = "LoaiHS"
        '    'clLoaiHS.HeaderText = "Tên Loại"
        '    'clLoaiHS.DataPropertyName = "LoaiHS"
        '    'dgvListHS.Columns.Add(clLoaiHS)

        '    Dim Cl_SoLuotMuon1 = New DataGridViewTextBoxColumn()
        '    Cl_SoLuotMuon1.Name = "Cl_SoLuotMuon1"
        '    Cl_SoLuotMuon1.HeaderText = "Số Lượt Mượn"
        '    Cl_SoLuotMuon1.DataPropertyName = "SoLuotMuon"
        '    Dgv_ListBaoCaoThongKe.Columns.Add(Cl_SoLuotMuon1)


        '    Dim Cl_TyLe1 = New DataGridViewTextBoxColumn()
        '    'Dim clLoaiHS = New DataGridView()
        '    Cl_TyLe1.Name = "Cl_TyLe1"
        '    Cl_TyLe1.HeaderText = "Tỷ Lệ"
        '    Cl_TyLe1.DataPropertyName = "TyLe"
        '    Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TyLe1)

        '    Dim Cl_Thang = New DataGridViewTextBoxColumn()
        '    Cl_Thang.Name = "Cl_Thang"
        '    Cl_Thang.HeaderText = "Tháng"
        '    Cl_Thang.DataPropertyName = "Thang"
        '    Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Thang)

        '    Dim Cl_Nam = New DataGridViewTextBoxColumn()
        '    Cl_Nam.Name = "Cl_Nam"
        '    Cl_Nam.HeaderText = "Năm"
        '    Cl_Nam.DataPropertyName = "Nam"
        '    Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Nam)
        'End If







    End Sub

    Private Sub Dgv_ListBaoCaoThongKe_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListLapBaoCaoThongKe.CellValueChanged
        If (e.RowIndex <> -1 And e.ColumnIndex = 0) Then
            'Dim y As PhieuMuonSach_DTO
            'y = New PhieuMuonSach_DTO()
            'If (PhieuMuonSachBus.isValidMaDocGia(y) = False) Then
            '    MessageBox.Show("Mã độc giả không được trống")
            '    Txt_MaDocGia.Focus()
            '    Return
            'End If

            For Each y As DataGridViewRow In Dgv_ListLapBaoCaoThongKe.Rows
                If e.RowIndex = 0 Then
                    Exit For
                Else
                    If (Dgv_ListLapBaoCaoThongKe.Item(0, y.Index).Value = Dgv_ListLapBaoCaoThongKe.Rows(e.RowIndex).Cells(0).Value And y.Index <> e.RowIndex) Then
                        MessageBox.Show("Sách đã được chọn ở trên.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Dgv_ListLapBaoCaoThongKe.Rows.RemoveAt(e.RowIndex)
                        Return
                        'Dgv_ListPhieuMuonSach.Focus()
                    End If
                End If
            Next



            'SachBus = New Sach_BUS()
            Dim ChiTiet As ChiTietBaoCaoMuonSachTheoThang_DTO
            ChiTiet = New ChiTietBaoCaoMuonSachTheoThang_DTO()




            If Dgv_ListLapBaoCaoThongKe.Rows.Count > 4 Then
                'Dgv_ListPhieuMuonSach1.AllowUserToDeleteRows = True
                MessageBox.Show("Số lượng thể loại cần lập báo cáo đã vượt quá qui định.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dgv_ListLapBaoCaoThongKe.Rows.RemoveAt(e.RowIndex)
                Return
            End If


            Dim TheLoai = Dgv_ListLapBaoCaoThongKe.Rows(e.RowIndex).Cells(0).Value


            'Dim Sach1 = New Sach_DTO()
            Dim result As Result
            result = ChiTietBUS.selecListChiTiet(TheLoai, Txt_Nam.Text, Cb_Thang.Text, ChiTiet, Txt_TongSoLuotMuon.Text)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sach các sách theo mã không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)

                Return
            End If
            If ChiTiet.TheLoai = "" Then
                MessageBox.Show("Không tồn tại thể loại này.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dgv_ListLapBaoCaoThongKe.Rows.RemoveAt(e.RowIndex)
                Dgv_ListLapBaoCaoThongKe.Focus()
            Else

                Dgv_ListLapBaoCaoThongKe.Item("Cl_SoLuotMuon", e.RowIndex).Value = ChiTiet.SoLuotMuon
                Dgv_ListLapBaoCaoThongKe.Item("Cl_TiLe", e.RowIndex).Value = ChiTiet.TyLe

                'Dgv_ListPhieuMuonSach.Item("Cl_TinhTrang", e.RowIndex).Value = Chitietphieumuonsach.TinhTrang
                'Dgv_ListPhieuMuonSach.Item("Cl_TacGia", e.RowIndex).Value = Chitietphieumuonsach.TenTacGia
                'Dgv_ListPhieuMuonSach.Item("Cl_NgayDuKienTra", e.RowIndex).Value = Chitietphieumuonsach.NgayDuKien
                ' Dgv_ListPhieuMuonSach.Item("Cl_STT", e.RowIndex).Value = e.RowIndex + 1
                If (listChiTiet.Count() = e.RowIndex) Then
                    listChiTiet.Add(New ChiTietBaoCaoMuonSachTheoThang_DTO(TheLoai, ChiTiet.SoLuotMuon, ChiTiet.TyLe))
                Else
                    If (listChiTiet.Count() > e.RowIndex) Then
                        listChiTiet.RemoveAt(e.RowIndex)
                        listChiTiet.Add(New ChiTietBaoCaoMuonSachTheoThang_DTO(TheLoai, ChiTiet.SoLuotMuon, ChiTiet.TyLe))
                    End If
                End If
            End If
        End If


    End Sub



    Private Sub Txt_Nam_TextChanged(sender As Object, e As EventArgs) Handles Txt_Nam.TextChanged

        'listChiTietPhieuMuonSach.Clear()
        'Dgv_ListPhieuMuonSach.DataSource = Nothing
        'Dgv_ListPhieuMuonSach.Refresh()
        Txt_TongSoLuotMuon.Text = String.Empty
        Dgv_ListLapBaoCaoThongKe.Rows.Clear()
        If Txt_Nam.Text.Length = 4 And Cb_Thang.Text = "" Then
            loadListChiTiet(Txt_Nam.Text)
        Else
            If Txt_Nam.Text.Length = 4 And Cb_Thang.Text.Length <> 0 Then
                loadListChiTiet2(Txt_Nam.Text, Cb_Thang.Text)
            End If
        End If

    End Sub


    Private Sub loadListChiTiet(ByRef Nam As Integer)

        listChiTiet1 = New List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)
        Dim result As Result
        'result = ChiTietBUS.LoadListChiTietByNam(Nam, listChiTiet1)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách độc giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'End If



        result = ChiTietBUS.LoadListChiTietByNam(Nam, listChiTiet1)
        If (result.FlagResult = True) Then

            'Dgv_ListPhieuMuonSach.Columns.Clear()
            'Dgv_ListPhieuMuonSach.DataSource = Nothing

            'Dgv_ListPhieuMuonSach.AutoGenerateColumns = False
            Dgv_ListBaoCaoThongKe.Columns.Clear()
            Dgv_ListBaoCaoThongKe.DataSource = Nothing

            Dgv_ListBaoCaoThongKe.AutoGenerateColumns = False
            Dgv_ListBaoCaoThongKe.AllowUserToAddRows = False
            Dgv_ListBaoCaoThongKe.DataSource = listChiTiet1

            Dim Cl_TenTheLoai1 = New DataGridViewTextBoxColumn()
            Cl_TenTheLoai1.Name = "Cl_TenTheLoai1"
            Cl_TenTheLoai1.HeaderText = "Tên Thể Loại"
            Cl_TenTheLoai1.DataPropertyName = "TheLoai"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TenTheLoai1)


            'Dim Cl_TheLoaiSach = New DataGridView()
            'Dim clLoaiHS = New DataGridView()
            'clLoaiHS.Name = "LoaiHS"
            'clLoaiHS.HeaderText = "Tên Loại"
            'clLoaiHS.DataPropertyName = "LoaiHS"
            'dgvListHS.Columns.Add(clLoaiHS)

            Dim Cl_SoLuotMuon1 = New DataGridViewTextBoxColumn()
            Cl_SoLuotMuon1.Name = "Cl_SoLuotMuon1"
            Cl_SoLuotMuon1.HeaderText = "Số Lượt Mượn"
            Cl_SoLuotMuon1.DataPropertyName = "SoLuotMuon"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_SoLuotMuon1)


            Dim Cl_TyLe1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TyLe1.Name = "Cl_TyLe1"
            Cl_TyLe1.HeaderText = "Tỷ Lệ"
            Cl_TyLe1.DataPropertyName = "TyLe"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TyLe1)

            Dim Cl_Thang = New DataGridViewTextBoxColumn()
            Cl_Thang.Name = "Cl_Thang"
            Cl_Thang.HeaderText = "Tháng"
            Cl_Thang.DataPropertyName = "Thang"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Thang)


            Dim Cl_Nam = New DataGridViewTextBoxColumn()
            Cl_Nam.Name = "Cl_Nam"
            Cl_Nam.HeaderText = "Năm"
            Cl_Nam.DataPropertyName = "Nam"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Nam)

        End If

        ' Dgv_ListPhieuMuonSach.Rows.Add()
        'listChiTietPhieuMuonSach.Clear()
    End Sub

    Private Sub loadListChiTiet2(ByRef Nam As Integer, ByRef Thang As Integer)

        listChiTiet1 = New List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)
        Dim result As Result
        'result = ChiTietBUS.LoadListChiTietByNam(Nam, listChiTiet1)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách độc giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'End If



        result = ChiTietBUS.LoadListChiTietByNam_ByThang(Nam, Thang, listChiTiet1)
        If (result.FlagResult = True) Then

            'Dgv_ListPhieuMuonSach.Columns.Clear()
            'Dgv_ListPhieuMuonSach.DataSource = Nothing

            'Dgv_ListPhieuMuonSach.AutoGenerateColumns = False
            Dgv_ListBaoCaoThongKe.Columns.Clear()
            Dgv_ListBaoCaoThongKe.DataSource = Nothing

            Dgv_ListBaoCaoThongKe.AutoGenerateColumns = False
            Dgv_ListBaoCaoThongKe.AllowUserToAddRows = False
            Dgv_ListBaoCaoThongKe.DataSource = listChiTiet1

            Dim Cl_TenTheLoai1 = New DataGridViewTextBoxColumn()
            Cl_TenTheLoai1.Name = "Cl_TenTheLoai1"
            Cl_TenTheLoai1.HeaderText = "Tên Thể Loại"
            Cl_TenTheLoai1.DataPropertyName = "TheLoai"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TenTheLoai1)


            'Dim Cl_TheLoaiSach = New DataGridView()
            'Dim clLoaiHS = New DataGridView()
            'clLoaiHS.Name = "LoaiHS"
            'clLoaiHS.HeaderText = "Tên Loại"
            'clLoaiHS.DataPropertyName = "LoaiHS"
            'dgvListHS.Columns.Add(clLoaiHS)

            Dim Cl_SoLuotMuon1 = New DataGridViewTextBoxColumn()
            Cl_SoLuotMuon1.Name = "Cl_SoLuotMuon1"
            Cl_SoLuotMuon1.HeaderText = "Số Lượt Mượn"
            Cl_SoLuotMuon1.DataPropertyName = "SoLuotMuon"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_SoLuotMuon1)


            Dim Cl_TyLe1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TyLe1.Name = "Cl_TyLe1"
            Cl_TyLe1.HeaderText = "Tỷ Lệ"
            Cl_TyLe1.DataPropertyName = "TyLe"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TyLe1)

            Dim Cl_Thang = New DataGridViewTextBoxColumn()
            Cl_Thang.Name = "Cl_Thang"
            Cl_Thang.HeaderText = "Tháng"
            Cl_Thang.DataPropertyName = "Thang"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Thang)


            Dim Cl_Nam = New DataGridViewTextBoxColumn()
            Cl_Nam.Name = "Cl_Nam"
            Cl_Nam.HeaderText = "Năm"
            Cl_Nam.DataPropertyName = "Nam"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Nam)

        End If

        ' Dgv_ListPhieuMuonSach.Rows.Add()
        'listChiTietPhieuMuonSach.Clear()
    End Sub

    Private Sub Btn_LapBaoCao_Click(sender As Object, e As EventArgs) Handles Btn_LapBaoCao.Click
        Dim BaoCaoThongKeMuonSach As BaoCaoMuonSachTheoThang_DTO
        BaoCaoThongKeMuonSach = New BaoCaoMuonSachTheoThang_DTO()


        '1. Mapping data from GUI control
        BaoCaoThongKeMuonSach.MaBaoCaoMuonSachTheoThang = Txt_MaLapBaoCao.Text
        BaoCaoThongKeMuonSach.Nam = Txt_Nam.Text
        BaoCaoThongKeMuonSach.Thang = Cb_Thang.Text
        BaoCaoThongKeMuonSach.TongSoLuotMuon = Txt_TongSoLuotMuon.Text

        '2. Business .....
        If (BaoCaoThongKeMuonSachBUS.isValidNam(BaoCaoThongKeMuonSach) = False) Then
            MessageBox.Show("Năm Không Hợp Lệ")
            Txt_Nam.Focus()
            Return
        End If

        'If (Txt_TinhTrangThe.Text = "Hết Hạn") Then
        '    MessageBox.Show("Thẻ đã hết hạn")
        '    Return
        'End If


        If (Dgv_ListLapBaoCaoThongKe.Rows.Count = 0) Then
            MessageBox.Show("Không có dữ liệu để lập báo cáo")
            Return
        End If




        'For Each x As DataGridViewRow In Dgv_ListPhieuMuonSach.Rows

        '    If (Dgv_ListPhieuMuonSach.Item(4, x.Index).Value = "DangMuon") Then
        '        MessageBox.Show("Sách đã có người mượn")
        '        Return
        '    End If
        'Next




        '3. Insert to DB
        Dim result As Result
        result = BaoCaoThongKeMuonSachBUS.insert(BaoCaoThongKeMuonSach, listChiTiet)
        If (result.FlagResult = True) Then
            MessageBox.Show("Lập Báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set Madocgia auto
            Dim nextMaBaoCaoThongKeMuonSach = "1"
            result = BaoCaoThongKeMuonSachBUS.getNextID(nextMaBaoCaoThongKeMuonSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy tự động Mã lập báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaLapBaoCao.Tag = nextMaBaoCaoThongKeMuonSach
            ' Dtp_NgayMuon.Value = ""   
            Txt_Nam.Text = String.Empty
            Cb_Thang.Text = String.Empty
            Txt_TongSoLuotMuon.Text = String.Empty
            listChiTiet.Clear()
            Dgv_ListLapBaoCaoThongKe.Rows.Clear()
        Else
            MessageBox.Show("Thêm Phiếu Mượn Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub


End Class