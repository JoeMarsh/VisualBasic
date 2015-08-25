<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddRecords))
        Dim CarDistrictLabel As System.Windows.Forms.Label
        Dim CarRegYearLabel As System.Windows.Forms.Label
        Dim CarRegCodeLabel As System.Windows.Forms.Label
        Dim CameraCodeLabel As System.Windows.Forms.Label
        Dim CameraDateTimeLabel As System.Windows.Forms.Label
        Me.CameraDatabaseDataSet = New VehicleCameraDatabase.CameraDatabaseDataSet()
        Me.RecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordsTableAdapter = New VehicleCameraDatabase.CameraDatabaseDataSetTableAdapters.RecordsTableAdapter()
        Me.TableAdapterManager = New VehicleCameraDatabase.CameraDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.RecordsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RecordsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CarDistrictTextBox = New System.Windows.Forms.TextBox()
        Me.CarRegYearTextBox = New System.Windows.Forms.TextBox()
        Me.CarRegCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CameraCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CameraDateTimeTextBox = New System.Windows.Forms.TextBox()
        CarDistrictLabel = New System.Windows.Forms.Label()
        CarRegYearLabel = New System.Windows.Forms.Label()
        CarRegCodeLabel = New System.Windows.Forms.Label()
        CameraCodeLabel = New System.Windows.Forms.Label()
        CameraDateTimeLabel = New System.Windows.Forms.Label()
        CType(Me.CameraDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecordsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CameraDatabaseDataSet
        '
        Me.CameraDatabaseDataSet.DataSetName = "CameraDatabaseDataSet"
        Me.CameraDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecordsBindingSource
        '
        Me.RecordsBindingSource.DataMember = "Records"
        Me.RecordsBindingSource.DataSource = Me.CameraDatabaseDataSet
        '
        'RecordsTableAdapter
        '
        Me.RecordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RecordsTableAdapter = Me.RecordsTableAdapter
        Me.TableAdapterManager.UpdateOrder = VehicleCameraDatabase.CameraDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecordsBindingNavigator
        '
        Me.RecordsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RecordsBindingNavigator.BindingSource = Me.RecordsBindingSource
        Me.RecordsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RecordsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RecordsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RecordsBindingNavigatorSaveItem})
        Me.RecordsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RecordsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RecordsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RecordsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RecordsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RecordsBindingNavigator.Name = "RecordsBindingNavigator"
        Me.RecordsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RecordsBindingNavigator.Size = New System.Drawing.Size(300, 25)
        Me.RecordsBindingNavigator.TabIndex = 0
        Me.RecordsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
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
        'RecordsBindingNavigatorSaveItem
        '
        Me.RecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecordsBindingNavigatorSaveItem.Image = CType(resources.GetObject("RecordsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RecordsBindingNavigatorSaveItem.Name = "RecordsBindingNavigatorSaveItem"
        Me.RecordsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RecordsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CarDistrictLabel
        '
        CarDistrictLabel.AutoSize = True
        CarDistrictLabel.Location = New System.Drawing.Point(48, 61)
        CarDistrictLabel.Name = "CarDistrictLabel"
        CarDistrictLabel.Size = New System.Drawing.Size(61, 13)
        CarDistrictLabel.TabIndex = 3
        CarDistrictLabel.Text = "Car District:"
        '
        'CarDistrictTextBox
        '
        Me.CarDistrictTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "CarDistrict", True))
        Me.CarDistrictTextBox.Location = New System.Drawing.Point(152, 58)
        Me.CarDistrictTextBox.Name = "CarDistrictTextBox"
        Me.CarDistrictTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CarDistrictTextBox.TabIndex = 4
        '
        'CarRegYearLabel
        '
        CarRegYearLabel.AutoSize = True
        CarRegYearLabel.Location = New System.Drawing.Point(48, 87)
        CarRegYearLabel.Name = "CarRegYearLabel"
        CarRegYearLabel.Size = New System.Drawing.Size(74, 13)
        CarRegYearLabel.TabIndex = 5
        CarRegYearLabel.Text = "Car Reg Year:"
        '
        'CarRegYearTextBox
        '
        Me.CarRegYearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "CarRegYear", True))
        Me.CarRegYearTextBox.Location = New System.Drawing.Point(152, 84)
        Me.CarRegYearTextBox.Name = "CarRegYearTextBox"
        Me.CarRegYearTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CarRegYearTextBox.TabIndex = 6
        '
        'CarRegCodeLabel
        '
        CarRegCodeLabel.AutoSize = True
        CarRegCodeLabel.Location = New System.Drawing.Point(48, 113)
        CarRegCodeLabel.Name = "CarRegCodeLabel"
        CarRegCodeLabel.Size = New System.Drawing.Size(77, 13)
        CarRegCodeLabel.TabIndex = 7
        CarRegCodeLabel.Text = "Car Reg Code:"
        '
        'CarRegCodeTextBox
        '
        Me.CarRegCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "CarRegCode", True))
        Me.CarRegCodeTextBox.Location = New System.Drawing.Point(152, 110)
        Me.CarRegCodeTextBox.Name = "CarRegCodeTextBox"
        Me.CarRegCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CarRegCodeTextBox.TabIndex = 8
        '
        'CameraCodeLabel
        '
        CameraCodeLabel.AutoSize = True
        CameraCodeLabel.Location = New System.Drawing.Point(48, 139)
        CameraCodeLabel.Name = "CameraCodeLabel"
        CameraCodeLabel.Size = New System.Drawing.Size(74, 13)
        CameraCodeLabel.TabIndex = 9
        CameraCodeLabel.Text = "Camera Code:"
        '
        'CameraCodeTextBox
        '
        Me.CameraCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "CameraCode", True))
        Me.CameraCodeTextBox.Location = New System.Drawing.Point(152, 136)
        Me.CameraCodeTextBox.Name = "CameraCodeTextBox"
        Me.CameraCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CameraCodeTextBox.TabIndex = 10
        '
        'CameraDateTimeLabel
        '
        CameraDateTimeLabel.AutoSize = True
        CameraDateTimeLabel.Location = New System.Drawing.Point(48, 165)
        CameraDateTimeLabel.Name = "CameraDateTimeLabel"
        CameraDateTimeLabel.Size = New System.Drawing.Size(98, 13)
        CameraDateTimeLabel.TabIndex = 11
        CameraDateTimeLabel.Text = "Camera Date Time:"
        '
        'CameraDateTimeTextBox
        '
        Me.CameraDateTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordsBindingSource, "CameraDateTime", True))
        Me.CameraDateTimeTextBox.Location = New System.Drawing.Point(152, 162)
        Me.CameraDateTimeTextBox.Name = "CameraDateTimeTextBox"
        Me.CameraDateTimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CameraDateTimeTextBox.TabIndex = 12
        '
        'frmAddRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 216)
        Me.Controls.Add(CarDistrictLabel)
        Me.Controls.Add(Me.CarDistrictTextBox)
        Me.Controls.Add(CarRegYearLabel)
        Me.Controls.Add(Me.CarRegYearTextBox)
        Me.Controls.Add(CarRegCodeLabel)
        Me.Controls.Add(Me.CarRegCodeTextBox)
        Me.Controls.Add(CameraCodeLabel)
        Me.Controls.Add(Me.CameraCodeTextBox)
        Me.Controls.Add(CameraDateTimeLabel)
        Me.Controls.Add(Me.CameraDateTimeTextBox)
        Me.Controls.Add(Me.RecordsBindingNavigator)
        Me.Name = "frmAddRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.CameraDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecordsBindingNavigator.ResumeLayout(False)
        Me.RecordsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CameraDatabaseDataSet As VehicleCameraDatabase.CameraDatabaseDataSet
    Friend WithEvents RecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecordsTableAdapter As VehicleCameraDatabase.CameraDatabaseDataSetTableAdapters.RecordsTableAdapter
    Friend WithEvents TableAdapterManager As VehicleCameraDatabase.CameraDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecordsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RecordsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CarDistrictTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarRegYearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarRegCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CameraCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CameraDateTimeTextBox As System.Windows.Forms.TextBox
End Class
