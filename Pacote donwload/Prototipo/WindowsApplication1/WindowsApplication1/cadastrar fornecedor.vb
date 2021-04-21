Public Class cadastrar_fornecedor

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClientesDataSet)

    End Sub

    Private Sub cadastrar_fornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FabricanteDataSet.fabricante' table. You can move, or remove it, as needed.
        Me.FabricanteTableAdapter.Fill(Me.FabricanteDataSet.fabricante)
        'TODO: This line of code loads data into the 'ClientesDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.clientes)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        localizar_fornecedor.Show()

    End Sub
End Class