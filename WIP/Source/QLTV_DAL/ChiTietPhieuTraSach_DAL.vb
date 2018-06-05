Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility


Public Class ChiTietPhieuTraSach_DAL
    Public connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function selectSachDaMuon(ByRef MaDocGia As String, ByRef ListChiTietPhieuMuonSach As List(Of Sach_DTO)) As Result  'ex: 18222229


        Dim query As String = String.Empty

        query &= "Select [tblChitietphieumuonsach].[MaPhieuMuonSach],[tblChitietphieumuonsach].[Masach],[tblPhieuMuonSach].[Maphieumuonsach],[TenSach],[TenTheLoaiSach],[TenTacGia],[tblChitietphieumuonsach].[TinhTrang],[NgayDuKienTra] "
        query &= "From [tblSach], [tblChiTietPhieuMuonSach], [tblPhieuMuonSach], [tblTheLoaiSach], [tblTacGia]"
        query &= "Where [tblSach].[MaSach] = [tblChiTietPhieuMuonSach].[MaSach]"
        query &= "And [tblPhieuMuonSach].[MaPhieuMuonSach]=[tblChiTietPhieuMuonSach].[MaPhieuMuonSach] "
        query &= "And [tblSach].MaTheLoaiSach=[tblTheLoaiSach].[MaTheLoaiSach]"
        query &= "And [tblSach].[MaTacGia]=[tblTacGia].[MaTacGia]"
        query &= "And [tblChiTIetPhieuMuonSach].[TinhTrang] Like N'%Đang Mượn%'"
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
                            ListChiTietPhieuMuonSach.Add(New Sach_DTO(reader("MaSach"), reader("TenSach"), reader("TenTheLoaiSach"), reader("TenTacGia"), reader("TinhTrang"), reader("NgayDuKienTra"), reader("MaPhieuMuonSach")))
                        End While
                        Dim currentdate = DateTime.Now

                        For Each x As Sach_DTO In ListChiTietPhieuMuonSach
                            If (currentdate > x.NgayDuKien) Then
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
