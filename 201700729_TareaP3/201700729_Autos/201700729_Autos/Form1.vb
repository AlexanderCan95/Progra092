Imports System.Math
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxBox_Nombre.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxBox_Placa.TextChanged

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Call salir()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        I = 0

        While (I <= 6)
            Carro(fila, I) = Nothing
            I = I + 1
        End While
        I = fila
        While (I <= 5)

            Carro(I, 0) = Carro(I + 1, 0)
            Carro(I, 1) = Carro(I + 1, 1)
            Carro(I, 2) = Carro(I + 1, 2)
            Carro(I, 3) = Carro(I + 1, 3)
            Carro(I, 4) = Carro(I + 1, 4)
            Carro(I, 5) = Carro(I + 1, 5)
            Carro(I, 6) = Carro(I + 1, 6)
            I = I + 1
        End While
        MsgBox("Registro Eliminado exitosamente")

        Carro(I, 0) = Nothing
        Carro(I, 1) = Nothing
        Carro(I, 2) = Nothing
        Carro(I, 3) = Nothing
        Carro(I, 4) = Nothing
        Carro(I, 5) = Nothing
        Carro(I, 6) = Nothing

        fila = I

        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Carro(fila, 0) = Val(TxBox_Nombre.Text)
        Carro(fila, 1) = TxBox_Placa.Text
        Carro(fila, 2) = Val(TxBox_Inicial.Text)
        Carro(fila, 3) = Val(TxBox_Final.Text)


        If (RB_1.Checked) Then
            Carro(fila, 4) = RB_1.Text
            Carro(fila, 5) = 500
        ElseIf (RB_2.Checked) Then
            Carro(fila, 4) = RB_2.Text
            Carro(fila, 5) = 400
        ElseIf (RB_3.Checked) Then
            Carro(fila, 4) = RB_3.Text
            Carro(fila, 5) = 300
        ElseIf (RB_4.Checked) Then
            Carro(fila, 4) = RB_3.Text
            Carro(fila, 5) = 200
        End If

        MsgBox("Registro actualizado correctamente en la matriz")
        limpiar_entradas()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

        Dim existe As Boolean = True
        I = 0

        While (I <= 5) And (existe)

            If (Carro(I, 0) <> Nothing) Then
                If (Val(Carro(I, 1)) = Val(TxBox_Consulta.Text)) Then
                    existe = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (existe) Then
            MsgBox("Placas no encontrado")
            TxBox_Consulta.Focus()
        Else
            MsgBox("Placas Encontrado exitosamente")

            TxBox_Nombre.Text = Carro(I, 0)
            TxBox_Placa.Text = Carro(I, 1)
            TxBox_Inicial.Text = Carro(I, 2)
            TxBox_Final.Text = Carro(I, 3)

            If (Carro(I, 5) = "Tipo 1") Then
                RB_1.Checked = True
            ElseIf (Carro(I, 5) = "Tipo 2") Then
                RB_2.Checked = True
            ElseIf (Carro(I, 5) = "Tipo 3") Then
                RB_3.Checked = True
            Else : RB_4.Checked = True
            End If

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Carro(I, 0), Carro(I, 1), Carro(I, 2), Carro(I, 3), Carro(I, 4), Carro(I, 5), Carro(I, 6))
            fila = I
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_Matriz()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If ((comprobar_repetido())) Then
            If (fila <= 5) Then
                Carro(fila, 0) = TxBox_Nombre.Text
                Carro(fila, 1) = TxBox_Placa.Text
                Carro(fila, 2) = TxBox_Inicial.Text
                Carro(fila, 3) = TxBox_Final.Text

                If (RB_1.Checked) Then
                    Carro(fila, 4) = RB_1.Text
                    Carro(fila, 5) = 500
                ElseIf (RB_2.Checked) Then
                    Carro(fila, 4) = RB_2.Text
                    Carro(fila, 5) = 400
                ElseIf (RB_3.Checked) Then
                    Carro(fila, 4) = RB_3.Text
                    Carro(fila, 5) = 300
                Else : Carro(fila, 4) = RB_4.Text
                    Carro(fila, 5) = 200
                End If

                If (TxBox_Final.Text <= 50) Then
                    Carro(fila, 6) = Carro(fila, 5) * 3
                ElseIf (TxBox_Final.Text >= 50) Then
                    Carro(fila, 6) = Carro(fila, 5) * 4
                ElseIf (TxBox_Final.Text >= 71) Then
                    Carro(fila, 6) = Carro(fila, 5) * 5
                    Carro(fila, 5) = 200
                End If

                fila = fila + 1
                limpiar_entradas()
            End If
        Else
            MsgBox("Carnet repetido no se puede ingresar el dato")
            TxBox_Nombre.Focus()
        End If
        If (fila = 5) Then
            MsgBox("Matriz llena")
        End If
    End Sub
End Class
