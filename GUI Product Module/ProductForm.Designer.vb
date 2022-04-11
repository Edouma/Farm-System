<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductForm))
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelProductID = New System.Windows.Forms.Label()
        Me.LabelProductCategory = New System.Windows.Forms.Label()
        Me.LabelProductPrice = New System.Windows.Forms.Label()
        Me.LabelProductDate = New System.Windows.Forms.Label()
        Me.LabelProductPaymentMethod = New System.Windows.Forms.Label()
        Me.TextBoxProductName = New System.Windows.Forms.TextBox()
        Me.TextBoxProductID = New System.Windows.Forms.TextBox()
        Me.TextBoxProductPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxProductPaymentMethod = New System.Windows.Forms.TextBox()
        Me.ComboBoxProductCategory = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LabelProductReport = New System.Windows.Forms.Label()
        Me.ComboBoxProductReport = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.ForeColor = System.Drawing.Color.White
        Me.LabelProductName.Location = New System.Drawing.Point(112, 102)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(64, 27)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Name"
        '
        'LabelProductID
        '
        Me.LabelProductID.AutoSize = True
        Me.LabelProductID.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductID.ForeColor = System.Drawing.Color.White
        Me.LabelProductID.Location = New System.Drawing.Point(137, 134)
        Me.LabelProductID.Name = "LabelProductID"
        Me.LabelProductID.Size = New System.Drawing.Size(36, 27)
        Me.LabelProductID.TabIndex = 1
        Me.LabelProductID.Text = "ID"
        '
        'LabelProductCategory
        '
        Me.LabelProductCategory.AutoSize = True
        Me.LabelProductCategory.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductCategory.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductCategory.ForeColor = System.Drawing.Color.White
        Me.LabelProductCategory.Location = New System.Drawing.Point(81, 167)
        Me.LabelProductCategory.Name = "LabelProductCategory"
        Me.LabelProductCategory.Size = New System.Drawing.Size(95, 27)
        Me.LabelProductCategory.TabIndex = 2
        Me.LabelProductCategory.Text = "Category"
        '
        'LabelProductPrice
        '
        Me.LabelProductPrice.AutoSize = True
        Me.LabelProductPrice.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductPrice.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductPrice.ForeColor = System.Drawing.Color.White
        Me.LabelProductPrice.Location = New System.Drawing.Point(120, 209)
        Me.LabelProductPrice.Name = "LabelProductPrice"
        Me.LabelProductPrice.Size = New System.Drawing.Size(57, 27)
        Me.LabelProductPrice.TabIndex = 3
        Me.LabelProductPrice.Text = "Price"
        '
        'LabelProductDate
        '
        Me.LabelProductDate.AutoSize = True
        Me.LabelProductDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductDate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductDate.ForeColor = System.Drawing.Color.White
        Me.LabelProductDate.Location = New System.Drawing.Point(119, 248)
        Me.LabelProductDate.Name = "LabelProductDate"
        Me.LabelProductDate.Size = New System.Drawing.Size(57, 27)
        Me.LabelProductDate.TabIndex = 4
        Me.LabelProductDate.Text = "Date"
        '
        'LabelProductPaymentMethod
        '
        Me.LabelProductPaymentMethod.AutoSize = True
        Me.LabelProductPaymentMethod.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductPaymentMethod.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductPaymentMethod.ForeColor = System.Drawing.Color.White
        Me.LabelProductPaymentMethod.Location = New System.Drawing.Point(11, 286)
        Me.LabelProductPaymentMethod.Name = "LabelProductPaymentMethod"
        Me.LabelProductPaymentMethod.Size = New System.Drawing.Size(166, 27)
        Me.LabelProductPaymentMethod.TabIndex = 5
        Me.LabelProductPaymentMethod.Text = "Payment Method"
        '
        'TextBoxProductName
        '
        Me.TextBoxProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductName.Location = New System.Drawing.Point(189, 102)
        Me.TextBoxProductName.Name = "TextBoxProductName"
        Me.TextBoxProductName.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxProductName.TabIndex = 6
        '
        'TextBoxProductID
        '
        Me.TextBoxProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductID.Location = New System.Drawing.Point(189, 136)
        Me.TextBoxProductID.Name = "TextBoxProductID"
        Me.TextBoxProductID.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxProductID.TabIndex = 7
        '
        'TextBoxProductPrice
        '
        Me.TextBoxProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductPrice.Location = New System.Drawing.Point(188, 209)
        Me.TextBoxProductPrice.Name = "TextBoxProductPrice"
        Me.TextBoxProductPrice.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxProductPrice.TabIndex = 8
        '
        'TextBoxProductPaymentMethod
        '
        Me.TextBoxProductPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductPaymentMethod.Location = New System.Drawing.Point(188, 287)
        Me.TextBoxProductPaymentMethod.Name = "TextBoxProductPaymentMethod"
        Me.TextBoxProductPaymentMethod.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxProductPaymentMethod.TabIndex = 9
        '
        'ComboBoxProductCategory
        '
        Me.ComboBoxProductCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProductCategory.FormattingEnabled = True
        Me.ComboBoxProductCategory.Location = New System.Drawing.Point(189, 169)
        Me.ComboBoxProductCategory.Name = "ComboBoxProductCategory"
        Me.ComboBoxProductCategory.Size = New System.Drawing.Size(207, 28)
        Me.ComboBoxProductCategory.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(188, 248)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(208, 22)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 96)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(885, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(177, 94)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(708, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(177, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(531, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(177, 94)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(354, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(177, 94)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(177, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(23, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 37)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(142, 486)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 37)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(262, 486)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 37)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(84, 534)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 37)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Remove"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(202, 534)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 37)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 337)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(450, 131)
        Me.DataGridView1.TabIndex = 18
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(493, 147)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(275, 321)
        Me.DataGridView2.TabIndex = 19
        '
        'LabelProductReport
        '
        Me.LabelProductReport.AutoSize = True
        Me.LabelProductReport.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductReport.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductReport.ForeColor = System.Drawing.Color.White
        Me.LabelProductReport.Location = New System.Drawing.Point(488, 111)
        Me.LabelProductReport.Name = "LabelProductReport"
        Me.LabelProductReport.Size = New System.Drawing.Size(73, 27)
        Me.LabelProductReport.TabIndex = 21
        Me.LabelProductReport.Text = "Report"
        '
        'ComboBoxProductReport
        '
        Me.ComboBoxProductReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProductReport.FormattingEnabled = True
        Me.ComboBoxProductReport.Location = New System.Drawing.Point(567, 115)
        Me.ComboBoxProductReport.Name = "ComboBoxProductReport"
        Me.ComboBoxProductReport.Size = New System.Drawing.Size(201, 23)
        Me.ComboBoxProductReport.TabIndex = 22
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 582)
        Me.Controls.Add(Me.ComboBoxProductReport)
        Me.Controls.Add(Me.LabelProductReport)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBoxProductCategory)
        Me.Controls.Add(Me.TextBoxProductPaymentMethod)
        Me.Controls.Add(Me.TextBoxProductPrice)
        Me.Controls.Add(Me.TextBoxProductID)
        Me.Controls.Add(Me.TextBoxProductName)
        Me.Controls.Add(Me.LabelProductPaymentMethod)
        Me.Controls.Add(Me.LabelProductDate)
        Me.Controls.Add(Me.LabelProductPrice)
        Me.Controls.Add(Me.LabelProductCategory)
        Me.Controls.Add(Me.LabelProductID)
        Me.Controls.Add(Me.LabelProductName)
        Me.Name = "ProductForm"
        Me.Text = "ProductForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelProductName As Label
    Friend WithEvents LabelProductID As Label
    Friend WithEvents LabelProductCategory As Label
    Friend WithEvents LabelProductPrice As Label
    Friend WithEvents LabelProductDate As Label
    Friend WithEvents LabelProductPaymentMethod As Label
    Friend WithEvents TextBoxProductName As TextBox
    Friend WithEvents TextBoxProductID As TextBox
    Friend WithEvents TextBoxProductPrice As TextBox
    Friend WithEvents TextBoxProductPaymentMethod As TextBox
    Friend WithEvents ComboBoxProductCategory As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents LabelProductReport As Label
    Friend WithEvents ComboBoxProductReport As ComboBox
End Class
