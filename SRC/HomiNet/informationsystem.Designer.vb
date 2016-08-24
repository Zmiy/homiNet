Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Informationsystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informationsystem))
        Me.tf = New System.Windows.Forms.RichTextBox()
        Me.d1 = New System.Windows.Forms.MonthCalendar()
        Me.imprimante = New System.Windows.Forms.ComboBox()
        Me.GlassButton5 = New Glass.GlassButton()
        Me.btnSystemUpdate = New Glass.GlassButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox0 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuShowOnlyPowerOn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tf
        '
        Me.tf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tf.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tf.Location = New System.Drawing.Point(4, 2)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(509, 522)
        Me.tf.TabIndex = 0
        Me.tf.Text = ""
        '
        'd1
        '
        Me.d1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.d1.Location = New System.Drawing.Point(519, 2)
        Me.d1.Name = "d1"
        Me.d1.TabIndex = 1
        '
        'imprimante
        '
        Me.imprimante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imprimante.FormattingEnabled = True
        Me.imprimante.Location = New System.Drawing.Point(565, 491)
        Me.imprimante.Name = "imprimante"
        Me.imprimante.Size = New System.Drawing.Size(181, 21)
        Me.imprimante.TabIndex = 46
        '
        'GlassButton5
        '
        Me.GlassButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GlassButton5.AutoEllipsis = True
        Me.GlassButton5.BackColor = System.Drawing.Color.Navy
        Me.GlassButton5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton5.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton5.Image = Global.HomiNet.My.Resources.Resources.imp24
        Me.GlassButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GlassButton5.Location = New System.Drawing.Point(565, 455)
        Me.GlassButton5.Name = "GlassButton5"
        Me.GlassButton5.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton5.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton5.Size = New System.Drawing.Size(181, 33)
        Me.GlassButton5.TabIndex = 45
        Me.GlassButton5.Text = "Remplissage"
        Me.GlassButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton5.UseCompatibleTextRendering = True
        '
        'btnSystemUpdate
        '
        Me.btnSystemUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSystemUpdate.AutoEllipsis = True
        Me.btnSystemUpdate.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSystemUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystemUpdate.GlowColor = System.Drawing.Color.Lime
        Me.btnSystemUpdate.Image = CType(resources.GetObject("btnSystemUpdate.Image"), System.Drawing.Image)
        Me.btnSystemUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSystemUpdate.Location = New System.Drawing.Point(519, 162)
        Me.btnSystemUpdate.Name = "btnSystemUpdate"
        Me.btnSystemUpdate.OuterBorderColor = System.Drawing.Color.Transparent
        Me.btnSystemUpdate.ShineColor = System.Drawing.Color.Transparent
        Me.btnSystemUpdate.Size = New System.Drawing.Size(227, 32)
        Me.btnSystemUpdate.TabIndex = 38
        Me.btnSystemUpdate.Text = "Remplissage"
        Me.btnSystemUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSystemUpdate.UseCompatibleTextRendering = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(519, 225)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox1.TabIndex = 47
        Me.CheckBox1.Tag = "1"
        Me.CheckBox1.Text = "driver stop"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(519, 248)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox2.TabIndex = 48
        Me.CheckBox2.Tag = "2"
        Me.CheckBox2.Text = "connection error"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(519, 271)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox3.TabIndex = 49
        Me.CheckBox3.Tag = "3"
        Me.CheckBox3.Text = "ucf reconnect"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(519, 294)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox6.TabIndex = 52
        Me.CheckBox6.Tag = "6"
        Me.CheckBox6.Text = "battery low"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(519, 317)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox7.TabIndex = 53
        Me.CheckBox7.Tag = "7"
        Me.CheckBox7.Text = "irf watchdog"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(519, 340)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox8.TabIndex = 54
        Me.CheckBox8.Tag = "8"
        Me.CheckBox8.Text = "irf reset power"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(519, 363)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox9.TabIndex = 55
        Me.CheckBox9.Tag = "9"
        Me.CheckBox9.Text = "irf reset instruction"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(519, 386)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(107, 17)
        Me.CheckBox10.TabIndex = 56
        Me.CheckBox10.Tag = "10"
        Me.CheckBox10.Text = "reset irf unknown"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(519, 409)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox11.TabIndex = 57
        Me.CheckBox11.Tag = "11"
        Me.CheckBox11.Text = "ucf synh"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(626, 200)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(69, 17)
        Me.CheckBox12.TabIndex = 58
        Me.CheckBox12.Tag = "12"
        Me.CheckBox12.Text = "test radio"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(626, 223)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox13.TabIndex = 59
        Me.CheckBox13.Tag = "13"
        Me.CheckBox13.Text = "watchdog ucf"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(626, 246)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox14.TabIndex = 60
        Me.CheckBox14.Tag = "14"
        Me.CheckBox14.Text = "reset power ucf"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(626, 271)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(118, 17)
        Me.CheckBox15.TabIndex = 61
        Me.CheckBox15.Tag = "15"
        Me.CheckBox15.Text = "ucf reset instruction"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(626, 294)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox16.TabIndex = 62
        Me.CheckBox16.Tag = "16"
        Me.CheckBox16.Text = "reset ucf unknown"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(626, 317)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox17.TabIndex = 63
        Me.CheckBox17.Tag = "17"
        Me.CheckBox17.Text = "code site error"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Location = New System.Drawing.Point(626, 340)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox18.TabIndex = 64
        Me.CheckBox18.Tag = "18"
        Me.CheckBox18.Text = "service door problem"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Location = New System.Drawing.Point(626, 363)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(112, 17)
        Me.CheckBox19.TabIndex = 65
        Me.CheckBox19.Tag = "19"
        Me.CheckBox19.Text = "problem switch full"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Location = New System.Drawing.Point(626, 386)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(116, 17)
        Me.CheckBox20.TabIndex = 66
        Me.CheckBox20.Tag = "20"
        Me.CheckBox20.Text = "problem flap switch"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CheckBox21.ForeColor = System.Drawing.Color.Red
        Me.CheckBox21.Location = New System.Drawing.Point(630, 432)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(89, 17)
        Me.CheckBox21.TabIndex = 67
        Me.CheckBox21.Tag = "-1"
        Me.CheckBox21.Text = "SELECT ALL"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox0
        '
        Me.CheckBox0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox0.AutoSize = True
        Me.CheckBox0.Location = New System.Drawing.Point(519, 202)
        Me.CheckBox0.Name = "CheckBox0"
        Me.CheckBox0.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox0.TabIndex = 68
        Me.CheckBox0.Tag = "0"
        Me.CheckBox0.Text = "driver start"
        Me.CheckBox0.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(519, 432)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox4.TabIndex = 69
        Me.CheckBox4.Tag = "4"
        Me.CheckBox4.Text = "Undefine Error"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(626, 409)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(89, 17)
        Me.CheckBox5.TabIndex = 70
        Me.CheckBox5.Tag = "5"
        Me.CheckBox5.Text = "False Invoice"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Enabled = False
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuShowOnlyPowerOn})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(191, 48)
        '
        'toolStripMenuShowOnlyPowerOn
        '
        Me.toolStripMenuShowOnlyPowerOn.CheckOnClick = True
        Me.toolStripMenuShowOnlyPowerOn.Name = "toolStripMenuShowOnlyPowerOn"
        Me.toolStripMenuShowOnlyPowerOn.Size = New System.Drawing.Size(190, 22)
        Me.toolStripMenuShowOnlyPowerOn.Text = "Show only 'Power On'"
        '
        'Informationsystem
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 523)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox0)
        Me.Controls.Add(Me.CheckBox21)
        Me.Controls.Add(Me.CheckBox20)
        Me.Controls.Add(Me.CheckBox19)
        Me.Controls.Add(Me.CheckBox18)
        Me.Controls.Add(Me.CheckBox17)
        Me.Controls.Add(Me.CheckBox16)
        Me.Controls.Add(Me.CheckBox15)
        Me.Controls.Add(Me.CheckBox14)
        Me.Controls.Add(Me.CheckBox13)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.imprimante)
        Me.Controls.Add(Me.GlassButton5)
        Me.Controls.Add(Me.btnSystemUpdate)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.tf)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(760, 550)
        Me.Name = "Informationsystem"
        Me.Text = "info system"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tf As RichTextBox
    Friend WithEvents d1 As MonthCalendar
    Friend WithEvents btnSystemUpdate As GlassButton
    Friend WithEvents imprimante As ComboBox
    Friend WithEvents GlassButton5 As GlassButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox0 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolStripMenuShowOnlyPowerOn As System.Windows.Forms.ToolStripMenuItem
End Class
