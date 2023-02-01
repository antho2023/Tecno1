Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Secretario
    Dim con As New SqlConnection(My.Settings.conection)
    Dim mensaje, sentencia As String
    Sub EjecutarSQL(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.ShowDialog()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim da As New SqlDataAdapter("Select * From Ingreso where Usuario= '" + txt_buscar.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.dtg1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        sentencia = "Update Registro set Usuario='" + txt_usuario.Text + "', Contraseña='" + txt_contraseña.Text + "',Roll='" + txt_roll.Text + "'"
        mensaje = "Datos Actualizados"
        EjecutarSQL(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *From Ingreso", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        sentencia = "Insert into Ingreso values('" + txt_usuario.Text + "','" + txt_contraseña.Text + "','" + txt_roll.Text + "')"
        mensaje = "Datos Insertados Correctamente"
        EjecutarSQL(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *From Ingreso", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class