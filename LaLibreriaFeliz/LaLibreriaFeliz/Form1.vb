Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LibrosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles LibrosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LibrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIBRERIADataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBRERIADataSet.libros' table. You can move, or remove it, as needed.
        Me.LibrosTableAdapter.Fill(Me.LIBRERIADataSet.libros)

    End Sub
End Class
