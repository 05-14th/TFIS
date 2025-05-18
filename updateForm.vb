Public Class updateForm
    Public query As String
    Private Sub updateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToDGV(query, view_dgv)
    End Sub


End Class
