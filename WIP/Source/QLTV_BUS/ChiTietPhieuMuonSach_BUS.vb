Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility


Public Class ChiTietPhieuMuonSach_BUS


    Private ChitTietpmsDAL As ChiTietPhieuMuonSach_DAL
    Public Sub New()
        ChitTietpmsDAL = New ChiTietPhieuMuonSach_DAL
    End Sub
    Public Sub New(connectionString As String)
        ChitTietpmsDAL = New ChiTietPhieuMuonSach_DAL(connectionString)
    End Sub







    Public Function selectSachDaMuon(ByRef MaDocGia As String, ByRef ListChiTietPhieuMuonSach As List(Of Sach_DTO)) As Result
        Return ChitTietpmsDAL.selectSachDaMuon(MaDocGia, ListChiTietPhieuMuonSach)
    End Function


End Class
