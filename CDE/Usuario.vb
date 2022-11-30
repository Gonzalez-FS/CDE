Public Class Usuario
    Public nombre As String
    Public mail As String
    Public contraseña As String
    Public tipo As String
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand

    Public Overridable Function Ingresar()
        tipo = "usuario"
        Try
            con.Open()
            cmd = New SqlCommand("sp_BuscarCuenta", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@contraseña", contraseña)
            cmd.Parameters.AddWithValue("@mail", mail)
            cmd.Parameters.AddWithValue("@tipo", tipo)
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
    Public Overridable Function Registrar()
        tipo = "usuario"
        Try
            con.Open()
            cmd = New SqlCommand("sp_GuardarCuenta", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@contraseña", contraseña)
            cmd.Parameters.AddWithValue("@mail", mail)
            cmd.Parameters.AddWithValue("@tipo", tipo)
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
