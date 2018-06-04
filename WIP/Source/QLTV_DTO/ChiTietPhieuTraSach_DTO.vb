Public Class ChiTietPhieuTraSach_DTO

    Private strMaSach As String
    Private strMaPhieuTraSach As String
    Private strTinhTrang As String
    Private iMaPhieuMuonSach As Integer

    Public Sub New()

    End Sub




    Public Sub New(strMaPhieuTraSach As String, strMaSach As String, strTinhTrang As String, iMaPhieuMuonSach As Integer)
        'Me.strMaChiTietPhieuMuonSach = strMaChiTietPhieuMuonSach
        Me.strMaSach = strMaSach
        Me.strMaPhieuTraSach = strMaPhieuTraSach
        Me.strTinhTrang = strTinhTrang
        Me.iMaPhieuMuonSach = iMaPhieuMuonSach
    End Sub


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


    Property TinhTrang() As String
        Get
            Return strTinhTrang
        End Get
        Set(ByVal Value As String)
            strTinhTrang = Value
        End Set
    End Property

    Property MaPhieuMuonSach() As Integer
        Get
            Return iMaPhieuMuonSach
        End Get
        Set(ByVal Value As Integer)
            iMaPhieuMuonSach = Value
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
