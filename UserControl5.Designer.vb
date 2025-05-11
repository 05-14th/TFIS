<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5Renewal
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
        cbxStatus = New ComboBox()
        cbxComplianceStatus = New ComboBox()
        cbxRenewalType = New ComboBox()
        tbRenewalNumber = New TextBox()
        tbAuthorityID = New TextBox()
        tbPenaltyFee = New TextBox()
        tbRenewalFee = New TextBox()
        tbFranchiseeID = New TextBox()
        tbFranchiseID = New TextBox()
        btnSave = New Button()
        dtpExpirationDate = New DateTimePicker()
        dtpApprovalDate = New DateTimePicker()
        dtpProcessingDate = New DateTimePicker()
        dtpSubmissionDate = New DateTimePicker()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        LabelVehicle_Regulatory = New Label()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbxStatus
        ' 
        cbxStatus.FormattingEnabled = True
        cbxStatus.Items.AddRange(New Object() {"approved", "denied", "pending"})
        cbxStatus.Location = New Point(69, 275)
        cbxStatus.Margin = New Padding(3, 4, 3, 4)
        cbxStatus.Name = "cbxStatus"
        cbxStatus.Size = New Size(249, 28)
        cbxStatus.TabIndex = 68
        ' 
        ' cbxComplianceStatus
        ' 
        cbxComplianceStatus.FormattingEnabled = True
        cbxComplianceStatus.Items.AddRange(New Object() {"compliant", "non-compliant"})
        cbxComplianceStatus.Location = New Point(69, 239)
        cbxComplianceStatus.Margin = New Padding(3, 4, 3, 4)
        cbxComplianceStatus.Name = "cbxComplianceStatus"
        cbxComplianceStatus.Size = New Size(249, 28)
        cbxComplianceStatus.TabIndex = 67
        ' 
        ' cbxRenewalType
        ' 
        cbxRenewalType.FormattingEnabled = True
        cbxRenewalType.Items.AddRange(New Object() {"annual", "semi-annual"})
        cbxRenewalType.Location = New Point(69, 203)
        cbxRenewalType.Margin = New Padding(3, 4, 3, 4)
        cbxRenewalType.Name = "cbxRenewalType"
        cbxRenewalType.Size = New Size(249, 28)
        cbxRenewalType.TabIndex = 66
        ' 
        ' tbRenewalNumber
        ' 
        tbRenewalNumber.Location = New Point(70, 352)
        tbRenewalNumber.Name = "tbRenewalNumber"
        tbRenewalNumber.PlaceholderText = "Renewal Number"
        tbRenewalNumber.Size = New Size(249, 27)
        tbRenewalNumber.TabIndex = 61
        ' 
        ' tbAuthorityID
        ' 
        tbAuthorityID.Location = New Point(365, 136)
        tbAuthorityID.Name = "tbAuthorityID"
        tbAuthorityID.PlaceholderText = "Authority ID"
        tbAuthorityID.Size = New Size(250, 27)
        tbAuthorityID.TabIndex = 60
        ' 
        ' tbPenaltyFee
        ' 
        tbPenaltyFee.Location = New Point(70, 443)
        tbPenaltyFee.Name = "tbPenaltyFee"
        tbPenaltyFee.PlaceholderText = "Penalty Fee"
        tbPenaltyFee.Size = New Size(250, 27)
        tbPenaltyFee.TabIndex = 59
        ' 
        ' tbRenewalFee
        ' 
        tbRenewalFee.Location = New Point(70, 395)
        tbRenewalFee.Name = "tbRenewalFee"
        tbRenewalFee.PlaceholderText = "Renewal Fee"
        tbRenewalFee.Size = New Size(250, 27)
        tbRenewalFee.TabIndex = 58
        ' 
        ' tbFranchiseeID
        ' 
        tbFranchiseeID.Location = New Point(69, 169)
        tbFranchiseeID.Name = "tbFranchiseeID"
        tbFranchiseeID.PlaceholderText = "Franchisee ID"
        tbFranchiseeID.Size = New Size(249, 27)
        tbFranchiseeID.TabIndex = 57
        ' 
        ' tbFranchiseID
        ' 
        tbFranchiseID.Location = New Point(69, 136)
        tbFranchiseID.Name = "tbFranchiseID"
        tbFranchiseID.PlaceholderText = "Franchise ID"
        tbFranchiseID.Size = New Size(249, 27)
        tbFranchiseID.TabIndex = 56
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.CornflowerBlue
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(490, 541)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(143, 37)
        btnSave.TabIndex = 69
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dtpExpirationDate
        ' 
        dtpExpirationDate.Location = New Point(366, 443)
        dtpExpirationDate.Margin = New Padding(3, 4, 3, 4)
        dtpExpirationDate.Name = "dtpExpirationDate"
        dtpExpirationDate.Size = New Size(249, 27)
        dtpExpirationDate.TabIndex = 82
        ' 
        ' dtpApprovalDate
        ' 
        dtpApprovalDate.Location = New Point(366, 362)
        dtpApprovalDate.Margin = New Padding(3, 4, 3, 4)
        dtpApprovalDate.Name = "dtpApprovalDate"
        dtpApprovalDate.Size = New Size(249, 27)
        dtpApprovalDate.TabIndex = 81
        ' 
        ' dtpProcessingDate
        ' 
        dtpProcessingDate.Location = New Point(366, 280)
        dtpProcessingDate.Margin = New Padding(3, 4, 3, 4)
        dtpProcessingDate.Name = "dtpProcessingDate"
        dtpProcessingDate.Size = New Size(249, 27)
        dtpProcessingDate.TabIndex = 80
        ' 
        ' dtpSubmissionDate
        ' 
        dtpSubmissionDate.Location = New Point(366, 209)
        dtpSubmissionDate.Margin = New Padding(3, 4, 3, 4)
        dtpSubmissionDate.Name = "dtpSubmissionDate"
        dtpSubmissionDate.Size = New Size(249, 27)
        dtpSubmissionDate.TabIndex = 79
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(366, 419)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 20)
        Label4.TabIndex = 89
        Label4.Text = "Expiration Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(366, 333)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 88
        Label3.Text = "Approval Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(366, 256)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
        Label2.TabIndex = 87
        Label2.Text = "Processing Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.Location = New Point(366, 185)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 86
        Label1.Text = "Submission Date"
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
        Panel1.Size = New Size(679, 55)
        Panel1.TabIndex = 90
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
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.CornflowerBlue
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(1365, 11)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(143, 37)
        btnSearch.TabIndex = 87
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.BackColor = SystemColors.ScrollBar
        txtSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(1107, 15)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "  Search to renewal"
        txtSearch.Size = New Size(250, 27)
        txtSearch.TabIndex = 86
        ' 
        ' Form5Renewal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.LightPink
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpExpirationDate)
        Controls.Add(dtpApprovalDate)
        Controls.Add(dtpProcessingDate)
        Controls.Add(dtpSubmissionDate)
        Controls.Add(btnSave)
        Controls.Add(cbxStatus)
        Controls.Add(cbxComplianceStatus)
        Controls.Add(cbxRenewalType)
        Controls.Add(tbRenewalNumber)
        Controls.Add(tbAuthorityID)
        Controls.Add(tbPenaltyFee)
        Controls.Add(tbRenewalFee)
        Controls.Add(tbFranchiseeID)
        Controls.Add(tbFranchiseID)
        Name = "Form5Renewal"
        Size = New Size(679, 615)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cbxStatus As ComboBox
    Friend WithEvents cbxComplianceStatus As ComboBox
    Friend WithEvents cbxRenewalType As ComboBox
    Friend WithEvents tbRenewalNumber As TextBox
    Friend WithEvents tbAuthorityID As TextBox
    Friend WithEvents tbPenaltyFee As TextBox
    Friend WithEvents tbRenewalFee As TextBox
    Friend WithEvents tbFranchiseeID As TextBox
    Friend WithEvents tbFranchiseID As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents dtpApprovalDate As DateTimePicker
    Friend WithEvents dtpProcessingDate As DateTimePicker
    Friend WithEvents dtpSubmissionDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelVehicle_Regulatory As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox

End Class
