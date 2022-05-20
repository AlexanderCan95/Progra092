Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (i <= 6) Then
            Hotel(i, 0) = TxBox_Nit.Text
            Hotel(i, 1) = TxBox_Cliente.Text
            Hotel(i, 2) = Val(TextBox1.Text)
            If (RadioButton1.Checked) Then
                Hotel(i, 3) = "Estandar"
                Hotel(i, 4) = 250
            ElseIf (RadioButton2.Checked) Then
                Hotel(i, 3) = "A/C"
                Hotel(i, 4) = 290
            ElseIf (RadioButton3.Checked) Then
                Hotel(i, 3) = "Jacuzzi"
                Hotel(i, 4) = 370
            Else
                MsgBox("No selecciono tipo de habitación")
                Exit Sub
            End If
            If (Val(TextBox1.Text) <= 4) Then
                Hotel(i, 5) = 0
            ElseIf (Val(TextBox1.Text >= 5)) Then
                Hotel(i, 5) = 60 * (Hotel(i, 2) - 4)
            End If
            Hotel(i, 6) = Val(Hotel(i, 4)) + Val(Hotel(i, 5))
            i = i + 1
            limpiar_entradas()
        End If
        If (i = 7) Then
            MsgBox("Error, matriz llena")
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        consultar()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_entradas()
        Limpiar_Matriz()
        DataGridView1.Rows.Clear()
    End Sub
End Class
