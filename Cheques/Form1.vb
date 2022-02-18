Public Class Form1
    Function CalcularDineroTotal() As String
        If cantidadCheque.Text IsNot "" And cantidadComision.Text IsNot "" Then
            Dim resultado As Double = Val((Val(cantidadCheque.Text)) - Val(cantidadComision.Text * (cantidadCheque.Text / 100)))
            Return resultado
        End If
        Return "Faltan datos"

    End Function

    Function CalcularDineroComision() As String
        If cantidadCheque.Text IsNot "" And cantidadComision.Text IsNot "" Then
            Dim resultado As Double = Val(cantidadComision.Text * (cantidadCheque.Text / 100))
            Return resultado
        End If
        Return "Faltan datos"

    End Function
    Private Sub txtBox_Materia_1_TextChanged(sender As Object, e As EventArgs) Handles cantidadCheque.TextChanged
        tBXResultado.Text = CalcularDineroTotal()
        dineroComision.Text = CalcularDineroComision()
    End Sub

    Private Sub txtBox_Materia_2_TextChanged(sender As Object, e As EventArgs) Handles cantidadComision.TextChanged
        tBXResultado.Text = CalcularDineroTotal()
        dineroComision.Text = CalcularDineroComision()
    End Sub
End Class
