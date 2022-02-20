Public Class FABRICACHUMPAS
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        Else
            Limpiarentradas()
        End If
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Limpiarentradas()
    End Sub

    Private Sub TipAlgodon_CheckedChanged(sender As Object, e As EventArgs) Handles TipAlgodon.CheckedChanged
        If (TipAlgodon.Checked) Then
            Cantidad.Visible = True
            Cantidad.Focus()
        Else
            Cantidad.Clear()
            Cantidad.Visible = False
        End If
    End Sub

    Private Sub TipSeda_CheckedChanged(sender As Object, e As EventArgs) Handles TipSeda.CheckedChanged
        If (TipSeda.Checked) Then
            Cantidad.Visible = True
            Cantidad.Focus()
        Else
            Cantidad.Clear()
            Cantidad.Visible = False
        End If
    End Sub

    Private Sub TipLona_CheckedChanged(sender As Object, e As EventArgs) Handles TipLona.CheckedChanged
        If (TipLona.Checked) Then
            Cantidad.Visible = True
            Cantidad.Focus()
        Else
            Cantidad.Clear()
            Cantidad.Visible = False
        End If
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        TOTALMATERIALES = Val(Cantidad.Text)
        If TamSmall.Checked Then
            If TOTALMATERIALES > 0 Then
                SUMA = ChumpaSmall + (Val(Cantidad.Text) * PMatAlgodon) + (Val(Cantidad.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona)
                ManoDeObra.Text = Val(ChumpaSmall) * Cantidad.Text
                TotalSeleccionado.Text = Math.Round((Val(Cantidad.Text) * PMatAlgodon) + (Val(Cantidad.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona), 2)
                PrecioCosto.Text = Math.Round(Val(SUMA) + Val(ManoDeObra.Text), 2)
                TotalAPagar.Text = Math.Round(Val(PrecioCosto.Text) * 0.65 + Val(PrecioCosto.Text), 2)
            Else
                Cantidad.Text = ""
                ManoDeObra.Text = ""
                PrecioCosto.Text = ""
                TotalAPagar.Text = ""
                TotalSeleccionado.Text = ""
                TipAlgodon.Checked = False
                TipSeda.Checked = False
                TipLona.Checked = False

                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If

        If TamMedium.Checked Then
            If TOTALMATERIALES > 0 Then
                SUMA = ChumpaMedium + (Val(Cantidad.Text) * PMatAlgodon) + (Val(Cantidad.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona)
                ManoDeObra.Text = Val(ChumpaMedium)
                TotalSeleccionado.Text = Math.Round((Val(Cantidad.Text) * PMatAlgodon) + (Val(Cantidad.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona), 2)
                PrecioCosto.Text = Math.Round(Val(SUMA) + Val(ManoDeObra.Text), 2)
                TotalAPagar.Text = Math.Round(Val(PrecioCosto.Text) * 0.65 + Val(PrecioCosto.Text), 2)
            Else
                Cantidad.Text = ""
                ManoDeObra.Text = ""
                PrecioCosto.Text = ""
                TotalAPagar.Text = ""
                TotalSeleccionado.Text = ""
                TipAlgodon.Checked = False
                TipSeda.Checked = False
                TipLona.Checked = False

                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If

        If TamLarge.Checked Then
            If TOTALMATERIALES > 0 Then
                SUMA = ChumpaLarge + (Val(Cantidad.Text) * PMatAlgodon) + (Val(Cantidad.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona)
                ManoDeObra.Text = Val(ChumpaLarge)
                TotalSeleccionado.Text = Math.Round((Val(Cantidad.Text) * PMatAlgodon) + (Val(Cantidad.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona), 2)
                PrecioCosto.Text = Math.Round(Val(SUMA) + Val(ManoDeObra.Text), 2)
                TotalAPagar.Text = Math.Round(Val(PrecioCosto.Text) * 0.65 + Val(PrecioCosto.Text), 2)
            Else
                Cantidad.Text = ""
                ManoDeObra.Text = ""
                PrecioCosto.Text = ""
                TotalAPagar.Text = ""
                TotalSeleccionado.Text = ""
                TipAlgodon.Checked = False
                TipSeda.Checked = False
                TipLona.Checked = False

                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If

    End Sub
End Class
