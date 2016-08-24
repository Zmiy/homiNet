Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class basegroupe
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(basegroupe))
        Me.GroupBox1 = New GroupBox
        Me.GlassButton2 = New GlassButton
        Me.GlassButton1 = New GlassButton
        Me.GlassButton0 = New GlassButton
        Me.dgroupe = New DataGridView
        Me.e = New DataGridViewTextBoxColumn
        Me.Column3 = New DataGridViewTextBoxColumn
        Me.GroupBox2 = New GroupBox
        Me.GlassButton5 = New GlassButton
        Me.GlassButton4 = New GlassButton
        Me.GlassButton3 = New GlassButton
        Me.dtaxe = New DataGridView
        Me.e2 = New DataGridViewTextBoxColumn
        Me.Column1 = New DataGridViewTextBoxColumn
        Me.Column2 = New DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgroupe, ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtaxe, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left), AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GlassButton2)
        Me.GroupBox1.Controls.Add(Me.GlassButton1)
        Me.GroupBox1.Controls.Add(Me.GlassButton0)
        Me.GroupBox1.Controls.Add(Me.dgroupe)
        Me.GroupBox1.Location = New Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(371, 326)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "groupe"
        '
        'GlassButton2
        '
        Me.GlassButton2.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GlassButton2.AutoEllipsis = True
        Me.GlassButton2.BackColor = Color.Navy
        Me.GlassButton2.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton2.GlowColor = Color.Blue
        Me.GlassButton2.Image = CType(resources.GetObject("GlassButton2.Image"), Image)
        Me.GlassButton2.ImageAlign = ContentAlignment.TopLeft
        Me.GlassButton2.Location = New Point(252, 287)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.OuterBorderColor = Color.Transparent
        Me.GlassButton2.ShineColor = Color.Transparent
        Me.GlassButton2.Size = New Size(104, 33)
        Me.GlassButton2.TabIndex = 28
        Me.GlassButton2.Tag = "1"
        Me.GlassButton2.Text = "envoi"
        Me.GlassButton2.TextAlign = ContentAlignment.MiddleLeft
        Me.GlassButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'GlassButton1
        '
        Me.GlassButton1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GlassButton1.AutoEllipsis = True
        Me.GlassButton1.BackColor = Color.Navy
        Me.GlassButton1.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton1.GlowColor = Color.Red
        Me.GlassButton1.Image = CType(resources.GetObject("GlassButton1.Image"), Image)
        Me.GlassButton1.ImageAlign = ContentAlignment.TopLeft
        Me.GlassButton1.Location = New Point(117, 287)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.OuterBorderColor = Color.Transparent
        Me.GlassButton1.ShineColor = Color.Transparent
        Me.GlassButton1.Size = New Size(104, 33)
        Me.GlassButton1.TabIndex = 27
        Me.GlassButton1.Tag = "1"
        Me.GlassButton1.Text = "supprimer"
        Me.GlassButton1.TextAlign = ContentAlignment.MiddleLeft
        Me.GlassButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'GlassButton0
        '
        Me.GlassButton0.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GlassButton0.AutoEllipsis = True
        Me.GlassButton0.BackColor = Color.Navy
        Me.GlassButton0.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton0.GlowColor = Color.Lime
        Me.GlassButton0.Image = CType(resources.GetObject("GlassButton0.Image"), Image)
        Me.GlassButton0.ImageAlign = ContentAlignment.TopLeft
        Me.GlassButton0.Location = New Point(6, 287)
        Me.GlassButton0.Name = "GlassButton0"
        Me.GlassButton0.OuterBorderColor = Color.Transparent
        Me.GlassButton0.ShineColor = Color.Transparent
        Me.GlassButton0.Size = New Size(104, 33)
        Me.GlassButton0.TabIndex = 26
        Me.GlassButton0.Tag = "1"
        Me.GlassButton0.Text = "ajouter"
        Me.GlassButton0.TextAlign = ContentAlignment.MiddleLeft
        Me.GlassButton0.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'dgroupe
        '
        Me.dgroupe.AllowUserToAddRows = False
        Me.dgroupe.AllowUserToDeleteRows = False
        Me.dgroupe.AllowUserToOrderColumns = True
        Me.dgroupe.AllowUserToResizeRows = False
        Me.dgroupe.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.dgroupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgroupe.Columns.AddRange(New DataGridViewColumn() {Me.e, Me.Column3})
        Me.dgroupe.Location = New Point(6, 19)
        Me.dgroupe.Name = "dgroupe"
        Me.dgroupe.Size = New Size(359, 262)
        Me.dgroupe.TabIndex = 0
        '
        'e
        '
        Me.e.HeaderText = ""
        Me.e.Name = "e"
        Me.e.Width = 20
        '
        'Column3
        '
        Me.Column3.HeaderText = "nomgroupe"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GlassButton5)
        Me.GroupBox2.Controls.Add(Me.GlassButton4)
        Me.GroupBox2.Controls.Add(Me.GlassButton3)
        Me.GroupBox2.Controls.Add(Me.dtaxe)
        Me.GroupBox2.Location = New Point(380, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New Size(369, 326)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "taxe"
        '
        'GlassButton5
        '
        Me.GlassButton5.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton5.AutoEllipsis = True
        Me.GlassButton5.BackColor = Color.Navy
        Me.GlassButton5.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton5.GlowColor = Color.Blue
        Me.GlassButton5.Image = CType(resources.GetObject("GlassButton5.Image"), Image)
        Me.GlassButton5.ImageAlign = ContentAlignment.TopLeft
        Me.GlassButton5.Location = New Point(259, 287)
        Me.GlassButton5.Name = "GlassButton5"
        Me.GlassButton5.OuterBorderColor = Color.Transparent
        Me.GlassButton5.ShineColor = Color.Transparent
        Me.GlassButton5.Size = New Size(104, 33)
        Me.GlassButton5.TabIndex = 29
        Me.GlassButton5.Tag = "1"
        Me.GlassButton5.Text = "envoi"
        Me.GlassButton5.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'GlassButton4
        '
        Me.GlassButton4.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GlassButton4.AutoEllipsis = True
        Me.GlassButton4.BackColor = Color.Navy
        Me.GlassButton4.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton4.GlowColor = Color.Red
        Me.GlassButton4.Image = CType(resources.GetObject("GlassButton4.Image"), Image)
        Me.GlassButton4.ImageAlign = ContentAlignment.TopLeft
        Me.GlassButton4.Location = New Point(116, 287)
        Me.GlassButton4.Name = "GlassButton4"
        Me.GlassButton4.OuterBorderColor = Color.Transparent
        Me.GlassButton4.ShineColor = Color.Transparent
        Me.GlassButton4.Size = New Size(104, 33)
        Me.GlassButton4.TabIndex = 28
        Me.GlassButton4.Tag = "1"
        Me.GlassButton4.Text = "supprimer"
        Me.GlassButton4.TextAlign = ContentAlignment.MiddleLeft
        Me.GlassButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'GlassButton3
        '
        Me.GlassButton3.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GlassButton3.AutoEllipsis = True
        Me.GlassButton3.BackColor = Color.Navy
        Me.GlassButton3.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton3.GlowColor = Color.Lime
        Me.GlassButton3.Image = CType(resources.GetObject("GlassButton3.Image"), Image)
        Me.GlassButton3.ImageAlign = ContentAlignment.TopLeft
        Me.GlassButton3.Location = New Point(6, 287)
        Me.GlassButton3.Name = "GlassButton3"
        Me.GlassButton3.OuterBorderColor = Color.Transparent
        Me.GlassButton3.ShineColor = Color.Transparent
        Me.GlassButton3.Size = New Size(104, 33)
        Me.GlassButton3.TabIndex = 27
        Me.GlassButton3.Tag = "1"
        Me.GlassButton3.Text = "ajouter"
        Me.GlassButton3.TextAlign = ContentAlignment.MiddleLeft
        Me.GlassButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'dtaxe
        '
        Me.dtaxe.AllowUserToAddRows = False
        Me.dtaxe.AllowUserToDeleteRows = False
        Me.dtaxe.AllowUserToResizeRows = False
        Me.dtaxe.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.dtaxe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaxe.Columns.AddRange(New DataGridViewColumn() {Me.e2, Me.Column1, Me.Column2})
        Me.dtaxe.Location = New Point(6, 19)
        Me.dtaxe.Name = "dtaxe"
        Me.dtaxe.Size = New Size(357, 262)
        Me.dtaxe.TabIndex = 0
        '
        'e2
        '
        Me.e2.HeaderText = ""
        Me.e2.Name = "e2"
        Me.e2.Width = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "TaxName"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "taux"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'basegroupe
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(752, 333)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "basegroupe"
        Me.Text = "groupe"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgroupe, ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtaxe, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GlassButton2 As GlassButton
    Friend WithEvents GlassButton1 As GlassButton
    Friend WithEvents GlassButton0 As GlassButton
    Friend WithEvents GlassButton5 As GlassButton
    Friend WithEvents GlassButton4 As GlassButton
    Friend WithEvents GlassButton3 As GlassButton
    Public WithEvents dtaxe As DataGridView
    Public WithEvents dgroupe As DataGridView
    Friend WithEvents e As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents e2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
