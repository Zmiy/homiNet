Imports System.Runtime.CompilerServices
Imports System.Data

Module MyExtTools
    <Extension()> Public Function LAnd(pred1 As Integer, pred2 As Integer) As Byte
        LAnd = 0
        If (pred1 And pred2) = pred2 Then
            LAnd = 1
        End If
    End Function

    <Extension()> Public Function LAnd(pred1 As Long, pred2 As Long) As Boolean
        LAnd = 0
        If (pred1 And pred2) = pred2 Then
            LAnd = 1
        End If
    End Function

    <Extension()> _
    Public Function DigitsOnly(value As String) As String
        Dim result As String = String.Empty
        Dim indx As String = 0
        While (Char.IsDigit(value(indx)))
            result += value(indx)
            indx += 1
            If indx >= value.Length Then
                Exit While
            End If
        End While
        If String.IsNullOrEmpty(result) Then
            result = "0"
        End If
        Return result
    End Function
    <Extension()> _
    Public Function Clone(dgv As DataGridView) As DataGridView
        Dim result As DataGridView = New DataGridView()

        Dim arrForCopyRows(dgv.Rows.Count - 1) As DataGridViewRow
        Dim soDirection As SortOrder
        soDirection = dgv.Columns(0).HeaderCell.SortGlyphDirection
        result.AllowUserToAddRows = False

        For Each col As DataGridViewColumn In dgv.Columns
            result.Columns.Add(col.Clone())
        Next

        dgv.Rows.CopyTo(arrForCopyRows, 0)
        For Each dgvrCurrent As DataGridViewRow In arrForCopyRows
            result.Rows.Add(CloneWithValues(dgvrCurrent))
        Next
        Return result
    End Function
    <Extension()> Public Function InSet(value As Integer, fromValue As Integer, toValue As Integer) As Boolean
        Dim result As Boolean = value >= fromValue AndAlso value <= toValue

        'Select Case value
        '    Case Is >= fromValue, Is <= toValue
        '        result = True
        '    Case Else
        '        result = False
        'End Select
        Return result
    End Function
    <Extension()> Public Function InSet(value As Byte, fromValue As Byte, toValue As Byte) As Boolean
        Dim result As Boolean = value >= fromValue AndAlso value <= toValue
        'Select Case value
        '    Case Is >= fromValue, Is <= toValue
        '        result = True
        '    Case Else
        '        result = False
        'End Select
        Return result
    End Function
    <Extension()> Public Function ToTable(dic As Dictionary(Of String, Integer), firstColumnName As String, secondColumnName As String, tableName As String) As DataTable
        Dim result As DataTable = New DataTable(tableName)
        result.Columns.Add(firstColumnName, Type.GetType("System.String"))
        result.Columns.Add(secondColumnName, Type.GetType("System.String"))
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
    Public Function PadCenter(str As String, width As Integer, c As Char) As String

        If str Is Nothing Then str = String.Empty
        If (width <= str.Length) Then Return str

        Dim padding As Integer = width - str.Length
        Return str.PadLeft(str.Length + (padding \ 2), c).PadRight(width, c)

    End Function

    <Extension()>
    Public Function PadCenter(str As String, width As Integer) As String

        If str Is Nothing Then str = String.Empty
        If (width <= str.Length) Then Return str

        Dim padding As Integer = width - str.Length
        Return str.PadLeft(str.Length + (padding \ 2)).PadRight(width)

    End Function
    '<Extension()> _
    'Public Function Exists_(ByVal tbl As DataTable, ByVal key As Object, ByVal Column As Integer) As Boolean

    'End Function
    Private Function CloneWithValues(row As DataGridViewRow) As DataGridViewRow
        Dim clonedRow As DataGridViewRow = row.Clone()
        For i As Integer = 0 To row.Cells.Count - 1
            clonedRow.Cells(i).Value = row.Cells(i).Value
        Next
        Return clonedRow
    End Function
End Module
