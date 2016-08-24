Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class journalrefill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(journalrefill))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.d1 = New System.Windows.Forms.MonthCalendar()
        Me.btnRefillJournalUpdate = New Glass.GlassButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dj = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.imprimante = New System.Windows.Forms.ComboBox()
        Me.gbtnPrint = New Glass.GlassButton()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.lblRefilledRoom = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'd1
        '
        Me.d1.Location = New System.Drawing.Point(12, 14)
        Me.d1.MaxSelectionCount = 1
        Me.d1.Name = "d1"
        Me.d1.ShowWeekNumbers = True
        Me.d1.TabIndex = 0
        '
        'btnRefillJournalUpdate
        '
        Me.btnRefillJournalUpdate.AutoEllipsis = True
        Me.btnRefillJournalUpdate.BackColor = System.Drawing.Color.DarkGreen
        Me.btnRefillJournalUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefillJournalUpdate.GlowColor = System.Drawing.Color.Lime
        Me.btnRefillJournalUpdate.Image = CType(resources.GetObject("btnRefillJournalUpdate.Image"), System.Drawing.Image)
        Me.btnRefillJournalUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRefillJournalUpdate.Location = New System.Drawing.Point(12, 171)
        Me.btnRefillJournalUpdate.Name = "btnRefillJournalUpdate"
        Me.btnRefillJournalUpdate.OuterBorderColor = System.Drawing.Color.Transparent
        Me.btnRefillJournalUpdate.ShineColor = System.Drawing.Color.Transparent
        Me.btnRefillJournalUpdate.Size = New System.Drawing.Size(247, 32)
        Me.btnRefillJournalUpdate.TabIndex = 38
        Me.btnRefillJournalUpdate.Text = "Remplissage"
        Me.btnRefillJournalUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefillJournalUpdate.UseCompatibleTextRendering = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.d1)
        Me.GroupBox1.Controls.Add(Me.btnRefillJournalUpdate)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 212)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(844, 46)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(117, 19)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton5.TabIndex = 6
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(689, 18)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(47, 20)
        Me.TextBox1.TabIndex = 5
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(248, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(591, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(355, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(471, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(274, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 23)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dj
        '
        Me.dj.AllowUserToAddRows = False
        Me.dj.AllowUserToDeleteRows = False
        Me.dj.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dj.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dj.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dj.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dj.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.NullValue = " "
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dj.DefaultCellStyle = DataGridViewCellStyle3
        Me.dj.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dj.Location = New System.Drawing.Point(273, 75)
        Me.dj.Margin = New System.Windows.Forms.Padding(0)
        Me.dj.MultiSelect = False
        Me.dj.Name = "dj"
        Me.dj.ReadOnly = True
        Me.dj.RowHeadersVisible = False
        Me.dj.RowHeadersWidth = 31
        Me.dj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dj.Size = New System.Drawing.Size(574, 381)
        Me.dj.TabIndex = 41
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.imprimante)
        Me.GroupBox3.Controls.Add(Me.gbtnPrint)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 186)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(12, 105)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 44
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'imprimante
        '
        Me.imprimante.FormattingEnabled = True
        Me.imprimante.Location = New System.Drawing.Point(12, 78)
        Me.imprimante.Name = "imprimante"
        Me.imprimante.Size = New System.Drawing.Size(247, 21)
        Me.imprimante.TabIndex = 43
        '
        'gbtnPrint
        '
        Me.gbtnPrint.AutoEllipsis = True
        Me.gbtnPrint.BackColor = System.Drawing.Color.Navy
        Me.gbtnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnPrint.GlowColor = System.Drawing.Color.Blue
        Me.gbtnPrint.Image = Global.HomiNet.My.Resources.Resources.imp24
        Me.gbtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gbtnPrint.Location = New System.Drawing.Point(12, 42)
        Me.gbtnPrint.Name = "gbtnPrint"
        Me.gbtnPrint.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnPrint.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnPrint.Size = New System.Drawing.Size(247, 33)
        Me.gbtnPrint.TabIndex = 42
        Me.gbtnPrint.Text = "Remplissage"
        Me.gbtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gbtnPrint.UseCompatibleTextRendering = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(12, 19)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'lblRefilledRoom
        '
        Me.lblRefilledRoom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRefilledRoom.BackColor = System.Drawing.Color.Navy
        Me.lblRefilledRoom.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefilledRoom.ForeColor = System.Drawing.Color.White
        Me.lblRefilledRoom.Location = New System.Drawing.Point(518, 52)
        Me.lblRefilledRoom.Name = "lblRefilledRoom"
        Me.lblRefilledRoom.Size = New System.Drawing.Size(329, 23)
        Me.lblRefilledRoom.TabIndex = 44
        Me.lblRefilledRoom.Text = "Label1"
        Me.lblRefilledRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'journalrefill
        '
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(852, 468)
        Me.Controls.Add(Me.lblRefilledRoom)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dj)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "journalrefill"
        Me.Text = "journalrefill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents d1 As MonthCalendar
    Friend WithEvents btnRefillJournalUpdate As GlassButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dj As DataGridView
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents imprimante As ComboBox
    Friend WithEvents gbtnPrint As GlassButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents lblRefilledRoom As Label
End Class
