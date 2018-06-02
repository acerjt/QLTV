Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class ChiTietBaoCaoThongKeSachTraTre_BUS
    Private ChitTietDAL As ChiTietBaoCaoThongKeSachTraTre_DAL

    Public Sub New()
        ChitTietDAL = New ChiTietBaoCaoThongKeSachTraTre_DAL
    End Sub
    Public Sub New(connectionString As String)
        ChitTietDAL = New ChiTietBaoCaoThongKeSachTraTre_DAL(connectionString)
    End Sub

    Public Function selecListChiTiet(ByRef Nam As String, ByRef Thang As String, ByRef ChiTiet As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)) As Result
        Return ChitTietDAL.selectListChiTiet(Nam, Thang, ChiTiet)
    End Function
    Public Function LoadListChiTietByNam(ByRef Nam As String, ByRef listChiTiet As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)) As Result
        Return ChitTietDAL.LoadListChiTietByNam(Nam, listChiTiet)
    End Function
    Public Function LoadListChiTietByNam_ByThang(ByRef Nam As String, ByRef Thang As String, ByRef listChiTiet As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)) As Result
        Return ChitTietDAL.LoadListChiTietByNam_ByThang(Nam, Thang, listChiTiet)
    End Function
    'Public Function SelectAll(ByRef listChiTiet As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)) As Result
    '    Return ChitTietDAL.SelectAll(listChiTiet)
    'End Function
End Class
