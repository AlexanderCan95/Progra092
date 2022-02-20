Module Module1
    Sub Limpiarentradas()
        FABRICACHUMPAS.Cantidad.Clear()
        FABRICACHUMPAS.PrecioCosto.Clear()
        FABRICACHUMPAS.ManoDeObra.Clear()
        FABRICACHUMPAS.TotalSeleccionado.Clear()
        FABRICACHUMPAS.TotalAPagar.Clear()
        FABRICACHUMPAS.TamSmall.Checked = False
        FABRICACHUMPAS.TamMedium.Checked = False
        FABRICACHUMPAS.TamLarge.Checked = False
        FABRICACHUMPAS.TipAlgodon.Checked = False
        FABRICACHUMPAS.TipSeda.Checked = False
        FABRICACHUMPAS.TipLona.Checked = False
    End Sub
    Public TOTALMATERIALES As Decimal
    Public SUMA As Decimal
    Public Const ChumpaSmall = 65.5
    Public Const ChumpaMedium = 85.99
    Public Const ChumpaLarge = 99.99
    Public Const PMatAlgodon = 15.0
    Public Const PMatSeda = 23.99
    Public Const PMatLona = 30.99

End Module
