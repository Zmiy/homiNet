Imports System.Globalization
Imports System.Text


Public Class Trouble
    Private dvTrouble As DataView = New DataView()
    Private tTrouble As DataTable = New DataTable("TTrouble")
    Private TroubleDescr As StringBuilder = New StringBuilder()
    Private IsTrobleRooms As Boolean = True
    Private added As Boolean = False
    Public arrWidth(4) As Integer
    Public Sub New()
        tTrouble.Columns.Add("numchambre", Type.GetType("System.String"))
        tTrouble.Columns.Add("nummodule", Type.GetType("System.String"))
        tTrouble.Columns.Add("descrtrouble", Type.GetType("System.String"))
        tTrouble.Columns.Add("FarVisitedWarrning", Type.GetType("System.String"))
        'arrWidth = New Integer(tTrouble.Columns.Count)

    End Sub

    Public Property IsAdded() As Boolean
        Get
            Return added
        End Get
        Set(value As Boolean)
            added = value
        End Set
    End Property
    Public Property View() As DataView
        Set(value As DataView)
            'Dim tmp As DataTable = New DataTable()
            'tmp = value.Table
            dvTrouble.Table = value.Table.Copy
        End Set
        Get
            Dim dv As New DataView()
            dv.Table = tTrouble
            Return dv
        End Get
    End Property
    Public Sub Clear()
        'dvTrouble.Table.Clear()
        If tTrouble.IsInitialized() Then
            tTrouble.Clear()
        End If
        TroubleDescr.Length = 0
    End Sub
    Public Sub IsTrouble()
        'If IsTrobleRooms Then  'if you check trouble in rooms
        dvTrouble.RowFilter = "numchambre not like 'R*' and test<>'" + Trans(37) + "'"
        'Else                   'if you check repiters's trouble
        'dvTrouble.RowFilter = "numchambre like R*"
        'End If

        For Each dr As DataRow In dvTrouble.ToTable().Rows 'Table.Rows
            Dim resultString As String = String.Empty
            TroubleDescr.Length = 0
            If ConErr(dr) Then
                'TroubleDescr.AppendLine("Connection Error ")
                TroubleDescr.AppendLine(Trans(208))
            End If
            If ItemErr(dr) Then
                'TroubleDescr.AppendLine("Item Error ")
                TroubleDescr.AppendLine(Trans(435))
            End If
            If ServiceErr(dr) Then
                'TroubleDescr.AppendLine("Service Switch Error ")
                TroubleDescr.AppendLine(Trans(436))
            End If
            If DoorErr(dr) Then
                'TroubleDescr.AppendLine("Door open")
                TroubleDescr.AppendLine(Trans(29) + " " + Trans(33))
            End If
            If TempErr(dr) Then
                'TroubleDescr.AppendLine("Temperature Error " + dr("etattemp").ToString())
                TroubleDescr.AppendLine(Trans(210) + " " + dr("etattemp").ToString())
            End If

            If dr("coffre") < 3 Then
                Dim sswr As String = dr("swr")
                Dim iSwrLenght As Integer = sswr.Length()
                If (iSwrLenght <> 3 And iSwrLenght <> 4) Or sswr.PadLeft(4).Substring(1, 1) <> "1" Then
                    TroubleDescr.AppendLine(Trans(433) + ": swr=" + sswr)
                End If
            End If

            If SwitchErr(dr, resultString) Then
                TroubleDescr.AppendLine(resultString)
            End If

            Dim tmp As Integer = FarVisitedWarrning(dr)
            resultString = String.Empty
            If tmp < 0 Then
                resultString = "Error of definition of date last refill"
            ElseIf tmp > 20 Then
                resultString = "Room was not visited " + tmp.ToString() + " days"
            End If
            If TroubleDescr.Length > 0 Or Not String.IsNullOrEmpty(resultString) Then
                tmp = TroubleDescr.ToString().LastIndexOf(Environment.NewLine, StringComparison.Ordinal)
                If tmp > 0 Then
                    TroubleDescr = TroubleDescr.Remove(tmp, Environment.NewLine().Length)
                End If
                'TroubleDescr.Append(dr("swr"))
                tTrouble.Rows.Add(New Object() {dr("numchambre").ToString, dr("nummodule").ToString(), TroubleDescr, resultString})
            End If

        Next
        'Dim max As Integer = 0
    End Sub
    Private Function SwitchErr(dr As DataRow, ByRef resultSwitch As String) As Boolean
        Dim result As Boolean = False
        Dim check() As Integer = New Integer() {&H10, &H20, &H40, &H80, &H1, &H2, &H4, &H8, &H1000, &H2000, &H4000, &H8000}
        If dr("coffre") = 3 Then
            Return result
        End If
        Try
            Dim swr As Integer = "&h" + dr("swr")
            For i As Integer = 1 To 12
                'st = remplissage.nomproduit(dr("nummodule"), i)

                If Maxcasier(dr("modelefrigo"), i) = dr("c" + i.ToString()) AndAlso (swr And check(i - 1)) = 0 Then
                    resultSwitch += i.ToString() + " "
                End If
            Next
            If resultSwitch.Trim().Length() > 0 Then
                resultSwitch = Trans(434) + ": " + resultSwitch.Trim()
                result = True
            End If
        Catch ex As Exception

        Finally
            result = False
        End Try
        Return result
    End Function

    Private Function ConErr(dr As DataRow) As Boolean
        Dim result As Boolean = (dr("test").ToString = Trans(208))
        Return result
    End Function
    Private Function str2int(str As String) As Integer
        Return Convert.ToInt32(str)
    End Function
    Private Function ItemErr(dr As DataRow) As Boolean
        Dim cell As String = String.Empty
        Dim result As Boolean = False
        For i As Integer = 1 To 12
            cell = "c" + i.ToString()
            If str2int(dr(cell)) < 0 Then
                result = True
                Exit For
            End If
        Next
        Return result
    End Function

    Private Function ServiceErr(dr As DataRow) As Boolean
        Dim result As Boolean = str2int(dr("service")).Equals(1)
        Return result
    End Function

    Private Function DoorErr(dr As DataRow) As Boolean
        Dim result As Boolean = False
        If dr("etatporte") = Trans(51) Then
            result = True
        End If
        Return result
    End Function
    'SUBSTRING(etattemp,1,1)='-' or Convert(Substring(etattemp,1,len(etattemp)-2),'System.Int32')>=

    Private Function TempErr(dr As DataRow) As Boolean
        Dim result As Boolean = False
        Dim temp As String = dr("etattemp").ToString()
        If temp.Substring(0, 1) = "-" OrElse Convert.ToInt32(temp.Substring(0, temp.Length - 2)) >= 18 Then
            result = True
        End If
        Return result
    End Function
    Private Function FarVisitedWarrning(dr As DataRow) As Integer
        Dim result As Integer = -1
        Dim lastRemplisage As DateTime

        If DateTime.TryParse(dr("dateremplissage"), New CultureInfo(""), DateTimeStyles.None, lastRemplisage) Then
            Dim diff As TimeSpan = DateTime.Now().Subtract(lastRemplisage)
            result = diff.Days
        End If

        Return result
    End Function
    Public ReadOnly Property Table() As DataTable
        Get
            Return tTrouble
        End Get
    End Property
    Public Function Maxcasier(modelefrigo As String, casier As Integer) As Integer
        ' maxcasier = -1
        'Dim m As String = FormTable.d(nummodule, "modelefrigo")
        'basemodele.modele.Rows(i)("nom")
        For i As Integer = 0 To basemodele.modele.Rows.Count - 1
            If basemodele.modele.Rows(i)("nom") = modelefrigo Then
                Dim R As Integer = basemodele.modele.Rows(i)(casier + MaxCountOfProducts) '(casier + 12)
                If R = 0 Then Return -1 Else Return R

            End If
        Next
        Return -1
    End Function
    Public ReadOnly Property ViewForPrint() As DataView
        Get
            Dim dv As New DataView()
            dv = View()
            Dim dttmp As DataTable = dv.Table.Copy()
            For i As Integer = 0 To dttmp.Rows.Count - 1
                dttmp.Rows(i)(2) = dttmp.Rows(i)(2).ToString().Replace(Environment.NewLine, " ")
            Next
            'dv.RowFilter = "numchambre not like 'R*' and test<>'" + trans(37) + "'"
            'For i As Integer = 0 To dv.Table.Rows.Count - 1
            '    dv.Table.Rows(i)(2) = dv.Table.Rows(i)(2).ToString().Replace(Environment.NewLine, " ")
            'Next
            dv.Table = dttmp
            Return dv
        End Get
    End Property
End Class


'maintable.Columns.Add("e", Type.GetType("System.String"))
'      maintable.Columns.Add("numchambre", Type.GetType("System.String"))
'      maintable.Columns.Add("etatporte", Type.GetType("System.String"))
'      maintable.Columns.Add("serrure", Type.GetType("System.String"))
'      maintable.Columns.Add("etattemp", Type.GetType("System.String"))
'      maintable.Columns.Add("signal", Type.GetType("System.String"))
'      maintable.Columns.Add("check", Type.GetType("System.String"))
'      maintable.Columns.Add("ouverture", GetType(Int32))
'      maintable.Columns.Add("status", Type.GetType("System.String"))
'      maintable.Columns.Add("nummodule", Type.GetType("System.String"))
'      maintable.Columns.Add("dateex", Type.GetType("System.String"))
'      maintable.Columns.Add("savserrure", Type.GetType("System.String"))
'      maintable.Columns.Add("test", Type.GetType("System.String"))
'      maintable.Columns.Add("dateremplissage", Type.GetType("System.String"))
'      maintable.Columns.Add("datecheckin", Type.GetType("System.String"))
'      maintable.Columns.Add("datecheckout", Type.GetType("System.String"))
'      maintable.Columns.Add("datelock", Type.GetType("System.String"))
'      maintable.Columns.Add("dateunlock", Type.GetType("System.String"))
'      maintable.Columns.Add("datemaintenance", Type.GetType("System.String"))
'      maintable.Columns.Add("dateanomalie", Type.GetType("System.String"))
'      maintable.Columns.Add("libre1", GetType(Int32))
'      maintable.Columns.Add("libre2", GetType(Int32))
'      maintable.Columns.Add("libre3", GetType(Int32))
'      maintable.Columns.Add("libre4", GetType(Int32))
'      maintable.Columns.Add("zone", GetType(Int32))
'      maintable.Columns.Add("chemin", Type.GetType("System.String"))
'      maintable.Columns.Add("remplacant", Type.GetType("System.String"))
'      maintable.Columns.Add("nummessage", Type.GetType("System.String"))
'      maintable.Columns.Add("messencours", Type.GetType("System.String"))
'      maintable.Columns.Add("updateeeprom", Type.GetType("System.String"))
'      maintable.Columns.Add("updateprog", Type.GetType("System.String"))
'      maintable.Columns.Add("remplaceprog", Type.GetType("System.String"))
'      maintable.Columns.Add("datemessage", Type.GetType("System.String"))
'      maintable.Columns.Add("lch", GetType(Int32))
'      maintable.Columns.Add("messageattente", Type.GetType("System.String"))
'      maintable.Columns.Add("recutelecom", Type.GetType("System.String"))
'      maintable.Columns.Add("numtelecommande", Type.GetType("System.String"))
'      maintable.Columns.Add("offsetouv", GetType(Int32))
'      maintable.Columns.Add("occupation", GetType(Int32))
'      maintable.Columns.Add("dateouvert", Type.GetType("System.String"))
'      maintable.Columns.Add("datefermer", Type.GetType("System.String"))
'      maintable.Columns.Add("power", Type.GetType("System.String"))
'      maintable.Columns.Add("airon", Type.GetType("System.String"))
'      maintable.Columns.Add("airoff", Type.GetType("System.String"))
'      maintable.Columns.Add("blink", GetType(Int32))
'      maintable.Columns.Add("memchkin", GetType(Int32))
'      maintable.Columns.Add("remplissage", GetType(Int32))
'      maintable.Columns.Add("maintenance", GetType(Int32))
'      maintable.Columns.Add("service", GetType(Int32))
'      maintable.Columns.Add("c1", GetType(Int32))
'      maintable.Columns.Add("c2", GetType(Int32))
'      maintable.Columns.Add("c3", GetType(Int32))
'      maintable.Columns.Add("c4", GetType(Int32))
'      maintable.Columns.Add("c5", GetType(Int32))
'      maintable.Columns.Add("c6", GetType(Int32))
'      maintable.Columns.Add("c7", GetType(Int32))
'      maintable.Columns.Add("c8", GetType(Int32))
'      maintable.Columns.Add("c9", GetType(Int32))
'      maintable.Columns.Add("c10", GetType(Int32))
'      maintable.Columns.Add("c11", GetType(Int32))
'      maintable.Columns.Add("c12", GetType(Int32))
'      maintable.Columns.Add("modelefrigo", Type.GetType("System.String"))
'      maintable.Columns.Add("nbconso", GetType(Int32))
'      maintable.Columns.Add("aremplir", GetType(Int32))
'      maintable.Columns.Add("updateparamhomi", GetType(Int32))
'      maintable.Columns.Add("factureclient", Type.GetType("System.String"))
'      maintable.Columns.Add("tarif", GetType(Int32))