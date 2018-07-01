Imports System
Imports System.Windows.Forms
Public Class Frm_Close

    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_yes.Click
        DialogResult = DialogResult.OK

        Me.Close()

    End Sub

    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        DialogResult = DialogResult.No
        Me.Close()

    End Sub

    Private Sub Frm_Close_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class