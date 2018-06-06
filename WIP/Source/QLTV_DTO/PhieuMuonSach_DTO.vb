
Public Class PhieuMuonSach_DTO
    Private iMaPhieuMuonSach As Integer
    Private iMaDocGia As Integer
    Private dateNgayMuon As DateTime
    Private dateNgayDuKienTra As DateTime

    'Private lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO)

    Public Sub New()

    End Sub

    Public Sub New(iMaPhieuMuonSach As Integer, iMaDocGia As Integer, dateNgayMuon As DateTime, dateNgayDuKienTra As DateTime) 'lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO))
        Me.iMaPhieuMuonSach = iMaPhieuMuonSach
        Me.iMaDocGia = iMaDocGia
        Me.dateNgayMuon = dateNgayMuon
    End Sub

    Property MaPhieuMuonSach() As Integer
        Get
            Return iMaPhieuMuonSach
        End Get
        Set(ByVal Value As Integer)
            iMaPhieuMuonSach = Value
        End Set
    End Property

    Property MaDocGia() As Integer
        Get
            Return iMaDocGia
        End Get
        Set(ByVal Value As Integer)
            iMaDocGia = Value
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


End Class
