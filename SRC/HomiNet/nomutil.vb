Public Class nomutil

    Private Sub GlassButton3_Click(sender As Object, e As EventArgs) Handles GlassButton3.Click
        For i As Integer = 0 To utilisateur.LV1.Items.Count - 1
            If utilisateur.LV1.Items(i).Text = utilisateur.TextBox1.Text Then
                utilisateur.LV1.Items(i).Text = TextBox1.Text
                utilisateur.TextBox1.Text = TextBox1.Text
            End If
        Next
        Me.Hide()

    End Sub
End Class