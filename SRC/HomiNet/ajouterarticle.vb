Public Class Ajouterarticle
    Dim tarif As Integer = 1

    Private Sub GlassButton2_Click(sender As Object, e As EventArgs) Handles GlassButton2.Click
        Me.Close()
    End Sub

    Private Sub ajouterarticle_Load(sender As Object, e As EventArgs) Handles Me.Load
        initlangue()
        ListBox1.Items.Clear()
        For i As Integer = 0 To baseproduit.dproduit.Rows.Count - 1
            ListBox1.Items.Add(baseproduit.dproduit.Rows(i).Cells("Column1").Value)
        Next
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = 0
    End Sub

    Public Sub initlangue()
        Label3.Text = Trans(353)
        Label4.Text = Trans(355)
        Label5.Text = Trans(357)
        GlassButton2.Text = Trans(70)
        GlassButton4.Text = Trans(316)
        RadioButton1.Text = Trans(349)
        RadioButton2.Text = Trans(350)
        RadioButton3.Text = Trans(351)
        RadioButton4.Text = Trans(352)
    End Sub

    Public Function formater(s As Object) As String
        Return Format(CDbl(s), "0.00")
    End Function

    Private Sub GlassButton4_Click(sender As Object, e As EventArgs) Handles GlassButton4.Click
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        table.AddEmis(facture.dg1.CurrentRow.Cells("nummodule").Value, "FACTUREAJOUTER|" + ListBox1.SelectedItem + "|" + tarif.ToString + "|" + nud.Value.ToString)
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim p As Double = 0
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        Select Case tarif
            Case 1
                p = Val(baseproduit.dproduit.Rows(ListBox1.SelectedIndex).Cells("Column6").Value)
            Case 2
                p = Val(baseproduit.dproduit.Rows(ListBox1.SelectedIndex).Cells("Column7").Value)
            Case 3
                p = Val(baseproduit.dproduit.Rows(ListBox1.SelectedIndex).Cells("Column8").Value)
            Case 4
                p = Val(baseproduit.dproduit.Rows(ListBox1.SelectedIndex).Cells("Column9").Value)
        End Select
        Label6.Text = formater(p / 100)
        Label7.Text = formater(p / 100 * nud.Value)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then tarif = 1
        If RadioButton2.Checked = True Then tarif = 2
        If RadioButton3.Checked = True Then tarif = 3
        If RadioButton4.Checked = True Then tarif = 4
        ListBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nud.ValueChanged
        ListBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub
End Class