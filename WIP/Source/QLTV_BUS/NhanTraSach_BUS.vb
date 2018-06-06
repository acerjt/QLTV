Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility


Public Class NhanTraSach_BUS
    Private ptsDAL As NhanTraSach_DAL
    Public Sub New()
        ptsDAL = New NhanTraSach_DAL()
    End Sub
    Public Sub New(connectionString As String)
        ptsDAL = New NhanTraSach_DAL(connectionString)
    End Sub
    Public Function isValidMaDocGia(PhieuTraSach As NhanTraSach_DTO) As Boolean

        If (PhieuTraSach.MaDocGia.ToString.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(pts As NhanTraSach_DTO, listChiTietPhieuTraSach As List(Of ChiTietPhieuTraSach_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptsDAL.insert(pts, listChiTietPhieuTraSach)
    End Function

    Public Function selectAll(ByRef listPhieuTraSach As List(Of NhanTraSach_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptsDAL.selectALL(listPhieuTraSach)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ptsDAL.getNextID(nextID)
    End Function
End Class
