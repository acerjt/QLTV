Public Class Login_DTO
    Private strUserName As String
    Private strPassWord As String
    Public Sub New()

    End Sub

    Public Sub New(strUserName As String,
        strPassWord As String)
        Me.strPassWord = strPassWord
        Me.strUserName = strUserName
    End Sub

    Property UserName() As String
        Get
            Return strUserName
        End Get
        Set(ByVal Value As String)
            strUserName = Value
        End Set
    End Property

    Property PassWord() As String
        Get
            Return strPassWord
        End Get
        Set(ByVal Value As String)
            strPassWord = Value
        End Set
    End Property
End Class
