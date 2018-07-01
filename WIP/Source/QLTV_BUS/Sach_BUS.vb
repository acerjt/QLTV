Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class Sach_BUS

    Private SachDAL As Sach_DAL
    Public Sub New()
        SachDAL = New Sach_DAL()
    End Sub
    Public Sub New(connectionString As String)
        SachDAL = New Sach_DAL(connectionString)
    End Sub
    Public Function isValidTenSach(Sach As Sach_DTO) As Boolean

        If (Sach.TenSach.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function isValidName(Sach As Sach_DTO) As Boolean
        If (Sach.TenSach.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function isValidNamXuatBan(Sach As Sach_DTO, qds As QuyDinh_DTO) As Boolean
        Dim currentyear = DateTime.Now.Year
        If (currentyear - Sach.NamXuatBan < 0 Or currentyear - Sach.NamXuatBan > qds.KhoangCachNamXuatBan) Then
            Return False
        End If

        Return True
    End Function
    Public Function isValidTacGia(Sach As Sach_DTO) As Boolean
        'Dim currentyear = DateTime.Now.Year
        If (Sach.TenTacGia < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function isValidTheLoai(Sach As Sach_DTO) As Boolean
        'Dim currentyear = DateTime.Now.Year
        If (Sach.TheLoai > 3 Or Sach.TheLoai < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function insert(Sach As Sach_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return SachDAL.insert(Sach)
    End Function
    Public Function update(Sach As Sach_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return SachDAL.update(Sach)
    End Function
    Public Function delete(MaSach As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return SachDAL.delete(MaSach)
    End Function
    Public Function selectAll(ByRef listSach As List(Of Sach_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return SachDAL.selectALL(listSach)
    End Function
    Public Function selectALL_ByTacGia(iMaTacGia As Integer, ByRef listSach As List(Of Sach_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return SachDAL.selectALL_ByMaTacGia(iMaTacGia, listSach)
    End Function
    Public Function selectALL_ByTheLoaiSach(iMaTheLoaiSach As Integer, ByRef listSach As List(Of Sach_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return SachDAL.selectALL_ByMaTheLoaiSach(iMaTheLoaiSach, listSach)
    End Function
    Public Function buildMaSach(ByRef nextMaSach As Integer) As Result
        Return SachDAL.buildMaSach(nextMaSach)
    End Function

    'Public Function select_ByMaSach(ByRef MaSach As Integer, ByRef tensach As String, ByRef theloai As String, ByRef tacgia As String) As Result
    '    Return SachDAL.select_ByMaSach(MaSach, tensach, theloai, tacgia)
    'End Function

    Public Function selectALL_ByMaSach(MaSach As Integer, ByRef ChiTietPhieuMuonSach As Sach_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return SachDAL.selectALL_ByMaSach(MaSach, ChiTietPhieuMuonSach)
    End Function

    Public Function search_ByTen(TenSach As String, ByRef listChiTietPhieuMuonSach As List(Of Sach_DTO)) As Result
        Return SachDAL.search_ByTen(TenSach, listChiTietPhieuMuonSach)
    End Function

    Public Function insert1(listSach As List(Of Sach_DTO)) As Result
        Return SachDAL.insert1(listSach)
    End Function
End Class


