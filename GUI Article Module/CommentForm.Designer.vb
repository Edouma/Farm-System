<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CommentForm))
        Me.LabelArticleCommentArticleTitle = New System.Windows.Forms.Label()
        Me.LabelArticleCommentArticleID = New System.Windows.Forms.Label()
        Me.LabelArticleCommentDate = New System.Windows.Forms.Label()
        Me.LabelArticleCommentComment = New System.Windows.Forms.Label()
        Me.LabelArticleCommentUserID = New System.Windows.Forms.Label()
        Me.LabelArticleCommentUserName = New System.Windows.Forms.Label()
        Me.TextBoxArticleCommentArticleTitle = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleCommentArticleID = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleCommentComment = New System.Windows.Forms.TextBox()
        Me.DateTimePickerArticleCommentDate = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridViewArticleComment = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewArticleComment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelArticleCommentArticleTitle
        '
        Me.LabelArticleCommentArticleTitle.AutoSize = True
        Me.LabelArticleCommentArticleTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LabelArticleCommentArticleTitle.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleCommentArticleTitle.ForeColor = System.Drawing.Color.White
        Me.LabelArticleCommentArticleTitle.Location = New System.Drawing.Point(15, 61)
        Me.LabelArticleCommentArticleTitle.Name = "LabelArticleCommentArticleTitle"
        Me.LabelArticleCommentArticleTitle.Size = New System.Drawing.Size(126, 27)
        Me.LabelArticleCommentArticleTitle.TabIndex = 0
        Me.LabelArticleCommentArticleTitle.Text = "Article Title"
        '
        'LabelArticleCommentArticleID
        '
        Me.LabelArticleCommentArticleID.AutoSize = True
        Me.LabelArticleCommentArticleID.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LabelArticleCommentArticleID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleCommentArticleID.ForeColor = System.Drawing.Color.White
        Me.LabelArticleCommentArticleID.Location = New System.Drawing.Point(34, 99)
        Me.LabelArticleCommentArticleID.Name = "LabelArticleCommentArticleID"
        Me.LabelArticleCommentArticleID.Size = New System.Drawing.Size(107, 27)
        Me.LabelArticleCommentArticleID.TabIndex = 1
        Me.LabelArticleCommentArticleID.Text = "Article ID"
        '
        'LabelArticleCommentDate
        '
        Me.LabelArticleCommentDate.AutoSize = True
        Me.LabelArticleCommentDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LabelArticleCommentDate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleCommentDate.ForeColor = System.Drawing.Color.White
        Me.LabelArticleCommentDate.Location = New System.Drawing.Point(84, 135)
        Me.LabelArticleCommentDate.Name = "LabelArticleCommentDate"
        Me.LabelArticleCommentDate.Size = New System.Drawing.Size(57, 27)
        Me.LabelArticleCommentDate.TabIndex = 2
        Me.LabelArticleCommentDate.Text = "Date"
        '
        'LabelArticleCommentComment
        '
        Me.LabelArticleCommentComment.AutoSize = True
        Me.LabelArticleCommentComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LabelArticleCommentComment.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleCommentComment.ForeColor = System.Drawing.Color.White
        Me.LabelArticleCommentComment.Location = New System.Drawing.Point(47, 174)
        Me.LabelArticleCommentComment.Name = "LabelArticleCommentComment"
        Me.LabelArticleCommentComment.Size = New System.Drawing.Size(94, 27)
        Me.LabelArticleCommentComment.TabIndex = 3
        Me.LabelArticleCommentComment.Text = "Comment"
        '
        'LabelArticleCommentUserID
        '
        Me.LabelArticleCommentUserID.AutoSize = True
        Me.LabelArticleCommentUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LabelArticleCommentUserID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleCommentUserID.ForeColor = System.Drawing.Color.White
        Me.LabelArticleCommentUserID.Location = New System.Drawing.Point(54, 269)
        Me.LabelArticleCommentUserID.Name = "LabelArticleCommentUserID"
        Me.LabelArticleCommentUserID.Size = New System.Drawing.Size(87, 27)
        Me.LabelArticleCommentUserID.TabIndex = 4
        Me.LabelArticleCommentUserID.Text = "User ID"
        '
        'LabelArticleCommentUserName
        '
        Me.LabelArticleCommentUserName.AutoSize = True
        Me.LabelArticleCommentUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LabelArticleCommentUserName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleCommentUserName.ForeColor = System.Drawing.Color.White
        Me.LabelArticleCommentUserName.Location = New System.Drawing.Point(26, 308)
        Me.LabelArticleCommentUserName.Name = "LabelArticleCommentUserName"
        Me.LabelArticleCommentUserName.Size = New System.Drawing.Size(115, 27)
        Me.LabelArticleCommentUserName.TabIndex = 5
        Me.LabelArticleCommentUserName.Text = "User Name"
        '
        'TextBoxArticleCommentArticleTitle
        '
        Me.TextBoxArticleCommentArticleTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleCommentArticleTitle.Location = New System.Drawing.Point(164, 61)
        Me.TextBoxArticleCommentArticleTitle.Name = "TextBoxArticleCommentArticleTitle"
        Me.TextBoxArticleCommentArticleTitle.Size = New System.Drawing.Size(248, 26)
        Me.TextBoxArticleCommentArticleTitle.TabIndex = 6
        '
        'TextBoxArticleCommentArticleID
        '
        Me.TextBoxArticleCommentArticleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleCommentArticleID.Location = New System.Drawing.Point(164, 101)
        Me.TextBoxArticleCommentArticleID.Name = "TextBoxArticleCommentArticleID"
        Me.TextBoxArticleCommentArticleID.Size = New System.Drawing.Size(78, 26)
        Me.TextBoxArticleCommentArticleID.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(164, 271)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(78, 26)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(164, 311)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(248, 26)
        Me.TextBox5.TabIndex = 10
        '
        'TextBoxArticleCommentComment
        '
        Me.TextBoxArticleCommentComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleCommentComment.Location = New System.Drawing.Point(165, 176)
        Me.TextBoxArticleCommentComment.Name = "TextBoxArticleCommentComment"
        Me.TextBoxArticleCommentComment.Size = New System.Drawing.Size(248, 80)
        Me.TextBoxArticleCommentComment.TabIndex = 8
        '
        'DateTimePickerArticleCommentDate
        '
        Me.DateTimePickerArticleCommentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerArticleCommentDate.Location = New System.Drawing.Point(164, 143)
        Me.DateTimePickerArticleCommentDate.Name = "DateTimePickerArticleCommentDate"
        Me.DateTimePickerArticleCommentDate.Size = New System.Drawing.Size(247, 22)
        Me.DateTimePickerArticleCommentDate.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(20, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(137, 489)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 36)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(255, 489)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 36)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(373, 489)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 36)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(618, 457)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 36)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Print"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridViewArticleComment
        '
        Me.DataGridViewArticleComment.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.DataGridViewArticleComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewArticleComment.Location = New System.Drawing.Point(498, 25)
        Me.DataGridViewArticleComment.Name = "DataGridViewArticleComment"
        Me.DataGridViewArticleComment.Size = New System.Drawing.Size(347, 426)
        Me.DataGridViewArticleComment.TabIndex = 17
        '
        'CommentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(873, 547)
        Me.Controls.Add(Me.DataGridViewArticleComment)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePickerArticleCommentDate)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBoxArticleCommentComment)
        Me.Controls.Add(Me.TextBoxArticleCommentArticleID)
        Me.Controls.Add(Me.TextBoxArticleCommentArticleTitle)
        Me.Controls.Add(Me.LabelArticleCommentUserName)
        Me.Controls.Add(Me.LabelArticleCommentUserID)
        Me.Controls.Add(Me.LabelArticleCommentComment)
        Me.Controls.Add(Me.LabelArticleCommentDate)
        Me.Controls.Add(Me.LabelArticleCommentArticleID)
        Me.Controls.Add(Me.LabelArticleCommentArticleTitle)
        Me.Name = "CommentForm"
        Me.Text = "CommentForm"
        CType(Me.DataGridViewArticleComment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelArticleCommentArticleTitle As Label
    Friend WithEvents LabelArticleCommentArticleID As Label
    Friend WithEvents LabelArticleCommentDate As Label
    Friend WithEvents LabelArticleCommentComment As Label
    Friend WithEvents LabelArticleCommentUserID As Label
    Friend WithEvents LabelArticleCommentUserName As Label
    Friend WithEvents TextBoxArticleCommentArticleTitle As TextBox
    Friend WithEvents TextBoxArticleCommentArticleID As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBoxArticleCommentComment As TextBox
    Friend WithEvents DateTimePickerArticleCommentDate As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewArticleComment As DataGridView
End Class
