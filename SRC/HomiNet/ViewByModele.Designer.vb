Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class ViewByModele
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewByModele))
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.dgvExtView = New System.Windows.Forms.DataGridView()
        Me.gradpnlSearch = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.gbtnFind = New Glass.GlassButton()
        Me.tbFind = New System.Windows.Forms.TextBox()
        Me.lblRooms = New System.Windows.Forms.Label()
        Me.gbLegend = New System.Windows.Forms.GroupBox()
        Me.tblpanelLegend = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnLock = New Glass.GlassButton()
        Me.lblBalanceText = New System.Windows.Forms.Label()
        Me.lblBalanceDescr = New System.Windows.Forms.Label()
        Me.lblItemsNbText = New System.Windows.Forms.Label()
        Me.lblIntemsNbDescr = New System.Windows.Forms.Label()
        Me.lbManualHistory = New System.Windows.Forms.ListBox()
        Me.btnUnlock = New Glass.GlassButton()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.btnSend = New Glass.GlassButton()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.GlassButton9 = New Glass.GlassButton()
        Me.lblServiceSwitchDesc = New System.Windows.Forms.Label()
        Me.lblTempText = New System.Windows.Forms.Label()
        Me.lblTempDesc = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlLegend = New System.Windows.Forms.Panel()
        Me.pbSW = New System.Windows.Forms.PictureBox()
        Me.pbMinibar = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cmsFiltersForExtView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiToRefill = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlLeft.SuspendLayout()
        CType(Me.dgvExtView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gradpnlSearch.SuspendLayout()
        Me.gbLegend.SuspendLayout()
        Me.tblpanelLegend.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlLegend.SuspendLayout()
        CType(Me.pbSW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinibar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsFiltersForExtView.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLeft.Controls.Add(Me.lblCount)
        Me.pnlLeft.Controls.Add(Me.dgvExtView)
        Me.pnlLeft.Controls.Add(Me.gradpnlSearch)
        Me.pnlLeft.Controls.Add(Me.lblRooms)
        Me.pnlLeft.Location = New System.Drawing.Point(1, 82)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(253, 510)
        Me.pnlLeft.TabIndex = 0
        '
        'dgvExtView
        '
        Me.dgvExtView.AllowUserToDeleteRows = False
        Me.dgvExtView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvExtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExtView.ContextMenuStrip = Me.cmsFiltersForExtView
        Me.dgvExtView.Location = New System.Drawing.Point(0, 33)
        Me.dgvExtView.Name = "dgvExtView"
        Me.dgvExtView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExtView.Size = New System.Drawing.Size(249, 440)
        Me.dgvExtView.TabIndex = 3
        '
        'gradpnlSearch
        '
        Me.gradpnlSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.gradpnlSearch.Border = True
        Me.gradpnlSearch.BorderColor = System.Drawing.Color.Black
        Me.gradpnlSearch.Colors.Add(Me.ColorWithAlpha1)
        Me.gradpnlSearch.Colors.Add(Me.ColorWithAlpha2)
        Me.gradpnlSearch.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.gradpnlSearch.Controls.Add(Me.gbtnFind)
        Me.gradpnlSearch.Controls.Add(Me.tbFind)
        Me.gradpnlSearch.CornerRadius = 8
        Me.gradpnlSearch.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.gradpnlSearch.Gradient = True
        Me.gradpnlSearch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gradpnlSearch.GradientOffset = 1.0!
        Me.gradpnlSearch.GradientSize = New System.Drawing.Size(0, 0)
        Me.gradpnlSearch.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.gradpnlSearch.Grayscale = False
        Me.gradpnlSearch.Image = Nothing
        Me.gradpnlSearch.ImageAlpha = 75
        Me.gradpnlSearch.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.gradpnlSearch.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.gradpnlSearch.ImageSize = New System.Drawing.Size(48, 48)
        Me.gradpnlSearch.Location = New System.Drawing.Point(46, 1)
        Me.gradpnlSearch.Name = "gradpnlSearch"
        Me.gradpnlSearch.Rounded = True
        Me.gradpnlSearch.Size = New System.Drawing.Size(152, 33)
        Me.gradpnlSearch.TabIndex = 41
        Me.gradpnlSearch.Visible = False
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha1.Parent = Me.gradpnlSearch
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha2.Parent = Me.gradpnlSearch
        '
        'gbtnFind
        '
        Me.gbtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbtnFind.Image = CType(resources.GetObject("gbtnFind.Image"), System.Drawing.Image)
        Me.gbtnFind.Location = New System.Drawing.Point(104, 3)
        Me.gbtnFind.Name = "gbtnFind"
        Me.gbtnFind.OuterBorderColor = System.Drawing.Color.Transparent
        Me.gbtnFind.ShineColor = System.Drawing.Color.Transparent
        Me.gbtnFind.Size = New System.Drawing.Size(36, 28)
        Me.gbtnFind.TabIndex = 2
        '
        'tbFind
        '
        Me.tbFind.AcceptsReturn = True
        Me.tbFind.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.tbFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbFind.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbFind.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbFind.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFind.Location = New System.Drawing.Point(11, 5)
        Me.tbFind.Margin = New System.Windows.Forms.Padding(0)
        Me.tbFind.Name = "tbFind"
        Me.tbFind.ShortcutsEnabled = False
        Me.tbFind.Size = New System.Drawing.Size(90, 23)
        Me.tbFind.TabIndex = 1
        '
        'lblRooms
        '
        Me.lblRooms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRooms.BackColor = System.Drawing.Color.SteelBlue
        Me.lblRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRooms.Location = New System.Drawing.Point(0, 0)
        Me.lblRooms.Name = "lblRooms"
        Me.lblRooms.Size = New System.Drawing.Size(251, 36)
        Me.lblRooms.TabIndex = 1
        Me.lblRooms.Text = "Rooms"
        Me.lblRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbLegend
        '
        Me.gbLegend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbLegend.Controls.Add(Me.tblpanelLegend)
        Me.gbLegend.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLegend.Location = New System.Drawing.Point(3, 262)
        Me.gbLegend.MinimumSize = New System.Drawing.Size(217, 221)
        Me.gbLegend.Name = "gbLegend"
        Me.gbLegend.Size = New System.Drawing.Size(217, 221)
        Me.gbLegend.TabIndex = 4
        Me.gbLegend.TabStop = False
        Me.gbLegend.Text = "Legend"
        '
        'tblpanelLegend
        '
        Me.tblpanelLegend.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblpanelLegend.AutoSize = True
        Me.tblpanelLegend.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.tblpanelLegend.ColumnCount = 2
        Me.tblpanelLegend.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0!))
        Me.tblpanelLegend.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.0!))
        Me.tblpanelLegend.Controls.Add(Me.Label17, 1, 4)
        Me.tblpanelLegend.Controls.Add(Me.Label16, 0, 4)
        Me.tblpanelLegend.Controls.Add(Me.Label11, 1, 3)
        Me.tblpanelLegend.Controls.Add(Me.Label1, 0, 0)
        Me.tblpanelLegend.Controls.Add(Me.Label2, 1, 0)
        Me.tblpanelLegend.Controls.Add(Me.Label3, 0, 1)
        Me.tblpanelLegend.Controls.Add(Me.Label4, 1, 1)
        Me.tblpanelLegend.Controls.Add(Me.Label8, 0, 2)
        Me.tblpanelLegend.Controls.Add(Me.Label9, 1, 2)
        Me.tblpanelLegend.Controls.Add(Me.Label10, 0, 3)
        Me.tblpanelLegend.Controls.Add(Me.Label13, 0, 5)
        Me.tblpanelLegend.Controls.Add(Me.Label14, 1, 5)
        Me.tblpanelLegend.Location = New System.Drawing.Point(8, 19)
        Me.tblpanelLegend.Margin = New System.Windows.Forms.Padding(0)
        Me.tblpanelLegend.Name = "tblpanelLegend"
        Me.tblpanelLegend.RowCount = 6
        Me.tblpanelLegend.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.Size = New System.Drawing.Size(202, 201)
        Me.tblpanelLegend.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Location = New System.Drawing.Point(49, 135)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 30)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Charged and replace"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(6, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 30)
        Me.Label16.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(49, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 30)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Not used plase"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 30)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(49, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product(s) in plase"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 30)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(49, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Missing product(s)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Yellow
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(6, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 30)
        Me.Label8.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(49, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 30)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Momentary pick ups"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Image = Global.HomiNet.My.Resources.Resources.cancel_24
        Me.Label10.Location = New System.Drawing.Point(6, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 30)
        Me.Label10.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Purple
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(6, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 30)
        Me.Label13.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Location = New System.Drawing.Point(49, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(147, 30)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Item Error!!!"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTop.Controls.Add(Me.btnLock)
        Me.pnlTop.Controls.Add(Me.lblBalanceText)
        Me.pnlTop.Controls.Add(Me.lblBalanceDescr)
        Me.pnlTop.Controls.Add(Me.lblItemsNbText)
        Me.pnlTop.Controls.Add(Me.lblIntemsNbDescr)
        Me.pnlTop.Controls.Add(Me.lbManualHistory)
        Me.pnlTop.Controls.Add(Me.btnUnlock)
        Me.pnlTop.Controls.Add(Me.lblStatus2)
        Me.pnlTop.Controls.Add(Me.btnSend)
        Me.pnlTop.Controls.Add(Me.lblStatus1)
        Me.pnlTop.Controls.Add(Me.GlassButton9)
        Me.pnlTop.Location = New System.Drawing.Point(1, 3)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1258, 64)
        Me.pnlTop.TabIndex = 1
        '
        'btnLock
        '
        Me.btnLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLock.BackColor = System.Drawing.Color.Navy
        Me.btnLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.Image = Global.HomiNet.My.Resources.Resources.LOCK24
        Me.btnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLock.Location = New System.Drawing.Point(1074, 30)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(97, 30)
        Me.btnLock.TabIndex = 63
        Me.btnLock.Text = "Locked"
        Me.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'lblBalanceText
        '
        Me.lblBalanceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceText.Location = New System.Drawing.Point(996, 33)
        Me.lblBalanceText.Name = "lblBalanceText"
        Me.lblBalanceText.Size = New System.Drawing.Size(89, 23)
        Me.lblBalanceText.TabIndex = 62
        Me.lblBalanceText.Text = "Unknown"
        '
        'lblBalanceDescr
        '
        Me.lblBalanceDescr.AutoSize = True
        Me.lblBalanceDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceDescr.Location = New System.Drawing.Point(918, 34)
        Me.lblBalanceDescr.Name = "lblBalanceDescr"
        Me.lblBalanceDescr.Size = New System.Drawing.Size(66, 17)
        Me.lblBalanceDescr.TabIndex = 61
        Me.lblBalanceDescr.Text = "Balance"
        '
        'lblItemsNbText
        '
        Me.lblItemsNbText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsNbText.Location = New System.Drawing.Point(995, 3)
        Me.lblItemsNbText.Name = "lblItemsNbText"
        Me.lblItemsNbText.Size = New System.Drawing.Size(59, 23)
        Me.lblItemsNbText.TabIndex = 60
        Me.lblItemsNbText.Text = "Unknown"
        '
        'lblIntemsNbDescr
        '
        Me.lblIntemsNbDescr.AutoSize = True
        Me.lblIntemsNbDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntemsNbDescr.Location = New System.Drawing.Point(918, 4)
        Me.lblIntemsNbDescr.Name = "lblIntemsNbDescr"
        Me.lblIntemsNbDescr.Size = New System.Drawing.Size(68, 17)
        Me.lblIntemsNbDescr.TabIndex = 59
        Me.lblIntemsNbDescr.Text = "Item Nb."
        '
        'lbManualHistory
        '
        Me.lbManualHistory.FormattingEnabled = True
        Me.lbManualHistory.Location = New System.Drawing.Point(688, 3)
        Me.lbManualHistory.Name = "lbManualHistory"
        Me.lbManualHistory.Size = New System.Drawing.Size(224, 56)
        Me.lbManualHistory.TabIndex = 58
        '
        'btnUnlock
        '
        Me.btnUnlock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUnlock.BackColor = System.Drawing.Color.Navy
        Me.btnUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUnlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.Image = CType(resources.GetObject("btnUnlock.Image"), System.Drawing.Image)
        Me.btnUnlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnlock.Location = New System.Drawing.Point(1074, 1)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(97, 30)
        Me.btnUnlock.TabIndex = 57
        Me.btnUnlock.Text = "Unlocked"
        Me.btnUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnlock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'lblStatus2
        '
        Me.lblStatus2.AutoEllipsis = True
        Me.lblStatus2.AutoSize = True
        Me.lblStatus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus2.Location = New System.Drawing.Point(145, 34)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(68, 17)
        Me.lblStatus2.TabIndex = 51
        Me.lblStatus2.Text = "Status 2"
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.Color.Navy
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Image = Global.HomiNet.My.Resources.Resources.envoi24
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSend.Location = New System.Drawing.Point(1170, 1)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(82, 58)
        Me.btnSend.TabIndex = 50
        Me.btnSend.Text = "Send Manual Refill"
        Me.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoEllipsis = True
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus1.Location = New System.Drawing.Point(145, 9)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(63, 17)
        Me.lblStatus1.TabIndex = 46
        Me.lblStatus1.Text = "Status1"
        '
        'GlassButton9
        '
        Me.GlassButton9.AutoEllipsis = True
        Me.GlassButton9.BackColor = System.Drawing.Color.SteelBlue
        Me.GlassButton9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton9.GlowColor = System.Drawing.Color.Navy
        Me.GlassButton9.Image = CType(resources.GetObject("GlassButton9.Image"), System.Drawing.Image)
        Me.GlassButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GlassButton9.Location = New System.Drawing.Point(0, 1)
        Me.GlassButton9.Name = "GlassButton9"
        Me.GlassButton9.OuterBorderColor = System.Drawing.Color.Transparent
        Me.GlassButton9.ShineColor = System.Drawing.Color.Transparent
        Me.GlassButton9.Size = New System.Drawing.Size(135, 61)
        Me.GlassButton9.TabIndex = 45
        Me.GlassButton9.Text = "Main"
        Me.GlassButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GlassButton9.UseCompatibleTextRendering = True
        '
        'lblServiceSwitchDesc
        '
        Me.lblServiceSwitchDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceSwitchDesc.Location = New System.Drawing.Point(168, 68)
        Me.lblServiceSwitchDesc.Name = "lblServiceSwitchDesc"
        Me.lblServiceSwitchDesc.Size = New System.Drawing.Size(63, 45)
        Me.lblServiceSwitchDesc.TabIndex = 55
        Me.lblServiceSwitchDesc.Text = "Service Switch"
        '
        'lblTempText
        '
        Me.lblTempText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempText.Location = New System.Drawing.Point(209, 4)
        Me.lblTempText.Name = "lblTempText"
        Me.lblTempText.Size = New System.Drawing.Size(53, 52)
        Me.lblTempText.TabIndex = 54
        Me.lblTempText.Text = "Unknown"
        Me.lblTempText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempDesc
        '
        Me.lblTempDesc.Image = Global.HomiNet.My.Resources.Resources.thermometer30_30
        Me.lblTempDesc.Location = New System.Drawing.Point(166, 4)
        Me.lblTempDesc.Name = "lblTempDesc"
        Me.lblTempDesc.Size = New System.Drawing.Size(37, 52)
        Me.lblTempDesc.TabIndex = 53
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        Me.TableLayoutPanel1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Left Side"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 1)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLegend
        '
        Me.pnlLegend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLegend.AutoScroll = True
        Me.pnlLegend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLegend.Controls.Add(Me.pbSW)
        Me.pnlLegend.Controls.Add(Me.pbMinibar)
        Me.pnlLegend.Controls.Add(Me.gbLegend)
        Me.pnlLegend.Controls.Add(Me.lblTempText)
        Me.pnlLegend.Controls.Add(Me.lblTempDesc)
        Me.pnlLegend.Controls.Add(Me.lblServiceSwitchDesc)
        Me.pnlLegend.Location = New System.Drawing.Point(952, 82)
        Me.pnlLegend.Name = "pnlLegend"
        Me.pnlLegend.Size = New System.Drawing.Size(306, 507)
        Me.pnlLegend.TabIndex = 2
        '
        'pbSW
        '
        Me.pbSW.Location = New System.Drawing.Point(235, 54)
        Me.pbSW.Name = "pbSW"
        Me.pbSW.Size = New System.Drawing.Size(48, 73)
        Me.pbSW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSW.TabIndex = 57
        Me.pbSW.TabStop = False
        '
        'pbMinibar
        '
        Me.pbMinibar.Location = New System.Drawing.Point(3, 4)
        Me.pbMinibar.Name = "pbMinibar"
        Me.pbMinibar.Size = New System.Drawing.Size(159, 213)
        Me.pbMinibar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbMinibar.TabIndex = 5
        Me.pbMinibar.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        Me.TableLayoutPanel2.Visible = False
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.BackColor = System.Drawing.Color.SteelBlue
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(0, 472)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(251, 36)
        Me.lblCount.TabIndex = 42
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmsFiltersForExtView
        '
        Me.cmsFiltersForExtView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAll, Me.tsmiToRefill})
        Me.cmsFiltersForExtView.Name = "cmsFiltersForExtView"
        Me.cmsFiltersForExtView.Size = New System.Drawing.Size(117, 48)
        '
        'tsmiAll
        '
        Me.tsmiAll.Name = "tsmiAll"
        Me.tsmiAll.Size = New System.Drawing.Size(152, 22)
        Me.tsmiAll.Text = "All"
        '
        'tsmiToRefill
        '
        Me.tsmiToRefill.Name = "tsmiToRefill"
        Me.tsmiToRefill.Size = New System.Drawing.Size(152, 22)
        Me.tsmiToRefill.Text = "To Refill"
        '
        'ViewByModele
        '
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1261, 593)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLegend)
        Me.Name = "ViewByModele"
        Me.Text = "ViewByModele"
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.dgvExtView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gradpnlSearch.ResumeLayout(False)
        Me.gradpnlSearch.PerformLayout()
        Me.gbLegend.ResumeLayout(False)
        Me.gbLegend.PerformLayout()
        Me.tblpanelLegend.ResumeLayout(False)
        Me.tblpanelLegend.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlLegend.ResumeLayout(False)
        Me.pnlLegend.PerformLayout()
        CType(Me.pbSW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinibar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsFiltersForExtView.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents GlassButton9 As GlassButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tblpanelLegend As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblRooms As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents gbLegend As GroupBox
    Friend WithEvents pnlLegend As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents pbMinibar As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents lblTempDesc As Label
    Friend WithEvents lblTempText As Label
    Friend WithEvents lblServiceSwitchDesc As Label
    Friend WithEvents lbManualHistory As ListBox
    Friend WithEvents lblBalanceText As Label
    Friend WithEvents lblBalanceDescr As Label
    Friend WithEvents lblItemsNbText As Label
    Friend WithEvents lblIntemsNbDescr As Label
    Friend WithEvents gradpnlSearch As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents gbtnFind As Glass.GlassButton
    Friend WithEvents tbFind As System.Windows.Forms.TextBox
    Friend WithEvents dgvExtView As System.Windows.Forms.DataGridView
    Friend WithEvents pbSW As System.Windows.Forms.PictureBox
    Friend WithEvents btnSend As Glass.GlassButton
    Friend WithEvents btnUnlock As Glass.GlassButton
    Friend WithEvents btnLock As Glass.GlassButton
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents cmsFiltersForExtView As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiToRefill As System.Windows.Forms.ToolStripMenuItem
End Class
