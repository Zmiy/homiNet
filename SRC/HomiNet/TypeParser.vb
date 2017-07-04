Public Class TypeParser
    Public Shared Function DecTryParse(str As String, Optional defValue As Decimal = 0D) As Decimal
        Dim result As Decimal
        If Not Decimal.TryParse(str, result) Then
            result = defValue
        End If
        Return result
    End Function

    Public Shared Function Int32TryParse(str As String, Optional defValue As Int32 = 0) As Int32
        Dim result As Int32
        If Not Int32.TryParse(str, result) Then
            result = defValue
        End If
        Return result
    End Function

    Public Shared Function Int32TryParse(obj As Object, Optional defValue As Int32 = 0) As Int32
        Dim str As String = TryCast(obj, String)
        If str IsNot Nothing Then
            Return Int32TryParse(str, defValue)
        Else
            Return defValue
        End If
    End Function

    Public Shared Function DblTryParse(str As String, Optional defValue As Double = 0) As Double
        Dim result As Double
        If Not Double.TryParse(str, result) Then
            result = defValue
        End If
        Return result
    End Function

End Class
