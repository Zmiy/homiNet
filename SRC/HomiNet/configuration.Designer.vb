Imports System.ComponentModel
Imports Glass
Imports HomiNet.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class configuration
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
        Me.tv = New TreeView()
        Me.tc = New TabControl()
        Me.TabPage1 = New TabPage()
        Me.chkbExtReport = New CheckBox()
        Me.TextBox2 = New TextBox()
        Me.lblHotelName = New Label()
        Me.TextBox1 = New TextBox()
        Me.Label1 = New Label()
        Me.comboBox2 = New ComboBox()
        Me.lblLanguage = New Label()
        Me.GlassButton3 = New GlassButton()
        Me.CheckBox54 = New CheckBox()
        Me.CheckBox53 = New CheckBox()
        Me.checkBox15 = New CheckBox()
        Me.cbappel = New ComboBox()
        Me.checkBox16 = New CheckBox()
        Me.TabPage2 = New TabPage()
        Me.GlassButton4 = New GlassButton()
        Me.GlassButton2 = New GlassButton()
        Me.textBox12 = New TextBox()
        Me.label10 = New Label()
        Me.textBox11 = New TextBox()
        Me.label11 = New Label()
        Me.TabPage3 = New TabPage()
        Me.GlassButton5 = New GlassButton()
        Me.CheckBox52 = New CheckBox()
        Me.CheckBox51 = New CheckBox()
        Me.checkBox50 = New CheckBox()
        Me.checkBox48 = New CheckBox()
        Me.checkBox47 = New CheckBox()
        Me.checkBox46 = New CheckBox()
        Me.checkBox45 = New CheckBox()
        Me.checkBox44 = New CheckBox()
        Me.checkBox43 = New CheckBox()
        Me.checkBox42 = New CheckBox()
        Me.checkBox41 = New CheckBox()
        Me.checkBox40 = New CheckBox()
        Me.checkBox39 = New CheckBox()
        Me.checkBox38 = New CheckBox()
        Me.checkBox37 = New CheckBox()
        Me.checkBox36 = New CheckBox()
        Me.checkBox35 = New CheckBox()
        Me.checkBox34 = New CheckBox()
        Me.checkBox33 = New CheckBox()
        Me.checkBox32 = New CheckBox()
        Me.checkBox31 = New CheckBox()
        Me.checkBox30 = New CheckBox()
        Me.checkBox29 = New CheckBox()
        Me.checkBox28 = New CheckBox()
        Me.TabPage4 = New TabPage()
        Me.GlassButton6 = New GlassButton()
        Me.GlassButton1 = New GlassButton()
        Me.tc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tv
        '
        Me.tv.Dock = DockStyle.Left
        Me.tv.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.tv.FullRowSelect = True
        Me.tv.HideSelection = False
        Me.tv.HotTracking = True
        Me.tv.Location = New Point(0, 0)
        Me.tv.Name = "tv"
        Me.tv.Size = New Size(220, 432)
        Me.tv.TabIndex = 0
        '
        'tc
        '
        Me.tc.Controls.Add(Me.TabPage1)
        Me.tc.Controls.Add(Me.TabPage2)
        Me.tc.Controls.Add(Me.TabPage3)
        Me.tc.Controls.Add(Me.TabPage4)
        Me.tc.Dock = DockStyle.Fill
        Me.tc.ItemSize = New Size(63, 10)
        Me.tc.Location = New Point(220, 0)
        Me.tc.Margin = New Padding(0)
        Me.tc.Name = "tc"
        Me.tc.Padding = New Point(0, 0)
        Me.tc.SelectedIndex = 0
        Me.tc.Size = New Size(564, 432)
        Me.tc.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = Color.Lavender
        Me.TabPage1.Controls.Add(Me.chkbExtReport)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.lblHotelName)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.comboBox2)
        Me.TabPage1.Controls.Add(Me.lblLanguage)
        Me.TabPage1.Controls.Add(Me.GlassButton3)
        Me.TabPage1.Controls.Add(Me.CheckBox54)
        Me.TabPage1.Controls.Add(Me.CheckBox53)
        Me.TabPage1.Controls.Add(Me.checkBox15)
        Me.TabPage1.Controls.Add(Me.cbappel)
        Me.TabPage1.Controls.Add(Me.checkBox16)
        Me.TabPage1.Location = New Point(4, 14)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New Size(556, 414)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'chkbExtReport
        '
        Me.chkbExtReport.AutoSize = True
        Me.chkbExtReport.Location = New Point(21, 48)
        Me.chkbExtReport.Name = "chkbExtReport"
        Me.chkbExtReport.Size = New Size(191, 17)
        Me.chkbExtReport.TabIndex = 34
        Me.chkbExtReport.Text = "View extention properties of reports"
        Me.chkbExtReport.UseVisualStyleBackColor = True
        Me.chkbExtReport.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Point(314, 148)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Size(213, 20)
        Me.TextBox2.TabIndex = 33
        '
        'lblHotelName
        '
        Me.lblHotelName.AutoSize = True
        Me.lblHotelName.Location = New Point(244, 151)
        Me.lblHotelName.Name = "lblHotelName"
        Me.lblHotelName.Size = New Size(32, 13)
        Me.lblHotelName.TabIndex = 32
        Me.lblHotelName.Text = "Hotel"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Point(427, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Size(100, 20)
        Me.TextBox1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(244, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(39, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Label1"
        '
        'comboBox2
        '
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Location = New Point(427, 55)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New Size(112, 21)
        Me.comboBox2.TabIndex = 29
        Me.comboBox2.Text = "comboBox2"
        '
        'lblLanguage
        '
        Me.lblLanguage.BackColor = Color.Transparent
        Me.lblLanguage.Location = New Point(244, 55)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New Size(160, 23)
        Me.lblLanguage.TabIndex = 28
        Me.lblLanguage.Text = "langue"
        '
        'GlassButton3
        '
        Me.GlassButton3.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton3.AutoEllipsis = True
        Me.GlassButton3.BackColor = Color.Navy
        Me.GlassButton3.Image = valider24
        Me.GlassButton3.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton3.Location = New Point(412, 374)
        Me.GlassButton3.Name = "GlassButton3"
        Me.GlassButton3.Size = New Size(136, 32)
        Me.GlassButton3.TabIndex = 27
        Me.GlassButton3.Text = "GlassButton3"
        Me.GlassButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton3.UseCompatibleTextRendering = True
        '
        'CheckBox54
        '
        Me.CheckBox54.BackColor = Color.Transparent
        Me.CheckBox54.Checked = True
        Me.CheckBox54.CheckState = CheckState.Checked
        Me.CheckBox54.Location = New Point(21, 96)
        Me.CheckBox54.Name = "CheckBox54"
        Me.CheckBox54.Size = New Size(192, 24)
        Me.CheckBox54.TabIndex = 26
        Me.CheckBox54.Text = "information"
        Me.CheckBox54.UseVisualStyleBackColor = False
        Me.CheckBox54.Visible = False
        '
        'CheckBox53
        '
        Me.CheckBox53.BackColor = Color.Transparent
        Me.CheckBox53.Checked = True
        Me.CheckBox53.CheckState = CheckState.Checked
        Me.CheckBox53.Location = New Point(21, 72)
        Me.CheckBox53.Name = "CheckBox53"
        Me.CheckBox53.Size = New Size(192, 24)
        Me.CheckBox53.TabIndex = 25
        Me.CheckBox53.Text = "anomalie"
        Me.CheckBox53.UseVisualStyleBackColor = False
        Me.CheckBox53.Visible = False
        '
        'checkBox15
        '
        Me.checkBox15.BackColor = Color.Transparent
        Me.checkBox15.Location = New Point(243, 9)
        Me.checkBox15.Name = "checkBox15"
        Me.checkBox15.Size = New Size(176, 40)
        Me.checkBox15.TabIndex = 5
        Me.checkBox15.Text = "appel utili à l'ouverture"
        Me.checkBox15.UseVisualStyleBackColor = False
        '
        'cbappel
        '
        Me.cbappel.DisplayMember = "Text"
        Me.cbappel.FormattingEnabled = True
        Me.cbappel.Location = New Point(427, 17)
        Me.cbappel.Name = "cbappel"
        Me.cbappel.Size = New Size(112, 21)
        Me.cbappel.TabIndex = 6
        '
        'checkBox16
        '
        Me.checkBox16.BackColor = Color.Transparent
        Me.checkBox16.Location = New Point(21, 17)
        Me.checkBox16.Name = "checkBox16"
        Me.checkBox16.Size = New Size(192, 24)
        Me.checkBox16.TabIndex = 4
        Me.checkBox16.Text = "maximise la fenetre"
        Me.checkBox16.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = Color.Lavender
        Me.TabPage2.Controls.Add(Me.GlassButton4)
        Me.TabPage2.Controls.Add(Me.GlassButton2)
        Me.TabPage2.Controls.Add(Me.textBox12)
        Me.TabPage2.Controls.Add(Me.label10)
        Me.TabPage2.Controls.Add(Me.textBox11)
        Me.TabPage2.Controls.Add(Me.label11)
        Me.TabPage2.Location = New Point(4, 14)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New Padding(3)
        Me.TabPage2.Size = New Size(556, 414)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'GlassButton4
        '
        Me.GlassButton4.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton4.AutoEllipsis = True
        Me.GlassButton4.BackColor = Color.Navy
        Me.GlassButton4.Image = valider24
        Me.GlassButton4.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton4.Location = New Point(412, 374)
        Me.GlassButton4.Name = "GlassButton4"
        Me.GlassButton4.Size = New Size(136, 32)
        Me.GlassButton4.TabIndex = 28
        Me.GlassButton4.Text = "GlassButton4"
        Me.GlassButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton4.UseCompatibleTextRendering = True
        '
        'GlassButton2
        '
        Me.GlassButton2.AutoEllipsis = True
        Me.GlassButton2.BackColor = Color.Navy
        Me.GlassButton2.GlowColor = Color.Lime
        Me.GlassButton2.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton2.Location = New Point(319, 31)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.Size = New Size(31, 20)
        Me.GlassButton2.TabIndex = 10
        Me.GlassButton2.Text = "..."
        Me.GlassButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton2.UseCompatibleTextRendering = True
        '
        'textBox12
        '
        Me.textBox12.Location = New Point(452, 31)
        Me.textBox12.Name = "textBox12"
        Me.textBox12.Size = New Size(80, 20)
        Me.textBox12.TabIndex = 7
        Me.textBox12.Text = "textBox12"
        '
        'label10
        '
        Me.label10.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New Point(20, 23)
        Me.label10.Name = "label10"
        Me.label10.Size = New Size(80, 40)
        Me.label10.TabIndex = 2
        Me.label10.Text = "label10"
        Me.label10.TextAlign = ContentAlignment.MiddleRight
        '
        'textBox11
        '
        Me.textBox11.Location = New Point(100, 31)
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New Size(216, 20)
        Me.textBox11.TabIndex = 6
        Me.textBox11.Text = "textBox11"
        '
        'label11
        '
        Me.label11.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New Point(356, 31)
        Me.label11.Name = "label11"
        Me.label11.Size = New Size(96, 24)
        Me.label11.TabIndex = 3
        Me.label11.Text = "label11"
        Me.label11.TextAlign = ContentAlignment.MiddleRight
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = Color.Lavender
        Me.TabPage3.Controls.Add(Me.GlassButton5)
        Me.TabPage3.Controls.Add(Me.CheckBox52)
        Me.TabPage3.Controls.Add(Me.CheckBox51)
        Me.TabPage3.Controls.Add(Me.checkBox50)
        Me.TabPage3.Controls.Add(Me.checkBox48)
        Me.TabPage3.Controls.Add(Me.checkBox47)
        Me.TabPage3.Controls.Add(Me.checkBox46)
        Me.TabPage3.Controls.Add(Me.checkBox45)
        Me.TabPage3.Controls.Add(Me.checkBox44)
        Me.TabPage3.Controls.Add(Me.checkBox43)
        Me.TabPage3.Controls.Add(Me.checkBox42)
        Me.TabPage3.Controls.Add(Me.checkBox41)
        Me.TabPage3.Controls.Add(Me.checkBox40)
        Me.TabPage3.Controls.Add(Me.checkBox39)
        Me.TabPage3.Controls.Add(Me.checkBox38)
        Me.TabPage3.Controls.Add(Me.checkBox37)
        Me.TabPage3.Controls.Add(Me.checkBox36)
        Me.TabPage3.Controls.Add(Me.checkBox35)
        Me.TabPage3.Controls.Add(Me.checkBox34)
        Me.TabPage3.Controls.Add(Me.checkBox33)
        Me.TabPage3.Controls.Add(Me.checkBox32)
        Me.TabPage3.Controls.Add(Me.checkBox31)
        Me.TabPage3.Controls.Add(Me.checkBox30)
        Me.TabPage3.Controls.Add(Me.checkBox29)
        Me.TabPage3.Controls.Add(Me.checkBox28)
        Me.TabPage3.Location = New Point(4, 14)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New Size(556, 414)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'GlassButton5
        '
        Me.GlassButton5.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton5.AutoEllipsis = True
        Me.GlassButton5.BackColor = Color.Navy
        Me.GlassButton5.Image = valider24
        Me.GlassButton5.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton5.Location = New Point(412, 374)
        Me.GlassButton5.Name = "GlassButton5"
        Me.GlassButton5.Size = New Size(136, 32)
        Me.GlassButton5.TabIndex = 75
        Me.GlassButton5.Text = "GlassButton5"
        Me.GlassButton5.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton5.UseCompatibleTextRendering = True
        '
        'CheckBox52
        '
        Me.CheckBox52.Checked = True
        Me.CheckBox52.CheckState = CheckState.Checked
        Me.CheckBox52.Location = New Point(207, 256)
        Me.CheckBox52.Name = "CheckBox52"
        Me.CheckBox52.Size = New Size(168, 24)
        Me.CheckBox52.TabIndex = 74
        Me.CheckBox52.Text = "CheckBox52"
        '
        'CheckBox51
        '
        Me.CheckBox51.Checked = True
        Me.CheckBox51.CheckState = CheckState.Checked
        Me.CheckBox51.Location = New Point(207, 232)
        Me.CheckBox51.Name = "CheckBox51"
        Me.CheckBox51.Size = New Size(168, 24)
        Me.CheckBox51.TabIndex = 73
        Me.CheckBox51.Text = "CheckBox51"
        '
        'checkBox50
        '
        Me.checkBox50.Checked = True
        Me.checkBox50.CheckState = CheckState.Checked
        Me.checkBox50.Location = New Point(207, 208)
        Me.checkBox50.Name = "checkBox50"
        Me.checkBox50.Size = New Size(168, 24)
        Me.checkBox50.TabIndex = 72
        Me.checkBox50.Text = "checkBox50"
        '
        'checkBox48
        '
        Me.checkBox48.Checked = True
        Me.checkBox48.CheckState = CheckState.Checked
        Me.checkBox48.Location = New Point(207, 184)
        Me.checkBox48.Name = "checkBox48"
        Me.checkBox48.Size = New Size(168, 24)
        Me.checkBox48.TabIndex = 71
        Me.checkBox48.Text = "checkBox48"
        '
        'checkBox47
        '
        Me.checkBox47.Checked = True
        Me.checkBox47.CheckState = CheckState.Checked
        Me.checkBox47.Location = New Point(207, 160)
        Me.checkBox47.Name = "checkBox47"
        Me.checkBox47.Size = New Size(168, 24)
        Me.checkBox47.TabIndex = 70
        Me.checkBox47.Text = "checkBox47"
        '
        'checkBox46
        '
        Me.checkBox46.Checked = True
        Me.checkBox46.CheckState = CheckState.Checked
        Me.checkBox46.Location = New Point(207, 136)
        Me.checkBox46.Name = "checkBox46"
        Me.checkBox46.Size = New Size(168, 24)
        Me.checkBox46.TabIndex = 69
        Me.checkBox46.Text = "checkBox46"
        '
        'checkBox45
        '
        Me.checkBox45.Checked = True
        Me.checkBox45.CheckState = CheckState.Checked
        Me.checkBox45.Location = New Point(207, 112)
        Me.checkBox45.Name = "checkBox45"
        Me.checkBox45.Size = New Size(168, 24)
        Me.checkBox45.TabIndex = 68
        Me.checkBox45.Text = "checkBox45"
        '
        'checkBox44
        '
        Me.checkBox44.Checked = True
        Me.checkBox44.CheckState = CheckState.Checked
        Me.checkBox44.Location = New Point(207, 88)
        Me.checkBox44.Name = "checkBox44"
        Me.checkBox44.Size = New Size(168, 24)
        Me.checkBox44.TabIndex = 67
        Me.checkBox44.Text = "checkBox44"
        '
        'checkBox43
        '
        Me.checkBox43.Checked = True
        Me.checkBox43.CheckState = CheckState.Checked
        Me.checkBox43.Location = New Point(207, 64)
        Me.checkBox43.Name = "checkBox43"
        Me.checkBox43.Size = New Size(168, 24)
        Me.checkBox43.TabIndex = 66
        Me.checkBox43.Text = "checkBox43"
        '
        'checkBox42
        '
        Me.checkBox42.Checked = True
        Me.checkBox42.CheckState = CheckState.Checked
        Me.checkBox42.Location = New Point(207, 40)
        Me.checkBox42.Name = "checkBox42"
        Me.checkBox42.Size = New Size(168, 24)
        Me.checkBox42.TabIndex = 65
        Me.checkBox42.Text = "checkBox42"
        '
        'checkBox41
        '
        Me.checkBox41.Checked = True
        Me.checkBox41.CheckState = CheckState.Checked
        Me.checkBox41.Location = New Point(207, 16)
        Me.checkBox41.Name = "checkBox41"
        Me.checkBox41.Size = New Size(168, 24)
        Me.checkBox41.TabIndex = 64
        Me.checkBox41.Text = "checkBox41"
        '
        'checkBox40
        '
        Me.checkBox40.Checked = True
        Me.checkBox40.CheckState = CheckState.Checked
        Me.checkBox40.Location = New Point(23, 304)
        Me.checkBox40.Name = "checkBox40"
        Me.checkBox40.Size = New Size(168, 24)
        Me.checkBox40.TabIndex = 63
        Me.checkBox40.Text = "checkBox40"
        '
        'checkBox39
        '
        Me.checkBox39.Checked = True
        Me.checkBox39.CheckState = CheckState.Checked
        Me.checkBox39.Location = New Point(23, 280)
        Me.checkBox39.Name = "checkBox39"
        Me.checkBox39.Size = New Size(168, 24)
        Me.checkBox39.TabIndex = 62
        Me.checkBox39.Text = "checkBox39"
        '
        'checkBox38
        '
        Me.checkBox38.Checked = True
        Me.checkBox38.CheckState = CheckState.Checked
        Me.checkBox38.Location = New Point(23, 256)
        Me.checkBox38.Name = "checkBox38"
        Me.checkBox38.Size = New Size(168, 24)
        Me.checkBox38.TabIndex = 61
        Me.checkBox38.Text = "checkBox38"
        '
        'checkBox37
        '
        Me.checkBox37.Checked = True
        Me.checkBox37.CheckState = CheckState.Checked
        Me.checkBox37.Location = New Point(23, 232)
        Me.checkBox37.Name = "checkBox37"
        Me.checkBox37.Size = New Size(168, 24)
        Me.checkBox37.TabIndex = 60
        Me.checkBox37.Text = "checkBox37"
        '
        'checkBox36
        '
        Me.checkBox36.Checked = True
        Me.checkBox36.CheckState = CheckState.Checked
        Me.checkBox36.Location = New Point(23, 208)
        Me.checkBox36.Name = "checkBox36"
        Me.checkBox36.Size = New Size(168, 24)
        Me.checkBox36.TabIndex = 59
        Me.checkBox36.Text = "checkBox36"
        '
        'checkBox35
        '
        Me.checkBox35.Checked = True
        Me.checkBox35.CheckState = CheckState.Checked
        Me.checkBox35.Location = New Point(23, 184)
        Me.checkBox35.Name = "checkBox35"
        Me.checkBox35.Size = New Size(168, 24)
        Me.checkBox35.TabIndex = 58
        Me.checkBox35.Text = "checkBox35"
        '
        'checkBox34
        '
        Me.checkBox34.Checked = True
        Me.checkBox34.CheckState = CheckState.Checked
        Me.checkBox34.Location = New Point(23, 160)
        Me.checkBox34.Name = "checkBox34"
        Me.checkBox34.Size = New Size(168, 24)
        Me.checkBox34.TabIndex = 57
        Me.checkBox34.Text = "checkBox34"
        '
        'checkBox33
        '
        Me.checkBox33.Checked = True
        Me.checkBox33.CheckState = CheckState.Checked
        Me.checkBox33.Location = New Point(23, 136)
        Me.checkBox33.Name = "checkBox33"
        Me.checkBox33.Size = New Size(168, 24)
        Me.checkBox33.TabIndex = 56
        Me.checkBox33.Text = "checkBox33"
        '
        'checkBox32
        '
        Me.checkBox32.Checked = True
        Me.checkBox32.CheckState = CheckState.Checked
        Me.checkBox32.Location = New Point(23, 112)
        Me.checkBox32.Name = "checkBox32"
        Me.checkBox32.Size = New Size(168, 24)
        Me.checkBox32.TabIndex = 55
        Me.checkBox32.Text = "checkBox32"
        '
        'checkBox31
        '
        Me.checkBox31.Checked = True
        Me.checkBox31.CheckState = CheckState.Checked
        Me.checkBox31.Location = New Point(23, 88)
        Me.checkBox31.Name = "checkBox31"
        Me.checkBox31.Size = New Size(168, 24)
        Me.checkBox31.TabIndex = 54
        Me.checkBox31.Text = "checkBox31"
        '
        'checkBox30
        '
        Me.checkBox30.Checked = True
        Me.checkBox30.CheckState = CheckState.Checked
        Me.checkBox30.Location = New Point(23, 64)
        Me.checkBox30.Name = "checkBox30"
        Me.checkBox30.Size = New Size(168, 24)
        Me.checkBox30.TabIndex = 53
        Me.checkBox30.Text = "checkBox30"
        '
        'checkBox29
        '
        Me.checkBox29.Checked = True
        Me.checkBox29.CheckState = CheckState.Checked
        Me.checkBox29.Location = New Point(23, 40)
        Me.checkBox29.Name = "checkBox29"
        Me.checkBox29.Size = New Size(168, 24)
        Me.checkBox29.TabIndex = 52
        Me.checkBox29.Text = "checkBox29"
        '
        'checkBox28
        '
        Me.checkBox28.Checked = True
        Me.checkBox28.CheckState = CheckState.Checked
        Me.checkBox28.Location = New Point(23, 16)
        Me.checkBox28.Name = "checkBox28"
        Me.checkBox28.Size = New Size(168, 24)
        Me.checkBox28.TabIndex = 51
        Me.checkBox28.Text = "checkBox28"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = Color.Lavender
        Me.TabPage4.Controls.Add(Me.GlassButton6)
        Me.TabPage4.Location = New Point(4, 14)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New Size(556, 414)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        '
        'GlassButton6
        '
        Me.GlassButton6.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton6.AutoEllipsis = True
        Me.GlassButton6.BackColor = Color.Navy
        Me.GlassButton6.Image = valider24
        Me.GlassButton6.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton6.Location = New Point(412, 374)
        Me.GlassButton6.Name = "GlassButton6"
        Me.GlassButton6.Size = New Size(136, 32)
        Me.GlassButton6.TabIndex = 28
        Me.GlassButton6.Text = "GlassButton6"
        Me.GlassButton6.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton6.UseCompatibleTextRendering = True
        '
        'GlassButton1
        '
        Me.GlassButton1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton1.AutoEllipsis = True
        Me.GlassButton1.BackColor = Color.Navy
        Me.GlassButton1.Image = valider24
        Me.GlassButton1.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton1.Location = New Point(412, 374)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.Size = New Size(136, 32)
        Me.GlassButton1.TabIndex = 28
        Me.GlassButton1.Text = "GlassButton6"
        Me.GlassButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton1.UseCompatibleTextRendering = True
        '
        'configuration
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(784, 432)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tv)
        Me.ForeColor = Color.Black
        Me.Name = "configuration"
        Me.Text = "configuration"
        Me.tc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tv As TreeView
    Friend WithEvents tc As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents textBox12 As TextBox
    Friend WithEvents textBox11 As TextBox
    Friend WithEvents label11 As Label
    Friend WithEvents label10 As Label
    Friend WithEvents CheckBox54 As CheckBox
    Friend WithEvents CheckBox53 As CheckBox
    Friend WithEvents checkBox15 As CheckBox
    Friend WithEvents cbappel As ComboBox
    Friend WithEvents checkBox16 As CheckBox
    Friend WithEvents GlassButton2 As GlassButton
    Friend WithEvents CheckBox52 As CheckBox
    Friend WithEvents CheckBox51 As CheckBox
    Friend WithEvents checkBox50 As CheckBox
    Friend WithEvents checkBox48 As CheckBox
    Friend WithEvents checkBox47 As CheckBox
    Friend WithEvents checkBox46 As CheckBox
    Friend WithEvents checkBox45 As CheckBox
    Friend WithEvents checkBox44 As CheckBox
    Friend WithEvents checkBox43 As CheckBox
    Friend WithEvents checkBox42 As CheckBox
    Friend WithEvents checkBox41 As CheckBox
    Friend WithEvents checkBox40 As CheckBox
    Friend WithEvents checkBox39 As CheckBox
    Friend WithEvents checkBox38 As CheckBox
    Friend WithEvents checkBox37 As CheckBox
    Friend WithEvents checkBox36 As CheckBox
    Friend WithEvents checkBox35 As CheckBox
    Friend WithEvents checkBox34 As CheckBox
    Friend WithEvents checkBox33 As CheckBox
    Friend WithEvents checkBox32 As CheckBox
    Friend WithEvents checkBox31 As CheckBox
    Friend WithEvents checkBox30 As CheckBox
    Friend WithEvents checkBox29 As CheckBox
    Friend WithEvents checkBox28 As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GlassButton3 As GlassButton
    Friend WithEvents GlassButton4 As GlassButton
    Friend WithEvents GlassButton5 As GlassButton
    Friend WithEvents GlassButton6 As GlassButton
    Friend WithEvents comboBox2 As ComboBox
    Friend WithEvents lblLanguage As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GlassButton1 As GlassButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblHotelName As Label
    Friend WithEvents chkbExtReport As CheckBox
End Class
