Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility



Public Class ChiTietPhieuMuonSach_DAL
    Public connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function selectSachDaMuon(ByRef MaDocGia As String, ByRef ListChiTietPhieuMuonSach As List(Of ChiTietPhieuMuonSach_DTO)) As Result  'ex: 18222229


        Dim query As String = String.Empty

        query &= "Select [tblSach].[Masach],[tblPhieuMuonSach].[Maphieumuonsach],[TenSach],[TenTheLoaiSach],[TenTacGia],[TinhTrang],[NgayDuKienTra] "
        query &= "From [tblSach], [tblChiTietPhieuMuonSach], [tblPhieuMuonSach], [tblTheLoaiSach], [tblTacGia]"
        query &= "Where [tblSach].[MaSach] = [tblChiTietPhieuMuonSach].[MaSach]"
        query &= "And [tblPhieuMuonSach].[MaPhieuMuonSach]=[tblChiTietPhieuMuonSach].[MaPhieuMuonSach] "
        query &= "And [tblSach].MaTheLoaiSach=[tblTheLoaiSach].[MaTheLoaiSach]"
        query &= "And [tblSach].[MaTacGia]=[tblTacGia].[MaTacGia]"
        query &= "And [tblSach].[TinhTrang]='DangMuon'"
        query &= "And [MaDocGia]=@MaDocGia"





        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDocGia", MaDocGia)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        ListChiTietPhieuMuonSach.Clear()
                        While reader.Read()
                            ListChiTietPhieuMuonSach.Add(New ChiTietPhieuMuonSach_DTO(reader("MaSach"), reader("MaPhieuMuonSach"), reader("TenSach"), reader("TenTheLoaiSach"), reader("TenTacGia"), reader("TinhTrang"), reader("NgayDuKienTra")))
                        End While
                        Dim currentdate = DateTime.Now

                        For Each x As ChiTietPhieuMuonSach_DTO In ListChiTietPhieuMuonSach
                            If (currentdate > x.NgayDuKienTra) Then
                                x.TinhTrang = "Đã Quá Hạn"
                            End If
                        Next
                    Else
                        ListChiTietPhieuMuonSach.Clear()
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Độc Giả theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function





End Class
