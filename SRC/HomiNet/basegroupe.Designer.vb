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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(basegroupe))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbtnSendGroup = New Glass.GlassButton()
        Me.gbtnRemoveGroup = New Glass.GlassButton()
        Me.gbtnAddGroup = New Glass.GlassButton()
        Me.dgroupe = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GlassButton5 = New Glass.GlassButton()
        Me.GlassButton4 = New Glass.GlassButton()
        Me.GlassButton3 = New Glass.GlassButton()
        Me.dtaxe = New System.Windows.Forms.DataGridView()
        Me.e2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.e = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgroupe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtaxe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.gbtnSendGroup)
        Me.GroupBox1.Controls.Add(Me.gbtnRemoveGroup)
        Me.GroupBox1.Controls.Add(Me.gbtnAddGroup)
        Me.GroupBox1.Controls.Add(Me.dgroupe)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 326)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "groupe"
        '
        'gbtnSendGroup
        '
        Me.gbtnSendGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnSendGroup.AutoEllipsis = True
        Me.gbtnSendGroup.BackColor = System.Drawing.Color.Navy
        Me.gbtnSendGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnSendGroup.GlowColor = System.Drawing.Color.Blue
        Me.gbtnSendGroup.Image = CType(resources.GetObject("gbtnSendGroup.Image"), System.Drawing.Image)
        Me.gbtnSendGroup.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.gbtnSendGroup.Location = New System.Drawing.Point(252, 287)
        Me.gbtnSendGroup.Name = "gbtnSendGroup"
        Me.gbtnSendGroup.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnSendGroup.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnSendGroup.Size = New System.Drawing.Size(104, 33)
        Me.gbtnSendGroup.TabIndex = 28
        Me.gbtnSendGroup.Tag = "1"
        Me.gbtnSendGroup.Text = "envoi"
        Me.gbtnSendGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnSendGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'gbtnRemoveGroup
        '
        Me.gbtnRemoveGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnRemoveGroup.AutoEllipsis = True
        Me.gbtnRemoveGroup.BackColor = System.Drawing.Color.Navy
        Me.gbtnRemoveGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnRemoveGroup.GlowColor = System.Drawing.Color.Red
        Me.gbtnRemoveGroup.Image = CType(resources.GetObject("gbtnRemoveGroup.Image"), System.Drawing.Image)
        Me.gbtnRemoveGroup.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.gbtnRemoveGroup.Location = New System.Drawing.Point(117, 287)
        Me.gbtnRemoveGroup.Name = "gbtnRemoveGroup"
        Me.gbtnRemoveGroup.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnRemoveGroup.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnRemoveGroup.Size = New System.Drawing.Size(104, 33)
        Me.gbtnRemoveGroup.TabIndex = 27
        Me.gbtnRemoveGroup.Tag = "1"
        Me.gbtnRemoveGroup.Text = "supprimer"
        Me.gbtnRemoveGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnRemoveGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'gbtnAddGroup
        '
        Me.gbtnAddGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbtnAddGroup.AutoEllipsis = True
        Me.gbtnAddGroup.BackColor = System.Drawing.Color.Navy
        Me.gbtnAddGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnAddGroup.GlowColor = System.Drawing.Color.Lime
        Me.gbtnAddGroup.Image = CType(resources.GetObject("gbtnAddGroup.Image"), System.Drawing.Image)
        Me.gbtnAddGroup.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.gbtnAddGroup.Location = New System.Drawing.Point(6, 287)
        Me.gbtnAddGroup.Name = "gbtnAddGroup"
        Me.gbtnAddGroup.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnAddGroup.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnAddGroup.Size = New System.Drawing.Size(104, 33)
        Me.gbtnAddGroup.TabIndex = 26
        Me.gbtnAddGroup.Tag = "1"
        Me.gbtnAddGroup.Text = "ajouter"
        Me.gbtnAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnAddGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'dgroupe
        '
        Me.dgroupe.AllowUserToAddRows = False
        Me.dgroupe.AllowUserToDeleteRows = False
        Me.dgroupe.AllowUserToOrderColumns = True
        Me.dgroupe.AllowUserToResizeRows = False
        Me.dgroupe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgroupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgroupe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.e, Me.Column3, Me.Column4})
        Me.dgroupe.Location = New System.Drawing.Point(6, 20)
        Me.dgroupe.Name = "dgroupe"
        Me.dgroupe.Size = New System.Drawing.Size(359, 262)
        Me.dgroupe.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GlassButton5)
        Me.GroupBox2.Controls.Add(Me.GlassButton4)
        Me.GroupBox2.Controls.Add(Me.GlassButton3)
        Me.GroupBox2.Controls.Add(Me.dtaxe)
        Me.GroupBox2.Location = New System.Drawing.Point(380, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 326)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "taxe"
        '
        'GlassButton5
        '
        Me.GlassButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GlassButton5.AutoEllipsis = True
        Me.GlassButton5.BackColor = System.Drawing.Color.Navy
        Me.GlassButton5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton5.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton5.Image = CType(resources.GetObject("GlassButton5.Image"), System.Drawing.Image)
        Me.GlassButton5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.GlassButton5.Location = New System.Drawing.Point(259, 287)
        Me.GlassButton5.Name = "GlassButton5"
        Me.GlassButton5.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton5.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton5.Size = New System.Drawing.Size(104, 33)
        Me.GlassButton5.TabIndex = 29
        Me.GlassButton5.Tag = "1"
        Me.GlassButton5.Text = "envoi"
        Me.GlassButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'GlassButton4
        '
        Me.GlassButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GlassButton4.AutoEllipsis = True
        Me.GlassButton4.BackColor = System.Drawing.Color.Navy
        Me.GlassButton4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton4.GlowColor = System.Drawing.Color.Red
        Me.GlassButton4.Image = CType(resources.GetObject("GlassButton4.Image"), System.Drawing.Image)
        Me.GlassButton4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.GlassButton4.Location = New System.Drawing.Point(116, 287)
        Me.GlassButton4.Name = "GlassButton4"
        Me.GlassButton4.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton4.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton4.Size = New System.Drawing.Size(104, 33)
        Me.GlassButton4.TabIndex = 28
        Me.GlassButton4.Tag = "1"
        Me.GlassButton4.Text = "supprimer"
        Me.GlassButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GlassButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'GlassButton3
        '
        Me.GlassButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GlassButton3.AutoEllipsis = True
        Me.GlassButton3.BackColor = System.Drawing.Color.Navy
        Me.GlassButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton3.GlowColor = System.Drawing.Color.Lime
        Me.GlassButton3.Image = CType(resources.GetObject("GlassButton3.Image"), System.Drawing.Image)
        Me.GlassButton3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.GlassButton3.Location = New System.Drawing.Point(6, 287)
        Me.GlassButton3.Name = "GlassButton3"
        Me.GlassButton3.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton3.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton3.Size = New System.Drawing.Size(104, 33)
        Me.GlassButton3.TabIndex = 27
        Me.GlassButton3.Tag = "1"
        Me.GlassButton3.Text = "ajouter"
        Me.GlassButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GlassButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'dtaxe
        '
        Me.dtaxe.AllowUserToAddRows = False
        Me.dtaxe.AllowUserToDeleteRows = False
        Me.dtaxe.AllowUserToResizeRows = False
        Me.dtaxe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtaxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaxe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.e2, Me.Column1, Me.Column2})
        Me.dtaxe.Location = New System.Drawing.Point(6, 19)
        Me.dtaxe.Name = "dtaxe"
        Me.dtaxe.Size = New System.Drawing.Size(357, 262)
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
        'Column4
        '
        Me.Column4.HeaderText = "codegroupe"
        Me.Column4.Name = "Column4"
        '
        'basegroupe
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 333)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "basegroupe"
        Me.Text = "groupe"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgroupe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtaxe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gbtnSendGroup As GlassButton
    Friend WithEvents gbtnRemoveGroup As GlassButton
    Friend WithEvents gbtnAddGroup As GlassButton
    Friend WithEvents GlassButton5 As GlassButton
    Friend WithEvents GlassButton4 As GlassButton
    Friend WithEvents GlassButton3 As GlassButton
    Public WithEvents dtaxe As DataGridView
    Public WithEvents dgroupe As DataGridView
    Friend WithEvents e2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents e As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
