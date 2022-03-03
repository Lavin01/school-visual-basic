Public Class Form1

    Dim Chispas As Double = 6
    Dim Mms As Double = 8
    Dim Oreo As Double = 4
    Dim Kisses As Double = 5

    Dim Chico As Double = 10
    Dim Mediano As Double = 20
    Dim Grande As Double = 30

    Function CalcularPrecio() As String
        Dim resultado As Double = 0
        If cB1.Checked = True Then
            resultado += Val(Chispas)
        End If
        If cB2.Checked = True Then
            resultado += Val(Mms)
        End If
        If cB3.Checked = True Then
            resultado += Val(Oreo)
        End If
        If cB4.Checked = True Then
            resultado += Val(Kisses)
        End If

        If optChico.Checked = True Then
            resultado += Val(Chico)
        End If
        If optMediano.Checked = True Then
            resultado += Val(Mediano)
        End If
        If optGrande.Checked = True Then
            resultado += Val(Grande)
        End If

        Dim resultadotxt As String = "$" + resultado.ToString()
        Return resultadotxt
    End Function
    Function Completar() As String
        cB1.Checked = False
        cB2.Checked = False
        cB3.Checked = False
        cB4.Checked = False

        rTipoCono.Checked = False
        rTipoVaso.Checked = False

        optChico.Checked = False
        optMediano.Checked = False
        optGrande.Checked = False
        Return True
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cB1.CheckedChanged
        lblResultado.Text = CalcularPrecio()
    End Sub
    Private Sub CBMMs(sender As System.Object, e As System.EventArgs) Handles cB2.CheckedChanged
        lblResultado.Text = CalcularPrecio()
    End Sub
    Private Sub CBOreo(sender As System.Object, e As System.EventArgs) Handles cB3.CheckedChanged
        lblResultado.Text = CalcularPrecio()
    End Sub
    Private Sub CBKIS(sender As System.Object, e As System.EventArgs) Handles cB4.CheckedChanged
        lblResultado.Text = CalcularPrecio()
    End Sub

    Private Sub optChico_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optChico.CheckedChanged
        lblResultado.Text = CalcularPrecio()
    End Sub
    Private Sub optMedianDo(sender As System.Object, e As System.EventArgs) Handles optMediano.CheckedChanged
        lblResultado.Text = CalcularPrecio()
    End Sub
    Private Sub optGrandeD(sender As System.Object, e As System.EventArgs) Handles optGrande.CheckedChanged
        lblResultado.Text = CalcularPrecio()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If MsgBox("¿Deseas cerrar sesion?", vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        If MsgBox("¿Deseas calcular un nuevo Helado?", vbYesNo) = vbYes Then
            Completar()
        End If
    End Sub
End Class
