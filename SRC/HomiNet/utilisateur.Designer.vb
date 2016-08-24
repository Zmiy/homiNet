Imports System.ComponentModel
Imports BlueActivity.Controls
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class utilisateur
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
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(utilisateur))
        Me.ColorWithAlpha1 = New ColorWithAlpha()
        Me.ColorWithAlpha2 = New ColorWithAlpha()
        Me.GlassButton3 = New GlassButton()
        Me.GlassButton2 = New GlassButton()
        Me.GlassButton1 = New GlassButton()
        Me.GroupBox1 = New GroupBox()
        Me.arriverdepart = New CheckBox()
        Me.GlassButton4 = New GlassButton()
        Me.TextBox3 = New TextBox()
        Me.Label4 = New Label()
        Me.ComboBox1 = New ComboBox()
        Me.Label3 = New Label()
        Me.tete = New ListView()
        Me.miniature = New ImageList(Me.components)
        Me.TextBox2 = New TextBox()
        Me.Label2 = New Label()
        Me.PictureBox1 = New PictureBox()
        Me.TextBox1 = New TextBox()
        Me.Label1 = New Label()
        Me.CheckBox5 = New CheckBox()
        Me.CheckBox6 = New CheckBox()
        Me.CheckBox7 = New CheckBox()
        Me.CheckBox8 = New CheckBox()
        Me.CheckBox4 = New CheckBox()
        Me.CheckBox3 = New CheckBox()
        Me.CheckBox2 = New CheckBox()
        Me.CheckBox1 = New CheckBox()
        Me.LV1 = New ListView()
        Me.ImageList1 = New ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
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
        'GlassButton3
        '
        Me.GlassButton3.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton3.AutoEllipsis = True
        Me.GlassButton3.BackColor = Color.Navy
        Me.GlassButton3.Image = My.Resources.Resources.valider24
        Me.GlassButton3.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton3.Location = New Point(528, 388)
        Me.GlassButton3.Name = "GlassButton3"
        Me.GlassButton3.Size = New Size(245, 32)
        Me.GlassButton3.TabIndex = 10
        Me.GlassButton3.Text = "GlassButton3"
        Me.GlassButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton3.UseCompatibleTextRendering = True
        '
        'GlassButton2
        '
        Me.GlassButton2.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GlassButton2.AutoEllipsis = True
        Me.GlassButton2.BackColor = Color.Navy
        Me.GlassButton2.GlowColor = Color.Red
        Me.GlassButton2.Image = My.Resources.Resources.moins24
        Me.GlassButton2.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton2.Location = New Point(147, 388)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.Size = New Size(129, 32)
        Me.GlassButton2.TabIndex = 9
        Me.GlassButton2.Text = "GlassButton2"
        Me.GlassButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton2.UseCompatibleTextRendering = True
        '
        'GlassButton1
        '
        Me.GlassButton1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GlassButton1.AutoEllipsis = True
        Me.GlassButton1.BackColor = Color.Navy
        Me.GlassButton1.GlowColor = Color.Lime
        Me.GlassButton1.Image = My.Resources.Resources.plus24
        Me.GlassButton1.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton1.Location = New Point(12, 388)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.Size = New Size(129, 32)
        Me.GlassButton1.TabIndex = 8
        Me.GlassButton1.Text = "GlassButton1"
        Me.GlassButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton1.UseCompatibleTextRendering = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.arriverdepart)
        Me.GroupBox1.Controls.Add(Me.GlassButton4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tete)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New Point(283, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(490, 360)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'arriverdepart
        '
        Me.arriverdepart.AutoSize = True
        Me.arriverdepart.Location = New Point(29, 316)
        Me.arriverdepart.Name = "arriverdepart"
        Me.arriverdepart.Size = New Size(81, 18)
        Me.arriverdepart.TabIndex = 22
        Me.arriverdepart.Text = "CheckBox9"
        Me.arriverdepart.UseCompatibleTextRendering = True
        Me.arriverdepart.UseVisualStyleBackColor = True
        '
        'GlassButton4
        '
        Me.GlassButton4.AutoEllipsis = True
        Me.GlassButton4.BackColor = Color.Navy
        Me.GlassButton4.GlowColor = Color.Lime
        Me.GlassButton4.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton4.Location = New Point(193, 31)
        Me.GlassButton4.Name = "GlassButton4"
        Me.GlassButton4.Size = New Size(18, 20)
        Me.GlassButton4.TabIndex = 21
        Me.GlassButton4.Text = "..."
        Me.GlassButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton4.UseCompatibleTextRendering = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Point(111, 273)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Size(100, 20)
        Me.TextBox3.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(26, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(39, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Label4"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New Point(111, 231)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New Size(121, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(26, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(39, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Label3"
        '
        'tete
        '
        Me.tete.Activation = ItemActivation.OneClick
        Me.tete.HeaderStyle = ColumnHeaderStyle.None
        Me.tete.HotTracking = True
        Me.tete.HoverSelection = True
        Me.tete.LargeImageList = Me.miniature
        Me.tete.Location = New Point(295, 23)
        Me.tete.MultiSelect = False
        Me.tete.Name = "tete"
        Me.tete.Size = New Size(189, 137)
        Me.tete.TabIndex = 14
        Me.tete.UseCompatibleStateImageBehavior = False
        Me.tete.Visible = False
        '
        'miniature
        '
        Me.miniature.ColorDepth = ColorDepth.Depth32Bit
        Me.miniature.ImageSize = New Size(32, 32)
        Me.miniature.TransparentColor = Color.Transparent
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Point(111, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Size(100, 20)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(26, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(39, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = Cursors.Hand
        Me.PictureBox1.Location = New Point(230, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(64, 64)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "0"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Point(111, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New Size(85, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(26, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = CheckState.Checked
        Me.CheckBox5.Location = New Point(246, 118)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New Size(81, 18)
        Me.CheckBox5.TabIndex = 7
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseCompatibleTextRendering = True
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = CheckState.Checked
        Me.CheckBox6.Location = New Point(246, 142)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New Size(81, 18)
        Me.CheckBox6.TabIndex = 6
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseCompatibleTextRendering = True
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = CheckState.Checked
        Me.CheckBox7.Location = New Point(246, 165)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New Size(81, 18)
        Me.CheckBox7.TabIndex = 5
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseCompatibleTextRendering = True
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = CheckState.Checked
        Me.CheckBox8.Location = New Point(246, 188)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New Size(81, 18)
        Me.CheckBox8.TabIndex = 4
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseCompatibleTextRendering = True
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = CheckState.Checked
        Me.CheckBox4.Location = New Point(29, 188)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New Size(81, 18)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseCompatibleTextRendering = True
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = CheckState.Checked
        Me.CheckBox3.Location = New Point(29, 165)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New Size(81, 18)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseCompatibleTextRendering = True
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = CheckState.Checked
        Me.CheckBox2.Location = New Point(29, 142)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New Size(81, 18)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseCompatibleTextRendering = True
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = CheckState.Checked
        Me.CheckBox1.Location = New Point(29, 119)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New Size(81, 18)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseCompatibleTextRendering = True
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LV1
        '
        Me.LV1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.LV1.Location = New Point(12, 12)
        Me.LV1.MultiSelect = False
        Me.LV1.Name = "LV1"
        Me.LV1.Size = New Size(265, 360)
        Me.LV1.TabIndex = 6
        Me.LV1.UseCompatibleStateImageBehavior = False
        Me.LV1.View = View.List
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        Me.ImageList1.TransparentColor = Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "User.png")
        Me.ImageList1.Images.SetKeyName(1, "7116-pittux-budymsn.png")
        Me.ImageList1.Images.SetKeyName(2, "7117-pittux-budymsn.png")
        Me.ImageList1.Images.SetKeyName(3, "femme1_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(4, "femme2_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(5, "femme3_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(6, "femme4_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(7, "femme5_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(8, "femme6_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(9, "homme1_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(10, "homme2_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(11, "homme3_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(12, "homme4_cameleonhelp_divers.png")
        Me.ImageList1.Images.SetKeyName(13, "msn-messenger1_cameleonhelp_software.png")
        Me.ImageList1.Images.SetKeyName(14, "msn-messenger2_cameleonhelp_software.png")
        Me.ImageList1.Images.SetKeyName(15, "msn-messenger3_cameleonhelp_software.png")
        Me.ImageList1.Images.SetKeyName(16, "msn-messenger_cameleonhelp_software.png")
        Me.ImageList1.Images.SetKeyName(17, "2868-63940.png")
        '
        'utilisateur
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(785, 432)
        Me.Controls.Add(Me.GlassButton3)
        Me.Controls.Add(Me.GlassButton2)
        Me.Controls.Add(Me.GlassButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LV1)
        Me.Name = "utilisateur"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorWithAlpha1 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As ColorWithAlpha
    Friend WithEvents GlassButton3 As GlassButton
    Friend WithEvents GlassButton2 As GlassButton
    Friend WithEvents GlassButton1 As GlassButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LV1 As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tete As ListView
    Friend WithEvents miniature As ImageList
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GlassButton4 As GlassButton
    Friend WithEvents arriverdepart As CheckBox
    Friend WithEvents ImageList1 As ImageList
End Class
