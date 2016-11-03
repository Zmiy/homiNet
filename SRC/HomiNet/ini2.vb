'
' Created by SharpDevelop.
' User: nicolas
' Date: 20/11/2004
' Time: 16:58
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing
imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Text

Module ModINI2
    'Nom du fichier INI
    Dim Fichier As String = Application.StartupPath & "\Param.ini"
    'Constante
    Const MAX_ENTRY As Integer = 32768
#Region "Lire INI"
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (lpApplicationName As String, lpKeyName As String, lpDefault As String, lpReturnedString As StringBuilder, nSize As Integer, lpFileName As String) As Integer
    '   Cette API permet de lire des fichiers d'initialisations. La fonction retourne 0 si la lecture du fichier d'initialisation a échoué, sinon elle retourne 1. 
    'lpApplicationName définit le nom de la section, 
    'lpKeyName définit le nom de la clef, 
    'lpDefault retourne la valeur par défaut si la clef n'est pas définie, 
    'lpReturnedString contient la valeur de la clef si elle existe sinon elle contient la valeur lpDefault, 
    'nSize est la taille de la variable lpReturnedString en octet, 
    'lpFileName définit le nom du fichier d'initialisation. 
    Function LireINI(Entete As String, Variable As String) As String
        Dim defval As String = ""
        Try
            Dim StrBuild As New StringBuilder(MAX_ENTRY)
            Dim Ret As Integer = GetPrivateProfileString(Entete, Variable, defval, StrBuild, MAX_ENTRY, Fichier)
            Return StrBuild.ToString
        Catch
            Return defval
        End Try
    End Function

    Function LireIniBool(Entete As String, Variable As String) As Boolean
        Dim defval As Boolean = 0
        Try
            Dim StrBuild As New StringBuilder(MAX_ENTRY)
            Dim Ret As Integer = GetPrivateProfileString(Entete, Variable, defval, StrBuild, MAX_ENTRY, Fichier)
            If StrBuild.ToString = "True" Then
                Return 1
            Else
                Return 0
            End If
        Catch
            Return defval
        End Try
    End Function
    'Function LireIniSmart(sectionName As String, keyName As String, defValue As String)
    '    Dim resultStr As New StringBuilder(MAX_ENTRY)
    '    Dim retVal = GetPrivateProfileString(sectionName, keyName, defValue, resultStr, MAX_ENTRY, Fichier)
    '    If retVal = 0 Then
    '        EcrireINI(sectionName, keyName, defValue)
    '    End If
    '    Return resultStr.ToString
    'End Function
    Function LireIniSmart(sectionName As String, keyName As String, defValue As String) As String
        Dim resultStr As New StringBuilder(MAX_ENTRY)
        Dim numberOfCharactersRead As Integer = GetPrivateProfileString(sectionName, keyName, "", resultStr, MAX_ENTRY, Fichier)
        If numberOfCharactersRead > 0 Then
            Return resultStr.ToString
        Else
            EcrireINI(sectionName, keyName, defValue)
            Return defValue
        End If
    End Function

    Function LireIniBoolSmart(sectionName As String, keyName As String, defValue As Boolean) As Boolean
        Dim resultStr As New StringBuilder(MAX_ENTRY)
        Dim numberOfCharactersRead As Integer = GetPrivateProfileString(sectionName, keyName, "", resultStr, MAX_ENTRY, Fichier)
        Dim result As Boolean
        If numberOfCharactersRead > 0 Then
            Select Case resultStr.ToString
                Case "0", "False", "false", "FALSE"
                    result = False
                Case "1", "True", "true", "TRUE"
                    result = True
                Case Else
                    result = defValue
            End Select
            Return result
        Else
            EcrireINI(sectionName, keyName, defValue)
            Return defValue
        End If
    End Function
#End Region

#Region "Ecrire INI"
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (lpApplicationName As String, lpKeyName As String, lpString As String, lpFileName As String) As Long
    '   Cette API permet de créer ou de modifier vos propres fichiers d'initialisations sans se soucier des détails (par exemple... la gestion des fichiers), si le fichier n'existe pas il est créé, sinon il est modifié. La fonction retourne 0 si la création ou la modification du fichier d'initialisation a échoué, sinon elle retourne 1. 
    'lpApplicationName définit le nom de la section, 
    'lpKeyName définit le nom de la clef, 
    'lpString définit la valeur à ajouter, 
    'lpFileName définit le nom du fichier d'initialisation. 
    Function EcrireINI(Entete As String, Variable As String, Valeur As String) As Boolean
        WritePrivateProfileString(Entete, Variable, Valeur, Fichier)
    End Function
#End Region

#Region "Supprime INI"
    Function SupprimeINI(Entete As String, Optional Variable As String = Nothing) As Boolean
        WritePrivateProfileString(Entete, Variable, vbNullString, Fichier)
    End Function
#End Region

#Region "Sections INI"
    Private Declare Function GetPrivateProfileSectionNames Lib "kernel32.dll" Alias "GetPrivateProfileSectionNamesA" (lpszReturnBuffer() As Byte, nSize As Integer, lpFileName As String) As Integer
    Function SectionsINI() As ArrayList
        SectionsINI = New ArrayList
        Dim Buffer(MAX_ENTRY) As Byte
        Dim BuffStr As String
        Dim PrevPos As Integer = 0
        Dim Length As Integer
        Try
            Length = GetPrivateProfileSectionNames(Buffer, MAX_ENTRY, Fichier)
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
                    SectionsINI.Add(BuffStr.Substring(PrevPos + 1, Length - PrevPos))
                Catch
                End Try
                PrevPos = Length
            Loop
        End If
    End Function
#End Region
End Module

