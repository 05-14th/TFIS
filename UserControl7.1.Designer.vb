<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl7
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
        PanelForms = New Panel()
        SuspendLayout()
        ' 
        ' PanelForms
        ' 
        PanelForms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelForms.AutoSize = True
        PanelForms.BackColor = Color.RosyBrown
        PanelForms.Location = New Point(145, 63)
        PanelForms.Name = "PanelForms"
        PanelForms.Size = New Size(794, 623)
        PanelForms.TabIndex = 7
        ' 
        ' UserControl7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PanelForms)
        Name = "UserControl7"
        Size = New Size(1085, 748)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelForms As Panel

End Class
