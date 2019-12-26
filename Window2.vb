Public Class BandwidthNeedCalc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RTSpeed, Bandwidthn As Double
        Dim Users As String

        If UserCol.Text = "" And RTPersonCol.Text = "" Then
            MessageBox.Show("Please enter User & Internet Speed You Want", "No entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Users = UserCol.Text
            RTSpeed = RTPersonCol.Text
            Bandwidthn = Users * RTSpeed
            BandwidthCol.Text = Bandwidthn
        End If
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Close()
        MainWindow.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Me.Hide()
        AboutApp.Show()
    End Sub
End Class