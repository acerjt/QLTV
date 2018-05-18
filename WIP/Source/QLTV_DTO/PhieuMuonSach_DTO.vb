Imports QLTV_DTO
Public Class PhieuMuonSach_DTO
    Private strMaPhieuMuonSach As String
    Private strMaDocGia As String
    Private dateNgayMuon As DateTime
    Private dateNgayDuKienTra As DateTime

    'Private lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO)

    Public Sub New()

    End Sub

    Public Sub New(strMaPhieuMuonSach As String, strMaDocGia As String, dateNgayMuon As DateTime, dateNgayDuKienTra As DateTime) 'lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO))
        Me.strMaPhieuMuonSach = strMaPhieuMuonSach
        Me.strMaDocGia = strMaDocGia
        Me.dateNgayMuon = dateNgayMuon
    End Sub

    Property MaPhieuMuonSach() As String
        Get
            Return strMaPhieuMuonSach
        End Get
        Set(ByVal Value As String)
            strMaPhieuMuonSach = Value
        End Set
    End Property

    Property MaDocGia() As String
        Get
            Return strMaDocGia
        End Get
        Set(ByVal Value As String)
            strMaDocGia = Value
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

    Public Property NgayDuKienTra() As DateTime
        Get
            Return dateNgayDuKienTra
        End Get
        Set(value As DateTime)
            dateNgayDuKienTra = value
        End Set
    End Property

    'Public Property ListCTPMS As List(Of ChiTietPhieuMuonSach_DTO)
    '    Get
    '        Return lsCTPMS
    '    End Get
    '    Set(value As List(Of ChiTietPhieuMuonSach_DTO))
    '        lsCTPMS = value
    '    End Set
    'End Property
End Class
