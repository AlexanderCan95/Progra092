Module Module2
    Public Hotel(7, 6) As String
    Public X As Byte = 0
    Public i As Byte = 0
    Public personas As Integer
    Public DESC As Integer
    Sub limpiar_entradas()
        Form1.TxBox_Nit.Text = ""
        Form1.TxBox_Cliente.Text = ""
        Form1.TextBox1.Text = ""
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
    End Sub
    Sub Mostrar()
        Form1.DataGridView1.Rows.Clear()
        X = 0
        While (X <= 6)
            If (Hotel(X, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Hotel(X, 0), Hotel(X, 1), Hotel(X, 2), Hotel(X, 3), Hotel(X, 5), Hotel(X, 6))
            Else
                Exit While

            End If
            X = X + 1
        End While



    End Sub
    Sub Limpiar_Matriz()
        Form1.DataGridView1.Rows.Clear()
        i = 0
        X = 0
        While (X <= 6)
            Hotel(X, 0) = Nothing
            Hotel(X, 1) = Nothing
            Hotel(X, 2) = Nothing
            Hotel(X, 3) = Nothing
            Hotel(X, 4) = Nothing
            Hotel(X, 5) = Nothing
            Hotel(X, 6) = Nothing
            X = X + 1
        End While
    End Sub
    Sub consultar()
        Dim Hay As Boolean = True
        X = 0
        While (X <= 6) And (Hay)
            If (Hotel(X, 0) <> Nothing) Then
                If (Val(Hotel(X, 0)) = Val(Form1.TxBox_Consulta.Text)) Then
                    Hay = False
                Else
                    X = X + 1
                End If
            Else
                Exit While

            End If

        End While
        If (Hay) Then
            MsgBox("Nit no encontrado")
            Form1.TxBox_Consulta.Focus()
        Else
            MsgBox("Nit encontrado")
            Form1.DataGridView1.Rows.Clear()
            Form1.TxBox_Nit.Text = Hotel(i, 0)
            Form1.TextBox1.Text = Hotel(i, 2)
            Form1.TxBox_Cliente.Text = Hotel(i, 1)
            Form1.DataGridView1.Rows.Add(Hotel(X, 0), Hotel(X, 1), Hotel(X, 2), Hotel(X, 3), Hotel(X, 5), Hotel(X, 6))
        End If
    End Sub
End Module
