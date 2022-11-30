<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_regadmin = New System.Windows.Forms.Button()
        Me.Btn_logadmin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Labelcyd = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_reg = New System.Windows.Forms.Button()
        Me.Btn_log = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_regadmin
        '
        Me.Btn_regadmin.Location = New System.Drawing.Point(617, 90)
        Me.Btn_regadmin.Name = "Btn_regadmin"
        Me.Btn_regadmin.Size = New System.Drawing.Size(107, 47)
        Me.Btn_regadmin.TabIndex = 15
        Me.Btn_regadmin.Text = "Registrar administrador"
        Me.Btn_regadmin.UseVisualStyleBackColor = True
        '
        'Btn_logadmin
        '
        Me.Btn_logadmin.Location = New System.Drawing.Point(617, 36)
        Me.Btn_logadmin.Name = "Btn_logadmin"
        Me.Btn_logadmin.Size = New System.Drawing.Size(107, 47)
        Me.Btn_logadmin.TabIndex = 14
        Me.Btn_logadmin.Text = "Entrar como administrador"
        Me.Btn_logadmin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Labelcyd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(93, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 220)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "¿Qué es CDE?"
        '
        'Labelcyd
        '
        Me.Labelcyd.AutoSize = True
        Me.Labelcyd.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcyd.Location = New System.Drawing.Point(42, 75)
        Me.Labelcyd.Name = "Labelcyd"
        Me.Labelcyd.Size = New System.Drawing.Size(439, 66)
        Me.Labelcyd.TabIndex = 0
        Me.Labelcyd.Text = "CDE es un sistema que recopila las principales causas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del deterioro en el desemp" &
    "eño escolar de los" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " estudiantes mediante un cuestionario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(433, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "¿No tienes una cuenta?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Para iniciar el programa"
        '
        'Btn_reg
        '
        Me.Btn_reg.Location = New System.Drawing.Point(446, 355)
        Me.Btn_reg.Name = "Btn_reg"
        Me.Btn_reg.Size = New System.Drawing.Size(168, 63)
        Me.Btn_reg.TabIndex = 10
        Me.Btn_reg.Text = "Registrarse"
        Me.Btn_reg.UseVisualStyleBackColor = True
        '
        'Btn_log
        '
        Me.Btn_log.Location = New System.Drawing.Point(93, 355)
        Me.Btn_log.Name = "Btn_log"
        Me.Btn_log.Size = New System.Drawing.Size(168, 63)
        Me.Btn_log.TabIndex = 9
        Me.Btn_log.Text = "Inicia sesión"
        Me.Btn_log.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 36)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bienvenido a CDE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_regadmin)
        Me.Controls.Add(Me.Btn_logadmin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_reg)
        Me.Controls.Add(Me.Btn_log)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_regadmin As Button
    Friend WithEvents Btn_logadmin As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Labelcyd As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_reg As Button
    Friend WithEvents Btn_log As Button
    Friend WithEvents Label1 As Label
End Class
