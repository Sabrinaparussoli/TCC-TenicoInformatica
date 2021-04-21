Public Class localizar_funcionario

    Private Sub FuncionarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FuncionarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FuncionarioDataSet)

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class