﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class solicitação_de_materia_prima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(solicitação_de_materia_prima))
        Dim DatacompraLabel As System.Windows.Forms.Label
        Dim Dataprevista_entregaLabel As System.Windows.Forms.Label
        Dim DataentregaLabel As System.Windows.Forms.Label
        Dim Qtd_encomendaLabel As System.Windows.Forms.Label
        Me.EncomendaDataSet = New WindowsApplication1.encomendaDataSet
        Me.EncomendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncomendaTableAdapter = New WindowsApplication1.encomendaDataSetTableAdapters.encomendaTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.encomendaDataSetTableAdapters.TableAdapterManager
        Me.EncomendaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EncomendaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DatacompraMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Dataprevista_entregaMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.DataentregaMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Qtd_encomendaMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        DatacompraLabel = New System.Windows.Forms.Label
        Dataprevista_entregaLabel = New System.Windows.Forms.Label
        DataentregaLabel = New System.Windows.Forms.Label
        Qtd_encomendaLabel = New System.Windows.Forms.Label
        CType(Me.EncomendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncomendaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EncomendaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'EncomendaDataSet
        '
        Me.EncomendaDataSet.DataSetName = "encomendaDataSet"
        Me.EncomendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EncomendaBindingSource
        '
        Me.EncomendaBindingSource.DataMember = "encomenda"
        Me.EncomendaBindingSource.DataSource = Me.EncomendaDataSet
        '
        'EncomendaTableAdapter
        '
        Me.EncomendaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.encomendaTableAdapter = Me.EncomendaTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.encomendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EncomendaBindingNavigator
        '
        Me.EncomendaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EncomendaBindingNavigator.BindingSource = Me.EncomendaBindingSource
        Me.EncomendaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EncomendaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EncomendaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EncomendaBindingNavigatorSaveItem})
        Me.EncomendaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EncomendaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EncomendaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EncomendaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EncomendaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EncomendaBindingNavigator.Name = "EncomendaBindingNavigator"
        Me.EncomendaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EncomendaBindingNavigator.Size = New System.Drawing.Size(306, 25)
        Me.EncomendaBindingNavigator.TabIndex = 0
        Me.EncomendaBindingNavigator.Text = "BindingNavigator1"
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
        'EncomendaBindingNavigatorSaveItem
        '
        Me.EncomendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EncomendaBindingNavigatorSaveItem.Image = CType(resources.GetObject("EncomendaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EncomendaBindingNavigatorSaveItem.Name = "EncomendaBindingNavigatorSaveItem"
        Me.EncomendaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EncomendaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DatacompraLabel
        '
        DatacompraLabel.AutoSize = True
        DatacompraLabel.Location = New System.Drawing.Point(12, 45)
        DatacompraLabel.Name = "DatacompraLabel"
        DatacompraLabel.Size = New System.Drawing.Size(66, 13)
        DatacompraLabel.TabIndex = 1
        DatacompraLabel.Text = "datacompra:"
        '
        'DatacompraMaskedTextBox
        '
        Me.DatacompraMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncomendaBindingSource, "datacompra", True))
        Me.DatacompraMaskedTextBox.Location = New System.Drawing.Point(125, 42)
        Me.DatacompraMaskedTextBox.Mask = "00/00/0000"
        Me.DatacompraMaskedTextBox.Name = "DatacompraMaskedTextBox"
        Me.DatacompraMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DatacompraMaskedTextBox.TabIndex = 2
        Me.DatacompraMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Dataprevista_entregaLabel
        '
        Dataprevista_entregaLabel.AutoSize = True
        Dataprevista_entregaLabel.Location = New System.Drawing.Point(12, 86)
        Dataprevista_entregaLabel.Name = "Dataprevista_entregaLabel"
        Dataprevista_entregaLabel.Size = New System.Drawing.Size(107, 13)
        Dataprevista_entregaLabel.TabIndex = 3
        Dataprevista_entregaLabel.Text = "dataprevista entrega:"
        '
        'Dataprevista_entregaMaskedTextBox
        '
        Me.Dataprevista_entregaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncomendaBindingSource, "dataprevista_entrega", True))
        Me.Dataprevista_entregaMaskedTextBox.Location = New System.Drawing.Point(125, 83)
        Me.Dataprevista_entregaMaskedTextBox.Mask = "00/00/0000"
        Me.Dataprevista_entregaMaskedTextBox.Name = "Dataprevista_entregaMaskedTextBox"
        Me.Dataprevista_entregaMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dataprevista_entregaMaskedTextBox.TabIndex = 4
        Me.Dataprevista_entregaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataentregaLabel
        '
        DataentregaLabel.AutoSize = True
        DataentregaLabel.Location = New System.Drawing.Point(12, 125)
        DataentregaLabel.Name = "DataentregaLabel"
        DataentregaLabel.Size = New System.Drawing.Size(67, 13)
        DataentregaLabel.TabIndex = 5
        DataentregaLabel.Text = "dataentrega:"
        '
        'DataentregaMaskedTextBox
        '
        Me.DataentregaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncomendaBindingSource, "dataentrega", True))
        Me.DataentregaMaskedTextBox.Location = New System.Drawing.Point(125, 122)
        Me.DataentregaMaskedTextBox.Mask = "00/00/0000"
        Me.DataentregaMaskedTextBox.Name = "DataentregaMaskedTextBox"
        Me.DataentregaMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataentregaMaskedTextBox.TabIndex = 6
        Me.DataentregaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Qtd_encomendaLabel
        '
        Qtd_encomendaLabel.AutoSize = True
        Qtd_encomendaLabel.Location = New System.Drawing.Point(12, 164)
        Qtd_encomendaLabel.Name = "Qtd_encomendaLabel"
        Qtd_encomendaLabel.Size = New System.Drawing.Size(86, 13)
        Qtd_encomendaLabel.TabIndex = 7
        Qtd_encomendaLabel.Text = "Qtd encomenda:"
        '
        'Qtd_encomendaMaskedTextBox
        '
        Me.Qtd_encomendaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncomendaBindingSource, "Qtd_encomenda", True))
        Me.Qtd_encomendaMaskedTextBox.Location = New System.Drawing.Point(125, 161)
        Me.Qtd_encomendaMaskedTextBox.Name = "Qtd_encomendaMaskedTextBox"
        Me.Qtd_encomendaMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Qtd_encomendaMaskedTextBox.TabIndex = 8
        '
        'solicitação_de_materia_prima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 230)
        Me.Controls.Add(Qtd_encomendaLabel)
        Me.Controls.Add(Me.Qtd_encomendaMaskedTextBox)
        Me.Controls.Add(DataentregaLabel)
        Me.Controls.Add(Me.DataentregaMaskedTextBox)
        Me.Controls.Add(Dataprevista_entregaLabel)
        Me.Controls.Add(Me.Dataprevista_entregaMaskedTextBox)
        Me.Controls.Add(DatacompraLabel)
        Me.Controls.Add(Me.DatacompraMaskedTextBox)
        Me.Controls.Add(Me.EncomendaBindingNavigator)
        Me.Name = "solicitação_de_materia_prima"
        Me.Text = "solicitação_de_materia_prima"
        CType(Me.EncomendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncomendaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EncomendaBindingNavigator.ResumeLayout(False)
        Me.EncomendaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EncomendaDataSet As WindowsApplication1.encomendaDataSet
    Friend WithEvents EncomendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncomendaTableAdapter As WindowsApplication1.encomendaDataSetTableAdapters.encomendaTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.encomendaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EncomendaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EncomendaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DatacompraMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Dataprevista_entregaMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataentregaMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Qtd_encomendaMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
