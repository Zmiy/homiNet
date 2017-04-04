Imports System.Drawing.Printing
Imports System.Linq
Imports System.Globalization
Imports System.Text


Public Class Informationinterface
    Dim _start As Integer = 0
    Dim _dicProducts As Dictionary(Of String, Double)
    Public CountOfCheckOutRomms As Integer = 0

    Private Sub informationinterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initlangue()
        _dicProducts = New Dictionary(Of String, Double)
        Dim fontI As New Font("Courier New", 10)
        rtbInformationView.Font = fontI
        '//для того чтобы рисовать моноширинным шрифтом.
        'Dim StrFormat As StringFormat = System.Drawing.StringFormat.GenericTypographic
        'StrFormat.FormatFlags = StrFormat.FormatFlags Or StringFormatFlags.MeasureTrailingSpaces

        '//tb - (RichTextBox, границы отключены).
        cmbExtension.Items.AddRange(New Object() {New typeOfBar(1, "All"), New typeOfBar(2, "Homi336/330"), New typeOfBar(3, "Homi226")})
        cmbExtension.SelectedIndex = 0
        'pnlBottom.Location = New Point(pnlBottom.Location.X, pnlCalendare.Bottom + 5)
        'pnlBottom.Height = Me.Bottom - 5 - pnlBottom.Location.Y
        SetExtPanelView(configuration.chkbExtReport.Checked)
    End Sub
    'Private Sub InitChart()
    '    ' Set series chart type
    '    chartProducts.Series(0).ChartType = SeriesChartType.Column

    '    ' Set series point width
    '    'chartProducts.Series("Series1")("PointWidth") = "0.6"

    '    ' Show data points labels
    '    'chartProducts.Series("Series1").IsValueShownAsLabel = True

    '    ' Set data points label style
    '    chartProducts.Series("Series1")("BarLabelStyle") = "Center"

    '    ' Display as 3D
    '    chartProducts.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    '    chartProducts.ChartAreas("ChartArea1").AxisX.IsMarginVisible = True

    '    ' Draw the chart as embossed
    '    chartProducts.Series("Series1")("DrawingStyle") = "Default"

    '    chartProducts.ChartAreas(0).AxisX.IsLabelAutoFit = True
    '    chartProducts.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep45
    '    chartProducts.ChartAreas(0).AxisX.LabelStyle.Enabled = True
    '    chartProducts.ChartAreas(0).AxisX.LabelStyle.Angle = -45
    '    chartProducts.ChartAreas(0).AxisX.Interval = 1
    '    chartProducts.ChartAreas(0).AxisX.MajorTickMark.Interval = 1
    '    chartProducts.ChartAreas(0).AxisY.LabelStyle.Format = "c"
    '    chartProducts.Series(0).IsVisibleInLegend = False
    'End Sub
    Private Sub Initlangue()
        Text = Trans(292)
        btnUpdate.Text = Trans(189)
        btnPrint.Text = Trans(141)
        btnSend.Text = Trans(317)
        rbtnAll.Text = Trans(382)
        rbtnSucceeded.Text = Trans(239)
        rbtnFailure.Text = Trans(240)
        GroupBox1.Text = Trans(154)
        GroupBox2.Text = Trans(15)
        imprimante.Items.Clear()
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            imprimante.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
        Next
        Try
            imprimante.Text = LireINI("imprimante", "systemanomalie")
            cmbRooms.DataSource = maintable
            cmbRooms.DisplayMember = "numchambre"
            chkbSelectedRoom.Checked = False
        Catch ex As Exception

        End Try
    End Sub
    Private _rowsCount As Integer = 1
    Private Sub AddLineToInform(line As String, color As Color)
        'tf.AppendText(vbCrLf)
        rtbInformationView.SelectionFont = rtbInformationView.Font
        rtbInformationView.SelectionStart = rtbInformationView.Text.Length
        rtbInformationView.SelectionLength = 0
        rtbInformationView.SelectionColor = color
        rtbInformationView.SelectionBackColor = color.White
        If _rowsCount Mod 2 = 0 Then
            rtbInformationView.SelectionBackColor = color.LightGray
        End If
        Dim redPmsStatus As String() = New String() {"check out", "check in lock", Chr(9) + "lock"}
        rtbInformationView.SelectedText = line     'v

        If redPmsStatus.Any(Function(s) line.ToLower().Contains(s)) Then 'line.ToLower.Contains(" check out") Or line.ToLower.Contains(" lock") Or line.ToLower().Contains("check in lock") Then
            Dim index As Integer = -1 'tf.Text.ToLower().LastIndexOf("check out")
            Dim i As Integer = 0
            While (index < 0) AndAlso (i < redPmsStatus.Count)
                index = line.ToLower().LastIndexOf(redPmsStatus(i), StringComparison.Ordinal)
                i += 1
            End While
            rtbInformationView.SelectionStart = rtbInformationView.Text.ToLower().LastIndexOf(line.Substring(index).TrimEnd().ToLower(), StringComparison.Ordinal) 'index
            rtbInformationView.SelectionLength = rtbInformationView.Text.Length - line.Substring(index).TrimEnd().Length 'index  
            rtbInformationView.SelectionColor = color.DarkRed
            rtbInformationView.SelectionFont = New Font(rtbInformationView.Font.FontFamily, 12, FontStyle.Bold)
        End If


        'Dim index = -1 'tf.Text.ToLower().LastIndexOf("check out")
        'Dim i As Integer = 0
        'While index < 0 And i < redPMSStatus.Count
        '    index = tf.Text.ToLower().LastIndexOf(redPMSStatus(i))
        '    i += 1
        'End While

        'If index >= 0 And (line.ToLower.Contains("check out") Or line.ToLower.Contains(" lock") Or line.ToLower().Contains("check in lock")) Then
        '    'Dim fnt = tf.SelectionFont
        '    tf.SelectionStart = index
        '    tf.SelectionLength = tf.Text.Length - index
        '    tf.SelectionColor = Drawing.Color.DarkRed
        '    tf.SelectionFont = New System.Drawing.Font(tf.Font.FontFamily, 12, FontStyle.Bold)
        'End If
        rtbInformationView.AppendText(vbCrLf)
        _rowsCount += 1
        rtbInformationView.Update()
    End Sub
    Public Sub ClearDic()
        _dicProducts.Clear()
    End Sub
    'Public Sub UpdateChart()
    '    ' Remove data points
    '    chartProducts.Series(0).Points.Clear()
    '    chartProducts.Series(0).Points.DataBindXY(dicProducts.Keys.ToArray(), dicProducts.Values.ToArray())
    '    'chartProducts.Series(0).Points.Add(5)
    '    'chartProducts.Series(0).Points.Add(6)
    '    'chartProducts.Series(0).Points.Add(7)
    '    'chartProducts.Series(0).Points.Add(2)
    '    'chartProducts.Series(0).Points.Add(5)
    '    'chartProducts.Series(0).Points.Add(6)
    '    'chartProducts.Series(0).Points.Add(7)
    '    'chartProducts.Series(0).Points.Add(2)

    '    'chartProducts.Series(0).Points.Add(5)
    '    'chartProducts.Series(0).Points.Add(6)


    '    'chartProducts.Series(0).Points(0).Label = "N America"
    '    'chartProducts.Series(0).Points(0).LabelAngle = 90

    '    '// Set Axis labels
    '    'chartProducts.Series(0).Points(0).AxisLabel = "N America"
    '    'chartProducts.Series(0).Points(1).AxisLabel = "S America"
    '    'chartProducts.Series(0).Points(2).AxisLabel = "Europe"
    '    'chartProducts.Series(0).Points(3).AxisLabel = "Asia"
    '    'chartProducts.Series(0).Points(4).AxisLabel = "N America1"
    '    'chartProducts.Series(0).Points(5).AxisLabel = "S America2"
    '    'chartProducts.Series(0).Points(6).AxisLabel = "Europe3"
    '    'chartProducts.Series(0).Points(7).AxisLabel = "Asia4"

    '    'chartProducts.Series(0).Points(8).AxisLabel = "N America"
    '    'chartProducts.Series(0).Points(9).AxisLabel = "S America"


    '    chartProducts.Series(0).BackGradientStyle = GradientStyle.VerticalCenter
    '    ' Remove custom attributes
    '    chartProducts.Series(0).CustomProperties = ""
    '    ' Recalculate and repaint chart
    '    chartProducts.ChartAreas(0).RecalculateAxesScale()
    '    chartProducts.Invalidate()


    '    For i As Integer = 0 To dicProducts.Count - 1
    '        'chartProducts.Series("Series1").Points.Add(dicProducts.Values(i))
    '        'chartProducts.Series("Series1").Points(i).AxisLabel = dicProducts.Keys(i)
    '    Next
    'End Sub
    Public Sub Traite(data As String)
        Try
            Dim ligne As String() = data.Split("$")
            ' Dim maxProducNameLenght As Integer = From maxCol In baseproduit.dproduit Select num3
            Dim maxWidghtOfRoomN As Integer = (From row As DataRow In maintable.Rows Select row("numchambre").ToString().Length).Max()
            Dim s As String()
            Dim c As Color '= Color.Black
            Dim etat As String '= Trans(239)
            Dim v As String
            Dim sb As StringBuilder = New StringBuilder
            Const AsNg As String = "Posting from 'Vacant' room"
            Dim typeOfBar As Byte '= 1
            Dim condition As Boolean
            For i As Integer = 1 To ligne.Length - 1
                s = ligne(i).Split("!")
                'c = Color.Black
                condition = False
                Select Case Val(s(1))
                    Case 0
                        c = Color.DarkOrange
                        etat = Trans(238)
                    Case 6
                        c = Color.DarkRed
                        etat = Trans(240)
                    Case 999
                        c = Color.DarkViolet
                        etat = AsNg
                    Case Else
                        etat = Trans(239)
                        c = Color.DarkGreen
                End Select

                If _dicProducts.ContainsKey(s(3).Trim) Then
                    _dicProducts(s(3).Trim()) += Convert.ToDouble(s(5)) / 100.0
                Else
                    _dicProducts.Add(s(3).Trim(), Convert.ToDouble(s(5)) / 100.0)
                End If
                typeOfBar = CType(cmbExtension.SelectedItem, typeOfBar).Type
                If s.Length < 10 OrElse pnlExtention.Visible = False Then
                    typeOfBar = 1
                End If
                Select Case typeOfBar
                    Case 1
                        condition = True
                    Case 2
                        condition = (CInt(s(9)).InSet(0, 2))
                    Case 3
                        condition = (CInt(s(9)).Equals(3))
                End Select
                If condition = False Then
                    Continue For
                End If
                sb.Remove(0, sb.Length)
                'sb.Append(s(0).PadLeft(19))

                Try
                    sb.Append(Convert.ToDateTime(s(0), CultureInfo.InvariantCulture).ToString().PadLeft(19))
                Catch
                    sb.Append(s(0).PadLeft(19))
                End Try
                sb.Append(Chr(9))
                sb.Append(etat.PadRight(25))
                sb.Append(Chr(9))

                For j As Byte = 2 To s.Length - 1 - IIf(s.Length > 8, 1, 0)
                    Select Case j
                        Case 3, 8
                            sb.Append(s(j).PadRight(20))
                        Case 2
                            sb.Append(s(j).PadRight(maxWidghtOfRoomN))
                        Case 7
                            sb.Append(s(j).PadLeft(4))
                        Case Else
                            sb.Append(s(j))
                    End Select
                    sb.Append(Chr(9))
                Next
                'sb.Append(s(0))
                'sb.Append(Chr(9))
                'sb.Append(etat)
                'sb.Append(Chr(9))
                'sb.Append(s(2))
                'sb.Append(Chr(9))
                'sb.Append(Mid(s(3) + "                ", 1, 16))
                'sb.Append(Chr(9))
                'sb.Append(s(4))
                'sb.Append(Chr(9))
                'sb.Append(s(5))
                'sb.Append(Chr(9))
                'sb.Append(s(6))
                'sb.Append(Chr(9))
                'sb.Append(s(7))
                'If s.Length > 7 Then
                '    sb.Append(Chr(9))
                '    sb.Append(s(8))
                'End If

                v = sb.ToString()
                If chkbSelectedRoom.Checked AndAlso Not cmbRooms.Text = s(2) Then
                    Continue For
                End If
                If rbtnAll.Checked = True Then
                    AddLineToInform(v, c)
                    Continue For
                End If
                If rbtnSucceeded.Checked = True AndAlso etat = Trans(239) Then
                    AddLineToInform(v, c)
                    Continue For
                End If
                If rbtnFailure.Checked = True AndAlso etat = Trans(240) Then
                    AddLineToInform(v, c)
                    Continue For
                End If
                If rbtnCheckOutPosting.Checked = True AndAlso etat = AsNg Then
                    AddLineToInform(v, c)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub imprimante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles imprimante.SelectedIndexChanged
        EcrireINI("imprimante", "systemanomalie", imprimante.Text)
    End Sub
    Private Sub UpdatePerformClickAction()

        Dim el2 As String = Format(Year(mcalendarInformation.SelectionStart), "0000") + Format(Month(mcalendarInformation.SelectionStart), "00") + Format(DateAndTime.Day(mcalendarInformation.SelectionStart), "00")
        rtbInformationView.Clear()
        table.AddEmis(0, "FINTERFACE|" + el2)
        If rbtnFailure.Checked = True Then
            btnSend.Enabled = True
        Else
            btnSend.Enabled = False
        End If
        _dicProducts.Clear()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click, rbtnSucceeded.Click, rbtnFailure.Click, rbtnCheckOutPosting.Click, rbtnAll.Click
        UpdatePerformClickAction()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim imp As New Imprimer
        imp.imprimante = imprimante.Text
        imp.imprime = "interface"
        imp.paysage = False
        imp.go()
    End Sub

    Private Sub informationinterface_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible = True Then
            chkbSelectedRoom.Checked = False
            If MAINFORM.ClientOfDriverIrf.IsConnected Then
                UpdatePerformClickAction()
            End If

        End If

    End Sub

    Private Sub tf_MouseDown(sender As Object, e As MouseEventArgs) Handles rtbInformationView.MouseDown
        Try

            rtbInformationView.SelectionStart = InStrRev(rtbInformationView.Text, Chr(10), If(rtbInformationView.SelectionStart = 0, 1, rtbInformationView.SelectionStart))
            _start = rtbInformationView.SelectionStart
            rtbInformationView.SelectionLength = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tf_MouseUp(sender As Object, e As MouseEventArgs) Handles rtbInformationView.MouseUp
        Try
            If _start > rtbInformationView.SelectionStart Then
                rtbInformationView.SelectionLength = 0
                Exit Sub
            End If
            rtbInformationView.SelectionStart = _start
            rtbInformationView.SelectionLength = InStr(Int(_start + rtbInformationView.SelectionLength), rtbInformationView.Text, Chr(10)) - _start

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRooms.SelectedIndexChanged
        'chkbSelectedRoom.Checked = True
        'GlassButton7_Click(Nothing, Nothing)
        If Visible = True Then
            If MAINFORM.ClientOfDriverIrf.IsConnected Then
                UpdatePerformClickAction()
            End If
        End If

    End Sub

    Private Sub chkbSelectedRoom_CheckedChanged(sender As Object, e As EventArgs) Handles chkbSelectedRoom.CheckedChanged
        Select Case chkbSelectedRoom.Checked
            Case True
                cmbRooms.Enabled = True
            Case False
                cmbRooms.Enabled = False
                cmbRooms.SelectedIndex = -1
                If Mainform.ClientOfDriverIrf.IsConnected Then
                    UpdatePerformClickAction()
                End If
        End Select

        'btnUpdate.PerformClick() 'GlassButton7_Click(Nothing, Nothing)
    End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If rtbInformationView.SelectionLength = 0 Then
            rtbInformationView.SelectionStart = 0
            rtbInformationView.SelectionLength = rtbInformationView.TextLength - 2
        End If
        Dim s As String() = rtbInformationView.SelectedText.Split(Chr(10))
        Dim reinvoiceData As String = mcalendarInformation.SelectionStart.ToString("yyyyMMdd")
        For Each l As String In s
            Try
                l = Replace(l, Chr(9) + Chr(9), Chr(9))
                Dim m As String() = l.Split(Chr(9))
                table.AddEmis(0, "RENVOIPMS|" + m(2).Trim() + "|" + m(3).Trim() + "|" + m(5).Trim() + "|" + m(6).Trim() + "|" + m(7).Trim() + "|" + reinvoiceData + "|")
            Catch ex As Exception : End Try
        Next
        rbtnAll.Checked = True
        'GlassButton7_Click(Nothing, Nothing)
        If MAINFORM.ClientOfDriverIrf.IsConnected Then
            UpdatePerformClickAction()
        End If
    End Sub


    'Private Sub tf_TextChanged(sender As System.Object, e As System.EventArgs) Handles tf.TextChanged
    '    Dim font As New Font("Courier New", 10)

    '    '//для того чтобы рисовать моноширинным шрифтом.
    '    Dim StrFormat As StringFormat = System.Drawing.StringFormat.GenericTypographic
    '    StrFormat.FormatFlags = StrFormat.FormatFlags Or StringFormatFlags.MeasureTrailingSpaces

    '    '//tb - (RichTextBox, границы отключены).
    '    tf.Font = font


    '    '//Рисуем прям под ним
    '    'e.Graphics.DrawString("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", font, Brushes.Black, 0, tb.Bounds.Height, stringFormat);
    'End Sub

    Public Sub SetExtPanelView(isVisible As Boolean)
        Select Case isVisible
            Case False
                pnlExtention.SendToBack()
                'pnlBotton.BringToFront()
                pnlBottom.Location = New Point(pnlBottom.Location.X, pnlCalendare.Bottom + 5)
            Case True
                pnlExtention.BringToFront()
                'pnlBotton.SendToBack()
                pnlExtention.Location = New Point(pnlBottom.Location.X, pnlCalendare.Bottom + 5)
                pnlBottom.Location = New Point(pnlBottom.Location.X, pnlExtention.Bottom + 5)

        End Select
        pnlBottom.Height = Bottom - 5 - pnlBottom.Location.Y
        pnlExtention.Visible = isVisible
    End Sub

    Private Sub btnVisible_Click(sender As Object, e As EventArgs) Handles btnVisible.Click
        Select Case pnlExtention.Visible
            Case True
                pnlExtention.SendToBack()
                'pnlBotton.BringToFront()
                pnlBottom.Location = New Point(pnlBottom.Location.X, pnlCalendare.Bottom + 5)

            Case False
                pnlExtention.BringToFront()
                'pnlBotton.SendToBack()
                pnlExtention.Location = New Point(pnlBottom.Location.X, pnlCalendare.Bottom + 5)
                pnlBottom.Location = New Point(pnlBottom.Location.X, pnlExtention.Bottom + 5)

        End Select
        pnlBottom.Height = Bottom - 5 - pnlBottom.Location.Y
        pnlExtention.Visible = Not pnlExtention.Visible
    End Sub

    Private Sub cmbExtension_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExtension.SelectedIndexChanged
        If Visible = True Then
            If Mainform.ClientOfDriverIrf.IsConnected Then
                UpdatePerformClickAction()
            End If
        End If

    End Sub
    'If rtbInformationView.SelectionLength = 0 Then
    '        rtbInformationView.SelectionStart = 0
    '        rtbInformationView.SelectionLength = rtbInformationView.TextLength - 2
    '    End If
    'Dim s As String() = rtbInformationView.SelectedText.Split(Chr(10))
    'Dim reinvoiceData As String = mcalendarInformation.SelectionStart.ToString("yyyyMMdd")
    '    For Each l As String In s
    '        Try
    '            l = Replace(l, Chr(9) + Chr(9), Chr(9))
    'Dim m As String() = l.Split(Chr(9))
    '            table.AddEmis(0, "RENVOIPMS|" + m(2).Trim() + "|" + m(3).Trim() + "|" + m(5).Trim() + "|" + m(6).Trim() + "|" + m(7).Trim() + "|" + reinvoiceData + "|")
    '        Catch ex As Exception : End Try
    '    Next
    '    rbtnAll.Checked = True
    ''GlassButton7_Click(Nothing, Nothing)
    '    If MAINFORM.ClientOfDriverIrf.IsConnected Then
    '        UpdatePerformClickAction()
    '    End If

    Private Sub ShowSums()
        If rtbInformationView.SelectionLength = 0 Then
            Exit Sub
        End If
        Dim selectedStrings() As String = rtbInformationView.SelectedText.Split(Chr(10))
        Dim positiveSum As Double = 0.0, negativeSum As Double = 0.0, currentValue As Double
        
        For Each str As String In From str1 In selectedStrings Where str1.Contains(Trans(239))
            currentValue = Convert.ToDouble(str.Replace(Chr(9) + Chr(9), Chr(9)).Split(Chr(9))(5)) / 100
            Select Case currentValue
                Case Is > 0
                    positiveSum += currentValue
                Case Is < 0
                    negativeSum += currentValue
            End Select
        Next
        MessageBox.Show("Positive = " & positiveSum.ToString() & " Negative = " & negativeSum & " Summ" & (positiveSum + negativeSum).ToString())
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ShowSums()
    End Sub
End Class