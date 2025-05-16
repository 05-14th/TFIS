<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class franchiseeForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cs_cb = New ReaLTaiizor.Controls.MaterialComboBox()
        fi_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        BigLabel1 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel2 = New ReaLTaiizor.Controls.BigLabel()
        ipn_txtbox = New ReaLTaiizor.Controls.BigLabel()
        BigLabel7 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel8 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel9 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel13 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel15 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel19 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel21 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel25 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel31 = New ReaLTaiizor.Controls.BigLabel()
        BigTextBox3 = New ReaLTaiizor.Controls.BigTextBox()
        fn_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        li_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        mn_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        model_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        ln_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        year_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        gender_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        BigLabel32 = New ReaLTaiizor.Controls.BigLabel()
        pn_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        BigLabel4 = New ReaLTaiizor.Controls.BigLabel()
        vi_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        status_cb = New ReaLTaiizor.Controls.MaterialComboBox()
        ForeverButton3 = New ReaLTaiizor.Controls.ForeverButton()
        email_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        ad_dt = New DateTimePicker()
        occupation_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        age_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        BigLabel14 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel12 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel11 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel3 = New ReaLTaiizor.Controls.BigLabel()
        brgy_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        prov_txtbox = New ReaLTaiizor.Controls.MaterialComboBox()
        muni_txtbox = New ReaLTaiizor.Controls.MaterialComboBox()
        zip_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        BigLabel27 = New ReaLTaiizor.Controls.BigLabel()
        birthdate_dt = New DateTimePicker()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cs_cb
        ' 
        cs_cb.AutoResize = False
        cs_cb.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cs_cb.Depth = 0
        cs_cb.Dock = DockStyle.Fill
        cs_cb.DrawMode = DrawMode.OwnerDrawVariable
        cs_cb.DropDownHeight = 174
        cs_cb.DropDownStyle = ComboBoxStyle.DropDownList
        cs_cb.DropDownWidth = 121
        cs_cb.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        cs_cb.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cs_cb.FormattingEnabled = True
        cs_cb.IntegralHeight = False
        cs_cb.ItemHeight = 43
        cs_cb.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Partner"})
        cs_cb.Location = New Point(330, 35)
        cs_cb.MaxDropDownItems = 4
        cs_cb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        cs_cb.Name = "cs_cb"
        cs_cb.Size = New Size(321, 49)
        cs_cb.StartIndex = 0
        cs_cb.TabIndex = 54
        ' 
        ' fi_txtbox
        ' 
        fi_txtbox.BackColor = Color.Transparent
        fi_txtbox.Dock = DockStyle.Fill
        fi_txtbox.Font = New Font("Tahoma", 11F)
        fi_txtbox.ForeColor = Color.DimGray
        fi_txtbox.Image = Nothing
        fi_txtbox.Location = New Point(3, 35)
        fi_txtbox.MaxLength = 32767
        fi_txtbox.Multiline = False
        fi_txtbox.Name = "fi_txtbox"
        fi_txtbox.ReadOnly = True
        fi_txtbox.Size = New Size(321, 50)
        fi_txtbox.TabIndex = 36
        fi_txtbox.TextAlignment = HorizontalAlignment.Left
        fi_txtbox.UseSystemPasswordChar = False
        ' 
        ' BigLabel1
        ' 
        BigLabel1.AutoSize = True
        BigLabel1.BackColor = Color.Transparent
        BigLabel1.Dock = DockStyle.Fill
        BigLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel1.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel1.Location = New Point(3, 0)
        BigLabel1.Name = "BigLabel1"
        BigLabel1.Size = New Size(321, 32)
        BigLabel1.TabIndex = 0
        BigLabel1.Text = "Franchisee ID"
        ' 
        ' BigLabel2
        ' 
        BigLabel2.AutoSize = True
        BigLabel2.BackColor = Color.Transparent
        BigLabel2.Dock = DockStyle.Fill
        BigLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel2.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel2.Location = New Point(330, 0)
        BigLabel2.Name = "BigLabel2"
        BigLabel2.Size = New Size(321, 32)
        BigLabel2.TabIndex = 1
        BigLabel2.Text = "Civil Status"
        ' 
        ' ipn_txtbox
        ' 
        ipn_txtbox.AutoSize = True
        ipn_txtbox.BackColor = Color.Transparent
        ipn_txtbox.Dock = DockStyle.Fill
        ipn_txtbox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ipn_txtbox.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        ipn_txtbox.Location = New Point(657, 0)
        ipn_txtbox.Name = "ipn_txtbox"
        ipn_txtbox.Size = New Size(307, 32)
        ipn_txtbox.TabIndex = 2
        ipn_txtbox.Text = "Insurance Policy Number"
        ' 
        ' BigLabel7
        ' 
        BigLabel7.AutoSize = True
        BigLabel7.BackColor = Color.Transparent
        BigLabel7.Dock = DockStyle.Fill
        BigLabel7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel7.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel7.Location = New Point(3, 88)
        BigLabel7.Name = "BigLabel7"
        BigLabel7.Size = New Size(321, 32)
        BigLabel7.TabIndex = 6
        BigLabel7.Text = "First Name"
        ' 
        ' BigLabel8
        ' 
        BigLabel8.AutoSize = True
        BigLabel8.BackColor = Color.Transparent
        BigLabel8.Dock = DockStyle.Fill
        BigLabel8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel8.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel8.Location = New Point(330, 88)
        BigLabel8.Name = "BigLabel8"
        BigLabel8.Size = New Size(321, 32)
        BigLabel8.TabIndex = 7
        BigLabel8.Text = "Address"
        ' 
        ' BigLabel9
        ' 
        BigLabel9.AutoSize = True
        BigLabel9.BackColor = Color.Transparent
        BigLabel9.Dock = DockStyle.Fill
        BigLabel9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel9.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel9.Location = New Point(657, 88)
        BigLabel9.Name = "BigLabel9"
        BigLabel9.Size = New Size(307, 32)
        BigLabel9.TabIndex = 8
        BigLabel9.Text = "License ID"
        ' 
        ' BigLabel13
        ' 
        BigLabel13.AutoSize = True
        BigLabel13.BackColor = Color.Transparent
        BigLabel13.Dock = DockStyle.Fill
        BigLabel13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel13.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel13.Location = New Point(3, 176)
        BigLabel13.Name = "BigLabel13"
        BigLabel13.Size = New Size(321, 55)
        BigLabel13.TabIndex = 12
        BigLabel13.Text = "Middle Name(Optional)"
        ' 
        ' BigLabel15
        ' 
        BigLabel15.AutoSize = True
        BigLabel15.BackColor = Color.Transparent
        BigLabel15.Dock = DockStyle.Fill
        BigLabel15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel15.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel15.Location = New Point(657, 176)
        BigLabel15.Name = "BigLabel15"
        BigLabel15.Size = New Size(307, 55)
        BigLabel15.TabIndex = 14
        BigLabel15.Text = "Model"
        ' 
        ' BigLabel19
        ' 
        BigLabel19.AutoSize = True
        BigLabel19.BackColor = Color.Transparent
        BigLabel19.Dock = DockStyle.Fill
        BigLabel19.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel19.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel19.Location = New Point(3, 287)
        BigLabel19.Name = "BigLabel19"
        BigLabel19.Size = New Size(321, 56)
        BigLabel19.TabIndex = 18
        BigLabel19.Text = "Last Name"
        ' 
        ' BigLabel21
        ' 
        BigLabel21.AutoSize = True
        BigLabel21.BackColor = Color.Transparent
        BigLabel21.Dock = DockStyle.Fill
        BigLabel21.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel21.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel21.Location = New Point(657, 287)
        BigLabel21.Name = "BigLabel21"
        BigLabel21.Size = New Size(307, 56)
        BigLabel21.TabIndex = 20
        BigLabel21.Text = "Year"
        ' 
        ' BigLabel25
        ' 
        BigLabel25.AutoSize = True
        BigLabel25.BackColor = Color.Transparent
        BigLabel25.Dock = DockStyle.Fill
        BigLabel25.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel25.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel25.Location = New Point(3, 399)
        BigLabel25.Name = "BigLabel25"
        BigLabel25.Size = New Size(321, 56)
        BigLabel25.TabIndex = 24
        BigLabel25.Text = "Gender"
        ' 
        ' BigLabel31
        ' 
        BigLabel31.AutoSize = True
        BigLabel31.BackColor = Color.Transparent
        BigLabel31.Dock = DockStyle.Fill
        BigLabel31.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel31.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel31.Location = New Point(3, 511)
        BigLabel31.Name = "BigLabel31"
        BigLabel31.Size = New Size(321, 56)
        BigLabel31.TabIndex = 30
        BigLabel31.Text = "Birthdate"
        ' 
        ' BigTextBox3
        ' 
        BigTextBox3.BackColor = Color.Transparent
        BigTextBox3.Dock = DockStyle.Fill
        BigTextBox3.Font = New Font("Tahoma", 11F)
        BigTextBox3.ForeColor = Color.DimGray
        BigTextBox3.Image = Nothing
        BigTextBox3.Location = New Point(657, 35)
        BigTextBox3.MaxLength = 32767
        BigTextBox3.Multiline = False
        BigTextBox3.Name = "BigTextBox3"
        BigTextBox3.ReadOnly = False
        BigTextBox3.Size = New Size(307, 50)
        BigTextBox3.TabIndex = 38
        BigTextBox3.TextAlignment = HorizontalAlignment.Left
        BigTextBox3.UseSystemPasswordChar = False
        ' 
        ' fn_txtbox
        ' 
        fn_txtbox.BackColor = Color.Transparent
        fn_txtbox.Dock = DockStyle.Fill
        fn_txtbox.Font = New Font("Tahoma", 11F)
        fn_txtbox.ForeColor = Color.DimGray
        fn_txtbox.Image = Nothing
        fn_txtbox.Location = New Point(3, 123)
        fn_txtbox.MaxLength = 32767
        fn_txtbox.Multiline = False
        fn_txtbox.Name = "fn_txtbox"
        fn_txtbox.ReadOnly = False
        fn_txtbox.Size = New Size(321, 50)
        fn_txtbox.TabIndex = 39
        fn_txtbox.TextAlignment = HorizontalAlignment.Left
        fn_txtbox.UseSystemPasswordChar = False
        ' 
        ' li_txtbox
        ' 
        li_txtbox.BackColor = Color.Transparent
        li_txtbox.Dock = DockStyle.Fill
        li_txtbox.Font = New Font("Tahoma", 11F)
        li_txtbox.ForeColor = Color.DimGray
        li_txtbox.Image = Nothing
        li_txtbox.Location = New Point(657, 123)
        li_txtbox.MaxLength = 32767
        li_txtbox.Multiline = False
        li_txtbox.Name = "li_txtbox"
        li_txtbox.ReadOnly = False
        li_txtbox.Size = New Size(307, 50)
        li_txtbox.TabIndex = 41
        li_txtbox.TextAlignment = HorizontalAlignment.Left
        li_txtbox.UseSystemPasswordChar = False
        ' 
        ' mn_txtbox
        ' 
        mn_txtbox.BackColor = Color.Transparent
        mn_txtbox.Dock = DockStyle.Fill
        mn_txtbox.Font = New Font("Tahoma", 11F)
        mn_txtbox.ForeColor = Color.DimGray
        mn_txtbox.Image = Nothing
        mn_txtbox.Location = New Point(3, 234)
        mn_txtbox.MaxLength = 32767
        mn_txtbox.Multiline = False
        mn_txtbox.Name = "mn_txtbox"
        mn_txtbox.ReadOnly = False
        mn_txtbox.Size = New Size(321, 50)
        mn_txtbox.TabIndex = 42
        mn_txtbox.TextAlignment = HorizontalAlignment.Left
        mn_txtbox.UseSystemPasswordChar = False
        ' 
        ' model_txtbox
        ' 
        model_txtbox.BackColor = Color.Transparent
        model_txtbox.Dock = DockStyle.Fill
        model_txtbox.Font = New Font("Tahoma", 11F)
        model_txtbox.ForeColor = Color.DimGray
        model_txtbox.Image = Nothing
        model_txtbox.Location = New Point(657, 234)
        model_txtbox.MaxLength = 32767
        model_txtbox.Multiline = False
        model_txtbox.Name = "model_txtbox"
        model_txtbox.ReadOnly = False
        model_txtbox.Size = New Size(307, 50)
        model_txtbox.TabIndex = 44
        model_txtbox.TextAlignment = HorizontalAlignment.Left
        model_txtbox.UseSystemPasswordChar = False
        ' 
        ' ln_txtbox
        ' 
        ln_txtbox.BackColor = Color.Transparent
        ln_txtbox.Dock = DockStyle.Fill
        ln_txtbox.Font = New Font("Tahoma", 11F)
        ln_txtbox.ForeColor = Color.DimGray
        ln_txtbox.Image = Nothing
        ln_txtbox.Location = New Point(3, 346)
        ln_txtbox.MaxLength = 32767
        ln_txtbox.Multiline = False
        ln_txtbox.Name = "ln_txtbox"
        ln_txtbox.ReadOnly = False
        ln_txtbox.Size = New Size(321, 50)
        ln_txtbox.TabIndex = 45
        ln_txtbox.TextAlignment = HorizontalAlignment.Left
        ln_txtbox.UseSystemPasswordChar = False
        ' 
        ' year_txtbox
        ' 
        year_txtbox.BackColor = Color.Transparent
        year_txtbox.Dock = DockStyle.Fill
        year_txtbox.Font = New Font("Tahoma", 11F)
        year_txtbox.ForeColor = Color.DimGray
        year_txtbox.Image = Nothing
        year_txtbox.Location = New Point(657, 346)
        year_txtbox.MaxLength = 32767
        year_txtbox.Multiline = False
        year_txtbox.Name = "year_txtbox"
        year_txtbox.ReadOnly = False
        year_txtbox.Size = New Size(307, 50)
        year_txtbox.TabIndex = 47
        year_txtbox.TextAlignment = HorizontalAlignment.Left
        year_txtbox.UseSystemPasswordChar = False
        ' 
        ' gender_txtbox
        ' 
        gender_txtbox.BackColor = Color.Transparent
        gender_txtbox.Dock = DockStyle.Fill
        gender_txtbox.Font = New Font("Tahoma", 11F)
        gender_txtbox.ForeColor = Color.DimGray
        gender_txtbox.Image = Nothing
        gender_txtbox.Location = New Point(3, 458)
        gender_txtbox.MaxLength = 32767
        gender_txtbox.Multiline = False
        gender_txtbox.Name = "gender_txtbox"
        gender_txtbox.ReadOnly = False
        gender_txtbox.Size = New Size(321, 50)
        gender_txtbox.TabIndex = 48
        gender_txtbox.TextAlignment = HorizontalAlignment.Left
        gender_txtbox.UseSystemPasswordChar = False
        ' 
        ' BigLabel32
        ' 
        BigLabel32.AutoSize = True
        BigLabel32.BackColor = Color.Transparent
        BigLabel32.Dock = DockStyle.Fill
        BigLabel32.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel32.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel32.Location = New Point(330, 343)
        BigLabel32.Name = "BigLabel32"
        BigLabel32.Size = New Size(321, 56)
        BigLabel32.TabIndex = 58
        BigLabel32.Text = "Phone Number"
        ' 
        ' pn_txtbox
        ' 
        pn_txtbox.BackColor = Color.Transparent
        pn_txtbox.Dock = DockStyle.Fill
        pn_txtbox.Font = New Font("Tahoma", 11F)
        pn_txtbox.ForeColor = Color.DimGray
        pn_txtbox.Image = Nothing
        pn_txtbox.Location = New Point(330, 402)
        pn_txtbox.MaxLength = 32767
        pn_txtbox.Multiline = False
        pn_txtbox.Name = "pn_txtbox"
        pn_txtbox.ReadOnly = False
        pn_txtbox.Size = New Size(321, 50)
        pn_txtbox.TabIndex = 59
        pn_txtbox.TextAlignment = HorizontalAlignment.Left
        pn_txtbox.UseSystemPasswordChar = False
        ' 
        ' BigLabel4
        ' 
        BigLabel4.AutoSize = True
        BigLabel4.BackColor = Color.Transparent
        BigLabel4.Dock = DockStyle.Fill
        BigLabel4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel4.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel4.Location = New Point(330, 455)
        BigLabel4.Name = "BigLabel4"
        BigLabel4.Size = New Size(321, 56)
        BigLabel4.TabIndex = 60
        BigLabel4.Text = "Valid ID"
        ' 
        ' vi_txtbox
        ' 
        vi_txtbox.BackColor = Color.Transparent
        vi_txtbox.Dock = DockStyle.Fill
        vi_txtbox.Font = New Font("Tahoma", 11F)
        vi_txtbox.ForeColor = Color.DimGray
        vi_txtbox.Image = Nothing
        vi_txtbox.Location = New Point(330, 514)
        vi_txtbox.MaxLength = 32767
        vi_txtbox.Multiline = False
        vi_txtbox.Name = "vi_txtbox"
        vi_txtbox.ReadOnly = False
        vi_txtbox.Size = New Size(321, 50)
        vi_txtbox.TabIndex = 61
        vi_txtbox.TextAlignment = HorizontalAlignment.Left
        vi_txtbox.UseSystemPasswordChar = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 313F))
        TableLayoutPanel1.Controls.Add(status_cb, 2, 9)
        TableLayoutPanel1.Controls.Add(ForeverButton3, 2, 14)
        TableLayoutPanel1.Controls.Add(email_txtbox, 2, 13)
        TableLayoutPanel1.Controls.Add(ad_dt, 2, 11)
        TableLayoutPanel1.Controls.Add(occupation_txtbox, 1, 13)
        TableLayoutPanel1.Controls.Add(age_txtbox, 0, 13)
        TableLayoutPanel1.Controls.Add(BigLabel14, 2, 12)
        TableLayoutPanel1.Controls.Add(BigLabel12, 1, 12)
        TableLayoutPanel1.Controls.Add(BigLabel11, 0, 12)
        TableLayoutPanel1.Controls.Add(BigLabel3, 2, 10)
        TableLayoutPanel1.Controls.Add(brgy_txtbox, 1, 3)
        TableLayoutPanel1.Controls.Add(prov_txtbox, 1, 5)
        TableLayoutPanel1.Controls.Add(muni_txtbox, 1, 4)
        TableLayoutPanel1.Controls.Add(vi_txtbox, 1, 10)
        TableLayoutPanel1.Controls.Add(BigLabel4, 1, 9)
        TableLayoutPanel1.Controls.Add(pn_txtbox, 1, 8)
        TableLayoutPanel1.Controls.Add(BigLabel32, 1, 7)
        TableLayoutPanel1.Controls.Add(zip_txtbox, 1, 6)
        TableLayoutPanel1.Controls.Add(gender_txtbox, 0, 9)
        TableLayoutPanel1.Controls.Add(year_txtbox, 2, 7)
        TableLayoutPanel1.Controls.Add(ln_txtbox, 0, 7)
        TableLayoutPanel1.Controls.Add(model_txtbox, 2, 5)
        TableLayoutPanel1.Controls.Add(mn_txtbox, 0, 5)
        TableLayoutPanel1.Controls.Add(li_txtbox, 2, 3)
        TableLayoutPanel1.Controls.Add(fn_txtbox, 0, 3)
        TableLayoutPanel1.Controls.Add(BigTextBox3, 2, 1)
        TableLayoutPanel1.Controls.Add(BigLabel31, 0, 10)
        TableLayoutPanel1.Controls.Add(BigLabel27, 2, 8)
        TableLayoutPanel1.Controls.Add(BigLabel25, 0, 8)
        TableLayoutPanel1.Controls.Add(BigLabel21, 2, 6)
        TableLayoutPanel1.Controls.Add(BigLabel19, 0, 6)
        TableLayoutPanel1.Controls.Add(BigLabel15, 2, 4)
        TableLayoutPanel1.Controls.Add(BigLabel13, 0, 4)
        TableLayoutPanel1.Controls.Add(BigLabel9, 2, 2)
        TableLayoutPanel1.Controls.Add(BigLabel8, 1, 2)
        TableLayoutPanel1.Controls.Add(BigLabel7, 0, 2)
        TableLayoutPanel1.Controls.Add(ipn_txtbox, 2, 0)
        TableLayoutPanel1.Controls.Add(BigLabel2, 1, 0)
        TableLayoutPanel1.Controls.Add(BigLabel1, 0, 0)
        TableLayoutPanel1.Controls.Add(fi_txtbox, 0, 1)
        TableLayoutPanel1.Controls.Add(cs_cb, 1, 1)
        TableLayoutPanel1.Controls.Add(birthdate_dt, 0, 11)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 13
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 63F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 8F))
        TableLayoutPanel1.Size = New Size(967, 789)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' status_cb
        ' 
        status_cb.AutoResize = False
        status_cb.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        status_cb.Depth = 0
        status_cb.Dock = DockStyle.Fill
        status_cb.DrawMode = DrawMode.OwnerDrawVariable
        status_cb.DropDownHeight = 174
        status_cb.DropDownStyle = ComboBoxStyle.DropDownList
        status_cb.DropDownWidth = 121
        status_cb.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        status_cb.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        status_cb.FormattingEnabled = True
        status_cb.IntegralHeight = False
        status_cb.ItemHeight = 43
        status_cb.Items.AddRange(New Object() {"Pending", "Approved", "Rejected"})
        status_cb.Location = New Point(657, 458)
        status_cb.MaxDropDownItems = 4
        status_cb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        status_cb.Name = "status_cb"
        status_cb.Size = New Size(307, 49)
        status_cb.StartIndex = 0
        status_cb.TabIndex = 103
        ' 
        ' ForeverButton3
        ' 
        ForeverButton3.BackColor = Color.Transparent
        ForeverButton3.BaseColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ForeverButton3.Dock = DockStyle.Top
        ForeverButton3.Font = New Font("Segoe UI", 12F)
        ForeverButton3.Location = New Point(657, 710)
        ForeverButton3.Name = "ForeverButton3"
        ForeverButton3.Rounded = False
        ForeverButton3.Size = New Size(307, 60)
        ForeverButton3.TabIndex = 102
        ForeverButton3.Text = "SAVE"
        ForeverButton3.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' email_txtbox
        ' 
        email_txtbox.BackColor = Color.Transparent
        email_txtbox.Dock = DockStyle.Fill
        email_txtbox.Font = New Font("Tahoma", 11F)
        email_txtbox.ForeColor = Color.DimGray
        email_txtbox.Image = Nothing
        email_txtbox.Location = New Point(657, 647)
        email_txtbox.MaxLength = 32767
        email_txtbox.Multiline = False
        email_txtbox.Name = "email_txtbox"
        email_txtbox.ReadOnly = False
        email_txtbox.Size = New Size(307, 50)
        email_txtbox.TabIndex = 98
        email_txtbox.TextAlignment = HorizontalAlignment.Left
        email_txtbox.UseSystemPasswordChar = False
        ' 
        ' ad_dt
        ' 
        ad_dt.Dock = DockStyle.Fill
        ad_dt.Location = New Point(657, 570)
        ad_dt.Name = "ad_dt"
        ad_dt.Size = New Size(307, 31)
        ad_dt.TabIndex = 96
        ' 
        ' occupation_txtbox
        ' 
        occupation_txtbox.BackColor = Color.Transparent
        occupation_txtbox.Dock = DockStyle.Fill
        occupation_txtbox.Font = New Font("Tahoma", 11F)
        occupation_txtbox.ForeColor = Color.DimGray
        occupation_txtbox.Image = Nothing
        occupation_txtbox.Location = New Point(330, 647)
        occupation_txtbox.MaxLength = 32767
        occupation_txtbox.Multiline = False
        occupation_txtbox.Name = "occupation_txtbox"
        occupation_txtbox.ReadOnly = False
        occupation_txtbox.Size = New Size(321, 50)
        occupation_txtbox.TabIndex = 94
        occupation_txtbox.TextAlignment = HorizontalAlignment.Left
        occupation_txtbox.UseSystemPasswordChar = False
        ' 
        ' age_txtbox
        ' 
        age_txtbox.BackColor = Color.Transparent
        age_txtbox.Dock = DockStyle.Fill
        age_txtbox.Font = New Font("Tahoma", 11F)
        age_txtbox.ForeColor = Color.DimGray
        age_txtbox.Image = Nothing
        age_txtbox.Location = New Point(3, 647)
        age_txtbox.MaxLength = 32767
        age_txtbox.Multiline = False
        age_txtbox.Name = "age_txtbox"
        age_txtbox.ReadOnly = False
        age_txtbox.Size = New Size(321, 50)
        age_txtbox.TabIndex = 92
        age_txtbox.TextAlignment = HorizontalAlignment.Left
        age_txtbox.UseSystemPasswordChar = False
        ' 
        ' BigLabel14
        ' 
        BigLabel14.AutoSize = True
        BigLabel14.BackColor = Color.Transparent
        BigLabel14.Dock = DockStyle.Fill
        BigLabel14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel14.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel14.Location = New Point(657, 604)
        BigLabel14.Name = "BigLabel14"
        BigLabel14.Size = New Size(307, 40)
        BigLabel14.TabIndex = 88
        BigLabel14.Text = "Email"
        ' 
        ' BigLabel12
        ' 
        BigLabel12.AutoSize = True
        BigLabel12.BackColor = Color.Transparent
        BigLabel12.Dock = DockStyle.Fill
        BigLabel12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel12.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel12.Location = New Point(330, 604)
        BigLabel12.Name = "BigLabel12"
        BigLabel12.Size = New Size(321, 40)
        BigLabel12.TabIndex = 87
        BigLabel12.Text = "Occupation"
        ' 
        ' BigLabel11
        ' 
        BigLabel11.AllowDrop = True
        BigLabel11.AutoSize = True
        BigLabel11.BackColor = Color.Transparent
        BigLabel11.Dock = DockStyle.Fill
        BigLabel11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel11.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel11.Location = New Point(3, 604)
        BigLabel11.Name = "BigLabel11"
        BigLabel11.Size = New Size(321, 40)
        BigLabel11.TabIndex = 86
        BigLabel11.Text = "Age"
        ' 
        ' BigLabel3
        ' 
        BigLabel3.AutoSize = True
        BigLabel3.BackColor = Color.Transparent
        BigLabel3.Dock = DockStyle.Fill
        BigLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel3.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel3.Location = New Point(657, 511)
        BigLabel3.Name = "BigLabel3"
        BigLabel3.Size = New Size(307, 56)
        BigLabel3.TabIndex = 79
        BigLabel3.Text = "Application Date"
        ' 
        ' brgy_txtbox
        ' 
        brgy_txtbox.BackColor = Color.Transparent
        brgy_txtbox.Dock = DockStyle.Fill
        brgy_txtbox.Font = New Font("Tahoma", 11F)
        brgy_txtbox.ForeColor = Color.DimGray
        brgy_txtbox.Image = Nothing
        brgy_txtbox.Location = New Point(330, 123)
        brgy_txtbox.MaxLength = 32767
        brgy_txtbox.Multiline = False
        brgy_txtbox.Name = "brgy_txtbox"
        brgy_txtbox.ReadOnly = False
        brgy_txtbox.Size = New Size(321, 50)
        brgy_txtbox.TabIndex = 64
        brgy_txtbox.TextAlignment = HorizontalAlignment.Left
        brgy_txtbox.UseSystemPasswordChar = False
        ' 
        ' prov_txtbox
        ' 
        prov_txtbox.AutoResize = False
        prov_txtbox.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        prov_txtbox.Depth = 0
        prov_txtbox.Dock = DockStyle.Fill
        prov_txtbox.DrawMode = DrawMode.OwnerDrawVariable
        prov_txtbox.DropDownHeight = 174
        prov_txtbox.DropDownStyle = ComboBoxStyle.DropDownList
        prov_txtbox.DropDownWidth = 121
        prov_txtbox.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        prov_txtbox.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        prov_txtbox.FormattingEnabled = True
        prov_txtbox.IntegralHeight = False
        prov_txtbox.ItemHeight = 43
        prov_txtbox.Items.AddRange(New Object() {"Camarines Norte"})
        prov_txtbox.Location = New Point(330, 234)
        prov_txtbox.MaxDropDownItems = 4
        prov_txtbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        prov_txtbox.Name = "prov_txtbox"
        prov_txtbox.Size = New Size(321, 49)
        prov_txtbox.StartIndex = 0
        prov_txtbox.TabIndex = 63
        ' 
        ' muni_txtbox
        ' 
        muni_txtbox.AutoResize = False
        muni_txtbox.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        muni_txtbox.Depth = 0
        muni_txtbox.Dock = DockStyle.Fill
        muni_txtbox.DrawMode = DrawMode.OwnerDrawVariable
        muni_txtbox.DropDownHeight = 174
        muni_txtbox.DropDownStyle = ComboBoxStyle.DropDownList
        muni_txtbox.DropDownWidth = 121
        muni_txtbox.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        muni_txtbox.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        muni_txtbox.FormattingEnabled = True
        muni_txtbox.IntegralHeight = False
        muni_txtbox.ItemHeight = 43
        muni_txtbox.Items.AddRange(New Object() {"Basud", "Daet", "Mercedes", "Vinzons", "Talisay", "Labo", "Paracale", "Capalonga", "Jose Panganiban", "San Lorenzo Ruiz", "San Vicente", "Sta Elena"})
        muni_txtbox.Location = New Point(330, 179)
        muni_txtbox.MaxDropDownItems = 4
        muni_txtbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        muni_txtbox.Name = "muni_txtbox"
        muni_txtbox.Size = New Size(321, 49)
        muni_txtbox.StartIndex = 0
        muni_txtbox.TabIndex = 62
        ' 
        ' zip_txtbox
        ' 
        zip_txtbox.BackColor = Color.Transparent
        zip_txtbox.Dock = DockStyle.Fill
        zip_txtbox.Font = New Font("Tahoma", 11F)
        zip_txtbox.ForeColor = Color.DimGray
        zip_txtbox.Image = Nothing
        zip_txtbox.Location = New Point(330, 290)
        zip_txtbox.MaxLength = 32767
        zip_txtbox.Multiline = False
        zip_txtbox.Name = "zip_txtbox"
        zip_txtbox.ReadOnly = False
        zip_txtbox.Size = New Size(321, 50)
        zip_txtbox.TabIndex = 57
        zip_txtbox.TextAlignment = HorizontalAlignment.Left
        zip_txtbox.UseSystemPasswordChar = False
        ' 
        ' BigLabel27
        ' 
        BigLabel27.AutoSize = True
        BigLabel27.BackColor = Color.Transparent
        BigLabel27.Dock = DockStyle.Fill
        BigLabel27.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel27.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel27.Location = New Point(657, 399)
        BigLabel27.Name = "BigLabel27"
        BigLabel27.Size = New Size(307, 56)
        BigLabel27.TabIndex = 26
        BigLabel27.Text = "Status"
        ' 
        ' birthdate_dt
        ' 
        birthdate_dt.Dock = DockStyle.Fill
        birthdate_dt.Location = New Point(3, 570)
        birthdate_dt.Name = "birthdate_dt"
        birthdate_dt.Size = New Size(321, 31)
        birthdate_dt.TabIndex = 76
        ' 
        ' franchiseeForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "franchiseeForm"
        Size = New Size(967, 789)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cs_cb As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents fi_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigLabel1 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel2 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents ipn_txtbox As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel7 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel8 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel9 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel13 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel15 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel19 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel21 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel25 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel31 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigTextBox3 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents fn_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents li_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents mn_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents model_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents ln_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents year_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents gender_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigLabel32 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents pn_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigLabel4 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents vi_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents brgy_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents prov_txtbox As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents muni_txtbox As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents zip_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents birthdate_dt As DateTimePicker
    Friend WithEvents BigLabel3 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel27 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents email_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents ad_dt As DateTimePicker
    Friend WithEvents occupation_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents age_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigLabel14 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel12 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel11 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents ForeverButton3 As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents status_cb As ReaLTaiizor.Controls.MaterialComboBox

End Class
