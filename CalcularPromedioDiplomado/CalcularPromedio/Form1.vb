Public Class Form1

    Function CalcularPromedio() As String
        If tBM1.Text IsNot "" And tBM2.Text IsNot "" And tBM3.Text IsNot "" And tBM4.Text IsNot "" And tBM5.Text IsNot "" Then
            Dim resultado As Double = Val(Val(tBM1.Text) + Val(tBM2.Text) + Val(tBM3.Text) + Val(tBM4.Text) + Val(tBM5.Text)) / 5
            Return resultado
        End If
        Return "Faltan datos"

    End Function

    Private Sub txtBox_Materia_1_TextChanged(sender As Object, e As EventArgs) Handles tBM1.TextChanged
        txtBoxResultado.Text = CalcularPromedio()
    End Sub
    Private Sub txtBox_Materia_2_TextChanged(sender As Object, e As EventArgs) Handles tBM2.TextChanged
        txtBoxResultado.Text = CalcularPromedio()
    End Sub
    Private Sub txtBox_Materia_3_TextChanged(sender As Object, e As EventArgs) Handles tBM3.TextChanged
        txtBoxResultado.Text = CalcularPromedio()
    End Sub
    Private Sub txtBox_Materia_4_TextChanged(sender As Object, e As EventArgs) Handles tBM4.TextChanged
        txtBoxResultado.Text = CalcularPromedio()
    End Sub
    Private Sub txtBox_Materia_5_TextChanged(sender As Object, e As EventArgs) Handles tBM5.TextChanged
        txtBoxResultado.Text = CalcularPromedio()
    End Sub
End Class
