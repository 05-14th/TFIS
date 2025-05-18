<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        deleteBtn = New ReaLTaiizor.Controls.PoisonButton()
        updateBtn = New ReaLTaiizor.Controls.PoisonButton()
        PoisonPanel1 = New ReaLTaiizor.Controls.PoisonPanel()
        search_txtbox = New ReaLTaiizor.Controls.PoisonTextBox()
        PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        view_dgv = New ReaLTaiizor.Controls.PoisonDataGridView()
        TableLayoutPanel1.SuspendLayout()
        PoisonPanel1.SuspendLayout()
        CType(view_dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Black
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80.91873F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.0812721F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 221F))
        TableLayoutPanel1.Controls.Add(deleteBtn, 2, 0)
        TableLayoutPanel1.Controls.Add(updateBtn, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(0, 902)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1071, 63)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' deleteBtn
        ' 
        deleteBtn.Dock = DockStyle.Fill
        deleteBtn.Location = New Point(852, 3)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(216, 57)
        deleteBtn.TabIndex = 3
        deleteBtn.Text = "Delete"
        deleteBtn.UseSelectable = True
        ' 
        ' updateBtn
        ' 
        updateBtn.Dock = DockStyle.Fill
        updateBtn.Location = New Point(690, 3)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(156, 57)
        updateBtn.TabIndex = 2
        updateBtn.Text = "Update"
        updateBtn.UseSelectable = True
        ' 
        ' PoisonPanel1
        ' 
        PoisonPanel1.Controls.Add(search_txtbox)
        PoisonPanel1.Controls.Add(PoisonLabel1)
        PoisonPanel1.Dock = DockStyle.Top
        PoisonPanel1.HorizontalScrollbarBarColor = True
        PoisonPanel1.HorizontalScrollbarHighlightOnWheel = False
        PoisonPanel1.HorizontalScrollbarSize = 10
        PoisonPanel1.Location = New Point(0, 0)
        PoisonPanel1.Name = "PoisonPanel1"
        PoisonPanel1.Size = New Size(1071, 42)
        PoisonPanel1.TabIndex = 1
        PoisonPanel1.VerticalScrollbarBarColor = True
        PoisonPanel1.VerticalScrollbarHighlightOnWheel = False
        PoisonPanel1.VerticalScrollbarSize = 10
        ' 
        ' search_txtbox
        ' 
        ' 
        ' 
        ' 
        search_txtbox.CustomButton.Image = Nothing
        search_txtbox.CustomButton.Location = New Point(980, 2)
        search_txtbox.CustomButton.Name = ""
        search_txtbox.CustomButton.Size = New Size(37, 37)
        search_txtbox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        search_txtbox.CustomButton.TabIndex = 1
        search_txtbox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        search_txtbox.CustomButton.UseSelectable = True
        search_txtbox.CustomButton.Visible = False
        search_txtbox.Dock = DockStyle.Fill
        search_txtbox.Location = New Point(51, 0)
        search_txtbox.MaxLength = 32767
        search_txtbox.Name = "search_txtbox"
        search_txtbox.PasswordChar = ChrW(0)
        search_txtbox.ScrollBars = ScrollBars.None
        search_txtbox.SelectedText = ""
        search_txtbox.SelectionLength = 0
        search_txtbox.SelectionStart = 0
        search_txtbox.ShortcutsEnabled = True
        search_txtbox.Size = New Size(1020, 42)
        search_txtbox.TabIndex = 3
        search_txtbox.UseSelectable = True
        search_txtbox.WaterMarkColor = Color.FromArgb(CByte(109), CByte(109), CByte(109))
        search_txtbox.WaterMarkFont = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel)
        ' 
        ' PoisonLabel1
        ' 
        PoisonLabel1.AutoSize = True
        PoisonLabel1.Dock = DockStyle.Left
        PoisonLabel1.Font = New Font("Segoe UI Light", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        PoisonLabel1.Location = New Point(0, 0)
        PoisonLabel1.Name = "PoisonLabel1"
        PoisonLabel1.Size = New Size(51, 19)
        PoisonLabel1.TabIndex = 2
        PoisonLabel1.Text = "Search:"
        ' 
        ' view_dgv
        ' 
        view_dgv.AllowUserToResizeRows = False
        view_dgv.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        view_dgv.BorderStyle = BorderStyle.None
        view_dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        view_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(174), CByte(219))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        view_dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        view_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        view_dgv.DefaultCellStyle = DataGridViewCellStyle2
        view_dgv.Dock = DockStyle.Fill
        view_dgv.EnableHeadersVisualStyles = False
        view_dgv.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        view_dgv.GridColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        view_dgv.Location = New Point(0, 42)
        view_dgv.Name = "view_dgv"
        view_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(0), CByte(174), CByte(219))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        view_dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        view_dgv.RowHeadersWidth = 62
        view_dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        view_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        view_dgv.Size = New Size(1071, 860)
        view_dgv.TabIndex = 2
        ' 
        ' updateForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(view_dgv)
        Controls.Add(PoisonPanel1)
        Controls.Add(TableLayoutPanel1)
        Name = "updateForm"
        Size = New Size(1071, 965)
        TableLayoutPanel1.ResumeLayout(False)
        PoisonPanel1.ResumeLayout(False)
        PoisonPanel1.PerformLayout()
        CType(view_dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PoisonPanel1 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents view_dgv As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents deleteBtn As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents updateBtn As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents search_txtbox As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel

End Class
