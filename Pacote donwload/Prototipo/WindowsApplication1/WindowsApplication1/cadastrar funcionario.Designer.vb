<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastrar_funcionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrar_funcionario))
        Dim Nome_funcionarioLabel As System.Windows.Forms.Label
        Me.FuncionarioDataSet = New WindowsApplication1.funcionarioDataSet
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionarioTableAdapter = New WindowsApplication1.funcionarioDataSetTableAdapters.funcionarioTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.funcionarioDataSetTableAdapters.TableAdapterManager
        Me.FuncionarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FuncionarioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Nome_funcionarioTextBox = New System.Windows.Forms.TextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Nome_funcionarioLabel = New System.Windows.Forms.Label
        CType(Me.FuncionarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FuncionarioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'FuncionarioDataSet
        '
        Me.FuncionarioDataSet.DataSetName = "funcionarioDataSet"
        Me.FuncionarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FuncionarioBindingSource
        '
        Me.FuncionarioBindingSource.DataMember = "funcionario"
        Me.FuncionarioBindingSource.DataSource = Me.FuncionarioDataSet
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.funcionarioTableAdapter = Me.FuncionarioTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.funcionarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FuncionarioBindingNavigator
        '
        Me.FuncionarioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FuncionarioBindingNavigator.BindingSource = Me.FuncionarioBindingSource
        Me.FuncionarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FuncionarioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FuncionarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FuncionarioBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.FuncionarioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FuncionarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FuncionarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FuncionarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FuncionarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FuncionarioBindingNavigator.Name = "FuncionarioBindingNavigator"
        Me.FuncionarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FuncionarioBindingNavigator.Size = New System.Drawing.Size(442, 25)
        Me.FuncionarioBindingNavigator.TabIndex = 0
        Me.FuncionarioBindingNavigator.Text = "BindingNavigator1"
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
        'FuncionarioBindingNavigatorSaveItem
        '
        Me.FuncionarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FuncionarioBindingNavigatorSaveItem.Image = CType(resources.GetObject("FuncionarioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FuncionarioBindingNavigatorSaveItem.Name = "FuncionarioBindingNavigatorSaveItem"
        Me.FuncionarioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.FuncionarioBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Nome_funcionarioLabel
        '
        Nome_funcionarioLabel.AutoSize = True
        Nome_funcionarioLabel.Location = New System.Drawing.Point(12, 43)
        Nome_funcionarioLabel.Name = "Nome_funcionarioLabel"
        Nome_funcionarioLabel.Size = New System.Drawing.Size(93, 13)
        Nome_funcionarioLabel.TabIndex = 1
        Nome_funcionarioLabel.Text = "Nome funcionario:"
        AddHandler Nome_funcionarioLabel.Click, AddressOf Me.Nome_funcionarioLabel_Click
        '
        'Nome_funcionarioTextBox
        '
        Me.Nome_funcionarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionarioBindingSource, "Nome_funcionario", True))
        Me.Nome_funcionarioTextBox.Location = New System.Drawing.Point(111, 40)
        Me.Nome_funcionarioTextBox.Multiline = True
        Me.Nome_funcionarioTextBox.Name = "Nome_funcionarioTextBox"
        Me.Nome_funcionarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nome_funcionarioTextBox.TabIndex = 2
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
        Me.ToolStripButton1.Text = "localizar funcionario"
        '
        'cadastrar_funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 76)
        Me.Controls.Add(Nome_funcionarioLabel)
        Me.Controls.Add(Me.Nome_funcionarioTextBox)
        Me.Controls.Add(Me.FuncionarioBindingNavigator)
        Me.Name = "cadastrar_funcionario"
        Me.Text = "cadastrar_funcionario"
        CType(Me.FuncionarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FuncionarioBindingNavigator.ResumeLayout(False)
        Me.FuncionarioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FuncionarioDataSet As WindowsApplication1.funcionarioDataSet
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As WindowsApplication1.funcionarioDataSetTableAdapters.funcionarioTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.funcionarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FuncionarioBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FuncionarioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nome_funcionarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
