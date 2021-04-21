Public Class cadastrar_funcionario

    Private Sub FuncionarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FuncionarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FuncionarioDataSet)

    End Sub

    Private Sub cadastrar_funcionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FuncionarioDataSet.funcionario' table. You can move, or remove it, as needed.
        Me.FuncionarioTableAdapter.Fill(Me.FuncionarioDataSet.funcionario)

    End Sub

    Private Sub Nome_funcionarioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nome_funcionarioTextBox.TextChanged

    End Sub

    Private Sub Nome_funcionarioLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        localizar_funcionario.Show()

    End Sub
End Class