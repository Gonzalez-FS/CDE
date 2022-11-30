Public Class Form_Ingreso
    Dim usuario1 As New Usuario
    Dim admin1 As New Admin
    Private Sub Btn_logOP_Click(sender As Object, e As EventArgs) Handles Btn_logOP.Click
        usuario1.nombre = Text_nombre.Text
        usuario1.contraseña = Text_contra.Text
        usuario1.mail = Text_mail.Text

        If usuario1.Ingresar = True Then
            Form1.Hide()
            Me.Hide()
            Form_cuestionario.Show()
        Else
            MsgBox("Usuario incorrecto")
        End If
    End Sub

    Private Sub Btn_logadminOP_Click(sender As Object, e As EventArgs) Handles Btn_logadminOP.Click
        admin1.nombre = Text_nombre.Text
        admin1.contraseña = Text_contra.Text
        admin1.mail = Text_mail.Text
        If admin1.Ingresar = True Then
            Form1.Hide()
            Me.Close()
            Form_admin.Show()
        Else
            MsgBox("Admin incorrecto")
        End If
    End Sub

    Private Sub Btn_regOP_Click(sender As Object, e As EventArgs) Handles Btn_regOP.Click
        usuario1.nombre = Text_nombre.Text
        usuario1.contraseña = Text_contra.Text
        usuario1.mail = Text_mail.Text
        If usuario1.Registrar Then
            MsgBox("Registrado correctamente")
        Else
            MsgBox("Ya existe una cuenta asociada a este mail")
        End If
    End Sub

    Private Sub Btn_regadminOP_Click(sender As Object, e As EventArgs) Handles Btn_regadminOP.Click
        If Text_org.Text = "ET24" Or Text_org.Text = "CDE" Then
            admin1.nombre = Text_nombre.Text
            admin1.contraseña = Text_contra.Text
            admin1.mail = Text_mail.Text
            If admin1.Registrar = True Then
                MsgBox("Registrado correctamente")
            Else
                MsgBox("Ya existe una cuenta asociada a este mail")
            End If
        Else
            MsgBox("Organización no autorizada")
        End If
    End Sub
End Class