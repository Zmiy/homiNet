Imports System.Drawing.Printing

Public Class information
    Public dva As New DataView

    Private Sub information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dva.Table = maintable
        dva.RowFilter = "test<>'" + Trans(97) + "' and test<>'" + Trans(37) + "'and test<>'" + Trans(26) + "'"
        dg1.DataSource = dva
        For i As Integer = 0 To dg1.Columns.Count - 1
            dg1.Columns(i).Visible = False
        Next
        dg1.Columns("numchambre").Visible = True
        dg1.Columns("etatporte").Visible = True
        dg1.Columns("serrure").Visible = True
        dg1.Columns("etattemp").Visible = True
        dg1.Columns("check").Visible = True
        dg1.Columns("ouverture").Visible = True
        dg1.Columns("nummodule").Visible = True
        dg1.Columns("test").Visible = True
        dg1.Columns("dateanomalie").Visible = True
        dg1.Columns("service").Visible = True
        dg1.Columns("c1").Visible = True
        dg1.Columns("c2").Visible = True
        dg1.Columns("c3").Visible = True
        dg1.Columns("c4").Visible = True
        dg1.Columns("c5").Visible = True
        dg1.Columns("c6").Visible = True
        dg1.Columns("c7").Visible = True
        dg1.Columns("c8").Visible = True
        dg1.Columns("c9").Visible = True
        dg1.Columns("c10").Visible = True
        dg1.Columns("c11").Visible = True
        dg1.Columns("c12").Visible = True
        dg1.Columns("modelefrigo").Visible = True
        dg1.Columns("nbconso").Visible = True
        dg1.Columns("aremplir").Visible = True
        dg1.Columns("updateparamhomi").Visible = True
        dg1.Columns("factureclient").Visible = True
        dg1.Columns("tarif").Visible = True
        initlangue()
    End Sub
    Public Sub initlangue()
        Me.Text = Trans(432)
        dg1.Columns("numchambre").HeaderText = Trans(28)
        dg1.Columns("etatporte").HeaderText = Trans(29)
        dg1.Columns("serrure").HeaderText = Trans(31)
        dg1.Columns("etattemp").HeaderText = Trans(30)
        dg1.Columns("ouverture").HeaderText = Trans(44)
        dg1.Columns("status").HeaderText = Trans(45)
        dg1.Columns("nummodule").HeaderText = Trans(32)
        dg1.Columns("check").HeaderText = Trans(23)
        dg1.Columns("test").HeaderText = Trans(26)
        dg1.Columns("dateremplissage").HeaderText = Trans(133)
        dg1.Columns("datecheckin").HeaderText = Trans(134)
        dg1.Columns("datecheckout").HeaderText = Trans(135)
        dg1.Columns("datelock").HeaderText = Trans(136)
        dg1.Columns("dateunlock").HeaderText = Trans(137)
        dg1.Columns("datemaintenance").HeaderText = Trans(138)
        dg1.Columns("dateanomalie").HeaderText = Trans(139)
        dg1.Columns("libre1").HeaderText = Trans(178)
        dg1.Columns("libre2").HeaderText = Trans(179)
        dg1.Columns("libre3").HeaderText = Trans(180)
        dg1.Columns("libre4").HeaderText = Trans(181)
        dg1.Columns("zone").HeaderText = Trans(127)
        dg1.Columns("numtelecommande").HeaderText = Trans(246)
        dg1.Columns("dateouvert").HeaderText = Trans(252)
        dg1.Columns("datefermer").HeaderText = Trans(253)

        dg1.Columns("service").HeaderText = Trans(328)
        dg1.Columns("c1").HeaderText = Trans(329)
        dg1.Columns("c2").HeaderText = Trans(330)
        dg1.Columns("c3").HeaderText = Trans(331)
        dg1.Columns("c4").HeaderText = Trans(332)
        dg1.Columns("c5").HeaderText = Trans(333)
        dg1.Columns("c6").HeaderText = Trans(334)
        dg1.Columns("c7").HeaderText = Trans(335)
        dg1.Columns("c8").HeaderText = Trans(336)
        dg1.Columns("c9").HeaderText = Trans(337)
        dg1.Columns("c10").HeaderText = Trans(338)
        dg1.Columns("c11").HeaderText = Trans(339)
        dg1.Columns("c12").HeaderText = Trans(340)
        dg1.Columns("modelefrigo").HeaderText = Trans(341)
        dg1.Columns("nbconso").HeaderText = Trans(342)
        dg1.Columns("aremplir").HeaderText = Trans(343)
        dg1.Columns("updateparamhomi").HeaderText = Trans(344)
        dg1.Columns("factureclient").HeaderText = Trans(345)
        dg1.Columns("tarif").HeaderText = Trans(346)
        GlassButton5.Text = Trans(141)
        CheckBox3.Text = Trans(385)
        imprimante.Items.Clear()
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            imprimante.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
        Next
        Try
            imprimante.Text = LireINI("imprimante", "information")
            CheckBox3.Checked = LireINI("imprimante", "informationpaysage")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        EcrireINI("imprimante", "informationpaysage", CheckBox3.Checked)
    End Sub
    Private Sub imprimante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles imprimante.SelectedIndexChanged
        EcrireINI("imprimante", "information", imprimante.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If MAINFORM.banomalie.BackColor = Color.Green Then Exit Sub
        If dva.Count = 0 Then
            MAINFORM.banomalie.BackColor = Color.Navy
        Else
            MAINFORM.banomalie.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub GlassButton5_Click(sender As Object, e As EventArgs) Handles GlassButton5.Click
        Dim imp As New Imprimer
        imp.imprimante = imprimante.Text
        imp.imprime = "information"
        imp.paysage = CheckBox3.Checked
        imp.go()
    End Sub
End Class