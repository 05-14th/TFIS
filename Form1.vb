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
