<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.LabelArticleAdminName = New System.Windows.Forms.Label()
        Me.LabelArticleAdminID = New System.Windows.Forms.Label()
        Me.LabelArticleAdminPassword = New System.Windows.Forms.Label()
        Me.LabelArticleAdminLoggedOn = New System.Windows.Forms.Label()
        Me.LabelArticleAdminLoggedOff = New System.Windows.Forms.Label()
        Me.LabelArticleAdminUserList = New System.Windows.Forms.Label()
        Me.TextBoxArticleAdminName = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleAdminID = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleAdminPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleAdminLoggedOn = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleAdminLoggedOff = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleAdminUserList = New System.Windows.Forms.TextBox()
        Me.DataGridViewArticleAdmin = New System.Windows.Forms.DataGridView()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.DataGridViewArticleAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelArticleAdminName
        '
        Me.LabelArticleAdminName.AutoSize = True
        Me.LabelArticleAdminName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleAdminName.ForeColor = System.Drawing.Color.White
        Me.LabelArticleAdminName.Location = New System.Drawing.Point(76, 82)
        Me.LabelArticleAdminName.Name = "LabelArticleAdminName"
        Me.LabelArticleAdminName.Size = New System.Drawing.Size(64, 27)
        Me.LabelArticleAdminName.TabIndex = 0
        Me.LabelArticleAdminName.Text = "Name"
        '
        'LabelArticleAdminID
        '
        Me.LabelArticleAdminID.AutoSize = True
        Me.LabelArticleAdminID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleAdminID.ForeColor = System.Drawing.Color.White
        Me.LabelArticleAdminID.Location = New System.Drawing.Point(104, 128)
        Me.LabelArticleAdminID.Name = "LabelArticleAdminID"
        Me.LabelArticleAdminID.Size = New System.Drawing.Size(36, 27)
        Me.LabelArticleAdminID.TabIndex = 1
        Me.LabelArticleAdminID.Text = "ID"
        '
        'LabelArticleAdminPassword
        '
        Me.LabelArticleAdminPassword.AutoSize = True
        Me.LabelArticleAdminPassword.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleAdminPassword.ForeColor = System.Drawing.Color.White
        Me.LabelArticleAdminPassword.Location = New System.Drawing.Point(46, 175)
        Me.LabelArticleAdminPassword.Name = "LabelArticleAdminPassword"
        Me.LabelArticleAdminPassword.Size = New System.Drawing.Size(94, 27)
        Me.LabelArticleAdminPassword.TabIndex = 2
        Me.LabelArticleAdminPassword.Text = "Password"
        '
        'LabelArticleAdminLoggedOn
        '
        Me.LabelArticleAdminLoggedOn.AutoSize = True
        Me.LabelArticleAdminLoggedOn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleAdminLoggedOn.ForeColor = System.Drawing.Color.White
        Me.LabelArticleAdminLoggedOn.Location = New System.Drawing.Point(33, 216)
        Me.LabelArticleAdminLoggedOn.Name = "LabelArticleAdminLoggedOn"
        Me.LabelArticleAdminLoggedOn.Size = New System.Drawing.Size(107, 27)
        Me.LabelArticleAdminLoggedOn.TabIndex = 3
        Me.LabelArticleAdminLoggedOn.Text = "Logged On"
        '
        'LabelArticleAdminLoggedOff
        '
        Me.LabelArticleAdminLoggedOff.AutoSize = True
        Me.LabelArticleAdminLoggedOff.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleAdminLoggedOff.ForeColor = System.Drawing.Color.White
        Me.LabelArticleAdminLoggedOff.Location = New System.Drawing.Point(27, 262)
        Me.LabelArticleAdminLoggedOff.Name = "LabelArticleAdminLoggedOff"
        Me.LabelArticleAdminLoggedOff.Size = New System.Drawing.Size(117, 27)
        Me.LabelArticleAdminLoggedOff.TabIndex = 4
        Me.LabelArticleAdminLoggedOff.Text = "Logged Off"
        '
        'LabelArticleAdminUserList
        '
        Me.LabelArticleAdminUserList.AutoSize = True
        Me.LabelArticleAdminUserList.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleAdminUserList.ForeColor = System.Drawing.Color.White
        Me.LabelArticleAdminUserList.Location = New System.Drawing.Point(44, 311)
        Me.LabelArticleAdminUserList.Name = "LabelArticleAdminUserList"
        Me.LabelArticleAdminUserList.Size = New System.Drawing.Size(96, 27)
        Me.LabelArticleAdminUserList.TabIndex = 5
        Me.LabelArticleAdminUserList.Text = "User List"
        '
        'TextBoxArticleAdminName
        '
        Me.TextBoxArticleAdminName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleAdminName.Location = New System.Drawing.Point(146, 84)
        Me.TextBoxArticleAdminName.Name = "TextBoxArticleAdminName"
        Me.TextBoxArticleAdminName.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxArticleAdminName.TabIndex = 6
        '
        'TextBoxArticleAdminID
        '
        Me.TextBoxArticleAdminID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleAdminID.Location = New System.Drawing.Point(146, 130)
        Me.TextBoxArticleAdminID.Name = "TextBoxArticleAdminID"
        Me.TextBoxArticleAdminID.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxArticleAdminID.TabIndex = 7
        '
        'TextBoxArticleAdminPassword
        '
        Me.TextBoxArticleAdminPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleAdminPassword.Location = New System.Drawing.Point(146, 177)
        Me.TextBoxArticleAdminPassword.Name = "TextBoxArticleAdminPassword"
        Me.TextBoxArticleAdminPassword.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxArticleAdminPassword.TabIndex = 8
        '
        'TextBoxArticleAdminLoggedOn
        '
        Me.TextBoxArticleAdminLoggedOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleAdminLoggedOn.Location = New System.Drawing.Point(146, 218)
        Me.TextBoxArticleAdminLoggedOn.Name = "TextBoxArticleAdminLoggedOn"
        Me.TextBoxArticleAdminLoggedOn.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxArticleAdminLoggedOn.TabIndex = 9
        '
        'TextBoxArticleAdminLoggedOff
        '
        Me.TextBoxArticleAdminLoggedOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleAdminLoggedOff.Location = New System.Drawing.Point(146, 264)
        Me.TextBoxArticleAdminLoggedOff.Name = "TextBoxArticleAdminLoggedOff"
        Me.TextBoxArticleAdminLoggedOff.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxArticleAdminLoggedOff.TabIndex = 10
        '
        'TextBoxArticleAdminUserList
        '
        Me.TextBoxArticleAdminUserList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleAdminUserList.Location = New System.Drawing.Point(146, 313)
        Me.TextBoxArticleAdminUserList.Name = "TextBoxArticleAdminUserList"
        Me.TextBoxArticleAdminUserList.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxArticleAdminUserList.TabIndex = 11
        '
        'DataGridViewArticleAdmin
        '
        Me.DataGridViewArticleAdmin.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGridViewArticleAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewArticleAdmin.Location = New System.Drawing.Point(407, 42)
        Me.DataGridViewArticleAdmin.Name = "DataGridViewArticleAdmin"
        Me.DataGridViewArticleAdmin.Size = New System.Drawing.Size(388, 468)
        Me.DataGridViewArticleAdmin.TabIndex = 12
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Location = New System.Drawing.Point(51, 406)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(110, 39)
        Me.ButtonAdd.TabIndex = 13
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Location = New System.Drawing.Point(240, 406)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(110, 39)
        Me.ButtonEdit.TabIndex = 14
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(51, 471)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(110, 39)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(240, 471)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(110, 39)
        Me.ButtonCancel.TabIndex = 16
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(814, 551)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.DataGridViewArticleAdmin)
        Me.Controls.Add(Me.TextBoxArticleAdminUserList)
        Me.Controls.Add(Me.TextBoxArticleAdminLoggedOff)
        Me.Controls.Add(Me.TextBoxArticleAdminLoggedOn)
        Me.Controls.Add(Me.TextBoxArticleAdminPassword)
        Me.Controls.Add(Me.TextBoxArticleAdminID)
        Me.Controls.Add(Me.TextBoxArticleAdminName)
        Me.Controls.Add(Me.LabelArticleAdminUserList)
        Me.Controls.Add(Me.LabelArticleAdminLoggedOff)
        Me.Controls.Add(Me.LabelArticleAdminLoggedOn)
        Me.Controls.Add(Me.LabelArticleAdminPassword)
        Me.Controls.Add(Me.LabelArticleAdminID)
        Me.Controls.Add(Me.LabelArticleAdminName)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        CType(Me.DataGridViewArticleAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelArticleAdminName As Label
    Friend WithEvents LabelArticleAdminID As Label
    Friend WithEvents LabelArticleAdminPassword As Label
    Friend WithEvents LabelArticleAdminLoggedOn As Label
    Friend WithEvents LabelArticleAdminLoggedOff As Label
    Friend WithEvents LabelArticleAdminUserList As Label
    Friend WithEvents TextBoxArticleAdminName As TextBox
    Friend WithEvents TextBoxArticleAdminID As TextBox
    Friend WithEvents TextBoxArticleAdminPassword As TextBox
    Friend WithEvents TextBoxArticleAdminLoggedOn As TextBox
    Friend WithEvents TextBoxArticleAdminLoggedOff As TextBox
    Friend WithEvents TextBoxArticleAdminUserList As TextBox
    Friend WithEvents DataGridViewArticleAdmin As DataGridView
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonCancel As Button
End Class
