<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxBox_Nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxBox_Placa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxBox_Inicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxBox_Final = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_4 = New System.Windows.Forms.RadioButton()
        Me.RB_3 = New System.Windows.Forms.RadioButton()
        Me.RB_2 = New System.Windows.Forms.RadioButton()
        Me.RB_1 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxBox_Consulta = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lime
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 25)
        Me.MenuStrip1.TabIndex = 0
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
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(63, 19)
        Me.MostrarToolStripMenuItem.Text = "Mostrar "
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(73, 19)
        Me.ConsultarToolStripMenuItem.Text = "Consultar "
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 19)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 19)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 19)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 19)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TxBox_Nombre
        '
        Me.TxBox_Nombre.BackColor = System.Drawing.Color.Cyan
        Me.TxBox_Nombre.Location = New System.Drawing.Point(152, 36)
        Me.TxBox_Nombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxBox_Nombre.Name = "TxBox_Nombre"
        Me.TxBox_Nombre.Size = New System.Drawing.Size(175, 25)
        Me.TxBox_Nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numero de Placa"
        '
        'TxBox_Placa
        '
        Me.TxBox_Placa.BackColor = System.Drawing.Color.Cyan
        Me.TxBox_Placa.Location = New System.Drawing.Point(152, 71)
        Me.TxBox_Placa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxBox_Placa.Name = "TxBox_Placa"
        Me.TxBox_Placa.Size = New System.Drawing.Size(175, 25)
        Me.TxBox_Placa.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kilometraje inicial"
        '
        'TxBox_Inicial
        '
        Me.TxBox_Inicial.BackColor = System.Drawing.Color.Cyan
        Me.TxBox_Inicial.Location = New System.Drawing.Point(152, 105)
        Me.TxBox_Inicial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxBox_Inicial.Name = "TxBox_Inicial"
        Me.TxBox_Inicial.Size = New System.Drawing.Size(175, 25)
        Me.TxBox_Inicial.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kilometraje Final" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxBox_Final
        '
        Me.TxBox_Final.BackColor = System.Drawing.Color.Cyan
        Me.TxBox_Final.Location = New System.Drawing.Point(152, 140)
        Me.TxBox_Final.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxBox_Final.Name = "TxBox_Final"
        Me.TxBox_Final.Size = New System.Drawing.Size(175, 25)
        Me.TxBox_Final.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.TxBox_Inicial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxBox_Nombre)
        Me.GroupBox1.Controls.Add(Me.TxBox_Final)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxBox_Placa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 48)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(355, 194)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lime
        Me.GroupBox2.Controls.Add(Me.RB_4)
        Me.GroupBox2.Controls.Add(Me.RB_3)
        Me.GroupBox2.Controls.Add(Me.RB_2)
        Me.GroupBox2.Controls.Add(Me.RB_1)
        Me.GroupBox2.Location = New System.Drawing.Point(423, 51)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(167, 189)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RB_4
        '
        Me.RB_4.AutoSize = True
        Me.RB_4.Location = New System.Drawing.Point(41, 136)
        Me.RB_4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_4.Name = "RB_4"
        Me.RB_4.Size = New System.Drawing.Size(62, 22)
        Me.RB_4.TabIndex = 3
        Me.RB_4.TabStop = True
        Me.RB_4.Text = "Tipo 4"
        Me.RB_4.UseVisualStyleBackColor = True
        '
        'RB_3
        '
        Me.RB_3.AutoSize = True
        Me.RB_3.Location = New System.Drawing.Point(41, 102)
        Me.RB_3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_3.Name = "RB_3"
        Me.RB_3.Size = New System.Drawing.Size(62, 22)
        Me.RB_3.TabIndex = 2
        Me.RB_3.TabStop = True
        Me.RB_3.Text = "Tipo 3"
        Me.RB_3.UseVisualStyleBackColor = True
        '
        'RB_2
        '
        Me.RB_2.AutoSize = True
        Me.RB_2.Location = New System.Drawing.Point(41, 67)
        Me.RB_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_2.Name = "RB_2"
        Me.RB_2.Size = New System.Drawing.Size(62, 22)
        Me.RB_2.TabIndex = 1
        Me.RB_2.TabStop = True
        Me.RB_2.Text = "Tipo 2"
        Me.RB_2.UseVisualStyleBackColor = True
        '
        'RB_1
        '
        Me.RB_1.AutoSize = True
        Me.RB_1.Location = New System.Drawing.Point(41, 33)
        Me.RB_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_1.Name = "RB_1"
        Me.RB_1.Size = New System.Drawing.Size(62, 22)
        Me.RB_1.TabIndex = 0
        Me.RB_1.TabStop = True
        Me.RB_1.Text = "Tipo 1"
        Me.RB_1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Cyan
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 261)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(858, 204)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Numero de Placa"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Kilometraje Inicial"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Kilometraje Final"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tipo"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total a Pagar"
        Me.Column7.Name = "Column7"
        '
        'TxBox_Consulta
        '
        Me.TxBox_Consulta.BackColor = System.Drawing.Color.Cyan
        Me.TxBox_Consulta.Location = New System.Drawing.Point(125, 63)
        Me.TxBox_Consulta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxBox_Consulta.Name = "TxBox_Consulta"
        Me.TxBox_Consulta.Size = New System.Drawing.Size(159, 25)
        Me.TxBox_Consulta.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Lime
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxBox_Consulta)
        Me.GroupBox3.Location = New System.Drawing.Point(609, 63)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(291, 114)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cosulta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Numero de Placa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(914, 540)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxBox_Nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxBox_Placa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxBox_Inicial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxBox_Final As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RB_4 As RadioButton
    Friend WithEvents RB_3 As RadioButton
    Friend WithEvents RB_2 As RadioButton
    Friend WithEvents RB_1 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents TxBox_Consulta As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
End Class
