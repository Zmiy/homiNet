﻿
Imports HomiNet.My.Resources

Public Class ViewByModele
    Private _selectedRow As DataGridViewRow
    'Private _dvRoomsForView As New DataView
    Private _labels As New List(Of Label)
    'Private _labels226 As New List(Of Label)
    Private _labels226New As New List(Of Label)

    'New Panel 226 &330/336
    '
    Friend WithEvents PnlHomi226New As Panel = New Panel()
    Friend WithEvents PnlHomi330New As Panel = New Panel()

    Friend WithEvents TblpanelTopShelf As TableLayoutPanel = New TableLayoutPanel()
    Friend WithEvents TblpanelMiddleShelf As TableLayoutPanel = New TableLayoutPanel()
    Friend WithEvents TblpanelBottomShelf As TableLayoutPanel = New TableLayoutPanel()
    Friend WithEvents TblpanelBalcony As TableLayoutPanel = New TableLayoutPanel()
    Friend WithEvents TblpanelExtTray As TableLayoutPanel = New TableLayoutPanel()
    Friend WithEvents TblpanelExtTray48 As TableLayoutPanel = New TableLayoutPanel()

    Friend WithEvents TblpanelMiddleShelf2Nd As TableLayoutPanel = New TableLayoutPanel()
    Friend WithEvents TblpanelBalcony2Nd As TableLayoutPanel = New TableLayoutPanel()

    Friend WithEvents TblpanelLeftSide As TableLayoutPanel = New TableLayoutPanel()
    Friend WithEvents TblpanelRightSide As TableLayoutPanel = New TableLayoutPanel()
    Friend WithEvents TblpanelExtTray330 As TableLayoutPanel = New TableLayoutPanel()
    Friend WithEvents TblpanelExtTray33048 As TableLayoutPanel = New TableLayoutPanel()

    Friend WithEvents LblTopName As Label = New Label()
    Friend WithEvents LblMiddleName As Label = New Label()
    Friend WithEvents LblMiddleName2Nd As Label = New Label()
    Friend WithEvents LblBottomName As Label = New Label()
    Friend WithEvents LblBalconyName As Label = New Label()
    Friend WithEvents LblBalconyName2Nd As Label = New Label()
    Friend WithEvents LblTrayName As Label = New Label()
    Friend WithEvents LblLeftName As Label = New Label()
    Friend WithEvents LblRightName As Label = New Label()
    Friend WithEvents LblTray330Name As Label = New Label()
    '
    '

    Private Sub GlassButton9_Click(sender As Object, e As EventArgs) Handles GlassButton9.Click
        MAINFORM.tabMain.TabPages(table).Select()
    End Sub

    Private Shared Sub CreatePanel(pnl As Panel, panelName As String, cntrl As Control())
        pnl.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
        Or AnchorStyles.Left) _
        Or AnchorStyles.Right), AnchorStyles)

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
        Next
        result.Size = New Size(95 * colCnt, IIf(rowCnt > 1, 79 * (rowCnt - 1) + result.RowStyles(0).Height, 79))
        If lblDescr IsNot Nothing Then
            result.Controls.Add(lblDescr, 0, 0)
            result.SetColumnSpan(lblDescr, colCnt)
        End If
        Return result
    End Function
    Private Function CreateDescrLabel(name As String, Text As String) As Label
        Dim result As Label = New Label()
        result.BackColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        result.Dock = DockStyle.Fill
        result.Font = New Font("Microsoft Sans Serif", 10.5!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CType(0, Byte))
        'result.Location = New System.Drawing.Point(0, 0)
        result.Name = "lbl" + name
        'result.Size = New System.Drawing.Size(83, 20)
        result.TextAlign = ContentAlignment.MiddleLeft
        'result.Margin = New Padding(0, 0, 0, 0)
        'result.TabIndex = 0
        result.Text = Text

        Return result
    End Function
    Private Sub SuspendL()
        Me.TblpanelTopShelf.SuspendLayout()
        Me.TblpanelMiddleShelf.SuspendLayout()
        Me.TblpanelBottomShelf.SuspendLayout()
        Me.TblpanelBalcony.SuspendLayout()
        Me.TblpanelExtTray.SuspendLayout()
        Me.TblpanelExtTray48.SuspendLayout()
        Me.TblpanelMiddleShelf2Nd.SuspendLayout()
        Me.TblpanelBalcony2Nd.SuspendLayout()
        Me.PnlHomi226New.SuspendLayout()

        Me.TblpanelLeftSide.SuspendLayout()
        Me.TblpanelRightSide.SuspendLayout()
        Me.TblpanelExtTray330.SuspendLayout()
        Me.TblpanelExtTray33048.SuspendLayout()
        Me.PnlHomi330New.SuspendLayout()

        Me.SuspendLayout()
    End Sub
    Private Sub ResumeL()
        Me.TblpanelTopShelf.ResumeLayout(False)
        Me.TblpanelTopShelf.PerformLayout()
        Me.TblpanelMiddleShelf.ResumeLayout(False)
        Me.TblpanelMiddleShelf.PerformLayout()
        Me.TblpanelMiddleShelf2Nd.ResumeLayout(False)
        Me.TblpanelMiddleShelf2Nd.PerformLayout()
        Me.TblpanelBottomShelf.ResumeLayout(False)
        Me.TblpanelBottomShelf.PerformLayout()
        Me.TblpanelBalcony.ResumeLayout(False)
        Me.TblpanelBalcony.PerformLayout()
        Me.TblpanelBalcony2Nd.ResumeLayout(False)
        Me.TblpanelBalcony2Nd.PerformLayout()
        Me.TblpanelExtTray.ResumeLayout(False)
        Me.TblpanelExtTray.PerformLayout()
        Me.TblpanelExtTray48.ResumeLayout(False)
        Me.TblpanelExtTray48.PerformLayout()

        Me.TblpanelLeftSide.ResumeLayout(False)
        Me.TblpanelLeftSide.PerformLayout()
        Me.TblpanelRightSide.ResumeLayout(False)
        Me.TblpanelRightSide.PerformLayout()

        Me.TblpanelExtTray330.ResumeLayout(False)
        Me.TblpanelExtTray330.PerformLayout()
        Me.TblpanelExtTray33048.ResumeLayout(False)
        Me.TblpanelExtTray33048.PerformLayout()

        Me.PnlHomi226New.ResumeLayout(False)
        Me.PnlHomi330New.ResumeLayout(False)

        Me.ResumeLayout(False)
    End Sub
    Private Sub CreatePanels()
        SuspendL()

        MakeLPanelHomi226()
        MakeLPanelHomi330()

        CreatePanel(PnlHomi226New, "pnlHomi226New", New Control() {TblpanelTopShelf, TblpanelMiddleShelf, TblpanelBottomShelf, TblpanelBalcony, TblpanelExtTray, TblpanelExtTray48, TblpanelBalcony2Nd, TblpanelMiddleShelf2Nd})
        CreatePanel(PnlHomi330New, "pnlHomi330New", New Control() {TblpanelLeftSide, TblpanelRightSide, TblpanelExtTray330, TblpanelExtTray33048})
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
        TblpanelExtTray330 = CreateLayoutPanel(4, 2, "tblpanelExtTray", LblTray330Name)
        TblpanelExtTray330.Location = New Point(TblpanelRightSide.Right + 10, TblpanelRightSide.Top)
        'if use tray 8 need add another 4 position
        TblpanelExtTray33048 = CreateLayoutPanel(4, 1, "tblpanelExtTray48", Nothing)
        TblpanelExtTray33048.Location = New Point(TblpanelExtTray330.Left, TblpanelExtTray.Bottom)
        TblpanelExtTray33048.Visible = False

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
        LblMiddleName2Nd = CreateDescrLabel("MiddleDescr2nd", "2nd Lay Down Bottle")
        TblpanelMiddleShelf2Nd = CreateLayoutPanel(4, 2, "tblpanelMiddleShelf", LblMiddleName2Nd)
        TblpanelMiddleShelf2Nd.Location = New Point(TblpanelBottomShelf.Left, TblpanelBottomShelf.Bottom + 30)

        'balcony
        LblBalconyName = CreateDescrLabel("BalconyDescr", "Balcony")
        TblpanelBalcony = CreateLayoutPanel(1, 7, "tblpanelBalcony", LblBalconyName)
        TblpanelBalcony.Location = New Point(TblpanelTopShelf.Right + 10, TblpanelTopShelf.Top)

        'balcony2nd
        LblBalconyName2Nd = CreateDescrLabel("BalconyDescr2nd", "Balcony2")
        TblpanelBalcony2Nd = CreateLayoutPanel(1, 7, "tblpanelBalcony", LblBalconyName2Nd)
        TblpanelBalcony2Nd.Location = New Point(TblpanelBalcony.Right + 10, TblpanelBalcony.Top)
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
        TblpanelExtTray330.Visible = False
        TblpanelExtTray33048.Visible = False
        If (hexSvm And &HFF) = 0 Then
            TblpanelExtTray330.Left = TblpanelLeftSide.Left
        Else
            TblpanelExtTray330.Left = TblpanelRightSide.Right + 10
        End If
        If CountOfProductsHomi330 < 16 Then
            If (hexSvm And &HF000) <> 0 Then
                TblpanelExtTray330.Visible = True
            End If
        Else
            If (hexSvm And &HF0000) <> 0 Then
                TblpanelExtTray330.Visible = True
            End If
            If (hexSvm And &HF000) <> 0 Then
                TblpanelExtTray33048.Visible = True
            End If
        End If


    End Sub

    Private Sub SetParamsByType(row As DataGridViewRow, lbl As List(Of Label), pnl As Panel)
        _selectedRow = row
        pnl.Visible = False
        Dim svmModele As String = _selectedRow.Cells("modelefrigo").Value
        'Dim dtModeleForView As New DataTable
        Dim dtModeleForView As DataTable = basemodele.modele.Copy()
        Dim iIndx As Integer = basemodele.lstbListOfModels.FindStringExact([svmModele])
        'FindString(SVMModele) 'basemodele.lstbListOfModels.Items.IndexOf(SVMModele)
        If iIndx = -1 Then Exit Sub
        'Model2Hex(iIndx)
        Dim coffre As Byte = Convert.ToByte(_selectedRow.Cells("coffre").Value)
        Dim realTrayOrShelfsStatus As Long
        Dim swr As String = String.Empty
        Dim hexSvm As Long
        Select Case coffre
            Case 0, 1, 2
                swr = _selectedRow.Cells("swr").Value.PadLeft(5).Substring(0, 2).Trim()
                hexSvm = ModelTools.ModelByIndex(iIndx, coffre) 'Model2Hex330(iIndx)
                PositionByVisibleFor330(hexSvm)
            Case 3
                TblpanelExtTray.Visible = False
                TblpanelExtTray48.Visible = False
                TblpanelBalcony2Nd.Visible = False
                TblpanelMiddleShelf2Nd.Visible = False
                swr = _selectedRow.Cells("swr").Value.PadLeft(13).Trim()
                'Dim hexSvm As Long = ModelTools.ModelByIndex(iIndx, coffre) 'Model2Hex226(iIndx)
                hexSvm = ModelTools.ModelByIndex(iIndx, coffre) 'Model2Hex226(iIndx)
                If String.IsNullOrEmpty(swr) Then
                    swr = "0"
                End If
                'Dim flag = False

                If (((Convert.ToInt64(swr, 16) And &HF00003F000) <> 0) AndAlso LireIniBoolSmart("HidenValues", "IsCanShow2ndBalconyAndMidleSHelf", False)) _
                    OrElse (hexSvm And &HF00003F000) <> 0 Then
                    TblpanelBalcony2Nd.Visible = True
                    TblpanelMiddleShelf2Nd.Visible = True
                    'flag = True
                End If
                If (hexSvm And &HFF0) <> 0 Then
                    'tblpanelExtTray.Location = New Point(IIf(flag, tblpanelBalcony2nd.Right + 10, tblpanelBalcony.Right + 10), tblpanelTopShelf.Top)
                    TblpanelExtTray.Visible = True
                    If (hexSvm And &HF00) <> 0 Then
                        TblpanelExtTray48.Visible = True
                    End If
                End If
                'realTrayStatus = Convert.ToInt64(SelectedRow.Cells("swr").Value.PadLeft(13).Trim(), 16)
        End Select
        If String.IsNullOrEmpty(swr) Then
            swr = "0"
        End If
        realTrayOrShelfsStatus = Convert.ToInt64(swr, 16)

        For ind As Integer = 0 To lbl.Count - 1
            lbl(ind).BackColor = Color.Green
            lbl(ind).Text = IIf(lbl(ind).Tag.ToString().Length > 0, lbl(ind).Tag + Chr(13), "")
            lbl(ind).Image = Nothing
        Next
        Dim sProdactName As String = String.Empty, sFormatStr As String = "{0}{1}{2} / {3}"
        Dim iMaxQ As Integer = 0, iRealQ As Integer = 0, iMp As Integer
        Dim drMp As DataRow = (From mp In dtMomentaryPickUp.AsEnumerable Where mp.Field(Of Integer)("nummodule") = _selectedRow.Cells("nummodule").Value Select mp)(0)
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

        pnl.Width = Me.Width - pnlLeft.Width - pnlLeft.Margin.Right - pnlLegend.Width - pnlLeft.Margin.Left - 15
        pnl.Height = Me.Height - pnlTop.Height - 20
        pnl.Visible = True
        pnl.BringToFront()
    End Sub


    Public Sub SetParams(row As DataGridViewRow)
        _selectedRow = row
        lblRoomNText.Text = _selectedRow.Cells("numchambre").Value.ToString() + "/" + _selectedRow.Cells("nummodule").Value.ToString()
        lblDoorStatusText.Text = _selectedRow.Cells("etatporte").Value.ToString() + "/" + _selectedRow.Cells("serrure").Value.ToString()
        lblRoomStatusTest.Text = _selectedRow.Cells("check").Value.ToString()
        lblTempText.Text = _selectedRow.Cells("etattemp").Value.ToString()
        lblServiceSwitchText.Text = IIf(CInt(_selectedRow.Cells("Service").Value.ToString()) = 1, Trans(51), Trans(50))
        lblItemsNbText.Text = _selectedRow.Cells("nbconso").Value.ToString()
        lblBalanceText.Text = _selectedRow.Cells("factureclient").Value.ToString()
        Dim coffre = CInt(_selectedRow.Cells("coffre").Value)
        If coffre < 3 AndAlso Convert.ToBoolean(ModelTools.Is226Model(_selectedRow.Cells("modelefrigo").Value)) Then
            coffre = 3
        End If

        Select Case coffre
            Case 0, 1, 2
                pbMinibar.Image = _330_closed100x123
                SetParamsByType(_selectedRow, _labels, PnlHomi330New)
            Case 3
                pbMinibar.Image = _226_closed100x135
                SetParamsByType(_selectedRow, _labels226New, PnlHomi226New)
        End Select

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


    Private Sub SetLabelHomi330New()
        'Dim lbl As Label
        _labels.Clear()
#If MiniBarVer = "226" Then
        _labels = CreateLabel4CellOfTblPanel("lbl330C", 16)
#ElseIf MiniBarVer = "330" OrElse MinibarVer = "330tray8" Then
        _labels = CreateLabel4CellOfTblPanel("lbl330C", IIf(CountOfProductsHomi330 + 4 < MaxCountOfProducts, CountOfProductsHomi330 + 4, CountOfProductsHomi330))
#End If
        '_labels = CreateLabel4CellOfTblPanel("lbl330C", IIf(CountOfProductsHomi330 + 4 < MaxCountOfProducts, CountOfProductsHomi330 + 4, CountOfProductsHomi330))
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
                TblpanelExtTray330.Controls.Add(_labels(casier), i - 1, 1)
                casier += 1
            Next
        End If

        If casier < _labels.Count Then 'CountOfProductsHomi330 Then
            For i As Integer = 1 To 4
                TblpanelExtTray33048.Controls.Add(_labels(casier), i - 1, 0)
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
        CreatePanels()

        SetLabelHomi226New()
        SetLabelHomi330New()
        Dim x As Integer = pnlLeft.Right + 10, y As Integer = pnlLeft.Top
        PnlHomi226New.Location = New Point(x, y)
        PnlHomi330New.Location = New Point(x, y)

    End Sub
    Public Sub InitView()
        lbRooms.DataSource = dv1
        lbRooms.DisplayMember = "numchambre"
        lbRooms.MultiColumn = True
        lbRooms.ValueMember = "nummodule"
    End Sub
    Private Sub lbRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbRooms.SelectedIndexChanged
        PnlHomi226New.Visible = False
        PnlHomi330New.Visible = False
        If lbRooms.SelectedIndex >= 0 AndAlso Visible = True Then
            SetParams(table.dgvMain.SelectedRows(0))
        End If

    End Sub

    Private Sub ViewByModele_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        lbRooms.DataSource = Nothing
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim s As String = String.Empty
        'For j As Integer = 1 To MaxCountOfProducts
        '    s += 0.ToString + " "
        'Next

        s = s.PadLeft(MaxCountOfProducts, "0").Replace("0", "0 ")
        Remplissagemanuel.LogString(s)
        'dch.CurrentRow.Cells("e").Value = "*"
        _selectedRow.Cells("e").Value = "*"
        table.AddEmis(_selectedRow.Cells("nummodule").Value, "ADDSTOCK|" + s)
    End Sub

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        _selectedRow.Cells("e").Value = "*"
        table.AddEmis(_selectedRow.Cells("nummodule").Value, "UNLOCK")
    End Sub



    Private Sub pnlHomi226New_VisibleChanged(sender As Object, e As EventArgs) Handles PnlHomi226New.VisibleChanged
        If PnlHomi226New.Visible Then
            TblpanelExtTray.Location = New Point(IIf(TblpanelBalcony2Nd.Visible, TblpanelBalcony2Nd.Right + 10, TblpanelBalcony.Right + 10), TblpanelTopShelf.Top)
        End If
    End Sub
End Class