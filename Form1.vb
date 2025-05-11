Public Class Form1
    Private isFullScreen As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the sub-panels as hidden
        Submenupanel.Visible = False
        ReportsSubpanel.Visible = False
    End Sub

    Private Sub ToggleSubPanels(excludePanel As Panel)
        ' Hide all sub-panels except the one passed as a parameter
        Submenupanel.Visible = (excludePanel Is Submenupanel)
        ReportsSubpanel.Visible = (excludePanel Is ReportsSubpanel)
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        ' Toggle visibility of the sub-panel and hide others
        If Submenupanel.Visible Then
            Submenupanel.Visible = False
        Else
            ToggleSubPanels(Submenupanel)
            Submenupanel.Visible = True
            Submenupanel.Location = New Point(ButtonMenu.Left, ButtonMenu.Bottom)
        End If
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs)
        ' Toggle visibility of the Reports sub-panel and hide others
        If ReportsSubpanel.Visible Then
            ReportsSubpanel.Visible = False
        Else
            ToggleSubPanels(ReportsSubpanel)
            ReportsSubpanel.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' Show EntryForms within Panel2
        Panel2.Controls.Clear()
        Dim entryforms As New EntryForms
        Panel2.Controls.Add(entryforms)
        entryforms.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Panel2.Controls.Clear()
        Dim franchiselist As New UserControl10
        franchiselist.Dock = DockStyle.Fill ' Use Dock instead of Anchor
        Panel2.Controls.Add(franchiselist)
        franchiselist.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Button4 clicked")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Panel2.Controls.Clear()
        Dim regulatoryauthority As New UserControl11
        regulatoryauthority.Dock = DockStyle.Fill ' Use Dock instead of Anchor
        Panel2.Controls.Add(regulatoryauthority)
        regulatoryauthority.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Panel2.Controls.Clear()
        Dim renewaldata As New RenewalData
        Panel2.Controls.Add(renewaldata)
        renewaldata.Show()
    End Sub

    Private Sub BtnFullScreen_Click(sender As Object, e As EventArgs) Handles BtnFullScreen.Click
        ' Toggle full screen mode
        If isFullScreen Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
        Else
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If
        isFullScreen = Not isFullScreen
    End Sub

    Private Sub BtnReports_Click_1(sender As Object, e As EventArgs) Handles BtnReports.Click
        If ReportsSubpanel.Visible Then
            ReportsSubpanel.Visible = False
        Else
            ToggleSubPanels(ReportsSubpanel)
            ReportsSubpanel.Visible = True
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

    End Sub
End Class
