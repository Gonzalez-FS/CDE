Public Class Form_admin
    Dim admin1 As New Admin
    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles Btn_salir.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "Select * from historial"
        Dim cmd As New SqlCommand(sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "historial")
            Me.DG_Historial.DataSource = ds.Tables("historial")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim sql2 As String = "Select * from cuentas"
        Dim cmd2 As New SqlCommand(sql2, con)
        Try
            Dim da2 As New SqlDataAdapter(cmd2)
            Dim ds2 As New DataSet
            da2.Fill(ds2, "cuentas")
            Me.DG_Usuarios.DataSource = ds2.Tables("cuentas")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_eliminar_Click(sender As Object, e As EventArgs) Handles Btn_eliminar.Click
        admin1.id_cuenta = Text_eliminar.Text
        If admin1.BorrarUsuario = True Then
            MsgBox("Usuario eliminado")

            Dim con As New SqlConnection(My.Settings.Conexion)
            Dim sql As String = "Select * from historial"
            Dim cmd As New SqlCommand(sql, con)
            Try
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "historial")
                Me.DG_Historial.DataSource = ds.Tables("historial")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim sql2 As String = "Select * from cuentas where tipo = 'usuario'"
            Dim cmd2 As New SqlCommand(sql2, con)
            Try
                Dim da2 As New SqlDataAdapter(cmd2)
                Dim ds2 As New DataSet
                da2.Fill(ds2, "cuentas")
                Me.DG_Usuarios.DataSource = ds2.Tables("cuentas")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No se puede eliminar esta cuenta")
        End If
    End Sub

    Private Sub Btn_Historial_Click(sender As Object, e As EventArgs) Handles Btn_Historial.Click
        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "Select * from historial"
        Dim cmd As New SqlCommand(sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "historial")
            Me.DG_Historial.DataSource = ds.Tables("historial")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_comentarios_Click(sender As Object, e As EventArgs) Handles Btn_comentarios.Click
        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "Select * from comentarios"
        Dim cmd As New SqlCommand(sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "comentarios")
            Me.DG_Historial.DataSource = ds.Tables("comentarios")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class