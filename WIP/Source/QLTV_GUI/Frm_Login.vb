Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_Login
    Private LoginBUS As Login_BUS
    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginBUS = New Login_BUS()

    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Dim Login As Login_DTO
        Login = New Login_DTO()

        Login.UserName = Txt_UserName.Text
        Login.PassWord = Txt_PassWord.Text

        Dim result As Result
        result = LoginBUS.getNextID(Login)
        If result.FlagResult = True Then
            Dim frmMain As Frm_Main = New Frm_Main()
            Me.Hide()
            frmMain.ShowDialog()
        Else
            MessageBox.Show("UserName Or PassWord Are Ivalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

    End Sub
End Class