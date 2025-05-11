<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PanelDashboard = New Panel()
        ReportsSubpanel = New Panel()
        Button12 = New Button()
        Button11 = New Button()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        BtnReports = New Button()
        Submenupanel = New Panel()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        BtnLogout = New Button()
        ButtonMenu = New Button()
        BtnDashboard = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        IconDropDownButton1 = New FontAwesome.Sharp.IconDropDownButton()
        IconDropDownButton2 = New FontAwesome.Sharp.IconDropDownButton()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Button1 = New Button()
        BtnFullScreen = New Button()
        Panel3 = New Panel()
        PanelDashboard.SuspendLayout()
        ReportsSubpanel.SuspendLayout()
        Submenupanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelDashboard
        ' 
        PanelDashboard.AutoScroll = True
        PanelDashboard.BackColor = Color.Firebrick
        PanelDashboard.Controls.Add(ReportsSubpanel)
        PanelDashboard.Controls.Add(BtnReports)
        PanelDashboard.Controls.Add(Submenupanel)
        PanelDashboard.Controls.Add(BtnLogout)
        PanelDashboard.Controls.Add(ButtonMenu)
        PanelDashboard.Controls.Add(BtnDashboard)
        PanelDashboard.Controls.Add(Panel1)
        PanelDashboard.Dock = DockStyle.Left
        PanelDashboard.Location = New Point(0, 0)
        PanelDashboard.Margin = New Padding(4)
        PanelDashboard.Name = "PanelDashboard"
        PanelDashboard.Size = New Size(458, 1050)
        PanelDashboard.TabIndex = 0
        ' 
        ' ReportsSubpanel
        ' 
        ReportsSubpanel.Controls.Add(Button12)
        ReportsSubpanel.Controls.Add(Button11)
        ReportsSubpanel.Controls.Add(Button10)
        ReportsSubpanel.Controls.Add(Button9)
        ReportsSubpanel.Controls.Add(Button8)
        ReportsSubpanel.Dock = DockStyle.Top
        ReportsSubpanel.Location = New Point(0, 846)
        ReportsSubpanel.Name = "ReportsSubpanel"
        ReportsSubpanel.Size = New Size(432, 240)
        ReportsSubpanel.TabIndex = 13
        ' 
        ' Button12
        ' 
        Button12.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button12.BackColor = Color.White
        Button12.Dock = DockStyle.Top
        Button12.FlatAppearance.BorderSize = 0
        Button12.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button12.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button12.FlatStyle = FlatStyle.Flat
        Button12.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = SystemColors.ActiveCaptionText
        Button12.ImageAlign = ContentAlignment.MiddleLeft
        Button12.Location = New Point(0, 192)
        Button12.Margin = New Padding(4)
        Button12.Name = "Button12"
        Button12.Padding = New Padding(12, 0, 0, 0)
        Button12.Size = New Size(432, 48)
        Button12.TabIndex = 21
        Button12.Text = "Route Data Report"
        Button12.TextAlign = ContentAlignment.MiddleLeft
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button11.BackColor = Color.White
        Button11.Dock = DockStyle.Top
        Button11.FlatAppearance.BorderSize = 0
        Button11.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button11.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button11.FlatStyle = FlatStyle.Flat
        Button11.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = SystemColors.ActiveCaptionText
        Button11.ImageAlign = ContentAlignment.MiddleLeft
        Button11.Location = New Point(0, 144)
        Button11.Margin = New Padding(4)
        Button11.Name = "Button11"
        Button11.Padding = New Padding(12, 0, 0, 0)
        Button11.Size = New Size(432, 48)
        Button11.TabIndex = 20
        Button11.Text = "Renewal Report"
        Button11.TextAlign = ContentAlignment.MiddleLeft
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button10.BackColor = Color.White
        Button10.Dock = DockStyle.Top
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button10.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = SystemColors.ActiveCaptionText
        Button10.ImageAlign = ContentAlignment.MiddleLeft
        Button10.Location = New Point(0, 96)
        Button10.Margin = New Padding(4)
        Button10.Name = "Button10"
        Button10.Padding = New Padding(12, 0, 0, 0)
        Button10.Size = New Size(432, 48)
        Button10.TabIndex = 19
        Button10.Text = "Vehicle Report"
        Button10.TextAlign = ContentAlignment.MiddleLeft
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button9.BackColor = Color.White
        Button9.Dock = DockStyle.Top
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button9.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = SystemColors.ActiveCaptionText
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.Location = New Point(0, 48)
        Button9.Margin = New Padding(4)
        Button9.Name = "Button9"
        Button9.Padding = New Padding(12, 0, 0, 0)
        Button9.Size = New Size(432, 48)
        Button9.TabIndex = 18
        Button9.Text = "Active Franchise Report"
        Button9.TextAlign = ContentAlignment.MiddleLeft
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button8.BackColor = Color.White
        Button8.Dock = DockStyle.Top
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button8.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = SystemColors.ActiveCaptionText
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.Location = New Point(0, 0)
        Button8.Margin = New Padding(4)
        Button8.Name = "Button8"
        Button8.Padding = New Padding(12, 0, 0, 0)
        Button8.Size = New Size(432, 48)
        Button8.TabIndex = 17
        Button8.Text = "Active Franchisee Report"
        Button8.TextAlign = ContentAlignment.MiddleLeft
        Button8.UseVisualStyleBackColor = False
        ' 
        ' BtnReports
        ' 
        BtnReports.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnReports.BackColor = Color.LightCoral
        BtnReports.Dock = DockStyle.Top
        BtnReports.FlatAppearance.BorderSize = 0
        BtnReports.FlatAppearance.MouseDownBackColor = Color.DimGray
        BtnReports.FlatAppearance.MouseOverBackColor = Color.DimGray
        BtnReports.FlatStyle = FlatStyle.Flat
        BtnReports.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnReports.ForeColor = SystemColors.ButtonHighlight
        BtnReports.Image = My.Resources.Resources.Reports
        BtnReports.ImageAlign = ContentAlignment.MiddleLeft
        BtnReports.Location = New Point(0, 770)
        BtnReports.Margin = New Padding(4)
        BtnReports.Name = "BtnReports"
        BtnReports.Padding = New Padding(12, 0, 0, 0)
        BtnReports.Size = New Size(432, 76)
        BtnReports.TabIndex = 12
        BtnReports.Text = "Reports"
        BtnReports.UseVisualStyleBackColor = False
        ' 
        ' Submenupanel
        ' 
        Submenupanel.Controls.Add(Button7)
        Submenupanel.Controls.Add(Button6)
        Submenupanel.Controls.Add(Button5)
        Submenupanel.Controls.Add(Button4)
        Submenupanel.Controls.Add(Button3)
        Submenupanel.Controls.Add(Button2)
        Submenupanel.Dock = DockStyle.Top
        Submenupanel.Location = New Point(0, 482)
        Submenupanel.Name = "Submenupanel"
        Submenupanel.Size = New Size(432, 288)
        Submenupanel.TabIndex = 11
        ' 
        ' Button7
        ' 
        Button7.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button7.BackColor = Color.White
        Button7.Dock = DockStyle.Top
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button7.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = SystemColors.ActiveCaptionText
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(0, 240)
        Button7.Margin = New Padding(4)
        Button7.Name = "Button7"
        Button7.Padding = New Padding(12, 0, 0, 0)
        Button7.Size = New Size(432, 48)
        Button7.TabIndex = 16
        Button7.Text = "Route Assignment"
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button6.BackColor = Color.White
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button6.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.ActiveCaptionText
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(0, 192)
        Button6.Margin = New Padding(4)
        Button6.Name = "Button6"
        Button6.Padding = New Padding(12, 0, 0, 0)
        Button6.Size = New Size(432, 48)
        Button6.TabIndex = 14
        Button6.Text = "Franchise Renewal"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button5.BackColor = Color.White
        Button5.Dock = DockStyle.Top
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button5.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ActiveCaptionText
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(0, 144)
        Button5.Margin = New Padding(4)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(12, 0, 0, 0)
        Button5.Size = New Size(432, 48)
        Button5.TabIndex = 13
        Button5.Text = "Vehicle"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button4.BackColor = Color.White
        Button4.Dock = DockStyle.Top
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button4.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ActiveCaptionText
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(0, 96)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(12, 0, 0, 0)
        Button4.Size = New Size(432, 48)
        Button4.TabIndex = 12
        Button4.Text = "Franchise"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button3.BackColor = Color.White
        Button3.Dock = DockStyle.Top
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button3.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(0, 48)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(12, 0, 0, 0)
        Button3.Size = New Size(432, 48)
        Button3.TabIndex = 11
        Button3.Text = "List of Franchisee"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button2.BackColor = Color.White
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button2.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(0, 0)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(12, 0, 0, 0)
        Button2.Size = New Size(432, 48)
        Button2.TabIndex = 10
        Button2.Text = "New Entry Form"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' BtnLogout
        ' 
        BtnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnLogout.BackColor = Color.LightCoral
        BtnLogout.Dock = DockStyle.Bottom
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatAppearance.MouseDownBackColor = Color.DimGray
        BtnLogout.FlatAppearance.MouseOverBackColor = Color.DimGray
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogout.ForeColor = SystemColors.ButtonHighlight
        BtnLogout.Image = My.Resources.Resources.Log_Out__1_
        BtnLogout.ImageAlign = ContentAlignment.MiddleLeft
        BtnLogout.Location = New Point(0, 1086)
        BtnLogout.Margin = New Padding(4)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Padding = New Padding(12, 0, 0, 0)
        BtnLogout.Size = New Size(432, 76)
        BtnLogout.TabIndex = 10
        BtnLogout.Text = "Log-out"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' ButtonMenu
        ' 
        ButtonMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ButtonMenu.BackColor = Color.LightCoral
        ButtonMenu.Dock = DockStyle.Top
        ButtonMenu.FlatAppearance.BorderSize = 0
        ButtonMenu.FlatAppearance.MouseDownBackColor = Color.Gray
        ButtonMenu.FlatAppearance.MouseOverBackColor = Color.Gray
        ButtonMenu.FlatStyle = FlatStyle.Flat
        ButtonMenu.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonMenu.ForeColor = SystemColors.ButtonHighlight
        ButtonMenu.Image = CType(resources.GetObject("ButtonMenu.Image"), Image)
        ButtonMenu.ImageAlign = ContentAlignment.MiddleLeft
        ButtonMenu.Location = New Point(0, 406)
        ButtonMenu.Margin = New Padding(4)
        ButtonMenu.Name = "ButtonMenu"
        ButtonMenu.Padding = New Padding(12, 0, 0, 0)
        ButtonMenu.Size = New Size(432, 76)
        ButtonMenu.TabIndex = 7
        ButtonMenu.Text = "Menu"
        ButtonMenu.UseVisualStyleBackColor = False
        ' 
        ' BtnDashboard
        ' 
        BtnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnDashboard.BackColor = Color.LightCoral
        BtnDashboard.Dock = DockStyle.Top
        BtnDashboard.FlatAppearance.BorderSize = 0
        BtnDashboard.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnDashboard.FlatAppearance.MouseOverBackColor = Color.Gray
        BtnDashboard.FlatStyle = FlatStyle.Flat
        BtnDashboard.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDashboard.ForeColor = SystemColors.ButtonHighlight
        BtnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        BtnDashboard.Location = New Point(0, 321)
        BtnDashboard.Margin = New Padding(4)
        BtnDashboard.Name = "BtnDashboard"
        BtnDashboard.Padding = New Padding(12, 0, 0, 0)
        BtnDashboard.Size = New Size(432, 85)
        BtnDashboard.TabIndex = 5
        BtnDashboard.Text = "Dashboard"
        BtnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Violet
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(432, 321)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightCoral
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(432, 321)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' IconDropDownButton1
        ' 
        IconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconDropDownButton1.IconColor = Color.Black
        IconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconDropDownButton1.Name = "IconDropDownButton1"
        IconDropDownButton1.Size = New Size(23, 23)
        IconDropDownButton1.Text = "IconDropDownButton1"
        ' 
        ' IconDropDownButton2
        ' 
        IconDropDownButton2.IconChar = FontAwesome.Sharp.IconChar.None
        IconDropDownButton2.IconColor = Color.Black
        IconDropDownButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconDropDownButton2.Name = "IconDropDownButton2"
        IconDropDownButton2.Size = New Size(23, 23)
        IconDropDownButton2.Text = "IconDropDownButton2"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources._22c4b23f_2706_4e11_bf6e_07bc0e18684b_removebg_preview
        PictureBox2.Location = New Point(177, 74)
        PictureBox2.Margin = New Padding(4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(558, 496)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.GhostWhite
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Controls.Add(PictureBox2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(458, 66)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(904, 984)
        Panel2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.Dock = DockStyle.Right
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(630, 0)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(274, 66)
        Button1.TabIndex = 0
        Button1.Text = "Admin Harley"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BtnFullScreen
        ' 
        BtnFullScreen.BackColor = SystemColors.ActiveCaptionText
        BtnFullScreen.Dock = DockStyle.Right
        BtnFullScreen.FlatStyle = FlatStyle.Flat
        BtnFullScreen.ForeColor = SystemColors.ActiveCaptionText
        BtnFullScreen.Image = My.Resources.Resources.Full_Screen
        BtnFullScreen.Location = New Point(564, 0)
        BtnFullScreen.Margin = New Padding(4)
        BtnFullScreen.Name = "BtnFullScreen"
        BtnFullScreen.Size = New Size(66, 66)
        BtnFullScreen.TabIndex = 1
        BtnFullScreen.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightCoral
        Panel3.Controls.Add(BtnFullScreen)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(458, 0)
        Panel3.Margin = New Padding(4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(904, 66)
        Panel3.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(1362, 1050)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(PanelDashboard)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        MinimumSize = New Size(1181, 734)
        Name = "Form1"
        Text = "Admin Control Panel"
        WindowState = FormWindowState.Maximized
        PanelDashboard.ResumeLayout(False)
        ReportsSubpanel.ResumeLayout(False)
        Submenupanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconDropDownButton1 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents IconDropDownButton2 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents Submenupanel As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents BtnReports As Button
    Friend WithEvents ReportsSubpanel As Panel
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnFullScreen As Button
    Friend WithEvents Panel3 As Panel

End Class
