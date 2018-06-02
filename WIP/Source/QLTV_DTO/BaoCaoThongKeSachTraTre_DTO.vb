Public Class BaoCaoThongKeSachTraTre_DTO
    Private iMaBaoCaoSachTraTre As Integer
    Private iNam As Integer
    Private iThang As Integer
    Private dateNgayLap As DateTime
    'Private iTongSoLuotMuon As Integer

    'Private lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO)

    Public Sub New()

    End Sub

    Public Sub New(iMaBaoCaoSachTreTre As Integer,
                   iNam As String,
                   iThang As String,
                   dateNgayLap As DateTime)
        'TongSoLuotMuon As Integer)


        Me.iMaBaoCaoSachTraTre = iMaBaoCaoSachTraTre
        Me.iNam = iNam
        Me.iThang = iThang
        Me.dateNgayLap = dateNgayLap

    End Sub

    Property MaBaoCaoSachTreTre() As Integer
        Get
            Return iMaBaoCaoSachTraTre
        End Get
        Set(ByVal Value As Integer)
            iMaBaoCaoSachTraTre = Value
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

    Property Thang() As Integer
        Get
            Return iThang
        End Get
        Set(ByVal Value As Integer)
            iThang = Value
        End Set
    End Property

    Public Property NgayLap() As DateTime
        Get
            Return dateNgayLap
        End Get
        Set(value As DateTime)
            dateNgayLap = value
        End Set
    End Property
End Class
