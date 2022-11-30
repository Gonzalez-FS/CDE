Public Class Admin
    Inherits Usuario
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand
    Public id_cuenta As Integer

    Public Overrides Function Ingresar() As Object
        tipo = "administrador"
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

    Public Overrides Function Registrar() As Object
        tipo = "administrador"
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

    Public Function BorrarUsuario()
        Try
            con.Open()
            cmd = New SqlCommand("SP_BorrarCuenta", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_cuenta", id_cuenta)
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
