Public Class ChiTietPhieuMuonSach_DTO
    Private strMaSach As String
    Private strMaPhieuMuonSach As String
    'Private iMaSach As Integer
    Private strTenSach As String
    Private strTheLoaiSach As String
    Private strTenTacGia As String
    Private strTinhTrang As String
    Private dateNgayDuKien As DateTime

    Public Sub New()

    End Sub
    Public Sub New(strMaSach As String,
                   strMaPhieuMuonSach As String,
                    strTenSach As String,
                   strTheLoaiSach As String,
                   strTenTacGia As String,
                   strTinhTrang As String,
                   dateNgayDuKien As DateTime)

        'Me.strMaChiTietPhieuMuonSach = strMaChiTietPhieuMuonSach
        Me.strMaSach = strMaSach
        Me.strMaPhieuMuonSach = strMaPhieuMuonSach
        'Me.iMaSach = iMaSach
        Me.strTenSach = strTenSach
        Me.strTheLoaiSach = strTheLoaiSach
        Me.strTenTacGia = strTenTacGia
        Me.strTinhTrang = strTinhTrang
        Me.dateNgayDuKien = dateNgayDuKien
    End Sub


    Public Sub New(strMaPhieuMuonSach As String, strMaSach As String)
        'Me.strMaChiTietPhieuMuonSach = strMaChiTietPhieuMuonSach
        Me.strMaSach = strMaSach
        Me.strMaPhieuMuonSach = strMaPhieuMuonSach
    End Sub

    Property MaSach() As String
        Get
            Return strMaSach
        End Get
        Set(ByVal Value As String)
            strMaSach = Value
        End Set
    End Property

    Property MaPhieuMuonSach() As String
        Get
            Return strMaPhieuMuonSach
        End Get
        Set(ByVal Value As String)
            strMaPhieuMuonSach = Value
        End Set
    End Property

    Property TenSach() As String
        Get
            Return strTenSach
        End Get
        Set(ByVal Value As String)
            strTenSach = Value
        End Set
    End Property


    Property TheLoaiSach() As String
        Get
            Return strTheLoaiSach
        End Get
        Set(ByVal Value As String)
            strTheLoaiSach = Value
        End Set
    End Property


    Property TenTacGia() As String
        Get
            Return strTenTacGia
        End Get
        Set(ByVal Value As String)
            strTenTacGia = Value
        End Set
    End Property


    Property TinhTrang() As String
        Get
            Return strTinhTrang
        End Get
        Set(ByVal Value As String)
            strTinhTrang = Value
        End Set
    End Property


    Property NgayDuKienTra() As DateTime
        Get
            Return dateNgayDuKien
        End Get
        Set(ByVal Value As DateTime)
            dateNgayDuKien = Value
        End Set
    End Property
End Class
