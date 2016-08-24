Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports BlueActivity.Controls
Imports Glass
Imports HomiNet.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Ajouterarticle
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
        Me.AlphaGradientPanel1 = New AlphaGradientPanel
        Me.ColorWithAlpha2 = New ColorWithAlpha
        Me.ColorWithAlpha1 = New ColorWithAlpha
        Me.Label5 = New Label
        Me.Label4 = New Label
        Me.Label3 = New Label
        Me.RadioButton4 = New RadioButton
        Me.RadioButton3 = New RadioButton
        Me.RadioButton2 = New RadioButton
        Me.RadioButton1 = New RadioButton
        Me.Label2 = New Label
        Me.Label1 = New Label
        Me.nud = New NumericUpDown
        Me.Label6 = New Label
        Me.Label7 = New Label
        Me.GlassButton2 = New GlassButton
        Me.GlassButton4 = New GlassButton
        Me.ListBox1 = New ListBox
        Me.AlphaGradientPanel1.SuspendLayout()
        CType(Me.nud, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = Color.Transparent
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = Color.Navy
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.ContentPadding = New Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.ListBox1)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label7)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label6)
        Me.AlphaGradientPanel1.Controls.Add(Me.GlassButton2)
        Me.AlphaGradientPanel1.Controls.Add(Me.GlassButton4)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label5)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label4)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label3)
        Me.AlphaGradientPanel1.Controls.Add(Me.RadioButton4)
        Me.AlphaGradientPanel1.Controls.Add(Me.RadioButton3)
        Me.AlphaGradientPanel1.Controls.Add(Me.RadioButton2)
        Me.AlphaGradientPanel1.Controls.Add(Me.RadioButton1)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label2)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label1)
        Me.AlphaGradientPanel1.Controls.Add(Me.nud)
        Me.AlphaGradientPanel1.CornerRadius = 20
        Me.AlphaGradientPanel1.Corners = CType((((Corner.TopLeft Or Corner.TopRight) _
                    Or Corner.BottomLeft) _
                    Or Corner.BottomRight), Corner)
        Me.AlphaGradientPanel1.Dock = DockStyle.Fill
        Me.AlphaGradientPanel1.Font = New Font("Arial Black", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New Size(30, 114)
        Me.AlphaGradientPanel1.GradientWrapMode = WrapMode.TileFlipX
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New Size(48, 48)
        Me.AlphaGradientPanel1.Location = New Point(0, 0)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New Size(357, 223)
        Me.AlphaGradientPanel1.TabIndex = 0
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = Color.SteelBlue
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = Color.LightSteelBlue
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New Point(286, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(51, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(210, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(44, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "prix"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(139, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(39, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "qte"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoEllipsis = True
        Me.RadioButton4.Font = New Font("Arial Black", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New Point(249, 35)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New Size(96, 28)
        Me.RadioButton4.TabIndex = 7
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseCompatibleTextRendering = True
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoEllipsis = True
        Me.RadioButton3.Font = New Font("Arial Black", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New Point(249, 12)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New Size(96, 28)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseCompatibleTextRendering = True
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoEllipsis = True
        Me.RadioButton2.Font = New Font("Arial Black", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New Point(139, 35)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New Size(96, 28)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseCompatibleTextRendering = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoEllipsis = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New Font("Arial Black", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New Point(139, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New Size(96, 28)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseCompatibleTextRendering = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(267, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(21, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(193, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(21, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "x"
        '
        'nud
        '
        Me.nud.Font = New Font("Arial Black", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.nud.Location = New Point(139, 112)
        Me.nud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud.Name = "nud"
        Me.nud.Size = New Size(48, 30)
        Me.nud.TabIndex = 0
        Me.nud.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New Point(210, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(48, 23)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New Point(286, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(48, 23)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "0.00"
        '
        'GlassButton2
        '
        Me.GlassButton2.AutoEllipsis = True
        Me.GlassButton2.BackColor = Color.Navy
        Me.GlassButton2.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton2.GlowColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GlassButton2.Image = annuler24
        Me.GlassButton2.ImageAlign = ContentAlignment.TopLeft
        Me.GlassButton2.Location = New Point(143, 178)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.OuterBorderColor = Color.Transparent
        Me.GlassButton2.ShineColor = Color.Transparent
        Me.GlassButton2.Size = New Size(98, 32)
        Me.GlassButton2.TabIndex = 65
        Me.GlassButton2.Text = "Remplissage"
        Me.GlassButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton2.UseCompatibleTextRendering = True
        '
        'GlassButton4
        '
        Me.GlassButton4.AutoEllipsis = True
        Me.GlassButton4.BackColor = Color.Navy
        Me.GlassButton4.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton4.GlowColor = Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GlassButton4.Image = valider24
        Me.GlassButton4.ImageAlign = ContentAlignment.TopLeft
        Me.GlassButton4.Location = New Point(247, 178)
        Me.GlassButton4.Name = "GlassButton4"
        Me.GlassButton4.OuterBorderColor = Color.Transparent
        Me.GlassButton4.ShineColor = Color.Transparent
        Me.GlassButton4.Size = New Size(98, 32)
        Me.GlassButton4.TabIndex = 64
        Me.GlassButton4.Text = "Remplissage"
        Me.GlassButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton4.UseCompatibleTextRendering = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New Font("Arial Black", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New Point(12, 11)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New Size(120, 199)
        Me.ListBox1.TabIndex = 68
        '
        'ajouterarticle
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.Snow
        Me.ClientSize = New Size(357, 223)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Name = "ajouterarticle"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "ajouterarticle"
        Me.TransparencyKey = Color.Snow
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.AlphaGradientPanel1.PerformLayout()
        CType(Me.nud, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlphaGradientPanel1 As AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As ColorWithAlpha
    Friend WithEvents Label1 As Label
    Friend WithEvents nud As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GlassButton4 As GlassButton
    Friend WithEvents GlassButton2 As GlassButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
