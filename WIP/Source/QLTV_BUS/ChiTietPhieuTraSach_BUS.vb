Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility


Public Class ChiTietPhieuTraSach_BUS
    Private ChitTietptsDAL As ChiTietPhieuTraSach_DAL
    Public Sub New()
        ChitTietptsDAL = New ChiTietPhieuTraSach_DAL
    End Sub
    Public Sub New(connectionString As String)
        ChitTietptsDAL = New ChiTietPhieuTraSach_DAL(connectionString)
    End Sub







    Public Function selectSachDaMuon(ByRef MaDocGia As String, ByRef ListChiTietPhieuMuonSach As List(Of Sach_DTO)) As Result
        Return ChitTietptsDAL.selectSachDaMuon(MaDocGia, ListChiTietPhieuMuonSach)
    End Function

End Class
