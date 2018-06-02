Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility



Public Class BaoCaoThongKeSachTraTre_DAL
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
        query &= "SELECT TOP 1 [MaBaoCaoThongKeSachTraTre] "
        query &= "FROM [tblBaoCaoThongKeSachTraTre] "
        query &= "ORDER BY [MaBaoCaoThongKeSachTraTre] DESC "

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
                            idOnDB = reader("MaBaoCaoThongKeSachTraTre")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Mã Báo Cáo Thống Kê Mượn Sách Theo Thể Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(bctkstt As BaoCaoThongKeSachTraTre_DTO, listChiTietbctkstt As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblBaoCaoThongKeSachTraTre] ([MaBaoCaoThongKeSachTraTre], [Nam], [Thang], [NgayLap])"
        query &= "VALUES (@MaBaoCaoThongKeSachTraTre, @Nam, @Thang, @NgayLap)"

        Dim query1 As String = String.Empty
        query1 &= "INSERT INTO [tblChiTietBaoCaoThongKeSachTraTre] ( [MaBaoCaoThongKeSachTraTre],[TenSach],[NgayMuon],[SoNgayTraTre])"
        query1 &= "VALUES (@MaBaoCaoThongKeSachTraTre1, @TenSach,@NgayMuon,@SoNgayTraTre)"

        'Dim query2 As String = String.Empty
        'query2 &= " UPDATE [tblSach] SET"
        'query2 &= " [TinhTrang]=@TinhTrang"
        'query2 &= " WHERE "
        'query2 &= " [MaSach] = @MaSach2"

        Dim nextID = 1
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        bctkstt.MaBaoCaoSachTreTre = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm, comm1 As New SqlCommand()

                conn.Open()
                With comm1

                    For Each x As ChiTietBaoCaoThongKeSachTraTre_DTO In listChiTietbctkstt
                        .Parameters.Clear()
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query1
                        .Parameters.AddWithValue("@MaBaoCaoThongKeSachTraTre1", bctkstt.MaBaoCaoSachTreTre)
                        .Parameters.AddWithValue("@TenSach", x.TenSach)
                        .Parameters.AddWithValue("@NgayMuon", x.NgayMuon)
                        .Parameters.AddWithValue("@SoNgayTraTre", x.SoNgayTraTre)
                        Try
                            .ExecuteNonQuery()
                            'conn.Close()
                        Catch ex As Exception
                            conn.Close()
                            ' them that bai!!!
                            Return New Result(False, "Lập Báo cáo không thành công", ex.StackTrace)
                        End Try
                    Next

                End With

                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaBaoCaoThongKeSachTraTre", bctkstt.MaBaoCaoSachTreTre)
                    .Parameters.AddWithValue("@Nam", bctkstt.Nam)
                    .Parameters.AddWithValue("@Thang", bctkstt.Thang)
                    .Parameters.AddWithValue("@NgayLap", bctkstt.NgayLap)
                    '.Parameters.AddWithValue("@tinhtrang", "DangMuon")
                    'Dim comm1 As New SqlCommand()

                End With
                Try
                    'conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lập Báo Cáo không thành công", ex.StackTrace)
                End Try

                'With comm2
                '    For Each x As ChiTietPhieuMuonSach_DTO In listChiTietPhieuMuonSach
                '        .Parameters.Clear()
                '        .Connection = conn
                '        .CommandType = CommandType.Text
                '        .CommandText = query2
                '        .Parameters.AddWithValue("@masach2", x.MaSach)
                '        .Parameters.AddWithValue("@tinhtrang", "DangMuon")
                '        Try
                '            .ExecuteNonQuery()
                '            'conn.Close()
                '        Catch ex As Exception
                '            conn.Close()
                '            ' them that bai!!!
                '            Return New Result(False, "Lập Phiếu Mượn Sách không thành công", ex.StackTrace)
                '        End Try
                '    Next

                'End With
                'Try
                '    'conn.Open()
                '    comm2.ExecuteNonQuery()
                'Catch ex As Exception
                '    conn.Close()
                '    ' them that bai!!!
                '    Return New Result(False, "Lập Phiếu Mượn Sách không thành công", ex.StackTrace)
                'End Try


            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


End Class
