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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(ViewByModele))
        Me.pnlLeft = New Panel()
        Me.Label12 = New Label()
        Me.lbRooms = New ListBox()
        Me.gbLegend = New GroupBox()
        Me.tblpanelLegend = New TableLayoutPanel()
        Me.Label17 = New Label()
        Me.Label16 = New Label()
        Me.Label11 = New Label()
        Me.Label1 = New Label()
        Me.Label2 = New Label()
        Me.Label3 = New Label()
        Me.Label4 = New Label()
        Me.Label8 = New Label()
        Me.Label9 = New Label()
        Me.Label10 = New Label()
        Me.Label13 = New Label()
        Me.Label14 = New Label()
        Me.pnlTop = New Panel()
        Me.lblBalanceText = New Label()
        Me.lblBalanceDescr = New Label()
        Me.lblItemsNbText = New Label()
        Me.lblIntemsNbDescr = New Label()
        Me.lbManualHistory = New ListBox()
        Me.btnUnlock = New Button()
        Me.lblServiceSwitchText = New Label()
        Me.lblServiceSwitchDesc = New Label()
        Me.lblTempText = New Label()
        Me.lblTempDesc = New Label()
        Me.lblRoomStatusTest = New Label()
        Me.lblRoomStatusDesc = New Label()
        Me.btnSend = New Button()
        Me.lblDoorStatusText = New Label()
        Me.lblDoorStatusDesc = New Label()
        Me.lblRoomNText = New Label()
        Me.lblRoomNTitle = New Label()
        Me.GlassButton9 = New GlassButton()
        Me.TableLayoutPanel1 = New TableLayoutPanel()
        Me.Label5 = New Label()
        Me.Label6 = New Label()
        Me.Label7 = New Label()
        Me.pnlLegend = New Panel()
        Me.pbMinibar = New PictureBox()
        Me.TableLayoutPanel2 = New TableLayoutPanel()
        Me.pnlLeft.SuspendLayout()
        Me.gbLegend.SuspendLayout()
        Me.tblpanelLegend.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlLegend.SuspendLayout()
        CType(Me.pbMinibar, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
        Me.pnlLeft.BorderStyle = BorderStyle.Fixed3D
        Me.pnlLeft.Controls.Add(Me.Label12)
        Me.pnlLeft.Controls.Add(Me.lbRooms)
        Me.pnlLeft.Location = New Point(1, 82)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New Size(198, 510)
        Me.pnlLeft.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.Label12.BackColor = Color.SteelBlue
        Me.Label12.BorderStyle = BorderStyle.Fixed3D
        Me.Label12.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New Size(196, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Rooms"
        Me.Label12.TextAlign = ContentAlignment.MiddleCenter
        '
        'lbRooms
        '
        Me.lbRooms.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.lbRooms.BorderStyle = BorderStyle.None
        Me.lbRooms.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.lbRooms.FormattingEnabled = True
        Me.lbRooms.ItemHeight = 20
        Me.lbRooms.Location = New Point(0, 26)
        Me.lbRooms.Name = "lbRooms"
        Me.lbRooms.ScrollAlwaysVisible = True
        Me.lbRooms.Size = New Size(194, 480)
        Me.lbRooms.TabIndex = 0
        '
        'gbLegend
        '
        Me.gbLegend.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
        Me.gbLegend.Controls.Add(Me.tblpanelLegend)
        Me.gbLegend.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.gbLegend.Location = New Point(11, 266)
        Me.gbLegend.MinimumSize = New Size(217, 221)
        Me.gbLegend.Name = "gbLegend"
        Me.gbLegend.Size = New Size(217, 221)
        Me.gbLegend.TabIndex = 4
        Me.gbLegend.TabStop = False
        Me.gbLegend.Text = "Legend"
        '
        'tblpanelLegend
        '
        Me.tblpanelLegend.Anchor = AnchorStyles.None
        Me.tblpanelLegend.AutoSize = True
        Me.tblpanelLegend.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
        Me.tblpanelLegend.ColumnCount = 2
        Me.tblpanelLegend.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.0!))
        Me.tblpanelLegend.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 79.0!))
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
        Me.tblpanelLegend.Location = New Point(8, 19)
        Me.tblpanelLegend.Margin = New Padding(0)
        Me.tblpanelLegend.Name = "tblpanelLegend"
        Me.tblpanelLegend.RowCount = 6
        Me.tblpanelLegend.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0!))
        Me.tblpanelLegend.Size = New Size(202, 194)
        Me.tblpanelLegend.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = DockStyle.Fill
        Me.Label17.Location = New Point(48, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New Size(149, 30)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Charged and replace"
        Me.Label17.TextAlign = ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = Color.DarkSlateGray
        Me.Label16.Dock = DockStyle.Fill
        Me.Label16.ForeColor = Color.DimGray
        Me.Label16.Location = New Point(5, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New Size(35, 30)
        Me.Label16.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = DockStyle.Fill
        Me.Label11.Location = New Point(48, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New Size(149, 30)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Not used plase"
        Me.Label11.TextAlign = ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = Color.Green
        Me.Label1.Dock = DockStyle.Fill
        Me.Label1.Location = New Point(5, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(35, 30)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = DockStyle.Fill
        Me.Label2.Location = New Point(48, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(149, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product(s) in plase"
        Me.Label2.TextAlign = ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = Color.Gray
        Me.Label3.Dock = DockStyle.Fill
        Me.Label3.Location = New Point(5, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(35, 30)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = DockStyle.Fill
        Me.Label4.Location = New Point(48, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(149, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Missing product(s)"
        Me.Label4.TextAlign = ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = Color.Yellow
        Me.Label8.Dock = DockStyle.Fill
        Me.Label8.Location = New Point(5, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New Size(35, 30)
        Me.Label8.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = DockStyle.Fill
        Me.Label9.Location = New Point(48, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New Size(149, 30)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Momentary pick ups"
        Me.Label9.TextAlign = ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = Color.White
        Me.Label10.Dock = DockStyle.Fill
        Me.Label10.Image = My.Resources.Resources.cancel_24
        Me.Label10.Location = New Point(5, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New Size(35, 30)
        Me.Label10.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = Color.Purple
        Me.Label13.Dock = DockStyle.Fill
        Me.Label13.Location = New Point(5, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New Size(35, 30)
        Me.Label13.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = DockStyle.Fill
        Me.Label14.Location = New Point(48, 162)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New Size(149, 30)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Item Error!!!"
        Me.Label14.TextAlign = ContentAlignment.MiddleCenter
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.pnlTop.BorderStyle = BorderStyle.Fixed3D
        Me.pnlTop.Controls.Add(Me.lblBalanceText)
        Me.pnlTop.Controls.Add(Me.lblBalanceDescr)
        Me.pnlTop.Controls.Add(Me.lblItemsNbText)
        Me.pnlTop.Controls.Add(Me.lblIntemsNbDescr)
        Me.pnlTop.Controls.Add(Me.lbManualHistory)
        Me.pnlTop.Controls.Add(Me.btnUnlock)
        Me.pnlTop.Controls.Add(Me.lblServiceSwitchText)
        Me.pnlTop.Controls.Add(Me.lblServiceSwitchDesc)
        Me.pnlTop.Controls.Add(Me.lblTempText)
        Me.pnlTop.Controls.Add(Me.lblTempDesc)
        Me.pnlTop.Controls.Add(Me.lblRoomStatusTest)
        Me.pnlTop.Controls.Add(Me.lblRoomStatusDesc)
        Me.pnlTop.Controls.Add(Me.btnSend)
        Me.pnlTop.Controls.Add(Me.lblDoorStatusText)
        Me.pnlTop.Controls.Add(Me.lblDoorStatusDesc)
        Me.pnlTop.Controls.Add(Me.lblRoomNText)
        Me.pnlTop.Controls.Add(Me.lblRoomNTitle)
        Me.pnlTop.Controls.Add(Me.GlassButton9)
        Me.pnlTop.Location = New Point(1, 3)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New Size(1258, 64)
        Me.pnlTop.TabIndex = 1
        '
        'lblBalanceText
        '
        Me.lblBalanceText.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceText.Location = New Point(996, 33)
        Me.lblBalanceText.Name = "lblBalanceText"
        Me.lblBalanceText.Size = New Size(89, 23)
        Me.lblBalanceText.TabIndex = 62
        Me.lblBalanceText.Text = "Unknown"
        '
        'lblBalanceDescr
        '
        Me.lblBalanceDescr.AutoSize = True
        Me.lblBalanceDescr.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceDescr.Location = New Point(918, 34)
        Me.lblBalanceDescr.Name = "lblBalanceDescr"
        Me.lblBalanceDescr.Size = New Size(66, 17)
        Me.lblBalanceDescr.TabIndex = 61
        Me.lblBalanceDescr.Text = "Balance"
        '
        'lblItemsNbText
        '
        Me.lblItemsNbText.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsNbText.Location = New Point(995, 3)
        Me.lblItemsNbText.Name = "lblItemsNbText"
        Me.lblItemsNbText.Size = New Size(59, 23)
        Me.lblItemsNbText.TabIndex = 60
        Me.lblItemsNbText.Text = "Unknown"
        '
        'lblIntemsNbDescr
        '
        Me.lblIntemsNbDescr.AutoSize = True
        Me.lblIntemsNbDescr.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntemsNbDescr.Location = New Point(918, 4)
        Me.lblIntemsNbDescr.Name = "lblIntemsNbDescr"
        Me.lblIntemsNbDescr.Size = New Size(68, 17)
        Me.lblIntemsNbDescr.TabIndex = 59
        Me.lblIntemsNbDescr.Text = "Item Nb."
        '
        'lbManualHistory
        '
        Me.lbManualHistory.FormattingEnabled = True
        Me.lbManualHistory.Location = New Point(709, 3)
        Me.lbManualHistory.Name = "lbManualHistory"
        Me.lbManualHistory.Size = New Size(203, 56)
        Me.lbManualHistory.TabIndex = 58
        '
        'btnUnlock
        '
        Me.btnUnlock.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
        Me.btnUnlock.BackColor = Color.Navy
        Me.btnUnlock.BackgroundImage = My.Resources.Resources.unlock48
        Me.btnUnlock.BackgroundImageLayout = ImageLayout.Stretch
        Me.btnUnlock.Font = New Font("Microsoft Sans Serif", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.ForeColor = Color.White
        Me.btnUnlock.Location = New Point(1087, 4)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New Size(66, 56)
        Me.btnUnlock.TabIndex = 57
        Me.btnUnlock.Text = "Unlock"
        Me.btnUnlock.TextAlign = ContentAlignment.BottomCenter
        Me.btnUnlock.UseVisualStyleBackColor = False
        '
        'lblServiceSwitchText
        '
        Me.lblServiceSwitchText.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceSwitchText.Location = New Point(480, 33)
        Me.lblServiceSwitchText.Name = "lblServiceSwitchText"
        Me.lblServiceSwitchText.Size = New Size(74, 23)
        Me.lblServiceSwitchText.TabIndex = 56
        Me.lblServiceSwitchText.Text = "Unknown"
        '
        'lblServiceSwitchDesc
        '
        Me.lblServiceSwitchDesc.AutoSize = True
        Me.lblServiceSwitchDesc.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceSwitchDesc.Location = New Point(362, 33)
        Me.lblServiceSwitchDesc.Name = "lblServiceSwitchDesc"
        Me.lblServiceSwitchDesc.Size = New Size(113, 17)
        Me.lblServiceSwitchDesc.TabIndex = 55
        Me.lblServiceSwitchDesc.Text = "Service Switch"
        '
        'lblTempText
        '
        Me.lblTempText.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempText.Location = New Point(641, 4)
        Me.lblTempText.Name = "lblTempText"
        Me.lblTempText.Size = New Size(62, 52)
        Me.lblTempText.TabIndex = 54
        Me.lblTempText.Text = "Unknown"
        Me.lblTempText.TextAlign = ContentAlignment.MiddleCenter
        '
        'lblTempDesc
        '
        Me.lblTempDesc.Image = My.Resources.Resources.thermometer30_30
        Me.lblTempDesc.Location = New Point(601, 4)
        Me.lblTempDesc.Name = "lblTempDesc"
        Me.lblTempDesc.Size = New Size(37, 52)
        Me.lblTempDesc.TabIndex = 53
        '
        'lblRoomStatusTest
        '
        Me.lblRoomStatusTest.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomStatusTest.Location = New Point(260, 33)
        Me.lblRoomStatusTest.Name = "lblRoomStatusTest"
        Me.lblRoomStatusTest.Size = New Size(105, 23)
        Me.lblRoomStatusTest.TabIndex = 52
        Me.lblRoomStatusTest.Text = "Unknown"
        '
        'lblRoomStatusDesc
        '
        Me.lblRoomStatusDesc.AutoSize = True
        Me.lblRoomStatusDesc.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomStatusDesc.Location = New Point(153, 33)
        Me.lblRoomStatusDesc.Name = "lblRoomStatusDesc"
        Me.lblRoomStatusDesc.Size = New Size(98, 17)
        Me.lblRoomStatusDesc.TabIndex = 51
        Me.lblRoomStatusDesc.Text = "Room status"
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
        Me.btnSend.BackColor = Color.Navy
        Me.btnSend.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = Color.White
        Me.btnSend.Image = My.Resources.Resources.envoi24
        Me.btnSend.ImageAlign = ContentAlignment.MiddleLeft
        Me.btnSend.Location = New Point(1159, 4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New Size(87, 56)
        Me.btnSend.TabIndex = 50
        Me.btnSend.Text = "Send Manual Refill"
        Me.btnSend.TextAlign = ContentAlignment.MiddleLeft
        Me.btnSend.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'lblDoorStatusText
        '
        Me.lblDoorStatusText.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoorStatusText.Location = New Point(427, 9)
        Me.lblDoorStatusText.Name = "lblDoorStatusText"
        Me.lblDoorStatusText.Size = New Size(157, 23)
        Me.lblDoorStatusText.TabIndex = 49
        Me.lblDoorStatusText.Text = "Unknown"
        '
        'lblDoorStatusDesc
        '
        Me.lblDoorStatusDesc.AutoSize = True
        Me.lblDoorStatusDesc.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoorStatusDesc.Location = New Point(373, 10)
        Me.lblDoorStatusDesc.Name = "lblDoorStatusDesc"
        Me.lblDoorStatusDesc.Size = New Size(48, 17)
        Me.lblDoorStatusDesc.TabIndex = 48
        Me.lblDoorStatusDesc.Text = "Door:"
        '
        'lblRoomNText
        '
        Me.lblRoomNText.AutoEllipsis = True
        Me.lblRoomNText.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNText.Location = New Point(277, 9)
        Me.lblRoomNText.Name = "lblRoomNText"
        Me.lblRoomNText.Size = New Size(90, 16)
        Me.lblRoomNText.TabIndex = 47
        Me.lblRoomNText.Text = "Unknown"
        '
        'lblRoomNTitle
        '
        Me.lblRoomNTitle.AutoSize = True
        Me.lblRoomNTitle.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNTitle.Location = New Point(153, 9)
        Me.lblRoomNTitle.Name = "lblRoomNTitle"
        Me.lblRoomNTitle.Size = New Size(116, 17)
        Me.lblRoomNTitle.TabIndex = 46
        Me.lblRoomNTitle.Text = "Room N/UCF N"
        '
        'GlassButton9
        '
        Me.GlassButton9.AutoEllipsis = True
        Me.GlassButton9.BackColor = Color.SteelBlue
        Me.GlassButton9.Font = New Font("Tahoma", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton9.GlowColor = Color.Navy
        Me.GlassButton9.Image = CType(resources.GetObject("GlassButton9.Image"), Image)
        Me.GlassButton9.ImageAlign = ContentAlignment.MiddleLeft
        Me.GlassButton9.Location = New Point(0, 1)
        Me.GlassButton9.Name = "GlassButton9"
        Me.GlassButton9.OuterBorderColor = Color.Transparent
        Me.GlassButton9.ShineColor = Color.Transparent
        Me.GlassButton9.Size = New Size(135, 61)
        Me.GlassButton9.TabIndex = 45
        Me.GlassButton9.Text = "Remplissage"
        Me.GlassButton9.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.GlassButton9.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Location = New Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        Me.TableLayoutPanel1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = DockStyle.Fill
        Me.Label5.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New Point(6, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(188, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Dock = DockStyle.Fill
        Me.Label6.Font = New Font("Microsoft Sans Serif", 11.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(188, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Left Side"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = DockStyle.Fill
        Me.Label7.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New Point(6, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(77, 1)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = ContentAlignment.MiddleCenter
        '
        'pnlLegend
        '
        Me.pnlLegend.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.pnlLegend.AutoScroll = True
        Me.pnlLegend.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.pnlLegend.BorderStyle = BorderStyle.Fixed3D
        Me.pnlLegend.Controls.Add(Me.pbMinibar)
        Me.pnlLegend.Controls.Add(Me.gbLegend)
        Me.pnlLegend.Location = New Point(1020, 82)
        Me.pnlLegend.Name = "pnlLegend"
        Me.pnlLegend.Size = New Size(239, 507)
        Me.pnlLegend.TabIndex = 2
        '
        'pbMinibar
        '
        Me.pbMinibar.Location = New Point(11, 3)
        Me.pbMinibar.MinimumSize = New Size(211, 205)
        Me.pbMinibar.Name = "pbMinibar"
        Me.pbMinibar.Size = New Size(211, 205)
        Me.pbMinibar.SizeMode = PictureBoxSizeMode.CenterImage
        Me.pbMinibar.TabIndex = 5
        Me.pbMinibar.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Location = New Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New Size(200, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        Me.TableLayoutPanel2.Visible = False
        '
        'ViewByModele
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New Size(1261, 593)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLegend)
        Me.Name = "ViewByModele"
        Me.Text = "ViewByModele"
        Me.pnlLeft.ResumeLayout(False)
        Me.gbLegend.ResumeLayout(False)
        Me.gbLegend.PerformLayout()
        Me.tblpanelLegend.ResumeLayout(False)
        Me.tblpanelLegend.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlLegend.ResumeLayout(False)
        CType(Me.pbMinibar, ISupportInitialize).EndInit()
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
    Friend WithEvents lbRooms As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents gbLegend As GroupBox
    Friend WithEvents pnlLegend As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents pbMinibar As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblRoomNText As Label
    Friend WithEvents lblRoomNTitle As Label
    Friend WithEvents lblDoorStatusText As Label
    Friend WithEvents lblDoorStatusDesc As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents lblRoomStatusTest As Label
    Friend WithEvents lblRoomStatusDesc As Label
    Friend WithEvents lblTempDesc As Label
    Friend WithEvents lblTempText As Label
    Friend WithEvents lblServiceSwitchDesc As Label
    Friend WithEvents lblServiceSwitchText As Label
    Friend WithEvents btnUnlock As Button
    Friend WithEvents lbManualHistory As ListBox
    Friend WithEvents lblBalanceText As Label
    Friend WithEvents lblBalanceDescr As Label
    Friend WithEvents lblItemsNbText As Label
    Friend WithEvents lblIntemsNbDescr As Label
End Class
