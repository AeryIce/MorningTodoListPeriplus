﻿Public Class FormLogin
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBoxUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUserName.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBoxPassword.Focus()
        End If

    End Sub
    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            ButtonLogin.Focus()
        End If

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Call KoneksiUserAdmin()
        If 
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiUserAdmin()
    End Sub
End Class