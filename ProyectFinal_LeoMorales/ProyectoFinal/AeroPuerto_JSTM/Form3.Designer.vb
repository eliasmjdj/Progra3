<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelResultado = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cmbx_Ventanilla = New System.Windows.Forms.ComboBox()
        Me.LabelVentanilla = New System.Windows.Forms.Label()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.TxtHorario = New System.Windows.Forms.TextBox()
        Me.TxtVuelo = New System.Windows.Forms.TextBox()
        Me.LabelVuelo = New System.Windows.Forms.Label()
        Me.LabelEscala = New System.Windows.Forms.Label()
        Me.TxtEscala = New System.Windows.Forms.TextBox()
        Me.LabelDestino = New System.Windows.Forms.Label()
        Me.TxtDestino = New System.Windows.Forms.TextBox()
        Me.Btn_Ejecutar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vista Administrador"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Info Vuelo Y Destino", "Recoleccion Monetario", "Corte Vuelo", "Pasajero Vuelo", "Pasajero Escala", "Total Pasajero Destino"})
        Me.ComboBox1.Location = New System.Drawing.Point(32, 86)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResultado.Location = New System.Drawing.Point(290, 108)
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(174, 20)
        Me.LabelResultado.TabIndex = 2
        Me.LabelResultado.Text = "................................."
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(247, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(552, 301)
        Me.DataGridView1.TabIndex = 3
        '
        'Cmbx_Ventanilla
        '
        Me.Cmbx_Ventanilla.FormattingEnabled = True
        Me.Cmbx_Ventanilla.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.Cmbx_Ventanilla.Location = New System.Drawing.Point(32, 168)
        Me.Cmbx_Ventanilla.Name = "Cmbx_Ventanilla"
        Me.Cmbx_Ventanilla.Size = New System.Drawing.Size(121, 21)
        Me.Cmbx_Ventanilla.TabIndex = 4
        '
        'LabelVentanilla
        '
        Me.LabelVentanilla.AutoSize = True
        Me.LabelVentanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentanilla.Location = New System.Drawing.Point(39, 149)
        Me.LabelVentanilla.Name = "LabelVentanilla"
        Me.LabelVentanilla.Size = New System.Drawing.Size(76, 16)
        Me.LabelVentanilla.TabIndex = 6
        Me.LabelVentanilla.Text = "Ventanilla"
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.Location = New System.Drawing.Point(45, 203)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(41, 16)
        Me.LabelHora.TabIndex = 7
        Me.LabelHora.Text = "Hora"
        '
        'TxtHorario
        '
        Me.TxtHorario.Location = New System.Drawing.Point(32, 222)
        Me.TxtHorario.Name = "TxtHorario"
        Me.TxtHorario.Size = New System.Drawing.Size(121, 20)
        Me.TxtHorario.TabIndex = 8
        '
        'TxtVuelo
        '
        Me.TxtVuelo.Location = New System.Drawing.Point(32, 285)
        Me.TxtVuelo.Name = "TxtVuelo"
        Me.TxtVuelo.Size = New System.Drawing.Size(100, 20)
        Me.TxtVuelo.TabIndex = 9
        '
        'LabelVuelo
        '
        Me.LabelVuelo.AutoSize = True
        Me.LabelVuelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVuelo.Location = New System.Drawing.Point(39, 257)
        Me.LabelVuelo.Name = "LabelVuelo"
        Me.LabelVuelo.Size = New System.Drawing.Size(47, 16)
        Me.LabelVuelo.TabIndex = 10
        Me.LabelVuelo.Text = "Vuelo"
        '
        'LabelEscala
        '
        Me.LabelEscala.AutoSize = True
        Me.LabelEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEscala.Location = New System.Drawing.Point(29, 330)
        Me.LabelEscala.Name = "LabelEscala"
        Me.LabelEscala.Size = New System.Drawing.Size(122, 16)
        Me.LabelEscala.TabIndex = 11
        Me.LabelEscala.Text = "Escala Pasajero"
        '
        'TxtEscala
        '
        Me.TxtEscala.Location = New System.Drawing.Point(32, 363)
        Me.TxtEscala.Name = "TxtEscala"
        Me.TxtEscala.Size = New System.Drawing.Size(100, 20)
        Me.TxtEscala.TabIndex = 12
        '
        'LabelDestino
        '
        Me.LabelDestino.AutoSize = True
        Me.LabelDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDestino.Location = New System.Drawing.Point(39, 395)
        Me.LabelDestino.Name = "LabelDestino"
        Me.LabelDestino.Size = New System.Drawing.Size(60, 16)
        Me.LabelDestino.TabIndex = 13
        Me.LabelDestino.Text = "Destino"
        '
        'TxtDestino
        '
        Me.TxtDestino.Location = New System.Drawing.Point(32, 418)
        Me.TxtDestino.Name = "TxtDestino"
        Me.TxtDestino.Size = New System.Drawing.Size(100, 20)
        Me.TxtDestino.TabIndex = 14
        '
        'Btn_Ejecutar
        '
        Me.Btn_Ejecutar.Location = New System.Drawing.Point(713, 120)
        Me.Btn_Ejecutar.Name = "Btn_Ejecutar"
        Me.Btn_Ejecutar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Ejecutar.TabIndex = 15
        Me.Btn_Ejecutar.Text = "Ejecutar"
        Me.Btn_Ejecutar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_Ejecutar)
        Me.Controls.Add(Me.TxtDestino)
        Me.Controls.Add(Me.LabelDestino)
        Me.Controls.Add(Me.TxtEscala)
        Me.Controls.Add(Me.LabelEscala)
        Me.Controls.Add(Me.LabelVuelo)
        Me.Controls.Add(Me.TxtVuelo)
        Me.Controls.Add(Me.TxtHorario)
        Me.Controls.Add(Me.LabelHora)
        Me.Controls.Add(Me.LabelVentanilla)
        Me.Controls.Add(Me.Cmbx_Ventanilla)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LabelResultado)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Administrador"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelResultado As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cmbx_Ventanilla As ComboBox
    Friend WithEvents LabelVentanilla As Label
    Friend WithEvents LabelHora As Label
    Friend WithEvents TxtHorario As TextBox
    Friend WithEvents TxtVuelo As TextBox
    Friend WithEvents LabelVuelo As Label
    Friend WithEvents LabelEscala As Label
    Friend WithEvents TxtEscala As TextBox
    Friend WithEvents LabelDestino As Label
    Friend WithEvents TxtDestino As TextBox
    Friend WithEvents Btn_Ejecutar As Button
End Class
