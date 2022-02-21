Public Class Form1
    Function CalcularPrecioAPagar() As String
        If tbxRequerida.Text IsNot "" Then
            Dim porcentaje As Double = Val(Val(tbxRequerida.Text) + Val(Val(tbxRequerida.Text) * 5 / 100))
            Dim resultadoPagarText As String = "$" + porcentaje.ToString
            Return resultadoPagarText
        End If
        Return "Faltan datos"
    End Function

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbxRequerida.TextChanged
        tbxCantidadMasDeuda.Text = CalcularPrecioAPagar()
    End Sub
End Class
