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
            ' MsgBox("Se conecto a la base de datos EXITOSAMENTE")
        Catch ex As Exception
            MsgBox("No se logro conectar a la base de datos", vbInformation)
        End Try

        actual()
    End Sub
    Sub actual()
        Dim sql As String = "Select * From ALQUILERES"

        consulta(DGTabla, sql)
    End Sub

    Sub consulta(ByVal Tabla As DataGridView, ByVal sql As String)
        Try
            Dim DA As New OleDbDataAdapter(sql, conConexion)
            Dim DT As New DataTable
            DA.Fill(DT)

            Tabla.DataSource = DT
        Catch ex As Exception
            MsgBox("No se logro realizar la consulta por: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        actual()
    End Sub
End Class
