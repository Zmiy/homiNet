Imports System.Drawing.Printing
Imports System.Globalization

Public Class Informationsystem

    Dim _checkParamList As Char()
    Public ReadOnly _systemTroubleTable As DataTable = New DataTable("systemtrouble")
    Private Sub informationsystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initlangue()
        _checkParamList = "000000000000000000000".ToCharArray()
        '_systemTroubleTable = New DataTable("systemtrouble")
        _systemTroubleTable.Columns.Add("Id", GetType(Integer))
        _systemTroubleTable.Columns.Add("DateTime", Type.GetType("System.DateTime"))
        _systemTroubleTable.Columns.Add("RoomN", Type.GetType("System.String"))
        _systemTroubleTable.Columns.Add("UCFN", GetType(Integer))
        _systemTroubleTable.Columns.Add("Message", Type.GetType("System.String"))
    End Sub
    Private Sub Initlangue()
        Me.Text = Trans(431)
        btnSystemUpdate.Text = Trans(189)
        GlassButton5.Text = Trans(141)
        imprimante.Items.Clear()
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            imprimante.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
        Next
        Try
            imprimante.Text = LireINI("imprimante", "systemanomalie")
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetDateTimeFromString(str As String) As DateTime
        Dim resultat As DateTime

        Dim index As Integer = str.IndexOf(" "c, str.IndexOf(" "c) + 1)
        If str.Substring(index + 1, 2).Equals("PM") OrElse str.Substring(index + 1, 2).Equals("AM") Then
            index += 3
        End If
        resultat = Convert.ToDateTime(str.Substring(0, index), CultureInfo.InvariantCulture)
        Return resultat
    End Function
    Public Sub DataCollector(data As String)
        '_systemTroubleTable.Clear()
        Try
            Dim ligne As String() = data.Split("$"c)
            Dim roomN As String = String.Empty, ucfN As Integer = 0, dt As DateTime = Nothing

            For i As Integer = 1 To ligne.Length - 1

                Dim str As String() = ligne(i).Split("|")
                Dim startI As Integer
                'startI = str(1).IndexOf("M ", StringComparison.Ordinal)
                dt = GetDateTimeFromString(str(1)) 'Convert.ToDateTime(str(1).Substring(0, startI + 1), CultureInfo.CreateSpecificCulture("en-US"))
                If str(1).Contains(Trans(28)) Then
                    startI = str(1).IndexOf(Trans(28), StringComparison.Ordinal)
                    startI += Trans(28).Length + 2
                    Dim endI As Integer = str(1).IndexOf(" ", startI, StringComparison.Ordinal)
                    roomN = str(1).Substring(startI, endI - startI)
                    startI = str(1).LastIndexOf(": ", StringComparison.Ordinal) + 2
                    endI = str(1).IndexOf(" ", startI, StringComparison.Ordinal)
                    ucfN = CInt(str(1).Substring(startI, endI - startI))
                End If
                startI = str(1).IndexOf("M ", StringComparison.Ordinal)
                _systemTroubleTable.Rows.Add(CInt(str(0)), dt, roomN, ucfN, str(1).Substring(startI + 2))
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ShowSystemIssues()
        If CheckBox3.Checked AndAlso Not ContextMenuStrip1.Enabled Then
            ContextMenuStrip1.Enabled = True
        End If
        tf.Clear()
        _systemTroubleTable.DefaultView.Sort = "RoomN, DateTime, Id"
        Dim i As Integer = 0
        For Each drow As DataRowView In _systemTroubleTable.DefaultView
            Dim c As Color = Color.Black
            Select Case DirectCast(drow(0), Integer)
                Case 0, 3
                    If drow(4).ToString().ToLower().Contains("power on") Then
                        c = Color.Purple
                    Else
                        c = Color.DarkGreen
                    End If

                Case 1, 2, 4, 5, 6, 17, 18, 19, 20
                    c = Color.DarkRed
                Case 7, 8, 9, 10, 12, 13, 14, 15, 16
                    c = Color.DarkOrange
                Case 11
                    c = Color.DarkOrchid
            End Select

            If _isPowerOnOnly AndAlso Not drow(4).ToString().ToLower().Contains("power on") Then
                Continue For
            End If
            i += 1
            tf.AppendText(vbCrLf)
            tf.SelectionStart = tf.Text.Length
            tf.SelectionLength = 0
            tf.SelectionColor = c
            tf.SelectedText = i.ToString() + vbTab + drow(1).ToString() + vbTab + drow(4)
            
        Next
    End Sub
    Public Sub Traite(data As String)
        Try
            Dim ligne As String() = data.Split("$")
            For i As Integer = 1 To ligne.Length - 1
                Dim s As String() = ligne(i).Split("|")
                Dim c As Color = Color.Black
                Select Case Val(s(0))
                    Case 0, 3
                        c = Color.DarkGreen
                    Case 1, 2, 4, 5, 6, 17, 18, 19, 20
                        c = Color.DarkRed
                    Case 7, 8, 9, 10, 12, 13, 14, 15, 16
                        c = Color.DarkOrange
                    Case 11
                        c = Color.DarkOrchid
                End Select

                tf.AppendText(vbCrLf)
                tf.SelectionStart = tf.Text.Length
                tf.SelectionLength = 0
                tf.SelectionColor = c
                tf.SelectedText = s(1)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub imprimante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles imprimante.SelectedIndexChanged
        EcrireINI("imprimante", "systemanomalie", imprimante.Text)
    End Sub
    Private Sub SystemUpdatePerformClickAction()
        Dim el2 As String = "system " + Format(Year(d1.SelectionStart), "0000") + Format(Month(d1.SelectionStart), "00") + Format(DateAndTime.Day(d1.SelectionStart), "00")
        tf.Clear()
        'table.addemis(0, "SYSTEM|" + el2)
        ContextMenuStrip1.Enabled = False
        Dim filterString As String = String.Empty

        'FilterString = CheckParamList.ToString

        For i As Integer = 0 To 20
            filterString += _checkParamList(i)
        Next
        If Mainform.ClientOfDriverIrf.IsConnected Then
            table.AddEmis(0, "SYSTEMFILTER|" + el2 + "|" + filterString)
        End If
    End Sub
    Private Sub btnSystemUpdate_Click(sender As Object, e As EventArgs) Handles btnSystemUpdate.Click
        SystemUpdatePerformClickAction()
    End Sub

    Private Sub GlassButton5_Click(sender As Object, e As EventArgs) Handles GlassButton5.Click
        Dim imp As New Imprimer(Me)
        imp.imprimante = imprimante.Text
        imp.imprime = "system"
        imp.paysage = False
        imp.Go()
        imp.Show()
    End Sub

    Private Sub informationsystem_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            SystemUpdatePerformClickAction()
        End If

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox0.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox1.CheckedChanged, CheckBox9.CheckedChanged, CheckBox8.CheckedChanged, CheckBox7.CheckedChanged, CheckBox6.CheckedChanged, CheckBox3.CheckedChanged, CheckBox20.CheckedChanged, CheckBox2.CheckedChanged, CheckBox19.CheckedChanged, CheckBox18.CheckedChanged, CheckBox17.CheckedChanged, CheckBox16.CheckedChanged, CheckBox15.CheckedChanged, CheckBox14.CheckedChanged, CheckBox13.CheckedChanged, CheckBox12.CheckedChanged, CheckBox11.CheckedChanged, CheckBox10.CheckedChanged
        If sender.checked = True Then
            _checkParamList(sender.Tag) = "1"
        Else
            _checkParamList(sender.Tag) = "0"
        End If
    End Sub
    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        For i As Integer = 0 To 20
            Dim controlNameToFind As String = "CheckBox" + i.ToString
            Dim oneControl As Control() = Me.Controls.Find(controlNameToFind, False)
            Dim oneCheckBox As CheckBox = oneControl(0)

            If sender.Checked = True Then
                oneCheckBox.Checked = True
            Else
                oneCheckBox.Checked = False
            End If
        Next
        If sender.Checked = True Then
            _checkParamList = "111111111111111111111".ToCharArray()
        Else
            _checkParamList = "000000000000000000000".ToCharArray()
        End If
    End Sub
    
    Private _isPowerOnOnly As Boolean = False

    Private Sub toolStripMenuShowOnlyPowerOn_Click(sender As System.Object, e As System.EventArgs) Handles toolStripMenuShowOnlyPowerOn.Click
        '_isPowerOnOnly = toolStripMenuShowOnlyPowerOn.Checked

        ShowSystemIssues()

    End Sub

    Private Sub toolStripMenuShowOnlyPowerOn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles toolStripMenuShowOnlyPowerOn.CheckedChanged
        _isPowerOnOnly = toolStripMenuShowOnlyPowerOn.Checked
    End Sub

    Private Sub ContextMenuStrip1_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles ContextMenuStrip1.EnabledChanged
        toolStripMenuShowOnlyPowerOn.Checked = False
    End Sub
End Class