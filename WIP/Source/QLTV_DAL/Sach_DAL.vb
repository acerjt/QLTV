Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class Sach_DAL

    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaSach(ByRef nextMaSach As String) As Result 'ex: 18222229

        nextMaSach = String.Empty
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaSach] "
        query &= "FROM [tblSach] "
        query &= "ORDER BY [MaSach] DESC "

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
                    Dim MaSachOnDB As String
                    MaSachOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            MaSachOnDB = reader("MaSach")
                        End While
                    End If
                    If (MaSachOnDB <> Nothing And MaSachOnDB.Length >= 1) Then

                        'Dim v = msOnDB
                        'Dim convertDecimal = Convert.ToDecimal(v)
                        'convertDecimal = convertDecimal + 1
                        '' Dim tmp = convertDecimal.ToString()
                        '' tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMaSach = MaSachOnDB + 1
                        System.Console.WriteLine(nextMaSach)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã sách kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(Sach As Sach_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblSach] ([MaSach], [TenSach], [MaTheLoaiSach], [MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia])"
        query &= "VALUES (@MaSach,@TenSach,@MaTheLoaiSach,@MaTacGia,@NamXuatBan,@NhaXuatBan,@NgayNhap,@TriGia)"

        'get MSSach
        Dim nextMaSach = "1"
        buildMaSach(nextMaSach)
        Sach.MaSach = nextMaSach

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", Sach.MaSach)
                    .Parameters.AddWithValue("@TenSach", Sach.TenSach)
                    .Parameters.AddWithValue("@MaTheloaiSach", Sach.TheLoai)
                    .Parameters.AddWithValue("@MaTacGia", Sach.TenTacGia)
                    .Parameters.AddWithValue("@NamXuatBan", Sach.NamXuatBan)
                    .Parameters.AddWithValue("@NhaXuatBan", Sach.NhaXuatBan)
                    .Parameters.AddWithValue("@NgayNhap", Sach.NgayNhap)
                    .Parameters.AddWithValue("@TriGia", Sach.TriGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listSach As List(Of Sach_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaSach], [TenSach], [TenTheLoaiSach], [TenTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia]"
        query &= "FROM [tblSach],[tblTacGia],[tblTheLoaiSach]"
        query &= "WHERE  [tblSach].[MaTacGia]=[tblTacGia].[MaTacGia] AND [tblSach].[MaTheLoaiSach]=[tblTheLoaiSach].[MaTheLoaiSach]"

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
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(New Sach_DTO(reader("MaSach"), reader("TenSach"), reader("TenTheLoaiSach"), reader("TenTacGia"), reader("NamXuatBan"), reader("NhaXuatBan"), reader("NgayNhap"), reader("TriGia")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaTheLoaiSach(iMaTheLoaiSach As Integer, ByRef listSach As List(Of Sach_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaSach], [TenSach], [MaTheLoaiSach], [TenTacGia], [NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia] "
        query &= "FROM [tblSach]    , [tblTacGia] "
        query &= "WHERE [tblSach].[MaTacGia] = [tblTacGia].[MaTacGia]"
        query &= "     AND [MaTheLoaiSach] = @MaTheLoaiSach"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTheLoaiSach", iMaTheLoaiSach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(New Sach_DTO(reader("MaSach"), reader("TenSach"), reader("MaTheLoaiSach"), reader("TenTacGia"), reader("NamXuatBan"), reader("NhaXuatBan"), reader("NgayNhap"), reader("TriGia")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy sách theo thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaTacGia(iMaTacGia As Integer, ByRef listSach As List(Of Sach_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaSach], [TenSach], [TenTheLoaiSach], [MaTacGia], [NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia] "
        query &= "FROM [tblSach]    , [tblTheLoaiSach] "
        query &= "WHERE [tblSach].[MaTheLoaiSach] = [tblTheLoaiSach].[MaTheLoaiSach]"
        query &= "     AND [MaTacGia] = @MaTacGia"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTacGia", iMaTacGia)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(New Sach_DTO(reader("MaSach"), reader("TenSach"), reader("TenTheLoaiSach"), reader("MaTacGia"), reader("NamXuatBan"), reader("NhaXuatBan"), reader("NgayNhap"), reader("TriGia")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy sách theo tên tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(Sach As Sach_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblSach] SET"
        query &= " [TenSach] = @TenSach "
        query &= " ,[MaTheLoaiSach] = @MaTheLoaiSach "
        query &= " ,[MaTacGia] = @MaTacGia "
        query &= " ,[NamXuatBan] = @NamXuatBan "
        query &= " ,[NhaXuatBan] = @NhaXuatBan "
        query &= " ,[NgayNhap] = @NgayNhap "
        query &= " ,[TriGia] = @TriGia "
        query &= " WHERE "
        query &= " [MaSach] = @MaSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenSach", Sach.TenSach)
                    .Parameters.AddWithValue("@MaTheLoaiSach", Sach.TheLoai)
                    .Parameters.AddWithValue("@MaTacGia", Sach.TenTacGia)
                    .Parameters.AddWithValue("@NamXuatBan", Sach.NamXuatBan)
                    .Parameters.AddWithValue("@NhaXuatBan", Sach.NhaXuatBan)
                    .Parameters.AddWithValue("@NgayNhap", Sach.NgayNhap)
                    .Parameters.AddWithValue("@TriGia", Sach.TriGia)
                    .Parameters.AddWithValue("@MaSach", Sach.MaSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(MaSach As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblSach] "
        query &= " WHERE "
        query &= " [MaSach] = @MaSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", MaSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
