Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class QuyDinhDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function update(qd As QuyDinhDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [[tblquydinh]] SET"
        query &= " [tuoitoithieu] = @tuoitoithieu "
        query &= " ,[tuoitoida] = @tuoitoida "
        query &= " ,[thoigiansudung] = @thoigiansudung"
        query &= "WHERE "
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
    Public Function selectALL(ByRef quydinh As List(Of QuyDinhDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [id], [tuoitoithieu], [tuoitoida], [thoigiansudung]"
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
                            quydinh.Add(New QuyDinhDTO(reader("id"), reader("tuoitoithieu"), reader("tuoitoida"), reader("thoigiansudung")))
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

    Public Function GetQuyDinh(ByRef GetTuoitoiThieu As Integer, ByRef GetTuoiToiDa As Integer, ByRef GetThoiGianSuDung As Integer) As Result 'ex: 18222229

        GetTuoiToiDa = 0
        GetTuoiToiDa = 0
        GetThoiGianSuDung = 0



        Dim query As String = String.Empty
        query &= "SELECT [tuoitoithieu],[tuoitoida],[thoigiansudung] "
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
                    Dim TuoiToiThieu As Integer
                    TuoiToiThieu = Nothing
                    Dim TuoiToiDa As Integer
                    TuoiToiDa = Nothing
                    Dim ThoiGianSuDung As Integer
                    ThoiGianSuDung = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            TuoiToiThieu = reader("tuoitoithieu")
                            TuoiToiDa = reader("tuoitoida")
                            ThoiGianSuDung = reader("thoigiansudung")
                        End While
                    End If
                    'If (msOnDB <> Nothing And msOnDB.Length >= 1) Then
                    'Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                    'Dim iCurrentYear = Integer.Parse(currentYear)
                    'Dim currentYearOnDB = msOnDB.Substring(0, 2)
                    'Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                    'Dim year = iCurrentYear
                    'If (year < icurrentYearOnDB) Then
                    '    year = icurrentYearOnDB
                    'End If
                    'nextMaDocGia = year.ToString()
                    'Dim v = msOnDB.Substring(2)
                    'Dim convertDecimal = Convert.ToDecimal(v)
                    'convertDecimal = convertDecimal + 1
                    'Dim tmp = convertDecimal.ToString()
                    'tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                    'nextMaDocGia = msOnDB + 1
                    '    System.Console.WriteLine(nextMaDocGia)
                    GetTuoitoiThieu = TuoiToiThieu
                    GetTuoiToiDa = TuoiToiDa
                    GetThoiGianSuDung = ThoiGianSuDung
                    'End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Độc Giả kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
