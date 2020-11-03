Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lblAbout03.Text = Me.lblAbout03.Text & SystemInformation.UserName
        Me.lblAbout04.Text = Me.lblAbout04.Text & SystemInformation.ComputerName
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class