Public Class MainWindow
    Dim Bandwidth, User As Long
    Dim SpeedReal, SpeedPerPerson As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Window2 As New BandwidthNeedCalc
        Window2.Show()
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutApp.Show()
        Me.Hide()
    End Sub
    Private Sub RTPersonBtn_Click(sender As Object, e As EventArgs) Handles RTPersonBtn.Click
        If BandwidthTxt.Text = "" And UserBox.Text = "" Then
            MessageBox.Show("Please enter User & Internet Bandwidth Nominal", "No entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Bandwidth = BandwidthTxt.Text
            User = UserBox.Text
            SpeedPerPerson = (Bandwidth / 8) / User
            RTPersonBox.Text = SpeedPerPerson
            RTPersonBox.Text = FormatNumber(SpeedPerPerson, 3)
        End If
    End Sub

    Private Sub RTSBtn_Click(sender As Object, e As EventArgs) Handles RTSBtn.Click
        If BandwidthTxt.Text = "" And UserBox.Text = "" Then
            MessageBox.Show("Please enter User & Internet Bandwidth Nominal", "No entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Bandwidth = BandwidthTxt.Text
            SpeedReal = Bandwidth / 8
            RealTimeBox.Text = SpeedReal
            RealTimeBox.Text = FormatNumber(SpeedReal, 2)
        End If
    End Sub
End Class