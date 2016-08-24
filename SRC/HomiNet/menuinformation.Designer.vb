Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports MdiTabControl
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class menuinformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuinformation))
        Me.tabInformation = New MdiTabControl.TabControl()
        Me.SuspendLayout()
        '
        'tabInformation
        '
        Me.tabInformation.BackHighColor = System.Drawing.Color.Lavender
        Me.tabInformation.BackLowColor = System.Drawing.Color.LightSteelBlue
        Me.tabInformation.BorderColor = System.Drawing.Color.DimGray
        Me.tabInformation.BorderColorDisabled = System.Drawing.Color.Gray
        Me.tabInformation.ControlButtonBackHighColor = System.Drawing.Color.Lavender
        Me.tabInformation.ControlButtonBackLowColor = System.Drawing.Color.Lavender
        Me.tabInformation.ControlButtonBorderColor = System.Drawing.Color.Navy
        Me.tabInformation.ControlButtonForeColor = System.Drawing.Color.Black
        Me.tabInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabInformation.ForeColorDisabled = System.Drawing.Color.Black
        Me.tabInformation.Location = New System.Drawing.Point(0, 0)
        Me.tabInformation.MenuRenderer = Nothing
        Me.tabInformation.Name = "tabInformation"
        Me.tabInformation.Size = New System.Drawing.Size(752, 426)
        Me.tabInformation.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tabInformation.TabBackHighColor = System.Drawing.Color.Lavender
        Me.tabInformation.TabBackHighColorDisabled = System.Drawing.Color.Azure
        Me.tabInformation.TabBackLowColor = System.Drawing.Color.RoyalBlue
        Me.tabInformation.TabBackLowColorDisabled = System.Drawing.Color.LightSteelBlue
        Me.tabInformation.TabCloseButtonBackLowColorDisabled = System.Drawing.Color.Silver
        Me.tabInformation.TabCloseButtonImage = Nothing
        Me.tabInformation.TabCloseButtonImageDisabled = Nothing
        Me.tabInformation.TabCloseButtonImageHot = Nothing
        Me.tabInformation.TabCloseButtonVisible = False
        Me.tabInformation.TabGlassGradient = True
        Me.tabInformation.TabIconSize = New System.Drawing.Size(24, 24)
        Me.tabInformation.TabIndex = 41
        '
        'menuinformation
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 426)
        Me.Controls.Add(Me.tabInformation)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menuinformation"
        Me.Text = "menu info"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabInformation As TabControl
End Class
