Imports System.Security.Policy

Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        'Declare variables
        Dim strHomeLanguage As String
        Dim strNmae As String

        strHomeLanguage = txtMotherTongue.Text.ToUpper
        strNmae = txtName.Text

        If strHomeLanguage = "ENGLISH" Then
            MessageBox.Show("Hello!")
        ElseIf strHomeLanguage = "ISINDEBELE" Then
            MessageBox.Show("Lotjhani!")
        ElseIf strHomeLanguage = "ISIXHOSA" Then
            MessageBox.Show("Molo!")
        ElseIf strHomeLanguage = "ISIZULU" Or strHomeLanguage = "SISWATI" Then
            MessageBox.Show("Sawubona!")
        ElseIf strHomeLanguage = "SEPEDI" Or strHomeLanguage = "SETSWANA" Then
            MessageBox.Show("Dumela!")
        ElseIf strHomeLanguage = "XITSONGA" Then
            MessageBox.Show("Avuxeni!")
        ElseIf strHomeLanguage = "TSHIVENDA" Then
            MessageBox.Show("Ndaa!")
        Else
            MessageBox.Show("Hallo!")
        End If
        'Print message
        MessageBox.Show(strNmae & " " & "your home language is" & " " & strHomeLanguage)
    End Sub

    Private Sub txtMotherTongue_TextChanged(sender As Object, e As EventArgs) Handles txtMotherTongue.TextChanged

    End Sub
End Class
