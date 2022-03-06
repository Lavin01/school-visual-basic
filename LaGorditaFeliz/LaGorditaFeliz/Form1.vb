Public Class Form1

    Function ChecarCheckedExtra(ByVal cual) As String
        Dim verificar As String = cual.Checked().ToString
        Return verificar
    End Function
    Function ActualizarValoresCheked(ByVal cual) As String
        Dim verificar As String = cual.Checked().ToString
        Return verificar
    End Function

    Function RetornarStringDeValoresActualizados(ByVal elObjeto) As String
        If elObjeto.Cheked() = True Then
            Select Case elObjeto.Text
                Case "cbTomate"
                    txtTomate.ReadOnly = False
                Case "cbLechuga"
                    txtLechuga.ReadOnly = False
                Case "cbChile"
                    txtChile.ReadOnly = False
                Case Else
                    txtTomate.Text = "Else2"
                    txtTomate.ReadOnly = False
            End Select
        Else : elObjeto.Cheked = False
            Select Case elObjeto.Text
                Case "cbTomate"
                    txtTomate.Text = "N/A"
                    txtTomate.ReadOnly = True
                Case "cbLechuga"
                    txtLechuga.Text = "N/A"
                    txtLechuga.ReadOnly = True
                Case "cbChile"
                    txtChile.Text = "N/A"
                    txtChile.ReadOnly = True
                Case Else
                    txtTomate.Text = "Else"
                    txtTomate.ReadOnly = True
            End Select
        End If
        Return 0
    End Function


    Function ChecarExtras() As Integer
        If cbTomate.Checked = True Then
            txtTomate.Text = "N/A"
            txtTomate.ReadOnly = True
        Else
            txtTomate.Text = "VF"
        End If
        Dim CantidadElegida As String = Val(txtCantidad.Text)

        Label1.Text = CantidadElegida

        Dim verificarExtraChecked = ChecarCheckedExtra(cbTomate)

        Dim obj2(,) As Integer = {{"Primero", "Segundo"}, {"Fulano", "Fulana"}}

        Dim datosRetornados As String = cbRelleno.Text
        Return obj2(1, 0)
    End Function
    Function AgregarDato() As String

        Dim NombreElegida As String = cbRelleno.Text
        Dim CantidadElegida As String = Val(txtCantidad.Text)

        Dim verificarExtraChecked = ChecarCheckedExtra(cbTomate)
        Label1.Text = verificarExtraChecked

        Dim obj2(,) As String = {{"Primero", "Segundo"}, {"Fulano", "Fulana"}}

        Dim datosRetornados As String = cbRelleno.Text
        Return obj2(1, 0)
    End Function


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        cbRelleno.Text = AgregarDato()
    End Sub
End Class
