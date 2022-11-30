Public Class CYD
    Dim NivelEducativoPas As Integer
    Dim NivelEducativoAct As Integer
    Dim TrabajoPas As Integer
    Dim TrabajoAct As Integer
    Dim RelFamiliaPas As Integer
    Dim RelFamiliaAct As Integer
    Dim RelCompPas As Integer
    Dim RelCompAct As Integer
    Dim CondEcoPas As Integer
    Dim CondEcoAct As Integer
    Dim EnfMenPas As Integer = 0
    Dim EnfMenAct As Integer = 0
    Dim ComuDocPas As Integer
    Dim ComuDocAct As Integer
    Dim CondInstiPas As Integer
    Dim CondInstiAct As Integer
    Dim ActivExtPas As Integer
    Dim ActivExtAct As Integer
    Dim EnfGravePas As Integer
    Dim EnfGraveAct As Integer
    Dim PromedioPas As Integer
    Dim PromedioAct As Integer
    Dim respuestas1 As New Respuestas

    Public Function ConvertirVariables()
        PromedioPas = Val(Form_cuestionario.Text_PromP.Text)
        PromedioAct = Val(Form_cuestionario.Text_PromA.Text)
        respuestas1.Mail = Form_Ingreso.Text_mail.Text
        If PromedioAct < PromedioPas Then

            If Form_cuestionario.Rb_PrimarioP.Checked = True Then
                NivelEducativoPas = 1
            ElseIf Form_cuestionario.Rb_secundarioP.Checked = True Then
                NivelEducativoPas = 2
            ElseIf Form_cuestionario.Rb_terciarioP.Checked = True Then
                NivelEducativoPas = 3
            Else
                Return False
            End If

            If Form_cuestionario.RB_PrimarioA.Checked = True Then
                NivelEducativoAct = 1
            ElseIf Form_cuestionario.RB_secundarioA.Checked = True Then
                NivelEducativoAct = 2
            ElseIf Form_cuestionario.RB_terciarioA.Checked = True Then
                NivelEducativoAct = 3
            Else
                Return False
            End If

            If Form_cuestionario.Rb_notrabajoP.Checked = True Then
                TrabajoPas = 1
            ElseIf Form_cuestionario.Rb_emprendimientoP.Checked = True Then
                TrabajoPas = 2
            ElseIf Form_cuestionario.Rb_formalP.Checked = True Then
                TrabajoPas = 3
            Else
                Return False
            End If

            If Form_cuestionario.RB_notrabajoA.Checked = True Then
                TrabajoAct = 1
            ElseIf Form_cuestionario.RB_emprendimientoA.Checked = True Then
                TrabajoAct = 2
            ElseIf Form_cuestionario.RB_formalA.Checked = True Then
                TrabajoAct = 3
            Else
                Return False
            End If

            If Form_cuestionario.Rb_FconflicP.Checked = True Then
                RelFamiliaPas = 1
            ElseIf Form_cuestionario.Rb_FfriaP.Checked = True Then
                RelFamiliaPas = 2
            ElseIf Form_cuestionario.Rb_FcordialP.Checked = True Then
                RelFamiliaPas = 3
            ElseIf Form_cuestionario.Rb_FbuenaP.Checked = True Then
                RelFamiliaPas = 4
            Else
                Return False
            End If

            If Form_cuestionario.RB_FconflicA.Checked = True Then
                RelFamiliaAct = 1
            ElseIf Form_cuestionario.RB_FfriaA.Checked = True Then
                RelFamiliaAct = 2
            ElseIf Form_cuestionario.RB_FcordialA.Checked = True Then
                RelFamiliaAct = 3
            ElseIf Form_cuestionario.RB_FbuenaA.Checked = True Then
                RelFamiliaAct = 4
            Else
                Return False
            End If

            If Form_cuestionario.Rb_CconflicP.Checked = True Then
                RelCompPas = 1
            ElseIf Form_cuestionario.Rb_CfriaP.Checked = True Then
                RelCompPas = 2
            ElseIf Form_cuestionario.Rb_CcordialP.Checked = True Then
                RelCompPas = 3
            ElseIf Form_cuestionario.Rb_CbuenaP.Checked = True Then
                RelCompPas = 4
            Else
                Return False
            End If

            If Form_cuestionario.RB_CconflicA.Checked = True Then
                RelCompAct = 1
            ElseIf Form_cuestionario.RB_CfriaA.Checked = True Then
                RelCompAct = 2
            ElseIf Form_cuestionario.RB_CcordialA.Checked = True Then
                RelCompAct = 3
            ElseIf Form_cuestionario.RB_CbuenaA.Checked = True Then
                RelCompAct = 4
            Else
                Return False
            End If

            If Form_cuestionario.Rb_PobrezaP.Checked = True Then
                CondEcoPas = 1
            ElseIf Form_cuestionario.Rb_BasicoP.Checked = True Then
                CondEcoPas = 2
            ElseIf Form_cuestionario.Rb_BasicoSupP.Checked = True Then
                CondEcoPas = 3
            ElseIf Form_cuestionario.Rb_estableP.Checked = True Then
                CondEcoPas = 4
            Else
                Return False
            End If

            If Form_cuestionario.RB_PobrezaA.Checked = True Then
                CondEcoAct = 1
            ElseIf Form_cuestionario.RB_BasicoA.Checked = True Then
                CondEcoAct = 2
            ElseIf Form_cuestionario.RB_BasicoSupA.Checked = True Then
                CondEcoAct = 3
            ElseIf Form_cuestionario.RB_estableA.Checked = True Then
                CondEcoAct = 4
            Else
                Return False
            End If

            If Form_cuestionario.CB_depP.Checked = True Then
                EnfMenPas = EnfMenPas + 1
            End If
            If Form_cuestionario.CB_ansP.Checked = True Then
                EnfMenPas = EnfMenPas + 1
            End If
            If Form_cuestionario.CB_adhdP.Checked = True Then
                EnfMenPas = EnfMenPas + 1
            End If
            If Form_cuestionario.CB_otroP.Checked = True Then
                EnfMenPas = EnfMenPas + 1
            End If

            If Form_cuestionario.CB_depA.Checked = True Then
                EnfMenAct = EnfMenAct + 1
            End If
            If Form_cuestionario.CB_ansA.Checked = True Then
                EnfMenAct = EnfMenAct + 1
            End If
            If Form_cuestionario.CB_adhdA.Checked = True Then
                EnfMenAct = EnfMenAct + 1
            End If
            If Form_cuestionario.CB_otroA.Checked = True Then
                EnfMenAct = EnfMenAct + 1
            End If

            If Form_cuestionario.Rb_docPocoP.Checked = True Then
                ComuDocPas = 1
            ElseIf Form_cuestionario.Rb_docVarP.Checked = True Then
                ComuDocPas = 2
            ElseIf Form_cuestionario.Rb_docPreP.Checked = True Then
                ComuDocPas = 3
            ElseIf Form_cuestionario.Rb_docVirP.Checked = True Then
                ComuDocPas = 4
            ElseIf Form_cuestionario.Rb_docAmP.Checked = True Then
                ComuDocPas = 5
            Else
                Return False
            End If

            If Form_cuestionario.RB_docPocoA.Checked = True Then
                ComuDocAct = 1
            ElseIf Form_cuestionario.RB_docVarA.Checked = True Then
                ComuDocAct = 2
            ElseIf Form_cuestionario.RB_docPreA.Checked = True Then
                ComuDocAct = 3
            ElseIf Form_cuestionario.RB_docVirA.Checked = True Then
                ComuDocAct = 4
            ElseIf Form_cuestionario.RB_docAmA.Checked = True Then
                ComuDocAct = 5
            Else
                Return False
            End If

            If Form_cuestionario.Rb_instdescP.Checked = True Then
                CondInstiPas = 1
            ElseIf Form_cuestionario.Rb_insttrabP.Checked = True Then
                CondInstiPas = 2
            ElseIf Form_cuestionario.Rb_instidonP.Checked = True Then
                CondInstiPas = 3
            Else
                Return False
            End If

            If Form_cuestionario.RB_instdescA.Checked = True Then
                CondInstiAct = 1
            ElseIf Form_cuestionario.RB_insttrabA.Checked = True Then
                CondInstiAct = 2
            ElseIf Form_cuestionario.RB_instidonA.Checked = True Then
                CondInstiAct = 3
            Else
                Return False
            End If

            If Form_cuestionario.Rb_extnoP.Checked = True Then
                ActivExtPas = 1
            ElseIf Form_cuestionario.Rb_extsiP.Checked = True Then
                ActivExtPas = 2
            Else
                Return False
            End If

            If Form_cuestionario.RB_extnoA.Checked = True Then
                ActivExtAct = 1
            ElseIf Form_cuestionario.RB_extsiA.Checked = True Then
                ActivExtAct = 2
            Else
                Return False
            End If

            If Form_cuestionario.Rb_enfnoP.Checked = True Then
                EnfGravePas = 1
            ElseIf Form_cuestionario.Rb_enfsiP.Checked = True Then
                EnfGravePas = 2
            Else
                Return False
            End If

            If Form_cuestionario.RB_enfnoA.Checked = True Then
                EnfGraveAct = 1
            ElseIf Form_cuestionario.RB_enfsiA.Checked = True Then
                EnfGraveAct = 2
            Else
                Return False
            End If

            If NivelEducativoAct > NivelEducativoPas Then
                respuestas1.MasNivelEducativo = True
                respuestas1.ID_causa = 1
                respuestas1.ID_causa2 = 1
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If TrabajoPas < TrabajoAct Then
                respuestas1.MasCargaTrabajo = True
                respuestas1.ID_causa = 2
                respuestas1.ID_causa2 = 2
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If RelFamiliaPas > RelFamiliaAct Then
                respuestas1.ProblemasFamiliares = True
                respuestas1.ID_causa = 3
                respuestas1.ID_causa2 = 3
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If RelCompPas > RelCompAct Then
                respuestas1.ProblemasCompañeros = True
                respuestas1.ID_causa = 4
                respuestas1.ID_causa2 = 4
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If CondEcoPas > CondEcoAct Then
                respuestas1.DeterioroEconomico = True
                respuestas1.ID_causa = 5
                respuestas1.ID_causa2 = 5
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If EnfMenAct > EnfMenPas Then
                respuestas1.DeterioroSaludMental = True
                respuestas1.ID_causa = 6
                respuestas1.ID_causa2 = 6
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If ComuDocPas > ComuDocAct Then
                respuestas1.PeorComuDocentes = True
                respuestas1.ID_causa = 7
                respuestas1.ID_causa2 = 7
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If CondInstiPas > CondInstiAct Then
                respuestas1.PeorInstitucion = True
                respuestas1.ID_causa = 8
                respuestas1.ID_causa2 = 8
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If ActivExtPas < ActivExtAct Then
                respuestas1.InicioActivsExtra = True
                respuestas1.ID_causa = 9
                respuestas1.ID_causa2 = 9
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If EnfGraveAct > EnfGravePas Then
                respuestas1.EnfermedadGrave = True
                respuestas1.ID_causa = 10
                respuestas1.ID_causa2 = 10
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            Return True
        End If



        If PromedioAct > PromedioPas Then

            If Form_cuestionario.Rb_PrimarioP.Checked = True Then
                NivelEducativoPas = 1
            ElseIf Form_cuestionario.Rb_secundarioP.Checked = True Then
                NivelEducativoPas = 2
            ElseIf Form_cuestionario.Rb_terciarioP.Checked = True Then
                NivelEducativoPas = 3
            Else
                Return False
            End If

            If Form_cuestionario.RB_PrimarioA.Checked = True Then
                NivelEducativoAct = 1
            ElseIf Form_cuestionario.RB_secundarioA.Checked = True Then
                NivelEducativoAct = 2
            ElseIf Form_cuestionario.RB_terciarioA.Checked = True Then
                NivelEducativoAct = 3
            Else
                Return False
            End If

            If Form_cuestionario.Rb_notrabajoP.Checked = True Then
                TrabajoPas = 1
            ElseIf Form_cuestionario.Rb_emprendimientoP.Checked = True Then
                TrabajoPas = 2
            ElseIf Form_cuestionario.Rb_formalP.Checked = True Then
                TrabajoPas = 3
            Else
                Return False
            End If

            If Form_cuestionario.RB_notrabajoA.Checked = True Then
                TrabajoAct = 1
            ElseIf Form_cuestionario.RB_emprendimientoA.Checked = True Then
                TrabajoAct = 2
            ElseIf Form_cuestionario.RB_formalA.Checked = True Then
                TrabajoAct = 3
            Else
                Return False
            End If

            If Form_cuestionario.Rb_FconflicP.Checked = True Then
                RelFamiliaPas = 1
            ElseIf Form_cuestionario.Rb_FfriaP.Checked = True Then
                RelFamiliaPas = 2
            ElseIf Form_cuestionario.Rb_FcordialP.Checked = True Then
                RelFamiliaPas = 3
            ElseIf Form_cuestionario.Rb_FbuenaP.Checked = True Then
                RelFamiliaPas = 4
            Else
                Return False
            End If

            If Form_cuestionario.RB_FconflicA.Checked = True Then
                RelFamiliaAct = 1
            ElseIf Form_cuestionario.RB_FfriaA.Checked = True Then
                RelFamiliaAct = 2
            ElseIf Form_cuestionario.RB_FcordialA.Checked = True Then
                RelFamiliaAct = 3
            ElseIf Form_cuestionario.RB_FbuenaA.Checked = True Then
                RelFamiliaAct = 4
            Else
                Return False
            End If

            If Form_cuestionario.Rb_CconflicP.Checked = True Then
                RelCompPas = 1
            ElseIf Form_cuestionario.Rb_CfriaP.Checked = True Then
                RelCompPas = 2
            ElseIf Form_cuestionario.Rb_CcordialP.Checked = True Then
                RelCompPas = 3
            ElseIf Form_cuestionario.Rb_CbuenaP.Checked = True Then
                RelCompPas = 4
            Else
                Return False
            End If

            If Form_cuestionario.RB_CconflicA.Checked = True Then
                RelCompAct = 1
            ElseIf Form_cuestionario.RB_CfriaA.Checked = True Then
                RelCompAct = 2
            ElseIf Form_cuestionario.RB_CcordialA.Checked = True Then
                RelCompAct = 3
            ElseIf Form_cuestionario.RB_CbuenaA.Checked = True Then
                RelCompAct = 4
            Else
                Return False
            End If

            If Form_cuestionario.Rb_PobrezaP.Checked = True Then
                CondEcoPas = 1
            ElseIf Form_cuestionario.Rb_BasicoP.Checked = True Then
                CondEcoPas = 2
            ElseIf Form_cuestionario.Rb_BasicoSupP.Checked = True Then
                CondEcoPas = 3
            ElseIf Form_cuestionario.Rb_estableP.Checked = True Then
                CondEcoPas = 4
            Else
                Return False
            End If

            If Form_cuestionario.RB_PobrezaA.Checked = True Then
                CondEcoAct = 1
            ElseIf Form_cuestionario.RB_BasicoA.Checked = True Then
                CondEcoAct = 2
            ElseIf Form_cuestionario.RB_BasicoSupA.Checked = True Then
                CondEcoAct = 3
            ElseIf Form_cuestionario.RB_estableA.Checked = True Then
                CondEcoAct = 4
            Else
                Return False
            End If

            If Form_cuestionario.CB_depP.Checked = True Then
                EnfMenPas = EnfMenPas + 1
            End If
            If Form_cuestionario.CB_ansP.Checked = True Then
                EnfMenPas = EnfMenPas + 1
            End If
            If Form_cuestionario.CB_adhdP.Checked = True Then
                EnfMenPas = EnfMenPas + 1
            End If
            If Form_cuestionario.CB_otroP.Checked = True Then
                EnfMenPas = EnfMenPas + 1
            End If

            If Form_cuestionario.CB_depA.Checked = True Then
                EnfMenAct = EnfMenAct + 1
            End If
            If Form_cuestionario.CB_ansA.Checked = True Then
                EnfMenAct = EnfMenAct + 1
            End If
            If Form_cuestionario.CB_adhdA.Checked = True Then
                EnfMenAct = EnfMenAct + 1
            End If
            If Form_cuestionario.CB_otroA.Checked = True Then
                EnfMenAct = EnfMenAct + 1
            End If

            If Form_cuestionario.Rb_docPocoP.Checked = True Then
                ComuDocPas = 1
            ElseIf Form_cuestionario.Rb_docVarP.Checked = True Then
                ComuDocPas = 2
            ElseIf Form_cuestionario.Rb_docPreP.Checked = True Then
                ComuDocPas = 3
            ElseIf Form_cuestionario.Rb_docVirP.Checked = True Then
                ComuDocPas = 4
            ElseIf Form_cuestionario.Rb_docAmP.Checked = True Then
                ComuDocPas = 5
            Else
                Return False
            End If

            If Form_cuestionario.RB_docPocoA.Checked = True Then
                ComuDocAct = 1
            ElseIf Form_cuestionario.RB_docVarA.Checked = True Then
                ComuDocAct = 2
            ElseIf Form_cuestionario.RB_docPreA.Checked = True Then
                ComuDocAct = 3
            ElseIf Form_cuestionario.RB_docVirA.Checked = True Then
                ComuDocAct = 4
            ElseIf Form_cuestionario.RB_docAmA.Checked = True Then
                ComuDocAct = 5
            Else
                Return False
            End If

            If Form_cuestionario.Rb_instdescP.Checked = True Then
                CondInstiPas = 1
            ElseIf Form_cuestionario.Rb_insttrabP.Checked = True Then
                CondInstiPas = 2
            ElseIf Form_cuestionario.Rb_instidonP.Checked = True Then
                CondInstiPas = 3
            Else
                Return False
            End If

            If Form_cuestionario.RB_instdescA.Checked = True Then
                CondInstiAct = 1
            ElseIf Form_cuestionario.RB_insttrabA.Checked = True Then
                CondInstiAct = 2
            ElseIf Form_cuestionario.RB_instidonA.Checked = True Then
                CondInstiAct = 3
            Else
                Return False
            End If

            If Form_cuestionario.Rb_extnoP.Checked = True Then
                ActivExtPas = 1
            ElseIf Form_cuestionario.Rb_extsiP.Checked = True Then
                ActivExtPas = 2
            Else
                Return False
            End If

            If Form_cuestionario.RB_extnoA.Checked = True Then
                ActivExtAct = 1
            ElseIf Form_cuestionario.RB_extsiA.Checked = True Then
                ActivExtAct = 2
            Else
                Return False
            End If

            If Form_cuestionario.Rb_enfnoP.Checked = True Then
                EnfGravePas = 1
            ElseIf Form_cuestionario.Rb_enfsiP.Checked = True Then
                EnfGravePas = 2
            Else
                Return False
            End If

            If Form_cuestionario.RB_enfnoA.Checked = True Then
                EnfGraveAct = 1
            ElseIf Form_cuestionario.RB_enfsiA.Checked = True Then
                EnfGraveAct = 2
            Else
                Return False
            End If

            If TrabajoPas > TrabajoAct Then
                respuestas1.MasCargaTrabajo = True
                respuestas1.ID_causa = 2
                respuestas1.ID_causa2 = 2
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If RelFamiliaPas < RelFamiliaAct Then
                respuestas1.ProblemasFamiliares = True
                respuestas1.ID_causa = 3
                respuestas1.ID_causa2 = 3
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If RelCompPas < RelCompAct Then
                respuestas1.ProblemasCompañeros = True
                respuestas1.ID_causa = 4
                respuestas1.ID_causa2 = 4
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If CondEcoPas < CondEcoAct Then
                respuestas1.DeterioroEconomico = True
                respuestas1.ID_causa = 5
                respuestas1.ID_causa2 = 5
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If EnfMenAct < EnfMenPas Then
                respuestas1.DeterioroSaludMental = True
                respuestas1.ID_causa = 6
                respuestas1.ID_causa2 = 6
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If ComuDocPas < ComuDocAct Then
                respuestas1.PeorComuDocentes = True
                respuestas1.ID_causa = 7
                respuestas1.ID_causa2 = 7
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If CondInstiPas < CondInstiAct Then
                respuestas1.PeorInstitucion = True
                respuestas1.ID_causa = 8
                respuestas1.ID_causa2 = 8
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If ActivExtPas > ActivExtAct Then
                respuestas1.InicioActivsExtra = True
                respuestas1.ID_causa = 9
                respuestas1.ID_causa2 = 9
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            If EnfGraveAct < EnfGravePas Then
                respuestas1.EnfermedadGrave = True
                respuestas1.ID_causa = 10
                respuestas1.ID_causa2 = 10
                respuestas1.SumarRespuestas()
                respuestas1.AgregarSumas()
            End If
            Return True
        End If
        Return True
    End Function

End Class
