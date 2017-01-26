Imports System.Drawing.Printing

Public Class facture
    Public nummoduleaff As Integer
    Public indligne As Integer = -1

    Private Sub facture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inittable()
        initlangue()
    End Sub
    Public Sub initlangue()
        For i As Integer = 0 To dg1.Columns.Count - 1
            dg1.Columns(i).Visible = False
        Next
        dg1.Columns("e").HeaderText = ""
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



        dg1.Columns("numchambre").Visible = True
        dg1.Columns("check").Visible = True
        dg1.Columns("nbconso").Visible = True
        dg1.Columns("factureclient").Visible = True

        RadioButton1.Text = Trans(49)
        RadioButton2.Text = Trans(21)
        RadioButton3.Text = Trans(22)
        GroupBox1.Text = Trans(154)
        GroupBox2.Text = Trans(389)
        gbtnOffer.Text = Trans(360)
        gbtnAllOffer.Text = Trans(361)
        gbtnCancel.Text = Trans(362)
        gbtnCancelAll.Text = Trans(363)
        gbtnPrint.Text = Trans(141)
        gbtnUpdate.Text = Trans(189)
        gbtnAdd.Text = Trans(316)
        GlassButton9.Text = Trans(4)
        GlassButton10.Text = Trans(348)
        Label2.Text = Trans(48)
        Label4.Text = Trans(359)
        Label6.Text = Trans(358)
        Label8.Text = ""
        Label7.Text = ""
        Label9.Text = Trans(390)
        Label10.Text = Trans(391)
        'entete facture
        TextBox2.Text = Mid(Trans(353) + "    ", 1, 4) + "|" + Mid(Trans(354) + "              ", 1, 13) + "|" + Microsoft.VisualBasic.Right("      " + Trans(355), 6) + "|" + Microsoft.VisualBasic.Right("      " + Trans(356), 6) + "|" + Microsoft.VisualBasic.Right("         " + Trans(357), 9)
        imprimante.Items.Clear()
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            imprimante.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
        Next
        Try
            haut.Text = LireINI("imprimante", "notehaut")
            gauche.Text = LireINI("imprimante", "notegauche")
            imprimante.Text = LireINI("imprimante", "note")

        Catch ex As Exception

        End Try
    End Sub
    Private Sub inittable()
        dv1.Table = maintable
        dv.Table = maintable
        dvch.Table = dv1.Table
        dv.Sort = "nummodule"
        dv1.Sort = "numchambre"
        dvch.Sort = "numchambre"
        dv1.RowFilter = "numchambre<>'R*' and " + "test<>'" + Trans(37) + "'"
        Label5.Text = Trans(49)
        dg1.DataSource = dv1

    End Sub

    Private Sub GlassButton9_Click(sender As Object, e As EventArgs) Handles GlassButton9.Click
        MAINFORM.tabMain.TabPages(table).Select()
    End Sub


    Private Sub facture_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Label7.Text = ""
            Label8.Text = ""
            Label1.Text = Trans(15)
            Label3.Text = Trans(46)
            rtf.Items.Clear()
            RadioButton1_CheckedChanged(Nothing, Nothing)
            nummoduleaff = 0
            dg1_SelectionChanged(Nothing, Nothing)

        End If
    End Sub

    Public Sub Total()
        Dim s As String = ""
        Dim ttax As Double = 0, ttc As Double = 0
        Dim tmpDbl As Double
        For i As Integer = 0 To rtf.Items.Count - 1
            Try
                If rtf.Items(i) = Space(42) Then
                    s = rtf.Items(i - 1)
                    tmpDbl = 0.0
                    If Not Double.TryParse(Mid(s, 27, 6), tmpDbl) Then
                        tmpDbl += 0.0
                    End If
                    ttax += tmpDbl
                    tmpDbl = 0.0
                    If Not Double.TryParse(Mid(s, 33, 10), tmpDbl) Then
                        tmpDbl = 0.0
                    End If
                    ttc += tmpDbl
                    'ttax += CDbl(Mid(s, 27, 6))
                    'ttc += CDbl(Mid(s, 33, 10))
                End If

            Catch ex As Exception

            End Try
        Next
        Label8.Text = Format(ttax, "0.00")
        Label7.Text = Format(ttc, "0.00")
    End Sub

    Private Sub GlassButton4_Click(sender As Object, e As EventArgs) Handles gbtnUpdate.Click
        Try
            If Me.Visible = True Then
                Label7.Text = ""
                Label8.Text = ""
                Label1.Text = Trans(15) + dg1.CurrentRow.Cells("numchambre").Value
                Label3.Text = Trans(46) + ":  " + dg1.CurrentRow.Cells("datecheckin").Value
                rtf.Items.Clear()
                nummoduleaff = dg1.CurrentRow.Cells("nummodule").Value
                table.AddEmis(dg1.CurrentRow.Cells("nummodule").Value, "FACTURE")
            End If

        Catch ex As Exception
            Label7.Text = ""
            Label8.Text = ""
            Label1.Text = Trans(15)
            Label3.Text = Trans(46)
            rtf.Items.Clear()
            nummoduleaff = 0
        End Try
    End Sub

    Private Sub GlassButton7_Click(sender As Object, e As EventArgs) Handles gbtnOffer.Click
        If rtf.SelectedIndex > -1 And indligne > -1 Then
            rtf_Click(Nothing, Nothing)
            table.AddEmis(dg1.CurrentRow.Cells("nummodule").Value, "FACTUREOFFERT|" + indligne.ToString)
        End If
    End Sub

    Private Sub rtf_Click(sender As Object, e As EventArgs) Handles rtf.Click
        Try
            If rtf.SelectedIndex > -1 Then
                If rtf.SelectedItem.ToString().ToLower().StartsWith("' move") Or rtf.SelectedItem.ToString().ToLower().StartsWith("' swap") Then
                    rtf.SelectedIndex = rtf.SelectedIndex - 3
                End If
                If rtf.SelectedItem() = Space(42) Then
                    indligne = rtf.SelectedIndex - 1
                ElseIf rtf.Items(rtf.SelectedIndex + 1) = Space(42) Then
                    indligne = rtf.SelectedIndex
                ElseIf rtf.Items(rtf.SelectedIndex + 2) = Space(42) Then
                    indligne = rtf.SelectedIndex + 1
                End If
            Else
                indligne = -1
            End If
            rtf.SetSelected(indligne, True)
            '            If rtf.SelectedIndex > -1 Then

            '                If rtf.SelectedItem = Space(42) Then
            '                    indligne = rtf.SelectedIndex - 1
            '                    GoTo fin
            '                End If
            '                If rtf.Items(rtf.SelectedIndex + 1) = Space(42) Then
            '                    indligne = rtf.SelectedIndex
            '                    GoTo fin
            '                End If
            '                If rtf.Items(rtf.SelectedIndex + 2) = Space(42) Then
            '                    indligne = rtf.SelectedIndex + 1
            '                    GoTo fin
            '                End If
            '            Else
            '                indligne = -1
            '            End If
            'fin:
            '            rtf.SetSelected(indligne, True)
        Catch ex As Exception
            indligne = -1
        End Try
    End Sub

    Private Sub gbtnCancel_Click(sender As Object, e As EventArgs) Handles gbtnCancel.Click
        If rtf.SelectedIndex > -1 And indligne > -1 Then
            dg1_SelectionChanged(Nothing, Nothing)
            table.AddEmis(dg1.CurrentRow.Cells("nummodule").Value, "FACTUREANNULE|" + indligne.ToString)
        End If
    End Sub

    Private Sub GlassButton6_Click(sender As Object, e As EventArgs) Handles gbtnAdd.Click
        ajouterarticle.ShowDialog()
        GlassButton4_Click(Nothing, Nothing)
    End Sub

    Private Sub GlassButton1_Click(sender As Object, e As EventArgs) Handles gbtnAllOffer.Click
        If MessageBox.Show(Trans(78), Trans(361), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes And indligne > -1 Then
            table.AddEmis(dg1.CurrentRow.Cells("nummodule").Value, "FACTURETOUTOFFERT|" + indligne.ToString)
        End If
    End Sub

    Private Sub GlassButton3_Click(sender As Object, e As EventArgs) Handles gbtnCancelAll.Click
        If MessageBox.Show(Trans(78), Trans(363), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes And indligne > -1 Then
            table.AddEmis(dg1.CurrentRow.Cells("nummodule").Value, "FACTURETOUTANNULE|" + indligne.ToString)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            dv1.RowFilter = "numchambre<>'R*' and " + "test<>'" + Trans(37) + "'"
            Label5.Text = Trans(49)
        End If
        If RadioButton2.Checked = True Then
            dv1.RowFilter = "numchambre<>'R*' and " + "check='" + Trans(21) + "' and test<>'" + Trans(37) + "'"
            Label5.Text = Trans(21)
        End If
        If RadioButton3.Checked = True Then
            dv1.RowFilter = "numchambre<>'R*' and " + "check='" + Trans(22) + "' and test<>'" + Trans(37) + "'"
            Label5.Text = Trans(22)
        End If
    End Sub

    Private Sub dg1_SelectionChanged(sender As Object, e As EventArgs) Handles dg1.SelectionChanged
        If dg1.Rows.Count = 0 Or Me.Visible = False Then
            Exit Sub
        End If
        Try
            If dg1.CurrentRow.Cells("check").Value = Trans(21) Then
                gbtnAllOffer.Enabled = True
                gbtnCancel.Enabled = True
                gbtnCancelAll.Enabled = True
                gbtnAdd.Enabled = True
                gbtnOffer.Enabled = True
            Else
                gbtnAllOffer.Enabled = False
                gbtnCancel.Enabled = False
                gbtnCancelAll.Enabled = False
                gbtnAdd.Enabled = False
                gbtnOffer.Enabled = False
            End If
            If nummoduleaff = dg1.CurrentRow.Cells("nummodule").Value Then Exit Sub
            If Me.Visible = True Then
                Label7.Text = ""
                Label8.Text = ""
                Label1.Text = Trans(15) + dg1.CurrentRow.Cells("numchambre").Value
                Label3.Text = Trans(46) + ":  " + dg1.CurrentRow.Cells("datecheckin").Value
                rtf.Items.Clear()
                nummoduleaff = dg1.CurrentRow.Cells("nummodule").Value
                table.AddEmis(dg1.CurrentRow.Cells("nummodule").Value, "FACTURE")
            End If

        Catch ex As Exception
            Label7.Text = ""
            Label8.Text = ""
            Label1.Text = Trans(15)
            Label3.Text = Trans(46)
            rtf.Items.Clear()
            nummoduleaff = 0
        End Try
    End Sub


    Public Sub GlassButton5_Click(sender As Object, e As EventArgs) Handles gbtnPrint.Click
        EcrireINI("imprimante", "notegauche", gauche.Text)
        EcrireINI("imprimante", "notehaut", haut.Text)
        Imprimer.imprimante = imprimante.Text
        Imprimer.imprime = "note"
        Imprimer.paysage = False
        Imprimer.userLeft = Val(gauche.Text)
        Imprimer.userTop = Val(haut.Text)
        Imprimer.go()
    End Sub

    Private Sub imprimante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles imprimante.SelectedIndexChanged
        EcrireINI("imprimante", "note", imprimante.Text)

    End Sub

    Private Sub haut_TextChanged(sender As Object, e As EventArgs) Handles haut.TextChanged
    End Sub

    Private Sub gauche_TextChanged(sender As Object, e As EventArgs) Handles gauche.TextChanged
    End Sub
End Class