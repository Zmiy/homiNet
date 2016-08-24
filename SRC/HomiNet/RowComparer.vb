Public Class RowComparer
    Implements IComparer

    Private ReadOnly _sortOrderModifier As Integer = 1

    Public Sub New(sortOrder As SortOrder)
        If sortOrder = sortOrder.Descending Then
            _sortOrderModifier = -1
        ElseIf sortOrder = sortOrder.Ascending Then

            _sortOrderModifier = 1
        End If
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare

        Dim dataGridViewRow1 As DataGridViewRow = CType(x, DataGridViewRow)
        Dim dataGridViewRow2 As DataGridViewRow = CType(y, DataGridViewRow)

        ' Try to sort based on the Last Name column.
        Dim compareResult As Integer
        ' System.String.Compare(DataGridViewRow1.Cells(1).Value.ToString(), DataGridViewRow2.Cells(1).Value.ToString())
        Dim roomX As Integer = Integer.Parse(dataGridViewRow1.Cells(0).Value.ToString().DigitsOnly())
        Dim roomY As Integer = Integer.Parse(dataGridViewRow2.Cells(0).Value.ToString().DigitsOnly())
        If roomX = roomY Then
            compareResult = 0
        ElseIf roomX > roomY Then
            compareResult = 1
        Else
            compareResult = -1
        End If
        Return compareResult * _sortOrderModifier
    End Function
End Class