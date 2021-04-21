Public Class produtos

    Private Sub ProdutosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProdutosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProdutosDataSet)

    End Sub

    Private Sub produtos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProdutosDataSet.produtos' table. You can move, or remove it, as needed.
        Me.ProdutosTableAdapter.Fill(Me.ProdutosDataSet.produtos)

    End Sub
End Class