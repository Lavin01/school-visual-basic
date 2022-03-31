Public Class Form1

    Private Sub ALQUILERESBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ALQUILERESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALQUILERESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RentaCochesDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RentaCochesDataSet.DISTRIBUIDOR' table. You can move, or remove it, as needed.
        Me.DISTRIBUIDORTableAdapter.Fill(Me.RentaCochesDataSet.DISTRIBUIDOR)
        'TODO: This line of code loads data into the 'RentaCochesDataSet.FLOTA' table. You can move, or remove it, as needed.
        Me.FLOTATableAdapter.Fill(Me.RentaCochesDataSet.FLOTA)
        'TODO: This line of code loads data into the 'RentaCochesDataSet.ALQUILERES' table. You can move, or remove it, as needed.
        Me.ALQUILERESTableAdapter.Fill(Me.RentaCochesDataSet.ALQUILERES)

    End Sub

    Private Sub FLOTADataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FLOTADataGridView.CellContentClick

    End Sub
End Class
