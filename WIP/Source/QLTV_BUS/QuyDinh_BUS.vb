Imports QLTV_DTO
Imports QLTV_DAL
Imports Utility
Public Class QuyDinh_BUS

    Private qdDAL As QuyDinh_DAL
    Public Sub New()
        qdDAL = New QuyDinh_DAL()
    End Sub
    Public Sub New(connectionString As String)
        qdDAL = New QuyDinh_DAL(connectionString)
    End Sub
    Public Function update(quydinh As QuyDinh_DTO) As Result
        Return qdDAL.update(quydinh)
    End Function
    Public Function GetQuyDinh(ByRef quydinh As QuyDinh_DTO) As Result
        Return qdDAL.GetQuyDinh(quydinh)
    End Function
    Public Function selectALL(ByRef quydinh As List(Of QuyDinh_DTO)) As Result
        Return qdDAL.selectALL(quydinh)
    End Function
End Class


