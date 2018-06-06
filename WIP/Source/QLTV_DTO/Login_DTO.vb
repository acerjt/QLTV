Public Class Login_DTO
    Private strUsername As String
    Private strPassword As String

    Public Sub New()

    End Sub
    Public Sub New(strUsername As String, strPassword As String)
        Me.strUsername = strUsername
        Me.strPassword = strPassword
    End Sub

    Property Username() As String
        Get
            Return strUsername
        End Get
        Set(ByVal Value As String)
            strUsername = Value
        End Set
    End Property

    Property Password() As String
        Get
            Return strPassword
        End Get
        Set(ByVal value As String)
            strPassword = value
        End Set
    End Property
End Class
