Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports BlueActivity.Controls
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Rfacture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rfacture))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GlassButton8 = New Glass.GlassButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lbListOfFacture = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Datefin = New System.Windows.Forms.DateTimePicker()
        Me.Datedebut = New System.Windows.Forms.DateTimePicker()
        Me.Month = New System.Windows.Forms.MonthCalendar()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.GlassButton5 = New Glass.GlassButton()
        Me.AlphaGradientPanel2 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbSelectedFactory = New System.Windows.Forms.ListBox()
        Me.gauche = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.haut = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbImprimante = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.AlphaGradientPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GlassButton8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.lbListOfFacture)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Datefin)
        Me.GroupBox1.Controls.Add(Me.Datedebut)
        Me.GroupBox1.Controls.Add(Me.Month)
        Me.GroupBox1.Location = New System.Drawing.Point(426, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 376)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'GlassButton8
        '
        Me.GlassButton8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GlassButton8.BackColor = System.Drawing.Color.Green
        Me.GlassButton8.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GlassButton8.Image = Global.HomiNet.My.Resources.Resources.actualiser24
        Me.GlassButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GlassButton8.Location = New System.Drawing.Point(12, 341)
        Me.GlassButton8.Name = "GlassButton8"
        Me.GlassButton8.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton8.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton8.Size = New System.Drawing.Size(491, 30)
        Me.GlassButton8.TabIndex = 71
        Me.GlassButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GlassButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Label5"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(81, 21)
        Me.ComboBox1.TabIndex = 69
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 139)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 68
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 116)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 67
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lbListOfFacture
        '
        Me.lbListOfFacture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbListOfFacture.ColumnWidth = 200
        Me.lbListOfFacture.FormattingEnabled = True
        Me.lbListOfFacture.Location = New System.Drawing.Point(12, 190)
        Me.lbListOfFacture.MultiColumn = True
        Me.lbListOfFacture.Name = "lbListOfFacture"
        Me.lbListOfFacture.Size = New System.Drawing.Size(491, 121)
        Me.lbListOfFacture.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Label4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Label2"
        '
        'Datefin
        '
        Me.Datefin.Location = New System.Drawing.Point(9, 79)
        Me.Datefin.Name = "Datefin"
        Me.Datefin.Size = New System.Drawing.Size(192, 20)
        Me.Datefin.TabIndex = 63
        '
        'Datedebut
        '
        Me.Datedebut.Location = New System.Drawing.Point(9, 31)
        Me.Datedebut.Name = "Datedebut"
        Me.Datedebut.Size = New System.Drawing.Size(192, 20)
        Me.Datedebut.TabIndex = 61
        '
        'Month
        '
        Me.Month.BackColor = System.Drawing.Color.White
        Me.Month.ForeColor = System.Drawing.Color.Black
        Me.Month.Location = New System.Drawing.Point(248, 12)
        Me.Month.MaxSelectionCount = 1000
        Me.Month.Name = "Month"
        Me.Month.ShowWeekNumbers = True
        Me.Month.TabIndex = 62
        Me.Month.TitleBackColor = System.Drawing.Color.LightSteelBlue
        Me.Month.TitleForeColor = System.Drawing.Color.Navy
        Me.Month.TrailingForeColor = System.Drawing.Color.DarkSeaGreen
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'GlassButton5
        '
        Me.GlassButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GlassButton5.AutoEllipsis = True
        Me.GlassButton5.BackColor = System.Drawing.Color.Navy
        Me.GlassButton5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton5.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GlassButton5.Image = Global.HomiNet.My.Resources.Resources.imp24
        Me.GlassButton5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.GlassButton5.Location = New System.Drawing.Point(426, 383)
        Me.GlassButton5.Name = "GlassButton5"
        Me.GlassButton5.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton5.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton5.Size = New System.Drawing.Size(90, 32)
        Me.GlassButton5.TabIndex = 71
        Me.GlassButton5.Text = "Remplissage"
        Me.GlassButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton5.UseCompatibleTextRendering = True
        '
        'AlphaGradientPanel2
        '
        Me.AlphaGradientPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel2.Border = True
        Me.AlphaGradientPanel2.BorderColor = System.Drawing.Color.Black
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel2.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel2.Controls.Add(Me.Label9)
        Me.AlphaGradientPanel2.Controls.Add(Me.Label10)
        Me.AlphaGradientPanel2.Controls.Add(Me.Panel1)
        Me.AlphaGradientPanel2.Controls.Add(Me.Label3)
        Me.AlphaGradientPanel2.Controls.Add(Me.TextBox2)
        Me.AlphaGradientPanel2.Controls.Add(Me.lbSelectedFactory)
        Me.AlphaGradientPanel2.CornerRadius = 20
        Me.AlphaGradientPanel2.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.AlphaGradientPanel2.Gradient = False
        Me.AlphaGradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel2.GradientOffset = 1.0!
        Me.AlphaGradientPanel2.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel2.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel2.Grayscale = False
        Me.AlphaGradientPanel2.Image = Nothing
        Me.AlphaGradientPanel2.ImageAlpha = 75
        Me.AlphaGradientPanel2.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel2.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel2.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel2.Location = New System.Drawing.Point(4, 6)
        Me.AlphaGradientPanel2.Name = "AlphaGradientPanel2"
        Me.AlphaGradientPanel2.Rounded = True
        Me.AlphaGradientPanel2.Size = New System.Drawing.Size(406, 408)
        Me.AlphaGradientPanel2.TabIndex = 72
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel2
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(207, 23)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoEllipsis = True
        Me.Label10.Location = New System.Drawing.Point(210, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 14)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.UseCompatibleTextRendering = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 50)
        Me.Panel1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(211, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.Location = New System.Drawing.Point(211, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Location = New System.Drawing.Point(210, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.UseCompatibleTextRendering = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(13, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(378, 18)
        Me.TextBox2.TabIndex = 1
        '
        'lbSelectedFactory
        '
        Me.lbSelectedFactory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSelectedFactory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbSelectedFactory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbSelectedFactory.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSelectedFactory.FormattingEnabled = True
        Me.lbSelectedFactory.ItemHeight = 11
        Me.lbSelectedFactory.Location = New System.Drawing.Point(13, 51)
        Me.lbSelectedFactory.Name = "lbSelectedFactory"
        Me.lbSelectedFactory.ScrollAlwaysVisible = True
        Me.lbSelectedFactory.Size = New System.Drawing.Size(378, 286)
        Me.lbSelectedFactory.TabIndex = 0
        '
        'gauche
        '
        Me.gauche.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gauche.Location = New System.Drawing.Point(742, 395)
        Me.gauche.Name = "gauche"
        Me.gauche.Size = New System.Drawing.Size(74, 20)
        Me.gauche.TabIndex = 3
        Me.gauche.Text = "0"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(684, 382)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Label11"
        '
        'haut
        '
        Me.haut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.haut.Location = New System.Drawing.Point(650, 395)
        Me.haut.Name = "haut"
        Me.haut.Size = New System.Drawing.Size(74, 20)
        Me.haut.TabIndex = 1
        Me.haut.Text = "0"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(592, 382)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Label12"
        '
        'cmbImprimante
        '
        Me.cmbImprimante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbImprimante.FormattingEnabled = True
        Me.cmbImprimante.Location = New System.Drawing.Point(522, 394)
        Me.cmbImprimante.Name = "cmbImprimante"
        Me.cmbImprimante.Size = New System.Drawing.Size(119, 21)
        Me.cmbImprimante.TabIndex = 73
        '
        'Rfacture
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 421)
        Me.Controls.Add(Me.gauche)
        Me.Controls.Add(Me.cmbImprimante)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AlphaGradientPanel2)
        Me.Controls.Add(Me.haut)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GlassButton5)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rfacture"
        Me.Text = "rfacture"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.AlphaGradientPanel2.ResumeLayout(False)
        Me.AlphaGradientPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GlassButton5 As GlassButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Datefin As DateTimePicker
    Friend WithEvents Datedebut As DateTimePicker
    Friend WithEvents Month As MonthCalendar
    Friend WithEvents ColorWithAlpha1 As ColorWithAlpha
    Friend WithEvents lbListOfFacture As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GlassButton8 As GlassButton
    Friend WithEvents AlphaGradientPanel2 As AlphaGradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbSelectedFactory As ListBox
    Friend WithEvents ColorWithAlpha2 As ColorWithAlpha
    Friend WithEvents Label10 As Label
    Friend WithEvents gauche As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents haut As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbImprimante As ComboBox
End Class
