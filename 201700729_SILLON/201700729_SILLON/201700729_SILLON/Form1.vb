Imports System.Math
Public Class Form1
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        Venta(INDICE) = Str(TXTB_VENTAS.Text)
        yardas(INDICE) = Val(Val(TXTB_YARDAS.Text))
        If RB_SOFA.Checked Then
            tamaño(INDICE) = "SOFA"
            If yardas(INDICE) >= 8 Then
                If RB_CUERO.Checked Then
                    tela(INDICE) = "CUERO"
                    COSTO(INDICE) = (Round((sofa + Val(TXTB_YARDAS.Text) * cuero), 2))
                    Total(INDICE) = (Round(COSTO(INDICE) + (Val(sofa + Val(TXTB_YARDAS.Text) * cuero) * 0.65), 2))
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(Total(INDICE)))
                    INDICE = INDICE + 1
                ElseIf RB_CUERINA.Checked Then
                    tela(INDICE) = "CUERINA"
                    COSTO(INDICE) = (Round((sofa + Val(TXTB_YARDAS.Text) * cuerina), 2))
                    Total(INDICE) = (Round(COSTO(INDICE) + (Val(sofa + Val(TXTB_YARDAS.Text) * cuerina) * 0.65), 2))
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(Total(INDICE)))
                    INDICE = INDICE + 1
                ElseIf MsgBox("SELECCIONE UNA TELA", vbQuestion + vbYesNo, "HACEN FALTAN DATOS") = vbInformation Then

                End If
            ElseIf MsgBox("FALTAN YARDAS", vbQuestion + vbYesNo, "HACEN FALTA DATOS") = vbInformation Then
            End If
        End If
        If RB_INDI.Checked Then
            tamaño(INDICE) = "INDIVIDUAL"
            If yardas(INDICE) >= 3.5 Then
                If RB_CUERO.Checked Then
                    tela(INDICE) = "CUERO"
                    COSTO(INDICE) = (Round((individual + Val(TXTB_YARDAS.Text) * cuero), 2))
                    Total(INDICE) = (Round(COSTO(INDICE) + (Val(individual + Val(TXTB_YARDAS.Text) * cuero) * 0.65), 2))
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(Total(INDICE)))
                    INDICE = INDICE + 1
                ElseIf RB_CUERINA.Checked Then
                    tela(INDICE) = "CUERINA"
                    COSTO(INDICE) = (Round((individual + Val(TXTB_YARDAS.Text) * cuerina), 2))
                    Total(INDICE) = (Round(COSTO(INDICE) + (Val(individual + Val(TXTB_YARDAS.Text) * cuerina) * 0.65), 2))
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(Total(INDICE)))
                    INDICE = INDICE + 1
                ElseIf MsgBox("SELECCIONE UNA TELA", vbQuestion + vbYesNo, "HACEN FALTA DATOS") = vbInformation Then

                End If

            ElseIf MsgBox("FALTAN YARDAS", vbQuestion + vbYesNo, "HACEN FALTA DATOS") = vbInformation Then
            End If
        End If
        If RB_DOBLE.Checked Then
            tamaño(INDICE) = "DOBLE"
            If yardas(INDICE) >= 6 Then
                If RB_CUERO.Checked Then
                    tela(INDICE) = "CUERO"
                    COSTO(INDICE) = (Round((doble + Val(TXTB_YARDAS.Text) * cuero), 2))
                    Total(INDICE) = (Round(COSTO(INDICE) + (Val(doble + Val(TXTB_YARDAS.Text) * cuero) * 0.65), 2))
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(Total(INDICE)))
                    INDICE = INDICE + 1
                ElseIf RB_CUERINA.Checked Then
                    tela(INDICE) = "CUERINA"
                    COSTO(INDICE) = (Round((doble + Val(TXTB_YARDAS.Text) * cuerina), 2))
                    Total(INDICE) = (Round(COSTO(INDICE) + (Val(doble + Val(TXTB_YARDAS.Text) * cuerina) * 0.65), 2))
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(Total(INDICE)))
                    INDICE = INDICE + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

                End If

            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If (INDICE = 8) Then
            MsgBox("VECTORES LLENOS")
        End If
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RB_CUERINA.CheckedChanged
        If RB_CUERINA.Checked Then
            TXTB_YARDAS.Enabled = True
        Else
            TXTB_YARDAS.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RB_CUERO.CheckedChanged
        If RB_CUERO.Checked Then
            TXTB_YARDAS.Enabled = True
        Else
            TXTB_YARDAS.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TXTB_YARDAS.KeyPress
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

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TXTB_VENTAS.KeyPress
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
