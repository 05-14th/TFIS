Imports ReaLTaiizor.Controls

Public Class Landing

    Private Sub isVisible(ctrl As Control, visible As Boolean)
        ctrl.Visible = visible
    End Sub

    Private Sub ShowOnly(selectedPanel As Control, ParamArray allPanels() As Control)
        For Each pnl In allPanels
            pnl.Visible = (pnl Is selectedPanel)
        Next

    End Sub

    Private Sub contBtn_Click(sender As Object, e As EventArgs) Handles contBtn.Click, contBtn.Click, contBtn.Click
        isVisible(startPnl, False)
        isVisible(signInPnl, True)
        CenterControl(signInPnl, mainPnl)
    End Sub

    Private Sub CenterControl(ctrl As Control, parent As Control, ByVal Optional centerHori As Boolean = True, ByVal Optional centerVerti As Boolean = True)
        If (centerHori AndAlso centerVerti) Then
            Dim x As Integer = (parent.ClientSize.Width - ctrl.Width) \ 2
            Dim y As Integer = (parent.ClientSize.Height - ctrl.Height) \ 2
            ctrl.Location = New Point(x, y)
        ElseIf (centerHori AndAlso centerVerti = False) Then
            ctrl.Left = (ctrl.Parent.ClientSize.Width - ctrl.Width) \ 2
        ElseIf (centerHori = False AndAlso centerVerti) Then
            ctrl.Top = (ctrl.Parent.ClientSize.Height - ctrl.Height) \ 2
        End If
    End Sub

    Private Sub DockControl(ctrl As Control, parent As Control, position As DockStyle)
        ctrl.Dock = position
        parent.Controls.Add(ctrl)
    End Sub

    Private Sub Resize(ctrl As Control, x As Integer, y As Integer)
        ctrl.Size = New Size(x, y)
    End Sub

    Private Sub signInBtn_Click(sender As Object, e As EventArgs) Handles signInBtn.Click
        If unameTxtBox.Text = "1" And passTxtBox.Text = "1" Then
            isVisible(signInPnl, False)
            isVisible(sidePnl, True)
            isVisible(dashPnl, True)
            DockControl(dashPnl, mainPnl, DockStyle.Fill)
            DockControl(sidePnl, mainPnl, DockStyle.Left)
        ElseIf unameTxtBox.Text = "admin" And passTxtBox.Text = "admin" Then
            Dim form1 As New Form1()
            form1.Show()
        End If
    End Sub

    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resize(signInPnl, 551, 332)
        Resize(signUpPnl, 1043, 535)
        UpdateConnectionString()
    End Sub

    Private Sub signUpLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signUpLink.LinkClicked
        isVisible(signInPnl, False)
        isVisible(signUpPnl, True)
        CenterControl(signUpPnl, mainPnl)
    End Sub

    Private Sub returnLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles returnLink.LinkClicked
        signUpPnl.Visible = False
        signInPnl.Visible = True
        CenterControl(signInPnl, mainPnl)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        passTxtBox.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub HopeButton2_Click(sender As Object, e As EventArgs) Handles HopeButton2.Click
        mainPnl.Controls.Clear()
        DockControl(profilePnl, mainPnl, DockStyle.Fill)
        DockControl(sidePnl, mainPnl, DockStyle.Left)
        ShowOnly(profilePnl, dashPnl, profilePnl, calendarPnl, aboutPnl)
    End Sub

    Private Sub HopeButton4_Click(sender As Object, e As EventArgs) Handles HopeButton4.Click
        mainPnl.Controls.Clear()
        DockControl(calendarPnl, mainPnl, DockStyle.Fill)
        DockControl(sidePnl, mainPnl, DockStyle.Left)
        ShowOnly(calendarPnl, dashPnl, profilePnl, calendarPnl, aboutPnl)
        CenterControl(calendar, calendarPnl)
        CenterControl(calendarPnl, mainPnl)
    End Sub

    Private Sub HopeButton3_Click(sender As Object, e As EventArgs) Handles HopeButton3.Click

    End Sub

    Private Sub HopeButton1_Click(sender As Object, e As EventArgs) Handles HopeButton1.Click
        mainPnl.Controls.Clear()
        DockControl(dashPnl, mainPnl, DockStyle.Fill)
        DockControl(sidePnl, mainPnl, DockStyle.Left)
        ShowOnly(dashPnl, dashPnl, profilePnl, calendarPnl, aboutPnl)
    End Sub

    Private Sub HopeButton5_Click(sender As Object, e As EventArgs) Handles HopeButton5.Click
        mainPnl.Controls.Clear()
        DockControl(aboutPnl, mainPnl, DockStyle.Fill)
        DockControl(sidePnl, mainPnl, DockStyle.Left)
        ShowOnly(aboutPnl, dashPnl, profilePnl, calendarPnl, aboutPnl)
        CenterControl(vision, visPnl)
        CenterControl(mission, misPnl)
        CenterControl(description, descPnl)
        CenterControl(vision_lbl, visPnl, centerVerti:=False)
        CenterControl(mission_lbl, misPnl, centerVerti:=False)
        CenterControl(description_lbl, descPnl, centerVerti:=False)
    End Sub
End Class

