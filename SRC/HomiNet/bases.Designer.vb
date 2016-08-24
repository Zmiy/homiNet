Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports BlueActivity.Controls
Imports HomiNet.My.Resources
Imports Microsoft.VisualBasic.CompilerServices
Imports TabControl = MdiTabControl.TabControl

<DesignerGenerated()> _
Partial Class bases
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
        Me.MyTaskPanePage1 = New MyTaskPanePage
        Me.MyTaskPanePage2 = New MyTaskPanePage
        Me.MyTaskPanePage3 = New MyTaskPanePage
        Me.MyTaskPanePage4 = New MyTaskPanePage
        Me.MyTaskPanePage5 = New MyTaskPanePage
        Me.MyTaskPanePage6 = New MyTaskPanePage
        Me.MyTaskPanePage7 = New MyTaskPanePage
        Me.TabControl1 = New TabControl
        Me.Label1 = New Label
        Me.PictureBox1 = New PictureBox
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyTaskPanePage1
        '
        Me.MyTaskPanePage1.Text = "TaskPane Page"
        '
        'MyTaskPanePage2
        '
        Me.MyTaskPanePage2.Text = "TaskPane Page"
        '
        'MyTaskPanePage3
        '
        Me.MyTaskPanePage3.Text = "TaskPane Page"
        '
        'MyTaskPanePage4
        '
        Me.MyTaskPanePage4.Text = "TaskPane Page"
        '
        'MyTaskPanePage5
        '
        Me.MyTaskPanePage5.Text = "TaskPane Page"
        '
        'MyTaskPanePage6
        '
        Me.MyTaskPanePage6.Text = "TaskPane Page"
        '
        'MyTaskPanePage7
        '
        Me.MyTaskPanePage7.Text = "TaskPane Page"
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
        Me.TabControl1.Location = New Point(3, 49)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New Size(779, 413)
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
        Me.TabControl1.TabIndex = 40
        Me.TabControl1.TabsDirection = TabControl.FlowDirection.LeftToRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Microsoft Sans Serif", 15.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New Point(67, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(83, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = BASE48
        Me.PictureBox1.Location = New Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(32, 32)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'bases
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(784, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = Color.Black
        Me.Name = "bases"
        Me.Text = "form"
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyTaskPanePage1 As MyTaskPanePage
    Friend WithEvents MyTaskPanePage2 As MyTaskPanePage
    Friend WithEvents MyTaskPanePage3 As MyTaskPanePage
    Friend WithEvents MyTaskPanePage4 As MyTaskPanePage
    Friend WithEvents MyTaskPanePage5 As MyTaskPanePage
    Friend WithEvents MyTaskPanePage6 As MyTaskPanePage
    Friend WithEvents MyTaskPanePage7 As MyTaskPanePage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
