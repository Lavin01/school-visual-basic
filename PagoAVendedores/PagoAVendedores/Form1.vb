Public Class Form1
    Dim rnd As New Random

    Function CalcularPago() As String
        If tbxCantidad.Text IsNot "" Then
            Dim resultado As Double = Val(Val(tbxCantidad.Text) * 0.2)
            Dim resultadoPagarText As String = "$" + resultado.ToString
            Return resultadoPagarText
        End If
        Return "Faltan datos"
    End Function

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbxCantidad.TextChanged
        Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        tbxResultado.Text = CalcularPago()
    End Sub


End Class