Public Class ChiTietBaoCaoThongKeSachTraTre_DTO
    Private iMaBaoCaoSachTraTre As Integer
    Private strTenSach As String
    Private dateNgayMuon As DateTime
    Private iSoNgayTraTre As Integer
    Private iThang As Integer
    Private iNam As Integer

    Public Sub New()

    End Sub




    Public Sub New(iMaBaoCaoSachTraTre As Integer,
                   strTenSach As String,
                   dateNgayMuon As DateTime,
                   iSoNgayTraTre As Integer)



        'Me.iMaBaoCaoMuonSachTheoThang = iMaBaoCaoMuonSachTheoThang
        Me.iMaBaoCaoSachTraTre = iMaBaoCaoSachTraTre
        Me.strTenSach = strTenSach
        Me.dateNgayMuon = dateNgayMuon
        Me.iSoNgayTraTre = iSoNgayTraTre
        ' Me.strTinhTrang = strTinhTrang
    End Sub

    Public Sub New(strTenSach As String,
                   dateNgayMuon As DateTime,
                   iSoNgayTraTre As Integer)



        'Me.iMaBaoCaoMuonSachTheoThang = iMaBaoCaoMuonSachTheoThang
        'Me.iMaBaoCaoSachTraTre = iMaBaoCaoSachTraTre
        Me.strTenSach = strTenSach
        Me.dateNgayMuon = dateNgayMuon
        Me.iSoNgayTraTre = iSoNgayTraTre
        ' Me.strTinhTrang = strTinhTrang
    End Sub

    Public Sub New(strTenSach As String,
                   dateNgayMuon As DateTime,
                   iSoNgayTraTre As Integer,
                   iThang As Integer,
                   iNam As Integer)



        'Me.iMaBaoCaoMuonSachTheoThang = iMaBaoCaoMuonSachTheoThang
        'Me.iMaBaoCaoSachTraTre = iMaBaoCaoSachTraTre
        Me.strTenSach = strTenSach
        Me.dateNgayMuon = dateNgayMuon
        Me.iSoNgayTraTre = iSoNgayTraTre
        Me.iThang = iThang
        Me.iNam = iNam
    End Sub
    'Public Sub New(iMaBaoCaoMuonSachTheoThang As Integer,
    '              strTheLoai As String,
    '                iSoLuotMuon As Integer,
    '                dTyLe As Double,
    '                iThang As Integer,
    '               iNam As Integer)
    '    Me.iMaBaoCaoMuonSachTheoThang = iMaBaoCaoMuonSachTheoThang
    '    Me.strTheLoai = strTheLoai
    '    Me.iSoLuotMuon = iSoLuotMuon
    '    Me.dTyLe = dTyLe
    '    Me.iThang = iThang
    '    Me.iNam = iNam
    '    ' Me.strTinhTrang = strTinhTrang
    'End Sub

    'Public Sub New(strTheLoai As String,
    '                iSoLuotMuon As Integer,
    '                dTyLe As Double,
    '                iThang As Integer,
    '               iNam As Integer)
    '    'Me.iMaBaoCaoMuonSachTheoThang = iMaBaoCaoMuonSachTheoThang
    '    Me.strTheLoai = strTheLoai
    '    Me.iSoLuotMuon = iSoLuotMuon
    '    Me.dTyLe = dTyLe
    '    Me.iThang = iThang
    '    Me.iNam = iNam
    '    ' Me.strTinhTrang = strTinhTrang
    'End Sub

    Property MaBaoCaoSachTraTre() As Integer
        Get
            Return iMaBaoCaoSachTraTre
        End Get
        Set(ByVal Value As Integer)
            iMaBaoCaoSachTraTre = Value
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

    Property NgayMuon() As DateTime
        Get
            Return dateNgayMuon
        End Get
        Set(ByVal Value As DateTime)
            dateNgayMuon = Value
        End Set
    End Property

    Property SoNgayTraTre() As Integer
        Get
            Return iSoNgayTraTre
        End Get
        Set(ByVal Value As Integer)
            iSoNgayTraTre = Value
        End Set
    End Property

    Property Thang() As Integer
        Get
            Return iThang
        End Get
        Set(ByVal Value As Integer)
            iThang = Value
        End Set
    End Property


    Property Nam() As Integer
        Get
            Return iNam
        End Get
        Set(ByVal Value As Integer)
            iNam = Value
        End Set
    End Property
End Class
