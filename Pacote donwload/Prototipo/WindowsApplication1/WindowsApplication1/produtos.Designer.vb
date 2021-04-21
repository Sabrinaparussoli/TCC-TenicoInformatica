<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class produtos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(produtos))
        Dim Nome_produtoLabel As System.Windows.Forms.Label
        Dim PrecoUNT_produtoLabel As System.Windows.Forms.Label
        Dim Total_produtoLabel As System.Windows.Forms.Label
        Me.ProdutosDataSet = New WindowsApplication1.produtosDataSet
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New WindowsApplication1.produtosDataSetTableAdapters.produtosTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.produtosDataSetTableAdapters.TableAdapterManager
        Me.ProdutosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProdutosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Nome_produtoTextBox = New System.Windows.Forms.TextBox
        Me.PrecoUNT_produtoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Total_produtoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Nome_produtoLabel = New System.Windows.Forms.Label
        PrecoUNT_produtoLabel = New System.Windows.Forms.Label
        Total_produtoLabel = New System.Windows.Forms.Label
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdutosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProdutosDataSet
        '
        Me.ProdutosDataSet.DataSetName = "produtosDataSet"
        Me.ProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "produtos"
        Me.ProdutosBindingSource.DataSource = Me.ProdutosDataSet
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.produtosTableAdapter = Me.ProdutosTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.produtosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProdutosBindingNavigator
        '
        Me.ProdutosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProdutosBindingNavigator.BindingSource = Me.ProdutosBindingSource
        Me.ProdutosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProdutosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProdutosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProdutosBindingNavigatorSaveItem})
        Me.ProdutosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProdutosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProdutosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProdutosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProdutosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProdutosBindingNavigator.Name = "ProdutosBindingNavigator"
        Me.ProdutosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProdutosBindingNavigator.Size = New System.Drawing.Size(304, 25)
        Me.ProdutosBindingNavigator.TabIndex = 0
        Me.ProdutosBindingNavigator.Text = "BindingNavigator1"
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
        'ProdutosBindingNavigatorSaveItem
        '
        Me.ProdutosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProdutosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProdutosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProdutosBindingNavigatorSaveItem.Name = "ProdutosBindingNavigatorSaveItem"
        Me.ProdutosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProdutosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Nome_produtoLabel
        '
        Nome_produtoLabel.AutoSize = True
        Nome_produtoLabel.Location = New System.Drawing.Point(12, 38)
        Nome_produtoLabel.Name = "Nome_produtoLabel"
        Nome_produtoLabel.Size = New System.Drawing.Size(77, 13)
        Nome_produtoLabel.TabIndex = 1
        Nome_produtoLabel.Text = "Nome produto:"
        '
        'Nome_produtoTextBox
        '
        Me.Nome_produtoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "Nome_produto", True))
        Me.Nome_produtoTextBox.Location = New System.Drawing.Point(120, 35)
        Me.Nome_produtoTextBox.Multiline = True
        Me.Nome_produtoTextBox.Name = "Nome_produtoTextBox"
        Me.Nome_produtoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nome_produtoTextBox.TabIndex = 2
        '
        'PrecoUNT_produtoLabel
        '
        PrecoUNT_produtoLabel.AutoSize = True
        PrecoUNT_produtoLabel.Location = New System.Drawing.Point(12, 72)
        PrecoUNT_produtoLabel.Name = "PrecoUNT_produtoLabel"
        PrecoUNT_produtoLabel.Size = New System.Drawing.Size(102, 13)
        PrecoUNT_produtoLabel.TabIndex = 3
        PrecoUNT_produtoLabel.Text = "preco UNT produto:"
        '
        'PrecoUNT_produtoMaskedTextBox
        '
        Me.PrecoUNT_produtoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "precoUNT_produto", True))
        Me.PrecoUNT_produtoMaskedTextBox.Location = New System.Drawing.Point(120, 69)
        Me.PrecoUNT_produtoMaskedTextBox.Name = "PrecoUNT_produtoMaskedTextBox"
        Me.PrecoUNT_produtoMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecoUNT_produtoMaskedTextBox.TabIndex = 4
        '
        'Total_produtoLabel
        '
        Total_produtoLabel.AutoSize = True
        Total_produtoLabel.Location = New System.Drawing.Point(12, 106)
        Total_produtoLabel.Name = "Total_produtoLabel"
        Total_produtoLabel.Size = New System.Drawing.Size(69, 13)
        Total_produtoLabel.TabIndex = 5
        Total_produtoLabel.Text = "total produto:"
        '
        'Total_produtoMaskedTextBox
        '
        Me.Total_produtoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "total_produto", True))
        Me.Total_produtoMaskedTextBox.Location = New System.Drawing.Point(120, 99)
        Me.Total_produtoMaskedTextBox.Name = "Total_produtoMaskedTextBox"
        Me.Total_produtoMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_produtoMaskedTextBox.TabIndex = 6
        '
        'produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 150)
        Me.Controls.Add(Total_produtoLabel)
        Me.Controls.Add(Me.Total_produtoMaskedTextBox)
        Me.Controls.Add(PrecoUNT_produtoLabel)
        Me.Controls.Add(Me.PrecoUNT_produtoMaskedTextBox)
        Me.Controls.Add(Nome_produtoLabel)
        Me.Controls.Add(Me.Nome_produtoTextBox)
        Me.Controls.Add(Me.ProdutosBindingNavigator)
        Me.Name = "produtos"
        Me.Text = "produtos"
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdutosBindingNavigator.ResumeLayout(False)
        Me.ProdutosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProdutosDataSet As WindowsApplication1.produtosDataSet
    Friend WithEvents ProdutosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdutosTableAdapter As WindowsApplication1.produtosDataSetTableAdapters.produtosTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.produtosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProdutosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProdutosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nome_produtoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecoUNT_produtoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Total_produtoMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
