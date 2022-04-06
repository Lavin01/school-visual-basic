Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Dim conConexion As OleDb.OleDbConnection
    Dim cmdCommand As OleDb.OleDbCommand
    Dim FilaActual As Integer

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

    Sub pasaDatos(ByVal i As Integer)
        txtMatricula.Text = DGTabla.Rows(i).Cells(1).Value
        txtEntrada.Text = DGTabla.Rows(i).Cells(2).Value
        txtSalida.Text = DGTabla.Rows(i).Cells(3).Value

        txtUDni.Text = DGTabla.Rows(i).Cells(4).Value
        txtUPhone.Text = DGTabla.Rows(i).Cells(5).Value

        txtNServicio.Text = DGTabla.Rows(i).Cells(0).Value
    End Sub
    Sub limpiarDatos()
        txtMatricula.Text = ""
        txtEntrada.Text = ""
        txtSalida.Text = ""

        txtUDni.Text = ""
        txtUPhone.Text = ""

        txtNServicio.Text = ""
    End Sub

    Private Sub DGTabla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGTabla.CellClick
        FilaActual = DGTabla.CurrentRow.Index
        pasaDatos(FilaActual)
    End Sub

    Private Sub DGTabla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGTabla.CellContentClick
        FilaActual = DGTabla.CurrentRow.Index
        pasaDatos(FilaActual)
    End Sub

    Private Sub boton_Siguiente(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
        Try
            FilaActual += 1
            If (DGTabla.Rows(FilaActual).Cells(1).Value = "") Then
                FilaActual += 1
            End If
            pasaDatos(FilaActual)
        Catch ex As Exception
            FilaActual = 0
            pasaDatos(FilaActual)
        End Try
    End Sub

    Private Sub btnPrevio_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevio.Click
        Try
            FilaActual -= 1
            pasaDatos(FilaActual)
        Catch ex As Exception
            FilaActual = DGTabla.Rows.Count - 2
            pasaDatos(FilaActual)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        limpiarDatos()
    End Sub
End Class
