Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports BlueActivity.Controls
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class rXZ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rXZ))
        Me.AlphaGradientPanel2 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtf = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbtnReadingPeriod = New Glass.GlassButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Datefin = New System.Windows.Forms.DateTimePicker()
        Me.Datedebut = New System.Windows.Forms.DateTimePicker()
        Me.Month = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbtnCloseDay = New Glass.GlassButton()
        Me.gbtnDaily = New Glass.GlassButton()
        Me.gauche = New System.Windows.Forms.TextBox()
        Me.imprimante = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.haut = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbtnPrint = New Glass.GlassButton()
        Me.AlphaGradientPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlphaGradientPanel2
        '
        Me.AlphaGradientPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel2.Border = True
        Me.AlphaGradientPanel2.BorderColor = System.Drawing.Color.Black
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel2.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel2.Controls.Add(Me.Label3)
        Me.AlphaGradientPanel2.Controls.Add(Me.Label1)
        Me.AlphaGradientPanel2.Controls.Add(Me.rtf)
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
        Me.AlphaGradientPanel2.Location = New System.Drawing.Point(3, 5)
        Me.AlphaGradientPanel2.Name = "AlphaGradientPanel2"
        Me.AlphaGradientPanel2.Rounded = True
        Me.AlphaGradientPanel2.Size = New System.Drawing.Size(352, 414)
        Me.AlphaGradientPanel2.TabIndex = 59
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Honeydew
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel2
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Location = New System.Drawing.Point(13, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtf
        '
        Me.rtf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rtf.BackColor = System.Drawing.Color.Honeydew
        Me.rtf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtf.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtf.FormattingEnabled = True
        Me.rtf.ItemHeight = 11
        Me.rtf.Location = New System.Drawing.Point(13, 50)
        Me.rtf.Name = "rtf"
        Me.rtf.ScrollAlwaysVisible = True
        Me.rtf.Size = New System.Drawing.Size(324, 352)
        Me.rtf.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.gbtnReadingPeriod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Datefin)
        Me.GroupBox1.Controls.Add(Me.Datedebut)
        Me.GroupBox1.Controls.Add(Me.Month)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 176)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Label4"
        '
        'gbtnReadingPeriod
        '
        Me.gbtnReadingPeriod.AutoEllipsis = True
        Me.gbtnReadingPeriod.BackColor = System.Drawing.Color.Navy
        Me.gbtnReadingPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnReadingPeriod.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbtnReadingPeriod.Image = Global.HomiNet.My.Resources.Resources.xdd24
        Me.gbtnReadingPeriod.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.gbtnReadingPeriod.Location = New System.Drawing.Point(9, 19)
        Me.gbtnReadingPeriod.Name = "gbtnReadingPeriod"
        Me.gbtnReadingPeriod.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnReadingPeriod.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnReadingPeriod.Size = New System.Drawing.Size(189, 32)
        Me.gbtnReadingPeriod.TabIndex = 71
        Me.gbtnReadingPeriod.Text = "Reading period"
        Me.gbtnReadingPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnReadingPeriod.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Label2"
        '
        'Datefin
        '
        Me.Datefin.Location = New System.Drawing.Point(6, 148)
        Me.Datefin.Name = "Datefin"
        Me.Datefin.Size = New System.Drawing.Size(192, 20)
        Me.Datefin.TabIndex = 63
        '
        'Datedebut
        '
        Me.Datedebut.Location = New System.Drawing.Point(6, 91)
        Me.Datedebut.Name = "Datedebut"
        Me.Datedebut.Size = New System.Drawing.Size(192, 20)
        Me.Datedebut.TabIndex = 61
        '
        'Month
        '
        Me.Month.BackColor = System.Drawing.Color.White
        Me.Month.ForeColor = System.Drawing.Color.Black
        Me.Month.Location = New System.Drawing.Point(210, 13)
        Me.Month.MaxSelectionCount = 1000
        Me.Month.Name = "Month"
        Me.Month.ShowWeekNumbers = True
        Me.Month.TabIndex = 62
        Me.Month.TitleBackColor = System.Drawing.Color.LightSteelBlue
        Me.Month.TitleForeColor = System.Drawing.Color.Navy
        Me.Month.TrailingForeColor = System.Drawing.Color.DarkSeaGreen
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.gbtnCloseDay)
        Me.GroupBox2.Controls.Add(Me.gbtnDaily)
        Me.GroupBox2.Location = New System.Drawing.Point(361, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 57)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        '
        'gbtnCloseDay
        '
        Me.gbtnCloseDay.AutoEllipsis = True
        Me.gbtnCloseDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbtnCloseDay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnCloseDay.GlowColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtnCloseDay.Image = Global.HomiNet.My.Resources.Resources.record24
        Me.gbtnCloseDay.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.gbtnCloseDay.Location = New System.Drawing.Point(219, 19)
        Me.gbtnCloseDay.Name = "gbtnCloseDay"
        Me.gbtnCloseDay.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnCloseDay.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnCloseDay.Size = New System.Drawing.Size(191, 32)
        Me.gbtnCloseDay.TabIndex = 69
        Me.gbtnCloseDay.Text = "Close day"
        Me.gbtnCloseDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnCloseDay.UseCompatibleTextRendering = True
        '
        'gbtnDaily
        '
        Me.gbtnDaily.AutoEllipsis = True
        Me.gbtnDaily.BackColor = System.Drawing.Color.DarkGreen
        Me.gbtnDaily.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnDaily.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtnDaily.Image = Global.HomiNet.My.Resources.Resources.lecture24
        Me.gbtnDaily.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.gbtnDaily.Location = New System.Drawing.Point(9, 19)
        Me.gbtnDaily.Name = "gbtnDaily"
        Me.gbtnDaily.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnDaily.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnDaily.Size = New System.Drawing.Size(204, 32)
        Me.gbtnDaily.TabIndex = 70
        Me.gbtnDaily.Text = "Daily"
        Me.gbtnDaily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnDaily.UseCompatibleTextRendering = True
        '
        'gauche
        '
        Me.gauche.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gauche.Location = New System.Drawing.Point(686, 259)
        Me.gauche.Name = "gauche"
        Me.gauche.Size = New System.Drawing.Size(74, 20)
        Me.gauche.TabIndex = 77
        Me.gauche.Text = "0"
        '
        'imprimante
        '
        Me.imprimante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imprimante.FormattingEnabled = True
        Me.imprimante.Location = New System.Drawing.Point(466, 258)
        Me.imprimante.Name = "imprimante"
        Me.imprimante.Size = New System.Drawing.Size(119, 21)
        Me.imprimante.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(683, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Label11"
        '
        'haut
        '
        Me.haut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.haut.Location = New System.Drawing.Point(594, 259)
        Me.haut.Name = "haut"
        Me.haut.Size = New System.Drawing.Size(74, 20)
        Me.haut.TabIndex = 75
        Me.haut.Text = "0"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(591, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Label12"
        '
        'gbtnPrint
        '
        Me.gbtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnPrint.AutoEllipsis = True
        Me.gbtnPrint.BackColor = System.Drawing.Color.Navy
        Me.gbtnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnPrint.GlowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbtnPrint.Image = Global.HomiNet.My.Resources.Resources.imp24
        Me.gbtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.gbtnPrint.Location = New System.Drawing.Point(370, 247)
        Me.gbtnPrint.Name = "gbtnPrint"
        Me.gbtnPrint.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnPrint.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnPrint.Size = New System.Drawing.Size(90, 32)
        Me.gbtnPrint.TabIndex = 78
        Me.gbtnPrint.Text = "Print"
        Me.gbtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnPrint.UseCompatibleTextRendering = True
        '
        'rXZ
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(856, 421)
        Me.Controls.Add(Me.gauche)
        Me.Controls.Add(Me.imprimante)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.haut)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.gbtnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AlphaGradientPanel2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rXZ"
        Me.Text = "xz"
        Me.AlphaGradientPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AlphaGradientPanel2 As AlphaGradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rtf As ListBox
    Friend WithEvents ColorWithAlpha1 As ColorWithAlpha
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Month As MonthCalendar
    Friend WithEvents Datedebut As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Datefin As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gbtnReadingPeriod As GlassButton
    Friend WithEvents gbtnCloseDay As GlassButton
    Friend WithEvents gbtnDaily As GlassButton
    Friend WithEvents gauche As TextBox
    Friend WithEvents imprimante As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents haut As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents gbtnPrint As GlassButton
End Class
