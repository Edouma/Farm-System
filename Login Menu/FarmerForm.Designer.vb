<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FarmerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FarmerForm))
        Me.LabelOrderAddress = New System.Windows.Forms.Label()
        Me.LabelOrderPrice = New System.Windows.Forms.Label()
        Me.LabelOrderPaymentMethod = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.DataGridViewCustomerOrder = New System.Windows.Forms.DataGridView()
        Me.LabelCustomerOrderOrderID = New System.Windows.Forms.Label()
        Me.txtFarmerId = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewCustomerOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelOrderAddress
        '
        Me.LabelOrderAddress.AutoSize = True
        Me.LabelOrderAddress.BackColor = System.Drawing.SystemColors.Control
        Me.LabelOrderAddress.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOrderAddress.Location = New System.Drawing.Point(11, 112)
        Me.LabelOrderAddress.Name = "LabelOrderAddress"
        Me.LabelOrderAddress.Size = New System.Drawing.Size(86, 27)
        Me.LabelOrderAddress.TabIndex = 0
        Me.LabelOrderAddress.Text = "Address"
        '
        'LabelOrderPrice
        '
        Me.LabelOrderPrice.AutoSize = True
        Me.LabelOrderPrice.BackColor = System.Drawing.SystemColors.Control
        Me.LabelOrderPrice.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOrderPrice.Location = New System.Drawing.Point(11, 68)
        Me.LabelOrderPrice.Name = "LabelOrderPrice"
        Me.LabelOrderPrice.Size = New System.Drawing.Size(139, 27)
        Me.LabelOrderPrice.TabIndex = 1
        Me.LabelOrderPrice.Text = "Farmer Name"
        '
        'LabelOrderPaymentMethod
        '
        Me.LabelOrderPaymentMethod.AutoSize = True
        Me.LabelOrderPaymentMethod.BackColor = System.Drawing.SystemColors.Control
        Me.LabelOrderPaymentMethod.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOrderPaymentMethod.Location = New System.Drawing.Point(11, 186)
        Me.LabelOrderPaymentMethod.Name = "LabelOrderPaymentMethod"
        Me.LabelOrderPaymentMethod.Size = New System.Drawing.Size(83, 27)
        Me.LabelOrderPaymentMethod.TabIndex = 4
        Me.LabelOrderPaymentMethod.Text = "Contact"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(179, 100)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(220, 80)
        Me.txtAddress.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(179, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(220, 26)
        Me.txtName.TabIndex = 6
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(12, 259)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(138, 38)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModify.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.ForeColor = System.Drawing.Color.White
        Me.btnModify.Location = New System.Drawing.Point(156, 218)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(239, 38)
        Me.btnModify.TabIndex = 11
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(156, 258)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(123, 38)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(12, 218)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 38)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(285, 258)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 39)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(179, 186)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(220, 26)
        Me.txtContact.TabIndex = 16
        '
        'DataGridViewCustomerOrder
        '
        Me.DataGridViewCustomerOrder.BackgroundColor = System.Drawing.Color.LightGreen
        Me.DataGridViewCustomerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomerOrder.Location = New System.Drawing.Point(424, 36)
        Me.DataGridViewCustomerOrder.Name = "DataGridViewCustomerOrder"
        Me.DataGridViewCustomerOrder.Size = New System.Drawing.Size(459, 259)
        Me.DataGridViewCustomerOrder.TabIndex = 18
        '
        'LabelCustomerOrderOrderID
        '
        Me.LabelCustomerOrderOrderID.AutoSize = True
        Me.LabelCustomerOrderOrderID.BackColor = System.Drawing.SystemColors.Control
        Me.LabelCustomerOrderOrderID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerOrderOrderID.Location = New System.Drawing.Point(11, 36)
        Me.LabelCustomerOrderOrderID.Name = "LabelCustomerOrderOrderID"
        Me.LabelCustomerOrderOrderID.Size = New System.Drawing.Size(111, 27)
        Me.LabelCustomerOrderOrderID.TabIndex = 19
        Me.LabelCustomerOrderOrderID.Text = "Farmer ID"
        '
        'txtFarmerId
        '
        Me.txtFarmerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFarmerId.Location = New System.Drawing.Point(179, 36)
        Me.txtFarmerId.Name = "txtFarmerId"
        Me.txtFarmerId.ReadOnly = True
        Me.txtFarmerId.Size = New System.Drawing.Size(220, 26)
        Me.txtFarmerId.TabIndex = 20
        '
        'FarmerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(901, 337)
        Me.Controls.Add(Me.txtFarmerId)
        Me.Controls.Add(Me.LabelCustomerOrderOrderID)
        Me.Controls.Add(Me.DataGridViewCustomerOrder)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.LabelOrderPaymentMethod)
        Me.Controls.Add(Me.LabelOrderPrice)
        Me.Controls.Add(Me.LabelOrderAddress)
        Me.Name = "FarmerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FarmerForm"
        CType(Me.DataGridViewCustomerOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelOrderAddress As Label
    Friend WithEvents LabelOrderPrice As Label
    Friend WithEvents LabelOrderPaymentMethod As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtContact As TextBox
    Friend WithEvents DataGridViewCustomerOrder As DataGridView
    Friend WithEvents LabelCustomerOrderOrderID As Label
    Friend WithEvents txtFarmerId As TextBox
End Class
