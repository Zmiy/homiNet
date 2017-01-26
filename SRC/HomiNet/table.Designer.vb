Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports BlueActivity.Controls
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Table
    Inherits Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Table))
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbRent = New System.Windows.Forms.RadioButton()
        Me.rbAnomaly = New System.Windows.Forms.RadioButton()
        Me.rbMaintenance = New System.Windows.Forms.RadioButton()
        Me.rbUnlocked = New System.Windows.Forms.RadioButton()
        Me.rbLocked = New System.Windows.Forms.RadioButton()
        Me.rbCheckOut = New System.Windows.Forms.RadioButton()
        Me.rbCheckIn = New System.Windows.Forms.RadioButton()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.lblFilterNane = New System.Windows.Forms.Label()
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.gbtnFind = New Glass.GlassButton()
        Me.tbFind = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabcntrlExtendedRoomActivity = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grbProducts = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rt = New System.Windows.Forms.RichTextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.gbtnExtendetView = New Glass.GlassButton()
        Me.gbtnUpdate = New Glass.GlassButton()
        Me.gbtnMaintenance = New Glass.GlassButton()
        Me.gbtnPrint = New Glass.GlassButton()
        Me.gbtnTest = New Glass.GlassButton()
        Me.gbtnLock = New Glass.GlassButton()
        Me.GbtnUnlock = New Glass.GlassButton()
        Me.gbtnCheckOut = New Glass.GlassButton()
        Me.gbtnCheckIn = New Glass.GlassButton()
        Me.GlassButton9 = New Glass.GlassButton()
        Me.gbtnEnvoice = New Glass.GlassButton()
        Me.ConErrAndSWErr = New System.Windows.Forms.Timer(Me.components)
        Me.gbtnRent = New Glass.GlassButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlphaGradientPanel1.SuspendLayout()
        Me.tabcntrlExtendedRoomActivity.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 200
        Me.ColorWithAlpha1.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 100
        Me.ColorWithAlpha2.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbRent)
        Me.GroupBox1.Controls.Add(Me.rbAnomaly)
        Me.GroupBox1.Controls.Add(Me.rbMaintenance)
        Me.GroupBox1.Controls.Add(Me.rbUnlocked)
        Me.GroupBox1.Controls.Add(Me.rbLocked)
        Me.GroupBox1.Controls.Add(Me.rbCheckOut)
        Me.GroupBox1.Controls.Add(Me.rbCheckIn)
        Me.GroupBox1.Controls.Add(Me.rbAll)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(2, 324)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 58)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'rbRent
        '
        Me.rbRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRent.Location = New System.Drawing.Point(321, 32)
        Me.rbRent.Name = "rbRent"
        Me.rbRent.Size = New System.Drawing.Size(80, 24)
        Me.rbRent.TabIndex = 7
        Me.rbRent.Tag = "rent"
        Me.rbRent.Text = "Rent"
        Me.rbRent.UseVisualStyleBackColor = True
        '
        'rbAnomaly
        '
        Me.rbAnomaly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAnomaly.Location = New System.Drawing.Point(439, 16)
        Me.rbAnomaly.Name = "rbAnomaly"
        Me.rbAnomaly.Size = New System.Drawing.Size(80, 17)
        Me.rbAnomaly.TabIndex = 6
        Me.rbAnomaly.Tag = "anomalie"
        Me.rbAnomaly.Text = "Anomaly"
        Me.rbAnomaly.UseVisualStyleBackColor = True
        '
        'rbMaintenance
        '
        Me.rbMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMaintenance.Location = New System.Drawing.Point(321, 15)
        Me.rbMaintenance.Name = "rbMaintenance"
        Me.rbMaintenance.Size = New System.Drawing.Size(101, 19)
        Me.rbMaintenance.TabIndex = 5
        Me.rbMaintenance.Tag = "maintenance"
        Me.rbMaintenance.Text = "Maintenance"
        Me.rbMaintenance.UseVisualStyleBackColor = True
        '
        'rbUnlocked
        '
        Me.rbUnlocked.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUnlocked.Location = New System.Drawing.Point(221, 35)
        Me.rbUnlocked.Name = "rbUnlocked"
        Me.rbUnlocked.Size = New System.Drawing.Size(79, 17)
        Me.rbUnlocked.TabIndex = 4
        Me.rbUnlocked.Tag = "unlock"
        Me.rbUnlocked.Text = "Unlocked"
        Me.rbUnlocked.UseVisualStyleBackColor = True
        '
        'rbLocked
        '
        Me.rbLocked.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLocked.Location = New System.Drawing.Point(221, 15)
        Me.rbLocked.Name = "rbLocked"
        Me.rbLocked.Size = New System.Drawing.Size(79, 19)
        Me.rbLocked.TabIndex = 3
        Me.rbLocked.Tag = "lock"
        Me.rbLocked.Text = "Locked"
        Me.rbLocked.UseVisualStyleBackColor = True
        '
        'rbCheckOut
        '
        Me.rbCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCheckOut.Location = New System.Drawing.Point(110, 35)
        Me.rbCheckOut.Name = "rbCheckOut"
        Me.rbCheckOut.Size = New System.Drawing.Size(105, 17)
        Me.rbCheckOut.TabIndex = 2
        Me.rbCheckOut.Tag = "checkout"
        Me.rbCheckOut.Text = "Check Out"
        Me.rbCheckOut.UseVisualStyleBackColor = True
        '
        'rbCheckIn
        '
        Me.rbCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCheckIn.Location = New System.Drawing.Point(110, 15)
        Me.rbCheckIn.Name = "rbCheckIn"
        Me.rbCheckIn.Size = New System.Drawing.Size(96, 19)
        Me.rbCheckIn.TabIndex = 1
        Me.rbCheckIn.Tag = "checkin"
        Me.rbCheckIn.Text = "Check In"
        Me.rbCheckIn.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.Checked = True
        Me.rbAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAll.Location = New System.Drawing.Point(15, 30)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(80, 15)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Tag = "tout"
        Me.rbAll.Text = "All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(891, 397)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(54, 26)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.WordWrap = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(748, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(542, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoEllipsis = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(539, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMain.Location = New System.Drawing.Point(2, 78)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(631, 240)
        Me.dgvMain.TabIndex = 38
        '
        'lblFilterNane
        '
        Me.lblFilterNane.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFilterNane.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFilterNane.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterNane.ForeColor = System.Drawing.Color.White
        Me.lblFilterNane.Location = New System.Drawing.Point(2, 55)
        Me.lblFilterNane.Name = "lblFilterNane"
        Me.lblFilterNane.Size = New System.Drawing.Size(631, 23)
        Me.lblFilterNane.TabIndex = 39
        Me.lblFilterNane.Text = "Label5"
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel1.AutoSize = True
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha3)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha4)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.gbtnFind)
        Me.AlphaGradientPanel1.Controls.Add(Me.tbFind)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label6)
        Me.AlphaGradientPanel1.CornerRadius = 8
        Me.AlphaGradientPanel1.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(453, 10)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(179, 41)
        Me.AlphaGradientPanel1.TabIndex = 40
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 200
        Me.ColorWithAlpha3.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha3.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 100
        Me.ColorWithAlpha4.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha4.Parent = Me.AlphaGradientPanel1
        '
        'gbtnFind
        '
        Me.gbtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbtnFind.Image = CType(resources.GetObject("gbtnFind.Image"), System.Drawing.Image)
        Me.gbtnFind.Location = New System.Drawing.Point(140, 5)
        Me.gbtnFind.Name = "gbtnFind"
        Me.gbtnFind.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnFind.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnFind.Size = New System.Drawing.Size(36, 30)
        Me.gbtnFind.TabIndex = 2
        '
        'tbFind
        '
        Me.tbFind.AcceptsReturn = True
        Me.tbFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbFind.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFind.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFind.Location = New System.Drawing.Point(50, 5)
        Me.tbFind.Margin = New System.Windows.Forms.Padding(0)
        Me.tbFind.Name = "tbFind"
        Me.tbFind.ShortcutsEnabled = False
        Me.tbFind.Size = New System.Drawing.Size(90, 30)
        Me.tbFind.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabcntrlExtendedRoomActivity
        '
        Me.tabcntrlExtendedRoomActivity.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tabcntrlExtendedRoomActivity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcntrlExtendedRoomActivity.Controls.Add(Me.TabPage2)
        Me.tabcntrlExtendedRoomActivity.Controls.Add(Me.TabPage1)
        Me.tabcntrlExtendedRoomActivity.HotTrack = True
        Me.tabcntrlExtendedRoomActivity.Location = New System.Drawing.Point(638, 5)
        Me.tabcntrlExtendedRoomActivity.Name = "tabcntrlExtendedRoomActivity"
        Me.tabcntrlExtendedRoomActivity.SelectedIndex = 0
        Me.tabcntrlExtendedRoomActivity.Size = New System.Drawing.Size(311, 377)
        Me.tabcntrlExtendedRoomActivity.TabIndex = 43
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage2.Controls.Add(Me.grbProducts)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(303, 351)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grbProducts
        '
        Me.grbProducts.AutoSize = True
        Me.grbProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbProducts.Location = New System.Drawing.Point(3, 378)
        Me.grbProducts.Name = "grbProducts"
        Me.grbProducts.Size = New System.Drawing.Size(280, 5)
        Me.grbProducts.TabIndex = 12
        Me.grbProducts.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 243)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 135)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Label47
        '
        Me.Label47.AutoEllipsis = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(125, 115)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(150, 15)
        Me.Label47.TabIndex = 16
        Me.Label47.Text = "Label47"
        '
        'Label21
        '
        Me.Label21.AutoEllipsis = True
        Me.Label21.Location = New System.Drawing.Point(5, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Label21"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label46
        '
        Me.Label46.AutoEllipsis = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(125, 95)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(150, 15)
        Me.Label46.TabIndex = 15
        Me.Label46.Text = "Label46"
        '
        'Label45
        '
        Me.Label45.AutoEllipsis = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(125, 75)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(150, 15)
        Me.Label45.TabIndex = 14
        Me.Label45.Text = "Label45"
        '
        'Label44
        '
        Me.Label44.AutoEllipsis = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(125, 55)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(150, 15)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "Label44"
        '
        'Label43
        '
        Me.Label43.AutoEllipsis = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(125, 35)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(150, 15)
        Me.Label43.TabIndex = 12
        Me.Label43.Text = "Label43"
        '
        'Label42
        '
        Me.Label42.AutoEllipsis = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(125, 15)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(150, 15)
        Me.Label42.TabIndex = 11
        Me.Label42.Text = "Label42"
        '
        'Label20
        '
        Me.Label20.AutoEllipsis = True
        Me.Label20.Location = New System.Drawing.Point(5, 95)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 13)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Label20"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoEllipsis = True
        Me.Label16.Location = New System.Drawing.Point(5, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoEllipsis = True
        Me.Label17.Location = New System.Drawing.Point(5, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Label17"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.AutoEllipsis = True
        Me.Label18.Location = New System.Drawing.Point(5, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Label18"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.AutoEllipsis = True
        Me.Label19.Location = New System.Drawing.Point(5, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 13)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Label19"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 188)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 55)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'Label41
        '
        Me.Label41.AutoEllipsis = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(125, 35)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(150, 15)
        Me.Label41.TabIndex = 10
        Me.Label41.Text = "Label41"
        '
        'Label40
        '
        Me.Label40.AutoEllipsis = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(125, 15)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(150, 15)
        Me.Label40.TabIndex = 9
        Me.Label40.Text = "Label40"
        '
        'Label14
        '
        Me.Label14.AutoEllipsis = True
        Me.Label14.Location = New System.Drawing.Point(5, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Label14"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoEllipsis = True
        Me.Label15.Location = New System.Drawing.Point(5, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Label15"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 53)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Label39
        '
        Me.Label39.AutoEllipsis = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(125, 35)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(150, 15)
        Me.Label39.TabIndex = 11
        Me.Label39.Text = "Label39"
        '
        'Label38
        '
        Me.Label38.AutoEllipsis = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(125, 15)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(150, 15)
        Me.Label38.TabIndex = 10
        Me.Label38.Text = "Label38"
        '
        'Label13
        '
        Me.Label13.AutoEllipsis = True
        Me.Label13.Location = New System.Drawing.Point(5, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Label13"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoEllipsis = True
        Me.Label12.Location = New System.Drawing.Point(5, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Label12"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(3, 37)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(280, 98)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'Label37
        '
        Me.Label37.AutoEllipsis = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(125, 75)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(150, 15)
        Me.Label37.TabIndex = 11
        Me.Label37.Text = "Label37"
        '
        'Label36
        '
        Me.Label36.AutoEllipsis = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(125, 55)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(150, 15)
        Me.Label36.TabIndex = 10
        Me.Label36.Text = "Label36"
        '
        'Label35
        '
        Me.Label35.AutoEllipsis = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(125, 35)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(150, 15)
        Me.Label35.TabIndex = 9
        Me.Label35.Text = "Label35"
        '
        'Label34
        '
        Me.Label34.AutoEllipsis = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(125, 15)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(150, 15)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Label34"
        '
        'Label11
        '
        Me.Label11.AutoEllipsis = True
        Me.Label11.Location = New System.Drawing.Point(5, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.Location = New System.Drawing.Point(5, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoEllipsis = True
        Me.Label10.Location = New System.Drawing.Point(5, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoEllipsis = True
        Me.Label9.Location = New System.Drawing.Point(5, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(280, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabPage1.Controls.Add(Me.rt)
        Me.TabPage1.Controls.Add(Me.Label60)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(303, 351)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rt
        '
        Me.rt.BackColor = System.Drawing.Color.LemonChiffon
        Me.rt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rt.Location = New System.Drawing.Point(3, 22)
        Me.rt.Name = "rt"
        Me.rt.ReadOnly = True
        Me.rt.Size = New System.Drawing.Size(297, 326)
        Me.rt.TabIndex = 0
        Me.rt.Text = ""
        '
        'Label60
        '
        Me.Label60.AutoEllipsis = True
        Me.Label60.BackColor = System.Drawing.Color.Khaki
        Me.Label60.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(3, 3)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(297, 19)
        Me.Label60.TabIndex = 3
        Me.Label60.Text = "Label60"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbtnExtendetView
        '
        Me.gbtnExtendetView.AutoEllipsis = True
        Me.gbtnExtendetView.BackColor = System.Drawing.Color.LightBlue
        Me.gbtnExtendetView.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnExtendetView.GlowColor = System.Drawing.Color.Navy
        Me.gbtnExtendetView.Image = Global.HomiNet.My.Resources.Resources.extView
        Me.gbtnExtendetView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnExtendetView.Location = New System.Drawing.Point(268, 4)
        Me.gbtnExtendetView.Name = "gbtnExtendetView"
        Me.gbtnExtendetView.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnExtendetView.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnExtendetView.Size = New System.Drawing.Size(146, 56)
        Me.gbtnExtendetView.TabIndex = 44
        Me.gbtnExtendetView.Text = "Extended View"
        Me.gbtnExtendetView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnExtendetView.UseCompatibleTextRendering = True
        '
        'gbtnUpdate
        '
        Me.gbtnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbtnUpdate.AutoEllipsis = True
        Me.gbtnUpdate.BackColor = System.Drawing.Color.DarkGreen
        Me.gbtnUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnUpdate.GlowColor = System.Drawing.Color.Lime
        Me.gbtnUpdate.Image = CType(resources.GetObject("gbtnUpdate.Image"), System.Drawing.Image)
        Me.gbtnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.gbtnUpdate.Location = New System.Drawing.Point(748, 426)
        Me.gbtnUpdate.Name = "gbtnUpdate"
        Me.gbtnUpdate.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnUpdate.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnUpdate.Size = New System.Drawing.Size(197, 32)
        Me.gbtnUpdate.TabIndex = 37
        Me.gbtnUpdate.Text = "Update"
        Me.gbtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnUpdate.UseCompatibleTextRendering = True
        '
        'gbtnMaintenance
        '
        Me.gbtnMaintenance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbtnMaintenance.AutoEllipsis = True
        Me.gbtnMaintenance.BackColor = System.Drawing.Color.Navy
        Me.gbtnMaintenance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnMaintenance.GlowColor = System.Drawing.Color.Yellow
        Me.gbtnMaintenance.Image = CType(resources.GetObject("gbtnMaintenance.Image"), System.Drawing.Image)
        Me.gbtnMaintenance.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.gbtnMaintenance.Location = New System.Drawing.Point(612, 388)
        Me.gbtnMaintenance.Name = "gbtnMaintenance"
        Me.gbtnMaintenance.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnMaintenance.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnMaintenance.Size = New System.Drawing.Size(66, 70)
        Me.gbtnMaintenance.TabIndex = 31
        Me.gbtnMaintenance.Tag = "6"
        Me.gbtnMaintenance.Text = "Maintenance"
        Me.gbtnMaintenance.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.gbtnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.gbtnMaintenance.UseCompatibleTextRendering = True
        '
        'gbtnPrint
        '
        Me.gbtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbtnPrint.AutoEllipsis = True
        Me.gbtnPrint.BackColor = System.Drawing.Color.Navy
        Me.gbtnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnPrint.GlowColor = System.Drawing.Color.Blue
        Me.gbtnPrint.Image = CType(resources.GetObject("gbtnPrint.Image"), System.Drawing.Image)
        Me.gbtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.gbtnPrint.Location = New System.Drawing.Point(526, 388)
        Me.gbtnPrint.Name = "gbtnPrint"
        Me.gbtnPrint.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnPrint.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnPrint.Size = New System.Drawing.Size(66, 70)
        Me.gbtnPrint.TabIndex = 30
        Me.gbtnPrint.Text = "Remplissage"
        Me.gbtnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.gbtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.gbtnPrint.UseCompatibleTextRendering = True
        '
        'gbtnTest
        '
        Me.gbtnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnTest.AutoEllipsis = True
        Me.gbtnTest.BackColor = System.Drawing.Color.Navy
        Me.gbtnTest.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnTest.GlowColor = System.Drawing.Color.Blue
        Me.gbtnTest.Image = CType(resources.GetObject("gbtnTest.Image"), System.Drawing.Image)
        Me.gbtnTest.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.gbtnTest.Location = New System.Drawing.Point(286, 388)
        Me.gbtnTest.Name = "gbtnTest"
        Me.gbtnTest.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnTest.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnTest.Size = New System.Drawing.Size(66, 70)
        Me.gbtnTest.TabIndex = 29
        Me.gbtnTest.Tag = "5"
        Me.gbtnTest.Text = "Test"
        Me.gbtnTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.gbtnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.gbtnTest.UseCompatibleTextRendering = True
        '
        'gbtnLock
        '
        Me.gbtnLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnLock.AutoEllipsis = True
        Me.gbtnLock.BackColor = System.Drawing.Color.Navy
        Me.gbtnLock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnLock.GlowColor = System.Drawing.Color.Red
        Me.gbtnLock.Image = Global.HomiNet.My.Resources.Resources.LOCK481
        Me.gbtnLock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.gbtnLock.Location = New System.Drawing.Point(214, 388)
        Me.gbtnLock.Name = "gbtnLock"
        Me.gbtnLock.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnLock.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnLock.Size = New System.Drawing.Size(66, 70)
        Me.gbtnLock.TabIndex = 28
        Me.gbtnLock.Tag = "3"
        Me.gbtnLock.Text = "Lock"
        Me.gbtnLock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.gbtnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.gbtnLock.UseCompatibleTextRendering = True
        '
        'GbtnUnlock
        '
        Me.GbtnUnlock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GbtnUnlock.AutoEllipsis = True
        Me.GbtnUnlock.BackColor = System.Drawing.Color.Navy
        Me.GbtnUnlock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbtnUnlock.GlowColor = System.Drawing.Color.Lime
        Me.GbtnUnlock.Image = CType(resources.GetObject("GbtnUnlock.Image"), System.Drawing.Image)
        Me.GbtnUnlock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GbtnUnlock.Location = New System.Drawing.Point(142, 388)
        Me.GbtnUnlock.Name = "GbtnUnlock"
        Me.GbtnUnlock.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GbtnUnlock.ShineColor = System.Drawing.Color.Transparent
        Me.GbtnUnlock.Size = New System.Drawing.Size(66, 70)
        Me.GbtnUnlock.TabIndex = 27
        Me.GbtnUnlock.Tag = "4"
        Me.GbtnUnlock.Text = "Unlock"
        Me.GbtnUnlock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GbtnUnlock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.GbtnUnlock.UseCompatibleTextRendering = True
        '
        'gbtnCheckOut
        '
        Me.gbtnCheckOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnCheckOut.AutoEllipsis = True
        Me.gbtnCheckOut.BackColor = System.Drawing.Color.Navy
        Me.gbtnCheckOut.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnCheckOut.GlowColor = System.Drawing.Color.Red
        Me.gbtnCheckOut.Image = CType(resources.GetObject("gbtnCheckOut.Image"), System.Drawing.Image)
        Me.gbtnCheckOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.gbtnCheckOut.Location = New System.Drawing.Point(70, 388)
        Me.gbtnCheckOut.Name = "gbtnCheckOut"
        Me.gbtnCheckOut.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnCheckOut.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnCheckOut.Size = New System.Drawing.Size(66, 70)
        Me.gbtnCheckOut.TabIndex = 26
        Me.gbtnCheckOut.Tag = "2"
        Me.gbtnCheckOut.Text = "Remplissage"
        Me.gbtnCheckOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.gbtnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.gbtnCheckOut.UseCompatibleTextRendering = True
        '
        'gbtnCheckIn
        '
        Me.gbtnCheckIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnCheckIn.AutoEllipsis = True
        Me.gbtnCheckIn.BackColor = System.Drawing.Color.Navy
        Me.gbtnCheckIn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnCheckIn.GlowColor = System.Drawing.Color.Lime
        Me.gbtnCheckIn.Image = CType(resources.GetObject("gbtnCheckIn.Image"), System.Drawing.Image)
        Me.gbtnCheckIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.gbtnCheckIn.Location = New System.Drawing.Point(2, 388)
        Me.gbtnCheckIn.Name = "gbtnCheckIn"
        Me.gbtnCheckIn.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnCheckIn.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnCheckIn.Size = New System.Drawing.Size(66, 70)
        Me.gbtnCheckIn.TabIndex = 25
        Me.gbtnCheckIn.Tag = "1"
        Me.gbtnCheckIn.Text = "Remplissage"
        Me.gbtnCheckIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.gbtnCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.gbtnCheckIn.UseCompatibleTextRendering = True
        '
        'GlassButton9
        '
        Me.GlassButton9.AutoEllipsis = True
        Me.GlassButton9.BackColor = System.Drawing.Color.SteelBlue
        Me.GlassButton9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton9.GlowColor = System.Drawing.Color.Navy
        Me.GlassButton9.Image = CType(resources.GetObject("GlassButton9.Image"), System.Drawing.Image)
        Me.GlassButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GlassButton9.Location = New System.Drawing.Point(1, 4)
        Me.GlassButton9.Name = "GlassButton9"
        Me.GlassButton9.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton9.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton9.Size = New System.Drawing.Size(135, 57)
        Me.GlassButton9.TabIndex = 41
        Me.GlassButton9.Text = "Remplissage"
        Me.GlassButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton9.UseCompatibleTextRendering = True
        '
        'gbtnEnvoice
        '
        Me.gbtnEnvoice.AutoEllipsis = True
        Me.gbtnEnvoice.BackColor = System.Drawing.Color.LightBlue
        Me.gbtnEnvoice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnEnvoice.GlowColor = System.Drawing.Color.Navy
        Me.gbtnEnvoice.Image = CType(resources.GetObject("gbtnEnvoice.Image"), System.Drawing.Image)
        Me.gbtnEnvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnEnvoice.Location = New System.Drawing.Point(134, 4)
        Me.gbtnEnvoice.Name = "gbtnEnvoice"
        Me.gbtnEnvoice.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnEnvoice.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnEnvoice.Size = New System.Drawing.Size(135, 57)
        Me.gbtnEnvoice.TabIndex = 42
        Me.gbtnEnvoice.Text = "Remplissage"
        Me.gbtnEnvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnEnvoice.UseCompatibleTextRendering = True
        '
        'gbtnRent
        '
        Me.gbtnRent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnRent.AutoEllipsis = True
        Me.gbtnRent.BackColor = System.Drawing.Color.Navy
        Me.gbtnRent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnRent.GlowColor = System.Drawing.Color.Yellow
        Me.gbtnRent.Image = Global.HomiNet.My.Resources.Resources.rentPng2
        Me.gbtnRent.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.gbtnRent.Location = New System.Drawing.Point(358, 388)
        Me.gbtnRent.Name = "gbtnRent"
        Me.gbtnRent.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnRent.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnRent.Size = New System.Drawing.Size(66, 70)
        Me.gbtnRent.TabIndex = 45
        Me.gbtnRent.Tag = "7"
        Me.gbtnRent.Text = "Rent"
        Me.gbtnRent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.gbtnRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.gbtnRent.UseCompatibleTextRendering = True
        '
        'Table
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(952, 462)
        Me.Controls.Add(Me.gbtnRent)
        Me.Controls.Add(Me.tabcntrlExtendedRoomActivity)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.gbtnUpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.Controls.Add(Me.lblFilterNane)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbtnMaintenance)
        Me.Controls.Add(Me.gbtnPrint)
        Me.Controls.Add(Me.gbtnTest)
        Me.Controls.Add(Me.gbtnLock)
        Me.Controls.Add(Me.GbtnUnlock)
        Me.Controls.Add(Me.gbtnCheckOut)
        Me.Controls.Add(Me.gbtnCheckIn)
        Me.Controls.Add(Me.GlassButton9)
        Me.Controls.Add(Me.gbtnEnvoice)
        Me.Controls.Add(Me.gbtnExtendetView)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Table"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.AlphaGradientPanel1.PerformLayout()
        Me.tabcntrlExtendedRoomActivity.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorWithAlpha1 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As ColorWithAlpha
    Friend WithEvents gbtnMaintenance As GlassButton
    Friend WithEvents gbtnPrint As GlassButton
    Friend WithEvents gbtnTest As GlassButton
    Friend WithEvents gbtnLock As GlassButton
    Friend WithEvents GbtnUnlock As GlassButton
    Friend WithEvents gbtnCheckOut As GlassButton
    Friend WithEvents gbtnCheckIn As GlassButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAnomaly As RadioButton
    Friend WithEvents rbMaintenance As RadioButton
    Friend WithEvents rbUnlocked As RadioButton
    Friend WithEvents rbLocked As RadioButton
    Friend WithEvents rbCheckOut As RadioButton
    Friend WithEvents rbCheckIn As RadioButton
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gbtnUpdate As GlassButton
    Friend WithEvents dgvMain As DataGridView
    Friend WithEvents lblFilterNane As Label
    Friend WithEvents AlphaGradientPanel1 As AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As ColorWithAlpha
    Friend WithEvents Label6 As Label
    Friend WithEvents tbFind As TextBox
    Friend WithEvents gbtnFind As GlassButton
    Friend WithEvents GlassButton9 As GlassButton
    Friend WithEvents gbtnEnvoice As GlassButton
    Friend WithEvents tabcntrlExtendedRoomActivity As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents grbProducts As GroupBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents rt As RichTextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents gbtnExtendetView As GlassButton
    Friend WithEvents ConErrAndSWErr As Timer
    Friend WithEvents gbtnRent As Glass.GlassButton
    Friend WithEvents rbRent As System.Windows.Forms.RadioButton
End Class
