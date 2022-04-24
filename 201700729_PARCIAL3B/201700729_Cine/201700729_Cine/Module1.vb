Module Module1
    Public Cine(7, 5) As String

    Public fila As Byte = 0

    Public I As Byte


    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True
        I = 0
        comprobar_repetido = True
        While (I <= 4) And (encontrado)
            If (Cine(I, 0) <> Nothing) Then
                If (Cine(I, 0) = Val(Form1.TxBox_Nit.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
        End If
    End Sub
    Sub limpiar_entradas()

        Form1.TxBox_Nit.Clear()
        Form1.TxBox_Pelicula.Clear()
        Form1.TxBox_Consulta.Clear()
        Form1.TxBox_BNormal.Clear()
        Form1.TxBox_B3D.Clear()
        Form1.TxBox_B4DX.Clear()
        Form1.TxBox_Nit.Focus()
    End Sub

    Sub limpiar_matriz()
        Dim J As Byte
        Form1.DataGridView1.Rows.Clear()
        fila = 0
        I = 0

        While (I <= 4)
            Cine(I, 0) = Nothing
            Cine(I, 1) = Nothing
            Cine(I, 2) = Nothing
            Cine(I, 3) = Nothing
            Cine(I, 4) = Nothing
            Cine(I, 5) = Nothing

            I = I + 1
        End While

    End Sub
    Sub Mostrar_Matriz()

        Form1.DataGridView1.Rows.Clear()
        I = 0
        While (I <= 6)
            If (Cine(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Cine(I, 0), Cine(I, 1), Cine(I, 2), Cine(I, 3), Cine(I, 4), Cine(I, 5))
            Else
                Exit While
            End If
            I = I + 1
        End While
    End Sub
End Module
