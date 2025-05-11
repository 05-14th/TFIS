<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RenewalData
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        dgvRenewal = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        lblRecordCount = New Label()
        cbxStatus = New ComboBox()
        cbxComplianceStatus = New ComboBox()
        cbxRenewalType = New ComboBox()
        dtpExpirationDate = New DateTimePicker()
        dtpApprovalDate = New DateTimePicker()
        dtpProcessingDate = New DateTimePicker()
        dtpSubmissionDate = New DateTimePicker()
        tbRenewalNumber = New TextBox()
        tbAuthorityID = New TextBox()
        tbPenaltyFee = New TextBox()
        tbRenewalFee = New TextBox()
        tbFranchiseID = New TextBox()
        tbFranchiseeID = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        LabelVehicle_Regulatory = New Label()
        Panel1 = New Panel()
        CType(dgvRenewal, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvRenewal
        ' 
        dgvRenewal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRenewal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRenewal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRenewal.Location = New Point(37, 475)
        dgvRenewal.Margin = New Padding(3, 4, 3, 4)
        dgvRenewal.Name = "dgvRenewal"
        dgvRenewal.RowHeadersWidth = 51
        dgvRenewal.Size = New Size(1021, 397)
        dgvRenewal.TabIndex = 0
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.CornflowerBlue
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(143, 403)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(143, 37)
        btnUpdate.TabIndex = 30
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.CornflowerBlue
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(317, 403)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(143, 37)
        btnDelete.TabIndex = 31
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.AutoSize = True
        lblRecordCount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecordCount.Location = New Point(37, 449)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(55, 20)
        lblRecordCount.TabIndex = 48
        lblRecordCount.Text = "Label2"
        ' 
        ' cbxStatus
        ' 
        cbxStatus.FormattingEnabled = True
        cbxStatus.Items.AddRange(New Object() {"approved", "denied", "pending"})
        cbxStatus.Location = New Point(37, 245)
        cbxStatus.Margin = New Padding(3, 4, 3, 4)
        cbxStatus.Name = "cbxStatus"
        cbxStatus.Size = New Size(249, 28)
        cbxStatus.TabIndex = 81
        ' 
        ' cbxComplianceStatus
        ' 
        cbxComplianceStatus.FormattingEnabled = True
        cbxComplianceStatus.Items.AddRange(New Object() {"compliant", "non-compliant"})
        cbxComplianceStatus.Location = New Point(37, 209)
        cbxComplianceStatus.Margin = New Padding(3, 4, 3, 4)
        cbxComplianceStatus.Name = "cbxComplianceStatus"
        cbxComplianceStatus.Size = New Size(249, 28)
        cbxComplianceStatus.TabIndex = 80
        ' 
        ' cbxRenewalType
        ' 
        cbxRenewalType.FormattingEnabled = True
        cbxRenewalType.Items.AddRange(New Object() {"annual", "semi-annual"})
        cbxRenewalType.Location = New Point(37, 173)
        cbxRenewalType.Margin = New Padding(3, 4, 3, 4)
        cbxRenewalType.Name = "cbxRenewalType"
        cbxRenewalType.Size = New Size(249, 28)
        cbxRenewalType.TabIndex = 79
        ' 
        ' dtpExpirationDate
        ' 
        dtpExpirationDate.Location = New Point(317, 319)
        dtpExpirationDate.Margin = New Padding(3, 4, 3, 4)
        dtpExpirationDate.Name = "dtpExpirationDate"
        dtpExpirationDate.Size = New Size(249, 27)
        dtpExpirationDate.TabIndex = 78
        ' 
        ' dtpApprovalDate
        ' 
        dtpApprovalDate.Location = New Point(317, 209)
        dtpApprovalDate.Margin = New Padding(3, 4, 3, 4)
        dtpApprovalDate.Name = "dtpApprovalDate"
        dtpApprovalDate.Size = New Size(249, 27)
        dtpApprovalDate.TabIndex = 77
        ' 
        ' dtpProcessingDate
        ' 
        dtpProcessingDate.Location = New Point(317, 264)
        dtpProcessingDate.Margin = New Padding(3, 4, 3, 4)
        dtpProcessingDate.Name = "dtpProcessingDate"
        dtpProcessingDate.Size = New Size(249, 27)
        dtpProcessingDate.TabIndex = 76
        ' 
        ' dtpSubmissionDate
        ' 
        dtpSubmissionDate.Location = New Point(317, 153)
        dtpSubmissionDate.Margin = New Padding(3, 4, 3, 4)
        dtpSubmissionDate.Name = "dtpSubmissionDate"
        dtpSubmissionDate.Size = New Size(249, 27)
        dtpSubmissionDate.TabIndex = 75
        ' 
        ' tbRenewalNumber
        ' 
        tbRenewalNumber.Location = New Point(37, 281)
        tbRenewalNumber.Name = "tbRenewalNumber"
        tbRenewalNumber.PlaceholderText = "Renewal Number"
        tbRenewalNumber.Size = New Size(249, 27)
        tbRenewalNumber.TabIndex = 74
        ' 
        ' tbAuthorityID
        ' 
        tbAuthorityID.Location = New Point(317, 100)
        tbAuthorityID.Name = "tbAuthorityID"
        tbAuthorityID.PlaceholderText = "Authority ID"
        tbAuthorityID.Size = New Size(250, 27)
        tbAuthorityID.TabIndex = 73
        ' 
        ' tbPenaltyFee
        ' 
        tbPenaltyFee.Location = New Point(35, 353)
        tbPenaltyFee.Name = "tbPenaltyFee"
        tbPenaltyFee.PlaceholderText = "Penalty Fee"
        tbPenaltyFee.Size = New Size(250, 27)
        tbPenaltyFee.TabIndex = 72
        ' 
        ' tbRenewalFee
        ' 
        tbRenewalFee.Location = New Point(35, 317)
        tbRenewalFee.Name = "tbRenewalFee"
        tbRenewalFee.PlaceholderText = "Renewal Fee"
        tbRenewalFee.Size = New Size(250, 27)
        tbRenewalFee.TabIndex = 71
        ' 
        ' tbFranchiseID
        ' 
        tbFranchiseID.Location = New Point(37, 100)
        tbFranchiseID.Name = "tbFranchiseID"
        tbFranchiseID.PlaceholderText = "Franchisee ID"
        tbFranchiseID.Size = New Size(249, 27)
        tbFranchiseID.TabIndex = 70
        ' 
        ' tbFranchiseeID
        ' 
        tbFranchiseeID.Location = New Point(37, 136)
        tbFranchiseeID.Name = "tbFranchiseeID"
        tbFranchiseeID.PlaceholderText = "Franchise ID"
        tbFranchiseeID.Size = New Size(249, 27)
        tbFranchiseeID.TabIndex = 69
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.Location = New Point(317, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 82
        Label1.Text = "Submission Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(317, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
        Label2.TabIndex = 83
        Label2.Text = "Processing Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(317, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 84
        Label3.Text = "Approval Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(317, 299)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 20)
        Label4.TabIndex = 85
        Label4.Text = "Expiration Date"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.BackColor = SystemColors.HighlightText
        txtSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(635, 16)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "  Search to renewal"
        txtSearch.Size = New Size(292, 27)
        txtSearch.TabIndex = 86
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.FromArgb(CByte(13), CByte(71), CByte(127))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(949, 11)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(109, 36)
        btnSearch.TabIndex = 87
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' LabelVehicle_Regulatory
        ' 
        LabelVehicle_Regulatory.AutoSize = True
        LabelVehicle_Regulatory.BackColor = Color.Transparent
        LabelVehicle_Regulatory.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelVehicle_Regulatory.ForeColor = Color.White
        LabelVehicle_Regulatory.Location = New Point(21, 16)
        LabelVehicle_Regulatory.Name = "LabelVehicle_Regulatory"
        LabelVehicle_Regulatory.Size = New Size(213, 23)
        LabelVehicle_Regulatory.TabIndex = 16
        LabelVehicle_Regulatory.Text = "RENEWAL INFORMATION"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(LabelVehicle_Regulatory)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtSearch)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1085, 55)
        Panel1.TabIndex = 88
        ' 
        ' RenewalData
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbxStatus)
        Controls.Add(cbxComplianceStatus)
        Controls.Add(cbxRenewalType)
        Controls.Add(dtpExpirationDate)
        Controls.Add(dtpApprovalDate)
        Controls.Add(dtpProcessingDate)
        Controls.Add(dtpSubmissionDate)
        Controls.Add(tbRenewalNumber)
        Controls.Add(tbAuthorityID)
        Controls.Add(tbPenaltyFee)
        Controls.Add(tbRenewalFee)
        Controls.Add(tbFranchiseID)
        Controls.Add(tbFranchiseeID)
        Controls.Add(lblRecordCount)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(dgvRenewal)
        Margin = New Padding(3, 4, 3, 4)
        Name = "RenewalData"
        Size = New Size(1085, 904)
        CType(dgvRenewal, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvRenewal As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents cbxStatus As ComboBox
    Friend WithEvents cbxComplianceStatus As ComboBox
    Friend WithEvents cbxRenewalType As ComboBox
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents dtpApprovalDate As DateTimePicker
    Friend WithEvents dtpProcessingDate As DateTimePicker
    Friend WithEvents dtpSubmissionDate As DateTimePicker
    Friend WithEvents tbRenewalNumber As TextBox
    Friend WithEvents tbAuthorityID As TextBox
    Friend WithEvents tbPenaltyFee As TextBox
    Friend WithEvents tbRenewalFee As TextBox
    Friend WithEvents tbFranchiseID As TextBox
    Friend WithEvents tbFranchiseeID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents LabelVehicle_Regulatory As Label
    Friend WithEvents Panel1 As Panel

End Class
