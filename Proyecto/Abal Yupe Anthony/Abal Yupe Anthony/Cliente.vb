Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Cliente
    Dim con As New SqlConnection(My.Settings.conection)
    Dim mensaje, sentencia As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Dim da As New SqlDataAdapter("Select * From Ingreso where Usuario= '" + txt_usuario.Text + "'", con)
        Dim ds As New DataSet
            da.Fill(ds)
        Me.dtg1.DataSource = ds.Tables(0)

    End Sub
End Class