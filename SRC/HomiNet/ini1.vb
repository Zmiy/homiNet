'
' Created by SharpDevelop.
' User: nicolas
' Date: 20/11/2004
' Time: 16:58
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Windows.Forms
imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Text

Module ModINI1
    'Nom du fichier INI
    Dim _fichier As String = Application.StartupPath & "\Language.ini"
    'Constante
    Const MaxEntry As Integer = 32768
#Region "Lire INI"
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (lpApplicationName As String, lpKeyName As String, lpDefault As String, lpReturnedString As StringBuilder, nSize As Integer, lpFileName As String) As Integer
    '   Cette API permet de lire des fichiers d'initialisations. La fonction retourne 0 si la lecture du fichier d'initialisation a échoué, sinon elle retourne 1. 
    'lpApplicationName définit le nom de la section, 
    'lpKeyName définit le nom de la clef, 
    'lpDefault retourne la valeur par défaut si la clef n'est pas définie, 
    'lpReturnedString contient la valeur de la clef si elle existe sinon elle contient la valeur lpDefault, 
    'nSize est la taille de la variable lpReturnedString en octet, 
    'lpFileName définit le nom du fichier d'initialisation. 
    Function LireInil(entete As String, variable As String) As String
        Dim defval As String = ""
        Try
            Dim strBuild As New StringBuilder(MaxEntry)
            Dim Ret As Integer = GetPrivateProfileString(entete, Variable, defval, strBuild, MaxEntry, _fichier)
            Return strBuild.ToString
        Catch
            Return defval
        End Try
    End Function
#End Region

#Region "Ecrire INI"
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (lpApplicationName As String, lpKeyName As String, lpString As String, lpFileName As String) As Long
    '   Cette API permet de créer ou de modifier vos propres fichiers d'initialisations sans se soucier des détails (par exemple... la gestion des fichiers), si le fichier n'existe pas il est créé, sinon il est modifié. La fonction retourne 0 si la création ou la modification du fichier d'initialisation a échoué, sinon elle retourne 1. 
    'lpApplicationName définit le nom de la section, 
    'lpKeyName définit le nom de la clef, 
    'lpString définit la valeur à ajouter, 
    'lpFileName définit le nom du fichier d'initialisation. 
    Function EcrireINIL(Entete As String, Variable As String, Valeur As String) As Boolean
        WritePrivateProfileString(Entete, Variable, Valeur, _fichier)
    End Function
#End Region

#Region "Supprime INI"
    Function SupprimeINIL(Entete As String, Optional Variable As String = Nothing) As Boolean
        WritePrivateProfileString(Entete, Variable, vbNullString, _fichier)
    End Function
#End Region

#Region "Sections INI"
    Private Declare Function GetPrivateProfileSectionNames Lib "kernel32.dll" Alias "GetPrivateProfileSectionNamesA" (lpszReturnBuffer() As Byte, nSize As Integer, lpFileName As String) As Integer
    Function SectionsINIL() As ArrayList
        SectionsINIL = New ArrayList
        Dim Buffer(MaxEntry) As Byte
        Dim BuffStr As String
        Dim PrevPos As Integer = 0
        Dim Length As Integer
        Try
            Length = GetPrivateProfileSectionNames(Buffer, MaxEntry, _fichier)
        Catch
            Exit Function
        End Try
        Dim ASCII As New ASCIIEncoding
        If Length > 0 Then
            BuffStr = ASCII.GetString(Buffer)
            Length = 0
            PrevPos = -1
            Do
                Length = BuffStr.IndexOf(ControlChars.NullChar, PrevPos + 1)
                If Length - PrevPos = 1 OrElse Length = -1 Then Exit Do
                Try
                    SectionsINIL.Add(BuffStr.Substring(PrevPos + 1, Length - PrevPos))
                Catch
                End Try
                PrevPos = Length
            Loop
        End If
    End Function
#End Region
End Module

