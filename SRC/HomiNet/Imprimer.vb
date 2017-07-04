Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO

Public Class Imprimer
    Public Imprime As String = ""
    Public Imprimante As String = ""
    Private ReadOnly _psd As New PageSettings
    Private _dx As Single = 0
    Private _dy As Single = 0
    Private _l As Single = 0
    Private _h As Single = 0
    Public Paysage As Boolean = False
    Private _index As Integer = 0
    Public UserTop As Integer = 0 'top
    Public UserLeft As Integer = 0 'left
    Public Pret As Boolean = False
    Private _neededqtyIndex As Integer = 0
    Private _xFirst As Single

    Public Sub New(ByVal ownr As Form)
        InitializeComponent()
        Me.Owner = ownr
    End Sub
    'DEZ 20.05.10
    Private _dgvTableRemp As New DataGridView()
    'Private _dvTableRemp As DataView = Nothing
    Private ReadOnly _dvForPrint As New DataView
    'Private _isFloorNumberPrinted As Boolean = False
    Private _currFloor As String = String.Empty, _nextFloor As String = String.Empty
    Public Property DgvTableRemp() As DataGridView
        Private Get
            Return _dgvTableRemp
        End Get
        Set(value As DataGridView)
            Dim dgvTmp As DataGridView = value
            _dgvTableRemp = dgvTmp.Clone
            'Dim arrForCopyRows(dgvTmp.Rows.Count - 1) As DataGridViewRow
            Dim soDirection As SortOrder   'SortOrder
            'Dim newColumn As DataGridViewColumn = dgvTmp.Columns(0)
            soDirection = dgvTmp.Columns(0).HeaderCell.SortGlyphDirection
            'Dim arrTemplateCol(dgvTmp.Columns.Count - 1) As DataGridViewColumn
            'dgvTmp.Columns.CopyTo(arrTemplateCol, 0)
            'dgvTableRemp.Columns.AddRange(arrTemplateCol)
            'For Each col As DataGridViewColumn In dgvTmp.Columns
            '    dgvTableRemp.Columns.Add(col.Clone())
            'Next

            'dgvTmp.Rows.CopyTo(arrForCopyRows, 0)
            'For Each dgvrCurrent As DataGridViewRow In arrForCopyRows
            '    dgvTableRemp.Rows.Add(CloneWithValues(dgvrCurrent))
            'Next
            'If newColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
            '    soDirection = SortOrder.None
            'ElseIf newColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
            '    soDirection = SortOrder.Ascending
            'Else
            '    soDirection = SortOrder.Descending
            'End If
            If soDirection = SortOrder.None Then
                'newColumn.SortMode = DataGridViewColumnSortMode.Automatic
                _dgvTableRemp.Sort(_dgvTableRemp.Columns(0), CType(soDirection, ListSortDirection))
            Else
                _dgvTableRemp.Columns(0).SortMode = DataGridViewColumnSortMode.Programmatic
                _dgvTableRemp.Sort(New RowComparer(soDirection))
            End If
        End Set
    End Property
    '    public DataGridViewRow CloneWithValues(DataGridViewRow row)
    '{
    '    DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
    '    for (Int32 index = 0; index < row.Cells.Count; index++)
    '    {
    '        clonedRow.Cells[index].Value = row.Cells[index].Value;
    '    }
    '    return clonedRow;
    '}

    Private Function CloneWithValues(row As DataGridViewRow) As DataGridViewRow
        Dim clonedRow As DataGridViewRow = row.Clone()
        For i As Integer = 0 To row.Cells.Count - 1
            clonedRow.Cells(i).Value = row.Cells(i).Value
        Next
        Return clonedRow
    End Function

    Public Property DvForPrint() As DataTable
        Set(value As DataTable)
            Dim tmp As DataTable = value
            _dvForPrint.Table = tmp.Copy()
        End Set
        Private Get
            _dvForPrint.Sort = "numchambre"
            Return _dvForPrint.Table
        End Get
    End Property

    
    'Public WriteOnly Property TableRempDataSource() As DataGridView
    '    Set(value)
    '        dgvTableRemp.DataSource = value
    '    End Set
    'End Property

    Private Sub Imprimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initlangue()
        Try
            'Me.Top = LireINI("imprimer", "top")
            'Me.Left = LireINI("imprimer", "left")
            'Me.Height = LireINI("imprimer", "height")
            'Me.Width = LireINI("imprimer", "width")
            textBox1.Text = LireINI("imprimer", "zoom")
            If Not String.IsNullOrEmpty(textBox1.Text) Then
                trackBar1.Value = Val(textBox1.Text)
            Else
                trackBar1.Value = 80.0
            End If
            trackBar1_Scroll(trackBar1, Nothing)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Initlangue()
        label25.Text = Trans(142)
        Text = Trans(144)
        gbtnClosePreview.Text = Trans(34)
    End Sub
    Private Sub GlassButton6_Click(sender As Object, e As EventArgs) Handles gbtnClosePreview.Click
        Me.Close()
    End Sub
    Private Sub Zoom(sender As Object, e As EventArgs) Handles GlassButton4.Click, GlassButton3.Click, GlassButton2.Click, GlassButton1.Click
        Select Case sender.tag
            Case 1
                PP1.Columns = 1
                PP1.Rows = 1
                PP1.AutoZoom = True
                PP1.Refresh()
                trackBar1.Value = PP1.Zoom * 100
            Case 2
                PP1.Columns = 1
                PP1.Rows = 1
                If Val(textBox1.Text) > 10 And textBox1.Text < 201 Then PP1.Zoom = Val(textBox1.Text) / 100
                PP1.Refresh()
                trackBar1.Value = PP1.Zoom * 100
            Case 3
                PP1.Columns = 2
                PP1.Rows = 1
                PP1.AutoZoom = True
                PP1.Refresh()
                trackBar1.Value = PP1.Zoom * 100
            Case 4
                PP1.Columns = 2
                PP1.Rows = 2
                PP1.AutoZoom = True
                PP1.Refresh()
                trackBar1.Value = PP1.Zoom * 100
        End Select
    End Sub
    Private Sub trackBar1_Scroll(sender As Object, e As EventArgs) Handles trackBar1.Scroll
        textBox1.Text = sender.value
        PP1.Zoom = sender.value / 100
        PP1.Refresh()
    End Sub
    Public Sub Go()
        _psd.Landscape = Paysage
        Dim ops As New PrinterSettings
        Try
            If Imprimante = "" Then
                Imprimante = ops.PrinterName  'PrinterSettings.InstalledPrinters.Item(0)
            End If

            _psd.PrinterSettings.PrinterName = Imprimante
            'psd.Margins
        Catch ex As Exception
            _psd.PrinterSettings.PrinterName = ops.PrinterName 'PrinterSettings.InstalledPrinters.Item(0)
        End Try

        'Dim ps As PaperSize
        'For ix As Integer = 0 To _psd.PrinterSettings.PaperSizes.Count - 1
        '    If _psd.PrinterSettings.PaperSizes(ix).Kind = PaperKind.A4 Then
        '        ps = _psd.PrinterSettings.PaperSizes(ix)
        '    End If
        'Next

        _psd.Margins = New Margins(25, 30, 30, 25)

        '_psd.Margins.Top = Math.Max(_psd.PrintableArea.Top, 45)
        '_psd.Margins.Left = _psd.PrintableArea.Left
        '_psd.Margins.Right = _psd.PrintableArea.Right
        '_psd.Margins.Bottom = _psd.PrintableArea.Bottom

        '        IEnumerable<PaperSize> paperSizes = settings.PaperSizes.Cast<PaperSize>();
        'PaperSize sizeA5 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A5);
        'PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4);
        'settings.DefaultPageSettings.PaperSize = sizeA5; 

        Dim paperSizes As IEnumerable(Of PaperSize) = _psd.PrinterSettings.PaperSizes.Cast(Of PaperSize)()
        Dim ps As PaperSize = paperSizes.First(Function(sizeP) sizeP.Kind = PaperKind.A4)
        If Doc Is Nothing Then
            Doc = New PrintDocument()
        End If
        Doc.PrinterSettings = _psd.PrinterSettings
        Doc.DefaultPageSettings.PaperSize = ps
        Doc.DefaultPageSettings = _psd
        PP1.Document = Doc
        WindowState = CInt(LireIniSmart("imprimer", "WindowState", CInt(FormWindowState.Normal)))
        'Show()

    End Sub

    Dim _action As PrintAction = PrintAction.PrintToPreview
    Private Sub Doc_BeginPrint(sender As Object, e As PrintEventArgs) Handles Doc.BeginPrint
        Doc.OriginAtMargins = False
        'Doc.DefaultPageSettings.Landscape = Paysage
        _action = e.PrintAction
        If Paysage = False Then 'Portrait
            _dx = _psd.PrintableArea.Left
            _dy = _psd.PrintableArea.Top
            _l = (_psd.PrintableArea.Right - _psd.PrintableArea.Left) 'psd.PrintableArea.Width 
            _h = (_psd.PrintableArea.Bottom - _psd.PrintableArea.Top)
        Else 'landscape
            _dy = _psd.PrintableArea.Left
            _dx = _psd.PrintableArea.Top
            _h = (_psd.PrintableArea.Right - _psd.PrintableArea.Left)
            _l = (_psd.PrintableArea.Bottom - _psd.PrintableArea.Top) 'psd.PrintableArea.Height
        End If


        Page = 1
        _index = 0
        listpage.Items.Clear()
        listpage.Items.Add(Page.ToString)
        listpage.SelectedIndex = 0
    End Sub

    Public Function GetBestPrintableArea(e As PrintPageEventArgs) As RectangleF

        Dim marginBounds As RectangleF = e.MarginBounds
        Dim printableArea As RectangleF = e.PageSettings.PrintableArea
        Dim pageBounds As RectangleF = e.PageBounds

        If (e.PageSettings.Landscape) Then
            printableArea = New RectangleF(printableArea.Y, printableArea.X, printableArea.Height, printableArea.Width)
        End If

        Dim bestArea As RectangleF = RectangleF.FromLTRB(
            Math.Max(marginBounds.Left, printableArea.Left),
            Math.Max(marginBounds.Top, printableArea.Top),
            Math.Min(marginBounds.Right, printableArea.Right),
            Math.Min(marginBounds.Bottom, printableArea.Bottom)
        )

        Dim bestMarginX As Single = Math.Max(bestArea.Left, pageBounds.Right - bestArea.Right)
        Dim bestMarginY As Single = Math.Max(bestArea.Top, pageBounds.Bottom - bestArea.Bottom)
        bestArea = RectangleF.FromLTRB(
                bestMarginX,
                bestMarginY,
                pageBounds.Right - bestMarginX,
                pageBounds.Bottom - bestMarginY
            )

        Return bestArea
    End Function
    Dim bestPArea As RectangleF

    Private Sub Doc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Doc.PrintPage

        'If _action = PrintAction.PrintToPreview Then
        '    e.Graphics.TranslateTransform(e.PageSettings.PrintableArea.X, e.PageSettings.PrintableArea.Y)
        'End If
        'If Not _action = PrintAction.PrintToPreview Then
        '    e.Graphics.TranslateTransform(-e.PageSettings.HardMarginX, -e.PageSettings.HardMarginY)
        'End If
        'Dim bestPrintArea As RectangleF = GetBestPrintableArea(e)
        '_dx = bestPrintArea.Left
        '_dy = bestPrintArea.Top
        '_l = bestPrintArea.Width
        '_h = bestPrintArea.Height

        'If Paysage = False Then 'Portrait
        '    _dx = _psd.PrintableArea.Left
        '    _dy = _psd.PrintableArea.Top
        '    _l = (_psd.PrintableArea.Right - _psd.PrintableArea.Left) 'psd.PrintableArea.Width 
        '    _h = (_psd.PrintableArea.Bottom - _psd.PrintableArea.Top)
        'Else 'landscape
        '    _dy = _psd.PrintableArea.Left
        '    _dx = _psd.PrintableArea.Top
        '    _h = (_psd.PrintableArea.Right - _psd.PrintableArea.Left)
        '    _l = (_psd.PrintableArea.Bottom - _psd.PrintableArea.Top) - 2 'psd.PrintableArea.Height
        'End If

        Select Case Imprime
            Case "journalremplissage"
                Printpagejournalremplissage(e)
            Case "perime"
                Printpageperime(e)
            Case "Total"
                Printpageremplissage(e)
            Case "remplissage"
                'printpageremplissage(e)
                'bestPArea = GetBestPrintableArea(e)
                Select Case LireIniBoolSmart("imprimer", "UsingOldStyleOfRefillList", False)
                    Case True
                        Printpageremplissage2(e)
                    Case False
                        Printpageremplissage4(e)
                End Select

            Case "note"
                Printpagenote(e)
            Case "facture"
                Printpagefacture(e)
            Case "xy"
                Printpagexy(e)
            Case "system"
                Printpagesystem(e)
            Case "interface"
                Printpageinterface(e)
            Case "information"
                Printpageinformation(e)
            Case "warning"
                Printpagewarning(e)
        End Select
    End Sub
    Private Sub Doc_EndPrint(sender As Object, e As PrintEventArgs) Handles Doc.EndPrint
        Me.Activate()
    End Sub

#Region "imprime"
    Private Sub Printpagejournalremplissage(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 10
        If Paysage = True Then dp = 14
        Dim ty As Integer = _dy
        Dim tx As Integer = _dx
        e.Graphics.DrawString(Now + " " + Nomhotel + " " + Mainform.Label4.Text, Farial8, Brushes.Black, _dx, ty)
        e.Graphics.DrawString(journalrefill.Label2.Text, Farial8, Brushes.Black, _l / 2, ty)
        e.Graphics.DrawString(Trans(142) + ": " + Page.ToString, Farial8, Brushes.Black, _l * 0.9, ty)
        e.Graphics.DrawRectangle(Pens.Black, _dx, ty, _l, 16)
        ty += 24

        'imprime logon
        For i As Integer = 0 To journalrefill.jlog.Rows.Count - 1
            tx += _l / dp
            e.Graphics.DrawString(journalrefill.jlog.Rows(i)(0), Farial10, Brushes.Black, tx, ty)
            ty += 2
            tx += _l / dp
            e.Graphics.DrawString(journalrefill.jlog.Rows(i)(1), Farial8, Brushes.Black, tx, ty)
            tx += _l / dp
            e.Graphics.DrawString(journalrefill.jlog.Rows(i)(2), Farial8, Brushes.Black, tx, ty)
            tx += 2 * (_l / dp)
            e.Graphics.DrawString(journalrefill.jlog.Rows(i)(3), Farial8, Brushes.Black, tx, ty)
            tx = _dx
            ty += 16
        Next
        ty += 16
        e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)

        Do Until _index = journalrefill.dj.Rows.Count
            'print chambre
            tx = _dx
            e.Graphics.DrawString(journalrefill.dj.Item(0, _index).Value, Farial12, Brushes.Black, tx, ty)
            tx = (_l / 12)
            e.Graphics.DrawString(journalrefill.dj.Item(2, _index).Value + " - " + journalrefill.dj.Item(3, _index).Value + "   " + journalrefill.dj.Item(4, _index).Value, Farial8, Brushes.Black, tx, ty)
            tx += (_l / dp)
            tx += (_l / dp)
            e.Graphics.DrawString(journalrefill.dj.Item(5, _index).Value, Farial10, Brushes.Black, tx, ty)
            tx += (_l / dp)
            For i As Integer = 6 To journalrefill.dj.Columns.Count - 1
                If Val(journalrefill.dj.Item(i, _index).Value) <> 0 Then
                    e.Graphics.DrawString(journalrefill.dj.Item(i, _index).Value.ToString + " " + journalrefill.dj.Columns(i).HeaderText, Farial8, Brushes.Black, tx, ty)
                    tx = tx + (_l / dp)
                    If tx >= _l Then
                        tx = 4 * (_l / dp)
                        ty += 16
                    End If
                End If
            Next
            _index += 1
            ty += 16
            If ty > _dy + _h Then Exit Do
            e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
            ty += 2
            If ty + 16 > _dy + _h Then Exit Do
        Loop

        If _index < journalrefill.dj.Rows.Count Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = 48 + ((journalrefill.dj.Columns.Count / (dp - 1)) * 16)
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                ty += 16
                e.Graphics.DrawString(Trans(386) + ": " + journalrefill.dj.Rows.Count.ToString, Farial10, Brushes.Black, _dx, ty)
                ty += 16
                e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                tx = 2 * (_l / dp)
                e.Graphics.DrawString(Trans(387), Farial10, Brushes.Black, _dx, ty)
                For i As Integer = 6 To journalrefill.dj.Columns.Count - 1
                    Dim t As Integer = 0
                    For j As Integer = 0 To journalrefill.dj.Rows.Count - 1
                        t += journalrefill.dj.Item(i, j).Value
                    Next
                    e.Graphics.DrawString(t.ToString + " " + journalrefill.dj.Columns(i).HeaderText, Farial8, Brushes.Black, tx, ty)
                    tx = tx + (_l / dp)
                    If tx > (_l - dp) Then
                        tx = _l / dp
                        ty += 16
                    End If
                Next

                e.HasMorePages = False
                Pret = True
            End If
        End If

    End Sub
    Private Sub Printpagewarning(e As PrintPageEventArgs)
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Integer = _dy
        Dim tx As Integer = _dx
        Dim tableWarrning As DataTable = DvForPrint
        tableWarrning.DefaultView.Sort = "numchambre"
        e.Graphics.DrawString(Now + " " + Nomhotel, Farial8, Brushes.Black, _dx, ty)
        e.Graphics.DrawString("Troubles list", Farial8, Brushes.Black, _l / 2, ty)
        e.Graphics.DrawString(Trans(142) + ": " + Page.ToString, Farial8, Brushes.Black, _l * 0.9, ty)
        e.Graphics.DrawRectangle(Pens.Black, _dx, ty, _l, 16)
        ty += 16

        Dim rowsCountToPrint As Integer = tableWarrning.DefaultView.Count '  Rows.Count 'TableRemp.Rows.Count
        Dim columnsCountToPrint As Integer = tableWarrning.Columns.Count 'TableRemp.Columns.Count

        '  to use in MeasureText
        Const Flags As TextFormatFlags = TextFormatFlags.NoPadding
        ' Declare a proposed size with dimensions set to the maximum integer value.
        Dim proposedSize As Size = New Size(Integer.MaxValue, Integer.MaxValue)
        'nextFloor = TableRemp.Item(0, 0).Value.ToString.Substring(0, IIf(Len(TableRemp.Item(0, 0).Value) > 3, 2, 1))
        _nextFloor = tableWarrning.DefaultView(0)(0).ToString().Substring(0, IIf(Len(tableWarrning.DefaultView(0)(0)) > 3, 2, 1))
        Dim arrWidth(columnsCountToPrint) As Integer
        Dim tmpFont As Font = Farial12
        Dim max As Integer = 0
        For i As Integer = 0 To columnsCountToPrint - 1
            max = tableWarrning.DefaultView(0)(i).ToString().Length()
            arrWidth(i) = 0
            For j As Integer = 1 To rowsCountToPrint - 1
                If tableWarrning.DefaultView(j)(i).ToString().Length() > max Then
                    max = tableWarrning.DefaultView(j)(i).ToString().Length()
                    arrWidth(i) = j 'TableRemp.Rows(0).Cells(i).Value.ToString().Length()
                End If
            Next

            Dim sizeM As Size = TextRenderer.MeasureText(e.Graphics, tableWarrning.DefaultView(arrWidth(i))(i).ToString(), tmpFont, proposedSize, Flags)
            arrWidth(i) = sizeM.Width + 10

            tmpFont = Farial10
        Next
        Dim vOffset As Integer = (Farial12.Height - Farial10.Height) / 2
        Do Until _index = rowsCountToPrint
            tx = _dx
            'start printing floor N before next floor
            'nextFloor = TableRemp.Item(0, index).Value.ToString.Substring(0, IIf(Len(TableRemp.Item(0, index).Value) > 3, 2, 1))
            _nextFloor = tableWarrning.DefaultView(_index)(0).ToString().Substring(0, IIf(Len(tableWarrning.DefaultView(_index)(0)) > 3, 2, 1))
            If _currFloor <> _nextFloor Then
                e.Graphics.DrawString("  Floor: " + _nextFloor, Farial12Ib, Brushes.Black, tx, ty)
                _currFloor = _nextFloor
                ty += Farial12Ib.Height + 2 '16
                e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                ty += 2
            End If
            ' end printing

            '' Measure each string with its font and NoPadding value and draw it to the form.
            'For i As Integer = 0 To stringsToPaint.Length - 1
            '    Dim size As Size = TextRenderer.MeasureText(e.Graphics, _
            '        stringsToPaint(i), fonts(i), proposedSize, flags)
            '    Dim rect As Rectangle = New Rectangle(startPoint, size)
            '    TextRenderer.DrawText(e.Graphics, stringsToPaint(i), fonts(i), _
            '        startPoint, Color.Black, flags)
            '    startPoint.X += size.Width
            'Next
            'Dim size As Size = TextRenderer.MeasureText(e.Graphics, TableRemp.Item(0, index).Value, f2, proposedSize, flags)
            'e.Graphics.DrawString(TableRemp.Item(0, index).Value, f2, Brushes.Black, tx, ty)
            e.Graphics.DrawString(tableWarrning.DefaultView(_index)(0), Farial12, Brushes.Black, tx, ty)
            'tx = L / dp
            'tx += (arrWidth(0) + 10) * f0.Size()
            tx += arrWidth(0)
            For i As Integer = 1 To columnsCountToPrint - 1
                'size = TextRenderer.MeasureText(e.Graphics, TableRemp.Item(i, index).Value, f2, proposedSize, flags)
                'e.Graphics.DrawString(TableRemp.Item(i, index).Value.ToString, f1, Brushes.Black, tx, ty + vOffset)
                e.Graphics.DrawString(tableWarrning.DefaultView(_index)(i).ToString, Farial10, Brushes.Black, tx, ty + vOffset)
                'If tx + TableRemp.Item(i, index).Value.ToString().Length < tx + (L / dp) Then
                '    tx = tx + (L / dp)
                'Else
                '    tx = tx + TableRemp.Item(i, index).Value.ToString().Length * f0.SizeInPoints()
                'End If
                'tx = tx + (L / dp)
                'tx += (arrWidth(i) + 10) * f0.Size()
                tx += arrWidth(i)
                If tx >= _l Then
                    tx = _l / dp
                    ty += Farial12.Height + 2 '16
                End If
            Next
            _index += 1
            ty += Farial12.Height + 2 '16
            If ty > _dy + _h Then Exit Do
            e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
            ty += 2
            If ty + Farial12.Height > _dy + _h - 10 Then Exit Do
            '        End If

        Loop
        'If index < remplissage.DGRemp.Rows.Count Then DEZ 19/05/10
        If _index < rowsCountToPrint Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = Farial10.Height + 3 + ((columnsCountToPrint / (dp - 1)) * Farial10.Height)
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                ty += Farial10.Height
                ''e.Graphics.DrawString(trans(386) + ": " + remplissage.DGRemp.Rows.Count.ToString, f1, Brushes.Black, dx, ty) DEZ 19/05/10
                e.Graphics.DrawString(Trans(386) + ": " + rowsCountToPrint.ToString(), Farial10, Brushes.Black, _dx, ty)
                'ty += 16
                'e.Graphics.DrawLine(Pens.Black, dx, ty, dx + L, ty)
                'tx = L / dp
                'e.Graphics.DrawString(trans(387), f1, Brushes.Black, dx, ty)
                'For i As Integer = 1 To ColumnsCountToPrint - 1
                '    Dim t As Integer = 0
                '    'For j As Integer = 0 To remplissage.DGRemp.Rows.Count - 1 DEZ 19/05/10
                '    For j As Integer = 0 To RowsCountToPrint - 1
                '        t += TableRemp.Item(i, j).Value
                '    Next
                '    e.Graphics.DrawString(t.ToString + " " + TableRemp.Columns(i).HeaderText, f0, Brushes.Black, tx, ty)
                '    tx = tx + (L / dp)
                '    If tx >= L Then
                '        tx = L / dp
                '        ty += 16
                '    End If
                'Next
                e.HasMorePages = False
                Pret = True
            End If
        End If

    End Sub
    Private Function PrintFloorN(e As PrintPageEventArgs, tx As Single, ty As Single) As Single
        Dim result As Single = ty
        Dim sPrintString As String = DgvTableRemp.Item(0, _index).Value.ToString().PadLeft(3, "0")
        _nextFloor = sPrintString.ToString().Substring(0, IIf(Len(DgvTableRemp.Item(0, _index).Value.ToString().DigitsOnly()) > 3, 2, 1))
        If _currFloor <> _nextFloor Then
            e.Graphics.DrawString("  Floor: " + _nextFloor, Farial12Ib, Brushes.Black, tx, ty)
            _currFloor = _nextFloor
            result += Farial12Ib.Height + 2
            'ty += Farial12Ib.Height + 2 '16
            'If ty > dy + H Then Exit Do
            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, result, e.MarginBounds.Right, result)
            result += 2
        End If
        Return result
    End Function
    '    static public int MeasureDisplayStringWidth(Graphics graphics, string text, Font font)
    '{
    '    System.Drawing.StringFormat format  = new System.Drawing.StringFormat ();
    '    System.Drawing.RectangleF   rect    = new System.Drawing.RectangleF(0, 0, 1000, 1000);
    '    var ranges  = new System.Drawing.CharacterRange(0, text.Length);
    '    System.Drawing.Region[] regions = new System.Drawing.Region[1];

    '    format.SetMeasurableCharacterRanges (ranges);

    '    regions = graphics.MeasureCharacterRanges (text, font, rect, format);
    '    rect    = regions[0].GetBounds (graphics);

    '    return (int)(rect.Right + 1.0f);
    '}

    Private Shared Function MeasureDisplayString(graphics As Graphics, measuredText As String, measuredFont As Font) As SizeF
        Dim strFormat As StringFormat = New StringFormat()
        Dim rect As RectangleF = New RectangleF(0, 0, 1000, 1000)
        Dim ranges As CharacterRange = New CharacterRange(0, measuredText.Length)
        Dim regions As Region() = New Region() {}
        strFormat.SetMeasurableCharacterRanges(New CharacterRange() {ranges})
        regions = graphics.MeasureCharacterRanges(measuredText, measuredFont, rect, strFormat)
        rect = regions(0).GetBounds(graphics)
        Return New SizeF(rect.Right, rect.Bottom)
    End Function

    Private Sub printpageremplissageOld(ByVal e As System.Drawing.Printing.PrintPageEventArgs) 'old stile
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Single = _dy
        Dim tx As Single = _dx
        Dim xShift As Integer = CInt(_l / dp)
        '--------------------------------
        'ty += (3 + My.Resources.HomiLogoN_H150.Height)
        'Dim imX As Single = (e.PageBounds.Width - My.Resources.HomiLogoN_H150.Width) / 2
        'e.Graphics.DrawImage(My.Resources.HomiLogoN_H150, imX, 1)
        'e.Graphics.DrawString(Now + " " + Nomhotel + " " + Mainform.Label4.Text, f0, Brushes.Black, dx, ty)
        'e.Graphics.DrawString(Trans(55), f0, Brushes.Black, L / 2, ty)
        'e.Graphics.DrawString(Trans(142) + ": " + Page.ToString, f0, Brushes.Black, L * 0.9, ty)
        'e.Graphics.DrawRectangle(Pens.Black, dx, ty, L, 16)
        'ty += 16

        Dim newImage As Image = My.Resources.Homi_hewLogoForPrint2
        e.Graphics.DrawImage(newImage, e.MarginBounds.Left, e.MarginBounds.Top, newImage.Width, newImage.Height)
        Dim y As Single = (newImage.Height - Farial10B.Height) / 2 + e.MarginBounds.Top
        e.Graphics.DrawString(DateTime.Now + " " + Nomhotel + " " + Mainform.Label4.Text + vbTab + Trans(55) + vbTab + Trans(142) + ": " + Page.ToString, Farial10B, Brushes.Black, e.MarginBounds.Left + newImage.Width + 10, y)
        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds.Left + newImage.Width + 5, y, e.MarginBounds.Width - newImage.Width, Farial10B.Height + 2) 'realWidth + 5, 6, _dx + _l - realWidth, 20)

        ty = e.MarginBounds.Top + newImage.Height + 10

        Dim rowsCountToPrint As Integer = _dgvTableRemp.Rows.Count
        Dim columnsCountToPrint As Integer = _dgvTableRemp.Columns.Count

        Dim sPrintString As String = String.Empty '_dgvTableRemp.Item(0, 0).Value.ToString().PadLeft(3, "0")
        Dim sVacant As String = String.Empty

        Dim vOffset As Integer = (Farial12.Height - Farial8.Height) / 2
        Dim meassure As SizeF = New SizeF(0, 0) 'Single = Single.MinValue
        Dim isNeedReturnCarret As Boolean

        Do Until _index = rowsCountToPrint
            'print chambre
            tx = _dx
            isNeedReturnCarret = False
            'start printing floor N before next floor
            If ty + Farial12Ib.Height * 2 + 4 > _dy + _h Then Exit Do
            sPrintString = _dgvTableRemp.Item(0, _index).Value.ToString().PadLeft(3, "0")
            _nextFloor = sPrintString.ToString().Substring(0, IIf(Len(_dgvTableRemp.Item(0, _index).Value.ToString().DigitsOnly()) > 3, 2, 1))
            If _currFloor <> _nextFloor Then
                e.Graphics.DrawString("  Floor: " + _nextFloor, Farial12Ib, Brushes.Black, tx, ty)
                _currFloor = _nextFloor
                ty += Farial12Ib.Height + 2 '16
                If ty > _dy + _h Then Exit Do
                e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                ty += 2
            End If
            ' end printing floor N
            sPrintString = String.Empty
            If ty + Farial12.Height + 2 > _dy + _h Then Exit Do 'If more than page height
            If String.Compare(DgvTableRemp.Item(1, _index).Value.ToString.ToUpper(), "CHECK OUT", StringComparison.Ordinal) = 0 Then
                sVacant = "Vac"
            Else
                sVacant = String.Empty
            End If
            sPrintString = String.Format("{0} {1}", _dgvTableRemp.Item(0, _index).Value, sVacant)
            e.Graphics.DrawString(sPrintString, Farial12, Brushes.Black, tx, ty)
            meassure = e.Graphics.MeasureString(sPrintString, Farial12)
            tx += Convert.ToSingle(meassure.Width)
            sPrintString = String.Format("{0}  '{1}'{2}{3}", Trans(150), "In", Space(6), DgvTableRemp.Item(2, _index).Value.ToString)
            e.Graphics.DrawString(sPrintString, Flitle, Brushes.Black, tx + 1, ty - 1)
            sPrintString = String.Format("{0}  '{1}'{2}{3}", Trans(150), "Out", Space(2), DgvTableRemp.Item(3, _index).Value.ToString)
            e.Graphics.DrawString(sPrintString, Flitle, Brushes.Black, tx + 1, ty + Flitle.Height - 1)

            Dim meassureL As SizeF = e.Graphics.MeasureString(sPrintString + vbTab, Flitle)
            tx = Convert.ToSingle(meassure.Width + meassureL.Width) + _dx  'L / dp

            sPrintString = String.Empty
            For i As Integer = 5 To columnsCountToPrint - 5
                If _dgvTableRemp.Item(i, _index).Value <> 0 Then
                    isNeedReturnCarret = True
                    If _dgvTableRemp.Item(i, _index).Value >= 0 And _dgvTableRemp.Columns(i).HeaderText.ToString().Contains("MP_") Then
                        sPrintString = _dgvTableRemp.Columns(i).HeaderText.ToString().Replace("MP_", "MP ")
                    Else
                        sPrintString = _dgvTableRemp.Item(i, _index).Value.ToString + " " + _dgvTableRemp.Columns(i).HeaderText
                    End If
                    If tx + 20 >= _l - 30 Then
                        tx = _dx 'Convert.ToSingle(meassure.Width + meassureL.Width)   'xShift
                        ty += Farial12.Height + 2 '16
                        isNeedReturnCarret = False
                    End If

                    e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + vOffset)
                    tx += e.Graphics.MeasureString(sPrintString, Farial8).Width + 20
                End If
            Next

            sPrintString = String.Empty
            For i As Integer = 4 To 2 Step -1

                If _dgvTableRemp.Item(columnsCountToPrint - i, _index).Value > 0 Then
                    sPrintString += _dgvTableRemp.Columns(columnsCountToPrint - i).HeaderText.ToString() + " "
                    isNeedReturnCarret = False
                End If
            Next
            If tx <> Convert.ToSingle(meassure.Width + meassureL.Width + _dx) Or isNeedReturnCarret = True Then
                ty += Farial12.Height + 2
                tx = _dx 'Convert.ToSingle(meassure.Width + meassureL.Width)
                isNeedReturnCarret = False
                If ty > _dy + _h Then Exit Do
            End If
            If sPrintString.Length > 0 Then
                e.Graphics.DrawString(sPrintString.Trim(), Farial12B, Brushes.Black, tx, ty - vOffset)
                ty += Farial12.Height + 2
                tx = _dx 'Convert.ToSingle(meassure.Width + meassureL.Width)
                isNeedReturnCarret = False
                If ty > _dy + _h Then Exit Do
            End If
            _index += 1
            If tx = Convert.ToSingle(meassure.Width + meassureL.Width + _dx) Then
                ty += Farial12.Height + 2
                tx = _dx 'Convert.ToSingle(meassure.Width + meassureL.Width)
                isNeedReturnCarret = False
                If ty > _dy + _h Then Exit Do
            End If
            e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
            ty += 2
            If ty + Farial12.Height + 2 > _dy + _h Then Exit Do
        Loop
        ' DEZ 19/05/10
        If _index < rowsCountToPrint Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = Farial12.Height * 3 + ((columnsCountToPrint / (dp - 1)) * Farial12.Height)
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                ty += Farial12.Height + 2 '16
                'e.Graphics.DrawString(trans(386) + ": " + remplissage.DGRemp.Rows.Count.ToString, f1, Brushes.Black, dx, ty) DEZ 19/05/10
                e.Graphics.DrawString(Trans(386) + ": " + rowsCountToPrint.ToString, Farial10, Brushes.Black, _dx, ty)
                ty += Farial10.Height + 2 '16
                e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                tx = xShift 'L / dp
                vOffset = (Farial10.Height - Farial8.Height) / 2
                e.Graphics.DrawString(Trans(387), Farial10, Brushes.Black, _dx, ty)
                For i As Integer = 5 To columnsCountToPrint - 5 '1  without 3 last columns Connection Error, Open Door, Service Switch Error
                    sPrintString = String.Empty
                    Dim t As Integer = 0
                    'For j As Integer = 0 To remplissage.DGRemp.Rows.Count - 1 DEZ 19/05/10
                    For j As Integer = 0 To rowsCountToPrint - 1
                        t += _dgvTableRemp.Item(i, j).Value
                    Next
                    If Not _dgvTableRemp.Columns(i).HeaderText.ToString().Contains("MP_") Then
                        sPrintString = t.ToString + " " + _dgvTableRemp.Columns(i).HeaderText
                        e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + vOffset)
                        'tx = tx + (L / dp)
                        tx += Convert.ToSingle(e.Graphics.MeasureString(sPrintString, Farial8).Width) + 2
                    End If
                    If tx >= _l - 30 Then
                        tx = xShift 'L / dp
                        ty += Farial8.Height + 2 '16
                    End If
                Next
                e.HasMorePages = False
                Pret = True
            End If
        End If

    End Sub
    'DEZ end

    Private Sub Printpageremplissage4(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Single = _dy
        Dim tx As Single
        Dim xShift As Integer = CInt(e.MarginBounds.Width / dp)
        '--------------------------------
        Dim newImage As Image = My.Resources.Homi_hewLogoForPrint2
        e.Graphics.DrawImage(newImage, e.MarginBounds.Left, e.MarginBounds.Top, newImage.Width, newImage.Height)
        Dim y As Single = (newImage.Height - Farial10B.Height) / 2 + e.MarginBounds.Top
        e.Graphics.DrawString(DateTime.Now + " " + Nomhotel + " " + Mainform.Label4.Text + vbTab + Trans(55) + vbTab + Trans(142) + ": " + Page.ToString, Farial10B, Brushes.Black, e.MarginBounds.Left + newImage.Width + 10, y)
        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds.Left + newImage.Width + 5, y, e.MarginBounds.Width - newImage.Width, Farial10B.Height + 2) 'realWidth + 5, 6, _dx + _l - realWidth, 20)

        ty = e.MarginBounds.Top + newImage.Height + 10
        Dim rowsCountToPrint As Integer = DgvTableRemp.Rows.Count
        Dim columnsCountToPrint As Integer = DgvTableRemp.Columns.Count

        Dim sPrintString As String
        Dim sVacant As String

        Dim meassure As SizeF
        Dim isNeedReturnCarret As Boolean
        Dim plugBackTextForConnection As String
        Dim tyForEmptyString As Single
        _dx = e.MarginBounds.Left
        Do Until _index = rowsCountToPrint
            'print chambre

            If _neededqtyIndex = 0 Then 'if can continue on the current page
                tx = _dx
                isNeedReturnCarret = False
                'start printing floor N before next floor
                If ty + Farial12Ib.Height * 2 + 4 > e.MarginBounds.Bottom Then Exit Do
                ty = PrintFloorN(e, tx, ty)

                If ty + Farial12B.Height > e.MarginBounds.Bottom Then Exit Do

                sPrintString = DgvTableRemp.Item(0, _index).Value.ToString().PadLeft(4, " ")
                e.Graphics.DrawString(sPrintString, Farial12, Brushes.Black, tx, ty) 'Room number
                meassure = e.Graphics.MeasureString(sPrintString + " ", Farial12)
                If String.Compare(_dgvTableRemp.Item(1, _index).Value.ToString.ToUpper(), "CHECK OUT", StringComparison.Ordinal) = 0 Then
                    sPrintString = "Vac"
                    e.Graphics.DrawString(sPrintString, Farial12B, Brushes.Black, tx + meassure.Width, ty)
                    meassure = New SizeF(meassure.Width + e.Graphics.MeasureString(sPrintString, Farial12B).Width, meassure.Height)
                End If
                sPrintString = "[ ] plugged back"
                plugBackTextForConnection = sPrintString

                If CInt(DgvTableRemp.Rows(_index).Cells("CE").Value) = 0 Then
                    e.Graphics.DrawString(sPrintString, Farial6B, Brushes.Black, tx, ty + meassure.Height) ', New SizeF(meassure.Width, Farial6B.Height))
                    plugBackTextForConnection = String.Empty
                    tyForEmptyString = ty + meassure.Height + Convert.ToSingle(MeasureDisplayString(e.Graphics, sPrintString + "ww", Farial6B).Height)
                End If
                tx += Math.Max(Convert.ToSingle(meassure.Width), Convert.ToSingle(MeasureDisplayString(e.Graphics, sPrintString + "ww", Farial6B).Width))
                _xFirst = tx + 30

                ' Print last checkin last checkout last refill
                sPrintString = String.Format("{0}: {1}   {2}: {3}   {4}:{5}", _
                                             Trans(134), _dgvTableRemp.Item(2, _index).Value.ToString, _
                                             Trans(135), _dgvTableRemp.Item(3, _index).Value.ToString, _
                                             Trans(133), _dgvTableRemp.Item(4, _index).Value.ToString _
                                             )
                e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, _xFirst, ty + 1) 'tx, ty + 1)
                _neededqtyIndex = 5
                ty += Farial8.Height '+ 2 '- vOffset '+ 2
                tx = _xFirst
                If ty + Farial12B.Height > e.MarginBounds.Bottom Then Exit Do
            Else 'continue printin current room on the next page
                tx = _xFirst
            End If
            Dim returnText As String
            Dim rec As RectangleF
            Dim retMeassure As SizeF
            Dim secondText As String = LireIniSmart("imprimer", "SecondText", " ")
            If Paysage Then
                meassure = New SizeF(CInt((e.MarginBounds.Right - _xFirst - 30) / 5), Farial10B.Height)
            Else
                meassure = New SizeF(CInt((e.MarginBounds.Right - _xFirst - 20) / 3), Farial10B.Height)
            End If

            Dim fs As New StringFormat
            While _neededqtyIndex <= columnsCountToPrint - 5
                If DgvTableRemp.Item(_neededqtyIndex, _index).Value <> 0 Then
                    isNeedReturnCarret = True
                    If DgvTableRemp.Item(_neededqtyIndex, _index).Value >= 0 AndAlso DgvTableRemp.Columns(_neededqtyIndex).HeaderText.ToString().Contains("MP_") Then
                        sPrintString = DgvTableRemp.Columns(_neededqtyIndex).HeaderText.ToString().Replace("MP_", "MP ")
                        returnText = String.Empty
                    Else
                        sPrintString = DgvTableRemp.Item(_neededqtyIndex, _index).Value.ToString + " " + DgvTableRemp.Columns(_neededqtyIndex).HeaderText
                        returnText = secondText '"T N R" '"  return [ ]"
                    End If
                    retMeassure = e.Graphics.MeasureString(returnText, Farial6B)
                    If tx + meassure.Width > e.MarginBounds.Right Then '- 30 Then
                        tx = _xFirst
                        ty += Farial12B.Height
                        If ty + Farial10B.Height > e.MarginBounds.Bottom Then
                            Exit Do
                        End If
                        isNeedReturnCarret = False
                    End If

                    fs.Trimming = StringTrimming.EllipsisCharacter
                    fs.Alignment = StringAlignment.Near
                    fs.LineAlignment = StringAlignment.Center
                    rec = New RectangleF(tx, ty, meassure.Width - retMeassure.Width - 10, Farial10B.Height) '-70
                    e.Graphics.DrawString(sPrintString, Farial10B, Brushes.Black, rec, fs)
                    rec = New RectangleF(tx + Math.Min(meassure.Width - retMeassure.Width - 10, e.Graphics.MeasureString(sPrintString, Farial10B, New SizeF(meassure.Width - retMeassure.Width - 10, Farial10B.Height), fs).Width + 5), ty, retMeassure.Width + 20, Farial10B.Height)
                    fs.Trimming = StringTrimming.None
                    e.Graphics.DrawString(returnText, Farial8, Brushes.Black, rec, fs)

                    tx += meassure.Width
                End If
                _neededqtyIndex += 1
            End While
            _neededqtyIndex = 0
            sPrintString = String.Empty
            'For i As Integer = 4 To 1 Step -1
            For i As Integer = 4 To IIf(LireIniBoolSmart("imprimer", "IsCanPrintGuestProducts", True), 1, 2) Step -1
                If DgvTableRemp.Item(columnsCountToPrint - i, _index).Value > 0 Then
                    sPrintString += DgvTableRemp.Columns(columnsCountToPrint - i).HeaderText.ToString() + " "
                    isNeedReturnCarret = False
                End If
            Next

            If Not tx.Equals(_xFirst) OrElse isNeedReturnCarret = True Then
                ty += Farial10B.Height
                tx = _xFirst

                If ty > e.MarginBounds.Bottom Then
                    _neededqtyIndex = columnsCountToPrint - 1
                    Exit Do
                End If
            End If
            If sPrintString.Length > 0 Then
                sPrintString += vbTab + plugBackTextForConnection
                e.Graphics.DrawString(sPrintString.Trim(), Farial12B, Brushes.Black, New RectangleF(tx, ty, e.MarginBounds.Right, Farial12B.Height), fs)
                ty += MeasureDisplayString(e.Graphics, sPrintString, Farial12B).Height
                If ty > e.MarginBounds.Bottom Then Exit Do
            End If
            _index += 1
            ty = Math.Max(ty, tyForEmptyString) + 2
            isNeedReturnCarret = False
            If ty > e.MarginBounds.Bottom Then Exit Do

            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, ty, e.MarginBounds.Right, ty)
            ty += 2
            If ty + Farial12.Height + 2 + Farial10B.Height > e.MarginBounds.Bottom Then Exit Do
        Loop
        ' DEZ 19/05/10
        If _index < rowsCountToPrint Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = Farial12.Height * 3 + ((columnsCountToPrint / (dp - 1)) * Farial12.Height)
            If ty + c > e.MarginBounds.Bottom Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                ty += Farial12.Height  '16
                'e.Graphics.DrawString(trans(386) + ": " + remplissage.DGRemp.Rows.Count.ToString, f1, Brushes.Black, dx, ty) DEZ 19/05/10
                e.Graphics.DrawString(Trans(386) + ": " + rowsCountToPrint.ToString, Farial10, Brushes.Black, _dx, ty)
                ty += Farial10.Height  '16
                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, ty, e.MarginBounds.Right, ty)
                e.Graphics.DrawString(Trans(387), Farial10, Brushes.Black, _dx, ty)
                xShift = e.Graphics.MeasureString(Trans(387), Farial10).Width + _dx
                tx = xShift
                Dim fs As New StringFormat
                fs.Alignment = StringAlignment.Near
                fs.LineAlignment = StringAlignment.Center
                fs.Trimming = StringTrimming.EllipsisCharacter
                If Paysage Then
                    meassure = New SizeF(CInt((e.MarginBounds.Width - xShift - 30) / 8), Farial8.Height)
                Else
                    meassure = New SizeF(CInt((e.MarginBounds.Width - xShift - 20) / 6), Farial8.Height)
                End If
                Dim rec As RectangleF
                For i As Integer = 5 To columnsCountToPrint - 2 '1  without 3 last columns Connection Error, Open Door, Service Switch Error, and Guest products
                    Dim t As Integer = 0
                    'For j As Integer = 0 To remplissage.DGRemp.Rows.Count - 1 DEZ 19/05/10
                    For j As Integer = 0 To rowsCountToPrint - 1
                        t += CInt(DgvTableRemp.Item(i, j).Value)
                    Next

                    If Not DgvTableRemp.Columns(i).HeaderText.ToString().Contains("MP_") AndAlso t <> 0 Then
                        sPrintString = t.ToString + " " + DgvTableRemp.Columns(i).HeaderText
                        'meassure = e.Graphics.MeasureString(sPrintString, Farial8) 'MeasureDisplayString(e.Graphics, sPrintString, Farial8)

                        If tx + meassure.Width > e.MarginBounds.Right Then
                            tx = xShift 'L / dp
                            ty += Farial8.Height  '16
                        End If
                        rec = New RectangleF(tx, ty, meassure.Width + 1, meassure.Height)
                        e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, rec, fs) ' + vOffset)
                        tx += meassure.Width
                    End If

                Next

                e.HasMorePages = False
                Pret = True
            End If
        End If

    End Sub







    Private Sub Printpageremplissage3(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Single = _dy
        Dim tx As Single
        Dim xShift As Integer = CInt(_l / dp)
        '--------------------------------
        Dim newImage As Image = My.Resources.Homi_hewLogoForPrint2 'HomiLogoN_H150
        'Dim realWidth As Single = (newImage.Width / newImage.HorizontalResolution) * 100 'e.Graphics.DpiX

        'e.Graphics.DrawImage(newImage, 1, e.MarginBounds.Top, newImage.Width, newImage.Height)
        e.Graphics.DrawImage(newImage, e.MarginBounds.Left, e.MarginBounds.Top, newImage.Width, newImage.Height)
        Dim y As Single = (newImage.Height - Farial10B.Height) / 2 + e.MarginBounds.Top
        'e.Graphics.DrawString(DateTime.Now + " " + Nomhotel + " " + Mainform.Label4.Text + vbTab + Trans(55) + vbTab + Trans(142) + ": " + Page.ToString, Farial10B, Brushes.Black, e.MarginBounds.Left + newImage.Width + 5, y + 1) '14 + 2) 'realWidth + 25, 6) 'dx, ty)
        'e.Graphics.DrawRectangle(Pens.Black, newImage.Width + 10, y, _dx + _l - newImage.Width - 10, Farial10B.Height + 2) 'realWidth + 5, 6, _dx + _l - realWidth, 20)
        e.Graphics.DrawString(DateTime.Now + " " + Nomhotel + " " + Mainform.Label4.Text + vbTab + Trans(55) + vbTab + Trans(142) + ": " + Page.ToString, Farial10B, Brushes.Black, e.MarginBounds.Left + newImage.Width + 10, y) '14 + 2) 'realWidth + 25, 6) 'dx, ty)
        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds.Left + newImage.Width + 5, y, e.MarginBounds.Right, Farial10B.Height + 2) 'realWidth + 5, 6, _dx + _l - realWidth, 20)

        'ty += e.MarginBounds.Top + newImage.Height 'e.MarginBounds.Top + 1 '22 '18
        ty += e.MarginBounds.Top + newImage.Height + 10
        Dim rowsCountToPrint As Integer = DgvTableRemp.Rows.Count
        Dim columnsCountToPrint As Integer = DgvTableRemp.Columns.Count

        Dim sPrintString As String '= String.Empty   '_dgvTableRemp.Item(0, 0).Value.ToString().PadLeft(3, "0")
        Dim sVacant As String

        ' Dim vOffset As Integer = (Farial12.Height - Farial8.Height) / 2
        Dim meassure As SizeF '= New SizeF(0, 0) 'Single = Single.MinValue
        Dim isNeedReturnCarret As Boolean
        Dim plugBackTextForConnection As String
        Dim tyForEmptyString As Single
        'Dim maxLen As Integer = (From cl As DataGridViewColumn In _dgvTableRemp.Columns Where cl.Index > 4 And cl.Index < columnsCountToPrint - 4 Select cl.Name.Length).DefaultIfEmpty().Max()
        'Dim maxColName = (From cl As DataGridViewColumn In _dgvTableRemp.Columns
        '                  Where cl.Index > 4 And cl.Index < columnsCountToPrint - 4 _
        '                  Select cl.Name).ToList().OrderByDescending(Function(x) x.Length).FirstOrDefault()
        '.OrderByDescending(Function(x) x.Length).ToList()


        '   Dim stud = _
        '    From s In students _
        '    Group s By Key = s.SubjectId Into Group _
        'Let topp = Group.Max(Function(x) x.Marks) _
        'Select New With {Key .Subject = Key, _
        '  Key .TopStudent = Group.First(Function(y) y.Marks = topp).StudentId, _
        '  Key .MaximumMarks = topp}



        Do Until _index = rowsCountToPrint
            'print chambre

            If _neededqtyIndex = 0 Then 'if can continue on the current page
                '_neededqtyIndex = 5
                tx = _dx
                isNeedReturnCarret = False
                'start printing floor N before next floor
                If ty + Farial12Ib.Height * 2 + 4 > _dy + _h Then Exit Do
                ty = PrintFloorN(e, tx, ty)
                'If ty > dy + H Then Exit Do
                'e.Graphics.DrawLine(Pens.Black, dx, ty, dx + L, ty)
                'ty += 2
                'If ty + MeasureDisplayString(e.Graphics, "1", Farial12).Height + MeasureDisplayString(e.Graphics, "1", Farial10b).Height > _dy + _h Then Exit Do
                If ty + Farial12B.Height * 3 + 6 > _dy + _h Then Exit Do
                'If ty + Farial12.Height + 2 > _dy + _h Then Exit Do 'If more than page height
                sPrintString = DgvTableRemp.Item(0, _index).Value.ToString().PadLeft(4, " ")
                e.Graphics.DrawString(sPrintString, Farial12, Brushes.Black, tx, ty) 'Room number
                meassure = e.Graphics.MeasureString(sPrintString + " ", Farial12)
                If String.Compare(_dgvTableRemp.Item(1, _index).Value.ToString.ToUpper(), "CHECK OUT", StringComparison.Ordinal) = 0 Then
                    sPrintString = "Vac"
                    e.Graphics.DrawString(sPrintString, Farial12B, Brushes.Black, tx + meassure.Width, ty)
                    meassure = New SizeF(meassure.Width + e.Graphics.MeasureString(sPrintString, Farial12B).Width, meassure.Height)
                    'Else
                    'sPrintString = String.Empty
                End If
                'sPrintString = String.Format("{0} {1}", DgvTableRemp.Item(0, _index).Value.ToString().PadLeft(4, " "), sPrintString) '+ vbTab)
                'e.Graphics.DrawString(sPrintString, Farial12, Brushes.Black, tx, ty)
                'meassure = MeasureDisplayString(e.Graphics, sPrintString, Farial12) 'e.Graphics.MeasureString(sPrintString, Farial12)
                sPrintString = "[ ] plugged back"
                plugBackTextForConnection = sPrintString

                If CInt(DgvTableRemp.Rows(_index).Cells("CE").Value) = 0 Then
                    e.Graphics.DrawString(sPrintString, Farial6B, Brushes.Black, tx, ty + meassure.Height) ', New SizeF(meassure.Width, Farial6B.Height))
                    plugBackTextForConnection = String.Empty
                    tyForEmptyString = ty + meassure.Height + Convert.ToSingle(MeasureDisplayString(e.Graphics, sPrintString + "ww", Farial6B).Height)
                End If
                tx += Math.Max(Convert.ToSingle(meassure.Width), Convert.ToSingle(MeasureDisplayString(e.Graphics, sPrintString + "ww", Farial6B).Width))
                _xFirst = tx + 30

                ' Print last checkin last checkout last refill
                sPrintString = String.Format("{0}: {1}   {2}: {3}   {4}:{5}", _
                                             Trans(134), _dgvTableRemp.Item(2, _index).Value.ToString, _
                                             Trans(135), _dgvTableRemp.Item(3, _index).Value.ToString, _
                                             Trans(133), _dgvTableRemp.Item(4, _index).Value.ToString _
                                             )
                e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + 1)
                _neededqtyIndex = 5
                ty += Farial8.Height '+ 2 '- vOffset '+ 2
                tx = _xFirst
                If ty + Farial12B.Height * 2 + 2 > _dy + _h Then Exit Do
            Else 'continue printin current room on the next page
                tx = _xFirst
            End If
            Dim returnText As String
            Dim rec As RectangleF
            Dim retMeassure As SizeF
            Dim secondText As String = LireIniSmart("imprimer", "SecondText", "return []")
            If Paysage Then
                meassure = New SizeF(CInt((_l - _xFirst - 30) / 5), Farial10B.Height)
            Else
                meassure = New SizeF(CInt((_l - _xFirst - 20) / 3), Farial10B.Height)
            End If
            Dim fs As New StringFormat
            While _neededqtyIndex <= columnsCountToPrint - 5
                If DgvTableRemp.Item(_neededqtyIndex, _index).Value <> 0 Then
                    isNeedReturnCarret = True
                    If DgvTableRemp.Item(_neededqtyIndex, _index).Value >= 0 AndAlso DgvTableRemp.Columns(_neededqtyIndex).HeaderText.ToString().Contains("MP_") Then
                        sPrintString = DgvTableRemp.Columns(_neededqtyIndex).HeaderText.ToString().Replace("MP_", "MP ")
                        returnText = String.Empty
                    Else
                        sPrintString = DgvTableRemp.Item(_neededqtyIndex, _index).Value.ToString + " " + DgvTableRemp.Columns(_neededqtyIndex).HeaderText
                        returnText = secondText '"T N R" '"  return [ ]"
                    End If
                    retMeassure = e.Graphics.MeasureString(returnText, Farial6B)
                    'meassure = New SizeF(230, Farial10B.Height) 'MeasureDisplayString(e.Graphics, maxColName + returnText, Farial10B) 'MeasureDisplayString(e.Graphics, sPrintString + returnText, Farial10b) '"1".PadLeft(maxLen + 3, "1")
                    'If tx + e.Graphics.MeasureString(sPrintString, Farial10b).Width >= _l - 30 Then
                    If tx + meassure.Width >= _l Then '- 30 Then
                        tx = _xFirst  'Convert.ToSingle(meassure.Width + meassureL.Width)   'xShift
                        ty += Farial12B.Height '+ 2 '16
                        If ty + Farial10B.Height + 20 > _h + _dy Then 'dy + H Then
                            'neededqtyIndex += 1
                            Exit Do
                        End If
                        isNeedReturnCarret = False
                    End If

                    fs.Trimming = StringTrimming.EllipsisCharacter
                    fs.Alignment = StringAlignment.Near
                    fs.LineAlignment = StringAlignment.Center
                    rec = New RectangleF(tx, ty, meassure.Width - retMeassure.Width - 10, Farial10B.Height) '-70
                    e.Graphics.DrawString(sPrintString, Farial10B, Brushes.Black, rec, fs)
                    rec = New RectangleF(tx + Math.Min(meassure.Width - retMeassure.Width - 10, e.Graphics.MeasureString(sPrintString, Farial10B, New SizeF(meassure.Width - retMeassure.Width - 10, Farial10B.Height), fs).Width + 5), ty, retMeassure.Width + 20, Farial10B.Height)
                    fs.Trimming = StringTrimming.None
                    e.Graphics.DrawString(returnText, Farial8, Brushes.Black, rec, fs)
                    'e.Graphics.DrawString(sPrintString, Farial10B, Brushes.Black, tx, ty + vOffset, fs)
                    'e.Graphics.DrawString(returnText, Farial10, Brushes.Black, tx + MeasureDisplayString(e.Graphics, sPrintString, Farial10B).Width, ty + vOffset)
                    tx += meassure.Width '+ 10 'e.Graphics.MeasureString(sPrintString, Farial10b).Width + 20
                End If
                _neededqtyIndex += 1
            End While
            _neededqtyIndex = 0
            sPrintString = String.Empty
            For i As Integer = 4 To 1 Step -1

                If DgvTableRemp.Item(columnsCountToPrint - i, _index).Value > 0 Then
                    sPrintString += DgvTableRemp.Columns(columnsCountToPrint - i).HeaderText.ToString() + " "
                    isNeedReturnCarret = False
                End If
            Next
            'sPrintString += vbTab & "[ ] is plugged back"
            'If tx <> Convert.ToSingle(meassure.Width + dx) Or isNeedReturnCarret = True Then
            If Not tx.Equals(_xFirst) OrElse isNeedReturnCarret = True Then
                ty += Farial10B.Height '- vOffset '+ 2
                tx = _xFirst 'dx 'Convert.ToSingle(meassure.Width + meassureL.Width)

                If ty > _dy + _h Then
                    'if sPrintString.Length 
                    _neededqtyIndex = columnsCountToPrint - 1
                    Exit Do
                End If
            End If
            If sPrintString.Length > 0 Then
                sPrintString += vbTab + plugBackTextForConnection
                'e.Graphics.DrawString(sPrintString.Trim(), Farial12B, Brushes.Black, tx, ty, fs) '- vOffset)
                e.Graphics.DrawString(sPrintString.Trim(), Farial12B, Brushes.Black, New RectangleF(tx, ty, _dx + _l, Farial12B.Height), fs)
                ty += MeasureDisplayString(e.Graphics, sPrintString, Farial12B).Height  'Farial12B.Height - vOffset '+ 2
                'tx = _xFirst 'dx 'Convert.ToSingle(meassure.Width + meassureL.Width)
                If ty > _dy + _h Then Exit Do
            End If
            _index += 1
            'If tx = Convert.ToSingle(meassure.Width + dx) Then

            'ty += 2 'Farial12.Height - vOffset ' + 2
            ty = Math.Max(ty, tyForEmptyString) + 2
            isNeedReturnCarret = False
            If ty > _dy + _h Then Exit Do

            e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
            ty += 2
            If ty + Farial12.Height + 2 + Farial10B.Height > _dy + _h Then Exit Do
        Loop
        ' DEZ 19/05/10
        If _index < rowsCountToPrint Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = Farial12.Height * 3 + ((columnsCountToPrint / (dp - 1)) * Farial12.Height)
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                ty += Farial12.Height  '16
                'e.Graphics.DrawString(trans(386) + ": " + remplissage.DGRemp.Rows.Count.ToString, f1, Brushes.Black, dx, ty) DEZ 19/05/10
                e.Graphics.DrawString(Trans(386) + ": " + rowsCountToPrint.ToString, Farial10, Brushes.Black, _dx, ty)
                ty += Farial10.Height  '16
                e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                'tx = xShift 'L / dp
                'vOffset = (Farial10.Height - Farial8.Height) / 2
                e.Graphics.DrawString(Trans(387), Farial10, Brushes.Black, _dx, ty)
                xShift = e.Graphics.MeasureString(Trans(387), Farial10).Width + _dx
                tx = xShift
                Dim fs As New StringFormat
                fs.Alignment = StringAlignment.Near
                fs.LineAlignment = StringAlignment.Center
                fs.Trimming = StringTrimming.EllipsisCharacter
                If Paysage Then
                    meassure = New SizeF(CInt((_l - xShift - 30) / 8), Farial8.Height)
                Else
                    meassure = New SizeF(CInt((_l - xShift - 20) / 6), Farial8.Height)
                End If
                Dim rec As RectangleF
                For i As Integer = 5 To columnsCountToPrint - 2 '1  without 3 last columns Connection Error, Open Door, Service Switch Error, and Guest products
                    Dim t As Integer = 0
                    'For j As Integer = 0 To remplissage.DGRemp.Rows.Count - 1 DEZ 19/05/10
                    For j As Integer = 0 To rowsCountToPrint - 1
                        t += CInt(DgvTableRemp.Item(i, j).Value)
                    Next

                    If Not DgvTableRemp.Columns(i).HeaderText.ToString().Contains("MP_") AndAlso t <> 0 Then
                        sPrintString = t.ToString + " " + DgvTableRemp.Columns(i).HeaderText
                        'meassure = e.Graphics.MeasureString(sPrintString, Farial8) 'MeasureDisplayString(e.Graphics, sPrintString, Farial8)

                        If tx + meassure.Width >= _l Then
                            tx = xShift 'L / dp
                            ty += Farial8.Height  '16
                        End If
                        rec = New RectangleF(tx, ty, meassure.Width + 1, meassure.Height)
                        e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, rec, fs) ' + vOffset)
                        tx += meassure.Width
                        'tx = tx + (L / dp)
                        'Convert.ToSingle(e.Graphics.MeasureString(sPrintString, Farial8).Width) + 2
                    End If

                Next

                e.HasMorePages = False
                Pret = True
            End If
        End If

    End Sub

    Private Sub Printpageremplissage2(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Single = _dy
        Dim tx As Single
        Dim xShift As Integer = CInt(_l / dp)
        '--------------------------------
        Dim newImage As Image = My.Resources.Homi_hewLogoForPrint2 'HomiLogoN_H150
        Dim realWidth As Single = (newImage.Width / newImage.HorizontalResolution) * 100
        e.Graphics.DrawImage(newImage, 1, -5)
        e.Graphics.DrawString(DateTime.Now + " " + Nomhotel + " " + Mainform.Label4.Text + vbTab + Trans(55) + vbTab + Trans(142) + ": " + Page.ToString, Farial10B, Brushes.Black, realWidth + 25, 6) 'dx, ty)
        e.Graphics.DrawRectangle(Pens.Black, realWidth + 5, 6, _dx + _l - realWidth, 20)
        ty += 22 '18

        Dim rowsCountToPrint As Integer = DgvTableRemp.Rows.Count
        Dim columnsCountToPrint As Integer = DgvTableRemp.Columns.Count

        Dim sPrintString As String = String.Empty   '_dgvTableRemp.Item(0, 0).Value.ToString().PadLeft(3, "0")
        Dim sVacant As String

        Dim vOffset As Integer = (Farial12.Height - Farial8.Height) / 2
        Dim meassure As SizeF '= New SizeF(0, 0) 'Single = Single.MinValue
        Dim isNeedReturnCarret As Boolean

        Do Until _index = rowsCountToPrint
            'print chambre

            If _neededqtyIndex = 0 Then 'if can continue on the current page
                '_neededqtyIndex = 5
                tx = _dx
                isNeedReturnCarret = False
                'start printing floor N before next floor
                If ty + Farial12Ib.Height * 2 + 4 > _dy + _h Then Exit Do
                ty = PrintFloorN(e, tx, ty)
                'If ty > dy + H Then Exit Do
                'e.Graphics.DrawLine(Pens.Black, dx, ty, dx + L, ty)
                'ty += 2
                'If ty + MeasureDisplayString(e.Graphics, "1", Farial12).Height + MeasureDisplayString(e.Graphics, "1", Farial10b).Height > _dy + _h Then Exit Do
                If ty + Farial12B.Height * 3 + 6 > _dy + _h Then Exit Do
                'If ty + Farial12.Height + 2 > _dy + _h Then Exit Do 'If more than page height
                If String.Compare(_dgvTableRemp.Item(1, _index).Value.ToString.ToUpper(), "CHECK OUT", StringComparison.Ordinal) = 0 Then
                    sPrintString = "Vac"
                Else
                    sPrintString = String.Empty
                End If
                sPrintString = String.Format("{0} {1}", DgvTableRemp.Item(0, _index).Value, sPrintString)
                e.Graphics.DrawString(sPrintString, Farial12, Brushes.Black, tx, ty)
                meassure = MeasureDisplayString(e.Graphics, sPrintString, Farial12) 'e.Graphics.MeasureString(sPrintString, Farial12)
                tx += Convert.ToSingle(meassure.Width)
                _xFirst = tx

                ' Print last checkin last checkout last refill
                sPrintString = String.Format("{0}: {1}   {2}: {3}   {4}:{5}", _
                                             Trans(134), _dgvTableRemp.Item(2, _index).Value.ToString, _
                                             Trans(135), _dgvTableRemp.Item(3, _index).Value.ToString, _
                                             Trans(133), _dgvTableRemp.Item(4, _index).Value.ToString _
                                             )
                e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + 1)
                _neededqtyIndex = 5
                ty += Farial8.Height + 2 '- vOffset '+ 2
                tx = _xFirst
                If ty + Farial12B.Height * 2 + 2 > _dy + _h Then Exit Do
            Else 'continu printin current room on the next page
                tx = _xFirst
            End If

            While _neededqtyIndex <= columnsCountToPrint - 5
                If DgvTableRemp.Item(_neededqtyIndex, _index).Value <> 0 Then
                    isNeedReturnCarret = True
                    If DgvTableRemp.Item(_neededqtyIndex, _index).Value >= 0 AndAlso DgvTableRemp.Columns(_neededqtyIndex).HeaderText.ToString().Contains("MP_") Then
                        sPrintString = DgvTableRemp.Columns(_neededqtyIndex).HeaderText.ToString().Replace("MP_", "MP ")
                    Else
                        sPrintString = DgvTableRemp.Item(_neededqtyIndex, _index).Value.ToString + " " + DgvTableRemp.Columns(_neededqtyIndex).HeaderText + " [ ] returned"
                    End If
                    meassure = MeasureDisplayString(e.Graphics, sPrintString, Farial10B)
                    'If tx + e.Graphics.MeasureString(sPrintString, Farial10b).Width >= _l - 30 Then
                    If tx + meassure.Width >= _l - 30 Then
                        tx = _xFirst 'Convert.ToSingle(meassure.Width + meassureL.Width)   'xShift
                        ty += Farial10B.Height + 2 '16
                        If ty + Farial10B.Height + 20 > _h + _dy Then 'dy + H Then
                            'neededqtyIndex += 1
                            Exit Do
                        End If
                        isNeedReturnCarret = False
                    End If
                    e.Graphics.DrawString(sPrintString, Farial10B, Brushes.Black, tx, ty + vOffset)
                    tx += meassure.Width + 20 'e.Graphics.MeasureString(sPrintString, Farial10b).Width + 20
                End If
                _neededqtyIndex += 1
            End While
            _neededqtyIndex = 0
            sPrintString = String.Empty
            For i As Integer = 4 To 1 Step -1

                If DgvTableRemp.Item(columnsCountToPrint - i, _index).Value > 0 Then
                    sPrintString += DgvTableRemp.Columns(columnsCountToPrint - i).HeaderText.ToString() + " "
                    isNeedReturnCarret = False
                End If
            Next
            sPrintString += vbTab & "[ ] is plugged back"
            'If tx <> Convert.ToSingle(meassure.Width + dx) Or isNeedReturnCarret = True Then
            If Not tx.Equals(_xFirst) OrElse isNeedReturnCarret = True Then
                ty += Farial12B.Height '- vOffset '+ 2
                tx = _xFirst 'dx 'Convert.ToSingle(meassure.Width + meassureL.Width)

                If ty > _dy + _h Then
                    'if sPrintString.Length 
                    _neededqtyIndex = columnsCountToPrint - 1
                    Exit Do
                End If
            End If
            If sPrintString.Length > 0 Then
                e.Graphics.DrawString(sPrintString.Trim(), Farial12B, Brushes.Black, tx, ty) '- vOffset)
                ty += MeasureDisplayString(e.Graphics, sPrintString, Farial12B).Height  'Farial12B.Height - vOffset '+ 2
                'tx = _xFirst 'dx 'Convert.ToSingle(meassure.Width + meassureL.Width)
                If ty > _dy + _h Then Exit Do
            End If
            _index += 1
            'If tx = Convert.ToSingle(meassure.Width + dx) Then

            ty += 2 'Farial12.Height - vOffset ' + 2
            isNeedReturnCarret = False
            If ty > _dy + _h Then Exit Do

            e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
            ty += 2
            If ty + Farial12.Height + 2 + Farial10B.Height > _dy + _h Then Exit Do
        Loop
        ' DEZ 19/05/10
        If _index < rowsCountToPrint Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = Farial12.Height * 3 + ((columnsCountToPrint / (dp - 1)) * Farial12.Height)
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                ty += Farial12.Height + 2 '16
                'e.Graphics.DrawString(trans(386) + ": " + remplissage.DGRemp.Rows.Count.ToString, f1, Brushes.Black, dx, ty) DEZ 19/05/10
                e.Graphics.DrawString(Trans(386) + ": " + rowsCountToPrint.ToString, Farial10, Brushes.Black, _dx, ty)
                ty += Farial10.Height + 2 '16
                e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                tx = xShift 'L / dp
                vOffset = (Farial10.Height - Farial8.Height) / 2
                e.Graphics.DrawString(Trans(387), Farial10, Brushes.Black, _dx, ty)
                For i As Integer = 5 To columnsCountToPrint - 4 '1  without 3 last columns Connection Error, Open Door, Service Switch Error
                    sPrintString = String.Empty
                    Dim t As Integer = 0
                    'For j As Integer = 0 To remplissage.DGRemp.Rows.Count - 1 DEZ 19/05/10
                    For j As Integer = 0 To rowsCountToPrint - 1
                        t += DgvTableRemp.Item(i, j).Value
                    Next
                    If Not DgvTableRemp.Columns(i).HeaderText.ToString().Contains("MP_") Then
                        sPrintString = t.ToString + " " + DgvTableRemp.Columns(i).HeaderText
                        e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + vOffset)
                        'tx = tx + (L / dp)
                        meassure = MeasureDisplayString(e.Graphics, sPrintString, Farial8)
                        tx += meassure.Width + 2 'Convert.ToSingle(e.Graphics.MeasureString(sPrintString, Farial8).Width) + 2
                    End If
                    If tx >= _l - 30 Then
                        tx = xShift 'L / dp
                        ty += Farial8.Height + 2 '16
                    End If
                Next
                e.HasMorePages = False
                Pret = True
            End If
        End If

    End Sub

    'DEZ begin
    Private Sub Printpageremplissage1(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Single = _dy
        Dim tx As Single
        Dim xShift As Integer = CInt(_l / dp)
        '--------------------------------
        'ty += (3 + My.Resources.HomiLogoN_H150.Height)
        'Dim imX As Single = (e.PageBounds.Width - My.Resources.HomiLogoN_H150.Width) / 2
        Dim newImage As Image = My.Resources.Homi_hewLogoForPrint2 'My.Resources.HomiLogoN_H150
        Dim realWidth As Single = (newImage.Width / newImage.HorizontalResolution) * 100
        'e.Graphics.DrawImage(newImage, 1, -5)
        'e.Graphics.DrawString(Now + " " + Nomhotel + " " + Mainform.Label4.Text + Space(20) + Trans(55) + Space(50) + Trans(142) + ": " + Page.ToString, Farial8B, Brushes.Black, realWidth + 15, 6) 'dx, ty)
        'e.Graphics.DrawString(Now + " " + nomhotel + " " + MAINFORM.Label4.Text, Farial8, Brushes.Black, My.Resources.HomiLogoN_H150.Width + 5, 3) 'dx, ty)
        ' e.Graphics.DrawString(Trans(55), Farial8, Brushes.Black, L / 2 + imX, 3) 'ty)
        'e.Graphics.DrawString(Trans(142) + ": " + Page.ToString, Farial8, Brushes.Black, L * 0.9 + imX, 3) 'ty)
        e.Graphics.DrawRectangle(Pens.Black, realWidth, 6, _dx + _l - realWidth, 16) 'ty, L, 16)
        ty += 16

        Dim rowsCountToPrint As Integer = DgvTableRemp.Rows.Count
        Dim columnsCountToPrint As Integer = DgvTableRemp.Columns.Count

        Dim sPrintString As String = String.Empty '_dgvTableRemp.Item(0, 0).Value.ToString().PadLeft(3, "0")
        Dim sVacant As String = String.Empty

        Dim vOffset As Integer = (Farial12.Height - Farial8.Height) / 2
        Dim meassure As SizeF = New SizeF(0, 0) 'Single = Single.MinValue
        Dim isNeedReturnCarret As Boolean

        Do Until _index = rowsCountToPrint
            'print chambre
            If _neededqtyIndex = 0 Then
                _neededqtyIndex = 5
                tx = _dx
                isNeedReturnCarret = False
                'start printing floor N before next floor
                If ty + Farial12Ib.Height * 2 + 4 > _dy + _h Then Exit Do
                sPrintString = DgvTableRemp.Item(0, _index).Value.ToString().PadLeft(3, "0")
                _nextFloor = sPrintString.ToString().Substring(0, IIf(Len(DgvTableRemp.Item(0, _index).Value.ToString().DigitsOnly()) > 3, 2, 1))
                If _currFloor <> _nextFloor Then
                    e.Graphics.DrawString("  Floor: " + _nextFloor, Farial12Ib, Brushes.Black, tx, ty)
                    _currFloor = _nextFloor
                    ty += Farial12Ib.Height + 2 '16
                    If ty > _dy + _h Then Exit Do
                    e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                    ty += 2
                End If
                ' end printing floor N

                If ty + Farial12.Height + 2 > _dy + _h Then Exit Do 'If more than page height
                If String.Compare(_dgvTableRemp.Item(1, _index).Value.ToString.ToUpper(), "CHECK OUT", StringComparison.Ordinal) = 0 Then
                    sVacant = "Vac"
                Else
                    sVacant = String.Empty
                End If
                sPrintString = String.Format("{0} {1}", DgvTableRemp.Item(0, _index).Value, sVacant)
                e.Graphics.DrawString(sPrintString, Farial12, Brushes.Black, tx, ty)
                meassure = e.Graphics.MeasureString(sPrintString, Farial12)
                tx += Convert.ToSingle(meassure.Width)
                _xFirst = tx
                ' Print last checkin last checkout last refill

                sPrintString = String.Format("{0}: {1}   {2}: {3}   {4}:{5}", _
                                             Trans(134), _dgvTableRemp.Item(2, _index).Value.ToString, _
                                             Trans(135), _dgvTableRemp.Item(3, _index).Value.ToString, _
                                             Trans(133), _dgvTableRemp.Item(4, _index).Value.ToString _
                                             )
                e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + 1)
                'meassure = e.Graphics.MeasureString(sPrintString, Farial8)

                'sPrintString = String.Format("{0}: {1}", Trans(134), dgvTableRemp.Item(2, index).Value.ToString)
                'e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + 1)
                'meassure = e.Graphics.MeasureString(sPrintString, Farial8)
                'tx += meassure.Width + 15
                'sPrintString = String.Format("{0}: {1}", Trans(135), dgvTableRemp.Item(3, index).Value.ToString)
                'e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + 1)
                'meassure = e.Graphics.MeasureString(sPrintString, Farial8)
                'tx += meassure.Width + 15
                'sPrintString = String.Format("{0}: {1}", Trans(133), dgvTableRemp.Item(4, index).Value.ToString)
                'e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + 1)
                '------------------------------------------
                ty += Farial8.Height + 2 '- vOffset '+ 2
                tx = _xFirst
            Else
                tx = _xFirst
            End If

            While _neededqtyIndex <= columnsCountToPrint - 4
                If DgvTableRemp.Item(_neededqtyIndex, _index).Value <> 0 Then
                    isNeedReturnCarret = True
                    If DgvTableRemp.Item(_neededqtyIndex, _index).Value >= 0 AndAlso DgvTableRemp.Columns(_neededqtyIndex).HeaderText.ToString().Contains("MP_") Then
                        sPrintString = DgvTableRemp.Columns(_neededqtyIndex).HeaderText.ToString().Replace("MP_", "MP ")
                    Else
                        sPrintString = DgvTableRemp.Item(_neededqtyIndex, _index).Value.ToString + " " + DgvTableRemp.Columns(_neededqtyIndex).HeaderText + " [ ] returned"
                    End If
                    If tx + e.Graphics.MeasureString(sPrintString, Farial10B).Width >= _l - 30 Then
                        tx = _xFirst 'Convert.ToSingle(meassure.Width + meassureL.Width)   'xShift
                        ty += Farial10B.Height + 2 '16
                        If ty + Farial10B.Height + 2 > _dy + _h Then
                            _neededqtyIndex += 1
                            Exit Do
                        End If
                        isNeedReturnCarret = False
                    End If

                    e.Graphics.DrawString(sPrintString, Farial10B, Brushes.Black, tx, ty + vOffset)

                    tx += e.Graphics.MeasureString(sPrintString, Farial10B).Width + 20

                End If
                _neededqtyIndex += 1
            End While
            _neededqtyIndex = 0
            'For i As Integer = 5 To columnsCountToPrint - 4
            '    If _dgvTableRemp.Item(i, index).Value <> 0 Then
            '        isNeedReturnCarret = True
            '        If _dgvTableRemp.Item(i, index).Value >= 0 AndAlso _dgvTableRemp.Columns(i).HeaderText.ToString().Contains("MP_") Then
            '            sPrintString = _dgvTableRemp.Columns(i).HeaderText.ToString().Replace("MP_", "MP ")
            '        Else
            '            sPrintString = _dgvTableRemp.Item(i, index).Value.ToString + " " + _dgvTableRemp.Columns(i).HeaderText
            '        End If
            '        If tx + e.Graphics.MeasureString(sPrintString, Farial10b).Width >= L - 30 Then
            '            tx = xFirst 'Convert.ToSingle(meassure.Width + meassureL.Width)   'xShift
            '            ty += Farial10b.Height + 2 '16
            '            isNeedReturnCarret = False
            '        End If

            '        e.Graphics.DrawString(sPrintString, Farial10b, Brushes.Black, tx, ty + vOffset)

            '        tx += e.Graphics.MeasureString(sPrintString, Farial10b).Width + 20
            '    End If
            'Next

            sPrintString = String.Empty
            For i As Integer = 3 To 1 Step -1

                If DgvTableRemp.Item(columnsCountToPrint - i, _index).Value > 0 Then
                    sPrintString += DgvTableRemp.Columns(columnsCountToPrint - i).HeaderText.ToString() + " "
                    isNeedReturnCarret = False
                End If
            Next
            sPrintString += vbTab & "[ ] is plugged back"
            'If tx <> Convert.ToSingle(meassure.Width + dx) Or isNeedReturnCarret = True Then
            If Not tx.Equals(_xFirst) OrElse isNeedReturnCarret = True Then
                ty += Farial12.Height '- vOffset '+ 2
                tx = _xFirst 'dx 'Convert.ToSingle(meassure.Width + meassureL.Width)
                isNeedReturnCarret = False
                If ty > _dy + _h Then
                    'if sPrintString.Length 
                    Exit Do
                End If
            End If
            If sPrintString.Length > 0 Then
                e.Graphics.DrawString(sPrintString.Trim(), Farial12B, Brushes.Black, tx, ty) '- vOffset)

                ty += Farial12B.Height - vOffset '+ 2
                tx = _xFirst 'dx 'Convert.ToSingle(meassure.Width + meassureL.Width)
                isNeedReturnCarret = False
                If ty > _dy + _h Then Exit Do
            End If
            _index += 1
            'If tx = Convert.ToSingle(meassure.Width + dx) Then
            If tx.Equals(_xFirst) Then
                ty += 2 'Farial12.Height - vOffset ' + 2
                tx = _xFirst 'dx 'Convert.ToSingle(meassure.Width + meassureL.Width)
                isNeedReturnCarret = False
                If ty > _dy + _h Then Exit Do
            End If
            e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
            ty += 2
            If ty + Farial12.Height + 2 > _dy + _h Then Exit Do
        Loop
        ' DEZ 19/05/10
        If _index < rowsCountToPrint Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = Farial12.Height * 3 + ((columnsCountToPrint / (dp - 1)) * Farial12.Height)
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                ty += Farial12.Height + 2 '16
                'e.Graphics.DrawString(trans(386) + ": " + remplissage.DGRemp.Rows.Count.ToString, f1, Brushes.Black, dx, ty) DEZ 19/05/10
                e.Graphics.DrawString(Trans(386) + ": " + rowsCountToPrint.ToString, Farial10, Brushes.Black, _dx, ty)
                ty += Farial10.Height + 2 '16
                e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                tx = xShift 'L / dp
                vOffset = (Farial10.Height - Farial8.Height) / 2
                e.Graphics.DrawString(Trans(387), Farial10, Brushes.Black, _dx, ty)
                For i As Integer = 5 To columnsCountToPrint - 4 '1  without 3 last columns Connection Error, Open Door, Service Switch Error
                    sPrintString = String.Empty
                    Dim t As Integer = 0
                    'For j As Integer = 0 To remplissage.DGRemp.Rows.Count - 1 DEZ 19/05/10
                    For j As Integer = 0 To rowsCountToPrint - 1
                        t += DgvTableRemp.Item(i, j).Value
                    Next
                    If Not DgvTableRemp.Columns(i).HeaderText.ToString().Contains("MP_") Then
                        sPrintString = t.ToString + " " + DgvTableRemp.Columns(i).HeaderText
                        e.Graphics.DrawString(sPrintString, Farial8, Brushes.Black, tx, ty + vOffset)
                        'tx = tx + (L / dp)
                        tx += Convert.ToSingle(e.Graphics.MeasureString(sPrintString, Farial8).Width) + 2
                    End If
                    If tx >= _l - 30 Then
                        tx = xShift 'L / dp
                        ty += Farial8.Height + 2 '16
                    End If
                Next
                e.HasMorePages = False
                Pret = True
            End If
        End If

    End Sub
    'DEZ end

    Private Sub Printpageremplissage(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Integer = _dy
        Dim tx As Integer = _dx
        e.Graphics.DrawString(Now + " " + Nomhotel + " " + Mainform.Label4.Text, Farial8, Brushes.Black, _dx, ty)
        e.Graphics.DrawString(Trans(55), Farial8, Brushes.Black, _l / 2, ty)
        e.Graphics.DrawString(Trans(142) + ": " + Page.ToString, Farial8, Brushes.Black, _l * 0.9, ty)
        e.Graphics.DrawRectangle(Pens.Black, _dx, ty, _l, 16)
        ty += 16

        Dim rowCountToPrint As Integer = Remplissage.DGRemp.RowCount
        'Do Until index = remplissage.DGRemp.Rows.Count
        Do Until _index = rowCountToPrint
            'print chambre
            '            If remplissage.DGRemp.Rows(index).Visible Then
            tx = _dx
            e.Graphics.DrawString(Remplissage.DGRemp.Item(0, _index).Value, Farial12, Brushes.Black, tx, ty)
            tx = _l / dp
            For i As Integer = 1 To Remplissage.DGRemp.Columns.Count - 1
                If Remplissage.DGRemp.Item(i, _index).Value <> 0 Then
                    e.Graphics.DrawString(Remplissage.DGRemp.Item(i, _index).Value.ToString + " " + Remplissage.DGRemp.Columns(i).HeaderText, Farial8, Brushes.Black, tx, ty)
                    tx = tx + (_l / dp)
                    If tx >= _l Then
                        tx = _l / dp
                        ty += 16
                    End If
                End If
            Next
            _index += 1
            ty += 16
            If ty > _dy + _h Then Exit Do
            e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
            ty += 2
            If ty + 16 > _dy + _h Then Exit Do
            '        End If

        Loop
        'If index < remplissage.DGRemp.Rows.Count Then DEZ 19/05/10
        If _index < rowCountToPrint Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = 48 + ((Remplissage.DGRemp.Columns.Count / (dp - 1)) * 16)
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                ty += 16
                'e.Graphics.DrawString(trans(386) + ": " + remplissage.DGRemp.Rows.Count.ToString, f1, Brushes.Black, dx, ty) DEZ 19/05/10
                e.Graphics.DrawString(Trans(386) + ": " + rowCountToPrint.ToString, Farial10, Brushes.Black, _dx, ty)
                ty += 16
                e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                tx = _l / dp
                e.Graphics.DrawString(Trans(387), Farial10, Brushes.Black, _dx, ty)
                For i As Integer = 1 To Remplissage.DGRemp.Columns.Count - 1
                    Dim t As Integer = 0
                    'For j As Integer = 0 To remplissage.DGRemp.Rows.Count - 1 DEZ 19/05/10
                    For j As Integer = 0 To rowCountToPrint - 1
                        t += Remplissage.DGRemp.Item(i, j).Value
                    Next
                    e.Graphics.DrawString(t.ToString + " " + Remplissage.DGRemp.Columns(i).HeaderText, Farial8, Brushes.Black, tx, ty)
                    tx = tx + (_l / dp)
                    If tx >= _l Then
                        tx = _l / dp
                        ty += 16
                    End If
                Next
                e.HasMorePages = False
                Pret = True
            End If
        End If

    End Sub
    Private Sub Printpageperime(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Integer = _dy
        Dim tx As Integer = _dx
        e.Graphics.DrawString(Now + " " + Nomhotel + " " + Mainform.Label4.Text, Farial8, Brushes.Black, _dx, ty)
        e.Graphics.DrawString(Trans(396), Farial8, Brushes.Black, _l / 2, ty)
        e.Graphics.DrawString(Trans(142) + ": " + Page.ToString, Farial8, Brushes.Black, _l * 0.9, ty)
        e.Graphics.DrawRectangle(Pens.Black, _dx, ty, _l, 16)
        ty += 16

        Do Until _index = Remplissage.DGRemp.Rows.Count
            'print chambre
            tx = _dx
            e.Graphics.DrawString(Remplissage.DGRemp.Item(0, _index).Value, Farial12, Brushes.Black, tx, ty)
            tx = _l / dp
            For i As Integer = 1 To Remplissage.DGRemp.Columns.Count - 1
                If Remplissage.DGRemp.Item(i, _index).Value <> 0 Then
                    e.Graphics.DrawString(Remplissage.DGRemp.Item(i, _index).Value.ToString + " " + Remplissage.DGRemp.Columns(i).HeaderText, Farial8, Brushes.Black, tx, ty)
                    tx = tx + (_l / dp)
                    If tx >= _l Then
                        tx = _l / dp
                        ty += 16
                    End If
                End If
            Next
            _index += 1
            ty += 16
            If ty > _dy + _h Then Exit Do
            e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
            ty += 2
            If ty + 16 > _dy + _h Then Exit Do
        Loop

        If _index < Remplissage.DGRemp.Rows.Count Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = 48 + ((Remplissage.DGRemp.Columns.Count / (dp - 1)) * 16)
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                ty += 16
                e.Graphics.DrawString(Trans(386) + ": " + Remplissage.DGRemp.Rows.Count.ToString, Farial10, Brushes.Black, _dx, ty)
                ty += 16
                e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
                tx = _l / dp
                e.Graphics.DrawString(Trans(384), Farial10, Brushes.Black, _dx, ty)
                For i As Integer = 1 To Remplissage.DGRemp.Columns.Count - 1
                    Dim t As Integer = 0
                    For j As Integer = 0 To Remplissage.DGRemp.Rows.Count - 1
                        t += Remplissage.DGRemp.Item(i, j).Value
                    Next
                    e.Graphics.DrawString(t.ToString + " " + Remplissage.DGRemp.Columns(i).HeaderText, Farial8, Brushes.Black, tx, ty)
                    tx = tx + (_l / dp)
                    If tx >= _l Then
                        tx = _l / dp
                        ty += 16
                    End If
                Next
                e.HasMorePages = False
                Pret = True
            End If
        End If

    End Sub
    Private Sub Printpagenote(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Integer = _dy + (UserTop / 0.254)
        Dim tx As Integer = _dx + (UserLeft / 0.254)
        e.Graphics.DrawString(facture.Label1.Text, Lf2, Brushes.Black, tx, ty)
        ty += 22
        e.Graphics.DrawString(Now + " " + Trans(388), Lf0, Brushes.Black, tx, ty)
        ty += 16
        e.Graphics.DrawString(facture.Label3.Text, Lf0, Brushes.Black, tx, ty)
        ty += 16
        e.Graphics.DrawString("__________________________________________", Lf0, Brushes.Black, tx, ty)
        ty += 16
        e.Graphics.DrawString(facture.TextBox2.Text, Lf0, Brushes.Black, tx, ty)
        ty += 3
        e.Graphics.DrawString("__________________________________________", Lf0, Brushes.Black, tx, ty)
        ty += 16

        Do Until _index = facture.rtf.Items.Count
            'print chambre
            e.Graphics.DrawString(facture.rtf.Items(_index), Lf0, Brushes.Black, tx, ty)
            _index += 1
            ty += 16
            If ty > _dy + _h Then Exit Do
        Loop

        If _index < facture.rtf.Items.Count Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = 48
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                e.Graphics.DrawString("__________________________________________", Lf0, Brushes.Black, tx, ty)
                ty += 16
                e.Graphics.DrawString(facture.Label4.Text + facture.Label8.Text, Lf0, Brushes.Black, tx, ty)
                ty += 16
                e.Graphics.DrawString(facture.Label6.Text + facture.Label7.Text, Lf2, Brushes.Black, tx, ty)
                e.HasMorePages = False
            End If
        End If

    End Sub
    Private Sub Printpagefacture(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Integer = _dy + (UserTop / 0.254)
        Dim tx As Integer = _dx + (UserLeft / 0.254)
        e.Graphics.DrawString(Rfacture.Label9.Text, Lf2, Brushes.Black, tx, ty)
        ty += 22
        e.Graphics.DrawString(Rfacture.Label3.Text + " " + Trans(348) + " " + Rfacture.Label10.Text, Lf0, Brushes.Black, tx, ty)
        ty += 16
        e.Graphics.DrawString("__________________________________________", Lf0, Brushes.Black, tx, ty)
        ty += 16
        e.Graphics.DrawString(Rfacture.TextBox2.Text, Lf0, Brushes.Black, tx, ty)
        ty += 3
        e.Graphics.DrawString("__________________________________________", Lf0, Brushes.Black, tx, ty)
        ty += 16

        Do Until _index = Rfacture.lbSelectedFactory.Items.Count
            'print chambre
            e.Graphics.DrawString(Rfacture.lbSelectedFactory.Items(_index), Lf0, Brushes.Black, tx, ty)
            _index += 1
            ty += 16
            If ty > _dy + _h Then Exit Do
        Loop

        If _index < Rfacture.lbSelectedFactory.Items.Count Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            Dim c As Integer = 48
            If ty + c > _dy + _h Then
                Page += 1
                listpage.Items.Add(Page.ToString)
                e.HasMorePages = True
            Else
                e.Graphics.DrawString("__________________________________________", Lf0, Brushes.Black, tx, ty)
                ty += 16
                e.Graphics.DrawString(Rfacture.Label1.Text + Rfacture.Label8.Text, Lf0, Brushes.Black, tx, ty)
                ty += 16
                e.Graphics.DrawString(Rfacture.Label6.Text + Rfacture.Label7.Text, Lf2, Brushes.Black, tx, ty)
                e.HasMorePages = False
            End If
        End If

    End Sub
    Private Sub Printpagexy(e As PrintPageEventArgs)
        'haut de page
        Dim dp As Integer = 7
        If Paysage = True Then dp = 11
        Dim ty As Integer = _dy + (UserTop / 0.254)
        Dim tx As Integer = _dx + (UserLeft / 0.254)
        e.Graphics.DrawString(rXZ.Label1.Text, Lf2, Brushes.Black, tx, ty)
        ty += 22
        e.Graphics.DrawString(rXZ.Label3.Text + " ", Lf0, Brushes.Black, tx, ty)
        ty += 16
        e.Graphics.DrawString("__________________________________________", Lf0, Brushes.Black, tx, ty)
        ty += 16

        Do Until _index = rXZ.lbPeriodResults.Items.Count
            'print chambre
            e.Graphics.DrawString(rXZ.lbPeriodResults.Items(_index), Lf0, Brushes.Black, tx, ty)
            _index += 1
            ty += 16
            If ty > _dy + _h Then Exit Do
        Loop

        If _index < rXZ.lbPeriodResults.Items.Count Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If

    End Sub
    Private Sub Printpagesystem(e As PrintPageEventArgs)
        'haut de page
        Dim ty As Integer = _dy
        Dim tx As Integer = _dx
        e.Graphics.DrawString(Now + " " + Nomhotel + " " + Mainform.Label4.Text, Farial8, Brushes.Black, _dx, ty)
        e.Graphics.DrawString(Trans(431), Farial8, Brushes.Black, _l / 2, ty)
        e.Graphics.DrawString(Trans(142) + ": " + Page.ToString, Farial8, Brushes.Black, _l * 0.9, ty)
        e.Graphics.DrawRectangle(Pens.Black, _dx, ty, _l, 16)
        ty += 24

        Do Until _index = Informationsystem.tf.Lines.Length
            'print chambre
            tx = _dx
            e.Graphics.DrawString(Informationsystem.tf.Lines(_index), Farial8, Brushes.Black, tx, ty)
            _index += 1
            ty += 16
            If ty > _dy + _h Then Exit Do
            If ty + 16 > _dy + _h Then Exit Do
        Loop

        If _index < Informationsystem.tf.Lines.Length Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            Pret = True
        End If

    End Sub
    Private Sub Printpageinterface(e As PrintPageEventArgs)
        'haut de page
        Dim ty As Integer = _dy
        Dim tx As Integer = _dx
        e.Graphics.DrawString(Now + " " + Nomhotel + " " + Mainform.Label4.Text, Farial8, Brushes.Black, _dx, ty)
        e.Graphics.DrawString(Trans(292), Farial8, Brushes.Black, _l / 2, ty)
        e.Graphics.DrawString(Trans(142) + ": " + Page.ToString, Farial8, Brushes.Black, _l * 0.9, ty)
        e.Graphics.DrawRectangle(Pens.Black, _dx, ty, _l, 16)
        ty += 24

        Do Until _index = Informationinterface.rtbInformationView.Lines.Length
            'print chambre
            tx = _dx
            e.Graphics.DrawString(Informationinterface.rtbInformationView.Lines(_index), Farial8, Brushes.Black, tx, ty)
            _index += 1
            ty += 16
            If ty > _dy + _h Then Exit Do
            If ty + 16 > _dy + _h Then Exit Do
        Loop

        If _index < Informationinterface.rtbInformationView.Lines.Length Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            Pret = True
        End If

    End Sub
    Private Sub Printpageinformation(e As PrintPageEventArgs)
        'haut de page
        Dim p As Integer = _l / 100
        Dim ty As Integer = _dy
        Dim tx As Integer = _dx
        e.Graphics.DrawString(Now + " " + Nomhotel + " " + Mainform.Label4.Text, Farial8, Brushes.Black, _dx, ty)
        e.Graphics.DrawString(Trans(432), Farial8, Brushes.Black, _l / 2, ty)
        e.Graphics.DrawString(Trans(142) + ": " + Page.ToString, Farial8, Brushes.Black, _l * 0.9, ty)
        e.Graphics.DrawRectangle(Pens.Black, _dx, ty, _l, 16)
        ty += 24

        'entete
        e.Graphics.DrawString(information.dg1.Columns("numchambre").HeaderText, Farial8, Brushes.Black, tx, ty)
        tx += 8 * p
        e.Graphics.DrawString(information.dg1.Columns("etatporte").HeaderText, Farial8, Brushes.Black, tx, ty)
        tx += 8 * p
        e.Graphics.DrawString(information.dg1.Columns("serrure").HeaderText, Farial8, Brushes.Black, tx, ty)
        tx += 10 * p
        e.Graphics.DrawString(information.dg1.Columns("etattemp").HeaderText, Farial8, Brushes.Black, tx, ty)
        tx += 10 * p
        e.Graphics.DrawString(information.dg1.Columns("check").HeaderText, Farial8, Brushes.Black, tx, ty)
        tx += 8 * p
        e.Graphics.DrawString(information.dg1.Columns("ouverture").HeaderText, Farial8, Brushes.Black, tx, ty)
        tx += 16 * p
        e.Graphics.DrawString(information.dg1.Columns("nummodule").HeaderText, Farial8, Brushes.Black, tx, ty)
        tx += 8 * p
        e.Graphics.DrawString(information.dg1.Columns("test").HeaderText, Farial8, Brushes.Black, tx, ty)
        tx += 18 * p
        e.Graphics.DrawString(information.dg1.Columns("dateanomalie").HeaderText, Farial8, Brushes.Black, tx, ty)

        ty += 16
        e.Graphics.DrawLine(Pens.Black, _dx, ty, _dx + _l, ty)
        e.Graphics.DrawLine(Pens.Black, _dx, ty + 1, _dx + _l, ty + 1)
        ty += 16

        Do Until _index = information.dg1.RowCount
            'print chambre
            tx = _dx
            e.Graphics.DrawString(information.dg1.Item("numchambre", _index).Value.ToString, Farial8, Brushes.Black, tx, ty)
            tx += 8 * p
            e.Graphics.DrawString(information.dg1.Item("etatporte", _index).Value.ToString, Farial8, Brushes.Black, tx, ty)
            tx += 8 * p
            e.Graphics.DrawString(information.dg1.Item("serrure", _index).Value.ToString, Farial8, Brushes.Black, tx, ty)
            tx += 10 * p
            e.Graphics.DrawString(information.dg1.Item("etattemp", _index).Value.ToString, Farial8, Brushes.Black, tx, ty)
            tx += 10 * p
            e.Graphics.DrawString(information.dg1.Item("check", _index).Value.ToString, Farial8, Brushes.Black, tx, ty)
            tx += 8 * p
            e.Graphics.DrawString(information.dg1.Item("ouverture", _index).Value.ToString, Farial8, Brushes.Black, tx, ty)
            tx += 16 * p
            e.Graphics.DrawString(information.dg1.Item("nummodule", _index).Value.ToString, Farial8, Brushes.Black, tx, ty)
            tx += 8 * p
            e.Graphics.DrawString(information.dg1.Item("test", _index).Value.ToString, Farial8, Brushes.Black, tx, ty)
            tx += 18 * p
            e.Graphics.DrawString(information.dg1.Item("dateanomalie", _index).Value.ToString, Farial8, Brushes.Black, tx, ty)
            _index += 1
            ty += 16
            If ty > _dy + _h Then Exit Do
            If ty + 16 > _dy + _h Then Exit Do
        Loop

        If _index < information.dg1.RowCount Then
            Page += 1
            listpage.Items.Add(Page.ToString)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            Pret = True
        End If

    End Sub
#End Region

    Private Sub GlassButton5_Click(sender As Object, e As EventArgs) Handles GlassButton5.Click
        Doc.Print()
        If Imprime = "remplissage" And LireIniBoolSmart("imprimer", "SaveCopyOfRefillList", False) Then
            Dim dir As DirectoryInfo = New DirectoryInfo(Path.Combine(Application.StartupPath, "xpsCopy"))
            If Not dir.Exists() Then
                dir.Create()
            End If
            Dim printerName As String = Doc.PrinterSettings.PrinterName
            Doc.PrinterSettings.PrinterName = "Microsoft XPS Document Writer"
            Doc.PrinterSettings.PrintToFile = True
            Doc.PrinterSettings.PrintFileName = Path.Combine(dir.FullName, DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xps")
            Doc.Print()
            Doc.PrinterSettings.PrintToFile = False
            Doc.PrinterSettings.PrinterName = printerName

        End If
        Me.Close()
    End Sub

    Private Sub listpage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listpage.SelectedIndexChanged
        PP1.StartPage = listpage.SelectedIndex
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Imprimer_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        EcrireINI("imprimer", "top", Me.Top)
        EcrireINI("imprimer", "left", Me.Left)
        EcrireINI("imprimer", "height", Me.Height)
        EcrireINI("imprimer", "width", Me.Width)
        EcrireINI("imprimer", "zoom", textBox1.Text)
        EcrireINI("imprimer", "WindowState", CInt(WindowState))
    End Sub
End Class