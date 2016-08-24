Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class information
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
        Me.components = New Container
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(information))
        Me.dg1 = New DataGridView
        Me.Timer1 = New Timer(Me.components)
        Me.CheckBox3 = New CheckBox
        Me.imprimante = New ComboBox
        Me.GlassButton5 = New GlassButton
        CType(Me.dg1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = Color.Black
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.dg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.[False]
        Me.dg1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg1.Location = New Point(2, 1)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New Size(591, 423)
        Me.dg1.TabIndex = 39
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New Point(599, 75)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New Size(81, 17)
        Me.CheckBox3.TabIndex = 47
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'imprimante
        '
        Me.imprimante.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
        Me.imprimante.FormattingEnabled = True
        Me.imprimante.Location = New Point(599, 48)
        Me.imprimante.Name = "imprimante"
        Me.imprimante.Size = New Size(149, 21)
        Me.imprimante.TabIndex = 46
        '
        'GlassButton5
        '
        Me.GlassButton5.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton5.AutoEllipsis = True
        Me.GlassButton5.BackColor = Color.Navy
        Me.GlassButton5.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton5.GlowColor = Color.Blue
        Me.GlassButton5.Image = My.Resources.Resources.imp24
        Me.GlassButton5.ImageAlign = ContentAlignment.MiddleLeft
        Me.GlassButton5.Location = New Point(599, 12)
        Me.GlassButton5.Name = "GlassButton5"
        Me.GlassButton5.OuterBorderColor = Color.Transparent
        Me.GlassButton5.ShineColor = Color.Transparent
        Me.GlassButton5.Size = New Size(149, 33)
        Me.GlassButton5.TabIndex = 45
        Me.GlassButton5.Text = "Remplissage"
        Me.GlassButton5.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton5.UseCompatibleTextRendering = True
        '
        'information
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(752, 426)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.imprimante)
        Me.Controls.Add(Me.GlassButton5)
        Me.Controls.Add(Me.dg1)
        Me.ForeColor = Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "information"
        Me.Text = "produit"
        CType(Me.dg1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents imprimante As ComboBox
    Friend WithEvents GlassButton5 As GlassButton
End Class
