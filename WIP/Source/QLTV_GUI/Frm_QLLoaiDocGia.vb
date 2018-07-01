Imports System.Configuration
Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_QLLoaiDocGia

    Private ldgBus As LoaiDocGia_BUS
        Private Sub Frm_ListLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ldgBus = New LoaiDocGia_BUS()
            ' Load LoaiDocGia list
            loadListLoaiDocGia()
        End Sub

        Private Sub loadListLoaiDocGia()
            ' Load LoaiHocSinh list
            Dim listLoaiDocGia = New List(Of LoaiDocGia_DTO)
            Dim result As Result
            result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            Dim frm_Infor = New Frm_Information()
            Frm_Information.m.Text = "Lấy danh sách loại Độc Giả không thành công."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Lấy danh sách loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        Dgv_ListLoaiDocGia.Columns.Clear()
        Dgv_ListLoaiDocGia.DataSource = Nothing


        Dgv_ListLoaiDocGia.AutoGenerateColumns = False
        Dgv_ListLoaiDocGia.AllowUserToAddRows = False

        Dgv_ListLoaiDocGia.DataSource = listLoaiDocGia
        Dgv_ListLoaiDocGia.HeaderForeColor = Color.White
        Dgv_ListLoaiDocGia.HeaderBgColor = Color.SeaGreen
        Dim clMaLoaiDocGia = New DataGridViewTextBoxColumn()

        clMaLoaiDocGia.Name = "MaLoaiDocGia"
        clMaLoaiDocGia.HeaderText = "Mã Loại Độc Giả"
        clMaLoaiDocGia.DataPropertyName = "MaLoaiDocGia"
        clMaLoaiDocGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Dgv_ListLoaiDocGia.Columns.Add(clMaLoaiDocGia)

        Dim clTenLoaiDocGia = New DataGridViewTextBoxColumn()
        clTenLoaiDocGia.Name = "TenLoaiDocGia"
        clTenLoaiDocGia.HeaderText = "Tên Loại Độc Giả"
        clTenLoaiDocGia.DataPropertyName = "TenLoaiDocGia"
        clTenLoaiDocGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Dgv_ListLoaiDocGia.Columns.Add(clTenLoaiDocGia)

    End Sub


    Private Sub Dgv_ListLoaiDocGia_SELECTionChanged(sender As Object, e As EventArgs) Handles Dgv_ListLoaiDocGia.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListLoaiDocGia.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListLoaiDocGia.RowCount) Then
            Try
                Dim ldg = CType(Dgv_ListLoaiDocGia.Rows(currentRowIndex).DataBoundItem, LoaiDocGia_DTO)
                Txt_MaLoaiDocGia.Text = ldg.MaLoaiDocGia
                Txt_TenLoaiDocGia.Text = ldg.TenLoaiDocGia
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_CapNhat_Click(sender As Object, e As EventArgs) Handles Btn_CapNhat.Click


        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListLoaiDocGia.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListLoaiDocGia.RowCount) Then
            Try
                Dim ldg As LoaiDocGia_DTO
                ldg = New LoaiDocGia_DTO()

                '1. Mapping data from GUI control
                ldg.MaLoaiDocGia = Convert.ToInt32(Txt_MaLoaiDocGia.Text)
                ldg.TenLoaiDocGia = Txt_TenLoaiDocGia.Text

                '2. Business .....
                If (ldgBus.isValidName(ldg) = False) Then
                    Dim frm_Infor = New Frm_Information()
                    Frm_Information.m.Text = "Tên loại độc giả không hợp lệ."
                    Frm_Information.ShowDialog()
                    'MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Txt_TenLoaiDocGia.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = ldgBus.update(ldg)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiDocGia list
                    loadListLoaiDocGia()
                    ' Hightlight the row has been updated on table
                    Dgv_ListLoaiDocGia.Rows(currentRowIndex).Selected = True
                    Try
                        ldg = CType(Dgv_ListLoaiDocGia.Rows(currentRowIndex).DataBoundItem, LoaiDocGia_DTO)
                        Txt_MaLoaiDocGia.Text = ldg.MaLoaiDocGia
                        Txt_TenLoaiDocGia.Text = ldg.TenLoaiDocGia
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    Dim frm_Infor = New Frm_Information()
                    Frm_Information.m.Text = "Cập nhật loại độc giả thành công."
                    Frm_Information.ShowDialog()
                    'MessageBox.Show("Cập nhật Loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim frm_Infor = New Frm_Information()
                    Frm_Information.m.Text = "Cập nhật loại độc giả không thành công."
                    Frm_Information.ShowDialog()
                    'MessageBox.Show("Cập nhật loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub Btn_Xoa_Click(sender As Object, e As EventArgs) Handles Btn_Xoa.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListLoaiDocGia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListLoaiDocGia.RowCount) Then
            Frm_Close.i.Text = "Bạn có thực sự muốn xóa loại độc giả có mã số: " + Txt_MaLoaiDocGia.Text
            Select Case Frm_Close.ShowDialog()'MsgBox("Bạn có thực sự muốn xóa loại độc giả có mã: " + Txt_MaLoaiDocGia.Text, MsgBoxStyle.YesNo, "Information")
                Case DialogResult.OK 'MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ldgBus.delete(Convert.ToInt32(Txt_MaLoaiDocGia.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiDocGianh list
                            loadListLoaiDocGia()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= Dgv_ListLoaiDocGia.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                Dgv_ListLoaiDocGia.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ldg = CType(Dgv_ListLoaiDocGia.Rows(currentRowIndex).DataBoundItem, LoaiDocGia_DTO)
                                    Txt_MaLoaiDocGia.Text = ldg.MaLoaiDocGia
                                    Txt_TenLoaiDocGia.Text = ldg.TenLoaiDocGia
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            Frm_Information.m.Text = "Xoá loại độc giả thành công."
                            Frm_Information.ShowDialog()
                            'MessageBox.Show("Xóa Loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Dim frm_Infor = New Frm_Information()
                            Frm_Information.m.Text = "Xoá loại độc giả không thành công."
                            Frm_Information.ShowDialog()
                            'MessageBox.Show("Xóa Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case DialogResult.No 'MsgBoxResult.No
                    Return
            End Select

        End If

    End Sub
    Private Sub Txt_HoVaTen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TenLoaiDocGia.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then

            e.Handled = True
            Frm_Information.m.Text = "Vui lòng không nhập kí tự đặc biệt, kí tự số."
            Frm_Information.ShowDialog()
            'MessageBox.Show("Vui lòng không nhập kí tự đặc biệt, kí tự số.")
        End If
    End Sub

    Private Sub Dgv_ListLoaiDocGia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListLoaiDocGia.CellContentClick

    End Sub
End Class