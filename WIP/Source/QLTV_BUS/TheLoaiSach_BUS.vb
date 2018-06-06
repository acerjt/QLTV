Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class TheLoaiSach_BUS
        Private TheLoaiSachDAL As TheLoaiSach_DAL
        Public Sub New()
            TheLoaiSachDAL = New TheLoaiSach_DAL()
        End Sub
    Public Sub New(connectionString As String)
        TheLoaiSachDAL = New TheLoaiSach_DAL(connectionString)
    End Sub

    Public Function isValidName(tls As TheLoaiSach_DTO) As Boolean

        If (tls.TenTheLoaiSach.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidInSertTheLoaiSach(TheLoaiSach As TheLoaiSach_DTO, qds As QuyDinh_DTO) As Boolean

        If (TheLoaiSach.MaTheLoaiSach > qds.SoTheLoaiSachToiDa) Then
            Return False
        End If

        Return True

    End Function
    Public Function insert(TheLoaiSach As TheLoaiSach_DTO) As Result
            '1. verify data here!!

            '2. insert to DB
            Return TheLoaiSachDAL.insert(TheLoaiSach)
        End Function
        Public Function update(tls As TheLoaiSach_DTO) As Result
            '1. verify data here!!

            '2. insert to DB
            Return TheLoaiSachDAL.update(tls)
        End Function
        Public Function delete(maTheLoaiSach As Integer) As Result
            '1. verify data here!!

            '2. insert to DB
            Return TheLoaiSachDAL.delete(maTheLoaiSach)
        End Function
        Public Function selectAll(ByRef listTheLoaiSach As List(Of TheLoaiSach_DTO)) As Result
            '1. verify data here!!

            '2. insert to DB
            Return TheLoaiSachDAL.selectALL(listTheLoaiSach)
        End Function
        Public Function getNextID(ByRef nextID As Integer) As Result
            Return TheLoaiSachDAL.getNextID(nextID)
        End Function
        Public Function CountSoLuongTheLoai(ByRef Count As Integer) As Result
            Return TheLoaiSachDAL.CountSoLuongTheLoai(Count)
        End Function
    End Class

