Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Form1
    Dim con As New SqlConnection(My.Settings.conection)
    Dim da As New SqlCommand
    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        If txt_usuario.Text = "Anthony" And txt_contraseña.Text = "1234B" Then
            Me.Hide()
            Administrador.ShowDialog()
        Else
            If txt_usuario.Text = "Melvin" And txt_contraseña.Text = "1234A" Then
                Me.Hide()
                Secretario.ShowDialog()
            Else
                If txt_usuario.Text = "Henrry" And txt_contraseña.Text = "1234C" Then
                    Me.Hide()
                    Cliente.ShowDialog()
                End If
            End If
        End If

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()
    End Sub
End Class
