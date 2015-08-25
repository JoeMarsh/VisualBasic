Public Class frmHello

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        MessageBox.Show("Hello World!")
        If lblMessage.Visible Then
            lblMessage.Visible = False
            btnHello.Text = "Show Text"
            else
            lblMessage.Visible = True
            btnHello.Text = "Hide Text"
        End If

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub
End Class
