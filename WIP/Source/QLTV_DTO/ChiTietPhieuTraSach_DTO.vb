Public Class ChiTietPhieuTraSach_DTO

    Private strMaSach As String
    Private strMaPhieuTraSach As String
    'Private iMaSach As Integer
    'Private strTenSach As String
    'Private strTenTheLoaiSach As String
    'Private strTenTacGia As String
    'Private strTinhTrang As String
    'Private dateNgayDuKien As DateTime

    Public Sub New()

    End Sub
    'Public Sub New(strMaSach As String,
    '               strMaPhieuTraSach As String,
    '               strTenSach As String,
    '               strTenTheLoaiSach As String,
    '               strTenTacGia As String,
    '               strTinhTrang As String)
    '    'dateNgayDuKien As DateTime)

    '    'Me.strMaChiTietPhieuMuonSach = strMaChiTietPhieuMuonSach
    '    Me.strMaSach = strMaSach
    '    Me.strMaPhieuTraSach = strMaPhieuTraSach
    '    'Me.iMaSach = iMaSach
    '    Me.strTenSach = strTenSach
    '    Me.strTenTheLoaiSach = strTenTheLoaiSach
    '    Me.strTenTacGia = strTenTacGia
    '    Me.strTinhTrang = strTinhTrang
    '    ' Me.dateNgayDuKien = dateNgayDuKien
    'End Sub




    Public Sub New(strMaPhieuTraSach As String, strMaSach As String)
        'Me.strMaChiTietPhieuMuonSach = strMaChiTietPhieuMuonSach
        Me.strMaSach = strMaSach
        Me.strMaPhieuTraSach = strMaPhieuTraSach
    End Sub

    'Public Sub New(strTenSach As String,
    '               strTenTheLoaiSach As String,
    '               strTenTacGia As String,
    '               strTinhTrang As String)
    '    'dateNgayDuKien As DateTime)

    '    'Me.strMaChiTietPhieuMuonSach = strMaChiTietPhieuMuonSach
    '    'Me.strMaSach = strMaSach
    '    'Me.strMaPhieuMuonSach = strMaPhieuMuonSach
    '    'Me.iMaSach = iMaSach
    '    Me.strTenSach = strTenSach
    '    Me.strTenTheLoaiSach = strTenTheLoaiSach
    '    Me.strTenTacGia = strTenTacGia
    '    Me.strTinhTrang = strTinhTrang
    '    'Me.dateNgayDuKien = dateNgayDuKien
    'End Sub

    'Public Sub New(
    '                strTenSach As String,
    '               strTenTheLoaiSach As String,
    '               strTenTacGia As String,
    '               strTinhTrang As String) ',
    '    '  dateNgayDuKien As DateTime)

    '    'Me.strMaChiTietPhieuMuonSach = strMaChiTietPhieuMuonSach
    '    'Me.strMaSach = strMaSach
    '    'Me.strMaPhieuMuonSach = strMaPhieuMuonSach
    '    'Me.iMaSach = iMaSach
    '    Me.strTenSach = strTenSach
    '    Me.strTenTheLoaiSach = strTenTheLoaiSach
    '    Me.strTenTacGia = strTenTacGia
    '    Me.strTinhTrang = strTinhTrang
    '    ' Me.dateNgayDuKien = dateNgayDuKien
    'End Sub


    Property MaSach() As String
        Get
            Return strMaSach
        End Get
        Set(ByVal Value As String)
            strMaSach = Value
        End Set
    End Property

    Property MaPhieuTraSach() As String
        Get
            Return strMaPhieuTraSach
        End Get
        Set(ByVal Value As String)
            strMaPhieuTraSach = Value
        End Set
    End Property

    'Property TenSach() As String
    '    Get
    '        Return strTenSach
    '    End Get
    '    Set(ByVal Value As String)
    '        strTenSach = Value
    '    End Set
    'End Property


    'Property TenTheLoaiSach() As String
    '    Get
    '        Return strTenTheLoaiSach
    '    End Get
    '    Set(ByVal Value As String)
    '        strTenTheLoaiSach = Value
    '    End Set
    'End Property


    'Property TenTacGia() As String
    '    Get
    '        Return strTenTacGia
    '    End Get
    '    Set(ByVal Value As String)
    '        strTenTacGia = Value
    '    End Set
    'End Property


    'Property TinhTrang() As String
    '    Get
    '        Return strTinhTrang
    '    End Get
    '    Set(ByVal Value As String)
    '        strTinhTrang = Value
    '    End Set
    'End Property


    'Property NgayDuKienTra() As DateTime
    '    Get
    '        Return dateNgayDuKien
    '    End Get
    '    Set(ByVal Value As DateTime)
    '        dateNgayDuKien = Value
    '    End Set
    'End Property

End Class
