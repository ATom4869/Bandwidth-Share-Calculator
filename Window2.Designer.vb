<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BandwidthNeedCalc
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
        Me.RTPersonCol = New System.Windows.Forms.TextBox()
        Me.RTPersonLabels = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.BandwidthLabel = New System.Windows.Forms.Label()
        Me.UserCol = New System.Windows.Forms.TextBox()
        Me.BandwidthCol = New System.Windows.Forms.TextBox()
        Me.TittleAppLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InfoUnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RTPersonCol
        '
        Me.RTPersonCol.BackColor = System.Drawing.SystemColors.Window
        Me.RTPersonCol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RTPersonCol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RTPersonCol.Location = New System.Drawing.Point(252, 135)
        Me.RTPersonCol.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RTPersonCol.Name = "RTPersonCol"
        Me.RTPersonCol.Size = New System.Drawing.Size(36, 20)
        Me.RTPersonCol.TabIndex = 21
        '
        'RTPersonLabels
        '
        Me.RTPersonLabels.AutoSize = True
        Me.RTPersonLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTPersonLabels.Location = New System.Drawing.Point(11, 134)
        Me.RTPersonLabels.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RTPersonLabels.Name = "RTPersonLabels"
        Me.RTPersonLabels.Size = New System.Drawing.Size(200, 36)
        Me.RTPersonLabels.TabIndex = 20
        Me.RTPersonLabels.Text = "Real Time Speed Per Person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(MegaByte/second)"
        Me.RTPersonLabels.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.Location = New System.Drawing.Point(11, 88)
        Me.UserLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(77, 18)
        Me.UserLabel.TabIndex = 18
        Me.UserLabel.Text = "Total User"
        '
        'BandwidthLabel
        '
        Me.BandwidthLabel.AutoSize = True
        Me.BandwidthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BandwidthLabel.Location = New System.Drawing.Point(11, 188)
        Me.BandwidthLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BandwidthLabel.Name = "BandwidthLabel"
        Me.BandwidthLabel.Size = New System.Drawing.Size(123, 36)
        Me.BandwidthLabel.TabIndex = 17
        Me.BandwidthLabel.Text = "Bandwidth Needs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Megabit/second)"
        Me.BandwidthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UserCol
        '
        Me.UserCol.Location = New System.Drawing.Point(252, 89)
        Me.UserCol.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.UserCol.Name = "UserCol"
        Me.UserCol.Size = New System.Drawing.Size(36, 20)
        Me.UserCol.TabIndex = 15
        '
        'BandwidthCol
        '
        Me.BandwidthCol.Enabled = False
        Me.BandwidthCol.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BandwidthCol.Location = New System.Drawing.Point(252, 189)
        Me.BandwidthCol.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BandwidthCol.Name = "BandwidthCol"
        Me.BandwidthCol.Size = New System.Drawing.Size(36, 20)
        Me.BandwidthCol.TabIndex = 14
        '
        'TittleAppLabel
        '
        Me.TittleAppLabel.AutoSize = True
        Me.TittleAppLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TittleAppLabel.Location = New System.Drawing.Point(12, 37)
        Me.TittleAppLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TittleAppLabel.Name = "TittleAppLabel"
        Me.TittleAppLabel.Size = New System.Drawing.Size(278, 25)
        Me.TittleAppLabel.TabIndex = 13
        Me.TittleAppLabel.Text = "Bandwidth Share Calculator"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(304, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ControlToolStripMenuItem
        '
        Me.ControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToolStripMenuItem, Me.InfoUnitToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.ControlToolStripMenuItem.Name = "ControlToolStripMenuItem"
        Me.ControlToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ControlToolStripMenuItem.Text = "&Control"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReturnToolStripMenuItem.Text = "Retur&n"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 35)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Calculate Your Bandwidth Needs"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InfoUnitToolStripMenuItem
        '
        Me.InfoUnitToolStripMenuItem.Name = "InfoUnitToolStripMenuItem"
        Me.InfoUnitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InfoUnitToolStripMenuItem.Text = "&Info Unit"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'BandwidthNeedCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.RTPersonCol)
        Me.Controls.Add(Me.RTPersonLabels)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.BandwidthLabel)
        Me.Controls.Add(Me.UserCol)
        Me.Controls.Add(Me.BandwidthCol)
        Me.Controls.Add(Me.TittleAppLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BandwidthNeedCalc"
        Me.Text = "Bandwidth Needs Calcluator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RTPersonCol As TextBox
    Friend WithEvents RTPersonLabels As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents BandwidthLabel As Label
    Friend WithEvents UserCol As TextBox
    Friend WithEvents BandwidthCol As TextBox
    Friend WithEvents TittleAppLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents ControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoUnitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
End Class
