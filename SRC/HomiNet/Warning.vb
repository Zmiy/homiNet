Imports System.Drawing.Printing
Imports System.Threading

Public Class Warning
    Dim dvWarning As New DataView()
    Private Sub Warning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'dvWarning = MAINFORM.tTroubleDescr.View

        'dvWarning.Sort = "numchambre"
        'dgvWarning.DataSource = dvWarning 'MAINFORM.tTroubleDescr.Table
        dataGridViewInitData()
        If dgvWarning.Columns.Count <> 0 Then
            dgvWarning.Columns("numchambre").HeaderText = Trans(28)
            dgvWarning.Columns("nummodule").HeaderText = Trans(32)
        End If

        gbWarnigPrint.Text = Trans(141)
        chkbLandscape.Text = Trans(385)
        imprimante.Items.Clear()
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            imprimante.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
        Next
        Try
            imprimante.Text = LireINI("Warning", "remplissage")
            chkbLandscape.Checked = LireIniBoolSmart("Warning", "remplissagepaysage", True)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dataGridViewInitData()
        dgvWarning.DataSource = Nothing
        dgvWarning.Refresh()
        dvWarning.Table = MAINFORM.TroubleDescr.View.Table.Copy()
        dvWarning.Sort = "numchambre"
        lblTroubleCount.Text = Trans(48) + " " + MAINFORM.TroubleDescr.View.ToTable().Rows.Count.ToString()
        dgvWarning.DataSource = dvWarning
    End Sub
    Private Sub dataGridViewinitView()
        For i As Integer = 0 To dgvWarning.Columns.Count - 1
            dgvWarning.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        dgvWarning.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders)
    End Sub
    Public Sub InitWarning()
        dataGridViewInitData()
        dataGridViewinitView()
        '        dgvWarning.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders)

    End Sub
    Private Sub gbWarnigPrint_Click(sender As Object, e As EventArgs) Handles gbWarnigPrint.Click
        Dim imp As New Imprimer()
        imp.imprimante = imprimante.Text
        imp.imprime = "warning"
        imp.paysage = chkbLandscape.Checked
        'Dim tmpstr As String = String.Empty

        Dim dv As DataView = MAINFORM.TroubleDescr.ViewForPrint()
        dv.Sort = "numchambre"
        imp.DvForPrint = dv.Table.Copy()
        'For i As Integer = 0 To imp.TableRemp.RowCount - 1
        '    tmpstr = imp.TableRemp.Rows(i).Cells(2).Value
        '    imp.TableRemp.Rows(i).Cells(2).Value = tmpstr.Replace(Environment.NewLine, " ").Trim()
        'Next
        'imp.TableRemp.DataSource = dv 'MAINFORM.tTroubleDescr.ViewForPrint()
        'imp.TableRempDataSource = dv
        imp.go()
        Do
            Application.DoEvents()
            Thread.Sleep(10)
        Loop Until imp.pret = True

        'MAINFORM.SpinningProgress1.AutoIncrement = True
        'Do
        '    Application.DoEvents()
        '    System.Threading.Thread.Sleep(20)
        'Loop Until MAINFORM.SpinningProgress1.AutoIncrement = False
        'imp.go()
        'imp._dgvTableRemp = Nothing
        dgvWarning.Refresh()
    End Sub

    Private Sub imprimante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles imprimante.SelectedIndexChanged
        EcrireINI("Warning", "remplissage", imprimante.Text)
    End Sub

    Private Sub chkbLandscape_CheckedChanged(sender As Object, e As EventArgs) Handles chkbLandscape.CheckedChanged
        EcrireINI("Warning", "remplissagepaysage", chkbLandscape.Checked.ToString())
    End Sub

    Private Sub Warning_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        MessageBox.Show("FormisDeactivate")
    End Sub

    Private Sub Warning_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MessageBox.Show("form is closed")
    End Sub
    Private Sub Warning_UnLoad(sender As Object, e As EventArgs)
        MessageBox.Show("Lost Focus")
    End Sub
End Class