Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_LapPhieuMuonSach
    Private PhieuMuonSach As PhieuMuonSach_BUS
    Private DocGia As DocGiaBUS
    Private Sub Frm_LapPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PhieuMuonSach = New PhieuMuonSach_BUS()
        DocGia = New DocGiaBUS()
        ' Load LoaiHocSinh list


        Dim listPhieuMuonSach = New List(Of PhieuMuonSach_DTO)
        Dim result As Result
        result = PhieuMuonSach.selectAll(listPhieuMuonSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cb_MaDocGia.DataSource = New BindingSource(listPhieuMuonSach, String.Empty)
        Cb_MaDocGia.DisplayMember = "MaDocGia"
        Cb_MaDocGia.ValueMember = "HoVaTen"
        'Txt_HoVaTen.DataBindings = New BindingSource(listPhieuMuonSach, String.Empty)

        Dim listDocGia = New List(Of DocGiaDTO)

        'Dim result1 As Result
        result = DocGia.selectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cb_MaDocGia.DataSource = New BindingSource(listDocGia, String.Empty)
        Cb_MaDocGia.DisplayMember = "MaDocGia"
        Cb_MaDocGia.ValueMember = "HoVaTen"


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
    Private Sub loadListDocGia(MaDocGia As String)

        Dim ten As String
        ten = ""

        Dim result As Result
        result = DocGia.selecthovaten(MaDocGia, ten)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        Txt_HoVaTen.Text = ten




    End Sub


    Private Sub Cb_MaDocGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_MaDocGia.SelectedIndexChanged
        Try
            Dim MaDocGia = Cb_MaDocGia.Text
            loadListDocGia(MaDocGia)

        Catch ex As Exception

        End Try
    End Sub


End Class