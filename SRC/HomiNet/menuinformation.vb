Public Class menuinformation

    Private Sub menuinformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabInformation.TabPages.Add(Informationinterface)
        tabInformation.TabPages.Add(informationsystem)
        tabInformation.TabPages.Add(information)
    End Sub
    Public Sub initlangue()

    End Sub
End Class