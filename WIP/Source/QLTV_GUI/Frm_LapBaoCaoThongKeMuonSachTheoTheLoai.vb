Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility


Public Class Frm_LapBaoCaoThongKeMuonSachTheoTheLoai
    Private listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)
    Private listChiTiet1 As List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)
    Private BaoCaoThongKeMuonSachBUS As BaoCaoMuonSachTheoTheLoai_BUS
    Private TheLoaiBUS As TheLoaiSach_BUS
    Private QuyDinhBUS As QuyDinh_BUS
    Private ChiTietBUS As ChiTietBaoCaoMuonSachTheoTheLoai_BUS
    Private Sub Frm_LapBaoCaoThongKeMuonSachTheoTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaoCaoThongKeMuonSachBUS = New BaoCaoMuonSachTheoTheLoai_BUS()
        TheLoaiBUS = New TheLoaiSach_BUS()
        ChiTietBUS = New ChiTietBaoCaoMuonSachTheoTheLoai_BUS()
        QuyDinhBUS = New QuyDinh_BUS()
        listChiTiet = New List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)
        listChiTiet1 = New List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)
        ' Load LoaiDocGia list
        Dim listTheLoaiSach = New List(Of TheLoaiSach_DTO)

        Dim result As Result
        'set MSSH auto
        Dim nextMaBaoCaoThongKeMuonSachTheoTheLoai = "1"
        result = BaoCaoThongKeMuonSachBUS.getNextID(nextMaBaoCaoThongKeMuonSachTheoTheLoai)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy tự động Mã Báo Cáo thống kê Mượn Sách không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaLapBaoCao.Text = nextMaBaoCaoThongKeMuonSachTheoTheLoai
        result = TheLoaiBUS.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy danh sách Thể Loại Sách không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If


        'Dgv_ListBaoCaoThongKe.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cl_TenTheLoai.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cl_TenTheLoai.DisplayMember = "TenTheLoaiSach"
        Cl_TenTheLoai.ValueMember = "MaTheLoaiSach"

        result = ChiTietBUS.SelectAll(listChiTiet1)

        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy tất cả Báo Cáo đã lập không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Return
        Else
            Dgv_ListBaoCaoThongKe.Columns.Clear()
            Dgv_ListBaoCaoThongKe.DataSource = Nothing

            Dgv_ListBaoCaoThongKe.AutoGenerateColumns = False
            Dgv_ListBaoCaoThongKe.AllowUserToAddRows = False
            Dgv_ListBaoCaoThongKe.DataSource = listChiTiet1

            Dim Cl_TenTheLoai1 = New DataGridViewTextBoxColumn()
            Cl_TenTheLoai1.Name = "Cl_TenTheLoai1"
            Cl_TenTheLoai1.HeaderText = "Thể Loại"
            Cl_TenTheLoai1.DataPropertyName = "TheLoai"
            Cl_TenTheLoai1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TenTheLoai1)


            Dim Cl_SoLuotMuon1 = New DataGridViewTextBoxColumn()
            Cl_SoLuotMuon1.Name = "Cl_SoLuotMuon1"
            Cl_SoLuotMuon1.HeaderText = "Số Lượt Mượn"
            Cl_SoLuotMuon1.DataPropertyName = "SoLuotMuon"
            Cl_SoLuotMuon1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_SoLuotMuon1)


            Dim Cl_TyLe1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TyLe1.Name = "Cl_TyLe1"
            Cl_TyLe1.HeaderText = "Tỷ Lệ"
            Cl_TyLe1.DataPropertyName = "TyLe"
            Cl_TyLe1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TyLe1)

            Dim Cl_Thang = New DataGridViewTextBoxColumn()
            Cl_Thang.Name = "Cl_Thang"
            Cl_Thang.HeaderText = "Tháng"
            Cl_Thang.DataPropertyName = "Thang"
            Cl_Thang.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Thang)

            Dim Cl_Nam = New DataGridViewTextBoxColumn()
            Cl_Nam.Name = "Cl_Nam"
            Cl_Nam.HeaderText = "Năm"
            Cl_Nam.DataPropertyName = "Nam"
            Cl_Nam.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Nam)
        End If


        Dtp_NgayLap.Value = DateTime.Now

    End Sub

    Private Sub Dgv_ListBaoCaoThongKe_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListLapBaoCaoThongKe.CellValueChanged
        If (e.RowIndex <> -1 And e.ColumnIndex = 0) Then

            For Each y As DataGridViewRow In Dgv_ListLapBaoCaoThongKe.Rows
                If e.RowIndex = 0 Then
                    Exit For
                Else
                    If (Dgv_ListLapBaoCaoThongKe.Item(0, y.Index).Value = Dgv_ListLapBaoCaoThongKe.Rows(e.RowIndex).Cells(0).Value And y.Index <> e.RowIndex) Then
                        Frm_Information.m.Text = "Sách đã được chọn ở trên."
                        Frm_Information.ShowDialog()
                        Dgv_ListLapBaoCaoThongKe.Rows.RemoveAt(e.RowIndex)
                        Return
                        'Dgv_ListPhieuMuonSach.Focus()
                    End If
                End If
            Next

            'SachBus = New Sach_BUS()
            Dim ChiTiet As ChiTietBaoCaoMuonSachTheoTheLoai_DTO
            ChiTiet = New ChiTietBaoCaoMuonSachTheoTheLoai_DTO()

            Dim QuyDinh As QuyDinh_DTO
            QuyDinh = New QuyDinh_DTO()
            QuyDinhBUS.GetQuyDinh(QuyDinh)


            If Dgv_ListLapBaoCaoThongKe.Rows.Count > QuyDinh.SoTheLoaiSachToiDa + 1 Then
                Frm_Information.m.Text = "Số lượng Thể Loại cần lập báo cáo đã vượt quá Quy Định."
                Frm_Information.ShowDialog()

                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dgv_ListLapBaoCaoThongKe.Rows.RemoveAt(e.RowIndex)
                Return
            End If


            Dim TheLoai = Dgv_ListLapBaoCaoThongKe.Rows(e.RowIndex).Cells(0).Value


            For Each y As DataGridViewRow In Dgv_ListBaoCaoThongKe.Rows

                If (Dgv_ListBaoCaoThongKe.Item(0, y.Index).Value = Dgv_ListLapBaoCaoThongKe.Rows(e.RowIndex).Cells(0).FormattedValue) Then
                    Frm_Information.m.Text = "Thể Loại này đã được lập Báo Cáo."
                    Frm_Information.ShowDialog()
                    Dgv_ListLapBaoCaoThongKe.Rows.RemoveAt(e.RowIndex)
                    Return
                    'Dgv_ListPhieuMuonSach.Focus()
                End If

            Next

            'Dim Sach1 = New Sach_DTO()
            Dim result As Result
            result = ChiTietBUS.selecListChiTiet(TheLoai, Txt_Nam.Text, Cb_Thang.Text, ChiTiet, Txt_TongSoLuotMuon.Text)
            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Lấy danh sách các Sách theo Mã không thành công."
                Frm_Information.ShowDialog()
                System.Console.WriteLine(result.SystemMessage)

                Return
            End If
            If ChiTiet.TheLoai = "" Then
                'MessageBox.Show("Không tồn tại thể loại này.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dgv_ListLapBaoCaoThongKe.Rows(e.RowIndex).Cells(2).Value = 0
                Dgv_ListLapBaoCaoThongKe.Rows(e.RowIndex).Cells(1).Value = 0
                'Dgv_ListLapBaoCaoThongKe.Focus()



                If (listChiTiet.Count() = e.RowIndex) Then
                    listChiTiet.Add(New ChiTietBaoCaoMuonSachTheoTheLoai_DTO(TheLoai, ChiTiet.SoLuotMuon, ChiTiet.TyLe))
                Else
                    If (listChiTiet.Count() > e.RowIndex) Then
                        listChiTiet.RemoveAt(e.RowIndex)
                        listChiTiet.Add(New ChiTietBaoCaoMuonSachTheoTheLoai_DTO(TheLoai, ChiTiet.SoLuotMuon, ChiTiet.TyLe))
                    End If
                End If



            Else

                Dgv_ListLapBaoCaoThongKe.Item("Cl_SoLuotMuon", e.RowIndex).Value = ChiTiet.SoLuotMuon
                Dgv_ListLapBaoCaoThongKe.Item("Cl_TiLe", e.RowIndex).Value = ChiTiet.TyLe

                'Dgv_ListPhieuMuonSach.Item("Cl_TinhTrang", e.RowIndex).Value = Chitietphieumuonsach.TinhTrang
                'Dgv_ListPhieuMuonSach.Item("Cl_TacGia", e.RowIndex).Value = Chitietphieumuonsach.TenTacGia
                'Dgv_ListPhieuMuonSach.Item("Cl_NgayDuKienTra", e.RowIndex).Value = Chitietphieumuonsach.NgayDuKien
                ' Dgv_ListPhieuMuonSach.Item("Cl_STT", e.RowIndex).Value = e.RowIndex + 1
                If (listChiTiet.Count() = e.RowIndex) Then
                    listChiTiet.Add(New ChiTietBaoCaoMuonSachTheoTheLoai_DTO(TheLoai, ChiTiet.SoLuotMuon, ChiTiet.TyLe))
                Else
                    If (listChiTiet.Count() > e.RowIndex) Then
                        listChiTiet.RemoveAt(e.RowIndex)
                        listChiTiet.Add(New ChiTietBaoCaoMuonSachTheoTheLoai_DTO(TheLoai, ChiTiet.SoLuotMuon, ChiTiet.TyLe))
                    End If
                End If
            End If
        End If


    End Sub



    Private Sub Txt_Nam_TextChanged(sender As Object, e As EventArgs) Handles Txt_Nam.TextChanged


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

        listChiTiet1 = New List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)
        Dim result As Result

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
            Cl_TenTheLoai1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TenTheLoai1)


            Dim Cl_SoLuotMuon1 = New DataGridViewTextBoxColumn()
            Cl_SoLuotMuon1.Name = "Cl_SoLuotMuon1"
            Cl_SoLuotMuon1.HeaderText = "Số Lượt Mượn"
            Cl_SoLuotMuon1.DataPropertyName = "SoLuotMuon"
            Cl_SoLuotMuon1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_SoLuotMuon1)


            Dim Cl_TyLe1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TyLe1.Name = "Cl_TyLe1"
            Cl_TyLe1.HeaderText = "Tỷ Lệ"
            Cl_TyLe1.DataPropertyName = "TyLe"
            Cl_TyLe1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TyLe1)

            Dim Cl_Thang = New DataGridViewTextBoxColumn()
            Cl_Thang.Name = "Cl_Thang"
            Cl_Thang.HeaderText = "Tháng"
            Cl_Thang.DataPropertyName = "Thang"
            Cl_Thang.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Thang)


            Dim Cl_Nam = New DataGridViewTextBoxColumn()
            Cl_Nam.Name = "Cl_Nam"
            Cl_Nam.HeaderText = "Năm"
            Cl_Nam.DataPropertyName = "Nam"
            Cl_Nam.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Nam)

        End If

    End Sub

    Private Sub loadListChiTiet2(ByRef Nam As Integer, ByRef Thang As Integer)

        listChiTiet1 = New List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)
        Dim result As Result


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
            Cl_TenTheLoai1.HeaderText = "Thể Loại"
            Cl_TenTheLoai1.DataPropertyName = "TheLoai"
            Cl_TenTheLoai1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TenTheLoai1)



            Dim Cl_SoLuotMuon1 = New DataGridViewTextBoxColumn()
            Cl_SoLuotMuon1.Name = "Cl_SoLuotMuon1"
            Cl_SoLuotMuon1.HeaderText = "Số Lượt Mượn"
            Cl_SoLuotMuon1.DataPropertyName = "SoLuotMuon"
            Cl_SoLuotMuon1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_SoLuotMuon1)


            Dim Cl_TyLe1 = New DataGridViewTextBoxColumn()
            'Dim clLoaiHS = New DataGridView()
            Cl_TyLe1.Name = "Cl_TyLe1"
            Cl_TyLe1.HeaderText = "Tỷ Lệ"
            Cl_TyLe1.DataPropertyName = "TyLe"
            Cl_TyLe1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_TyLe1)

            Dim Cl_Thang = New DataGridViewTextBoxColumn()
            Cl_Thang.Name = "Cl_Thang"
            Cl_Thang.HeaderText = "Tháng"
            Cl_Thang.DataPropertyName = "Thang"
            Cl_Thang.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Thang)


            Dim Cl_Nam = New DataGridViewTextBoxColumn()
            Cl_Nam.Name = "Cl_Nam"
            Cl_Nam.HeaderText = "Năm"
            Cl_Nam.DataPropertyName = "Nam"
            Cl_Nam.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            Dgv_ListBaoCaoThongKe.Columns.Add(Cl_Nam)

        End If

    End Sub

    Private Sub Btn_LapBaoCao_Click(sender As Object, e As EventArgs) Handles Btn_LapBaoCao.Click
        Dim BaoCaoThongKeMuonSach As BaoCaoMuonSachTheoTheLoai_DTO
        BaoCaoThongKeMuonSach = New BaoCaoMuonSachTheoTheLoai_DTO()


        '1. Mapping data from GUI control
        BaoCaoThongKeMuonSach.MaBaoCaoMuonSachTheoThang = Txt_MaLapBaoCao.Text
        If Txt_Nam.Text = "" Then
            Frm_Information.m.Text = "Chưa Nhập Năm."
            Frm_Information.ShowDialog()
            Return
        End If
        BaoCaoThongKeMuonSach.Nam = Txt_Nam.Text
        If Cb_Thang.Text = "" Then
            Frm_Information.m.Text = "Chưa Nhập Tháng."
            Frm_Information.ShowDialog()
            Return
        End If
        BaoCaoThongKeMuonSach.Thang = Cb_Thang.Text
        If Txt_TongSoLuotMuon.Text = "" Then
            Frm_Information.m.Text = "Chưa Chọn Thể Loại Để Lập."
            Frm_Information.ShowDialog()
            Return
        End If
        BaoCaoThongKeMuonSach.TongSoLuotMuon = Txt_TongSoLuotMuon.Text
        BaoCaoThongKeMuonSach.NgayLap = Dtp_NgayLap.Value
        '2. Business .....
        If (BaoCaoThongKeMuonSachBUS.isValidNam(BaoCaoThongKeMuonSach) = False) Then
            Frm_Information.m.Text = "Năm không hợp lệ."
            Frm_Information.ShowDialog()
            Txt_Nam.Focus()
            Return
        End If

        If (Dgv_ListLapBaoCaoThongKe.Rows.Count = 0) Then
            Frm_Information.m.Text = "Không có dữ liệu để lập báo cáo."
            Frm_Information.ShowDialog()
            Return
        End If


        '3. Insert to DB
        Dim result As Result
        result = BaoCaoThongKeMuonSachBUS.insert(BaoCaoThongKeMuonSach, listChiTiet)
        If (result.FlagResult = True) Then
            Frm_Information.m.Text = "Lập Báo cáo thành công."
            Frm_Information.ShowDialog()
            'set Madocgia auto
            Dim nextMaBaoCaoThongKeMuonSach = "1"
            result = BaoCaoThongKeMuonSachBUS.getNextID(nextMaBaoCaoThongKeMuonSach)
            If (result.FlagResult = False) Then
                Frm_Information.m.Text = "Lấy tự động Mã lập báo cáo không thành công."
                Frm_Information.ShowDialog()
                Me.Close()
                Return
            End If
            Txt_MaLapBaoCao.Text = nextMaBaoCaoThongKeMuonSach
            ' Dtp_NgayMuon.Value = ""   
            Txt_Nam.Text = String.Empty
            Cb_Thang.Text = String.Empty
            Txt_TongSoLuotMuon.Text = String.Empty
            listChiTiet.Clear()
            Dgv_ListLapBaoCaoThongKe.Rows.Clear()
        Else
            Frm_Information.m.Text = "Thêm Phiếu Mượn Sách không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
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

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class