Imports System.Drawing.Printing
Imports System.Globalization

Public Class Rfacture
    Dim _memd As Boolean = False
    Private Sub Month_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Month.DateChanged
        _memd = True
        Datedebut.Value = Month.SelectionStart
        Datefin.Value = Month.SelectionEnd
    End Sub

    Private Sub Datefin_ValueChanged(sender As Object, e As EventArgs) Handles Datefin.ValueChanged
        If _memd = False Then
            Month.SelectionStart = Datedebut.Value
            Month.SelectionEnd = Datefin.Value
        End If
        _memd = False
    End Sub

    Private Sub Datedebut_ValueChanged(sender As Object, e As EventArgs) Handles Datedebut.ValueChanged
        If _memd = False Then
            Month.SelectionStart = Datedebut.Value
            Month.SelectionEnd = Datefin.Value
        End If
        _memd = False
    End Sub


    Private Sub rfacture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initlangue()
        ComboBox1.DataSource = maintable
        ComboBox1.DisplayMember = "numchambre"
    End Sub
    Public Sub Initlangue()
        Text = Trans(376)
        RadioButton1.Text = Trans(236)
        RadioButton2.Text = Trans(28)
        Label5.Text = Trans(377)
        Label2.Text = Trans(367)
        Label4.Text = Trans(368)
        Label1.Text = Trans(359)
        Label6.Text = Trans(358)
        Label9.Text = ""
        Label3.Text = ""
        Label8.Text = ""
        Label10.Text = ""
        Label7.Text = ""
        Label11.Text = Trans(391)
        Label12.Text = Trans(390)
        GlassButton8.Text = Trans(189)
        GlassButton5.Text = Trans(141)
        'entete facture
        TextBox2.Text = Mid(Trans(353) + "    ", 1, 4) + "|" + Mid(Trans(354) + "              ", 1, 13) + "|" + Microsoft.VisualBasic.Right("      " + Trans(355), 6) + "|" + Microsoft.VisualBasic.Right("      " + Trans(356), 6) + "|" + Microsoft.VisualBasic.Right("         " + Trans(357), 9)

        imprimante.Items.Clear()
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            imprimante.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
        Next
        Try
            haut.Text = LireINI("imprimante", "facturehaut")
            gauche.Text = LireINI("imprimante", "facturegauche")
            imprimante.Text = LireINI("imprimante", "facture")

        Catch ex As Exception

        End Try
    End Sub

    Private Shared Sub ClearControl(control As Control)
        For Each cnt As Control In control.Controls
            If TypeOf cnt Is Label Then
                CType(cnt, Label).Text = String.Empty
                Continue For
            ElseIf TypeOf cnt Is ListBox Then
                CType(cnt, ListBox).Items.Clear()
                Continue For
            End If
            If cnt.HasChildren Then
                ClearControl(cnt)
            End If
        Next
    End Sub

    Private Sub GlassButton8_Click(sender As Object, e As EventArgs) Handles GlassButton8.Click
        Dim nummodule As Integer = 0
        Dim waitMessage As String = "Wait factures for all rooms"
        ClearControl(AlphaGradientPanel2)
        If RadioButton2.Checked = True Then
            nummodule = CInt(ComboBox1.Text) 'Val(ComboBox1.Text)
            waitMessage = "Wait factures for room " + ComboBox1.Text.Trim()
        End If
        lbListOfFacture.Items.Clear()
        lbListOfFacture.Items.Add(waitMessage)
        table.AddEmis(nummodule, "ARCHIVEFACTURELIST|" + Datedebut.Value.ToUniversalTime().ToString("u") + "|" + Datefin.Value.ToUniversalTime().ToString("u") + "|" + nummodule.ToString)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbListOfFacture.SelectedIndexChanged
        If lbListOfFacture.SelectedIndex = -1 Then Exit Sub
        table.AddEmis(0, "ARCHIVEFACTURE|" + lbListOfFacture.SelectedItem)
        Dim s As String() = lbListOfFacture.SelectedItem.ToString.Split(" "c)
        If s.Length >= 3 Then
            '-----------------------------------------------
            lbSelectedFactory.Items.Clear()
            Label8.Text = String.Empty
            Label7.Text = String.Empty
            '-----------------------------------------------
            Label9.Text = Trans(348) + ": " + s(2)
            Label3.Text = Mid(s(1), 1, 4) + "/" + Mid(s(1), 5, 2) + "/" + Mid(s(1), 7, 2)
            Dim nummodule As Integer = Val(Mid(s(0), 2, s(0).Length - 1))
            Label10.Text = Trans(15) + ": " + nummodule.ToString 'MAINFORM.d(nummodule, "numchambre")
        End If
    End Sub

    Public Sub Total()
        Dim s As String
        Dim ttax As Double = 0, ttc As Double = 0
        Dim nfi As NumberFormatInfo = NumberFormatInfo.CurrentInfo
        nfi = CType(nfi.Clone(), NumberFormatInfo)
        nfi.NumberDecimalSeparator = "."
        'Dim culture2 As CultureInfo = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name)
        'Dim current2 As NumberFormatInfo = culture2.NumberFormat
        For i As Integer = 0 To lbSelectedFactory.Items.Count - 1
            Try
                If lbSelectedFactory.Items(i).ToString() = Space(42) Then
                    s = lbSelectedFactory.Items(i - 1).ToString()
                    ttax += Convert.ToDouble(Mid(s, 27, 6), nfi) 'CDbl(Mid(s, 27, 6))
                    ttc += Convert.ToDouble(Mid(s, 33, 10), nfi) 'CDbl(Mid(s, 33, 10))
                End If

            Catch ex As Exception

            End Try
        Next
        'Dim nfi As NumberFormatInfo = CultureInfo.InvariantCulture.NumberFormat


        'nfi.NumberDecimalSeparator = "."
        Label8.Text = Format(ttax, "0.00")
        Label7.Text = Format(ttc, "0.00")
    End Sub

    Private Sub GlassButton5_Click(sender As Object, e As EventArgs) Handles GlassButton5.Click
        EcrireINI("imprimante", "facturegauche", gauche.Text)
        EcrireINI("imprimante", "facturehaut", haut.Text)
        Dim imp As New Imprimer(Me)
        imp.Imprimante = imprimante.Text
        imp.Imprime = "facture"
        imp.Paysage = False
        imp.UserLeft = Val(gauche.Text)
        imp.UserTop = Val(haut.Text)
        imp.Go()
        imp.Show()
    End Sub

    Private Sub imprimante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles imprimante.SelectedIndexChanged
        EcrireINI("imprimante", "facture", imprimante.Text)

    End Sub
End Class