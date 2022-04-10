Module Module1

    Public INDICE As Byte = 0

    Public NOMBRE(10) As String
    Public VALOR(10) As Integer
    Public PESO(10) As Integer
    Public TIPO(10) As String
    Public TRANS(10) As String
    Public IMP(10) As Double
    Public PARCIAL(10) As Double
    Public TOTAL(10) As Double

    Public Const CAMION = 50
    Public Const MOTO = 15

    Public Const DOC = 0.015
    Public Const ROPA = 0.06
    Public Const P_PREC = 0.055
    Public Const PLAST = 0.045
    Public Const LOCIO = 0.02

    Sub mostrar_vectores()

        Form1.ListBox1.Items.Add(NOMBRE(INDICE))
        Form1.ListBox2.Items.Add(VALOR(INDICE))
        Form1.ListBox3.Items.Add(IMP(INDICE))
        Form1.ListBox4.Items.Add(TIPO(INDICE))
        Form1.ListBox5.Items.Add(PARCIAL(INDICE))
        Form1.ListBox6.Items.Add(TOTAL(INDICE))
    End Sub
        Sub LIMPIAR_ENTRADAS()
        Form1.Txbox_nombre.Clear()
        Form1.Txbox_valor.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.Txbox_nombre.Focus()
    End Sub

    End Module
