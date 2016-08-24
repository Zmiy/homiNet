Public Class menuremplissage

    Private Sub bases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.TabPages.Add(journalrefill)
        TabControl1.TabPages.Add(Remplissagemanuel)
        TabControl1.TabPages.Add(remplissage)

        initlangue()
    End Sub
    Public Sub initlangue()
        remplissage.Text = Trans(55)
    End Sub
End Class