<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class franchiseForm
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
        lrd_dt = New DateTimePicker()
        franchisee_save = New ReaLTaiizor.Controls.ForeverButton()
        BigLabel1 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel2 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel3 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel7 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel8 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel9 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel13 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel14 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel15 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel20 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel21 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel26 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel27 = New ReaLTaiizor.Controls.BigLabel()
        franchise_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        assoc_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        fd_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        ln_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        ap_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        ed_dt = New DateTimePicker()
        TableLayoutPanel1 = New TableLayoutPanel()
        tv_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        route_cb = New ReaLTaiizor.Controls.MaterialComboBox()
        BigLabel4 = New ReaLTaiizor.Controls.BigLabel()
        vehicle_cb = New ReaLTaiizor.Controls.MaterialComboBox()
        area_cb = New ReaLTaiizor.Controls.MaterialComboBox()
        status_cb = New ReaLTaiizor.Controls.MaterialComboBox()
        franchisee_cb = New ReaLTaiizor.Controls.MaterialComboBox()
        ft_cb = New ReaLTaiizor.Controls.MaterialComboBox()
        di_dt = New DateTimePicker()
        BigLabel25 = New ReaLTaiizor.Controls.BigLabel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lrd_dt
        ' 
        lrd_dt.Dock = DockStyle.Fill
        lrd_dt.Location = New Point(659, 211)
        lrd_dt.Name = "lrd_dt"
        lrd_dt.Size = New Size(317, 31)
        lrd_dt.TabIndex = 53
        ' 
        ' franchisee_save
        ' 
        franchisee_save.BackColor = Color.Transparent
        franchisee_save.BaseColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        franchisee_save.Dock = DockStyle.Top
        franchisee_save.Font = New Font("Segoe UI", 12F)
        franchisee_save.Location = New Point(659, 492)
        franchisee_save.Name = "franchisee_save"
        franchisee_save.Rounded = False
        franchisee_save.Size = New Size(317, 60)
        franchisee_save.TabIndex = 52
        franchisee_save.Text = "SAVE"
        franchisee_save.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
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
        BigLabel1.Size = New Size(322, 32)
        BigLabel1.TabIndex = 1
        BigLabel1.Text = "Franchise ID"
        ' 
        ' BigLabel2
        ' 
        BigLabel2.AutoSize = True
        BigLabel2.BackColor = Color.Transparent
        BigLabel2.Dock = DockStyle.Fill
        BigLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel2.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel2.Location = New Point(331, 0)
        BigLabel2.Name = "BigLabel2"
        BigLabel2.Size = New Size(322, 32)
        BigLabel2.TabIndex = 2
        BigLabel2.Text = "Status"
        ' 
        ' BigLabel3
        ' 
        BigLabel3.AutoSize = True
        BigLabel3.BackColor = Color.Transparent
        BigLabel3.Dock = DockStyle.Fill
        BigLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel3.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel3.Location = New Point(659, 0)
        BigLabel3.Name = "BigLabel3"
        BigLabel3.Size = New Size(317, 32)
        BigLabel3.TabIndex = 3
        BigLabel3.Text = "Date Issued"
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
        BigLabel7.Size = New Size(322, 32)
        BigLabel7.TabIndex = 7
        BigLabel7.Text = "Franchise Type"
        ' 
        ' BigLabel8
        ' 
        BigLabel8.AutoSize = True
        BigLabel8.BackColor = Color.Transparent
        BigLabel8.Dock = DockStyle.Fill
        BigLabel8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel8.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel8.Location = New Point(331, 88)
        BigLabel8.Name = "BigLabel8"
        BigLabel8.Size = New Size(322, 32)
        BigLabel8.TabIndex = 8
        BigLabel8.Text = "Total Violations"
        ' 
        ' BigLabel9
        ' 
        BigLabel9.AutoSize = True
        BigLabel9.BackColor = Color.Transparent
        BigLabel9.Dock = DockStyle.Fill
        BigLabel9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel9.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel9.Location = New Point(659, 88)
        BigLabel9.Name = "BigLabel9"
        BigLabel9.Size = New Size(317, 32)
        BigLabel9.TabIndex = 9
        BigLabel9.Text = "Expiration Date"
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
        BigLabel13.Size = New Size(322, 32)
        BigLabel13.TabIndex = 13
        BigLabel13.Text = "Franchisee"
        ' 
        ' BigLabel14
        ' 
        BigLabel14.AutoSize = True
        BigLabel14.BackColor = Color.Transparent
        BigLabel14.Dock = DockStyle.Fill
        BigLabel14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel14.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel14.Location = New Point(331, 176)
        BigLabel14.Name = "BigLabel14"
        BigLabel14.Size = New Size(322, 32)
        BigLabel14.TabIndex = 14
        BigLabel14.Text = "Area"
        ' 
        ' BigLabel15
        ' 
        BigLabel15.AutoSize = True
        BigLabel15.BackColor = Color.Transparent
        BigLabel15.Dock = DockStyle.Fill
        BigLabel15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel15.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel15.Location = New Point(659, 176)
        BigLabel15.Name = "BigLabel15"
        BigLabel15.Size = New Size(317, 32)
        BigLabel15.TabIndex = 15
        BigLabel15.Text = "Last Renewal Date"
        ' 
        ' BigLabel20
        ' 
        BigLabel20.AutoSize = True
        BigLabel20.BackColor = Color.Transparent
        BigLabel20.Dock = DockStyle.Fill
        BigLabel20.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel20.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel20.Location = New Point(331, 263)
        BigLabel20.Name = "BigLabel20"
        BigLabel20.Size = New Size(322, 32)
        BigLabel20.TabIndex = 20
        BigLabel20.Text = "Association"
        ' 
        ' BigLabel21
        ' 
        BigLabel21.AutoSize = True
        BigLabel21.BackColor = Color.Transparent
        BigLabel21.Dock = DockStyle.Fill
        BigLabel21.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel21.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel21.Location = New Point(659, 263)
        BigLabel21.Name = "BigLabel21"
        BigLabel21.Size = New Size(317, 32)
        BigLabel21.TabIndex = 21
        BigLabel21.Text = "Franchise Duration"
        ' 
        ' BigLabel26
        ' 
        BigLabel26.AutoSize = True
        BigLabel26.BackColor = Color.Transparent
        BigLabel26.Dock = DockStyle.Fill
        BigLabel26.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel26.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel26.Location = New Point(331, 351)
        BigLabel26.Name = "BigLabel26"
        BigLabel26.Size = New Size(322, 32)
        BigLabel26.TabIndex = 26
        BigLabel26.Text = "License No."
        ' 
        ' BigLabel27
        ' 
        BigLabel27.AutoSize = True
        BigLabel27.BackColor = Color.Transparent
        BigLabel27.Dock = DockStyle.Fill
        BigLabel27.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel27.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel27.Location = New Point(659, 351)
        BigLabel27.Name = "BigLabel27"
        BigLabel27.Size = New Size(317, 32)
        BigLabel27.TabIndex = 27
        BigLabel27.Text = "Amount Paid"
        ' 
        ' franchise_txtbox
        ' 
        franchise_txtbox.BackColor = Color.Transparent
        franchise_txtbox.Dock = DockStyle.Fill
        franchise_txtbox.Font = New Font("Tahoma", 11F)
        franchise_txtbox.ForeColor = Color.DimGray
        franchise_txtbox.Image = Nothing
        franchise_txtbox.Location = New Point(3, 35)
        franchise_txtbox.MaxLength = 32767
        franchise_txtbox.Multiline = False
        franchise_txtbox.Name = "franchise_txtbox"
        franchise_txtbox.ReadOnly = False
        franchise_txtbox.Size = New Size(322, 50)
        franchise_txtbox.TabIndex = 37
        franchise_txtbox.TextAlignment = HorizontalAlignment.Left
        franchise_txtbox.UseSystemPasswordChar = False
        ' 
        ' assoc_txtbox
        ' 
        assoc_txtbox.BackColor = Color.Transparent
        assoc_txtbox.Dock = DockStyle.Fill
        assoc_txtbox.Font = New Font("Tahoma", 11F)
        assoc_txtbox.ForeColor = Color.DimGray
        assoc_txtbox.Image = Nothing
        assoc_txtbox.Location = New Point(331, 298)
        assoc_txtbox.MaxLength = 32767
        assoc_txtbox.Multiline = False
        assoc_txtbox.Name = "assoc_txtbox"
        assoc_txtbox.ReadOnly = False
        assoc_txtbox.Size = New Size(322, 50)
        assoc_txtbox.TabIndex = 47
        assoc_txtbox.TextAlignment = HorizontalAlignment.Left
        assoc_txtbox.UseSystemPasswordChar = False
        ' 
        ' fd_txtbox
        ' 
        fd_txtbox.BackColor = Color.Transparent
        fd_txtbox.Dock = DockStyle.Fill
        fd_txtbox.Font = New Font("Tahoma", 11F)
        fd_txtbox.ForeColor = Color.DimGray
        fd_txtbox.Image = Nothing
        fd_txtbox.Location = New Point(659, 298)
        fd_txtbox.MaxLength = 32767
        fd_txtbox.Multiline = False
        fd_txtbox.Name = "fd_txtbox"
        fd_txtbox.ReadOnly = False
        fd_txtbox.Size = New Size(317, 50)
        fd_txtbox.TabIndex = 48
        fd_txtbox.TextAlignment = HorizontalAlignment.Left
        fd_txtbox.UseSystemPasswordChar = False
        ' 
        ' ln_txtbox
        ' 
        ln_txtbox.BackColor = Color.Transparent
        ln_txtbox.Dock = DockStyle.Fill
        ln_txtbox.Font = New Font("Tahoma", 11F)
        ln_txtbox.ForeColor = Color.DimGray
        ln_txtbox.Image = Nothing
        ln_txtbox.Location = New Point(331, 386)
        ln_txtbox.MaxLength = 32767
        ln_txtbox.Multiline = False
        ln_txtbox.Name = "ln_txtbox"
        ln_txtbox.ReadOnly = False
        ln_txtbox.Size = New Size(322, 50)
        ln_txtbox.TabIndex = 50
        ln_txtbox.TextAlignment = HorizontalAlignment.Left
        ln_txtbox.UseSystemPasswordChar = False
        ' 
        ' ap_txtbox
        ' 
        ap_txtbox.BackColor = Color.Transparent
        ap_txtbox.Dock = DockStyle.Fill
        ap_txtbox.Font = New Font("Tahoma", 11F)
        ap_txtbox.ForeColor = Color.DimGray
        ap_txtbox.Image = Nothing
        ap_txtbox.Location = New Point(659, 386)
        ap_txtbox.MaxLength = 32767
        ap_txtbox.Multiline = False
        ap_txtbox.Name = "ap_txtbox"
        ap_txtbox.ReadOnly = False
        ap_txtbox.Size = New Size(317, 50)
        ap_txtbox.TabIndex = 51
        ap_txtbox.TextAlignment = HorizontalAlignment.Left
        ap_txtbox.UseSystemPasswordChar = False
        ' 
        ' ed_dt
        ' 
        ed_dt.Dock = DockStyle.Fill
        ed_dt.Location = New Point(659, 123)
        ed_dt.Name = "ed_dt"
        ed_dt.Size = New Size(317, 31)
        ed_dt.TabIndex = 54
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 323F))
        TableLayoutPanel1.Controls.Add(tv_txtbox, 1, 3)
        TableLayoutPanel1.Controls.Add(route_cb, 0, 7)
        TableLayoutPanel1.Controls.Add(BigLabel4, 0, 6)
        TableLayoutPanel1.Controls.Add(vehicle_cb, 0, 9)
        TableLayoutPanel1.Controls.Add(area_cb, 1, 5)
        TableLayoutPanel1.Controls.Add(status_cb, 1, 1)
        TableLayoutPanel1.Controls.Add(franchisee_cb, 0, 5)
        TableLayoutPanel1.Controls.Add(ft_cb, 0, 3)
        TableLayoutPanel1.Controls.Add(di_dt, 2, 1)
        TableLayoutPanel1.Controls.Add(ed_dt, 2, 3)
        TableLayoutPanel1.Controls.Add(ap_txtbox, 2, 9)
        TableLayoutPanel1.Controls.Add(ln_txtbox, 1, 9)
        TableLayoutPanel1.Controls.Add(fd_txtbox, 2, 7)
        TableLayoutPanel1.Controls.Add(assoc_txtbox, 1, 7)
        TableLayoutPanel1.Controls.Add(franchise_txtbox, 0, 1)
        TableLayoutPanel1.Controls.Add(BigLabel27, 2, 8)
        TableLayoutPanel1.Controls.Add(BigLabel26, 1, 8)
        TableLayoutPanel1.Controls.Add(BigLabel25, 0, 8)
        TableLayoutPanel1.Controls.Add(BigLabel21, 2, 6)
        TableLayoutPanel1.Controls.Add(BigLabel20, 1, 6)
        TableLayoutPanel1.Controls.Add(BigLabel15, 2, 4)
        TableLayoutPanel1.Controls.Add(BigLabel14, 1, 4)
        TableLayoutPanel1.Controls.Add(BigLabel13, 0, 4)
        TableLayoutPanel1.Controls.Add(BigLabel9, 2, 2)
        TableLayoutPanel1.Controls.Add(BigLabel8, 1, 2)
        TableLayoutPanel1.Controls.Add(BigLabel7, 0, 2)
        TableLayoutPanel1.Controls.Add(BigLabel3, 2, 0)
        TableLayoutPanel1.Controls.Add(BigLabel2, 1, 0)
        TableLayoutPanel1.Controls.Add(BigLabel1, 0, 0)
        TableLayoutPanel1.Controls.Add(franchisee_save, 2, 11)
        TableLayoutPanel1.Controls.Add(lrd_dt, 2, 5)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 12
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
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(979, 985)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' tv_txtbox
        ' 
        tv_txtbox.BackColor = Color.Transparent
        tv_txtbox.Dock = DockStyle.Fill
        tv_txtbox.Font = New Font("Tahoma", 11F)
        tv_txtbox.ForeColor = Color.DimGray
        tv_txtbox.Image = Nothing
        tv_txtbox.Location = New Point(331, 123)
        tv_txtbox.MaxLength = 32767
        tv_txtbox.Multiline = False
        tv_txtbox.Name = "tv_txtbox"
        tv_txtbox.ReadOnly = False
        tv_txtbox.Size = New Size(322, 50)
        tv_txtbox.TabIndex = 72
        tv_txtbox.TextAlignment = HorizontalAlignment.Left
        tv_txtbox.UseSystemPasswordChar = False
        ' 
        ' route_cb
        ' 
        route_cb.AutoResize = False
        route_cb.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        route_cb.Depth = 0
        route_cb.Dock = DockStyle.Fill
        route_cb.DrawMode = DrawMode.OwnerDrawVariable
        route_cb.DropDownHeight = 174
        route_cb.DropDownStyle = ComboBoxStyle.DropDownList
        route_cb.DropDownWidth = 121
        route_cb.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        route_cb.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        route_cb.FormattingEnabled = True
        route_cb.IntegralHeight = False
        route_cb.ItemHeight = 43
        route_cb.Location = New Point(3, 298)
        route_cb.MaxDropDownItems = 4
        route_cb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        route_cb.Name = "route_cb"
        route_cb.Size = New Size(322, 49)
        route_cb.StartIndex = 0
        route_cb.TabIndex = 71
        ' 
        ' BigLabel4
        ' 
        BigLabel4.AutoSize = True
        BigLabel4.BackColor = Color.Transparent
        BigLabel4.Dock = DockStyle.Fill
        BigLabel4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel4.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel4.Location = New Point(3, 263)
        BigLabel4.Name = "BigLabel4"
        BigLabel4.Size = New Size(322, 32)
        BigLabel4.TabIndex = 70
        BigLabel4.Text = "Route"
        ' 
        ' vehicle_cb
        ' 
        vehicle_cb.AutoResize = False
        vehicle_cb.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        vehicle_cb.Depth = 0
        vehicle_cb.Dock = DockStyle.Fill
        vehicle_cb.DrawMode = DrawMode.OwnerDrawVariable
        vehicle_cb.DropDownHeight = 174
        vehicle_cb.DropDownStyle = ComboBoxStyle.DropDownList
        vehicle_cb.DropDownWidth = 121
        vehicle_cb.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        vehicle_cb.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        vehicle_cb.FormattingEnabled = True
        vehicle_cb.IntegralHeight = False
        vehicle_cb.ItemHeight = 43
        vehicle_cb.Location = New Point(3, 386)
        vehicle_cb.MaxDropDownItems = 4
        vehicle_cb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        vehicle_cb.Name = "vehicle_cb"
        vehicle_cb.Size = New Size(322, 49)
        vehicle_cb.StartIndex = 0
        vehicle_cb.TabIndex = 68
        ' 
        ' area_cb
        ' 
        area_cb.AutoResize = False
        area_cb.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        area_cb.Depth = 0
        area_cb.Dock = DockStyle.Fill
        area_cb.DrawMode = DrawMode.OwnerDrawVariable
        area_cb.DropDownHeight = 174
        area_cb.DropDownStyle = ComboBoxStyle.DropDownList
        area_cb.DropDownWidth = 121
        area_cb.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        area_cb.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        area_cb.FormattingEnabled = True
        area_cb.IntegralHeight = False
        area_cb.ItemHeight = 43
        area_cb.Items.AddRange(New Object() {"Basud", "Daet", "Mercedes", "Vinzons", "Talisay", "Labo", "Paracale", "Capalonga", "Jose Panganiban", "San Lorenzo Ruiz", "San Vicente", "Sta Elena"})
        area_cb.Location = New Point(331, 211)
        area_cb.MaxDropDownItems = 4
        area_cb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        area_cb.Name = "area_cb"
        area_cb.Size = New Size(322, 49)
        area_cb.StartIndex = 0
        area_cb.TabIndex = 66
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
        status_cb.Items.AddRange(New Object() {"Active", "Suspended", "Expired"})
        status_cb.Location = New Point(331, 35)
        status_cb.MaxDropDownItems = 4
        status_cb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        status_cb.Name = "status_cb"
        status_cb.Size = New Size(322, 49)
        status_cb.StartIndex = 0
        status_cb.TabIndex = 65
        ' 
        ' franchisee_cb
        ' 
        franchisee_cb.AutoResize = False
        franchisee_cb.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        franchisee_cb.Depth = 0
        franchisee_cb.Dock = DockStyle.Fill
        franchisee_cb.DrawMode = DrawMode.OwnerDrawVariable
        franchisee_cb.DropDownHeight = 174
        franchisee_cb.DropDownStyle = ComboBoxStyle.DropDownList
        franchisee_cb.DropDownWidth = 121
        franchisee_cb.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        franchisee_cb.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        franchisee_cb.FormattingEnabled = True
        franchisee_cb.IntegralHeight = False
        franchisee_cb.ItemHeight = 43
        franchisee_cb.Location = New Point(3, 211)
        franchisee_cb.MaxDropDownItems = 4
        franchisee_cb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        franchisee_cb.Name = "franchisee_cb"
        franchisee_cb.Size = New Size(322, 49)
        franchisee_cb.StartIndex = 0
        franchisee_cb.TabIndex = 64
        ' 
        ' ft_cb
        ' 
        ft_cb.AutoResize = False
        ft_cb.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ft_cb.Depth = 0
        ft_cb.Dock = DockStyle.Fill
        ft_cb.DrawMode = DrawMode.OwnerDrawVariable
        ft_cb.DropDownHeight = 174
        ft_cb.DropDownStyle = ComboBoxStyle.DropDownList
        ft_cb.DropDownWidth = 121
        ft_cb.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        ft_cb.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        ft_cb.FormattingEnabled = True
        ft_cb.IntegralHeight = False
        ft_cb.ItemHeight = 43
        ft_cb.Items.AddRange(New Object() {"New", "Renewal"})
        ft_cb.Location = New Point(3, 123)
        ft_cb.MaxDropDownItems = 4
        ft_cb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        ft_cb.Name = "ft_cb"
        ft_cb.Size = New Size(322, 49)
        ft_cb.StartIndex = 0
        ft_cb.TabIndex = 63
        ' 
        ' di_dt
        ' 
        di_dt.Dock = DockStyle.Fill
        di_dt.Location = New Point(659, 35)
        di_dt.Name = "di_dt"
        di_dt.Size = New Size(317, 31)
        di_dt.TabIndex = 55
        ' 
        ' BigLabel25
        ' 
        BigLabel25.AutoSize = True
        BigLabel25.BackColor = Color.Transparent
        BigLabel25.Dock = DockStyle.Fill
        BigLabel25.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel25.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel25.Location = New Point(3, 351)
        BigLabel25.Name = "BigLabel25"
        BigLabel25.Size = New Size(322, 32)
        BigLabel25.TabIndex = 25
        BigLabel25.Text = "Vehicle"
        ' 
        ' franchiseForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "franchiseForm"
        Size = New Size(979, 985)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lrd_dt As DateTimePicker
    Friend WithEvents franchisee_save As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents BigLabel1 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel2 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel3 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel7 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel8 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel9 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel13 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel14 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel15 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel20 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel21 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel26 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel27 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents franchise_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents assoc_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents fd_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents ln_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents ap_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents ed_dt As DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents di_dt As DateTimePicker
    Friend WithEvents area_cb As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents status_cb As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents franchisee_cb As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents ft_cb As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents vehicle_cb As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents BigLabel25 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents route_cb As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents BigLabel4 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents tv_txtbox As ReaLTaiizor.Controls.BigTextBox

End Class
