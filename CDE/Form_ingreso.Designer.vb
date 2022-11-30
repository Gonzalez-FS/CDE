<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Ingreso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_nombre = New System.Windows.Forms.TextBox()
        Me.Labelmail = New System.Windows.Forms.Label()
        Me.Text_mail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Labelorg = New System.Windows.Forms.Label()
        Me.Text_contra = New System.Windows.Forms.TextBox()
        Me.Text_org = New System.Windows.Forms.TextBox()
        Me.Btn_logOP = New System.Windows.Forms.Button()
        Me.Btn_regOP = New System.Windows.Forms.Button()
        Me.Btn_logadminOP = New System.Windows.Forms.Button()
        Me.Btn_regadminOP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Text_nombre
        '
        Me.Text_nombre.Location = New System.Drawing.Point(111, 32)
        Me.Text_nombre.Name = "Text_nombre"
        Me.Text_nombre.Size = New System.Drawing.Size(382, 20)
        Me.Text_nombre.TabIndex = 1
        '
        'Labelmail
        '
        Me.Labelmail.AutoSize = True
        Me.Labelmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelmail.Location = New System.Drawing.Point(21, 86)
        Me.Labelmail.Name = "Labelmail"
        Me.Labelmail.Size = New System.Drawing.Size(34, 15)
        Me.Labelmail.TabIndex = 2
        Me.Labelmail.Text = "Mail:"
        '
        'Text_mail
        '
        Me.Text_mail.Location = New System.Drawing.Point(111, 81)
        Me.Text_mail.Name = "Text_mail"
        Me.Text_mail.Size = New System.Drawing.Size(382, 20)
        Me.Text_mail.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña:"
        '
        'Labelorg
        '
        Me.Labelorg.AutoSize = True
        Me.Labelorg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelorg.Location = New System.Drawing.Point(22, 164)
        Me.Labelorg.Name = "Labelorg"
        Me.Labelorg.Size = New System.Drawing.Size(83, 15)
        Me.Labelorg.TabIndex = 5
        Me.Labelorg.Text = "Organización:"
        Me.Labelorg.Visible = False
        '
        'Text_contra
        '
        Me.Text_contra.Location = New System.Drawing.Point(111, 124)
        Me.Text_contra.Name = "Text_contra"
        Me.Text_contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.Text_contra.Size = New System.Drawing.Size(382, 20)
        Me.Text_contra.TabIndex = 6
        '
        'Text_org
        '
        Me.Text_org.Location = New System.Drawing.Point(111, 164)
        Me.Text_org.Name = "Text_org"
        Me.Text_org.Size = New System.Drawing.Size(382, 20)
        Me.Text_org.TabIndex = 7
        Me.Text_org.Visible = False
        '
        'Btn_logOP
        '
        Me.Btn_logOP.Location = New System.Drawing.Point(211, 301)
        Me.Btn_logOP.Name = "Btn_logOP"
        Me.Btn_logOP.Size = New System.Drawing.Size(118, 54)
        Me.Btn_logOP.TabIndex = 8
        Me.Btn_logOP.Text = "Ingresar"
        Me.Btn_logOP.UseVisualStyleBackColor = True
        Me.Btn_logOP.Visible = False
        '
        'Btn_regOP
        '
        Me.Btn_regOP.Location = New System.Drawing.Point(419, 312)
        Me.Btn_regOP.Name = "Btn_regOP"
        Me.Btn_regOP.Size = New System.Drawing.Size(114, 32)
        Me.Btn_regOP.TabIndex = 9
        Me.Btn_regOP.Text = "Registrarse"
        Me.Btn_regOP.UseVisualStyleBackColor = True
        Me.Btn_regOP.Visible = False
        '
        'Btn_logadminOP
        '
        Me.Btn_logadminOP.Location = New System.Drawing.Point(211, 246)
        Me.Btn_logadminOP.Name = "Btn_logadminOP"
        Me.Btn_logadminOP.Size = New System.Drawing.Size(118, 49)
        Me.Btn_logadminOP.TabIndex = 10
        Me.Btn_logadminOP.Text = "Ingresar como Admin"
        Me.Btn_logadminOP.UseVisualStyleBackColor = True
        Me.Btn_logadminOP.Visible = False
        '
        'Btn_regadminOP
        '
        Me.Btn_regadminOP.Location = New System.Drawing.Point(12, 312)
        Me.Btn_regadminOP.Name = "Btn_regadminOP"
        Me.Btn_regadminOP.Size = New System.Drawing.Size(100, 32)
        Me.Btn_regadminOP.TabIndex = 11
        Me.Btn_regadminOP.Text = "Registrar Admin"
        Me.Btn_regadminOP.UseVisualStyleBackColor = True
        Me.Btn_regadminOP.Visible = False
        '
        'Form_Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 367)
        Me.Controls.Add(Me.Btn_regadminOP)
        Me.Controls.Add(Me.Btn_logadminOP)
        Me.Controls.Add(Me.Btn_regOP)
        Me.Controls.Add(Me.Btn_logOP)
        Me.Controls.Add(Me.Text_org)
        Me.Controls.Add(Me.Text_contra)
        Me.Controls.Add(Me.Labelorg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Text_mail)
        Me.Controls.Add(Me.Labelmail)
        Me.Controls.Add(Me.Text_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Ingreso"
        Me.Text = "Ingreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Text_nombre As TextBox
    Friend WithEvents Labelmail As Label
    Friend WithEvents Text_mail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Labelorg As Label
    Friend WithEvents Text_contra As TextBox
    Friend WithEvents Text_org As TextBox
    Friend WithEvents Btn_logOP As Button
    Friend WithEvents Btn_regOP As Button
    Friend WithEvents Btn_logadminOP As Button
    Friend WithEvents Btn_regadminOP As Button
End Class
