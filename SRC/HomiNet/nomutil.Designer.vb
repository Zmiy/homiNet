Imports System.ComponentModel
Imports Glass
Imports HomiNet.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class nomutil
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
        Me.Label1 = New Label
        Me.TextBox1 = New TextBox
        Me.GlassButton3 = New GlassButton
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(25, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Point(87, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Size(208, 20)
        Me.TextBox1.TabIndex = 1
        '
        'GlassButton3
        '
        Me.GlassButton3.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton3.AutoEllipsis = True
        Me.GlassButton3.BackColor = Color.Navy
        Me.GlassButton3.Image = valider24
        Me.GlassButton3.InnerBorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GlassButton3.Location = New Point(28, 54)
        Me.GlassButton3.Name = "GlassButton3"
        Me.GlassButton3.Size = New Size(267, 32)
        Me.GlassButton3.TabIndex = 11
        Me.GlassButton3.Text = "GlassButton3"
        Me.GlassButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton3.UseCompatibleTextRendering = True
        '
        'nomutil
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(336, 107)
        Me.Controls.Add(Me.GlassButton3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nomutil"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "nomutil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GlassButton3 As GlassButton
End Class
