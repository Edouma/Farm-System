<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SellerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellerForm))
        Me.LabelSellerSellerName = New System.Windows.Forms.Label()
        Me.LabelSellerSellerID = New System.Windows.Forms.Label()
        Me.LabelSellerSellerAddress = New System.Windows.Forms.Label()
        Me.LabelSellerSellerContact = New System.Windows.Forms.Label()
        Me.LabelSellerSellerPassword = New System.Windows.Forms.Label()
        Me.LabelSellerSellerLocation = New System.Windows.Forms.Label()
        Me.TextBoxSellerSellerName = New System.Windows.Forms.TextBox()
        Me.TextBoxSellerSellerID = New System.Windows.Forms.TextBox()
        Me.TextBoxSellerSellerAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxSellerSellerContact = New System.Windows.Forms.TextBox()
        Me.TextBoxSellerSellerPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxSellerSellerLocation = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.DataGridViewSellerSeller = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewSellerSeller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelSellerSellerName
        '
        Me.LabelSellerSellerName.AutoSize = True
        Me.LabelSellerSellerName.BackColor = System.Drawing.Color.Transparent
        Me.LabelSellerSellerName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerSellerName.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerSellerName.Location = New System.Drawing.Point(47, 48)
        Me.LabelSellerSellerName.Name = "LabelSellerSellerName"
        Me.LabelSellerSellerName.Size = New System.Drawing.Size(64, 27)
        Me.LabelSellerSellerName.TabIndex = 0
        Me.LabelSellerSellerName.Text = "Name"
        '
        'LabelSellerSellerID
        '
        Me.LabelSellerSellerID.AutoSize = True
        Me.LabelSellerSellerID.BackColor = System.Drawing.Color.Transparent
        Me.LabelSellerSellerID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerSellerID.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerSellerID.Location = New System.Drawing.Point(75, 86)
        Me.LabelSellerSellerID.Name = "LabelSellerSellerID"
        Me.LabelSellerSellerID.Size = New System.Drawing.Size(36, 27)
        Me.LabelSellerSellerID.TabIndex = 1
        Me.LabelSellerSellerID.Text = "ID"
        '
        'LabelSellerSellerAddress
        '
        Me.LabelSellerSellerAddress.AutoSize = True
        Me.LabelSellerSellerAddress.BackColor = System.Drawing.Color.Transparent
        Me.LabelSellerSellerAddress.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerSellerAddress.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerSellerAddress.Location = New System.Drawing.Point(28, 126)
        Me.LabelSellerSellerAddress.Name = "LabelSellerSellerAddress"
        Me.LabelSellerSellerAddress.Size = New System.Drawing.Size(86, 27)
        Me.LabelSellerSellerAddress.TabIndex = 2
        Me.LabelSellerSellerAddress.Text = "Address"
        '
        'LabelSellerSellerContact
        '
        Me.LabelSellerSellerContact.AutoSize = True
        Me.LabelSellerSellerContact.BackColor = System.Drawing.Color.Transparent
        Me.LabelSellerSellerContact.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerSellerContact.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerSellerContact.Location = New System.Drawing.Point(28, 217)
        Me.LabelSellerSellerContact.Name = "LabelSellerSellerContact"
        Me.LabelSellerSellerContact.Size = New System.Drawing.Size(83, 27)
        Me.LabelSellerSellerContact.TabIndex = 3
        Me.LabelSellerSellerContact.Text = "Contact"
        '
        'LabelSellerSellerPassword
        '
        Me.LabelSellerSellerPassword.AutoSize = True
        Me.LabelSellerSellerPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelSellerSellerPassword.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerSellerPassword.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerSellerPassword.Location = New System.Drawing.Point(22, 257)
        Me.LabelSellerSellerPassword.Name = "LabelSellerSellerPassword"
        Me.LabelSellerSellerPassword.Size = New System.Drawing.Size(94, 27)
        Me.LabelSellerSellerPassword.TabIndex = 4
        Me.LabelSellerSellerPassword.Text = "Password"
        '
        'LabelSellerSellerLocation
        '
        Me.LabelSellerSellerLocation.AutoSize = True
        Me.LabelSellerSellerLocation.BackColor = System.Drawing.Color.Transparent
        Me.LabelSellerSellerLocation.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSellerSellerLocation.ForeColor = System.Drawing.Color.Black
        Me.LabelSellerSellerLocation.Location = New System.Drawing.Point(27, 297)
        Me.LabelSellerSellerLocation.Name = "LabelSellerSellerLocation"
        Me.LabelSellerSellerLocation.Size = New System.Drawing.Size(87, 27)
        Me.LabelSellerSellerLocation.TabIndex = 5
        Me.LabelSellerSellerLocation.Text = "Location"
        '
        'TextBoxSellerSellerName
        '
        Me.TextBoxSellerSellerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerSellerName.Location = New System.Drawing.Point(117, 50)
        Me.TextBoxSellerSellerName.Name = "TextBoxSellerSellerName"
        Me.TextBoxSellerSellerName.Size = New System.Drawing.Size(168, 26)
        Me.TextBoxSellerSellerName.TabIndex = 6
        '
        'TextBoxSellerSellerID
        '
        Me.TextBoxSellerSellerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerSellerID.Location = New System.Drawing.Point(117, 87)
        Me.TextBoxSellerSellerID.Name = "TextBoxSellerSellerID"
        Me.TextBoxSellerSellerID.Size = New System.Drawing.Size(168, 26)
        Me.TextBoxSellerSellerID.TabIndex = 7
        '
        'TextBoxSellerSellerAddress
        '
        Me.TextBoxSellerSellerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerSellerAddress.Location = New System.Drawing.Point(117, 128)
        Me.TextBoxSellerSellerAddress.Name = "TextBoxSellerSellerAddress"
        Me.TextBoxSellerSellerAddress.Size = New System.Drawing.Size(168, 80)
        Me.TextBoxSellerSellerAddress.TabIndex = 8
        '
        'TextBoxSellerSellerContact
        '
        Me.TextBoxSellerSellerContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerSellerContact.Location = New System.Drawing.Point(117, 219)
        Me.TextBoxSellerSellerContact.Name = "TextBoxSellerSellerContact"
        Me.TextBoxSellerSellerContact.Size = New System.Drawing.Size(168, 26)
        Me.TextBoxSellerSellerContact.TabIndex = 9
        '
        'TextBoxSellerSellerPassword
        '
        Me.TextBoxSellerSellerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerSellerPassword.Location = New System.Drawing.Point(117, 259)
        Me.TextBoxSellerSellerPassword.Name = "TextBoxSellerSellerPassword"
        Me.TextBoxSellerSellerPassword.Size = New System.Drawing.Size(168, 26)
        Me.TextBoxSellerSellerPassword.TabIndex = 10
        '
        'TextBoxSellerSellerLocation
        '
        Me.TextBoxSellerSellerLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSellerSellerLocation.Location = New System.Drawing.Point(117, 299)
        Me.TextBoxSellerSellerLocation.Name = "TextBoxSellerSellerLocation"
        Me.TextBoxSellerSellerLocation.Size = New System.Drawing.Size(168, 26)
        Me.TextBoxSellerSellerLocation.TabIndex = 11
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Location = New System.Drawing.Point(25, 386)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(91, 35)
        Me.ButtonAdd.TabIndex = 12
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonModify
        '
        Me.ButtonModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModify.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModify.ForeColor = System.Drawing.Color.White
        Me.ButtonModify.Location = New System.Drawing.Point(133, 386)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(91, 35)
        Me.ButtonModify.TabIndex = 13
        Me.ButtonModify.Text = "Modify"
        Me.ButtonModify.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(240, 386)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(91, 35)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(349, 386)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(91, 35)
        Me.ButtonCancel.TabIndex = 15
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonLast
        '
        Me.ButtonLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLast.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLast.ForeColor = System.Drawing.Color.White
        Me.ButtonLast.Location = New System.Drawing.Point(298, 450)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(58, 33)
        Me.ButtonLast.TabIndex = 23
        Me.ButtonLast.Text = ">>"
        Me.ButtonLast.UseVisualStyleBackColor = False
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrevious.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrevious.ForeColor = System.Drawing.Color.White
        Me.ButtonPrevious.Location = New System.Drawing.Point(234, 450)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(58, 33)
        Me.ButtonPrevious.TabIndex = 22
        Me.ButtonPrevious.Text = "<"
        Me.ButtonPrevious.UseVisualStyleBackColor = False
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNext.ForeColor = System.Drawing.Color.White
        Me.ButtonNext.Location = New System.Drawing.Point(170, 450)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(58, 33)
        Me.ButtonNext.TabIndex = 21
        Me.ButtonNext.Text = ">"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'ButtonFirst
        '
        Me.ButtonFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFirst.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFirst.ForeColor = System.Drawing.Color.White
        Me.ButtonFirst.Location = New System.Drawing.Point(106, 450)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(58, 33)
        Me.ButtonFirst.TabIndex = 20
        Me.ButtonFirst.Text = "<<"
        Me.ButtonFirst.UseVisualStyleBackColor = False
        '
        'DataGridViewSellerSeller
        '
        Me.DataGridViewSellerSeller.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.DataGridViewSellerSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSellerSeller.Location = New System.Drawing.Point(443, 48)
        Me.DataGridViewSellerSeller.Name = "DataGridViewSellerSeller"
        Me.DataGridViewSellerSeller.Size = New System.Drawing.Size(295, 319)
        Me.DataGridViewSellerSeller.TabIndex = 24
        '
        'SellerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(763, 523)
        Me.Controls.Add(Me.DataGridViewSellerSeller)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonModify)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxSellerSellerLocation)
        Me.Controls.Add(Me.TextBoxSellerSellerPassword)
        Me.Controls.Add(Me.TextBoxSellerSellerContact)
        Me.Controls.Add(Me.TextBoxSellerSellerAddress)
        Me.Controls.Add(Me.TextBoxSellerSellerID)
        Me.Controls.Add(Me.TextBoxSellerSellerName)
        Me.Controls.Add(Me.LabelSellerSellerLocation)
        Me.Controls.Add(Me.LabelSellerSellerPassword)
        Me.Controls.Add(Me.LabelSellerSellerContact)
        Me.Controls.Add(Me.LabelSellerSellerAddress)
        Me.Controls.Add(Me.LabelSellerSellerID)
        Me.Controls.Add(Me.LabelSellerSellerName)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "SellerForm"
        Me.Text = "SellerForm"
        CType(Me.DataGridViewSellerSeller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSellerSellerName As Label
    Friend WithEvents LabelSellerSellerID As Label
    Friend WithEvents LabelSellerSellerAddress As Label
    Friend WithEvents LabelSellerSellerContact As Label
    Friend WithEvents LabelSellerSellerPassword As Label
    Friend WithEvents LabelSellerSellerLocation As Label
    Friend WithEvents TextBoxSellerSellerName As TextBox
    Friend WithEvents TextBoxSellerSellerID As TextBox
    Friend WithEvents TextBoxSellerSellerAddress As TextBox
    Friend WithEvents TextBoxSellerSellerContact As TextBox
    Friend WithEvents TextBoxSellerSellerPassword As TextBox
    Friend WithEvents TextBoxSellerSellerLocation As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonLast As Button
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonFirst As Button
    Friend WithEvents DataGridViewSellerSeller As DataGridView
End Class
