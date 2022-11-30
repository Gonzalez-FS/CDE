<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_admin
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
        Me.DG_Historial = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_eliminar = New System.Windows.Forms.TextBox()
        Me.Btn_eliminar = New System.Windows.Forms.Button()
        Me.Btn_salir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DG_Usuarios = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Historial = New System.Windows.Forms.Button()
        Me.Btn_comentarios = New System.Windows.Forms.Button()
        CType(Me.DG_Historial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_Historial
        '
        Me.DG_Historial.AllowUserToAddRows = False
        Me.DG_Historial.AllowUserToDeleteRows = False
        Me.DG_Historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Historial.Location = New System.Drawing.Point(27, 182)
        Me.DG_Historial.Name = "DG_Historial"
        Me.DG_Historial.ReadOnly = True
        Me.DG_Historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Historial.Size = New System.Drawing.Size(745, 227)
        Me.DG_Historial.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID de usuario a eliminar:"
        '
        'Text_eliminar
        '
        Me.Text_eliminar.Location = New System.Drawing.Point(150, 46)
        Me.Text_eliminar.Name = "Text_eliminar"
        Me.Text_eliminar.Size = New System.Drawing.Size(108, 20)
        Me.Text_eliminar.TabIndex = 2
        '
        'Btn_eliminar
        '
        Me.Btn_eliminar.Location = New System.Drawing.Point(99, 83)
        Me.Btn_eliminar.Name = "Btn_eliminar"
        Me.Btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_eliminar.TabIndex = 3
        Me.Btn_eliminar.Text = "Eliminar"
        Me.Btn_eliminar.UseVisualStyleBackColor = True
        '
        'Btn_salir
        '
        Me.Btn_salir.BackColor = System.Drawing.Color.Red
        Me.Btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_salir.Location = New System.Drawing.Point(361, 415)
        Me.Btn_salir.Name = "Btn_salir"
        Me.Btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_salir.TabIndex = 4
        Me.Btn_salir.Text = "SALIR"
        Me.Btn_salir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 5
        '
        'DG_Usuarios
        '
        Me.DG_Usuarios.AllowUserToAddRows = False
        Me.DG_Usuarios.AllowUserToDeleteRows = False
        Me.DG_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Usuarios.Location = New System.Drawing.Point(451, 46)
        Me.DG_Usuarios.Name = "DG_Usuarios"
        Me.DG_Usuarios.ReadOnly = True
        Me.DG_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Usuarios.Size = New System.Drawing.Size(321, 124)
        Me.DG_Usuarios.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(570, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Usuarios"
        '
        'Btn_Historial
        '
        Me.Btn_Historial.Location = New System.Drawing.Point(30, 150)
        Me.Btn_Historial.Name = "Btn_Historial"
        Me.Btn_Historial.Size = New System.Drawing.Size(91, 23)
        Me.Btn_Historial.TabIndex = 8
        Me.Btn_Historial.Text = "Ver historial"
        Me.Btn_Historial.UseVisualStyleBackColor = True
        '
        'Btn_comentarios
        '
        Me.Btn_comentarios.Location = New System.Drawing.Point(128, 150)
        Me.Btn_comentarios.Name = "Btn_comentarios"
        Me.Btn_comentarios.Size = New System.Drawing.Size(113, 23)
        Me.Btn_comentarios.TabIndex = 9
        Me.Btn_comentarios.Text = "Ver comentarios"
        Me.Btn_comentarios.UseVisualStyleBackColor = True
        '
        'Form_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_comentarios)
        Me.Controls.Add(Me.Btn_Historial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DG_Usuarios)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_salir)
        Me.Controls.Add(Me.Btn_eliminar)
        Me.Controls.Add(Me.Text_eliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DG_Historial)
        Me.Name = "Form_admin"
        Me.Text = "Form_admin"
        CType(Me.DG_Historial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_Historial As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Text_eliminar As TextBox
    Friend WithEvents Btn_eliminar As Button
    Friend WithEvents Btn_salir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DG_Usuarios As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Historial As Button
    Friend WithEvents Btn_comentarios As Button
End Class
