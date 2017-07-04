
Public Class ModelTools
    Private Shared _mainTable As DataTable = New DataTable()
    Private Shared _modelTable As DataTable = New DataTable()
    Private _modelsHex As Dictionary(Of String, Long)
    Public Shared Function Is226Model(indx As Integer) As Boolean
        Return Convert.ToBoolean(basemodele.modele.Rows(indx)("Is226"))
    End Function
    Public Shared Function Is226Model(modelname As String) As Boolean
        Dim indx As Integer = basemodele.lstbListOfModels.FindStringExact(modelname)
        If indx <> -1 Then
            Return Convert.ToBoolean(basemodele.modele.Rows(indx)("Is226"))
        Else
            Return False
        End If
    End Function

    Public Shared Property mainTable As DataTable
        Set(value As DataTable)
            _mainTable = value
        End Set
        Private Get
            Return _mainTable
        End Get
    End Property

    Public Shared Property modelTable As DataTable
        Set(value As DataTable)
            _modelTable = value
        End Set
        Private Get
            Return _modelTable
        End Get
    End Property
    Public Shared Function Model2Hex() As Dictionary(Of String, Long)
        Dim dicHexModels As Dictionary(Of String, Long) = New Dictionary(Of String, Long)()
        For i As Integer = 0 To basemodele.modele.Rows.Count - 1
            If Convert.ToBoolean(basemodele.modele.Rows(i)("Is226").ToString()) Then
                dicHexModels.Add(basemodele.modele.Rows(i)("nom").ToString(), Model2Hex226(i))
            Else
                dicHexModels.Add(basemodele.modele.Rows(i)("nom").ToString(), Model2Hex330(i))
            End If
        Next
        Return dicHexModels
    End Function
    Private Shared Function Model2Hex330(indx As Integer) As Integer
        Dim swrModel As Integer = &H100
#If MinibarVer = "226" Then
        For casier As Integer = 1 To 16 'CountOfProductsHomi330
#ElseIf MinibarVer = "330" OrElse MinibarVer = "330tray8" Then
        For casier As Integer = 1 To CountOfProductsHomi330
#End If
            Dim tray1St As Integer '= &H10000
            Const tray2Nd As Integer = &H1000
            If CountOfProductsHomi330 < 16 Then
                tray1St = &H1000
            Else
                tray1St = &H10000
            End If
            If Convert.ToInt16(basemodele.modele.Rows(indx)("q" + casier.ToString())) > 0 Then
                Select Case casier
                    Case Is <= 4 'left
                        swrModel = &H10 << (casier - 1) Xor swrModel
                    Case Is <= 8  'right
                        swrModel = &H1 << (casier - 5) Xor swrModel
                    Case Is <= 12  'tray
                        swrModel = tray1St << (casier - 9) Xor swrModel '&H10000 << (casier - 9) Xor swrModel
                    Case Is <= 16 'tray8
                        swrModel = tray2Nd << (casier - 13) Xor swrModel '&H1000 << (casier - 13) Xor swrModel
                End Select
            End If
        Next
        Return swrModel
    End Function
    Public Shared Function ModelByIndex(indx As Integer, coffre As Integer) As Long
        If indx = -1 Then
            Return indx
        End If
        Select Case coffre
            Case 0, 1, 2
                Return Model2Hex330(indx)
            Case 3
                Return Model2Hex226(indx)
        End Select
        Return -1
    End Function
    Public Shared Function ModelByName(modelname As String, coffre As Integer) As Long
        Dim indx As Integer = basemodele.lstbListOfModels.FindStringExact(modelname)
        If indx = -1 Then
            Return indx
        End If
        Select Case coffre
            Case 0, 1, 2
                Return Model2Hex330(indx)
            Case 3
                Return Model2Hex226(indx)
        End Select
        Return -1
    End Function
    Private Shared Function Model2Hex226(indx As Integer) As Long
        Dim swrModel As Long = 0L
        For casier As Integer = 1 To MaxCountOfProducts
            If Convert.ToInt16(basemodele.modele.Rows(indx)("q" + casier.ToString())) = 1 Then
                Select Case casier
                    Case Is <= 12 'top shelf
                        swrModel = &H10000000000L << (casier - 1) Xor swrModel
                    Case Is <= 24  'bottom shelf
                        swrModel = &H10000000L << (casier - 13) Xor swrModel
                    Case Is <= 30  'balcony1
                        swrModel = &H100000L << (casier - 25) Xor swrModel
                    Case Is <= 36  'balcony2
                        swrModel = &H1000L << (casier - 31) Xor swrModel
                    Case Is > 36  'tray
                        swrModel = &H10L << (casier - 37) Xor swrModel
                End Select
            End If
        Next
        Return swrModel
    End Function
    Public Shared Function ListRoomsWithGuestProduct(table As DataTable) As List(Of DataRow)
        Dim result As List(Of DataRow) = New List(Of DataRow)()
        Dim modelsHex As Dictionary(Of String, Long) = Model2Hex()
        Dim sceleton As Long
        Dim realSwr As Long
        For Each dr As DataRow In From dr1 As DataRow In table.Rows Where dr1("coffre").ToString() = "3" And Not dr1("numchambre").ToString().StartsWith("R")
            If modelsHex.ContainsKey(dr("modelefrigo").ToString()) Then
                sceleton = modelsHex(dr("modelefrigo").ToString().Trim())
                realSwr = Convert.ToInt64(dr("swr").ToString(), 16)
                If (((realSwr And &HF00003F000) = 0) AndAlso ((realSwr - 1) Or sceleton) <> sceleton) Then
                    result.Add(dr)
                End If
            Else
                Continue For
            End If
        Next
        Return result
        'Return (From dr1 As DataRow In table.Rows Let sceleton = modelsHex(dr1("modelefrigo").ToString()) Let realSwr = Convert.ToInt64(dr1("swr").ToString(), 16) Where dr1("coffre").ToString() = "3" And ((realSwr And &HF00003F000) = 0 And (realSwr - 1 Or sceleton) <> sceleton) Select dr1).ToList()
    End Function

    Public Shared Function IsGuestPresentSomething(swr As String, modelname As String, coffre As String) As Boolean
        Select Case coffre
            Case "0", "1", "2"
                Return False
            Case "3"
                Return IsGuestPresentSomething(swr, modelname)
            Case Else
                Return False
        End Select
    End Function
    Public Shared Function IsGuestPresentSomething(swr As String, modelname As String) As Boolean
        Dim realSwr As Long = Convert.ToInt64(swr, 16)
        Dim sceleton As Long = ModelByName(modelname, 3)
        Return ((sceleton Or (realSwr - 1)) <> sceleton) AndAlso ((realSwr And &HF00003F000) = 0)
    End Function

    'Public Shared Sub PresentofGuestProduct()
    '    Dim dv = mainTable.DataView
    '    Dim shelveserrorUcfNumbers = New StringBuilder()
    '    if Not dv IsNothing Then
    '        For Each dr As DataRow in 
    '    End If
    '                                {
    '                                    foreach (DataRow dr in from DataRow dr in dv.ToTable().Rows let sceleton = _modelsHex[dr["modelefrigo"].ToString()] let realSwr = Convert.ToInt64(dr["swr"].ToString(), 16) where (realSwr & 0xF00003F000) == 0 && (realSwr - 1 | sceleton) != sceleton select dr)
    '                                    {
    '                                        shelveserrorUcfNumbers.Append("'" + dr["nummodule"].ToString() + "'");
    '                                        shelveserrorUcfNumbers.Append(", ");
    '                                    }
    '                                }

    'End Sub
End Class
