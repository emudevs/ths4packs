<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Новинки")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CAS")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Аксессуары")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Брови и ресницы")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Косметика")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Линзы и глаза")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Особенности кожи")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Скинтоны")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Татуировки")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Внешность", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Другое")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Декор")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Комнаты")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Мебель")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Наборы интерьера")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Техника")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Интерьер", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Моды")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Обувь")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Одежда")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Питомцы и животные")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Позы")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Прически")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Окна, двери и арки")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Стены и пол")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Строительные наборы")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Строительство", New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25, TreeNode26})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.button_setting = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.button_downloads = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.button_refresh = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.viewphoto = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.down_panel = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.button_setting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.button_downloads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.button_refresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.viewphoto.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.down_panel.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.Font = New System.Drawing.Font("Segoe UI Light", 10.25!)
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.Location = New System.Drawing.Point(0, 41)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "start"
        TreeNode1.NodeFont = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        TreeNode1.Text = "Новинки"
        TreeNode2.Name = "CAS-dlya-sims-4"
        TreeNode2.Text = "CAS"
        TreeNode2.ToolTipText = "CAS для Симс 4"
        TreeNode3.Name = "aksessuary-dlya-sims-4"
        TreeNode3.Text = "Аксессуары"
        TreeNode3.ToolTipText = "Аксессуары для Симс 4"
        TreeNode4.Name = "brovi-i-resnitsy-dlya-sims-4"
        TreeNode4.Text = "Брови и ресницы"
        TreeNode4.ToolTipText = "Брови и ресницы"
        TreeNode5.Name = "kosmetika-dlya-sims-4"
        TreeNode5.Text = "Косметика"
        TreeNode5.ToolTipText = "Косметика для Симс 4"
        TreeNode6.Name = "linzy-i-glaza-dlya-sims-4"
        TreeNode6.Text = "Линзы и глаза"
        TreeNode6.ToolTipText = "Линзы и глаза для Симс 4"
        TreeNode7.Name = "osobennosti-kozhi-dlya-sims-4"
        TreeNode7.Text = "Особенности кожи"
        TreeNode7.ToolTipText = "Особенности кожи для Симс 4"
        TreeNode8.Name = "skintony-dlya-sims-4"
        TreeNode8.Text = "Скинтоны"
        TreeNode8.ToolTipText = "Скинтоны для Симс 4"
        TreeNode9.Name = "tatuirovki-dlya-sims-4"
        TreeNode9.Text = "Татуировки"
        TreeNode9.ToolTipText = "Татуировки для Симс 4"
        TreeNode10.Name = "vneshnost-dlya-sims-4"
        TreeNode10.Text = "Внешность"
        TreeNode10.ToolTipText = "Внешность персонажей для Симс 4"
        TreeNode11.Name = "drugoe-dlya-sims-4"
        TreeNode11.Text = "Другое"
        TreeNode11.ToolTipText = "Другое для Симс 4"
        TreeNode12.Name = "dekor-dlya-sims-4"
        TreeNode12.Text = "Декор"
        TreeNode12.ToolTipText = "Декор для Симс 4"
        TreeNode13.Name = "komnaty-dlya-sims-4"
        TreeNode13.Text = "Комнаты"
        TreeNode13.ToolTipText = "Комнаты для Симс 4"
        TreeNode14.Name = "mebel-dlya-sims-4"
        TreeNode14.Text = "Мебель"
        TreeNode14.ToolTipText = "Мебель для Симс 4"
        TreeNode15.Name = "nabory-interera-dlya-sims-4"
        TreeNode15.Text = "Наборы интерьера"
        TreeNode15.ToolTipText = "Наборы интерьера для Симс 4"
        TreeNode16.Name = "tekhnika-dlya-sims-4"
        TreeNode16.Text = "Техника"
        TreeNode16.ToolTipText = "Техника для Симс 4"
        TreeNode17.Name = "interer-dlya-sims-4"
        TreeNode17.Text = "Интерьер"
        TreeNode17.ToolTipText = "Интерьер для Симс 4"
        TreeNode18.Name = "mody-dlya-sims-4"
        TreeNode18.Text = "Моды"
        TreeNode18.ToolTipText = "Моды для Симс 4"
        TreeNode19.Name = "obuv-dlya-sims-4"
        TreeNode19.Text = "Обувь"
        TreeNode19.ToolTipText = "Обувь для Симс 4"
        TreeNode20.Name = "odezhda-dlya-sims-4"
        TreeNode20.Text = "Одежда"
        TreeNode20.ToolTipText = "Одежда для Симс 4"
        TreeNode21.Name = "pitomtsy-i-zhivotnye-dlya-sims-4"
        TreeNode21.Text = "Питомцы и животные"
        TreeNode21.ToolTipText = "Питомцы и животные для Симс 4"
        TreeNode22.Name = "pozy-dlya-sims-4"
        TreeNode22.Text = "Позы"
        TreeNode22.ToolTipText = "Позы для Симс 4"
        TreeNode23.Name = "pricheski-dlya-sims-4"
        TreeNode23.Text = "Прически"
        TreeNode23.ToolTipText = "Прически для Симс 4"
        TreeNode24.Name = "okna-dveri-i-arki-dlya-sims-4"
        TreeNode24.Text = "Окна, двери и арки"
        TreeNode24.ToolTipText = "Окна, двери и арки для Симс 4"
        TreeNode25.Name = "steny-i-pol-dlya-sims-4"
        TreeNode25.Text = "Стены и пол"
        TreeNode25.ToolTipText = "Стены и пол для Симс 4"
        TreeNode26.Name = "nabory-stroitelstva-dlya-sims-4"
        TreeNode26.Text = "Строительные наборы"
        TreeNode26.ToolTipText = "Строительные наборы для Симс 4"
        TreeNode27.Name = "stroitelstvo-dlya-sims-4"
        TreeNode27.Text = "Строительство"
        TreeNode27.ToolTipText = "Строительство для Симс 4"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode10, TreeNode11, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode27})
        Me.TreeView1.Size = New System.Drawing.Size(251, 465)
        Me.TreeView1.TabIndex = 1
        Me.TreeView1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(737, 506)
        Me.TextBox1.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(251, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 465)
        Me.Panel1.TabIndex = 5
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(485, 465)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.TabStop = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 465)
        Me.Panel10.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(-170, 195)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(170, 156)
        Me.ListBox1.TabIndex = 6
        Me.ListBox1.Visible = False
        '
        'ListBox3
        '
        Me.ListBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 19
        Me.ListBox3.Location = New System.Drawing.Point(-120, 350)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(119, 156)
        Me.ListBox3.TabIndex = 8
        Me.ListBox3.Visible = False
        '
        'Timer1
        '
        '
        'ListBox4
        '
        Me.ListBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 19
        Me.ListBox4.Location = New System.Drawing.Point(-117, 38)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(117, 156)
        Me.ListBox4.TabIndex = 10
        Me.ListBox4.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel3.Controls.Add(Me.button_setting)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.button_downloads)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.button_refresh)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(737, 41)
        Me.Panel3.TabIndex = 12
        '
        'button_setting
        '
        Me.button_setting.BackgroundImage = Global.ths4packs.My.Resources.Resources.config
        Me.button_setting.Location = New System.Drawing.Point(41, 7)
        Me.button_setting.Name = "button_setting"
        Me.button_setting.Size = New System.Drawing.Size(27, 25)
        Me.button_setting.TabIndex = 9
        Me.button_setting.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 9.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(502, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "0 из 0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'button_downloads
        '
        Me.button_downloads.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_downloads.BackgroundImage = Global.ths4packs.My.Resources.Resources.download
        Me.button_downloads.Location = New System.Drawing.Point(702, 7)
        Me.button_downloads.Name = "button_downloads"
        Me.button_downloads.Size = New System.Drawing.Size(27, 25)
        Me.button_downloads.TabIndex = 4
        Me.button_downloads.TabStop = False
        Me.button_downloads.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 40)
        Me.ProgressBar1.Maximum = 102
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(737, 1)
        Me.ProgressBar1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(702, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "X"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'button_refresh
        '
        Me.button_refresh.BackgroundImage = Global.ths4packs.My.Resources.Resources.refresh
        Me.button_refresh.Enabled = False
        Me.button_refresh.Location = New System.Drawing.Point(8, 7)
        Me.button_refresh.Name = "button_refresh"
        Me.button_refresh.Size = New System.Drawing.Size(27, 25)
        Me.button_refresh.TabIndex = 3
        Me.button_refresh.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(255, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 464)
        Me.Panel2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(30, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 42)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Вам необходимо выбрать одну из категорий для загрузки и отображения списка модов." &
    ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 100.25!)
        Me.Label3.Location = New System.Drawing.Point(-32, -28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 177)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "⧼"
        '
        'viewphoto
        '
        Me.viewphoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewphoto.BackColor = System.Drawing.Color.Black
        Me.viewphoto.Controls.Add(Me.Panel4)
        Me.viewphoto.Controls.Add(Me.PictureBox1)
        Me.viewphoto.Controls.Add(Me.Panel5)
        Me.viewphoto.Location = New System.Drawing.Point(0, 41)
        Me.viewphoto.Name = "viewphoto"
        Me.viewphoto.Size = New System.Drawing.Size(737, 465)
        Me.viewphoto.TabIndex = 6
        Me.viewphoto.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(534, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 465)
        Me.Panel4.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ths4packs.My.Resources.Resources._04de2e31234507_564a1d23645bf
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(535, 465)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(535, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(202, 465)
        Me.Panel5.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(39, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Установить"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(169, 428)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.ths4packs.My.Resources.Resources.back
        Me.PictureBox3.Location = New System.Drawing.Point(6, 428)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Загрузка..."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(5, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 389)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Загрузка..."
        '
        'down_panel
        '
        Me.down_panel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.down_panel.Controls.Add(Me.Panel7)
        Me.down_panel.Controls.Add(Me.Panel8)
        Me.down_panel.Controls.Add(Me.Panel9)
        Me.down_panel.Controls.Add(Me.Panel12)
        Me.down_panel.Controls.Add(Me.Panel14)
        Me.down_panel.Controls.Add(Me.Panel16)
        Me.down_panel.Controls.Add(Me.Panel17)
        Me.down_panel.Controls.Add(Me.Button2)
        Me.down_panel.Controls.Add(Me.Button1)
        Me.down_panel.Location = New System.Drawing.Point(-329, 42)
        Me.down_panel.Name = "down_panel"
        Me.down_panel.Size = New System.Drawing.Size(329, 242)
        Me.down_panel.TabIndex = 14
        Me.down_panel.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(328, 1)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 240)
        Me.Panel7.TabIndex = 18
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(1, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(328, 1)
        Me.Panel8.TabIndex = 16
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(1, 241)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(328, 1)
        Me.Panel9.TabIndex = 15
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel12.Controls.Add(Me.PictureBox5)
        Me.Panel12.Controls.Add(Me.Label8)
        Me.Panel12.Controls.Add(Me.Label9)
        Me.Panel12.Controls.Add(Me.PictureBox6)
        Me.Panel12.Controls.Add(Me.Panel11)
        Me.Panel12.Location = New System.Drawing.Point(8, 135)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(314, 58)
        Me.Panel12.TabIndex = 14
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.ths4packs.My.Resources.Resources.dir
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox5.Location = New System.Drawing.Point(287, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 57)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Location = New System.Drawing.Point(56, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Загрузка завершена."
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(54, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(260, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "(скачано с sims3pack.ru) 835c_1361440 (4).zip"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.ths4packs.My.Resources.Resources.file
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(48, 57)
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 57)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(314, 1)
        Me.Panel11.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel14.Controls.Add(Me.PictureBox4)
        Me.Panel14.Controls.Add(Me.Label10)
        Me.Panel14.Controls.Add(Me.Label11)
        Me.Panel14.Controls.Add(Me.PictureBox7)
        Me.Panel14.Controls.Add(Me.Panel13)
        Me.Panel14.Location = New System.Drawing.Point(8, 71)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(314, 58)
        Me.Panel14.TabIndex = 13
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.ths4packs.My.Resources.Resources.dir
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox4.Location = New System.Drawing.Point(287, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 57)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(56, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Загрузка завершена."
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(54, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(260, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "(скачано с sims3pack.ru) 835c_1361440 (4).zip"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.ths4packs.My.Resources.Resources.file
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(48, 57)
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(0, 57)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(314, 1)
        Me.Panel13.TabIndex = 0
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1, 242)
        Me.Panel16.TabIndex = 17
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel17.Controls.Add(Me.PictureBox8)
        Me.Panel17.Controls.Add(Me.Label12)
        Me.Panel17.Controls.Add(Me.Label13)
        Me.Panel17.Controls.Add(Me.PictureBox9)
        Me.Panel17.Controls.Add(Me.Panel15)
        Me.Panel17.Location = New System.Drawing.Point(8, 7)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(314, 58)
        Me.Panel17.TabIndex = 12
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.ths4packs.My.Resources.Resources.dir
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox8.Location = New System.Drawing.Point(287, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(27, 57)
        Me.PictureBox8.TabIndex = 4
        Me.PictureBox8.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Location = New System.Drawing.Point(56, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Загрузка завершена."
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(54, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(260, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "(скачано с sims3pack.ru) 835c_1361440 (4).zip"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.ths4packs.My.Resources.Resources.file
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox9.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox9.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(48, 57)
        Me.PictureBox9.TabIndex = 1
        Me.PictureBox9.TabStop = False
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel15.Location = New System.Drawing.Point(0, 57)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(314, 1)
        Me.Panel15.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(235, 199)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 34)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Подробнее"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(8, 199)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Очистить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 19
        Me.ListBox2.Location = New System.Drawing.Point(-127, 194)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 156)
        Me.ListBox2.TabIndex = 15
        Me.ListBox2.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(-4, 377)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(255, 129)
        Me.WebBrowser1.TabIndex = 16
        Me.WebBrowser1.Url = New System.Uri("http://vk.com/mrSlink", System.UriKind.Absolute)
        Me.WebBrowser1.Visible = False
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 506)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.down_panel)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.viewphoto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 10.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(501, 501)
        Me.Name = "Form1"
        Me.Text = "The Sims 4 Packages (Alpha)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.button_setting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.button_downloads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.button_refresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.viewphoto.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.down_panel.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents button_refresh As PictureBox
    Friend WithEvents button_downloads As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents viewphoto As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents down_panel As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents button_setting As PictureBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
