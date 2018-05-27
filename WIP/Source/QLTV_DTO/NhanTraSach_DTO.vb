Public Class NhanTraSach_DTO


    Private strMaTraSach As String
    Private strMaDocGia As String
    Private dateNgayTra As DateTime

    'Private lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO)

    Public Sub New()

    End Sub

    Public Sub New(strMaTraSach As String, strMaDocGia As String, dateNgayTra As DateTime) 'lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO))
        Me.strMaTraSach = strMaTraSach
        Me.strMaDocGia = strMaDocGia
        Me.dateNgayTra = dateNgayTra
    End Sub

    Property MaTraSach() As String
        Get
            Return strMaTraSach
        End Get
        Set(ByVal Value As String)
            strMaTraSach = Value
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

    Property NgayTra() As DateTime
        Get
            Return dateNgayTra
        End Get
        Set(ByVal Value As DateTime)
            dateNgayTra = Value
        End Set
    End Property

    'Public Property NgayDuKienTra() As DateTime
    '    Get
    '        Return dateNgayDuKienTra
    '    End Get
    '    Set(value As DateTime)
    '        dateNgayDuKienTra = value
    '    End Set
    'End Property

    'Public Property ListCTPMS As List(Of ChiTietPhieuMuonSach_DTO)
    '    Get
    '        Return lsCTPMS
    '    End Get
    '    Set(value As List(Of ChiTietPhieuMuonSach_DTO))
    '        lsCTPMS = value
    '    End Set
    'End Property
End Class
