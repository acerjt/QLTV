Public Class Sach_DTO
    Private strMaSach As String
    Private strTenSach As String
    Private iTheLoai As String
    Private iTacGia As String
    Private iNamXuatBan As String
    Private strNhaXuatBan As String
    Private dateNgayNhap As DateTime
    Private strTriGia As String
    Private strTinhTrang As String
    Private dateNgayDuKien As DateTime


    Public Sub New()
    End Sub
    Public Sub New(strMaSach As String,
                   strTenSach As String,
                   iTheLoai As String,
                   iTacGia As String,
                   iNamXuatBan As Integer,
                   strNhaXuatBan As String,
                   dateNgayNhap As DateTime,
                   strTriGia As String,
                   strTinhTrang As String,
                   dateNgayDuKien As DateTime)


        Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.iTheLoai = iTheLoai
        ' Me.strMaTacGia = strMaTacGia
        Me.iTacGia = iTacGia
        Me.iNamXuatBan = iNamXuatBan
        Me.strNhaXuatBan = strNhaXuatBan
        Me.dateNgayNhap = dateNgayNhap
        Me.strTriGia = strTriGia
        Me.strTinhTrang = strTinhTrang
        Me.dateNgayDuKien = dateNgayDuKien
    End Sub

    Public Sub New(strMaSach As String,
                   strTenSach As String,
                   iTheLoai As String,
                   iTacGia As String,
                   strTinhTrang As String,
                   dateNgayDuKien As DateTime)


        Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.iTheLoai = iTheLoai
        ' Me.strMaTacGia = strMaTacGia
        Me.iTacGia = iTacGia
        ' Me.iNamXuatBan = iNamXuatBan
        'Me.strNhaXuatBan = strNhaXuatBan
        'Me.dateNgayNhap = dateNgayNhap
        '  Me.strTriGia = strTriGia
        Me.strTinhTrang = strTinhTrang
        Me.dateNgayDuKien = dateNgayDuKien
    End Sub

    Public Sub New(strMaSach As String,
                   strTenSach As String,
                   iTheLoai As String,
                   iTacGia As String,
                   iNamXuatBan As Integer,
                   strNhaXuatBan As String,
                   dateNgayNhap As DateTime,
                   strTriGia As String,
                   strTinhTrang As String)
        'dateNgayDyKien As DateTime)


        Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.iTheLoai = iTheLoai
        ' Me.strMaTacGia = strMaTacGia
        Me.iTacGia = iTacGia
        Me.iNamXuatBan = iNamXuatBan
        Me.strNhaXuatBan = strNhaXuatBan
        Me.dateNgayNhap = dateNgayNhap
        Me.strTriGia = strTriGia
        Me.strTinhTrang = strTinhTrang
        'Me.dateNgayDuKien = dateNgayDuKien
    End Sub

    Public Sub New(strTenSach As String,
                   iTheLoai As String,
                   iTacGia As String,
                   strTinhTrang As String,
                   dateNgayDuKien As DateTime)


        'Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.iTheLoai = iTheLoai
        ' Me.strMaTacGia = strMaTacGia
        Me.iTacGia = iTacGia
        Me.iNamXuatBan = iNamXuatBan
        ' Me.strNhaXuatBan = strNhaXuatBan
        'Me.dateNgayNhap = dateNgayNhap
        ' Me.strTriGia = strTriGia
        Me.strTinhTrang = strTinhTrang
        Me.dateNgayDuKien = dateNgayDuKien
    End Sub

    Public Sub New(strTenSach As String,
                   iTheLoai As String,
                   iTacGia As String,
                   strTinhTrang As String)


        'Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.iTheLoai = iTheLoai
        ' Me.strMaTacGia = strMaTacGia
        Me.iTacGia = iTacGia
        Me.iNamXuatBan = iNamXuatBan
        ' Me.strNhaXuatBan = strNhaXuatBan
        'Me.dateNgayNhap = dateNgayNhap
        ' Me.strTriGia = strTriGia
        Me.strTinhTrang = strTinhTrang
        'Me.dateNgayDuKien = dateNgayDuKien
    End Sub
    Property MaSach() As String
        Get
            Return strMaSach
        End Get
        Set(ByVal value As String)
            strMaSach = value
        End Set
    End Property
    Property TenSach() As String
        Get
            Return strTenSach
        End Get
        Set(ByVal value As String)
            strTenSach = value
        End Set
    End Property
    Property TheLoai() As String
        Get
            Return iTheLoai
        End Get
        Set(ByVal value As String)
            iTheLoai = value
        End Set
    End Property
    'Property TenTacGia() As String
    '    Get
    '        Return strTenTacGia
    '    End Get
    '    Set(ByVal value As String)
    '        strTenTacGia = value
    '    End Set
    'End Property
    Property TenTacGia() As String
        Get
            Return iTacGia
        End Get
        Set(ByVal value As String)
            iTacGia = value
        End Set
    End Property
    Property NamXuatBan() As Integer
        Get
            Return iNamXuatBan
        End Get
        Set(ByVal value As Integer)
            iNamXuatBan = value
        End Set
    End Property
    Property NhaXuatBan() As String
        Get
            Return strNhaXuatBan
        End Get
        Set(ByVal value As String)
            strNhaXuatBan = value
        End Set
    End Property
    Property NgayNhap() As Date
        Get
            Return dateNgayNhap
        End Get
        Set(ByVal value As Date)
            dateNgayNhap = value
        End Set
    End Property
    Property TriGia() As String
        Get
            Return strTriGia
        End Get
        Set(ByVal value As String)
            strTriGia = value
        End Set
    End Property
    Property TinhTrang() As String
        Get
            Return strTinhTrang
        End Get
        Set(ByVal value As String)
            strTinhTrang = value
        End Set
    End Property
    Property NgayDuKien() As DateTime
        Get
            Return dateNgayDuKien
        End Get
        Set(ByVal value As DateTime)
            dateNgayDuKien = value
        End Set
    End Property
End Class
