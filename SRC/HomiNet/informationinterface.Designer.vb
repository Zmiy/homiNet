Imports System.ComponentModel
Imports Glass
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Informationinterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informationinterface))
        Me.rtbInformationView = New System.Windows.Forms.RichTextBox()
        Me.pnlCalendare = New System.Windows.Forms.Panel()
        Me.btnUpdate = New Glass.GlassButton()
        Me.mcalendarInformation = New System.Windows.Forms.MonthCalendar()
        Me.pnlExtention = New System.Windows.Forms.Panel()
        Me.gbExtention = New System.Windows.Forms.GroupBox()
        Me.cmbExtension = New System.Windows.Forms.ComboBox()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnVisible = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbRooms = New System.Windows.Forms.ComboBox()
        Me.chkbSelectedRoom = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnCheckOutPosting = New System.Windows.Forms.RadioButton()
        Me.btnSend = New Glass.GlassButton()
        Me.rbtnFailure = New System.Windows.Forms.RadioButton()
        Me.rbtnAll = New System.Windows.Forms.RadioButton()
        Me.rbtnSucceeded = New System.Windows.Forms.RadioButton()
        Me.imprimante = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New Glass.GlassButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlCalendare.SuspendLayout()
        Me.pnlExtention.SuspendLayout()
        Me.gbExtention.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbInformationView
        '
        Me.rtbInformationView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbInformationView.DetectUrls = False
        Me.rtbInformationView.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbInformationView.HideSelection = False
        Me.rtbInformationView.Location = New System.Drawing.Point(4, 2)
        Me.rtbInformationView.Name = "rtbInformationView"
        Me.rtbInformationView.Size = New System.Drawing.Size(550, 487)
        Me.rtbInformationView.TabIndex = 0
        Me.rtbInformationView.Text = ""
        Me.rtbInformationView.WordWrap = False
        '
        'pnlCalendare
        '
        Me.pnlCalendare.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCalendare.Controls.Add(Me.btnUpdate)
        Me.pnlCalendare.Controls.Add(Me.mcalendarInformation)
        Me.pnlCalendare.Location = New System.Drawing.Point(560, 2)
        Me.pnlCalendare.Name = "pnlCalendare"
        Me.pnlCalendare.Size = New System.Drawing.Size(263, 191)
        Me.pnlCalendare.TabIndex = 54
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoEllipsis = True
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkGreen
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.GlowColor = System.Drawing.Color.Lime
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUpdate.Location = New System.Drawing.Point(1, 162)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OuterBorderColor = System.Drawing.Color.Transparent
        Me.btnUpdate.ShineColor = System.Drawing.Color.Transparent
        Me.btnUpdate.Size = New System.Drawing.Size(231, 29)
        Me.btnUpdate.TabIndex = 40
        Me.btnUpdate.Text = "Remplissage"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseCompatibleTextRendering = True
        '
        'mcalendarInformation
        '
        Me.mcalendarInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcalendarInformation.Location = New System.Drawing.Point(5, 1)
        Me.mcalendarInformation.Name = "mcalendarInformation"
        Me.mcalendarInformation.TabIndex = 39
        '
        'pnlExtention
        '
        Me.pnlExtention.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlExtention.Controls.Add(Me.gbExtention)
        Me.pnlExtention.Location = New System.Drawing.Point(561, 192)
        Me.pnlExtention.Name = "pnlExtention"
        Me.pnlExtention.Size = New System.Drawing.Size(250, 44)
        Me.pnlExtention.TabIndex = 55
        Me.pnlExtention.Visible = False
        '
        'gbExtention
        '
        Me.gbExtention.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbExtention.Controls.Add(Me.cmbExtension)
        Me.gbExtention.Location = New System.Drawing.Point(24, 3)
        Me.gbExtention.Name = "gbExtention"
        Me.gbExtention.Size = New System.Drawing.Size(196, 38)
        Me.gbExtention.TabIndex = 53
        Me.gbExtention.TabStop = False
        Me.gbExtention.Text = "Extention Select"
        '
        'cmbExtension
        '
        Me.cmbExtension.FormattingEnabled = True
        Me.cmbExtension.Location = New System.Drawing.Point(8, 13)
        Me.cmbExtension.Name = "cmbExtension"
        Me.cmbExtension.Size = New System.Drawing.Size(129, 21)
        Me.cmbExtension.TabIndex = 0
        '
        'pnlBottom
        '
        Me.pnlBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBottom.Controls.Add(Me.btnVisible)
        Me.pnlBottom.Controls.Add(Me.GroupBox2)
        Me.pnlBottom.Controls.Add(Me.GroupBox1)
        Me.pnlBottom.Controls.Add(Me.imprimante)
        Me.pnlBottom.Controls.Add(Me.btnPrint)
        Me.pnlBottom.Location = New System.Drawing.Point(560, 243)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(250, 245)
        Me.pnlBottom.TabIndex = 56
        '
        'btnVisible
        '
        Me.btnVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisible.Location = New System.Drawing.Point(23, 188)
        Me.btnVisible.Name = "btnVisible"
        Me.btnVisible.Size = New System.Drawing.Size(39, 48)
        Me.btnVisible.TabIndex = 58
        Me.btnVisible.Text = "Button1"
        Me.btnVisible.UseVisualStyleBackColor = True
        Me.btnVisible.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmbRooms)
        Me.GroupBox2.Controls.Add(Me.chkbSelectedRoom)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 55)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'cmbRooms
        '
        Me.cmbRooms.Enabled = False
        Me.cmbRooms.FormattingEnabled = True
        Me.cmbRooms.Location = New System.Drawing.Point(47, 25)
        Me.cmbRooms.Name = "cmbRooms"
        Me.cmbRooms.Size = New System.Drawing.Size(165, 21)
        Me.cmbRooms.TabIndex = 1
        '
        'chkbSelectedRoom
        '
        Me.chkbSelectedRoom.AutoSize = True
        Me.chkbSelectedRoom.Location = New System.Drawing.Point(11, 25)
        Me.chkbSelectedRoom.Name = "chkbSelectedRoom"
        Me.chkbSelectedRoom.Size = New System.Drawing.Size(29, 17)
        Me.chkbSelectedRoom.TabIndex = 0
        Me.chkbSelectedRoom.Text = " "
        Me.chkbSelectedRoom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rbtnCheckOutPosting)
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.rbtnFailure)
        Me.GroupBox1.Controls.Add(Me.rbtnAll)
        Me.GroupBox1.Controls.Add(Me.rbtnSucceeded)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 115)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rbtnCheckOutPosting
        '
        Me.rbtnCheckOutPosting.AutoSize = True
        Me.rbtnCheckOutPosting.Location = New System.Drawing.Point(7, 96)
        Me.rbtnCheckOutPosting.Name = "rbtnCheckOutPosting"
        Me.rbtnCheckOutPosting.Size = New System.Drawing.Size(114, 17)
        Me.rbtnCheckOutPosting.TabIndex = 51
        Me.rbtnCheckOutPosting.TabStop = True
        Me.rbtnCheckOutPosting.Text = "Check Out Posting"
        Me.rbtnCheckOutPosting.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.AutoEllipsis = True
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSend.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.GlowColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSend.Location = New System.Drawing.Point(130, 87)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.OuterBorderColor = System.Drawing.Color.Transparent
        Me.btnSend.ShineColor = System.Drawing.Color.Transparent
        Me.btnSend.Size = New System.Drawing.Size(93, 22)
        Me.btnSend.TabIndex = 50
        Me.btnSend.Text = "Remplissage"
        Me.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSend.UseCompatibleTextRendering = True
        '
        'rbtnFailure
        '
        Me.rbtnFailure.AutoSize = True
        Me.rbtnFailure.Location = New System.Drawing.Point(7, 73)
        Me.rbtnFailure.Name = "rbtnFailure"
        Me.rbtnFailure.Size = New System.Drawing.Size(56, 17)
        Me.rbtnFailure.TabIndex = 49
        Me.rbtnFailure.Text = "Failure"
        Me.rbtnFailure.UseVisualStyleBackColor = True
        '
        'rbtnAll
        '
        Me.rbtnAll.AutoSize = True
        Me.rbtnAll.Checked = True
        Me.rbtnAll.Location = New System.Drawing.Point(7, 27)
        Me.rbtnAll.Name = "rbtnAll"
        Me.rbtnAll.Size = New System.Drawing.Size(36, 17)
        Me.rbtnAll.TabIndex = 47
        Me.rbtnAll.TabStop = True
        Me.rbtnAll.Text = "All"
        Me.rbtnAll.UseVisualStyleBackColor = True
        '
        'rbtnSucceeded
        '
        Me.rbtnSucceeded.AutoSize = True
        Me.rbtnSucceeded.Location = New System.Drawing.Point(7, 50)
        Me.rbtnSucceeded.Name = "rbtnSucceeded"
        Me.rbtnSucceeded.Size = New System.Drawing.Size(80, 17)
        Me.rbtnSucceeded.TabIndex = 48
        Me.rbtnSucceeded.Text = "Succeeded"
        Me.rbtnSucceeded.UseVisualStyleBackColor = True
        '
        'imprimante
        '
        Me.imprimante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imprimante.FormattingEnabled = True
        Me.imprimante.Location = New System.Drawing.Point(65, 216)
        Me.imprimante.Name = "imprimante"
        Me.imprimante.Size = New System.Drawing.Size(181, 21)
        Me.imprimante.TabIndex = 55
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.AutoEllipsis = True
        Me.btnPrint.BackColor = System.Drawing.Color.Navy
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GlowColor = System.Drawing.Color.Blue
        Me.btnPrint.Image = Global.HomiNet.My.Resources.Resources.imp24
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(66, 180)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OuterBorderColor = System.Drawing.Color.Transparent
        Me.btnPrint.ShineColor = System.Drawing.Color.Transparent
        Me.btnPrint.Size = New System.Drawing.Size(181, 33)
        Me.btnPrint.TabIndex = 54
        Me.btnPrint.Text = "Remplissage"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseCompatibleTextRendering = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(202, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 28)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Informationinterface
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(817, 491)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlCalendare)
        Me.Controls.Add(Me.rtbInformationView)
        Me.Controls.Add(Me.pnlExtention)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Informationinterface"
        Me.Text = "info system "
        Me.pnlCalendare.ResumeLayout(False)
        Me.pnlExtention.ResumeLayout(False)
        Me.gbExtention.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbInformationView As RichTextBox
    Friend WithEvents pnlCalendare As Panel
    Friend WithEvents btnUpdate As GlassButton
    Friend WithEvents mcalendarInformation As MonthCalendar
    Friend WithEvents pnlExtention As Panel
    Friend WithEvents gbExtention As GroupBox
    Friend WithEvents cmbExtension As ComboBox
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents btnVisible As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbRooms As ComboBox
    Friend WithEvents chkbSelectedRoom As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnCheckOutPosting As RadioButton
    Friend WithEvents btnSend As GlassButton
    Friend WithEvents rbtnFailure As RadioButton
    Friend WithEvents rbtnAll As RadioButton
    Friend WithEvents rbtnSucceeded As RadioButton
    Friend WithEvents imprimante As ComboBox
    Friend WithEvents btnPrint As GlassButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
