<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Me.LabelPaymentOrderID = New System.Windows.Forms.Label()
        Me.LabelPaymentAmount = New System.Windows.Forms.Label()
        Me.LabelPaymentTransID = New System.Windows.Forms.Label()
        Me.LabelPaymentTransDate = New System.Windows.Forms.Label()
        Me.LabelPaymentStatus = New System.Windows.Forms.Label()
        Me.LabelPaymentRemarks = New System.Windows.Forms.Label()
        Me.TextBoxPaymentOrderID = New System.Windows.Forms.TextBox()
        Me.TextBoxPaymentAmount = New System.Windows.Forms.TextBox()
        Me.TextBoxPaymentTransID = New System.Windows.Forms.TextBox()
        Me.TextBoxPaymentRemarks = New System.Windows.Forms.TextBox()
        Me.ComboBoxPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerPaymentTransDate = New System.Windows.Forms.DateTimePicker()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonList = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.LabelPaymentTotal = New System.Windows.Forms.Label()
        Me.LabelPaymentOtherChanges = New System.Windows.Forms.Label()
        Me.LabelPaymentGrandTotal = New System.Windows.Forms.Label()
        Me.TextBoxPaymentTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxPaymentOtherChanges = New System.Windows.Forms.TextBox()
        Me.TextBoxPaymentGrandTotal = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelPaymentOrderID
        '
        Me.LabelPaymentOrderID.AutoSize = True
        Me.LabelPaymentOrderID.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaymentOrderID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentOrderID.ForeColor = System.Drawing.Color.White
        Me.LabelPaymentOrderID.Location = New System.Drawing.Point(305, 184)
        Me.LabelPaymentOrderID.Name = "LabelPaymentOrderID"
        Me.LabelPaymentOrderID.Size = New System.Drawing.Size(99, 27)
        Me.LabelPaymentOrderID.TabIndex = 0
        Me.LabelPaymentOrderID.Text = "Order ID"
        '
        'LabelPaymentAmount
        '
        Me.LabelPaymentAmount.AutoSize = True
        Me.LabelPaymentAmount.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaymentAmount.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentAmount.ForeColor = System.Drawing.Color.White
        Me.LabelPaymentAmount.Location = New System.Drawing.Point(30, 138)
        Me.LabelPaymentAmount.Name = "LabelPaymentAmount"
        Me.LabelPaymentAmount.Size = New System.Drawing.Size(80, 27)
        Me.LabelPaymentAmount.TabIndex = 1
        Me.LabelPaymentAmount.Text = "Amount"
        '
        'LabelPaymentTransID
        '
        Me.LabelPaymentTransID.AutoSize = True
        Me.LabelPaymentTransID.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaymentTransID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentTransID.ForeColor = System.Drawing.Color.White
        Me.LabelPaymentTransID.Location = New System.Drawing.Point(8, 53)
        Me.LabelPaymentTransID.Name = "LabelPaymentTransID"
        Me.LabelPaymentTransID.Size = New System.Drawing.Size(96, 27)
        Me.LabelPaymentTransID.TabIndex = 2
        Me.LabelPaymentTransID.Text = "Trans ID"
        '
        'LabelPaymentTransDate
        '
        Me.LabelPaymentTransDate.AutoSize = True
        Me.LabelPaymentTransDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaymentTransDate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentTransDate.ForeColor = System.Drawing.Color.White
        Me.LabelPaymentTransDate.Location = New System.Drawing.Point(289, 54)
        Me.LabelPaymentTransDate.Name = "LabelPaymentTransDate"
        Me.LabelPaymentTransDate.Size = New System.Drawing.Size(117, 27)
        Me.LabelPaymentTransDate.TabIndex = 3
        Me.LabelPaymentTransDate.Text = "Trans Date"
        '
        'LabelPaymentStatus
        '
        Me.LabelPaymentStatus.AutoSize = True
        Me.LabelPaymentStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaymentStatus.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentStatus.ForeColor = System.Drawing.Color.White
        Me.LabelPaymentStatus.Location = New System.Drawing.Point(32, 104)
        Me.LabelPaymentStatus.Name = "LabelPaymentStatus"
        Me.LabelPaymentStatus.Size = New System.Drawing.Size(73, 27)
        Me.LabelPaymentStatus.TabIndex = 4
        Me.LabelPaymentStatus.Text = "Status"
        '
        'LabelPaymentRemarks
        '
        Me.LabelPaymentRemarks.AutoSize = True
        Me.LabelPaymentRemarks.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaymentRemarks.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentRemarks.ForeColor = System.Drawing.Color.White
        Me.LabelPaymentRemarks.Location = New System.Drawing.Point(313, 108)
        Me.LabelPaymentRemarks.Name = "LabelPaymentRemarks"
        Me.LabelPaymentRemarks.Size = New System.Drawing.Size(89, 27)
        Me.LabelPaymentRemarks.TabIndex = 5
        Me.LabelPaymentRemarks.Text = "Remarks"
        '
        'TextBoxPaymentOrderID
        '
        Me.TextBoxPaymentOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaymentOrderID.Location = New System.Drawing.Point(407, 184)
        Me.TextBoxPaymentOrderID.Name = "TextBoxPaymentOrderID"
        Me.TextBoxPaymentOrderID.Size = New System.Drawing.Size(147, 26)
        Me.TextBoxPaymentOrderID.TabIndex = 6
        '
        'TextBoxPaymentAmount
        '
        Me.TextBoxPaymentAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaymentAmount.Location = New System.Drawing.Point(111, 138)
        Me.TextBoxPaymentAmount.Name = "TextBoxPaymentAmount"
        Me.TextBoxPaymentAmount.Size = New System.Drawing.Size(147, 26)
        Me.TextBoxPaymentAmount.TabIndex = 7
        '
        'TextBoxPaymentTransID
        '
        Me.TextBoxPaymentTransID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaymentTransID.Location = New System.Drawing.Point(110, 55)
        Me.TextBoxPaymentTransID.Name = "TextBoxPaymentTransID"
        Me.TextBoxPaymentTransID.Size = New System.Drawing.Size(147, 26)
        Me.TextBoxPaymentTransID.TabIndex = 8
        '
        'TextBoxPaymentRemarks
        '
        Me.TextBoxPaymentRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaymentRemarks.Location = New System.Drawing.Point(408, 95)
        Me.TextBoxPaymentRemarks.Name = "TextBoxPaymentRemarks"
        Me.TextBoxPaymentRemarks.Size = New System.Drawing.Size(213, 80)
        Me.TextBoxPaymentRemarks.TabIndex = 9
        '
        'ComboBoxPaymentStatus
        '
        Me.ComboBoxPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPaymentStatus.FormattingEnabled = True
        Me.ComboBoxPaymentStatus.Location = New System.Drawing.Point(111, 104)
        Me.ComboBoxPaymentStatus.Name = "ComboBoxPaymentStatus"
        Me.ComboBoxPaymentStatus.Size = New System.Drawing.Size(147, 28)
        Me.ComboBoxPaymentStatus.TabIndex = 10
        '
        'DateTimePickerPaymentTransDate
        '
        Me.DateTimePickerPaymentTransDate.CalendarFont = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerPaymentTransDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerPaymentTransDate.Location = New System.Drawing.Point(407, 58)
        Me.DateTimePickerPaymentTransDate.Name = "DateTimePickerPaymentTransDate"
        Me.DateTimePickerPaymentTransDate.Size = New System.Drawing.Size(213, 22)
        Me.DateTimePickerPaymentTransDate.TabIndex = 11
        '
        'ButtonNew
        '
        Me.ButtonNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNew.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNew.ForeColor = System.Drawing.Color.White
        Me.ButtonNew.Location = New System.Drawing.Point(21, 563)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(105, 34)
        Me.ButtonNew.TabIndex = 12
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(152, 563)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(105, 34)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonList
        '
        Me.ButtonList.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonList.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonList.ForeColor = System.Drawing.Color.White
        Me.ButtonList.Location = New System.Drawing.Point(286, 563)
        Me.ButtonList.Name = "ButtonList"
        Me.ButtonList.Size = New System.Drawing.Size(105, 34)
        Me.ButtonList.TabIndex = 14
        Me.ButtonList.Text = "List"
        Me.ButtonList.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(420, 563)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(105, 34)
        Me.ButtonClear.TabIndex = 15
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'LabelPaymentTotal
        '
        Me.LabelPaymentTotal.AutoSize = True
        Me.LabelPaymentTotal.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaymentTotal.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentTotal.Location = New System.Drawing.Point(465, 448)
        Me.LabelPaymentTotal.Name = "LabelPaymentTotal"
        Me.LabelPaymentTotal.Size = New System.Drawing.Size(60, 27)
        Me.LabelPaymentTotal.TabIndex = 16
        Me.LabelPaymentTotal.Text = "Total"
        '
        'LabelPaymentOtherChanges
        '
        Me.LabelPaymentOtherChanges.AutoSize = True
        Me.LabelPaymentOtherChanges.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaymentOtherChanges.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentOtherChanges.Location = New System.Drawing.Point(376, 484)
        Me.LabelPaymentOtherChanges.Name = "LabelPaymentOtherChanges"
        Me.LabelPaymentOtherChanges.Size = New System.Drawing.Size(149, 27)
        Me.LabelPaymentOtherChanges.TabIndex = 17
        Me.LabelPaymentOtherChanges.Text = "Other Changes"
        '
        'LabelPaymentGrandTotal
        '
        Me.LabelPaymentGrandTotal.AutoSize = True
        Me.LabelPaymentGrandTotal.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaymentGrandTotal.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentGrandTotal.Location = New System.Drawing.Point(403, 523)
        Me.LabelPaymentGrandTotal.Name = "LabelPaymentGrandTotal"
        Me.LabelPaymentGrandTotal.Size = New System.Drawing.Size(122, 27)
        Me.LabelPaymentGrandTotal.TabIndex = 18
        Me.LabelPaymentGrandTotal.Text = "Grand Total"
        '
        'TextBoxPaymentTotal
        '
        Me.TextBoxPaymentTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaymentTotal.Location = New System.Drawing.Point(541, 450)
        Me.TextBoxPaymentTotal.Name = "TextBoxPaymentTotal"
        Me.TextBoxPaymentTotal.Size = New System.Drawing.Size(159, 26)
        Me.TextBoxPaymentTotal.TabIndex = 19
        '
        'TextBoxPaymentOtherChanges
        '
        Me.TextBoxPaymentOtherChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaymentOtherChanges.Location = New System.Drawing.Point(541, 488)
        Me.TextBoxPaymentOtherChanges.Name = "TextBoxPaymentOtherChanges"
        Me.TextBoxPaymentOtherChanges.Size = New System.Drawing.Size(159, 26)
        Me.TextBoxPaymentOtherChanges.TabIndex = 20
        '
        'TextBoxPaymentGrandTotal
        '
        Me.TextBoxPaymentGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPaymentGrandTotal.Location = New System.Drawing.Point(541, 526)
        Me.TextBoxPaymentGrandTotal.Name = "TextBoxPaymentGrandTotal"
        Me.TextBoxPaymentGrandTotal.Size = New System.Drawing.Size(159, 26)
        Me.TextBoxPaymentGrandTotal.TabIndex = 21
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(733, 488)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(105, 37)
        Me.ButtonClose.TabIndex = 22
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gold
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 253)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(588, 169)
        Me.DataGridView1.TabIndex = 23
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(849, 606)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.TextBoxPaymentGrandTotal)
        Me.Controls.Add(Me.TextBoxPaymentOtherChanges)
        Me.Controls.Add(Me.TextBoxPaymentTotal)
        Me.Controls.Add(Me.LabelPaymentGrandTotal)
        Me.Controls.Add(Me.LabelPaymentOtherChanges)
        Me.Controls.Add(Me.LabelPaymentTotal)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonList)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.DateTimePickerPaymentTransDate)
        Me.Controls.Add(Me.ComboBoxPaymentStatus)
        Me.Controls.Add(Me.TextBoxPaymentRemarks)
        Me.Controls.Add(Me.TextBoxPaymentTransID)
        Me.Controls.Add(Me.TextBoxPaymentAmount)
        Me.Controls.Add(Me.TextBoxPaymentOrderID)
        Me.Controls.Add(Me.LabelPaymentRemarks)
        Me.Controls.Add(Me.LabelPaymentStatus)
        Me.Controls.Add(Me.LabelPaymentTransDate)
        Me.Controls.Add(Me.LabelPaymentTransID)
        Me.Controls.Add(Me.LabelPaymentAmount)
        Me.Controls.Add(Me.LabelPaymentOrderID)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "PaymentForm"
        Me.Text = "PaymentForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPaymentOrderID As Label
    Friend WithEvents LabelPaymentAmount As Label
    Friend WithEvents LabelPaymentTransID As Label
    Friend WithEvents LabelPaymentTransDate As Label
    Friend WithEvents LabelPaymentStatus As Label
    Friend WithEvents LabelPaymentRemarks As Label
    Friend WithEvents TextBoxPaymentOrderID As TextBox
    Friend WithEvents TextBoxPaymentAmount As TextBox
    Friend WithEvents TextBoxPaymentTransID As TextBox
    Friend WithEvents TextBoxPaymentRemarks As TextBox
    Friend WithEvents ComboBoxPaymentStatus As ComboBox
    Friend WithEvents DateTimePickerPaymentTransDate As DateTimePicker
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonList As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents LabelPaymentTotal As Label
    Friend WithEvents LabelPaymentOtherChanges As Label
    Friend WithEvents LabelPaymentGrandTotal As Label
    Friend WithEvents TextBoxPaymentTotal As TextBox
    Friend WithEvents TextBoxPaymentOtherChanges As TextBox
    Friend WithEvents TextBoxPaymentGrandTotal As TextBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
