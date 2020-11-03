Public Class Form2

    Private Sub txtWord_TextChanged(sender As Object, e As EventArgs) Handles txtWord.TextChanged
        If Me.txtWord.Text = " " Then
            Me.btnOk.Enabled = False
        Else
            Me.btnOk.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class