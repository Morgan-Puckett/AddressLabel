'Morgan Puckett 
'RCET0265
'Spring 2022
'Address Label
'https://github.com/Morgan-Puckett/AddressLabel.git

Public Class AddressLabelForm
    'Varibles to allow cleaner code
    Dim finalLabel As String
    Dim areaSpec As String

    'Displays given information into the display label
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        finalLabel = FirstNameTextBox.Text + " " + LastNameTextBox.Text
        finalLabel = finalLabel + vbCrLf + StreetAddressTextBox.Text
        areaSpec = CityTextBox.Text + ", " + StateTextBox.Text + " " + ZipTextBox.Text
        finalLabel = finalLabel + vbCrLf + areaSpec

        DisplayLabel.Text = finalLabel
    End Sub

    'Clears current Information
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

    'Closes the form 
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class


