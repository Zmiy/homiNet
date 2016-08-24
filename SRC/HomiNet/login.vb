Imports System.Threading

Public Class login
    Public utillogin As String = ""
    Dim pass As String

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initlangue()
        initutil()

    End Sub
    Public Sub initlangue()

        Label3.Text = Trans(11)
        Label1.Text = Trans(68)

    End Sub

    Public Sub initutil()
        lv.LargeImageList = utilisateur.ImageList1
        lv.Items.Clear()
        lv.Update()
        Dim j As Integer = LireINI("utilisateur", "nb"), u As String, im As Integer
        For i As Integer = 0 To j - 1
            u = LireINI("utilisateur", i.ToString)
            im = Val(LireINI(u, "image"))
            lv.Items.Add(u, im)
            lv.Update()
        Next

    End Sub

    Private Sub lv_Click(sender As Object, e As EventArgs) Handles lv.Click
        utillogin = lv.SelectedItems(0).Text
        pass = LireINI(utillogin, "pass")
        If pass = "" Then
            autorisation()
        Else
            TextBox1.SelectAll()
            TextBox1.Focus()
        End If

    End Sub
    Public Sub autorisation()
        Try
            If LireINI(utillogin, "arrivedepart") = True Then
                log.nom = utillogin
                log.tel = LireINI(utillogin, "telecommande")
                If log.ShowDialog() <> DialogResult.OK Then
                    Exit Sub

                End If
            End If
            Dim im As Integer = Val(LireINI(utillogin, "image"))
            MAINFORM.PictureBox3.Image = utilisateur.ImageList1.Images(im)
            MAINFORM.Label4.Text = utillogin
            MAINFORM.gbtnRemplissage.Enabled = LireINI(utillogin, "1")
            MAINFORM.block.Enabled = LireINI(utillogin, "2")
            MAINFORM.bbase.Enabled = LireINI(utillogin, "3")
            MAINFORM.butilisateur.Enabled = LireINI(utillogin, "4")
            MAINFORM.bedition.Enabled = LireINI(utillogin, "5")
            MAINFORM.bresultat.Enabled = LireINI(utillogin, "6")
            MAINFORM.bconfiguration.Enabled = LireINI(utillogin, "7")
            MAINFORM.banomalie.Enabled = LireINI(utillogin, "8")
            'TODO: add button Error to Parameter page

            Dim s As String = LireINI(utillogin, "lien")
            Select Case s
                Case "0"
                    MAINFORM.SpinningProgress1.AutoIncrement = True
                    Do
                        Application.DoEvents()
                        Thread.Sleep(20)
                    Loop Until MAINFORM.SpinningProgress1.AutoIncrement = False
                    MAINFORM.RemplissagePerformClickAction()
                Case "1"
                    MAINFORM.block_Click(Nothing, Nothing)
                Case "2"
                    MAINFORM.bbase_Click(Nothing, Nothing)
                Case "3"
                    MAINFORM.butilisateur_Click(Nothing, Nothing)
                Case "4"
                    MAINFORM.bedition_Click(Nothing, Nothing)
                Case "5"
                    MAINFORM.bresultat_Click(Nothing, Nothing)
                Case "6"
                    MAINFORM.bconfiguration_Click(Nothing, Nothing)
                Case "7"
                    MAINFORM.banomalie_Click(Nothing, Nothing)
                Case "8"
                    MAINFORM.PictureBox3_Click(Nothing, Nothing)
            End Select

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox1.Text = pass Then
                TextBox1.Text = ""
                autorisation()

            End If
        End If
    End Sub


    Private Sub AlphaGradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles AlphaGradientPanel2.Paint

    End Sub
End Class