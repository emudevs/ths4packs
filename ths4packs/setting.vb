Public Class setting
    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Electronic Arts\The Sims 4\Mods"
        Label3.Text = My.Application.Info.Version.ToString()
        Me.Size = Form1.Size
        Me.Location = Form1.Location

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        WorkProcess.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            WorkProcess.Hide()
        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        WorkProcess.Hide()
    End Sub

End Class