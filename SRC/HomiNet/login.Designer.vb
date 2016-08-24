Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports BlueActivity.Controls
Imports HomiNet.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class login
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
        Me.ColorWithAlpha1 = New ColorWithAlpha
        Me.ColorWithAlpha2 = New ColorWithAlpha
        Me.Label3 = New Label
        Me.Label2 = New Label
        Me.AlphaGradientPanel3 = New AlphaGradientPanel
        Me.ColorWithAlpha3 = New ColorWithAlpha
        Me.ColorWithAlpha4 = New ColorWithAlpha
        Me.Label1 = New Label
        Me.TextBox1 = New TextBox
        Me.AlphaGradientPanel2 = New AlphaGradientPanel
        Me.ColorWithAlpha5 = New ColorWithAlpha
        Me.lv = New ListView
        Me.AlphaGradientPanel1.SuspendLayout()
        Me.AlphaGradientPanel3.SuspendLayout()
        Me.AlphaGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = Color.Transparent
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label3)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label2)
        Me.AlphaGradientPanel1.Controls.Add(Me.AlphaGradientPanel3)
        Me.AlphaGradientPanel1.Controls.Add(Me.AlphaGradientPanel2)
        Me.AlphaGradientPanel1.CornerRadius = 1
        Me.AlphaGradientPanel1.Corners = CType((((Corner.TopLeft Or Corner.TopRight) _
                    Or Corner.BottomLeft) _
                    Or Corner.BottomRight), Corner)
        Me.AlphaGradientPanel1.Dock = DockStyle.Fill
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New Size(48, 48)
        Me.AlphaGradientPanel1.Location = New Point(0, 0)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New Size(784, 432)
        Me.AlphaGradientPanel1.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 200
        Me.ColorWithAlpha1.Color = Color.RoyalBlue
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 100
        Me.ColorWithAlpha2.Color = Color.RoyalBlue
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'Label3
        '
        Me.Label3.Font = New Font("Microsoft Sans Serif", 15.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New Point(72, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(314, 46)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New Font("Microsoft Sans Serif", 15.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = login48
        Me.Label2.ImageAlign = ContentAlignment.MiddleLeft
        Me.Label2.Location = New Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(57, 57)
        Me.Label2.TabIndex = 2
        Me.Label2.TextAlign = ContentAlignment.MiddleLeft
        Me.Label2.UseCompatibleTextRendering = True
        '
        'AlphaGradientPanel3
        '
        Me.AlphaGradientPanel3.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.AlphaGradientPanel3.BackColor = Color.Transparent
        Me.AlphaGradientPanel3.Border = True
        Me.AlphaGradientPanel3.BorderColor = Color.Black
        Me.AlphaGradientPanel3.Colors.Add(Me.ColorWithAlpha3)
        Me.AlphaGradientPanel3.Colors.Add(Me.ColorWithAlpha4)
        Me.AlphaGradientPanel3.ContentPadding = New Padding(0)
        Me.AlphaGradientPanel3.Controls.Add(Me.Label1)
        Me.AlphaGradientPanel3.Controls.Add(Me.TextBox1)
        Me.AlphaGradientPanel3.CornerRadius = 20
        Me.AlphaGradientPanel3.Corners = CType((((Corner.TopLeft Or Corner.TopRight) _
                    Or Corner.BottomLeft) _
                    Or Corner.BottomRight), Corner)
        Me.AlphaGradientPanel3.Gradient = True
        Me.AlphaGradientPanel3.GradientMode = LinearGradientMode.Vertical
        Me.AlphaGradientPanel3.GradientOffset = 1.0!
        Me.AlphaGradientPanel3.GradientSize = New Size(0, 0)
        Me.AlphaGradientPanel3.GradientWrapMode = WrapMode.Tile
        Me.AlphaGradientPanel3.Grayscale = False
        Me.AlphaGradientPanel3.Image = Nothing
        Me.AlphaGradientPanel3.ImageAlpha = 75
        Me.AlphaGradientPanel3.ImagePadding = New Padding(5)
        Me.AlphaGradientPanel3.ImagePosition = ImagePosition.BottomRight
        Me.AlphaGradientPanel3.ImageSize = New Size(48, 48)
        Me.AlphaGradientPanel3.Location = New Point(293, 283)
        Me.AlphaGradientPanel3.Name = "AlphaGradientPanel3"
        Me.AlphaGradientPanel3.Rounded = True
        Me.AlphaGradientPanel3.Size = New Size(202, 69)
        Me.AlphaGradientPanel3.TabIndex = 1
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = Color.LightSteelBlue
        Me.ColorWithAlpha3.Parent = Me.AlphaGradientPanel3
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = Color.SteelBlue
        Me.ColorWithAlpha4.Parent = Me.AlphaGradientPanel3
        '
        'Label1
        '
        Me.Label1.Location = New Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(158, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Point(26, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = ChrW(42)
        Me.TextBox1.Size = New Size(155, 20)
        Me.TextBox1.TabIndex = 0
        '
        'AlphaGradientPanel2
        '
        Me.AlphaGradientPanel2.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.AlphaGradientPanel2.BackColor = Color.Transparent
        Me.AlphaGradientPanel2.Border = True
        Me.AlphaGradientPanel2.BorderColor = Color.Black
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha5)
        Me.AlphaGradientPanel2.ContentPadding = New Padding(0)
        Me.AlphaGradientPanel2.Controls.Add(Me.lv)
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
        Me.AlphaGradientPanel2.Location = New Point(18, 102)
        Me.AlphaGradientPanel2.Name = "AlphaGradientPanel2"
        Me.AlphaGradientPanel2.Rounded = True
        Me.AlphaGradientPanel2.Size = New Size(760, 135)
        Me.AlphaGradientPanel2.TabIndex = 0
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 100
        Me.ColorWithAlpha5.Color = Color.Transparent
        Me.ColorWithAlpha5.Parent = Me.AlphaGradientPanel2
        '
        'lv
        '
        Me.lv.Activation = ItemActivation.OneClick
        Me.lv.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.lv.HeaderStyle = ColumnHeaderStyle.None
        Me.lv.Location = New Point(14, 15)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.ShowGroups = False
        Me.lv.Size = New Size(729, 104)
        Me.lv.TabIndex = 0
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'login
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.White
        Me.ClientSize = New Size(784, 432)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.Name = "login"
        Me.Text = "Form1"
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.AlphaGradientPanel3.ResumeLayout(False)
        Me.AlphaGradientPanel3.PerformLayout()
        Me.AlphaGradientPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlphaGradientPanel1 As AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As ColorWithAlpha
    Friend WithEvents AlphaGradientPanel2 As AlphaGradientPanel
    Friend WithEvents lv As ListView
    Friend WithEvents AlphaGradientPanel3 As AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As ColorWithAlpha
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ColorWithAlpha5 As ColorWithAlpha
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
