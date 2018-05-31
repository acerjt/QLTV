Public Class ChiTietBaoCaoMuonSachTheoThang_DTO
    Private iMaBaoCaoMuonSachTheoThang As Integer
    Private strTheLoai As String
    Private iSoLuotMuon As Integer
    Private dTyLe As Double
    Private iThang As Integer
    Private iNam As Integer

    Public Sub New()

    End Sub




    Public Sub New(strTheLoai As String,
                    iSoLuotMuon As Integer,
                    dTyLe As Double)


        'Me.iMaBaoCaoMuonSachTheoThang = iMaBaoCaoMuonSachTheoThang
        Me.strTheLoai = strTheLoai
        Me.iSoLuotMuon = iSoLuotMuon
        Me.dTyLe = dTyLe

        ' Me.strTinhTrang = strTinhTrang
    End Sub
    Public Sub New(iMaBaoCaoMuonSachTheoThang As Integer,
                  strTheLoai As String,
                    iSoLuotMuon As Integer,
                    dTyLe As Double,
                    iThang As Integer,
                   iNam As Integer)
        Me.iMaBaoCaoMuonSachTheoThang = iMaBaoCaoMuonSachTheoThang
        Me.strTheLoai = strTheLoai
        Me.iSoLuotMuon = iSoLuotMuon
        Me.dTyLe = dTyLe
        Me.iThang = iThang
        Me.iNam = iNam
        ' Me.strTinhTrang = strTinhTrang
    End Sub

    Public Sub New(strTheLoai As String,
                    iSoLuotMuon As Integer,
                    dTyLe As Double,
                    iThang As Integer,
                   iNam As Integer)
        'Me.iMaBaoCaoMuonSachTheoThang = iMaBaoCaoMuonSachTheoThang
        Me.strTheLoai = strTheLoai
        Me.iSoLuotMuon = iSoLuotMuon
        Me.dTyLe = dTyLe
        Me.iThang = iThang
        Me.iNam = iNam
        ' Me.strTinhTrang = strTinhTrang
    End Sub

    Property MaBaoCaoMuonSachTheoThang() As Integer
        Get
            Return iMaBaoCaoMuonSachTheoThang
        End Get
        Set(ByVal Value As Integer)
            iMaBaoCaoMuonSachTheoThang = Value
        End Set
    End Property

    Property TheLoai() As String
        Get
            Return strTheLoai
        End Get
        Set(ByVal Value As String)
            strTheLoai = Value
        End Set
    End Property

    Property SoLuotMuon() As Integer
        Get
            Return iSoLuotMuon
        End Get
        Set(ByVal Value As Integer)
            iSoLuotMuon = Value
        End Set
    End Property

    Property TyLe() As Double
        Get
            Return dTyLe
        End Get
        Set(ByVal Value As Double)
            dTyLe = Value
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
