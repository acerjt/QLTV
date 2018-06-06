Public Class NhanTraSach_DTO


    Private iMaTraSach As Integer
    Private iMaDocGia As Integer
    Private dateNgayTra As DateTime

    'Private lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO)

    Public Sub New()

    End Sub

    Public Sub New(iMaTraSach As Integer, iMaDocGia As Integer, dateNgayTra As DateTime) 'lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO))
        Me.iMaTraSach = iMaTraSach
        Me.iMaDocGia = iMaDocGia
        Me.dateNgayTra = dateNgayTra
    End Sub

    Property MaTraSach() As Integer
        Get
            Return iMaTraSach
        End Get
        Set(ByVal Value As Integer)
            iMaTraSach = Value
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

    Property NgayTra() As DateTime
        Get
            Return dateNgayTra
        End Get
        Set(ByVal Value As DateTime)
            dateNgayTra = Value
        End Set
    End Property


End Class
