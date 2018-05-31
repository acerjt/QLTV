Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility


Public Class ChiTietBaoCaoMuonSachTheoThang_DAL
    Public connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectListChiTiet(ByRef TheLoai As String, ByRef Nam As String, ByRef Thang As String, ByRef ChiTiet As ChiTietBaoCaoMuonSachTheoThang_DTO, ByRef TongSoLuotMuon As String) As Result  'ex: 18222229


        Dim query As String = String.Empty

        query &= " select [TenTheLoaiSach],count([TenTheLoaiSach]) as [SoLuotMuon], count([TenTheLoaiSach])*1.0 / (select count([masach]) from [tblPhieuMuonSach], [tblChiTietPhieuMuonSach] where MONTH([ngaymuon])=@Thang And year([ngaymuon]) =@Nam and [tblChiTietPhieuMuonSach].[maphieumuonsach]=[tblPhieuMuonSach].[maphieumuonsach] )*100 as [TyLe],(select count([masach]) from [tblPhieuMuonSach], [tblChiTietPhieuMuonSach] where MONTH([ngaymuon])=@Thang And year([ngaymuon]) =@Nam and [tblChiTietPhieuMuonSach].[maphieumuonsach]=[tblPhieuMuonSach].[maphieumuonsach] ) As [TongSoLuotMuon] "
        query &= " from [tblChiTietPhieuMuonSach],[tblSach],[tblTheLoaiSach],[tblPhieuMuonSach]"
        query &= " where [tblChiTietPhieuMuonSach].[masach] = [tblSach].[MaSach]"
        query &= " And [tblSach].[MaTheLoaiSach]=[tblTheLoaiSach].[MaTheLoaiSach]"
        query &= " And [tblChiTietPhieuMuonSach].[maphieumuonsach]=[tblPhieuMuonSach].[maphieumuonsach]"
        query &= " And [tblsach].[MaTheLoaiSach] =@MaTheLoaiSach"
        query &= " And MONTH([ngaymuon])=@Thang"
        query &= " And year([ngaymuon]) =@Nam"
        query &= " group by [TenTheLoaiSach]"






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
                    .Parameters.AddWithValue("@MaTheLoaiSach", TheLoai)
                    .Parameters.AddWithValue("@Thang", Thang)
                    .Parameters.AddWithValue("@Nam", Nam)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()
                            ChiTiet = (New ChiTietBaoCaoMuonSachTheoThang_DTO(reader("TenTheLoaiSach"), reader("SoLuotMuon"), reader("TyLe")))
                            TongSoLuotMuon = reader("TongSoLuotMuon")
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

    Public Function LoadListChiTietByNam(ByRef Nam As String, ByRef listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)) As Result
        Dim query As String = String.Empty

        query &= " select [TenTheLoaiSach],[SoLuotMuon],[Tyle],[Thang],[Nam]"
        query &= " from [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai],[tblBaoCaoThongKeMuonSachTheoTheLoai],[tblTheLoaiSach]"
        query &= " where [tblBaoCaoThongKeMuonSachTheoTheLoai].[MaBaoCaoThongKeMuonSachTheoTheLoai] = [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai].[MaBaoCaoThongKeMuonSachTheoTheLoai]"
        query &= " And [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai].[MaTheLoaiSach] =[tblTheLoaiSach].[MaTheLoaiSach]"
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
                            listChiTiet.Add(New ChiTietBaoCaoMuonSachTheoThang_DTO(reader("TenTheLoaiSach"), reader("SoLuotMuon"), reader("TyLe"), reader("Thang"), reader("Nam")))
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

    Public Function LoadListChiTietByNam_ByThang(ByRef Nam As String, ByRef Thang As String, ByRef listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)) As Result
        Dim query As String = String.Empty

        query &= " select [TenTheLoaiSach],[SoLuotMuon],[Tyle],[Thang],[Nam]"
        query &= " from [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai],[tblBaoCaoThongKeMuonSachTheoTheLoai],[tblTheLoaiSach]"
        query &= " where [tblBaoCaoThongKeMuonSachTheoTheLoai].[MaBaoCaoThongKeMuonSachTheoTheLoai] = [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai].[MaBaoCaoThongKeMuonSachTheoTheLoai]"
        query &= " And [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai].[MaTheLoaiSach] =[tblTheLoaiSach].[MaTheLoaiSach]"
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
                            listChiTiet.Add(New ChiTietBaoCaoMuonSachTheoThang_DTO(reader("TenTheLoaiSach"), reader("SoLuotMuon"), reader("TyLe"), reader("Thang"), reader("Nam")))
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



    Public Function SelectAll(ByRef listChiTiet As List(Of ChiTietBaoCaoMuonSachTheoThang_DTO)) As Result
        Dim query As String = String.Empty

        query &= " select [TenTheLoaiSach],[SoLuotMuon],[Tyle],[Thang],[Nam]"
        query &= " from [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai],[tblBaoCaoThongKeMuonSachTheoTheLoai],[tblTheLoaiSach]"
        query &= " where [tblBaoCaoThongKeMuonSachTheoTheLoai].[MaBaoCaoThongKeMuonSachTheoTheLoai] = [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai].[MaBaoCaoThongKeMuonSachTheoTheLoai]"
        'query &= " And [tblSach].[MaTheLoaiSach]=[tblTheLoaiSach].[MaTheLoaiSach]"
        'query &= " And [tblChiTietPhieuMuonSach].[maphieumuonsach]=[tblPhieuMuonSach].[maphieumuonsach]"
        query &= " And [tblChiTietBaoCaoThongKeMuonSachTheoTheLoai].[MaTheLoaiSach] =[tblTheLoaiSach].[MaTheLoaiSach]"
        'query &= " And MONTH([ngaymuon])=@Thang"
        'query &= " And year([Nam]) =@Nam"
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
                    '.Parameters.AddWithValue("@Nam", Nam)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTiet.Clear()
                        While reader.Read()
                            listChiTiet.Add(New ChiTietBaoCaoMuonSachTheoThang_DTO(reader("TenTheLoaiSach"), reader("SoLuotMuon"), reader("TyLe"), reader("Thang"), reader("Nam")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả danh sách báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
