Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class PhieuMuonSach_BUS


    Private pmsDAL As PhieuMuonSach_DAL
    Public Sub New()
        pmsDAL = New PhieuMuonSach_DAL()
    End Sub
        Public Sub New(connectionString As String)
        pmsDAL = New PhieuMuonSach_DAL(connectionString)
    End Sub
    Public Function isValidMaDocGia(PhieuMuonSach As PhieuMuonSach_DTO) As Boolean

        If (PhieuMuonSach.MaDocGia.ToString.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(pms As PhieuMuonSach_DTO, listChiTietPhieuMuonSach As List(Of ChiTietPhieuMuonSach_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pmsDAL.insert(pms, listChiTietPhieuMuonSach)
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
    Public Function selectAll(ByRef listPhieuMuonSach As List(Of PhieuMuonSach_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pmsDAL.selectALL(listPhieuMuonSach)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return pmsDAL.getNextID(nextID)
    End Function
    End Class




