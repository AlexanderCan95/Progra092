Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("Desea Salir", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (INDICE <= 10) Then
            NOMBRE(INDICE) = Txbox_nombre.Text
            VALOR(INDICE) = Val(Txbox_valor.Text)
            PESO(INDICE) = Val(InputBox("Ingrese Peso"))
            TIPO(INDICE) = ComboBox1.Text
            TRANS(INDICE) = ComboBox2.Text
            If TRANS(INDICE) = "Camion" Then
                If TIPO(INDICE) = "Documentos" Then
                    IMP(INDICE) = VALOR(INDICE) * DOC
                ElseIf TIPO(INDICE) = "Ropa" Then
                    IMP(INDICE) = VALOR(INDICE) * ROPA
                ElseIf TIPO(INDICE) = "Articulos pedecederos" Then
                    IMP(INDICE) = VALOR(INDICE) * P_PREC
                ElseIf TIPO(INDICE) = "Articulos plasticos" Then
                    IMP(INDICE) = VALOR(INDICE) * PLAST
                ElseIf TIPO(INDICE) = "Lociones" Then
                    IMP(INDICE) = VALOR(INDICE) * LOCIO
                End If
                PARCIAL(INDICE) = Math.Round(CAMION + IMP(INDICE), 2)

            ElseIf TRANS(INDICE) = "Motocicleta" Then
                If TIPO(INDICE) = "Documentos" Then
                    IMP(INDICE) = VALOR(INDICE) * DOC
                ElseIf TIPO(INDICE) = "Ropa" Then
                    IMP(INDICE) = VALOR(INDICE) * ROPA
                ElseIf TIPO(INDICE) = "Articulos pedecederos" Then
                    IMP(INDICE) = VALOR(INDICE) * P_PREC
                ElseIf TIPO(INDICE) = "Articulos plasticos" Then
                    IMP(INDICE) = VALOR(INDICE) * PLAST
                ElseIf TIPO(INDICE) = "Lociones" Then
                    IMP(INDICE) = VALOR(INDICE) * LOCIO
                End If
                PARCIAL(INDICE) = Math.Round(MOTO + IMP(INDICE), 2)
            End If

            TOTAL(INDICE) = Math.Round(PARCIAL(INDICE) + VALOR(INDICE), 2)

            mostrar_vectores()
            INDICE = INDICE + 1
        End If

        If (INDICE = 10) Then
            MsgBox("Vectores Llenos")
        End If
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub EstadisticosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticosToolStripMenuItem.Click
        Dim i As Byte
        Dim totlociones As Double
        Dim totdocumentos As Double
        Dim totropa As Double
        Dim totplasticos As Double
        totplasticos = 0
        totropa = 0
        totlociones = 0
        totdocumentos = 0
        For i = 0 To 10

            If (ComboBox1.Text = "Documentos") Then

                totdocumentos = totdocumentos + VALOR(i)

                If (ComboBox1.Text = "Lociones") Then
                    totlociones = totlociones + VALOR(INDICE)
                End If

                If (ComboBox1.Text = "Ropa") Then
                    totropa = totropa + 1
                End If
                If (ComboBox1.Text = "Articulos plasticos") Then
                    totplasticos = totplasticos + 1
                End If

            Else
                Exit For
            End If
        Next i
        Txbox_paque_plastico.Text = Str(totdocumentos)
        Txbox_paque_doc.Text = Str(totlociones)
        txbox_paque_locion.Text = Str(totplasticos)
        txbox_paquete_ropa.Text = Str(totropa)
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        INDICE = 0

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class
