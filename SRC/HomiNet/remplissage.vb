
Imports System.Drawing.Printing
Imports System.Threading

Public Class Remplissage
    Public ReadOnly Dvr As New DataView
    ReadOnly _sav(8) As Object

    Public Structure Stockcasier
        Dim Nom As String
        Dim Max As Integer
    End Structure
    Dim _queryAlarm
    Dim _conditionFrom As Byte = 0
    Dim _conditionTo As Byte = 3
    Dim _setTypeOfBar() As Integer

    Private Sub remplissage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initlangue()
        Dvr.Table = Maintable
        Dvr.Sort = "numchambre"
        cmbExtension.Items.AddRange(New Object() {New typeOfBar(1, "All"), New typeOfBar(2, "Homi336/330"), New typeOfBar(3, "Homi226")})
        cmbExtension.SelectedIndex = 0
        SetExtPanelView(configuration.chkbExtReport.Checked)
    End Sub

    Private Shared Function GetDefaultPrinterName() As String
        Dim oPs As New PrinterSettings

        Try
            GetDefaultPrinterName = oPs.PrinterName
        Catch ex As Exception
            GetDefaultPrinterName = ""
        Finally
            oPs = Nothing
        End Try
    End Function

    Private Shared Function GetListOfPrinters() As List(Of String)
        GetListOfPrinters = New List(Of String)
        Try
            For Each printer As String In PrinterSettings.InstalledPrinters
                GetListOfPrinters.Add(printer)
            Next
        Catch ex As Exception

        End Try
    End Function

    Public Sub Initlangue()
        lblHeader.Text = Trans(41)
        lblFooter.Text = Trans(48)
        GroupBox1.Text = Trans(378)
        GroupBox2.Text = Trans(381)
        GroupBox3.Text = Trans(394)
        rbtnAlarm1.Text = Trans(379)
        rbtnAlarm2.Text = Trans(380)
        rbtnAll.Text = Trans(382)
        rbtnLimitTo.Text = Trans(383)
        rbtnRoomN.Text = Trans(28)
        rbtnOutOfday.Text = Trans(395)
        rbtnTotalStock.Text = "Total rooms stock" 'trans(451)
        gbtnPrint.Text = Trans(141)
        CheckBox1.Text = Trans(385)
        cmbRefill.Items.Clear()


        'For i As Integer = 0 To Printing.PrinterSettings.InstalledPrinters.Count - 1
        '    imprimante.Items.Add(Printing.PrinterSettings.InstalledPrinters.Item(i))
        'Next
        cmbRefill.Items.AddRange(GetListOfPrinters().ToArray())

        Try
            Dim usedPrinter As String = LireINI("imprimante", "remplissage")
            If GetListOfPrinters().Contains(usedPrinter) Then
                cmbRefill.Text = usedPrinter
            Else
                cmbRefill.Text = GetDefaultPrinterName()
            End If
            'imprimante.Text = LireINI("imprimante", "remplissage")
            CheckBox1.Checked = LireINI("imprimante", "remplissagepaysage")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InitcmbFromcmbTo()
        cmbFrom.Items.Clear()
        cmbTo.Items.Clear()
        For i As Integer = 0 To _queryAlarm.Count - 1 'dvr.Count - 1
            'cb1.Items.Add(dvr(i)("numchambre"))
            'cb2.Items.Add(dvr(i)("numchambre"))
            cmbFrom.Items.Add(_queryAlarm(i).maint("numchambre"))
            cmbTo.Items.Add(_queryAlarm(i).maint("numchambre"))
        Next
        If rbtnRoomN.Checked = True Then
            Try
                cmbFrom.SelectedIndex = 0
                cmbTo.SelectedIndex = cmbTo.Items.Count - 1
            Catch ex As Exception
            End Try
        End If

    End Sub
    Private Sub AlarmPerformClickAction(sender As Object)
        Dim rdbtnAlarm As RadioButton = CType(sender, RadioButton)
        Dim iAlarm As Integer = 0
        If rdbtnAlarm.Checked = True And Me.Visible = True Then
            Select Case rdbtnAlarm.Name
                Case "rbtnAlarm1"
                    iAlarm = 1
                    Dvr.RowFilter = String.Format("(aremplir='1' or aremplir='3') and (test<>'{0}' and test<>'{1}') and numchambre Not Like 'R*'", Trans(37), Trans(43))
                    'Dvr.RowFilter = "(aremplir='1' or aremplir='3') and (test<>'" + Trans(37) + "' or test<>'" + Trans(43) + "') and numchambre Not Like 'R*'"
                Case "rbtnAlarm2"
                    iAlarm = 2
                    Dvr.RowFilter = String.Format("aremplir<>'0' and (test<>'{0}' and test<>'{1}') and numchambre Not Like 'R*'", Trans(37), Trans(43))
                    'Dvr.RowFilter = "(aremplir='1' or aremplir='2' or aremplir='3') and test<>'" + Trans(37) + "' and numchambre Not Like 'R*'"
            End Select
            Query(iAlarm)
            InitcmbFromcmbTo()
            calculremplissage(iAlarm)
        End If
    End Sub
    Private Sub rdbtAlarm_ChekedChanged(sender As Object, e As EventArgs) Handles rbtnAlarm2.Click, rbtnAlarm1.Click
        AlarmPerformClickAction(sender)
    End Sub

    Private Sub rbtnAlarm1_CheckedChanged(sender As Object, e As EventArgs)
        If rbtnAlarm1.Checked = True And Me.Visible = True Then
            lblHeader.Text = Trans(41)
            'dvr.RowFilter = "aremplir='1' and " + "test<>'" + trans(37) + "' and numchambre<>'R*" + "' or " + "aremplir='3' and " + "test<>'" + trans(37) + "' and numchambre<>'R*" + "'"
            Dvr.RowFilter = String.Format("(aremplir='1' or aremplir='3') and (test<>'{0}' and test<>'{1}') and numchambre Not Like 'R*'", Trans(37), Trans(43))
            'Dvr.RowFilter = "(aremplir='1' or aremplir='3') and test<>'" + Trans(37) + "' and numchambre Not Like 'R*'"
            Query(1)
            InitcmbFromcmbTo()
            calculremplissage(1)
        End If
        'DEZ: move calcul in IF  20/05/10
    End Sub
    Private Sub rbtnAlarm2_CheckedChanged(sender As Object, e As EventArgs)
        If rbtnAlarm2.Checked = True And Me.Visible = True Then
            lblHeader.Text = Trans(41)
            'dvr.RowFilter = "aremplir='2' and " + "test<>'" + trans(37) + "' and numchambre<>'R*" + "' or " + "aremplir='1' and " + "test<>'" + trans(37) + "' and numchambre<>'R*" + "' or " + "aremplir='3' and " + "test<>'" + trans(37) + "' and numchambre<>'R*" + "'"
            Dvr.RowFilter = String.Format("aremplir<>'0' and (test<>'{0}' and test<>'{1}') and numchambre Not Like 'R*'", Trans(37), Trans(43))
            'Dvr.RowFilter = "(aremplir='1' or aremplir='2' or aremplir='3') and test<>'" + Trans(37) + "' and numchambre Not Like 'R*'"
            Query(2)
            InitcmbFromcmbTo()
            calculremplissage(2)
        End If
        'DEZ: move calcul in IF  20/05/10

    End Sub

    Public Sub Calcultotalitems()
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False

        DGRemp.Columns.Clear()
        TOTALRemp.Columns.Clear()
        DGRemp.Columns.Add("chambre", Trans(28))
        TOTALRemp.Columns.Add("chambre", Trans(28))
        TOTALRemp.Rows.Add()
        DGRemp.Columns(0).SortMode = DataGridViewColumnSortMode.Programmatic
        For i As Integer = 1 To baseproduit.dproduit.Rows.Count ' format both tables and headers for all products
            Try
                If baseproduit.dproduit.Rows(i - 1).Cells("Column14").Value = False Then ' if it is not safe
                    DGRemp.Columns.Add(baseproduit.dproduit.Rows(i - 1).Cells(1).Value, baseproduit.dproduit.Rows(i - 1).Cells(1).Value)
                    TOTALRemp.Columns.Add(baseproduit.dproduit.Rows(i - 1).Cells(1).Value, baseproduit.dproduit.Rows(i - 1).Cells(1).Value)
                    TOTALRemp.Item(TOTALRemp.ColumnCount - 1, 0).Value = 0
                End If
            Catch ex As Exception
            End Try
        Next
        TOTALRemp.Item(0, 0).Value = Trans(384)

        For i As Integer = 0 To Maintable.Rows.Count - 1 ' for each room
            'init dgremp
            DGRemp.Rows.Add(basedlc.dch.Rows(i).Cells("numchambre").Value)
            For j As Integer = 1 To DGRemp.ColumnCount - 1
                DGRemp.Item(j, i).Value = 0
            Next
            Basedlc.returndlc(i)

            For j As Integer = 0 To MaxCountOfProducts - 1 '11
                Dim cremp As Integer = Trouveremp(basedlc.dfrigo1.Columns(j).HeaderText) ' find index of column by name of product in dlc form
                'test si perime
                If cremp > -1 Then ' if index found
                    Try
                        DGRemp.Item(cremp, i).Value += basedlc.dfrigo2.Rows(0).Cells(j).Value
                    Catch ex As Exception
                        DGRemp.Item(cremp, i).Value = 0
                    End Try
                End If
            Next
        Next
        'supprime les ligne a zero
        Dim r As Boolean = False
        For i As Integer = DGRemp.Rows.Count - 1 To 0 Step -1
            For j As Integer = 1 To DGRemp.ColumnCount - 1
                If Val(DGRemp.Item(j, i).Value) > 0 Then
                    r = True
                    Exit For
                End If
            Next
            If r = False Then DGRemp.Rows.RemoveAt(i)
            r = False
        Next
        'total 
        For i As Integer = 0 To DGRemp.Rows.Count - 1
            Try
                For j As Integer = 1 To DGRemp.Columns.Count - 1
                    TOTALRemp.Item(j, 0).Value += DGRemp.Item(j, i).Value
                Next
            Catch ex As Exception
            End Try
        Next
        lblFooter.Text = Trans(48) + DGRemp.Rows.Count.ToString
    End Sub

    Public Sub Calculperime()
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False

        DGRemp.Columns.Clear()
        TOTALRemp.Columns.Clear()
        DGRemp.Columns.Add("chambre", Trans(28))
        TOTALRemp.Columns.Add("chambre", Trans(28))
        TOTALRemp.Rows.Add()
        For i As Integer = 1 To baseproduit.dproduit.Rows.Count
            Try
                If baseproduit.dproduit.Rows(i - 1).Cells("Column14").Value = False Then
                    DGRemp.Columns.Add(baseproduit.dproduit.Rows(i - 1).Cells(1).Value, baseproduit.dproduit.Rows(i - 1).Cells(1).Value)
                    TOTALRemp.Columns.Add(baseproduit.dproduit.Rows(i - 1).Cells(1).Value, baseproduit.dproduit.Rows(i - 1).Cells(1).Value)
                    TOTALRemp.Item(TOTALRemp.ColumnCount - 1, 0).Value = 0
                End If
            Catch ex As Exception
            End Try
        Next
        TOTALRemp.Item(0, 0).Value = Trans(384)

        For i As Integer = 0 To Maintable.Rows.Count - 1
            'init dgremp
            DGRemp.Rows.Add(basedlc.dch.Rows(i).Cells("numchambre").Value)
            For j As Integer = 1 To DGRemp.ColumnCount - 1
                DGRemp.Item(j, i).Value = 0
            Next
            Basedlc.returndlc(i)
            For j As Integer = 0 To MaxCountOfProducts - 1 '11
                Dim cremp As Integer = Trouveremp(basedlc.dfrigo1.Columns(j).HeaderText)
                'test si perime
                If cremp > -1 Then
                    Dim cptp As Integer = 0
                    For k As Integer = 0 To 5
                        Dim d As String = basedlc.dfrigo1.Item(j, k).Value
                        If d <> "" Then
                            If Val(d) < np.Value Then
                                cptp += 1
                            End If
                        End If
                    Next
                    'note le resultat
                    DGRemp.Item(cremp, i).Value += cptp
                End If
            Next
        Next
        'supprime les ligne a zero
        For i As Integer = DGRemp.Rows.Count - 1 To 0 Step -1
            Dim r As Boolean = False
            For j As Integer = 1 To DGRemp.ColumnCount - 1
                If DGRemp.Item(j, i).Value > 0 Then
                    r = True
                End If
            Next
            If r = False Then DGRemp.Rows.RemoveAt(i)
        Next
        'total 
        For i As Integer = 0 To DGRemp.Rows.Count - 1
            Try
                For j As Integer = 1 To DGRemp.Columns.Count - 1
                    TOTALRemp.Item(j, 0).Value += DGRemp.Item(j, i).Value
                Next
            Catch ex As Exception
            End Try
        Next
        lblFooter.Text = Trans(48) + DGRemp.Rows.Count.ToString
    End Sub
    Public Function Trouveremp(nom As String) As Integer
        Trouveremp = -1
        For i As Integer = 1 To DGRemp.ColumnCount - 1
            If DGRemp.Columns(i).HeaderText = nom Then
                Return i
            End If
        Next
    End Function
    Private Sub Query(ByRef alarme As Integer)
        Dim setAlarme() As Integer = New Integer() {}
        _setTypeOfBar = New Integer() {}
        Select Case alarme
            Case 0
                setAlarme = New Integer() {0, 1, 2, 3}
            Case 1
                setAlarme = New Integer() {1, 3}
            Case 2
                setAlarme = New Integer() {1, 2, 3}
        End Select
        Dim typeOfBar As Byte = CType(cmbExtension.SelectedItem, typeOfBar).Type
        If pnlExtention.Visible = False Then
            typeOfBar = 1
        End If
        Select Case typeOfBar
            Case 1
                _setTypeOfBar = New Integer() {0, 1, 2, 3}
            Case 2
                _setTypeOfBar = New Integer() {0, 1, 2}
            Case 3
                _setTypeOfBar = New Integer() {3}
        End Select
        Dim _mp As List(Of DataRow) = (From mompck In DtMomentaryPickUp.AsEnumerable().Where _
                                      ( _
                                          Function(p)
                                              Dim sum As Integer = 0
                                              For i As Integer = 1 To MaxCountOfProducts
                                                  sum += p.Field(Of Int32)("c" + i.ToString())
                                              Next
                                              Return sum > 0

                                          End Function
                                      ) _
                                  Select mompck _
    ).ToList()
        Dim needAddGuestProdact = LireIniBoolSmart("imprimer", "IsCanPrintGuestProducts", True)
        'Group Join mp In DtMomentaryPickUp.AsEnumerable()
        _queryAlarm = (From maint In Maintable.AsEnumerable() _
            Group Join mp In _mp.AsEnumerable() On maint.Field(Of String)("nummodule") Equals mp.Field(Of Integer)("nummodule").ToString() _
            Into righrGrp = Group From mp In righrGrp.DefaultIfEmpty _
            Where ( _
                        (_setTypeOfBar.Contains(maint.Field(Of Integer)("coffre")) _
                        AndAlso ((Not maint.Field(Of String)("numchambre") Like "R*") AndAlso (maint.Field(Of String)("test") <> Trans(37) AndAlso maint.Field(Of String)("test") <> Trans(43)) _
                                 AndAlso maint.Field(Of String)("numchambre").Trim().Length > 0)) _
                    AndAlso _
                        ( _
                            setAlarme.Contains(maint.Field(Of Integer)("aremplir")) OrElse ((maint.Field(Of Integer)("aremplir") = 0 AndAlso mp IsNot Nothing)) _
                            OrElse _
                            ( _
                            (maint.Field(Of String)("etatporte") = Trans(51)) OrElse (maint.Field(Of String)("test") = Trans(208)) _
                            OrElse (maint.Field(Of Int32)("service") = 1) _
                            ) _
                            OrElse _
                            (needAddGuestProdact AndAlso ModelTools.IsGuestPresentSomething(maint.Field(Of String)("swr"), maint.Field(Of String)("modelefrigo")) AndAlso maint.Field(Of Integer)("coffre") = 3) _
                        ) _
                    ) _
            Select maint, mp, door = IIf(maint.Field(Of String)("etatporte") = "Open", "1", "0"), test = IIf(maint.Field(Of String)("Test") = "Connection error", "1", "0"), _
                      gp = IIf(ModelTools.IsGuestPresentSomething(maint.Field(Of String)("swr"), maint.Field(Of String)("modelefrigo"), maint.Field(Of Integer)("coffre").ToString()), "1", "0"), _
                      service = maint.Field(Of Int32)("service") Order By maint.Field(Of String)("numchambre") _
                      Order By maint.Field(Of String)("numchambre").DigitsOnly()).ToList()


        '_queryAlarm = (From maint In Maintable.AsEnumerable() _
        '    Group Join mp In DtMomentaryPickUp.AsEnumerable() On maint.Field(Of String)("nummodule") Equals mp.Field(Of Integer)("nummodule").ToString() _
        '    Into righrGrp = Group From mp In righrGrp.DefaultIfEmpty _
        '    Where ( _
        '        ((setAlarme.Contains(maint.Field(Of Integer)("aremplir")) OrElse (maint.Field(Of Integer)("aremplir") = 0 AndAlso mp IsNot Nothing)) _
        '        AndAlso (_setTypeOfBar.Contains(maint.Field(Of Integer)("coffre"))) _
        '        AndAlso ((Not maint.Field(Of String)("numchambre") Like "R*") AndAlso maint.Field(Of String)("test") <> Trans(37) AndAlso maint.Field(Of String)("numchambre").Trim().Length > 0)) _
        '        OrElse _
        '        ( _
        '                  (maint.Field(Of String)("etatporte") = Trans(51)) OrElse (maint.Field(Of String)("test") = Trans(208)) _
        '                  OrElse (maint.Field(Of Int32)("service") = 1) _
        '                  AndAlso (_setTypeOfBar.Contains(maint.Field(Of Integer)("coffre"))) _
        '                  AndAlso _
        '                  ( _
        '                  (Not maint.Field(Of String)("numchambre") Like "R*") _
        '                       AndAlso (maint.Field(Of String)("test") <> Trans(37)) _
        '                       AndAlso (maint.Field(Of String)("numchambre").Trim().Length > 0) _
        '                  ) _
        '              ) _
        '      ) _
        '    Select maint, mp, door = IIf(maint.Field(Of String)("etatporte") = "Open", "1", "0"), test = IIf(maint.Field(Of String)("Test") = "Connection error", "1", "0"), _
        '              service = maint.Field(Of Int32)("service") Order By maint.Field(Of String)("numchambre") _
        'Order By maint.Field(Of String)("numchambre").DigitsOnly()).ToList()

    End Sub

    Private Sub calculremplissage(ByRef alarme As Integer)
        If rbtnOutOfday.Checked = True Then
            Calculperime()
            Exit Sub
        End If
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        DGRemp.Rows.Clear()
        TOTALRemp.Rows.Clear()
        DGRemp.Columns.Clear()
        TOTALRemp.Columns.Clear()
        DGRemp.Refresh()
        DGRemp.Columns.Add("chambre", Trans(28))
        DGRemp.Columns.Add("RoomStatus", "Room Status")

        DGRemp.Columns.Add("LastCheckin", "LastCheckin")
        DGRemp.Columns.Add("LastCheckOut", "LastCheckOut")
        DGRemp.Columns.Add("LastRefill", "LastRefill")

        DGRemp.Columns("LastCheckin").Visible = False
        DGRemp.Columns("LastCheckOut").Visible = False
        DGRemp.Columns("LastRefill").Visible = False

        With TOTALRemp
            .Columns.Add("chambre", Trans(28))
            .Columns.Add("RoomStatus", "Room Status")
            '.Columns.Add("LastCheckin", "LastCheckin")
            '.Columns.Add("LastCheckOut", "LastCheckOut")
            '.Columns.Add("LastRefill", "LastRefill")
            '.Columns("LastCheckin").Visible = False
            '.Columns("LastCheckOut").Visible = False
            '.Columns("LastRefill").Visible = False
            .Rows.Add()
        End With

        Dim dgvTmp As New DataGridView()
        DGRemp.Columns(0).SortMode = DataGridViewColumnSortMode.Programmatic
        dgvTmp = DGRemp

        For i As Integer = 1 To baseproduit.dproduit.Rows.Count
            Try
                If baseproduit.dproduit.Rows(i - 1).Cells("Column14").Value = False Then
                    dgvTmp.Columns.Add(baseproduit.dproduit.Rows(i - 1).Cells(1).Value, baseproduit.dproduit.Rows(i - 1).Cells(2).Value)
                    TOTALRemp.Columns.Add(baseproduit.dproduit.Rows(i - 1).Cells(1).Value, baseproduit.dproduit.Rows(i - 1).Cells(2).Value)
                    TOTALRemp.Item(TOTALRemp.ColumnCount - 1, 0).Value = 0
                End If

            Catch ex As Exception
            End Try
        Next

        'Try to add MP
        If chkbMomPickUp.Checked = True Then
            For i As Integer = 1 To baseproduit.dproduit.Rows.Count
                Try
                    If baseproduit.dproduit.Rows(i - 1).Cells("Column14").Value = False Then
                        dgvTmp.Columns.Add("MP_" + baseproduit.dproduit.Rows(i - 1).Cells(1).Value, "MP_" + baseproduit.dproduit.Rows(i - 1).Cells(2).Value)
                    End If
                Catch ex As Exception

                End Try
            Next
        End If
        dgvTmp.Columns.Add("CE", "Con. Error")
        dgvTmp.Columns.Add("DO", "Door Open")
        dgvTmp.Columns.Add("SSE", "Serv. Switch Error")
        dgvTmp.Columns.Add("GP", "Guest Products")
        TOTALRemp.Columns.Add("CE", "Con. Error")
        TOTALRemp.Columns.Add("DO", "Door Open")
        TOTALRemp.Columns.Add("SSE", "Serv. Switch Error")
        TOTALRemp.Columns.Add("GP", "Guest Products")
        TOTALRemp.Item(0, 0).Value = Trans(384)
        TOTALRemp.Item("CE", 0).Value = 0
        TOTALRemp.Item("DO", 0).Value = 0
        TOTALRemp.Item("SSE", 0).Value = 0
        TOTALRemp.Item("GP", 0).Value = 0
        Dim f As Integer, st As Stockcasier 'nom & max
        Dim d As Integer = 0

        If rbtnAll.Checked = True Then f = _queryAlarm.Count 'dvr.Count
        If rbtnLimitTo.Checked = True Then f = nbc.Value
        If rbtnRoomN.Checked = True Then
            f = cmbTo.SelectedIndex + 1
            d = cmbFrom.SelectedIndex
        End If
        lblFooter.Text = Trans(48) + dgvTmp.Rows.Count.ToString()
        lblFooter.Refresh()
        'If f > dvr.Count Then f = dvr.Count
        If f > _queryAlarm.Count Then f = _queryAlarm.Count
        If d < 0 Then d = 0
        For i As Integer = d To f - 1
            Dim addCheck As Integer = CInt(_queryAlarm(i).door) + CInt(_queryAlarm(i).test) + CInt(_queryAlarm(i).service) + CInt(_queryAlarm(i).gp)
            If _queryAlarm(i).maint("aremplir") > 0 OrElse chkbMomPickUp.Checked OrElse addCheck > 0 Then
                Try
                    If chkbVacantOnly.Checked = True AndAlso String.Compare(_queryAlarm(i).maint("check").ToString().ToUpper, "CHECK IN", StringComparison.Ordinal) = 0 Then
                        Continue For
                    End If
                    dgvTmp.Rows.Add(New Object() {_queryAlarm(i).maint("numchambre"), _queryAlarm(i).maint("check"), _queryAlarm(i).maint("datecheckin"), _queryAlarm(i).maint("datecheckout"), _queryAlarm(i).maint("dateremplissage")}) '(dvr(i)("numchambre"))
                    'dgvTmp("RoomStatus", dgvTmp.Rows.Count - 1).Value = queryAlarm(i).maint("check")
                    For j As Integer = 5 To dgvTmp.Columns.Count - 1
                        dgvTmp.Item(j, dgvTmp.Rows.Count - 1).Value = 0
                    Next
                Catch ex As Exception
                End Try
                For j As Integer = 1 To MaxCountOfProducts '12
                    Try
                        'st = nomproduit(queryAlarm(i).maint("numchambre"), j) 'nomproduit(dvr(i)("numchambre"), j)
                        st = NomProduitLinq1(_queryAlarm(i).maint("numchambre"), j)
                        If st.Nom.Length > 0 Then
                            dgvTmp.Item(st.Nom, dgvTmp.Rows.Count - 1).Value += _queryAlarm(i).maint("c" + j.ToString()) - st.Max    'dvr(i)("c" + j.ToString()) - st.max  'dvr(i)(48 + j) - st.max
                            If chkbMomPickUp.Checked = True AndAlso _queryAlarm(i).mp IsNot Nothing Then
                                dgvTmp.Item("MP_" + st.Nom, dgvTmp.Rows.Count - 1).Value += _queryAlarm(i).mp("c" + j.ToString()) 'dr("c" + j.ToString())
                            End If
                        End If

                    Catch ex As Exception

                    End Try

                Next
                dgvTmp.Item("DO", dgvTmp.Rows.Count - 1).Value = _queryAlarm(i).door
                dgvTmp.Item("CE", dgvTmp.Rows.Count - 1).Value = _queryAlarm(i).test
                dgvTmp.Item("SSE", dgvTmp.Rows.Count - 1).Value = _queryAlarm(i).service
                dgvTmp.Item("GP", dgvTmp.Rows.Count - 1).Value = _queryAlarm(i).gp
            End If
            'If queryAlarm(i).maint("etatporte").ToString().ToUpper() = trans(51).ToUpper() Then
            '    dgvTmp.Rows(dgvTmp.Rows.Count - 1).Cells("DO").Value = 1
            'End If
            'If queryAlarm(i).maint("test").ToString().ToUpper() = trans(208).ToUpper() Then
            '    dgvTmp.Rows(dgvTmp.Rows.Count - 1).Cells("CE").Value = 1
            'End If
            'If queryAlarm(i).maint("service") = 1 Then
            '    dgvTmp.Rows(dgvTmp.Rows.Count - 1).Cells("SSE").Value = 1
            'End If

            lblFooter.Text = Trans(48) + dgvTmp.Rows.Count.ToString()
            lblFooter.Refresh()
        Next

        'dgvTmp = AddTroublesToReport(dgvTmp)

        'total 
        For i As Integer = 0 To dgvTmp.Rows.Count - 1
            Try
                'For j As Integer = 5 To ((dgvTmp.Columns.Count - 8) / 2) - 1 + 5  'dgvTmp.Columns.Count - 1
                '    TOTALRemp.Item(j - 3, 0).Value += dgvTmp.Item(j, i).Value
                'Next
                For j As Integer = 2 To TOTALRemp.Columns.Count - 1
                    TOTALRemp.Item(j, 0).Value += dgvTmp.Item(j + 3, i).Value
                Next
            Catch ex As Exception
            End Try
        Next
        lblFooter.Text = Trans(48) + dgvTmp.Rows.Count.ToString
        DGRemp = dgvTmp
        'DGRemp.Sort(New RowComparer(SortOrder.Ascending))
        'DGRemp.Columns(0).HeaderCell.SortGlyphDirection = SortOrder.Ascending
    End Sub
    'Private Function dgv2print_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) As Integer

    '    Dim result As Integer = -1
    '    result = CType(sender, DataGridView).Rows.Count - 1
    '    For cntr As Integer = 1 To dgv2Print.Columns.Count - 1
    '        dgv2Print(cntr, result).Value = 0
    '    Next
    '    Return result
    'End Function

    'MainTable.Columns.Add("gp")F
    'Dim testA = (From lists In MainTable.AsEnumerable().Where _
    '            ( _
    '                Function(p)
    '                    Dim real = Convert.ToInt64(p("swr"), 16)
    '                    Dim sceleton = ModelTools.ModelByName(p("modelefrigo"), p("coffre"))
    '                    p.SetField("gp", ((sceleton Or (real - 1)) <> sceleton).ToString())

    '                    'p.Field(Of String)("gp") = "0"
    '                    'Dim gp = ((sceleton Or (real - 1)) <> sceleton).ToString()
    '                    Return ( _
    '                              ( _
    '                                  ( _
    '                                      (sceleton Or (real - 1)) <> sceleton _
    '                                  ) _
    '                                  Or _
    '                                      (p("etatporte") = "Open" Or p("test") = "Connection error" Or p("service") = "1") _
    '                               ) _
    '                               And _
    '                                      (p("coffre") = "3") And Not p("numchambre").ToString().StartsWith("R") _
    '                           )
    '                End Function
    '            ) _
    '            Select rn = lists("numchambre"), _
    '                   door = IIf(lists("etatporte") = "Open", "1", 0), test = IIf(lists("Test") = "Connection error", "1", "0"), _
    '                   service = lists.Field(Of String)("service"), gp = IIf(lists("gp") = "True", "1", "0"), lastcheckin = lists("datecheckin"), lastcheckout = lists("datecheckout"), lastrefill = lists("dateremplissage") _
    '                   Order By rn _
    '                            ).ToList()

    Private Function AddTroublesToReport(dgv2Print As DataGridView) As DataGridView
        Dim numchambre As String = String.Empty
        Dim iIndex As Int16
        'AddHandler dgv2Print.RowsAdded, AddressOf dgv2print_RowsAdded
        Dim troubleList = (From trouble In Maintable.AsEnumerable() _
                          Where _
                          ( _
                          (trouble.Field(Of String)("etatporte") = Trans(51)) OrElse (trouble.Field(Of String)("test") = Trans(208)) _
                          OrElse (trouble.Field(Of Int32)("service") = 1) _
                          ) _
                          AndAlso (_setTypeOfBar.Contains(trouble.Field(Of Integer)("coffre"))) _
                          AndAlso _
                          ( _
                          (Not trouble.Field(Of String)("numchambre") Like "R*") _
                               AndAlso (trouble.Field(Of String)("test") <> Trans(37)) _
                               AndAlso (trouble.Field(Of String)("numchambre").Trim().Length > 0) _
                          ) _
                         Select rn = trouble.Field(Of String)("numchambre"), door = trouble.Field(Of String)("etatporte"), test = trouble.Field(Of String)("Test"), _
                          service = trouble.Field(Of Int32)("service"), lastcheckin = trouble.Field(Of String)("datecheckin"), lastcheckout = trouble.Field(Of String)("datecheckout"), lastrefill = trouble.Field(Of String)("dateremplissage")).ToList()

        Dim guestProductList As List(Of DataRow) = ModelTools.ListRoomsWithGuestProduct(Maintable)

        For i As Integer = 0 To troubleList.Count - 1
            numchambre = troubleList(i).rn
            iIndex = -1
            For j As Integer = 0 To dgv2Print.Rows.Count - 1
                If dgv2Print(0, j).FormattedValue.ToString() = numchambre Then
                    iIndex = j
                    Exit For
                End If
            Next
            If (iIndex = -1 AndAlso rbtnAll.Checked) OrElse _
            (iIndex = -1 AndAlso rbtnRoomN.Checked AndAlso CInt(numchambre.DigitsOnly()) >= CInt(cmbFrom.Text.DigitsOnly()) AndAlso CInt(numchambre.DigitsOnly()) <= CInt(cmbTo.Text.DigitsOnly())) Then
                dgv2Print.Rows.Add(New Object() {numchambre, "", troubleList(i).lastcheckin, troubleList(i).lastcheckout, troubleList(i).lastrefill})
                iIndex = dgv2Print.Rows.Count - 1
                For cntr As Integer = 5 To dgv2Print.Columns.Count - 1
                    dgv2Print(cntr, iIndex).Value = 0
                Next
            End If
            If iIndex >= 0 Then
                If troubleList(i).door = Trans(51) Then
                    dgv2Print.Rows(iIndex).Cells("DO").Value = 1
                End If
                If troubleList(i).test = Trans(208) Then
                    dgv2Print.Rows(iIndex).Cells("CE").Value = 1
                End If
                If troubleList(i).service = 1 Then
                    dgv2Print.Rows(iIndex).Cells("SSE").Value = 1
                End If
            End If
        Next

        Return dgv2Print
    End Function

    Public Sub calculremplissage()
        If rbtnOutOfday.Checked = True Then
            Calculperime()
            Exit Sub
        End If

        GroupBox2.Enabled = True
        GroupBox3.Enabled = True

        DGRemp.Columns.Clear()
        TOTALRemp.Columns.Clear()
        DGRemp.Columns.Add("chambre", Trans(28))
        TOTALRemp.Columns.Add("chambre", Trans(28))
        TOTALRemp.Rows.Add()

        'DEZ 14.06.10
        DGRemp.Columns(0).SortMode = DataGridViewColumnSortMode.Programmatic


        For i As Integer = 1 To baseproduit.dproduit.Rows.Count
            Try
                If baseproduit.dproduit.Rows(i - 1).Cells("Column14").Value = False Then
                    DGRemp.Columns.Add(baseproduit.dproduit.Rows(i - 1).Cells(1).Value, baseproduit.dproduit.Rows(i - 1).Cells(1).Value)
                    TOTALRemp.Columns.Add(baseproduit.dproduit.Rows(i - 1).Cells(1).Value, baseproduit.dproduit.Rows(i - 1).Cells(1).Value)
                    TOTALRemp.Item(TOTALRemp.ColumnCount - 1, 0).Value = 0
                End If

            Catch ex As Exception
            End Try
        Next
        'Try to add MP
        If chkbMomPickUp.Checked = True Then
            For i As Integer = 1 To baseproduit.dproduit.Rows.Count
                Try
                    If baseproduit.dproduit.Rows(i - 1).Cells("Column14").Value = False Then
                        DGRemp.Columns.Add("MP_" + baseproduit.dproduit.Rows(i - 1).Cells(1).Value, "MP_" + baseproduit.dproduit.Rows(i - 1).Cells(1).Value)
                    End If
                Catch ex As Exception

                End Try
            Next
        End If

        TOTALRemp.Item(0, 0).Value = Trans(384)
        Dim f As Integer, st As Stockcasier 'nom & max
        Dim d As Integer = 0

        If rbtnAll.Checked = True Then f = Dvr.Count
        If rbtnLimitTo.Checked = True Then f = nbc.Value
        If rbtnRoomN.Checked = True Then
            f = cmbTo.SelectedIndex + 1
            d = cmbFrom.SelectedIndex
        End If

        If f > Dvr.Count Then f = Dvr.Count
        Dim dr As DataRow
        For i As Integer = d To f - 1
            Try
                DGRemp.Rows.Add(Dvr(i)("numchambre"))
                For j As Integer = 1 To DGRemp.Columns.Count - 1
                    DGRemp.Item(j, DGRemp.Rows.Count - 1).Value = 0
                Next
            Catch ex As Exception
            End Try
            Dim nummodule As Integer = CInt(Dvr(i)("nummodule"))
            dr = (From mp As DataRow In DtMomentaryPickUp.AsEnumerable() Where mp.Field(Of Integer)("nummodule") = nummodule Select mp)(0)
            For j As Integer = 1 To MaxCountOfProducts '12
                Try
                    st = Nomproduit(Dvr(i)("numchambre"), j)
                    If st.Nom.Length > 0 Then
                        DGRemp.Item(st.Nom, DGRemp.Rows.Count - 1).Value += Dvr(i)("c" + j.ToString()) - st.Max  'dvr(i)(48 + j) - st.max
                        If chkbMomPickUp.Checked = True And dr IsNot Nothing Then
                            DGRemp.Item("MP_" + st.Nom, DGRemp.Rows.Count - 1).Value += dr("c" + j.ToString())
                        End If
                    End If

                Catch ex As Exception

                End Try

            Next
        Next
        'supprime les ligne a zero
        'For i As Integer = DGRemp.Rows.Count - 1 To 0 Step -1
        '    Dim r As Boolean = False

        '    For j As Integer = 1 To DGRemp.ColumnCount - 1
        '        If Val(DGRemp.Item(j, i).Value) <> 0 Then
        '            r = True
        '        End If
        '    Next
        '    If r = False And DGRemp.ColumnCount > 1 Then
        '        DGRemp.Rows.RemoveAt(i)
        '    End If

        'Next

        'total 
        For i As Integer = 0 To DGRemp.Rows.Count - 1
            Try
                For j As Integer = 1 To DGRemp.Columns.Count - 1
                    TOTALRemp.Item(j, 0).Value += DGRemp.Item(j, i).Value
                Next
            Catch ex As Exception
            End Try
        Next
        lblFooter.Text = Trans(48) + DGRemp.Rows.Count.ToString

    End Sub
    Private Function NomProduitLinq1(numchambre As String, casier As Integer)
        Dim result As New Stockcasier
        result.Nom = String.Empty
        result.Max = 0
        Dim queryNom As List(Of Stockcasier) = (From maint As DataRow In Maintable.AsEnumerable() Join model In basemodele.modele.AsEnumerable() _
                                              On maint.Field(Of String)("modelefrigo") Equals model.Field(Of String)("nom") _
                                              Where maint.Field(Of String)("numchambre").ToString() = numchambre _
                                              Select New Stockcasier With {.Nom = model.Field(Of String)(casier), .Max = CInt(model.Field(Of String)(casier + MaxCountOfProducts))}).ToList()
        If queryNom IsNot Nothing AndAlso queryNom.Count > 0 Then
            result.Nom = queryNom(0).Nom
            result.Max = queryNom(0).Max
        End If
        Return result
    End Function
    Private Function NomproduitLinq(numchambre As String, casier As Integer) As Stockcasier
        Dim result As New Stockcasier
        result.Nom = String.Empty
        result.Max = 0
        Dim queryNom As List(Of Stockcasier) = (From maint As DataRow In Maintable.AsEnumerable() _
                       Group Join model In basemodele.modele.AsEnumerable() _
                       On maint.Field(Of String)("modelefrigo") Equals model.Field(Of String)("nom") _
                       Into righrGrp = Group From model In righrGrp.DefaultIfEmpty _
                       Where maint.Field(Of String)("numchambre").ToString() = numchambre _
        Select New Stockcasier With {.Nom = righrGrp(0)(casier), .Max = righrGrp(0)(casier + MaxCountOfProducts)}).ToList()

        'Select prod = righrGrp(0)(casier), max = righrGrp(0)(casier + MaxCountOfProducts)).ToList()

        If queryNom IsNot Nothing Then
            result.Nom = queryNom(0).Nom
            result.Max = queryNom(0).Max
        End If
        Return result
    End Function
    Public Function Nomproduit(numch As String, casier As Integer) As Stockcasier
        Nomproduit.Nom = ""
        Nomproduit.Max = 0

        Dim m As String = ""
        For i As Integer = 0 To Dvr.Count - 1
            If Dvr.Item(i)("numchambre") = numch Then
                m = Dvr.Item(i)("modelefrigo")
                Exit For
            End If
        Next
        For i As Integer = 0 To basemodele.modele.Rows.Count - 1
            If basemodele.modele.Rows(i)("nom") = m Then
                Nomproduit.Nom = basemodele.modele.Rows(i)(casier)
                Nomproduit.Max = basemodele.modele.Rows(i)(casier + MaxCountOfProducts) '(casier + 12)
                Exit For
            End If
        Next
    End Function

    Private Sub remplissage_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True And Not IsStarted Then
            AlarmsRefresh()
        End If
    End Sub
    Private Sub nbc_ValueChanged(sender As Object, e As EventArgs) Handles nbc.ValueChanged
        rbtnAlarm2_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub rbtnAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAll.CheckedChanged
        If rbtnAll.Checked = True AndAlso Me.Visible = True Then
            'calculremplissage()
            If rbtnAlarm1.Checked = True Then
                Query(1)
                calculremplissage(1)
            ElseIf rbtnAlarm2.Checked = True Then
                Query(2)
                calculremplissage(2)
            End If
        End If
    End Sub

    Private Sub rbtnLimitTo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLimitTo.CheckedChanged
        If rbtnLimitTo.Checked = True Then
            'calculremplissage()
            If rbtnAlarm1.Checked = True Then
                calculremplissage(1)
            ElseIf rbtnAlarm2.Checked = True Then
                calculremplissage(2)
            End If
        End If
    End Sub

    Private Sub rbtnRoomN_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRoomN.CheckedChanged
        If rbtnRoomN.Checked = True Then
            'calculremplissage()
            If rbtnAlarm1.Checked = True Then
                calculremplissage(1)
            ElseIf rbtnAlarm2.Checked = True Then
                calculremplissage(2)
            End If
        End If
    End Sub

    Private Sub rbtnTotalStock_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTotalStock.CheckedChanged
        If rbtnTotalStock.Checked = True Then
            lblHeader.Text = Trans(451)
            Dvr.RowFilter = "test<>'" + Trans(37) + "' and numchambre<>'R*'"
            Query(0)
            InitcmbFromcmbTo()
            Calcultotalitems()
        End If
    End Sub


    Private Sub rbtnOutOfday_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOutOfday.CheckedChanged
        If rbtnOutOfday.Checked = True Then
            lblHeader.Text = Trans(396)
            calculremplissage()
        End If
    End Sub

    Private Sub gbtnPrint_Click(sender As Object, e As EventArgs) Handles gbtnPrint.Click
        Try
            If rbtnOutOfday.Checked = True Then
                Dim imp As New Imprimer
                imp.imprimante = cmbRefill.Text
                imp.imprime = "perime"
                imp.paysage = CheckBox1.Checked
                imp.go()
                'imp.Show()
                Exit Sub
            End If
            Savsave()
            Dim nb As Integer = DGRemp.Rows.Count
            Dim ec As Integer = CInt(nb / n1.Value)
            Dim fin As Integer = cmbTo.Items.Count
            If rbtnRoomN.Checked = True Then
                fin = cmbTo.SelectedIndex + 1
            Else
                cmbFrom.SelectedIndex = 0
                cmbTo.SelectedIndex = nb - 1
                fin = nb
                'RadioButton5.Checked = True
            End If

            For i As Integer = 1 To n1.Value
                Dim f As Integer = 0
                If i = n1.Value Then
                    f = fin
                Else
                    f = cmbFrom.SelectedIndex + ec
                End If
                cmbTo.SelectedIndex = f - 1

                Dim imp As New Imprimer

                imp.Top = pnlRight.Top
                imp.Left = pnlRight.Left
                imp.Width = pnlRight.Width
                imp.Height = pnlRight.Height

                imp.imprimante = cmbRefill.Text
                imp.imprime = "remplissage"
                imp.paysage = CheckBox1.Checked
                Dim dgvSaved As DataGridView = DGRemp.Clone()
                If DGRemp.Columns(0).HeaderCell.SortGlyphDirection = SortOrder.None Then
                    dgvSaved.Columns(0).HeaderCell.SortGlyphDirection = SortOrder.Ascending
                Else
                    dgvSaved.Columns(0).HeaderCell.SortGlyphDirection = DGRemp.Columns(0).HeaderCell.SortGlyphDirection
                End If
                If Not rbtnTotalStock.Checked = True Then
                    imp.DgvTableRemp = dgvSaved 'AddTroublesToReport(dgvSaved)
                Else
                    imp.DgvTableRemp = dgvSaved
                    imp.imprime = "Total"
                End If
                imp.go()
                'imp.Show()
                Do
                    Application.DoEvents()
                    Thread.Sleep(100)
                Loop Until imp.pret = True
                If i <> n1.Value Then cmbFrom.SelectedIndex += ec
            Next
            Savrestore()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Savsave()
        _sav(0) = rbtnAlarm1.Checked
        _sav(1) = rbtnAlarm2.Checked
        _sav(2) = rbtnAll.Checked
        _sav(3) = rbtnLimitTo.Checked
        _sav(4) = rbtnRoomN.Checked
        _sav(5) = nbc.Value
        _sav(6) = cmbFrom.SelectedIndex
        _sav(7) = cmbTo.SelectedIndex

    End Sub

    Private Sub Savrestore()
        rbtnAlarm1.Checked = _sav(0)
        rbtnAlarm2.Checked = _sav(1)
        rbtnAll.Checked = _sav(2)
        rbtnLimitTo.Checked = _sav(3)
        rbtnRoomN.Checked = _sav(4)
        nbc.Value = _sav(5)
        cmbFrom.SelectedIndex = _sav(6)
        cmbTo.SelectedIndex = _sav(7)
    End Sub

    Private Sub imprimante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRefill.SelectedIndexChanged
        EcrireINI("imprimante", "remplissage", cmbRefill.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        EcrireINI("imprimante", "remplissagepaysage", CheckBox1.Checked)
    End Sub
    Private Sub cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTo.SelectedIndexChanged, cmbFrom.SelectedIndexChanged
        If rbtnRoomN.Checked = True Then
            'calculremplissage()
            If rbtnAlarm1.Checked = True Then
                Query(1)
                calculremplissage(1)
            ElseIf rbtnAlarm2.Checked = True Then
                Query(2)
                calculremplissage(2)
            End If
        End If
    End Sub

    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If rbtnRoomN.Checked = True Then
            'calculremplissage()
            If rbtnAlarm1.Checked = True Then
                calculremplissage(1)
            ElseIf rbtnAlarm2.Checked = True Then
                calculremplissage(2)
            End If
        End If
    End Sub

    Private Sub cb2_SelectedIndexChanged(sender As Object, e As EventArgs)
        If rbtnRoomN.Checked = True Then
            'calculremplissage()
            If rbtnAlarm1.Checked = True Then
                calculremplissage(1)
            ElseIf rbtnAlarm2.Checked = True Then
                calculremplissage(2)
            End If
        End If
    End Sub

    Private Sub DGRemp_Scroll(sender As Object, e As ScrollEventArgs) Handles DGRemp.Scroll
        If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
            TOTALRemp.HorizontalScrollingOffset = DGRemp.HorizontalScrollingOffset
        End If
    End Sub

    Private Sub CalcOutOfDays_Click(sender As Object, e As EventArgs) Handles gbtnCalcOutOfDays.Click
        calculremplissage()
    End Sub


    Private Sub DGRemp_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub
    'DEZ 14.06.10
    Private Sub DGRemp_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGRemp.ColumnHeaderMouseClick
        Dim newColumn As DataGridViewColumn = DGRemp.Columns(e.ColumnIndex)

        'Dim oldColumn As DataGridViewColumn = DGRemp.SortedColumn
        Dim direction As SortOrder

        ' If oldColumn is null, then the DataGridView is not currently sorted.
        'If oldColumn IsNot Nothing Then

        '    ' Sort the same column again, reversing the SortOrder.
        '    If oldColumn Is newColumn AndAlso DGRemp.SortOrder = SortOrder.Ascending Then
        '        direction = System.ComponentModel.ListSortDirection.Descending
        '    Else

        '        ' Sort a new column and remove the old SortGlyph.
        '        direction = System.ComponentModel.ListSortDirection.Ascending
        '        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None
        '    End If
        'Else
        '    direction = System.ComponentModel.ListSortDirection.Ascending
        'End If
        If newColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
            direction = SortOrder.Ascending
        ElseIf newColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
            direction = SortOrder.Descending
        Else
            direction = SortOrder.None
        End If
        If direction = SortOrder.None Then
            'newColumn.SortMode = DataGridViewColumnSortMode.Automatic
            DGRemp.Sort(newColumn, direction)
        Else
            newColumn.SortMode = DataGridViewColumnSortMode.Programmatic
            DGRemp.Sort(New RowComparer(direction))
        End If


        ' Sort the selected column.

        newColumn.HeaderCell.SortGlyphDirection = direction
        'DGRemp.SortedColumn.DisplayIndex = newColumn.DisplayIndex
        'newColumn.SortMode = DataGridViewColumnSortMode.Programmatic
        'If direction = SortOrder.Ascending Then
        '    newColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending
        'Else
        '    newColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending
        'End If

    End Sub

    'Public Class RowComparer
    '    Implements System.Collections.IComparer

    '    Private sortOrderModifier As Integer = 1

    '    Public Sub New(ByVal sortOrder As SortOrder)
    '        If sortOrder = sortOrder.Descending Then
    '            sortOrderModifier = -1
    '        ElseIf sortOrder = sortOrder.Ascending Then

    '            sortOrderModifier = 1
    '        End If
    '    End Sub

    '    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

    '        Dim DataGridViewRow1 As DataGridViewRow = CType(x, DataGridViewRow)
    '        Dim DataGridViewRow2 As DataGridViewRow = CType(y, DataGridViewRow)

    '        ' Try to sort based on the Last Name column.
    '        Dim CompareResult As Integer = 0 ' System.String.Compare(DataGridViewRow1.Cells(1).Value.ToString(), DataGridViewRow2.Cells(1).Value.ToString())
    '        Dim roomX As Integer = Integer.Parse(DataGridViewRow1.Cells(0).Value.ToString())
    '        Dim roomY As Integer = Integer.Parse(DataGridViewRow2.Cells(0).Value.ToString())
    '        If roomX = roomY Then
    '            CompareResult = 0
    '        ElseIf roomX > roomY Then
    '            CompareResult = 1
    '        Else
    '            CompareResult = -1

    '        End If

    '        Return CompareResult * sortOrderModifier
    '    End Function
    'End Class


    Private Sub chkbMomPickUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkbVacantOnly.CheckedChanged, chkbMomPickUp.CheckedChanged
        If rbtnAlarm1.Checked = True Then
            Query(1)
            InitcmbFromcmbTo()
            calculremplissage(1)
        ElseIf rbtnAlarm2.Checked = True Then
            Query(2)
            InitcmbFromcmbTo()
            calculremplissage(2)
        End If
    End Sub

    Public Sub SetExtPanelView(visible As Boolean)
        Select Case visible
            Case False
                pnlExtention.SendToBack()
                'pnlBotton.BringToFront()
                pnlLeft.Location = New Point(pnlLeft.Location.X, Me.Bounds.Location.Y + 2)
            Case True
                pnlExtention.BringToFront()
                'pnlBotton.SendToBack()
                pnlExtention.Location = New Point(pnlLeft.Location.X, Me.Bounds.Location.Y + 2)
                pnlLeft.Location = New Point(pnlLeft.Location.X, pnlExtention.Bottom + 5)

        End Select
        pnlLeft.Height = Me.Bottom - 5 - pnlLeft.Location.Y
        pnlExtention.Visible = visible
    End Sub


    Private Sub cmbExtension_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExtension.SelectedIndexChanged
        AlarmPerformClickAction(Me.rbtnAlarm1)
    End Sub
    Private Sub AlarmsRefresh()
        Dim sndr As Object = New Object()
        If rbtnAlarm1.Checked Then
            sndr = rbtnAlarm1
        ElseIf rbtnAlarm2.Checked Then
            sndr = rbtnAlarm2
        End If
        If Not IsNothing(sndr) Then
            AlarmPerformClickAction(sndr)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        AlarmsRefresh()
    End Sub

    
End Class