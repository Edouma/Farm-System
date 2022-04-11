<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticleForm))
        Me.LabelArticleArticleTitle = New System.Windows.Forms.Label()
        Me.LabelArticleArticleContent = New System.Windows.Forms.Label()
        Me.LabelArticleArticlePublishedDate = New System.Windows.Forms.Label()
        Me.LabelArticleArticlePublishedName = New System.Windows.Forms.Label()
        Me.LabelArticleArticlePublishedID = New System.Windows.Forms.Label()
        Me.LabelArticleArticleViews = New System.Windows.Forms.Label()
        Me.TextBoxArticleArticleTitle = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleArticleContent = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleArticlePublishedName = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleArticlePublishedID = New System.Windows.Forms.TextBox()
        Me.TextBoxArticleArticleViews = New System.Windows.Forms.TextBox()
        Me.DateTimePickerArticleArticlePublishedDate = New System.Windows.Forms.DateTimePicker()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.DataGridViewArticleArticle = New System.Windows.Forms.DataGridView()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        CType(Me.DataGridViewArticleArticle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelArticleArticleTitle
        '
        Me.LabelArticleArticleTitle.AutoSize = True
        Me.LabelArticleArticleTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelArticleArticleTitle.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleArticleTitle.ForeColor = System.Drawing.Color.White
        Me.LabelArticleArticleTitle.Location = New System.Drawing.Point(46, 78)
        Me.LabelArticleArticleTitle.Name = "LabelArticleArticleTitle"
        Me.LabelArticleArticleTitle.Size = New System.Drawing.Size(126, 27)
        Me.LabelArticleArticleTitle.TabIndex = 0
        Me.LabelArticleArticleTitle.Text = "Article Title"
        '
        'LabelArticleArticleContent
        '
        Me.LabelArticleArticleContent.AutoSize = True
        Me.LabelArticleArticleContent.BackColor = System.Drawing.Color.Transparent
        Me.LabelArticleArticleContent.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleArticleContent.ForeColor = System.Drawing.Color.White
        Me.LabelArticleArticleContent.Location = New System.Drawing.Point(432, 76)
        Me.LabelArticleArticleContent.Name = "LabelArticleArticleContent"
        Me.LabelArticleArticleContent.Size = New System.Drawing.Size(154, 27)
        Me.LabelArticleArticleContent.TabIndex = 1
        Me.LabelArticleArticleContent.Text = "Article Content"
        '
        'LabelArticleArticlePublishedDate
        '
        Me.LabelArticleArticlePublishedDate.AutoSize = True
        Me.LabelArticleArticlePublishedDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelArticleArticlePublishedDate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleArticlePublishedDate.ForeColor = System.Drawing.Color.White
        Me.LabelArticleArticlePublishedDate.Location = New System.Drawing.Point(24, 114)
        Me.LabelArticleArticlePublishedDate.Name = "LabelArticleArticlePublishedDate"
        Me.LabelArticleArticlePublishedDate.Size = New System.Drawing.Size(148, 27)
        Me.LabelArticleArticlePublishedDate.TabIndex = 2
        Me.LabelArticleArticlePublishedDate.Text = "Published Date"
        '
        'LabelArticleArticlePublishedName
        '
        Me.LabelArticleArticlePublishedName.AutoSize = True
        Me.LabelArticleArticlePublishedName.BackColor = System.Drawing.Color.Transparent
        Me.LabelArticleArticlePublishedName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleArticlePublishedName.ForeColor = System.Drawing.Color.White
        Me.LabelArticleArticlePublishedName.Location = New System.Drawing.Point(25, 150)
        Me.LabelArticleArticlePublishedName.Name = "LabelArticleArticlePublishedName"
        Me.LabelArticleArticlePublishedName.Size = New System.Drawing.Size(153, 27)
        Me.LabelArticleArticlePublishedName.TabIndex = 3
        Me.LabelArticleArticlePublishedName.Text = "Publisher Name"
        '
        'LabelArticleArticlePublishedID
        '
        Me.LabelArticleArticlePublishedID.AutoSize = True
        Me.LabelArticleArticlePublishedID.BackColor = System.Drawing.Color.Transparent
        Me.LabelArticleArticlePublishedID.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleArticlePublishedID.ForeColor = System.Drawing.Color.White
        Me.LabelArticleArticlePublishedID.Location = New System.Drawing.Point(45, 193)
        Me.LabelArticleArticlePublishedID.Name = "LabelArticleArticlePublishedID"
        Me.LabelArticleArticlePublishedID.Size = New System.Drawing.Size(127, 27)
        Me.LabelArticleArticlePublishedID.TabIndex = 4
        Me.LabelArticleArticlePublishedID.Text = "Published ID"
        '
        'LabelArticleArticleViews
        '
        Me.LabelArticleArticleViews.AutoSize = True
        Me.LabelArticleArticleViews.BackColor = System.Drawing.Color.Transparent
        Me.LabelArticleArticleViews.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArticleArticleViews.ForeColor = System.Drawing.Color.White
        Me.LabelArticleArticleViews.Location = New System.Drawing.Point(523, 202)
        Me.LabelArticleArticleViews.Name = "LabelArticleArticleViews"
        Me.LabelArticleArticleViews.Size = New System.Drawing.Size(63, 27)
        Me.LabelArticleArticleViews.TabIndex = 5
        Me.LabelArticleArticleViews.Text = "Views"
        '
        'TextBoxArticleArticleTitle
        '
        Me.TextBoxArticleArticleTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleArticleTitle.Location = New System.Drawing.Point(181, 78)
        Me.TextBoxArticleArticleTitle.Name = "TextBoxArticleArticleTitle"
        Me.TextBoxArticleArticleTitle.Size = New System.Drawing.Size(236, 26)
        Me.TextBoxArticleArticleTitle.TabIndex = 6
        '
        'TextBoxArticleArticleContent
        '
        Me.TextBoxArticleArticleContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleArticleContent.Location = New System.Drawing.Point(592, 65)
        Me.TextBoxArticleArticleContent.Name = "TextBoxArticleArticleContent"
        Me.TextBoxArticleArticleContent.Size = New System.Drawing.Size(215, 129)
        Me.TextBoxArticleArticleContent.TabIndex = 7
        '
        'TextBoxArticleArticlePublishedName
        '
        Me.TextBoxArticleArticlePublishedName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleArticlePublishedName.Location = New System.Drawing.Point(181, 152)
        Me.TextBoxArticleArticlePublishedName.Name = "TextBoxArticleArticlePublishedName"
        Me.TextBoxArticleArticlePublishedName.Size = New System.Drawing.Size(236, 26)
        Me.TextBoxArticleArticlePublishedName.TabIndex = 8
        '
        'TextBoxArticleArticlePublishedID
        '
        Me.TextBoxArticleArticlePublishedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleArticlePublishedID.Location = New System.Drawing.Point(181, 193)
        Me.TextBoxArticleArticlePublishedID.Name = "TextBoxArticleArticlePublishedID"
        Me.TextBoxArticleArticlePublishedID.Size = New System.Drawing.Size(104, 26)
        Me.TextBoxArticleArticlePublishedID.TabIndex = 9
        '
        'TextBoxArticleArticleViews
        '
        Me.TextBoxArticleArticleViews.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArticleArticleViews.Location = New System.Drawing.Point(592, 203)
        Me.TextBoxArticleArticleViews.Name = "TextBoxArticleArticleViews"
        Me.TextBoxArticleArticleViews.Size = New System.Drawing.Size(56, 26)
        Me.TextBoxArticleArticleViews.TabIndex = 10
        '
        'DateTimePickerArticleArticlePublishedDate
        '
        Me.DateTimePickerArticleArticlePublishedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerArticleArticlePublishedDate.Location = New System.Drawing.Point(181, 118)
        Me.DateTimePickerArticleArticlePublishedDate.Name = "DateTimePickerArticleArticlePublishedDate"
        Me.DateTimePickerArticleArticlePublishedDate.Size = New System.Drawing.Size(236, 22)
        Me.DateTimePickerArticleArticlePublishedDate.TabIndex = 11
        '
        'ButtonNew
        '
        Me.ButtonNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNew.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNew.ForeColor = System.Drawing.Color.White
        Me.ButtonNew.Location = New System.Drawing.Point(30, 522)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(101, 38)
        Me.ButtonNew.TabIndex = 12
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.UseVisualStyleBackColor = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpdate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.Location = New System.Drawing.Point(156, 522)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(101, 38)
        Me.ButtonUpdate.TabIndex = 13
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(286, 522)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(101, 38)
        Me.ButtonSave.TabIndex = 14
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(415, 522)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(101, 38)
        Me.ButtonClose.TabIndex = 15
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'DataGridViewArticleArticle
        '
        Me.DataGridViewArticleArticle.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGridViewArticleArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewArticleArticle.Location = New System.Drawing.Point(32, 262)
        Me.DataGridViewArticleArticle.Name = "DataGridViewArticleArticle"
        Me.DataGridViewArticleArticle.Size = New System.Drawing.Size(483, 232)
        Me.DataGridViewArticleArticle.TabIndex = 16
        '
        'ButtonPrint
        '
        Me.ButtonPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrint.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrint.ForeColor = System.Drawing.Color.White
        Me.ButtonPrint.Location = New System.Drawing.Point(560, 333)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(101, 38)
        Me.ButtonPrint.TabIndex = 17
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = False
        '
        'ArticleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(855, 572)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.DataGridViewArticleArticle)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.DateTimePickerArticleArticlePublishedDate)
        Me.Controls.Add(Me.TextBoxArticleArticleViews)
        Me.Controls.Add(Me.TextBoxArticleArticlePublishedID)
        Me.Controls.Add(Me.TextBoxArticleArticlePublishedName)
        Me.Controls.Add(Me.TextBoxArticleArticleContent)
        Me.Controls.Add(Me.TextBoxArticleArticleTitle)
        Me.Controls.Add(Me.LabelArticleArticleViews)
        Me.Controls.Add(Me.LabelArticleArticlePublishedID)
        Me.Controls.Add(Me.LabelArticleArticlePublishedName)
        Me.Controls.Add(Me.LabelArticleArticlePublishedDate)
        Me.Controls.Add(Me.LabelArticleArticleContent)
        Me.Controls.Add(Me.LabelArticleArticleTitle)
        Me.Name = "ArticleForm"
        Me.Text = "ArticleForm"
        CType(Me.DataGridViewArticleArticle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelArticleArticleTitle As Label
    Friend WithEvents LabelArticleArticleContent As Label
    Friend WithEvents LabelArticleArticlePublishedDate As Label
    Friend WithEvents LabelArticleArticlePublishedName As Label
    Friend WithEvents LabelArticleArticlePublishedID As Label
    Friend WithEvents LabelArticleArticleViews As Label
    Friend WithEvents TextBoxArticleArticleTitle As TextBox
    Friend WithEvents TextBoxArticleArticleContent As TextBox
    Friend WithEvents TextBoxArticleArticlePublishedName As TextBox
    Friend WithEvents TextBoxArticleArticlePublishedID As TextBox
    Friend WithEvents TextBoxArticleArticleViews As TextBox
    Friend WithEvents DateTimePickerArticleArticlePublishedDate As DateTimePicker
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents DataGridViewArticleArticle As DataGridView
    Friend WithEvents ButtonPrint As Button
End Class
