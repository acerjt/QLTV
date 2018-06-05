Public Class ChiTietPhieuMuonSach_DTO
    Private strMaSach As String
    Private strMaPhieuMuonSach As String
    Private strTinhTrang As String
    'Private iMaSach As Integer
    'Private strTenSach As String
    'Private strTenTheLoaiSach As String
    'Private strTenTacGia As String
    'Private strTinhTrang As String
    'Private dateNgayDuKien As DateTime

    Public Sub New()

    End Sub





    Public Sub New(strMaPhieuMuonSach As String, strMaSach As String) ', strTinhTrang As String)
        'Me.strMaChiTietPhieuMuonSach = strMaChiTietPhieuMuonSach
        Me.strMaSach = strMaSach
        Me.strMaPhieuMuonSach = strMaPhieuMuonSach
        ' Me.strTinhTrang = strTinhTrang
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

    Property TinhTrang() As String
        Get
            Return strTinhTrang
        End Get
        Set(ByVal Value As String)
            strTinhTrang = Value
        End Set
    End Property
End Class
