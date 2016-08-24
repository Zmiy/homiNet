Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class basemodele
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(basemodele))
        Me.Panel2 = New Panel()
        Me.gbtnAdd = New GlassButton()
        Me.Label1 = New Label()
        Me.chkbIs226 = New CheckBox()
        Me.txtbCurrModeleName = New TextBox()
        Me.Panel1 = New Panel()
        Me.GroupBox2 = New GroupBox()
        Me.gbtnAlternateSetModele = New GlassButton()
        Me.gbtnRemove = New GlassButton()
        Me.dmod = New DataGridView()
        Me.gbtnSetModele = New GlassButton()
        Me.lstbListOfModels = New ListBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dmod, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((AnchorStyles.Bottom Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.Panel2.Controls.Add(Me.gbtnAdd)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.chkbIs226)
        Me.Panel2.Controls.Add(Me.txtbCurrModeleName)
        Me.Panel2.Location = New Point(4, 463)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Size(556, 45)
        Me.Panel2.TabIndex = 18
        '
        'gbtnAdd
        '
        Me.gbtnAdd.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
        Me.gbtnAdd.BackColor = Color.Navy
        Me.gbtnAdd.GlowColor = Color.Lime
        Me.gbtnAdd.Image = My.Resources.Resources.plus16
        Me.gbtnAdd.Location = New Point(293, 10)
        Me.gbtnAdd.Name = "gbtnAdd"
        Me.gbtnAdd.Size = New Size(145, 23)
        Me.gbtnAdd.TabIndex = 0
        Me.gbtnAdd.Text = "Add Modele"
        Me.gbtnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
        Me.Label1.Location = New Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(137, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'chkbIs226
        '
        Me.chkbIs226.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
        Me.chkbIs226.AutoSize = True
        Me.chkbIs226.Location = New Point(444, 14)
        Me.chkbIs226.Name = "chkbIs226"
        Me.chkbIs226.Size = New Size(61, 17)
        Me.chkbIs226.TabIndex = 3
        Me.chkbIs226.Text = "Is 226?"
        Me.chkbIs226.UseVisualStyleBackColor = True
        Me.chkbIs226.Visible = False
        '
        'txtbCurrModeleName
        '
        Me.txtbCurrModeleName.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
        Me.txtbCurrModeleName.Location = New Point(151, 10)
        Me.txtbCurrModeleName.Name = "txtbCurrModeleName"
        Me.txtbCurrModeleName.Size = New Size(125, 20)
        Me.txtbCurrModeleName.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMinSize = New Size(1, 1)
        Me.Panel1.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Location = New Point(4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Size(556, 451)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.gbtnAlternateSetModele)
        Me.GroupBox2.Controls.Add(Me.gbtnRemove)
        Me.GroupBox2.Controls.Add(Me.dmod)
        Me.GroupBox2.Controls.Add(Me.gbtnSetModele)
        Me.GroupBox2.Controls.Add(Me.lstbListOfModels)
        Me.GroupBox2.Location = New Point(566, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New Size(562, 507)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'gbtnAlternateSetModele
        '
        Me.gbtnAlternateSetModele.BackColor = Color.Navy
        Me.gbtnAlternateSetModele.GlowColor = Color.Lime
        Me.gbtnAlternateSetModele.Location = New Point(201, 261)
        Me.gbtnAlternateSetModele.Name = "gbtnAlternateSetModele"
        Me.gbtnAlternateSetModele.Size = New Size(60, 35)
        Me.gbtnAlternateSetModele.TabIndex = 18
        Me.gbtnAlternateSetModele.Text = "Alternate Set"
        '
        'gbtnRemove
        '
        Me.gbtnRemove.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.gbtnRemove.BackColor = Color.Navy
        Me.gbtnRemove.GlowColor = Color.Red
        Me.gbtnRemove.Image = My.Resources.Resources.moin16
        Me.gbtnRemove.ImageAlign = ContentAlignment.MiddleLeft
        Me.gbtnRemove.Location = New Point(6, 478)
        Me.gbtnRemove.Name = "gbtnRemove"
        Me.gbtnRemove.Size = New Size(193, 23)
        Me.gbtnRemove.TabIndex = 15
        Me.gbtnRemove.Text = "Remove"
        Me.gbtnRemove.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'dmod
        '
        Me.dmod.AllowUserToAddRows = False
        Me.dmod.AllowUserToDeleteRows = False
        Me.dmod.AllowUserToResizeColumns = False
        Me.dmod.AllowUserToResizeRows = False
        Me.dmod.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.dmod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dmod.Location = New Point(262, 19)
        Me.dmod.Name = "dmod"
        Me.dmod.ReadOnly = True
        Me.dmod.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dmod.Size = New Size(291, 477)
        Me.dmod.TabIndex = 17
        '
        'gbtnSetModele
        '
        Me.gbtnSetModele.BackColor = Color.Navy
        Me.gbtnSetModele.GlowColor = Color.Lime
        Me.gbtnSetModele.Image = My.Resources.Resources.fleche48
        Me.gbtnSetModele.Location = New Point(201, 209)
        Me.gbtnSetModele.Name = "gbtnSetModele"
        Me.gbtnSetModele.Size = New Size(60, 46)
        Me.gbtnSetModele.TabIndex = 16
        '
        'lstbListOfModels
        '
        Me.lstbListOfModels.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
        Me.lstbListOfModels.FormattingEnabled = True
        Me.lstbListOfModels.Location = New Point(6, 19)
        Me.lstbListOfModels.Name = "lstbListOfModels"
        Me.lstbListOfModels.Size = New Size(193, 446)
        Me.lstbListOfModels.TabIndex = 0
        Me.lstbListOfModels.Tag = ""
        '
        'basemodele
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(1125, 520)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "basemodele"
        Me.Text = "modelemvs"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dmod, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbtnAdd As GlassButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbCurrModeleName As TextBox
    Friend WithEvents chkbIs226 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gbtnRemove As GlassButton
    Friend WithEvents dmod As DataGridView
    Friend WithEvents gbtnSetModele As GlassButton
    Friend WithEvents lstbListOfModels As ListBox
    Friend WithEvents gbtnAlternateSetModele As GlassButton
End Class
