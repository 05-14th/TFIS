Module UIModule
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
End Module