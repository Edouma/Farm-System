<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderForm))
        Me.LabelSellerOrderCustomerID = New System.Windows.Forms.Label()
        Me.LabelSellerOrderAddress = New System.Windows.Forms.Label()
        Me.LabelSellerOrderPrice = New System.Windows.Forms.Label()
        Me.LabelSellerOrderStatus = New System.Windows.Forms.Label()
        Me.LabelSellerOrderDate = New System.Windows.Forms.Label()
        Me.LabelSellerOrderPaymetMethod = New System.Windows.Forms.Label()
        Me.TextBoxSellerOrderCustomerID = New System.Windows.Forms.TextBox()
        Me.TextBoxSellerOrderAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxSellerOrderPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxSellerOrderPaymentMethod = New System.Windows.Forms.TextBox()
        Me.ComboBoxSellerOrderStatus = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerSellerOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonViewOrders = New System.Windows.Forms.Button()
        Me.DataGridViewSellerOrder = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSellerOrderQuantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewSellerOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelSellerOrderCustomerID
        '
        Me.LabelSellerOrderCustomerID.AutoSize = True
        Me.LabelSellerOrderCustomerID.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSellerOrderCustomerID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerOrderCustomerID.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerOrderCustomerID.Location = New System.Drawing.Point(34, 47)
        Me.LabelSellerOrderCustomerID.Name = "LabelSellerOrderCustomerID"
        Me.LabelSellerOrderCustomerID.Size = New System.Drawing.Size(129, 27)
        Me.LabelSellerOrderCustomerID.TabIndex = 0
        Me.LabelSellerOrderCustomerID.Text = "Customer ID"
        '
        'LabelSellerOrderAddress
        '
        Me.LabelSellerOrderAddress.AutoSize = True
        Me.LabelSellerOrderAddress.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSellerOrderAddress.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerOrderAddress.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerOrderAddress.Location = New System.Drawing.Point(37, 124)
        Me.LabelSellerOrderAddress.Name = "LabelSellerOrderAddress"
        Me.LabelSellerOrderAddress.Size = New System.Drawing.Size(86, 27)
        Me.LabelSellerOrderAddress.TabIndex = 1
        Me.LabelSellerOrderAddress.Text = "Address"
        '
        'LabelSellerOrderPrice
        '
        Me.LabelSellerOrderPrice.AutoSize = True
        Me.LabelSellerOrderPrice.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSellerOrderPrice.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerOrderPrice.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerOrderPrice.Location = New System.Drawing.Point(37, 159)
        Me.LabelSellerOrderPrice.Name = "LabelSellerOrderPrice"
        Me.LabelSellerOrderPrice.Size = New System.Drawing.Size(57, 27)
        Me.LabelSellerOrderPrice.TabIndex = 2
        Me.LabelSellerOrderPrice.Text = "Price"
        '
        'LabelSellerOrderStatus
        '
        Me.LabelSellerOrderStatus.AutoSize = True
        Me.LabelSellerOrderStatus.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSellerOrderStatus.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerOrderStatus.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerOrderStatus.Location = New System.Drawing.Point(37, 270)
        Me.LabelSellerOrderStatus.Name = "LabelSellerOrderStatus"
        Me.LabelSellerOrderStatus.Size = New System.Drawing.Size(73, 27)
        Me.LabelSellerOrderStatus.TabIndex = 3
        Me.LabelSellerOrderStatus.Text = "Status"
        '
        'LabelSellerOrderDate
        '
        Me.LabelSellerOrderDate.AutoSize = True
        Me.LabelSellerOrderDate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSellerOrderDate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerOrderDate.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerOrderDate.Location = New System.Drawing.Point(37, 309)
        Me.LabelSellerOrderDate.Name = "LabelSellerOrderDate"
        Me.LabelSellerOrderDate.Size = New System.Drawing.Size(92, 27)
        Me.LabelSellerOrderDate.TabIndex = 4
        Me.LabelSellerOrderDate.Text = "Bill Date"
        '
        'LabelSellerOrderPaymetMethod
        '
        Me.LabelSellerOrderPaymetMethod.AutoSize = True
        Me.LabelSellerOrderPaymetMethod.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSellerOrderPaymetMethod.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerOrderPaymetMethod.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerOrderPaymetMethod.Location = New System.Drawing.Point(37, 345)
        Me.LabelSellerOrderPaymetMethod.Name = "LabelSellerOrderPaymetMethod"
        Me.LabelSellerOrderPaymetMethod.Size = New System.Drawing.Size(166, 27)
        Me.LabelSellerOrderPaymetMethod.TabIndex = 5
        Me.LabelSellerOrderPaymetMethod.Text = "Payment Method"
        '
        'TextBoxSellerOrderCustomerID
        '
        Me.TextBoxSellerOrderCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerOrderCustomerID.Location = New System.Drawing.Point(206, 47)
        Me.TextBoxSellerOrderCustomerID.Name = "TextBoxSellerOrderCustomerID"
        Me.TextBoxSellerOrderCustomerID.Size = New System.Drawing.Size(190, 24)
        Me.TextBoxSellerOrderCustomerID.TabIndex = 6
        '
        'TextBoxSellerOrderAddress
        '
        Me.TextBoxSellerOrderAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerOrderAddress.Location = New System.Drawing.Point(209, 124)
        Me.TextBoxSellerOrderAddress.Name = "TextBoxSellerOrderAddress"
        Me.TextBoxSellerOrderAddress.Size = New System.Drawing.Size(190, 24)
        Me.TextBoxSellerOrderAddress.TabIndex = 7
        '
        'TextBoxSellerOrderPrice
        '
        Me.TextBoxSellerOrderPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerOrderPrice.Location = New System.Drawing.Point(209, 159)
        Me.TextBoxSellerOrderPrice.Name = "TextBoxSellerOrderPrice"
        Me.TextBoxSellerOrderPrice.Size = New System.Drawing.Size(190, 24)
        Me.TextBoxSellerOrderPrice.TabIndex = 8
        '
        'TextBoxSellerOrderPaymentMethod
        '
        Me.TextBoxSellerOrderPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerOrderPaymentMethod.Location = New System.Drawing.Point(209, 348)
        Me.TextBoxSellerOrderPaymentMethod.Name = "TextBoxSellerOrderPaymentMethod"
        Me.TextBoxSellerOrderPaymentMethod.Size = New System.Drawing.Size(187, 24)
        Me.TextBoxSellerOrderPaymentMethod.TabIndex = 9
        '
        'ComboBoxSellerOrderStatus
        '
        Me.ComboBoxSellerOrderStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSellerOrderStatus.FormattingEnabled = True
        Me.ComboBoxSellerOrderStatus.Location = New System.Drawing.Point(209, 270)
        Me.ComboBoxSellerOrderStatus.Name = "ComboBoxSellerOrderStatus"
        Me.ComboBoxSellerOrderStatus.Size = New System.Drawing.Size(190, 24)
        Me.ComboBoxSellerOrderStatus.TabIndex = 10
        '
        'DateTimePickerSellerOrderDate
        '
        Me.DateTimePickerSellerOrderDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerSellerOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerSellerOrderDate.Location = New System.Drawing.Point(209, 309)
        Me.DateTimePickerSellerOrderDate.Name = "DateTimePickerSellerOrderDate"
        Me.DateTimePickerSellerOrderDate.Size = New System.Drawing.Size(190, 24)
        Me.DateTimePickerSellerOrderDate.TabIndex = 11
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Location = New System.Drawing.Point(18, 480)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(101, 37)
        Me.ButtonAdd.TabIndex = 12
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonModify
        '
        Me.ButtonModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModify.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModify.ForeColor = System.Drawing.Color.White
        Me.ButtonModify.Location = New System.Drawing.Point(143, 480)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(101, 37)
        Me.ButtonModify.TabIndex = 13
        Me.ButtonModify.Text = "Modify"
        Me.ButtonModify.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(271, 480)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(101, 37)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(399, 480)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(101, 37)
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
        Me.ButtonClose.Location = New System.Drawing.Point(529, 480)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(101, 37)
        Me.ButtonClose.TabIndex = 16
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'ButtonViewOrders
        '
        Me.ButtonViewOrders.Location = New System.Drawing.Point(604, 12)
        Me.ButtonViewOrders.Name = "ButtonViewOrders"
        Me.ButtonViewOrders.Size = New System.Drawing.Size(102, 29)
        Me.ButtonViewOrders.TabIndex = 17
        Me.ButtonViewOrders.Text = "View Orders"
        Me.ButtonViewOrders.UseVisualStyleBackColor = True
        '
        'DataGridViewSellerOrder
        '
        Me.DataGridViewSellerOrder.BackgroundColor = System.Drawing.Color.SpringGreen
        Me.DataGridViewSellerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSellerOrder.Location = New System.Drawing.Point(447, 47)
        Me.DataGridViewSellerOrder.Name = "DataGridViewSellerOrder"
        Me.DataGridViewSellerOrder.Size = New System.Drawing.Size(414, 281)
        Me.DataGridViewSellerOrder.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(37, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 27)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Quantity"
        '
        'TextBoxSellerOrderQuantity
        '
        Me.TextBoxSellerOrderQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerOrderQuantity.Location = New System.Drawing.Point(209, 198)
        Me.TextBoxSellerOrderQuantity.Name = "TextBoxSellerOrderQuantity"
        Me.TextBoxSellerOrderQuantity.Size = New System.Drawing.Size(190, 24)
        Me.TextBoxSellerOrderQuantity.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Total"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(209, 237)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(190, 24)
        Me.TextBox2.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 27)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Product Code"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(206, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 24)
        Me.TextBox1.TabIndex = 24
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(873, 525)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxSellerOrderQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewSellerOrder)
        Me.Controls.Add(Me.ButtonViewOrders)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonModify)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.DateTimePickerSellerOrderDate)
        Me.Controls.Add(Me.ComboBoxSellerOrderStatus)
        Me.Controls.Add(Me.TextBoxSellerOrderPaymentMethod)
        Me.Controls.Add(Me.TextBoxSellerOrderPrice)
        Me.Controls.Add(Me.TextBoxSellerOrderAddress)
        Me.Controls.Add(Me.TextBoxSellerOrderCustomerID)
        Me.Controls.Add(Me.LabelSellerOrderPaymetMethod)
        Me.Controls.Add(Me.LabelSellerOrderDate)
        Me.Controls.Add(Me.LabelSellerOrderStatus)
        Me.Controls.Add(Me.LabelSellerOrderPrice)
        Me.Controls.Add(Me.LabelSellerOrderAddress)
        Me.Controls.Add(Me.LabelSellerOrderCustomerID)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        CType(Me.DataGridViewSellerOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSellerOrderCustomerID As Label
    Friend WithEvents LabelSellerOrderAddress As Label
    Friend WithEvents LabelSellerOrderPrice As Label
    Friend WithEvents LabelSellerOrderStatus As Label
    Friend WithEvents LabelSellerOrderDate As Label
    Friend WithEvents LabelSellerOrderPaymetMethod As Label
    Friend WithEvents TextBoxSellerOrderCustomerID As TextBox
    Friend WithEvents TextBoxSellerOrderAddress As TextBox
    Friend WithEvents TextBoxSellerOrderPrice As TextBox
    Friend WithEvents TextBoxSellerOrderPaymentMethod As TextBox
    Friend WithEvents ComboBoxSellerOrderStatus As ComboBox
    Friend WithEvents DateTimePickerSellerOrderDate As DateTimePicker
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonViewOrders As Button
    Friend WithEvents DataGridViewSellerOrder As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSellerOrderQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
