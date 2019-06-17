<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Core
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
        Me.lightZeroOnRBTN = New System.Windows.Forms.RadioButton()
        Me.lightZeroOffRBTN = New System.Windows.Forms.RadioButton()
        Me.lightZeroGBX = New System.Windows.Forms.GroupBox()
        Me.lightZeroRepeatGBX = New System.Windows.Forms.GroupBox()
        Me.lightZeroRepeatTXT = New System.Windows.Forms.TextBox()
        Me.lightZeroRepeatOffRBTN = New System.Windows.Forms.RadioButton()
        Me.lightZeroRepeatOnRBTN = New System.Windows.Forms.RadioButton()
        Me.sendBTN = New System.Windows.Forms.Button()
        Me.sendTXT = New System.Windows.Forms.TextBox()
        Me.sendLBL = New System.Windows.Forms.Label()
        Me.discoveredLightsLBX = New System.Windows.Forms.ListBox()
        Me.discoveredLightsLBL = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthenticationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhilipsUsernameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhilipsUsernameTXT = New System.Windows.Forms.ToolStripTextBox()
        Me.DiscoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RediscoverAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lightZeroGBX.SuspendLayout()
        Me.lightZeroRepeatGBX.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lightZeroOnRBTN
        '
        Me.lightZeroOnRBTN.AutoSize = True
        Me.lightZeroOnRBTN.Location = New System.Drawing.Point(6, 37)
        Me.lightZeroOnRBTN.Name = "lightZeroOnRBTN"
        Me.lightZeroOnRBTN.Size = New System.Drawing.Size(48, 21)
        Me.lightZeroOnRBTN.TabIndex = 1
        Me.lightZeroOnRBTN.Text = "On"
        Me.lightZeroOnRBTN.UseVisualStyleBackColor = True
        '
        'lightZeroOffRBTN
        '
        Me.lightZeroOffRBTN.AutoSize = True
        Me.lightZeroOffRBTN.Location = New System.Drawing.Point(60, 37)
        Me.lightZeroOffRBTN.Name = "lightZeroOffRBTN"
        Me.lightZeroOffRBTN.Size = New System.Drawing.Size(48, 21)
        Me.lightZeroOffRBTN.TabIndex = 2
        Me.lightZeroOffRBTN.Text = "Off"
        Me.lightZeroOffRBTN.UseVisualStyleBackColor = True
        '
        'lightZeroGBX
        '
        Me.lightZeroGBX.Controls.Add(Me.lightZeroOffRBTN)
        Me.lightZeroGBX.Controls.Add(Me.lightZeroOnRBTN)
        Me.lightZeroGBX.Location = New System.Drawing.Point(166, 50)
        Me.lightZeroGBX.Name = "lightZeroGBX"
        Me.lightZeroGBX.Size = New System.Drawing.Size(132, 77)
        Me.lightZeroGBX.TabIndex = 3
        Me.lightZeroGBX.TabStop = False
        Me.lightZeroGBX.Text = "Light"
        '
        'lightZeroRepeatGBX
        '
        Me.lightZeroRepeatGBX.Controls.Add(Me.lightZeroRepeatTXT)
        Me.lightZeroRepeatGBX.Controls.Add(Me.lightZeroRepeatOffRBTN)
        Me.lightZeroRepeatGBX.Controls.Add(Me.lightZeroRepeatOnRBTN)
        Me.lightZeroRepeatGBX.Location = New System.Drawing.Point(166, 133)
        Me.lightZeroRepeatGBX.Name = "lightZeroRepeatGBX"
        Me.lightZeroRepeatGBX.Size = New System.Drawing.Size(132, 114)
        Me.lightZeroRepeatGBX.TabIndex = 4
        Me.lightZeroRepeatGBX.TabStop = False
        Me.lightZeroRepeatGBX.Text = "Light Repeat"
        '
        'lightZeroRepeatTXT
        '
        Me.lightZeroRepeatTXT.Location = New System.Drawing.Point(8, 77)
        Me.lightZeroRepeatTXT.Name = "lightZeroRepeatTXT"
        Me.lightZeroRepeatTXT.Size = New System.Drawing.Size(100, 22)
        Me.lightZeroRepeatTXT.TabIndex = 5
        '
        'lightZeroRepeatOffRBTN
        '
        Me.lightZeroRepeatOffRBTN.AutoSize = True
        Me.lightZeroRepeatOffRBTN.Location = New System.Drawing.Point(60, 37)
        Me.lightZeroRepeatOffRBTN.Name = "lightZeroRepeatOffRBTN"
        Me.lightZeroRepeatOffRBTN.Size = New System.Drawing.Size(48, 21)
        Me.lightZeroRepeatOffRBTN.TabIndex = 2
        Me.lightZeroRepeatOffRBTN.TabStop = True
        Me.lightZeroRepeatOffRBTN.Text = "Off"
        Me.lightZeroRepeatOffRBTN.UseVisualStyleBackColor = True
        '
        'lightZeroRepeatOnRBTN
        '
        Me.lightZeroRepeatOnRBTN.AutoSize = True
        Me.lightZeroRepeatOnRBTN.Location = New System.Drawing.Point(6, 37)
        Me.lightZeroRepeatOnRBTN.Name = "lightZeroRepeatOnRBTN"
        Me.lightZeroRepeatOnRBTN.Size = New System.Drawing.Size(48, 21)
        Me.lightZeroRepeatOnRBTN.TabIndex = 1
        Me.lightZeroRepeatOnRBTN.TabStop = True
        Me.lightZeroRepeatOnRBTN.Text = "On"
        Me.lightZeroRepeatOnRBTN.UseVisualStyleBackColor = True
        '
        'sendBTN
        '
        Me.sendBTN.Location = New System.Drawing.Point(35, 133)
        Me.sendBTN.Name = "sendBTN"
        Me.sendBTN.Size = New System.Drawing.Size(81, 38)
        Me.sendBTN.TabIndex = 5
        Me.sendBTN.Text = "Send"
        Me.sendBTN.UseVisualStyleBackColor = True
        '
        'sendTXT
        '
        Me.sendTXT.Location = New System.Drawing.Point(15, 105)
        Me.sendTXT.Name = "sendTXT"
        Me.sendTXT.Size = New System.Drawing.Size(127, 22)
        Me.sendTXT.TabIndex = 6
        '
        'sendLBL
        '
        Me.sendLBL.AutoSize = True
        Me.sendLBL.Location = New System.Drawing.Point(32, 85)
        Me.sendLBL.Name = "sendLBL"
        Me.sendLBL.Size = New System.Drawing.Size(92, 17)
        Me.sendLBL.TabIndex = 7
        Me.sendLBL.Text = "Send to Light"
        '
        'discoveredLightsLBX
        '
        Me.discoveredLightsLBX.FormattingEnabled = True
        Me.discoveredLightsLBX.ItemHeight = 16
        Me.discoveredLightsLBX.Location = New System.Drawing.Point(316, 57)
        Me.discoveredLightsLBX.Name = "discoveredLightsLBX"
        Me.discoveredLightsLBX.Size = New System.Drawing.Size(209, 180)
        Me.discoveredLightsLBX.TabIndex = 8
        '
        'discoveredLightsLBL
        '
        Me.discoveredLightsLBL.AutoSize = True
        Me.discoveredLightsLBL.Location = New System.Drawing.Point(363, 28)
        Me.discoveredLightsLBL.Name = "discoveredLightsLBL"
        Me.discoveredLightsLBL.Size = New System.Drawing.Size(121, 17)
        Me.discoveredLightsLBL.TabIndex = 9
        Me.discoveredLightsLBL.Text = "Discovered Lights"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MessagesToolStripMenuItem, Me.AuthenticationToolStripMenuItem, Me.DiscoveryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(537, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MessagesToolStripMenuItem
        '
        Me.MessagesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloToolStripMenuItem})
        Me.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem"
        Me.MessagesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.MessagesToolStripMenuItem.Text = "Messages"
        '
        'HelloToolStripMenuItem
        '
        Me.HelloToolStripMenuItem.Name = "HelloToolStripMenuItem"
        Me.HelloToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.HelloToolStripMenuItem.Text = "Hello"
        '
        'AuthenticationToolStripMenuItem
        '
        Me.AuthenticationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhilipsUsernameToolStripMenuItem})
        Me.AuthenticationToolStripMenuItem.Name = "AuthenticationToolStripMenuItem"
        Me.AuthenticationToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.AuthenticationToolStripMenuItem.Text = "Authentication"
        '
        'PhilipsUsernameToolStripMenuItem
        '
        Me.PhilipsUsernameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhilipsUsernameTXT})
        Me.PhilipsUsernameToolStripMenuItem.Name = "PhilipsUsernameToolStripMenuItem"
        Me.PhilipsUsernameToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.PhilipsUsernameToolStripMenuItem.Text = "Philips Username"
        '
        'PhilipsUsernameTXT
        '
        Me.PhilipsUsernameTXT.Name = "PhilipsUsernameTXT"
        Me.PhilipsUsernameTXT.Size = New System.Drawing.Size(100, 27)
        '
        'DiscoveryToolStripMenuItem
        '
        Me.DiscoveryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RediscoverAllToolStripMenuItem})
        Me.DiscoveryToolStripMenuItem.Name = "DiscoveryToolStripMenuItem"
        Me.DiscoveryToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.DiscoveryToolStripMenuItem.Text = "Discovery"
        '
        'RediscoverAllToolStripMenuItem
        '
        Me.RediscoverAllToolStripMenuItem.Name = "RediscoverAllToolStripMenuItem"
        Me.RediscoverAllToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.RediscoverAllToolStripMenuItem.Text = "Rediscover All"
        '
        'Core
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 259)
        Me.Controls.Add(Me.discoveredLightsLBL)
        Me.Controls.Add(Me.discoveredLightsLBX)
        Me.Controls.Add(Me.sendLBL)
        Me.Controls.Add(Me.sendTXT)
        Me.Controls.Add(Me.sendBTN)
        Me.Controls.Add(Me.lightZeroRepeatGBX)
        Me.Controls.Add(Me.lightZeroGBX)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Core"
        Me.Text = "LIFX Test"
        Me.lightZeroGBX.ResumeLayout(False)
        Me.lightZeroGBX.PerformLayout()
        Me.lightZeroRepeatGBX.ResumeLayout(False)
        Me.lightZeroRepeatGBX.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lightZeroOnRBTN As RadioButton
    Friend WithEvents lightZeroOffRBTN As RadioButton
    Friend WithEvents lightZeroGBX As GroupBox
    Friend WithEvents lightZeroRepeatGBX As GroupBox
    Friend WithEvents lightZeroRepeatTXT As TextBox
    Friend WithEvents lightZeroRepeatOffRBTN As RadioButton
    Friend WithEvents lightZeroRepeatOnRBTN As RadioButton
    Friend WithEvents sendBTN As Button
    Friend WithEvents sendTXT As TextBox
    Friend WithEvents sendLBL As Label
    Friend WithEvents discoveredLightsLBX As ListBox
    Friend WithEvents discoveredLightsLBL As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuthenticationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhilipsUsernameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhilipsUsernameTXT As ToolStripTextBox
    Friend WithEvents DiscoveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RediscoverAllToolStripMenuItem As ToolStripMenuItem
End Class
