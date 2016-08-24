Public Class utilisateur

    Private Sub utilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
        Dim i As Integer = LireINI("utilisateur", "nb")
        For j As Integer = 0 To i - 1
            LV1.Items.Add(LireINI("utilisateur", j.ToString))
        Next

        For j As Integer = 0 To ImageList1.Images.Count - 1
            miniature.Images.Add(ImageList1.Images(j))
            tete.Items.Add("", j)
        Next
    End Sub
    Public Sub initlangue()

        GlassButton1.Text = Trans(316)
        GlassButton2.Text = Trans(77)
        GlassButton3.Text = Trans(69)
        Label1.Text = Trans(72)
        Label2.Text = Trans(68)
        Label3.Text = Trans(39)
        Label4.Text = Trans(246)
        CheckBox1.Text = Trans(55)
        CheckBox2.Text = Trans(4)
        CheckBox3.Text = Trans(315)
        CheckBox4.Text = Trans(1)
        CheckBox5.Text = Trans(2)
        CheckBox6.Text = Trans(319)
        CheckBox7.Text = Trans(3)
        CheckBox8.Text = Trans(81)
        GroupBox1.Text = Trans(1)
        arriverdepart.Text = Trans(406)
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add(Trans(55))
        ComboBox1.Items.Add(Trans(4))
        ComboBox1.Items.Add(Trans(315))
        ComboBox1.Items.Add(Trans(1))
        ComboBox1.Items.Add(Trans(2))
        ComboBox1.Items.Add(Trans(319))
        ComboBox1.Items.Add(Trans(3))
        ComboBox1.Items.Add(Trans(81))
        ComboBox1.Items.Add(Trans(404))
        nomutil.Text = Trans(148)
        nomutil.Label1.Text = Trans(72)

    End Sub

    Private Sub GlassButton1_Click(sender As Object, e As EventArgs) Handles GlassButton1.Click
        LV1.Items.Add(Trans(1) + LV1.Items.Count.ToString)
        TextBox1.Text = LV1.Items(LV1.Items.Count - 1).Text
        GlassButton3_Click(Nothing, Nothing)
        GlassButton1.Enabled = False
        GlassButton2.Enabled = False
    End Sub

    Private Sub GlassButton2_Click(sender As Object, e As EventArgs) Handles GlassButton2.Click
        If LV1.SelectedItems(0).Index < 1 Then Exit Sub

        SupprimeINI(TextBox1.Text)
        SupprimeINI("utilisateur")

        EcrireINI("utilisateur", "nb", LV1.Items.Count)
        For i As Integer = 0 To LV1.Items.Count - 1
            EcrireINI("utilisateur", i.ToString, LV1.Items(i).Text)
        Next
        LV1.SelectedItems(0).Remove()

    End Sub

    Private Sub GlassButton3_Click(sender As Object, e As EventArgs) Handles GlassButton3.Click
        If TextBox1.Text = "" Then Exit Sub

        EcrireINI(TextBox1.Text, "nom", TextBox1.Text)
        EcrireINI(TextBox1.Text, "pass", TextBox2.Text)
        EcrireINI(TextBox1.Text, "telecommande", TextBox3.Text)
        EcrireINI(TextBox1.Text, "image", PictureBox1.Tag)
        EcrireINI(TextBox1.Text, "1", CheckBox1.Checked)
        EcrireINI(TextBox1.Text, "2", CheckBox2.Checked)
        EcrireINI(TextBox1.Text, "3", CheckBox3.Checked)
        EcrireINI(TextBox1.Text, "4", CheckBox4.Checked)
        EcrireINI(TextBox1.Text, "5", CheckBox5.Checked)
        EcrireINI(TextBox1.Text, "6", CheckBox6.Checked)
        EcrireINI(TextBox1.Text, "7", CheckBox7.Checked)
        EcrireINI(TextBox1.Text, "8", CheckBox8.Checked)
        EcrireINI(TextBox1.Text, "arrivedepart", arriverdepart.Checked)
        EcrireINI(TextBox1.Text, "lien", ComboBox1.SelectedIndex)

        SupprimeINI("utilisateur")

        EcrireINI("utilisateur", "nb", LV1.Items.Count)
        For i As Integer = 0 To LV1.Items.Count - 1
            EcrireINI("utilisateur", i.ToString, LV1.Items(i).Text)
        Next


        GlassButton1.Enabled = True
        GlassButton2.Enabled = True

    End Sub

    Private Sub LV1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV1.SelectedIndexChanged
        Try
            If LV1.SelectedItems.Count < 1 Then Exit Sub
            TextBox1.Text = LireINI(LV1.SelectedItems(0).Text, "nom")
            TextBox2.Text = LireINI(LV1.SelectedItems(0).Text, "pass")
            TextBox3.Text = LireINI(LV1.SelectedItems(0).Text, "telecommande")
            PictureBox1.Tag = LireINI(LV1.SelectedItems(0).Text, "image")
            CheckBox1.Checked = LireINI(LV1.SelectedItems(0).Text, "1")
            CheckBox2.Checked = LireINI(LV1.SelectedItems(0).Text, "2")
            CheckBox3.Checked = LireINI(LV1.SelectedItems(0).Text, "3")
            CheckBox4.Checked = LireINI(LV1.SelectedItems(0).Text, "4")
            CheckBox5.Checked = LireINI(LV1.SelectedItems(0).Text, "5")
            CheckBox6.Checked = LireINI(LV1.SelectedItems(0).Text, "6")
            CheckBox7.Checked = LireINI(LV1.SelectedItems(0).Text, "7")
            CheckBox8.Checked = LireINI(LV1.SelectedItems(0).Text, "8")
            arriverdepart.Checked = LireINI(LV1.SelectedItems(0).Text, "arrivedepart")
            ComboBox1.SelectedIndex = Val(LireINI(LV1.SelectedItems(0).Text, "lien"))
            Dim i As Integer = Val(PictureBox1.Tag)
            PictureBox1.Image = ImageList1.Images(i)

        Catch ex As Exception

        End Try
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        tete.Visible = True
    End Sub

    Private Sub tete_Click(sender As Object, e As EventArgs) Handles tete.Click
        tete.Visible = False
        PictureBox1.Tag = tete.SelectedItems(0).Index
        PictureBox1.Image = ImageList1.Images(tete.SelectedItems(0).Index)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GlassButton4_Click(sender As Object, e As EventArgs) Handles GlassButton4.Click
        nomutil.ShowDialog()
    End Sub
End Class