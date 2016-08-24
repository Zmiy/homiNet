Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports BlueActivity.Controls
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.btTroubleWarning = New Glass.GlassButton()
        Me.SpinningProgress1 = New BlueActivity.Controls.SpinningProgress()
        Me.banomalie = New Glass.GlassButton()
        Me.block = New Glass.GlassButton()
        Me.bconfiguration = New Glass.GlassButton()
        Me.bresultat = New Glass.GlassButton()
        Me.bbase = New Glass.GlassButton()
        Me.butilisateur = New Glass.GlassButton()
        Me.gbtnRemplissage = New Glass.GlassButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.tabMain = New BlueActivity.Controls.TabControl()
        Me.Timerconnect = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTraiteReseau = New System.Windows.Forms.Timer(Me.components)
        Me.Timerenvoireseau = New System.Windows.Forms.Timer(Me.components)
        Me.spinning = New System.Windows.Forms.Timer(Me.components)
        Me.ntf = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.m1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.m2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerWarningsOfTrouble = New System.Windows.Forms.Timer(Me.components)
        Me.bedition = New Glass.GlassButton()
        Me.AlphaGradientPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cm.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.btTroubleWarning)
        Me.AlphaGradientPanel1.Controls.Add(Me.SpinningProgress1)
        Me.AlphaGradientPanel1.Controls.Add(Me.banomalie)
        Me.AlphaGradientPanel1.Controls.Add(Me.block)
        Me.AlphaGradientPanel1.Controls.Add(Me.bconfiguration)
        Me.AlphaGradientPanel1.Controls.Add(Me.bresultat)
        Me.AlphaGradientPanel1.Controls.Add(Me.bbase)
        Me.AlphaGradientPanel1.Controls.Add(Me.butilisateur)
        Me.AlphaGradientPanel1.Controls.Add(Me.gbtnRemplissage)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label4)
        Me.AlphaGradientPanel1.Controls.Add(Me.PictureBox3)
        Me.AlphaGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.AlphaGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.AlphaGradientPanel1.Controls.Add(Me.PictureBox4)
        Me.AlphaGradientPanel1.CornerRadius = 1
        Me.AlphaGradientPanel1.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.AlphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(917, 78)
        Me.AlphaGradientPanel1.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 200
        Me.ColorWithAlpha1.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 100
        Me.ColorWithAlpha2.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'btTroubleWarning
        '
        Me.btTroubleWarning.AutoEllipsis = True
        Me.btTroubleWarning.BackColor = System.Drawing.Color.Navy
        Me.btTroubleWarning.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btTroubleWarning.Image = Global.HomiNet.My.Resources.Resources.cancel_48
        Me.btTroubleWarning.Location = New System.Drawing.Point(471, 3)
        Me.btTroubleWarning.Name = "btTroubleWarning"
        Me.btTroubleWarning.Size = New System.Drawing.Size(71, 70)
        Me.btTroubleWarning.TabIndex = 37
        Me.btTroubleWarning.Text = "WARNING"
        Me.btTroubleWarning.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btTroubleWarning.Visible = False
        '
        'SpinningProgress1
        '
        Me.SpinningProgress1.ActiveSegmentColour = System.Drawing.Color.Navy
        Me.SpinningProgress1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpinningProgress1.AutoIncrement = False
        Me.SpinningProgress1.AutoSize = True
        Me.SpinningProgress1.ForeColor = System.Drawing.Color.Black
        Me.SpinningProgress1.InactiveSegmentColour = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SpinningProgress1.Location = New System.Drawing.Point(879, 10)
        Me.SpinningProgress1.Margin = New System.Windows.Forms.Padding(1)
        Me.SpinningProgress1.Name = "SpinningProgress1"
        Me.SpinningProgress1.Padding = New System.Windows.Forms.Padding(1)
        Me.SpinningProgress1.Size = New System.Drawing.Size(28, 28)
        Me.SpinningProgress1.TabIndex = 33
        Me.SpinningProgress1.TransistionSegment = 1
        Me.SpinningProgress1.TransistionSegmentColour = System.Drawing.Color.RoyalBlue
        '
        'banomalie
        '
        Me.banomalie.AutoEllipsis = True
        Me.banomalie.BackColor = System.Drawing.Color.Navy
        Me.banomalie.Enabled = False
        Me.banomalie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.banomalie.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.banomalie.Image = CType(resources.GetObject("banomalie.Image"), System.Drawing.Image)
        Me.banomalie.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.banomalie.Location = New System.Drawing.Point(402, 3)
        Me.banomalie.Name = "banomalie"
        Me.banomalie.OuterBorderColor = System.Drawing.Color.Transparent
        Me.banomalie.Size = New System.Drawing.Size(66, 70)
        Me.banomalie.TabIndex = 32
        Me.banomalie.Text = "information"
        Me.banomalie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.banomalie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.banomalie.UseCompatibleTextRendering = True
        '
        'block
        '
        Me.block.AutoEllipsis = True
        Me.block.BackColor = System.Drawing.Color.Navy
        Me.block.Enabled = False
        Me.block.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.block.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.block.Image = CType(resources.GetObject("block.Image"), System.Drawing.Image)
        Me.block.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.block.Location = New System.Drawing.Point(71, 3)
        Me.block.Name = "block"
        Me.block.OuterBorderColor = System.Drawing.Color.Transparent
        Me.block.Size = New System.Drawing.Size(66, 70)
        Me.block.TabIndex = 31
        Me.block.Text = "Lock/Unlock"
        Me.block.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.block.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.block.UseCompatibleTextRendering = True
        '
        'bconfiguration
        '
        Me.bconfiguration.AutoEllipsis = True
        Me.bconfiguration.BackColor = System.Drawing.Color.Navy
        Me.bconfiguration.Enabled = False
        Me.bconfiguration.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bconfiguration.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bconfiguration.Image = CType(resources.GetObject("bconfiguration.Image"), System.Drawing.Image)
        Me.bconfiguration.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bconfiguration.Location = New System.Drawing.Point(336, 3)
        Me.bconfiguration.Name = "bconfiguration"
        Me.bconfiguration.OuterBorderColor = System.Drawing.Color.Transparent
        Me.bconfiguration.Size = New System.Drawing.Size(66, 70)
        Me.bconfiguration.TabIndex = 30
        Me.bconfiguration.Text = "Configurartion"
        Me.bconfiguration.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bconfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bconfiguration.UseCompatibleTextRendering = True
        '
        'bresultat
        '
        Me.bresultat.AutoEllipsis = True
        Me.bresultat.BackColor = System.Drawing.Color.Navy
        Me.bresultat.Enabled = False
        Me.bresultat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bresultat.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bresultat.Image = CType(resources.GetObject("bresultat.Image"), System.Drawing.Image)
        Me.bresultat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bresultat.Location = New System.Drawing.Point(270, 3)
        Me.bresultat.Name = "bresultat"
        Me.bresultat.OuterBorderColor = System.Drawing.Color.Transparent
        Me.bresultat.Size = New System.Drawing.Size(66, 70)
        Me.bresultat.TabIndex = 29
        Me.bresultat.Text = "Resultat"
        Me.bresultat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bresultat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bresultat.UseCompatibleTextRendering = True
        '
        'bbase
        '
        Me.bbase.AutoEllipsis = True
        Me.bbase.BackColor = System.Drawing.Color.Navy
        Me.bbase.Enabled = False
        Me.bbase.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbase.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bbase.Image = CType(resources.GetObject("bbase.Image"), System.Drawing.Image)
        Me.bbase.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bbase.Location = New System.Drawing.Point(137, 3)
        Me.bbase.Name = "bbase"
        Me.bbase.OuterBorderColor = System.Drawing.Color.Transparent
        Me.bbase.Size = New System.Drawing.Size(66, 70)
        Me.bbase.TabIndex = 27
        Me.bbase.Text = "Bases"
        Me.bbase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bbase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bbase.UseCompatibleTextRendering = True
        '
        'butilisateur
        '
        Me.butilisateur.AutoEllipsis = True
        Me.butilisateur.BackColor = System.Drawing.Color.Navy
        Me.butilisateur.Enabled = False
        Me.butilisateur.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butilisateur.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.butilisateur.Image = CType(resources.GetObject("butilisateur.Image"), System.Drawing.Image)
        Me.butilisateur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.butilisateur.Location = New System.Drawing.Point(203, 3)
        Me.butilisateur.Name = "butilisateur"
        Me.butilisateur.OuterBorderColor = System.Drawing.Color.Transparent
        Me.butilisateur.Size = New System.Drawing.Size(66, 70)
        Me.butilisateur.TabIndex = 26
        Me.butilisateur.Text = "Utilisateur"
        Me.butilisateur.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.butilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.butilisateur.UseCompatibleTextRendering = True
        '
        'gbtnRemplissage
        '
        Me.gbtnRemplissage.AutoEllipsis = True
        Me.gbtnRemplissage.BackColor = System.Drawing.Color.Navy
        Me.gbtnRemplissage.Enabled = False
        Me.gbtnRemplissage.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnRemplissage.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtnRemplissage.Image = CType(resources.GetObject("gbtnRemplissage.Image"), System.Drawing.Image)
        Me.gbtnRemplissage.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.gbtnRemplissage.Location = New System.Drawing.Point(5, 3)
        Me.gbtnRemplissage.Name = "gbtnRemplissage"
        Me.gbtnRemplissage.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnRemplissage.Size = New System.Drawing.Size(66, 70)
        Me.gbtnRemplissage.TabIndex = 25
        Me.gbtnRemplissage.Text = "Remplissage"
        Me.gbtnRemplissage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.gbtnRemplissage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.gbtnRemplissage.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoEllipsis = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(796, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 23)
        Me.Label4.TabIndex = 22
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(805, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.HomiNet.My.Resources.Resources.con48x28a_r
        Me.PictureBox2.Location = New System.Drawing.Point(707, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.HomiNet.My.Resources.Resources.irf48x28A_r
        Me.PictureBox1.Location = New System.Drawing.Point(650, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.HomiNet.My.Resources.Resources.homi_newLogo1
        Me.PictureBox4.Location = New System.Drawing.Point(559, 31)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(85, 46)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'tabMain
        '
        Me.tabMain.AllowTabReorder = False
        Me.tabMain.BackHighColor = System.Drawing.Color.White
        Me.tabMain.BackLowColor = System.Drawing.Color.White
        Me.tabMain.BorderColor = System.Drawing.Color.White
        Me.tabMain.BorderColorDisabled = System.Drawing.Color.White
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.DropButtonVisible = False
        Me.tabMain.FontBoldOnSelect = False
        Me.tabMain.HotTrack = False
        Me.tabMain.Location = New System.Drawing.Point(0, 78)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(917, 459)
        Me.tabMain.TabBackLowColorDisabled = System.Drawing.Color.White
        Me.tabMain.TabCloseButtonBackLowColorDisabled = System.Drawing.Color.White
        Me.tabMain.TabCloseButtonBorderColorDisabled = System.Drawing.Color.White
        Me.tabMain.TabCloseButtonImage = Nothing
        Me.tabMain.TabCloseButtonImageDisabled = Nothing
        Me.tabMain.TabCloseButtonImageHot = Nothing
        Me.tabMain.TabCloseButtonSize = New System.Drawing.Size(0, 0)
        Me.tabMain.TabCloseButtonVisible = False
        Me.tabMain.TabHeight = 0
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabMaximumWidth = 0
        Me.tabMain.TabMinimumWidth = 0
        Me.tabMain.TabOffset = 0
        Me.tabMain.TabPadLeft = 0
        Me.tabMain.TabPadRight = 0
        Me.tabMain.TabStop = False
        Me.tabMain.TabTop = 0
        Me.tabMain.TopSeparator = False
        '
        'Timerconnect
        '
        Me.Timerconnect.Enabled = True
        Me.Timerconnect.Interval = 60000
        '
        'TimerTraiteReseau
        '
        Me.TimerTraiteReseau.Enabled = True
        Me.TimerTraiteReseau.Interval = 1
        '
        'Timerenvoireseau
        '
        Me.Timerenvoireseau.Enabled = True
        Me.Timerenvoireseau.Interval = 1
        '
        'spinning
        '
        Me.spinning.Enabled = True
        Me.spinning.Interval = 1000
        '
        'ntf
        '
        Me.ntf.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntf.BalloonTipTitle = "HomiNet"
        Me.ntf.ContextMenuStrip = Me.cm
        Me.ntf.Icon = CType(resources.GetObject("ntf.Icon"), System.Drawing.Icon)
        Me.ntf.Text = "HomiNet"
        '
        'cm
        '
        Me.cm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m1, Me.m2})
        Me.cm.Name = "cm"
        Me.cm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cm.ShowImageMargin = False
        Me.cm.Size = New System.Drawing.Size(159, 48)
        '
        'm1
        '
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(158, 22)
        Me.m1.Text = "ToolStripMenuItem1"
        '
        'm2
        '
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(158, 22)
        Me.m2.Text = "ToolStripMenuItem2"
        '
        'TimerWarningsOfTrouble
        '
        Me.TimerWarningsOfTrouble.Enabled = True
        Me.TimerWarningsOfTrouble.Interval = 50000
        '
        'bedition
        '
        Me.bedition.AutoEllipsis = True
        Me.bedition.BackColor = System.Drawing.Color.Navy
        Me.bedition.Enabled = False
        Me.bedition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bedition.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bedition.Image = CType(resources.GetObject("bedition.Image"), System.Drawing.Image)
        Me.bedition.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bedition.Location = New System.Drawing.Point(662, 183)
        Me.bedition.Name = "bedition"
        Me.bedition.OuterBorderColor = System.Drawing.Color.Transparent
        Me.bedition.Size = New System.Drawing.Size(66, 70)
        Me.bedition.TabIndex = 28
        Me.bedition.Text = "Edition"
        Me.bedition.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bedition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bedition.UseCompatibleTextRendering = True
        Me.bedition.Visible = False
        '
        'Mainform
        '
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(917, 537)
        Me.Controls.Add(Me.bedition)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 104)
        Me.Name = "Mainform"
        Me.Text = "HomiNet"
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.AlphaGradientPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlphaGradientPanel1 As AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As ColorWithAlpha
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents tabMain As TabControl
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timerconnect As Timer
    Friend WithEvents TimerTraiteReseau As Timer
    Friend WithEvents Timerenvoireseau As Timer
    Friend WithEvents banomalie As GlassButton
    Friend WithEvents block As GlassButton
    Friend WithEvents bconfiguration As GlassButton
    Friend WithEvents bresultat As GlassButton
    Friend WithEvents bedition As GlassButton
    Friend WithEvents bbase As GlassButton
    Friend WithEvents butilisateur As GlassButton
    Friend WithEvents gbtnRemplissage As GlassButton
    Friend WithEvents SpinningProgress1 As SpinningProgress
    Friend WithEvents spinning As Timer
    Friend WithEvents ntf As NotifyIcon
    Friend WithEvents cm As ContextMenuStrip
    Friend WithEvents m1 As ToolStripMenuItem
    Friend WithEvents m2 As ToolStripMenuItem
    Public WithEvents TimerWarningsOfTrouble As Timer
    Friend WithEvents btTroubleWarning As GlassButton

End Class
