Public Class formSelection
    Private form1 As New Form1

    Public Sub New(parent As Form1)
        InitializeComponent() ' If this is a user control
        form1 = parent
    End Sub

    Private Sub franchiseeBtn_Click(sender As Object, e As EventArgs) Handles franchiseeBtn.Click
        form1.mainPnl.Controls.Clear()
        Dim myFranchiseeForm As New franchiseeForm
        form1.mainPnl.Controls.Add(myFranchiseeForm)
        CenterControlInParent(myFranchiseeForm)
    End Sub

    Private Sub franchiseBtn_Click(sender As Object, e As EventArgs) Handles franchiseBtn.Click
        form1.mainPnl.Controls.Clear()
        Dim myFranchiseForm As New franchiseForm
        form1.mainPnl.Controls.Add(myFranchiseForm)
        CenterControlInParent(myFranchiseForm)
    End Sub

    Private Sub vehicleBtn_Click(sender As Object, e As EventArgs) Handles vehicleBtn.Click
        form1.mainPnl.Controls.Clear()
        Dim myVehicleForm As New vehicleForm
        form1.mainPnl.Controls.Add(myVehicleForm)
        CenterControlInParent(myVehicleForm)
    End Sub

    Private Sub renewalBtn_Click(sender As Object, e As EventArgs) Handles renewalBtn.Click
        form1.mainPnl.Controls.Clear()
        Dim myRenewalForm As New renewalForm
        form1.mainPnl.Controls.Add(myRenewalForm)
        CenterControlInParent(myRenewalForm)
    End Sub

    Private Sub arfBtn_Click(sender As Object, e As EventArgs) Handles arfBtn.Click
        form1.mainPnl.Controls.Clear()
        Dim myRouteAssignForm As New routeAssignForm
        form1.mainPnl.Controls.Add(myRouteAssignForm)
        CenterControlInParent(myRouteAssignForm)
    End Sub
End Class
