Public Class ChiTietPhieuTraSach_DTO

    Private iMaSach As Integer
    Private iMaPhieuTraSach As Integer
    Private strTinhTrang As String
    Private iMaPhieuMuonSach As Integer

    Public Sub New()

    End Sub

    Public Sub New(iMaPhieuTraSach As Integer, iMaSach As Integer, strTinhTrang As String, iMaPhieuMuonSach As Integer)
        'Me.strMaChiTietPhieuMuonSach = strMaChiTietPhieuMuonSach
        Me.iMaSach = iMaSach
        Me.iMaPhieuTraSach = iMaPhieuTraSach
        Me.strTinhTrang = strTinhTrang
        Me.iMaPhieuMuonSach = iMaPhieuMuonSach
    End Sub


    Property MaSach() As Integer
        Get
            Return iMaSach
        End Get
        Set(ByVal Value As Integer)
            iMaSach = Value
        End Set
    End Property

    Property MaPhieuTraSach() As Integer
        Get
            Return iMaPhieuTraSach
        End Get
        Set(ByVal Value As Integer)
            iMaPhieuTraSach = Value
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
