
Imports System.IO
Imports System.Data
Imports System.ComponentModel
Imports System.Threading


Public Class Table

    Private Sub table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inittable()
        InitLabelView()
        initlangue()
        Initapplication()
        AddHandler Dv1.ListChanged, AddressOf Dv1ListChanged
        dgvMain.AutoResizeColumnHeadersHeight()
        dgvMain.AutoResizeColumns()
        dgvMain.AutoGenerateColumns = True
        For Each column As DataGridViewColumn In dgvMain.Columns
            With column
                Select Case .Name
                    Case "numchambre"
                        .Width = 90
                    Case "modelefrigo"
                        .Width = 90
                    Case "updateparamhomi"
                        .Width = 40
                    Case "etattemp"
                        .Width = 50
                    Case "service"
                        .Width = 50
                        .DisplayIndex = 3
                    Case "ouverture"
                        .Width = 40

                    Case "nummodule"
                        .Width = 70

                    Case "test"
                        .Width = 110

                    Case Else
                        If .Width > 85 Then
                            .Width = 85
                        End If
                        .ReadOnly = True
                End Select
            End With
        Next
        With dgvMain
            .Columns("nummodule").DisplayIndex = 2
            .Columns("service").DisplayIndex = 3
            .Columns("etatporte").DisplayIndex = 4
            .Columns("serrure").DisplayIndex = 5
            .Columns("etattemp").DisplayIndex = 6
            .Columns("check").DisplayIndex = 7
            .Columns("savserrure").DisplayIndex = 8
            .Columns("test").DisplayIndex = 9
            .Columns("modelefrigo").DisplayIndex = 10
        End With
        'MAINFORM.WarningOfTroubleUpdate()
    End Sub
    Private Sub InitLabelView()
        Dim iIndxY As Integer = 15
        Dim lblProduct As Label
        For casier As Integer = 1 To MaxCountOfProducts
            lblProduct = New Label()
            lblProduct.AutoEllipsis = True
            lblProduct.Location = New Point(5, iIndxY)
            lblProduct.Name = "lblProductText" + casier.ToString()
            lblProduct.Size = New Size(116, 13)
            lblProduct.Text = ""
            lblProduct.TextAlign = ContentAlignment.TopRight
            iIndxY += 20
            grbProducts.Controls.Add(lblProduct)
        Next
        iIndxY = 15
        For casier As Integer = 1 To MaxCountOfProducts
            lblProduct = New Label()
            lblProduct.AutoEllipsis = True
            lblProduct.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            lblProduct.Location = New Point(125, iIndxY)
            lblProduct.Name = "lblProductValue" + casier.ToString()
            lblProduct.Size = New Size(145, 15)
            lblProduct.Text = ""
            lblProduct.TextAlign = ContentAlignment.TopLeft
            iIndxY += 20
            grbProducts.Controls.Add(lblProduct)
        Next
    End Sub

    Public Sub Initlangue()
        For i As Integer = 0 To dgvMain.Columns.Count - 1
            dgvMain.Columns(i).Visible = False
        Next
        dgvMain.Columns("e").HeaderText = ""
        dgvMain.Columns("numchambre").HeaderText = Trans(28)
        dgvMain.Columns("etatporte").HeaderText = Trans(29)
        dgvMain.Columns("serrure").HeaderText = Trans(31)
        dgvMain.Columns("etattemp").HeaderText = Trans(30)
        dgvMain.Columns("ouverture").HeaderText = Trans(44)
        dgvMain.Columns("status").HeaderText = Trans(45)
        dgvMain.Columns("nummodule").HeaderText = Trans(32)
        dgvMain.Columns("check").HeaderText = Trans(23)
        dgvMain.Columns("test").HeaderText = Trans(26)
        dgvMain.Columns("savserrure").HeaderText = "PMS status"
        dgvMain.Columns("dateremplissage").HeaderText = Trans(133)
        dgvMain.Columns("datecheckin").HeaderText = Trans(134)
        dgvMain.Columns("datecheckout").HeaderText = Trans(135)
        dgvMain.Columns("datelock").HeaderText = Trans(136)
        dgvMain.Columns("dateunlock").HeaderText = Trans(137)
        dgvMain.Columns("datemaintenance").HeaderText = Trans(138)
        dgvMain.Columns("dateanomalie").HeaderText = Trans(139)
        dgvMain.Columns("libre1").HeaderText = Trans(178)
        dgvMain.Columns("libre2").HeaderText = Trans(179)
        dgvMain.Columns("libre3").HeaderText = Trans(180)
        dgvMain.Columns("libre4").HeaderText = Trans(181)
        dgvMain.Columns("zone").HeaderText = Trans(127)
        dgvMain.Columns("numtelecommande").HeaderText = Trans(246)
        dgvMain.Columns("dateouvert").HeaderText = Trans(252)
        dgvMain.Columns("datefermer").HeaderText = Trans(253)

        dgvMain.Columns("service").HeaderText = Trans(328)

        For casier As Integer = 1 To MaxCountOfProducts
            dgvMain.Columns("c" + casier.ToString()).HeaderText = "Rack" + casier.ToString()
        Next

        dgvMain.Columns("modelefrigo").HeaderText = Trans(341)
        dgvMain.Columns("nbconso").HeaderText = Trans(342)
        dgvMain.Columns("aremplir").HeaderText = Trans(343)
        dgvMain.Columns("updateparamhomi").HeaderText = Trans(344)
        dgvMain.Columns("factureclient").HeaderText = Trans(345)
        dgvMain.Columns("tarif").HeaderText = Trans(346)



        dgvMain.Columns("e").Visible = True
        dgvMain.Columns("numchambre").Visible = True
        dgvMain.Columns("etatporte").Visible = True
        dgvMain.Columns("serrure").Visible = True
        dgvMain.Columns("etattemp").Visible = True
        dgvMain.Columns("ouverture").Visible = True
        dgvMain.Columns("status").Visible = True
        dgvMain.Columns("nummodule").Visible = True
        dgvMain.Columns("check").Visible = True
        dgvMain.Columns("test").Visible = True
        dgvMain.Columns("savserrure").Visible = True
        dgvMain.Columns("dateremplissage").Visible = True
        dgvMain.Columns("datecheckin").Visible = True
        dgvMain.Columns("datecheckout").Visible = True
        dgvMain.Columns("datelock").Visible = True
        dgvMain.Columns("dateunlock").Visible = True
        dgvMain.Columns("datemaintenance").Visible = True
        dgvMain.Columns("dateanomalie").Visible = True
        'dgvMain.Columns("libre1").Visible = True
        'dgvMain.Columns("libre2").Visible = True
        'dgvMain.Columns("libre3").Visible = True
        'dgvMain.Columns("libre4").Visible = True
        'dgvMain.Columns("zone").Visible = True
        dgvMain.Columns("numtelecommande").Visible = True
        dgvMain.Columns("dateouvert").Visible = True
        dgvMain.Columns("datefermer").Visible = True

        dgvMain.Columns("service").Visible = True
        'dg1.Columns("c1").Visible = True
        'dg1.Columns("c2").Visible = True
        'dg1.Columns("c3").Visible = True
        'dg1.Columns("c4").Visible = True
        'dg1.Columns("c5").Visible = True
        'dg1.Columns("c6").Visible = True
        'dg1.Columns("c7").Visible = True
        'dg1.Columns("c8").Visible = True
        'dg1.Columns("c9").Visible = True
        'dg1.Columns("c10").Visible = True
        'dg1.Columns("c11").Visible = True
        'dg1.Columns("c12").Visible = True

        'For casier As Integer = 1 To MaxCountOfProducts
        '    dgvMain.Columns("c" + casier.ToString()).Visible = True
        'Next
        dgvMain.Columns("modelefrigo").Visible = True
        dgvMain.Columns("nbconso").Visible = True
        dgvMain.Columns("aremplir").Visible = True
        dgvMain.Columns("updateparamhomi").Visible = True
        dgvMain.Columns("factureclient").Visible = True
        dgvMain.Columns("tarif").Visible = True

        rbAll.Text = Trans(49)
        rbCheckIn.Text = Trans(21)
        rbCheckOut.Text = Trans(22)
        rbLocked.Text = Trans(35)
        rbUnlocked.Text = Trans(36)
        rbMaintenance.Text = Trans(37)
        rbAnomaly.Text = Trans(20)
        GroupBox1.Text = Trans(154)
        gbtnCheckIn.Text = Trans(21)
        gbtnCheckOut.Text = Trans(22)
        GbtnUnlock.Text = Trans(25)
        gbtnLock.Text = Trans(24)
        gbtnTest.Text = Trans(26)
        gbtnPrint.Text = Trans(141)
        gbtnMaintenance.Text = Trans(27)
        gbtnUpdate.Text = Trans(189)
        GlassButton9.Text = Trans(4)
        gbtnEnvoice.Text = Trans(348)
        Label2.Text = Trans(48)
        Label3.Text = Trans(204)
        Label4.Text = Trans(205)
        Label6.Text = Trans(347)
        TabPage1.Text = Trans(81)
        TabPage2.Text = Trans(15)

        Label1.Text = ""
        Label7.Text = ""
        Label8.Text = Trans(16) + ":"
        Label9.Text = Trans(31) + ":"
        Label10.Text = Trans(17) + ":"
        Label11.Text = Trans(44) + ":"
        Label12.Text = Trans(342) + ":"
        Label13.Text = Trans(345) + ":"
        Label14.Text = Trans(133) + ":"
        Label15.Text = Trans(246) + ":"
        Label16.Text = Trans(134) + ":"
        Label17.Text = Trans(135) + ":"
        Label18.Text = Trans(136) + ":"
        Label19.Text = Trans(137) + ":"
        Label20.Text = Trans(252) + ":"
        Label21.Text = Trans(253) + ":"
        Dim lblProduct As Label
        For casier As Integer = 1 To MaxCountOfProducts
            lblProduct = grbProducts.Controls.Find("lblProductText" + casier.ToString(), True)(0)
            lblProduct.Text = "Rack " + casier.ToString() + ":"
            lblProduct = grbProducts.Controls.Find("lblProductValue" + casier.ToString(), True)(0)
            lblProduct.Text = ""
        Next
        'Label22.Text = trans(329) + ":"
        'Label23.Text = trans(330) + ":"
        'Label24.Text = trans(331) + ":"
        'Label25.Text = trans(332) + ":"
        'Label26.Text = trans(333) + ":"
        'Label27.Text = trans(334) + ":"
        'Label28.Text = trans(335) + ":"
        'Label29.Text = trans(336) + ":"
        'Label30.Text = trans(337) + ":"
        'Label31.Text = trans(338) + ":"
        'Label32.Text = trans(339) + ":"
        'Label33.Text = trans(340) + ":"
        Label34.Text = ""
        Label35.Text = ""
        Label36.Text = ""
        Label37.Text = ""
        Label38.Text = ""
        Label39.Text = ""
        Label40.Text = ""
        Label41.Text = ""
        Label42.Text = ""
        Label43.Text = ""
        Label44.Text = ""
        Label45.Text = ""
        Label46.Text = ""
        Label47.Text = ""
        'Label48.Text = ""
        'Label49.Text = ""
        'Label50.Text = ""
        'Label51.Text = ""
        'Label52.Text = ""
        'Label53.Text = ""
        'Label54.Text = ""
        'Label55.Text = ""
        'Label56.Text = ""
        'Label57.Text = ""
        'Label58.Text = ""
        'Label59.Text = ""
        Label60.Text = ""

        ViewByModele.GlassButton9.Text = Trans(4)


    End Sub
    Private Sub Inittable()
        Maintable.Columns.Add("e", Type.GetType("System.String")) '0
        Maintable.Columns.Add("numchambre", Type.GetType("System.String"))
        Maintable.Columns.Add("etatporte", Type.GetType("System.String"))
        Maintable.Columns.Add("serrure", Type.GetType("System.String"))
        Maintable.Columns.Add("etattemp", Type.GetType("System.String"))
        Maintable.Columns.Add("signal", Type.GetType("System.String"))
        Maintable.Columns.Add("check", Type.GetType("System.String"))
        Maintable.Columns.Add("ouverture", GetType(Int32))
        Maintable.Columns.Add("status", Type.GetType("System.String"))
        Maintable.Columns.Add("nummodule", Type.GetType("System.String"))
        Maintable.Columns.Add("savserrure", Type.GetType("System.String")) '10
        Maintable.Columns.Add("test", Type.GetType("System.String"))
        Maintable.Columns.Add("dateex", Type.GetType("System.String"))
        Maintable.Columns.Add("dateremplissage", Type.GetType("System.String"))
        Maintable.Columns.Add("datecheckin", Type.GetType("System.String"))
        Maintable.Columns.Add("datecheckout", Type.GetType("System.String"))
        Maintable.Columns.Add("datelock", Type.GetType("System.String"))
        Maintable.Columns.Add("dateunlock", Type.GetType("System.String"))
        Maintable.Columns.Add("datemaintenance", Type.GetType("System.String"))
        Maintable.Columns.Add("dateanomalie", Type.GetType("System.String"))
        Maintable.Columns.Add("libre1", GetType(Int32))                      '20
        Maintable.Columns.Add("libre2", GetType(Int32))
        Maintable.Columns.Add("libre3", GetType(Int32))
        Maintable.Columns.Add("libre4", GetType(Int32))
        Maintable.Columns.Add("zone", GetType(Int32))
        Maintable.Columns.Add("nummessage", Type.GetType("System.String"))  '25
        Maintable.Columns.Add("messencours", Type.GetType("System.String"))
        Maintable.Columns.Add("messageattente", Type.GetType("System.String"))
        Maintable.Columns.Add("numtelecommande", Type.GetType("System.String"))
        Maintable.Columns.Add("dateouvert", Type.GetType("System.String"))
        Maintable.Columns.Add("datefermer", Type.GetType("System.String"))
        Maintable.Columns.Add("remplissage", GetType(Int32))                   '30
        Maintable.Columns.Add("maintenance", GetType(Int32))
        Maintable.Columns.Add("service", GetType(Int32))

        For casier As Integer = 1 To MaxCountOfProducts
            Maintable.Columns.Add("c" + casier.ToString(), GetType(Int32))
        Next
        'maintable.Columns.Add("c1", GetType(Int32))
        'maintable.Columns.Add("c2", GetType(Int32))
        'maintable.Columns.Add("c3", GetType(Int32))
        'maintable.Columns.Add("c4", GetType(Int32))
        'maintable.Columns.Add("c5", GetType(Int32))
        'maintable.Columns.Add("c6", GetType(Int32))
        'maintable.Columns.Add("c7", GetType(Int32))
        'maintable.Columns.Add("c8", GetType(Int32))                               '40
        'maintable.Columns.Add("c9", GetType(Int32))
        'maintable.Columns.Add("c10", GetType(Int32))
        'maintable.Columns.Add("c11", GetType(Int32))
        'maintable.Columns.Add("c12", GetType(Int32))

        '---DEZ for Dry 4-8 ---------------------------------------------------------
        'maintable.Columns.Add("c13", GetType(Int32))
        'maintable.Columns.Add("c14", GetType(Int32))
        'maintable.Columns.Add("c15", GetType(Int32))
        'maintable.Columns.Add("c16", GetType(Int32))
        '----------------------------------------------------------------------------
        Maintable.Columns.Add("modelefrigo", Type.GetType("System.String"))
        Maintable.Columns.Add("nbconso", GetType(Int32))
        Maintable.Columns.Add("aremplir", GetType(Int32))
        Maintable.Columns.Add("updateparamhomi", GetType(Int32))
        Maintable.Columns.Add("factureclient", Type.GetType("System.String"))
        Maintable.Columns.Add("tarif", GetType(Int32))
        'DEZ 23/06/10 add swr--------------------------------------------------------
        Maintable.Columns.Add("swr", GetType(String))
        '----------------------------------------------------------------------------
        Maintable.Columns.Add("coffre", GetType(Int32))
        Dv1.Table = Maintable
        Dv.Table = Maintable
        Dvch.Table = Dv1.Table
        Dv.Sort = "nummodule"
        Dv1.Sort = "numchambre"
        Dvch.Sort = "numchambre"
        Dv1.RowFilter = "numchambre Not Like 'R*' and " + "test<>'" + Trans(37) + "'"
        lblFilterNane.Text = Trans(49)
        dgvMain.DataSource = Dv1
        '      TextBox2.DataBindings.Add("Text", dv1, "numchambre")
        '     TextBox2.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList
        DtMomentaryPickUp.Columns.Add("nummodule", GetType(Int32))
        For casier As Integer = 1 To MaxCountOfProducts
            DtMomentaryPickUp.Columns.Add("c" + casier.ToString(), GetType(Int32))
            DtMomentaryPickUp.Columns.Add("dmp" + casier.ToString(), GetType(String))
        Next
        '--------------------------------------------------------------------
        DtMomentaryPickUp.PrimaryKey = New DataColumn() {DtMomentaryPickUp.Columns("nummodule")}

    End Sub

    Private Shared Sub Initapplication()
        'mise a jour logiciel
        Dim fe3 As New FileInfo(Application.StartupPath + "\Param.ini")

        If Not fe3.Exists Then
            FileCopy(Application.StartupPath + "\ParamTemp.ini", Application.StartupPath + "\Param.ini")
        End If

        'jour = Microsoft.VisualBasic.Day(Now)

        'init utilisateur

    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbAnomaly.CheckedChanged, rbMaintenance.CheckedChanged, rbUnlocked.CheckedChanged, rbLocked.CheckedChanged, rbCheckOut.CheckedChanged, rbCheckIn.CheckedChanged, rbAll.CheckedChanged, rbRent.CheckedChanged
        If Not Visible Then
            Exit Sub
        End If

        Select Case True
            Case rbAll.Checked
                Dv1.RowFilter = String.Format("numchambre <> 'R*' and test <> '{0}'", Trans(37))
                lblFilterNane.Text = Trans(49)
            Case rbCheckIn.Checked
                Dv1.RowFilter = String.Format("numchambre Not Like 'R*' and {0} = '{1}' and test <> '{2}'", "check", Trans(21), Trans(37))
                lblFilterNane.Text = Trans(21)
            Case rbCheckOut.Checked
                Dv1.RowFilter = String.Format("numchambre Not Like 'R*' and {0} = '{1}' and test <> '{2}'", "check", Trans(22), Trans(37))
                lblFilterNane.Text = Trans(22)
            Case rbLocked.Checked
                Dv1.RowFilter = String.Format("numchambre Not Like 'R*' and {0} = '{1}' and test <> '{2}'", "serrure", Trans(35), Trans(37))
                lblFilterNane.Text = Trans(35)
            Case rbUnlocked.Checked
                Dv1.RowFilter = String.Format("numchambre Not Like 'R*' and {0} = '{1}' and test <> '{2}'", "serrure", Trans(36), Trans(37))
                lblFilterNane.Text = Trans(36)
            Case rbMaintenance.Checked
                Dv1.RowFilter = String.Format("test = '{0}'", Trans(37))
                lblFilterNane.Text = Trans(37)
            Case rbAnomaly.Checked
                Dv1.RowFilter = String.Format("test <> '{0}' and test <> '{1}' and test <> '{2}' and test <> '{3}'", Trans(97), Trans(37), Trans(26), Trans(43))
                lblFilterNane.Text = Trans(20)
            Case rbRent.Checked
                Dv1.RowFilter = String.Format("test ='{0}'", Trans(43))
                lblFilterNane.Text = Trans(43)
        End Select


    End Sub
    Private Sub Dv1ListChanged(sender As Object, e As ListChangedEventArgs)
        Try
            Label2.Text = Trans(48)
            TextBox1.Text = Str(Dv1.Count)
            ' facture.TextBox1.Text = Str(dv1.Count)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub gbtnUpdate_Click(sender As Object, e As EventArgs) Handles gbtnUpdate.Click
        MAINFORM.Actualiser()
        'Dim rb As RadioButton = GroupBox1.Controls.OfType(Of RadioButton).FirstOrDefault(Function(x) x.Checked = True)
        'Where item.GetType() Is GetType(RadioButton) AndAlso CType(item, RadioButton).Checked Select item)
        RadioButton_CheckedChanged(Nothing, Nothing)
        'Dim qry = From item As Control In ctls _
        '    Where item.ID = "ButtonOK" _
        'Select item


    End Sub

    Private Sub GlassButton0_Click(sender As Object, e As EventArgs) Handles gbtnCheckIn.Click, gbtnMaintenance.Click, gbtnTest.Click, gbtnLock.Click, GbtnUnlock.Click, gbtnCheckOut.Click, gbtnRent.Click
        Dim i As Integer
        If Bufemis.Items.Count > 0 Then
            MessageBox.Show(Trans(198), Trans(81), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Dim tabsel(Dv1.Count) As Boolean
        For i = 0 To Dv1.Count - 1
            tabsel(i) = dgvMain.Rows(i).Selected
            dgvMain.Rows(i).Selected = False
        Next
        Select Case sender.tag
            Case "1" 'check in

                For i = Dv1.Count - 1 To 0 Step -1
                    If tabsel(i) = True Then
                        If Dv1(i)("check") = Trans(22) Then
                            Dv1(i)("e") = "*"
                            AddEmis(Dv1(i)("nummodule"), "CHECKIN")
                        End If
                    End If
                Next
            Case "2" 'check out
                For i = Dv1.Count - 1 To 0 Step -1
                    If tabsel(i) = True Then
                        Dv1(i)("e") = "*"
                        AddEmis(Dv1(i)("nummodule"), "CHECKOUT")
                    End If
                Next
            Case "3" 'lock
                For i = Dv1.Count - 1 To 0 Step -1
                    If tabsel(i) = True Then
                        Dv1(i)("e") = "*"
                        AddEmis(Dv1(i)("nummodule"), "LOCK")
                    End If
                Next
            Case "4" 'unlock
                For i = Dv1.Count - 1 To 0 Step -1
                    If tabsel(i) = True Then
                        Dv1(i)("e") = "*"
                        AddEmis(Dv1(i)("nummodule"), "UNLOCK")
                    End If
                Next
            Case "5" 'test
                For i = Dv1.Count - 1 To 0 Step -1
                    If tabsel(i) = True Then
                        Dv1(i)("e") = "*"
                        AddEmis(Dv1(i)("nummodule"), "TEST")
                    End If
                Next
            Case "6" 'maintenance
                For i = Dv1.Count - 1 To 0 Step -1
                    If tabsel(i) = True Then
                        Dv1(i)("e") = "*"
                        AddEmis(Dv1(i)("nummodule"), "MAINTENANCE")

                    End If
                Next
            Case "7" 'Rent
                For i = Dv1.Count - 1 To 0 Step -1
                    If tabsel(i) = True Then
                        Dv1(i)("e") = "*"
                        AddEmis(Dv1(i)("nummodule"), "RENT")
                    End If
                Next
        End Select

    End Sub

    Public Sub AddEmis(nummodule As Integer, s As String)
        bufemis.Items.Add(s + "|" + CStr(nummodule))
        libre = True
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles tbFind.KeyDown
        If e.KeyCode = (13) Then
            Dim i As Integer = dvch.Find(tbFind.Text)
            If i >= 0 Then
                dgvMain.CurrentCell = dgvMain.Item(0, i)
            End If
            tbFind.SelectAll()
        End If
    End Sub

    Private Sub tbFind_MouseDown(sender As Object, e As MouseEventArgs) Handles tbFind.MouseDown
        tbFind.SelectAll()
        tbFind.AutoCompleteCustomSource.Clear()
        For i As Integer = 0 To dgvMain.Rows.Count - 1
            tbFind.AutoCompleteCustomSource.Add(dgvMain.Item("numchambre", i).Value)
        Next
    End Sub
    'search
    Private Sub gbtnFind_Click(sender As Object, e As EventArgs) Handles gbtnFind.Click
        'Try
        '    For j As Integer = 0 To dgvMain.Rows.Count - 1
        '        If dgvMain.Item(1, j).Value = TextBox2.Text Then
        '            dgvMain.CurrentCell = dgvMain.Item(0, j)
        '            Exit For
        '        End If
        '    Next
        'Catch ex As Exception

        'End Try

        Dim currManager As CurrencyManager = CType(dgvMain.BindingContext(dgvMain.DataSource), CurrencyManager)
        Dim dv As DataView = CType(currManager.List, DataView)
        If tbFind.Text.ToString.Length = 0 OrElse currManager.Count = 0 Then
            Exit Sub
        End If

        dv.Sort = "numchambre"

        Dim pos As Integer
        pos = dv.Find(tbFind.Text.ToString())
        If pos > -1 Then
            currManager.Position = pos
            dgvMain.CurrentCell = dgvMain.CurrentRow.Cells(dv.Sort)
            dgvMain.CurrentRow.Selected = True
            dgvMain_RowEnterPerfomeAction()
        Else
            MessageBox.Show(String.Format("{0} {1} not found", dgvMain.Columns("numchambre").HeaderText, tbFind.Text.ToString()))
        End If


        'Dim i As Integer = dvch.Find(TextBox2.Text)
        'If i >= 0 Then
        '    dg1.CurrentCell = dg1.Item(0, i)
        'End If
        tbFind.SelectAll()
    End Sub

    Private Sub gbtnEnvoice_Click(sender As Object, e As EventArgs) Handles gbtnEnvoice.Click
        Mainform.tabMain.TabPages(facture).Select()
    End Sub


    Private Sub table_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            'Dim rb = (From item As Control In GroupBox1.Controls Where item.GetType() Is GetType(RadioButton) AndAlso CType(item, RadioButton).Checked Select item).ToList()
            RadioButton_CheckedChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub gbtnPrint_Click(sender As Object, e As EventArgs) Handles gbtnPrint.Click
        If dgvMain.SelectedRows(0).Index < 0 Then Exit Sub
        Try
            facture.Label7.Text = ""
            facture.Label8.Text = ""
            facture.Label1.Text = Trans(15) + facture.dg1.CurrentRow.Cells("numchambre").Value
            facture.Label3.Text = Trans(46) + ":  " + facture.dg1.CurrentRow.Cells("datecheckin").Value
            facture.rtf.Items.Clear()
            facture.nummoduleaff = facture.dg1.CurrentRow.Cells("nummodule").Value
            AddEmis(facture.dg1.CurrentRow.Cells("nummodule").Value, "FACTURE")

        Catch ex As Exception
            facture.Label7.Text = ""
            facture.Label8.Text = ""
            facture.Label1.Text = Trans(15)
            facture.Label3.Text = Trans(46)
            facture.rtf.Items.Clear()
            facture.nummoduleaff = 0
        End Try
        Mainform.SpinningProgress1.AutoIncrement = True
        Do
            Application.DoEvents()
            Thread.Sleep(20)
        Loop Until Mainform.SpinningProgress1.AutoIncrement = False
        facture.GlassButton5_Click(Nothing, Nothing)
    End Sub
    Private Sub dgvMain_RowEnterPerfomeAction()
        If dgvMain.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FillCurrentRoomInfo()
        If tabcntrlExtendedRoomActivity.SelectedIndex = 1 Then
            FillCurrentGuestHistory()
        End If
    End Sub
    Private Sub dgvMain_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.RowEnter
        dgvMain_RowEnterPerfomeAction()
    End Sub
    Private Sub FillCurrentRoomInfo() 'left tab(0)

        If dgvMain.Rows.Count > 0 AndAlso dgvMain.Columns.Count > 0 Then
            Dim nummodule As Integer = dgvMain.SelectedRows(0).Cells("nummodule").Value
            Label1.Text = dgvMain.SelectedRows(0).Cells("numchambre").Value
            Label7.Text = dgvMain.SelectedRows(0).Cells("check").Value
            Label34.Text = dgvMain.SelectedRows(0).Cells("etatporte").Value
            Label35.Text = dgvMain.SelectedRows(0).Cells("serrure").Value
            Label36.Text = dgvMain.SelectedRows(0).Cells("etattemp").Value
            Label37.Text = dgvMain.SelectedRows(0).Cells("ouverture").Value
            Label38.Text = dgvMain.SelectedRows(0).Cells("nbconso").Value
            Label39.Text = dgvMain.SelectedRows(0).Cells("factureclient").Value
            Label40.Text = dgvMain.SelectedRows(0).Cells("dateremplissage").Value
            Label41.Text = dgvMain.SelectedRows(0).Cells("numtelecommande").Value
            Label42.Text = dgvMain.SelectedRows(0).Cells("datecheckin").Value
            Label43.Text = dgvMain.SelectedRows(0).Cells("datecheckout").Value
            Label44.Text = dgvMain.SelectedRows(0).Cells("datelock").Value
            Label45.Text = dgvMain.SelectedRows(0).Cells("dateunlock").Value
            Label46.Text = dgvMain.SelectedRows(0).Cells("datefermer").Value
            Label47.Text = dgvMain.SelectedRows(0).Cells("dateouvert").Value
            Dim lblProduct As Label
            For casier As Integer = 1 To MaxCountOfProducts
                'lblProduct = New Label()
                lblProduct = Me.grbProducts.Controls.Find("lblProductText" + casier.ToString(), True)(0)
                lblProduct.Text = journalrefill.nomproduit(nummodule, casier).nom
                'lblProduct = New Label()
                lblProduct = Me.grbProducts.Controls.Find("lblProductValue" + casier.ToString(), True)(0)
                lblProduct.Text = dgvMain.SelectedRows(0).Cells("c" + casier.ToString()).Value
            Next

        End If
    End Sub
    Private Sub FillCurrentGuestHistory() 'left tab(1)
        rt.Clear()
        Try
            Dim nummodule As Integer = dgvMain.SelectedRows(0).Cells("nummodule").Value
            AddEmis(0, "JOURNALHOMI|" + nummodule.ToString)
            Label60.Text = MAINFORM.FieldAccess(nummodule, "numchambre").ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dg1_MouseUp(sender As Object, e As MouseEventArgs) 'Handles dgvMain.MouseUp
        FillCurrentGuestHistory()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabcntrlExtendedRoomActivity.SelectedIndexChanged
        If tabcntrlExtendedRoomActivity.SelectedIndex = 1 Then
            'dg1_MouseUp(Nothing, Nothing)
            FillCurrentGuestHistory()
        End If

    End Sub
    Private Sub dg1_SelectionChanged(sender As Object, e As EventArgs) 'Handles dgvMain.SelectionChanged
        Try
            If dgvMain.SelectedRows.Count = 0 Then
                Exit Sub
            End If
            If dgvMain.Rows.Count > 0 And dgvMain.Columns.Count > 0 Then
                Dim nummodule As Integer = dgvMain.SelectedRows(0).Cells("nummodule").Value
                If tabcntrlExtendedRoomActivity.SelectedIndex = 0 Then
                    Label1.Text = dgvMain.SelectedRows(0).Cells("numchambre").Value
                    Label7.Text = dgvMain.SelectedRows(0).Cells("check").Value
                    Label34.Text = dgvMain.SelectedRows(0).Cells("etatporte").Value
                    Label35.Text = dgvMain.SelectedRows(0).Cells("serrure").Value
                    Label36.Text = dgvMain.SelectedRows(0).Cells("etattemp").Value
                    Label37.Text = dgvMain.SelectedRows(0).Cells("ouverture").Value
                    Label38.Text = dgvMain.SelectedRows(0).Cells("nbconso").Value
                    Label39.Text = dgvMain.SelectedRows(0).Cells("factureclient").Value
                    Label40.Text = dgvMain.SelectedRows(0).Cells("dateremplissage").Value
                    Label41.Text = dgvMain.SelectedRows(0).Cells("numtelecommande").Value
                    Label42.Text = dgvMain.SelectedRows(0).Cells("datecheckin").Value
                    Label43.Text = dgvMain.SelectedRows(0).Cells("datecheckout").Value
                    Label44.Text = dgvMain.SelectedRows(0).Cells("datelock").Value
                    Label45.Text = dgvMain.SelectedRows(0).Cells("dateunlock").Value
                    Label46.Text = dgvMain.SelectedRows(0).Cells("datefermer").Value
                    Label47.Text = dgvMain.SelectedRows(0).Cells("dateouvert").Value
                    Dim lblProduct As Label
                    For casier As Integer = 1 To MaxCountOfProducts
                        'lblProduct = New Label()
                        lblProduct = grbProducts.Controls.Find("lblProductText" + casier.ToString(), True)(0)
                        lblProduct.Text = journalrefill.nomproduit(nummodule, casier).nom
                        'lblProduct = New Label()
                        lblProduct = grbProducts.Controls.Find("lblProductValue" + casier.ToString(), True)(0)
                        lblProduct.Text = dgvMain.SelectedRows(0).Cells("c" + casier.ToString()).Value
                    Next
                Else
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub Traitejournal(data As String)
        Try
            Dim s As String() = data.Split(";")
            Dim c As Color = Color.Black
            Dim r As String = ""
            Select Case s(0)
                Case "JOURNAL|open"
                    '  MsgBox(convdate(s(2)))
                    '  MsgBox(convdate(s(3)))
                    Dim db As Integer = Convdate(s(2))
                    Dim df As Integer = Convdate(s(3))
                    Dim tmp As String = (df - db).ToString
                    c = Color.DarkBlue
                    r = Trans(51) + ": " + s(1) + "   " + Trans(284) + ": " + tmp + "s"
                Case "JOURNAL|lock"
                    c = Color.DarkRed
                    r = Trans(35) + ": " + s(1) + " - " + s(2)
                Case "JOURNAL|unlock"
                    c = Color.DarkGreen
                    r = Trans(36) + ": " + s(1) + " - " + s(2)
                Case "JOURNAL|checkin"
                    c = Color.DarkGreen
                    r = Trans(21) + ": " + s(1)
                Case "JOURNAL|checkout"
                    c = Color.DarkRed
                    r = Trans(22) + ": " + s(1)
                Case "JOURNAL|telecommande"
                    c = Color.DarkOrchid
                    r = Trans(248) + ": " + s(1) + " - " + s(2)
                Case "JOURNAL|refill"
                    c = Color.DarkSeaGreen
                    r = Trans(55) + ": " + s(1)
                Case "JOURNAL|facture"
                    c = Color.DarkOrange
                    r = Trans(348) + ": " + s(1) + "   " + s(2) + "   " + s(3)
                Case "JOURNAL|move"
                    c = Color.Black
                    r = s(1)
            End Select
            rt.SelectionStart = rt.TextLength
            rt.SelectionLength = 0
            rt.SelectionColor = c
            rt.SelectedText = r + vbCrLf
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Finjournal()
        rt.ScrollToCaret()

    End Sub

    Private Shared Function Convdate(s As String) As Integer
        Try
            Dim t As String() = s.Split(" ")
            Dim tj As String() = t(0).Split("/")
            Dim th As String() = t(1).Split(":")
            Dim d As Integer = (CInt(th(0)) * 3600) + (CInt(th(1)) * 60) + CInt(th(2))
            Return d

        Catch ex As Exception
        End Try
    End Function

    Private Sub dg1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvMain.MouseDoubleClick
        'Dim frm As Form = New ViewByModele(dg1.SelectedRows(0))

        'frm.Show()
    End Sub

    Private Sub GlassButton11_Click(sender As Object, e As EventArgs) Handles gbtnExtendetView.Click
        ViewByModele.InitView()
        If dgvMain.SelectedRows.Count > 0 Then
            ViewByModele.SetParams(dgvMain.SelectedRows(0))
        Else
            If dgvMain.Rows.Count > 0 Then
                ViewByModele.SetParams(dgvMain.Rows(0))
            End If
        End If

        MAINFORM.tabMain.TabPages(ViewByModele).Select()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub dgvMain_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMain.CellFormatting

        Dim currRow As DataGridViewRow = CType(sender, DataGridView).Rows(e.RowIndex)
        Select Case dgvMain.Columns(e.ColumnIndex).Name.ToLower()
            Case "test"
                Select Case currRow.Cells("test").Value.ToString().ToLower()
                    Case Trans(208).ToLower()
                        Dim ts As TimeSpan = New TimeSpan(1000000000)
                        Try
                            ts = DateTime.Now - DateTime.Parse(currRow.Cells("dateanomalie").Value)
                        Catch ex As Exception

                        End Try
                        Dim backGroundColor As Color = Color.Red
                        If ts.TotalHours > 3.0 Then
                            backGroundColor = Color.Purple
                        End If
                        e.CellStyle.BackColor = backGroundColor
                    Case Trans(43).ToLower()
                        e.CellStyle.BackColor = Color.DarkCyan
                End Select
                If currRow.Cells("test").Value = Trans(208) Then 'And dgvMain.Columns("test").Index = dgvMain.CurrentCell.ColumnIndex Then
                    Dim ts As TimeSpan = New TimeSpan(1000000000)
                    Try
                        ts = DateTime.Now - DateTime.Parse(currRow.Cells("dateanomalie").Value)
                    Catch ex As Exception

                    End Try
                    Dim backGroundColor As Color = Color.Red
                    If ts.TotalHours > 3.0 Then
                        backGroundColor = Color.Purple
                    End If
                    e.CellStyle.BackColor = backGroundColor
                End If
            Case "etatporte"
                If currRow.Cells("etatporte").Value = Trans(51) Then 'And dgvMain.Columns("test").Index = dgvMain.CurrentCell.ColumnIndex Then
                    Dim ts As TimeSpan = New TimeSpan(1000000000)
                    Try
                        ts = DateTime.Now - DateTime.Parse(currRow.Cells("dateouvert").Value)
                    Catch ex As Exception

                    End Try
                    Dim backGroundColor As Color = e.CellStyle.BackColor '= Color.Red
                    If ts.TotalMinutes > 5.0 Then
                        backGroundColor = Color.Red
                    End If
                    If ts.TotalHours > 3.0 Then
                        backGroundColor = Color.Purple
                    End If
                    e.CellStyle.BackColor = backGroundColor
                End If
            Case "savserrure"
                Dim backGroundColor As Color = e.CellStyle.BackColor
                Select Case currRow.Cells("savserrure").Value.ToString().ToLower()
                    Case "check in"
                        backGroundColor = Color.DarkGreen
                        'Case "check out"
                        '    backGroundColor = Color.Red
                    Case "check in lock"
                        backGroundColor = Color.MediumVioletRed
                    Case "lock"
                        backGroundColor = Color.Violet
                    Case "unlock"
                        backGroundColor = Color.DarkGreen
                    Case "not set"
                        If Not currRow.Cells("numchambre").Value.ToString().ToLower().StartsWith("r") Then
                            backGroundColor = Color.LightSlateGray
                        End If

                End Select
                e.CellStyle.BackColor = backGroundColor

        End Select


    End Sub
    'Private _bIsWarninigExist As Boolean = False
    'Private WithEvents bgErr As BackgroundWorker

    'Private Sub ConErrAndSWErr_Tick(sender As Object, e As EventArgs) Handles ConErrAndSWErr.Tick
    '    If Maintable.Rows.Count = 0 Then
    '        Return
    '    End If
    '    If ConErrAndSWErr.Interval = 100 Then
    '        ConErrAndSWErr.Interval = 3600000
    '    End If

    '    Dim countOfConnErr As Integer = (From row In Maintable.Rows Where row("test") = Trans(208) Select row).Count()
    '    Dim countOfSwErr As Integer = (From row In Maintable.Rows Where row("service") = 1 Select row).Count()
    '    'Dim aa As Integer = maintable.AsEnumerable.Where(Function(row) row("test") = trans(208)).Count()
    '    Dim information As String() = Informationinterface.rtbInformationView.Text.Split(Chr(9))
    '    Dim countOfPostingFromChkOut As Integer = information.Count(Function(str) str.Contains("Posting from 'Check Out' room"))

    '    'For Each str As String In information
    '    '    If str.Contains("Posting from 'Check Out' room") Then
    '    '        countOfPostingFromChkOut += 1
    '    '    End If
    '    'Next

    '    If (countOfConnErr > 0 OrElse countOfSwErr > 0 OrElse countOfPostingFromChkOut > 0) AndAlso _bIsWarninigExist = False Then
    '        _bIsWarninigExist = True
    '        bgErr = New BackgroundWorker()
    '        bgErr.RunWorkerAsync(countOfConnErr.ToString() + "|" + countOfSwErr.ToString() + "|" + countOfPostingFromChkOut.ToString())
    '    End If
    'End Sub
    'Private Sub TestWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgErr.DoWork
    '    e.Result = e.Argument
    'End Sub
    'Private Sub TestWorker_DoWork(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgErr.RunWorkerCompleted
    '    Dim arrCountofErrors() As String = e.Result.ToString().Split("|")
    '    Dim formatStr As String = Trans(20) + Environment.NewLine + Trans(208) + " =>{0}" + Environment.NewLine() + Trans(436) + " =>{1}" + _
    '    Environment.NewLine + "Posting from 'Check Out' room =>{2}"
    '    MessageBox.Show(Me, String.Format(formatStr, arrCountofErrors(0), arrCountofErrors(1), arrCountofErrors(2)), _
    '                    "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, Nothing, 0)
    '    _bIsWarninigExist = False
    'End Sub



End Class