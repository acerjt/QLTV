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
            Frm_Information.m.Text = "Lấy tự động mã báo cáo thống kê mượn sách không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaLapBaoCao.Text = nextMaBaoCaoThongKeSachTraTre
        Dtp_NgayLap.Value = DateTime.Now
    End Sub
    Private Sub Txt_Nam_TextChanged(sender As Object, e As EventArgs) Handles Txt_Nam.TextChanged

        Dgv_ListLapBaoCaoThongKe.DataSource = Nothing
        Dgv_ListBaoCaoThongKe.DataSource = Nothing
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
            Dgv_ListBaoCaoThongKe.ColumnHeadersHeight = 50

            Dim Cl_TenSach = New DataGridViewTextBoxColumn()
            Cl_TenSach.Name = "Cl_TenSach"
            Cl_TenSach.HeaderText = "Tên Sách"
            Cl_TenSach.DataPropertyName = "TenSach"
            Cl_TenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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

            Cl_NgayMuon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
            Dgv_ListLapBaoCaoThongKe.ColumnHeadersHeight = 50

            Dim Cl_TenSach = New DataGridViewTextBoxColumn()
            Cl_TenSach.Name = "Cl_TenSach"
            Cl_TenSach.HeaderText = "Tên Sách"
            Cl_TenSach.DataPropertyName = "TenSach"

            Cl_TenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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

            Cl_NgayMuon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Dgv_ListLapBaoCaoThongKe.Columns.Add(Cl_NgayMuon)


            Dim Cl_SoNgayTraTre = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_SoNgayTraTre.Name = "Cl_SoNgayTraTre"
            Cl_SoNgayTraTre.HeaderText = "Số Ngày Trả Trễ"
            Cl_SoNgayTraTre.DataPropertyName = "SoNgayTraTre"
            Dgv_ListLapBaoCaoThongKe.Columns.Add(Cl_SoNgayTraTre)


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
            Dgv_ListBaoCaoThongKe.ColumnHeadersHeight = 50

            Dim Cl_TenSach = New DataGridViewTextBoxColumn()
            Cl_TenSach.Name = "Cl_TenSach"
            Cl_TenSach.HeaderText = "Tên Sách"
            Cl_TenSach.DataPropertyName = "TenSach"

            Cl_TenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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

            Cl_NgayMuon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
        Dgv_ListLapBaoCaoThongKe.DataSource = Nothing
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
        If Txt_Nam.Text = "" Then
            Frm_Information.m.Text = "Chưa Nhập Năm."
            Frm_Information.ShowDialog()
            Return
        End If
        BaoCaoThongKeSachTraTre.Nam = Txt_Nam.Text
        If Cb_Thang.Text = "" Then
            Frm_Information.m.Text = "Chưa Nhập Tháng."
            Frm_Information.ShowDialog()
            Return
        End If
        BaoCaoThongKeSachTraTre.Thang = Cb_Thang.Text
        BaoCaoThongKeSachTraTre.NgayLap = Dtp_NgayLap.Value

        '2. Business .....
        If (Dgv_ListLapBaoCaoThongKe.Rows.Count = 0) Then
            Frm_Information.m.Text = "Không có dữ liệu để lập báo cáo."
            Frm_Information.ShowDialog()
            Return
        End If
        If (Dgv_ListBaoCaoThongKe.Rows.Count = Dgv_ListLapBaoCaoThongKe.Rows.Count) Then
            Frm_Information.m.Text = "Báo cáo đã được lập."
            Frm_Information.ShowDialog()
            Return
        End If
        If (BaoCaoThongKeSachTraTreBUS.isValidNam(BaoCaoThongKeSachTraTre) = False) Then

            Frm_Information.m.Text = "Năm không hợp lệ."
            Frm_Information.ShowDialog()
            Txt_Nam.Focus()
            Return
        End If



        '3. Insert to DB
        Dim result As Result
        result = BaoCaoThongKeSachTraTreBUS.insert(BaoCaoThongKeSachTraTre, listChiTiet2)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Lập Báo Cáo thành công."
            Frm_Information.ShowDialog()
            'set Madocgia auto
            Dim nextMaBaoCaoThongKeSachTraTre = "1"
            result = BaoCaoThongKeSachTraTreBUS.getNextID(nextMaBaoCaoThongKeSachTraTre)
            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Lấy tự động Mã Lập Báo Cáo không thành công."
                Frm_Information.ShowDialog()
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
            Frm_Information.m.Text = "Thêm Phiếu Mượn Sách không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub


End Class
