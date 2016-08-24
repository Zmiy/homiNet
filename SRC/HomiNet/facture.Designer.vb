Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports BlueActivity.Controls
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class facture
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(facture))
        Me.ColorWithAlpha1 = New ColorWithAlpha()
        Me.ColorWithAlpha2 = New ColorWithAlpha()
        Me.Label5 = New Label()
        Me.dg1 = New DataGridView()
        Me.GroupBox1 = New GroupBox()
        Me.TextBox1 = New TextBox()
        Me.Label2 = New Label()
        Me.Ligne2 = New Ligne.Ligne()
        Me.RadioButton3 = New RadioButton()
        Me.RadioButton2 = New RadioButton()
        Me.RadioButton1 = New RadioButton()
        Me.AlphaGradientPanel2 = New AlphaGradientPanel()
        Me.ColorWithAlpha3 = New ColorWithAlpha()
        Me.ColorWithAlpha4 = New ColorWithAlpha()
        Me.Panel1 = New Panel()
        Me.Label7 = New Label()
        Me.Label8 = New Label()
        Me.Label6 = New Label()
        Me.Label4 = New Label()
        Me.Label3 = New Label()
        Me.Label1 = New Label()
        Me.TextBox2 = New TextBox()
        Me.rtf = New ListBox()
        Me.Ligne1 = New Ligne.Ligne()
        Me.Ligne3 = New Ligne.Ligne()
        Me.Ligne4 = New Ligne.Ligne()
        Me.gbtnAdd = New GlassButton()
        Me.gbtnPrint = New GlassButton()
        Me.gbtnUpdate = New GlassButton()
        Me.gbtnCancelAll = New GlassButton()
        Me.gbtnCancel = New GlassButton()
        Me.gbtnAllOffer = New GlassButton()
        Me.gbtnOffer = New GlassButton()
        Me.GlassButton9 = New GlassButton()
        Me.GlassButton10 = New GlassButton()
        Me.imprimante = New ComboBox()
        Me.GroupBox2 = New GroupBox()
        Me.gauche = New TextBox()
        Me.Label10 = New Label()
        Me.haut = New TextBox()
        Me.Label9 = New Label()
        CType(Me.dg1, ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.AlphaGradientPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 200
        Me.ColorWithAlpha1.Color = Color.RoyalBlue
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 100
        Me.ColorWithAlpha2.Color = Color.RoyalBlue
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New Font("Arial Black", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = Color.White
        Me.Label5.Location = New Point(12, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(304, 23)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Label5"
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.AllowUserToOrderColumns = True
        Me.dg1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = Color.Black
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
        Me.dg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dg1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Me.dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.[False]
        Me.dg1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg1.Location = New Point(12, 78)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dg1.ShowCellErrors = False
        Me.dg1.ShowRowErrors = False
        Me.dg1.Size = New Size(304, 284)
        Me.dg1.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Ligne2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.FlatStyle = FlatStyle.Flat
        Me.GroupBox1.Location = New Point(12, 368)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(304, 93)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = Color.White
        Me.TextBox1.Font = New Font("Arial Black", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New Point(198, 44)
        Me.TextBox1.Margin = New Padding(1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New Size(72, 30)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = HorizontalAlignment.Center
        Me.TextBox1.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New Point(182, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(100, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = ContentAlignment.MiddleCenter
        '
        'Ligne2
        '
        Me.Ligne2.Caption = ""
        Me.Ligne2.CaptionHOrizontalAlign = Ligne.Ligne.ECaptionOrizontalAlign.Centre
        Me.Ligne2.CaptionMargeSpace = 16
        Me.Ligne2.CaptionPad = 2
        Me.Ligne2.Epaisseur = 1
        Me.Ligne2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Ligne2.ForeColorOmbre = Color.White
        Me.Ligne2.ForeColorText = Color.Black
        Me.Ligne2.LigneVerticalAlign = Ligne.Ligne.ELineVerticalAlign.Milieu
        Me.Ligne2.Location = New Point(20, 42)
        Me.Ligne2.Name = "Ligne2"
        Me.Ligne2.Ombre = False
        Me.Ligne2.Size = New Size(110, 1)
        Me.Ligne2.TabIndex = 8
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New Point(20, 72)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New Size(103, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Tag = "checkout"
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New Point(20, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New Size(103, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Tag = "checkin"
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New Point(20, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New Size(103, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Tag = "tout"
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'AlphaGradientPanel2
        '
        Me.AlphaGradientPanel2.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
        Me.AlphaGradientPanel2.BackColor = Color.Transparent
        Me.AlphaGradientPanel2.Border = True
        Me.AlphaGradientPanel2.BorderColor = Color.Black
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha3)
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha4)
        Me.AlphaGradientPanel2.ContentPadding = New Padding(0)
        Me.AlphaGradientPanel2.Controls.Add(Me.Panel1)
        Me.AlphaGradientPanel2.Controls.Add(Me.Label3)
        Me.AlphaGradientPanel2.Controls.Add(Me.Label1)
        Me.AlphaGradientPanel2.Controls.Add(Me.TextBox2)
        Me.AlphaGradientPanel2.Controls.Add(Me.rtf)
        Me.AlphaGradientPanel2.CornerRadius = 20
        Me.AlphaGradientPanel2.Corners = CType((((Corner.TopLeft Or Corner.TopRight) _
            Or Corner.BottomLeft) _
            Or Corner.BottomRight), Corner)
        Me.AlphaGradientPanel2.Gradient = False
        Me.AlphaGradientPanel2.GradientMode = LinearGradientMode.Vertical
        Me.AlphaGradientPanel2.GradientOffset = 1.0!
        Me.AlphaGradientPanel2.GradientSize = New Size(0, 0)
        Me.AlphaGradientPanel2.GradientWrapMode = WrapMode.Tile
        Me.AlphaGradientPanel2.Grayscale = False
        Me.AlphaGradientPanel2.Image = Nothing
        Me.AlphaGradientPanel2.ImageAlpha = 75
        Me.AlphaGradientPanel2.ImagePadding = New Padding(5)
        Me.AlphaGradientPanel2.ImagePosition = ImagePosition.BottomRight
        Me.AlphaGradientPanel2.ImageSize = New Size(48, 48)
        Me.AlphaGradientPanel2.Location = New Point(325, 4)
        Me.AlphaGradientPanel2.Name = "AlphaGradientPanel2"
        Me.AlphaGradientPanel2.Rounded = True
        Me.AlphaGradientPanel2.Size = New Size(352, 453)
        Me.AlphaGradientPanel2.TabIndex = 58
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha3.Parent = Me.AlphaGradientPanel2
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha4.Parent = Me.AlphaGradientPanel2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.Panel1.BorderStyle = BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New Point(13, 385)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Size(324, 50)
        Me.Panel1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New Point(211, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(90, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.Location = New Point(211, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New Size(90, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = ContentAlignment.MiddleRight
        Me.Label8.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New Point(3, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(189, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.Location = New Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(189, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = ContentAlignment.MiddleRight
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Location = New Point(156, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(181, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = ContentAlignment.MiddleRight
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(137, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.BorderStyle = BorderStyle.FixedSingle
        Me.TextBox2.Font = New Font("Lucida Console", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New Point(13, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Size(324, 18)
        Me.TextBox2.TabIndex = 1
        '
        'rtf
        '
        Me.rtf.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
        Me.rtf.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rtf.BorderStyle = BorderStyle.None
        Me.rtf.Font = New Font("Lucida Console", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.rtf.FormattingEnabled = True
        Me.rtf.ItemHeight = 11
        Me.rtf.Location = New Point(13, 51)
        Me.rtf.Name = "rtf"
        Me.rtf.ScrollAlwaysVisible = True
        Me.rtf.Size = New Size(324, 341)
        Me.rtf.TabIndex = 0
        '
        'Ligne1
        '
        Me.Ligne1.Caption = ""
        Me.Ligne1.CaptionHOrizontalAlign = Ligne.Ligne.ECaptionOrizontalAlign.Centre
        Me.Ligne1.CaptionMargeSpace = 16
        Me.Ligne1.CaptionPad = 1
        Me.Ligne1.Epaisseur = 1
        Me.Ligne1.ForeColorOmbre = Color.White
        Me.Ligne1.ForeColorText = Color.Black
        Me.Ligne1.LigneVerticalAlign = Ligne.Ligne.ELineVerticalAlign.Milieu
        Me.Ligne1.Location = New Point(701, 56)
        Me.Ligne1.Name = "Ligne1"
        Me.Ligne1.Ombre = False
        Me.Ligne1.Size = New Size(65, 1)
        Me.Ligne1.TabIndex = 66
        '
        'Ligne3
        '
        Me.Ligne3.Caption = ""
        Me.Ligne3.CaptionHOrizontalAlign = Ligne.Ligne.ECaptionOrizontalAlign.Centre
        Me.Ligne3.CaptionMargeSpace = 16
        Me.Ligne3.CaptionPad = 1
        Me.Ligne3.Epaisseur = 1
        Me.Ligne3.ForeColorOmbre = Color.White
        Me.Ligne3.ForeColorText = Color.Black
        Me.Ligne3.LigneVerticalAlign = Ligne.Ligne.ELineVerticalAlign.Milieu
        Me.Ligne3.Location = New Point(701, 149)
        Me.Ligne3.Name = "Ligne3"
        Me.Ligne3.Ombre = False
        Me.Ligne3.Size = New Size(65, 1)
        Me.Ligne3.TabIndex = 67
        '
        'Ligne4
        '
        Me.Ligne4.Caption = ""
        Me.Ligne4.CaptionHOrizontalAlign = Ligne.Ligne.ECaptionOrizontalAlign.Centre
        Me.Ligne4.CaptionMargeSpace = 16
        Me.Ligne4.CaptionPad = 1
        Me.Ligne4.Epaisseur = 1
        Me.Ligne4.ForeColorOmbre = Color.White
        Me.Ligne4.ForeColorText = Color.Black
        Me.Ligne4.LigneVerticalAlign = Ligne.Ligne.ELineVerticalAlign.Milieu
        Me.Ligne4.Location = New Point(701, 242)
        Me.Ligne4.Name = "Ligne4"
        Me.Ligne4.Ombre = False
        Me.Ligne4.Size = New Size(65, 1)
        Me.Ligne4.TabIndex = 68
        '
        'gbtnAdd
        '
        Me.gbtnAdd.AutoEllipsis = True
        Me.gbtnAdd.BackColor = Color.Blue
        Me.gbtnAdd.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnAdd.GlowColor = Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbtnAdd.Image = My.Resources.Resources.plus24
        Me.gbtnAdd.ImageAlign = ContentAlignment.TopLeft
        Me.gbtnAdd.Location = New Point(683, 12)
        Me.gbtnAdd.Name = "gbtnAdd"
        Me.gbtnAdd.OuterBorderColor = Color.Transparent
        Me.gbtnAdd.ShineColor = Color.Transparent
        Me.gbtnAdd.Size = New Size(98, 32)
        Me.gbtnAdd.TabIndex = 65
        Me.gbtnAdd.Text = "Add"
        Me.gbtnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.gbtnAdd.UseCompatibleTextRendering = True
        '
        'gbtnPrint
        '
        Me.gbtnPrint.AutoEllipsis = True
        Me.gbtnPrint.BackColor = Color.Navy
        Me.gbtnPrint.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnPrint.GlowColor = Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbtnPrint.Image = My.Resources.Resources.imp24
        Me.gbtnPrint.ImageAlign = ContentAlignment.TopLeft
        Me.gbtnPrint.Location = New Point(683, 297)
        Me.gbtnPrint.Name = "gbtnPrint"
        Me.gbtnPrint.OuterBorderColor = Color.Transparent
        Me.gbtnPrint.ShineColor = Color.Transparent
        Me.gbtnPrint.Size = New Size(98, 32)
        Me.gbtnPrint.TabIndex = 64
        Me.gbtnPrint.Text = "Print"
        Me.gbtnPrint.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.gbtnPrint.UseCompatibleTextRendering = True
        '
        'gbtnUpdate
        '
        Me.gbtnUpdate.AutoEllipsis = True
        Me.gbtnUpdate.BackColor = Color.DarkGreen
        Me.gbtnUpdate.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnUpdate.GlowColor = Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtnUpdate.Image = CType(resources.GetObject("gbtnUpdate.Image"), Image)
        Me.gbtnUpdate.ImageAlign = ContentAlignment.TopLeft
        Me.gbtnUpdate.Location = New Point(683, 249)
        Me.gbtnUpdate.Name = "gbtnUpdate"
        Me.gbtnUpdate.OuterBorderColor = Color.Transparent
        Me.gbtnUpdate.ShineColor = Color.Transparent
        Me.gbtnUpdate.Size = New Size(98, 32)
        Me.gbtnUpdate.TabIndex = 63
        Me.gbtnUpdate.Text = "Update"
        Me.gbtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.gbtnUpdate.UseCompatibleTextRendering = True
        '
        'gbtnCancelAll
        '
        Me.gbtnCancelAll.AutoEllipsis = True
        Me.gbtnCancelAll.BackColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbtnCancelAll.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnCancelAll.GlowColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtnCancelAll.Image = My.Resources.Resources.corbeil24
        Me.gbtnCancelAll.ImageAlign = ContentAlignment.TopLeft
        Me.gbtnCancelAll.Location = New Point(683, 204)
        Me.gbtnCancelAll.Name = "gbtnCancelAll"
        Me.gbtnCancelAll.OuterBorderColor = Color.Transparent
        Me.gbtnCancelAll.ShineColor = Color.Transparent
        Me.gbtnCancelAll.Size = New Size(98, 32)
        Me.gbtnCancelAll.TabIndex = 62
        Me.gbtnCancelAll.Text = "Cancel All"
        Me.gbtnCancelAll.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.gbtnCancelAll.UseCompatibleTextRendering = True
        '
        'gbtnCancel
        '
        Me.gbtnCancel.AutoEllipsis = True
        Me.gbtnCancel.BackColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbtnCancel.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnCancel.GlowColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtnCancel.Image = CType(resources.GetObject("gbtnCancel.Image"), Image)
        Me.gbtnCancel.ImageAlign = ContentAlignment.TopLeft
        Me.gbtnCancel.Location = New Point(683, 166)
        Me.gbtnCancel.Name = "gbtnCancel"
        Me.gbtnCancel.OuterBorderColor = Color.Transparent
        Me.gbtnCancel.ShineColor = Color.Transparent
        Me.gbtnCancel.Size = New Size(98, 32)
        Me.gbtnCancel.TabIndex = 61
        Me.gbtnCancel.Text = "Cancel"
        Me.gbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.gbtnCancel.UseCompatibleTextRendering = True
        '
        'gbtnAllOffer
        '
        Me.gbtnAllOffer.AutoEllipsis = True
        Me.gbtnAllOffer.BackColor = Color.Goldenrod
        Me.gbtnAllOffer.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnAllOffer.GlowColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtnAllOffer.Image = My.Resources.Resources.toffert24
        Me.gbtnAllOffer.ImageAlign = ContentAlignment.TopLeft
        Me.gbtnAllOffer.Location = New Point(683, 111)
        Me.gbtnAllOffer.Name = "gbtnAllOffer"
        Me.gbtnAllOffer.OuterBorderColor = Color.Transparent
        Me.gbtnAllOffer.ShineColor = Color.Transparent
        Me.gbtnAllOffer.Size = New Size(98, 32)
        Me.gbtnAllOffer.TabIndex = 60
        Me.gbtnAllOffer.Text = "All Offer"
        Me.gbtnAllOffer.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.gbtnAllOffer.UseCompatibleTextRendering = True
        '
        'gbtnOffer
        '
        Me.gbtnOffer.AutoEllipsis = True
        Me.gbtnOffer.BackColor = Color.Goldenrod
        Me.gbtnOffer.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnOffer.GlowColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtnOffer.Image = CType(resources.GetObject("gbtnOffer.Image"), Image)
        Me.gbtnOffer.ImageAlign = ContentAlignment.TopLeft
        Me.gbtnOffer.Location = New Point(683, 73)
        Me.gbtnOffer.Name = "gbtnOffer"
        Me.gbtnOffer.OuterBorderColor = Color.Transparent
        Me.gbtnOffer.ShineColor = Color.Transparent
        Me.gbtnOffer.Size = New Size(98, 32)
        Me.gbtnOffer.TabIndex = 59
        Me.gbtnOffer.Text = "Offer"
        Me.gbtnOffer.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.gbtnOffer.UseCompatibleTextRendering = True
        '
        'GlassButton9
        '
        Me.GlassButton9.AutoEllipsis = True
        Me.GlassButton9.BackColor = Color.LightBlue
        Me.GlassButton9.Font = New Font("Tahoma", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton9.GlowColor = Color.Navy
        Me.GlassButton9.Image = CType(resources.GetObject("GlassButton9.Image"), Image)
        Me.GlassButton9.ImageAlign = ContentAlignment.MiddleLeft
        Me.GlassButton9.Location = New Point(12, 4)
        Me.GlassButton9.Name = "GlassButton9"
        Me.GlassButton9.OuterBorderColor = Color.Transparent
        Me.GlassButton9.ShineColor = Color.Transparent
        Me.GlassButton9.Size = New Size(152, 57)
        Me.GlassButton9.TabIndex = 56
        Me.GlassButton9.Text = "Remplissage"
        Me.GlassButton9.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton9.UseCompatibleTextRendering = True
        '
        'GlassButton10
        '
        Me.GlassButton10.AutoEllipsis = True
        Me.GlassButton10.BackColor = Color.SteelBlue
        Me.GlassButton10.Font = New Font("Tahoma", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton10.GlowColor = Color.Navy
        Me.GlassButton10.Image = My.Resources.Resources.facture48
        Me.GlassButton10.ImageAlign = ContentAlignment.MiddleLeft
        Me.GlassButton10.Location = New Point(164, 4)
        Me.GlassButton10.Name = "GlassButton10"
        Me.GlassButton10.OuterBorderColor = Color.Transparent
        Me.GlassButton10.ShineColor = Color.Transparent
        Me.GlassButton10.Size = New Size(152, 57)
        Me.GlassButton10.TabIndex = 57
        Me.GlassButton10.Text = "Remplissage"
        Me.GlassButton10.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton10.UseCompatibleTextRendering = True
        '
        'imprimante
        '
        Me.imprimante.FormattingEnabled = True
        Me.imprimante.Location = New Point(683, 335)
        Me.imprimante.Name = "imprimante"
        Me.imprimante.Size = New Size(98, 21)
        Me.imprimante.TabIndex = 69
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gauche)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.haut)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New Point(683, 363)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = RightToLeft.Yes
        Me.GroupBox2.Size = New Size(97, 94)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'gauche
        '
        Me.gauche.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.gauche.Location = New Point(9, 68)
        Me.gauche.Name = "gauche"
        Me.gauche.Size = New Size(80, 20)
        Me.gauche.TabIndex = 3
        Me.gauche.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New Point(6, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New Size(45, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Label10"
        '
        'haut
        '
        Me.haut.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.haut.Location = New Point(9, 28)
        Me.haut.Name = "haut"
        Me.haut.Size = New Size(80, 20)
        Me.haut.TabIndex = 1
        Me.haut.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New Point(6, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New Size(39, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Label9"
        '
        'facture
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(784, 462)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.imprimante)
        Me.Controls.Add(Me.Ligne4)
        Me.Controls.Add(Me.Ligne3)
        Me.Controls.Add(Me.Ligne1)
        Me.Controls.Add(Me.gbtnAdd)
        Me.Controls.Add(Me.gbtnPrint)
        Me.Controls.Add(Me.gbtnUpdate)
        Me.Controls.Add(Me.gbtnCancelAll)
        Me.Controls.Add(Me.gbtnCancel)
        Me.Controls.Add(Me.gbtnAllOffer)
        Me.Controls.Add(Me.gbtnOffer)
        Me.Controls.Add(Me.AlphaGradientPanel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GlassButton9)
        Me.Controls.Add(Me.GlassButton10)
        Me.ForeColor = Color.Black
        Me.Name = "facture"
        CType(Me.dg1, ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.AlphaGradientPanel2.ResumeLayout(False)
        Me.AlphaGradientPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Ligne2 As Ligne.Ligne
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GlassButton9 As GlassButton
    Friend WithEvents GlassButton10 As GlassButton
    Friend WithEvents ColorWithAlpha1 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As ColorWithAlpha
    Friend WithEvents AlphaGradientPanel2 As AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As ColorWithAlpha
    Friend WithEvents rtf As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gbtnOffer As GlassButton
    Friend WithEvents gbtnAllOffer As GlassButton
    Friend WithEvents gbtnCancel As GlassButton
    Friend WithEvents gbtnCancelAll As GlassButton
    Friend WithEvents gbtnUpdate As GlassButton
    Friend WithEvents gbtnPrint As GlassButton
    Friend WithEvents gbtnAdd As GlassButton
    Friend WithEvents Ligne1 As Ligne.Ligne
    Friend WithEvents Ligne3 As Ligne.Ligne
    Friend WithEvents Ligne4 As Ligne.Ligne
    Friend WithEvents imprimante As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gauche As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents haut As TextBox
    Friend WithEvents Label9 As Label
End Class
