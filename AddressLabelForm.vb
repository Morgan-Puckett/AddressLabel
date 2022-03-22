Public Class AddressLabelForm


    Private Sub DisplayButton_Click(sender As Object, e As EventArgs)
        DisplayLabel.text = $"{FirstNameTextbox.text} {LastNameTextbox.text}"
    End Sub
End Class
