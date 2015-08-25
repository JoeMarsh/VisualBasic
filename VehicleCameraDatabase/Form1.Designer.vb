<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.combCar = New System.Windows.Forms.ComboBox()
        Me.txtCarInput = New System.Windows.Forms.TextBox()
        Me.lblCamera = New System.Windows.Forms.Label()
        Me.combCamera = New System.Windows.Forms.ComboBox()
        Me.txtCameraInput = New System.Windows.Forms.TextBox()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.lblNoRecords = New System.Windows.Forms.Label()
        Me.txtNoRecords = New System.Windows.Forms.TextBox()
        Me.picCamera = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(353, 120)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 35)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(353, 29)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 35)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCar.Location = New System.Drawing.Point(29, 23)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(40, 18)
        Me.lblCar.TabIndex = 2
        Me.lblCar.Text = "Car:"
        '
        'combCar
        '
        Me.combCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combCar.FormattingEnabled = True
        Me.combCar.Items.AddRange(New Object() {"CarDistrict", "CarRegYear", "CarRegCode"})
        Me.combCar.Location = New System.Drawing.Point(32, 44)
        Me.combCar.Name = "combCar"
        Me.combCar.Size = New System.Drawing.Size(121, 21)
        Me.combCar.TabIndex = 3
        '
        'txtCarInput
        '
        Me.txtCarInput.Location = New System.Drawing.Point(169, 44)
        Me.txtCarInput.Name = "txtCarInput"
        Me.txtCarInput.Size = New System.Drawing.Size(147, 20)
        Me.txtCarInput.TabIndex = 4
        '
        'lblCamera
        '
        Me.lblCamera.AutoSize = True
        Me.lblCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamera.Location = New System.Drawing.Point(29, 82)
        Me.lblCamera.Name = "lblCamera"
        Me.lblCamera.Size = New System.Drawing.Size(68, 17)
        Me.lblCamera.TabIndex = 5
        Me.lblCamera.Text = "Camera:"
        '
        'combCamera
        '
        Me.combCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combCamera.FormattingEnabled = True
        Me.combCamera.Items.AddRange(New Object() {"CameraCode", "CameraDateTime"})
        Me.combCamera.Location = New System.Drawing.Point(32, 102)
        Me.combCamera.Name = "combCamera"
        Me.combCamera.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.combCamera.Size = New System.Drawing.Size(121, 21)
        Me.combCamera.TabIndex = 6
        '
        'txtCameraInput
        '
        Me.txtCameraInput.Location = New System.Drawing.Point(169, 103)
        Me.txtCameraInput.Name = "txtCameraInput"
        Me.txtCameraInput.Size = New System.Drawing.Size(147, 20)
        Me.txtCameraInput.TabIndex = 7
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(32, 197)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(645, 299)
        Me.dgvResults.TabIndex = 8
        '
        'lblNoRecords
        '
        Me.lblNoRecords.AutoSize = True
        Me.lblNoRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecords.Location = New System.Drawing.Point(29, 171)
        Me.lblNoRecords.Name = "lblNoRecords"
        Me.lblNoRecords.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNoRecords.Size = New System.Drawing.Size(103, 17)
        Me.lblNoRecords.TabIndex = 9
        Me.lblNoRecords.Text = "No. Records:"
        '
        'txtNoRecords
        '
        Me.txtNoRecords.Location = New System.Drawing.Point(129, 171)
        Me.txtNoRecords.Name = "txtNoRecords"
        Me.txtNoRecords.Size = New System.Drawing.Size(100, 20)
        Me.txtNoRecords.TabIndex = 10
        '
        'picCamera
        '
        Me.picCamera.Image = CType(resources.GetObject("picCamera.Image"), System.Drawing.Image)
        Me.picCamera.Location = New System.Drawing.Point(499, 23)
        Me.picCamera.Name = "picCamera"
        Me.picCamera.Size = New System.Drawing.Size(129, 144)
        Me.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCamera.TabIndex = 11
        Me.picCamera.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(353, 76)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 29)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add Records"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 533)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.picCamera)
        Me.Controls.Add(Me.txtNoRecords)
        Me.Controls.Add(Me.lblNoRecords)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.txtCameraInput)
        Me.Controls.Add(Me.combCamera)
        Me.Controls.Add(Me.lblCamera)
        Me.Controls.Add(Me.txtCarInput)
        Me.Controls.Add(Me.combCar)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblCar As System.Windows.Forms.Label
    Friend WithEvents combCar As System.Windows.Forms.ComboBox
    Friend WithEvents txtCarInput As System.Windows.Forms.TextBox
    Friend WithEvents lblCamera As System.Windows.Forms.Label
    Friend WithEvents combCamera As System.Windows.Forms.ComboBox
    Friend WithEvents txtCameraInput As System.Windows.Forms.TextBox
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
    Friend WithEvents lblNoRecords As System.Windows.Forms.Label
    Friend WithEvents txtNoRecords As System.Windows.Forms.TextBox
    Friend WithEvents picCamera As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button

End Class
