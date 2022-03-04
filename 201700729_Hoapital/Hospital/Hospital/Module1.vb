Imports System.Math
Module Module1
    Public INDICE As Byte = 0

    Public NOMBRE(6) As String
    Public NIT(6) As Double
    Public DIAS(6) As Double
    Public HONORARIOS(6) As Double
    Public HABITACION(6) As String
    Public ENCAMAMIENTO(6) As Double
    Public OPERACION(6) As Double
    Public MATERNIDAD(6) As Double
    Public FORMA_PAGO(6) As String
    Public TOTAL(6) As Double
    Public descuento(6) As Double
    Public TOTAL_PAGO(6) As Double

    Public Const PRIVADA_E = 350
    Public Const SEMI_PRIVADA_E = 250
    Public Const NO_PRIVADA_E = 150
    Public Const PRIVADA_O = 550
    Public Const SEMI_PRIVADA_O = 400
    Public Const NO_PRIVADA_O = 300
    Public Const PRIVADA_M = 450
    Public Const SEMI_PRIVADA_M = 350
    Public Const NO_PRIVADA_M = 250

    Public Const efectivo = 0.15
    Public Const cheque = 0.15
    Public Const tarjeta_debito = 0.08  'recargo
    Public Const tarjeta_credito = 0.05

    Sub limpiar_entradas()
        HOSPITAL.NOMBRE.Clear()
        HOSPITAL.NIT.Clear()
        HOSPITAL.DHOSPI.Clear()
        HOSPITAL.HONO.Clear()
        HOSPITAL.CHECKB_ENCAMAMIENTO.Checked = False
        HOSPITAL.CHECKB_OPERACION.Checked = False
        HOSPITAL.CHECKB_MATERNIDAD.Checked = False
        HOSPITAL.COMBOB_THABITACION.SelectedIndex = -1
        HOSPITAL.RB_EFECTIVO.Checked = 0
        HOSPITAL.RB_CHEQUE.Checked = 0
        HOSPITAL.RB_CREDITO.Checked = 0
        HOSPITAL.RB_DEBITO.Checked = 0

        HOSPITAL.NOMBRE.Focus()
    End Sub
    Sub HABITACIONPRIVADA()
        Dim HONORARIOS As Double
        Dim DIAS As Double
        DIAS = Val(HOSPITAL.DHOSPI.Text)
        HONORARIOS = Val(HOSPITAL.HONO.Text)
        If (HOSPITAL.CHECKB_ENCAMAMIENTO.Checked) Or (HOSPITAL.CHECKB_OPERACION.Checked) Or (HOSPITAL.CHECKB_MATERNIDAD.Checked) Then
            If HOSPITAL.CHECKB_ENCAMAMIENTO.Checked Then
                ENCAMAMIENTO(INDICE) = PRIVADA_E * DIAS
            Else
                ENCAMAMIENTO(INDICE) = 0
            End If
            If HOSPITAL.CHECKB_OPERACION.Checked Then
                OPERACION(INDICE) = PRIVADA_O * DIAS
            Else
                OPERACION(INDICE) = 0
            End If
            If HOSPITAL.CHECKB_MATERNIDAD.Checked Then
                MATERNIDAD(INDICE) = PRIVADA_M * DIAS
            Else
                MATERNIDAD(INDICE) = 0
            End If
            TOTAL(INDICE) = ENCAMAMIENTO(INDICE) + OPERACION(INDICE) + MATERNIDAD(INDICE) + HONORARIOS

        Else
            MsgBox("ERROR, NO SELECCIONÓ UN SERVICIO")
            Exit Sub
        End If
    End Sub
    Sub HABITACIONSEMIPRIVADA()
        Dim HONORARIOS As Double
        Dim DIAS As Double
        DIAS = Val(HOSPITAL.DHOSPI.Text)
        HONORARIOS = Val(HOSPITAL.HONO.Text)
        If (HOSPITAL.CHECKB_ENCAMAMIENTO.Checked) Or (HOSPITAL.CHECKB_OPERACION.Checked) Or (HOSPITAL.CHECKB_MATERNIDAD.Checked) Then
            If HOSPITAL.CHECKB_ENCAMAMIENTO.Checked Then
                ENCAMAMIENTO(INDICE) = SEMI_PRIVADA_E * DIAS
            Else
                ENCAMAMIENTO(INDICE) = 0
            End If
            If HOSPITAL.CHECKB_OPERACION.Checked Then
                OPERACION(INDICE) = SEMI_PRIVADA_O * DIAS
            Else
                OPERACION(INDICE) = 0
            End If
            If HOSPITAL.CHECKB_MATERNIDAD.Checked Then
                MATERNIDAD(INDICE) = SEMI_PRIVADA_M * DIAS
            Else
                MATERNIDAD(INDICE) = 0
            End If
            TOTAL(INDICE) = ENCAMAMIENTO(INDICE) + OPERACION(INDICE) + MATERNIDAD(INDICE) + HONORARIOS
        Else
            MsgBox("ERROR, NO SELECCIONÓ UN SERVICIO")
            Exit Sub
        End If
    End Sub
    Sub HABITACIONNOPRIVADA()
        Dim HONORARIOS As Double
        Dim DIAS As Double
        DIAS = Val(HOSPITAL.DHOSPI.Text)
        HONORARIOS = Val(HOSPITAL.HONO.Text)
        If (HOSPITAL.CHECKB_ENCAMAMIENTO.Checked) Or (HOSPITAL.CHECKB_OPERACION.Checked) Or (HOSPITAL.CHECKB_MATERNIDAD.Checked) Then
            If HOSPITAL.CHECKB_ENCAMAMIENTO.Checked Then
                ENCAMAMIENTO(INDICE) = NO_PRIVADA_E * DIAS
            Else
                ENCAMAMIENTO(INDICE) = 0
            End If
            If HOSPITAL.CHECKB_OPERACION.Checked Then
                OPERACION(INDICE) = NO_PRIVADA_O * DIAS
            Else
                OPERACION(INDICE) = 0
            End If
            If HOSPITAL.CHECKB_MATERNIDAD.Checked Then
                MATERNIDAD(INDICE) = NO_PRIVADA_M * DIAS
            Else
                MATERNIDAD(INDICE) = 0
            End If
            TOTAL(INDICE) = ENCAMAMIENTO(INDICE) + OPERACION(INDICE) + MATERNIDAD(INDICE) + HONORARIOS
        Else
            MsgBox("ERROR, NO SELECCIONÓ UN SERVICIO")
            Exit Sub
        End If
    End Sub
    Function calculardescuentorecargo() As Double
        Dim desc As Double
        Dim recargo As Double

        If (HOSPITAL.RB_EFECTIVO.Checked) Then
            FORMA_PAGO(INDICE) = HOSPITAL.RB_EFECTIVO.Text
            desc = TOTAL(INDICE) * efectivo
            Return desc * -1
        ElseIf (HOSPITAL.RB_CHEQUE.Checked) Then
            FORMA_PAGO(INDICE) = HOSPITAL.RB_CHEQUE.Text
            desc = TOTAL(INDICE) * cheque
            Return desc * -1
        ElseIf (HOSPITAL.RB_CREDITO.Checked) Then
            FORMA_PAGO(INDICE) = HOSPITAL.RB_CREDITO.Text
            recargo = TOTAL(INDICE) * tarjeta_credito
            Return recargo
        ElseIf (HOSPITAL.RB_DEBITO.Checked) Then
            FORMA_PAGO(INDICE) = HOSPITAL.RB_DEBITO.Text
            desc = TOTAL(INDICE) * tarjeta_debito
            Return desc * -1

        End If
    End Function
    Function totalfinal() As Double

        totalfinal = TOTAL(INDICE) + descuento(INDICE)
        Return totalfinal
    End Function
    Sub muestre_totales()
        HOSPITAL.ListBox1.Items.Add(NOMBRE(INDICE))
        HOSPITAL.ListBox2.Items.Add(Val(HOSPITAL.DHOSPI.Text))
        HOSPITAL.ListBox3.Items.Add(Val(HOSPITAL.HONO.Text))
        HOSPITAL.ListBox4.Items.Add((HABITACION(INDICE)))
        HOSPITAL.ListBox5.Items.Add(Str(ENCAMAMIENTO(INDICE)))
        HOSPITAL.ListBox6.Items.Add(Str(OPERACION(INDICE)))
        HOSPITAL.ListBox7.Items.Add(Str(MATERNIDAD(INDICE)))
        HOSPITAL.ListBox11.Items.Add(FORMA_PAGO(INDICE))
        HOSPITAL.ListBox8.Items.Add(Str(TOTAL(INDICE)))
        HOSPITAL.ListBox9.Items.Add(Str(descuento(INDICE)))
        HOSPITAL.ListBox10.Items.Add(Str(TOTAL_PAGO(INDICE)))
    End Sub


End Module
