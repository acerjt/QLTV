Imports System.Configuration
Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_QLTacGia

    Private tgBus As TacGia_BUS
    Dim frm_Infor = New Frm_Information()
    Private Sub Frm_ListTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tgBus = New TacGia_BUS()
        ' Load LoaiDocGia list
        loadListTacGia()
    End Sub

    Private Sub loadListTacGia()
        ' Load LoaiHocSinh list
        Dim listTacGia = New List(Of TacGia_DTO)
        Dim result As Result
        result = tgBus.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            frm_Infor.m.Text = "Lấy danh sách Loại Độc Giả không thành công."
            frm_Infor.ShowDialog()
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        Dgv_ListTacGia.Columns.Clear()
        Dgv_ListTacGia.DataSource = Nothing


        Dgv_ListTacGia.AutoGenerateColumns = False
        Dgv_ListTacGia.AllowUserToAddRows = False

        Dgv_ListTacGia.DataSource = listTacGia
        Dgv_ListTacGia.HeaderForeColor = Color.White
        Dgv_ListTacGia.HeaderBgColor = Color.SeaGreen

        Dim clMaTacGia = New DataGridViewTextBoxColumn()

        clMaTacGia.Name = "MaTacGia"
        clMaTacGia.HeaderText = "Mã Tác Giả"
        clMaTacGia.DataPropertyName = "MaTacGia"
        clMaTacGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Dgv_ListTacGia.Columns.Add(clMaTacGia)

        Dim clTenTacGia = New DataGridViewTextBoxColumn()
        clTenTacGia.Name = "TenTacGia"
        clTenTacGia.HeaderText = "Tên Tác Giả"
        clTenTacGia.DataPropertyName = "TenTacGia"
        clTenTacGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dgv_ListTacGia.Columns.Add(clTenTacGia)

    End Sub
    Private Sub Btn_CapNhat_Click(sender As Object, e As EventArgs) Handles Btn_CapNhap.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListTacGia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListTacGia.RowCount) Then
            Try
                Dim tg As TacGia_DTO
                tg = New TacGia_DTO()

                '1. Mapping data from GUI control
                tg.MaTacGia = Convert.ToInt32(Txt_MaTacGia.Text)
                tg.TenTacGia = Txt_TenTacGia.Text

                '2. Business .....
                If (tgBus.isValidName(tg) = False) Then
                    frm_Infor.m.Text = "Tên Tác Giả không đúng. Vui lòng kiểm tra lại."
                    frm_Infor.ShowDialog()
                    Txt_TenTacGia.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = tgBus.update(tg)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiDocGia list
                    loadListTacGia()
                    ' Hightlight the row has been updated on table
                    Dgv_ListTacGia.Rows(currentRowIndex).Selected = True
                    Try
                        tg = CType(Dgv_ListTacGia.Rows(currentRowIndex).DataBoundItem, TacGia_DTO)
                        Txt_MaTacGia.Text = tg.MaTacGia
                        Txt_TenTacGia.Text = tg.TenTacGia
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    frm_Infor.m.Text = "Cập nhật Tác Giả thành công."
                    frm_Infor.ShowDialog()
                Else
                    frm_Infor.m.Text = "Cập nhật Tác Giả không thành công."
                    frm_Infor.ShowDialog()
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub Dgv_ListLoaiDocGia_SELECTionChanged(sender As Object, e As EventArgs) Handles Dgv_ListTacGia.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListTacGia.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListTacGia.RowCount) Then
            Try
                Dim tg = CType(Dgv_ListTacGia.Rows(currentRowIndex).DataBoundItem, TacGia_DTO)
                Txt_MaTacGia.Text = tg.MaTacGia
                Txt_TenTacGia.Text = tg.TenTacGia
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub Btn_Xoa_Click(sender As Object, e As EventArgs) Handles Btn_Xoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = Dgv_ListTacGia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < Dgv_ListTacGia.RowCount) Then
            Frm_Close.i.Text = "Bạn có thực sự muốn xóa Tác Giả có mã số: " + Txt_MaTacGia.Text
            Select Case Frm_Close.ShowDialog()
                Case DialogResult.OK
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = tgBus.delete(Convert.ToInt32(Txt_MaTacGia.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiDocGianh list
                            loadListTacGia()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= Dgv_ListTacGia.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                Dgv_ListTacGia.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim tg = CType(Dgv_ListTacGia.Rows(currentRowIndex).DataBoundItem, TacGia_DTO)
                                    Txt_MaTacGia.Text = tg.MaTacGia
                                    Txt_TenTacGia.Text = tg.TenTacGia
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            frm_Infor.m.Text = "Xóa Tác Giả thành công."
                            frm_Infor.ShowDialog()
                        Else
                            frm_Infor.m.Text = "Xóa Tác Giả không thành công."
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

    Private Sub Txt_TenTacGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TenTacGia.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
            frm_Infor.m.Text = "Vui lòng không nhập kí tự đặc biệt."
            frm_Infor.ShowDialog()
        End If
    End Sub


End Class
