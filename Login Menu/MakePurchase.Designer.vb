<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MakePurchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MakePurchase))
        Me.txtPurchaseNo = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.LabelCropEntriesCropName = New System.Windows.Forms.Label()
        Me.LabelCropEntriesCropCode = New System.Windows.Forms.Label()
        Me.LabelCropEntriesCategory = New System.Windows.Forms.Label()
        Me.LabelCropEntriesPurchasePrice = New System.Windows.Forms.Label()
        Me.LabelCropEntriesSellingPrice = New System.Windows.Forms.Label()
        Me.LabelCropEntriesSeason = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.txtFarmerId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerProductOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPurchaseNo
        '
        Me.txtPurchaseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseNo.Location = New System.Drawing.Point(208, 71)
        Me.txtPurchaseNo.Name = "txtPurchaseNo"
        Me.txtPurchaseNo.ReadOnly = True
        Me.txtPurchaseNo.Size = New System.Drawing.Size(159, 26)
        Me.txtPurchaseNo.TabIndex = 1
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(208, 148)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(159, 26)
        Me.txtUnitPrice.TabIndex = 2
        '
        'LabelCropEntriesCropName
        '
        Me.LabelCropEntriesCropName.AutoSize = True
        Me.LabelCropEntriesCropName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesCropName.Location = New System.Drawing.Point(45, 30)
        Me.LabelCropEntriesCropName.Name = "LabelCropEntriesCropName"
        Me.LabelCropEntriesCropName.Size = New System.Drawing.Size(57, 27)
        Me.LabelCropEntriesCropName.TabIndex = 3
        Me.LabelCropEntriesCropName.Text = "Date"
        '
        'LabelCropEntriesCropCode
        '
        Me.LabelCropEntriesCropCode.AutoSize = True
        Me.LabelCropEntriesCropCode.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesCropCode.Location = New System.Drawing.Point(45, 69)
        Me.LabelCropEntriesCropCode.Name = "LabelCropEntriesCropCode"
        Me.LabelCropEntriesCropCode.Size = New System.Drawing.Size(134, 27)
        Me.LabelCropEntriesCropCode.TabIndex = 4
        Me.LabelCropEntriesCropCode.Text = "Purchase No:"
        '
        'LabelCropEntriesCategory
        '
        Me.LabelCropEntriesCategory.AutoSize = True
        Me.LabelCropEntriesCategory.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesCategory.Location = New System.Drawing.Point(45, 107)
        Me.LabelCropEntriesCategory.Name = "LabelCropEntriesCategory"
        Me.LabelCropEntriesCategory.Size = New System.Drawing.Size(81, 27)
        Me.LabelCropEntriesCategory.TabIndex = 5
        Me.LabelCropEntriesCategory.Text = "Product"
        '
        'LabelCropEntriesPurchasePrice
        '
        Me.LabelCropEntriesPurchasePrice.AutoSize = True
        Me.LabelCropEntriesPurchasePrice.BackColor = System.Drawing.SystemColors.Control
        Me.LabelCropEntriesPurchasePrice.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesPurchasePrice.Location = New System.Drawing.Point(45, 146)
        Me.LabelCropEntriesPurchasePrice.Name = "LabelCropEntriesPurchasePrice"
        Me.LabelCropEntriesPurchasePrice.Size = New System.Drawing.Size(111, 27)
        Me.LabelCropEntriesPurchasePrice.TabIndex = 6
        Me.LabelCropEntriesPurchasePrice.Text = "Unit Price:"
        '
        'LabelCropEntriesSellingPrice
        '
        Me.LabelCropEntriesSellingPrice.AutoSize = True
        Me.LabelCropEntriesSellingPrice.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesSellingPrice.Location = New System.Drawing.Point(45, 181)
        Me.LabelCropEntriesSellingPrice.Name = "LabelCropEntriesSellingPrice"
        Me.LabelCropEntriesSellingPrice.Size = New System.Drawing.Size(110, 27)
        Me.LabelCropEntriesSellingPrice.TabIndex = 7
        Me.LabelCropEntriesSellingPrice.Text = "Product Id"
        '
        'LabelCropEntriesSeason
        '
        Me.LabelCropEntriesSeason.AutoSize = True
        Me.LabelCropEntriesSeason.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesSeason.Location = New System.Drawing.Point(45, 219)
        Me.LabelCropEntriesSeason.Name = "LabelCropEntriesSeason"
        Me.LabelCropEntriesSeason.Size = New System.Drawing.Size(94, 27)
        Me.LabelCropEntriesSeason.TabIndex = 8
        Me.LabelCropEntriesSeason.Text = "Quantity"
        '
        'txtProductId
        '
        Me.txtProductId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductId.Location = New System.Drawing.Point(208, 185)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(159, 26)
        Me.txtProductId.TabIndex = 9
        '
        'cboProduct
        '
        Me.cboProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(208, 109)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(159, 28)
        Me.cboProduct.TabIndex = 10
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(120, 341)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(79, 41)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(38, 341)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(76, 41)
        Me.ButtonClear.TabIndex = 15
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(300, 341)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(80, 41)
        Me.ButtonClose.TabIndex = 17
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'txtFarmerId
        '
        Me.txtFarmerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFarmerId.Location = New System.Drawing.Point(208, 263)
        Me.txtFarmerId.Name = "txtFarmerId"
        Me.txtFarmerId.Size = New System.Drawing.Size(159, 26)
        Me.txtFarmerId.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 27)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Farmer Id"
        '
        'DateTimePickerProductOrderDate
        '
        Me.DateTimePickerProductOrderDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerProductOrderDate.Location = New System.Drawing.Point(139, 30)
        Me.DateTimePickerProductOrderDate.Name = "DateTimePickerProductOrderDate"
        Me.DateTimePickerProductOrderDate.Size = New System.Drawing.Size(228, 25)
        Me.DateTimePickerProductOrderDate.TabIndex = 21
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(208, 220)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(159, 26)
        Me.txtQuantity.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGreen
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(389, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(453, 149)
        Me.DataGridView1.TabIndex = 23
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightGreen
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(389, 207)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(453, 164)
        Me.DataGridView2.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(766, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Products"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(768, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Farmers"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(208, 302)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(159, 26)
        Me.txtTotal.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 27)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Total"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(205, 341)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 41)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'MakePurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 394)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.LabelCropEntriesCropCode)
        Me.Controls.Add(Me.txtPurchaseNo)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.DateTimePickerProductOrderDate)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.LabelCropEntriesCropName)
        Me.Controls.Add(Me.LabelCropEntriesSeason)
        Me.Controls.Add(Me.txtFarmerId)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.LabelCropEntriesSellingPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.LabelCropEntriesCategory)
        Me.Controls.Add(Me.LabelCropEntriesPurchasePrice)
        Me.Controls.Add(Me.ButtonClose)
        Me.Name = "MakePurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CropForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPurchaseNo As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents LabelCropEntriesCropName As Label
    Friend WithEvents LabelCropEntriesCropCode As Label
    Friend WithEvents LabelCropEntriesCategory As Label
    Friend WithEvents LabelCropEntriesPurchasePrice As Label
    Friend WithEvents LabelCropEntriesSellingPrice As Label
    Friend WithEvents LabelCropEntriesSeason As Label
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents txtFarmerId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerProductOrderDate As DateTimePicker
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdate As Button
End Class
