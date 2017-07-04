Imports System.Resources
Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' Les informations générales relatives à un assembly dépendent de 
' l'ensemble d'attributs suivant. Changez les valeurs de ces attributs pour modifier les informations
' associées à un assembly.

' Vérifiez les valeurs des attributs de l'assembly



#If MiniBarVer = "226" Then
#If NET3_5 Then
<Assembly: AssemblyTitle("HomiNet - 226/330 for .NET Framework 3.5")> 
#ElseIf NET4_0 Then
<Assembly: AssemblyTitle("HomiNet - 226/330 for .NET Framework 4.0")> 
#ElseIf NET4_5 Then
<Assembly: AssemblyTitle("HomiNet - 226/330 for .NET Framework 4.5")> 
#End If
<Assembly: AssemblyProduct("APP HomiNet V8- 226/330")> 
<Assembly: AssemblyDescription("Support 330-336 with/without eTray And MP, support 226")> 
#ElseIf MiniBarVer = "330" Then
#If NET3_5 Then
<Assembly: AssemblyTitle("HomiNet - 330 for .NET Framework 3.5")> 
#ElseIF NET4_0 Then
<Assembly: AssemblyTitle("HomiNet - 330 for .NET Framework 4.0")> 
#ElseIf NET4_5 Then
<Assembly: AssemblyTitle("HomiNet - 330 for .NET Framework 4.5")> 
#End If

<Assembly: AssemblyProduct("APP HomiNet V8 - 330")> 
<Assembly: AssemblyDescription("Support 330-336 with/without eTray And MP")>
#End If

<Assembly: AssemblyCompany("By Nicolas TILLET, Evgeny Drapkin")> 
<Assembly: AssemblyCopyright("Copyright ©  2008-2016")> 
<Assembly: AssemblyTrademark("")> 

<Assembly: ComVisible(False)> 

'Le GUID suivant est pour l'ID de la typelib si ce projet est exposé à COM
<Assembly: Guid("635e99b7-327a-43f9-88d5-f37538ba63e7")> 

' Les informations de version pour un assembly se composent des quatre valeurs suivantes :
'
'      Version principale
'      Version secondaire 
'      Numéro de build
'      Révision
'
' Vous pouvez spécifier toutes les valeurs ou indiquer les numéros de build et de révision par défaut 
' en utilisant '*', comme indiqué ci-dessous :
' <Assembly: AssemblyVersion("1.0.*")> 


<Assembly: AssemblyVersion("8.1.4.9")> 
<Assembly: AssemblyFileVersion("8.1.4.912")> 

<Assembly: NeutralResourcesLanguageAttribute("en-US")> 

'Friend Class versionInfo
'    Public AssemblyTitle As String
'    Private AssemblyTitleFramework As String
'    Private AssemblyTitleDemo As String = String.Empty
'#If DEMO Then
'    AssemblyTitleDemo = "DemoEdition"
'#End If
'End Class