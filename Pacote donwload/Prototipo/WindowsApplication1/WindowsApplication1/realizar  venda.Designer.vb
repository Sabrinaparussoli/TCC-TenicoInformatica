<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class realizar__venda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(realizar__venda))
        Dim DetalheLabel As System.Windows.Forms.Label
        Dim DatainicialLabel As System.Windows.Forms.Label
        Dim DataentregaLabel As System.Windows.Forms.Label
        Dim DescontoLabel As System.Windows.Forms.Label
        Dim Total_pedidoLabel As System.Windows.Forms.Label
        Me.PedidoDataSet = New WindowsApplication1.pedidoDataSet
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidoTableAdapter = New WindowsApplication1.pedidoDataSetTableAdapters.pedidoTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.pedidoDataSetTableAdapters.TableAdapterManager
        Me.PedidoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.PedidoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DetalheTextBox = New System.Windows.Forms.TextBox
        Me.DatainicialMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.DataentregaMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.DescontoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Total_pedidoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        DetalheLabel = New System.Windows.Forms.Label
        DatainicialLabel = New System.Windows.Forms.Label
        DataentregaLabel = New System.Windows.Forms.Label
        DescontoLabel = New System.Windows.Forms.Label
        Total_pedidoLabel = New System.Windows.Forms.Label
        CType(Me.PedidoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PedidoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PedidoDataSet
        '
        Me.PedidoDataSet.DataSetName = "pedidoDataSet"
        Me.PedidoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidoBindingSource
        '
        Me.PedidoBindingSource.DataMember = "pedido"
        Me.PedidoBindingSource.DataSource = Me.PedidoDataSet
        '
        'PedidoTableAdapter
        '
        Me.PedidoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pedidoTableAdapter = Me.PedidoTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.pedidoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PedidoBindingNavigator
        '
        Me.PedidoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PedidoBindingNavigator.BindingSource = Me.PedidoBindingSource
        Me.PedidoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PedidoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PedidoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PedidoBindingNavigatorSaveItem})
        Me.PedidoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PedidoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PedidoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PedidoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PedidoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PedidoBindingNavigator.Name = "PedidoBindingNavigator"
        Me.PedidoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PedidoBindingNavigator.Size = New System.Drawing.Size(420, 25)
        Me.PedidoBindingNavigator.TabIndex = 0
        Me.PedidoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PedidoBindingNavigatorSaveItem
        '
        Me.PedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PedidoBindingNavigatorSaveItem.Image = CType(resources.GetObject("PedidoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PedidoBindingNavigatorSaveItem.Name = "PedidoBindingNavigatorSaveItem"
        Me.PedidoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PedidoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DetalheLabel
        '
        DetalheLabel.AutoSize = True
        DetalheLabel.Location = New System.Drawing.Point(26, 94)
        DetalheLabel.Name = "DetalheLabel"
        DetalheLabel.Size = New System.Drawing.Size(47, 13)
        DetalheLabel.TabIndex = 1
        DetalheLabel.Text = "Detalhe:"
        '
        'DetalheTextBox
        '
        Me.DetalheTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "Detalhe", True))
        Me.DetalheTextBox.Location = New System.Drawing.Point(89, 91)
        Me.DetalheTextBox.Multiline = True
        Me.DetalheTextBox.Name = "DetalheTextBox"
        Me.DetalheTextBox.Size = New System.Drawing.Size(100, 98)
        Me.DetalheTextBox.TabIndex = 2
        '
        'DatainicialLabel
        '
        DatainicialLabel.AutoSize = True
        DatainicialLabel.Location = New System.Drawing.Point(26, 51)
        DatainicialLabel.Name = "DatainicialLabel"
        DatainicialLabel.Size = New System.Drawing.Size(57, 13)
        DatainicialLabel.TabIndex = 3
        DatainicialLabel.Text = "datainicial:"
        '
        'DatainicialMaskedTextBox
        '
        Me.DatainicialMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "datainicial", True))
        Me.DatainicialMaskedTextBox.Location = New System.Drawing.Point(89, 48)
        Me.DatainicialMaskedTextBox.Mask = "00/00/0000"
        Me.DatainicialMaskedTextBox.Name = "DatainicialMaskedTextBox"
        Me.DatainicialMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DatainicialMaskedTextBox.TabIndex = 4
        Me.DatainicialMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataentregaLabel
        '
        DataentregaLabel.AutoSize = True
        DataentregaLabel.Location = New System.Drawing.Point(227, 55)
        DataentregaLabel.Name = "DataentregaLabel"
        DataentregaLabel.Size = New System.Drawing.Size(67, 13)
        DataentregaLabel.TabIndex = 5
        DataentregaLabel.Text = "dataentrega:"
        '
        'DataentregaMaskedTextBox
        '
        Me.DataentregaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "dataentrega", True))
        Me.DataentregaMaskedTextBox.Location = New System.Drawing.Point(300, 52)
        Me.DataentregaMaskedTextBox.Mask = "00/00/0000"
        Me.DataentregaMaskedTextBox.Name = "DataentregaMaskedTextBox"
        Me.DataentregaMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataentregaMaskedTextBox.TabIndex = 6
        Me.DataentregaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DescontoLabel
        '
        DescontoLabel.AutoSize = True
        DescontoLabel.Location = New System.Drawing.Point(227, 91)
        DescontoLabel.Name = "DescontoLabel"
        DescontoLabel.Size = New System.Drawing.Size(56, 13)
        DescontoLabel.TabIndex = 7
        DescontoLabel.Text = "Desconto:"
        '
        'DescontoMaskedTextBox
        '
        Me.DescontoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "Desconto", True))
        Me.DescontoMaskedTextBox.Location = New System.Drawing.Point(300, 88)
        Me.DescontoMaskedTextBox.Name = "DescontoMaskedTextBox"
        Me.DescontoMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescontoMaskedTextBox.TabIndex = 8
        '
        'Total_pedidoLabel
        '
        Total_pedidoLabel.AutoSize = True
        Total_pedidoLabel.Location = New System.Drawing.Point(227, 127)
        Total_pedidoLabel.Name = "Total_pedidoLabel"
        Total_pedidoLabel.Size = New System.Drawing.Size(69, 13)
        Total_pedidoLabel.TabIndex = 9
        Total_pedidoLabel.Text = "Total pedido:"
        '
        'Total_pedidoMaskedTextBox
        '
        Me.Total_pedidoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "Total_pedido", True))
        Me.Total_pedidoMaskedTextBox.Location = New System.Drawing.Point(302, 124)
        Me.Total_pedidoMaskedTextBox.Name = "Total_pedidoMaskedTextBox"
        Me.Total_pedidoMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_pedidoMaskedTextBox.TabIndex = 10
        '
        'realizar__venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 261)
        Me.Controls.Add(Total_pedidoLabel)
        Me.Controls.Add(Me.Total_pedidoMaskedTextBox)
        Me.Controls.Add(DescontoLabel)
        Me.Controls.Add(Me.DescontoMaskedTextBox)
        Me.Controls.Add(DataentregaLabel)
        Me.Controls.Add(Me.DataentregaMaskedTextBox)
        Me.Controls.Add(DatainicialLabel)
        Me.Controls.Add(Me.DatainicialMaskedTextBox)
        Me.Controls.Add(DetalheLabel)
        Me.Controls.Add(Me.DetalheTextBox)
        Me.Controls.Add(Me.PedidoBindingNavigator)
        Me.Name = "realizar__venda"
        Me.Text = "realizar__venda"
        CType(Me.PedidoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PedidoBindingNavigator.ResumeLayout(False)
        Me.PedidoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PedidoDataSet As WindowsApplication1.pedidoDataSet
    Friend WithEvents PedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PedidoTableAdapter As WindowsApplication1.pedidoDataSetTableAdapters.pedidoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.pedidoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PedidoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PedidoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DetalheTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatainicialMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataentregaMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DescontoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Total_pedidoMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
