Imports System.Configuration
Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_QLTheLoaiSach

    Private tlsBus As TheLoaiSach_BUS
    Dim frm_Infor = New Frm_Information()
    Private Sub Frm_QLTheLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tlsBus = New TheLoaiSach_BUS()
        ' Load LoaiDocGia list
        loadListTheLoaiSach()
    End Sub


    Private Sub loadListTheLoaiSach()
        ' Load LoaiHocSinh list
        Dim listTheLoaiSach = New List(Of TheLoaiSach_DTO)
        Dim result As Result
        result = tlsBus.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            frm_Infor.m.Text = "Lấy danh sách thể loại sách không thành công."
            frm_Infor.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        Dgv_ListTheLoaiSach.Columns.Clear()
        Dgv_ListTheLoaiSach.DataSource = Nothing

        Dgv_ListTheLoaiSach.AutoGenerateColumns = False
        Dgv_ListTheLoaiSach.AllowUserToAddRows = False
        Dgv_ListTheLoaiSach.DataSource = listTheLoaiSach

        Dim clMaTheLoaiSach = New DataGridViewTextBoxColumn()
        clMaTheLoaiSach.Name = "MaTheLoaiSach"
        clMaTheLoaiSach.HeaderText = "Mã Thể Loại Sách"
        clMaTheLoaiSach.DataPropertyName = "MaTheLoaiSach"
        clMaTheLoaiSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Dgv_ListTheLoaiSach.Columns.Add(clMaTheLoaiSach)


        Dim clTenTheLoaiSach = New DataGridViewTextBoxColumn()
        clTenTheLoaiSach.Name = "TenTheLoaiSah"
        clTenTheLoaiSach.HeaderText = "Tên Thể Loại Sách"
        clTenTheLoaiSach.DataPropertyName = "TenTheLoaiSach"
        clTenTheLoaiSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Dgv_ListTheLoaiSach.Columns.Add(clTenTheLoaiSach)

    End Sub
    Private Sub Btn_CapNhat_Click(sender As Object, e As EventArgs) Handles Btn_CapNhap.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListTheLoaiSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListTheLoaiSach.RowCount) Then
            Try
                Dim tls As TheLoaiSach_DTO
                tls = New TheLoaiSach_DTO()

                '1. Mapping data from GUI control
                tls.MaTheLoaiSach = Convert.ToInt32(Txt_MaTheLoaiSach.Text)
                tls.TenTheLoaiSach = Txt_TenTheLoaiSach.Text

                '2. Business .....
                If (tlsBus.isValidName(tls) = False) Then
                    frm_Infor.m.Text = "Tên Thể Loại Sách không đúng. Vui lòng kiểm tra lại"
                    frm_Infor.ShowDialog()
                    Txt_TenTheLoaiSach.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = tlsBus.update(tls)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiDocGia list
                    loadListTheLoaiSach()
                    ' Hightlight the row has been updated on table
                    Dgv_ListTheLoaiSach.Rows(currentRowIndex).Selected = True
                    Try
                        tls = CType(Dgv_ListTheLoaiSach.Rows(currentRowIndex).DataBoundItem, TheLoaiSach_DTO)
                        Txt_MaTheLoaiSach.Text = tls.MaTheLoaiSach
                        Txt_TenTheLoaiSach.Text = tls.TenTheLoaiSach
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    frm_Infor.m.Text = "Cập nhật Thể Loại Sách thành công."
                    frm_Infor.ShowDialog()
                Else
                    frm_Infor.m.Text = "Cập nhật Thể Loại Sách không thành công."
                    frm_Infor.ShowDialog()
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub



    Private Sub Dgv_ListLoaiDocGia_SELECTionChanged(sender As Object, e As EventArgs) Handles Dgv_ListTheLoaiSach.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListTheLoaiSach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListTheLoaiSach.RowCount) Then
            Try
                Dim tls = CType(Dgv_ListTheLoaiSach.Rows(currentRowIndex).DataBoundItem, TheLoaiSach_DTO)
                Txt_MaTheLoaiSach.Text = tls.MaTheLoaiSach
                Txt_TenTheLoaiSach.Text = tls.TenTheLoaiSach
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub Btn_Xoa_Click(sender As Object, e As EventArgs) Handles Btn_Xoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListTheLoaiSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListTheLoaiSach.RowCount) Then
            Frm_Close.i.Text = "Bạn có thực sự muốn xóa sách có mã số: " + Txt_MaTheLoaiSach.Text
            Select Case Frm_Close.ShowDialog()
                Case DialogResult.OK
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = tlsBus.delete(Convert.ToInt32(Txt_MaTheLoaiSach.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiDocGianh list
                            loadListTheLoaiSach()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= Dgv_ListTheLoaiSach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                Dgv_ListTheLoaiSach.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ldg = CType(Dgv_ListTheLoaiSach.Rows(currentRowIndex).DataBoundItem, LoaiDocGia_DTO)
                                    Txt_MaTheLoaiSach.Text = ldg.MaLoaiDocGia
                                    Txt_TenTheLoaiSach.Text = ldg.TenLoaiDocGia
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            frm_Infor.m.Text = "Xóa Thể Loại Sách thành công"
                            frm_Infor.ShowDialog()
                        Else
                            frm_Infor.m.Text = "Xóa Thể Loại Sách không thành công"
                            frm_Infor.ShowDialog()
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

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub


End Class

