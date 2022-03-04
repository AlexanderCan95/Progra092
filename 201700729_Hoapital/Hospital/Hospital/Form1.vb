Public Class HOSPITAL
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PROCESO PARA COLOCAR EN EL COMBOBOX LOS ELEMENTOS QUE MOSTRARÁ
        COMBOB_THABITACION.Items.Add("Privada")
        COMBOB_THABITACION.Items.Add("Semi privada")
        COMBOB_THABITACION.Items.Add("No privada")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub LIMPLISTA_Click(sender As Object, e As EventArgs) Handles LIMPLISTA.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()
        ListBox10.Items.Clear()
    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        limpiar_entradas()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles NOMBRE.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles NIT.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles DHOSPI.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As KeyPressEventArgs) Handles HONO.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CALCULAR_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click
        If (INDICE <= 6) Then
            If (NOMBRE.Text <> "") And (NIT.Text <> "") Then
                Module1.NOMBRE(INDICE) = NOMBRE.Text + " " + NIT.Text

            Else
                MsgBox("ERROR, DATO NOMBRE  PARTICIPANTE INCORRECTO")
                NOMBRE.Focus()
                Exit Sub
            End If
            If (COMBOB_THABITACION.SelectedIndex > -1) Then
                HABITACION(INDICE) = COMBOB_THABITACION.Text
            Else
                MsgBox("ERROR, NO SELECCIONÓ CONGRESO")
                COMBOB_THABITACION.Focus()
                Exit Sub
            End If
            'SE INICIALIZA EL VECTOR DE PARCIAL PARA CALCULARLO POR CADA INGRESO QUE SE HAGA
            TOTAL(INDICE) = 0
            Select Case (COMBOB_THABITACION.SelectedIndex)
                Case 0 : HABITACIONPRIVADA()
                Case 1 : HABITACIONSEMIPRIVADA()
                Case 2 : HABITACIONNOPRIVADA()
            End Select

            descuento(INDICE) = calculardescuentorecargo()

            TOTAL_PAGO(INDICE) = totalfinal()
            muestre_totales()
            INDICE = INDICE + 1
        End If
        If INDICE = 7 Then
            MsgBox("VECTORES LLENOS")
            limpiar_entradas()
        End If
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class
