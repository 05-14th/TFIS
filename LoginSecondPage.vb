Public Class LoginSecondPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStandUser1.Click
        Dim form3 As New LoginThirdPage()

        form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdmin1.Click
        Dim form7 As New LoginAdminHome()

        form7.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LoginSecondPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class