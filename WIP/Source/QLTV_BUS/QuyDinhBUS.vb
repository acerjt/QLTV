Imports QLTV_DTO
Imports QLTV_DAL
Imports Utility
Public Class QuyDinhBUS
    Private qdDAL As QuyDinhDAL
    Public Sub New()
        qdDAL = New QuyDinhDAL()
    End Sub
    Public Sub New(connectionString As String)
        qdDAL = New QuyDinhDAL(connectionString)
    End Sub
    Public Function update(qd As QuyDinhDTO) As Result
        Return qdDAL.update(qd)
    End Function
    Public Function GetQuyDinh(ByRef GetTuoitoiThieu As Integer, ByRef GetTuoiToiDa As Integer, ByRef GetThoiGianSuDung As Integer) As Result
        Return qdDAL.GetQuyDinh(GetTuoitoiThieu, GetTuoiToiDa, GetThoiGianSuDung)
    End Function
    Public Function selectALL(ByRef quydinh As List(Of QuyDinhDTO)) As Result
        Return qdDAL.selectALL(quydinh)
    End Function
End Class
