Imports System.Drawing.Printing

Public Class PrinterSet
    Private Shared Function GetListOfPrinters() As List(Of String)
        GetListOfPrinters = New List(Of String)
        Try
            For Each printer As String In PrinterSettings.InstalledPrinters
                GetListOfPrinters.Add(printer)
            Next
        Catch ex As Exception

        End Try
    End Function

    Private Shared Function GetPrintername(usedPrinterName As String) As String
        Try

            If GetListOfPrinters().Contains(usedPrinterName) Then
                GetPrintername = usedPrinterName
            Else
                GetPrintername = GetDefaultPrinterName()
            End If

        Catch ex As Exception

        End Try
    End Function
    Public Shared Sub SetPrinter(ByRef cmb As ComboBox, propertySection As String, propertyName As String)
        Dim usedPrinter As String = LireIniSmart(propertySection, propertyName, "")
        cmb.Items.Clear()
        cmb.Items.AddRange(GetListOfPrinters.ToArray())
        cmb.Text = GetPrintername(usedPrinter)
        EcrireINI(propertySection, propertyName, cmb.Text)
    End Sub
    Public Shared Sub SetPrinter(ByRef cmb As ComboBox, printerName As String)
        cmb.Items.Clear()
        cmb.Items.AddRange(GetListOfPrinters.ToArray())
        cmb.Text = GetPrintername(printerName)
    End Sub

    Private Shared Function GetDefaultPrinterName() As String

        Dim oPs As New PrinterSettings

        Try
            GetDefaultPrinterName = oPs.PrinterName
        Catch ex As Exception
            GetDefaultPrinterName = ""
        Finally
            oPs = Nothing
        End Try
    End Function
End Class
