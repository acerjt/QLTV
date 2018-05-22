Public Class ChiTietPhieuMuonSach_DTO
    Private strMaSach As String
    Private strMaPhieuMuonSach As String

    Public Sub New()

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
End Class
