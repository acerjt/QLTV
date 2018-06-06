Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class Login_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef Login As Login_DTO) As Result


        Dim query As String = String.Empty
        query &= " SELECT *  "
        query &= " FROM [tblLogin] "
        query &= " WHERE [username] =@username "
        query &= " AND [password] =@password "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@username", Login.Username)
                    .Parameters.AddWithValue("@password", Login.PassWord)
                End With
                Try
                    conn.Open()
                    Dim adapter As New SqlDataAdapter(comm)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    If (table.Rows.Count() <= 0) Then
                        Return New Result(False)

                    Else
                        Return New Result(True)
                    End If
                    ' new ID = current ID + 1

                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy ID kế tiếp của Mã Báo Cáo Thống Kê Mượn Sách Theo Thể Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
