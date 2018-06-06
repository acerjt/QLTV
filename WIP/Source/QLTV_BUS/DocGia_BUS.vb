Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class DocGia_BUS

    Private dgDAL As DocGia_DAL
    Public Sub New()
        dgDAL = New DocGia_DAL()
    End Sub
        Public Sub New(connectionString As String)
        dgDAL = New DocGia_DAL(connectionString)
    End Sub
    Public Function isValidName(dg As DocGia_DTO) As Boolean

        If (dg.HoVaTen.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function isValidAge(dg As DocGia_DTO, qd As QuyDinh_DTO) As Boolean
        Dim NamHienTai = DateTime.Now.Year
        If ((NamHienTai - dg.NgaySinh.Year) < qd.TuoiToiThieu Or (NamHienTai - dg.NgaySinh.Year) > qd.TuoiToiDa) Then
            Return False
        End If
        Return True
    End Function


    Public Function isValidHethan(dg As DocGia_DTO) As Boolean
        Dim NamHienTai = DateTime.Now
        If (NamHienTai > dg.NgayLap.AddMonths(6)) Then
            Return False
        End If
        Return True
    End Function


    Public Function insert(dg As DocGia_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.Insert(dg)
    End Function
    Public Function update(dg As DocGia_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.update(dg)
    End Function
    Public Function delete(MaLoaiDocGia As Integer) As Result
            '1. verify data here!!

            '2. insert to DB
            Return dgDAL.Delete(MaLoaiDocGia)
        End Function
    Public Function selectAll(ByRef listLoaiDocGia As List(Of DocGia_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.SelectALL(listLoaiDocGia)
    End Function
    'Public Function selectALL_ByMaLop(iMaLop As Integer, ByRef listHS As List(Of HocSinhDTO)) As Result
    '        '1. verify data here!!

    '        '2. insert to DB
    '        Return hsDAL.selectALL_ByMaLop(iMaLop, listHS)
    '    End Function
    Public Function selectALL_ByType(MaLoaiDocGia As Integer, ByRef listDocGia As List(Of DocGia_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.SelectALL_ByType(MaLoaiDocGia, listDocGia)
    End Function

    Public Function selecthovaten(ByRef MaDocGia As Integer, ByRef dg As DocGia_DTO) As Result
        '1. verify data here!!

        Return dgDAL.selectHoVaTen(MaDocGia, dg)
    End Function



    Public Function buildMaDocGia(ByRef nextMaDocGia As Integer) As Result
            Return dgDAL.BuildMaDocGia(nextMaDocGia)
        End Function
    End Class


