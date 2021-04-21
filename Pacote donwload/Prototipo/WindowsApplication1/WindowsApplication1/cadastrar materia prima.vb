Public Class cadastrar_materia_prima

    Private Sub EncomendaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EncomendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EncomendaDataSet)

    End Sub

    Private Sub cadastrar_materia_prima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Matera_primaDataSet.materia_prima' table. You can move, or remove it, as needed.
        Me.Materia_primaTableAdapter.Fill(Me.Matera_primaDataSet.materia_prima)
        'TODO: This line of code loads data into the 'EncomendaDataSet.encomenda' table. You can move, or remove it, as needed.
        Me.EncomendaTableAdapter.Fill(Me.EncomendaDataSet.encomenda)

    End Sub

    Private Sub Materia_primaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Materia_primaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Materia_primaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Matera_primaDataSet)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        localizar_mp.Show()

    End Sub
End Class