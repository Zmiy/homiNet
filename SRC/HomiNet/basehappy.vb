Public Class basehappy

    Private Sub produit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
    End Sub
    Public Sub initlangue()
        CheckBox1.Text = Trans(409)
        CheckBox2.Text = Trans(410)
        CheckBox3.Text = Trans(411)
        CheckBox4.Text = Trans(412)
        CheckBox5.Text = Trans(413)
        CheckBox6.Text = Trans(414)
        CheckBox7.Text = Trans(415)
        Me.Text = Trans(408)
        rbtnPrice1.Text = Trans(349)
        rbtnPrice2.Text = Trans(350)
        rbtnPrice3.Text = Trans(351)
        rbtnPrice4.Text = Trans(352)

        rbtnHappyON.Text = Trans(121)
        rbtnHappyOFF.Text = Trans(122)

        Label3.Text = Trans(367)
        Label4.Text = Trans(368)

        GlassButton0.Text = Trans(316)
        GlassButton1.Text = Trans(77)
        GlassButton2.Text = Trans(317)

        GroupBox7.Text = Trans(184)
        GroupBox8.Text = Trans(346)
        GroupBox6.Text = Trans(416)

        Column1.HeaderText = Trans(72)
        Column2.HeaderText = Trans(131)
        Column3.HeaderText = Trans(367)
        Column4.HeaderText = Trans(368)
        Column5.HeaderText = Trans(346)
        Column6.HeaderText = Trans(409)
        Column7.HeaderText = Trans(410)
        Column8.HeaderText = Trans(411)
        Column9.HeaderText = Trans(412)
        Column10.HeaderText = Trans(413)
        Column11.HeaderText = Trans(414)
        Column12.HeaderText = Trans(415)
    End Sub
    Public Sub clearhappy()
        dh.Rows.Clear()
    End Sub
    Public Sub addhappy(message As String())
        Dim dateS As DateTime = Convert.ToDateTime(message(3))

        dh.Rows.Add(message(1), message(2), Convert.ToDateTime(message(3)), Convert.ToDateTime(message(4)), message(5), message(6), message(7), message(8), message(9), message(10), message(11), message(12))
    End Sub
    Private Sub GlassButton2_Click(sender As Object, e As EventArgs) Handles GlassButton2.Click
        Dim db As String = String.Empty, df As String = String.Empty
        For i As Integer = 0 To dh.Rows.Count - 1
            db = Convert.ToDateTime(dh.Item(2, i).Value).ToUniversalTime.ToString("u")
            df = Convert.ToDateTime(dh.Item(3, i).Value).ToUniversalTime.ToString("u")
            Dim s1 As String = ("MAJHAPPY|" + dh.Item(0, i).Value.ToString + "|" + dh.Item(1, i).Value.ToString + "|" + db + "|" + df + "|" + dh.Item(4, i).Value.ToString + "|" + dh.Item(5, i).Value.ToString + "|" + dh.Item(6, i).Value.ToString + "|" + dh.Item(7, i).Value.ToString + "|" + dh.Item(8, i).Value.ToString + "|" + dh.Item(9, i).Value.ToString + "|" + dh.Item(10, i).Value.ToString + "|" + dh.Item(11, i).Value.ToString)
            table.AddEmis("0", s1)
        Next
        table.AddEmis("0", "ACTUALISERHAPPY|")
    End Sub

    Private Sub GlassButton0_Click(sender As Object, e As EventArgs) Handles GlassButton0.Click
        Dim onoff As String = "off"
        If rbtnHappyON.Checked = True Then onoff = "on"
        Dim t As String = "1"
        If rbtnPrice2.Checked = True Then t = "2"
        If rbtnPrice3.Checked = True Then t = "3"
        If rbtnPrice4.Checked = True Then t = "4"

        dh.Rows.Add("Happy " + dh.Rows.Count.ToString, onoff, db.Value.ToString, df.Value.ToString, t, CheckBox1.Checked.ToString, CheckBox2.Checked.ToString, CheckBox3.Checked.ToString, CheckBox4.Checked.ToString, CheckBox5.Checked.ToString, CheckBox6.Checked.ToString, CheckBox7.Checked.ToString)
    End Sub

    Private Sub GlassButton1_Click(sender As Object, e As EventArgs) Handles GlassButton1.Click
        If MessageBox.Show(Trans(78), Trans(77), MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For i As Integer = dh.SelectedRows.Count - 1 To 0 Step -1
                table.AddEmis("0", "SUPPRIMEHAPPY|" + dh.SelectedRows(i).Cells(0).Value)
            Next
            table.AddEmis("0", "ACTUALISERHAPPY|")
        End If
    End Sub

    Private Sub dh_SelectionChanged(sender As Object, e As EventArgs) Handles dh.SelectionChanged
        Try
            Dim d As Date = dh.CurrentRow.Cells(2).Value.ToString
            db.Value = d
            d = dh.CurrentRow.Cells(3).Value.ToString
            df.Value = d
        Catch ex As Exception

        End Try

        If dh.CurrentRow.Cells(1).Value = "on" Then rbtnHappyON.Checked = True Else rbtnHappyOFF.Checked = True

        Select Case dh.CurrentRow.Cells(4).Value
            Case 1
                rbtnPrice1.Checked = True
            Case 2
                rbtnPrice2.Checked = True
            Case 3
                rbtnPrice3.Checked = True
            Case 4
                rbtnPrice4.Checked = True
        End Select
        CheckBox1.Checked = dh.CurrentRow.Cells(5).Value
        CheckBox2.Checked = dh.CurrentRow.Cells(6).Value
        CheckBox3.Checked = dh.CurrentRow.Cells(7).Value
        CheckBox4.Checked = dh.CurrentRow.Cells(8).Value
        CheckBox5.Checked = dh.CurrentRow.Cells(9).Value
        CheckBox6.Checked = dh.CurrentRow.Cells(10).Value
        CheckBox7.Checked = dh.CurrentRow.Cells(11).Value


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPrice1.CheckedChanged
        If dh.Rows.Count = 0 Or Me.Visible = False Then
            Exit Sub
        End If
        If sender.checked = True Then
            Try
                dh.CurrentRow.Cells(4).Value = "1"
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPrice2.CheckedChanged
        If dh.Rows.Count = 0 Or Me.Visible = False Then
            Exit Sub
        End If
        If sender.checked = True Then
            Try
                dh.CurrentRow.Cells(4).Value = "2"
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPrice3.CheckedChanged
        If dh.Rows.Count = 0 Or Me.Visible = False Then
            Exit Sub
        End If
        If sender.checked = True Then
            Try
                dh.CurrentRow.Cells(4).Value = "3"
            Catch ex As Exception

            End Try
        End If

    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPrice4.CheckedChanged
        If dh.Rows.Count = 0 Or Me.Visible = False Then
            Exit Sub
        End If
        If sender.checked = True Then
            Try
                dh.CurrentRow.Cells(4).Value = "4"
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub rbtnHappyON_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnHappyON.CheckedChanged
        If dh.Rows.Count = 0 Or Me.Visible = False Then
            Exit Sub
        End If
        If sender.checked = True Then
            Try
                dh.CurrentRow.Cells(1).Value = "on"
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub rbtnHappyOFF_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnHappyOFF.CheckedChanged
        If dh.Rows.Count = 0 Or Me.Visible = False Then
            Exit Sub
        End If
        If sender.checked = True Then
            Try
                dh.CurrentRow.Cells(1).Value = "off"
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            dh.CurrentRow.Cells(5).Value = sender.checked
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Try
            dh.CurrentRow.Cells(6).Value = sender.checked
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Try
            dh.CurrentRow.Cells(7).Value = sender.checked
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Try
            dh.CurrentRow.Cells(8).Value = sender.checked
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Try
            dh.CurrentRow.Cells(9).Value = sender.checked
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Try
            dh.CurrentRow.Cells(10).Value = sender.checked
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Try
            dh.CurrentRow.Cells(11).Value = sender.checked
        Catch ex As Exception

        End Try
    End Sub

    Private Sub db_ValueChanged(sender As Object, e As EventArgs) Handles db.ValueChanged
        Try
            hb.Value = db.Value
            dh.CurrentRow.Cells(2).Value = sender.value.ToString
        Catch ex As Exception

        End Try
    End Sub
    Private Sub df_ValueChanged(sender As Object, e As EventArgs) Handles df.ValueChanged
        Try
            hf.Value = df.Value
            dh.CurrentRow.Cells(3).Value = sender.value.ToString
        Catch ex As Exception

        End Try

    End Sub


    Private Sub hb_ValueChanged(sender As Object, e As EventArgs) Handles hb.ValueChanged
        Try
            db.Value = hb.Value
            dh.CurrentRow.Cells(2).Value = sender.value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub hf_ValueChanged(sender As Object, e As EventArgs) Handles hf.ValueChanged
        Try
            df.Value = hf.Value
            dh.CurrentRow.Cells(3).Value = sender.value.ToString
        Catch ex As Exception

        End Try

    End Sub


End Class