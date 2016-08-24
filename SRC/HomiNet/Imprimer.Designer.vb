Imports System.ComponentModel
Imports System.Drawing.Printing
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Imprimer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imprimer))
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.GlassButton6 = New Glass.GlassButton()
        Me.GlassButton4 = New Glass.GlassButton()
        Me.GlassButton3 = New Glass.GlassButton()
        Me.GlassButton2 = New Glass.GlassButton()
        Me.GlassButton1 = New Glass.GlassButton()
        Me.GlassButton5 = New Glass.GlassButton()
        Me.listpage = New System.Windows.Forms.ComboBox()
        Me.label25 = New System.Windows.Forms.Label()
        Me.label24 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.trackBar1 = New System.Windows.Forms.TrackBar()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.PP1 = New System.Windows.Forms.PrintPreviewControl()
        Me.panel3.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.panel3.Controls.Add(Me.GlassButton6)
        Me.panel3.Controls.Add(Me.GlassButton4)
        Me.panel3.Controls.Add(Me.GlassButton3)
        Me.panel3.Controls.Add(Me.GlassButton2)
        Me.panel3.Controls.Add(Me.GlassButton1)
        Me.panel3.Controls.Add(Me.GlassButton5)
        Me.panel3.Controls.Add(Me.listpage)
        Me.panel3.Controls.Add(Me.label25)
        Me.panel3.Controls.Add(Me.label24)
        Me.panel3.Controls.Add(Me.textBox1)
        Me.panel3.Controls.Add(Me.trackBar1)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(88, 462)
        Me.panel3.TabIndex = 1
        '
        'GlassButton6
        '
        Me.GlassButton6.AutoEllipsis = True
        Me.GlassButton6.BackColor = System.Drawing.Color.Red
        Me.GlassButton6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton6.GlowColor = System.Drawing.Color.LightCoral
        Me.GlassButton6.Location = New System.Drawing.Point(3, 421)
        Me.GlassButton6.Name = "GlassButton6"
        Me.GlassButton6.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton6.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton6.Size = New System.Drawing.Size(72, 38)
        Me.GlassButton6.TabIndex = 45
        Me.GlassButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton6.UseCompatibleTextRendering = True
        '
        'GlassButton4
        '
        Me.GlassButton4.AutoEllipsis = True
        Me.GlassButton4.BackColor = System.Drawing.Color.RoyalBlue
        Me.GlassButton4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton4.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton4.Image = Global.HomiNet.My.Resources.Resources.apercu4
        Me.GlassButton4.Location = New System.Drawing.Point(46, 184)
        Me.GlassButton4.Name = "GlassButton4"
        Me.GlassButton4.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton4.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton4.Size = New System.Drawing.Size(33, 33)
        Me.GlassButton4.TabIndex = 44
        Me.GlassButton4.Tag = "4"
        Me.GlassButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton4.UseCompatibleTextRendering = True
        '
        'GlassButton3
        '
        Me.GlassButton3.AutoEllipsis = True
        Me.GlassButton3.BackColor = System.Drawing.Color.RoyalBlue
        Me.GlassButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton3.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton3.Image = Global.HomiNet.My.Resources.Resources.apercu3
        Me.GlassButton3.Location = New System.Drawing.Point(8, 184)
        Me.GlassButton3.Name = "GlassButton3"
        Me.GlassButton3.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton3.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton3.Size = New System.Drawing.Size(33, 33)
        Me.GlassButton3.TabIndex = 43
        Me.GlassButton3.Tag = "3"
        Me.GlassButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton3.UseCompatibleTextRendering = True
        '
        'GlassButton2
        '
        Me.GlassButton2.AutoEllipsis = True
        Me.GlassButton2.BackColor = System.Drawing.Color.RoyalBlue
        Me.GlassButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton2.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton2.Image = Global.HomiNet.My.Resources.Resources.apercu2
        Me.GlassButton2.Location = New System.Drawing.Point(46, 145)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton2.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton2.Size = New System.Drawing.Size(33, 33)
        Me.GlassButton2.TabIndex = 42
        Me.GlassButton2.Tag = "2"
        Me.GlassButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton2.UseCompatibleTextRendering = True
        '
        'GlassButton1
        '
        Me.GlassButton1.AutoEllipsis = True
        Me.GlassButton1.BackColor = System.Drawing.Color.RoyalBlue
        Me.GlassButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton1.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton1.Image = Global.HomiNet.My.Resources.Resources.apercu11
        Me.GlassButton1.Location = New System.Drawing.Point(8, 145)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton1.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton1.Size = New System.Drawing.Size(33, 33)
        Me.GlassButton1.TabIndex = 41
        Me.GlassButton1.Tag = "1"
        Me.GlassButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton1.UseCompatibleTextRendering = True
        '
        'GlassButton5
        '
        Me.GlassButton5.AutoEllipsis = True
        Me.GlassButton5.BackColor = System.Drawing.Color.Navy
        Me.GlassButton5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton5.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton5.Image = CType(resources.GetObject("GlassButton5.Image"), System.Drawing.Image)
        Me.GlassButton5.Location = New System.Drawing.Point(8, 64)
        Me.GlassButton5.Name = "GlassButton5"
        Me.GlassButton5.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton5.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton5.Size = New System.Drawing.Size(72, 55)
        Me.GlassButton5.TabIndex = 40
        Me.GlassButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton5.UseCompatibleTextRendering = True
        '
        'listpage
        '
        Me.listpage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listpage.FormattingEnabled = True
        Me.listpage.Location = New System.Drawing.Point(8, 24)
        Me.listpage.Name = "listpage"
        Me.listpage.Size = New System.Drawing.Size(72, 21)
        Me.listpage.TabIndex = 11
        '
        'label25
        '
        Me.label25.Location = New System.Drawing.Point(8, 0)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(64, 24)
        Me.label25.TabIndex = 4
        Me.label25.Text = "label25"
        Me.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Location = New System.Drawing.Point(64, 328)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(15, 13)
        Me.label24.TabIndex = 2
        Me.label24.Text = "%"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(8, 328)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(56, 26)
        Me.textBox1.TabIndex = 1
        Me.textBox1.Text = "0"
        '
        'trackBar1
        '
        Me.trackBar1.LargeChange = 25
        Me.trackBar1.Location = New System.Drawing.Point(16, 240)
        Me.trackBar1.Maximum = 200
        Me.trackBar1.Minimum = 10
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trackBar1.Size = New System.Drawing.Size(45, 88)
        Me.trackBar1.TabIndex = 0
        Me.trackBar1.Value = 10
        '
        'Doc
        '
        '
        'PP1
        '
        Me.PP1.BackColor = System.Drawing.Color.GhostWhite
        Me.PP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PP1.Location = New System.Drawing.Point(88, 0)
        Me.PP1.Name = "PP1"
        Me.PP1.Size = New System.Drawing.Size(496, 462)
        Me.PP1.TabIndex = 2
        '
        'Imprimer
        '
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.PP1)
        Me.Controls.Add(Me.panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Imprimer"
        Me.Text = "Imprimer"
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel3 As Panel
    Friend WithEvents listpage As ComboBox
    Friend WithEvents label25 As Label
    Friend WithEvents label24 As Label
    Friend WithEvents textBox1 As TextBox
    Friend WithEvents trackBar1 As TrackBar
    Friend WithEvents GlassButton5 As GlassButton
    Friend WithEvents GlassButton4 As GlassButton
    Friend WithEvents GlassButton3 As GlassButton
    Friend WithEvents GlassButton2 As GlassButton
    Friend WithEvents GlassButton1 As GlassButton
    Friend WithEvents GlassButton6 As GlassButton
    Friend WithEvents Doc As PrintDocument
    Friend WithEvents PP1 As PrintPreviewControl
End Class
