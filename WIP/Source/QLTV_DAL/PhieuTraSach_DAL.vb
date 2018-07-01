Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility


Public Class PhieuTraSach_DAL

    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result


        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaPhieuTraSach] "
        query &= "FROM [tblPhieuTraSach] "
        query &= "ORDER BY [MaPhieUTraSach] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaPhieuTraSach")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Mã Phiếu Mượn Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(pts As PhieuTraSach_DTO, listChiTietPhieuTraSach As List(Of ChiTietPhieuTraSach_DTO)) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuTraSach] ([MaPhieuTraSach], [MaDocGia], [NgayTra])"
        query &= "VALUES (@MaPhieuTraSach, @MaDocGia, @NgayTra)"

        Dim query1 As String = String.Empty
        query1 &= "INSERT INTO [tblChiTietPhieuTraSach] ( [MaPhieuTraSach],[MaSach],[TinhTrang],[MaPhieuMuonSach])"
        query1 &= "VALUES (@MaPhieuTraSach1, @MaSach,@TinhTrang,@MaPhieuMuonSach)"

        Dim query2 As String = String.Empty
        query2 &= " UPDATE [tblSach] SET"
        query2 &= " [TinhTrang]=@TinhTrang"
        query2 &= " WHERE "
        query2 &= " [MaSach] = @MaSach2"



        Dim query3 As String = String.Empty
        query3 &= " UPDATE [tblChitietphieumuonsach] SET"
        query3 &= " [TinhTrang]=@TinhTrang"
        query3 &= " WHERE "
        query3 &= " [MaSach] = @MaSach3"





        Dim nextID = 1
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        pts.MaTraSach = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm, comm1, comm2, comm3 As New SqlCommand()

                conn.Open()
                With comm1

                    For Each x As ChiTietPhieuTraSach_DTO In listChiTietPhieuTraSach
                        .Parameters.Clear()
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query1
                        .Parameters.AddWithValue("@MaPhieuTraSach1", pts.MaTraSach)
                        .Parameters.AddWithValue("@MaSach", x.MaSach)
                        .Parameters.AddWithValue("@TinhTrang", x.TinhTrang)
                        .Parameters.AddWithValue("@MaPhieuMuonSach", x.MaPhieuMuonSach)
                        Try
                            .ExecuteNonQuery()
                            'conn.Close()
                        Catch ex As Exception
                            conn.Close()
                            ' them that bai!!!
                            Return New Result(False, "Lập Phiếu Mượn Sách không thành công", ex.StackTrace)
                        End Try
                    Next

                End With

                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuTraSach", pts.MaTraSach)
                    .Parameters.AddWithValue("@MaDocGia", pts.MaDocGia)
                    .Parameters.AddWithValue("@NgayTra", pts.NgayTra)
                    '.Parameters.AddWithValue("@ngaydukientra", pms.NgayDuKienTra)
                    '.Parameters.AddWithValue("@tinhtrang", "DangMuon")
                    'Dim comm1 As New SqlCommand()

                End With
                Try
                    'conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lập Phiếu Mượn Sách không thành công", ex.StackTrace)
                End Try

                With comm2
                    For Each x As ChiTietPhieuTraSach_DTO In listChiTietPhieuTraSach
                        .Parameters.Clear()
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query2
                        .Parameters.AddWithValue("@masach2", x.MaSach)
                        .Parameters.AddWithValue("@tinhtrang", " ")
                        Try
                            .ExecuteNonQuery()
                            'conn.Close()
                        Catch ex As Exception
                            conn.Close()
                            ' them that bai!!!
                            Return New Result(False, "Lập Phiếu Mượn Sách không thành công", ex.StackTrace)
                        End Try
                    Next

                End With
                Try
                    'conn.Open()
                    comm2.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lập Phiếu Mượn Sách không thành công", ex.StackTrace)
                End Try

                With comm3
                    For Each x As ChiTietPhieuTraSach_DTO In listChiTietPhieuTraSach
                        .Parameters.Clear()
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query3
                        .Parameters.AddWithValue("@masach3", x.MaSach)
                        .Parameters.AddWithValue("@tinhtrang", " ")
                        Try
                            .ExecuteNonQuery()
                            'conn.Close()
                        Catch ex As Exception
                            conn.Close()
                            ' them that bai!!!
                            Return New Result(False, "Lập Phiếu Mượn Sách không thành công", ex.StackTrace)
                        End Try
                    Next

                End With
                Try
                    'conn.Open()
                    comm2.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lập Phiếu Mượn Sách không thành công", ex.StackTrace)
                End Try



            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    'Public Function update(pdg As PhieuMuonSach_DTO) As Result

    '    Dim query As String = String.Empty
    '    query &= " UPDATE [tblLoaiDocGia] SET"
    '    query &= " [tenloaidocgia] = @tenloaidocgia "
    '    query &= "WHERE "
    '    query &= " [maloaidocgia] = @maloaidocgia "

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '                .Parameters.AddWithValue("@maloaidocgia", ldg.MaLoaiDocGia)
    '                .Parameters.AddWithValue("@tenloaidocgia", ldg.TenLoaiDocGia)
    '            End With
    '            Try
    '                conn.Open()
    '                comm.ExecuteNonQuery()
    '            Catch ex As Exception
    '                Console.WriteLine(ex.StackTrace)
    '                conn.Close()
    '                ' them that bai!!!
    '                Return New Result(False, "Cập nhật Độc Giả không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True) ' thanh cong
    'End Function


    Public Function selectALL(ByRef listPhieuTraSach As List(Of PhieuTraSach_DTO)) As Result

        Dim query As String = String.Empty

        query &= " SELECT [MaPhieuTraSach], [MaDocGia], [NgayTra]"
        query &= " FROM [tblPhieuTraSach]"



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
                        listPhieuTraSach.Clear()
                        While reader.Read()
                            listPhieuTraSach.Add(New PhieuTraSach_DTO(reader("maphieutrasach"), reader("madocgia"), reader("ngaytra")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phiếu mượn sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(MaPhieuMuonSach As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhieuMuonSach] "
        query &= " WHERE "
        query &= " [maphieumuonsach] = @maphieumuonsach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieumuonsach", MaPhieuMuonSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa phiếu mượn sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


End Class
