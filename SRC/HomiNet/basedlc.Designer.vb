Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class basedlc
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(basedlc))
        Me.dch = New DataGridView
        Me.dfrigo1 = New DataGridView
        Me.Timer1 = New Timer(Me.components)
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.dfrigo2 = New DataGridView
        Me.DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New DataGridViewTextBoxColumn
        Me.Panel1 = New Panel
        CType(Me.dch, ISupportInitialize).BeginInit()
        CType(Me.dfrigo1, ISupportInitialize).BeginInit()
        CType(Me.dfrigo2, ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dch
        '
        Me.dch.AllowUserToAddRows = False
        Me.dch.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = Color.Black
        Me.dch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dch.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
                    Or AnchorStyles.Left), AnchorStyles)
        Me.dch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dch.BackgroundColor = Color.Gray
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.[True]
        Me.dch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dch.GridColor = Color.DarkGray
        Me.dch.Location = New Point(12, 9)
        Me.dch.MultiSelect = False
        Me.dch.Name = "dch"
        Me.dch.ReadOnly = True
        Me.dch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dch.Size = New Size(214, 321)
        Me.dch.TabIndex = 0
        '
        'dfrigo1
        '
        Me.dfrigo1.AllowUserToAddRows = False
        Me.dfrigo1.AllowUserToDeleteRows = False
        Me.dfrigo1.AllowUserToResizeColumns = False
        Me.dfrigo1.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.ForeColor = Color.Black
        Me.dfrigo1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dfrigo1.BackgroundColor = Color.LightSteelBlue
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.[True]
        Me.dfrigo1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Arial Black", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.NullValue = " "
        DataGridViewCellStyle5.SelectionBackColor = Color.Lavender
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.[False]
        Me.dfrigo1.DefaultCellStyle = DataGridViewCellStyle5
        Me.dfrigo1.Dock = DockStyle.Fill
        Me.dfrigo1.GridColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dfrigo1.Location = New Point(0, 0)
        Me.dfrigo1.Margin = New Padding(0)
        Me.dfrigo1.MultiSelect = False
        Me.dfrigo1.Name = "dfrigo1"
        Me.dfrigo1.RowHeadersVisible = False
        Me.dfrigo1.RowHeadersWidth = 31
        Me.dfrigo1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dfrigo1.ScrollBars = ScrollBars.None
        Me.dfrigo1.Size = New Size(501, 178)
        Me.dfrigo1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.Label1.BackColor = Color.Navy
        Me.Label1.Font = New Font("Arial Black", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = Color.White
        Me.Label1.Location = New Point(246, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(501, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.Label2.BackColor = Color.Navy
        Me.Label2.Font = New Font("Arial Black", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = Color.White
        Me.Label2.Location = New Point(246, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(501, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = ContentAlignment.MiddleLeft
        '
        'dfrigo2
        '
        Me.dfrigo2.AllowUserToAddRows = False
        Me.dfrigo2.AllowUserToDeleteRows = False
        Me.dfrigo2.AllowUserToResizeColumns = False
        Me.dfrigo2.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.ForeColor = Color.Black
        Me.dfrigo2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dfrigo2.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.dfrigo2.BackgroundColor = Color.LightSteelBlue
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.[True]
        Me.dfrigo2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dfrigo2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dfrigo2.Columns.AddRange(New DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.White
        DataGridViewCellStyle8.Font = New Font("Arial Black", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = Color.Black
        DataGridViewCellStyle8.NullValue = " "
        DataGridViewCellStyle8.SelectionBackColor = Color.Lavender
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.[False]
        Me.dfrigo2.DefaultCellStyle = DataGridViewCellStyle8
        Me.dfrigo2.GridColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dfrigo2.Location = New Point(246, 240)
        Me.dfrigo2.Margin = New Padding(0)
        Me.dfrigo2.MultiSelect = False
        Me.dfrigo2.Name = "dfrigo2"
        Me.dfrigo2.RowHeadersVisible = False
        Me.dfrigo2.RowHeadersWidth = 31
        Me.dfrigo2.ScrollBars = ScrollBars.None
        Me.dfrigo2.Size = New Size(501, 70)
        Me.dfrigo2.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 31
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "2"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 31
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "3"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 31
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "4"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 32
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "5"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 31
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "6"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 31
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "7"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 31
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "8"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 31
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "9"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 31
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "10"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 31
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "11"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 31
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "12"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 32
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "13"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 31
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "14"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 31
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "15"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 31
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "16"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 31
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.Panel1.Controls.Add(Me.dfrigo1)
        Me.Panel1.Location = New Point(246, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Size(501, 178)
        Me.Panel1.TabIndex = 5
        '
        'basedlc
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(752, 333)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dfrigo2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dch)
        Me.ForeColor = Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "basedlc"
        Me.Text = "dlc"
        CType(Me.dch, ISupportInitialize).EndInit()
        CType(Me.dfrigo1, ISupportInitialize).EndInit()
        CType(Me.dfrigo2, ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dch As DataGridView
    Friend WithEvents dfrigo1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dfrigo2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
