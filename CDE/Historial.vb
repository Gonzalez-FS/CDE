Public Class Historial
    Public mail As String
    Public fecha As String
    Public tipoEnc As String
    Public promedio As String
    Public nivel_educativo As String
    Public trabajo As String
    Public relfam As String
    Public relcomp As String
    Public condeco As String
    Public enfmen As String = "_"
    Public comudoc As String
    Public condinsti As String
    Public activext As String
    Public enfgrave As String
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand

    Public Function LlenarHistorial()

        If tipoEnc = "Pasado" Then
            promedio = Form_cuestionario.Text_PromP.Text

            If Form_cuestionario.Rb_PrimarioP.Checked = True Then
                nivel_educativo = "Primario"
            ElseIf Form_cuestionario.Rb_secundarioP.Checked = True Then
                nivel_educativo = "Secundario"
            ElseIf Form_cuestionario.Rb_terciarioP.Checked = True Then
                nivel_educativo = "Secundario"
            Else
                Return False
            End If

            If Form_cuestionario.Rb_notrabajoP.Checked = True Then
                trabajo = "Desempleado"
            ElseIf Form_cuestionario.Rb_emprendimientoP.Checked = True Then
                trabajo = "Emprendimiento"
            ElseIf Form_cuestionario.Rb_formalP.Checked = True Then
                trabajo = "Formal"
            Else
                Return False
            End If

            If Form_cuestionario.Rb_FconflicP.Checked = True Then
                relfam = "Conflictiva"
            ElseIf Form_cuestionario.Rb_FfriaP.Checked = True Then
                relfam = "Fría"
            ElseIf Form_cuestionario.Rb_FcordialP.Checked = True Then
                relfam = "Cordial"
            ElseIf Form_cuestionario.Rb_FbuenaP.Checked = True Then
                relfam = "Buena"
            Else
                Return False
            End If

            If Form_cuestionario.Rb_CconflicP.Checked = True Then
                relcomp = "Conflictiva"
            ElseIf Form_cuestionario.Rb_CfriaP.Checked = True Then
                relcomp = "Fría"
            ElseIf Form_cuestionario.Rb_CcordialP.Checked = True Then
                relcomp = "Cordial"
            ElseIf Form_cuestionario.Rb_CbuenaP.Checked = True Then
                relcomp = "Buena"
            Else
                Return False
            End If

            If Form_cuestionario.Rb_PobrezaP.Checked = True Then
                condeco = "Pobreza"
            ElseIf Form_cuestionario.Rb_BasicoP.Checked = True Then
                condeco = "Básico"
            ElseIf Form_cuestionario.Rb_BasicoSupP.Checked = True Then
                condeco = "Básico + Suplementos"
            ElseIf Form_cuestionario.Rb_estableP.Checked = True Then
                condeco = "Estable"
            Else
                Return False
            End If

            If Form_cuestionario.CB_depP.Checked = True Then
                enfmen = enfmen + " + Depresión"
            End If
            If Form_cuestionario.CB_ansP.Checked = True Then
                enfmen = enfmen + " + Ansiedad"
            End If
            If Form_cuestionario.CB_adhdP.Checked = True Then
                enfmen = enfmen + " + ADHD"
            End If
            If Form_cuestionario.CB_otroP.Checked = True Then
                enfmen = enfmen + " + Otro"
            End If

            If Form_cuestionario.Rb_docPocoP.Checked = True Then
                comudoc = "Poca"
            ElseIf Form_cuestionario.Rb_docVarP.Checked = True Then
                comudoc = "Varía según profesor"
            ElseIf Form_cuestionario.Rb_docPreP.Checked = True Then
                comudoc = "Presencial"
            ElseIf Form_cuestionario.Rb_docVirP.Checked = True Then
                comudoc = "Virtual"
            ElseIf Form_cuestionario.Rb_docAmP.Checked = True Then
                comudoc = "Ambas"
            Else
                Return False
            End If

            If Form_cuestionario.Rb_instdescP.Checked = True Then
                condinsti = "Descuidada"
            ElseIf Form_cuestionario.Rb_insttrabP.Checked = True Then
                condinsti = "Trabajada"
            ElseIf Form_cuestionario.Rb_instidonP.Checked = True Then
                condinsti = "Idonea"
            Else
                Return False
            End If

            If Form_cuestionario.Rb_extnoP.Checked = True Then
                activext = "No"
            ElseIf Form_cuestionario.Rb_extsiP.Checked = True Then
                activext = "Sí"
            Else
                Return False
            End If

            If Form_cuestionario.Rb_enfnoP.Checked = True Then
                enfgrave = "No"
            ElseIf Form_cuestionario.Rb_enfsiP.Checked = True Then
                enfgrave = "Sí"
            Else
                Return False
            End If

            Return True
        End If

        If tipoEnc = "Actual" Then
            promedio = Form_cuestionario.Text_PromA.Text

            If Form_cuestionario.RB_PrimarioA.Checked = True Then
                nivel_educativo = "Primario"
            ElseIf Form_cuestionario.RB_secundarioA.Checked = True Then
                nivel_educativo = "Secundario"
            ElseIf Form_cuestionario.RB_terciarioA.Checked = True Then
                nivel_educativo = "Secundario"
            Else
                Return False
            End If

            If Form_cuestionario.RB_notrabajoA.Checked = True Then
                trabajo = "Desempleado"
            ElseIf Form_cuestionario.RB_emprendimientoA.Checked = True Then
                trabajo = "Emprendimiento"
            ElseIf Form_cuestionario.RB_formalA.Checked = True Then
                trabajo = "Formal"
            Else
                Return False
            End If

            If Form_cuestionario.RB_FconflicA.Checked = True Then
                relfam = "Conflictiva"
            ElseIf Form_cuestionario.RB_FfriaA.Checked = True Then
                relfam = "Fría"
            ElseIf Form_cuestionario.RB_FcordialA.Checked = True Then
                relfam = "Cordial"
            ElseIf Form_cuestionario.RB_FbuenaA.Checked = True Then
                relfam = "Buena"
            Else
                Return False
            End If

            If Form_cuestionario.RB_CconflicA.Checked = True Then
                relcomp = "Conflictiva"
            ElseIf Form_cuestionario.RB_CfriaA.Checked = True Then
                relcomp = "Fría"
            ElseIf Form_cuestionario.RB_CcordialA.Checked = True Then
                relcomp = "Cordial"
            ElseIf Form_cuestionario.RB_CbuenaA.Checked = True Then
                relcomp = "Buena"
            Else
                Return False
            End If

            If Form_cuestionario.RB_PobrezaA.Checked = True Then
                condeco = "Pobreza"
            ElseIf Form_cuestionario.RB_BasicoA.Checked = True Then
                condeco = "Básico"
            ElseIf Form_cuestionario.RB_BasicoSupA.Checked = True Then
                condeco = "Básico + Suplementos"
            ElseIf Form_cuestionario.RB_estableA.Checked = True Then
                condeco = "Estable"
            Else
                Return False
            End If

            If Form_cuestionario.CB_depA.Checked = True Then
                enfmen = enfmen + " + Depresión"
            End If
            If Form_cuestionario.CB_ansA.Checked = True Then
                enfmen = enfmen + " + Ansiedad"
            End If
            If Form_cuestionario.CB_adhdA.Checked = True Then
                enfmen = enfmen + " + ADHD"
            End If
            If Form_cuestionario.CB_otroA.Checked = True Then
                enfmen = enfmen + " + Otro"
            End If

            If Form_cuestionario.RB_docPocoA.Checked = True Then
                comudoc = "Poca"
            ElseIf Form_cuestionario.RB_docVarA.Checked = True Then
                comudoc = "Varía según profesor"
            ElseIf Form_cuestionario.RB_docPreA.Checked = True Then
                comudoc = "Presencial"
            ElseIf Form_cuestionario.RB_docVirA.Checked = True Then
                comudoc = "Virtual"
            ElseIf Form_cuestionario.RB_docAmA.Checked = True Then
                comudoc = "Ambas"
            Else
                Return False
            End If

            If Form_cuestionario.RB_instdescA.Checked = True Then
                condinsti = "Descuidada"
            ElseIf Form_cuestionario.RB_insttrabA.Checked = True Then
                condinsti = "Trabajada"
            ElseIf Form_cuestionario.RB_instidonA.Checked = True Then
                condinsti = "Idonea"
            Else
                Return False
            End If

            If Form_cuestionario.RB_extnoA.Checked = True Then
                activext = "No"
            ElseIf Form_cuestionario.RB_extsiA.Checked = True Then
                activext = "Sí"
            Else
                Return False
            End If

            If Form_cuestionario.RB_enfnoA.Checked = True Then
                enfgrave = "No"
            ElseIf Form_cuestionario.RB_enfsiA.Checked = True Then
                enfgrave = "Sí"
            Else
                Return False
            End If
            Return True
        End If
        Return False
    End Function
    Public Function GuardarHistorial()
        Try
            con.Open()
            cmd = New SqlCommand("sp_GuardarHistorial", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@mail", mail)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@tipo", tipoEnc)
            cmd.Parameters.AddWithValue("@promedio", promedio)
            cmd.Parameters.AddWithValue("@nivel_educativo", nivel_educativo)
            cmd.Parameters.AddWithValue("@trabajo", trabajo)
            cmd.Parameters.AddWithValue("@relfam", relfam)
            cmd.Parameters.AddWithValue("@relcomp", relcomp)
            cmd.Parameters.AddWithValue("@condeco", condeco)
            cmd.Parameters.AddWithValue("@enfmen", enfmen)
            cmd.Parameters.AddWithValue("@comudoc", comudoc)
            cmd.Parameters.AddWithValue("@condinsti", condinsti)
            cmd.Parameters.AddWithValue("@activext", activext)
            cmd.Parameters.AddWithValue("@enfgrave", enfgrave)
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
