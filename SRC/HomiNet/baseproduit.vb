Public Class baseproduit

    Private Sub produit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
    End Sub
    Public Sub initlangue()
        Column1.HeaderText = Trans(301)
        Column2.HeaderText = Trans(303)
        Column3.HeaderText = Trans(304)
        Column4.HeaderText = Trans(306)
        Column5.HeaderText = Trans(311)
        Column6.HeaderText = Trans(307)
        Column7.HeaderText = Trans(308)
        Column8.HeaderText = Trans(309)
        Column9.HeaderText = Trans(310)
        Column10.HeaderText = Trans(312)
        Column11.HeaderText = Trans(313)
        Column12.HeaderText = Trans(379)
        Column13.HeaderText = Trans(380)
        Column14.HeaderText = Trans(393)
        Me.Text = Trans(318)
        GlassButton1.Text = Trans(77)
        GlassButton0.Text = Trans(316)
        GlassButton2.Text = Trans(317)

    End Sub

    Private Sub GlassButton1_Click(sender As Object, e As EventArgs) Handles GlassButton1.Click
        For i As Integer = dproduit.SelectedRows.Count - 1 To 0 Step -1
            table.AddEmis("0", "SUPPRIMEPRODUIT|" + dproduit.SelectedRows(i).Cells(1).Value)
        Next
        table.AddEmis("0", "ACTUALISERPRODUIT|")
    End Sub
    Private Sub UpdateComboBoxColumns()
        Try
            Column4.Items.Clear()
            Column5.Items.Clear()
            For i As Integer = 0 To basegroupe.dgroupe.Rows.Count - 1
                Column4.Items.Add(basegroupe.dgroupe.Item(1, i).Value)
            Next
            For i As Integer = 0 To basegroupe.dtaxe.Rows.Count - 1
                Column5.Items.Add(basegroupe.dtaxe.Item(1, i).Value)
            Next

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GlassButton0_Click(sender As Object, e As EventArgs) Handles GlassButton0.Click
        UpdateComboBoxColumns()
        dproduit.Rows.Add("*", "", "", "", "", "", "0", "0", "0", "0", "180", "0", "2", "3", False)
    End Sub

    Public Sub clearproduit()
        dproduit.Rows.Clear()
    End Sub
    Public Sub addproduit(message As String())
        'Try
        '    Column4.Items.Clear()
        '    Column5.Items.Clear()
        '    For i As Integer = 0 To basegroupe.dgroupe.Rows.Count - 1
        '        Column4.Items.Add(basegroupe.dgroupe.Item(1, i).Value)
        '    Next
        '    For i As Integer = 0 To basegroupe.dtaxe.Rows.Count - 1
        '        Column5.Items.Add(basegroupe.dtaxe.Item(1, i).Value)
        '    Next

        'Catch ex As Exception

        'End Try
        UpdateComboBoxColumns()
        Try
            Dim safe As Boolean = False
            If message(14) = "1" Then safe = True Else safe = False
            dproduit.Rows.Add("", message(1), message(2), message(3), message(4), message(5), message(6), message(7), message(8), message(9), message(10), message(11), message(12), message(13), safe)
        Catch ex As Exception

        End Try
    End Sub
    'Send
    Private Sub GlassButton2_Click(sender As Object, e As EventArgs) Handles GlassButton2.Click
        For i As Integer = 0 To dproduit.Rows.Count - 1
            Dim safe As String = "0"
            If dproduit.Item(14, i).Value = True Then safe = "1"
            Dim s1 As String = ("MAJPRODUIT|" + dproduit.Item(1, i).Value + "|" + dproduit.Item(2, i).Value + "|" + dproduit.Item(3, i).Value + "|" + dproduit.Item(4, i).Value + "|" + dproduit.Item(5, i).Value + "|" + dproduit.Item(6, i).Value + "|" + dproduit.Item(7, i).Value + "|" + dproduit.Item(8, i).Value + "|" + dproduit.Item(9, i).Value + "|" + dproduit.Item(10, i).Value + "|" + dproduit.Item(11, i).Value + "|" + dproduit.Item(12, i).Value + "|" + dproduit.Item(13, i).Value + "|" + safe + "|")
            table.AddEmis("0", s1)
            dproduit.Item(0, i).Value = ""
        Next
        table.AddEmis("0", "ACTUALISERPRODUIT|")

    End Sub

    Private Sub dproduit_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dproduit.DataError
        Exit Sub
    End Sub

    Private Sub dproduit_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dproduit.CellValueChanged
        If e.ColumnIndex = 1 And dproduit.Rows.Count > 0 Then
            Try
                Dim i As Integer = dproduit.CurrentRow.Index
                If dproduit.Item(2, i).Value = "" Then dproduit.Item(2, i).Value = dproduit.Item(1, i).Value
                If dproduit.Item(3, i).Value = "" Then dproduit.Item(3, i).Value = dproduit.Item(1, i).Value

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub baseproduit_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        UpdateComboBoxColumns()
    End Sub
End Class