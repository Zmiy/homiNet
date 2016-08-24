Imports System.Runtime.CompilerServices
Imports System.Data

Module MyExtTools
    <Extension()> Public Function LAnd(ByVal pred1 As Integer, ByVal pred2 As Integer) As Byte
        LAnd = 0
        If (pred1 And pred2) = pred2 Then
            LAnd = 1
        End If
    End Function

    <Extension()> Public Function LAnd(ByVal pred1 As Long, ByVal pred2 As Long) As Boolean
        LAnd = 0
        If (pred1 And pred2) = pred2 Then
            LAnd = 1
        End If
    End Function

    <Extension()> _
    Public Function DigitsOnly(ByVal value As String) As String
        Dim result As String = String.Empty
        Dim Indx As String = 0
        While (Char.IsDigit(value(Indx)))
            result += value(Indx)
            Indx += 1
            If Indx >= value.Length Then
                Exit While
            End If
        End While
        If String.IsNullOrEmpty(result) Then
            result = "0"
        End If
        Return result
    End Function
    <Extension()> _
    Public Function Clone(ByVal dgv As DataGridView) As DataGridView
        Dim result As DataGridView = New DataGridView()

        Dim arrForCopyRows(dgv.Rows.Count - 1) As DataGridViewRow
        Dim soDirection As SortOrder
        soDirection = dgv.Columns(0).HeaderCell.SortGlyphDirection
        result.AllowUserToAddRows = False

        For Each col As DataGridViewColumn In dgv.Columns
            result.Columns.Add(col.Clone())
        Next

        Dim counter As Integer = 0
        dgv.Rows.CopyTo(arrForCopyRows, 0)
        For Each dgvrCurrent As DataGridViewRow In arrForCopyRows
            result.Rows.Add(CloneWithValues(dgvrCurrent))
        Next
        Return result
    End Function
    <Extension()> Public Function InSet(ByVal value As Integer, ByVal fromValue As Integer, ByVal toValue As Integer)
        Dim result As Boolean = False
        If value >= fromValue And value <= toValue Then
            result = True
        End If

        'Select Case value
        '    Case Is >= fromValue, Is <= toValue
        '        result = True
        '    Case Else
        '        result = False
        'End Select
        Return result
    End Function
    <Extension()> Public Function InSet(ByVal value As Byte, ByVal fromValue As Byte, ByVal toValue As Byte)
        Dim result As Boolean = False
        If value >= fromValue And value <= toValue Then
            result = True
        End If
        'Select Case value
        '    Case Is >= fromValue, Is <= toValue
        '        result = True
        '    Case Else
        '        result = False
        'End Select
        Return result
    End Function
    <Extension()> Public Function ToTable(ByVal dic As Dictionary(Of String, Integer), ByVal FirstColumnName As String, ByVal SecondColumnName As String, ByVal TableName As String)
        Dim result As DataTable = New DataTable(TableName)
        result.Columns.Add(FirstColumnName, Type.GetType("System.String"))
        result.Columns.Add(SecondColumnName, Type.GetType("System.String"))
        Dim dr As DataRow
        For Each pair As KeyValuePair(Of String, Integer) In dic
            dr = result.NewRow()
            dr(0) = pair.Key
            dr(1) = pair.Value
            result.Rows.Add(dr)
        Next
        Return result
    End Function
    <Extension()>
    Public Function PadCenter(ByVal [string] As String, ByVal width As Integer, ByVal c As Char) As String

        If [string] Is Nothing Then [string] = String.Empty
        If (width <= [string].Length) Then Return [string]

        Dim padding = width - [string].Length
        Return [string].PadLeft([string].Length + (padding \ 2), c).PadRight(width, c)

    End Function

    <Extension()>
    Public Function PadCenter(ByVal [string] As String, ByVal width As Integer) As String

        If [string] Is Nothing Then [string] = String.Empty
        If (width <= [string].Length) Then Return [string]

        Dim padding = width - [string].Length
        Return [string].PadLeft([string].Length + (padding \ 2)).PadRight(width)

    End Function
    '<Extension()> _
    'Public Function Exists_(ByVal tbl As DataTable, ByVal key As Object, ByVal Column As Integer) As Boolean

    'End Function
    Private Function CloneWithValues(ByVal row As DataGridViewRow) As DataGridViewRow
        Dim clonedRow As DataGridViewRow = row.Clone()
        For i As Integer = 0 To row.Cells.Count - 1
            clonedRow.Cells(i).Value = row.Cells(i).Value
        Next
        Return clonedRow
    End Function
End Module
