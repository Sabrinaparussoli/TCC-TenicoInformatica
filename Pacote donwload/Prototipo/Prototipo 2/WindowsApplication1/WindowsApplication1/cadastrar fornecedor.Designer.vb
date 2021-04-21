<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastrar_fornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrar_fornecedor))
        Dim Tel_fabricanteLabel As System.Windows.Forms.Label
        Dim CNPJ_fabricanteLabel As System.Windows.Forms.Label
        Dim Estado_fabricanteLabel As System.Windows.Forms.Label
        Dim Cidade_fabricanteLabel As System.Windows.Forms.Label
        Dim Logradouro_fabricanteLabel As System.Windows.Forms.Label
        Dim CEP_fabricanteLabel As System.Windows.Forms.Label
        Dim Nome_fabricanteLabel As System.Windows.Forms.Label
        Me.ClientesDataSet = New WindowsApplication1.clientesDataSet
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New WindowsApplication1.clientesDataSetTableAdapters.clientesTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.clientesDataSetTableAdapters.TableAdapterManager
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
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.Tel_fabricanteMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CNPJ_fabricanteMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Estado_fabricanteTextBox = New System.Windows.Forms.TextBox
        Me.Cidade_fabricanteTextBox = New System.Windows.Forms.TextBox
        Me.Logradouro_fabricanteTextBox = New System.Windows.Forms.TextBox
        Me.CEP_fabricanteMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Nome_fabricanteTextBox = New System.Windows.Forms.TextBox
        Tel_fabricanteLabel = New System.Windows.Forms.Label
        CNPJ_fabricanteLabel = New System.Windows.Forms.Label
        Estado_fabricanteLabel = New System.Windows.Forms.Label
        Cidade_fabricanteLabel = New System.Windows.Forms.Label
        Logradouro_fabricanteLabel = New System.Windows.Forms.Label
        CEP_fabricanteLabel = New System.Windows.Forms.Label
        Nome_fabricanteLabel = New System.Windows.Forms.Label
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientesDataSet
        '
        Me.ClientesDataSet.DataSetName = "clientesDataSet"
        Me.ClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ClientesDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.clientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(436, 25)
        Me.ClientesBindingNavigator.TabIndex = 0
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripButton1.Text = "Localizar fornecedor"
        '
        'Tel_fabricanteLabel
        '
        Tel_fabricanteLabel.AutoSize = True
        Tel_fabricanteLabel.Location = New System.Drawing.Point(32, 237)
        Tel_fabricanteLabel.Name = "Tel_fabricanteLabel"
        Tel_fabricanteLabel.Size = New System.Drawing.Size(75, 13)
        Tel_fabricanteLabel.TabIndex = 26
        Tel_fabricanteLabel.Text = "Tel fabricante:"
        '
        'Tel_fabricanteMaskedTextBox
        '
        Me.Tel_fabricanteMaskedTextBox.Location = New System.Drawing.Point(150, 230)
        Me.Tel_fabricanteMaskedTextBox.Mask = "(99) 0000-0000"
        Me.Tel_fabricanteMaskedTextBox.Name = "Tel_fabricanteMaskedTextBox"
        Me.Tel_fabricanteMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tel_fabricanteMaskedTextBox.TabIndex = 27
        '
        'CNPJ_fabricanteLabel
        '
        CNPJ_fabricanteLabel.AutoSize = True
        CNPJ_fabricanteLabel.Location = New System.Drawing.Point(32, 198)
        CNPJ_fabricanteLabel.Name = "CNPJ_fabricanteLabel"
        CNPJ_fabricanteLabel.Size = New System.Drawing.Size(87, 13)
        CNPJ_fabricanteLabel.TabIndex = 24
        CNPJ_fabricanteLabel.Text = "CNPJ fabricante:"
        '
        'CNPJ_fabricanteMaskedTextBox
        '
        Me.CNPJ_fabricanteMaskedTextBox.Location = New System.Drawing.Point(150, 195)
        Me.CNPJ_fabricanteMaskedTextBox.Mask = "000.000.000.00-00"
        Me.CNPJ_fabricanteMaskedTextBox.Name = "CNPJ_fabricanteMaskedTextBox"
        Me.CNPJ_fabricanteMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CNPJ_fabricanteMaskedTextBox.TabIndex = 25
        '
        'Estado_fabricanteLabel
        '
        Estado_fabricanteLabel.AutoSize = True
        Estado_fabricanteLabel.Location = New System.Drawing.Point(32, 163)
        Estado_fabricanteLabel.Name = "Estado_fabricanteLabel"
        Estado_fabricanteLabel.Size = New System.Drawing.Size(93, 13)
        Estado_fabricanteLabel.TabIndex = 22
        Estado_fabricanteLabel.Text = "Estado fabricante:"
        '
        'Estado_fabricanteTextBox
        '
        Me.Estado_fabricanteTextBox.Location = New System.Drawing.Point(150, 160)
        Me.Estado_fabricanteTextBox.Multiline = True
        Me.Estado_fabricanteTextBox.Name = "Estado_fabricanteTextBox"
        Me.Estado_fabricanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Estado_fabricanteTextBox.TabIndex = 23
        '
        'Cidade_fabricanteLabel
        '
        Cidade_fabricanteLabel.AutoSize = True
        Cidade_fabricanteLabel.Location = New System.Drawing.Point(32, 133)
        Cidade_fabricanteLabel.Name = "Cidade_fabricanteLabel"
        Cidade_fabricanteLabel.Size = New System.Drawing.Size(93, 13)
        Cidade_fabricanteLabel.TabIndex = 20
        Cidade_fabricanteLabel.Text = "Cidade fabricante:"
        '
        'Cidade_fabricanteTextBox
        '
        Me.Cidade_fabricanteTextBox.Location = New System.Drawing.Point(150, 126)
        Me.Cidade_fabricanteTextBox.Multiline = True
        Me.Cidade_fabricanteTextBox.Name = "Cidade_fabricanteTextBox"
        Me.Cidade_fabricanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cidade_fabricanteTextBox.TabIndex = 21
        '
        'Logradouro_fabricanteLabel
        '
        Logradouro_fabricanteLabel.AutoSize = True
        Logradouro_fabricanteLabel.Location = New System.Drawing.Point(32, 96)
        Logradouro_fabricanteLabel.Name = "Logradouro_fabricanteLabel"
        Logradouro_fabricanteLabel.Size = New System.Drawing.Size(114, 13)
        Logradouro_fabricanteLabel.TabIndex = 18
        Logradouro_fabricanteLabel.Text = "Logradouro fabricante:"
        '
        'Logradouro_fabricanteTextBox
        '
        Me.Logradouro_fabricanteTextBox.Location = New System.Drawing.Point(150, 93)
        Me.Logradouro_fabricanteTextBox.Multiline = True
        Me.Logradouro_fabricanteTextBox.Name = "Logradouro_fabricanteTextBox"
        Me.Logradouro_fabricanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Logradouro_fabricanteTextBox.TabIndex = 19
        '
        'CEP_fabricanteLabel
        '
        CEP_fabricanteLabel.AutoSize = True
        CEP_fabricanteLabel.Location = New System.Drawing.Point(32, 64)
        CEP_fabricanteLabel.Name = "CEP_fabricanteLabel"
        CEP_fabricanteLabel.Size = New System.Drawing.Size(81, 13)
        CEP_fabricanteLabel.TabIndex = 16
        CEP_fabricanteLabel.Text = "CEP fabricante:"
        '
        'CEP_fabricanteMaskedTextBox
        '
        Me.CEP_fabricanteMaskedTextBox.Location = New System.Drawing.Point(150, 64)
        Me.CEP_fabricanteMaskedTextBox.Mask = "00.000-000"
        Me.CEP_fabricanteMaskedTextBox.Name = "CEP_fabricanteMaskedTextBox"
        Me.CEP_fabricanteMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CEP_fabricanteMaskedTextBox.TabIndex = 17
        '
        'Nome_fabricanteLabel
        '
        Nome_fabricanteLabel.AutoSize = True
        Nome_fabricanteLabel.Location = New System.Drawing.Point(32, 34)
        Nome_fabricanteLabel.Name = "Nome_fabricanteLabel"
        Nome_fabricanteLabel.Size = New System.Drawing.Size(88, 13)
        Nome_fabricanteLabel.TabIndex = 14
        Nome_fabricanteLabel.Text = "Nome fabricante:"
        '
        'Nome_fabricanteTextBox
        '
        Me.Nome_fabricanteTextBox.Location = New System.Drawing.Point(150, 27)
        Me.Nome_fabricanteTextBox.Multiline = True
        Me.Nome_fabricanteTextBox.Name = "Nome_fabricanteTextBox"
        Me.Nome_fabricanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nome_fabricanteTextBox.TabIndex = 15
        '
        'cadastrar_fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 258)
        Me.Controls.Add(Tel_fabricanteLabel)
        Me.Controls.Add(Me.Tel_fabricanteMaskedTextBox)
        Me.Controls.Add(CNPJ_fabricanteLabel)
        Me.Controls.Add(Me.CNPJ_fabricanteMaskedTextBox)
        Me.Controls.Add(Estado_fabricanteLabel)
        Me.Controls.Add(Me.Estado_fabricanteTextBox)
        Me.Controls.Add(Cidade_fabricanteLabel)
        Me.Controls.Add(Me.Cidade_fabricanteTextBox)
        Me.Controls.Add(Logradouro_fabricanteLabel)
        Me.Controls.Add(Me.Logradouro_fabricanteTextBox)
        Me.Controls.Add(CEP_fabricanteLabel)
        Me.Controls.Add(Me.CEP_fabricanteMaskedTextBox)
        Me.Controls.Add(Nome_fabricanteLabel)
        Me.Controls.Add(Me.Nome_fabricanteTextBox)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Name = "cadastrar_fornecedor"
        Me.Text = "cadastrar_fornecedor"
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientesDataSet As WindowsApplication1.clientesDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As WindowsApplication1.clientesDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.clientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tel_fabricanteMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CNPJ_fabricanteMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Estado_fabricanteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cidade_fabricanteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Logradouro_fabricanteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEP_fabricanteMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Nome_fabricanteTextBox As System.Windows.Forms.TextBox
End Class
