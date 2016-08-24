Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Remplissagemanuel
    Inherits Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Remplissagemanuel))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dc = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.gbtnMinus = New Glass.GlassButton()
        Me.gbtnFull = New Glass.GlassButton()
        Me.GlassButton2 = New Glass.GlassButton()
        Me.lbReportOFManualRefill = New System.Windows.Forms.ListBox()
        Me.GlassButton1 = New Glass.GlassButton()
        Me.gbtnSendManualRefill = New Glass.GlassButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblpanelNewValues = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.dch = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.pnlTop.SuspendLayout()
        CType(Me.dc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        CType(Me.dch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.dc)
        Me.pnlTop.Location = New System.Drawing.Point(199, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(667, 93)
        Me.pnlTop.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(112, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(541, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dc
        '
        Me.dc.AllowUserToAddRows = False
        Me.dc.AllowUserToDeleteRows = False
        Me.dc.AllowUserToResizeColumns = False
        Me.dc.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dc.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.NullValue = " "
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dc.DefaultCellStyle = DataGridViewCellStyle3
        Me.dc.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dc.Location = New System.Drawing.Point(7, 28)
        Me.dc.Margin = New System.Windows.Forms.Padding(0)
        Me.dc.MultiSelect = False
        Me.dc.Name = "dc"
        Me.dc.ReadOnly = True
        Me.dc.RowHeadersVisible = False
        Me.dc.RowHeadersWidth = 31
        Me.dc.Size = New System.Drawing.Size(646, 61)
        Me.dc.TabIndex = 46
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 54
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "2"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 54
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "3"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 54
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "4"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 54
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "5"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 54
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "6"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 54
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "7"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 53
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "8"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 54
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "9"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 54
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "10"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 54
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "11"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 54
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "12"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 54
        '
        'pnlBottom
        '
        Me.pnlBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBottom.Controls.Add(Me.gbtnMinus)
        Me.pnlBottom.Controls.Add(Me.gbtnFull)
        Me.pnlBottom.Controls.Add(Me.GlassButton2)
        Me.pnlBottom.Controls.Add(Me.lbReportOFManualRefill)
        Me.pnlBottom.Controls.Add(Me.GlassButton1)
        Me.pnlBottom.Controls.Add(Me.gbtnSendManualRefill)
        Me.pnlBottom.Controls.Add(Me.Label1)
        Me.pnlBottom.Controls.Add(Me.tblpanelNewValues)
        Me.pnlBottom.Location = New System.Drawing.Point(199, 101)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(667, 317)
        Me.pnlBottom.TabIndex = 46
        '
        'gbtnMinus
        '
        Me.gbtnMinus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbtnMinus.AutoEllipsis = True
        Me.gbtnMinus.BackColor = System.Drawing.Color.Navy
        Me.gbtnMinus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnMinus.GlowColor = System.Drawing.Color.Blue
        Me.gbtnMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnMinus.Location = New System.Drawing.Point(386, -1)
        Me.gbtnMinus.Name = "gbtnMinus"
        Me.gbtnMinus.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnMinus.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnMinus.Size = New System.Drawing.Size(87, 23)
        Me.gbtnMinus.TabIndex = 52
        Me.gbtnMinus.Text = "Minus"
        Me.gbtnMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnMinus.UseCompatibleTextRendering = True
        '
        'gbtnFull
        '
        Me.gbtnFull.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbtnFull.AutoEllipsis = True
        Me.gbtnFull.BackColor = System.Drawing.Color.Navy
        Me.gbtnFull.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnFull.GlowColor = System.Drawing.Color.Blue
        Me.gbtnFull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnFull.Location = New System.Drawing.Point(478, -1)
        Me.gbtnFull.Name = "gbtnFull"
        Me.gbtnFull.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnFull.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnFull.Size = New System.Drawing.Size(87, 23)
        Me.gbtnFull.TabIndex = 51
        Me.gbtnFull.Text = "Full"
        Me.gbtnFull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnFull.UseCompatibleTextRendering = True
        '
        'GlassButton2
        '
        Me.GlassButton2.AutoEllipsis = True
        Me.GlassButton2.BackColor = System.Drawing.Color.Navy
        Me.GlassButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton2.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GlassButton2.Location = New System.Drawing.Point(8, 81)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton2.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton2.Size = New System.Drawing.Size(87, 23)
        Me.GlassButton2.TabIndex = 50
        Me.GlassButton2.Text = "Remplissage"
        Me.GlassButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton2.UseCompatibleTextRendering = True
        '
        'lbReportOFManualRefill
        '
        Me.lbReportOFManualRefill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbReportOFManualRefill.FormattingEnabled = True
        Me.lbReportOFManualRefill.HorizontalScrollbar = True
        Me.lbReportOFManualRefill.Location = New System.Drawing.Point(7, 108)
        Me.lbReportOFManualRefill.Name = "lbReportOFManualRefill"
        Me.lbReportOFManualRefill.ScrollAlwaysVisible = True
        Me.lbReportOFManualRefill.Size = New System.Drawing.Size(650, 199)
        Me.lbReportOFManualRefill.TabIndex = 49
        '
        'GlassButton1
        '
        Me.GlassButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GlassButton1.AutoEllipsis = True
        Me.GlassButton1.BackColor = System.Drawing.Color.Navy
        Me.GlassButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton1.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GlassButton1.Location = New System.Drawing.Point(571, -1)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton1.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton1.Size = New System.Drawing.Size(87, 23)
        Me.GlassButton1.TabIndex = 48
        Me.GlassButton1.Text = "Remplissage"
        Me.GlassButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton1.UseCompatibleTextRendering = True
        '
        'gbtnSendManualRefill
        '
        Me.gbtnSendManualRefill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbtnSendManualRefill.AutoEllipsis = True
        Me.gbtnSendManualRefill.BackColor = System.Drawing.Color.Navy
        Me.gbtnSendManualRefill.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnSendManualRefill.GlowColor = System.Drawing.Color.Red
        Me.gbtnSendManualRefill.Image = Global.HomiNet.My.Resources.Resources.envoi24
        Me.gbtnSendManualRefill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnSendManualRefill.Location = New System.Drawing.Point(512, 74)
        Me.gbtnSendManualRefill.Name = "gbtnSendManualRefill"
        Me.gbtnSendManualRefill.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnSendManualRefill.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnSendManualRefill.Size = New System.Drawing.Size(146, 30)
        Me.gbtnSendManualRefill.TabIndex = 47
        Me.gbtnSendManualRefill.Text = "Send"
        Me.gbtnSendManualRefill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnSendManualRefill.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 23)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tblpanelNewValues
        '
        Me.tblpanelNewValues.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblpanelNewValues.AutoScroll = True
        Me.tblpanelNewValues.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tblpanelNewValues.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblpanelNewValues.ColumnCount = 1
        Me.tblpanelNewValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblpanelNewValues.Location = New System.Drawing.Point(8, 23)
        Me.tblpanelNewValues.Name = "tblpanelNewValues"
        Me.tblpanelNewValues.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.tblpanelNewValues.RowCount = 1
        Me.tblpanelNewValues.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblpanelNewValues.Size = New System.Drawing.Size(647, 49)
        Me.tblpanelNewValues.TabIndex = 45
        '
        'pnlLeft
        '
        Me.pnlLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlLeft.Controls.Add(Me.dch)
        Me.pnlLeft.Controls.Add(Me.GroupBox1)
        Me.pnlLeft.Location = New System.Drawing.Point(0, 7)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(200, 411)
        Me.pnlLeft.TabIndex = 52
        '
        'dch
        '
        Me.dch.AllowUserToAddRows = False
        Me.dch.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dch.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dch.GridColor = System.Drawing.Color.DarkGray
        Me.dch.Location = New System.Drawing.Point(5, 76)
        Me.dch.MultiSelect = False
        Me.dch.Name = "dch"
        Me.dch.ReadOnly = True
        Me.dch.RowHeadersWidth = 10
        Me.dch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dch.Size = New System.Drawing.Size(190, 337)
        Me.dch.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 73)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(10, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(10, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Remplissagemanuel
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(871, 428)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Remplissagemanuel"
        Me.Text = "remplissage manuel"
        Me.pnlTop.ResumeLayout(False)
        CType(Me.dc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.dch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dc As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents gbtnFull As GlassButton
    Friend WithEvents GlassButton2 As GlassButton
    Friend WithEvents lbReportOFManualRefill As ListBox
    Friend WithEvents GlassButton1 As GlassButton
    Friend WithEvents gbtnSendManualRefill As GlassButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tblpanelNewValues As TableLayoutPanel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents dch As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents gbtnMinus As Glass.GlassButton
End Class
