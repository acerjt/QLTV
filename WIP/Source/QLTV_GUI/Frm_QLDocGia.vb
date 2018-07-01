Imports System.Configuration
Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_QLDocGia


    Private dgBus As DocGia_BUS
    Private ldgBus As LoaiDocGia_BUS
    Private qdBus As QuyDinh_BUS
    Private Sub Btn_CapNhat_Click(sender As Object, e As EventArgs) Handles Btn_CapNhap.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListDocGia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListDocGia.RowCount) Then
            Try
                Dim docgia As DocGia_DTO
                docgia = New DocGia_DTO()

                '1. Mapping data from GUI control
                docgia.MaDocGia = Txt_MaDocGia.Text
                docgia.HoVaTen = Txt_HoVaTen.Text
                docgia.LoaiDocGia = Convert.ToInt32(Cb_LoaiDocGia.SelectedValue)
                docgia.NgaySinh = Dtp_NgaySinh.Value
                docgia.DiaChi = Txt_DiaChi.Text
                docgia.Email = Txt_Email.Text
                docgia.NgayLap = Dtp_NgayLap.Value
                docgia.NgayHetHan = Txt_NgayHetHan.Text
                'docgia.TinhTrangThe = Txt_TinhTrangThe.Text
                'docgia.SoSachDangMuon = Txt_SoSachDangMuon.Text

                'docgia.LoaiDocGia = Convert.ToInt32(Cb_LoaiDocGiaCapNhap.SelectedValue)
                '2. Business .....
                If (dgBus.isValidName(docgia) = False) Then
                    Frm_Information.m.Text = "Tên Độc Giả không hợp lệ."
                    Frm_Information.ShowDialog()
                    Txt_HoVaTen.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = dgBus.update(docgia)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListDocGia(Cb_LoaiDocGia.SelectedValue)
                    ' Hightlight the row has been updated on table
                    Dgv_ListDocGia.Rows(currentRowIndex).Selected = True

                    Frm_Information.m.Text = "Cập nhật Độc Giả thành công."
                    Frm_Information.ShowDialog()
                Else
                    Frm_Information.m.Text = "Cập nhật Độc Giả không thành công."
                    Frm_Information.ShowDialog()
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub Btn_Xoa_Click(sender As Object, e As EventArgs) Handles Btn_Xoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListDocGia.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListDocGia.RowCount) Then

            Frm_Close.i.Text = "Bạn có thực sự muốn xóa độc giả có mã số: " + Txt_MaDocGia.Text
            'Frm_Close.i.Location = New Point(80, 78)
            Select Case Frm_Close.ShowDialog()

                'MsgBox("Bạn có thực sự muốn xóa độc giả có mã số: " + Txt_MaDocGia.Text, MsgBoxStyle.YesNo, "Information")
                Case DialogResult.OK 'MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = dgBus.delete(Txt_MaDocGia.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListDocGia(Cb_LoaiDocGia.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= Dgv_ListDocGia.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                Dgv_ListDocGia.Rows(currentRowIndex).Selected = True
                            End If

                            Frm_Information.m.Text = "Xoá Độc Giả thành công."
                            Frm_Information.ShowDialog()
                        Else
                            Frm_Information.m.Text = "Xóa Độc Giả không thành công."
                            Frm_Information.ShowDialog()
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case DialogResult.No
                    Return
            End Select


        End If
    End Sub

    Private Sub Frm_QLDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgBus = New DocGia_BUS()
        ldgBus = New LoaiDocGia_BUS()

        ' Load LoaiDocGia list
        Dim listLoaiDocGia = New List(Of LoaiDocGia_DTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy danh sách loại độc giả không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If


        Cb_LoaiDocGia.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        Cb_LoaiDocGia.DisplayMember = "TenLoaiDocGia"
        Cb_LoaiDocGia.ValueMember = "MaLoaiDocGia"

        Cb_LoaiDocGiaCapNhap.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        Cb_LoaiDocGiaCapNhap.DisplayMember = "TenLoaiDocGia"
        Cb_LoaiDocGiaCapNhap.ValueMember = "MaLoaiDocGia"

        Txt_NgayHetHan.Text = ""
        Txt_TinhTrangThe.Text = ""
    End Sub

    Private Sub loadListDocGia(MaLoaiDocGia As String)
        Dim listDocGia = New List(Of DocGia_DTO)
        Dim result As Result
        result = dgBus.selectALL_ByType(MaLoaiDocGia, listDocGia)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy danh sách độc giả theo loại không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListDocGia.SuspendLayout()
        Dgv_ListDocGia.Columns.Clear()
        Dgv_ListDocGia.DataSource = Nothing

        Dgv_ListDocGia.AutoGenerateColumns = False
        Dgv_ListDocGia.AllowUserToAddRows = False
        Dgv_ListDocGia.DataSource = listDocGia

        Dim clMaDocGia = New DataGridViewTextBoxColumn()
        clMaDocGia.Name = "MaDocGia"
        clMaDocGia.HeaderText = "Mã Độc Giả"
        clMaDocGia.DataPropertyName = "MaDocGia"
        clMaDocGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Dgv_ListDocGia.Columns.Add(clMaDocGia)

        Dim clLoaiDocGia = New DataGridView()
        'clLoaiDocGia.Name = "LoaiDocGia"
        'clLoaiDocGia.HeaderText = "Tên Loại Độc Giả"
        'clLoaiDocGia.DataPropertyName = "LoaiDocGia"
        'Dgv_ListDocGia.Columns.Add(clLoaiDocGia)

        Dim clHoVaTen = New DataGridViewTextBoxColumn()
        clHoVaTen.Name = "HoVaTen"
        clHoVaTen.HeaderText = "Họ Và Tên"
        clHoVaTen.DataPropertyName = "HoVaTen"
        clHoVaTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dgv_ListDocGia.Columns.Add(clHoVaTen)

        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "NgaySinh"
        clNgaySinh.HeaderText = "Ngày Sinh"
        clNgaySinh.DataPropertyName = "NgaySinh"
        Dgv_ListDocGia.Columns.Add(clNgaySinh)
        'Dgv_ListDocGia.ResumeLayout()

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        Dgv_ListDocGia.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        Dgv_ListDocGia.Columns.Add(clEmail)

        Dim clNgayLap = New DataGridViewTextBoxColumn()
        clNgayLap.Name = "NgayLap"
        clNgayLap.HeaderText = "Ngày Lập"
        clNgayLap.DataPropertyName = "NgayLap"
        Dgv_ListDocGia.Columns.Add(clNgayLap)

        Dim clNgayHetHan = New DataGridViewTextBoxColumn()
        clNgayHetHan.Name = "NgayHetHan"
        clNgayHetHan.HeaderText = "Ngày Hết Hạn"
        clNgayHetHan.DataPropertyName = "NgayHetHan"
        clNgayHetHan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Dgv_ListDocGia.Columns.Add(clNgayHetHan)


    End Sub

    Private Sub Cb_LoaiDocGia_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles Cb_LoaiDocGia.SelectedIndexChanged
        Try
            Dim MaLoaiDocGia = Convert.ToInt32(Cb_LoaiDocGia.SelectedValue)
            loadListDocGia(MaLoaiDocGia)


            For Each x As DataGridViewRow In Dgv_ListDocGia.Rows
                Dim currentday = DateTime.Now
                If (currentday > Dgv_ListDocGia.Rows(x.Index).Cells(6).Value) Then
                    x.DefaultCellStyle.BackColor = Color.Pink
                End If
            Next
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Dgv_ListDocGia_SELECTionChanged(sender As Object, e As EventArgs) Handles Dgv_ListDocGia.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListDocGia.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = Dgv_ListDocGia.CurrentCellAddress.X 'curent column selected
        'Dim x As Integer = Dgv_ListDocGia.CurrentCell.Selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListDocGia.RowCount) Then
            Try
                Dim dg = CType(Dgv_ListDocGia.Rows(currentRowIndex).DataBoundItem, DocGia_DTO)
                Txt_MaDocGia.Text = dg.MaDocGia
                Txt_HoVaTen.Text = dg.HoVaTen
                Txt_DiaChi.Text = dg.DiaChi
                Dtp_NgaySinh.Value = dg.NgaySinh
                Txt_Email.Text = dg.Email
                Dtp_NgayLap.Value = dg.NgayLap
                Txt_NgayHetHan.Text = dg.NgayHetHan



                If (dgBus.isValidHethan(dg) = False) Then
                    Txt_TinhTrangThe.Text = "Hết Hạn"
                    ' Dgv_ListDocGia.Rows(currentRowIndex).
                Else Txt_TinhTrangThe.Text = "Còn Hạn"

                End If


                Cb_LoaiDocGiaCapNhap.SelectedIndex = Cb_LoaiDocGia.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Txt_NgayLap_onValueChanged(sender As Object, e As EventArgs) Handles Dtp_NgayLap.onValueChanged

        Dim quydinh As QuyDinh_DTO
        quydinh = New QuyDinh_DTO()

        qdBus = New QuyDinh_BUS()
        Dim result As Result
        result = qdBus.GetQuyDinh(quydinh)
        If (result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy quy định không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_NgayHetHan.Text = Dtp_NgayLap.Value.AddMonths(quydinh.ThoiGianSuDung)
        Dim NamHienTai = DateTime.Now
        If (NamHienTai > Dtp_NgayLap.Value.AddMonths(quydinh.ThoiGianSuDung)) Then
            Txt_TinhTrangThe.Text = "Hết Hạn"
            Txt_TinhTrangThe.BackColor = Color.Red
        Else
            Txt_TinhTrangThe.Text = "Còn Hạn"
            Txt_TinhTrangThe.BackColor = Color.WhiteSmoke

        End If

    End Sub

    Private Sub Txt_HoVaTen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_HoVaTen.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then

            e.Handled = True
            Frm_Information.m.Text = "Vui lòng không nhập kí tự đặc biệt."
            Frm_Information.ShowDialog()
        End If
    End Sub

    Private Sub Txt_TinhTrangThe_TextChanged(sender As Object, e As EventArgs) Handles Txt_TinhTrangThe.TextChanged

    End Sub

    Private Sub Dgv_ListDocGia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListDocGia.CellContentClick

    End Sub
End Class