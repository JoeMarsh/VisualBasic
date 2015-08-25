Public Class Form1
    Private stopwatch As New Diagnostics.Stopwatch

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        lblTimer.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
        Math.Floor(elapsed.TotalHours),
        elapsed.Minutes, elapsed.Seconds,
        elapsed.Milliseconds)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
        Me.stopwatch.Start()
        btnReset.Enabled = False
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        btnReset.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.stopwatch.Reset()
        lblTimer.Text = "00:00:00:000"
        lbResults.Items.Clear()
    End Sub

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click
        lbResults.Items.Add(lbResults.Items.Count + 1 & " " & lblTimer.Text)
    End Sub

End Class
