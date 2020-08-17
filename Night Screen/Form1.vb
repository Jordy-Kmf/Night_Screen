Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim w As Integer = My.Computer.Screen.Bounds.Width
        Dim h As Integer = My.Computer.Screen.Bounds.Height

        Size = New Drawing.Size(w - 3, h - 3)
    End Sub

    Private Sub btnTop_Click(sender As Object, e As EventArgs) Handles btnTop.Click
        If TopMost = True Then
            TopMost = False
            btnTop.Text = "_"
        Else
            TopMost = True
            btnTop.Text = "--"
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Opacity < 0.85 Then
            Opacity += 0.05
        End If
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        If Opacity > 0.3 Then
            Opacity -= 0.05
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
