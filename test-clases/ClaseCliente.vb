Public Class ClaseCliente
    Public Codigo As Integer
    Public Deuda As Decimal

    Public Sub Comprar(importe As Decimal)
        Deuda = Deuda + importe
    End Sub

    Public Sub Pagar(importe As Decimal)
        Deuda = Deuda - importe
    End Sub
End Class
