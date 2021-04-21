Public Class solicitação_de_materia_prima

    Private Sub EncomendaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncomendaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EncomendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EncomendaDataSet)

    End Sub

    Private Sub solicitação_de_materia_prima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EncomendaDataSet.encomenda' table. You can move, or remove it, as needed.
        Me.EncomendaTableAdapter.Fill(Me.EncomendaDataSet.encomenda)

    End Sub
End Class