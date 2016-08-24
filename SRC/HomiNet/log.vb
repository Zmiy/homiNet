Public Class log
    Public nom As String = ""
    Public tel As String = ""

    Private Sub log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
    End Sub
    Public Sub initlangue()
        Me.Text = Trans(406)
        GlassButton1.Text = Trans(404)
        GlassButton2.Text = Trans(405)

    End Sub

    Private Sub GlassButton1_Click(sender As Object, e As EventArgs) Handles GlassButton1.Click
        table.AddEmis(0, "LOGIN|" + nom + "|" + tel)
    End Sub

    Private Sub GlassButton2_Click(sender As Object, e As EventArgs) Handles GlassButton2.Click
        table.AddEmis(0, "LOGOUT|" + nom + "|" + tel)
    End Sub
End Class