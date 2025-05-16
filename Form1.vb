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
        Me.Close()
    End Sub

    Public Sub CenterControlInParent(ByVal controlToCenter As Control)
        If controlToCenter.Parent Is Nothing Then
            Throw New ArgumentException("The control must have a parent container")
        End If

        Dim parent = controlToCenter.Parent

        ' Calculate the centered position
        Dim newX As Integer = (parent.ClientSize.Width - controlToCenter.Width) \ 2
        Dim newY As Integer = (parent.ClientSize.Height - controlToCenter.Height) \ 2

        ' Ensure position is not negative (minimum 0)
        newX = Math.Max(0, newX)
        newY = Math.Max(0, newY)

        ' Set the location
        controlToCenter.Location = New Point(newX, newY)

        ' Optional: Set anchor to None to maintain centered position
        ' when parent is resized (you'll need to call this function again)
        controlToCenter.Anchor = AnchorStyles.None
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainPnl.Controls.Clear()
        Dim selection As New formSelection(Me)
        mainPnl.Controls.Add(selection)
        CenterControlInParent(selection)
    End Sub
End Class