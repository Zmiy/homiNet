Imports System.ComponentModel
Imports System.Globalization

Public Class Basedlc
    ReadOnly _dvd As New DataView

    Private Sub basedlc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dlc.Columns.Add("nummodule", Type.GetType("System.String"))
        For i As Integer = 1 To MaxCountOfProducts
            For j As Integer = 1 To 6
                Dlc.Columns.Add("dlc_" + i.ToString() + "_" + j.ToString(), Type.GetType("System.String"))
            Next
        Next

        'dfrigo1.Columns.Clear()
        'dfrigo2.Columns.Clear()
        'Dim sCasier As String = String.Empty
        'For casier As Integer = 1 To MaxCountOfProducts
        '    sCasier = casier.ToString()
        '    dfrigo1.Columns.Add("Column" + sCasier, sCasier)
        '    dfrigo2.Columns.Add("Column" + sCasier, sCasier)
        'Next
        'dfrigo1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        'dfrigo1.ColumnHeadersHeight = 10


        'dfrigo2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        'dfrigo2.ColumnHeadersHeight = 10

        _dvd.Table = Dlc
        _dvd.Sort = "nummodule"

        dch.DataSource = Maintable
        dch.Sort(dch.Columns("numchambre"), ListSortDirection.Ascending)
        For i As Integer = 0 To dch.Columns.Count - 1
            dch.Columns(i).Visible = False
        Next
        Try
            dch.Columns("numchambre").Visible = True
            dch.Columns("nbconso").Visible = True
            dch.Columns("factureclient").Visible = True

        Catch ex As Exception

        End Try

        'For i As Integer = 1 To 6
        '    dfrigo1.Rows.Add()
        'Next
        'dfrigo2.Rows.Add()
        'dfrigo1.SelectedCells(0).Selected = False
        'dfrigo2.SelectedCells(0).Selected = False
        'dfrigo1.ScrollBars = ScrollBars.Horizontal
        'dfrigo1.HorizontalScrollingOffset = 10
        initlangue()
    End Sub

    Public Sub Initlangue()
        Text = Trans(312)
        dch.Columns("numchambre").HeaderText = Trans(15)
        dch.Columns("nbconso").HeaderText = Trans(342)
        dch.Columns("factureclient").HeaderText = Trans(345)
        Label1.Text = Trans(312)
        Label2.Text = Trans(313)
    End Sub
    Public Sub Adddlc(s As String())
        Dim i As Integer = _dvd.Find(s(1))
        If i < 0 Then
            Dim r As DataRow
            r = Dlc.NewRow
            r(0) = s(1)
            Dlc.Rows.Add(r)
            i = _dvd.Find(s(1))
        End If
        _dvd(i).BeginEdit()
        For j As Integer = 1 To MaxCountOfProducts * 6 '72  
            If (j + 1) < s.Length Then
                _dvd(i)(j) = s(j + 1)
            Else
                _dvd(i)(j) = ""
            End If
        Next
        _dvd(i).EndEdit()
    End Sub


    Private Sub dch_MouseClick(sender As Object, e As MouseEventArgs) Handles dch.MouseClick
        dfrigo1.ScrollBars = ScrollBars.Horizontal
        For i As Integer = 0 To 5
            For j As Integer = 0 To MaxCountOfProducts - 1
                dfrigo1.Rows(i).Cells(j).Style.BackColor = Color.White
                dfrigo1.Rows(i).Cells(j).Value = ""
                dfrigo2.Rows(0).Cells(j).Style.BackColor = Color.White
                dfrigo2.Rows(0).Cells(j).Value = ""
            Next
        Next
        'recherche modele frigo
        Dim m As Integer = -1
        For i As Integer = 0 To basemodele.modele.Rows.Count - 1
            If dch.CurrentRow.Cells("modelefrigo").Value = basemodele.modele.Rows(i)(0) Then
                m = i
                Exit For
            End If
        Next
        If m = -1 Then Exit Sub
        For i As Integer = 0 To MaxCountOfProducts - 1
            dfrigo1.Columns(i).HeaderText = basemodele.modele.Rows(m)(i + 1).ToString
        Next
        'color les non utilise
        For i As Integer = 0 To MaxCountOfProducts - 1 '11
            Dim n As Integer = Val(basemodele.modele.Rows(m)(i + MaxCountOfProducts + 1))
            For j As Integer = n To 5
                dfrigo1.Rows(j).Cells(i).Style.BackColor = Color.LightSteelBlue
            Next
        Next
        'recherche dlc
        Dim d As Integer = _dvd.Find(dch.CurrentRow.Cells("nummodule").Value)
        If d = -1 Then Exit Sub
        For i As Integer = 0 To MaxCountOfProducts - 1 '11
            For j As Integer = 0 To 5
                If dfrigo1.Rows(j).Cells(i).Style.BackColor <> BackColor Then
                    If _dvd(d)((i * 6) + 1 + j) <> "0" Then

                        Dim tempDateString As String = _dvd(d)((i * 6) + 1 + j)
                        'Dim temp As DateTime = DateTime.Parse(tempDateString, System.Globalization.DateTimeFormatInfo.InvariantInfo)

                        Dim dd As Date = DateTime.Parse(tempDateString, DateTimeFormatInfo.InvariantInfo) 'dvd(d)((i * 6) + 1 + j)


                        dfrigo1.Rows(j).Cells(i).Style.BackColor = Color.Green
                        dfrigo1.Rows(j).Cells(i).Value = dd.Subtract(Now).Days
                        If dfrigo1.Rows(j).Cells(i).Value < 0 Then
                            dfrigo1.Rows(j).Cells(i).Style.BackColor = Color.Red
                        End If
                    End If
                End If
            Next
        Next

        'total casier
        'ToDo: need decode Tray to values 
        For i As Integer = 0 To MaxCountOfProducts - 1 '11
            dfrigo2.Rows(0).Cells(i).Value = dch.CurrentRow.Cells("c" + (i + 1).ToString()).Value '(i + 49).Value
            If dfrigo2.Rows(0).Cells(i).Value < 0 Then
                dfrigo2.Rows(0).Cells(i).Style.BackColor = Color.Red
            Else
                dfrigo2.Rows(0).Cells(i).Style.BackColor = Color.LightGreen
            End If
            If dfrigo2.Rows(0).Cells(i).Value = 0 Then
                dfrigo2.Rows(0).Cells(i).Style.BackColor = Color.Orange
            End If
            If dfrigo1.Rows(0).Cells(i).Style.BackColor = Color.LightSteelBlue Then
                dfrigo2.Rows(0).Cells(i).Style.BackColor = Color.LightSteelBlue
                dfrigo2.Rows(0).Cells(i).Value = ""
            End If

        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Visible = True Then dch_MouseClick(Nothing, Nothing)
    End Sub

    Public Sub Returndlc(indx As Integer)
        For i As Integer = 0 To 5
            For j As Integer = 0 To MaxCountOfProducts - 1 '11
                dfrigo1.Rows(i).Cells(j).Style.BackColor = Color.White
                dfrigo1.Rows(i).Cells(j).Value = ""
                dfrigo2.Rows(0).Cells(j).Style.BackColor = Color.White
                dfrigo2.Rows(0).Cells(j).Value = ""
            Next
        Next
        'recherche modele frigo
        Dim m As Integer = -1
        For i As Integer = 0 To basemodele.modele.Rows.Count - 1
            If dch.Rows(indx).Cells("modelefrigo").Value = basemodele.modele.Rows(i)(0) Then
                m = i
                Exit For
            End If
        Next
        If m = -1 Then Exit Sub
        For i As Integer = 0 To MaxCountOfProducts - 1 '11
            dfrigo1.Columns(i).HeaderText = basemodele.modele.Rows(m)(i + 1).ToString
        Next
        'color les non utilise
        For i As Integer = 0 To MaxCountOfProducts - 1 '11
            Dim n As Integer = Val(basemodele.modele.Rows(m)(i + MaxCountOfProducts + 1))
            For j As Integer = n To 5
                dfrigo1.Rows(j).Cells(i).Style.BackColor = Color.LightSteelBlue
            Next
        Next
        'recherche dlc
        Dim d As Integer = _dvd.Find(dch.Rows(indx).Cells("nummodule").Value)
        If d = -1 Then Exit Sub
        For i As Integer = 0 To MaxCountOfProducts - 1 '11
            For j As Integer = 0 To 5
                If dfrigo1.Rows(j).Cells(i).Style.BackColor <> BackColor Then
                    If _dvd(d)((i * 6) + 1 + j) <> "0" And Not String.IsNullOrEmpty(_dvd(d)((i * 6) + 1 + j)) Then
                        Dim dd As Date
                        Try
                            dd = DateTime.Parse(_dvd(d)((i * 6) + 1 + j), DateTimeFormatInfo.InvariantInfo) 'dvd(d)((i * 6) + 1 + j)
                        Catch
                            dd = _dvd(d)((i * 6) + 1 + j)
                        End Try
                        dfrigo1.Rows(j).Cells(i).Style.BackColor = Color.Green
                        dfrigo1.Rows(j).Cells(i).Value = dd.Subtract(Now).Days
                        If dfrigo1.Rows(j).Cells(i).Value < 0 Then
                            dfrigo1.Rows(j).Cells(i).Style.BackColor = Color.Red
                        End If
                    End If
                End If
            Next
        Next

        'total casier
        For i As Integer = 0 To MaxCountOfProducts - 1 '11
            dfrigo2.Rows(0).Cells(i).Value = dch.Rows(indx).Cells("c" + (i + 1).ToString).Value 'Cells(i + 49).Value
            If dfrigo2.Rows(0).Cells(i).Value < 0 Then
                dfrigo2.Rows(0).Cells(i).Style.BackColor = Color.Red
            Else
                dfrigo2.Rows(0).Cells(i).Style.BackColor = Color.LightGreen
            End If
            If dfrigo2.Rows(0).Cells(i).Value = 0 Then
                dfrigo2.Rows(0).Cells(i).Style.BackColor = Color.Orange
            End If
            If dfrigo1.Rows(0).Cells(i).Style.BackColor = Color.LightSteelBlue Then
                dfrigo2.Rows(0).Cells(i).Style.BackColor = Color.LightSteelBlue
                dfrigo2.Rows(0).Cells(i).Value = ""
            End If

        Next

    End Sub

    Private Sub basedlc_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Dim a As String = ""

    End Sub

    Private Sub basedlc_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        If Visible = True Then
            'InitializeComponent()
            dfrigo1.Columns.Clear()
            dfrigo2.Columns.Clear()
            Dim sCasier As String '= String.Empty
            For casier As Integer = 1 To MaxCountOfProducts
                sCasier = casier.ToString()
                dfrigo1.Columns.Add("Column" + sCasier, sCasier)
                dfrigo2.Columns.Add("Column" + sCasier, sCasier)
            Next
            dfrigo1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            'dfrigo1.ColumnHeadersHeight = 10


            dfrigo2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            'dfrigo2.ColumnHeadersHeight = 10

            For i As Integer = 1 To 6
                dfrigo1.Rows.Add()
            Next
            dfrigo2.Rows.Add()
            dfrigo1.SelectedCells(0).Selected = False
            dfrigo2.SelectedCells(0).Selected = False
            'dfrigo1.ScrollBars = ScrollBars.Both
            'dfrigo1.HorizontalScrollingOffset = 10

            'dfrigo1.Rows(0).Cells(MaxCountOfProducts - 1).Selected = True
        End If
    End Sub

    Private Sub dfrigo1_Scroll(sender As Object, e As ScrollEventArgs) Handles dfrigo1.Scroll
        Dim dgv As DataGridView = CType(sender, DataGridView)
        If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
            dfrigo2.HorizontalScrollingOffset = dgv.HorizontalScrollingOffset
        End If
    End Sub

End Class