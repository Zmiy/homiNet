Imports System.IO
Imports System.Text

Public Class Remplissagemanuel
    Private ReadOnly _arrNum As New List(Of NumericUpDown)

    Private Sub remplissagemanuel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initdch()
        initlangue()
        dc.Columns.Clear()
        For casier As Byte = 1 To MaxCountOfProducts
            dc.Columns.Add(casier.ToString(), casier.ToString())
            dc.Columns(casier - 1).Width = dc.ClientSize.Width / 8 'MaxCountOfProducts
        Next
        dc.Rows.Add()

        tblpanelNewValues.ColumnStyles.Clear()
        tblpanelNewValues.ColumnCount = MaxCountOfProducts
        tblpanelNewValues.HorizontalScroll.Enabled = True
        tblpanelNewValues.HorizontalScroll.Visible = True

        Dim nud As NumericUpDown
        For i As Integer = 1 To MaxCountOfProducts
            nud = New NumericUpDown()
            nud.Maximum = 6
            nud.Minimum = -6
            nud.Name = "n" + (i).ToString()
            nud.Width = dc.Columns(i - 1).Width - 5
            nud.Anchor = AnchorStyles.Left
            _arrNum.Add(nud)
            tblpanelNewValues.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, dc.Columns(i - 1).Width - 2))
            tblpanelNewValues.Controls.Add(nud, i - 1, 0)
        Next
        tblpanelNewValues.HorizontalScroll.Maximum = dc.Columns(0).Width * MaxCountOfProducts + 10
    End Sub

    Public Sub Initlangue()
        Me.Text = Trans(397)
        GroupBox1.Text = Trans(154)
        RadioButton1.Text = Trans(49)
        RadioButton2.Text = Trans(343)
        Label2.Text = Trans(28)
        Label1.Text = Trans(398)
        GlassButton1.Text = Trans(193)
        GlassButton2.Text = Trans(40)
        gbtnSendManualRefill.Text = Trans(317)

        Try
            dch.Columns("numchambre").HeaderText = Trans(15)
            dch.Columns("test").HeaderText = Trans(26)
            dch.Columns("modelefrigo").HeaderText = Trans(327)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub initdch()
        If Me.Visible = False Then Exit Sub

        If RadioButton1.Checked = True Then
            dch.DataSource = Maintable
        End If
        If RadioButton2.Checked = True Then
            dch.DataSource = Remplissage.Dvr
        End If
        For i As Integer = 0 To dch.ColumnCount - 1
            dch.Columns(i).Visible = False
        Next

        Try
            dch.Columns("numchambre").Visible = True
            dch.Columns("test").Visible = True
            dch.Columns("modelefrigo").Visible = True
        Catch ex As Exception
        End Try
        dch.ClearSelection()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True AndAlso Me.Visible = True Then
            initdch()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True AndAlso Me.Visible = True Then
            initdch()
        End If
    End Sub
    Private Function bin(value As Integer) As String
        Dim result As String = String.Empty
        Dim decimalNumber As Integer = value
        Dim remainder As Byte
        While (decimalNumber > 0)
            remainder = decimalNumber Mod 2
            decimalNumber = CInt(Fix(decimalNumber / 2))
            result = remainder.ToString() + result
        End While
        Return result
    End Function
    Private Sub dch_MouseClick(sender As Object, e As MouseEventArgs) Handles dch.MouseClick
        Try
            If dch Is Nothing OrElse dch.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim swr As String = dch.CurrentRow.Cells("swr").Value.ToString
            Label2.Text = Trans(28) + ": " + dch.CurrentRow.Cells("numchambre").Value.ToString
            Label3.Text = "SWR: " + swr
            'Dim shelf As Integer = 0
            'If dch.CurrentRow.Cells("coffre").Value = "3" Then
            '    shelf = Convert.ToInt32(SWR.Substring(0, 3), 16)
            '    Label3.Text += " ---" + bin(shelf)
            '    shelf = Convert.ToInt32(SWR.Substring(3, 3), 16)
            '    Label3.Text += " ---" + bin(shelf)
            'End If
            'For j As Integer = 0 To 11
            '    dc.Rows(0).Cells(j).Style.BackColor = Color.White
            '    dc.Rows(0).Cells(j).Value = ""
            '    dc.Rows(0).Cells(j).Style.BackColor = Color.White
            '    dc.Rows(0).Cells(j).Value = ""
            'Next
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
                dc.Columns(i).HeaderText = basemodele.modele.Rows(m)(i + 1).ToString
            Next
            'color les non utilise
            'For i As Integer = 0 To 11
            '    'Dim n As Integer = Val(basemodele.modele.Rows(m)(i + MaxCountOfProducts + 1)) '(i + 13))
            '    dc.Rows(0).Cells(i).Style.BackColor = Color.LightSteelBlue
            'Next

            'total casier
            Dim currCell As DataGridViewCell
            For casier As Integer = 1 To MaxCountOfProducts
                currCell = dc.Rows(0).Cells(casier - 1)
                currCell.Selected = False
                currCell.Style.BackColor = Color.LightSteelBlue
                'dc.Rows(0).Cells(casier - 1).Value = dch.CurrentRow.Cells("c" + casier.ToString()).Value 'Cells(i + 49).Value
                currCell.Value = dch.CurrentRow.Cells("c" + casier.ToString()).Value 'Cells(i + 49).Value
                If currCell.Value < 0 Then
                    currCell.Style.BackColor = Color.Red
                Else
                    currCell.Style.BackColor = Color.LightGreen
                End If
                If currCell.Value = 0 Then
                    currCell.Style.BackColor = Color.Orange
                End If
                If dc.Columns(casier - 1).HeaderText = "" Then
                    currCell.Style.BackColor = Color.Black
                End If


                'If dc.Rows(0).Cells(casier - 1).Value < 0 Then
                '    dc.Rows(0).Cells(casier - 1).Style.BackColor = Color.Red
                'Else
                '    dc.Rows(0).Cells(casier).Style.BackColor = Color.LightGreen
                'End If
                'If dc.Rows(0).Cells(casier).Value = 0 Then
                '    dc.Rows(0).Cells(casier).Style.BackColor = Color.Orange
                'End If
                'If dc.Columns(casier - 1).HeaderText = "" Then
                '    dc.Rows(0).Cells(casier - 1).Style.BackColor = Color.Black
                'End If

            Next
            dc.ClearSelection()
            'init n
            For i As Byte = 1 To MaxCountOfProducts
                If dc.Item(i - 1, 0).Style.BackColor = Color.Black Then
                    _arrNum(i - 1).Enabled = False
                Else
                    _arrNum(i - 1).Enabled = True
                End If
            Next
            dc.AutoResizeRows()
            pnlTop.Height = dc.ColumnHeadersHeight + dc.Rows(0).Height + 70 'dc.Height + Label2.Height + 10
            pnlTop.Refresh()
            pnlBottom.Top = pnlTop.Bottom + 5
            tblpanelNewValues.Width = dc.Width
            ' ListBox1.Size = New Size(ListBox1.Width, pnlBottom.Height - Label1.Height - tblpanelNewValues.Height - gbtnSendManualRefill.Height - 5)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub nzero()
        For Each nud As NumericUpDown In _arrNum
            nud.Value = 0
        Next
        'n1.Value = 0
        'n2.Value = 0
        'n3.Value = 0
        'n4.Value = 0
        'n5.Value = 0
        'n6.Value = 0
        'n7.Value = 0
        'n8.Value = 0
        'n9.Value = 0
        'n10.Value = 0
        'n11.Value = 0
        'n12.Value = 0
    End Sub
    'clear
    Private Sub GlassButton1_Click(sender As Object, e As EventArgs) Handles GlassButton1.Click
        nzero()
    End Sub

    Private Sub gbtnSendManualRefill_Click(sender As Object, e As EventArgs) Handles gbtnSendManualRefill.Click
        If dch.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim s As String = String.Empty, sLog As String = String.Empty
        Dim numUpDownStockI As New NumericUpDown()
        Dim i As Integer = 0
        'calcul stock
        For j As Integer = 1 To MaxCountOfProducts
            numUpDownStockI = DirectCast(Me.Controls.Find("n" + j.ToString(), True)(0), NumericUpDown)
            i = CInt(numUpDownStockI.Value)
            sLog += i.ToString() + " "
            If i < 0 Then
                i += 16
            End If
            s += i.ToString + " "
        Next
        LogString(sLog)
        LogString(s)

        dch.CurrentRow.Cells("e").Value = "*"
        table.AddEmis(CInt(dch.CurrentRow.Cells("nummodule").Value), "ADDSTOCK|" + s)
        nzero()

        lbReportOFManualRefill.Items.Add("")
        lbReportOFManualRefill.Items.Add(DateTime.Now.ToString() + " " + Label2.Text + "         " + Trans(397))
        lbReportOFManualRefill.SelectedIndex = lbReportOFManualRefill.Items.Count - 1

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Me.Visible = True AndAlso dch.CurrentRow IsNot Nothing AndAlso dch.CurrentRow.Index > -1 Then
                'dch_MouseClick(Nothing, Nothing)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GlassButton2_Click(sender As Object, e As EventArgs) Handles GlassButton2.Click
        lbReportOFManualRefill.Items.Clear()
    End Sub


    Public Sub LogString(stringToLog As String)
        Try
            Dim el2 As String = Format(Year(Now), "0000") + "-" + _
            Format(Month(Now), "00") + "-" + _
            Format(DateAndTime.Day(Now), "00") + " " + _
            Format(Hour(Now), "00") + ":" + _
            Format(Minute(Now), "00") + ":" + _
            Format(Second(Now), "00")

            Dim sw As New StreamWriter(Application.StartupPath + "\refNet.log", True, Encoding.UTF8)
            sw.WriteLine(el2 + " : " + stringToLog)
            sw.Flush()
            sw.Close()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub gbtnFull_Click(sender As Object, e As EventArgs) Handles gbtnFull.Click
        Dim svm As String = dch.CurrentRow.Cells("modelefrigo").Value.ToString()
        Dim svmValues(MaxCountOfProducts) As Integer
        For i As Integer = 0 To MaxCountOfProducts - 1
            svmValues(i) = 0
        Next
        For i As Integer = 0 To basemodele.modele.Rows.Count - 1
            If basemodele.modele.Rows(i)("nom") = svm Then
                For j As Integer = 1 To MaxCountOfProducts
                    svmValues(j - 1) = CInt(basemodele.modele.Rows(i)(j + MaxCountOfProducts))
                Next
                Exit For
            End If
        Next
        Dim upDown As NumericUpDown
        For i As Integer = 0 To MaxCountOfProducts - 1
            upDown = DirectCast(Me.Controls.Find("n" + (i + 1).ToString(), True)(0), NumericUpDown)
            upDown.Value = svmValues(i)
        Next

    End Sub

    Private Sub ListBox1_VisibleChanged(sender As Object, e As EventArgs) Handles lbReportOFManualRefill.VisibleChanged
        If Me.Visible = True Then
            initdch()
        End If
    End Sub

    Private Sub dch_BindingContextChanged(sender As Object, e As EventArgs) Handles dch.BindingContextChanged
        'MessageBox.Show("Changed")
        dch_MouseClick(Nothing, Nothing)
    End Sub

    Private Sub dch_CausesValidationChanged(sender As Object, e As EventArgs)
        Dim i As Integer = 0
    End Sub

    Private Sub dch_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        Dim i As Integer = 0
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbReportOFManualRefill.SelectedIndexChanged
        dc.Refresh()
    End Sub

    Private Sub dc_Scroll(sender As Object, e As ScrollEventArgs) Handles dc.Scroll
        Dim dgv As DataGridView = CType(sender, DataGridView)
        If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
            'dfrigo2.HorizontalScrollingOffset = dgv.HorizontalScrollingOffset
            tblpanelNewValues.HorizontalScroll.Value = dgv.HorizontalScrollingOffset
        End If
    End Sub

    Private Sub tblpanelNewValues_Scroll(sender As Object, e As ScrollEventArgs) Handles tblpanelNewValues.Scroll
        Dim tbl As TableLayoutPanel = CType(sender, TableLayoutPanel)
        If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
            'dfrigo2.HorizontalScrollingOffset = dgv.HorizontalScrollingOffset
            dc.HorizontalScrollingOffset = tbl.HorizontalScroll.Value
        End If
    End Sub

    Private Sub remplissagemanuel_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim i As Integer = 1
        End If
    End Sub

    Private Sub dch_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dch.DataBindingComplete
        dch_MouseClick(Nothing, Nothing)
    End Sub



    Private Sub dch_SelectionChanged(sender As Object, e As EventArgs) Handles dch.SelectionChanged
        dch_MouseClick(Nothing, Nothing)
    End Sub


    Private Sub gbtnMinus_Click(sender As System.Object, e As System.EventArgs) Handles gbtnMinus.Click
        If dch.CurrentRow Is Nothing Then
            Exit Sub
        End If
        For i As Integer = 1 To MaxCountOfProducts
            If CInt(dch.CurrentRow.Cells("c" + i.ToString()).Value) < 0 Then
                DirectCast(Me.Controls.Find("n" + i.ToString(), True)(0), NumericUpDown).Value = CInt(dch.CurrentRow.Cells("c" + i.ToString()).Value) * -1
            End If

        Next
    End Sub
End Class
