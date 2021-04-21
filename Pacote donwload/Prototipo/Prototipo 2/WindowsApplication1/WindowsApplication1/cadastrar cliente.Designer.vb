<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastrar_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrar_cliente))
        Dim Nome_ClienteLabel As System.Windows.Forms.Label
        Dim CPF_ClienteLabel As System.Windows.Forms.Label
        Dim Logradouro_clienteLabel As System.Windows.Forms.Label
        Dim Cidade_clienteLabel As System.Windows.Forms.Label
        Dim Bairro_ClienteLabel As System.Windows.Forms.Label
        Dim Estado_clienteLabel As System.Windows.Forms.Label
        Dim Tel_clienteLabel As System.Windows.Forms.Label
        Dim CEP_ClienteLabel As System.Windows.Forms.Label
        Dim Email_clienteLabel As System.Windows.Forms.Label
        Me.ClientesDataSet1 = New WindowsApplication1.clientesDataSet
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter1 = New WindowsApplication1.clientesDataSetTableAdapters.clientesTableAdapter
        Me.TableAdapterManager1 = New WindowsApplication1.clientesDataSetTableAdapters.TableAdapterManager
        Me.ClientesBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ClientesBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Nome_ClienteTextBox1 = New System.Windows.Forms.TextBox
        Me.CPF_ClienteMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.Logradouro_clienteTextBox1 = New System.Windows.Forms.TextBox
        Me.Cidade_clienteTextBox1 = New System.Windows.Forms.TextBox
        Me.Bairro_ClienteTextBox1 = New System.Windows.Forms.TextBox
        Me.Estado_clienteTextBox1 = New System.Windows.Forms.TextBox
        Me.Tel_clienteMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.CEP_ClienteMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.Email_clienteTextBox1 = New System.Windows.Forms.TextBox
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Nome_ClienteLabel = New System.Windows.Forms.Label
        CPF_ClienteLabel = New System.Windows.Forms.Label
        Logradouro_clienteLabel = New System.Windows.Forms.Label
        Cidade_clienteLabel = New System.Windows.Forms.Label
        Bairro_ClienteLabel = New System.Windows.Forms.Label
        Estado_clienteLabel = New System.Windows.Forms.Label
        Tel_clienteLabel = New System.Windows.Forms.Label
        CEP_ClienteLabel = New System.Windows.Forms.Label
        Email_clienteLabel = New System.Windows.Forms.Label
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingSource1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientesDataSet1
        '
        Me.ClientesDataSet1.DataSetName = "clientesDataSet"
        Me.ClientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "clientes"
        Me.ClientesBindingSource1.DataSource = Me.ClientesDataSet1
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.clientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.clientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesBindingSource1BindingNavigator
        '
        Me.ClientesBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.ClientesBindingSource1BindingNavigator.BindingSource = Me.ClientesBindingSource1
        Me.ClientesBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.ClientesBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.ClientesBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.ClientesBindingSource1BindingNavigatorSaveItem, Me.ToolStripSeparator4, Me.ToolStripButton7})
        Me.ClientesBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.ClientesBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.ClientesBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.ClientesBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.ClientesBindingSource1BindingNavigator.Name = "ClientesBindingSource1BindingNavigator"
        Me.ClientesBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.ClientesBindingSource1BindingNavigator.Size = New System.Drawing.Size(685, 25)
        Me.ClientesBindingSource1BindingNavigator.TabIndex = 0
        Me.ClientesBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "BindingNavigatorMoveFirstItem"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "BindingNavigatorMovePreviousItem"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "BindingNavigatorPositionItem"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "BindingNavigatorCountItem"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "BindingNavigatorMoveNextItem"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "BindingNavigatorMoveLastItem"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "BindingNavigatorAddNewItem"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Add new"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "BindingNavigatorDeleteItem"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Delete"
        '
        'ClientesBindingSource1BindingNavigatorSaveItem
        '
        Me.ClientesBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingSource1BindingNavigatorSaveItem.Name = "ClientesBindingSource1BindingNavigatorSaveItem"
        Me.ClientesBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientesBindingSource1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Nome_ClienteLabel
        '
        Nome_ClienteLabel.AutoSize = True
        Nome_ClienteLabel.Location = New System.Drawing.Point(1, 45)
        Nome_ClienteLabel.Name = "Nome_ClienteLabel"
        Nome_ClienteLabel.Size = New System.Drawing.Size(73, 13)
        Nome_ClienteLabel.TabIndex = 1
        Nome_ClienteLabel.Text = "Nome Cliente:"
        AddHandler Nome_ClienteLabel.Click, AddressOf Me.Nome_ClienteLabel_Click
        '
        'Nome_ClienteTextBox1
        '
        Me.Nome_ClienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Nome_Cliente", True))
        Me.Nome_ClienteTextBox1.Location = New System.Drawing.Point(101, 38)
        Me.Nome_ClienteTextBox1.Multiline = True
        Me.Nome_ClienteTextBox1.Name = "Nome_ClienteTextBox1"
        Me.Nome_ClienteTextBox1.Size = New System.Drawing.Size(123, 20)
        Me.Nome_ClienteTextBox1.TabIndex = 2
        '
        'CPF_ClienteLabel
        '
        CPF_ClienteLabel.AutoSize = True
        CPF_ClienteLabel.Location = New System.Drawing.Point(243, 41)
        CPF_ClienteLabel.Name = "CPF_ClienteLabel"
        CPF_ClienteLabel.Size = New System.Drawing.Size(65, 13)
        CPF_ClienteLabel.TabIndex = 3
        CPF_ClienteLabel.Text = "CPF Cliente:"
        '
        'CPF_ClienteMaskedTextBox1
        '
        Me.CPF_ClienteMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "CPF_Cliente", True))
        Me.CPF_ClienteMaskedTextBox1.Location = New System.Drawing.Point(326, 38)
        Me.CPF_ClienteMaskedTextBox1.Mask = "000.000.000-00"
        Me.CPF_ClienteMaskedTextBox1.Name = "CPF_ClienteMaskedTextBox1"
        Me.CPF_ClienteMaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CPF_ClienteMaskedTextBox1.TabIndex = 4
        '
        'Logradouro_clienteLabel
        '
        Logradouro_clienteLabel.AutoSize = True
        Logradouro_clienteLabel.Location = New System.Drawing.Point(-3, 74)
        Logradouro_clienteLabel.Name = "Logradouro_clienteLabel"
        Logradouro_clienteLabel.Size = New System.Drawing.Size(98, 13)
        Logradouro_clienteLabel.TabIndex = 5
        Logradouro_clienteLabel.Text = "Logradouro cliente:"
        '
        'Logradouro_clienteTextBox1
        '
        Me.Logradouro_clienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Logradouro_cliente", True))
        Me.Logradouro_clienteTextBox1.Location = New System.Drawing.Point(101, 71)
        Me.Logradouro_clienteTextBox1.Multiline = True
        Me.Logradouro_clienteTextBox1.Name = "Logradouro_clienteTextBox1"
        Me.Logradouro_clienteTextBox1.Size = New System.Drawing.Size(123, 20)
        Me.Logradouro_clienteTextBox1.TabIndex = 6
        '
        'Cidade_clienteLabel
        '
        Cidade_clienteLabel.AutoSize = True
        Cidade_clienteLabel.Location = New System.Drawing.Point(-3, 102)
        Cidade_clienteLabel.Name = "Cidade_clienteLabel"
        Cidade_clienteLabel.Size = New System.Drawing.Size(77, 13)
        Cidade_clienteLabel.TabIndex = 7
        Cidade_clienteLabel.Text = "Cidade cliente:"
        '
        'Cidade_clienteTextBox1
        '
        Me.Cidade_clienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Cidade_cliente", True))
        Me.Cidade_clienteTextBox1.Location = New System.Drawing.Point(101, 102)
        Me.Cidade_clienteTextBox1.Multiline = True
        Me.Cidade_clienteTextBox1.Name = "Cidade_clienteTextBox1"
        Me.Cidade_clienteTextBox1.Size = New System.Drawing.Size(123, 20)
        Me.Cidade_clienteTextBox1.TabIndex = 8
        '
        'Bairro_ClienteLabel
        '
        Bairro_ClienteLabel.AutoSize = True
        Bairro_ClienteLabel.Location = New System.Drawing.Point(243, 74)
        Bairro_ClienteLabel.Name = "Bairro_ClienteLabel"
        Bairro_ClienteLabel.Size = New System.Drawing.Size(72, 13)
        Bairro_ClienteLabel.TabIndex = 9
        Bairro_ClienteLabel.Text = "Bairro Cliente:"
        '
        'Bairro_ClienteTextBox1
        '
        Me.Bairro_ClienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Bairro_Cliente", True))
        Me.Bairro_ClienteTextBox1.Location = New System.Drawing.Point(326, 71)
        Me.Bairro_ClienteTextBox1.Multiline = True
        Me.Bairro_ClienteTextBox1.Name = "Bairro_ClienteTextBox1"
        Me.Bairro_ClienteTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Bairro_ClienteTextBox1.TabIndex = 10
        '
        'Estado_clienteLabel
        '
        Estado_clienteLabel.AutoSize = True
        Estado_clienteLabel.Location = New System.Drawing.Point(243, 109)
        Estado_clienteLabel.Name = "Estado_clienteLabel"
        Estado_clienteLabel.Size = New System.Drawing.Size(77, 13)
        Estado_clienteLabel.TabIndex = 11
        Estado_clienteLabel.Text = "Estado cliente:"
        '
        'Estado_clienteTextBox1
        '
        Me.Estado_clienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Estado_cliente", True))
        Me.Estado_clienteTextBox1.Location = New System.Drawing.Point(326, 106)
        Me.Estado_clienteTextBox1.Multiline = True
        Me.Estado_clienteTextBox1.Name = "Estado_clienteTextBox1"
        Me.Estado_clienteTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Estado_clienteTextBox1.TabIndex = 12
        '
        'Tel_clienteLabel
        '
        Tel_clienteLabel.AutoSize = True
        Tel_clienteLabel.Location = New System.Drawing.Point(454, 41)
        Tel_clienteLabel.Name = "Tel_clienteLabel"
        Tel_clienteLabel.Size = New System.Drawing.Size(59, 13)
        Tel_clienteLabel.TabIndex = 13
        Tel_clienteLabel.Text = "Tel cliente:"
        '
        'Tel_clienteMaskedTextBox1
        '
        Me.Tel_clienteMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Tel_cliente", True))
        Me.Tel_clienteMaskedTextBox1.Location = New System.Drawing.Point(526, 38)
        Me.Tel_clienteMaskedTextBox1.Mask = "(99) 0000-0000"
        Me.Tel_clienteMaskedTextBox1.Name = "Tel_clienteMaskedTextBox1"
        Me.Tel_clienteMaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Tel_clienteMaskedTextBox1.TabIndex = 14
        '
        'CEP_ClienteLabel
        '
        CEP_ClienteLabel.AutoSize = True
        CEP_ClienteLabel.Location = New System.Drawing.Point(454, 78)
        CEP_ClienteLabel.Name = "CEP_ClienteLabel"
        CEP_ClienteLabel.Size = New System.Drawing.Size(66, 13)
        CEP_ClienteLabel.TabIndex = 15
        CEP_ClienteLabel.Text = "CEP Cliente:"
        '
        'CEP_ClienteMaskedTextBox1
        '
        Me.CEP_ClienteMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "CEP_Cliente", True))
        Me.CEP_ClienteMaskedTextBox1.Location = New System.Drawing.Point(526, 75)
        Me.CEP_ClienteMaskedTextBox1.Mask = "00.000-000"
        Me.CEP_ClienteMaskedTextBox1.Name = "CEP_ClienteMaskedTextBox1"
        Me.CEP_ClienteMaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CEP_ClienteMaskedTextBox1.TabIndex = 16
        '
        'Email_clienteLabel
        '
        Email_clienteLabel.AutoSize = True
        Email_clienteLabel.Location = New System.Drawing.Point(444, 113)
        Email_clienteLabel.Name = "Email_clienteLabel"
        Email_clienteLabel.Size = New System.Drawing.Size(69, 13)
        Email_clienteLabel.TabIndex = 17
        Email_clienteLabel.Text = "Email cliente:"
        '
        'Email_clienteTextBox1
        '
        Me.Email_clienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Email_cliente", True))
        Me.Email_clienteTextBox1.Location = New System.Drawing.Point(526, 113)
        Me.Email_clienteTextBox1.Multiline = True
        Me.Email_clienteTextBox1.Name = "Email_clienteTextBox1"
        Me.Email_clienteTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Email_clienteTextBox1.TabIndex = 18
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton7.Text = "localizar"
        '
        'cadastrar_cliente
        '
        Me.ClientSize = New System.Drawing.Size(685, 156)
        Me.Controls.Add(Email_clienteLabel)
        Me.Controls.Add(Me.Email_clienteTextBox1)
        Me.Controls.Add(CEP_ClienteLabel)
        Me.Controls.Add(Me.CEP_ClienteMaskedTextBox1)
        Me.Controls.Add(Tel_clienteLabel)
        Me.Controls.Add(Me.Tel_clienteMaskedTextBox1)
        Me.Controls.Add(Estado_clienteLabel)
        Me.Controls.Add(Me.Estado_clienteTextBox1)
        Me.Controls.Add(Bairro_ClienteLabel)
        Me.Controls.Add(Me.Bairro_ClienteTextBox1)
        Me.Controls.Add(Cidade_clienteLabel)
        Me.Controls.Add(Me.Cidade_clienteTextBox1)
        Me.Controls.Add(Logradouro_clienteLabel)
        Me.Controls.Add(Me.Logradouro_clienteTextBox1)
        Me.Controls.Add(CPF_ClienteLabel)
        Me.Controls.Add(Me.CPF_ClienteMaskedTextBox1)
        Me.Controls.Add(Nome_ClienteLabel)
        Me.Controls.Add(Me.Nome_ClienteTextBox1)
        Me.Controls.Add(Me.ClientesBindingSource1BindingNavigator)
        Me.Name = "cadastrar_cliente"
        Me.Text = "cadastrar cliente"
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingSource1BindingNavigator.ResumeLayout(False)
        Me.ClientesBindingSource1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientesDataSet As WindowsApplication1.clientesDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As WindowsApplication1.clientesDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.clientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nome_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPF_ClienteMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Logradouro_clienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cidade_clienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bairro_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Estado_clienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEP_ClienteMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Email_clienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_clienteMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ClientesDataSet1 As WindowsApplication1.clientesDataSet
    Friend WithEvents ClientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter1 As WindowsApplication1.clientesDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.clientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingSource1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClientesBindingSource1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nome_ClienteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CPF_ClienteMaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Logradouro_clienteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cidade_clienteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Bairro_ClienteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Estado_clienteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Tel_clienteMaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CEP_ClienteMaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Email_clienteTextBox1 As System.Windows.Forms.TextBox
End Class
