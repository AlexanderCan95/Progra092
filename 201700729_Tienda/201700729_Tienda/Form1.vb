Public Class FrmTienda
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim libras_de_Arroz As Integer
        Dim libras_de_Frijol As Integer
        Dim libras_de_Azucar As Integer
        Dim Precio_sin_IVA As Double
        Dim Precio_IVA As Double
        Dim Pago_con_IVA As Double
        Dim Descuento As Double
        Dim Pago_Final As Double
        Const Precio_Arroz = 2
        Const Precio_Frijol = 1.75
        Const Precio_Azucar = 2.5
        Const IVA = 0.12
        Const Descontar = 0.025

        libras_de_Arroz = TextBox1.Text
        libras_de_Frijol = TextBox2.Text
        libras_de_Azucar = TextBox3.Text

        Precio_sin_IVA = (libras_de_Arroz * Precio_Arroz) + (libras_de_Frijol * Precio_Frijol) + (libras_de_Azucar * Precio_Azucar)
        Precio_IVA = (Precio_sin_IVA * IVA)
        Pago_con_IVA = (Precio_sin_IVA + Precio_IVA)
        Descuento = (Pago_con_IVA * Descontar)
        Pago_Final = (Pago_con_IVA - Descuento)

        TextBox4.Text = Precio_sin_IVA.ToString
        TextBox5.Text = Precio_IVA.ToString
        TextBox6.Text = Pago_con_IVA.ToString
        TextBox7.Text = Descuento.ToString
        TextBox8.Text = Pago_Final.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
