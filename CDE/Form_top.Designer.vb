<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_top
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
        Me.Label_Titulo = New System.Windows.Forms.Label()
        Me.DGtop = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_salir = New System.Windows.Forms.Button()
        CType(Me.DGtop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Titulo
        '
        Me.Label_Titulo.AutoSize = True
        Me.Label_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titulo.Location = New System.Drawing.Point(156, 23)
        Me.Label_Titulo.Name = "Label_Titulo"
        Me.Label_Titulo.Size = New System.Drawing.Size(331, 20)
        Me.Label_Titulo.TabIndex = 1
        Me.Label_Titulo.Text = "Mayores causas de deterioro académico"
        '
        'DGtop
        '
        Me.DGtop.AllowUserToAddRows = False
        Me.DGtop.AllowUserToDeleteRows = False
        Me.DGtop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGtop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGtop.Location = New System.Drawing.Point(129, 63)
        Me.DGtop.Name = "DGtop"
        Me.DGtop.ReadOnly = True
        Me.DGtop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGtop.Size = New System.Drawing.Size(401, 153)
        Me.DGtop.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 11
        '
        'Btn_salir
        '
        Me.Btn_salir.BackColor = System.Drawing.Color.Red
        Me.Btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_salir.Location = New System.Drawing.Point(284, 253)
        Me.Btn_salir.Name = "Btn_salir"
        Me.Btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_salir.TabIndex = 12
        Me.Btn_salir.Text = "SALIR"
        Me.Btn_salir.UseVisualStyleBackColor = False
        '
        'Form_top
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 301)
        Me.Controls.Add(Me.Btn_salir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGtop)
        Me.Controls.Add(Me.Label_Titulo)
        Me.Name = "Form_top"
        Me.Text = "Form_top"
        CType(Me.DGtop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Titulo As Label
    Friend WithEvents DGtop As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_salir As Button
End Class
