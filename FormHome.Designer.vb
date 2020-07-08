<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
		Me.Panelkiri = New System.Windows.Forms.Panel()
		Me.PanelHeader = New System.Windows.Forms.Panel()
		Me.PanelLogo = New System.Windows.Forms.Panel()
		Me.Panelkiri.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panelkiri
		'
		Me.Panelkiri.Controls.Add(Me.PanelLogo)
		Me.Panelkiri.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panelkiri.Location = New System.Drawing.Point(0, 0)
		Me.Panelkiri.Name = "Panelkiri"
		Me.Panelkiri.Size = New System.Drawing.Size(102, 768)
		Me.Panelkiri.TabIndex = 0
		'
		'PanelHeader
		'
		Me.PanelHeader.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelHeader.Location = New System.Drawing.Point(102, 0)
		Me.PanelHeader.Name = "PanelHeader"
		Me.PanelHeader.Size = New System.Drawing.Size(922, 103)
		Me.PanelHeader.TabIndex = 1
		'
		'PanelLogo
		'
		Me.PanelLogo.BackgroundImage = Global.MorningTodoListPeriplus.My.Resources.Resources.Banner_Periplus
		Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
		Me.PanelLogo.Name = "PanelLogo"
		Me.PanelLogo.Size = New System.Drawing.Size(102, 104)
		Me.PanelLogo.TabIndex = 1
		'
		'FormHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CornflowerBlue
		Me.ClientSize = New System.Drawing.Size(1024, 768)
		Me.Controls.Add(Me.PanelHeader)
		Me.Controls.Add(Me.Panelkiri)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormHome"
		Me.Opacity = 0.95R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormHome"
		Me.Panelkiri.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panelkiri As Panel
	Friend WithEvents PanelLogo As Panel
	Friend WithEvents PanelHeader As Panel
End Class
