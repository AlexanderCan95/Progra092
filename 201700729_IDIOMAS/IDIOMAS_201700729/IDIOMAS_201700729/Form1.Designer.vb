<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class INSCRIPCIONES
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INSCRIPCIONES))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RB_CHEQUE = New System.Windows.Forms.RadioButton()
        Me.RB_EFECTIVO = New System.Windows.Forms.RadioButton()
        Me.DTW_DETALLES = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckB_SABADO = New System.Windows.Forms.CheckBox()
        Me.CheckB_VIERNES = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBOX_IDIOMAS = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBOX_CARNET = New System.Windows.Forms.TextBox()
        Me.TBOX_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DTW_DETALLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.RB_CHEQUE)
        Me.GroupBox4.Controls.Add(Me.RB_EFECTIVO)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(560, 157)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(355, 103)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forma de Pago"
        '
        'RB_CHEQUE
        '
        Me.RB_CHEQUE.AutoSize = True
        Me.RB_CHEQUE.ForeColor = System.Drawing.Color.Yellow
        Me.RB_CHEQUE.Location = New System.Drawing.Point(82, 60)
        Me.RB_CHEQUE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RB_CHEQUE.Name = "RB_CHEQUE"
        Me.RB_CHEQUE.Size = New System.Drawing.Size(87, 23)
        Me.RB_CHEQUE.TabIndex = 1
        Me.RB_CHEQUE.TabStop = True
        Me.RB_CHEQUE.Text = "Cheque"
        Me.RB_CHEQUE.UseVisualStyleBackColor = True
        '
        'RB_EFECTIVO
        '
        Me.RB_EFECTIVO.AutoSize = True
        Me.RB_EFECTIVO.Location = New System.Drawing.Point(82, 28)
        Me.RB_EFECTIVO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RB_EFECTIVO.Name = "RB_EFECTIVO"
        Me.RB_EFECTIVO.Size = New System.Drawing.Size(94, 23)
        Me.RB_EFECTIVO.TabIndex = 0
        Me.RB_EFECTIVO.TabStop = True
        Me.RB_EFECTIVO.Text = "Efectivo"
        Me.RB_EFECTIVO.UseVisualStyleBackColor = True
        '
        'DTW_DETALLES
        '
        Me.DTW_DETALLES.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DTW_DETALLES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTW_DETALLES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.DTW_DETALLES.GridColor = System.Drawing.Color.DimGray
        Me.DTW_DETALLES.Location = New System.Drawing.Point(72, 267)
        Me.DTW_DETALLES.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DTW_DETALLES.Name = "DTW_DETALLES"
        Me.DTW_DETALLES.RowTemplate.Height = 25
        Me.DTW_DETALLES.Size = New System.Drawing.Size(1159, 352)
        Me.DTW_DETALLES.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Carnet"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha de Inscripcion"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Dias"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Horas"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Idioma"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Forma de Pago "
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Total Parcial"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Descuento"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Descuento 2"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Total a Pagar"
        Me.Column11.Name = "Column11"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CheckB_SABADO)
        Me.GroupBox3.Controls.Add(Me.CheckB_VIERNES)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox3.Location = New System.Drawing.Point(949, 115)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(336, 104)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dias"
        '
        'CheckB_SABADO
        '
        Me.CheckB_SABADO.AutoSize = True
        Me.CheckB_SABADO.Location = New System.Drawing.Point(35, 66)
        Me.CheckB_SABADO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CheckB_SABADO.Name = "CheckB_SABADO"
        Me.CheckB_SABADO.Size = New System.Drawing.Size(86, 23)
        Me.CheckB_SABADO.TabIndex = 1
        Me.CheckB_SABADO.Text = "Sabado"
        Me.CheckB_SABADO.UseVisualStyleBackColor = True
        '
        'CheckB_VIERNES
        '
        Me.CheckB_VIERNES.AutoSize = True
        Me.CheckB_VIERNES.Location = New System.Drawing.Point(35, 34)
        Me.CheckB_VIERNES.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CheckB_VIERNES.Name = "CheckB_VIERNES"
        Me.CheckB_VIERNES.Size = New System.Drawing.Size(91, 23)
        Me.CheckB_VIERNES.TabIndex = 0
        Me.CheckB_VIERNES.Text = "Viernes"
        Me.CheckB_VIERNES.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CBOX_IDIOMAS)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Location = New System.Drawing.Point(560, 50)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(355, 98)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Idioma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Seleccionar"
        '
        'CBOX_IDIOMAS
        '
        Me.CBOX_IDIOMAS.FormattingEnabled = True
        Me.CBOX_IDIOMAS.Location = New System.Drawing.Point(140, 49)
        Me.CBOX_IDIOMAS.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CBOX_IDIOMAS.Name = "CBOX_IDIOMAS"
        Me.CBOX_IDIOMAS.Size = New System.Drawing.Size(188, 27)
        Me.CBOX_IDIOMAS.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DTP_FECHA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBOX_CARNET)
        Me.GroupBox1.Controls.Add(Me.TBOX_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(14, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(536, 228)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'DTP_FECHA
        '
        Me.DTP_FECHA.Location = New System.Drawing.Point(196, 153)
        Me.DTP_FECHA.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DTP_FECHA.Name = "DTP_FECHA"
        Me.DTP_FECHA.Size = New System.Drawing.Size(312, 26)
        Me.DTP_FECHA.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha de Inscripción"
        '
        'TBOX_CARNET
        '
        Me.TBOX_CARNET.Location = New System.Drawing.Point(223, 94)
        Me.TBOX_CARNET.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TBOX_CARNET.Name = "TBOX_CARNET"
        Me.TBOX_CARNET.Size = New System.Drawing.Size(244, 26)
        Me.TBOX_CARNET.TabIndex = 3
        '
        'TBOX_NOMBRE
        '
        Me.TBOX_NOMBRE.Location = New System.Drawing.Point(223, 32)
        Me.TBOX_NOMBRE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TBOX_NOMBRE.Name = "TBOX_NOMBRE"
        Me.TBOX_NOMBRE.Size = New System.Drawing.Size(244, 26)
        Me.TBOX_NOMBRE.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero de Carnet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre del Estudiante"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Cyan
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarMatrizToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1318, 25)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(62, 19)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 19)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(107, 19)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(95, 19)
        Me.LimpiarMatrizToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 19)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'INSCRIPCIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1318, 636)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DTW_DETALLES)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "INSCRIPCIONES"
        Me.Text = "INSCRIPCIONES"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DTW_DETALLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RB_CHEQUE As RadioButton
    Friend WithEvents RB_EFECTIVO As RadioButton
    Friend WithEvents DTW_DETALLES As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckB_SABADO As CheckBox
    Friend WithEvents CheckB_VIERNES As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBOX_IDIOMAS As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTP_FECHA As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TBOX_CARNET As TextBox
    Friend WithEvents TBOX_NOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
