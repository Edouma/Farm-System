<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.PictureBoxLogin = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.CheckBoxPass = New System.Windows.Forms.CheckBox()
        Me.BTlogin = New System.Windows.Forms.Button()
        Me.PanelFarmMgtSystem = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFarmMgtSystem.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxLogin
        '
        Me.PictureBoxLogin.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogin.BackgroundImage = CType(resources.GetObject("PictureBoxLogin.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogin.Location = New System.Drawing.Point(473, 240)
        Me.PictureBoxLogin.Name = "PictureBoxLogin"
        Me.PictureBoxLogin.Size = New System.Drawing.Size(205, 198)
        Me.PictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogin.TabIndex = 0
        Me.PictureBoxLogin.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(679, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(684, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(784, 261)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(186, 26)
        Me.TextBoxUsername.TabIndex = 3
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(784, 319)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(186, 26)
        Me.TextBoxPassword.TabIndex = 4
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'CheckBoxPass
        '
        Me.CheckBoxPass.AutoSize = True
        Me.CheckBoxPass.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPass.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPass.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxPass.Location = New System.Drawing.Point(784, 361)
        Me.CheckBoxPass.Name = "CheckBoxPass"
        Me.CheckBoxPass.Size = New System.Drawing.Size(197, 23)
        Me.CheckBoxPass.TabIndex = 5
        Me.CheckBoxPass.Text = "Show Password Characters"
        Me.CheckBoxPass.UseVisualStyleBackColor = False
        '
        'BTlogin
        '
        Me.BTlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BTlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTlogin.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTlogin.ForeColor = System.Drawing.Color.White
        Me.BTlogin.Location = New System.Drawing.Point(760, 405)
        Me.BTlogin.Name = "BTlogin"
        Me.BTlogin.Size = New System.Drawing.Size(97, 42)
        Me.BTlogin.TabIndex = 6
        Me.BTlogin.Text = "Login"
        Me.BTlogin.UseVisualStyleBackColor = False
        '
        'PanelFarmMgtSystem
        '
        Me.PanelFarmMgtSystem.BackColor = System.Drawing.Color.Chocolate
        Me.PanelFarmMgtSystem.Controls.Add(Me.Label3)
        Me.PanelFarmMgtSystem.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFarmMgtSystem.Location = New System.Drawing.Point(0, 0)
        Me.PanelFarmMgtSystem.Name = "PanelFarmMgtSystem"
        Me.PanelFarmMgtSystem.Size = New System.Drawing.Size(1370, 64)
        Me.PanelFarmMgtSystem.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(484, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(491, 38)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "FARMING MANAGEMENT SYSTEM"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PanelFarmMgtSystem)
        Me.Controls.Add(Me.BTlogin)
        Me.Controls.Add(Me.CheckBoxPass)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxLogin)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBoxLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFarmMgtSystem.ResumeLayout(False)
        Me.PanelFarmMgtSystem.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxLogin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents CheckBoxPass As CheckBox
    Friend WithEvents BTlogin As Button
    Friend WithEvents PanelFarmMgtSystem As Panel
    Friend WithEvents Label3 As Label
End Class
