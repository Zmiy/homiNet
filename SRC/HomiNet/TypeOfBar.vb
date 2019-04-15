Public Class TypeOfBar

    Private _type As Byte
    Private _descr As String
    Public Property Type() As Byte
        Set(value As Byte)
            _type = value
        End Set
        Get
            Return _type
        End Get
    End Property
    Public WriteOnly Property Descr() As String
        Set(value As String)
            _descr = value
        End Set
    End Property

    Public Sub New(barType As Byte, barDescr As String)
        _type = barType
        Descr = barDescr
    End Sub
    Public Overrides Function ToString() As String
        Return _descr
    End Function

End Class
