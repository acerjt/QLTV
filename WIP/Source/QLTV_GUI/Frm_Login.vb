﻿Imports QLTV_BUS
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
            'Dim frmClose As Frm_Close = New Frm_Close()
            'frmClose.Hide()
            Dim frmMain As Frm_Main = New Frm_Main()
            Me.Hide()
            'Dim frmMain = New Frm_Main()

            frmMain.ShowDialog()

            'Dim frmLogin = New Frm_Login
            'frmLogin.Show()
            Me.Close()
        Else
            MessageBox.Show("UserName Or PassWord Are Ivalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub
End Class