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

    Public Sub ClearFormControls(ctrl As Control)
        For Each c As Control In ctrl.Controls
            ' Recursively clear nested containers
            If c.HasChildren Then
                ClearFormControls(c)
            End If

            ' Clear TextBoxes (ReaLTaiizor or standard)
            If TypeOf c Is TextBoxBase Then
                DirectCast(c, TextBoxBase).Clear()

                ' Clear ComboBoxes
            ElseIf TypeOf c Is ComboBox Then
                DirectCast(c, ComboBox).SelectedIndex = -1

                ' Clear DateTimePickers
            ElseIf TypeOf c Is DateTimePicker Then
                DirectCast(c, DateTimePicker).Value = DateTime.Now
            End If
        Next
    End Sub
End Module