<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplicationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApplicationForm))
        Me.LabelApplicationJobName = New System.Windows.Forms.Label()
        Me.LabelApplicationJobCategory = New System.Windows.Forms.Label()
        Me.LabelApplicationWorkerID = New System.Windows.Forms.Label()
        Me.LabelApplicationExperience = New System.Windows.Forms.Label()
        Me.LabelApplicationLocation = New System.Windows.Forms.Label()
        Me.LabelApplicationDate = New System.Windows.Forms.Label()
        Me.TextBoxApplicationJobName = New System.Windows.Forms.TextBox()
        Me.ComboBoxApplicationJobCategory = New System.Windows.Forms.ComboBox()
        Me.TextBoxApplicationWorkerID = New System.Windows.Forms.TextBox()
        Me.ComboBoxApplicationExperience = New System.Windows.Forms.ComboBox()
        Me.TextBoxApplicationLocation = New System.Windows.Forms.TextBox()
        Me.DateTimePickerApplicationDate = New System.Windows.Forms.DateTimePicker()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonList = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TextBoxApplicationSearch = New System.Windows.Forms.TextBox()
        Me.LabelApplicationSearch = New System.Windows.Forms.Label()
        Me.ButtonGo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelApplicationJobName
        '
        Me.LabelApplicationJobName.AutoSize = True
        Me.LabelApplicationJobName.BackColor = System.Drawing.SystemColors.Control
        Me.LabelApplicationJobName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApplicationJobName.Location = New System.Drawing.Point(17, 64)
        Me.LabelApplicationJobName.Name = "LabelApplicationJobName"
        Me.LabelApplicationJobName.Size = New System.Drawing.Size(106, 27)
        Me.LabelApplicationJobName.TabIndex = 0
        Me.LabelApplicationJobName.Text = "Job Name"
        '
        'LabelApplicationJobCategory
        '
        Me.LabelApplicationJobCategory.AutoSize = True
        Me.LabelApplicationJobCategory.BackColor = System.Drawing.SystemColors.Control
        Me.LabelApplicationJobCategory.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApplicationJobCategory.Location = New System.Drawing.Point(17, 107)
        Me.LabelApplicationJobCategory.Name = "LabelApplicationJobCategory"
        Me.LabelApplicationJobCategory.Size = New System.Drawing.Size(137, 27)
        Me.LabelApplicationJobCategory.TabIndex = 1
        Me.LabelApplicationJobCategory.Text = "Job Category"
        '
        'LabelApplicationWorkerID
        '
        Me.LabelApplicationWorkerID.AutoSize = True
        Me.LabelApplicationWorkerID.BackColor = System.Drawing.SystemColors.Control
        Me.LabelApplicationWorkerID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApplicationWorkerID.Location = New System.Drawing.Point(17, 145)
        Me.LabelApplicationWorkerID.Name = "LabelApplicationWorkerID"
        Me.LabelApplicationWorkerID.Size = New System.Drawing.Size(113, 27)
        Me.LabelApplicationWorkerID.TabIndex = 2
        Me.LabelApplicationWorkerID.Text = "Worker ID"
        '
        'LabelApplicationExperience
        '
        Me.LabelApplicationExperience.AutoSize = True
        Me.LabelApplicationExperience.BackColor = System.Drawing.SystemColors.Control
        Me.LabelApplicationExperience.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApplicationExperience.Location = New System.Drawing.Point(17, 185)
        Me.LabelApplicationExperience.Name = "LabelApplicationExperience"
        Me.LabelApplicationExperience.Size = New System.Drawing.Size(112, 27)
        Me.LabelApplicationExperience.TabIndex = 3
        Me.LabelApplicationExperience.Text = "Experience"
        '
        'LabelApplicationLocation
        '
        Me.LabelApplicationLocation.AutoSize = True
        Me.LabelApplicationLocation.BackColor = System.Drawing.SystemColors.Control
        Me.LabelApplicationLocation.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApplicationLocation.Location = New System.Drawing.Point(17, 223)
        Me.LabelApplicationLocation.Name = "LabelApplicationLocation"
        Me.LabelApplicationLocation.Size = New System.Drawing.Size(194, 27)
        Me.LabelApplicationLocation.TabIndex = 4
        Me.LabelApplicationLocation.Text = "Application Location"
        '
        'LabelApplicationDate
        '
        Me.LabelApplicationDate.AutoSize = True
        Me.LabelApplicationDate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelApplicationDate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApplicationDate.Location = New System.Drawing.Point(17, 265)
        Me.LabelApplicationDate.Name = "LabelApplicationDate"
        Me.LabelApplicationDate.Size = New System.Drawing.Size(174, 27)
        Me.LabelApplicationDate.TabIndex = 5
        Me.LabelApplicationDate.Text = "Appplication Date"
        '
        'TextBoxApplicationJobName
        '
        Me.TextBoxApplicationJobName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxApplicationJobName.Location = New System.Drawing.Point(221, 66)
        Me.TextBoxApplicationJobName.Name = "TextBoxApplicationJobName"
        Me.TextBoxApplicationJobName.Size = New System.Drawing.Size(218, 26)
        Me.TextBoxApplicationJobName.TabIndex = 6
        '
        'ComboBoxApplicationJobCategory
        '
        Me.ComboBoxApplicationJobCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxApplicationJobCategory.FormattingEnabled = True
        Me.ComboBoxApplicationJobCategory.Location = New System.Drawing.Point(221, 107)
        Me.ComboBoxApplicationJobCategory.Name = "ComboBoxApplicationJobCategory"
        Me.ComboBoxApplicationJobCategory.Size = New System.Drawing.Size(218, 26)
        Me.ComboBoxApplicationJobCategory.TabIndex = 7
        '
        'TextBoxApplicationWorkerID
        '
        Me.TextBoxApplicationWorkerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxApplicationWorkerID.Location = New System.Drawing.Point(221, 147)
        Me.TextBoxApplicationWorkerID.Name = "TextBoxApplicationWorkerID"
        Me.TextBoxApplicationWorkerID.Size = New System.Drawing.Size(218, 26)
        Me.TextBoxApplicationWorkerID.TabIndex = 8
        '
        'ComboBoxApplicationExperience
        '
        Me.ComboBoxApplicationExperience.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxApplicationExperience.FormattingEnabled = True
        Me.ComboBoxApplicationExperience.Location = New System.Drawing.Point(221, 185)
        Me.ComboBoxApplicationExperience.Name = "ComboBoxApplicationExperience"
        Me.ComboBoxApplicationExperience.Size = New System.Drawing.Size(218, 26)
        Me.ComboBoxApplicationExperience.TabIndex = 9
        '
        'TextBoxApplicationLocation
        '
        Me.TextBoxApplicationLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxApplicationLocation.Location = New System.Drawing.Point(221, 226)
        Me.TextBoxApplicationLocation.Name = "TextBoxApplicationLocation"
        Me.TextBoxApplicationLocation.Size = New System.Drawing.Size(218, 26)
        Me.TextBoxApplicationLocation.TabIndex = 10
        '
        'DateTimePickerApplicationDate
        '
        Me.DateTimePickerApplicationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerApplicationDate.Location = New System.Drawing.Point(221, 265)
        Me.DateTimePickerApplicationDate.Name = "DateTimePickerApplicationDate"
        Me.DateTimePickerApplicationDate.Size = New System.Drawing.Size(222, 24)
        Me.DateTimePickerApplicationDate.TabIndex = 11
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Location = New System.Drawing.Point(33, 403)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(90, 39)
        Me.ButtonAdd.TabIndex = 12
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(145, 403)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(90, 39)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpdate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.Location = New System.Drawing.Point(261, 403)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(90, 39)
        Me.ButtonUpdate.TabIndex = 14
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = False
        '
        'ButtonPrint
        '
        Me.ButtonPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrint.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrint.ForeColor = System.Drawing.Color.White
        Me.ButtonPrint.Location = New System.Drawing.Point(33, 466)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(90, 39)
        Me.ButtonPrint.TabIndex = 15
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(492, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(338, 341)
        Me.DataGridView1.TabIndex = 16
        '
        'ButtonList
        '
        Me.ButtonList.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonList.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonList.ForeColor = System.Drawing.Color.White
        Me.ButtonList.Location = New System.Drawing.Point(145, 466)
        Me.ButtonList.Name = "ButtonList"
        Me.ButtonList.Size = New System.Drawing.Size(90, 39)
        Me.ButtonList.TabIndex = 17
        Me.ButtonList.Text = "List"
        Me.ButtonList.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(261, 466)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(90, 39)
        Me.ButtonCancel.TabIndex = 18
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'TextBoxApplicationSearch
        '
        Me.TextBoxApplicationSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxApplicationSearch.Location = New System.Drawing.Point(573, 53)
        Me.TextBoxApplicationSearch.Name = "TextBoxApplicationSearch"
        Me.TextBoxApplicationSearch.Size = New System.Drawing.Size(150, 24)
        Me.TextBoxApplicationSearch.TabIndex = 20
        '
        'LabelApplicationSearch
        '
        Me.LabelApplicationSearch.AutoSize = True
        Me.LabelApplicationSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApplicationSearch.Location = New System.Drawing.Point(509, 57)
        Me.LabelApplicationSearch.Name = "LabelApplicationSearch"
        Me.LabelApplicationSearch.Size = New System.Drawing.Size(61, 18)
        Me.LabelApplicationSearch.TabIndex = 21
        Me.LabelApplicationSearch.Text = "Search"
        '
        'ButtonGo
        '
        Me.ButtonGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGo.Location = New System.Drawing.Point(729, 52)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(76, 24)
        Me.ButtonGo.TabIndex = 22
        Me.ButtonGo.Text = "Go"
        Me.ButtonGo.UseVisualStyleBackColor = True
        '
        'ApplicationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(857, 547)
        Me.Controls.Add(Me.ButtonGo)
        Me.Controls.Add(Me.LabelApplicationSearch)
        Me.Controls.Add(Me.TextBoxApplicationSearch)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonList)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.DateTimePickerApplicationDate)
        Me.Controls.Add(Me.TextBoxApplicationLocation)
        Me.Controls.Add(Me.ComboBoxApplicationExperience)
        Me.Controls.Add(Me.TextBoxApplicationWorkerID)
        Me.Controls.Add(Me.ComboBoxApplicationJobCategory)
        Me.Controls.Add(Me.TextBoxApplicationJobName)
        Me.Controls.Add(Me.LabelApplicationDate)
        Me.Controls.Add(Me.LabelApplicationLocation)
        Me.Controls.Add(Me.LabelApplicationExperience)
        Me.Controls.Add(Me.LabelApplicationWorkerID)
        Me.Controls.Add(Me.LabelApplicationJobCategory)
        Me.Controls.Add(Me.LabelApplicationJobName)
        Me.Name = "ApplicationForm"
        Me.Text = "ApplicationForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelApplicationJobName As Label
    Friend WithEvents LabelApplicationJobCategory As Label
    Friend WithEvents LabelApplicationWorkerID As Label
    Friend WithEvents LabelApplicationExperience As Label
    Friend WithEvents LabelApplicationLocation As Label
    Friend WithEvents LabelApplicationDate As Label
    Friend WithEvents TextBoxApplicationJobName As TextBox
    Friend WithEvents ComboBoxApplicationJobCategory As ComboBox
    Friend WithEvents TextBoxApplicationWorkerID As TextBox
    Friend WithEvents ComboBoxApplicationExperience As ComboBox
    Friend WithEvents TextBoxApplicationLocation As TextBox
    Friend WithEvents DateTimePickerApplicationDate As DateTimePicker
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonList As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents TextBoxApplicationSearch As TextBox
    Friend WithEvents LabelApplicationSearch As Label
    Friend WithEvents ButtonGo As Button
End Class
