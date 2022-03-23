<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabelForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddresssLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TipsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StreetAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterYourStreetAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterTheCityYouWouldLikeTheMailDeliveredToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterTheStateInWhichYourCityResidesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterTheZipCodeOfTheAssocitatedCityAndStateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirstAndLastNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameOfThePersonTheMailIsBeingDeiveredToOrFromToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayLabelButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplaysTheGivenInformationInTheAppropiateMailingAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearsGivenInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClosesTheProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InputGroupBox.Controls.Add(Me.ZipLabel)
        Me.InputGroupBox.Controls.Add(Me.StateTextBox)
        Me.InputGroupBox.Controls.Add(Me.StateLabel)
        Me.InputGroupBox.Controls.Add(Me.CityTextBox)
        Me.InputGroupBox.Controls.Add(Me.CityLabel)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressTextBox)
        Me.InputGroupBox.Controls.Add(Me.StreetAddresssLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupBox.Location = New System.Drawing.Point(14, 28)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(348, 410)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Mailing Address"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(19, 349)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(213, 27)
        Me.ZipTextBox.TabIndex = 11
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(19, 326)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(31, 20)
        Me.ZipLabel.TabIndex = 10
        Me.ZipLabel.Text = "Zip"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(19, 295)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(213, 27)
        Me.StateTextBox.TabIndex = 9
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(19, 272)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(43, 20)
        Me.StateLabel.TabIndex = 8
        Me.StateLabel.Text = "State"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(19, 237)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(213, 27)
        Me.CityTextBox.TabIndex = 7
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(19, 214)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(34, 20)
        Me.CityLabel.TabIndex = 6
        Me.CityLabel.Text = "City"
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(19, 177)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(213, 27)
        Me.StreetAddressTextBox.TabIndex = 5
        '
        'StreetAddresssLabel
        '
        Me.StreetAddresssLabel.AutoSize = True
        Me.StreetAddresssLabel.Location = New System.Drawing.Point(19, 154)
        Me.StreetAddresssLabel.Name = "StreetAddresssLabel"
        Me.StreetAddresssLabel.Size = New System.Drawing.Size(105, 20)
        Me.StreetAddresssLabel.TabIndex = 4
        Me.StreetAddresssLabel.Text = "Street Address"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(19, 120)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(213, 27)
        Me.LastNameTextBox.TabIndex = 3
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(19, 97)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(79, 20)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "Last Name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(19, 65)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(213, 27)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(19, 42)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(84, 20)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First Name "
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(368, 28)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(417, 320)
        Me.OutputGroupBox.TabIndex = 1
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Address Label"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Location = New System.Drawing.Point(6, 42)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(13, 20)
        Me.DisplayLabel.TabIndex = 0
        Me.DisplayLabel.Text = " "
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(368, 354)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(135, 84)
        Me.DisplayButton.TabIndex = 2
        Me.DisplayButton.Text = "Display Label"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(509, 354)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(135, 84)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(650, 354)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(135, 84)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TipsToolStripMenuItem
        '
        Me.TipsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StreetAddressToolStripMenuItem, Me.CityToolStripMenuItem, Me.StateToolStripMenuItem, Me.ZipToolStripMenuItem, Me.FirstAndLastNameToolStripMenuItem, Me.DisplayLabelButtonToolStripMenuItem, Me.ClearButtonToolStripMenuItem, Me.ExitButtonToolStripMenuItem})
        Me.TipsToolStripMenuItem.Name = "TipsToolStripMenuItem"
        Me.TipsToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.TipsToolStripMenuItem.Text = "Tips"
        '
        'StreetAddressToolStripMenuItem
        '
        Me.StreetAddressToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterYourStreetAddressToolStripMenuItem})
        Me.StreetAddressToolStripMenuItem.Name = "StreetAddressToolStripMenuItem"
        Me.StreetAddressToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.StreetAddressToolStripMenuItem.Text = "Street Address"
        '
        'EnterYourStreetAddressToolStripMenuItem
        '
        Me.EnterYourStreetAddressToolStripMenuItem.Name = "EnterYourStreetAddressToolStripMenuItem"
        Me.EnterYourStreetAddressToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.EnterYourStreetAddressToolStripMenuItem.Text = "Enter your Street Address"
        '
        'CityToolStripMenuItem
        '
        Me.CityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterTheCityYouWouldLikeTheMailDeliveredToToolStripMenuItem})
        Me.CityToolStripMenuItem.Name = "CityToolStripMenuItem"
        Me.CityToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.CityToolStripMenuItem.Text = "City"
        '
        'EnterTheCityYouWouldLikeTheMailDeliveredToToolStripMenuItem
        '
        Me.EnterTheCityYouWouldLikeTheMailDeliveredToToolStripMenuItem.Name = "EnterTheCityYouWouldLikeTheMailDeliveredToToolStripMenuItem"
        Me.EnterTheCityYouWouldLikeTheMailDeliveredToToolStripMenuItem.Size = New System.Drawing.Size(422, 26)
        Me.EnterTheCityYouWouldLikeTheMailDeliveredToToolStripMenuItem.Text = "Enter the City you would like the mail delivered to"
        '
        'StateToolStripMenuItem
        '
        Me.StateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterTheStateInWhichYourCityResidesToolStripMenuItem})
        Me.StateToolStripMenuItem.Name = "StateToolStripMenuItem"
        Me.StateToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.StateToolStripMenuItem.Text = "State"
        '
        'EnterTheStateInWhichYourCityResidesToolStripMenuItem
        '
        Me.EnterTheStateInWhichYourCityResidesToolStripMenuItem.Name = "EnterTheStateInWhichYourCityResidesToolStripMenuItem"
        Me.EnterTheStateInWhichYourCityResidesToolStripMenuItem.Size = New System.Drawing.Size(358, 26)
        Me.EnterTheStateInWhichYourCityResidesToolStripMenuItem.Text = "Enter The state in which your city resides"
        '
        'ZipToolStripMenuItem
        '
        Me.ZipToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterTheZipCodeOfTheAssocitatedCityAndStateToolStripMenuItem})
        Me.ZipToolStripMenuItem.Name = "ZipToolStripMenuItem"
        Me.ZipToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ZipToolStripMenuItem.Text = "Zip"
        '
        'EnterTheZipCodeOfTheAssocitatedCityAndStateToolStripMenuItem
        '
        Me.EnterTheZipCodeOfTheAssocitatedCityAndStateToolStripMenuItem.Name = "EnterTheZipCodeOfTheAssocitatedCityAndStateToolStripMenuItem"
        Me.EnterTheZipCodeOfTheAssocitatedCityAndStateToolStripMenuItem.Size = New System.Drawing.Size(432, 26)
        Me.EnterTheZipCodeOfTheAssocitatedCityAndStateToolStripMenuItem.Text = "Enter the Zip code of the associtated City and State"
        '
        'FirstAndLastNameToolStripMenuItem
        '
        Me.FirstAndLastNameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameOfThePersonTheMailIsBeingDeiveredToOrFromToolStripMenuItem})
        Me.FirstAndLastNameToolStripMenuItem.Name = "FirstAndLastNameToolStripMenuItem"
        Me.FirstAndLastNameToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.FirstAndLastNameToolStripMenuItem.Text = "First and Last Name"
        '
        'NameOfThePersonTheMailIsBeingDeiveredToOrFromToolStripMenuItem
        '
        Me.NameOfThePersonTheMailIsBeingDeiveredToOrFromToolStripMenuItem.Name = "NameOfThePersonTheMailIsBeingDeiveredToOrFromToolStripMenuItem"
        Me.NameOfThePersonTheMailIsBeingDeiveredToOrFromToolStripMenuItem.Size = New System.Drawing.Size(472, 26)
        Me.NameOfThePersonTheMailIsBeingDeiveredToOrFromToolStripMenuItem.Text = "Name of the person the mail is being deivered to or from"
        '
        'DisplayLabelButtonToolStripMenuItem
        '
        Me.DisplayLabelButtonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplaysTheGivenInformationInTheAppropiateMailingAddressToolStripMenuItem})
        Me.DisplayLabelButtonToolStripMenuItem.Name = "DisplayLabelButtonToolStripMenuItem"
        Me.DisplayLabelButtonToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.DisplayLabelButtonToolStripMenuItem.Text = "Display Label Button"
        '
        'DisplaysTheGivenInformationInTheAppropiateMailingAddressToolStripMenuItem
        '
        Me.DisplaysTheGivenInformationInTheAppropiateMailingAddressToolStripMenuItem.Name = "DisplaysTheGivenInformationInTheAppropiateMailingAddressToolStripMenuItem"
        Me.DisplaysTheGivenInformationInTheAppropiateMailingAddressToolStripMenuItem.Size = New System.Drawing.Size(574, 26)
        Me.DisplaysTheGivenInformationInTheAppropiateMailingAddressToolStripMenuItem.Text = "Displays the given information in the appropiate mailing address fashion"
        '
        'ClearButtonToolStripMenuItem
        '
        Me.ClearButtonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearsGivenInformationToolStripMenuItem})
        Me.ClearButtonToolStripMenuItem.Name = "ClearButtonToolStripMenuItem"
        Me.ClearButtonToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ClearButtonToolStripMenuItem.Text = "Clear Button"
        '
        'ClearsGivenInformationToolStripMenuItem
        '
        Me.ClearsGivenInformationToolStripMenuItem.Name = "ClearsGivenInformationToolStripMenuItem"
        Me.ClearsGivenInformationToolStripMenuItem.Size = New System.Drawing.Size(254, 26)
        Me.ClearsGivenInformationToolStripMenuItem.Text = "Clears given Information"
        '
        'ExitButtonToolStripMenuItem
        '
        Me.ExitButtonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClosesTheProgramToolStripMenuItem})
        Me.ExitButtonToolStripMenuItem.Name = "ExitButtonToolStripMenuItem"
        Me.ExitButtonToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ExitButtonToolStripMenuItem.Text = "Exit Button"
        '
        'ClosesTheProgramToolStripMenuItem
        '
        Me.ClosesTheProgramToolStripMenuItem.Name = "ClosesTheProgramToolStripMenuItem"
        Me.ClosesTheProgramToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.ClosesTheProgramToolStripMenuItem.Text = "Closes the program"
        '
        'AddressLabelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AddressLabelForm"
        Me.Text = "Form1"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents StreetAddresssLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TipsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StreetAddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FirstAndLastNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayLabelButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterYourStreetAddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterTheCityYouWouldLikeTheMailDeliveredToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterTheStateInWhichYourCityResidesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterTheZipCodeOfTheAssocitatedCityAndStateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NameOfThePersonTheMailIsBeingDeiveredToOrFromToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplaysTheGivenInformationInTheAppropiateMailingAddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearsGivenInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClosesTheProgramToolStripMenuItem As ToolStripMenuItem
End Class
