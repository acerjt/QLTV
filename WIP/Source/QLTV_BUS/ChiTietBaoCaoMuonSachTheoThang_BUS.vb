Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility


Public Class ChiTietBaoCaoMuonSachTheoThang_BUS
    Private ChitTietDAL As ChiTietBaoCaoMuonSachTheoThang_DAL

    Public Sub New()
        ChitTietDAL = New ChiTietBaoCaoMuonSachTheoThang_DAL
    End Sub
    Public Sub New(connectionString As String)
        ChitTietDAL = New ChiTietBaoCaoMuonSachTheoThang_DAL(connectionString)
    End Sub

    Public Function selecListChiTiet(ByRef TheLoaiSach As String, ByRef Nam As String, ByRef Thang As String, ByRef ChiTiet As ChiTietBaoCaoMuonSachTheoThang_DTO, ByRef TongSoLuotMuon As String) As Result
        Return ChitTietDAL.selectListChiTiet(TheLoaiSach, Nam, Thang, ChiTiet, TongSoLuotMuon)
    End Function
    Public Function LoadListChiTietByNam(ByRef Nam As String, ByRef listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)) As Result
        Return ChitTietDAL.LoadListChiTietByNam(Nam, listChiTiet)
    End Function
    Public Function LoadListChiTietByNam_ByThang(ByRef Nam As String, ByRef Thang As String, ByRef listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)) As Result
        Return ChitTietDAL.LoadListChiTietByNam_ByThang(Nam, Thang, listChiTiet)
    End Function
    Public Function SelectAll(ByRef listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)) As Result
        Return ChitTietDAL.SelectAll(listChiTiet)
    End Function
End Class
