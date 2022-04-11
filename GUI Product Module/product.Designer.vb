<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(product))
        Me.LabelProductOrderCustomerID = New System.Windows.Forms.Label()
        Me.LabelProductOrderPrice = New System.Windows.Forms.Label()
        Me.LabelProductOrderDate = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxProductOrderPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxProductOrderPaymentMethod = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelProductOrderCustomerID
        '
        Me.LabelProductOrderCustomerID.AutoSize = True
        Me.LabelProductOrderCustomerID.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductOrderCustomerID.Location = New System.Drawing.Point(91, 66)
        Me.LabelProductOrderCustomerID.Name = "LabelProductOrderCustomerID"
        Me.LabelProductOrderCustomerID.Size = New System.Drawing.Size(96, 23)
        Me.LabelProductOrderCustomerID.TabIndex = 0
        Me.LabelProductOrderCustomerID.Text = "Product ID"
        '
        'LabelProductOrderPrice
        '
        Me.LabelProductOrderPrice.AutoSize = True
        Me.LabelProductOrderPrice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductOrderPrice.Location = New System.Drawing.Point(91, 102)
        Me.LabelProductOrderPrice.Name = "LabelProductOrderPrice"
        Me.LabelProductOrderPrice.Size = New System.Drawing.Size(125, 23)
        Me.LabelProductOrderPrice.TabIndex = 2
        Me.LabelProductOrderPrice.Text = "Product Name:"
        '
        'LabelProductOrderDate
        '
        Me.LabelProductOrderDate.AutoSize = True
        Me.LabelProductOrderDate.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductOrderDate.Location = New System.Drawing.Point(91, 131)
        Me.LabelProductOrderDate.Name = "LabelProductOrderDate"
        Me.LabelProductOrderDate.Size = New System.Drawing.Size(48, 23)
        Me.LabelProductOrderDate.TabIndex = 4
        Me.LabelProductOrderDate.Text = "Price"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(249, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 26)
        Me.TextBox1.TabIndex = 6
        '
        'TextBoxProductOrderPrice
        '
        Me.TextBoxProductOrderPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductOrderPrice.Location = New System.Drawing.Point(249, 98)
        Me.TextBoxProductOrderPrice.Name = "TextBoxProductOrderPrice"
        Me.TextBoxProductOrderPrice.Size = New System.Drawing.Size(227, 26)
        Me.TextBoxProductOrderPrice.TabIndex = 8
        '
        'TextBoxProductOrderPaymentMethod
        '
        Me.TextBoxProductOrderPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductOrderPaymentMethod.Location = New System.Drawing.Point(249, 130)
        Me.TextBoxProductOrderPaymentMethod.Name = "TextBoxProductOrderPaymentMethod"
        Me.TextBoxProductOrderPaymentMethod.Size = New System.Drawing.Size(227, 26)
        Me.TextBoxProductOrderPaymentMethod.TabIndex = 9
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Location = New System.Drawing.Point(42, 228)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(96, 35)
        Me.ButtonAdd.TabIndex = 13
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonModify
        '
        Me.ButtonModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModify.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModify.ForeColor = System.Drawing.Color.White
        Me.ButtonModify.Location = New System.Drawing.Point(144, 187)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(96, 35)
        Me.ButtonModify.TabIndex = 14
        Me.ButtonModify.Text = "Modify"
        Me.ButtonModify.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(144, 228)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(96, 35)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(42, 187)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(96, 35)
        Me.ButtonClear.TabIndex = 16
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(246, 228)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(96, 35)
        Me.ButtonClose.TabIndex = 17
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 267)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonModify)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxProductOrderPaymentMethod)
        Me.Controls.Add(Me.TextBoxProductOrderPrice)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelProductOrderDate)
        Me.Controls.Add(Me.LabelProductOrderPrice)
        Me.Controls.Add(Me.LabelProductOrderCustomerID)
        Me.Name = "product"
        Me.Text = "OrderForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelProductOrderCustomerID As Label
    Friend WithEvents LabelProductOrderPrice As Label
    Friend WithEvents LabelProductOrderDate As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxProductOrderPrice As TextBox
    Friend WithEvents TextBoxProductOrderPaymentMethod As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonClose As Button
End Class
