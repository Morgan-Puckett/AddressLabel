'Morgan Puckett 
'RCET0265
'Spring 2022
'Address Label
' 



Public Class AddressLabelForm
    Dim finalLabel As String
    Dim areaSpec As String


    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        finalLabel = FirstNameTextBox.Text + " " + LastNameTextBox.Text
        finalLabel = finalLabel + vbCrLf + StreetAddressTextBox.Text
        areaSpec = CityTextBox.Text + ", " + StateTextBox.Text + " " + ZipTextBox.Text
        finalLabel = finalLabel + vbCrLf + areaSpec

        DisplayLabel.Text = finalLabel
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        finalLabel = " "
        DisplayLabel.Text = finalLabel
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        CityTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class


