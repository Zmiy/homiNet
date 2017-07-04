Imports System.Drawing.Printing
Imports System.Text.RegularExpressions

Public Class rXZ
    Dim memd As Boolean = False
    Private Sub Month_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Month.DateChanged
        memd = True
        Datedebut.Value = Month.SelectionStart
        Datefin.Value = Month.SelectionEnd
    End Sub

    Private Sub Datefin_ValueChanged(sender As Object, e As EventArgs) Handles Datefin.ValueChanged
        If memd = False Then
            Month.SelectionStart = Datedebut.Value
            Month.SelectionEnd = Datefin.Value
        End If
        memd = False
    End Sub

    Private Sub Datedebut_ValueChanged(sender As Object, e As EventArgs) Handles Datedebut.ValueChanged
        If memd = False Then
            Month.SelectionStart = Datedebut.Value
            Month.SelectionEnd = Datefin.Value
        End If
        memd = False
    End Sub

    Private Sub rXZ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
    End Sub
    Public Sub initlangue()
        Me.Text = Trans(319)
        gbtnDaily.Text = Trans(364)
        gbtnCloseDay.Text = Trans(365)
        gbtnReadingPeriod.Text = Trans(366)
        gbtnPrint.Text = Trans(141)
        Label2.Text = Trans(367)
        Label4.Text = Trans(368)
        Label1.Text = ""
        Label3.Text = ""
        Label11.Text = Trans(391)
        Label12.Text = Trans(390)

        imprimante.Items.Clear()
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            imprimante.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
        Next
        Try
            haut.Text = LireINI("imprimante", "xyhaut")
            gauche.Text = LireINI("imprimante", "xygauche")
            imprimante.Text = LireINI("imprimante", "xy")

        Catch ex As Exception

        End Try
    End Sub
    'Daily
    Private Sub GlassButton4_Click(sender As Object, e As EventArgs) Handles gbtnDaily.Click 'Daily
        table.AddEmis(0, "LECTUREJOURNALIERE|")
        Label1.Text = Trans(364)
        Label3.Text = Now
    End Sub

    Private Sub GlassButton3_Click(sender As Object, e As EventArgs) Handles gbtnCloseDay.Click    'Close day
        If DialogResult.Yes = MessageBox.Show("Do you realy WANT CLOSED DAY?", "My Homi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) Then
            table.AddEmis(0, "CLOTUREJOURNALIERE|")
            Label1.Text = Trans(365)
            Label3.Text = Now
        End If

    End Sub
    'Reading period
    Private Sub gbtnReadingPeriod_Click(sender As Object, e As EventArgs) Handles gbtnReadingPeriod.Click   'Reading period
        lbPeriodResults.Items.Clear()
        table.AddEmis(0, "LECTUREDATE|" + Datedebut.Value.ToUniversalTime().ToString("u") + "|" + Datefin.Value.ToUniversalTime().ToString("u"))
        Label1.Text = Trans(374)
        Label3.Text = Datedebut.Value + " - " + Datefin.Value
        lbPeriodResults.Items.Add("Please wait!!!")
    End Sub
    Public Sub ResultsToTable()
        Dim indx As Integer = lbPeriodResults.FindString("------------------------------------------")
        Dim result() As String
        If indx > -1 Then
            Dim pattern As String = "\s{2,}"
            For indx = indx + 3 To lbPeriodResults.FindString("__________________________________________") - 1
                Dim str As String = Regex.Replace(lbPeriodResults.Items(indx).ToString().Trim(), pattern, "~")
                result = str.Split("~"c)
            Next

        End If
    End Sub
    Private Sub GlassButton1_Click(sender As Object, e As EventArgs) Handles gbtnPrint.Click   'Print
        EcrireINI("imprimante", "xygauche", gauche.Text)
        EcrireINI("imprimante", "xyhaut", haut.Text)
        Using imp As New Imprimer(Me)
            imp.Imprimante = imprimante.Text
            imp.Imprime = "xy"
            imp.Paysage = False
            imp.UserLeft = Val(gauche.Text)
            imp.UserTop = Val(haut.Text)
            imp.Go()
            imp.Show()
        End Using

    End Sub
End Class