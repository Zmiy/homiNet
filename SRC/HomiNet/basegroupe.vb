Public Class basegroupe

    Private Sub produit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
    End Sub
    Public Sub initlangue()
        Me.Text = Trans(306) '+ "-" + trans(311)
        Column3.HeaderText = Trans(320)
        Column1.HeaderText = Trans(321)
        Column2.HeaderText = Trans(322)
        gbtnRemoveGroup.Text = Trans(77)
        gbtnAddGroup.Text = Trans(316)
        gbtnSendGroup.Text = Trans(317)
        GlassButton4.Text = Trans(77)
        GlassButton3.Text = Trans(316)
        GlassButton5.Text = Trans(317)
        GroupBox1.Text = Trans(306)
        GroupBox2.Text = Trans(311)
    End Sub
    'Group Add
    Private Sub gbtnAddGroup_Click(sender As Object, e As EventArgs) Handles gbtnAddGroup.Click
        dgroupe.Rows.Add("*", "NewGroup", 0)
    End Sub
    'Tax add
    Private Sub GlassButton3_Click(sender As Object, ea As EventArgs) Handles GlassButton3.Click
        dtaxe.Rows.Add("*", "NewTax", "1")
    End Sub
    'Groupe remuve
    Private Sub gbtnRemoveGroup_Click(sender As Object, ea As EventArgs) Handles gbtnRemoveGroup.Click
        For i As Integer = dgroupe.SelectedRows.Count - 1 To 0 Step -1
            Table.AddEmis("0", "SUPPRIMEGROUPE|" + dgroupe.SelectedRows(i).Cells(1).Value)
        Next
        Table.AddEmis("0", "ACTUALISERGROUPE|")
    End Sub

    Private Sub GlassButton4_Click(sender As Object, ex As EventArgs) Handles GlassButton4.Click
        For i As Integer = dtaxe.SelectedRows.Count - 1 To 0 Step -1
            Table.AddEmis("0", "SUPPRIMETAXE|" + dtaxe.SelectedRows(i).Cells(1).Value)
        Next
        Table.AddEmis("0", "ACTUALISERTAXE|")
    End Sub

    Private Sub gbtnSendGroup_Click(sender As Object, ea As EventArgs) Handles gbtnSendGroup.Click
        For i As Integer = 0 To dgroupe.Rows.Count - 1
            Table.AddEmis("0", "MAJGROUPE|" + dgroupe.Item(1, i).Value + "|" + dgroupe.Item(2, i).Value + "|")
            dgroupe.Item(0, i).Value = ""
        Next
        Table.AddEmis("0", "ACTUALISERGROUPE|")
    End Sub

    Private Sub GlassButton5_Click(sender As Object, ea As EventArgs) Handles GlassButton5.Click
        For i As Integer = 0 To dtaxe.Rows.Count - 1
            Table.AddEmis("0", "MAJTAXE|" + dtaxe.Item(1, i).Value + "|" + dtaxe.Item(2, i).Value + "|")
            dtaxe.Item(0, i).Value = ""
        Next
        Table.AddEmis("0", "ACTUALISERTAXE|")
    End Sub
    Public Sub cleargroupe()
        dgroupe.Rows.Clear()
    End Sub
    Public Sub cleartaxe()
        dtaxe.Rows.Clear()
    End Sub
    Public Sub addgroupe(message As String())
        dgroupe.Rows.Add("", message(1), message(4))
    End Sub
    Public Sub addtaxe(message As String())
        dtaxe.Rows.Add("", message(1), message(2))
    End Sub
End Class