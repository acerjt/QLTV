Imports System.Configuration
Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_QlSach
    Private SachBUS As Sach_BUS
    Private TheLoaiSachBUS As TheLoaiSach_BUS
    Private TacGiaBUS As TacGia_BUS
    Private Sub Frm_QlSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SachBUS = New Sach_BUS()
        TheLoaiSachBUS = New TheLoaiSach_BUS()
        TacGiaBUS = New TacGia_BUS()
        ' Load LoaiSach list
        Dim listTheLoaiSach = New List(Of TheLoaiSach_DTO)
        Dim result As Result
        result = TheLoaiSachBUS.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        Cb_TheLoaiSach.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cb_TheLoaiSach.DisplayMember = "TenTheLoaiSach"
        Cb_TheLoaiSach.ValueMember = "MaTheLoaiSach"

        Cb_TheLoaiSachCapNhat.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cb_TheLoaiSachCapNhat.DisplayMember = "TenTheLoaiSach"
        Cb_TheLoaiSachCapNhat.ValueMember = "MaTheLoaiSach"


        Dim listTacGia = New List(Of TacGia_DTO)
        'Dim result As Result
        result = TacGiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        Cb_TenTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        Cb_TenTacGia.DisplayMember = "TenTacGia"
        Cb_TenTacGia.ValueMember = "MaTacGia"

        CB_TenTacGiaCapNhat.DataSource = New BindingSource(listTacGia, String.Empty)
        CB_TenTacGiaCapNhat.DisplayMember = "TenTacGia"
        CB_TenTacGiaCapNhat.ValueMember = "MaTacGia"
        loadListSach()
    End Sub
    Private Sub loadListSachByTheLoaiSach(MaTheLoaiSach As Integer)
        Dim listSach = New List(Of Sach_DTO)
        Dim result As Result
        result = SachBUS.selectALL_ByTheLoaiSach(MaTheLoaiSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách theo thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If



        'dgvListHS.SuspendLayout()
        Dgv_ListSach.Columns.Clear()
        Dgv_ListSach.DataSource = Nothing

        Dgv_ListSach.AutoGenerateColumns = False
        Dgv_ListSach.AllowUserToAddRows = False
        Dgv_ListSach.DataSource = listSach

        Dim Cl_MaSach = New DataGridViewTextBoxColumn()
        Cl_MaSach.Name = "Cl_MaSach"
        Cl_MaSach.HeaderText = "Mã Sách"
        Cl_MaSach.DataPropertyName = "MaSach"
        Dgv_ListSach.Columns.Add(Cl_MaSach)


        Dim Cl_TheLoaiSach = New DataGridView()
        'Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim Cl_TenSach = New DataGridViewTextBoxColumn()
        Cl_TenSach.Name = "Cl_TenSach"
        Cl_TenSach.HeaderText = "Tên Sách"
        Cl_TenSach.DataPropertyName = "TenSach"
        Dgv_ListSach.Columns.Add(Cl_TenSach)


        Dim Cl_TenTacGia = New DataGridViewTextBoxColumn()
        Cl_TenTacGia.Name = "Cl_TenTacGia"
        Cl_TenTacGia.HeaderText = "Tên Tác Giả"
        Cl_TenTacGia.DataPropertyName = "TenTacGia"
        Dgv_ListSach.Columns.Add(Cl_TenTacGia)

        Dim Cl_NamXuatBan = New DataGridViewTextBoxColumn()
        Cl_NamXuatBan.Name = "Cl_NamXuatBan "
        Cl_NamXuatBan.HeaderText = "Năm Xuất Bản"
        Cl_NamXuatBan.DataPropertyName = "NamXuatBan"
        Dgv_ListSach.Columns.Add(Cl_NamXuatBan)

        Dim Cl_NhaXuatBan = New DataGridViewTextBoxColumn()
        Cl_NhaXuatBan.Name = "Cl_NhaXuatBan "
        Cl_NhaXuatBan.HeaderText = "Nhà Xuất Bản"
        Cl_NhaXuatBan.DataPropertyName = "NhaXuatBan"
        Dgv_ListSach.Columns.Add(Cl_NhaXuatBan)

        Dim Cl_NgayNhap = New DataGridViewTextBoxColumn()
        Cl_NgayNhap.Name = "Cl_NgayNhap "
        Cl_NgayNhap.HeaderText = "Ngày Nhập"
        Cl_NgayNhap.DataPropertyName = "NgayNhap"
        Dgv_ListSach.Columns.Add(Cl_NgayNhap)

        Dim Cl_TriGia = New DataGridViewTextBoxColumn()
        Cl_TriGia.Name = "Cl_TriGia"
        Cl_TriGia.HeaderText = "Trị Giá"
        Cl_TriGia.DataPropertyName = "TriGia"
        Dgv_ListSach.Columns.Add(Cl_TriGia)

        Dgv_ListSach.AutoResizeColumns()
        'dgvListHS.ResumeLayout()
    End Sub
    Private Sub loadListSach()
        Dim listSach = New List(Of Sach_DTO)
        Dim result As Result
        result = SachBUS.selectAll(listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        Dgv_ListSach.Columns.Clear()
        Dgv_ListSach.DataSource = Nothing

        Dgv_ListSach.AutoGenerateColumns = False
        Dgv_ListSach.AllowUserToAddRows = False
        Dgv_ListSach.DataSource = listSach

        Dim Cl_MaSach = New DataGridViewTextBoxColumn()
        Cl_MaSach.Name = "Cl_MaSach"
        Cl_MaSach.HeaderText = "Mã Sách"
        Cl_MaSach.DataPropertyName = "MaSach"
        Dgv_ListSach.Columns.Add(Cl_MaSach)

        'Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim Cl_TheLoaiSach = New DataGridViewTextBoxColumn()
        Cl_TheLoaiSach.Name = "Cl_TheLoaiSach"
        Cl_TheLoaiSach.HeaderText = "Thể loại"
        Cl_TheLoaiSach.DataPropertyName = "TheLoai"
        Dgv_ListSach.Columns.Add(Cl_TheLoaiSach)

        Dim Cl_TenSach = New DataGridViewTextBoxColumn()
        Cl_TenSach.Name = "Cl_TenSach"
        Cl_TenSach.HeaderText = "Tên Sách"
        Cl_TenSach.DataPropertyName = "TenSach"
        Dgv_ListSach.Columns.Add(Cl_TenSach)



        Dim Cl_TenTacGia = New DataGridViewTextBoxColumn()
        Cl_TenTacGia.Name = "Cl_TenTacGia"
        Cl_TenTacGia.HeaderText = "Tên Tác Giả"
        Cl_TenTacGia.DataPropertyName = "TenTacGia"
        Dgv_ListSach.Columns.Add(Cl_TenTacGia)

        Dim Cl_NamXuatBan = New DataGridViewTextBoxColumn()
        Cl_NamXuatBan.Name = "Cl_NamXuatBan "
        Cl_NamXuatBan.HeaderText = "Năm Xuất Bản"
        Cl_NamXuatBan.DataPropertyName = "NamXuatBan"
        Dgv_ListSach.Columns.Add(Cl_NamXuatBan)

        Dim Cl_NhaXuatBan = New DataGridViewTextBoxColumn()
        Cl_NhaXuatBan.Name = "Cl_NhaXuatBan "
        Cl_NhaXuatBan.HeaderText = "Nhà Xuất Bản"
        Cl_NhaXuatBan.DataPropertyName = "NhaXuatBan"
        Dgv_ListSach.Columns.Add(Cl_NhaXuatBan)

        Dim Cl_NgayNhap = New DataGridViewTextBoxColumn()
        Cl_NgayNhap.Name = "Cl_NgayNhap "
        Cl_NgayNhap.HeaderText = "Ngày Nhập"
        Cl_NgayNhap.DataPropertyName = "NgayNhap"
        Dgv_ListSach.Columns.Add(Cl_NgayNhap)

        Dim Cl_TriGia = New DataGridViewTextBoxColumn()
        Cl_TriGia.Name = "Cl_TriGia"
        Cl_TriGia.HeaderText = "Trị Giá"
        Cl_TriGia.DataPropertyName = "TriGia"
        Dgv_ListSach.Columns.Add(Cl_TriGia)


        Dgv_ListSach.AutoResizeColumns()
        'dgvListHS.ResumeLayout()
    End Sub
    Private Sub loadListSachByTenTacGia(MaTacGia As Integer)
        Dim listSach = New List(Of Sach_DTO)
        Dim result As Result
        result = SachBUS.selectALL_ByTacGia(MaTacGia, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách theo tên tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If



        'dgvListHS.SuspendLayout()
        Dgv_ListSach.Columns.Clear()
        Dgv_ListSach.DataSource = Nothing

        Dgv_ListSach.AutoGenerateColumns = False
        Dgv_ListSach.AllowUserToAddRows = False
        Dgv_ListSach.DataSource = listSach

        Dim Cl_MaSach = New DataGridViewTextBoxColumn()
        Cl_MaSach.Name = "Cl_MaSach"
        Cl_MaSach.HeaderText = "Mã Sách"
        Cl_MaSach.DataPropertyName = "MaSach"
        Dgv_ListSach.Columns.Add(Cl_MaSach)




        'Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim Cl_TenSach = New DataGridViewTextBoxColumn()
        Cl_TenSach.Name = "Cl_TenSach"
        Cl_TenSach.HeaderText = "Tên Sách"
        Cl_TenSach.DataPropertyName = "TenSach"
        Dgv_ListSach.Columns.Add(Cl_TenSach)


        Dim Cl_TenTheLoaiSach = New DataGridViewTextBoxColumn()
        Cl_TenTheLoaiSach.Name = "Cl_TenTheLoaiSach"
        Cl_TenTheLoaiSach.HeaderText = "Tên Thể Loại Sách"
        Cl_TenTheLoaiSach.DataPropertyName = "TheLoai"
        Dgv_ListSach.Columns.Add(Cl_TenTheLoaiSach)


        Dim Cl_NamXuatBan = New DataGridViewTextBoxColumn()
        Cl_NamXuatBan.Name = "Cl_NamXuatBan "
        Cl_NamXuatBan.HeaderText = "Năm Xuất Bản"
        Cl_NamXuatBan.DataPropertyName = "NamXuatBan"
        Dgv_ListSach.Columns.Add(Cl_NamXuatBan)

        Dim Cl_NhaXuatBan = New DataGridViewTextBoxColumn()
        Cl_NhaXuatBan.Name = "Cl_NhaXuatBan "
        Cl_NhaXuatBan.HeaderText = "Nhà Xuất Bản"
        Cl_NhaXuatBan.DataPropertyName = "NhaXuatBan"
        Dgv_ListSach.Columns.Add(Cl_NhaXuatBan)

        Dim Cl_NgayNhap = New DataGridViewTextBoxColumn()
        Cl_NgayNhap.Name = "Cl_NgayNhap "
        Cl_NgayNhap.HeaderText = "Ngày Nhập"
        Cl_NgayNhap.DataPropertyName = "NgayNhap"
        Dgv_ListSach.Columns.Add(Cl_NgayNhap)

        Dim Cl_TriGia = New DataGridViewTextBoxColumn()
        Cl_TriGia.Name = "Cl_TriGia"
        Cl_TriGia.HeaderText = "Trị Giá"
        Cl_TriGia.DataPropertyName = "TriGia"
        Dgv_ListSach.Columns.Add(Cl_TriGia)

        Dgv_ListSach.AutoResizeColumns()
        'dgvListHS.ResumeLayout()
    End Sub

    Private Sub Cb_TheLoaiSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_TheLoaiSach.SelectedIndexChanged
        Dim currentRowIndex As Integer = Dgv_ListSach.CurrentCellAddress.Y
        Try

            Dim MaTheLoaiSach = Convert.ToInt32(Cb_TheLoaiSach.SelectedValue)
            loadListSachByTheLoaiSach(MaTheLoaiSach)

            Cb_TheLoaiSachCapNhat.SelectedIndex = Cb_TheLoaiSach.SelectedIndex
            If (-1 < currentRowIndex And currentRowIndex < Dgv_ListSach.RowCount) Then
                Try
                    Dim Sach = CType(Dgv_ListSach.Rows(currentRowIndex).DataBoundItem, Sach_DTO)

                    ' Cb_TheLoaiSachCapNhat.SelectedIndex =
                    CB_TenTacGiaCapNhat.Text = Sach.TenTacGia
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                End Try

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dgv_ListSach_SelectionChanged(sender As Object, e As EventArgs) Handles Dgv_ListSach.SelectionChanged
        Dim currentRowIndex As Integer = Dgv_ListSach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListSach.RowCount) Then
            Try
                Dim Sach = CType(Dgv_ListSach.Rows(currentRowIndex).DataBoundItem, Sach_DTO)
                Txt_MaSach.Text = Sach.MaSach
                Txt_TenSach.Text = Sach.TenSach
                Txt_NamXuatBan.Text = Sach.NamXuatBan
                Txt_NhaXuatBan.Text = Sach.NhaXuatBan
                Dtp_NgayNhap.Value = Sach.NgayNhap
                Txt_TriGia.Text = Sach.TriGia
                ' Cb_TheLoaiSachCapNhat.SelectedIndex =
                'CB_TenTacGiaCapNhat.SelectedIndex =
                'Cb_TheLoaiSachCapNhat.Text = Sach.TheLoai
                Cb_TheLoaiSachCapNhat.Text = Sach.TheLoai
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub Cb_TenTacGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_TenTacGia.SelectedIndexChanged
        Dim currentRowIndex As Integer = Dgv_ListSach.CurrentCellAddress.Y 'current row selected

        Try
            Dim MaTacGia = Convert.ToInt32(Cb_TenTacGia.SelectedValue)
            loadListSachByTenTacGia(MaTacGia)
            CB_TenTacGiaCapNhat.SelectedIndex = Cb_TenTacGia.SelectedIndex
            If (-1 < currentRowIndex And currentRowIndex < Dgv_ListSach.RowCount) Then
                Try
                    Dim Sach = CType(Dgv_ListSach.Rows(currentRowIndex).DataBoundItem, Sach_DTO)

                    ' Cb_TheLoaiSachCapNhat.SelectedIndex =
                    Cb_TheLoaiSachCapNhat.Text = Sach.TheLoai
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                End Try

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_CapNhat_Click(sender As Object, e As EventArgs) Handles Btn_CapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListSach.RowCount) Then
            Try
                Dim Sach As Sach_DTO
                Sach = New Sach_DTO()

                '1. Mapping data from GUI control
                Sach.MaSach = Txt_MaSach.Text
                Sach.TenSach = Txt_TenSach.Text
                Sach.NamXuatBan = Txt_NamXuatBan.Text
                Sach.NhaXuatBan = Txt_NhaXuatBan.Text
                Sach.TriGia = Txt_TriGia.Text
                Sach.TheLoai = Convert.ToInt32(Cb_TheLoaiSachCapNhat.SelectedValue)
                Sach.TenTacGia = Convert.ToInt32(CB_TenTacGiaCapNhat.SelectedValue)
                Sach.NgayNhap = Dtp_NgayNhap.Value
                '2. Business .....
                If (SachBUS.isValidNamXuatBan(Sach) = False) Then
                    MessageBox.Show("Chi nhan sach xuat ban trong vong 8 nam")
                    Txt_NamXuatBan.Focus()
                    Return
                End If

                If (SachBUS.isValidTacGia(Sach) = False) Then
                    MessageBox.Show("Tác giả chưa có trong cơ sở dữ liệu")
                    CB_TenTacGiaCapNhat.Focus()
                    Return
                End If
                If (SachBUS.isValidTheLoai(Sach) = False) Then
                    MessageBox.Show("Thể loại không hợp lệ")
                    Cb_TheLoaiSachCapNhat.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = SachBUS.update(Sach)
                If (result.FlagResult = True) Then
                    ' Re-Load Sach list
                    ' loadListSach(Cb_TheLoaiSach.SelectedIndex)
                    ' Hightlight the row has been updated on table
                    Dgv_ListSach.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub


    Private Sub Btn_Xoa_Click(sender As Object, e As EventArgs) Handles Btn_Xoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListSach.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa học sinh có mã số: " + Txt_MaSach.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = SachBUS.delete(Txt_MaSach.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            'loadListHocSinh(cbLoaiHS.SELECTedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= Dgv_ListSach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                Dgv_ListSach.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa Học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select


        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Txt_MaSach_TextChanged(sender As Object, e As EventArgs) Handles Txt_MaSach.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Txt_TriGia_TextChanged(sender As Object, e As EventArgs) Handles Txt_TriGia.TextChanged

    End Sub

    Private Sub Dtp_NgayNhap_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_NgayNhap.ValueChanged

    End Sub

    Private Sub Txt_NhaXuatBan_TextChanged(sender As Object, e As EventArgs) Handles Txt_NhaXuatBan.TextChanged

    End Sub

    Private Sub Txt_NamXuatBan_TextChanged(sender As Object, e As EventArgs) Handles Txt_NamXuatBan.TextChanged

    End Sub

    Private Sub CB_TenTacGiaCapNhat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_TenTacGiaCapNhat.SelectedIndexChanged

    End Sub

    Private Sub Cb_TheLoaiSachCapNhat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_TheLoaiSachCapNhat.SelectedIndexChanged

    End Sub

    Private Sub Txt_TenSach_TextChanged(sender As Object, e As EventArgs) Handles Txt_TenSach.TextChanged

    End Sub
End Class