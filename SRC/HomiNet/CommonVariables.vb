Module CommonVariables
    '----DEZ for try 8 and use both 330 and 226--------------------------
    '#If MiniBarVer = "226" Then
    '    Public Const MaxCountOfProducts As Integer = 44
    '#ElseIf MiniBarVer = "330" Then
    '    Public Const MaxCountOfProducts As Integer = 12
    '#End If

    '    Public Const CountOfProductsHomi330 As Integer = 12
    '    Public Const CountOfProductsHomi226 As Integer = 44
    '    '--------------------------------------------------------------------
#If MiniBarVer = "226" Then
    Public Const MaxCountOfProducts As Integer = 44
    Public Const CountOfProductsHomi330 As Integer = 12
#ElseIf MiniBarVer = "330" Then
    Public Const MaxCountOfProducts As Integer = 12
    Public Const CountOfProductsHomi330 As Integer = 12
#ElseIf MinibarVer = "330tray8" Then
    Public Const MaxCountOfProducts As Integer = 16
    Public Const CountOfProductsHomi330 As Integer = 16
#End If

End Module
