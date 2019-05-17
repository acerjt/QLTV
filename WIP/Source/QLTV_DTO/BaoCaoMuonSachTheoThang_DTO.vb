﻿Public Class BaoCaoMuonSachTheoThang_DTO
    Private iMaBaoCaoMuonSachTheoThang As Integer
    Private iNam As Integer
    Private iThang As Integer
    Private iTongSoLuotMuon As Integer

    'Private lsCTPMS As List(Of ChiTietPhieuMuonSach_DTO)

    Public Sub New()

    End Sub

    Public Sub New(iMaBaoCaoMuonSachTheoThang As Integer,
                   iNam As String,
                   iThang As String,
                   TongSoLuotMuon As Integer)


        Me.iMaBaoCaoMuonSachTheoThang = iMaBaoCaoMuonSachTheoThang
        Me.iNam = iNam
        Me.iThang = iThang
        Me.iTongSoLuotMuon = iTongSoLuotMuon

    End Sub

    Property MaBaoCaoMuonSachTheoThang() As Integer
        Get
            Return iMaBaoCaoMuonSachTheoThang
        End Get
        Set(ByVal Value As Integer)
            iMaBaoCaoMuonSachTheoThang = Value
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

    Public Property TongSoLuotMuon() As Integer
        Get
            Return iTongSoLuotMuon
        End Get
        Set(value As Integer)
            iTongSoLuotMuon = value
        End Set
    End Property
End Class
