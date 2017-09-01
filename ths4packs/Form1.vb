Imports HtmlAgilityPack
Imports System.Net
Imports System.Drawing.Color
Imports System.Threading
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports SharpCompress.Archive
Imports SharpCompress.Common

Public Class Form1
    Dim SC As SynchronizationContext
    Dim page As Integer = 0

    Structure Params
        Dim S As String
        Dim P As Integer
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'WebBrowser1.Silent = True
    End Sub

    Public WebSite As String = "http://sims4pack.ru"
    Public Mods As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "/Electronic Arts/The Sims 4/Mods"
    Public dID As String
    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ListBox2.Items.Count <> 0) Then
            Label7.Text = "Модов в категории: " & ListBox2.Items.Count
        Else
            Label7.Text = ""
        End If

        If (PictureBox1.Tag + 1 = ListBox2.Items.Count) Then
            PictureBox2.Enabled = False
        Else
            PictureBox2.Enabled = True
        End If

        If (PictureBox1.Tag = 1) Then
            PictureBox3.Enabled = False
        Else
            PictureBox3.Enabled = True
        End If

        If (viewphoto.Visible = True) Then
            Label7.Text = PictureBox1.Tag + 1 & " из " & ListBox2.Items.Count
            If GetAsyncKeyState(Keys.Left) And PictureBox1.Tag >= 1 Then
                'Back
                PictureBox1.Image = My.Resources.Resources._04de2e31234507_564a1d23645bf
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

                Dim title As String = ListBox3.Items(PictureBox1.Tag - 1)
                title = title.Replace("&quot;", "")
                PictureBox1.Tag = PictureBox1.Tag - 1
                PictureBox1.ImageLocation = Replace(ListBox2.Items(PictureBox1.Tag), "img600", "img")
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                Label2.Text = title
                Label1.Text = ListBox4.Items(PictureBox1.Tag)
                viewphoto.Show()
            End If

            If GetAsyncKeyState(Keys.Right) And PictureBox1.Tag + 1 <= ListBox2.Items.Count - 1 Then
                'Next
                PictureBox1.Image = My.Resources.Resources._04de2e31234507_564a1d23645bf
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

                Dim title As String = ListBox3.Items(PictureBox1.Tag + 1)
                title = title.Replace("&quot;", "")
                PictureBox1.Tag = PictureBox1.Tag + 1
                PictureBox1.ImageLocation = Replace(ListBox2.Items(PictureBox1.Tag), "img600", "img")
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                Label2.Text = title
                Label1.Text = ListBox4.Items(PictureBox1.Tag)
                viewphoto.Show()
            End If
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If (TreeView1.SelectedNode.Name <> "genetika") Then
            FlowLayoutPanel1.Controls.Clear()
            Label4.Visible = False
            Label3.Visible = False

            button_refresh.Enabled = True

            Dim page As Integer = 0
            Panel1.Cursor = Cursors.WaitCursor

            SC = SynchronizationContext.Current
            Dim Th As New System.Threading.Thread(AddressOf Work)
            Dim Param As New Params With {.S = TreeView1.SelectedNode.Name, .P = 0}
            Th.Start(Param)

            Panel1.Cursor = Cursors.Default
            Panel2.Visible = False
        End If
    End Sub

    Sub Work(ByVal Par As Params)
        SC.Send(AddressOf GetTitle, Par)
    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Try
            ProgressBar1.Maximum = e.MaximumProgress
            ProgressBar1.Value = e.CurrentProgress
        Catch ex As Exception

        End Try

    End Sub

    Public Function GetTitle(ByVal Par As Params)
        'Получение списка модов

        ListBox1.Items.Clear()  'Очищаем наши списки
        ListBox2.Items.Clear()  'Очищаем наши списки
        ListBox3.Items.Clear()  'Очищаем наши списки
        ListBox4.Items.Clear()  'Очищаем наши списки

        'OLD
        'Dim web As New HtmlWeb
        'Dim doc As New HtmlDocument

        'Показываем пользователю, что идёт загрузка данных
        FlowLayoutPanel1.Cursor = Cursors.WaitCursor
        Panel2.Cursor = Cursors.WaitCursor

        Dim k As Integer = 0
        ProgressBar1.Maximum = 20
        ProgressBar1.Style = ProgressBarStyle.Marquee
        While (k <> 21)
            ProgressBar1.Value = k
            'Устанавливаем параметры пути
            Dim vs = Par.S
            Dim vp = k
            Dim vc2 = ""
            Dim vcg = ""

            k = k + 1

            'Собираем путь
            Dim SiteURL As String = WebSite & "/engine/shadow.php?vc=" & vs & "&vp= " & vp & "&vc2= " & vc2 & "&vcg=" & vcg

            'Получаем содержимое страницы
            Dim HTML = (New System.Net.WebClient).DownloadString(SiteURL)

            'Меняем кодировку страницы
            Dim Encw1252 As Encoding = Encoding.GetEncoding("utf-8")
            Dim EncUTF8 As Encoding = Encoding.GetEncoding("UTF-8")
            HTML = Encw1252.GetString(Encoding.Convert(EncUTF8, Encw1252, Encoding.Default.GetBytes(HTML)))

            '<div class="mb"><div class="image" style="background-image: url('{1}');"></div>
            '<div Class='mat_info'><a href="{2}">{3}</a>{4}</div><div class='aandc'>...</div></div>

            '{1} - image
            '{2} - link
            '{3} - title
            '{4} - description

            'start <div class="mb">
            'end </div></div>


            'Получения ссылок на страницу поста
            Dim urls As String = "<div class='mat_info'><a href=[""']([^>]*)[""']>[^<]*</a>\s*"
            For Each match As Match In Regex.Matches(HTML, urls)
                ListBox1.Items.Add(WebSite & match.Groups(1).Value)
            Next

            'Получение ссылок на изображения
            Dim images As String = "style=""background-image: url\((?:""|""|')(.+?)(?:""|""|')\);"">\s*"
            For Each match As Match In Regex.Matches(HTML, images)
                ListBox2.Items.Add(WebSite & match.Groups(1).Value)
            Next

            'Получение заголовков
            Dim titles As String = "<div class='mat_info'><a href=[^>]*>([^<]*)</a>\s*"
            For Each match As Match In Regex.Matches(HTML, titles)
                ListBox3.Items.Add(match.Groups(1).Value)

            Next

            'Получение описания
            Dim description As String = "</a>([^>]*)</div><div class='aandc'>\s*"
            For Each match As Match In Regex.Matches(HTML, description)
                ListBox4.Items.Add(match.Groups(1).Value)
            Next

            FlowLayoutPanel1.Refresh()
        End While

        'OLD:
        'Получения ссылок на страницу поста
        'For Each urls As HtmlNode In doc.DocumentNode.SelectNodes("//*[@id=""dle-content""]/div/div[2]/div[1]/b/a")
        'ListBox1.Items.Add(urls.Attributes("href").Value)
        'Next

        'Получение ссылок на изображения
        'For Each images As HtmlNode In doc.DocumentNode.SelectNodes("//*[@id=""dle-content""]/div/div[1]/span/a/img")
        'ListBox2.Items.Add(images.Attributes("src").Value)
        '
        'Next

        'Получение заголовков
        'For Each titles As HtmlNode In doc.DocumentNode.SelectNodes("//*[@id=""dle-content""]/div/div[2]/div[1]/b/a")
        'ListBox3.Items.Add(titles.InnerText)
        'Debug.WriteLine("Загрузка: " & titles.InnerText)
        'If (ProgressBar1.Value <> 102) Then
        'ProgressBar1.Value = ProgressBar1.Value + 1.6
        'ProgressBar1.Update()
        'End If
        'Next

        'Получение описания
        'For Each description As HtmlNode In doc.DocumentNode.SelectNodes("//*[@id=""dle-content""]/div/div[2]/div[2]/div")
        'ListBox4.Items.Add(description.InnerText)
        'Next
        ProgressBar1.Value = 0
        ProgressBar1.Style = ProgressBarStyle.Continuous
        Try
            Dim g As Integer = -1
            For Each i In ListBox1.Items()
                g = g + 1
                ProgressBar1.Maximum = ListBox1.Items.Count()
                ProgressBar1.Value = g
                'URL = ListBox1.Items(g)
                'Description = ListBox4.Items(g)
                Dim Panel_1 As New Panel
                Dim Label_1 As New Label
                Dim Imagex As New PictureBox


                With Panel_1
                    .MinimumSize = New Point(150, 107)
                    .MaximumSize = New Point(150, 107)
                    .Size = New Point(150, 107)
                    .BackColor = Color.DarkGray
                End With

                Dim title As String = ListBox3.Items(g)
                title = title.Replace("&quot;", "")

                With Label_1
                    .AutoSize = False
                    .Size = New Point(300, 21)
                    .Dock = DockStyle.Top
                    .BackColor = Color.DarkGray
                    .Text = title
                    .MinimumSize = New Point(300, 21)
                    .Cursor = Cursors.Hand
                    .Tag = g
                End With


                AddHandler Label_1.Click, AddressOf Label_1_Click
                AddHandler Imagex.Click, AddressOf Imagex_Click

                With Imagex
                    .Location = New Point(4, 24)
                    .Dock = DockStyle.Left
                    .ImageLocation = ListBox2.Items(g)
                    .SizeMode = PictureBoxSizeMode.Zoom
                    .Size = New Point(150, 150)
                    .MinimumSize = New Point(150, 150)
                    .Tag = g
                End With

                FlowLayoutPanel1.Controls.Add(Panel_1)
                With Panel_1.Controls
                    .Add(Imagex)
                    .Add(Label_1)
                End With
                Debug.WriteLine(getPostID(ListBox1.Items(g)) & " - " & title & " complete!")
                FlowLayoutPanel1.Refresh()

            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        FlowLayoutPanel1.Cursor = Cursors.Default
        'Return
        ProgressBar1.Value = 0

    End Function

    Private Function getPostID(ByVal url As String) As Integer
        Dim postID As Integer

        Dim id As String = "([0-9]{3,4})-[^>]\s*"
getID:
        For Each match As Match In Regex.Matches(url, id)
            postID = match.Groups(1).Value
        Next

        If (postID = 0) Then
            id = "([0-9]{2})-[^>]\s*"
            GoTo getID
        End If

        Return postID
    End Function
    Sub Label_1_Click(sender As Object, e As EventArgs)
        Dim postID As String = getPostID(ListBox1.Items(sender.Tag))

        If (My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "/tmp/") = False) Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "/tmp/")
        End If

        WebBrowser1.Navigate(New Uri("http://sims4pack.ru/go/" & postID))
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim downloadurl As String
        Dim postID As String
        Dim url As String = ListBox1.Items(sender.Tag)

        Dim id As String = "([0-9]{3,4})-[^>]\s*"
        For Each match As Match In Regex.Matches(url, id)
            postID = match.Groups(1).Value
            Debug.WriteLine("Selected post (" & postID & "). Starting download...")
        Next

        If (My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "/tmp/") = False) Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "/tmp/")
        End If

        dID = postID
        WebBrowser1.Navigate(New Uri("http://sims4pack.ru/go/" & postID))
    End Sub

    Sub Imagex_Click(sender As Object, e As EventArgs)
        Label5.Show()
        Label7.Show()
        'Label7.Location = New Point(536, 7)
        button_downloads.Location = New Point(button_downloads.Location.X - 31, 7)
        viewphoto.Location = New Point(0, 41)
        viewphoto.Show()
        PictureBox1.Image = My.Resources.Resources._04de2e31234507_564a1d23645bf
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        Dim title As String = ListBox3.Items(sender.Tag)
        title = title.Replace("&quot;", "")
        PictureBox1.Tag = sender.Tag
        PictureBox1.ImageLocation = Replace(ListBox2.Items(PictureBox1.Tag), "img600", "img")
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Label2.Text = title
        Label1.Text = ListBox4.Items(sender.Tag)
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Next
        PictureBox1.Image = My.Resources.Resources._04de2e31234507_564a1d23645bf
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

        If (PictureBox1.Tag <= ListBox2.Items.Count - 1 And PictureBox1.Tag + 1 <= ListBox2.Items.Count - 1) Then
            Dim title As String = ListBox3.Items(PictureBox1.Tag + 1)
            title = title.Replace("&quot;", "")
            PictureBox1.Tag = PictureBox1.Tag + 1
            PictureBox1.ImageLocation = Replace(ListBox2.Items(PictureBox1.Tag), "img600", "img")
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Label2.Text = title
            Label1.Text = ListBox4.Items(PictureBox1.Tag)
            viewphoto.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'Back
        PictureBox1.Image = My.Resources.Resources._04de2e31234507_564a1d23645bf
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

        If (PictureBox1.Tag <= ListBox2.Items.Count - 1 And PictureBox1.Tag + 1 <= ListBox2.Items.Count - 1) Then
            Dim title As String = ListBox3.Items(PictureBox1.Tag - 1)
            title = title.Replace("&quot;", "")
            PictureBox1.Tag = PictureBox1.Tag - 1
            PictureBox1.ImageLocation = Replace(ListBox2.Items(PictureBox1.Tag), "img600", "img")
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Label2.Text = title
            Label1.Text = ListBox4.Items(PictureBox1.Tag)
            viewphoto.Show()
        End If
    End Sub

    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles Label5.MouseHover
        Label5.BackColor = Color.FromArgb(219, 219, 219)
    End Sub
    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.BackColor = Color.Transparent
    End Sub
    Private Sub Label6_MouseHover(sender As Object, e As EventArgs) Handles Label6.MouseHover
        Label6.BackColor = Color.FromArgb(219, 219, 219)
    End Sub
    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.BackColor = Color.Transparent
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.BackgroundImage = My.Resources.backa
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackgroundImage = My.Resources.back
    End Sub
    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.BackgroundImage = My.Resources.nexta
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackgroundImage = My.Resources._next
    End Sub
    Private Sub button_refresh_MouseHover(sender As Object, e As EventArgs) Handles button_refresh.MouseHover
        button_refresh.BackgroundImage = My.Resources.refresha
    End Sub
    Private Sub button_refresh_MouseLeave(sender As Object, e As EventArgs) Handles button_refresh.MouseLeave
        button_refresh.BackgroundImage = My.Resources.refresh
    End Sub
    Private Sub button_downloads_MouseHover(sender As Object, e As EventArgs) Handles button_downloads.MouseHover
        button_downloads.BackgroundImage = My.Resources.downloada
    End Sub
    Private Sub button_downloads_MouseLeave(sender As Object, e As EventArgs) Handles button_downloads.MouseLeave
        button_downloads.BackgroundImage = My.Resources.download
    End Sub
    Private Sub button_setting_MouseHover(sender As Object, e As EventArgs) Handles button_setting.MouseHover
        button_setting.BackgroundImage = My.Resources.configa
    End Sub
    Private Sub button_setting_MouseLeave(sender As Object, e As EventArgs) Handles button_setting.MouseLeave
        button_setting.BackgroundImage = My.Resources.config
    End Sub

    Private Sub button_refresh_Click(sender As Object, e As EventArgs) Handles button_refresh.Click
        FlowLayoutPanel1.Controls.Clear()
        Panel2.Visible = True
        Panel1.Cursor = Cursors.WaitCursor

        SC = SynchronizationContext.Current
        Dim Th As New System.Threading.Thread(AddressOf Work)
        Dim Param As New Params With {.S = TreeView1.SelectedNode.Name, .P = page}
        Th.Start(Param)

        Panel1.Cursor = Cursors.Default
        Panel2.Visible = False
    End Sub

    Private Sub button_downloads_Click(sender As Object, e As EventArgs) Handles button_downloads.Click
        down_panel.Show()
    End Sub

    Private Sub viewphoto_LostFocus(sender As Object, e As EventArgs) Handles viewphoto.LostFocus
        viewphoto.Hide()
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        viewphoto.Hide()
        button_downloads.Location = New Point(702, 7)
        'Label7.Location = New Point(567, 7)
        Label7.Hide()
        Label5.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As EventArgs) Handles Panel3.Click, TreeView1.Click, Panel2.Click, FlowLayoutPanel1.Click, viewphoto.Click, PictureBox1.Click, Panel5.Click, Label1.Click, Label2.Click
        down_panel.Hide()
    End Sub

    Private Sub button_setting_Click(sender As Object, e As EventArgs) Handles button_setting.Click
        setting.ShowDialog()

    End Sub

    Private Sub Form1_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        ProgressBar1.Value = 0
    End Sub
End Class
Class Rar
    Public Shared Function Uncompress(ByVal filename As String)
        Dim archive As IArchive = ArchiveFactory.Open(filename)
        For Each entry In archive.Entries
            If Not entry.IsDirectory Then
                entry.WriteToDirectory(My.Application.Info.DirectoryPath & "/tmp/",
                  ExtractOptions.ExtractFullPath Or ExtractOptions.Overwrite)
                Return True
            End If
            Return False
        Next
        Return False
    End Function
End Class