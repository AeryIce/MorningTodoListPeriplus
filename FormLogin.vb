'Morning Routine Report
'Create By. BinaryTardigrade
'Start in 8 Juli 2020


'Import namespace
Imports System.Data.SqlClient
Public Class FormLogin
    ' Define Button Login function
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBoxUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUserName.KeyPress
        'After User Clicked Enter Button Mouse Move to textbox password
        If e.KeyChar = Chr(13) Then
            TextBoxPassword.Focus()
        End If

    End Sub
    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        ' After User Clicked enter button, Mouse move to Login Button
        If e.KeyChar = Chr(13) Then
            ButtonLogin.Focus()
        End If

    End Sub

    'Login Proccess Start here
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click


        'checking user Input Req For Login
        If TextBoxUserName.Text = "" Or TextBoxPassword.Text = "" Then
            If MsgBox("Data Belum Lengkap, Lengkapi data? ", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                If TextBoxUserName.Text = "" Then
                    Me.Show()
                    TextBoxUserName.Focus()
                Else
                    Me.Show()
                    TextBoxPassword.Focus()
                End If
            Else
                Me.Close()

            End If
        Else
            'Call Module KoneksiInvUser (InvUser = name of Table that Store USER and PASSWORD)
            Call KoneksiInvUser()
            'Checking Username And Password 
            Cmd = New SqlCommand("SELECT * FROM inv_user WHERE [user] = '" & TextBoxUserName.Text & "' and [password] = '" & TextBoxPassword.Text & "' ", Conn)
            Dr = Cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                Me.Visible = False

            Else
                MsgBox("Password Salah")
            End If



        End If



    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiInvUser()
    End Sub
End Class
