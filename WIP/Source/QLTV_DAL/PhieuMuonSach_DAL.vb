Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class PhieuMuonSach_DAL

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
        query &= "SELECT TOP 1 [maphieumuonsach] "
        query &= "FROM [tblPhieuMuonSach] "
        query &= "ORDER BY [maphieumuonsach] DESC "

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
                            idOnDB = reader("maphieumuonsach")
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

    Public Function insert(pms As PhieuMuonSach_DTO, listChiTietPhieuMuonSach As List(Of ChiTietPhieuMuonSach_DTO)) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblphieumuonsach] ([maphieumuonsach], [madocgia], [ngaymuon], [ngaydukientra])"
        query &= "VALUES (@maphieumuonsach, @madocgia, @ngaymuon, @ngaydukientra)"

        Dim query1 As String = String.Empty
        query1 &= "INSERT INTO [tblChitietphieumuonsach] ( [maphieumuonsach],[masach],[tinhtrang])"
        query1 &= "VALUES (@maphieumuonsach1, @masach,@tinhtrang1)"

        Dim query2 As String = String.Empty
        query2 &= " UPDATE [tblSach] SET"
        query2 &= " [TinhTrang]=@TinhTrang"
        query2 &= " WHERE "
        query2 &= " [MaSach] = @MaSach2"

        Dim nextID = 1
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        pms.MaPhieuMuonSach = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm, comm1, comm2 As New SqlCommand()

                conn.Open()
                With comm1

                    For Each x As ChiTietPhieuMuonSach_DTO In listChiTietPhieuMuonSach
                        .Parameters.Clear()
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query1
                        .Parameters.AddWithValue("@maphieumuonsach1", x.MaPhieuMuonSach)
                        .Parameters.AddWithValue("@masach", x.MaSach)
                        .Parameters.AddWithValue("@tinhtrang1", "Đang Mượn")
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
                    .Parameters.AddWithValue("@maphieumuonsach", pms.MaPhieuMuonSach)
                    .Parameters.AddWithValue("@madocgia", pms.MaDocGia)
                    .Parameters.AddWithValue("@ngaymuon", pms.NgayMuon)
                    .Parameters.AddWithValue("@ngaydukientra", pms.NgayDuKienTra)
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
                    For Each x As ChiTietPhieuMuonSach_DTO In listChiTietPhieuMuonSach
                        .Parameters.Clear()
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query2
                        .Parameters.AddWithValue("@masach2", x.MaSach)
                        .Parameters.AddWithValue("@tinhtrang", "Đang Mượn")
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



    Public Function selectALL(ByRef listPhieuMuonSach As List(Of PhieuMuonSach_DTO)) As Result

        Dim query As String = String.Empty

        query &= " SELECT [maphieumuonsach], [madocgia], [ngaymuon], [ngaydukientra]"
        query &= " FROM [tblPhieuMuonSach]"



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
                        listPhieuMuonSach.Clear()
                        While reader.Read()
                            listPhieuMuonSach.Add(New PhieuMuonSach_DTO(reader("maphieumuonsach"), reader("madocgia"), reader("ngaymuon"), reader("ngaydukientra")))
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




