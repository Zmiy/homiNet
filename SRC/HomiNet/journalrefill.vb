Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.Globalization

Public Class journalrefill
    Public dvj As New DataView
    Public jremp As New DataTable("jremp")
    Public jlog As New DataTable("jlog")


    Public Structure stockcasier
        Dim nom As String
        Dim max As Integer

    End Structure

    Private Sub journalrefill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
        dvj.Table = jremp
        dj.DataSource = dvj
    End Sub
    Public Sub initlangue()
        Me.Text = Trans(399)
        Label2.Text = Trans(399)
        GroupBox1.Text = Trans(184)
        GroupBox2.Text = Trans(154)
        btnRefillJournalUpdate.Text = Trans(189)
        RadioButton1.Text = Trans(49)
        RadioButton2.Text = Trans(400)
        RadioButton3.Text = Trans(401)
        RadioButton4.Text = Trans(402)
        RadioButton5.Text = Trans(407)
        CheckBox1.Text = Trans(246)
        CheckBox2.Text = Trans(403)
        gbtnPrint.Text = Trans(141)
        CheckBox3.Text = Trans(385)
        imprimante.Items.Clear()
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            imprimante.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
        Next
        Try
            imprimante.Text = LireINI("imprimante", "journalremplissage")
            CheckBox1.Checked = LireIniBoolSmart("imprimante", "journalremplissagepaysage", False)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub imprimante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles imprimante.SelectedIndexChanged
        EcrireINI("imprimante", "journalremplissage", imprimante.Text)
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        EcrireINI("imprimante", "journalremplissagepaysage", CheckBox1.Checked)
    End Sub
    Public Function Rechlog(nom As String) As Integer
        Rechlog = -1
        For i As Integer = 0 To jlog.Rows.Count - 1
            If jlog.Rows(i)("nom") = nom Then
                Return i
            End If
        Next
    End Function
    Public Sub traite(s0 As String)
        Try
            dvj.RowFilter = ""
            Dim dd As Date
            Dim s As String() = s0.Split("|"c)
            Dim nummodule As Integer = Val(s(1))
            Select Case s(4)
                Case "login"
                    Dim ix As Integer = rechlog(s(5))
                    If ix = -1 Then
                        jlog.Rows.Add(s(5), s(3), s(2), "")
                    End If
                Case "logout"
                    Dim ix As Integer = rechlog(s(5))
                    If ix > -1 Then
                        jlog.Rows(ix)("flog") = s(2)
                    End If
                Case "debut remplissage"
                    '                 dvj.BeginInit()

                    Dim ch As String = MAINFORM.FieldAccess(nummodule, "numchambre")
                    Try
                        dd = s(2)
                    Catch ex As Exception
                        dd = Date.Parse(s(2), DateTimeFormatInfo.InvariantInfo)
                    End Try
                    's(2)
                    Dim trow As DataRow = jremp.NewRow
                    trow(0) = ch
                    trow(1) = s(3)
                    trow(2) = dd.TimeOfDay
                    trow(3) = "-"
                    trow(4) = "-"
                    trow(5) = ""
                    For j As Integer = 6 To 5 + baseproduit.dproduit.Rows.Count
                        trow(j) = 0
                    Next

                    'maj nbproduit
                    For i As Integer = 0 To MaxCountOfProducts - 1 '11
                        Dim tp As String = nomproduit(nummodule, i + 1).nom
                        For j As Integer = 6 To 5 + baseproduit.dproduit.Rows.Count
                            If tp = dj.Columns(j).HeaderText Then
                                Dim v As Integer = Val(s(5 + i))
                                If v < 0 Then v = 0
                                trow(j) += v
                                Exit For
                            End If
                        Next
                    Next
                    jremp.Rows.InsertAt(trow, 0)
                Case "fin remplissage"
                    Dim indx As Integer = -1
                    '                 dvj.BeginInit()
                    Dim ch As String = MAINFORM.FieldAccess(nummodule, "numchambre")
                    For k As Integer = 0 To jremp.Rows.Count - 1
                        If ch = jremp.Rows(k)(0) Then
                            If jremp.Rows(k)(3) = "-" Then
                                indx = k
                                Exit For
                            End If
                        End If
                    Next
                    If indx = -1 Then Exit Sub

                    'maj nbproduit
                    Try
                        dd = s(2)
                    Catch ex As Exception
                        dd = Date.Parse(s(2), DateTimeFormatInfo.InvariantInfo)
                    End Try

                    'dd = Date.Parse(s(2), System.Globalization.DateTimeFormatInfo.InvariantInfo) 's(2)
                    jremp.Rows(indx)(3) = dd.TimeOfDay
                    'calcul duree
                    Dim df As Date = dd 's(2)
                    Dim db As Date = jremp.Rows(indx)(2)
                    Dim tmp As String() = (df - db).ToString.Split(".")
                    jremp.Rows(indx)(4) = tmp(1)
                    For i As Integer = 0 To MaxCountOfProducts - 1 '11
                        Dim tp As String = nomproduit(nummodule, i + 1).nom
                        For j As Integer = 6 To 5 + baseproduit.dproduit.Rows.Count
                            If tp = dj.Columns(j).HeaderText Then
                                Dim v As Integer = Val(s(5 + i))
                                If v < 0 Then v = 0
                                Dim ec As Integer = v - Val(jremp.Rows(indx)(j))
                                '        If ch = "1001" Then MsgBox(v.ToString + "    jremp" + jremp.Rows(indx)(j).ToString + "    ec" + ec.ToString)
                                jremp.Rows(indx)(j) = ec
                                Exit For
                            End If
                        Next
                    Next
                    'test si perime
                    Dim p As Boolean = False
                    For j As Integer = 6 To 5 + baseproduit.dproduit.Rows.Count
                        If jremp.Rows(indx)(j) < 0 Then
                            p = True
                        End If
                    Next

                    'test si full
                    Dim f As Boolean = True
                    For i As Integer = 0 To MaxCountOfProducts - 1 '11
                        Dim tp As Integer = nomproduit(nummodule, i + 1).max
                        If tp <> Val(s(5 + i)) Then f = False
                    Next
                    If f = True Then
                        jremp.Rows(indx)(5) = Trans(400)
                    Else
                        If p = True Then
                            jremp.Rows(indx)(5) = Trans(402)
                        Else
                            jremp.Rows(indx)(5) = Trans(401)
                        End If
                    End If

            End Select
        Catch ex As Exception
        End Try
    End Sub
    Public Sub traitefin()
        Dim RefillsCount As Integer = 0    ' count of rooms of physical refilled
        Try

            'inverse les valeur du tableau
            For i As Integer = jremp.Rows.Count - 1 To 0 Step -1
                Dim nb As Boolean = False
                For j As Integer = 6 To 5 + baseproduit.dproduit.Rows.Count
                    '                    jremp.Rows(i)(j) *= -1
                    If jremp.Rows(i)(j) <> 0 Then nb = True
                Next
                'supp ligne a zero
                If nb = False And CheckBox2.Checked = True Then
                    jremp.Rows.RemoveAt(i)
                End If
            Next
            RadioButton4_CheckedChanged(Nothing, Nothing)
            dj.Sort(dj.Columns(2), ListSortDirection.Ascending)
        Catch ex As Exception

        End Try

        For i As Integer = 0 To jremp.Rows.Count - 1
            If jremp.Rows(i)(1) <> 99999 Then   ' DEZ 12.05.10 =0 if was refill without remote controls
                RefillsCount = RefillsCount + 1
            End If
        Next
        '   Dim ManualRefilled = (From tbl In jremp.AsEnumerable).Count(Function(p) p.Field(Of Integer)(1) = 99999)
        'Label2.Text = Label2.Text
        lblRefilledRoom.Text = " Refilled rooms count = " + RefillsCount.ToString

    End Sub
    Private Sub RefillJournalPerformClickAction()
        Dim el2 As String = "r" + Format(Year(d1.SelectionStart), "0000") + Format(Month(d1.SelectionStart), "00") + Format(DateAndTime.Day(d1.SelectionStart), "00")
        Label2.Text = Trans(399) + " " + d1.SelectionStart
        ' TOMAS check
        Try
            dvj.Table.Clear()
        Catch ex As Exception

        End Try
        table.AddEmis(0, "REFILL|" + el2)  'send message to Driver IRF
    End Sub
    Private Sub btnRefillJournalUpdate_Click(sender As Object, e As EventArgs) Handles btnRefillJournalUpdate.Click
        RefillJournalPerformClickAction()
    End Sub

    Public Function Nomproduit(nummodule As Integer, casier As Integer) As stockcasier
        nomproduit.nom = ""
        nomproduit.max = 0

        Dim m As String = ""
        m = Mainform.FieldAccess(nummodule, "modelefrigo")

        For i As Integer = 0 To basemodele.modele.Rows.Count - 1
            If basemodele.modele.Rows(i)("nom") = m Then
                nomproduit.nom = basemodele.modele.Rows(i)(casier)
                nomproduit.max = basemodele.modele.Rows(i)(casier + MaxCountOfProducts)
                Exit For
            End If
        Next
    End Function
    Private Sub journalrefill_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True And Not IsStarted Then
            Try
                clearjremp()
                jlog.Columns.Add("nom", Type.GetType("System.String"))
                jlog.Columns.Add("tel", Type.GetType("System.String"))
                jlog.Columns.Add("dlog", Type.GetType("System.String"))
                jlog.Columns.Add("flog", Type.GetType("System.String"))

                jremp.Columns.Add("nchambre1", Type.GetType("System.String"))
                jremp.Columns.Add("ntelecommande", Type.GetType("System.String"))
                jremp.Columns.Add("dremp", Type.GetType("System.String"))
                jremp.Columns.Add("fremp", Type.GetType("System.String"))
                jremp.Columns.Add("tremp", Type.GetType("System.String"))
                jremp.Columns.Add("etat", Type.GetType("System.String"))
                For i As Integer = 0 To baseproduit.dproduit.Rows.Count - 1
                    jremp.Columns.Add(baseproduit.dproduit.Item(1, i).Value.ToString, Type.GetType("System.String"))
                Next
                dj.Columns(0).HeaderText = Trans(28)
                dj.Columns(1).HeaderText = Trans(246)
                dj.Columns(2).HeaderText = Trans(367)
                dj.Columns(3).HeaderText = Trans(368)
                dj.Columns(4).HeaderText = Trans(284)
                dj.Columns(5).HeaderText = Trans(131)
                RefillJournalPerformClickAction()
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub clearjremp()
        jremp.Clear()
        jremp.Reset()
        jlog.Clear()
        jlog.Reset()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged, TextBox1.TextChanged, CheckBox1.CheckedChanged
        Dim fi As String = "etat<>''"
        If RadioButton2.Checked = True Then fi = "etat='" + Trans(400) + "' "
        If RadioButton3.Checked = True Then fi = "etat='" + Trans(401) + "' "
        If RadioButton4.Checked = True Then fi = "etat='" + Trans(402) + "' "
        If RadioButton5.Checked = True Then fi = "etat<>'" + Trans(402) + "' "

        If CheckBox1.Checked = True Then
            fi += "and ntelecommande='" + TextBox1.Text + "'"
        End If

        dvj.RowFilter = fi
        dj.Update()

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Me.Visible = True Then RefillJournalPerformClickAction()
    End Sub

    Private Sub gbtnPrint_Click(sender As Object, e As EventArgs) Handles gbtnPrint.Click
        Dim imp As New Imprimer(Me)
        imp.imprimante = imprimante.Text
        imp.imprime = "journalremplissage"
        imp.paysage = CheckBox3.Checked
        imp.go()
        imp.Show()
    End Sub
End Class