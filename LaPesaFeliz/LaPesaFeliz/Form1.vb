Public Class Form1

    Dim planInicial As Integer = 200
    Dim planMedio As Integer = 400
    Dim planAvanzado As Integer = 600

    Dim valorItems As String = ""
    Function returnValuesUpdated(ByVal elObjeto) As String
        Dim ValorActual As Double = 0
        If elObjeto.Checked() = True Then
            Select elObjeto.Name
                Case "radInicial"
                    ValorActual += planInicial
                Case "radMedio"
                    ValorActual += planMedio
                Case "radAvanzado"
                    ValorActual += planAvanzado
            End Select
        End If

        lstTicket.Items.Clear()
        Dim testArray() As String = Split(valorItems, ",")
        Dim lastNonEmpty As Integer = -1
        lstTicket.Items.Add("                     LA PESA FELIZ")
        lstTicket.Items.Add("                     Tel: 868-000-0000")
        lstTicket.Items.Add("                     RFC: GPSDCS55CA1DC")
        lstTicket.Items.Add("------------- CLIENTES REGISTRADOS ---------------------")

        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                lstTicket.Items.Add(testArray(i))
            End If
        Next
        Return ValorActual
    End Function

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        txtNoC.Text = ""
        txtName.Text = ""
        txtDireccion.Text = ""
        txtPhone.Text = ""
        txtMail.Text = ""
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstTicket.Items.Add("                     LA PESA FELIZ")
        lstTicket.Items.Add("                     Tel: 868-000-0000")
        lstTicket.Items.Add("                     RFC: GPSDCS55CA1DC")
        lstTicket.Items.Add("------------- CLIENTES REGISTRADOS ---------------------")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox(valorItems)
    End Sub

    Private Sub radInicial_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radInicial.CheckedChanged
        lblTotal.Text = returnValuesUpdated(radInicial)
    End Sub

    Private Sub radMedio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radMedio.CheckedChanged
        lblTotal.Text = returnValuesUpdated(radMedio)
    End Sub

    Private Sub radAvanzado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radAvanzado.CheckedChanged
        lblTotal.Text = returnValuesUpdated(radAvanzado)
    End Sub

    Private Sub checkedListBox_ItemCheck(sender As Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles checkedListBox.ItemCheck
        valorItems = ""
        Dim i As Integer
        Dim Valor As String
        For i = 0 To Me.checkedListBox.CheckedItems.Count - 1
            Valor = checkedListBox.CheckedItems(i)
            valorItems += Valor + ","
        Next
        returnValuesUpdated(radInicial)
    End Sub
End Class
