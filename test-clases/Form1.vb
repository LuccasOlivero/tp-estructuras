Public Class Form1

    Private cmpDeuda As Decimal
    Private cmpCodigo As Integer
    Private ObjCliente As New ClaseCliente

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        ObjCliente.Pagar(TextBox1.Text)
        TextBox2.Text = ObjCliente.Deuda
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        ObjCliente.Comprar(TextBox1.Text)
        TextBox2.Text = ObjCliente.Deuda
    End Sub

    Public Property Codigo As Integer
        Get
            Return cmpCodigo
        End Get
        Set(cod As Integer)
            cmpCodigo = cod
        End Set
    End Property

    Public Property Deuda As Decimal
        Get
            Return cmpDeuda
        End Get
        Set(Deu As Decimal)
            cmpDeuda = Deu
        End Set
    End Property
End Class
