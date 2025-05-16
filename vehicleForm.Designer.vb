<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vehicleForm
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
        TableLayoutPanel1 = New TableLayoutPanel()
        cb_owner = New ReaLTaiizor.Controls.MaterialComboBox()
        red_dt = New DateTimePicker()
        or_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        en_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        tt_cb = New ReaLTaiizor.Controls.MaterialComboBox()
        pn_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        model_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        ft_type = New ReaLTaiizor.Controls.MaterialComboBox()
        nw_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        cn_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        ym_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        mileage_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        color_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        vid_txtbox = New ReaLTaiizor.Controls.BigTextBox()
        BigLabel27 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel26 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel25 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel21 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel20 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel19 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel15 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel14 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel13 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel9 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel8 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel7 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel3 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel2 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel1 = New ReaLTaiizor.Controls.BigLabel()
        ForeverButton1 = New ReaLTaiizor.Controls.ForeverButton()
        pd_dt = New DateTimePicker()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 323.0F))
        TableLayoutPanel1.Controls.Add(cb_owner, 1, 3)
        TableLayoutPanel1.Controls.Add(red_dt, 1, 1)
        TableLayoutPanel1.Controls.Add(or_txtbox, 2, 3)
        TableLayoutPanel1.Controls.Add(en_txtbox, 2, 1)
        TableLayoutPanel1.Controls.Add(tt_cb, 1, 7)
        TableLayoutPanel1.Controls.Add(pn_txtbox, 0, 3)
        TableLayoutPanel1.Controls.Add(model_txtbox, 0, 5)
        TableLayoutPanel1.Controls.Add(ft_type, 1, 5)
        TableLayoutPanel1.Controls.Add(nw_txtbox, 2, 9)
        TableLayoutPanel1.Controls.Add(cn_txtbox, 1, 9)
        TableLayoutPanel1.Controls.Add(ym_txtbox, 0, 9)
        TableLayoutPanel1.Controls.Add(mileage_txtbox, 2, 7)
        TableLayoutPanel1.Controls.Add(color_txtbox, 0, 7)
        TableLayoutPanel1.Controls.Add(vid_txtbox, 0, 1)
        TableLayoutPanel1.Controls.Add(BigLabel27, 2, 8)
        TableLayoutPanel1.Controls.Add(BigLabel26, 1, 8)
        TableLayoutPanel1.Controls.Add(BigLabel25, 0, 8)
        TableLayoutPanel1.Controls.Add(BigLabel21, 2, 6)
        TableLayoutPanel1.Controls.Add(BigLabel20, 1, 6)
        TableLayoutPanel1.Controls.Add(BigLabel19, 0, 6)
        TableLayoutPanel1.Controls.Add(BigLabel15, 2, 4)
        TableLayoutPanel1.Controls.Add(BigLabel14, 1, 4)
        TableLayoutPanel1.Controls.Add(BigLabel13, 0, 4)
        TableLayoutPanel1.Controls.Add(BigLabel9, 2, 2)
        TableLayoutPanel1.Controls.Add(BigLabel8, 1, 2)
        TableLayoutPanel1.Controls.Add(BigLabel7, 0, 2)
        TableLayoutPanel1.Controls.Add(BigLabel3, 2, 0)
        TableLayoutPanel1.Controls.Add(BigLabel2, 1, 0)
        TableLayoutPanel1.Controls.Add(BigLabel1, 0, 0)
        TableLayoutPanel1.Controls.Add(ForeverButton1, 2, 11)
        TableLayoutPanel1.Controls.Add(pd_dt, 2, 5)
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
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(980, 1077)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' cb_owner
        ' 
        cb_owner.AutoResize = False
        cb_owner.BackColor = Color.FromArgb(255, 255, 255)
        cb_owner.Depth = 0
        cb_owner.Dock = DockStyle.Fill
        cb_owner.DrawMode = DrawMode.OwnerDrawVariable
        cb_owner.DropDownHeight = 174
        cb_owner.DropDownStyle = ComboBoxStyle.DropDownList
        cb_owner.DropDownWidth = 121
        cb_owner.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        cb_owner.ForeColor = Color.FromArgb(222, 0, 0, 0)
        cb_owner.FormattingEnabled = True
        cb_owner.IntegralHeight = False
        cb_owner.ItemHeight = 43
        cb_owner.Location = New Point(331, 123)
        cb_owner.MaxDropDownItems = 4
        cb_owner.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        cb_owner.Name = "cb_owner"
        cb_owner.Size = New Size(322, 49)
        cb_owner.StartIndex = 0
        cb_owner.TabIndex = 74
        ' 
        ' red_dt
        ' 
        red_dt.Dock = DockStyle.Fill
        red_dt.Location = New Point(331, 35)
        red_dt.Name = "red_dt"
        red_dt.Size = New Size(322, 31)
        red_dt.TabIndex = 73
        ' 
        ' or_txtbox
        ' 
        or_txtbox.BackColor = Color.Transparent
        or_txtbox.Dock = DockStyle.Fill
        or_txtbox.Font = New Font("Tahoma", 11.0F)
        or_txtbox.ForeColor = Color.DimGray
        or_txtbox.Image = Nothing
        or_txtbox.Location = New Point(659, 123)
        or_txtbox.MaxLength = 32767
        or_txtbox.Multiline = False
        or_txtbox.Name = "or_txtbox"
        or_txtbox.ReadOnly = False
        or_txtbox.Size = New Size(318, 50)
        or_txtbox.TabIndex = 71
        or_txtbox.TextAlignment = HorizontalAlignment.Left
        or_txtbox.UseSystemPasswordChar = False
        ' 
        ' en_txtbox
        ' 
        en_txtbox.BackColor = Color.Transparent
        en_txtbox.Dock = DockStyle.Fill
        en_txtbox.Font = New Font("Tahoma", 11.0F)
        en_txtbox.ForeColor = Color.DimGray
        en_txtbox.Image = Nothing
        en_txtbox.Location = New Point(659, 35)
        en_txtbox.MaxLength = 32767
        en_txtbox.Multiline = False
        en_txtbox.Name = "en_txtbox"
        en_txtbox.ReadOnly = False
        en_txtbox.Size = New Size(318, 50)
        en_txtbox.TabIndex = 70
        en_txtbox.TextAlignment = HorizontalAlignment.Left
        en_txtbox.UseSystemPasswordChar = False
        ' 
        ' tt_cb
        ' 
        tt_cb.AutoResize = False
        tt_cb.BackColor = Color.FromArgb(255, 255, 255)
        tt_cb.Depth = 0
        tt_cb.Dock = DockStyle.Fill
        tt_cb.DrawMode = DrawMode.OwnerDrawVariable
        tt_cb.DropDownHeight = 174
        tt_cb.DropDownStyle = ComboBoxStyle.DropDownList
        tt_cb.DropDownWidth = 121
        tt_cb.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        tt_cb.ForeColor = Color.FromArgb(222, 0, 0, 0)
        tt_cb.FormattingEnabled = True
        tt_cb.IntegralHeight = False
        tt_cb.ItemHeight = 43
        tt_cb.Items.AddRange(New Object() {"Automatic", "Semi Automatic", "Manual"})
        tt_cb.Location = New Point(331, 299)
        tt_cb.MaxDropDownItems = 4
        tt_cb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        tt_cb.Name = "tt_cb"
        tt_cb.Size = New Size(322, 49)
        tt_cb.StartIndex = 0
        tt_cb.TabIndex = 69
        ' 
        ' pn_txtbox
        ' 
        pn_txtbox.BackColor = Color.Transparent
        pn_txtbox.Dock = DockStyle.Fill
        pn_txtbox.Font = New Font("Tahoma", 11.0F)
        pn_txtbox.ForeColor = Color.DimGray
        pn_txtbox.Image = Nothing
        pn_txtbox.Location = New Point(3, 123)
        pn_txtbox.MaxLength = 32767
        pn_txtbox.Multiline = False
        pn_txtbox.Name = "pn_txtbox"
        pn_txtbox.ReadOnly = False
        pn_txtbox.Size = New Size(322, 50)
        pn_txtbox.TabIndex = 68
        pn_txtbox.TextAlignment = HorizontalAlignment.Left
        pn_txtbox.UseSystemPasswordChar = False
        ' 
        ' model_txtbox
        ' 
        model_txtbox.BackColor = Color.Transparent
        model_txtbox.Dock = DockStyle.Fill
        model_txtbox.Font = New Font("Tahoma", 11.0F)
        model_txtbox.ForeColor = Color.DimGray
        model_txtbox.Image = Nothing
        model_txtbox.Location = New Point(3, 211)
        model_txtbox.MaxLength = 32767
        model_txtbox.Multiline = False
        model_txtbox.Name = "model_txtbox"
        model_txtbox.ReadOnly = False
        model_txtbox.Size = New Size(322, 50)
        model_txtbox.TabIndex = 67
        model_txtbox.TextAlignment = HorizontalAlignment.Left
        model_txtbox.UseSystemPasswordChar = False
        ' 
        ' ft_type
        ' 
        ft_type.AutoResize = False
        ft_type.BackColor = Color.FromArgb(255, 255, 255)
        ft_type.Depth = 0
        ft_type.Dock = DockStyle.Fill
        ft_type.DrawMode = DrawMode.OwnerDrawVariable
        ft_type.DropDownHeight = 174
        ft_type.DropDownStyle = ComboBoxStyle.DropDownList
        ft_type.DropDownWidth = 121
        ft_type.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        ft_type.ForeColor = Color.FromArgb(222, 0, 0, 0)
        ft_type.FormattingEnabled = True
        ft_type.IntegralHeight = False
        ft_type.ItemHeight = 43
        ft_type.Items.AddRange(New Object() {"Gasoline", "Diesel", "Kerosene"})
        ft_type.Location = New Point(331, 211)
        ft_type.MaxDropDownItems = 4
        ft_type.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        ft_type.Name = "ft_type"
        ft_type.Size = New Size(322, 49)
        ft_type.StartIndex = 0
        ft_type.TabIndex = 66
        ' 
        ' nw_txtbox
        ' 
        nw_txtbox.BackColor = Color.Transparent
        nw_txtbox.Dock = DockStyle.Fill
        nw_txtbox.Font = New Font("Tahoma", 11.0F)
        nw_txtbox.ForeColor = Color.DimGray
        nw_txtbox.Image = Nothing
        nw_txtbox.Location = New Point(659, 387)
        nw_txtbox.MaxLength = 32767
        nw_txtbox.Multiline = False
        nw_txtbox.Name = "nw_txtbox"
        nw_txtbox.ReadOnly = False
        nw_txtbox.Size = New Size(318, 50)
        nw_txtbox.TabIndex = 51
        nw_txtbox.TextAlignment = HorizontalAlignment.Left
        nw_txtbox.UseSystemPasswordChar = False
        ' 
        ' cn_txtbox
        ' 
        cn_txtbox.BackColor = Color.Transparent
        cn_txtbox.Dock = DockStyle.Fill
        cn_txtbox.Font = New Font("Tahoma", 11.0F)
        cn_txtbox.ForeColor = Color.DimGray
        cn_txtbox.Image = Nothing
        cn_txtbox.Location = New Point(331, 387)
        cn_txtbox.MaxLength = 32767
        cn_txtbox.Multiline = False
        cn_txtbox.Name = "cn_txtbox"
        cn_txtbox.ReadOnly = False
        cn_txtbox.Size = New Size(322, 50)
        cn_txtbox.TabIndex = 50
        cn_txtbox.TextAlignment = HorizontalAlignment.Left
        cn_txtbox.UseSystemPasswordChar = False
        ' 
        ' ym_txtbox
        ' 
        ym_txtbox.BackColor = Color.Transparent
        ym_txtbox.Dock = DockStyle.Fill
        ym_txtbox.Font = New Font("Tahoma", 11.0F)
        ym_txtbox.ForeColor = Color.DimGray
        ym_txtbox.Image = Nothing
        ym_txtbox.Location = New Point(3, 387)
        ym_txtbox.MaxLength = 32767
        ym_txtbox.Multiline = False
        ym_txtbox.Name = "ym_txtbox"
        ym_txtbox.ReadOnly = False
        ym_txtbox.Size = New Size(322, 50)
        ym_txtbox.TabIndex = 49
        ym_txtbox.TextAlignment = HorizontalAlignment.Left
        ym_txtbox.UseSystemPasswordChar = False
        ' 
        ' mileage_txtbox
        ' 
        mileage_txtbox.BackColor = Color.Transparent
        mileage_txtbox.Dock = DockStyle.Fill
        mileage_txtbox.Font = New Font("Tahoma", 11.0F)
        mileage_txtbox.ForeColor = Color.DimGray
        mileage_txtbox.Image = Nothing
        mileage_txtbox.Location = New Point(659, 299)
        mileage_txtbox.MaxLength = 32767
        mileage_txtbox.Multiline = False
        mileage_txtbox.Name = "mileage_txtbox"
        mileage_txtbox.ReadOnly = False
        mileage_txtbox.Size = New Size(318, 50)
        mileage_txtbox.TabIndex = 48
        mileage_txtbox.TextAlignment = HorizontalAlignment.Left
        mileage_txtbox.UseSystemPasswordChar = False
        ' 
        ' color_txtbox
        ' 
        color_txtbox.BackColor = Color.Transparent
        color_txtbox.Dock = DockStyle.Fill
        color_txtbox.Font = New Font("Tahoma", 11.0F)
        color_txtbox.ForeColor = Color.DimGray
        color_txtbox.Image = Nothing
        color_txtbox.Location = New Point(3, 299)
        color_txtbox.MaxLength = 32767
        color_txtbox.Multiline = False
        color_txtbox.Name = "color_txtbox"
        color_txtbox.ReadOnly = False
        color_txtbox.Size = New Size(322, 50)
        color_txtbox.TabIndex = 46
        color_txtbox.TextAlignment = HorizontalAlignment.Left
        color_txtbox.UseSystemPasswordChar = False
        ' 
        ' vid_txtbox
        ' 
        vid_txtbox.BackColor = Color.Transparent
        vid_txtbox.Dock = DockStyle.Fill
        vid_txtbox.Font = New Font("Tahoma", 11.0F)
        vid_txtbox.ForeColor = Color.DimGray
        vid_txtbox.Image = Nothing
        vid_txtbox.Location = New Point(3, 35)
        vid_txtbox.MaxLength = 32767
        vid_txtbox.Multiline = False
        vid_txtbox.Name = "vid_txtbox"
        vid_txtbox.ReadOnly = True
        vid_txtbox.Size = New Size(322, 50)
        vid_txtbox.TabIndex = 37
        vid_txtbox.TextAlignment = HorizontalAlignment.Left
        vid_txtbox.UseSystemPasswordChar = False
        ' 
        ' BigLabel27
        ' 
        BigLabel27.AutoSize = True
        BigLabel27.BackColor = Color.Transparent
        BigLabel27.Dock = DockStyle.Fill
        BigLabel27.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel27.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel27.Location = New Point(659, 352)
        BigLabel27.Name = "BigLabel27"
        BigLabel27.Size = New Size(318, 32)
        BigLabel27.TabIndex = 27
        BigLabel27.Text = "Net Weight"
        ' 
        ' BigLabel26
        ' 
        BigLabel26.AutoSize = True
        BigLabel26.BackColor = Color.Transparent
        BigLabel26.Dock = DockStyle.Fill
        BigLabel26.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel26.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel26.Location = New Point(331, 352)
        BigLabel26.Name = "BigLabel26"
        BigLabel26.Size = New Size(322, 32)
        BigLabel26.TabIndex = 26
        BigLabel26.Text = "Chassis No."
        ' 
        ' BigLabel25
        ' 
        BigLabel25.AutoSize = True
        BigLabel25.BackColor = Color.Transparent
        BigLabel25.Dock = DockStyle.Fill
        BigLabel25.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel25.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel25.Location = New Point(3, 352)
        BigLabel25.Name = "BigLabel25"
        BigLabel25.Size = New Size(322, 32)
        BigLabel25.TabIndex = 25
        BigLabel25.Text = "Year Manufactured"
        ' 
        ' BigLabel21
        ' 
        BigLabel21.AutoSize = True
        BigLabel21.BackColor = Color.Transparent
        BigLabel21.Dock = DockStyle.Fill
        BigLabel21.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel21.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel21.Location = New Point(659, 264)
        BigLabel21.Name = "BigLabel21"
        BigLabel21.Size = New Size(318, 32)
        BigLabel21.TabIndex = 21
        BigLabel21.Text = "Mileage"
        ' 
        ' BigLabel20
        ' 
        BigLabel20.AutoSize = True
        BigLabel20.BackColor = Color.Transparent
        BigLabel20.Dock = DockStyle.Fill
        BigLabel20.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel20.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel20.Location = New Point(331, 264)
        BigLabel20.Name = "BigLabel20"
        BigLabel20.Size = New Size(322, 32)
        BigLabel20.TabIndex = 20
        BigLabel20.Text = "Transmission Type"
        ' 
        ' BigLabel19
        ' 
        BigLabel19.AutoSize = True
        BigLabel19.BackColor = Color.Transparent
        BigLabel19.Dock = DockStyle.Fill
        BigLabel19.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel19.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel19.Location = New Point(3, 264)
        BigLabel19.Name = "BigLabel19"
        BigLabel19.Size = New Size(322, 32)
        BigLabel19.TabIndex = 19
        BigLabel19.Text = "Color"
        ' 
        ' BigLabel15
        ' 
        BigLabel15.AutoSize = True
        BigLabel15.BackColor = Color.Transparent
        BigLabel15.Dock = DockStyle.Fill
        BigLabel15.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel15.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel15.Location = New Point(659, 176)
        BigLabel15.Name = "BigLabel15"
        BigLabel15.Size = New Size(318, 32)
        BigLabel15.TabIndex = 15
        BigLabel15.Text = "Purchase Date"
        ' 
        ' BigLabel14
        ' 
        BigLabel14.AutoSize = True
        BigLabel14.BackColor = Color.Transparent
        BigLabel14.Dock = DockStyle.Fill
        BigLabel14.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel14.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel14.Location = New Point(331, 176)
        BigLabel14.Name = "BigLabel14"
        BigLabel14.Size = New Size(322, 32)
        BigLabel14.TabIndex = 14
        BigLabel14.Text = "Fuel Type"
        ' 
        ' BigLabel13
        ' 
        BigLabel13.AutoSize = True
        BigLabel13.BackColor = Color.Transparent
        BigLabel13.Dock = DockStyle.Fill
        BigLabel13.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel13.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel13.Location = New Point(3, 176)
        BigLabel13.Name = "BigLabel13"
        BigLabel13.Size = New Size(322, 32)
        BigLabel13.TabIndex = 13
        BigLabel13.Text = "Model"
        ' 
        ' BigLabel9
        ' 
        BigLabel9.AutoSize = True
        BigLabel9.BackColor = Color.Transparent
        BigLabel9.Dock = DockStyle.Fill
        BigLabel9.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel9.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel9.Location = New Point(659, 88)
        BigLabel9.Name = "BigLabel9"
        BigLabel9.Size = New Size(318, 32)
        BigLabel9.TabIndex = 9
        BigLabel9.Text = "Official Receipt"
        ' 
        ' BigLabel8
        ' 
        BigLabel8.AutoSize = True
        BigLabel8.BackColor = Color.Transparent
        BigLabel8.Dock = DockStyle.Fill
        BigLabel8.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel8.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel8.Location = New Point(331, 88)
        BigLabel8.Name = "BigLabel8"
        BigLabel8.Size = New Size(322, 32)
        BigLabel8.TabIndex = 8
        BigLabel8.Text = "Owner"
        ' 
        ' BigLabel7
        ' 
        BigLabel7.AutoSize = True
        BigLabel7.BackColor = Color.Transparent
        BigLabel7.Dock = DockStyle.Fill
        BigLabel7.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel7.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel7.Location = New Point(3, 88)
        BigLabel7.Name = "BigLabel7"
        BigLabel7.Size = New Size(322, 32)
        BigLabel7.TabIndex = 7
        BigLabel7.Text = "Plate No."
        ' 
        ' BigLabel3
        ' 
        BigLabel3.AutoSize = True
        BigLabel3.BackColor = Color.Transparent
        BigLabel3.Dock = DockStyle.Fill
        BigLabel3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel3.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel3.Location = New Point(659, 0)
        BigLabel3.Name = "BigLabel3"
        BigLabel3.Size = New Size(318, 32)
        BigLabel3.TabIndex = 3
        BigLabel3.Text = "Engine No."
        ' 
        ' BigLabel2
        ' 
        BigLabel2.AutoSize = True
        BigLabel2.BackColor = Color.Transparent
        BigLabel2.Dock = DockStyle.Fill
        BigLabel2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel2.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel2.Location = New Point(331, 0)
        BigLabel2.Name = "BigLabel2"
        BigLabel2.Size = New Size(322, 32)
        BigLabel2.TabIndex = 2
        BigLabel2.Text = "Registration Expiry Date"
        ' 
        ' BigLabel1
        ' 
        BigLabel1.AutoSize = True
        BigLabel1.BackColor = Color.Transparent
        BigLabel1.Dock = DockStyle.Fill
        BigLabel1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BigLabel1.ForeColor = Color.FromArgb(80, 80, 80)
        BigLabel1.Location = New Point(3, 0)
        BigLabel1.Name = "BigLabel1"
        BigLabel1.Size = New Size(322, 32)
        BigLabel1.TabIndex = 1
        BigLabel1.Text = "Vehicle ID"
        ' 
        ' ForeverButton1
        ' 
        ForeverButton1.BackColor = Color.Transparent
        ForeverButton1.BaseColor = Color.FromArgb(0, 192, 192)
        ForeverButton1.Dock = DockStyle.Top
        ForeverButton1.Font = New Font("Segoe UI", 12.0F)
        ForeverButton1.Location = New Point(659, 493)
        ForeverButton1.Name = "ForeverButton1"
        ForeverButton1.Rounded = False
        ForeverButton1.Size = New Size(318, 60)
        ForeverButton1.TabIndex = 52
        ForeverButton1.Text = "SAVE"
        ForeverButton1.TextColor = Color.FromArgb(243, 243, 243)
        ' 
        ' pd_dt
        ' 
        pd_dt.Dock = DockStyle.Fill
        pd_dt.Location = New Point(659, 211)
        pd_dt.Name = "pd_dt"
        pd_dt.Size = New Size(318, 31)
        pd_dt.TabIndex = 53
        ' 
        ' vehicleForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "vehicleForm"
        Size = New Size(980, 1077)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ft_type As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents nw_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents cn_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents ym_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents mileage_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents color_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents vid_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigLabel27 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel26 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel25 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel21 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel20 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel19 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel15 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel14 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel13 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel9 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel8 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel7 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel3 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel2 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel1 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents ForeverButton1 As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents pd_dt As DateTimePicker
    Friend WithEvents tt_cb As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents pn_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents model_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents or_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents en_txtbox As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents red_dt As DateTimePicker
    Friend WithEvents cb_owner As ReaLTaiizor.Controls.MaterialComboBox

End Class
