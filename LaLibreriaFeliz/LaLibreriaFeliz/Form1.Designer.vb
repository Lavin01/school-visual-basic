<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim EditorialLabel As System.Windows.Forms.Label
        Dim AnioLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LIBRERIADataSet = New LaLibreriaFeliz.LIBRERIADataSet()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrosTableAdapter = New LaLibreriaFeliz.LIBRERIADataSetTableAdapters.librosTableAdapter()
        Me.TableAdapterManager = New LaLibreriaFeliz.LIBRERIADataSetTableAdapters.TableAdapterManager()
        Me.LibrosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.LibrosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.EditorialTextBox = New System.Windows.Forms.TextBox()
        Me.AnioTextBox = New System.Windows.Forms.TextBox()
        ISBNLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        EditorialLabel = New System.Windows.Forms.Label()
        AnioLabel = New System.Windows.Forms.Label()
        CType(Me.LIBRERIADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibrosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "La Libreria Feliz"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(358, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LIBRERIADataSet
        '
        Me.LIBRERIADataSet.DataSetName = "LIBRERIADataSet"
        Me.LIBRERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibrosBindingSource
        '
        Me.LibrosBindingSource.DataMember = "libros"
        Me.LibrosBindingSource.DataSource = Me.LIBRERIADataSet
        '
        'LibrosTableAdapter
        '
        Me.LibrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.librosTableAdapter = Me.LibrosTableAdapter
        Me.TableAdapterManager.UpdateOrder = LaLibreriaFeliz.LIBRERIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LibrosBindingNavigator
        '
        Me.LibrosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LibrosBindingNavigator.BindingSource = Me.LibrosBindingSource
        Me.LibrosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LibrosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LibrosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LibrosBindingNavigatorSaveItem})
        Me.LibrosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LibrosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LibrosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LibrosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LibrosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LibrosBindingNavigator.Name = "LibrosBindingNavigator"
        Me.LibrosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LibrosBindingNavigator.Size = New System.Drawing.Size(400, 25)
        Me.LibrosBindingNavigator.TabIndex = 2
        Me.LibrosBindingNavigator.Text = "BindingNavigator1"
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
        'LibrosBindingNavigatorSaveItem
        '
        Me.LibrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LibrosBindingNavigatorSaveItem.Image = CType(resources.GetObject("LibrosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LibrosBindingNavigatorSaveItem.Name = "LibrosBindingNavigatorSaveItem"
        Me.LibrosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.LibrosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(25, 62)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 3
        ISBNLabel.Text = "ISBN:"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(66, 59)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(308, 20)
        Me.ISBNTextBox.TabIndex = 4
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(24, 98)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(36, 13)
        TituloLabel.TabIndex = 5
        TituloLabel.Text = "Titulo:"
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(66, 95)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(308, 20)
        Me.TituloTextBox.TabIndex = 6
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(24, 134)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 7
        AutorLabel.Text = "Autor:"
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "Autor", True))
        Me.AutorTextBox.Location = New System.Drawing.Point(65, 131)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(308, 20)
        Me.AutorTextBox.TabIndex = 8
        '
        'EditorialLabel
        '
        EditorialLabel.AutoSize = True
        EditorialLabel.Location = New System.Drawing.Point(13, 172)
        EditorialLabel.Name = "EditorialLabel"
        EditorialLabel.Size = New System.Drawing.Size(47, 13)
        EditorialLabel.TabIndex = 9
        EditorialLabel.Text = "Editorial:"
        '
        'EditorialTextBox
        '
        Me.EditorialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "Editorial", True))
        Me.EditorialTextBox.Location = New System.Drawing.Point(66, 169)
        Me.EditorialTextBox.Name = "EditorialTextBox"
        Me.EditorialTextBox.Size = New System.Drawing.Size(308, 20)
        Me.EditorialTextBox.TabIndex = 10
        '
        'AnioLabel
        '
        AnioLabel.AutoSize = True
        AnioLabel.Location = New System.Drawing.Point(29, 204)
        AnioLabel.Name = "AnioLabel"
        AnioLabel.Size = New System.Drawing.Size(31, 13)
        AnioLabel.TabIndex = 11
        AnioLabel.Text = "Anio:"
        '
        'AnioTextBox
        '
        Me.AnioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "Anio", True))
        Me.AnioTextBox.Location = New System.Drawing.Point(66, 201)
        Me.AnioTextBox.Name = "AnioTextBox"
        Me.AnioTextBox.Size = New System.Drawing.Size(308, 20)
        Me.AnioTextBox.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 302)
        Me.Controls.Add(AnioLabel)
        Me.Controls.Add(Me.AnioTextBox)
        Me.Controls.Add(EditorialLabel)
        Me.Controls.Add(Me.EditorialTextBox)
        Me.Controls.Add(AutorLabel)
        Me.Controls.Add(Me.AutorTextBox)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(ISBNLabel)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(Me.LibrosBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LIBRERIADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibrosBindingNavigator.ResumeLayout(False)
        Me.LibrosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LIBRERIADataSet As LaLibreriaFeliz.LIBRERIADataSet
    Friend WithEvents LibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibrosTableAdapter As LaLibreriaFeliz.LIBRERIADataSetTableAdapters.librosTableAdapter
    Friend WithEvents TableAdapterManager As LaLibreriaFeliz.LIBRERIADataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibrosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LibrosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TituloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditorialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnioTextBox As System.Windows.Forms.TextBox

End Class
