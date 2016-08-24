Public Class configuration

    Private Sub produit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
        Lireparam()
    End Sub
    Public Sub initlangue()
        tv.Nodes.Clear()
        tv.Nodes.Add(Trans(375))
        tv.Nodes.Add(Trans(212))
        tv.Nodes.Add(Trans(191))
        TabPage1.Text = ""
        TabPage2.Text = ""
        TabPage3.Text = ""
        TabPage4.Text = ""
        tc.ItemSize = New Size(1, 1)
        GlassButton3.Text = Trans(69)
        GlassButton4.Text = Trans(69)
        GlassButton5.Text = Trans(69)
        GlassButton6.Text = Trans(69)
        checkBox15.Text = Trans(101)
        checkBox16.Text = Trans(100)
        checkBox28.Text = Trans(28)
        checkBox29.Text = Trans(29)
        checkBox30.Text = Trans(31)
        checkBox31.Text = Trans(30)
        checkBox32.Text = Trans(44)
        checkBox33.Text = Trans(45)
        checkBox34.Text = Trans(32)
        checkBox35.Text = Trans(23)
        checkBox36.Text = Trans(26)
        checkBox37.Text = Trans(133)
        checkBox38.Text = Trans(134)
        checkBox39.Text = Trans(135)
        checkBox40.Text = Trans(136)
        checkBox41.Text = Trans(137)
        checkBox42.Text = Trans(138)
        checkBox43.Text = Trans(139)
        checkBox44.Text = Trans(178)
        checkBox45.Text = Trans(179)
        checkBox46.Text = Trans(180)
        checkBox47.Text = Trans(181)
        checkBox48.Text = Trans(127)
        checkBox50.Text = Trans(246)
        CheckBox51.Text = Trans(252)
        CheckBox52.Text = Trans(253)
        CheckBox53.Text = Trans(269)
        CheckBox54.Text = Trans(270)
        label10.Text = Trans(207)
        label11.Text = Trans(88)
        Label1.Text = Trans(392)
        lblLanguage.Text = Trans(102)
    End Sub

    Private Sub tv_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv.AfterSelect
        Try
            Select Case tv.SelectedNode.Text
                Case Trans(375)
                    tc.SelectedIndex = 0
                Case Trans(212)
                    tc.SelectedIndex = 1
                Case Trans(191)
                    tc.SelectedIndex = 2
                Case Trans(2)
                    tc.SelectedIndex = 3
            End Select

        Catch ex As Exception

        End Try

    End Sub

    Private Sub GlassButton3_Click(sender As Object, e As EventArgs) Handles GlassButton3.Click, GlassButton5.Click, GlassButton4.Click, GlassButton6.Click
        EcrireINI("langage", "langue", comboBox2.Text)
        EcrireINI("Parametre", "maximise", checkBox16.Checked)
        EcrireINI("Parametre", "appel", checkBox15.Checked)
        EcrireINI("Parametre", "appelnom", cbappel.Text)
        EcrireINI("Parametre", "anomalie", CheckBox53.Checked)
        EcrireINI("Parametre", "information", CheckBox54.Checked)
        EcrireINI("Parametre", "host", textBox11.Text)
        EcrireINI("Parametre", "port", textBox12.Text)
        EcrireINI("Parametre", "hotel", TextBox2.Text)
        EcrireINI("Parametre", "ExtView", chkbExtReport.Checked)
        RemotePort = textBox12.Text
        'RemoteHost = textBox11.Text

#If Demo Then
        RemoteHost = Net.Dns.GetHostName()
        textbox11.Text = RemoteHost
#Else
        RemoteHost = textBox11.Text
#End If

        EcrireINI("Parametre", "1", checkBox28.Checked)
        EcrireINI("Parametre", "2", checkBox29.Checked)
        EcrireINI("Parametre", "3", checkBox30.Checked)
        EcrireINI("Parametre", "4", checkBox31.Checked)
        EcrireINI("Parametre", "5", checkBox32.Checked)
        EcrireINI("Parametre", "6", checkBox33.Checked)
        EcrireINI("Parametre", "7", checkBox34.Checked)
        EcrireINI("Parametre", "8", checkBox35.Checked)
        EcrireINI("Parametre", "9", checkBox36.Checked)
        EcrireINI("Parametre", "10", checkBox37.Checked)
        EcrireINI("Parametre", "11", checkBox38.Checked)
        EcrireINI("Parametre", "12", checkBox39.Checked)
        EcrireINI("Parametre", "13", checkBox40.Checked)
        EcrireINI("Parametre", "14", checkBox41.Checked)
        EcrireINI("Parametre", "15", checkBox42.Checked)
        EcrireINI("Parametre", "16", checkBox43.Checked)
        EcrireINI("Parametre", "17", checkBox44.Checked)
        EcrireINI("Parametre", "18", checkBox45.Checked)
        EcrireINI("Parametre", "19", checkBox46.Checked)
        EcrireINI("Parametre", "20", checkBox47.Checked)
        EcrireINI("Parametre", "21", checkBox48.Checked)
        EcrireINI("Parametre", "22", checkBox50.Checked)
        EcrireINI("Parametre", "23", CheckBox51.Checked)
        EcrireINI("Parametre", "24", CheckBox52.Checked)
        EcrireINI("Parametre", "autologin", TextBox1.Text)

        Lireparam()
    End Sub
    Public Sub Lireparam()
        nomhotel = LireINI("Parametre", "hotel")
        TextBox2.Text = nomhotel
        accesucf = Val(LireINI("Parametre", "autologin"))
        'maximise
        checkBox16.Checked = LireINI("Parametre", "maximise")
        chkbExtReport.Checked = LireINIBool("Parametre", "ExtView")
        If checkBox16.Checked = True Then
            MAINFORM.WindowState = FormWindowState.Maximized
        Else
            MAINFORM.WindowState = FormWindowState.Normal
            MAINFORM.StartPosition = 1
            MAINFORM.Refresh()
        End If

        Dim i As Integer = LireINI("utilisateur", "nb")
        For j As Integer = 0 To i - 1
            cbappel.Items.Add(LireINI("utilisateur", j.ToString))
        Next

        checkBox15.Checked = LireINI("Parametre", "appel")
        cbappel.Text = LireINI("Parametre", "appelnom")

        CheckBox53.Checked = LireINIBool("Parametre", "anomalie")

        CheckBox54.Checked = LireINIBool("Parametre", "information")

        textBox11.Text = LireINI("Parametre", "host")
        textBox12.Text = LireINI("Parametre", "port")
        RemotePort = textBox12.Text

#If Demo Then
        RemoteHost = Net.Dns.GetHostName()
        textbox11.Text = RemoteHost
#Else
        RemoteHost = textBox11.Text
#End If


        checkBox28.Checked = LireINIBool("Parametre", "1")
        checkBox29.Checked = LireINIBool("Parametre", "2")
        checkBox30.Checked = LireINIBool("Parametre", "3")
        checkBox31.Checked = LireINIBool("Parametre", "4")
        checkBox32.Checked = LireINIBool("Parametre", "5")
        checkBox33.Checked = LireINIBool("Parametre", "6")
        checkBox34.Checked = LireINIBool("Parametre", "7")
        checkBox35.Checked = LireINIBool("Parametre", "8")
        checkBox36.Checked = LireINIBool("Parametre", "9")
        checkBox37.Checked = LireINIBool("Parametre", "10")
        checkBox38.Checked = LireINIBool("Parametre", "11")
        checkBox39.Checked = LireINIBool("Parametre", "12")
        checkBox40.Checked = LireINIBool("Parametre", "13")
        checkBox41.Checked = LireINIBool("Parametre", "14")
        checkBox42.Checked = LireINIBool("Parametre", "15")
        checkBox43.Checked = LireINIBool("Parametre", "16")
        checkBox44.Checked = LireINIBool("Parametre", "17")
        checkBox45.Checked = LireINIBool("Parametre", "18")
        checkBox46.Checked = LireINIBool("Parametre", "19")
        checkBox47.Checked = LireINIBool("Parametre", "20")
        checkBox48.Checked = LireINIBool("Parametre", "21")
        checkBox50.Checked = LireINIBool("Parametre", "22")
        CheckBox51.Checked = LireINIBool("Parametre", "23")
        CheckBox52.Checked = LireINIBool("Parametre", "24")
        TextBox1.Text = LireINI("Parametre", "autologin")


        comboBox2.Items.Clear()
        For i0 As Integer = 1 To Val(LireINIL("langage", "nblangage"))
            comboBox2.Items.Add(LireINIL("langage", CStr(i0)))
        Next
        comboBox2.Text = LireINI("langage", "langue")
        MAINFORM.langue()
        ajouterarticle.initlangue()
        basedlc.initlangue()
        basegroupe.initlangue()
        basehappy.initlangue()
        basemodele.initlangue()
        baseproduit.initlangue()
        bases.initlangue()
        Me.initlangue()
        edition.initlangue()
        facture.initlangue()
        Imprimer.initlangue()
        information.initlangue()
        login.initlangue()
        remplissage.initlangue()
        resultat.initlangue()
        rXZ.initlangue()
        table.initlangue()
        utilisateur.initlangue()
        Rfacture.Initlangue()
        journalrefill.initlangue()
        Remplissagemanuel.initlangue()
        remplissage.initlangue()

        'colonne visible
        table.dgvMain.Columns("numchambre").Visible = checkBox28.Checked
        table.dgvMain.Columns("etatporte").Visible = checkBox29.Checked
        table.dgvMain.Columns("serrure").Visible = checkBox30.Checked
        table.dgvMain.Columns("etattemp").Visible = checkBox31.Checked
        table.dgvMain.Columns("check").Visible = checkBox32.Checked
        table.dgvMain.Columns("ouverture").Visible = checkBox33.Checked
        table.dgvMain.Columns("status").Visible = checkBox34.Checked
        table.dgvMain.Columns("nummodule").Visible = checkBox35.Checked
        table.dgvMain.Columns("test").Visible = checkBox36.Checked
        table.dgvMain.Columns("dateremplissage").Visible = checkBox37.Checked
        table.dgvMain.Columns("datecheckin").Visible = checkBox38.Checked
        table.dgvMain.Columns("datecheckout").Visible = checkBox39.Checked
        table.dgvMain.Columns("datelock").Visible = checkBox40.Checked
        table.dgvMain.Columns("dateunlock").Visible = checkBox41.Checked
        table.dgvMain.Columns("datemaintenance").Visible = checkBox42.Checked
        table.dgvMain.Columns("dateanomalie").Visible = checkBox43.Checked
        table.dgvMain.Columns("libre1").Visible = checkBox44.Checked
        table.dgvMain.Columns("libre2").Visible = checkBox45.Checked
        table.dgvMain.Columns("libre3").Visible = checkBox46.Checked
        table.dgvMain.Columns("libre4").Visible = checkBox47.Checked
        table.dgvMain.Columns("zone").Visible = checkBox48.Checked
        table.dgvMain.Columns("numtelecommande").Visible = checkBox50.Checked
        table.dgvMain.Columns("dateouvert").Visible = CheckBox51.Checked
        table.dgvMain.Columns("datefermer").Visible = CheckBox52.Checked
    End Sub

    Private Sub checkBox15_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox15.CheckedChanged
        cbappel.Items.Clear()
        Dim i As Integer = LireINI("utilisateur", "nb")
        For j As Integer = 0 To i - 1
            cbappel.Items.Add(LireINI("utilisateur", j.ToString))
        Next

    End Sub

    Private Sub chkbExtReport_CheckedChanged(sender As Object, e As EventArgs) Handles chkbExtReport.CheckedChanged
        EcrireINI("Parametre", "ExtView", chkbExtReport.Checked)
        Informationinterface.SetExtPanelView(chkbExtReport.Checked)
        remplissage.SetExtPanelView(chkbExtReport.Checked)
    End Sub

    Private Sub GlassButton2_Click(sender As Object, e As EventArgs) Handles GlassButton2.Click

    End Sub
End Class