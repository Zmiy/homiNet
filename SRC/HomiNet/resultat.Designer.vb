Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports MdiTabControl
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class resultat
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
        Me.TabControl1 = New TabControl
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = TabControl.TabAlignment.Top
        Me.TabControl1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.TabControl1.BackHighColor = Color.Lavender
        Me.TabControl1.BackLowColor = Color.LightSteelBlue
        Me.TabControl1.BorderColor = Color.DimGray
        Me.TabControl1.BorderColorDisabled = Color.Gray
        Me.TabControl1.ControlButtonBackHighColor = Color.Lavender
        Me.TabControl1.ControlButtonBackLowColor = Color.Lavender
        Me.TabControl1.ControlButtonBorderColor = Color.Navy
        Me.TabControl1.ControlButtonForeColor = Color.Black
        Me.TabControl1.ForeColorDisabled = Color.Black
        Me.TabControl1.Location = New Point(0, 12)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New Size(791, 448)
        Me.TabControl1.SmoothingMode = SmoothingMode.HighQuality
        Me.TabControl1.TabBackHighColor = Color.Lavender
        Me.TabControl1.TabBackHighColorDisabled = Color.Azure
        Me.TabControl1.TabBackLowColor = Color.RoyalBlue
        Me.TabControl1.TabBackLowColorDisabled = Color.LightSteelBlue
        Me.TabControl1.TabBorderEnhanceWeight = TabControl.Weight.Medium
        Me.TabControl1.TabCloseButtonBackLowColorDisabled = Color.Silver
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabCloseButtonVisible = False
        Me.TabControl1.TabGlassGradient = True
        Me.TabControl1.TabIconSize = New Size(24, 24)
        Me.TabControl1.TabIndex = 41
        Me.TabControl1.TabsDirection = TabControl.FlowDirection.LeftToRight
        '
        'resultat
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(784, 462)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = Color.Black
        Me.Name = "resultat"
        Me.Text = "resultat"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
End Class
