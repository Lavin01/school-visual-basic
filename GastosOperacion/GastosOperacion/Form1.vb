Public Class Form1

    Function CalcularPrecioAPagar() As String
        If tbxAgua.Text IsNot "" And tbxLuz.Text IsNot "" And tbxMaterial.Text IsNot "" And tbxMObra.Text IsNot "" Then
            Dim resultado As Double = Val(Val(tbxLuz.Text) + Val(tbxAgua.Text) + Val(tbxMaterial.Text) + Val(tbxMObra.Text))
            Dim resultadoPagarText As String = "$" + resultado.ToString
            Return resultadoPagarText
        End If
        Return "Faltan datos"
    End Function

    Private Sub tbxRender1(sender As System.Object, e As System.EventArgs) Handles tbxAgua.TextChanged
        tbxTotal.Text = CalcularPrecioAPagar()
    End Sub
    Private Sub tbxRender2(sender As System.Object, e As System.EventArgs) Handles tbxLuz.TextChanged
        tbxTotal.Text = CalcularPrecioAPagar()
    End Sub
    Private Sub tbxRender3(sender As System.Object, e As System.EventArgs) Handles tbxMaterial.TextChanged
        tbxTotal.Text = CalcularPrecioAPagar()
    End Sub
    Private Sub tbxRender4(sender As System.Object, e As System.EventArgs) Handles tbxMObra.TextChanged
        tbxTotal.Text = CalcularPrecioAPagar()
    End Sub
End Class