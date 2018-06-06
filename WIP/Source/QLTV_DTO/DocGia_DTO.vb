Public Class DocGia_DTO

    Private iMaDocGia As Integer
    Private strHoVaTen As String
    Private iLoaiDocGia As Integer
    Private dateNgaySinh As DateTime
    Private strDiaChi As String
    Private strEmail As String
    Private dateNgayLap As DateTime
    Private dateNgayHetHan As DateTime
    'Private strTinhTrangThe As String
    'Private iSoSachDangMuon As Integer
    Public Sub New()

    End Sub

    Public Sub New(iMaDocGia As Integer, strHoVaTen As String, iLoaiDocGia As Integer, dateNgaySinh As DateTime, strDiaChi As String, strEmail As String, dateNgayLap As DateTime, dateNgayHetHan As DateTime) ', strTinhTrangThe As String) ', iSoSachDangMuon As Integer)
        Me.iMaDocGia = iMaDocGia
        Me.strHoVaTen = strHoVaTen
        Me.iLoaiDocGia = iLoaiDocGia
        Me.dateNgaySinh = dateNgaySinh
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.dateNgayLap = dateNgayLap
        Me.dateNgayHetHan = dateNgayHetHan
        'Me.strTinhTrangThe = strTinhTrangThe
        'Me.iSoSachDangMuon = iSoSachDangMuon
    End Sub

    Property MaDocGia() As Integer
        Get
            Return iMaDocGia
        End Get
        Set(ByVal Value As Integer)
            iMaDocGia = Value
        End Set
    End Property

    Property HoVaTen() As String
        Get
            Return strHoVaTen
        End Get
        Set(ByVal Value As String)
            strHoVaTen = Value
        End Set
    End Property

    Property LoaiDocGia() As Integer
        Get
            Return iLoaiDocGia
        End Get
        Set(ByVal Value As Integer)
            iLoaiDocGia = Value
        End Set
    End Property

    Property NgaySinh() As DateTime
        Get
            Return dateNgaySinh
        End Get
        Set(ByVal Value As DateTime)
            dateNgaySinh = Value
        End Set
    End Property

    Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal Value As String)
            strDiaChi = Value
        End Set
    End Property

    Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal Value As String)
            strEmail = Value
        End Set
    End Property

    Property NgayLap() As DateTime
        Get
            Return dateNgayLap
        End Get
        Set(ByVal Value As DateTime)
            dateNgayLap = Value
        End Set
    End Property

    Property NgayHetHan() As DateTime
        Get
            Return dateNgayHetHan
        End Get
        Set(ByVal Value As DateTime)
            dateNgayHetHan = Value
        End Set
    End Property

    'Property TinhTrangThe() As String
    '    Get
    '        Return strTinhTrangThe
    '    End Get
    '    Set(ByVal Value As String)
    '        strTinhTrangThe = Value
    '    End Set
    'End Property

    'Property SoSachDangMuon() As Integer
    '    Get
    '        Return iSoSachDangMuon
    '    End Get
    '    Set(ByVal Value As Integer)
    '        iSoSachDangMuon = Value
    '    End Set
    'End Property


End Class
