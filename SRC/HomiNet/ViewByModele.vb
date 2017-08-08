Imports Glass
Imports HomiNet.My.Resources



Public Class ViewByModele
    Private Class ExtPanel
        Inherits Panel
        Public Property HexSvm As Long
        Public Property Swr As String

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class

    Private _selectedRow As DataGridViewRow
    'Private _dvRoomsForView As New DataView
    Private _labels As New List(Of Label)
    'Private _labels226 As New List(Of Label)
    Private _labels226New As New List(Of Label)
    Private WithEvents tmrDoubleClick As New Timer()
    Private _isFirstClick As Boolean = True
    Private _isDoubleClick As Boolean = False
    Private _milliseconds As Integer = 0
    Private ReadOnly _doubleClickRectangle = New Rectangle(0, 0, 24, 30)
    Private _filterStr
    'New Panel 226 &330/336
    '
    Private WithEvents PnlHomi226New As ExtPanel
    Private WithEvents PnlHomi330New As ExtPanel

    Private WithEvents TblpanelTopShelf As TableLayoutPanel
    Private WithEvents TblpanelMiddleShelf As TableLayoutPanel
    Private WithEvents TblpanelBottomShelf As TableLayoutPanel
    Private WithEvents TblpanelBalcony As TableLayoutPanel
    Private WithEvents TblpanelExtTray As TableLayoutPanel
    Private WithEvents TblpanelExtTray48 As TableLayoutPanel
    Private WithEvents TblpanelMiddleShelf2Nd As TableLayoutPanel
    Private WithEvents TblpanelBalcony2Nd As TableLayoutPanel

    Private WithEvents TblpanelLeftSide As TableLayoutPanel
    Private WithEvents TblpanelRightSide As TableLayoutPanel
    Private WithEvents _tblpanelExtTray330 As TableLayoutPanel
    Private WithEvents _tblpanelExtTray33048 As TableLayoutPanel
    Private WithEvents _tblpanelButtons330 As TableLayoutPanel
    Private WithEvents LblTopName As Label
    Private WithEvents LblMiddleName As Label
    Private WithEvents LblMiddleName2Nd As Label
    Private WithEvents LblBottomName As Label
    Private WithEvents LblBalconyName As Label
    Private WithEvents LblBalconyName2Nd As Label
    Private WithEvents LblTrayName As Label
    Private WithEvents LblLeftName As Label
    Private WithEvents LblRightName As Label
    Private WithEvents LblTray330Name As Label
    '
    '
    Private Sub Initialize()
        PnlHomi226New = New ExtPanel()
        PnlHomi330New = New ExtPanel()

        TblpanelTopShelf = New TableLayoutPanel()
        TblpanelMiddleShelf = New TableLayoutPanel()
        TblpanelBottomShelf = New TableLayoutPanel()
        TblpanelBalcony = New TableLayoutPanel()
        TblpanelExtTray = New TableLayoutPanel()
        TblpanelExtTray48 = New TableLayoutPanel()
        TblpanelMiddleShelf2Nd = New TableLayoutPanel()
        TblpanelBalcony2Nd = New TableLayoutPanel()

        TblpanelLeftSide = New TableLayoutPanel()
        TblpanelRightSide = New TableLayoutPanel()
        _tblpanelExtTray330 = New TableLayoutPanel()
        _tblpanelExtTray33048 = New TableLayoutPanel()
        _tblpanelButtons330 = New TableLayoutPanel()
        LblTopName = New Label()
        LblMiddleName = New Label()
        LblMiddleName2Nd = New Label()
        LblBottomName = New Label()
        LblBalconyName = New Label()
        LblBalconyName2Nd = New Label()
        LblTrayName = New Label()
        LblLeftName = New Label()
        LblRightName = New Label()
        LblTray330Name = New Label()
    End Sub
    Private Enum Commands
        Lock = 1
        Unlock = 2
        Test = 3
        AddStock = 15
    End Enum
    Private Sub GlassButton9_Click(sender As Object, e As EventArgs) Handles GlassButton9.Click
        Mainform.tabMain.TabPages(Table).Select()
    End Sub
    Private Sub InitLanguage()
        btnUnlock.Text = Trans(25)
        btnLock.Text = Trans(24)
        btnSend.Text = Trans(216)
        cmsFiltersForExtView.Items.Item(0).Text = Trans(49)
        cmsFiltersForExtView.Items.Item(1).Text = Trans(343)
    End Sub
    Private Shared Sub CreatePanel(pnl As Panel, panelName As String, cntrl As Control())
        pnl.Anchor = (((AnchorStyles.Top Or AnchorStyles.Bottom) _
                       Or AnchorStyles.Left) _
                      Or AnchorStyles.Right)

        pnl.AutoScroll = True
        pnl.BorderStyle = BorderStyle.Fixed3D
        pnl.Location = New Point(218, 79)
        pnl.Controls.AddRange(cntrl)
        pnl.Name = panelName
        pnl.Size = New Size(100, 100) '(829, 502)
        pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnl.TabIndex = 5
    End Sub

    Private Shared Function CreateLayoutPanel(colCnt As Integer, rowCnt As Integer, namePanel As String, lblDescr As Label) As TableLayoutPanel
        Dim result As TableLayoutPanel = New TableLayoutPanel()
        result.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        result.ColumnCount = colCnt
        If colCnt = 1 Then
            result.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0!))
        Else
            For i As Byte = 1 To colCnt
                result.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0!))
                'result.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
            Next
        End If
        result.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        result.Location = New Point(10, 15)
        result.Name = namePanel
        result.RowCount = rowCnt
        If rowCnt > 1 Then
            result.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Else
            result.RowStyles.Add(New RowStyle(SizeType.Percent, Val(100.0 / (rowCnt - 1))))
        End If
        For i As Byte = 2 To rowCnt
            result.RowStyles.Add(New RowStyle(SizeType.Percent, Val(100.0 / (rowCnt - 1))))
            'result.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Next
        'result.Size = New Size(95 * colCnt, IIf(rowCnt > 1, 79 * (rowCnt - 1) + result.RowStyles(0).Height, 79))
        result.Size = New Size(91 * colCnt, IIf(rowCnt > 1, 91 * (rowCnt - 1) + result.RowStyles(0).Height, 91))
        If lblDescr IsNot Nothing Then
            result.Controls.Add(lblDescr, 0, 0)
            result.SetColumnSpan(lblDescr, colCnt)
        End If

        Return result
    End Function
    Private Function CreateDescrLabel(lblName As String, lblText As String) As Label
        Dim result As Label = New Label()
        result.BackColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        result.Dock = DockStyle.Fill
        result.Font = New Font("Microsoft Sans Serif", 10.5!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CType(0, Byte))
        'result.Location = New System.Drawing.Point(0, 0)
        result.Name = "lbl" + lblName
        'result.Size = New System.Drawing.Size(83, 20)
        result.TextAlign = ContentAlignment.MiddleLeft
        'result.Margin = New Padding(0, 0, 0, 0)
        'result.TabIndex = 0
        result.Text = lblText

        Return result
    End Function
    Private Sub SuspendL()
        TblpanelTopShelf.SuspendLayout()
        TblpanelMiddleShelf.SuspendLayout()
        TblpanelBottomShelf.SuspendLayout()
        TblpanelBalcony.SuspendLayout()
        TblpanelExtTray.SuspendLayout()
        TblpanelExtTray48.SuspendLayout()
        TblpanelMiddleShelf2Nd.SuspendLayout()
        TblpanelBalcony2Nd.SuspendLayout()
        PnlHomi226New.SuspendLayout()
        _tblpanelExtTray330.SuspendLayout()
        _tblpanelExtTray33048.SuspendLayout()
        _tblpanelButtons330.SuspendLayout()

        TblpanelLeftSide.SuspendLayout()
        TblpanelRightSide.SuspendLayout()
        PnlHomi330New.SuspendLayout()
        SuspendLayout()
    End Sub
    Private Sub ResumeL()
        TblpanelTopShelf.ResumeLayout(False)
        TblpanelTopShelf.PerformLayout()
        TblpanelMiddleShelf.ResumeLayout(False)
        TblpanelMiddleShelf.PerformLayout()
        TblpanelMiddleShelf2Nd.ResumeLayout(False)
        TblpanelMiddleShelf2Nd.PerformLayout()
        TblpanelBottomShelf.ResumeLayout(False)
        TblpanelBottomShelf.PerformLayout()
        TblpanelBalcony.ResumeLayout(False)
        TblpanelBalcony.PerformLayout()
        TblpanelBalcony2Nd.ResumeLayout(False)
        TblpanelBalcony2Nd.PerformLayout()
        TblpanelExtTray.ResumeLayout(False)
        TblpanelExtTray.PerformLayout()
        TblpanelExtTray48.ResumeLayout(False)
        TblpanelExtTray48.PerformLayout()
        _tblpanelButtons330.ResumeLayout(False)
        _tblpanelButtons330.PerformLayout()

        TblpanelLeftSide.ResumeLayout(False)
        TblpanelLeftSide.PerformLayout()
        TblpanelRightSide.ResumeLayout(False)
        TblpanelRightSide.PerformLayout()

        _tblpanelExtTray330.ResumeLayout(False)
        _tblpanelExtTray330.PerformLayout()
        _tblpanelExtTray33048.ResumeLayout(False)
        _tblpanelExtTray33048.PerformLayout()

        PnlHomi226New.ResumeLayout(False)
        PnlHomi330New.ResumeLayout(False)

        ResumeLayout(False)
    End Sub
    Private Sub CreatePanels()
        SuspendL()

        MakeLPanelHomi226()
        MakeLPanelHomi330()

        CreatePanel(PnlHomi226New, "pnlHomi226New", New Control() {TblpanelTopShelf, TblpanelMiddleShelf, TblpanelBottomShelf, TblpanelBalcony, TblpanelExtTray, TblpanelExtTray48, TblpanelBalcony2Nd, TblpanelMiddleShelf2Nd})
        CreatePanel(PnlHomi330New, "pnlHomi330New", New Control() {TblpanelLeftSide, TblpanelRightSide, _tblpanelExtTray330, _tblpanelExtTray33048, _tblpanelButtons330})
        Me.Controls.AddRange(New Control() {PnlHomi226New, PnlHomi330New})

        ResumeL()
    End Sub
    Private Sub MakeLPanelHomi330()
        'Left Side
        LblLeftName = CreateDescrLabel("lblLeftSide", "Left Side")
        TblpanelLeftSide = CreateLayoutPanel(1, 5, "tblpanelLeftSide", LblLeftName)

        'Right Side
        LblRightName = CreateDescrLabel("lblRightSide", "Right Side")
        TblpanelRightSide = CreateLayoutPanel(1, 5, "tblpanelRightSide", LblRightName)
        TblpanelRightSide.Location = New Point(TblpanelLeftSide.Right + 10, TblpanelLeftSide.Top)
        'Ext Tray
        LblTray330Name = CreateDescrLabel("lblTray330Descr", "Extended Tray")
        _tblpanelExtTray330 = CreateLayoutPanel(4, 2, "_tblpanelExtTray330", LblTray330Name)
        _tblpanelExtTray330.Location = New Point(TblpanelRightSide.Right + 10, TblpanelRightSide.Top)
        'if use tray 8 need add another 4 position
        _tblpanelExtTray33048 = CreateLayoutPanel(4, 1, "_tblpanelExtTray33048", Nothing)
        _tblpanelExtTray33048.Location = New Point(_tblpanelExtTray330.Left, TblpanelExtTray.Bottom)
        _tblpanelExtTray33048.Visible = False

        'Buttons for Manual
        _tblpanelButtons330 = CreateLayoutPanel(4, 1, "tblButtons330", Nothing)
        _tblpanelButtons330.Location = New Point(_tblpanelExtTray33048.Left, _tblpanelExtTray33048.Bottom)
    End Sub

    Private Sub MakeLPanelHomi226()

        'top Shelf
        LblTopName = CreateDescrLabel("TopDescr", "Top Shelf")
        TblpanelTopShelf = CreateLayoutPanel(4, 3, "tblpanelTopShelf", LblTopName)

        'Lay Down
        LblMiddleName = CreateDescrLabel("MiddleDescr", "Lay Down Bottle")
        TblpanelMiddleShelf = CreateLayoutPanel(4, 2, "tblpanelMiddleShelf", LblMiddleName)
        TblpanelMiddleShelf.Location = New Point(TblpanelTopShelf.Left, TblpanelTopShelf.Bottom + 30)

        'bottomshelf
        LblBottomName = CreateDescrLabel("BottomDescr", "Bottom Shelf")
        TblpanelBottomShelf = CreateLayoutPanel(4, 3, "tblpanelBottomShelf", LblBottomName)
        TblpanelBottomShelf.Location = New Point(TblpanelTopShelf.Left, TblpanelMiddleShelf.Bottom + 30)

        'Lay Down 2nd
        LblMiddleName2Nd = CreateDescrLabel("MiddleDescr2nd", "Lay Down Bottle")
        TblpanelMiddleShelf2Nd = CreateLayoutPanel(4, 2, "tblpanelMiddleShelf", LblMiddleName2Nd)
        TblpanelMiddleShelf2Nd.Location = New Point(TblpanelBottomShelf.Left, TblpanelBottomShelf.Bottom + 30)

        'balcony
        LblBalconyName = CreateDescrLabel("BalconyDescr", "Balcony")
        TblpanelBalcony = CreateLayoutPanel(1, 7, "tblpanelBalcony", LblBalconyName)
        TblpanelBalcony.Location = New Point(TblpanelTopShelf.Right + 10, TblpanelTopShelf.Top)

        'balcony2nd
        LblBalconyName2Nd = CreateDescrLabel("BalconyDescr2nd", "Balcony2")
        TblpanelBalcony2Nd = CreateLayoutPanel(1, 7, "tblpanelBalcony2Nd", LblBalconyName2Nd)
        TblpanelBalcony2Nd.Location = New Point(TblpanelBalcony.Right + 10, TblpanelTopShelf.Top)
        TblpanelBalcony2Nd.Visible = False

        'Ext Tray
        LblTrayName = CreateDescrLabel("TrayDescr", "Extended Tray")
        TblpanelExtTray = CreateLayoutPanel(4, 2, "tblpanelExtTray", LblTrayName)
        TblpanelExtTray.Location = New Point(TblpanelBalcony.Right + 10, TblpanelTopShelf.Top)
        'if use tray 8 need add another 4 position
        TblpanelExtTray48 = CreateLayoutPanel(4, 1, "tblpanelExtTray48", Nothing)
        TblpanelExtTray48.Location = New Point(TblpanelExtTray.Left, TblpanelExtTray.Bottom)
        TblpanelExtTray48.Visible = False


    End Sub



    Private Shared Function RealShelfStatus(status As Long, casier As Integer) As Boolean
        Select Case casier
            Case Is <= 12 'top shelf
                Return status.LAnd(&H10000000000L << (casier - 1))
            Case Is <= 24  'bottom shelf
                Return status.LAnd(&H10000000L << (casier - 13))
            Case Is <= 30  'balcony1
                Return status.LAnd(&H100000L << (casier - 25))
            Case Is <= 36  'balcony2
                Return status.LAnd(&H1000L << (casier - 31))
            Case Is > 36  'tray
                Return status.LAnd(&H10L << (casier - 37))
        End Select
        Return False
    End Function
    'Private Sub Model2Hex(ByVal indx As Integer)
    '    Dim swrModel As Long = &HFFFFFF3F3FFF1
    '    For casier As Integer = 1 To MaxCountOfProducts
    '        If Convert.ToInt16(basemodele.modele.Rows(Indx)("q" + casier.ToString())) = 0 Then
    '            Select Case casier
    '                Case Is <= 12 'top shelf
    '                    swrModel = &H10000000000L << (casier - 1) Xor swrModel
    '                Case Is <= 24  'bottom shelf
    '                    swrModel = &H10000000L << (casier - 13) Xor swrModel
    '                Case Is <= 30  'balcony1
    '                    swrModel = &H100000L << (casier - 25) Xor swrModel
    '                Case Is <= 36  'balcony2
    '                    swrModel = &H1000L << (casier - 31) Xor swrModel
    '                Case Is > 36  'tray
    '                    swrModel = &H10L << (casier - 37) Xor swrModel
    '            End Select
    '        End If
    '    Next
    'End Sub
    'Private Function Model2Hex330(ByVal indx As Integer) As Integer
    '    Dim swrModel As Integer = &H100
    '    For casier As Integer = 1 To CountOfProductsHomi330

    '        If Convert.ToInt16(basemodele.modele.Rows(indx)("q" + casier.ToString())) > 0 Then
    '            Select Case casier
    '                Case Is <= 4 'left
    '                    swrModel = &H10 << (casier - 1) Xor swrModel
    '                Case Is <= 8  'right
    '                    swrModel = &H1 << (casier - 5) Xor swrModel
    '                Case Is <= 12  'balcony1
    '                    swrModel = &H1000 << (casier - 9) Xor swrModel
    '                    'Case Is <= 36  'balcony2
    '                    '    swrModel = &H1000L << (casier - 31) Xor swrModel
    '                    'Case Is > 36  'tray
    '                    '    swrModel = &H10L << (casier - 37) Xor swrModel
    '            End Select
    '        End If
    '    Next
    '    Return swrModel
    'End Function
    'Private Function Model2Hex226(indx As Integer) As Long
    '    Dim swrModel As Long = 0L
    '    For casier As Integer = 1 To MaxCountOfProducts
    '        If Convert.ToInt16(basemodele.modele.Rows(indx)("q" + casier.ToString())) = 1 Then
    '            Select Case casier
    '                Case Is <= 12 'top shelf
    '                    swrModel = &H10000000000L << (casier - 1) Xor swrModel
    '                Case Is <= 24  'bottom shelf
    '                    swrModel = &H10000000L << (casier - 13) Xor swrModel
    '                Case Is <= 30  'balcony1
    '                    swrModel = &H100000L << (casier - 25) Xor swrModel
    '                Case Is <= 36  'balcony2
    '                    swrModel = &H1000L << (casier - 31) Xor swrModel
    '                Case Is > 36  'tray
    '                    swrModel = &H10L << (casier - 37) Xor swrModel
    '            End Select
    '        End If
    '    Next
    '    Return swrModel
    'End Function
    Private Sub PositionByVisibleFor330(ByVal hexSvm As Long)

        TblpanelLeftSide.Visible = ((hexSvm And &HF0) <> 0)
        TblpanelRightSide.Visible = ((hexSvm And &HF) <> 0)
        _tblpanelExtTray330.Visible = IIf(CountOfProductsHomi330 < 16, ((hexSvm And &HF000) <> 0), ((hexSvm And &HF0000) <> 0))
        _tblpanelExtTray33048.Visible = Not CountOfProductsHomi330 < 16 AndAlso ((hexSvm And &HF000) <> 0)
        
        If (hexSvm And &HFF) = 0 Then
            _tblpanelExtTray330.Left = TblpanelLeftSide.Left
        Else
            _tblpanelExtTray330.Left = TblpanelRightSide.Right + 10
        End If

    End Sub

    Private Sub SetParamsByType(row As DataGridViewRow, lbl As List(Of Label), pnl As ExtPanel)
        _selectedRow = row
        If pnl.Visible Then
            pnl.Visible = False
        End If
        Dim svmModele As String = _selectedRow.Cells("modelefrigo").Value

        Dim dtModeleForView As DataTable = basemodele.modele.Copy()
        Dim iIndx As Integer = basemodele.lstbListOfModels.FindStringExact([svmModele])
        'FindString(SVMModele) 'basemodele.lstbListOfModels.Items.IndexOf(SVMModele)
        If iIndx = -1 Then Exit Sub

        Dim coffre As Byte = Convert.ToByte(_selectedRow.Cells("coffre").Value)
        Dim realTrayOrShelfsStatus As Long
        Dim swr As String = String.Empty
        Dim hexSvm As Long = ModelTools.ModelByIndex(iIndx, coffre)
        pnl.HexSvm = hexSvm
        Select Case coffre
            Case 0, 1, 2
                swr = _selectedRow.Cells("swr").Value.PadLeft(5).Substring(0, 2).Trim()
                'hexSvm = ModelTools.ModelByIndex(iIndx, coffre) 'Model2Hex330(iIndx)

                'PositionByVisibleFor330(hexSvm)
            Case 3
                'hexSvm = ModelTools.ModelByIndex(iIndx, coffre)
                swr = _selectedRow.Cells("swr").Value.PadLeft(13).Trim()
                'TblpanelExtTray.Visible = (hexSvm And &HFF0) <> 0
                'TblpanelExtTray48.Visible = (hexSvm And &HF00) <> 0
                'TblpanelBalcony2Nd.Visible = (hexSvm And &H3F000) <> 0
                'TblpanelMiddleShelf2Nd.Visible = (hexSvm And &HF000000000) <> 0
                'If TblpanelMiddleShelf2Nd.Visible Then
                '    TblpanelMiddleShelf.Visible = (hexSvm And &HF000000000000) <> 0
                'End If
                'Dim hexSvm As Long = ModelTools.ModelByIndex(iIndx, coffre) 'Model2Hex226(iIndx)
                'Model2Hex226(iIndx)

                'Dim flag = False

                'If (((Convert.ToInt64(swr, 16) And &HF00003F000) <> 0) AndAlso LireIniBoolSmart("HiddenValues", "IsCanShow2ndBalconyAndMidleSHelf", False)) _
                '    OrElse (hexSvm And &HF00003F000) <> 0 Then
                '    TblpanelBalcony2Nd.Visible = True
                '    TblpanelMiddleShelf2Nd.Visible = True
                '    'flag = True
                'End If
                'If (hexSvm And &HFF0) <> 0 Then
                '    'tblpanelExtTray.Location = New Point(IIf(flag, tblpanelBalcony2nd.Right + 10, tblpanelBalcony.Right + 10), tblpanelTopShelf.Top)
                '    TblpanelExtTray.Visible = True
                '    If (hexSvm And &HF00) <> 0 Then
                '        TblpanelExtTray48.Visible = True
                '    End If
                'End If
                'realTrayStatus = Convert.ToInt64(SelectedRow.Cells("swr").Value.PadLeft(13).Trim(), 16)
                'If Not TblpanelMiddleShelf.Visible Then
                '    TblpanelBottomShelf.Top = TblpanelMiddleShelf.Top
                '    If TblpanelMiddleShelf2Nd.Visible Then
                '        TblpanelMiddleShelf2Nd.Top = TblpanelBottomShelf.Bottom
                '    End If
                'End If
        End Select
        If String.IsNullOrEmpty(swr) Then
            swr = "0"
        End If
        pnl.Swr = swr
        realTrayOrShelfsStatus = Convert.ToInt64(swr, 16)

        For ind As Integer = 0 To lbl.Count - 1
            lbl(ind).BackColor = Color.Green
            lbl(ind).AutoEllipsis = True
            lbl(ind).Text = IIf(lbl(ind).Tag.ToString().Length > 0, lbl(ind).Tag + Chr(13), "")
            lbl(ind).Image = Nothing
        Next
        '-----------------------------
        For ind As Integer = 0 To _ucList.Count - 1
            _ucList(ind).AddColor(Color.Green)
            _ucList(ind).Reset()
            _ucList(ind).NotUseImage = Nothing
            _ucList(ind).MaxGridValue = Integer.MaxValue
        Next
        '-----------------------------

        Dim sProdactName As String
        Const sFormatStr As String = "{0}{1}{2} / {3}"
        Dim iMaxQ As Integer = 0, iRealQ As Integer = 0, iMp As Integer
        Dim drMp As DataRow = (From mp In DtMomentaryPickUp.AsEnumerable Where mp.Field(Of Integer)("nummodule") = _selectedRow.Cells("nummodule").Value Select mp)(0)
        Dim i As Integer = 4
        If ((hexSvm >> &HC) And &HF0) > 0 Then
            i = 0
        End If
        Dim trayPosition As Integer() = New Integer() {&H10, &H20, &H40, &H80, &H1, &H2, &H4, &H8}
        For casier As Integer = 1 To lbl.Count 'MaxCountOfProducts
            sProdactName = dtModeleForView.Rows(iIndx)("p" + casier.ToString())
            iMaxQ = dtModeleForView.Rows(iIndx)("q" + casier.ToString())
            iRealQ = _selectedRow.Cells("c" + casier.ToString()).Value
            iMp = 0
            ' Not used place
            If String.IsNullOrEmpty(sProdactName) And iMaxQ = 0 Then
                lbl(casier - 1).BackColor = Color.White
                lbl(casier - 1).Image = cancel_48
                If RealShelfStatus(realTrayOrShelfsStatus, casier) Then
                    lbl(casier - 1).BackColor = Color.Aqua
                End If
                Continue For
            End If

            'MP start
            If drMp IsNot Nothing Then
                iMp = drMp("c" + casier.ToString())
            End If
            'lbl(casier - 1).Text = lbl(casier - 1).Text.PadRight(sProdactName.Length)
            lbl(casier - 1).Text += String.Format(sFormatStr, sProdactName, Chr(13), iRealQ.ToString(), iMaxQ.ToString())
            If iRealQ = iMaxQ AndAlso iMp = 1 Then
                lbl(casier - 1).BackColor = Color.Yellow
                lbl(casier - 1).Text += Chr(13) + drMp("dmp" + casier.ToString())
                Continue For
            End If
            'MP end

            Select Case iRealQ
                Case Is < 0
                    lbl(casier - 1).BackColor = Color.Purple
                Case Is < iMaxQ
                    Select Case coffre
                        Case 0 To 2
                            Try
                                'Dim trayStatus As Integer = realTrayOrShelfsStatus >> &HC
                                If (casier > 8 AndAlso (realTrayOrShelfsStatus.LAnd(trayPosition(i)))) Then  '(&H1 << (casier - 9)))
                                    lbl(casier - 1).BackColor = Color.DarkSlateGray  'Coral
                                Else
                                    lbl(casier - 1).BackColor = Color.Gray
                                End If
                            Catch
                            Finally
                                lbl(casier - 1).BackColor = Color.Gray
                            End Try
                        Case 3
                            If (RealShelfStatus(realTrayOrShelfsStatus, casier)) Then
                                lbl(casier - 1).BackColor = Color.DarkSlateGray
                            Else
                                lbl(casier - 1).BackColor = Color.Gray
                            End If
                    End Select

            End Select
            'If iRealQ < iMaxQ And iRealQ >= 0 Then
            '    If iMP = 1 Then
            '        lbl(casier - 1).BackColor = Color.Yellow
            '        lbl(casier - 1).Text += Chr(13) + drMP("dmp" + casier.ToString())
            '    Else
            '        If (Coffre.InSet(0, 2) And casier > 8 And (realTrayStatus.LAnd((&H1 << (casier - 9))) = 1)) Then
            '            lbl(casier - 1).BackColor = Color.DarkSlateGray  'Coral
            '        Else
            '            lbl(casier - 1).BackColor = Color.Gray
            '        End If
            '    End If
            'ElseIf iRealQ < 0 Then
            '    lbl(casier - 1).BackColor = Color.Purple
            'End If
            If casier > 8 Then
                i += 1
            End If
        Next
        If coffre < 3 Then
            '----------------------------------------------------------------------------------------------------------------
            i = 4
            If ((hexSvm >> &HC) And &HF0) > 0 Then
                i = 0
            End If
            For casier As Integer = 1 To _ucList.Count 'MaxCountOfProducts
                sProdactName = dtModeleForView.Rows(iIndx)("p" + casier.ToString())
                iMaxQ = dtModeleForView.Rows(iIndx)("q" + casier.ToString())
                iRealQ = _selectedRow.Cells("c" + casier.ToString()).Value
                iMp = 0
                ' Not used place
                If String.IsNullOrEmpty(sProdactName) And iMaxQ = 0 Then
                    _ucList(casier - 1).AddColor(Color.White)
                    _ucList(casier - 1).NotUseImage = cancel_48
                    If RealShelfStatus(realTrayOrShelfsStatus, casier) Then
                        _ucList(casier - 1).AddColor(Color.Aqua)
                    End If
                    Continue For
                End If

                'MP start
                If drMp IsNot Nothing Then
                    iMp = drMp("c" + casier.ToString())
                End If
                'lbl(casier - 1).Text = lbl(casier - 1).Text.PadRight(sProdactName.Length)
                _ucList(casier - 1).CellProductName = sProdactName 'String.Format(sFormatStr, sProdactName, Chr(13), iRealQ.ToString(), iMaxQ.ToString())
                _ucList(casier - 1).RealValue = iRealQ
                _ucList(casier - 1).ValueBefore = iRealQ
                _ucList(casier - 1).MaxGridValue = iMaxQ
                If iRealQ = iMaxQ AndAlso iMp = 1 Then
                    _ucList(casier - 1).AddColor(Color.Yellow)
                    _ucList(casier - 1).CellProductName += Chr(13) + drMp("dmp" + casier.ToString())
                    Continue For
                End If
                'MP end

                Select Case iRealQ
                    Case Is < 0
                        _ucList(casier - 1).AddColor(Color.Purple)
                    Case Is < iMaxQ
                        Select Case coffre
                            Case 0 To 2
                                Try
                                    'Dim trayStatus As Integer = realTrayOrShelfsStatus >> &HC
                                    If (casier > 8 AndAlso (realTrayOrShelfsStatus.LAnd(trayPosition(i)))) Then  '(&H1 << (casier - 9)))
                                        _ucList(casier - 1).AddColor(Color.DarkSlateGray)  'Coral
                                    Else
                                        _ucList(casier - 1).AddColor(Color.Gray)
                                    End If
                                Catch
                                Finally
                                    _ucList(casier - 1).AddColor(Color.Gray)
                                End Try
                            Case 3
                                If (RealShelfStatus(realTrayOrShelfsStatus, casier)) Then
                                    lbl(casier - 1).BackColor = Color.DarkSlateGray
                                Else
                                    lbl(casier - 1).BackColor = Color.Gray
                                End If
                        End Select

                End Select

                If casier > 8 Then
                    i += 1
                End If
            Next
            '----------------------------------------------------------------------------------------------------------------
        End If

        pnl.Width = Me.Width - pnlLeft.Width - pnlLeft.Margin.Right - pnlLegend.Width - pnlLeft.Margin.Left - 15
        pnl.Height = Me.Height - pnlTop.Height - 20
        pnl.Visible = True
        pnl.BringToFront()
    End Sub
    Private Function findRowByRoom(room As String) As Integer
        Dim currManager As CurrencyManager = CType(dgvExtView.BindingContext(dgvExtView.DataSource), CurrencyManager)
        Dim dv As DataView = CType(currManager.List, DataView)
        If room.Length = 0 OrElse currManager.Count = 0 Then
            Exit Function
        End If

        dv.Sort = "numchambre"

        Dim pos As Integer
        Return dv.Find(room)

    End Function



    Public Sub SetParams(room As String)
        Dim pos As Integer = findRowByRoom(room)
        Dim row As DataGridViewRow = dgvExtView.Rows(pos)
        Dim arg As New DataGridViewCellEventArgs(0, pos)
        dgvExtView.ClearSelection()
        dgvExtView.FirstDisplayedCell = row.Cells("numchambre")
        dgvExtView_RowEnter(Me, arg)
        
        SetParams(row)
    End Sub

    Public Sub SetParams(row As DataGridViewRow)
        _selectedRow = row
        If _selectedRow Is Nothing Then
            Exit Sub
        End If
        Dim statusString = String.Format("{0} - {1} ({2}:{3}), {4}: {5}", _
                                         Trans(28), _selectedRow.Cells("numchambre").Value.ToString(), _
                                         Trans(32), _selectedRow.Cells("nummodule").Value.ToString(), _
                                         Trans(287), _selectedRow.Cells("modelefrigo").Value.ToString())
        lblStatus1.Text = statusString
        statusString = String.Format("PMS Status: {0}", _selectedRow.Cells("savserrure").Value.ToString())
        lblStatus2.Text = statusString
        'lblRoomNText.Text = _selectedRow.Cells("numchambre").Value.ToString() + "/" + _selectedRow.Cells("nummodule").Value.ToString()
        'lblDoorStatusText.Text = _selectedRow.Cells("etatporte").Value.ToString() + "/" + _selectedRow.Cells("serrure").Value.ToString()
        'lblRoomStatusTest.Text = _selectedRow.Cells("check").Value.ToString()
        lblTempText.Text = _selectedRow.Cells("etattemp").Value.ToString()
        'lblServiceSwitchText.Text = IIf(CInt(_selectedRow.Cells("Service").Value.ToString()) = 1, Trans(51), Trans(50))
        pbSW.Image = IIf(CInt(_selectedRow.Cells("Service").Value.ToString()) = 1, SwithOn, SwithOff) 'on36, off36)
        lblItemsNbText.Text = _selectedRow.Cells("nbconso").Value.ToString()
        lblBalanceText.Text = _selectedRow.Cells("factureclient").Value.ToString()
        Dim coffre = CInt(_selectedRow.Cells("coffre").Value)
        If coffre < 3 AndAlso Convert.ToBoolean(ModelTools.Is226Model(_selectedRow.Cells("modelefrigo").Value)) Then
            coffre = 3
        End If
        'pbLockUnlock.Image = IIf(_selectedRow.Cells("serrure").Value.ToString().Equals(Trans(35)), LOCK, UNLOCK)
        'pbLitleLockUnlock.Image = IIf(_selectedRow.Cells("serrure").Value.ToString().Equals(Trans(35)), LOCK24, unlock24)
        Dim lockImg As Image = IIf(_selectedRow.Cells("serrure").Value.ToString().Equals(Trans(35)), LockVert, UnlockVert)
        Dim minibarImg As Image
        Select Case coffre
            Case 0, 1, 2
                minibarImg = IIf(_selectedRow.Cells("etatporte").Value.ToString().Equals(Trans(51)), _330open, _330closed)
                SetParamsByType(_selectedRow, _labels, PnlHomi330New)
            Case 3
                minibarImg = IIf(_selectedRow.Cells("etatporte").Value.ToString().Equals(Trans(51)), _226open, _226closed)
                SetParamsByType(_selectedRow, _labels226New, PnlHomi226New)
        End Select
        'dgvExtView.CurrentCell = dgvExtView.Item(1, _selectedRow.Index)
        '_selectedRow.Selected = True
        pbMinibar.Image = CombineBitmap(minibarImg, lockImg)
        pbMinibar.Tag = IIf(_selectedRow.Cells("serrure").Value.ToString().Equals(Trans(35)), 2, 1)
    End Sub
    Private Function CreateLabel4CellOfTblPanel(labelName As String, cnt As Integer) As List(Of Label)
        Dim lbl As Label
        Dim result As New List(Of Label)
        For casier As Integer = 1 To cnt
            lbl = New Label()
            lbl.Name = labelName + casier.ToString()
            lbl.Dock = DockStyle.Fill
            lbl.BackColor = Color.Green
            'lbl.Font = New Font(lbl.Font, FontStyle.Bold)
            lbl.Font = New Font(lbl.Font.FontFamily, 10, FontStyle.Bold)
            lbl.Text = ""
            lbl.Tag = casier.ToString()
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.AutoEllipsis = True
            lbl.Margin = New Padding(0, 0, 0, 0)
            result.Add(lbl)
        Next
        Return result
    End Function
    Private _ucList As New List(Of Usc330GridCell)
    Private Sub SetButtons330()
        Dim buttons As List(Of GlassButton) = MakeButtonFor330Panel()
        For i As Integer = 0 To 3
            _tblpanelButtons330.Controls.Add(buttons(i), i, 0)
        Next
    End Sub
    Private Function MakeButtonFor330Panel() As List(Of GlassButton)
        Dim result As New List(Of GlassButton)
        Dim names() As String = New String() {"Minus", "Full", "Reset", "Manual Refill"}
        For i As Integer = 1 To 4
            Dim btn As GlassButton = New GlassButton()
            With btn
                .AutoSize = True
                .Dock = DockStyle.Fill
                .AutoEllipsis = True
                .Name = names(i - 1)
                .Text = names(i - 1)
                .BackColor = Color.Navy
                .ImageAlign = ContentAlignment.MiddleLeft
                .ForeColor = Color.White
                .GlowColor = Color.Blue
                .Font = New Font(.Font.FontFamily, 8.25, FontStyle.Bold)
                .TextAlign = ContentAlignment.MiddleLeft
                .TextImageRelation = TextImageRelation.ImageBeforeText
                Select Case i
                    Case 1
                        .Image = moins24 'HomiNet.My.Resources.
                    Case 4
                        .Image = envoi24
                End Select

                AddHandler .Click, AddressOf buttons_Click
                .Tag = i
            End With
            result.Add(btn)
        Next
        Return result
    End Function

    

    Private Sub buttons_Click(sender As Object, e As EventArgs)
        Dim btn = TryCast(sender, GlassButton)
        If btn IsNot Nothing Then
            Dim sendStr As String = String.Empty

            Select Case btn.tag
                Case 1
                    _ucList.ForEach(Sub(uc) If uc.RealValue < 0 Then uc.RealValue = 0)
                    'Dim s As List(Of String) = _ucList.Select(Function(uc) CStr(uc.ForManualRefillValue)).Cast(Of String)()

                    'AddCommand(_selectedRow, String.Format("{0}|{1}", Commands.AddStock.ToString().ToUpper(), sendStr))
                Case 2
                    _ucList.ForEach(Sub(uc) uc.RealValue = uc.MaxGridValue)
                Case 3
                    _ucList.ForEach(Sub(uc) uc.RealValue = uc.ValueBefore)
                    Exit Sub
                Case 4
                    '_ucList.ForEach(Sub(uc) sendStr += uc.ForManualRefillValue + " ")
                    
            End Select
            _ucList.ForEach(Sub(uc) sendStr += uc.ForManualRefillValue + " ")
            Remplissagemanuel.LogString(sendStr)
            AddCommand(_selectedRow, String.Format("{0}|{1}", Commands.AddStock.ToString().ToUpper(), sendStr))
        End If
    End Sub

    Private Shared Function MakeUcFor330(cnt As Integer) As List(Of Usc330GridCell)
        Dim result As New List(Of Usc330GridCell)
        For casier As Integer = 1 To cnt
            Dim cntrl As Usc330GridCell = New Usc330GridCell()
            With cntrl
                .CellNumber = casier
                .Dock = DockStyle.Fill
                .AutoSize = True
            End With
            result.Add(cntrl)
        Next
        Return result
    End Function
    Private Sub SetLabelHomi330NewWithuserControl()
        _ucList.Clear()
#If MiniBarVer = "226" Then
        _ucList = MakeUCFor330(16)
#ElseIf MiniBarVer = "330" OrElse MinibarVer = "330tray8" Then
        _ucList = MakeUCFor330(IIf(CountOfProductsHomi330 + 4 < MaxCountOfProducts, CountOfProductsHomi330 + 4, CountOfProductsHomi330))
#End If
        Dim casier As Integer
        casier = 0
        Dim maxUcWidth = _ucList.Max(Function(x) x.Width)
        Dim maxUcHeight = _ucList.Max(Function(x) x.Height)
        'left
        'Dim tblCapacity = TblpanelLeftSide.RowStyles(0).Height
        'TblpanelLeftSide.ColumnStyles(0).Width = maxUcWidth
        TblpanelLeftSide.Width = maxUcWidth
        TblpanelRightSide.Width = maxUcWidth
        For i As Integer = 1 To 4
            TblpanelLeftSide.RowStyles(i).Height = maxUcHeight
            TblpanelLeftSide.Controls.Add(_ucList(casier), 0, i)
            casier += 1
            '   tblCapacity += TblpanelLeftSide.RowStyles(i).Height
        Next
        TblpanelLeftSide.Height = 4 * maxUcHeight + TblpanelLeftSide.RowStyles(0).Height
        'right
        'tblCapacity = TblpanelRightSide.RowStyles(0).Height
        'TblpanelRightSide.ColumnStyles(0).Width = maxUcWidth
        For i As Integer = 1 To 4
            TblpanelRightSide.RowStyles(i).Height = maxUcHeight
            TblpanelRightSide.Controls.Add(_ucList(casier), 0, i)
            casier += 1
            'tblCapacity += TblpanelRightSide.RowStyles(i).Height
        Next
        TblpanelRightSide.Height = 4 * maxUcHeight + TblpanelRightSide.RowStyles(0).Height
        'TblpanelRightSide.Width = _ucList(0).Width
        'tblCapacity = 0
        _tblpanelExtTray330.Width = 4 * maxUcWidth
        If casier < _ucList.Count Then 'CountOfProductsHomi330 Then
            _tblpanelExtTray330.RowStyles(1).Height = maxUcHeight
            For i As Integer = 1 To 4
                'TblpanelExtTray330.ColumnStyles(i - 1) = New ColumnStyle(SizeType.Absolute, maxUcWidth) '_ucList(casier).Width
                _tblpanelExtTray330.Controls.Add(_ucList(casier), i - 1, 1)
                casier += 1
                'tblCapacity += TblpanelExtTray330.ColumnStyles(i - 1).Width
            Next
        End If

        _tblpanelExtTray330.Height = maxUcHeight + _tblpanelExtTray330.RowStyles(0).Height

        If casier < _ucList.Count Then 'CountOfProductsHomi330 Then
            For i As Integer = 1 To 4
                _tblpanelExtTray33048.Controls.Add(_ucList(casier), i - 1, 0)
                casier += 1
            Next
        End If
    End Sub


    Private Sub SetLabelHomi330New()
        'Dim lbl As Label
        _labels.Clear()
#If MiniBarVer = "226" Then
        _labels = CreateLabel4CellOfTblPanel("lbl330C", 16)
#ElseIf MiniBarVer = "330" OrElse MinibarVer = "330tray8" Then
        _labels = CreateLabel4CellOfTblPanel("lbl330C", IIf(CountOfProductsHomi330 + 4 < MaxCountOfProducts, CountOfProductsHomi330 + 4, CountOfProductsHomi330))
#End If
        '_labels = CreateLabel4CellOfTblPanel("lbl330C", IIf(CountOfProductsHomi330 + 4 < MaxCountOfProducts, CountOfProductsHomi330 + 4, CountOfProductsHomi330))
        Return
        Dim casier As Integer
        casier = 0
        For i As Integer = 1 To 4
            TblpanelLeftSide.Controls.Add(_labels(casier), 0, i)
            casier += 1
        Next
        For i As Integer = 1 To 4
            TblpanelRightSide.Controls.Add(_labels(casier), 0, i)
            casier += 1
        Next

        If casier < _labels.Count Then 'CountOfProductsHomi330 Then
            For i As Integer = 1 To 4
                _tblpanelExtTray330.Controls.Add(_labels(casier), i - 1, 1)
                casier += 1
            Next
        End If

        If casier < _labels.Count Then 'CountOfProductsHomi330 Then
            For i As Integer = 1 To 4
                _tblpanelExtTray33048.Controls.Add(_labels(casier), i - 1, 0)
                casier += 1
            Next
        End If
    End Sub

    Private Sub SetLabelHomi226New()
        If MaxCountOfProducts <= 16 Then
            Exit Sub
        End If
        'Dim lbl As Label
        _labels226New.Clear()
        _labels226New = CreateLabel4CellOfTblPanel("lbl226C", MaxCountOfProducts)
        Dim casier As Integer
        casier = 0
        'top Shelf
        For i As Integer = 1 To 4
            TblpanelTopShelf.Controls.Add(_labels226New(casier), i - 1, 2)
            TblpanelTopShelf.Controls.Add(_labels226New(casier + 1), i - 1, 1)
            casier += 2
        Next
        For i As Integer = 1 To 4
            TblpanelMiddleShelf.Controls.Add(_labels226New(casier), i - 1, 1)
            casier += 1
        Next

        'Botton Shelf
        For i As Integer = 1 To 4
            TblpanelBottomShelf.Controls.Add(_labels226New(casier), i - 1, 2)
            TblpanelBottomShelf.Controls.Add(_labels226New(casier + 1), i - 1, 1)
            casier += 2
        Next
        '2nd Middle Shelf
        For i As Integer = 1 To 4
            TblpanelMiddleShelf2Nd.Controls.Add(_labels226New(casier), i - 1, 1)
            casier += 1
        Next
        'Balcony 1
        'casier += 4
        For i As Integer = 1 To 6
            TblpanelBalcony.Controls.Add(_labels226New(casier), 0, i)
            casier += 1
        Next
        'Balcony 2
        For i As Integer = 1 To 6
            TblpanelBalcony2Nd.Controls.Add(_labels226New(casier), 0, i)
            casier += 1
        Next
        'External Tray (1st 4)
        'casier += 6
        If casier < MaxCountOfProducts Then
            For i As Integer = 1 To 4

                TblpanelExtTray.Controls.Add(_labels226New(casier), i - 1, 1)
                casier += 1
            Next
        End If
        'External Tray (2nd 4)
        If casier < MaxCountOfProducts Then
            For i As Integer = 1 To 4
                TblpanelExtTray48.Controls.Add(_labels226New(casier), i - 1, 0)
                casier += 1
            Next
        End If
    End Sub


    Private Sub ViewByModele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialize()
        InitLanguage()
        CreatePanels()

        SetLabelHomi226New()
        SetLabelHomi330New()
        SetLabelHomi330NewWithuserControl()
        SetButtons330()
        Dim x As Integer = pnlLeft.Right + 10, y As Integer = pnlLeft.Top
        PnlHomi226New.Location = New Point(x, y)
        PnlHomi330New.Location = New Point(x, y)
        tmrDoubleClick.Interval = 100
        'tmrDoubleClick.Tick = New EventHandler(AddressOf tmrDoubleClick_Tick)

    End Sub
    Public WriteOnly Property CountForExtView
        Set(value)
            lblCount.Text = value.ToString()
        End Set
    End Property
    Public Sub InitView()
        'lbRooms.DataSource = dv1
        'lbRooms.DisplayMember = "numchambre"
        'lbRooms.MultiColumn = False
        'lbRooms.ValueMember = "nummodule"
        _filterStr = Dv1.RowFilter

        dgvExtView.DataSource = Dv1
        Dv1.RowFilter = String.Format("numchambre Not Like 'R*' and test<>'{0}'", Trans(37)) '"numchambre Not Like 'R*' and " + "test<>'" + Trans(37) + "'"
        'For Each foundFile As String In From foundFiles In My.Computer.FileSystem.GetFiles(Application.StartupPath + "\Z\") Where foundFiles.Contains(el2) = True
        For Each clm As DataGridViewColumn In From columns In dgvExtView.Columns Where Not columns.Name.ToString().InSet(New String() {"numchambre", "test"})
            clm.Visible = False
        Next
        dgvExtView.Columns("numchambre").HeaderText = Trans(28)
        dgvExtView_DataSourceChanged(dgvExtView, Nothing)
    End Sub
    'Private Sub lbRooms_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    PnlHomi226New.Visible = False
    '    PnlHomi330New.Visible = False
    '    If lbRooms.SelectedIndex >= 0 AndAlso Visible = True Then
    '        SetParams(Table.dgvMain.SelectedRows(0))
    '    End If

    'End Sub

    Private Sub ViewByModele_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        HideSearchPanel()
        _isFiltered = False
        'lbRooms.DataSource = Nothing
        Dv1.RowFilter = _filterStr
    End Sub
    Private Sub _tblpanelExtTray330_LocationChanged(sender As Object, e As EventArgs) Handles _tblpanelExtTray330.LocationChanged
        _tblpanelExtTray33048.Left = _tblpanelExtTray330.Left
    End Sub

    Private Sub pnlHomi330New_VisibleChanged(sender As Object, e As EventArgs) Handles PnlHomi330New.VisibleChanged
        If PnlHomi330New.Visible Then
            PositionByVisibleFor330(PnlHomi330New.HexSvm)

            Dim x As Integer = _tblpanelExtTray33048.Left
            If TblpanelRightSide.Visible Then
                x = TblpanelRightSide.Right + 10
            Else
                If TblpanelLeftSide.Visible Then
                    x = TblpanelLeftSide.Right + 10
                End If
            End If
            Dim y As Integer = _tblpanelExtTray330.Top
            If _tblpanelExtTray33048.Visible Then
                y = _tblpanelExtTray33048.Bottom + 10
            Else
                If _tblpanelExtTray330.Visible Then
                    y = _tblpanelExtTray330.Bottom + 10
                End If
            End If
            _tblpanelButtons330.Width = _tblpanelButtons330.ColumnCount * 100 'btnSend.Width
            _tblpanelButtons330.Height = 60 'btnSend.Height
            _tblpanelButtons330.Location = New Point(x, y)
            _tblpanelButtons330.CellBorderStyle = TableLayoutPanelCellBorderStyle.None
        End If
    End Sub

    Private Sub pnlHomi226New_VisibleChanged(sender As Object, e As EventArgs) Handles PnlHomi226New.VisibleChanged
        If PnlHomi226New.Visible Then
            Dim hexSvm = PnlHomi226New.HexSvm
            TblpanelExtTray.Visible = (hexSvm And &HFF0) <> 0
            TblpanelExtTray48.Visible = (hexSvm And &HF00) <> 0
            TblpanelBalcony2Nd.Visible = (hexSvm And &H3F000) <> 0
            TblpanelMiddleShelf2Nd.Visible = (hexSvm And &HF000000000) <> 0
            If TblpanelMiddleShelf2Nd.Visible Then
                TblpanelMiddleShelf.Visible = (hexSvm And &HF000000000000) <> 0
            End If


            If (((Convert.ToInt64(PnlHomi226New.Swr, 16) And &HF00003F000) <> 0) AndAlso LireIniBoolSmart("HiddenValues", "IsCanShow2ndBalconyAndMidleSHelf", False)) _
                OrElse (hexSvm And &HF00003F000) <> 0 Then
                TblpanelBalcony2Nd.Visible = True
                TblpanelMiddleShelf2Nd.Visible = True
                'flag = True
            End If
            TblpanelExtTray.Location = New Point(IIf(TblpanelBalcony2Nd.Visible, TblpanelBalcony2Nd.Right + 10, TblpanelBalcony.Right + 10), TblpanelTopShelf.Top)
            TblpanelBottomShelf.Location = New Point(TblpanelTopShelf.Left, IIf(TblpanelMiddleShelf.Visible, TblpanelMiddleShelf.Bottom + 30, TblpanelMiddleShelf.Top))
            TblpanelMiddleShelf2Nd.Location = New Point(TblpanelBottomShelf.Left, TblpanelBottomShelf.Bottom + 30)
        End If
    End Sub


    Private Sub lblRooms_Click(sender As Object, e As EventArgs) Handles lblRooms.Click
        If Not gradpnlSearch.Visible Then
            ShowSearchPanel()
        Else
            HideSearchPanel()
        End If
    End Sub
    Private Sub ShowSearchPanel()
        gradpnlSearch.Visible = True
        lblRooms.SendToBack()
    End Sub
    Private Sub HideSearchPanel()
        tbFind.Text = ""
        gradpnlSearch.Visible = False
        lblRooms.BringToFront()
    End Sub
    Private Sub gbtnFind_Click(sender As Object, e As EventArgs) Handles gbtnFind.Click
        'Dim currManager As CurrencyManager = CType(lbRooms.BindingContext(lbRooms.DataSource), CurrencyManager)
        Dim currManager As CurrencyManager = CType(dgvExtView.BindingContext(dgvExtView.DataSource), CurrencyManager)
        Dim dv As DataView = CType(currManager.List, DataView)
        If tbFind.Text.ToString.Length = 0 OrElse currManager.Count = 0 Then
            Exit Sub
        End If

        dv.Sort = "numchambre"

        Dim pos As Integer
        pos = dv.Find(tbFind.Text.ToString())
        If pos > -1 Then
            currManager.Position = pos
            'dgvExtView.CurrentRow.Selected = True 'SetSelected(pos, True)

            Dim arg As New DataGridViewCellEventArgs(0, dgvExtView.CurrentRow.Index)
            dgvExtView_RowEnter(Me, arg)
        Else
            MessageBox.Show(String.Format("{0} {1} not found", Trans(28), tbFind.Text.ToString()))
        End If
        HideSearchPanel()
    End Sub
    Private Shared Function CombineBitmap(minibar As Image, locker As Image) As Bitmap
        Dim finalImage As Bitmap
        Try
            Dim padX = Convert.ToInt32(locker.Width / 2)
            Dim padY = Convert.ToInt32(locker.Height / 2)
            Dim width As Integer = minibar.Width + padX
            Dim height As Integer = minibar.Height + padY
            finalImage = New Bitmap(width, height)
            Using g As Graphics = Graphics.FromImage(finalImage)
                g.Clear(Color.Transparent)
                g.DrawImage(minibar, New Rectangle(padX, padY, minibar.Width, minibar.Height))
                g.DrawImage(locker, Point.Empty)
            End Using
            Return finalImage
        Catch ex As Exception
            If finalImage IsNot Nothing Then
                finalImage.Dispose()
            End If
        End Try
    End Function

    'Private Sub lbRooms_Format(sender As System.Object, e As System.Windows.Forms.ListControlConvertEventArgs)
    '    Dim row As DataRow = DirectCast(e.ListItem, DataRowView).Row
    '    e.Value = e.Value.ToString().PadLeft(10) & " |" & row("test").ToString() & " |" & row("modelefrigo")
    'End Sub

    Private Sub dgvExtView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExtView.RowEnter
        If Not dgvExtView.Rows(e.RowIndex).Selected Then
            dgvExtView.Rows(e.RowIndex).Selected = True
        End If
        PnlHomi226New.Visible = False
        PnlHomi330New.Visible = False
        If dgvExtView.SelectedRows.Count > 0 AndAlso Visible = True Then
            SetParams(dgvExtView.SelectedRows(0))
        End If

    End Sub
#Region "Buttons"
    Private Sub pbMinibar_MouseDown(sender As Object, e As MouseEventArgs) Handles pbMinibar.MouseDown
        If _isFirstClick Then
            _isFirstClick = False
            tmrDoubleClick.Start()
        Else
            If _doubleClickRectangle.Contains(e.Location) AndAlso _milliseconds < SystemInformation.DoubleClickTime Then
                _isDoubleClick = True
            End If
        End If
    End Sub

    'Private Sub pbMinibar_DoubleClick(sender As System.Object, e As System.EventArgs) Handles pbMinibar.DoubleClick

    'End Sub
    'Private Sub pbMinibar_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pbMinibar.MouseClick

    '    If dgvExtView.SelectedRows.Count > 0 AndAlso Visible = True Then
    '        Table.AddEmis(CInt(dgvExtView.CurrentRow.Cells("nummodule").Value), "TEST")
    '    End If
    'End Sub

    'Private Sub pbMinibar_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pbMinibar.MouseDoubleClick
    '    If e.X > 0 AndAlso e.X < 24 AndAlso e.Y > 0 AndAlso e.Y < 30 Then
    '        MessageBox.Show("V")
    '    End If

    'End Sub

    Private Sub tmrDoubleClick_Tick(sender As Object, e As EventArgs) Handles tmrDoubleClick.Tick
        _milliseconds += 100

        If _milliseconds >= SystemInformation.DoubleClickTime Then
            tmrDoubleClick.Stop()
            If _isDoubleClick Then
                AddCommand(_selectedRow, CType(pbMinibar.Tag, Commands).ToString.ToUpper())
            Else
                If dgvExtView.SelectedRows.Count > 0 AndAlso Visible = True Then
                    AddCommand(_selectedRow, Commands.Test.ToString().ToUpper())
                End If
            End If
            _isFirstClick = True
            _isDoubleClick = False
            _milliseconds = 0
        End If
    End Sub

    Private Sub AddCommand(row As DataGridViewRow, command As String)
        row.Cells("e").Value = "*"
        Table.AddEmis(CInt(row.Cells("nummodule").Value), command)
    End Sub

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        AddCommand(_selectedRow, Commands.Unlock.ToString().ToUpper())
    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        AddCommand(_selectedRow, Commands.Lock.ToString().ToUpper())
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim s As String = String.Empty
        Select Case CInt(_selectedRow.Cells("coffre").Value)
            Case 0, 1, 2
                _ucList.ForEach(Sub(uc) s += uc.ForManualRefillValue + " ")
            Case 3
                s = s.PadLeft(MaxCountOfProducts, "0").Replace("0", "0 ")
        End Select
        Remplissagemanuel.LogString(s)
        AddCommand(_selectedRow, String.Format("{0}|{1}", Commands.AddStock.ToString().ToUpper(), s))
    End Sub
#End Region

    Private Sub tsmiAll_Click(sender As System.Object, e As System.EventArgs) Handles tsmiAll.Click
        _isFiltered = False
        dgvExtView.Visible = False
        'RemoveHandler dgvExtView.RowEnter, AddressOf dgvExtView_RowEnter
        Dv1.RowFilter = String.Format("numchambre Not Like 'R*' and test<>'{0}'", Trans(37))
        dgvExtView.DataSource = Dv1
        dgvExtView.FirstDisplayedCell = Nothing
        dgvExtView.ClearSelection()
        'AddHandler dgvExtView.RowEnter, AddressOf dgvExtView_RowEnter
        dgvExtView.Visible = True

    End Sub

    Private Sub tsmiToRefill_Click(sender As System.Object, e As System.EventArgs) Handles tsmiToRefill.Click
        _isFiltered = True
        dgvExtView.Visible = False
        'RemoveHandler dgvExtView.RowEnter, AddressOf dgvExtView_RowEnter
        dgvExtView.DataSource = Remplissage.Dvr
        dgvExtView.FirstDisplayedCell = Nothing
        dgvExtView.ClearSelection()
        'AddHandler dgvExtView.RowEnter, AddressOf dgvExtView_RowEnter
        dgvExtView.Visible = True
        If dgvExtView.Rows.Count > 0 Then
            dgvExtView.Rows(0).Selected = True
        End If
        
    End Sub
    Dim _isFiltered As Boolean = False
    Private Sub dgvExtView_DataSourceChanged(sender As System.Object, e As System.EventArgs) Handles dgvExtView.DataSourceChanged
        lblCount.Text = Trans(48) + " " + dgvExtView.Rows.Count().ToString() + " " + IIf(_isFiltered, Trans(343), "")
    End Sub

End Class