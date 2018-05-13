Public Class QuyDinhDTO
    Private iID As Integer
    Private iTuoiToiDa As Integer
    Private iTuoiToiThieu As Integer
    Private iThoiGianSuDung As Integer

    Public Sub New()
        ID = 0
        iTuoiToiDa = 0
        iTuoiToiThieu = 0
        iThoiGianSuDung = 0
    End Sub
    Public Sub New(id As Integer, iTuoiToiThieu As Integer, iTuoiToiDa As Integer, iThoiGianSuDung As Integer)
        Me.iID = id
        Me.iTuoiToiThieu = iTuoiToiThieu
        Me.iTuoiToiDa = iTuoiToiDa
        Me.iThoiGianSuDung = iThoiGianSuDung
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
    Public Property ID As Integer
        Get
            Return iID
        End Get
        Set(value As Integer)
            iID = value
        End Set
    End Property
End Class

