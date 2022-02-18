Public Class Form1
    Private Sub CalcularSueldo(sender As Object, e As EventArgs) Handles buttonCalcSueldo.Click
        If txtbWorkedHours.Text IsNot "" And txtbPayHour.Text IsNot "" Then


            sueldoResultadoText.Text = "$" + (Val(txtbWorkedHours.Text) * Val(txtbPayHour.Text)).ToString


            If sueldoResultadoText.Text < 100 Then
                sueldoResultadoText.ForeColor = Color.FromArgb(153, 9, 9)
            Else
                sueldoResultadoText.ForeColor = Color.FromArgb(77, 153, 0)
            End If
        Else
            sueldoResultadoText.Text = "No se encontraron datos validos"
        End If
    End Sub
End Class
