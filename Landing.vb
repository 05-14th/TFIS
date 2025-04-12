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

    Private Sub CenterControl(ctrl As Control, parent As Control)
        Dim x As Integer = (parent.ClientSize.Width - ctrl.Width) \ 2
        Dim y As Integer = (parent.ClientSize.Height - ctrl.Height) \ 2
        ctrl.Location = New Point(x, y)
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
        End If
    End Sub

    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resize(signInPnl, 551, 332)
        Resize(signUpPnl, 1043, 535)
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
        ShowOnly(profilePnl, dashPnl, profilePnl)
        DockControl(profilePnl, mainPnl, DockStyle.Fill)
        DockControl(sidePnl, mainPnl, DockStyle.Left)
    End Sub
End Class

