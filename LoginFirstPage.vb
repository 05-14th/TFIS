Public Class LoginFirstPage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnContinue1.Click
        Dim form2 As New LoginSecondPage()
        form2.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub labelFranchise1_Click(sender As Object, e As EventArgs) Handles labelFranchise1.Click

    End Sub

    Private Sub labelInformation1_Click(sender As Object, e As EventArgs) Handles labelInformation1.Click

    End Sub

    Private Sub picboxTricy1_Click(sender As Object, e As EventArgs) Handles picboxTricy1.Click

    End Sub

    Private Sub labelTricycle1_Click(sender As Object, e As EventArgs) Handles labelTricycle1.Click

    End Sub
End Class
