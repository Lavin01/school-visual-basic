Public Class Form1

    Function RetornarStringDeValoresActualizados(ByVal elObjeto) As String
        If elObjeto.Checked() = True Then
            Select Case elObjeto.Text
                Case "TOMATE"
                    txtTomate.Text = "1"
                    txtTomate.ReadOnly = False
                Case "LECHUGA"
                    txtLechuga.Text = "1"
                    txtLechuga.ReadOnly = False
                Case "JALAPEÑO"
                    txtChile.Text = "1"
                    txtChile.ReadOnly = False
                Case Else
                    txtTomate.Text = elObjeto.Name
                    txtTomate.ReadOnly = False
            End Select
        Else : elObjeto.Checked() = False
            Select Case elObjeto.Text
                Case "TOMATE"
                    txtTomate.Text = "N/A"
                    txtTomate.ReadOnly = True
                Case "LECHUGA"
                    txtLechuga.Text = "N/A"
                    txtLechuga.ReadOnly = True
                Case "JALAPEÑO"
                    txtChile.Text = "N/A"
                    txtChile.ReadOnly = True
                Case Else
                    txtTomate.Text = "N/A"
                    txtTomate.ReadOnly = True
            End Select
        End If
        Return 0
    End Function

    Function DatosPedidoGordita() As String
        Dim vChile As Integer = 0
        If cbChile.Checked = True Then
            vChile = Val(txtTomate.Text)
        Else : vChile = ""
        End If

        Dim resultadoTotal As String = vChile
        Return 0
    End Function

    Function BorrarDatos() As String
        cbTomate.Checked = False
        RetornarStringDeValoresActualizados(cbTomate)
        cbLechuga.Checked = False
        RetornarStringDeValoresActualizados(cbLechuga)
        cbChile.Checked = False
        RetornarStringDeValoresActualizados(cbChile)
        Return 0
    End Function

    Function AgregarDato() As String
        RetornarStringDeValoresActualizados(cbTomate)
        RetornarStringDeValoresActualizados(cbChile)
        RetornarStringDeValoresActualizados(cbLechuga)



        Dim datosRetornados As String = cbRelleno.Text
        Return True
    End Function


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        cbRelleno.Text = AgregarDato()
        MsgBox("Si")
        RetornarStringDeValoresActualizados(cbTomate)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BorrarDatos()
    End Sub
End Class
