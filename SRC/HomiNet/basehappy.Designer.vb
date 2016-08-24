Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class basehappy
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(basehappy))
        Me.dh = New DataGridView()
        Me.Column1 = New DataGridViewTextBoxColumn()
        Me.Column2 = New DataGridViewTextBoxColumn()
        Me.Column3 = New DataGridViewTextBoxColumn()
        Me.Column4 = New DataGridViewTextBoxColumn()
        Me.Column5 = New DataGridViewTextBoxColumn()
        Me.Column6 = New DataGridViewTextBoxColumn()
        Me.Column7 = New DataGridViewTextBoxColumn()
        Me.Column8 = New DataGridViewTextBoxColumn()
        Me.Column9 = New DataGridViewTextBoxColumn()
        Me.Column10 = New DataGridViewTextBoxColumn()
        Me.Column11 = New DataGridViewTextBoxColumn()
        Me.Column12 = New DataGridViewTextBoxColumn()
        Me.GroupBox6 = New GroupBox()
        Me.CheckBox7 = New CheckBox()
        Me.CheckBox6 = New CheckBox()
        Me.CheckBox5 = New CheckBox()
        Me.CheckBox4 = New CheckBox()
        Me.CheckBox3 = New CheckBox()
        Me.CheckBox2 = New CheckBox()
        Me.CheckBox1 = New CheckBox()
        Me.GroupBox7 = New GroupBox()
        Me.hb = New DateTimePicker()
        Me.hf = New DateTimePicker()
        Me.rbtnHappyON = New RadioButton()
        Me.rbtnHappyOFF = New RadioButton()
        Me.Label3 = New Label()
        Me.db = New DateTimePicker()
        Me.df = New DateTimePicker()
        Me.Label4 = New Label()
        Me.GroupBox8 = New GroupBox()
        Me.rbtnPrice4 = New RadioButton()
        Me.rbtnPrice3 = New RadioButton()
        Me.rbtnPrice2 = New RadioButton()
        Me.rbtnPrice1 = New RadioButton()
        Me.GlassButton2 = New GlassButton()
        Me.GlassButton1 = New GlassButton()
        Me.GlassButton0 = New GlassButton()
        CType(Me.dh, ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'dh
        '
        Me.dh.AllowUserToAddRows = False
        Me.dh.AllowUserToDeleteRows = False
        Me.dh.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.dh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dh.Columns.AddRange(New DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.dh.Location = New Point(3, 2)
        Me.dh.Name = "dh"
        Me.dh.Size = New Size(745, 228)
        Me.dh.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Column9"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Column10"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Column11"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((AnchorStyles.Bottom Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.CheckBox7)
        Me.GroupBox6.Controls.Add(Me.CheckBox6)
        Me.GroupBox6.Controls.Add(Me.CheckBox5)
        Me.GroupBox6.Controls.Add(Me.CheckBox4)
        Me.GroupBox6.Controls.Add(Me.CheckBox3)
        Me.GroupBox6.Controls.Add(Me.CheckBox2)
        Me.GroupBox6.Controls.Add(Me.CheckBox1)
        Me.GroupBox6.Location = New Point(330, 236)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New Size(408, 117)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New Point(19, 83)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New Size(81, 17)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New Point(295, 49)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New Size(81, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New Point(160, 49)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New Size(81, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New Point(19, 49)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New Size(81, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New Point(295, 19)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New Size(81, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New Point(160, 19)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New Size(81, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New Point(19, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New Size(81, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.hb)
        Me.GroupBox7.Controls.Add(Me.hf)
        Me.GroupBox7.Controls.Add(Me.rbtnHappyON)
        Me.GroupBox7.Controls.Add(Me.rbtnHappyOFF)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.db)
        Me.GroupBox7.Controls.Add(Me.df)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Location = New Point(8, 236)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New Size(316, 117)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        '
        'hb
        '
        Me.hb.CustomFormat = "dd/mm/yyyy hh:mm:ss"
        Me.hb.Format = DateTimePickerFormat.Time
        Me.hb.Location = New Point(226, 19)
        Me.hb.Name = "hb"
        Me.hb.ShowUpDown = True
        Me.hb.Size = New Size(78, 20)
        Me.hb.TabIndex = 6
        '
        'hf
        '
        Me.hf.Format = DateTimePickerFormat.Time
        Me.hf.Location = New Point(226, 45)
        Me.hf.Name = "hf"
        Me.hf.ShowUpDown = True
        Me.hf.Size = New Size(78, 20)
        Me.hf.TabIndex = 7
        '
        'rbtnHappyON
        '
        Me.rbtnHappyON.AutoSize = True
        Me.rbtnHappyON.Location = New Point(22, 83)
        Me.rbtnHappyON.Name = "rbtnHappyON"
        Me.rbtnHappyON.Size = New Size(41, 17)
        Me.rbtnHappyON.TabIndex = 5
        Me.rbtnHappyON.Text = "ON"
        Me.rbtnHappyON.UseVisualStyleBackColor = True
        '
        'rbtnHappyOFF
        '
        Me.rbtnHappyOFF.AutoSize = True
        Me.rbtnHappyOFF.Checked = True
        Me.rbtnHappyOFF.Location = New Point(165, 83)
        Me.rbtnHappyOFF.Name = "rbtnHappyOFF"
        Me.rbtnHappyOFF.Size = New Size(45, 17)
        Me.rbtnHappyOFF.TabIndex = 4
        Me.rbtnHappyOFF.TabStop = True
        Me.rbtnHappyOFF.Text = "OFF"
        Me.rbtnHappyOFF.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label3"
        '
        'db
        '
        Me.db.CustomFormat = "dd/mm/yyyy hh:mm:ss"
        Me.db.Format = DateTimePickerFormat.[Short]
        Me.db.Location = New Point(110, 19)
        Me.db.Name = "db"
        Me.db.Size = New Size(94, 20)
        Me.db.TabIndex = 1
        '
        'df
        '
        Me.df.Format = DateTimePickerFormat.[Short]
        Me.df.Location = New Point(110, 45)
        Me.df.Name = "df"
        Me.df.Size = New Size(94, 20)
        Me.df.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Label4"
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.rbtnPrice4)
        Me.GroupBox8.Controls.Add(Me.rbtnPrice3)
        Me.GroupBox8.Controls.Add(Me.rbtnPrice2)
        Me.GroupBox8.Controls.Add(Me.rbtnPrice1)
        Me.GroupBox8.Location = New Point(8, 353)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New Size(316, 65)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "GroupBox8"
        '
        'rbtnPrice4
        '
        Me.rbtnPrice4.AutoSize = True
        Me.rbtnPrice4.Location = New Point(165, 42)
        Me.rbtnPrice4.Name = "rbtnPrice4"
        Me.rbtnPrice4.Size = New Size(58, 17)
        Me.rbtnPrice4.TabIndex = 9
        Me.rbtnPrice4.Text = "Price 4"
        Me.rbtnPrice4.UseVisualStyleBackColor = True
        '
        'rbtnPrice3
        '
        Me.rbtnPrice3.AutoSize = True
        Me.rbtnPrice3.Location = New Point(165, 19)
        Me.rbtnPrice3.Name = "rbtnPrice3"
        Me.rbtnPrice3.Size = New Size(58, 17)
        Me.rbtnPrice3.TabIndex = 8
        Me.rbtnPrice3.Text = "Price 3"
        Me.rbtnPrice3.UseVisualStyleBackColor = True
        '
        'rbtnPrice2
        '
        Me.rbtnPrice2.AutoSize = True
        Me.rbtnPrice2.Location = New Point(22, 42)
        Me.rbtnPrice2.Name = "rbtnPrice2"
        Me.rbtnPrice2.Size = New Size(58, 17)
        Me.rbtnPrice2.TabIndex = 7
        Me.rbtnPrice2.Text = "Price 2"
        Me.rbtnPrice2.UseVisualStyleBackColor = True
        '
        'rbtnPrice1
        '
        Me.rbtnPrice1.AutoSize = True
        Me.rbtnPrice1.Location = New Point(22, 19)
        Me.rbtnPrice1.Name = "rbtnPrice1"
        Me.rbtnPrice1.Size = New Size(58, 17)
        Me.rbtnPrice1.TabIndex = 6
        Me.rbtnPrice1.Text = "Price 1"
        Me.rbtnPrice1.UseVisualStyleBackColor = True
        '
        'GlassButton2
        '
        Me.GlassButton2.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        Me.GlassButton2.AutoEllipsis = True
        Me.GlassButton2.BackColor = Color.Navy
        Me.GlassButton2.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton2.GlowColor = Color.Blue
        Me.GlassButton2.Image = My.Resources.Resources.envoi24
        Me.GlassButton2.ImageAlign = ContentAlignment.TopCenter
        Me.GlassButton2.Location = New Point(616, 385)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.OuterBorderColor = Color.Transparent
        Me.GlassButton2.ShineColor = Color.Transparent
        Me.GlassButton2.Size = New Size(124, 33)
        Me.GlassButton2.TabIndex = 34
        Me.GlassButton2.Tag = "1"
        Me.GlassButton2.Text = "envoi"
        Me.GlassButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'GlassButton1
        '
        Me.GlassButton1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GlassButton1.AutoEllipsis = True
        Me.GlassButton1.BackColor = Color.Navy
        Me.GlassButton1.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton1.GlowColor = Color.Red
        Me.GlassButton1.Image = My.Resources.Resources.moins24
        Me.GlassButton1.ImageAlign = ContentAlignment.TopCenter
        Me.GlassButton1.Location = New Point(473, 385)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.OuterBorderColor = Color.Transparent
        Me.GlassButton1.ShineColor = Color.Transparent
        Me.GlassButton1.Size = New Size(124, 33)
        Me.GlassButton1.TabIndex = 33
        Me.GlassButton1.Tag = "1"
        Me.GlassButton1.Text = "supprimer"
        Me.GlassButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'GlassButton0
        '
        Me.GlassButton0.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GlassButton0.AutoEllipsis = True
        Me.GlassButton0.BackColor = Color.Navy
        Me.GlassButton0.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton0.GlowColor = Color.Lime
        Me.GlassButton0.Image = My.Resources.Resources.plus24
        Me.GlassButton0.ImageAlign = ContentAlignment.TopCenter
        Me.GlassButton0.Location = New Point(343, 385)
        Me.GlassButton0.Name = "GlassButton0"
        Me.GlassButton0.OuterBorderColor = Color.Transparent
        Me.GlassButton0.ShineColor = Color.Transparent
        Me.GlassButton0.Size = New Size(124, 33)
        Me.GlassButton0.TabIndex = 32
        Me.GlassButton0.Tag = "1"
        Me.GlassButton0.Text = "ajouter"
        Me.GlassButton0.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'basehappy
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(752, 426)
        Me.Controls.Add(Me.GlassButton2)
        Me.Controls.Add(Me.GlassButton1)
        Me.Controls.Add(Me.GlassButton0)
        Me.Controls.Add(Me.dh)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.ForeColor = Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "basehappy"
        Me.Text = "happyhours"
        CType(Me.dh, ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dh As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents db As DateTimePicker
    Friend WithEvents df As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents rbtnHappyON As RadioButton
    Friend WithEvents rbtnHappyOFF As RadioButton
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents rbtnPrice4 As RadioButton
    Friend WithEvents rbtnPrice3 As RadioButton
    Friend WithEvents rbtnPrice2 As RadioButton
    Friend WithEvents rbtnPrice1 As RadioButton
    Friend WithEvents GlassButton2 As GlassButton
    Friend WithEvents GlassButton1 As GlassButton
    Friend WithEvents GlassButton0 As GlassButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents hb As DateTimePicker
    Friend WithEvents hf As DateTimePicker
End Class
