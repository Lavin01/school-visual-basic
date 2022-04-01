Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Dim conConexion As OleDb.OleDbConnection
    Dim cmdCommand As OleDb.OleDbCommand

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim con As String = "Provider=Microsoft.ACE.OLED.0.12.0;Data Source=" &
            Application.StartupPath & "\rentaCoches.accdb"
        conConexion = New OleDb.OleDbConnection(con)
    End Sub
End Class
