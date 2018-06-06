Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class Login_BUS
    Private loginDAL As Login_DAL
    Public Sub New()
        loginDAL = New Login_DAL
    End Sub
    Public Sub New(connectionString As String)
        loginDAL = New Login_DAL(connectionString)
    End Sub
    Public Function getNextID(ByRef Login As Login_DTO) As Result
        Return loginDAL.getNextID(Login)
    End Function


End Class
