Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing


Module CommonMod1
#Region " Mes variable "
    Public Couleur As Color

    Public ReadOnly Trans(2000) As String
    

    Public Colwidth(40) As Integer


    Public P As New Pen(Color.Black)
    Public B0 As New SolidBrush(Color.Black)
    Public ReadOnly Farial8 As New Font("Arial", 8)
    Public ReadOnly Farial8B As New Font("Arial", 8, FontStyle.Bold)
    Public ReadOnly Farial6B As New Font("Arial", 6, FontStyle.Bold)
    Public ReadOnly Farial10 As New Font("Arial", 10)
    Public ReadOnly Farial10B As New Font("Arial", 10, FontStyle.Bold)
    Public ReadOnly Farial12 As New Font("Arial", 12)
    Public ReadOnly Farial12Ib As New Font("Arial", 12, FontStyle.Italic Or FontStyle.Bold)
    Public ReadOnly Farial12B As New Font("Arial", 12, FontStyle.Bold)

    Public ReadOnly CourierNMono8 As New Font("Courier New", 8)
    Public ReadOnly CourierNMono8B As New Font("Courier New", 8, FontStyle.Bold)
    Public ReadOnly CourierNMono6B As New Font("Courier New", 6, FontStyle.Bold)
    Public ReadOnly CourierNMono10 As New Font("Courier New", 10)
    Public ReadOnly CourierNMono10B As New Font("Courier New", 10, FontStyle.Bold)
    Public ReadOnly CourierNMono12 As New Font("Courier New", 12)
    Public ReadOnly CourierNMono12Ib As New Font("Courier New", 12, FontStyle.Italic Or FontStyle.Bold)
    Public ReadOnly CourierNMono12B As New Font("Courier New", 12, FontStyle.Bold)

    Public ReadOnly ConsolasMono8 As New Font("Consolas", 8)
    Public ReadOnly ConsolasMono8B As New Font("Consolas", 8, FontStyle.Bold)
    Public ReadOnly ConsolasMono6B As New Font("Consolas", 6, FontStyle.Bold)
    Public ReadOnly ConsolasMono10 As New Font("Consolas", 10)
    Public ReadOnly ConsolasMono10B As New Font("Consolas", 10, FontStyle.Bold)
    Public ReadOnly ConsolasMono12 As New Font("Consolas", 12)
    Public ReadOnly ConsolasMono12Ib As New Font("Consolas", 12, FontStyle.Italic Or FontStyle.Bold)
    Public ReadOnly ConsolasMono12B As New Font("Consolas", 12, FontStyle.Bold)

    'Public ReadOnly Farial8 As New Font("PT Serif", 8)
    'Public ReadOnly Farial8B As New Font("PT Serif", 8, FontStyle.Bold)
    'Public ReadOnly Farial6B As New Font("PT Serif", 6, FontStyle.Bold)
    'Public ReadOnly Farial10 As New Font("PT Serif", 10)
    'Public ReadOnly Farial10b As New Font("PT Serif", 10, FontStyle.Bold)
    'Public ReadOnly Farial12 As New Font("PT Serif", 12)
    Public F3 As New Font("Arial", 14)
    Public F4 As New Font("Arial", 20)
    
    Public ReadOnly Flitle As New Font("Times New Roman", 6, FontStyle.Bold)
    Public Lf0 As New Font("Lucida Console", 8)
    Public Lf1 As New Font("Lucida Console", 10)
    Public Lf2 As New Font("Lucida Console", 12)
    Public Lf3 As New Font("Lucida Console", 14)
    Public Lf4 As New Font("Lucida Console", 20)
    Public Page As Integer
    Public Bt As New Button
    Public Curx As Integer
    Public Cury As Integer
    Public T(180, 5000) As Object
    Public Rien As DBNull
    Public Cc0(100) As String
    Public Cc1(100) As String
    Public Cc2(100) As String
    Public Jour As Integer
    Public Nbsel As String
    Public ReadOnly Maintable As New DataTable("maintable")
    Public ReadOnly DtMomentaryPickUp As New DataTable("MomentaryPickUp")
    Public ReadOnly Dlc As New DataTable("dlc")
    Public WithEvents Dv As New DataView
    Public ReadOnly Dvch As New DataView
    Public WithEvents Dv1 As New DataView
    Public Ouvremin As Integer
    Public Nomhotel As String = "HOTEL"
    Public Accesucf As Integer = 65535

#End Region
    Public IsStarted As Boolean = True

#Region "variable serveur"
    Public RemoteHost As String = "nicolas-laptop"
    Public RemotePort As String = "7000"

    Public Ts(50) As String
    '    Dim _wRow As DataRow
    '    Dim _numrow As Integer
    Public ReadOnly Bufrecep As New ListBox
    Public ReadOnly Bufemis As New ListBox
    Public Libre As Boolean = True
    '    Public savcount As Integer = 0

#End Region

    
    
End Module
