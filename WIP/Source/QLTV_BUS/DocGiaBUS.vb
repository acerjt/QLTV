Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class DocGiaBUS



    Private dgDAL As DocGiaDAL
    Public Sub New()
        dgDAL = New DocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New DocGiaDAL(connectionString)
    End Sub
    Public Function isValidName(dg As DocGiaDTO) As Boolean

        If (dg.HoVaTen.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function isValidAge(dg As DocGiaDTO, qd As QuyDinhDTO) As Boolean
        Dim NamHienTai = DateTime.Now.Year
        If ((NamHienTai - dg.NgaySinh.Year) < qd.TuoiToiThieu Or (NamHienTai - dg.NgaySinh.Year) > qd.TuoiToiDa) Then
            Return False
        End If
        Return True
    End Function


    Public Function isValidHethan(dg As DocGiaDTO) As Boolean
        Dim NamHienTai = DateTime.Now
        If (NamHienTai > dg.NgayLap.AddMonths(6)) Then
            Return False
        End If
        Return True
    End Function


    Public Function insert(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.Insert(dg)
    End Function
    Public Function update(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.Update(dg)
    End Function
    Public Function delete(MaLoaiDocGia As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.Delete(MaLoaiDocGia)
    End Function
    Public Function selectAll(ByRef listLoaiDocGia As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.SelectALL(listLoaiDocGia)
    End Function
    'Public Function selectALL_ByMaLop(iMaLop As Integer, ByRef listHS As List(Of HocSinhDTO)) As Result
    '        '1. verify data here!!

    '        '2. insert to DB
    '        Return hsDAL.selectALL_ByMaLop(iMaLop, listHS)
    '    End Function
    Public Function selectALL_ByType(MaLoaiDocGia As Integer, ByRef listDocGia As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.SelectALL_ByType(MaLoaiDocGia, listDocGia)
    End Function

    Public Function selecthovaten(ByRef MaDocGia As Integer, ByRef ten As String) As Result
        '1. verify data here!!

        Return dgDAL.selectHoVaTen(MaDocGia, ten)
    End Function



    Public Function buildMaDocGia(ByRef nextMaDocGia As Integer) As Result
        Return dgDAL.BuildMaDocGia(nextMaDocGia)
    End Function
End Class

