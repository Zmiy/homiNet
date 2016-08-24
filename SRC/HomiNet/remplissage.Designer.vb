Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Remplissage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Remplissage))
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.TOTALRemp = New System.Windows.Forms.DataGridView()
        Me.DGRemp = New System.Windows.Forms.DataGridView()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlExtention = New System.Windows.Forms.Panel()
        Me.gbExtention = New System.Windows.Forms.GroupBox()
        Me.cmbExtension = New System.Windows.Forms.ComboBox()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.n1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.imprimante = New System.Windows.Forms.ComboBox()
        Me.gbtnPrint = New Glass.GlassButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTo = New System.Windows.Forms.ComboBox()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.rbtnRoomN = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nbc = New System.Windows.Forms.NumericUpDown()
        Me.rbtnAll = New System.Windows.Forms.RadioButton()
        Me.rbtnLimitTo = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.chkbVacantOnly = New System.Windows.Forms.CheckBox()
        Me.chkbMomPickUp = New System.Windows.Forms.CheckBox()
        Me.rbtnTotalStock = New System.Windows.Forms.RadioButton()
        Me.gbtnCalcOutOfDays = New Glass.GlassButton()
        Me.np = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtnOutOfday = New System.Windows.Forms.RadioButton()
        Me.rbtnAlarm2 = New System.Windows.Forms.RadioButton()
        Me.rbtnAlarm1 = New System.Windows.Forms.RadioButton()
        Me.pnlRight.SuspendLayout()
        CType(Me.TOTALRemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExtention.SuspendLayout()
        Me.gbExtention.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.n1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nbc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.np, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRight
        '
        Me.pnlRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRight.Controls.Add(Me.TOTALRemp)
        Me.pnlRight.Controls.Add(Me.DGRemp)
        Me.pnlRight.Controls.Add(Me.lblFooter)
        Me.pnlRight.Controls.Add(Me.lblHeader)
        Me.pnlRight.Location = New System.Drawing.Point(303, 3)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(443, 475)
        Me.pnlRight.TabIndex = 44
        '
        'TOTALRemp
        '
        Me.TOTALRemp.AllowUserToAddRows = False
        Me.TOTALRemp.AllowUserToDeleteRows = False
        Me.TOTALRemp.AllowUserToResizeColumns = False
        Me.TOTALRemp.AllowUserToResizeRows = False
        Me.TOTALRemp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TOTALRemp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TOTALRemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TOTALRemp.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TOTALRemp.DefaultCellStyle = DataGridViewCellStyle2
        Me.TOTALRemp.Location = New System.Drawing.Point(3, 417)
        Me.TOTALRemp.Name = "TOTALRemp"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TOTALRemp.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TOTALRemp.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TOTALRemp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TOTALRemp.Size = New System.Drawing.Size(437, 24)
        Me.TOTALRemp.TabIndex = 11
        '
        'DGRemp
        '
        Me.DGRemp.AllowUserToAddRows = False
        Me.DGRemp.AllowUserToDeleteRows = False
        Me.DGRemp.AllowUserToResizeColumns = False
        Me.DGRemp.AllowUserToResizeRows = False
        Me.DGRemp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGRemp.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRemp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGRemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGRemp.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGRemp.Location = New System.Drawing.Point(3, 36)
        Me.DGRemp.Name = "DGRemp"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRemp.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGRemp.Size = New System.Drawing.Size(437, 375)
        Me.DGRemp.TabIndex = 10
        '
        'lblFooter
        '
        Me.lblFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFooter.BackColor = System.Drawing.Color.Navy
        Me.lblFooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFooter.ForeColor = System.Drawing.Color.White
        Me.lblFooter.Location = New System.Drawing.Point(4, 444)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(436, 22)
        Me.lblFooter.TabIndex = 9
        Me.lblFooter.Text = "Label2"
        Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHeader
        '
        Me.lblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeader.BackColor = System.Drawing.Color.Navy
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 8)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(437, 25)
        Me.lblHeader.TabIndex = 8
        Me.lblHeader.Text = "Label1"
        '
        'pnlExtention
        '
        Me.pnlExtention.Controls.Add(Me.gbExtention)
        Me.pnlExtention.Location = New System.Drawing.Point(2, 4)
        Me.pnlExtention.Name = "pnlExtention"
        Me.pnlExtention.Size = New System.Drawing.Size(295, 49)
        Me.pnlExtention.TabIndex = 56
        Me.pnlExtention.Visible = False
        '
        'gbExtention
        '
        Me.gbExtention.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbExtention.Controls.Add(Me.cmbExtension)
        Me.gbExtention.Location = New System.Drawing.Point(5, 3)
        Me.gbExtention.Name = "gbExtention"
        Me.gbExtention.Size = New System.Drawing.Size(285, 43)
        Me.gbExtention.TabIndex = 53
        Me.gbExtention.TabStop = False
        Me.gbExtention.Text = "Extention Select"
        '
        'cmbExtension
        '
        Me.cmbExtension.FormattingEnabled = True
        Me.cmbExtension.Location = New System.Drawing.Point(8, 13)
        Me.cmbExtension.Name = "cmbExtension"
        Me.cmbExtension.Size = New System.Drawing.Size(271, 21)
        Me.cmbExtension.TabIndex = 0
        '
        'pnlLeft
        '
        Me.pnlLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlLeft.Controls.Add(Me.GroupBox3)
        Me.pnlLeft.Controls.Add(Me.CheckBox1)
        Me.pnlLeft.Controls.Add(Me.imprimante)
        Me.pnlLeft.Controls.Add(Me.gbtnPrint)
        Me.pnlLeft.Controls.Add(Me.GroupBox2)
        Me.pnlLeft.Controls.Add(Me.GroupBox1)
        Me.pnlLeft.Location = New System.Drawing.Point(2, 59)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(295, 419)
        Me.pnlLeft.TabIndex = 57
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.n1)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 283)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(285, 46)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'n1
        '
        Me.n1.Location = New System.Drawing.Point(49, 19)
        Me.n1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.n1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(64, 20)
        Me.n1.TabIndex = 42
        Me.n1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(5, 396)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 48
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'imprimante
        '
        Me.imprimante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imprimante.FormattingEnabled = True
        Me.imprimante.Location = New System.Drawing.Point(5, 370)
        Me.imprimante.Name = "imprimante"
        Me.imprimante.Size = New System.Drawing.Size(285, 21)
        Me.imprimante.TabIndex = 47
        '
        'gbtnPrint
        '
        Me.gbtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnPrint.AutoEllipsis = True
        Me.gbtnPrint.BackColor = System.Drawing.Color.Navy
        Me.gbtnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnPrint.GlowColor = System.Drawing.Color.Blue
        Me.gbtnPrint.Image = Global.HomiNet.My.Resources.Resources.imp24
        Me.gbtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnPrint.Location = New System.Drawing.Point(5, 333)
        Me.gbtnPrint.Name = "gbtnPrint"
        Me.gbtnPrint.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnPrint.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnPrint.Size = New System.Drawing.Size(285, 33)
        Me.gbtnPrint.TabIndex = 46
        Me.gbtnPrint.Text = "Remplissage"
        Me.gbtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnPrint.UseCompatibleTextRendering = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTo)
        Me.GroupBox2.Controls.Add(Me.cmbFrom)
        Me.GroupBox2.Controls.Add(Me.rbtnRoomN)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.nbc)
        Me.GroupBox2.Controls.Add(Me.rbtnAll)
        Me.GroupBox2.Controls.Add(Me.rbtnLimitTo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 122)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'cmbTo
        '
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(216, 96)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(64, 21)
        Me.cmbTo.TabIndex = 45
        '
        'cmbFrom
        '
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(124, 96)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(64, 21)
        Me.cmbFrom.TabIndex = 42
        '
        'rbtnRoomN
        '
        Me.rbtnRoomN.AutoSize = True
        Me.rbtnRoomN.Location = New System.Drawing.Point(10, 96)
        Me.rbtnRoomN.Name = "rbtnRoomN"
        Me.rbtnRoomN.Size = New System.Drawing.Size(64, 17)
        Me.rbtnRoomN.TabIndex = 44
        Me.rbtnRoomN.Text = "Room N"
        Me.rbtnRoomN.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(273, 9)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "___________________________________________________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 9)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "___________________________________________________________________"
        '
        'nbc
        '
        Me.nbc.Location = New System.Drawing.Point(178, 53)
        Me.nbc.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nbc.Name = "nbc"
        Me.nbc.Size = New System.Drawing.Size(86, 20)
        Me.nbc.TabIndex = 2
        '
        'rbtnAll
        '
        Me.rbtnAll.AutoSize = True
        Me.rbtnAll.Checked = True
        Me.rbtnAll.Location = New System.Drawing.Point(10, 20)
        Me.rbtnAll.Name = "rbtnAll"
        Me.rbtnAll.Size = New System.Drawing.Size(36, 17)
        Me.rbtnAll.TabIndex = 1
        Me.rbtnAll.TabStop = True
        Me.rbtnAll.Text = "All"
        Me.rbtnAll.UseVisualStyleBackColor = True
        '
        'rbtnLimitTo
        '
        Me.rbtnLimitTo.AutoSize = True
        Me.rbtnLimitTo.Location = New System.Drawing.Point(10, 54)
        Me.rbtnLimitTo.Name = "rbtnLimitTo"
        Me.rbtnLimitTo.Size = New System.Drawing.Size(62, 17)
        Me.rbtnLimitTo.TabIndex = 0
        Me.rbtnLimitTo.Text = "Limit To"
        Me.rbtnLimitTo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "to"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.chkbVacantOnly)
        Me.GroupBox1.Controls.Add(Me.chkbMomPickUp)
        Me.GroupBox1.Controls.Add(Me.rbtnTotalStock)
        Me.GroupBox1.Controls.Add(Me.gbtnCalcOutOfDays)
        Me.GroupBox1.Controls.Add(Me.np)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rbtnOutOfday)
        Me.GroupBox1.Controls.Add(Me.rbtnAlarm2)
        Me.GroupBox1.Controls.Add(Me.rbtnAlarm1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 145)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(8, 57)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(60, 21)
        Me.btnRefresh.TabIndex = 49
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'chkbVacantOnly
        '
        Me.chkbVacantOnly.AutoSize = True
        Me.chkbVacantOnly.Location = New System.Drawing.Point(156, 39)
        Me.chkbVacantOnly.Name = "chkbVacantOnly"
        Me.chkbVacantOnly.Size = New System.Drawing.Size(122, 17)
        Me.chkbVacantOnly.TabIndex = 48
        Me.chkbVacantOnly.Text = "Only Vacant's Room"
        Me.chkbVacantOnly.UseVisualStyleBackColor = True
        '
        'chkbMomPickUp
        '
        Me.chkbMomPickUp.AutoSize = True
        Me.chkbMomPickUp.Location = New System.Drawing.Point(156, 16)
        Me.chkbMomPickUp.Name = "chkbMomPickUp"
        Me.chkbMomPickUp.Size = New System.Drawing.Size(67, 17)
        Me.chkbMomPickUp.TabIndex = 47
        Me.chkbMomPickUp.Text = "With MP"
        Me.chkbMomPickUp.UseVisualStyleBackColor = True
        '
        'rbtnTotalStock
        '
        Me.rbtnTotalStock.AutoSize = True
        Me.rbtnTotalStock.Location = New System.Drawing.Point(10, 116)
        Me.rbtnTotalStock.Name = "rbtnTotalStock"
        Me.rbtnTotalStock.Size = New System.Drawing.Size(49, 17)
        Me.rbtnTotalStock.TabIndex = 44
        Me.rbtnTotalStock.TabStop = True
        Me.rbtnTotalStock.Text = "Total"
        Me.rbtnTotalStock.UseVisualStyleBackColor = True
        '
        'gbtnCalcOutOfDays
        '
        Me.gbtnCalcOutOfDays.AutoEllipsis = True
        Me.gbtnCalcOutOfDays.BackColor = System.Drawing.Color.Navy
        Me.gbtnCalcOutOfDays.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnCalcOutOfDays.GlowColor = System.Drawing.Color.Blue
        Me.gbtnCalcOutOfDays.Image = Global.HomiNet.My.Resources.Resources.autua16
        Me.gbtnCalcOutOfDays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnCalcOutOfDays.Location = New System.Drawing.Point(239, 88)
        Me.gbtnCalcOutOfDays.Name = "gbtnCalcOutOfDays"
        Me.gbtnCalcOutOfDays.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnCalcOutOfDays.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnCalcOutOfDays.Size = New System.Drawing.Size(25, 23)
        Me.gbtnCalcOutOfDays.TabIndex = 46
        Me.gbtnCalcOutOfDays.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnCalcOutOfDays.UseCompatibleTextRendering = True
        '
        'np
        '
        Me.np.Location = New System.Drawing.Point(166, 90)
        Me.np.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.np.Name = "np"
        Me.np.Size = New System.Drawing.Size(67, 20)
        Me.np.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(273, 9)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "___________________________________________________________________"
        '
        'rbtnOutOfday
        '
        Me.rbtnOutOfday.AutoSize = True
        Me.rbtnOutOfday.Location = New System.Drawing.Point(10, 88)
        Me.rbtnOutOfday.Name = "rbtnOutOfday"
        Me.rbtnOutOfday.Size = New System.Drawing.Size(83, 17)
        Me.rbtnOutOfday.TabIndex = 2
        Me.rbtnOutOfday.Text = "Out Of Days"
        Me.rbtnOutOfday.UseVisualStyleBackColor = True
        '
        'rbtnAlarm2
        '
        Me.rbtnAlarm2.AutoSize = True
        Me.rbtnAlarm2.Location = New System.Drawing.Point(10, 39)
        Me.rbtnAlarm2.Name = "rbtnAlarm2"
        Me.rbtnAlarm2.Size = New System.Drawing.Size(60, 17)
        Me.rbtnAlarm2.TabIndex = 1
        Me.rbtnAlarm2.Text = "Alarm 2"
        Me.rbtnAlarm2.UseVisualStyleBackColor = True
        '
        'rbtnAlarm1
        '
        Me.rbtnAlarm1.AutoSize = True
        Me.rbtnAlarm1.Checked = True
        Me.rbtnAlarm1.Location = New System.Drawing.Point(10, 16)
        Me.rbtnAlarm1.Name = "rbtnAlarm1"
        Me.rbtnAlarm1.Size = New System.Drawing.Size(60, 17)
        Me.rbtnAlarm1.TabIndex = 0
        Me.rbtnAlarm1.TabStop = True
        Me.rbtnAlarm1.Text = "Alarm 1"
        Me.rbtnAlarm1.UseVisualStyleBackColor = True
        '
        'Remplissage
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 481)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlExtention)
        Me.Controls.Add(Me.pnlRight)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Remplissage"
        Me.Text = "remplissage"
        Me.pnlRight.ResumeLayout(False)
        CType(Me.TOTALRemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExtention.ResumeLayout(False)
        Me.gbExtention.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.n1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nbc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.np, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlRight As Panel
    Friend WithEvents TOTALRemp As DataGridView
    Public WithEvents DGRemp As DataGridView
    Friend WithEvents lblFooter As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents pnlExtention As Panel
    Friend WithEvents gbExtention As GroupBox
    Friend WithEvents cmbExtension As ComboBox
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents n1 As NumericUpDown
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents imprimante As ComboBox
    Friend WithEvents gbtnPrint As GlassButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents rbtnRoomN As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nbc As NumericUpDown
    Friend WithEvents rbtnAll As RadioButton
    Friend WithEvents rbtnLimitTo As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkbVacantOnly As CheckBox
    Friend WithEvents chkbMomPickUp As CheckBox
    Friend WithEvents rbtnTotalStock As RadioButton
    Friend WithEvents gbtnCalcOutOfDays As GlassButton
    Friend WithEvents np As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents rbtnOutOfday As RadioButton
    Friend WithEvents rbtnAlarm2 As RadioButton
    Friend WithEvents rbtnAlarm1 As RadioButton
    Friend WithEvents btnRefresh As Button
End Class
