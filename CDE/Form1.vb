Imports System.Data.SqlClient
Public Class Form1

    Private Sub Btn_log_Click(sender As Object, e As EventArgs) Handles Btn_log.Click
        Form_Ingreso.Show()
        Form_Ingreso.Btn_logOP.Visible = True
    End Sub

    Private Sub Btn_reg_Click(sender As Object, e As EventArgs) Handles Btn_reg.Click
        Form_Ingreso.Show()
        Form_Ingreso.Btn_regOP.Visible = True
    End Sub

    Private Sub Btn_logadmin_Click(sender As Object, e As EventArgs) Handles Btn_logadmin.Click
        Form_Ingreso.Show()
        Form_Ingreso.Btn_logadminOP.Visible = True
    End Sub

    Private Sub Btn_regadmin_Click(sender As Object, e As EventArgs) Handles Btn_regadmin.Click
        Form_Ingreso.Show()
        Form_Ingreso.Btn_regadminOP.Visible = True
        Form_Ingreso.Labelorg.Visible = True
        Form_Ingreso.Text_org.Visible = True
    End Sub

End Class
