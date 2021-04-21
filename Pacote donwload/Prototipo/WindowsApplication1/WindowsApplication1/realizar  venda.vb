Public Class realizar__venda

    Private Sub PedidoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PedidoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PedidoDataSet)

    End Sub

    Private Sub realizar__venda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PedidoDataSet.pedido' table. You can move, or remove it, as needed.
        Me.PedidoTableAdapter.Fill(Me.PedidoDataSet.pedido)

    End Sub
End Class