Public Class Form1

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        lstTicket.Items.Add(txtAddItem.Text)
        txtAddItem.Text = ""
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim letterWidth As Double, x As Integer, centerListBox As Integer, maxnumLettersInListbox As Integer
        Dim numSpacesNeeded As Integer, myText As String
        letterWidth = lstTicket.Width
        centerListBox = lstTicket.Width / 2
        maxnumLettersInListbox = lstTicket.Width / letterWidth
        lstTicket.Items.Add("Hello")
        lstTicket.TopIndex = 0
        numSpacesNeeded = (maxnumLettersInListbox - Len(lstTicket.Text)) / 2
        For x = 1 To numSpacesNeeded
            myText = " " & myText
        Next x
        myText = myText & lstTicket.Text
        lstTicket.Items.Remove(0)
        lstTicket.Items.Add(myText)
        lstTicket.Items.Add("Good bye, ya'll")
    End Sub
End Class
