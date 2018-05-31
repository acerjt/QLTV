Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class BaoCaoMuonSachTheoThang_BUS
    Private bctkmsDAL As BaoCaoMuonSachTheoThang_DAL
    Public Sub New()
        bctkmsDAL = New BaoCaoMuonSachTheoThang_DAL
    End Sub
    Public Sub New(connectionString As String)
        bctkmsDAL = New BaoCaoMuonSachTheoThang_DAL(connectionString)
    End Sub
    Public Function isValidNam(BaoCaoThongKeMuonSach As BaoCaoMuonSachTheoThang_DTO) As Boolean
        Dim currentyear = DateTime.Now.Year
        If (BaoCaoThongKeMuonSach.Nam.ToString.Length > 4 And BaoCaoThongKeMuonSach.Nam.ToString.Length < 3 And BaoCaoThongKeMuonSach.Nam > currentyear) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(bctkms As BaoCaoMuonSachTheoThang_DTO, listChiTietBCTKMS As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctkmsDAL.insert(bctkms, listChiTietBCTKMS)
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
        Return bctkmsDAL.getNextID(nextID)
    End Function
End Class
