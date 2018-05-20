Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_LapPhieuMuonSach
    Private PhieuMuonSach As PhieuMuonSach_BUS
    Private DocGia As DocGiaBUS
    Private Sach As Sach_BUS
    Private Sub Frm_LapPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PhieuMuonSach = New PhieuMuonSach_BUS()
        DocGia = New DocGiaBUS()
        Sach = New Sach_BUS()

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
        result = PhieuMuonSach.getNextID(nextMaPhieuMuonSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaPhieuMuonSach.Text = nextMaPhieuMuonSach
    End Sub
    Private Sub loadListDocGia(ByRef MaDocGia As Integer)
        Dim ten As String
        ten = String.Empty

        Dim result As Result
        result = DocGia.selecthovaten(MaDocGia, ten)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        If ten = "" Then
            MessageBox.Show("Không tồn tại mã độc giả.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Txt_HoVaTen.Text = ten

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

        If Txt_MaDocGia.Text <> "" Then
            MaDocGia = Txt_MaDocGia.Text
            loadListDocGia(MaDocGia)
        End If

    End Sub



    Private Sub Dgv_ListPhieuMuonSach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListPhieuMuonSach.CellValueChanged
        If (e.RowIndex <> -1 And e.ColumnIndex = 1) Then
            Sach = New Sach_BUS()
            Dim a, b, c As String
            Dim d As DateTime
            a = ""
            b = ""
            c = ""

            Dim x = Dgv_ListPhieuMuonSach.Rows(e.RowIndex).Cells(1).Value


            Dim Sach1 = New Sach_DTO()
            Dim result As Result
            result = Sach.selectALL_ByMaSach(x, a, b, c, d)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sach các sách theo mã không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)

                Return
            End If
            If a = "" Then
                MessageBox.Show("Không tồn tại mã độc giả.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'x = Dgv_ListPhieuMuonSach.Rows(e.RowIndex).Cells(1).Value
                Dgv_ListPhieuMuonSach.Focus()
            End If

            Dgv_ListPhieuMuonSach.Item("Cl_TenSach", e.RowIndex).Value = a
            Dgv_ListPhieuMuonSach.Item("Cl_TheLoai", e.RowIndex).Value = b
            Dgv_ListPhieuMuonSach.Item("Cl_TacGia", e.RowIndex).Value = c
            Dgv_ListPhieuMuonSach.Item("Cl_NgayDuKienTra", e.RowIndex).Value = d
            Dgv_ListPhieuMuonSach.Item("Cl_STT", e.RowIndex).Value = e.RowIndex + 1
        End If

    End Sub

End Class