Imports System.ComponentModel
Imports System.Globalization
Imports System.Net
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Threading
Imports TcpClient = TcpLibrary.TcpClient

Public Class Mainform
    Public ReadOnly TroubleDescr As Trouble = New Trouble()
#Region "FORM"
    Const TroubleMessageCaption As String = "Warning!!!"
    Private Delegate Sub SetTextCallback(header As String)

    Private Sub SetText(headerText As String)
        If InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Invoke(d, New Object() {headerText})
        Else
            Text = headerText
        End If
    End Sub
    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Langue()
        tabMain.BackColor = Color.RoyalBlue
        tabMain.TabPages.Add(table)
        tabMain.TabPages.Add(ViewByModele)
        tabMain.TabPages.Add(facture)
        tabMain.TabPages.Add(bases)
        tabMain.TabPages.Add(utilisateur)
        tabMain.TabPages.Add(resultat)
        tabMain.TabPages.Add(menuremplissage)
        tabMain.TabPages.Add(edition)
        tabMain.TabPages.Add(menuinformation)
        tabMain.TabPages.Add(configuration)
        tabMain.TabPages.Add(Warning)
        tabMain.TabPages.Add(login)
        IsStarted = False
        Initserveur()
        'TimerWarningsOfTrouble_Tick(Nothing, Nothing)
        Dim ciCurrent As CultureInfo = CultureInfo.CurrentCulture
        Dim ci As CultureInfo = CultureInfo.CreateSpecificCulture(ciCurrent.ToString())

        Dim pattern As String() = ci.DateTimeFormat.ShortDatePattern().Split(CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator)

        For ii As Byte = 0 To 2
            Select Case pattern(ii)
                Case "d"
                    pattern(ii) = "dd"
                Case "M"
                    pattern(ii) = "MM"
            End Select
        Next
        ci.DateTimeFormat.ShortDatePattern = String.Join(ci.DateTimeFormat.DateSeparator.ToString(), pattern)
        'pattern(0) + CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator + pattern(1) + CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator + pattern(2)

        Dim patternT() As String = ci.DateTimeFormat.LongTimePattern.Split(ci.DateTimeFormat.TimeSeparator)

        For ii As Byte = 0 To patternT.Count - 1
            Select Case patternT(ii)
                Case "h"
                    patternT(ii) = "hh"
                Case "H"
                    patternT(ii) = "HH"
                Case "m"
                    patternT(ii) = "mm"
                Case "s"
                    patternT(ii) = "ss"
            End Select
        Next
       ci.DateTimeFormat.LongTimePattern = String.Join(ci.DateTimeFormat.TimeSeparator.ToString(), patternT)
        'patternT(0) + CultureInfo.CurrentCulture.DateTimeFormat.TimeSeparator + patternT(1) + CultureInfo.CurrentCulture.DateTimeFormat.TimeSeparator + patternT(2)

        Thread.CurrentThread.CurrentCulture = ci
    End Sub
    Private Sub MAINFORM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        '   End
        e.Cancel = True
        Visible = False
        ntf.Visible = True
    End Sub

    Public Sub Langue()
        Ouvremin = Val(LireINI("Parametre", "ouvremin"))
        Dim st0 As String = LireINI("langage", "langue")
        If st0 = "" Then st0 = "Francais"
        For i0 As Integer = 0 To 500
            Trans(i0) = Trim(LireINIL(st0, Trim(Str(i0))))
        Next
        gbtnRemplissage.Text = Trans(55)
        block.Text = Trans(4)
        bbase.Text = Trans(315)
        butilisateur.Text = Trans(1)
        bedition.Text = Trans(2)
        bresultat.Text = Trans(319)
        bconfiguration.Text = Trans(3)
        banomalie.Text = Trans(81)
        m1.Text = Trans(33)
        m2.Text = Trans(34)
    End Sub

    Private Sub Buttonnavy()
        gbtnRemplissage.BackColor = Color.Navy
        block.BackColor = Color.Navy
        bbase.BackColor = Color.Navy
        butilisateur.BackColor = Color.Navy
        bedition.BackColor = Color.Navy
        bresultat.BackColor = Color.Navy
        bconfiguration.BackColor = Color.Navy
        banomalie.BackColor = Color.Navy
        btTroubleWarning.BackColor = Color.Navy
    End Sub
    Public Sub block_Click(sender As Object, e As EventArgs) Handles block.Click
        Buttonnavy()
        tabMain.TabPages.Item(table).Select()
        block.BackColor = Color.Green
    End Sub
    Public Sub bbase_Click(sender As Object, e As EventArgs) Handles bbase.Click
        Buttonnavy()
        tabMain.TabPages.Item(bases).Select()
        bbase.BackColor = Color.Green
    End Sub
    Public Sub bresultat_Click(sender As Object, e As EventArgs) Handles bresultat.Click
        Buttonnavy()
        tabMain.TabPages.Item(resultat).Select()
        bresultat.BackColor = Color.Green
    End Sub
    Public Sub RemplissagePerformClickAction()
        Do
            Application.DoEvents()
            Thread.Sleep(20)
        Loop Until SpinningProgress1.AutoIncrement = False
        Buttonnavy()
        tabMain.TabPages.Item(menuremplissage).Select()
        gbtnRemplissage.BackColor = Color.Green
    End Sub

    Private Sub gbtnRemplissage_Click(sender As Object, e As EventArgs) Handles gbtnRemplissage.Click
        RemplissagePerformClickAction()
    End Sub

    Public Sub butilisateur_Click(sender As Object, e As EventArgs) Handles butilisateur.Click
        Buttonnavy()
        tabMain.TabPages.Item(utilisateur).Select()
        butilisateur.BackColor = Color.Green
    End Sub
    Public Sub bedition_Click(sender As Object, e As EventArgs) Handles bedition.Click
        Buttonnavy()
        tabMain.TabPages.Item(edition).Select()
        bedition.BackColor = Color.Green
    End Sub
    Public Sub bconfiguration_Click(sender As Object, e As EventArgs) Handles bconfiguration.Click
        Buttonnavy()
        tabMain.TabPages.Item(configuration).Select()
        bconfiguration.BackColor = Color.Green
    End Sub
    Public Sub banomalie_Click(sender As Object, e As EventArgs) Handles banomalie.Click
        Buttonnavy()
        menuinformation.tabInformation.TabPages(Informationinterface).Select()
        tabMain.TabPages.Item(menuinformation).Select()
        banomalie.BackColor = Color.Green
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim versionN As String = Assembly.GetExecutingAssembly().GetName().Version.ToString()
#If Demo Then
        versionN += " Demo Edition"
#End If
        MessageBox.Show("HomiNet V " + versionN, "Version", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'MsgBox("HomiNet V 8.1.4.3", MsgBoxStyle.Information, "Version")
    End Sub


#End Region

#Region "serveur"
    Public WithEvents ClientOfDriverIrf As New TcpClient()

    Private Sub Initserveur()
        Timerconnect_Tick(Nothing, Nothing)
    End Sub
    Private Sub Timerconnect_Tick(sender As Object, e As EventArgs) Handles Timerconnect.Tick
        If ClientOfDriverIrf.IsConnected = False Then
            'Try
            '    ClientOfDriverIrf.Close()

            'Catch ex As Exception

            'End Try
            ClientOfDriverIrf.Connect(RemoteHost, Int32.Parse(RemotePort))
            'client.Connect(IP.ToString(), Int32.Parse(RemotePort))
        End If
    End Sub
    Private Sub Client_connect() Handles ClientOfDriverIrf.Connected
        SetText("HomiNet " + Trans(194))
    End Sub
    Private Sub Client_disconnect() Handles ClientOfDriverIrf.Disconnect
        SetText("HomiNet " + Trans(195))
    End Sub
    Private Sub Client_DataArrival(available As Long) Handles ClientOfDriverIrf.DataArrival
        Dim s As String = "", c As Integer
        Try
            Do While ClientOfDriverIrf.BytesAvailable > 0
                s = ""
                SpinningProgress1.AutoIncrement = True
                Do
                    '-------------
                    If ClientOfDriverIrf.BytesAvailable < 2 Then
                        c = 0
                    Else
                        c = Val("&h" + Chr(ClientOfDriverIrf.GetData(1).GetValue(0)) + Chr(ClientOfDriverIrf.GetData(1).GetValue(0)))
                        If c <> (0) Then s = s + Chr(c)
                    End If
                    '-------------------
                    'c = Val("&h" + Chr(client.GetData(1).GetValue(0)) + Chr(client.GetData(1).GetValue(0)))
                    'If c <> (0) Then s = s + Chr(c)
                Loop Until c = (0)
                Bufrecep.Items.Add(s)
                Bufrecep.Update()
            Loop
        Catch
        End Try

    End Sub
    Private Sub TimerTraiteReseau_Tick(sender As Object, e As EventArgs) Handles TimerTraiteReseau.Tick
        If Bufrecep.Items.Count = 0 Then Exit Sub
        If Bufrecep.Items.Count = Nothing Then
            Bufrecep.Items.RemoveAt(0)
            Exit Sub
        End If
        Dim data As String = Bufrecep.Items(0)
        Dim s() As String = data.Split(Chr(124))
        Bufrecep.Items.RemoveAt(0)
        Select Case s(0)
            Case "JOURNALDEBUT"
                table.rt.Clear()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "JOURNAL"
                Dim ligne As String() = data.Split("$")
                For i As Integer = 0 To ligne.Length - 1
                    If ligne(i) <> "" Then table.traitejournal(ligne(i))
                Next
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "JOURNALFIN"
                table.finjournal()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "FACTUREDEBUT"
                facture.rtf.Items.Clear()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "FACTURE"
                If s(1) = facture.nummoduleaff Then
                    facture.rtf.Items.Add(s(2))
                    facture.rtf.Items.Add(s(3))
                    facture.rtf.Items.Add(s(4))
                End If
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
                facture.rtf.SelectedIndex = facture.rtf.Items.Count - 1
                If facture.rtf.SelectedIndex > -1 Then
                    facture.rtf.SetSelected(facture.rtf.Items.Count - 1, False)
                End If
            Case "FACTUREMAJLIGNE"
                If s(1) = facture.nummoduleaff Then
                    facture.indligne = Val(s(5))
                    facture.rtf.Items(facture.indligne - 1) = s(2)
                    facture.rtf.Items(facture.indligne) = s(3)
                    facture.rtf.Items(facture.indligne + 1) = s(4)
                End If
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "FACTUREFIN"
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
                facture.rtf.Items.Add("")
                facture.total()
            Case "LECTUREDEBUT"
                rXZ.rtf.Items.Clear()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "LECTURE"
                rXZ.rtf.Items.Add(s(1))
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "LECTUREFIN"
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ARCHIVEDEBUT"
                Rfacture.lbSelectedFactory.Items.Clear()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ARCHIVE"
                Rfacture.lbSelectedFactory.Items.Add(s(1))
                Rfacture.lbSelectedFactory.Items.Add(s(2))
                Rfacture.lbSelectedFactory.Items.Add(s(3))
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ARCHIVEFIN"
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
                Rfacture.Total()
            Case "ARCHIVELISTDEBUT"
                Rfacture.lbListOfFacture.Items.Clear()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ARCHIVELIST"
                For i As Integer = 1 To s.Length - 1
                    Rfacture.lbListOfFacture.Items.Add(s(i))
                Next
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "NOM"
                'client.Close()
                'client.Connect(RemoteHost, Int32.Parse(RemotePort))
                ClientOfDriverIrf.SendData(Conv("REPONSE_NOM|" & My.Computer.Name & "|"))
            Case "NBLIGNE"
                '  table.dg1.DataSource = Nothing
                table.dgvMain.Visible = False
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "DELETE_MP"
                delete_MP(data)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "DELETE_BY_IP"
                Delete_By_IP(data)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "REPONSE_LIGNE_MP"
                recoi_ligne_MP(data)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "REPONSE_LIGNE"
                recoi_ligne(data)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "Popup_Warning"
#If Not Demo Then
                ConErrAndSwErr(data)
#End If
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "REPONSE_LIGNEFIN"
                table.dgvMain.DataSource = Dv1
                table.dgvMain.Visible = True
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
                TimerWarningsOfTrouble_Tick(Nothing, Nothing)
            Case "COMMANDEOK"
                Libre = True
                If Bufemis.Items.Count > 0 Then Bufemis.Items.RemoveAt(0)
            Case "ACTUALISER"
                Actualiser()
            Case "pilehs"
                '         Dim f As New anomali
                '        f.Show()
                '       f.Label2.Text = trans(285) + s(1)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ADDSTOCKOK"
                If Remplissagemanuel.Visible = True Then
                    Remplissagemanuel.lbReportOFManualRefill.Items.Add(DateTime.Now.ToString() + " " + Trans(28) + ": " + s(1) + "    " + Trans(80))
                    Remplissagemanuel.lbReportOFManualRefill.SelectedIndex = Remplissagemanuel.lbReportOFManualRefill.Items.Count - 1
                End If
                If ViewByModele.Visible = True Then
                    If ViewByModele.lbManualHistory.Items.Count > 30 Then
                        ViewByModele.lbManualHistory.Items.RemoveAt(0)
                    End If
                    ViewByModele.lbManualHistory.Items.Add(Trans(28) + ": " + s(1) + "    " + Trans(80))
                    ViewByModele.lbManualHistory.SelectedIndex = ViewByModele.lbManualHistory.Items.Count - 1
                End If
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ETATIRF"
                If s(1) = "0" Then
                    PictureBox1.Image = My.Resources.irf48x28A_r
                Else
                    PictureBox1.Image = My.Resources.irf48x28_v
                End If
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "INTERFACEETAT"
                If s(1) = "0" Then
#If Demo Then
                    PictureBox2.Image = My.Resources.con48x28a_r
#Else
                    PictureBox2.Image = My.Resources.con48x28a_r
#End If
                Else
                    PictureBox2.Image = My.Resources.con48x28_v
                End If
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "CLEARGROUPE"
                basegroupe.cleargroupe()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "CLEARTAXE"
                basegroupe.cleartaxe()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "CLEARPRODUIT"
                baseproduit.clearproduit()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "CLEARMODELE"
                basemodele.clearmodele()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "CLEARHAPPY"
                basehappy.clearhappy()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "CLEARDLC"
                Dlc.Rows.Clear()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ADDGROUPE"
                basegroupe.addgroupe(s)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ADDTAXE"
                basegroupe.addtaxe(s)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ADDPRODUIT"
                baseproduit.addproduit(s)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ADDMODELE"
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
                basemodele.Addmodele(s)
            Case "ADDHAPPY"
                basehappy.addhappy(s)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "ADDDLC"
                basedlc.adddlc(s)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "REFILLDEBUT"
                journalrefill.dj.Visible = False
                journalrefill.jremp.Clear()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "REFILL"
                Dim ligne As String() = data.Split("$")
                For i As Integer = 0 To ligne.Length - 1
                    If ligne(i) <> "" Then journalrefill.traite(ligne(i))
                Next
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "REFILLFIN"
                journalrefill.dj.Visible = True
                journalrefill.traitefin()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "FINTERFACEDEBUT"
                Informationinterface.rtbInformationView.Clear()
                Informationinterface.ClearDic()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "FINTERFACE"
                Informationinterface.Traite(data)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "FINTERFACEFIN"
                Informationinterface.rtbInformationView.AppendText(vbCrLf)
                'informationinterface.UpdateChart()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "SYSTEMDEBUT"
                Informationsystem.tf.Clear()
                Informationsystem._systemTroubleTable.Clear()
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case "SYSTEM"
                'informationsystem.traite(data)
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
                Informationsystem.DataCollector(data)
            Case "SYSTEMFIN"
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
                Informationsystem.ShowSystemIssues()
            Case "MESSAGETELECOMMANDE"
                'acces login telecommande
                If Val(s(1)) = Accesucf Then
                    'cherche utilisateur
                    Dim k As Integer = Val(LireINI("utilisateur", "nb")), m As String
                    For i As Integer = 0 To k - 1
                        m = LireINI("utilisateur", i.ToString)
                        If LireINI(m, "telecommande") = s(2) Then
                            Me.Visible = True
                            ntf.Visible = False
                            login.utillogin = m
                            login.autorisation()
                        End If
                    Next
                End If
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
            Case Else
                ClientOfDriverIrf.SendData(Conv("LIGNEOK"))
        End Select
    End Sub

    Private Shared Function Conv(s As String) As String
        Dim i As Integer
        Conv = ""
        For i = 1 To s.Length
            Conv = Conv + Hex(Asc(s.Chars(i - 1)))
        Next
        Conv = Conv + "00"
    End Function
    Private Function GetHostIp(af As AddressFamily) As IPAddress
        Dim ip As IPAddress = IPAddress.None
        ip = Dns.GetHostEntry(Dns.GetHostName).AddressList.FirstOrDefault(Function(adrf) adrf.AddressFamily = af)
        Return IIf(ip Is Nothing, IPAddress.None, ip)
    End Function
    Public Sub Actualiser()
        Bufemis.Items.Clear()
        Maintable.Rows.Clear()
        Try
            If ClientOfDriverIrf.IsConnected = True Then
                ClientOfDriverIrf.SendData(Conv("REPONSE_NOM|" & My.Computer.Name & "|"))
            Else
                ClientOfDriverIrf.Connect(RemoteHost, Int32.Parse(RemotePort))
            End If
        Catch ex As Exception
            MessageBox.Show(Trans(200), Trans(81), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        End Try

    End Sub
    Private Shared Sub Delete_By_IP(strmess As String)
        Dim sDrValues() As String = strmess.Split("|")
        Dim key As Integer = 0
        key = Convert.ToInt32(sDrValues(1))
        Dim sortBack As String = Dv1.Sort
        Dv1.Sort = "nummodule"
        Dim i As Integer = Dv1.Find(key)
        If i <> -1 Then
            Dv1.Item(i).Delete()
        End If
        Dv1.Sort = sortBack
    End Sub
    Private Shared Sub delete_MP(strmess As String)
        Dim dr As DataRow
        Dim sDrValues() As String = strmess.Split("|")
        Dim nummodule As Integer = Convert.ToInt32(sDrValues(1))
        dr = DtMomentaryPickUp.Rows.Find(nummodule)
        If dr IsNot Nothing Then
            DtMomentaryPickUp.Rows.Remove(dr)
        End If
    End Sub
    Private Shared Sub recoi_ligne_MP(strmess As String)
        'MessageBox.Show(strmess)
        Dim dr As DataRow
        Dim sDrValues() As String = strmess.Split("|")
        Dim nummodule As Integer = Convert.ToInt32(sDrValues(2))
        Dim iCurrentIntValue As Integer = 0
        dr = DtMomentaryPickUp.Rows.Find(nummodule)
        'Dim shift As Integer = 2
        If dr Is Nothing Then
            dr = DtMomentaryPickUp.NewRow()
            dr("nummodule") = nummodule
            DtMomentaryPickUp.Rows.Add(dr)
            dr = DtMomentaryPickUp.Rows.Find(nummodule)
        End If
        For casier As Integer = 1 To MaxCountOfProducts
            If Int32.TryParse(sDrValues(casier * 2 + 1), iCurrentIntValue) Then
                dr("c" + casier.ToString()) = iCurrentIntValue
            Else
                dr("c" + casier.ToString()) = 0
            End If
            'shift += 1
            dr("dmp" + casier.ToString()) = sDrValues(casier * 2 + 2)
            iCurrentIntValue = 0
        Next

    End Sub
    Private Sub recoi_ligne(strmess As String)
        Dim ri1 As Integer
        Dim wRow As DataRow
        Try
            Ts = strmess.Split(Chr(124))
            Dim nummodule As Integer = Val(Trim(Ts(10)))
            ri1 = Rechmodule(nummodule)
            If ri1 = -1 Then
                wRow = Maintable.NewRow
                For i As Integer = 1 To Maintable.Columns.Count - 1
                    wRow(i) = Ts(i + 1)
                Next
                Maintable.Rows.Add(wRow)
            Else
                Try
                    Dv.Table.Rows(ri1).BeginEdit()
                    For i As Integer = 1 To Dv.Table.Columns.Count - 1
                        Dv.Table.Rows(ri1)(i) = Ts(i + 1)
                    Next

                    If (Ts(27) = "1") Or (Ts(28) = "1") Then
                        Dv.Table.Rows(ri1)("e") = "*"
                    Else
                        Dv.Table.Rows(ri1)("e") = ""
                    End If
                    Dv.Table.Rows(ri1).EndEdit()

                Catch ex As Exception

                End Try
            End If
        Catch ee As Exception
        End Try
    End Sub
    Public ReadOnly Property FieldAccess(nummodule As Integer, colonne As String) As Object
        Get
            Dim i As Integer = Rechmodule(nummodule)
            If i = -1 Then
                Return ""
            Else
                Return Dv(i)(colonne)
            End If
        End Get
        'Set(ByVal value As Object)
        '    Dim i As Integer = rechmodule(nummodule)
        '    If i <> -1 Then
        '        dv(i)(colonne) = value
        '    End If
        'End Set
    End Property

    Private Property BIsWarninigExist As Boolean = New Boolean

    ''' <summary>
    ''' Check if exist UCF number on MainTable
    ''' </summary>
    ''' <param name="nummodule">UCF number</param>
    ''' <returns>number of line if exist on MainTable, or -1 else</returns>
    ''' <remarks></remarks>
    Private Function PositionInTableByNummodule(nummodule As Integer) As Integer
        Dim iResult As Integer = -1
        For i As Integer = 0 To Maintable.Rows.Count - 1
            If Maintable.Rows(i)("nummodule") = CStr(nummodule) Then
                iResult = i
            End If
        Next
        Return iResult
    End Function
    Private Shared Function Rechmodule(nummod As Integer) As Integer

        For i As Integer = 0 To Dv.Table.Rows.Count - 1
            If Dv.Table.Rows(i)("nummodule") = CStr(nummod) Then
                Return i
            End If
        Next
        Return -1

        'dv.Sort = "nummodule"
        'rechmodule = dv.Find(CStr(nummod))
    End Function
    Public Function moduletochambre(nummodule As Integer) As String
        Dim i As Integer = Rechmodule(nummodule)
        Return Dv(i)("numchambre")
    End Function
    Public Function chambretomodule(numch As String) As String
        Dv.Sort = "numchambre"
        chambretomodule = Dv(Dv.Find(CStr(numch)))("nummodule")
    End Function
    Public Function rechdv1chamb(numch As Object) As Integer
        rechdv1chamb = -1
        Dv.Sort = "numchambre"
        Try
            rechdv1chamb = Dv.Find(CStr(numch))
        Catch ee As Exception
            rechdv1chamb = -1
        End Try

    End Function
    Private Sub Timerenvoireseau_Tick(sender As Object, e As EventArgs) Handles Timerenvoireseau.Tick
        Try
            If Libre = False Then Exit Sub
            If Bufemis.Items.Count > 0 Then
                ClientOfDriverIrf.SendData(Conv(Bufemis.Items(0)))
                Libre = False
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub spinning_Tick(sender As Object, e As EventArgs) Handles spinning.Tick
        SpinningProgress1.AutoIncrement = False
        SpinningProgress1.TransistionSegment = 0
    End Sub

#End Region

    Public Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Buttonnavy()
        tabMain.TabPages.Item(login).Select()
        login.initutil()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Buttonnavy()
        tabMain.TabPages.Item(login).Select()
        login.initutil()
    End Sub



    Private Sub m1_Click(sender As Object, e As EventArgs) Handles m1.Click
        Me.Visible = True
        ntf.Visible = False
        If configuration.checkBox15.Checked = True Then
            login.utillogin = configuration.cbappel.Text
            login.autorisation()
        End If
    End Sub

    Private Sub m2_Click(sender As Object, e As EventArgs) Handles m2.Click
        ntf.Visible = False
        End
    End Sub

    Private Sub ntf_MouseDown(sender As Object, e As MouseEventArgs) Handles ntf.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Visible = True
            ntf.Visible = False
            If configuration.checkBox15.Checked = True Then
                login.utillogin = configuration.cbappel.Text
                login.autorisation()
            End If
        End If

    End Sub
    Private Sub TimerWarningsOfTrouble_Tick(sender As Object, e As EventArgs) Handles TimerWarningsOfTrouble.Tick
        WinManager.MoveWIndow2TopofZOrder(TroubleMessageCaption)
        If tabMain.TabPages.Item(Warning).Selected() = True Then
            Exit Sub
        End If
        TimerWarningsOfTrouble.Stop()
        'Dim dvTrouble As DataView = New DataView()
        'dvTrouble = CType(table.dg1.DataSource, DataView)
        'MessageBox.Show("works")
        'Dim dtTrouble As DataTable = New DataTable()
        TroubleDescr.Clear()
        TroubleDescr.View = table.dgvMain.DataSource 'CType(table.dg1.DataSource, DataView) 'dvTrouble
        TroubleDescr.IsTrouble()
        If TroubleDescr.Table.Rows.Count <> 0 Then
            'MessageBox.Show("Trobles Found")
            'If Not tTroubleDescr.IsAdded Then
            '    TabControl1.TabPages.Add(Warning)
            '    tTroubleDescr.IsAdded = True
            'End If
            'PictureBoxWarning.Click += New System.EventHandler(AddressOf PictureBoxWarning_Click)
            'btnTroubles.BackColor = Color.DarkRed

            'AddHandler btnTroubles.Click, AddressOf btnTroubles_Click
            'btnTroubles.Visible = True
            btTroubleWarning.Visible = True
            'AddHandler btTroubleWarning.Click, AddressOf btTroubleWarning_Click
            'btnTroubles.BackColor = Color.Red
            'btnTroubles.Cursor = Cursors.Hand
            'PictureBoxWarning.Image = My.Resources.record24
            'AddHandler PictureBoxWarning.Click, AddressOf PictureBoxWarning_Click
            'PictureBoxWarning.Cursor = Cursors.Hand
        Else
            'PictureBoxWarning.Image = My.Resources.lecture24
            'RemoveHandler PictureBoxWarning.Click, AddressOf PictureBoxWarning_Click
            'PictureBoxWarning.Cursor = Cursors.Default

            btTroubleWarning.Visible = False
            'RemoveHandler btTroubleWarning.Click, AddressOf btTroubleWarning_Click
            'btnTroubles.Cursor = Cursors.Default
        End If
        TimerWarningsOfTrouble.Start()
        'MessageBox.Show("works")
    End Sub
    Private Sub btnTroubles_Click(sender As Object, e As EventArgs)
        'buttonnavy()
        Dim dtStartTime As DateTime = DateTime.Now()
        Dim dif As TimeSpan
        'TimerWarningsOfTrouble_Tick(Nothing, Nothing)
        'dif = dtStartTime - DateTime.Now
        'MessageBox.Show("Tick " + dif.Seconds.ToString())
        dtStartTime = DateTime.Now
        'Warning.InitWarning()
        dif = dtStartTime - DateTime.Now
        MessageBox.Show("Init Warning " + dif.Seconds.ToString())
        'TabControl1.TabPages.Item(Warning).Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        TimerWarningsOfTrouble_Tick(Nothing, Nothing)
        Warning.InitWarning()
        tabMain.TabPages.Item(Warning).Select()
        MessageBox.Show("Button 1 Click")
    End Sub

    Private Sub btTroubleWarning_Click(sender As Object, e As EventArgs) Handles btTroubleWarning.Click
        Buttonnavy()
        TimerWarningsOfTrouble_Tick(Nothing, Nothing)
        Warning.InitWarning()
        tabMain.TabPages.Item(Warning).Select()
        btTroubleWarning.BackColor = Color.Green
    End Sub
    '= False
    Private WithEvents _bgworkerErr As BackgroundWorker
    Private Sub ConErrAndSwErr(message As String)
        If Maintable.Rows.Count = 0 Then
            Return
        End If

        
        For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1
            Dim frm As Form = Application.OpenForms.Item(i)
            If frm.Text = Trans(144) Then
                frm.Close()
            End If
        Next
        _bgworkerErr = New BackgroundWorker()
        WinManager.CloseMessageBox(TroubleMessageCaption, _bgworkerErr)


        _bgworkerErr.RunWorkerAsync(message) ' + "|"  + countOfPostingFromChkOut.ToString())
        'End If
    End Sub
    Private Sub TestWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles _bgworkerErr.DoWork
        e.Result = e.Argument
    End Sub
    Private Sub TestWorker_DoWork(sender As Object, e As RunWorkerCompletedEventArgs) Handles _bgworkerErr.RunWorkerCompleted
        Dim arrCountofErrors() As String = e.Result.ToString().Split("|")
        Dim formatStr As String = Trans(20) + Environment.NewLine + Trans(208) + " -> {0}" + _
                Environment.NewLine + "Relays " + Trans(208) + " -> {1}" + _
                Environment.NewLine + Trans(436) + " -> {2}" + _
                Environment.NewLine + "Posting from 'Check Out' room -> {3}"
        MessageBox.Show(Me, DateTime.Now.ToString() + " " + String.Format(formatStr, arrCountofErrors(1), arrCountofErrors(2), arrCountofErrors(3), arrCountofErrors(4)), _
                        TroubleMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information, Nothing, 0)
        BIsWarninigExist = False
    End Sub
End Class
