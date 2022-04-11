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
        Me.TextBoxCropEntriesCropCode = New System.Windows.Forms.TextBox()
        Me.TextBoxCropEntriesPurchasePrice = New System.Windows.Forms.TextBox()
        Me.LabelCropEntriesCropName = New System.Windows.Forms.Label()
        Me.LabelCropEntriesCropCode = New System.Windows.Forms.Label()
        Me.LabelCropEntriesCategory = New System.Windows.Forms.Label()
        Me.LabelCropEntriesPurchasePrice = New System.Windows.Forms.Label()
        Me.LabelCropEntriesSellingPrice = New System.Windows.Forms.Label()
        Me.LabelCropEntriesSeason = New System.Windows.Forms.Label()
        Me.TextBoxCropEntriesSellingPrice = New System.Windows.Forms.TextBox()
        Me.ComboBoxCropEntriesCategory = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCropEntriesSeason = New System.Windows.Forms.ComboBox()
        Me.DataGridViewCropEntriesCrop = New System.Windows.Forms.DataGridView()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DateTimePickerProductOrderDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridViewCropEntriesCrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCropEntriesCropCode
        '
        Me.TextBoxCropEntriesCropCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCropEntriesCropCode.Location = New System.Drawing.Point(178, 67)
        Me.TextBoxCropEntriesCropCode.Name = "TextBoxCropEntriesCropCode"
        Me.TextBoxCropEntriesCropCode.Size = New System.Drawing.Size(159, 26)
        Me.TextBoxCropEntriesCropCode.TabIndex = 1
        '
        'TextBoxCropEntriesPurchasePrice
        '
        Me.TextBoxCropEntriesPurchasePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCropEntriesPurchasePrice.Location = New System.Drawing.Point(178, 144)
        Me.TextBoxCropEntriesPurchasePrice.Name = "TextBoxCropEntriesPurchasePrice"
        Me.TextBoxCropEntriesPurchasePrice.Size = New System.Drawing.Size(159, 26)
        Me.TextBoxCropEntriesPurchasePrice.TabIndex = 2
        '
        'LabelCropEntriesCropName
        '
        Me.LabelCropEntriesCropName.AutoSize = True
        Me.LabelCropEntriesCropName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesCropName.Location = New System.Drawing.Point(15, 26)
        Me.LabelCropEntriesCropName.Name = "LabelCropEntriesCropName"
        Me.LabelCropEntriesCropName.Size = New System.Drawing.Size(57, 27)
        Me.LabelCropEntriesCropName.TabIndex = 3
        Me.LabelCropEntriesCropName.Text = "Date"
        '
        'LabelCropEntriesCropCode
        '
        Me.LabelCropEntriesCropCode.AutoSize = True
        Me.LabelCropEntriesCropCode.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesCropCode.Location = New System.Drawing.Point(15, 65)
        Me.LabelCropEntriesCropCode.Name = "LabelCropEntriesCropCode"
        Me.LabelCropEntriesCropCode.Size = New System.Drawing.Size(134, 27)
        Me.LabelCropEntriesCropCode.TabIndex = 4
        Me.LabelCropEntriesCropCode.Text = "Purchase No:"
        '
        'LabelCropEntriesCategory
        '
        Me.LabelCropEntriesCategory.AutoSize = True
        Me.LabelCropEntriesCategory.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesCategory.Location = New System.Drawing.Point(15, 103)
        Me.LabelCropEntriesCategory.Name = "LabelCropEntriesCategory"
        Me.LabelCropEntriesCategory.Size = New System.Drawing.Size(81, 27)
        Me.LabelCropEntriesCategory.TabIndex = 5
        Me.LabelCropEntriesCategory.Text = "Product"
        '
        'LabelCropEntriesPurchasePrice
        '
        Me.LabelCropEntriesPurchasePrice.AutoSize = True
        Me.LabelCropEntriesPurchasePrice.BackColor = System.Drawing.Color.White
        Me.LabelCropEntriesPurchasePrice.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesPurchasePrice.Location = New System.Drawing.Point(15, 142)
        Me.LabelCropEntriesPurchasePrice.Name = "LabelCropEntriesPurchasePrice"
        Me.LabelCropEntriesPurchasePrice.Size = New System.Drawing.Size(111, 27)
        Me.LabelCropEntriesPurchasePrice.TabIndex = 6
        Me.LabelCropEntriesPurchasePrice.Text = "Unit Price:"
        '
        'LabelCropEntriesSellingPrice
        '
        Me.LabelCropEntriesSellingPrice.AutoSize = True
        Me.LabelCropEntriesSellingPrice.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesSellingPrice.Location = New System.Drawing.Point(15, 177)
        Me.LabelCropEntriesSellingPrice.Name = "LabelCropEntriesSellingPrice"
        Me.LabelCropEntriesSellingPrice.Size = New System.Drawing.Size(110, 27)
        Me.LabelCropEntriesSellingPrice.TabIndex = 7
        Me.LabelCropEntriesSellingPrice.Text = "Product Id"
        '
        'LabelCropEntriesSeason
        '
        Me.LabelCropEntriesSeason.AutoSize = True
        Me.LabelCropEntriesSeason.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCropEntriesSeason.Location = New System.Drawing.Point(15, 215)
        Me.LabelCropEntriesSeason.Name = "LabelCropEntriesSeason"
        Me.LabelCropEntriesSeason.Size = New System.Drawing.Size(94, 27)
        Me.LabelCropEntriesSeason.TabIndex = 8
        Me.LabelCropEntriesSeason.Text = "Quantity"
        '
        'TextBoxCropEntriesSellingPrice
        '
        Me.TextBoxCropEntriesSellingPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCropEntriesSellingPrice.Location = New System.Drawing.Point(178, 181)
        Me.TextBoxCropEntriesSellingPrice.Name = "TextBoxCropEntriesSellingPrice"
        Me.TextBoxCropEntriesSellingPrice.Size = New System.Drawing.Size(159, 26)
        Me.TextBoxCropEntriesSellingPrice.TabIndex = 9
        '
        'ComboBoxCropEntriesCategory
        '
        Me.ComboBoxCropEntriesCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCropEntriesCategory.FormattingEnabled = True
        Me.ComboBoxCropEntriesCategory.Location = New System.Drawing.Point(178, 105)
        Me.ComboBoxCropEntriesCategory.Name = "ComboBoxCropEntriesCategory"
        Me.ComboBoxCropEntriesCategory.Size = New System.Drawing.Size(159, 28)
        Me.ComboBoxCropEntriesCategory.TabIndex = 10
        '
        'ComboBoxCropEntriesSeason
        '
        Me.ComboBoxCropEntriesSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCropEntriesSeason.FormattingEnabled = True
        Me.ComboBoxCropEntriesSeason.Location = New System.Drawing.Point(178, 217)
        Me.ComboBoxCropEntriesSeason.Name = "ComboBoxCropEntriesSeason"
        Me.ComboBoxCropEntriesSeason.Size = New System.Drawing.Size(159, 28)
        Me.ComboBoxCropEntriesSeason.TabIndex = 11
        '
        'DataGridViewCropEntriesCrop
        '
        Me.DataGridViewCropEntriesCrop.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DataGridViewCropEntriesCrop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCropEntriesCrop.Location = New System.Drawing.Point(343, 26)
        Me.DataGridViewCropEntriesCrop.Name = "DataGridViewCropEntriesCrop"
        Me.DataGridViewCropEntriesCrop.Size = New System.Drawing.Size(526, 259)
        Me.DataGridViewCropEntriesCrop.TabIndex = 12
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(553, 350)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(101, 41)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonModify
        '
        Me.ButtonModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModify.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModify.ForeColor = System.Drawing.Color.White
        Me.ButtonModify.Location = New System.Drawing.Point(660, 303)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(101, 41)
        Me.ButtonModify.TabIndex = 14
        Me.ButtonModify.Text = "Modify"
        Me.ButtonModify.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(553, 303)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(101, 41)
        Me.ButtonClear.TabIndex = 15
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(660, 350)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(101, 41)
        Me.ButtonDelete.TabIndex = 16
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(767, 350)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(101, 41)
        Me.ButtonClose.TabIndex = 17
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(178, 259)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 26)
        Me.TextBox1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 27)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Farmer Id"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(767, 303)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(101, 41)
        Me.btnRefresh.TabIndex = 20
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'DateTimePickerProductOrderDate
        '
        Me.DateTimePickerProductOrderDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerProductOrderDate.Location = New System.Drawing.Point(109, 26)
        Me.DateTimePickerProductOrderDate.Name = "DateTimePickerProductOrderDate"
        Me.DateTimePickerProductOrderDate.Size = New System.Drawing.Size(228, 25)
        Me.DateTimePickerProductOrderDate.TabIndex = 21
        '
        'MakePurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(902, 404)
        Me.Controls.Add(Me.DateTimePickerProductOrderDate)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonModify)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.DataGridViewCropEntriesCrop)
        Me.Controls.Add(Me.ComboBoxCropEntriesSeason)
        Me.Controls.Add(Me.ComboBoxCropEntriesCategory)
        Me.Controls.Add(Me.TextBoxCropEntriesSellingPrice)
        Me.Controls.Add(Me.LabelCropEntriesSeason)
        Me.Controls.Add(Me.LabelCropEntriesSellingPrice)
        Me.Controls.Add(Me.LabelCropEntriesPurchasePrice)
        Me.Controls.Add(Me.LabelCropEntriesCategory)
        Me.Controls.Add(Me.LabelCropEntriesCropCode)
        Me.Controls.Add(Me.LabelCropEntriesCropName)
        Me.Controls.Add(Me.TextBoxCropEntriesPurchasePrice)
        Me.Controls.Add(Me.TextBoxCropEntriesCropCode)
        Me.Name = "MakePurchase"
        Me.Text = "CropForm"
        CType(Me.DataGridViewCropEntriesCrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxCropEntriesCropCode As TextBox
    Friend WithEvents TextBoxCropEntriesPurchasePrice As TextBox
    Friend WithEvents LabelCropEntriesCropName As Label
    Friend WithEvents LabelCropEntriesCropCode As Label
    Friend WithEvents LabelCropEntriesCategory As Label
    Friend WithEvents LabelCropEntriesPurchasePrice As Label
    Friend WithEvents LabelCropEntriesSellingPrice As Label
    Friend WithEvents LabelCropEntriesSeason As Label
    Friend WithEvents TextBoxCropEntriesSellingPrice As TextBox
    Friend WithEvents ComboBoxCropEntriesCategory As ComboBox
    Friend WithEvents ComboBoxCropEntriesSeason As ComboBox
    Friend WithEvents DataGridViewCropEntriesCrop As DataGridView
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DateTimePickerProductOrderDate As DateTimePicker
End Class
