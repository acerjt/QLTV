Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility


Public Class ChiTietBaoCaoMuonSachTheoTheLoai_BUS
    Private ChitTietDAL As ChiTietBaoCaoMuonSachTheoTheLoai_DAL

    Public Sub New()
        ChitTietDAL = New ChiTietBaoCaoMuonSachTheoTheLoai_DAL
    End Sub
    Public Sub New(connectionString As String)
        ChitTietDAL = New ChiTietBaoCaoMuonSachTheoTheLoai_DAL(connectionString)
    End Sub

    Public Function selecListChiTiet(ByRef TheLoaiSach As String, ByRef Nam As String, ByRef Thang As String, ByRef ChiTiet As ChiTietBaoCaoMuonSachTheoTheLoai_DTO, ByRef TongSoLuotMuon As String) As Result
        Return ChitTietDAL.selectListChiTiet(TheLoaiSach, Nam, Thang, ChiTiet, TongSoLuotMuon)
    End Function
    Public Function LoadListChiTietByNam(ByRef Nam As String, ByRef listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)) As Result
        Return ChitTietDAL.LoadListChiTietByNam(Nam, listChiTiet)
    End Function
    Public Function LoadListChiTietByNam_ByThang(ByRef Nam As String, ByRef Thang As String, ByRef listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)) As Result
        Return ChitTietDAL.LoadListChiTietByNam_ByThang(Nam, Thang, listChiTiet)
    End Function
    Public Function SelectAll(ByRef listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)) As Result
        Return ChitTietDAL.SelectAll(listChiTiet)
    End Function
End Class
