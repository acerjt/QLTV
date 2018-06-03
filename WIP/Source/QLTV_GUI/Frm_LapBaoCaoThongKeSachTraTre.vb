Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility


Public Class Frm_LapBaoCaoThongKeSachTraTre

    ' Private listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)
    Private listChiTiet1 As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)
    Private listChiTiet2 As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)
    Private BaoCaoThongKeSachTraTreBUS As BaoCaoThongKeSachTraTre_BUS
    ' Private TheLoaiBUS As TheLoaiSach_BUS
    Private ChiTietBUS As ChiTietBaoCaoThongKeSachTraTre_BUS
    Private Sub Frm_LapBaoCaoThongKeSachTraTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaoCaoThongKeSachTraTreBUS = New BaoCaoThongKeSachTraTre_BUS()
        'TheLoaiBUS = New TheLoaiSach_BUS()
        ChiTietBUS = New ChiTietBaoCaoThongKeSachTraTre_BUS()
        ' listChiTiet = New List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)
        ' listChiTiet1 = New List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)
        ' Load LoaiDocGia list
        Dim listTheLoaiSach = New List(Of TheLoaiSach_DTO)

        Dim result As Result
        'set MSSH auto
        Dim nextMaBaoCaoThongKeSachTraTre = "1"
        result = BaoCaoThongKeSachTraTreBUS.getNextID(nextMaBaoCaoThongKeSachTraTre)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã báo cáo thống kê mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaLapBaoCao.Text = nextMaBaoCaoThongKeSachTraTre
        'result = TheLoaiBUS.selectAll(listTheLoaiSach)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'End If


        ''Dgv_ListBaoCaoThongKe.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        'Cl_TenTheLoai.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        'Cl_TenTheLoai.DisplayMember = "TenTheLoaiSach"
        'Cl_TenTheLoai.ValueMember = "MaTheLoaiSach"

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
    Private Sub Txt_Nam_TextChanged(sender As Object, e As EventArgs) Handles Txt_Nam.TextChanged

        'listChiTietPhieuMuonSach.Clear()
        'Dgv_ListPhieuMuonSach.DataSource = Nothing
        'Dgv_ListPhieuMuonSach.Refresh()
        'Txt_TongSoLuotMuon.Text = String.Empty
        'Dgv_ListLapBaoCaoThongKe.Rows.Clear()
        If Txt_Nam.Text.Length = 4 And Cb_Thang.Text = "" Then
            loadListChiTiet(Txt_Nam.Text)
        Else
            If Txt_Nam.Text.Length = 4 And Cb_Thang.Text.Length <> 0 Then
                loadListChiTiet2(Txt_Nam.Text, Cb_Thang.Text)
            End If
        End If

    End Sub
    Private Sub loadListChiTiet(ByRef Nam As Integer)

        listChiTiet1 = New List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)
        Dim result As Result
        result = ChiTietBUS.LoadListChiTietByNam(Nam, listChiTiet1)
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

            Dim Cl_TenSach = New DataGridViewTextBoxColumn()
            Cl_TenSach.Name = "Cl_TenSach"
            Cl_TenSach.HeaderText = "Tên Sách"
            Cl_TenSach.DataPropertyName = "TenSach"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TenSach)


            'Dim Cl_TheLoaiSach = New DataGridView()
            'Dim clLoaiHS = New DataGridView()
            'clLoaiHS.Name = "LoaiHS"
            'clLoaiHS.HeaderText = "Tên Loại"
            'clLoaiHS.DataPropertyName = "LoaiHS"
            'dgvListHS.Columns.Add(clLoaiHS)

            Dim Cl_NgayMuon = New DataGridViewTextBoxColumn()
            Cl_NgayMuon.Name = "Cl_NgayMuon"
            Cl_NgayMuon.HeaderText = "Ngày Mượn"
            Cl_NgayMuon.DataPropertyName = "NgayMuon"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_NgayMuon)


            Dim Cl_SoNgayTraTre = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_SoNgayTraTre.Name = "Cl_SoNgayTraTre"
            Cl_SoNgayTraTre.HeaderText = "Số Ngày Trả Trễ"
            Cl_SoNgayTraTre.DataPropertyName = "SoNgayTraTre"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_SoNgayTraTre)

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

        listChiTiet1 = New List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)
        listChiTiet2 = New List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)
        Dim result As Result
        'result = ChiTietBUS.LoadListChiTietByNam(Nam, listChiTiet1)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách độc giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'End If

        result = ChiTietBUS.selecListChiTiet(Nam, Thang, listChiTiet2)

        If (result.FlagResult = True) Then

            'Dgv_ListPhieuMuonSach.Columns.Clear()
            'Dgv_ListPhieuMuonSach.DataSource = Nothing

            'Dgv_ListPhieuMuonSach.AutoGenerateColumns = False
            Dgv_ListLapBaoCaoThongKe.Columns.Clear()
            Dgv_ListLapBaoCaoThongKe.DataSource = Nothing

            Dgv_ListLapBaoCaoThongKe.AutoGenerateColumns = False
            Dgv_ListLapBaoCaoThongKe.AllowUserToAddRows = False
            Dgv_ListLapBaoCaoThongKe.DataSource = listChiTiet2

            Dim Cl_TenSach = New DataGridViewTextBoxColumn()
            Cl_TenSach.Name = "Cl_TenSach"
            Cl_TenSach.HeaderText = "Tên Sách"
            Cl_TenSach.DataPropertyName = "TenSach"
            Dgv_ListLapBaoCaoThongKe.Columns.Add(Cl_TenSach)


            'Dim Cl_TheLoaiSach = New DataGridView()
            'Dim clLoaiHS = New DataGridView()
            'clLoaiHS.Name = "LoaiHS"
            'clLoaiHS.HeaderText = "Tên Loại"
            'clLoaiHS.DataPropertyName = "LoaiHS"
            'dgvListHS.Columns.Add(clLoaiHS)

            Dim Cl_NgayMuon = New DataGridViewTextBoxColumn()
            Cl_NgayMuon.Name = "Cl_NgayMuon"
            Cl_NgayMuon.HeaderText = "Ngày Mượn"
            Cl_NgayMuon.DataPropertyName = "NgayMuon"
            Dgv_ListLapBaoCaoThongKe.Columns.Add(Cl_NgayMuon)


            Dim Cl_SoNgayTraTre = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_SoNgayTraTre.Name = "Cl_SoNgayTraTre"
            Cl_SoNgayTraTre.HeaderText = "Số Ngày Trả Trễ"
            Cl_SoNgayTraTre.DataPropertyName = "SoNgayTraTre"
            Dgv_ListLapBaoCaoThongKe.Columns.Add(Cl_SoNgayTraTre)

            'Dim Cl_Thang = New DataGridViewTextBoxColumn()
            'Cl_Thang.Name = "Cl_Thang"
            'Cl_Thang.HeaderText = "Tháng"
            'Cl_Thang.DataPropertyName = "Thang"
            'Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Thang)


            'Dim Cl_Nam = New DataGridViewTextBoxColumn()
            'Cl_Nam.Name = "Cl_Nam"
            'Cl_Nam.HeaderText = "Năm"
            'Cl_Nam.DataPropertyName = "Nam"
            'Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Nam)

        End If




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

            Dim Cl_TenSach = New DataGridViewTextBoxColumn()
            Cl_TenSach.Name = "Cl_TenSach"
            Cl_TenSach.HeaderText = "Tên Sách"
            Cl_TenSach.DataPropertyName = "TenSach"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TenSach)


            'Dim Cl_TheLoaiSach = New DataGridView()
            'Dim clLoaiHS = New DataGridView()
            'clLoaiHS.Name = "LoaiHS"
            'clLoaiHS.HeaderText = "Tên Loại"
            'clLoaiHS.DataPropertyName = "LoaiHS"
            'dgvListHS.Columns.Add(clLoaiHS)

            Dim Cl_NgayMuon = New DataGridViewTextBoxColumn()
            Cl_NgayMuon.Name = "Cl_NgayMuon"
            Cl_NgayMuon.HeaderText = "Ngày Mượn"
            Cl_NgayMuon.DataPropertyName = "NgayMuon"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_NgayMuon)


            Dim Cl_SoNgayTraTre = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_SoNgayTraTre.Name = "Cl_SoNgayTraTre"
            Cl_SoNgayTraTre.HeaderText = "Số Ngày Trả Trễ"
            Cl_SoNgayTraTre.DataPropertyName = "SoNgayTraTre"
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_SoNgayTraTre)

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
    Private Sub Cb_Thang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Thang.SelectedIndexChanged
        If (Txt_Nam.Text.Length = 4) Then

            Try
                Dim Thang = Cb_Thang.Text
                loadListChiTiet2(Txt_Nam.Text, Thang)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Cb_Thang_TextChanged(sender As Object, e As EventArgs) Handles Cb_Thang.TextChanged
        Dgv_ListBaoCaoThongKe.DataSource = Nothing
        If (Txt_Nam.Text.Length = 4) Then
            Try
                Dim Thang = Cb_Thang.Text
                loadListChiTiet2(Txt_Nam.Text, Thang)
            Catch ex As Exception

            End Try
        End If
        If (Cb_Thang.Text = "" And Txt_Nam.Text.Length = 4) Then
            loadListChiTiet(Txt_Nam.Text)
        End If
    End Sub

    Private Sub Btn_LapBaoCao_Click(sender As Object, e As EventArgs) Handles Btn_LapBaoCao.Click
        Dim BaoCaoThongKeSachTraTre As BaoCaoThongKeSachTraTre_DTO
        BaoCaoThongKeSachTraTre = New BaoCaoThongKeSachTraTre_DTO()


        '1. Mapping data from GUI control
        BaoCaoThongKeSachTraTre.MaBaoCaoSachTreTre = Txt_MaLapBaoCao.Text
        BaoCaoThongKeSachTraTre.Nam = Txt_Nam.Text
        BaoCaoThongKeSachTraTre.Thang = Cb_Thang.Text
        BaoCaoThongKeSachTraTre.NgayLap = Dtp_NgayLap.Value

        '2. Business .....
        If (Dgv_ListLapBaoCaoThongKe.Rows.Count = 0) Then
            MessageBox.Show("Không có dữ liệu để lập báo cáo")
            Return
        End If
        If (Dgv_ListBaoCaoThongKe.Rows.Count = Dgv_ListLapBaoCaoThongKe.Rows.Count) Then
            MessageBox.Show("Báo cáo đã lập")
            Return
        End If
        If (BaoCaoThongKeSachTraTreBUS.isValidNam(BaoCaoThongKeSachTraTre) = False) Then
            MessageBox.Show("Năm Không Hợp Lệ")
            Txt_Nam.Focus()
            Return
        End If

        'If (Txt_TinhTrangThe.Text = "Hết Hạn") Then
        '    MessageBox.Show("Thẻ đã hết hạn")
        '    Return
        'End If






        'For Each x As DataGridViewRow In Dgv_ListPhieuMuonSach.Rows

        '    If (Dgv_ListPhieuMuonSach.Item(4, x.Index).Value = "DangMuon") Then
        '        MessageBox.Show("Sách đã có người mượn")
        '        Return
        '    End If
        'Next




        '3. Insert to DB
        Dim result As Result
        result = BaoCaoThongKeSachTraTreBUS.insert(BaoCaoThongKeSachTraTre, listChiTiet2)
        If (result.FlagResult = True) Then
            MessageBox.Show("Lập Báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set Madocgia auto
            Dim nextMaBaoCaoThongKeSachTraTre = "1"
            result = BaoCaoThongKeSachTraTreBUS.getNextID(nextMaBaoCaoThongKeSachTraTre)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy tự động Mã lập báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaLapBaoCao.Text = nextMaBaoCaoThongKeSachTraTre
            ' Dtp_NgayMuon.Value = ""   
            Txt_Nam.Text = String.Empty
            Cb_Thang.Text = String.Empty
            'Txt_TongSoLuot=Muon.Text = String.Empty
            listChiTiet2.Clear()
            Dgv_ListLapBaoCaoThongKe.DataSource = Nothing
        Else
            MessageBox.Show("Thêm Phiếu Mượn Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class