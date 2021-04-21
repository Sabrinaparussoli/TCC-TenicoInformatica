<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estoque_minimo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(estoque_minimo))
        Dim Nome_MPLabel As System.Windows.Forms.Label
        Dim Qtd_MPLabel As System.Windows.Forms.Label
        Dim Qtd_minimaLabel As System.Windows.Forms.Label
        Me.Matera_primaDataSet = New WindowsApplication1.matera_primaDataSet
        Me.Materia_primaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Materia_primaTableAdapter = New WindowsApplication1.matera_primaDataSetTableAdapters.materia_primaTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.matera_primaDataSetTableAdapters.TableAdapterManager
        Me.Materia_primaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Materia_primaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Nome_MPLabel = New System.Windows.Forms.Label
        Qtd_MPLabel = New System.Windows.Forms.Label
        Qtd_minimaLabel = New System.Windows.Forms.Label
        CType(Me.Matera_primaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Materia_primaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Materia_primaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Materia_primaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Matera_primaDataSet
        '
        Me.Matera_primaDataSet.DataSetName = "matera_primaDataSet"
        Me.Matera_primaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Materia_primaBindingSource
        '
        Me.Materia_primaBindingSource.DataMember = "materia prima"
        Me.Materia_primaBindingSource.DataSource = Me.Matera_primaDataSet
        '
        'Materia_primaTableAdapter
        '
        Me.Materia_primaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.materia_primaTableAdapter = Me.Materia_primaTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.matera_primaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Materia_primaBindingNavigator
        '
        Me.Materia_primaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Materia_primaBindingNavigator.BindingSource = Me.Materia_primaBindingSource
        Me.Materia_primaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Materia_primaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Materia_primaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Materia_primaBindingNavigatorSaveItem})
        Me.Materia_primaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Materia_primaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Materia_primaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Materia_primaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Materia_primaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Materia_primaBindingNavigator.Name = "Materia_primaBindingNavigator"
        Me.Materia_primaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Materia_primaBindingNavigator.Size = New System.Drawing.Size(338, 25)
        Me.Materia_primaBindingNavigator.TabIndex = 0
        Me.Materia_primaBindingNavigator.Text = "BindingNavigator1"
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
        'Materia_primaBindingNavigatorSaveItem
        '
        Me.Materia_primaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Materia_primaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Materia_primaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Materia_primaBindingNavigatorSaveItem.Name = "Materia_primaBindingNavigatorSaveItem"
        Me.Materia_primaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Materia_primaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Nome_MPLabel
        '
        Nome_MPLabel.AutoSize = True
        Nome_MPLabel.Location = New System.Drawing.Point(32, 35)
        Nome_MPLabel.Name = "Nome_MPLabel"
        Nome_MPLabel.Size = New System.Drawing.Size(57, 13)
        Nome_MPLabel.TabIndex = 1
        Nome_MPLabel.Text = "Nome MP:"
        '
        'Qtd_MPLabel
        '
        Qtd_MPLabel.AutoSize = True
        Qtd_MPLabel.Location = New System.Drawing.Point(116, 35)
        Qtd_MPLabel.Name = "Qtd_MPLabel"
        Qtd_MPLabel.Size = New System.Drawing.Size(46, 13)
        Qtd_MPLabel.TabIndex = 3
        Qtd_MPLabel.Text = "Qtd MP:"
        '
        'Qtd_minimaLabel
        '
        Qtd_minimaLabel.AutoSize = True
        Qtd_minimaLabel.Location = New System.Drawing.Point(200, 35)
        Qtd_minimaLabel.Name = "Qtd_minimaLabel"
        Qtd_minimaLabel.Size = New System.Drawing.Size(62, 13)
        Qtd_minimaLabel.TabIndex = 5
        Qtd_minimaLabel.Text = "Qtd minima:"
        AddHandler Qtd_minimaLabel.Click, AddressOf Me.Qtd_minimaLabel_Click
        '
        'estoque_minimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 201)
        Me.Controls.Add(Qtd_minimaLabel)
        Me.Controls.Add(Qtd_MPLabel)
        Me.Controls.Add(Nome_MPLabel)
        Me.Controls.Add(Me.Materia_primaBindingNavigator)
        Me.Name = "estoque_minimo"
        Me.Text = "estoque_minimo"
        CType(Me.Matera_primaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Materia_primaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Materia_primaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Materia_primaBindingNavigator.ResumeLayout(False)
        Me.Materia_primaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Matera_primaDataSet As WindowsApplication1.matera_primaDataSet
    Friend WithEvents Materia_primaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Materia_primaTableAdapter As WindowsApplication1.matera_primaDataSetTableAdapters.materia_primaTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.matera_primaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Materia_primaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Materia_primaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
End Class
