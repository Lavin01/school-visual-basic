Public Class Form1

    Function CalcularIMC() As String
        If tbxAltura.Text IsNot "" And tbxPeso.Text IsNot "" Then
            Dim resultado As Double = (Val(tbxAltura.Text) * Val(tbxAltura.Text)) / Val(tbxPeso.Text)
            Dim resultadoText As String = "IMC: " + resultado.ToString
            Return resultadoText
        End If
        Return "Faltan datos"
    End Function

    Private Sub tbxRender1(sender As System.Object, e As System.EventArgs) Handles tbxAltura.TextChanged
        tbxResultado.Text = CalcularIMC()
    End Sub

    Private Sub tbxRender2(sender As System.Object, e As System.EventArgs) Handles tbxPeso.TextChanged
        tbxResultado.Text = CalcularIMC()
    End Sub
End Class
