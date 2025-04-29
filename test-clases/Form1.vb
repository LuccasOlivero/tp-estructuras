Public Class Form1

    Private ObjCliente As New ClaseCliente

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        ObjCliente.Pagar(TextBox1.Text)
        TextBox2.Text = ObjCliente.Deuda
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        ObjCliente.Comprar(TextBox1.Text)
        TextBox2.Text = ObjCliente.Deuda
    End Sub
End Class
