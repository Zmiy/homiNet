Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class baseproduit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(baseproduit))
        Me.dproduit = New System.Windows.Forms.DataGridView()
        Me.e = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GlassButton2 = New Glass.GlassButton()
        Me.GlassButton1 = New Glass.GlassButton()
        Me.GlassButton0 = New Glass.GlassButton()
        CType(Me.dproduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dproduit
        '
        Me.dproduit.AllowUserToAddRows = False
        Me.dproduit.AllowUserToDeleteRows = False
        Me.dproduit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dproduit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.e, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dproduit.Location = New System.Drawing.Point(1, 0)
        Me.dproduit.Name = "dproduit"
        Me.dproduit.Size = New System.Drawing.Size(752, 293)
        Me.dproduit.TabIndex = 0
        '
        'e
        '
        Me.e.HeaderText = ""
        Me.e.Name = "e"
        Me.e.Width = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "nom1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "nom2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "nom3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "groupe"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "taxe"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "prix1"
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column7
        '
        Me.Column7.HeaderText = "prix2"
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column8
        '
        Me.Column8.HeaderText = "prix3"
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column9
        '
        Me.Column9.HeaderText = "prix4"
        Me.Column9.Name = "Column9"
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column10
        '
        Me.Column10.HeaderText = "dlc"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "stock"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "alarme1"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "alarm2"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "safe"
        Me.Column14.Name = "Column14"
        '
        'GlassButton2
        '
        Me.GlassButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GlassButton2.AutoEllipsis = True
        Me.GlassButton2.BackColor = System.Drawing.Color.Navy
        Me.GlassButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton2.GlowColor = System.Drawing.Color.Blue
        Me.GlassButton2.Image = Global.HomiNet.My.Resources.Resources.envoi24
        Me.GlassButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GlassButton2.Location = New System.Drawing.Point(616, 299)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton2.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton2.Size = New System.Drawing.Size(124, 33)
        Me.GlassButton2.TabIndex = 31
        Me.GlassButton2.Tag = "1"
        Me.GlassButton2.Text = "envoi"
        Me.GlassButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'GlassButton1
        '
        Me.GlassButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GlassButton1.AutoEllipsis = True
        Me.GlassButton1.BackColor = System.Drawing.Color.Navy
        Me.GlassButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton1.GlowColor = System.Drawing.Color.Red
        Me.GlassButton1.Image = Global.HomiNet.My.Resources.Resources.moins24
        Me.GlassButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GlassButton1.Location = New System.Drawing.Point(131, 299)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton1.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton1.Size = New System.Drawing.Size(124, 33)
        Me.GlassButton1.TabIndex = 30
        Me.GlassButton1.Tag = "1"
        Me.GlassButton1.Text = "supprimer"
        Me.GlassButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'GlassButton0
        '
        Me.GlassButton0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GlassButton0.AutoEllipsis = True
        Me.GlassButton0.BackColor = System.Drawing.Color.Navy
        Me.GlassButton0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton0.GlowColor = System.Drawing.Color.Lime
        Me.GlassButton0.Image = Global.HomiNet.My.Resources.Resources.plus24
        Me.GlassButton0.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GlassButton0.Location = New System.Drawing.Point(1, 299)
        Me.GlassButton0.Name = "GlassButton0"
        Me.GlassButton0.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton0.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton0.Size = New System.Drawing.Size(124, 33)
        Me.GlassButton0.TabIndex = 29
        Me.GlassButton0.Tag = "1"
        Me.GlassButton0.Text = "ajouter"
        Me.GlassButton0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'baseproduit
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 333)
        Me.Controls.Add(Me.GlassButton2)
        Me.Controls.Add(Me.GlassButton1)
        Me.Controls.Add(Me.GlassButton0)
        Me.Controls.Add(Me.dproduit)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "baseproduit"
        Me.Text = "produit"
        CType(Me.dproduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dproduit As DataGridView
    Friend WithEvents GlassButton2 As GlassButton
    Friend WithEvents GlassButton1 As GlassButton
    Friend WithEvents GlassButton0 As GlassButton
    Friend WithEvents e As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents Column5 As DataGridViewComboBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewCheckBoxColumn
End Class
