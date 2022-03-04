<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HOSPITAL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOSPITAL))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HONO = New System.Windows.Forms.TextBox()
        Me.DHOSPI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NIT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NOMBRE = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.COMBOB_THABITACION = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CHECKB_MATERNIDAD = New System.Windows.Forms.CheckBox()
        Me.CHECKB_OPERACION = New System.Windows.Forms.CheckBox()
        Me.CHECKB_ENCAMAMIENTO = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RB_DEBITO = New System.Windows.Forms.RadioButton()
        Me.RB_CREDITO = New System.Windows.Forms.RadioButton()
        Me.RB_CHEQUE = New System.Windows.Forms.RadioButton()
        Me.RB_EFECTIVO = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ListBox11 = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBox10 = New System.Windows.Forms.ListBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CALCULAR = New System.Windows.Forms.Button()
        Me.LIMPIAR = New System.Windows.Forms.Button()
        Me.LIMPLISTA = New System.Windows.Forms.Button()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.HONO)
        Me.GroupBox1.Controls.Add(Me.DHOSPI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NIT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NOMBRE)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(15, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Honorarios"
        '
        'HONO
        '
        Me.HONO.Location = New System.Drawing.Point(210, 114)
        Me.HONO.Name = "HONO"
        Me.HONO.Size = New System.Drawing.Size(153, 29)
        Me.HONO.TabIndex = 6
        '
        'DHOSPI
        '
        Me.DHOSPI.Location = New System.Drawing.Point(210, 85)
        Me.DHOSPI.Name = "DHOSPI"
        Me.DHOSPI.Size = New System.Drawing.Size(153, 29)
        Me.DHOSPI.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(15, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dias Hospitalizado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(15, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NIT"
        '
        'NIT
        '
        Me.NIT.Location = New System.Drawing.Point(210, 56)
        Me.NIT.Name = "NIT"
        Me.NIT.Size = New System.Drawing.Size(153, 29)
        Me.NIT.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'NOMBRE
        '
        Me.NOMBRE.Location = New System.Drawing.Point(210, 27)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(153, 29)
        Me.NOMBRE.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.COMBOB_THABITACION)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(400, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 71)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Habitacion"
        '
        'COMBOB_THABITACION
        '
        Me.COMBOB_THABITACION.FormattingEnabled = True
        Me.COMBOB_THABITACION.Location = New System.Drawing.Point(41, 27)
        Me.COMBOB_THABITACION.Name = "COMBOB_THABITACION"
        Me.COMBOB_THABITACION.Size = New System.Drawing.Size(121, 29)
        Me.COMBOB_THABITACION.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CHECKB_MATERNIDAD)
        Me.GroupBox3.Controls.Add(Me.CHECKB_OPERACION)
        Me.GroupBox3.Controls.Add(Me.CHECKB_ENCAMAMIENTO)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(400, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Servicio"
        '
        'CHECKB_MATERNIDAD
        '
        Me.CHECKB_MATERNIDAD.AutoSize = True
        Me.CHECKB_MATERNIDAD.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CHECKB_MATERNIDAD.ForeColor = System.Drawing.Color.White
        Me.CHECKB_MATERNIDAD.Location = New System.Drawing.Point(24, 81)
        Me.CHECKB_MATERNIDAD.Name = "CHECKB_MATERNIDAD"
        Me.CHECKB_MATERNIDAD.Size = New System.Drawing.Size(121, 23)
        Me.CHECKB_MATERNIDAD.TabIndex = 2
        Me.CHECKB_MATERNIDAD.Text = "Maternidad"
        Me.CHECKB_MATERNIDAD.UseVisualStyleBackColor = True
        '
        'CHECKB_OPERACION
        '
        Me.CHECKB_OPERACION.AutoSize = True
        Me.CHECKB_OPERACION.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CHECKB_OPERACION.ForeColor = System.Drawing.Color.Transparent
        Me.CHECKB_OPERACION.Location = New System.Drawing.Point(24, 54)
        Me.CHECKB_OPERACION.Name = "CHECKB_OPERACION"
        Me.CHECKB_OPERACION.Size = New System.Drawing.Size(112, 23)
        Me.CHECKB_OPERACION.TabIndex = 1
        Me.CHECKB_OPERACION.Text = "Operacion"
        Me.CHECKB_OPERACION.UseVisualStyleBackColor = True
        '
        'CHECKB_ENCAMAMIENTO
        '
        Me.CHECKB_ENCAMAMIENTO.AutoSize = True
        Me.CHECKB_ENCAMAMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.CHECKB_ENCAMAMIENTO.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CHECKB_ENCAMAMIENTO.ForeColor = System.Drawing.Color.White
        Me.CHECKB_ENCAMAMIENTO.Location = New System.Drawing.Point(24, 29)
        Me.CHECKB_ENCAMAMIENTO.Name = "CHECKB_ENCAMAMIENTO"
        Me.CHECKB_ENCAMAMIENTO.Size = New System.Drawing.Size(148, 23)
        Me.CHECKB_ENCAMAMIENTO.TabIndex = 0
        Me.CHECKB_ENCAMAMIENTO.Text = "Encamamiento"
        Me.CHECKB_ENCAMAMIENTO.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.RB_DEBITO)
        Me.GroupBox4.Controls.Add(Me.RB_CREDITO)
        Me.GroupBox4.Controls.Add(Me.RB_CHEQUE)
        Me.GroupBox4.Controls.Add(Me.RB_EFECTIVO)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(648, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 168)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forma de Pago"
        '
        'RB_DEBITO
        '
        Me.RB_DEBITO.AutoSize = True
        Me.RB_DEBITO.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RB_DEBITO.Location = New System.Drawing.Point(23, 126)
        Me.RB_DEBITO.Name = "RB_DEBITO"
        Me.RB_DEBITO.Size = New System.Drawing.Size(144, 23)
        Me.RB_DEBITO.TabIndex = 3
        Me.RB_DEBITO.TabStop = True
        Me.RB_DEBITO.Text = "Tarjeta Debito"
        Me.RB_DEBITO.UseVisualStyleBackColor = True
        '
        'RB_CREDITO
        '
        Me.RB_CREDITO.AutoSize = True
        Me.RB_CREDITO.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RB_CREDITO.Location = New System.Drawing.Point(21, 96)
        Me.RB_CREDITO.Name = "RB_CREDITO"
        Me.RB_CREDITO.Size = New System.Drawing.Size(152, 23)
        Me.RB_CREDITO.TabIndex = 2
        Me.RB_CREDITO.TabStop = True
        Me.RB_CREDITO.Text = "Tarjeta Credito"
        Me.RB_CREDITO.UseVisualStyleBackColor = True
        '
        'RB_CHEQUE
        '
        Me.RB_CHEQUE.AutoSize = True
        Me.RB_CHEQUE.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RB_CHEQUE.Location = New System.Drawing.Point(22, 62)
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
        Me.RB_EFECTIVO.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RB_EFECTIVO.Location = New System.Drawing.Point(23, 33)
        Me.RB_EFECTIVO.Name = "RB_EFECTIVO"
        Me.RB_EFECTIVO.Size = New System.Drawing.Size(94, 23)
        Me.RB_EFECTIVO.TabIndex = 0
        Me.RB_EFECTIVO.TabStop = True
        Me.RB_EFECTIVO.Text = "Efectivo"
        Me.RB_EFECTIVO.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.ListBox11)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.ListBox10)
        Me.GroupBox5.Controls.Add(Me.ListBox9)
        Me.GroupBox5.Controls.Add(Me.ListBox8)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.ListBox7)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.ListBox6)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.ListBox5)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.ListBox4)
        Me.GroupBox5.Controls.Add(Me.ListBox3)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.ListBox2)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.ListBox1)
        Me.GroupBox5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(1, 216)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(995, 202)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Resultados"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(617, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 18)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Forma de Pago"
        '
        'ListBox11
        '
        Me.ListBox11.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox11.FormattingEnabled = True
        Me.ListBox11.ItemHeight = 20
        Me.ListBox11.Location = New System.Drawing.Point(622, 55)
        Me.ListBox11.Name = "ListBox11"
        Me.ListBox11.Size = New System.Drawing.Size(80, 124)
        Me.ListBox11.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(899, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 18)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Total Final"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(812, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 18)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Descuento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(732, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 18)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Total"
        '
        'ListBox10
        '
        Me.ListBox10.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox10.FormattingEnabled = True
        Me.ListBox10.ItemHeight = 20
        Me.ListBox10.Location = New System.Drawing.Point(899, 55)
        Me.ListBox10.Name = "ListBox10"
        Me.ListBox10.Size = New System.Drawing.Size(90, 124)
        Me.ListBox10.TabIndex = 16
        '
        'ListBox9
        '
        Me.ListBox9.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 20
        Me.ListBox9.Location = New System.Drawing.Point(803, 55)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(90, 124)
        Me.ListBox9.TabIndex = 15
        '
        'ListBox8
        '
        Me.ListBox8.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 20
        Me.ListBox8.Location = New System.Drawing.Point(708, 55)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(90, 124)
        Me.ListBox8.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(536, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 18)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Maternidad"
        '
        'ListBox7
        '
        Me.ListBox7.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 20
        Me.ListBox7.Location = New System.Drawing.Point(536, 55)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(80, 124)
        Me.ListBox7.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(461, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 18)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Operacion"
        '
        'ListBox6
        '
        Me.ListBox6.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 20
        Me.ListBox6.Location = New System.Drawing.Point(454, 55)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(76, 124)
        Me.ListBox6.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(291, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Habitacion"
        '
        'ListBox5
        '
        Me.ListBox5.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 20
        Me.ListBox5.Location = New System.Drawing.Point(369, 55)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(79, 124)
        Me.ListBox5.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(369, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Encamamiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(213, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Honorarios"
        '
        'ListBox4
        '
        Me.ListBox4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(286, 55)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(77, 124)
        Me.ListBox4.TabIndex = 5
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(213, 55)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(67, 124)
        Me.ListBox3.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(165, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Dias"
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(165, 55)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(42, 124)
        Me.ListBox2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(32, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nombre Y NIT"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(6, 55)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(153, 124)
        Me.ListBox1.TabIndex = 0
        '
        'CALCULAR
        '
        Me.CALCULAR.BackColor = System.Drawing.Color.Black
        Me.CALCULAR.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.CALCULAR.ForeColor = System.Drawing.Color.White
        Me.CALCULAR.Location = New System.Drawing.Point(873, 12)
        Me.CALCULAR.Name = "CALCULAR"
        Me.CALCULAR.Size = New System.Drawing.Size(89, 39)
        Me.CALCULAR.TabIndex = 4
        Me.CALCULAR.Text = "Calcular"
        Me.CALCULAR.UseVisualStyleBackColor = False
        '
        'LIMPIAR
        '
        Me.LIMPIAR.BackColor = System.Drawing.Color.Black
        Me.LIMPIAR.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LIMPIAR.ForeColor = System.Drawing.Color.White
        Me.LIMPIAR.Location = New System.Drawing.Point(873, 57)
        Me.LIMPIAR.Name = "LIMPIAR"
        Me.LIMPIAR.Size = New System.Drawing.Size(89, 39)
        Me.LIMPIAR.TabIndex = 5
        Me.LIMPIAR.Text = "Limpiar"
        Me.LIMPIAR.UseVisualStyleBackColor = False
        '
        'LIMPLISTA
        '
        Me.LIMPLISTA.BackColor = System.Drawing.Color.Black
        Me.LIMPLISTA.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LIMPLISTA.ForeColor = System.Drawing.Color.White
        Me.LIMPLISTA.Location = New System.Drawing.Point(873, 104)
        Me.LIMPLISTA.Name = "LIMPLISTA"
        Me.LIMPLISTA.Size = New System.Drawing.Size(89, 51)
        Me.LIMPLISTA.TabIndex = 6
        Me.LIMPLISTA.Text = "Limpiar Listas"
        Me.LIMPLISTA.UseVisualStyleBackColor = False
        '
        'SALIR
        '
        Me.SALIR.BackColor = System.Drawing.Color.Black
        Me.SALIR.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.SALIR.ForeColor = System.Drawing.Color.White
        Me.SALIR.Location = New System.Drawing.Point(873, 161)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(89, 39)
        Me.SALIR.TabIndex = 7
        Me.SALIR.Text = "Salir"
        Me.SALIR.UseVisualStyleBackColor = False
        '
        'HOSPITAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(999, 490)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.LIMPLISTA)
        Me.Controls.Add(Me.LIMPIAR)
        Me.Controls.Add(Me.CALCULAR)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "HOSPITAL"
        Me.ShowInTaskbar = False
        Me.Text = "Hospital"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents HONO As TextBox
    Friend WithEvents DHOSPI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NIT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NOMBRE As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents COMBOB_THABITACION As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CHECKB_MATERNIDAD As CheckBox
    Friend WithEvents CHECKB_OPERACION As CheckBox
    Friend WithEvents CHECKB_ENCAMAMIENTO As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ListBox10 As ListBox
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CALCULAR As Button
    Friend WithEvents LIMPIAR As Button
    Friend WithEvents LIMPLISTA As Button
    Friend WithEvents SALIR As Button
    Friend WithEvents RB_DEBITO As RadioButton
    Friend WithEvents RB_CREDITO As RadioButton
    Friend WithEvents RB_CHEQUE As RadioButton
    Friend WithEvents RB_EFECTIVO As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents ListBox11 As ListBox
End Class
