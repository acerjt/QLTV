Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class QuyDinh_DAL

    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function update(ByRef qd As QuyDinh_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblquydinh] SET"
        query &= " [tuoitoithieu] = @tuoitoithieu "
        query &= " ,[tuoitoida] = @tuoitoida"
        query &= " ,[thoigiansudung] = @thoigiansudung"
        query &= " ,[sotheloaisachtoida] = @sotheloaisachtoida"
        query &= " ,[sotacgiatoida] = @sotacgiatoida"
        query &= " ,[khoangcachnamxuatban] = @khoangcachnamxuatban"
        query &= " ,[soluongsachmuontoida] = @soluongsachmuontoida"
        query &= " ,[songaymuontoida] = @songaymuontoida"
        query &= " WHERE "
        query &= " [id] = @id "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tuoitoithieu", qd.TuoiToiThieu)
                    .Parameters.AddWithValue("@tuoitoida", qd.TuoiToiDa)
                    .Parameters.AddWithValue("@thoigiansudung", qd.ThoiGianSuDung)
                    .Parameters.AddWithValue("@sotheloaisachtoida", qd.SoTheLoaiSachToiDa)
                    .Parameters.AddWithValue("@sotacgiatoida", qd.SoTacGiaToiDa)
                    .Parameters.AddWithValue("@soluongsachmuontoida", qd.SoLuongSachMuonToiDa)
                    .Parameters.AddWithValue("@songaymuontoida", qd.SoNgayMuonToiDa)
                    .Parameters.AddWithValue("@khoangcachnamxuatban", qd.KhoangCachNamXuatBan)
                    .Parameters.AddWithValue("@id", qd.ID)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef quydinh As List(Of QuyDinh_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [id], [tuoitoithieu], [tuoitoida], [thoigiansudung],[sotheloaisachtoida], [sotacgiatoida], [khoangcachnamxuatban],[soluongsachmuontoida],[songaymuontoida]"
        query &= " FROM [tblquydinh]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        quydinh.Clear()
                        While reader.Read()
                            quydinh.Add(New QuyDinh_DTO(reader("id"), reader("tuoitoithieu"), reader("tuoitoida"), reader("thoigiansudung"), reader("sotheloaisachtoida"), reader("sotacgiatoida"), reader("khoangcachnamxuatban"), reader("soluongsachmuontoida"), reader("songaymuontoida")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function GetQuyDinh(ByRef quydinh As QuyDinh_DTO) As Result


        Dim query As String = String.Empty
        query &= "SELECT [id],[tuoitoithieu],[tuoitoida],[thoigiansudung],[sotheloaisachtoida],[sotacgiatoida],[khoangcachnamxuatban],[soluongsachmuontoida],[songaymuontoida]"
        query &= "FROM [tblQuyDinh] "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()

                    If reader.HasRows = True Then
                        While reader.Read()
                            quydinh = (New QuyDinh_DTO(reader("id"), reader("tuoitoithieu"), reader("tuoitoida"), reader("thoigiansudung"), reader("sotheloaisachtoida"), reader("sotacgiatoida"), reader("khoangcachnamxuatban"), reader("soluongsachmuontoida"), reader("songaymuontoida")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Quy Định kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
