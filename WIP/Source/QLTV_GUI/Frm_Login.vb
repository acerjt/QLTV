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

        Login.Username = Txt_UserName.Text
        Login.Password = Txt_PassWord.Text

        Dim result As Result
        result = LoginBUS.getNextID(Login)
        If result.FlagResult = True Then

            Hide()
            Dim frmMain = New Frm_Main()

            frmMain.ShowDialog()

            If (frmMain.DialogResult = DialogResult.Cancel) Then
                Application.Exit()
            ElseIf (frmMain.DialogResult = DialogResult.Ok) Then
                Show()
                'ElseIf (frmMain.DialogResult = DialogResult.No) Then
                '    Return
            End If
        Else

            Dim frm_Infor = New Frm_Information()
            Frm_Information.m.Text = "UserName Or PassWord Are Ivalid."
            Frm_Information.ShowDialog()

            'MessageBox.Show("UserName Or PassWord Are Ivalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Application.Exit()
    End Sub
End Class