Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class log
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(log))
        Me.GlassButton2 = New GlassButton
        Me.GlassButton1 = New GlassButton
        Me.SuspendLayout()
        '
        'GlassButton2
        '
        Me.GlassButton2.AutoEllipsis = True
        Me.GlassButton2.BackColor = Color.Maroon
        Me.GlassButton2.DialogResult = DialogResult.OK
        Me.GlassButton2.Font = New Font("Tahoma", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton2.GlowColor = Color.CornflowerBlue
        Me.GlassButton2.Image = My.Resources.Resources.depart
        Me.GlassButton2.ImageAlign = ContentAlignment.TopCenter
        Me.GlassButton2.Location = New Point(193, 12)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.OuterBorderColor = Color.Transparent
        Me.GlassButton2.Size = New Size(175, 129)
        Me.GlassButton2.TabIndex = 27
        Me.GlassButton2.Text = "Remplissage"
        Me.GlassButton2.TextAlign = ContentAlignment.BottomCenter
        Me.GlassButton2.TextImageRelation = TextImageRelation.ImageAboveText
        Me.GlassButton2.UseCompatibleTextRendering = True
        '
        'GlassButton1
        '
        Me.GlassButton1.AutoEllipsis = True
        Me.GlassButton1.BackColor = Color.Green
        Me.GlassButton1.DialogResult = DialogResult.OK
        Me.GlassButton1.Font = New Font("Tahoma", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton1.GlowColor = Color.CornflowerBlue
        Me.GlassButton1.Image = My.Resources.Resources.arriver
        Me.GlassButton1.ImageAlign = ContentAlignment.TopCenter
        Me.GlassButton1.Location = New Point(12, 12)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.OuterBorderColor = Color.Transparent
        Me.GlassButton1.Size = New Size(175, 129)
        Me.GlassButton1.TabIndex = 26
        Me.GlassButton1.Text = "Remplissage"
        Me.GlassButton1.TextAlign = ContentAlignment.BottomCenter
        Me.GlassButton1.TextImageRelation = TextImageRelation.ImageAboveText
        Me.GlassButton1.UseCompatibleTextRendering = True
        '
        'log
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.Honeydew
        Me.ClientSize = New Size(380, 157)
        Me.Controls.Add(Me.GlassButton2)
        Me.Controls.Add(Me.GlassButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "log"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "log"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GlassButton1 As GlassButton
    Friend WithEvents GlassButton2 As GlassButton
End Class
