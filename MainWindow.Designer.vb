<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.TittleAppLabel = New System.Windows.Forms.Label()
        Me.BandwidthTxt = New System.Windows.Forms.TextBox()
        Me.UserBox = New System.Windows.Forms.TextBox()
        Me.RealTimeBox = New System.Windows.Forms.TextBox()
        Me.BandwidthLabel = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.RTSLabel = New System.Windows.Forms.Label()
        Me.RTPersonLabel = New System.Windows.Forms.Label()
        Me.RTPersonBox = New System.Windows.Forms.TextBox()
        Me.RTSBtn = New System.Windows.Forms.Button()
        Me.RTPersonBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TittleAppLabel
        '
        Me.TittleAppLabel.AutoSize = True
        Me.TittleAppLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TittleAppLabel.Location = New System.Drawing.Point(12, 23)
        Me.TittleAppLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TittleAppLabel.Name = "TittleAppLabel"
        Me.TittleAppLabel.Size = New System.Drawing.Size(278, 25)
        Me.TittleAppLabel.TabIndex = 0
        Me.TittleAppLabel.Text = "Bandwidth Share Calculator"
        '
        'BandwidthTxt
        '
        Me.BandwidthTxt.Location = New System.Drawing.Point(252, 93)
        Me.BandwidthTxt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BandwidthTxt.Name = "BandwidthTxt"
        Me.BandwidthTxt.Size = New System.Drawing.Size(36, 20)
        Me.BandwidthTxt.TabIndex = 1
        '
        'UserBox
        '
        Me.UserBox.Location = New System.Drawing.Point(252, 131)
        Me.UserBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(36, 20)
        Me.UserBox.TabIndex = 2
        '
        'RealTimeBox
        '
        Me.RealTimeBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RealTimeBox.Cursor = System.Windows.Forms.Cursors.No
        Me.RealTimeBox.Enabled = False
        Me.RealTimeBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.RealTimeBox.Location = New System.Drawing.Point(227, 170)
        Me.RealTimeBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RealTimeBox.Name = "RealTimeBox"
        Me.RealTimeBox.ReadOnly = True
        Me.RealTimeBox.Size = New System.Drawing.Size(62, 20)
        Me.RealTimeBox.TabIndex = 3
        Me.RealTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BandwidthLabel
        '
        Me.BandwidthLabel.AutoSize = True
        Me.BandwidthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BandwidthLabel.Location = New System.Drawing.Point(9, 92)
        Me.BandwidthLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BandwidthLabel.Name = "BandwidthLabel"
        Me.BandwidthLabel.Size = New System.Drawing.Size(183, 18)
        Me.BandwidthLabel.TabIndex = 4
        Me.BandwidthLabel.Text = "Bandwidth nominal (Mbps)"
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.Location = New System.Drawing.Point(9, 130)
        Me.UserLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(77, 18)
        Me.UserLabel.TabIndex = 5
        Me.UserLabel.Text = "Total User"
        '
        'RTSLabel
        '
        Me.RTSLabel.AutoSize = True
        Me.RTSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTSLabel.Location = New System.Drawing.Point(9, 169)
        Me.RTSLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RTSLabel.Name = "RTSLabel"
        Me.RTSLabel.Size = New System.Drawing.Size(162, 18)
        Me.RTSLabel.TabIndex = 6
        Me.RTSLabel.Text = "Real Time Speed MB/S"
        '
        'RTPersonLabel
        '
        Me.RTPersonLabel.AutoSize = True
        Me.RTPersonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTPersonLabel.Location = New System.Drawing.Point(11, 208)
        Me.RTPersonLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RTPersonLabel.Name = "RTPersonLabel"
        Me.RTPersonLabel.Size = New System.Drawing.Size(200, 18)
        Me.RTPersonLabel.TabIndex = 7
        Me.RTPersonLabel.Text = "Real Time Speed Per Person"
        '
        'RTPersonBox
        '
        Me.RTPersonBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RTPersonBox.Cursor = System.Windows.Forms.Cursors.No
        Me.RTPersonBox.Enabled = False
        Me.RTPersonBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.RTPersonBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.RTPersonBox.Location = New System.Drawing.Point(227, 209)
        Me.RTPersonBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RTPersonBox.MaxLength = 3
        Me.RTPersonBox.Name = "RTPersonBox"
        Me.RTPersonBox.ReadOnly = True
        Me.RTPersonBox.Size = New System.Drawing.Size(61, 20)
        Me.RTPersonBox.TabIndex = 8
        '
        'RTSBtn
        '
        Me.RTSBtn.Location = New System.Drawing.Point(183, 255)
        Me.RTSBtn.Name = "RTSBtn"
        Me.RTSBtn.Size = New System.Drawing.Size(108, 35)
        Me.RTSBtn.TabIndex = 9
        Me.RTSBtn.Text = "Calculate Real Time Speed"
        Me.RTSBtn.UseVisualStyleBackColor = True
        '
        'RTPersonBtn
        '
        Me.RTPersonBtn.Location = New System.Drawing.Point(12, 255)
        Me.RTPersonBtn.Name = "RTPersonBtn"
        Me.RTPersonBtn.Size = New System.Drawing.Size(110, 35)
        Me.RTPersonBtn.TabIndex = 10
        Me.RTPersonBtn.Text = "Calculate Real Time Speed/Person"
        Me.RTPersonBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(303, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calculate Your Bandwidth Needs"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 372)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RTPersonBtn)
        Me.Controls.Add(Me.RTSBtn)
        Me.Controls.Add(Me.RTPersonBox)
        Me.Controls.Add(Me.RTPersonLabel)
        Me.Controls.Add(Me.RTSLabel)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.BandwidthLabel)
        Me.Controls.Add(Me.RealTimeBox)
        Me.Controls.Add(Me.UserBox)
        Me.Controls.Add(Me.BandwidthTxt)
        Me.Controls.Add(Me.TittleAppLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "MainWindow"
        Me.Text = "Bandwidth Share Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TittleAppLabel As Label
    Friend WithEvents BandwidthTxt As TextBox
    Friend WithEvents UserBox As TextBox
    Friend WithEvents RealTimeBox As TextBox
    Friend WithEvents BandwidthLabel As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents RTSLabel As Label
    Friend WithEvents RTPersonLabel As Label
    Friend WithEvents RTPersonBox As TextBox
    Friend WithEvents RTSBtn As Button
    Friend WithEvents RTPersonBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
