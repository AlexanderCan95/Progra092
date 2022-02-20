<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FABRICACHUMPAS
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TamLarge = New System.Windows.Forms.RadioButton()
        Me.TamMedium = New System.Windows.Forms.RadioButton()
        Me.TamSmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TipLona = New System.Windows.Forms.RadioButton()
        Me.TipSeda = New System.Windows.Forms.RadioButton()
        Me.TipAlgodon = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalAPagar = New System.Windows.Forms.TextBox()
        Me.TotalSeleccionado = New System.Windows.Forms.TextBox()
        Me.PrecioCosto = New System.Windows.Forms.TextBox()
        Me.ManoDeObra = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TamLarge)
        Me.GroupBox1.Controls.Add(Me.TamMedium)
        Me.GroupBox1.Controls.Add(Me.TamSmall)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño de Chumpa"
        '
        'TamLarge
        '
        Me.TamLarge.AutoSize = True
        Me.TamLarge.Location = New System.Drawing.Point(19, 115)
        Me.TamLarge.Name = "TamLarge"
        Me.TamLarge.Size = New System.Drawing.Size(54, 19)
        Me.TamLarge.TabIndex = 2
        Me.TamLarge.TabStop = True
        Me.TamLarge.Text = "Large"
        Me.TamLarge.UseVisualStyleBackColor = True
        '
        'TamMedium
        '
        Me.TamMedium.AutoSize = True
        Me.TamMedium.Location = New System.Drawing.Point(21, 67)
        Me.TamMedium.Name = "TamMedium"
        Me.TamMedium.Size = New System.Drawing.Size(70, 19)
        Me.TamMedium.TabIndex = 1
        Me.TamMedium.TabStop = True
        Me.TamMedium.Text = "Medium"
        Me.TamMedium.UseVisualStyleBackColor = True
        '
        'TamSmall
        '
        Me.TamSmall.AutoSize = True
        Me.TamSmall.Location = New System.Drawing.Point(21, 30)
        Me.TamSmall.Name = "TamSmall"
        Me.TamSmall.Size = New System.Drawing.Size(54, 19)
        Me.TamSmall.TabIndex = 0
        Me.TamSmall.TabStop = True
        Me.TamSmall.Text = "Small"
        Me.TamSmall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TipLona)
        Me.GroupBox2.Controls.Add(Me.TipSeda)
        Me.GroupBox2.Controls.Add(Me.TipAlgodon)
        Me.GroupBox2.Location = New System.Drawing.Point(276, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 177)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Tela"
        '
        'TipLona
        '
        Me.TipLona.AutoSize = True
        Me.TipLona.Location = New System.Drawing.Point(16, 121)
        Me.TipLona.Name = "TipLona"
        Me.TipLona.Size = New System.Drawing.Size(51, 19)
        Me.TipLona.TabIndex = 2
        Me.TipLona.TabStop = True
        Me.TipLona.Text = "Lona"
        Me.TipLona.UseVisualStyleBackColor = True
        '
        'TipSeda
        '
        Me.TipSeda.AutoSize = True
        Me.TipSeda.Location = New System.Drawing.Point(18, 78)
        Me.TipSeda.Name = "TipSeda"
        Me.TipSeda.Size = New System.Drawing.Size(50, 19)
        Me.TipSeda.TabIndex = 1
        Me.TipSeda.TabStop = True
        Me.TipSeda.Text = "Seda"
        Me.TipSeda.UseVisualStyleBackColor = True
        '
        'TipAlgodon
        '
        Me.TipAlgodon.AutoSize = True
        Me.TipAlgodon.Location = New System.Drawing.Point(17, 32)
        Me.TipAlgodon.Name = "TipAlgodon"
        Me.TipAlgodon.Size = New System.Drawing.Size(71, 19)
        Me.TipAlgodon.TabIndex = 0
        Me.TipAlgodon.TabStop = True
        Me.TipAlgodon.Text = "Algodón"
        Me.TipAlgodon.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Cantidad)
        Me.GroupBox3.Location = New System.Drawing.Point(509, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 97)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Numero de Chumpas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cantidad"
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(82, 48)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(152, 23)
        Me.Cantidad.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TotalAPagar)
        Me.GroupBox4.Controls.Add(Me.TotalSeleccionado)
        Me.GroupBox4.Controls.Add(Me.PrecioCosto)
        Me.GroupBox4.Controls.Add(Me.ManoDeObra)
        Me.GroupBox4.Location = New System.Drawing.Point(87, 226)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(622, 148)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total a Pagar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total de Materiales Selccionados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Precio de Costo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mano de Obra"
        '
        'TotalAPagar
        '
        Me.TotalAPagar.Location = New System.Drawing.Point(491, 99)
        Me.TotalAPagar.Name = "TotalAPagar"
        Me.TotalAPagar.Size = New System.Drawing.Size(100, 23)
        Me.TotalAPagar.TabIndex = 3
        '
        'TotalSeleccionado
        '
        Me.TotalSeleccionado.Location = New System.Drawing.Point(491, 44)
        Me.TotalSeleccionado.Name = "TotalSeleccionado"
        Me.TotalSeleccionado.Size = New System.Drawing.Size(100, 23)
        Me.TotalSeleccionado.TabIndex = 2
        '
        'PrecioCosto
        '
        Me.PrecioCosto.Location = New System.Drawing.Point(138, 99)
        Me.PrecioCosto.Name = "PrecioCosto"
        Me.PrecioCosto.Size = New System.Drawing.Size(100, 23)
        Me.PrecioCosto.TabIndex = 1
        '
        'ManoDeObra
        '
        Me.ManoDeObra.Location = New System.Drawing.Point(138, 44)
        Me.ManoDeObra.Name = "ManoDeObra"
        Me.ManoDeObra.Size = New System.Drawing.Size(100, 23)
        Me.ManoDeObra.TabIndex = 0
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(124, 402)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 4
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(363, 402)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 5
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(578, 402)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 6
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'FABRICACHUMPAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FABRICACHUMPAS"
        Me.Text = "Ventas de Chumpas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TamLarge As RadioButton
    Friend WithEvents TamMedium As RadioButton
    Friend WithEvents TamSmall As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TipLona As RadioButton
    Friend WithEvents TipSeda As RadioButton
    Friend WithEvents TipAlgodon As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cantidad As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalAPagar As TextBox
    Friend WithEvents TotalSeleccionado As TextBox
    Friend WithEvents PrecioCosto As TextBox
    Friend WithEvents ManoDeObra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
End Class
