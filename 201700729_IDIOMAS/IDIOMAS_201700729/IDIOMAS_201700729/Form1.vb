Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
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

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Ingles")
        ComboBox1.Items.Add("Portugues")
        ComboBox1.Items.Add("Frances")
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        NOMBRE = TextBox1.Text
        CARNET = TextBox2.Text
        HORA = Val(InputBox("INGRESE CANTIDAD DE HORAS"))
        CLASES(FILA, 0) = NOMBRE
        CLASES(FILA, 1) = CARNET
        CLASES(FILA, 2) = DateTimePicker1.Value
        CLASES(FILA, 5) = ComboBox1.SelectedItem
        CLASES(FILA, 4) = HORA

        PAGO_PARCIAL = 0

        If FILA <= 9 Then
            If ComboBox1.SelectedIndex = 0 Then
                PAGO_PARCIAL = Val(HORA * P_INGLES)
                CLASES(FILA, 7) = PAGO_PARCIAL
            ElseIf ComboBox1.SelectedIndex = 1 Then
                PAGO_PARCIAL = Val(HORA * P_PORTUGUES)
                CLASES(FILA, 7) = PAGO_PARCIAL
            ElseIf ComboBox1.SelectedIndex = 2 Then
                PAGO_PARCIAL = Val(HORA * P_FRANCES)
                CLASES(FILA, 7) = PAGO_PARCIAL
            Else
                MsgBox("NO SELECCIONO UN IDIOMA")
                Exit Sub
            End If
            If (CheckBox1.Checked) And (CheckBox2.Checked) Then
                CLASES(FILA, 3) = "V & S"
                SEGUNDODESCUENTO = Val(PAGO_PARCIAL * DOSDIAS)
                CLASES(FILA, 9) = SEGUNDODESCUENTO
            ElseIf (CheckBox1.Checked) Then
                CLASES(FILA, 3) = "VIERNES"
            ElseIf (CheckBox2.Checked) Then
                CLASES(FILA, 3) = "SABADO"
            Else
                MsgBox("NO SELECCIONO EL DIA")
                Exit Sub
            End If
            If (RadioButton1.Checked) Then
                CLASES(FILA, 6) = RadioButton1.Text
                PRIMERDESCUENTO = Val(PAGO_PARCIAL * D_EFECTIVO)
                CLASES(FILA, 8) = PRIMERDESCUENTO
            ElseIf (RadioButton2.Checked) Then
                CLASES(FILA, 6) = RadioButton2.Text
                PRIMERDESCUENTO = Val(PAGO_PARCIAL * D_CHEQUE)
                CLASES(FILA, 8) = PRIMERDESCUENTO
            Else
                MsgBox("NO SELECCIONO TIPO DE PAGO")
                Exit Sub
            End If
            TOTALFINAL = Val(PAGO_PARCIAL - PRIMERDESCUENTO - SEGUNDODESCUENTO)
            CLASES(FILA, 10) = TOTALFINAL
        End If
        limpiar_entradas()
    End Sub
End Class
