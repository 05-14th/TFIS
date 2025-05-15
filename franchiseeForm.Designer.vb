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
        MaterialComboBox1 = New ReaLTaiizor.Controls.MaterialComboBox()
        BigTextBox1 = New ReaLTaiizor.Controls.BigTextBox()
        BigLabel1 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel2 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel3 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel7 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel8 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel9 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel13 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel15 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel19 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel21 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel25 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel27 = New ReaLTaiizor.Controls.BigLabel()
        BigLabel31 = New ReaLTaiizor.Controls.BigLabel()
        BigTextBox3 = New ReaLTaiizor.Controls.BigTextBox()
        BigTextBox4 = New ReaLTaiizor.Controls.BigTextBox()
        BigTextBox6 = New ReaLTaiizor.Controls.BigTextBox()
        BigTextBox7 = New ReaLTaiizor.Controls.BigTextBox()
        BigTextBox9 = New ReaLTaiizor.Controls.BigTextBox()
        BigTextBox10 = New ReaLTaiizor.Controls.BigTextBox()
        BigTextBox12 = New ReaLTaiizor.Controls.BigTextBox()
        BigTextBox13 = New ReaLTaiizor.Controls.BigTextBox()
        BigTextBox15 = New ReaLTaiizor.Controls.BigTextBox()
        BigTextBox16 = New ReaLTaiizor.Controls.BigTextBox()
        BigLabel32 = New ReaLTaiizor.Controls.BigLabel()
        BigTextBox17 = New ReaLTaiizor.Controls.BigTextBox()
        BigLabel4 = New ReaLTaiizor.Controls.BigLabel()
        BigTextBox2 = New ReaLTaiizor.Controls.BigTextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        BigTextBox5 = New ReaLTaiizor.Controls.BigTextBox()
        MaterialComboBox3 = New ReaLTaiizor.Controls.MaterialComboBox()
        MaterialComboBox2 = New ReaLTaiizor.Controls.MaterialComboBox()
        BigTextBox14 = New ReaLTaiizor.Controls.BigTextBox()
        ForeverButton1 = New ReaLTaiizor.Controls.ForeverButton()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialComboBox1
        ' 
        MaterialComboBox1.AutoResize = False
        MaterialComboBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialComboBox1.Depth = 0
        MaterialComboBox1.Dock = DockStyle.Fill
        MaterialComboBox1.DrawMode = DrawMode.OwnerDrawVariable
        MaterialComboBox1.DropDownHeight = 174
        MaterialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        MaterialComboBox1.DropDownWidth = 121
        MaterialComboBox1.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialComboBox1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialComboBox1.FormattingEnabled = True
        MaterialComboBox1.IntegralHeight = False
        MaterialComboBox1.ItemHeight = 43
        MaterialComboBox1.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Partner"})
        MaterialComboBox1.Location = New Point(330, 35)
        MaterialComboBox1.MaxDropDownItems = 4
        MaterialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        MaterialComboBox1.Name = "MaterialComboBox1"
        MaterialComboBox1.Size = New Size(321, 49)
        MaterialComboBox1.StartIndex = 0
        MaterialComboBox1.TabIndex = 54
        ' 
        ' BigTextBox1
        ' 
        BigTextBox1.BackColor = Color.Transparent
        BigTextBox1.Dock = DockStyle.Fill
        BigTextBox1.Font = New Font("Tahoma", 11F)
        BigTextBox1.ForeColor = Color.DimGray
        BigTextBox1.Image = Nothing
        BigTextBox1.Location = New Point(3, 35)
        BigTextBox1.MaxLength = 32767
        BigTextBox1.Multiline = False
        BigTextBox1.Name = "BigTextBox1"
        BigTextBox1.ReadOnly = False
        BigTextBox1.Size = New Size(321, 50)
        BigTextBox1.TabIndex = 36
        BigTextBox1.TextAlignment = HorizontalAlignment.Left
        BigTextBox1.UseSystemPasswordChar = False
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
        BigLabel1.Text = "Franchise ID"
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
        ' BigLabel3
        ' 
        BigLabel3.AutoSize = True
        BigLabel3.BackColor = Color.Transparent
        BigLabel3.Dock = DockStyle.Fill
        BigLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BigLabel3.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel3.Location = New Point(657, 0)
        BigLabel3.Name = "BigLabel3"
        BigLabel3.Size = New Size(307, 32)
        BigLabel3.TabIndex = 2
        BigLabel3.Text = "Insurance Policy Number"
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
        BigLabel27.Text = "Application Date"
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
        ' BigTextBox4
        ' 
        BigTextBox4.BackColor = Color.Transparent
        BigTextBox4.Dock = DockStyle.Fill
        BigTextBox4.Font = New Font("Tahoma", 11F)
        BigTextBox4.ForeColor = Color.DimGray
        BigTextBox4.Image = Nothing
        BigTextBox4.Location = New Point(3, 123)
        BigTextBox4.MaxLength = 32767
        BigTextBox4.Multiline = False
        BigTextBox4.Name = "BigTextBox4"
        BigTextBox4.ReadOnly = False
        BigTextBox4.Size = New Size(321, 50)
        BigTextBox4.TabIndex = 39
        BigTextBox4.TextAlignment = HorizontalAlignment.Left
        BigTextBox4.UseSystemPasswordChar = False
        ' 
        ' BigTextBox6
        ' 
        BigTextBox6.BackColor = Color.Transparent
        BigTextBox6.Dock = DockStyle.Fill
        BigTextBox6.Font = New Font("Tahoma", 11F)
        BigTextBox6.ForeColor = Color.DimGray
        BigTextBox6.Image = Nothing
        BigTextBox6.Location = New Point(657, 123)
        BigTextBox6.MaxLength = 32767
        BigTextBox6.Multiline = False
        BigTextBox6.Name = "BigTextBox6"
        BigTextBox6.ReadOnly = False
        BigTextBox6.Size = New Size(307, 50)
        BigTextBox6.TabIndex = 41
        BigTextBox6.TextAlignment = HorizontalAlignment.Left
        BigTextBox6.UseSystemPasswordChar = False
        ' 
        ' BigTextBox7
        ' 
        BigTextBox7.BackColor = Color.Transparent
        BigTextBox7.Dock = DockStyle.Fill
        BigTextBox7.Font = New Font("Tahoma", 11F)
        BigTextBox7.ForeColor = Color.DimGray
        BigTextBox7.Image = Nothing
        BigTextBox7.Location = New Point(3, 234)
        BigTextBox7.MaxLength = 32767
        BigTextBox7.Multiline = False
        BigTextBox7.Name = "BigTextBox7"
        BigTextBox7.ReadOnly = False
        BigTextBox7.Size = New Size(321, 50)
        BigTextBox7.TabIndex = 42
        BigTextBox7.TextAlignment = HorizontalAlignment.Left
        BigTextBox7.UseSystemPasswordChar = False
        ' 
        ' BigTextBox9
        ' 
        BigTextBox9.BackColor = Color.Transparent
        BigTextBox9.Dock = DockStyle.Fill
        BigTextBox9.Font = New Font("Tahoma", 11F)
        BigTextBox9.ForeColor = Color.DimGray
        BigTextBox9.Image = Nothing
        BigTextBox9.Location = New Point(657, 234)
        BigTextBox9.MaxLength = 32767
        BigTextBox9.Multiline = False
        BigTextBox9.Name = "BigTextBox9"
        BigTextBox9.ReadOnly = False
        BigTextBox9.Size = New Size(307, 50)
        BigTextBox9.TabIndex = 44
        BigTextBox9.TextAlignment = HorizontalAlignment.Left
        BigTextBox9.UseSystemPasswordChar = False
        ' 
        ' BigTextBox10
        ' 
        BigTextBox10.BackColor = Color.Transparent
        BigTextBox10.Dock = DockStyle.Fill
        BigTextBox10.Font = New Font("Tahoma", 11F)
        BigTextBox10.ForeColor = Color.DimGray
        BigTextBox10.Image = Nothing
        BigTextBox10.Location = New Point(3, 346)
        BigTextBox10.MaxLength = 32767
        BigTextBox10.Multiline = False
        BigTextBox10.Name = "BigTextBox10"
        BigTextBox10.ReadOnly = False
        BigTextBox10.Size = New Size(321, 50)
        BigTextBox10.TabIndex = 45
        BigTextBox10.TextAlignment = HorizontalAlignment.Left
        BigTextBox10.UseSystemPasswordChar = False
        ' 
        ' BigTextBox12
        ' 
        BigTextBox12.BackColor = Color.Transparent
        BigTextBox12.Dock = DockStyle.Fill
        BigTextBox12.Font = New Font("Tahoma", 11F)
        BigTextBox12.ForeColor = Color.DimGray
        BigTextBox12.Image = Nothing
        BigTextBox12.Location = New Point(657, 346)
        BigTextBox12.MaxLength = 32767
        BigTextBox12.Multiline = False
        BigTextBox12.Name = "BigTextBox12"
        BigTextBox12.ReadOnly = False
        BigTextBox12.Size = New Size(307, 50)
        BigTextBox12.TabIndex = 47
        BigTextBox12.TextAlignment = HorizontalAlignment.Left
        BigTextBox12.UseSystemPasswordChar = False
        ' 
        ' BigTextBox13
        ' 
        BigTextBox13.BackColor = Color.Transparent
        BigTextBox13.Dock = DockStyle.Fill
        BigTextBox13.Font = New Font("Tahoma", 11F)
        BigTextBox13.ForeColor = Color.DimGray
        BigTextBox13.Image = Nothing
        BigTextBox13.Location = New Point(3, 458)
        BigTextBox13.MaxLength = 32767
        BigTextBox13.Multiline = False
        BigTextBox13.Name = "BigTextBox13"
        BigTextBox13.ReadOnly = False
        BigTextBox13.Size = New Size(321, 50)
        BigTextBox13.TabIndex = 48
        BigTextBox13.TextAlignment = HorizontalAlignment.Left
        BigTextBox13.UseSystemPasswordChar = False
        ' 
        ' BigTextBox15
        ' 
        BigTextBox15.BackColor = Color.Transparent
        BigTextBox15.Dock = DockStyle.Fill
        BigTextBox15.Font = New Font("Tahoma", 11F)
        BigTextBox15.ForeColor = Color.DimGray
        BigTextBox15.Image = Nothing
        BigTextBox15.Location = New Point(657, 458)
        BigTextBox15.MaxLength = 32767
        BigTextBox15.Multiline = False
        BigTextBox15.Name = "BigTextBox15"
        BigTextBox15.ReadOnly = False
        BigTextBox15.Size = New Size(307, 50)
        BigTextBox15.TabIndex = 50
        BigTextBox15.TextAlignment = HorizontalAlignment.Left
        BigTextBox15.UseSystemPasswordChar = False
        ' 
        ' BigTextBox16
        ' 
        BigTextBox16.BackColor = Color.Transparent
        BigTextBox16.Dock = DockStyle.Fill
        BigTextBox16.Font = New Font("Tahoma", 11F)
        BigTextBox16.ForeColor = Color.DimGray
        BigTextBox16.Image = Nothing
        BigTextBox16.Location = New Point(3, 570)
        BigTextBox16.MaxLength = 32767
        BigTextBox16.Multiline = False
        BigTextBox16.Name = "BigTextBox16"
        BigTextBox16.ReadOnly = False
        BigTextBox16.Size = New Size(321, 50)
        BigTextBox16.TabIndex = 51
        BigTextBox16.TextAlignment = HorizontalAlignment.Left
        BigTextBox16.UseSystemPasswordChar = False
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
        ' BigTextBox17
        ' 
        BigTextBox17.BackColor = Color.Transparent
        BigTextBox17.Dock = DockStyle.Fill
        BigTextBox17.Font = New Font("Tahoma", 11F)
        BigTextBox17.ForeColor = Color.DimGray
        BigTextBox17.Image = Nothing
        BigTextBox17.Location = New Point(330, 402)
        BigTextBox17.MaxLength = 32767
        BigTextBox17.Multiline = False
        BigTextBox17.Name = "BigTextBox17"
        BigTextBox17.ReadOnly = False
        BigTextBox17.Size = New Size(321, 50)
        BigTextBox17.TabIndex = 59
        BigTextBox17.TextAlignment = HorizontalAlignment.Left
        BigTextBox17.UseSystemPasswordChar = False
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
        ' BigTextBox2
        ' 
        BigTextBox2.BackColor = Color.Transparent
        BigTextBox2.Dock = DockStyle.Fill
        BigTextBox2.Font = New Font("Tahoma", 11F)
        BigTextBox2.ForeColor = Color.DimGray
        BigTextBox2.Image = Nothing
        BigTextBox2.Location = New Point(330, 514)
        BigTextBox2.MaxLength = 32767
        BigTextBox2.Multiline = False
        BigTextBox2.Name = "BigTextBox2"
        BigTextBox2.ReadOnly = False
        BigTextBox2.Size = New Size(321, 50)
        BigTextBox2.TabIndex = 61
        BigTextBox2.TextAlignment = HorizontalAlignment.Left
        BigTextBox2.UseSystemPasswordChar = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 313F))
        TableLayoutPanel1.Controls.Add(BigTextBox5, 1, 3)
        TableLayoutPanel1.Controls.Add(MaterialComboBox3, 1, 5)
        TableLayoutPanel1.Controls.Add(MaterialComboBox2, 1, 4)
        TableLayoutPanel1.Controls.Add(BigTextBox2, 1, 10)
        TableLayoutPanel1.Controls.Add(BigLabel4, 1, 9)
        TableLayoutPanel1.Controls.Add(BigTextBox17, 1, 8)
        TableLayoutPanel1.Controls.Add(BigLabel32, 1, 7)
        TableLayoutPanel1.Controls.Add(BigTextBox14, 1, 6)
        TableLayoutPanel1.Controls.Add(BigTextBox16, 0, 11)
        TableLayoutPanel1.Controls.Add(BigTextBox15, 2, 9)
        TableLayoutPanel1.Controls.Add(BigTextBox13, 0, 9)
        TableLayoutPanel1.Controls.Add(BigTextBox12, 2, 7)
        TableLayoutPanel1.Controls.Add(BigTextBox10, 0, 7)
        TableLayoutPanel1.Controls.Add(BigTextBox9, 2, 5)
        TableLayoutPanel1.Controls.Add(BigTextBox7, 0, 5)
        TableLayoutPanel1.Controls.Add(BigTextBox6, 2, 3)
        TableLayoutPanel1.Controls.Add(BigTextBox4, 0, 3)
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
        TableLayoutPanel1.Controls.Add(BigLabel3, 2, 0)
        TableLayoutPanel1.Controls.Add(BigLabel2, 1, 0)
        TableLayoutPanel1.Controls.Add(BigLabel1, 0, 0)
        TableLayoutPanel1.Controls.Add(BigTextBox1, 0, 1)
        TableLayoutPanel1.Controls.Add(MaterialComboBox1, 1, 1)
        TableLayoutPanel1.Controls.Add(ForeverButton1, 2, 11)
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
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(967, 789)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' BigTextBox5
        ' 
        BigTextBox5.BackColor = Color.Transparent
        BigTextBox5.Dock = DockStyle.Fill
        BigTextBox5.Font = New Font("Tahoma", 11F)
        BigTextBox5.ForeColor = Color.DimGray
        BigTextBox5.Image = Nothing
        BigTextBox5.Location = New Point(330, 123)
        BigTextBox5.MaxLength = 32767
        BigTextBox5.Multiline = False
        BigTextBox5.Name = "BigTextBox5"
        BigTextBox5.ReadOnly = False
        BigTextBox5.Size = New Size(321, 50)
        BigTextBox5.TabIndex = 64
        BigTextBox5.TextAlignment = HorizontalAlignment.Left
        BigTextBox5.UseSystemPasswordChar = False
        ' 
        ' MaterialComboBox3
        ' 
        MaterialComboBox3.AutoResize = False
        MaterialComboBox3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialComboBox3.Depth = 0
        MaterialComboBox3.Dock = DockStyle.Fill
        MaterialComboBox3.DrawMode = DrawMode.OwnerDrawVariable
        MaterialComboBox3.DropDownHeight = 174
        MaterialComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        MaterialComboBox3.DropDownWidth = 121
        MaterialComboBox3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialComboBox3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialComboBox3.FormattingEnabled = True
        MaterialComboBox3.IntegralHeight = False
        MaterialComboBox3.ItemHeight = 43
        MaterialComboBox3.Items.AddRange(New Object() {"Camarines Norte"})
        MaterialComboBox3.Location = New Point(330, 234)
        MaterialComboBox3.MaxDropDownItems = 4
        MaterialComboBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        MaterialComboBox3.Name = "MaterialComboBox3"
        MaterialComboBox3.Size = New Size(321, 49)
        MaterialComboBox3.StartIndex = 0
        MaterialComboBox3.TabIndex = 63
        ' 
        ' MaterialComboBox2
        ' 
        MaterialComboBox2.AutoResize = False
        MaterialComboBox2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialComboBox2.Depth = 0
        MaterialComboBox2.Dock = DockStyle.Fill
        MaterialComboBox2.DrawMode = DrawMode.OwnerDrawVariable
        MaterialComboBox2.DropDownHeight = 174
        MaterialComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        MaterialComboBox2.DropDownWidth = 121
        MaterialComboBox2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialComboBox2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialComboBox2.FormattingEnabled = True
        MaterialComboBox2.IntegralHeight = False
        MaterialComboBox2.ItemHeight = 43
        MaterialComboBox2.Items.AddRange(New Object() {"Basud", "Daet", "Mercedes", "Vinzons", "Talisay", "Labo", "Paracale", "Capalonga", "Jose Panganiban", "San Lorenzo Ruiz", "San Vicente", "Sta Elena"})
        MaterialComboBox2.Location = New Point(330, 179)
        MaterialComboBox2.MaxDropDownItems = 4
        MaterialComboBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        MaterialComboBox2.Name = "MaterialComboBox2"
        MaterialComboBox2.Size = New Size(321, 49)
        MaterialComboBox2.StartIndex = 0
        MaterialComboBox2.TabIndex = 62
        ' 
        ' BigTextBox14
        ' 
        BigTextBox14.BackColor = Color.Transparent
        BigTextBox14.Dock = DockStyle.Fill
        BigTextBox14.Font = New Font("Tahoma", 11F)
        BigTextBox14.ForeColor = Color.DimGray
        BigTextBox14.Image = Nothing
        BigTextBox14.Location = New Point(330, 290)
        BigTextBox14.MaxLength = 32767
        BigTextBox14.Multiline = False
        BigTextBox14.Name = "BigTextBox14"
        BigTextBox14.ReadOnly = False
        BigTextBox14.Size = New Size(321, 50)
        BigTextBox14.TabIndex = 57
        BigTextBox14.TextAlignment = HorizontalAlignment.Left
        BigTextBox14.UseSystemPasswordChar = False
        ' 
        ' ForeverButton1
        ' 
        ForeverButton1.BackColor = Color.Transparent
        ForeverButton1.BaseColor = Color.DarkTurquoise
        ForeverButton1.Dock = DockStyle.Fill
        ForeverButton1.Font = New Font("Segoe UI", 12F)
        ForeverButton1.Location = New Point(657, 570)
        ForeverButton1.Name = "ForeverButton1"
        ForeverButton1.Rounded = False
        ForeverButton1.Size = New Size(307, 60)
        ForeverButton1.TabIndex = 65
        ForeverButton1.Text = "SAVE"
        ForeverButton1.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
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

    Friend WithEvents MaterialComboBox1 As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents BigTextBox1 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigLabel1 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel2 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel3 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel7 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel8 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel9 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel13 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel15 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel19 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel21 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel25 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel27 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel31 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigTextBox3 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigTextBox4 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigTextBox6 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigTextBox7 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigTextBox9 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigTextBox10 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigTextBox12 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigTextBox13 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigTextBox15 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigTextBox16 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigLabel32 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigTextBox17 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents BigLabel4 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigTextBox2 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BigTextBox5 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents MaterialComboBox3 As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents MaterialComboBox2 As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents BigTextBox14 As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents ForeverButton1 As ReaLTaiizor.Controls.ForeverButton

End Class
