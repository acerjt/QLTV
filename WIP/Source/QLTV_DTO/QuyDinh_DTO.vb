Public Class QuyDinh_DTO

    Private iID As Integer
    Private iTuoiToiDa As Integer
    Private iTuoiToiThieu As Integer
    Private iThoiGianSuDung As Integer
    Private iSoTheLoaiSachToiDa As Integer
    Private iSoTacGiaToiDa As Integer
    Private iKhoangCachNamXuatBan As Integer
    Private iSoLuongSachMuonToiDa As Integer
    Private iSoNgayMuonToiDa As Integer
    Public Sub New()
        ID = 0
        iTuoiToiDa = 0
        iTuoiToiThieu = 0
        iThoiGianSuDung = 0
        iSoTheLoaiSachToiDa = 0
        iSoTacGiaToiDa = 0
        iKhoangCachNamXuatBan = 0
        iSoLuongSachMuonToiDa = 0
        iSoNgayMuonToiDa = 0
    End Sub
    Public Sub New(id As Integer, iTuoiToiThieu As Integer, iTuoiToiDa As Integer, iThoiGianSuDung As Integer, iSoTheLoaiSachToiDa As Integer, iSoTacGiaToiDa As Integer, iKhoangCachNamXuatBan As Integer, iSoLuongSachMuonToiDa As Integer, iSoNgayMuonToiDa As Integer)
        Me.iID = id
        Me.iTuoiToiThieu = iTuoiToiThieu
        Me.iTuoiToiDa = iTuoiToiDa
        Me.iThoiGianSuDung = iThoiGianSuDung
        Me.iSoTheLoaiSachToiDa = iSoTheLoaiSachToiDa
        Me.iSoTacGiaToiDa = iSoTacGiaToiDa
        Me.iKhoangCachNamXuatBan = iKhoangCachNamXuatBan
        Me.iSoLuongSachMuonToiDa = iSoLuongSachMuonToiDa
        Me.iSoNgayMuonToiDa = iSoNgayMuonToiDa
    End Sub
    Public Property TuoiToiThieu As Integer
        Get
            Return iTuoiToiThieu
        End Get
        Set(value As Integer)
            iTuoiToiThieu = value
        End Set
    End Property

    Public Property TuoiToiDa As Integer
        Get
            Return iTuoiToiDa
        End Get
        Set(value As Integer)
            iTuoiToiDa = value
        End Set
    End Property

    Public Property ThoiGianSuDung As Integer
        Get
            Return iThoiGianSuDung
        End Get
        Set(value As Integer)
            iThoiGianSuDung = value
        End Set
    End Property
    Public Property SoTheLoaiSachToiDa As Integer
        Get
            Return iSoTheLoaiSachToiDa
        End Get
        Set(value As Integer)
            iSoTheLoaiSachToiDa = value
        End Set
    End Property

    Public Property SoTacGiaToiDa As Integer
        Get
            Return iSoTacGiaToiDa
        End Get
        Set(value As Integer)
            iSoTacGiaToiDa = value
        End Set
    End Property

    Public Property KhoangCachNamXuatBan As Integer
        Get
            Return iKhoangCachNamXuatBan
        End Get
        Set(value As Integer)
            iKhoangCachNamXuatBan = value
        End Set
    End Property

    Public Property SoLuongSachMuonToiDa As Integer
        Get
            Return iSoLuongSachMuonToiDa
        End Get
        Set(value As Integer)
            iSoLuongSachMuonToiDa = value
        End Set
    End Property
    Public Property SoNgayMuonToiDa As Integer
        Get
            Return iSoNgayMuonToiDa
        End Get
        Set(value As Integer)
            iSoNgayMuonToiDa = value
        End Set
    End Property
    Public Property ID As Integer
        Get
            Return iID
        End Get
        Set(value As Integer)
            iID = value
        End Set
    End Property
End Class


