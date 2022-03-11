Public Class Form1


    Public RandomVariableGlobal As String = "test"
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

    Function BorrarDatos() As String
        cbTomate.Checked = False
        RetornarStringDeValoresActualizados(cbTomate)
        cbLechuga.Checked = False
        RetornarStringDeValoresActualizados(cbLechuga)
        cbChile.Checked = False
        RetornarStringDeValoresActualizados(cbChile)
        Return 0
    End Function

    Function AgregarDato() As Boolean
        If cbRelleno.Text = "" Then
            Return False
        End If
        If Val(txtCantidad.Text) < 1 Or txtCantidad.Text = "" Then
            Return False
        End If
        lstPedidoActual.Items.Add("[0] ----------------------------------" + RandomVariableGlobal)
        lstPedidoActual.Items.Add("Relleno Elegido: " + cbRelleno.Text + " (" + txtCantidad.Text + ")")
        If Val(txtTomate.Text) > 0 Then
            lstPedidoActual.Items.Add("Extra Tomate: " + txtTomate.Text)
        End If
        If Val(txtChile.Text) > 0 Then
            lstPedidoActual.Items.Add("Extra Jalaño: " + txtChile.Text)
        End If
        If Val(txtLechuga.Text) > 0 Then
            lstPedidoActual.Items.Add("Extra Lechuga: " + txtLechuga.Text)
        End If
        lstPedidoActual.Items.Add("[0] ----------------------------------" + RandomVariableGlobal)

        RandomVariableGlobal = RandomVariableGlobal + ",AnotherTest"

        Dim datosRetornados As String = cbRelleno.Text
        Return True
    End Function


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If AgregarDato() = False Then
            MsgBox("Faltan datos")
            Return
        End If
        MsgBox("Agregado")
        BorrarDatos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BorrarDatos()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        imgProd.BackgroundImage = Image.FromFile("C:\Users\LABJUVENTUS\Documents\PRACTICASVB\school-visual-basic\LaGorditaFeliz\LaGorditaFeliz\Resources\plogo.png")
        imgProd.BackgroundImageLayout = ImageLayout.Zoom
        lstPedidoActual.Items.Add("                     LA GORDITA FELIZ")
        lstPedidoActual.Items.Add("                     Tel: 868-000-0000")
        lstPedidoActual.Items.Add("                     RFC: GORDIS55CA1DC")
        lstPedidoActual.Items.Add("----------------------- PEDIDO ACTUAL --------------------------------------------")

        ListBox2.Items.Add("                     LA GORDITA FELIZ")
        ListBox2.Items.Add("                     Tel: 868-000-0000")
        ListBox2.Items.Add("                     RFC: GORDIS55CA1DC")
        ListBox2.Items.Add("---------------------------------------------------------------------------------")
    End Sub

    Private Sub cbTomate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbTomate.CheckedChanged
        RetornarStringDeValoresActualizados(cbTomate)
    End Sub

    Private Sub cbLechuga_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbLechuga.CheckedChanged
        RetornarStringDeValoresActualizados(cbLechuga)
    End Sub

    Private Sub cbChile_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbChile.CheckedChanged
        RetornarStringDeValoresActualizados(cbChile)
    End Sub

    Private Sub cbRelleno_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbRelleno.SelectedIndexChanged
        Select Case cbRelleno.Text
            Case "CARNITAS"
                imgProd.BackgroundImage = Image.FromFile("C:\Users\LABJUVENTUS\Documents\PRACTICASVB\school-visual-basic\LaGorditaFeliz\LaGorditaFeliz\Resources\gcarnitas.jpg")
            Case "FRIJOLES"
                imgProd.BackgroundImage = Image.FromFile("C:\Users\LABJUVENTUS\Documents\PRACTICASVB\school-visual-basic\LaGorditaFeliz\LaGorditaFeliz\Resources\gfrijoles.jpg")
            Case "MACHACADO"
                imgProd.BackgroundImage = Image.FromFile("C:\Users\LABJUVENTUS\Documents\PRACTICASVB\school-visual-basic\LaGorditaFeliz\LaGorditaFeliz\Resources\gmachacado.jpg")
            Case "HUEVO CON FRIJOLES"
                imgProd.BackgroundImage = Image.FromFile("C:\Users\LABJUVENTUS\Documents\PRACTICASVB\school-visual-basic\LaGorditaFeliz\LaGorditaFeliz\Resources\gfrijoleshuevo.jpg")
            Case "HUEVO CON JAMON"
                imgProd.BackgroundImage = Image.FromFile("C:\Users\LABJUVENTUS\Documents\PRACTICASVB\school-visual-basic\LaGorditaFeliz\LaGorditaFeliz\Resources\gjamonhuevo.jpg")
            Case "PICADILLO"
                imgProd.BackgroundImage = Image.FromFile("C:\Users\LABJUVENTUS\Documents\PRACTICASVB\school-visual-basic\LaGorditaFeliz\LaGorditaFeliz\Resources\gpicadillo.jpg")

            Case Else
                imgProd.BackgroundImage = Image.FromFile("C:\Users\LABJUVENTUS\Documents\PRACTICASVB\school-visual-basic\LaGorditaFeliz\LaGorditaFeliz\Resources\plogo.png")
        End Select
    End Sub
End Class