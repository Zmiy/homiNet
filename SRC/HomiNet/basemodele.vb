Imports svm

Public Class basemodele
    Public WithEvents modele As New DataTable("modele")
    Public panele As New Panel()
    Public dt As New DataTable()
    Private WithEvents _bs As BindingSource = New BindingSource()


    Private Sub basemodele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modele.Columns.Add("nom", Type.GetType("System.String"))
        For i As Integer = 1 To MaxCountOfProducts
            modele.Columns.Add("p" + i.ToString(), Type.GetType("System.String"))
        Next

        For i As Integer = 1 To MaxCountOfProducts
            modele.Columns.Add("q" + i.ToString(), Type.GetType("System.String"))
        Next
        modele.Columns.Add("Is226", Type.GetType("System.Boolean"))

        dmod.DataSource = Maintable
        For i As Integer = 0 To dmod.Columns.Count - 1
            dmod.Columns(i).Visible = False
        Next

        Try
            dmod.Columns("numchambre").Visible = True
            dmod.Columns("modelefrigo").Visible = True
            dmod.Columns("updateparamhomi").Visible = True
        Catch ex As Exception

        End Try
        initlangue()

        dt.Columns.Add("nom1")
        dt.Columns.Add("nom2")
        dt.Columns.Add("nom3")
        dt.Columns.Add("prix1")
        dt.Columns.Add("quantity")

        For Each dr As DataGridViewRow In baseproduit.dproduit.Rows
            dt.Rows.Add(New Object() {dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(6).Value, dr.Cells(11).Value})
        Next

        svmUnit.MaxCountOfProducts = MaxCountOfProducts
#If MinibarVer = "226" Then
        svmUnit.CountOfProductsOldBar = 16
#ElseIf MinibarVer = "330" OrElse MinibarVer = "330tray8" Then
        svmUnit.CountOfProductsOldBar = IIf(CountOfProductsHomi330 + 4 < MaxCountOfProducts, CountOfProductsHomi330 + 4, CountOfProductsHomi330)
#End If
        svmUnit.dtModele = modele.Copy
        svmUnit.ProductSource = dt
        svmUnit.SetSvm()
        panele = Me.Controls.Find("Panel1", False)(0)
        If panele.Controls.Count > 0 Then
            panele.Controls.Clear()
        End If
        '---------------------------------------------------------

        svmUnit.grbMain.Text = "SVM"
        panele.Controls.Add(svmUnit.grbMain)
        svmUnit.grbMain.AutoSize = True
        'panele.AutoSize = True
        _bs.DataSource = modele
        lstbListOfModels.DisplayMember = "nom"
        lstbListOfModels.ValueMember = "Is226"
        lstbListOfModels.DataSource = _bs 'modele

        lstbListOfModels.SelectedIndex = -1
        lstbListOfModels.Tag = -1
        If MaxCountOfProducts > 16 Then
            chkbIs226.Visible = True
        End If
    End Sub
    Public Sub initlangue()
        Me.Text = Trans(327)
        'GlassButton13.Text = trans(316)
        gbtnAdd.Text = Trans(316)
        gbtnRemove.Text = Trans(77)
        'Column1.HeaderText = trans(323)
        'Column2.HeaderText = trans(318)
        'Column3.HeaderText = trans(324)
        GroupBox2.Text = Trans(325)
        Label1.Text = Trans(326)
        dmod.Columns("numchambre").HeaderText = Trans(15)
        dmod.Columns("modelefrigo").HeaderText = Trans(327)
        dmod.Columns("updateparamhomi").HeaderText = Trans(189)
    End Sub
    Private Sub svm_click(sender As Object, e As EventArgs)
        'If sender.backcolor = Color.DarkGreen Then
        '    sender.backcolor = Color.DarkRed
        '    Dim R As Integer = Val(sender.text) - 1
        '    dsvm.Item(2, R).Value = "0"
        'Else
        '    sender.backcolor = Color.DarkGreen
        '    Dim R As Integer = Val(sender.text) - 1
        '    dsvm.Item(2, R).Value = "6"
        'End If
    End Sub

    Public Sub Clearmodele()
        modele.Rows.Clear()
        'lstbListOfModels.Items.Clear()
        'ListBox1.Items.Clear()
    End Sub
    Private Sub _bs_DataSourceChanged(sender As Object, e As System.EventArgs) Handles _bs.DataSourceChanged
        If modele.Rows.Count = 0 Then
            lstbListOfModels.SelectedIndex = -1
        Else
            lstbListOfModels.SelectedIndex = _bs.Count - 1
        End If

    End Sub

    Public Sub Addmodele(message As String())
        'modele.Rows.Add(message(1), message(2), message(3), message(4), message(5), message(6), message(7), message(8), message(9), message(10), message(11), message(12), message(13), message(14), message(15), message(16), message(17), message(18), message(19), message(20), message(21), message(22), message(23), message(24), message(25))
        Dim dr As DataRow = modele.NewRow()
        Dim columnsCount As Integer = modele.Columns.Count - 1
        'Dim maxModeleColumn As Integer = IIf(message.Length > modele.Columns.Count, modele.Columns.Count, message.Length)
        For i As Integer = 0 To columnsCount - 1
            dr(i) = message(i + 1)
        Next
        Try
            dr(columnsCount) = CBool(message(columnsCount + 1))
        Catch ex As Exception
            dr(columnsCount) = CBool("false")
        End Try

        modele.Rows.Add(dr)
        _bs.ResetBindings(False)
        'lstbListOfModels.SelectedIndex = _bs.Count - 1

        'lstbListOfModels.Items.Add(message(1))
        'lstbListOfModels.SelectedIndex = IIf(lstbListOfModels.Items.Count > 0, lstbListOfModels.Items.Count - 1, -1)
        'Application.DoEvents()
        'lstbListOfModels_SelectedIndexChanged(Nothing, Nothing)
        'Application.DoEvents()
        'ListBox1.DataSource = modele
        'ListBox1.Refresh()
        'ListBox1.Items.Add(message(1))
    End Sub

    Private Sub lstbListOfModels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbListOfModels.SelectedIndexChanged
        If Not Me.Visible Then
            Exit Sub
        End If
        lstbListOfModels.Tag = lstbListOfModels.SelectedIndex.ToString()

        If lstbListOfModels.SelectedIndex < 0 Then
            svmUnit.iCurrModeleIndex = lstbListOfModels.SelectedIndex
            'svmUnit.ShowOldGrid()
            Exit Sub
        End If

        txtbCurrModeleName.Text = lstbListOfModels.Text
        dt.Rows.Clear()
        For Each dr As DataGridViewRow In baseproduit.dproduit.Rows
            dt.Rows.Add(New Object() {dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(6).Value, dr.Cells(11).Value})
        Next

        svmUnit.dtModele = Me.modele.Copy()
        svmUnit.ProductSource = dt
        svmUnit.iCurrModeleIndex = lstbListOfModels.SelectedIndex
        If lstbListOfModels.SelectedValue = True Then
            'If modele(lstbListOfModels.SelectedIndex)("Is226") = True Then
            svmUnit.ShowNewGrid()
        Else
            svmUnit.ShowOldGrid()
        End If
        chkbIs226.Checked = modele(lstbListOfModels.SelectedIndex)("Is226") 'lstbListOfModels.SelectedValue
        'TextBox1.Text = ListBox1.SelectedItem
        'dsvm.Item(1, 0).Value = modele.Rows(ListBox1.SelectedIndex)("p1").ToString
        'dsvm.Item(1, 1).Value = modele.Rows(ListBox1.SelectedIndex)("p2").ToString
        'dsvm.Item(1, 2).Value = modele.Rows(ListBox1.SelectedIndex)("p3").ToString
        'dsvm.Item(1, 3).Value = modele.Rows(ListBox1.SelectedIndex)("p4").ToString
        'dsvm.Item(1, 4).Value = modele.Rows(ListBox1.SelectedIndex)("p5").ToString
        'dsvm.Item(1, 5).Value = modele.Rows(ListBox1.SelectedIndex)("p6").ToString
        'dsvm.Item(1, 6).Value = modele.Rows(ListBox1.SelectedIndex)("p7").ToString
        'dsvm.Item(1, 7).Value = modele.Rows(ListBox1.SelectedIndex)("p8").ToString
        'dsvm.Item(1, 8).Value = modele.Rows(ListBox1.SelectedIndex)("p9").ToString
        'dsvm.Item(1, 9).Value = modele.Rows(ListBox1.SelectedIndex)("p10").ToString
        'dsvm.Item(1, 10).Value = modele.Rows(ListBox1.SelectedIndex)("p11").ToString
        'dsvm.Item(1, 11).Value = modele.Rows(ListBox1.SelectedIndex)("p12").ToString

        'dsvm.Item(2, 0).Value = modele.Rows(ListBox1.SelectedIndex)("q1")
        'dsvm.Item(2, 1).Value = modele.Rows(ListBox1.SelectedIndex)("q2")
        'dsvm.Item(2, 2).Value = modele.Rows(ListBox1.SelectedIndex)("q3")
        'dsvm.Item(2, 3).Value = modele.Rows(ListBox1.SelectedIndex)("q4")
        'dsvm.Item(2, 4).Value = modele.Rows(ListBox1.SelectedIndex)("q5")
        'dsvm.Item(2, 5).Value = modele.Rows(ListBox1.SelectedIndex)("q6")
        'dsvm.Item(2, 6).Value = modele.Rows(ListBox1.SelectedIndex)("q7")
        'dsvm.Item(2, 7).Value = modele.Rows(ListBox1.SelectedIndex)("q8")
        'dsvm.Item(2, 8).Value = modele.Rows(ListBox1.SelectedIndex)("q9")
        'dsvm.Item(2, 9).Value = modele.Rows(ListBox1.SelectedIndex)("q10")
        'dsvm.Item(2, 10).Value = modele.Rows(ListBox1.SelectedIndex)("q11")
        'dsvm.Item(2, 11).Value = modele.Rows(ListBox1.SelectedIndex)("q12")

        'If dsvm.Item(2, 0).Value = "0" Then GlassButton1.BackColor = Color.DarkRed Else GlassButton1.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 1).Value = "0" Then GlassButton2.BackColor = Color.DarkRed Else GlassButton2.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 2).Value = "0" Then GlassButton3.BackColor = Color.DarkRed Else GlassButton3.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 3).Value = "0" Then GlassButton4.BackColor = Color.DarkRed Else GlassButton4.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 4).Value = "0" Then GlassButton5.BackColor = Color.DarkRed Else GlassButton5.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 5).Value = "0" Then GlassButton6.BackColor = Color.DarkRed Else GlassButton6.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 6).Value = "0" Then GlassButton7.BackColor = Color.DarkRed Else GlassButton7.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 7).Value = "0" Then GlassButton8.BackColor = Color.DarkRed Else GlassButton8.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 8).Value = "0" Then GlassButton9.BackColor = Color.DarkRed Else GlassButton9.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 9).Value = "0" Then GlassButton10.BackColor = Color.DarkRed Else GlassButton10.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 10).Value = "0" Then GlassButton11.BackColor = Color.DarkRed Else GlassButton11.BackColor = Color.DarkGreen
        'If dsvm.Item(2, 11).Value = "0" Then GlassButton12.BackColor = Color.DarkRed Else GlassButton12.BackColor = Color.DarkGreen


    End Sub


    Private Sub GlassButton13_Click(sender As Object, e As EventArgs) Handles gbtnAdd.Click
        txtbCurrModeleName.Text = txtbCurrModeleName.Text.Trim()
        'If Not lstbListOfModels.Items.Contains(txtbCurrModeleName.Text) Then
        'lstbListOfModels.SelectedIndex = -1
        'svmUnit.iCurrModeleIndex = lstbListOfModels.SelectedIndex
        'End If
        If Not Exists(txtbCurrModeleName.Text) Then
            lstbListOfModels.SelectedIndex = -1
            svmUnit.iCurrModeleIndex = lstbListOfModels.SelectedIndex
        End If
        Dim footerStr As String = String.Format("MAJMODELE|{0}|{1}|{2}", txtbCurrModeleName.Text, svmUnit.Modele, chkbIs226.Checked.ToString())
        'Table.AddEmis("0", "MAJMODELE|" + txtbCurrModeleName.Text + "|" + svmUnit.Modele + "|" + chkbIs226.Checked.ToString())
        Table.AddEmis("0", footerStr)
        'table.addemis("0", "MAJMODELE|" + TextBox1.Text + "|" + dsvm.Item(1, 0).Value + "|" + dsvm.Item(1, 1).Value + "|" + dsvm.Item(1, 2).Value + "|" + dsvm.Item(1, 3).Value + "|" + dsvm.Item(1, 4).Value + "|" + dsvm.Item(1, 5).Value + "|" + dsvm.Item(1, 6).Value + "|" + dsvm.Item(1, 7).Value + "|" + dsvm.Item(1, 8).Value + "|" + dsvm.Item(1, 9).Value + "|" + dsvm.Item(1, 10).Value + "|" + dsvm.Item(1, 11).Value + "|" + dsvm.Item(2, 0).Value + "|" + dsvm.Item(2, 1).Value + "|" + dsvm.Item(2, 2).Value + "|" + dsvm.Item(2, 3).Value + "|" + dsvm.Item(2, 4).Value + "|" + dsvm.Item(2, 5).Value + "|" + dsvm.Item(2, 6).Value + "|" + dsvm.Item(2, 7).Value + "|" + dsvm.Item(2, 8).Value + "|" + dsvm.Item(2, 9).Value + "|" + dsvm.Item(2, 10).Value + "|" + dsvm.Item(2, 11).Value)
        table.AddEmis("0", "ACTUALISERMODELE|")
    End Sub
    Private Function Exists(key As String) As Boolean
        Dim result As Boolean = False
        'Dim index As Integer = -1
        'modele.DefaultView.Sort = "nom asc"
        'index = modele.DefaultView.Find(key)
        'modele.DefaultView.Sort = ""
        'If index >= 0 Then
        '    result = True
        'End If
        Dim filter As String = String.Format("nom='{0}'", key)
        Dim dr As DataRow() = modele.Select(filter)
        If dr.Length > 0 Then
            result = True
        End If
        Return result
    End Function
    Private Sub dsvm_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        Exit Sub
    End Sub
    'remove modele
    Private Sub GlassButton14_Click(sender As Object, e As EventArgs) Handles gbtnRemove.Click
        ' table.addemis("0", "SUPPRIMEMODELE|" + TextBox1.Text)
        table.AddEmis("0", "SUPPRIMEMODELE|" + txtbCurrModeleName.Text)
        table.AddEmis("0", "ACTUALISERMODELE|")
        'lstbListOfModels.SelectedIndex = lstbListOfModels.Items.Count - 1 '2 
        lstbListOfModels.SelectedIndex = IIf(lstbListOfModels.Items.Count - 1 > 0, 0, -1)
    End Sub

    Private Sub dsvm_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
        'If e.ColumnIndex = 1 Then
        '    ListBox2.Items.Clear()
        '    ListBox2.Items.Add(trans(129))
        '    For i As Integer = 0 To baseproduit.dproduit.Rows.Count - 1
        '        ListBox2.Items.Add(baseproduit.dproduit.Item("column1", i).Value)
        '    Next
        '    ListBox2.Visible = True
        'Else
        '    ListBox2.Visible = False

        'End If
    End Sub

    Private Sub ListBox2_MouseClick(sender As Object, e As MouseEventArgs)
        'If ListBox2.SelectedIndex = 0 Then
        '    dsvm.CurrentCell.Value = ""
        'Else
        '    dsvm.CurrentCell.Value = ListBox2.SelectedItem
        'End If
        'ListBox2.Visible = False

    End Sub

    Private Sub dsvm_MouseDown(sender As Object, e As MouseEventArgs)
        'ListBox2.Location = e.Location
        'ListBox2.Left += dsvm.Left - 20
        'ListBox2.Parent = Me
        'ListBox2.BringToFront()
        'ListBox2.Focus()
    End Sub

    Private Sub ListBox2_Leave(sender As Object, e As EventArgs)
        'ListBox2.Visible = False

    End Sub
    'set modele to room(s)
    Private Sub gbtnSetModele_Click(sender As Object, e As EventArgs) Handles gbtnSetModele.Click
        If lstbListOfModels.Text = "" Then Exit Sub
        For i As Integer = 0 To dmod.Rows.Count - 1
            If dmod.Rows(i).Selected = True Then
                dmod.Item("modelefrigo", i).Value = lstbListOfModels.Text
                dmod.Item("updateparamhomi", i).Value = "1"
                table.AddEmis(dmod.Item("nummodule", i).Value, "ATTRIBUTMODELE|" + dmod.Item("nummodule", i).Value + "|" + lstbListOfModels.Text + "|1")
            End If
        Next
    End Sub

    Private Sub basemodele_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True And Not IsStarted Then
            If lstbListOfModels.Items.Count > 0 Then
                lstbListOfModels.SelectedIndex = CInt(lstbListOfModels.Tag)
            End If
        End If
    End Sub

    Private Sub gbtnAlternateSetModele_Click(sender As Object, e As EventArgs) Handles gbtnAlternateSetModele.Click
        Dim WarningMess As String = "Are you sure?" + Environment.NewLine + "This is alternate method for assign SVM model." + Environment.NewLine + _
                                    "This method usable only that would change model name, without sending information to the Minibar." + Environment.NewLine + _
                                    "For regulare assign please use button  "">>""  above." + Environment.NewLine + _
                                    "For continue press OK, for use regular SVM's setup, press Cansel"
        If lstbListOfModels.Text = "" Then Exit Sub

        If MessageBox.Show(WarningMess, "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
            For i As Integer = 0 To dmod.Rows.Count - 1
                If dmod.Rows(i).Selected = True Then
                    dmod.Item("modelefrigo", i).Value = lstbListOfModels.Text
                    table.AddEmis(dmod.Item("nummodule", i).Value, "ATTRIBUTMODELEONLY|" + dmod.Item("nummodule", i).Value + "|" + lstbListOfModels.Text)
                End If
            Next
        End If
    End Sub

    Private Sub lstbListOfModels_DataSourceChanged(sender As Object, e As EventArgs) Handles lstbListOfModels.DataSourceChanged
        'If lstbListOfModels.Items.Count > 0 Then
        '    lstbListOfModels.Tag = 0
        '    lstbListOfModels.SelectedIndex = 0
        'End If
    End Sub

    
    Private Sub _bs_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles _bs.ListChanged
        If modele.Rows.Count = 0 Then
            lstbListOfModels.SelectedIndex = -1
        Else
            lstbListOfModels.SelectedIndex = _bs.Count - 1
        End If

    End Sub
End Class