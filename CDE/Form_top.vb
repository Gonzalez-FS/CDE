Imports System.Data.SqlClient
Public Class Form_top
    Dim respuestas1 As New Respuestas
    Private Sub Form_top_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If respuestas1.ContarRespuestas = True Then
            Dim con As New SqlConnection(My.Settings.Conexion)
            Dim sql As String = "Select * from respuestas order by frecuencia desc"
            Dim cmd As New SqlCommand(sql, con)
            Try
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "respuestas")
                Me.DGtop.DataSource = ds.Tables("respuestas")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Label_Titulo.Text = "Aún no hay respuestas!"
        End If

    End Sub

    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles Btn_salir.Click
        Form1.Show()
        Me.Close()
        Form_Ingreso.Close()
    End Sub
End Class