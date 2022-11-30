Public Class Form_cuestionario
    Dim cyd1 As New CYD
    Dim historial1 As New Historial
    Dim respuestas1 As New Respuestas
    Private Sub Btn_Omitir_Click(sender As Object, e As EventArgs) Handles Btn_Omitir.Click
        Me.Close()
        Form_top.Show()
    End Sub

    Private Sub Btn_Responder_Click(sender As Object, e As EventArgs) Handles Btn_Responder.Click
        historial1.mail = Form_Ingreso.Text_mail.Text
        respuestas1.Mail = Form_Ingreso.Text_mail.Text
        If Val(Text_PromP.Text) >= 1 And Val(Text_PromP.Text) <= 10 And Val(Text_PromA.Text) >= 1 And Val(Text_PromA.Text) <= 10 Then

            historial1.fecha = Date.Now
            historial1.tipoEnc = "Pasado"
            If historial1.LlenarHistorial = True And historial1.GuardarHistorial = True Then
                historial1.tipoEnc = "Actual"
                If historial1.LlenarHistorial = True And historial1.GuardarHistorial = True Then
                    If cyd1.ConvertirVariables = True Then
                        Me.Close()
                        Form_top.Show()
                    End If
                Else
                    MsgBox("Falta completar respuestas actuales")
                End If
            Else
                MsgBox("Falta completar respuestas pasadas")
            End If
        Else
            MsgBox("Valores de promedio fuera de límites")
        End If
    End Sub

    Private Sub Btn_EnviarComentario_Click(sender As Object, e As EventArgs) Handles Btn_EnviarComentario.Click
        respuestas1.Mail = Form_Ingreso.Text_mail.Text
        respuestas1.comentario = Text_comentario.Text
        If respuestas1.AgregarComentario = True Then
            MsgBox("Comentario enviado")
            Btn_EnviarComentario.Enabled = False
            Text_comentario.ReadOnly = True
        Else
            MsgBox("Error al enviar")
        End If
    End Sub
End Class