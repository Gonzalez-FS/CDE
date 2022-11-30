Public Class Respuestas
    Public MasNivelEducativo As Boolean
    Public MasCargaTrabajo As Boolean
    Public ProblemasFamiliares As Boolean
    Public ProblemasCompañeros As Boolean
    Public DeterioroEconomico As Boolean
    Public DeterioroSaludMental As Boolean
    Public PeorComuDocentes As Boolean
    Public PeorInstitucion As Boolean
    Public InicioActivsExtra As Boolean
    Public EnfermedadGrave As Boolean
    Public Mail As String
    Public comentario As String
    Public ID_causa As Integer
    Public ID_causa2 As Integer
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand
    Public Function SumarRespuestas()
        Try
            con.Open()
            cmd = New SqlCommand("SP_SumarRespuestas", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_causa", ID_causa)
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            con.Close()
        End Try
    End Function
    Public Function AgregarSumas()
        Try
            con.Open()
            cmd = New SqlCommand("SP_AgregarSumas", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@mail", Mail)
            cmd.Parameters.AddWithValue("@id_causa", ID_causa2)
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            con.Close()
        End Try
    End Function
    Public Function ContarRespuestas()
        Try
            con.Open()
            cmd = New SqlCommand("SP_ContarRespuestas", con)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            con.Close()
        End Try
    End Function
    Public Function AgregarComentario()
        Try
            con.Open()
            cmd = New SqlCommand("SP_AgregarComentario", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@mail", Mail)
            cmd.Parameters.AddWithValue("@comentario", comentario)
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            con.Close()
        End Try
    End Function
End Class
