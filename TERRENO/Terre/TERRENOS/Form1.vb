Public Class Form1
    Function CalcularArea() As String
        If tbxAltura.Text IsNot "" And tbxArea.Text IsNot "" Then
            Dim resultado As Double = Val(tbxAltura.Text) * Val(tbxBase.Text) / 2
            Dim resultadoText As String = resultado.ToString + "m2"
            Return resultadoText
        End If
        Return "Faltan datos"
    End Function


    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbxBase.TextChanged
        tbxArea.Text = CalcularArea()
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbxAltura.TextChanged
        tbxArea.Text = CalcularArea()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
