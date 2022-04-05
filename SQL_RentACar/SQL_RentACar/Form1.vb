Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Dim conConexion As OleDb.OleDbConnection
    Dim cmdCommand As OleDb.OleDbCommand

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = rentaCoches.accdb"
        conConexion = New OleDb.OleDbConnection(con)

        Try
            conConexion.Open()
            MsgBox("Se conecto a la base de datos EXITOSAMENTE")
        Catch ex As Exception
            MsgBox("No se logro conectar a la base de datos", vbInformation)
        End Try
    End Sub
End Class
