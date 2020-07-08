<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
		Me.LabelLogo = New System.Windows.Forms.Label()
		Me.TextBoxUserName = New System.Windows.Forms.TextBox()
		Me.TextBoxPassword = New System.Windows.Forms.TextBox()
		Me.LabelStatus = New System.Windows.Forms.Label()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.ButtonLogin = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
		Me.PictureBoxbackGround = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBoxbackGround, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LabelLogo
		'
		Me.LabelLogo.AutoSize = True
		Me.LabelLogo.Font = New System.Drawing.Font("Rockwell Extra Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelLogo.ForeColor = System.Drawing.Color.AliceBlue
		Me.LabelLogo.Location = New System.Drawing.Point(67, 119)
		Me.LabelLogo.Name = "LabelLogo"
		Me.LabelLogo.Size = New System.Drawing.Size(170, 32)
		Me.LabelLogo.TabIndex = 0
		Me.LabelLogo.Text = "PERIPLUS"
		'
		'TextBoxUserName
		'
		Me.TextBoxUserName.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TextBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TextBoxUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxUserName.Location = New System.Drawing.Point(107, 166)
		Me.TextBoxUserName.Name = "TextBoxUserName"
		Me.TextBoxUserName.Size = New System.Drawing.Size(119, 29)
		Me.TextBoxUserName.TabIndex = 3
		'
		'TextBoxPassword
		'
		Me.TextBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxPassword.Location = New System.Drawing.Point(107, 206)
		Me.TextBoxPassword.Name = "TextBoxPassword"
		Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxPassword.Size = New System.Drawing.Size(119, 29)
		Me.TextBoxPassword.TabIndex = 5
		'
		'LabelStatus
		'
		Me.LabelStatus.AutoSize = True
		Me.LabelStatus.Location = New System.Drawing.Point(196, 372)
		Me.LabelStatus.Name = "LabelStatus"
		Me.LabelStatus.Size = New System.Drawing.Size(10, 13)
		Me.LabelStatus.TabIndex = 8
		Me.LabelStatus.Text = "."
		'
		'ButtonCancel
		'
		Me.ButtonCancel.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ButtonCancel.BackgroundImage = Global.MorningTodoListPeriplus.My.Resources.Resources.close_window_32px
		Me.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonCancel.FlatAppearance.BorderSize = 0
		Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonCancel.Location = New System.Drawing.Point(165, 246)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(41, 28)
		Me.ButtonCancel.TabIndex = 7
		Me.ButtonCancel.UseVisualStyleBackColor = False
		'
		'ButtonLogin
		'
		Me.ButtonLogin.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ButtonLogin.BackgroundImage = Global.MorningTodoListPeriplus.My.Resources.Resources.telegram_app_32px
		Me.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonLogin.FlatAppearance.BorderSize = 0
		Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonLogin.Location = New System.Drawing.Point(107, 247)
		Me.ButtonLogin.Name = "ButtonLogin"
		Me.ButtonLogin.Size = New System.Drawing.Size(41, 28)
		Me.ButtonLogin.TabIndex = 6
		Me.ButtonLogin.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
		Me.PictureBox1.BackgroundImage = Global.MorningTodoListPeriplus.My.Resources.Resources.password_32px
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox1.Location = New System.Drawing.Point(61, 205)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(35, 29)
		Me.PictureBox1.TabIndex = 4
		Me.PictureBox1.TabStop = False
		'
		'PictureBoxUser
		'
		Me.PictureBoxUser.BackColor = System.Drawing.Color.WhiteSmoke
		Me.PictureBoxUser.BackgroundImage = Global.MorningTodoListPeriplus.My.Resources.Resources.user_32px
		Me.PictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBoxUser.Location = New System.Drawing.Point(61, 166)
		Me.PictureBoxUser.Name = "PictureBoxUser"
		Me.PictureBoxUser.Size = New System.Drawing.Size(35, 29)
		Me.PictureBoxUser.TabIndex = 2
		Me.PictureBoxUser.TabStop = False
		'
		'PictureBoxbackGround
		'
		Me.PictureBoxbackGround.BackgroundImage = Global.MorningTodoListPeriplus.My.Resources.Resources.pngtree_vintage_frame_background_png_image_316654
		Me.PictureBoxbackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBoxbackGround.Location = New System.Drawing.Point(16, -71)
		Me.PictureBoxbackGround.Name = "PictureBoxbackGround"
		Me.PictureBoxbackGround.Size = New System.Drawing.Size(263, 523)
		Me.PictureBoxbackGround.TabIndex = 1
		Me.PictureBoxbackGround.TabStop = False
		'
		'FormLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CornflowerBlue
		Me.ClientSize = New System.Drawing.Size(299, 394)
		Me.Controls.Add(Me.LabelStatus)
		Me.Controls.Add(Me.ButtonCancel)
		Me.Controls.Add(Me.ButtonLogin)
		Me.Controls.Add(Me.TextBoxPassword)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.TextBoxUserName)
		Me.Controls.Add(Me.PictureBoxUser)
		Me.Controls.Add(Me.LabelLogo)
		Me.Controls.Add(Me.PictureBoxbackGround)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormLogin"
		Me.Opacity = 0.95R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBoxbackGround, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelLogo As Label
	Friend WithEvents PictureBoxbackGround As PictureBox
	Friend WithEvents PictureBoxUser As PictureBox
	Friend WithEvents TextBoxUserName As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents TextBoxPassword As TextBox
	Friend WithEvents ButtonLogin As Button
	Friend WithEvents ButtonCancel As Button
	Public WithEvents LabelStatus As Label
End Class
