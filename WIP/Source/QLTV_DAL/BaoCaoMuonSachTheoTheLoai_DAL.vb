Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class BaoCaoMuonSachTheoTheLoai_DAL
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
        query &= "SELECT TOP 1 [MaBaoCaoThongKeMuonSachTheoTheLoai] "
        query &= "FROM [tblBaoCaoThongKeMuonSachTheoTheLoai] "
        query &= "ORDER BY [MaBaoCaoThongKeMuonSachTheoTheLoai] DESC "

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
                            idOnDB = reader("MaBaoCaoThongKeMuonSachTheoTheLoai")
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

    Public Function insert(bctkms As BaoCaoMuonSachTheoTheLoai_DTO, listChiTietbctkms As List(Of ChiTietBaoCaoMuonSachTheoTheLoai_DTO)) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblBaoCaoThongKeMuonSachTheoTheLoai] ([MaBaoCaoThongKeMuonSachTheoTheLoai], [Nam], [Thang], [TongSoLuotMuon], [NgayLap])"
        query &= "VALUES (@MaBaoCaoThongKeMuonSachTheoTheLoai, @Nam, @Thang, @TongSoLuotMuon, @NgayLap)"

        Dim query1 As String = String.Empty
        query1 &= "INSERT INTO [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai] ( [MaBaoCaoThongKeMuonSachTheoTheLoai],[MaTheLoaiSach],[SoLuotMuon],[TyLe])"
        query1 &= "VALUES (@MaBaoCaoThongKeMuonSachTheoTheLoai1, @MaTheLoaiSach,@SoLuotMuon,@TyLe)"

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
        bctkms.MaBaoCaoMuonSachTheoThang = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm, comm1 As New SqlCommand()

                conn.Open()
                With comm1

                    For Each x As ChiTietBaoCaoMuonSachTheoTheLoai_DTO In listChiTietbctkms
                        .Parameters.Clear()
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query1
                        .Parameters.AddWithValue("@MaBaoCaoThongKeMuonSachTheoTheLoai1", bctkms.MaBaoCaoMuonSachTheoThang)
                        .Parameters.AddWithValue("@MaTheLoaiSach", x.TheLoai)
                        .Parameters.AddWithValue("@SoLuotMuon", x.SoLuotMuon)
                        .Parameters.AddWithValue("@TyLe", x.TyLe)
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
                    .Parameters.AddWithValue("@MaBaoCaoThongKeMuonSachTheoTheLoai", bctkms.MaBaoCaoMuonSachTheoThang)
                    .Parameters.AddWithValue("@Nam", bctkms.Nam)
                    .Parameters.AddWithValue("@Thang", bctkms.Thang)
                    .Parameters.AddWithValue("@TongSoLuotMuon", bctkms.TongSoLuotMuon)
                    .Parameters.AddWithValue("@NgayLap", bctkms.NgayLap)
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
