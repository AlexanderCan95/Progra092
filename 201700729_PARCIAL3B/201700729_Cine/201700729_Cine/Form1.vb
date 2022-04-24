Imports System.Math

Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Call salir()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click

        Cine(fila, 0) = Val(TxBox_Nit.Text)
        Cine(fila, 1) = TxBox_Pelicula.Text
        Cine(fila, 2) = Val(TxBox_BNormal.Text)
        Cine(fila, 3) = Val(TxBox_B3D.Text)
        Cine(fila, 4) = Val(TxBox_B4DX.Text)

        Cine(fila, 5) = Round(Val(Cine(fila, 2) * 44) + Val(Cine(fila, 3) * 62) + Val(Cine(fila, 4) * 104), 2)
        MsgBox("Registro actualizado correctamente en la matriz")

        limpiar_entradas()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

        Dim existe As Boolean = True
        I = 0

        While (I <= 6) And (existe)
            If (Cine(I, 0) <> Nothing) Then
                If (Val(Cine(I, 0)) = Val(TxBox_Consulta.Text)) Then
                    existe = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("Nit no encontrado")
            TxBox_Consulta.Focus()
        Else
            MsgBox("Registro Encontrado exitosamente")

            TxBox_Nit.Text = Cine(I, 0)
            TxBox_Pelicula.Text = Cine(I, 1)
            TxBox_BNormal.Text = Cine(I, 2)
            TxBox_B3D.Text = Cine(I, 3)
            TxBox_B4DX.Text = Cine(I, 4)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Cine(I, 0), Cine(I, 1), Cine(I, 2), Cine(I, 3), Cine(I, 4), Cine(I, 5))

            fila = I
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_Matriz()
    End Sub


    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If ((comprobar_repetido())) Then
            If (fila <= 6) Then
                Cine(fila, 0) = TxBox_Nit.Text
                Cine(fila, 1) = TxBox_Pelicula.Text
                Cine(fila, 2) = TxBox_BNormal.Text
                Cine(fila, 3) = TxBox_B3D.Text
                Cine(fila, 4) = TxBox_B4DX.Text

                Cine(fila, 5) = Str(Round((Val(Cine(fila, 2) * 44) + Val(Cine(fila, 3) * 62) + Val(Cine(fila, 4) * 104)), 2))
                fila = fila + 1
                limpiar_entradas()
            End If
        Else
            MsgBox("Carnet repetido no se puede ingresar el dato")
            TxBox_Nit.Focus()
        End If
        If (fila = 7) Then
            MsgBox("Matriz llena")
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click

        I = 0
        While (I <= 6)
            Cine(fila, I) = Nothing
            I = I + 1
        End While

        I = fila
        While (I <= 5)

            Cine(I, 0) = Cine(I + 1, 0)
            Cine(I, 1) = Cine(I + 1, 1)
            Cine(I, 2) = Cine(I + 1, 2)
            Cine(I, 3) = Cine(I + 1, 3)
            Cine(I, 4) = Cine(I + 1, 4)
            Cine(I, 5) = Cine(I + 1, 5)

            I = I + 1
        End While
        MsgBox("Registro Eliminado exitosamente")

        Cine(I, 0) = Nothing
        Cine(I, 1) = Nothing
        Cine(I, 2) = Nothing
        Cine(I, 3) = Nothing
        Cine(I, 4) = Nothing
        Cine(I, 5) = Nothing

        fila = I

        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub
End Class
