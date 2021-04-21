Public Class cadastrar_cliente

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClientesDataSet)

    End Sub

    Private Sub cadastrar_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientesDataSet1.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter1.Fill(Me.ClientesDataSet1.clientes)
        'TODO: This line of code loads data into the 'ClientesDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.clientes)

    End Sub

    Private Sub cadastrar_cliente_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClientesBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.ClientesDataSet1)

    End Sub

    Private Sub Nome_ClienteLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        localizar.Show()
    End Sub
End Class