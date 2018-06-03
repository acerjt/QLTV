Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class ChiTietBaoCaoThongKeSachTraTre_DAL
    Public connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectListChiTiet(ByRef Nam As String, ByRef Thang As String, ByRef listChiTiet As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)) As Result  'ex: 18222229


        Dim query As String = String.Empty

        query &= " select [tensach],[ngaymuon],DATEDIFF ( day , [ngaydukientra] , [ngaytra] ) as [Songaytratre]"
        query &= " from [tblChiTietPhieuTraSach],[tblPhieuTraSach],[tblSach],[tblPhieuMuonSach]"
        query &= " where [tblChiTietPhieuTraSach].[maphieutrasach]=[tblPhieuTraSach].[maphieutrasach]"
        query &= " and [tblSach].[MaSach]=[tblChiTietPhieuTraSach].[masach]"
        query &= " and [tblChiTietPhieuTraSach].[MaPhieuMuonSach]=[tblPhieuMuonSach].[maphieumuonsach]"
        query &= " And [tblChiTietPhieuTraSach].[tinhtrang] Like N'%Trả Trễ%'"
        query &= " And year([ngaytra])=@Nam"
        query &= " And month([ngaytra])=@Thang"







        'query &= "From [tblSach], [tblChiTietPhieuMuonSach], [tblPhieuMuonSach], [tblTheLoaiSach], [tblTacGia]"
        'query &= "Where [tblSach].[MaSach] = [tblChiTietPhieuMuonSach].[MaSach]"
        'query &= "And [tblPhieuMuonSach].[MaPhieuMuonSach]=[tblChiTietPhieuMuonSach].[MaPhieuMuonSach] "
        'query &= "And [tblSach].MaTheLoaiSach=[tblTheLoaiSach].[MaTheLoaiSach]"
        'query &= "And [tblSach].[MaTacGia]=[tblTacGia].[MaTacGia]"
        'query &= "And [tblChiTietPhieuMuonSach].[TinhTrang]='DangMuon'"
        'query &= "And [MaDocGia]=@MaDocGia"





        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Thang", Thang)
                    .Parameters.AddWithValue("@Nam", Nam)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTiet.Clear()
                        While reader.Read()
                            listChiTiet.Add(New ChiTietBaoCaoThongKeSachTraTre_DTO(reader("TenSach"), reader("NgayMuon"), reader("SoNgayTraTre")))
                        End While

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

    Public Function LoadListChiTietByNam(ByRef Nam As String, ByRef listChiTiet As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)) As Result
        Dim query As String = String.Empty

        query &= " select [TenSach],[NgayMuon],[SoNgayTraTre],[Thang],[Nam]"
        query &= " from [tblChiTietBaoCaoThongKeSachTraTre],[tblBaoCaoThongKeSachTraTre]"
        query &= " where [tblChiTietBaoCaoThongKeSachTraTre].[MaBaoCaoThongKeSachTraTre] = [tblBaoCaoThongKeSachTraTre].[MaBaoCaoThongKeSachTraTre]"
        query &= " And [Nam] =@Nam"
        'query &= " group by [TenTheLoaiSach]"






        'query &= "From [tblSach], [tblChiTietPhieuMuonSach], [tblPhieuMuonSach], [tblTheLoaiSach], [tblTacGia]"
        'query &= "Where [tblSach].[MaSach] = [tblChiTietPhieuMuonSach].[MaSach]"
        'query &= "And [tblPhieuMuonSach].[MaPhieuMuonSach]=[tblChiTietPhieuMuonSach].[MaPhieuMuonSach] "
        'query &= "And [tblSach].MaTheLoaiSach=[tblTheLoaiSach].[MaTheLoaiSach]"
        'query &= "And [tblSach].[MaTacGia]=[tblTacGia].[MaTacGia]"
        'query &= "And [tblChiTietPhieuMuonSach].[TinhTrang]='DangMuon'"
        'query &= "And [MaDocGia]=@MaDocGia"





        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@MaTheLoaiSach", TheLoai)
                    '.Parameters.AddWithValue("@Thang", Thang)
                    .Parameters.AddWithValue("@Nam", Nam)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTiet.Clear()
                        While reader.Read()
                            listChiTiet.Add(New ChiTietBaoCaoThongKeSachTraTre_DTO(reader("TenSach"), reader("NgayMuon"), reader("SoNgayTraTre"), reader("Thang"), reader("Nam")))
                        End While
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

    Public Function LoadListChiTietByNam_ByThang(ByRef Nam As String, ByRef Thang As String, ByRef listChiTiet As List(Of ChiTietBaoCaoThongKeSachTraTre_DTO)) As Result
        Dim query As String = String.Empty


        query &= " select [TenSach],[NgayMuon],[SoNgayTraTre],[Thang],[Nam]"
        query &= " from [tblChiTietBaoCaoThongKeSachTraTre],[tblBaoCaoThongKeSachTraTre]"
        query &= " where [tblBaoCaoThongKeSachTraTre].[MaBaoCaoThongKeSachTraTre] = [tblChiTietBaoCaoThongKeSachTraTre].[MaBaoCaoThongKeSachTraTre]"
        query &= " And [Nam] =@Nam"
        query &= " And [Thang] =@Thang"
        'query &= " group by [TenTheLoaiSach]"






        'query &= "From [tblSach], [tblChiTietPhieuMuonSach], [tblPhieuMuonSach], [tblTheLoaiSach], [tblTacGia]"
        'query &= "Where [tblSach].[MaSach] = [tblChiTietPhieuMuonSach].[MaSach]"
        'query &= "And [tblPhieuMuonSach].[MaPhieuMuonSach]=[tblChiTietPhieuMuonSach].[MaPhieuMuonSach] "
        'query &= "And [tblSach].MaTheLoaiSach=[tblTheLoaiSach].[MaTheLoaiSach]"
        'query &= "And [tblSach].[MaTacGia]=[tblTacGia].[MaTacGia]"
        'query &= "And [tblChiTietPhieuMuonSach].[TinhTrang]='DangMuon'"
        'query &= "And [MaDocGia]=@MaDocGia"





        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@MaTheLoaiSach", TheLoai)
                    '.Parameters.AddWithValue("@Thang", Thang)
                    .Parameters.AddWithValue("@Nam", Nam)
                    .Parameters.AddWithValue("@Thang", Thang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTiet.Clear()
                        While reader.Read()
                            listChiTiet.Add(New ChiTietBaoCaoThongKeSachTraTre_DTO(reader("TenSach"), reader("NgayMuon"), reader("SoNgayTraTre"), reader("Thang"), reader("Nam")))
                        End While
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
