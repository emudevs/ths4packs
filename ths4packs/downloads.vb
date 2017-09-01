Public Class downloads

    Private Sub downloads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = Form1.Location.X
        Dim y As Integer = Form1.Location.Y

        Dim sx As Integer = Form1.Size.Width
        Dim sy As Integer = Form1.Size.Height

        Dim ix As Integer = x + Form1.Size.Width - Me.Width - 10
        Dim iy As Integer = y + 71

        Me.Location = New Point(ix, iy)
    End Sub

    Private Sub downloads_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        MessageBox.Show("lostFocus")
        Me.Hide()
    End Sub
End Class