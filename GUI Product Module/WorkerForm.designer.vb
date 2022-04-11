<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWorkerTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormWorkerTable))
        Me.LabelWorkerLabel = New System.Windows.Forms.Label()
        Me.LabelWorkerAddress = New System.Windows.Forms.Label()
        Me.LabelWorkerID = New System.Windows.Forms.Label()
        Me.LabelWorkerGender = New System.Windows.Forms.Label()
        Me.LabelWorkerContact = New System.Windows.Forms.Label()
        Me.LabelWorkerPassword = New System.Windows.Forms.Label()
        Me.TextBoxWorkerName = New System.Windows.Forms.TextBox()
        Me.TextBoxWorkerAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxWorkerID = New System.Windows.Forms.TextBox()
        Me.TextBoxWorkercontact = New System.Windows.Forms.TextBox()
        Me.TextBoxWorkerPassword = New System.Windows.Forms.TextBox()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonList = New System.Windows.Forms.Button()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonLast = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelWorkerLabel
        '
        Me.LabelWorkerLabel.AutoSize = True
        Me.LabelWorkerLabel.BackColor = System.Drawing.Color.Transparent
        Me.LabelWorkerLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWorkerLabel.Location = New System.Drawing.Point(38, 51)
        Me.LabelWorkerLabel.Name = "LabelWorkerLabel"
        Me.LabelWorkerLabel.Size = New System.Drawing.Size(64, 27)
        Me.LabelWorkerLabel.TabIndex = 0
        Me.LabelWorkerLabel.Text = "Name"
        '
        'LabelWorkerAddress
        '
        Me.LabelWorkerAddress.AutoSize = True
        Me.LabelWorkerAddress.BackColor = System.Drawing.Color.Transparent
        Me.LabelWorkerAddress.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWorkerAddress.Location = New System.Drawing.Point(333, 46)
        Me.LabelWorkerAddress.Name = "LabelWorkerAddress"
        Me.LabelWorkerAddress.Size = New System.Drawing.Size(86, 27)
        Me.LabelWorkerAddress.TabIndex = 1
        Me.LabelWorkerAddress.Text = "Address"
        '
        'LabelWorkerID
        '
        Me.LabelWorkerID.AutoSize = True
        Me.LabelWorkerID.BackColor = System.Drawing.Color.Transparent
        Me.LabelWorkerID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWorkerID.Location = New System.Drawing.Point(66, 93)
        Me.LabelWorkerID.Name = "LabelWorkerID"
        Me.LabelWorkerID.Size = New System.Drawing.Size(36, 27)
        Me.LabelWorkerID.TabIndex = 2
        Me.LabelWorkerID.Text = "ID"
        '
        'LabelWorkerGender
        '
        Me.LabelWorkerGender.AutoSize = True
        Me.LabelWorkerGender.BackColor = System.Drawing.Color.Transparent
        Me.LabelWorkerGender.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWorkerGender.Location = New System.Drawing.Point(342, 139)
        Me.LabelWorkerGender.Name = "LabelWorkerGender"
        Me.LabelWorkerGender.Size = New System.Drawing.Size(77, 27)
        Me.LabelWorkerGender.TabIndex = 3
        Me.LabelWorkerGender.Text = "Gender"
        '
        'LabelWorkerContact
        '
        Me.LabelWorkerContact.AutoSize = True
        Me.LabelWorkerContact.BackColor = System.Drawing.Color.Transparent
        Me.LabelWorkerContact.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWorkerContact.Location = New System.Drawing.Point(19, 141)
        Me.LabelWorkerContact.Name = "LabelWorkerContact"
        Me.LabelWorkerContact.Size = New System.Drawing.Size(83, 27)
        Me.LabelWorkerContact.TabIndex = 4
        Me.LabelWorkerContact.Text = "Contact"
        '
        'LabelWorkerPassword
        '
        Me.LabelWorkerPassword.AutoSize = True
        Me.LabelWorkerPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelWorkerPassword.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWorkerPassword.Location = New System.Drawing.Point(8, 185)
        Me.LabelWorkerPassword.Name = "LabelWorkerPassword"
        Me.LabelWorkerPassword.Size = New System.Drawing.Size(94, 27)
        Me.LabelWorkerPassword.TabIndex = 5
        Me.LabelWorkerPassword.Text = "Password"
        '
        'TextBoxWorkerName
        '
        Me.TextBoxWorkerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWorkerName.Location = New System.Drawing.Point(118, 51)
        Me.TextBoxWorkerName.Name = "TextBoxWorkerName"
        Me.TextBoxWorkerName.Size = New System.Drawing.Size(194, 24)
        Me.TextBoxWorkerName.TabIndex = 6
        '
        'TextBoxWorkerAddress
        '
        Me.TextBoxWorkerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWorkerAddress.Location = New System.Drawing.Point(426, 42)
        Me.TextBoxWorkerAddress.Name = "TextBoxWorkerAddress"
        Me.TextBoxWorkerAddress.Size = New System.Drawing.Size(190, 80)
        Me.TextBoxWorkerAddress.TabIndex = 7
        '
        'TextBoxWorkerID
        '
        Me.TextBoxWorkerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWorkerID.Location = New System.Drawing.Point(118, 96)
        Me.TextBoxWorkerID.Name = "TextBoxWorkerID"
        Me.TextBoxWorkerID.Size = New System.Drawing.Size(194, 24)
        Me.TextBoxWorkerID.TabIndex = 8
        '
        'TextBoxWorkercontact
        '
        Me.TextBoxWorkercontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWorkercontact.Location = New System.Drawing.Point(118, 144)
        Me.TextBoxWorkercontact.Name = "TextBoxWorkercontact"
        Me.TextBoxWorkercontact.Size = New System.Drawing.Size(194, 24)
        Me.TextBoxWorkercontact.TabIndex = 9
        '
        'TextBoxWorkerPassword
        '
        Me.TextBoxWorkerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWorkerPassword.Location = New System.Drawing.Point(118, 188)
        Me.TextBoxWorkerPassword.Name = "TextBoxWorkerPassword"
        Me.TextBoxWorkerPassword.Size = New System.Drawing.Size(194, 24)
        Me.TextBoxWorkerPassword.TabIndex = 10
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonMale.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMale.Location = New System.Drawing.Point(428, 144)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(64, 27)
        Me.RadioButtonMale.TabIndex = 11
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = False
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonFemale.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonFemale.Location = New System.Drawing.Point(549, 145)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(81, 27)
        Me.RadioButtonFemale.TabIndex = 12
        Me.RadioButtonFemale.TabStop = True
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Wheat
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 244)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(583, 193)
        Me.DataGridView1.TabIndex = 13
        '
        'ButtonNew
        '
        Me.ButtonNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNew.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNew.ForeColor = System.Drawing.Color.White
        Me.ButtonNew.Location = New System.Drawing.Point(64, 462)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(106, 40)
        Me.ButtonNew.TabIndex = 14
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(199, 462)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(106, 40)
        Me.ButtonSave.TabIndex = 15
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpdate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.Location = New System.Drawing.Point(334, 462)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(106, 40)
        Me.ButtonUpdate.TabIndex = 16
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(475, 462)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(106, 40)
        Me.ButtonDelete.TabIndex = 17
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonList
        '
        Me.ButtonList.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonList.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonList.ForeColor = System.Drawing.Color.White
        Me.ButtonList.Location = New System.Drawing.Point(647, 317)
        Me.ButtonList.Name = "ButtonList"
        Me.ButtonList.Size = New System.Drawing.Size(93, 38)
        Me.ButtonList.TabIndex = 18
        Me.ButtonList.Text = "List"
        Me.ButtonList.UseVisualStyleBackColor = False
        '
        'ButtonFirst
        '
        Me.ButtonFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFirst.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFirst.ForeColor = System.Drawing.Color.White
        Me.ButtonFirst.Location = New System.Drawing.Point(186, 512)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(58, 33)
        Me.ButtonFirst.TabIndex = 19
        Me.ButtonFirst.Text = "<<"
        Me.ButtonFirst.UseVisualStyleBackColor = False
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrevious.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrevious.ForeColor = System.Drawing.Color.White
        Me.ButtonPrevious.Location = New System.Drawing.Point(259, 512)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(58, 33)
        Me.ButtonPrevious.TabIndex = 20
        Me.ButtonPrevious.Text = "<"
        Me.ButtonPrevious.UseVisualStyleBackColor = False
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNext.ForeColor = System.Drawing.Color.White
        Me.ButtonNext.Location = New System.Drawing.Point(331, 512)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(58, 33)
        Me.ButtonNext.TabIndex = 21
        Me.ButtonNext.Text = ">"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'ButtonLast
        '
        Me.ButtonLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLast.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLast.ForeColor = System.Drawing.Color.White
        Me.ButtonLast.Location = New System.Drawing.Point(406, 512)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(58, 33)
        Me.ButtonLast.TabIndex = 22
        Me.ButtonLast.Text = ">>"
        Me.ButtonLast.UseVisualStyleBackColor = False
        '
        'FormWorkerTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(849, 557)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.ButtonList)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RadioButtonFemale)
        Me.Controls.Add(Me.RadioButtonMale)
        Me.Controls.Add(Me.TextBoxWorkerPassword)
        Me.Controls.Add(Me.TextBoxWorkercontact)
        Me.Controls.Add(Me.TextBoxWorkerID)
        Me.Controls.Add(Me.TextBoxWorkerAddress)
        Me.Controls.Add(Me.TextBoxWorkerName)
        Me.Controls.Add(Me.LabelWorkerPassword)
        Me.Controls.Add(Me.LabelWorkerContact)
        Me.Controls.Add(Me.LabelWorkerGender)
        Me.Controls.Add(Me.LabelWorkerID)
        Me.Controls.Add(Me.LabelWorkerAddress)
        Me.Controls.Add(Me.LabelWorkerLabel)
        Me.Name = "FormWorkerTable"
        Me.Text = "WorkerForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelWorkerLabel As Label
    Friend WithEvents LabelWorkerAddress As Label
    Friend WithEvents LabelWorkerID As Label
    Friend WithEvents LabelWorkerGender As Label
    Friend WithEvents LabelWorkerContact As Label
    Friend WithEvents LabelWorkerPassword As Label
    Friend WithEvents TextBoxWorkerName As TextBox
    Friend WithEvents TextBoxWorkerAddress As TextBox
    Friend WithEvents TextBoxWorkerID As TextBox
    Friend WithEvents TextBoxWorkercontact As TextBox
    Friend WithEvents TextBoxWorkerPassword As TextBox
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonList As Button
    Friend WithEvents ButtonFirst As Button
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonLast As Button
End Class
