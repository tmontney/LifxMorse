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
        Me.lightZeroBTN = New System.Windows.Forms.Button()
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
        Me.lightZeroGBX.SuspendLayout()
        Me.lightZeroRepeatGBX.SuspendLayout()
        Me.SuspendLayout()
        '
        'lightZeroBTN
        '
        Me.lightZeroBTN.Location = New System.Drawing.Point(12, 12)
        Me.lightZeroBTN.Name = "lightZeroBTN"
        Me.lightZeroBTN.Size = New System.Drawing.Size(120, 49)
        Me.lightZeroBTN.TabIndex = 0
        Me.lightZeroBTN.Text = "Send ""Hello"""
        Me.lightZeroBTN.UseVisualStyleBackColor = True
        '
        'lightZeroOnRBTN
        '
        Me.lightZeroOnRBTN.AutoSize = True
        Me.lightZeroOnRBTN.Location = New System.Drawing.Point(6, 37)
        Me.lightZeroOnRBTN.Name = "lightZeroOnRBTN"
        Me.lightZeroOnRBTN.Size = New System.Drawing.Size(48, 21)
        Me.lightZeroOnRBTN.TabIndex = 1
        Me.lightZeroOnRBTN.TabStop = True
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
        Me.lightZeroOffRBTN.TabStop = True
        Me.lightZeroOffRBTN.Text = "Off"
        Me.lightZeroOffRBTN.UseVisualStyleBackColor = True
        '
        'lightZeroGBX
        '
        Me.lightZeroGBX.Controls.Add(Me.lightZeroOffRBTN)
        Me.lightZeroGBX.Controls.Add(Me.lightZeroOnRBTN)
        Me.lightZeroGBX.Location = New System.Drawing.Point(166, 12)
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
        Me.lightZeroRepeatGBX.Location = New System.Drawing.Point(166, 104)
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
        Me.sendBTN.Location = New System.Drawing.Point(32, 180)
        Me.sendBTN.Name = "sendBTN"
        Me.sendBTN.Size = New System.Drawing.Size(81, 38)
        Me.sendBTN.TabIndex = 5
        Me.sendBTN.Text = "Send"
        Me.sendBTN.UseVisualStyleBackColor = True
        '
        'sendTXT
        '
        Me.sendTXT.Location = New System.Drawing.Point(12, 152)
        Me.sendTXT.Name = "sendTXT"
        Me.sendTXT.Size = New System.Drawing.Size(127, 22)
        Me.sendTXT.TabIndex = 6
        '
        'sendLBL
        '
        Me.sendLBL.AutoSize = True
        Me.sendLBL.Location = New System.Drawing.Point(29, 132)
        Me.sendLBL.Name = "sendLBL"
        Me.sendLBL.Size = New System.Drawing.Size(92, 17)
        Me.sendLBL.TabIndex = 7
        Me.sendLBL.Text = "Send to Light"
        '
        'discoveredLightsLBX
        '
        Me.discoveredLightsLBX.FormattingEnabled = True
        Me.discoveredLightsLBX.ItemHeight = 16
        Me.discoveredLightsLBX.Location = New System.Drawing.Point(316, 12)
        Me.discoveredLightsLBX.Name = "discoveredLightsLBX"
        Me.discoveredLightsLBX.Size = New System.Drawing.Size(209, 196)
        Me.discoveredLightsLBX.TabIndex = 8
        '
        'Core
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 233)
        Me.Controls.Add(Me.discoveredLightsLBX)
        Me.Controls.Add(Me.sendLBL)
        Me.Controls.Add(Me.sendTXT)
        Me.Controls.Add(Me.sendBTN)
        Me.Controls.Add(Me.lightZeroRepeatGBX)
        Me.Controls.Add(Me.lightZeroGBX)
        Me.Controls.Add(Me.lightZeroBTN)
        Me.Name = "Core"
        Me.Text = "LIFX Test"
        Me.lightZeroGBX.ResumeLayout(False)
        Me.lightZeroGBX.PerformLayout()
        Me.lightZeroRepeatGBX.ResumeLayout(False)
        Me.lightZeroRepeatGBX.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lightZeroBTN As Button
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
End Class
