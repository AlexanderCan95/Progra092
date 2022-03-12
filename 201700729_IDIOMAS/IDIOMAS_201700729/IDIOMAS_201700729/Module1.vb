Imports System.Math
Module Module1
    Public NOMBRE As String
    Public CARNET As Integer
    Public IDIOMAS As String
    Public DIAS As String
    Public HORA As Integer
    Public PAGO_PARCIAL As String
    Public PAGO_TOTAL As Double
    Public PRIMERDESCUENTO As Double
    Public SEGUNDODESCUENTO As Double
    Public TOTALFINAL As Double

    Public CLASES(8, 10) As String
    Public FILA As Byte = 0

    Public Const P_INGLES = 150
    Public Const P_PORTUGUES = 80
    Public Const P_FRANCES = 125

    Public Const D_EFECTIVO = 0.02
    Public Const D_CHEQUE = 0.015
    Public Const DOSDIAS = 0.05

    Sub limpiar_matriz()
        Dim i As Byte, j As Byte
        For i = 0 To 8
            For j = 0 To 10
                CLASES(i, j) = Nothing
            Next j
        Next i
        INSCRIPCIONES.DTW_DETALLES.Rows.Clear()
        FILA = 0
    End Sub
    Sub limpiar_entradas()
        INSCRIPCIONES.TBOX_CARNET.Text = ""
        INSCRIPCIONES.TBOX_NOMBRE.Text = ""

        INSCRIPCIONES.CheckB_VIERNES.Checked = False
        INSCRIPCIONES.CheckB_SABADO.Checked = False

        INSCRIPCIONES.CBOX_IDIOMAS.Text = "SELECCIONE UN IDIOMA"

        INSCRIPCIONES.RB_EFECTIVO.Checked = False
        INSCRIPCIONES.RB_CHEQUE.Checked = False
    End Sub
    Sub Mostrar()

        For FILA = 0 To 8
            If CLASES(FILA, 0) <> Nothing Then
                INSCRIPCIONES.DTW_DETALLES.Rows.Add(CLASES(FILA, 0), CLASES(FILA, 1), CLASES(FILA, 2), CLASES(FILA, 3), CLASES(FILA, 4), CLASES(FILA, 5), CLASES(FILA, 6), CLASES(FILA, 7), CLASES(FILA, 8), CLASES(FILA, 9), CLASES(FILA, 10))
            Else
                Exit For
            End If
        Next FILA
    End Sub

End Module
