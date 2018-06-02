Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility


Public Class BaoCaoThongKeSachTraTre_BUS
    Private bctksttDAL As BaoCaoThongKeSachTraTre_DAL
    Public Sub New()
        bctksttDAL = New BaoCaoThongKeSachTraTre_DAL
    End Sub
    Public Sub New(connectionString As String)
        bctksttDAL = New BaoCaoThongKeSachTraTre_DAL(connectionString)
    End Sub
    Public Function isValidNam(BaoCaoThongKeSachTraTre As BaoCaoThongKeSachTraTre_DTO) As Boolean
        Dim currentyear = DateTime.Now.Year
        If (BaoCaoThongKeSachTraTre.Nam.ToString.Length > 4 And BaoCaoThongKeSachTraTre.Nam.ToString.Length < 3 And BaoCaoThongKeSachTraTre.Nam > currentyear) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(bctkstt As BaoCaoThongKeSachTraTre_DTO, listChiTietBCTKSTT As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctksttDAL.insert(bctkstt, listChiTietBCTKSTT)
    End Function
    'Public Function update(pms As PhieuMuonSach_DTO) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return pmsDAL.update(pms)
    'End Function
    'Public Function delete(MaLoaiDocGia As Integer) As Result
    '        '1. verify data here!!

    '        '2. insert to DB
    '        Return ldgDAL.delete(MaLoaiDocGia)
    '    End Function
    'Public Function selectAll(ByRef listPhieuMuonSach As List(Of PhieuMuonSach_DTO)) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return pmsDAL.selectALL(listPhieuMuonSach)
    'End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return bctksttDAL.getNextID(nextID)
    End Function
End Class
