Public Class bases

    Private Sub bases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
        TabControl1.TabPages.Add(basedlc)
        TabControl1.TabPages.Add(basehappy)
        TabControl1.TabPages.Add(basemodele)
        TabControl1.TabPages.Add(basegroupe)
        TabControl1.TabPages.Add(baseproduit)
    End Sub
    Public Sub initlangue()
        Label1.Text = Trans(315)
    End Sub
End Class