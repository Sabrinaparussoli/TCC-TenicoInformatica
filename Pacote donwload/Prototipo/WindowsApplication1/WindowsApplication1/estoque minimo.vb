Public Class estoque_minimo

    Private Sub Materia_primaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Materia_primaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Materia_primaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Matera_primaDataSet)

    End Sub

    Private Sub estoque_minimo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Matera_primaDataSet.materia_prima' table. You can move, or remove it, as needed.
        Me.Materia_primaTableAdapter.Fill(Me.Matera_primaDataSet.materia_prima)

    End Sub

    Private Sub Qtd_minimaLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class