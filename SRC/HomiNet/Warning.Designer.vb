Imports System.ComponentModel
Imports Glass
Imports HomiNet.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Warning
    Inherits Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle
        Me.dgvWarning = New DataGridView
        Me.gbWarnigPrint = New GlassButton
        Me.GroupBox1 = New GroupBox
        Me.chkbLandscape = New CheckBox
        Me.imprimante = New ComboBox
        Me.lblTroubleCount = New Label
        CType(Me.dgvWarning, ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvWarning
        '
        Me.dgvWarning.AllowUserToAddRows = False
        Me.dgvWarning.AllowUserToDeleteRows = False
        Me.dgvWarning.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.LightYellow
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.[True]
        Me.dgvWarning.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvWarning.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.dgvWarning.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(177, Byte))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.[True]
        Me.dgvWarning.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvWarning.Location = New Point(-1, 27)
        Me.dgvWarning.Name = "dgvWarning"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.[True]
        Me.dgvWarning.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvWarning.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvWarning.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
        Me.dgvWarning.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvWarning.Size = New Size(784, 358)
        Me.dgvWarning.TabIndex = 0
        '
        'gbWarnigPrint
        '
        Me.gbWarnigPrint.BackColor = Color.Navy
        Me.gbWarnigPrint.GlowColor = Color.Blue
        Me.gbWarnigPrint.Image = imp24
        Me.gbWarnigPrint.Location = New Point(13, 19)
        Me.gbWarnigPrint.Name = "gbWarnigPrint"
        Me.gbWarnigPrint.Size = New Size(171, 32)
        Me.gbWarnigPrint.TabIndex = 2
        Me.gbWarnigPrint.Text = "GlassButton2"
        Me.gbWarnigPrint.TextImageRelation = TextImageRelation.ImageBeforeText
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkbLandscape)
        Me.GroupBox1.Controls.Add(Me.imprimante)
        Me.GroupBox1.Controls.Add(Me.gbWarnigPrint)
        Me.GroupBox1.Location = New Point(-1, 391)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(784, 69)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'chkbLandscape
        '
        Me.chkbLandscape.AutoSize = True
        Me.chkbLandscape.Location = New Point(556, 24)
        Me.chkbLandscape.Name = "chkbLandscape"
        Me.chkbLandscape.Size = New Size(81, 17)
        Me.chkbLandscape.TabIndex = 42
        Me.chkbLandscape.Text = "CheckBox1"
        Me.chkbLandscape.UseVisualStyleBackColor = True
        '
        'imprimante
        '
        Me.imprimante.FormattingEnabled = True
        Me.imprimante.Location = New Point(250, 24)
        Me.imprimante.Name = "imprimante"
        Me.imprimante.Size = New Size(285, 21)
        Me.imprimante.TabIndex = 41
        '
        'lblTroubleCount
        '
        Me.lblTroubleCount.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.lblTroubleCount.BackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTroubleCount.Font = New Font("Arial Black", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroubleCount.ForeColor = Color.White
        Me.lblTroubleCount.Location = New Point(0, 1)
        Me.lblTroubleCount.Name = "lblTroubleCount"
        Me.lblTroubleCount.Size = New Size(783, 23)
        Me.lblTroubleCount.TabIndex = 40
        Me.lblTroubleCount.Text = "Count"
        '
        'Warning
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(784, 462)
        Me.Controls.Add(Me.lblTroubleCount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvWarning)
        Me.Name = "Warning"
        Me.Text = "Warning"
        CType(Me.dgvWarning, ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvWarning As DataGridView
    Friend WithEvents gbWarnigPrint As GlassButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTroubleCount As Label
    Friend WithEvents imprimante As ComboBox
    Friend WithEvents chkbLandscape As CheckBox
End Class
