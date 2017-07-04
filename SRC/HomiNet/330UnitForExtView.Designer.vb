<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usc330GridCell
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbxProduct = New System.Windows.Forms.GroupBox()
        Me.pnlBackGround = New System.Windows.Forms.Panel()
        Me.lblSlash = New System.Windows.Forms.Label()
        Me.lblMaxCnt = New System.Windows.Forms.Label()
        Me.numudCnt = New System.Windows.Forms.NumericUpDown()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.gbxProduct.SuspendLayout()
        Me.pnlBackGround.SuspendLayout()
        CType(Me.numudCnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxProduct
        '
        Me.gbxProduct.BackColor = System.Drawing.SystemColors.Control
        Me.gbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gbxProduct.Controls.Add(Me.pnlBackGround)
        Me.gbxProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.gbxProduct.Location = New System.Drawing.Point(0, 0)
        Me.gbxProduct.Margin = New System.Windows.Forms.Padding(0, 3, 0, 1)
        Me.gbxProduct.Name = "gbxProduct"
        Me.gbxProduct.Padding = New System.Windows.Forms.Padding(0)
        Me.gbxProduct.Size = New System.Drawing.Size(91, 91)
        Me.gbxProduct.TabIndex = 0
        Me.gbxProduct.TabStop = False
        Me.gbxProduct.Text = "0"
        '
        'pnlBackGround
        '
        Me.pnlBackGround.Controls.Add(Me.lblSlash)
        Me.pnlBackGround.Controls.Add(Me.lblMaxCnt)
        Me.pnlBackGround.Controls.Add(Me.numudCnt)
        Me.pnlBackGround.Controls.Add(Me.lblProductName)
        Me.pnlBackGround.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBackGround.Location = New System.Drawing.Point(0, 15)
        Me.pnlBackGround.Name = "pnlBackGround"
        Me.pnlBackGround.Size = New System.Drawing.Size(91, 76)
        Me.pnlBackGround.TabIndex = 0
        '
        'lblSlash
        '
        Me.lblSlash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSlash.AutoSize = True
        Me.lblSlash.Location = New System.Drawing.Point(48, 53)
        Me.lblSlash.Name = "lblSlash"
        Me.lblSlash.Size = New System.Drawing.Size(13, 16)
        Me.lblSlash.TabIndex = 6
        Me.lblSlash.Text = "/"
        '
        'lblMaxCnt
        '
        Me.lblMaxCnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMaxCnt.Location = New System.Drawing.Point(63, 53)
        Me.lblMaxCnt.Name = "lblMaxCnt"
        Me.lblMaxCnt.Size = New System.Drawing.Size(25, 18)
        Me.lblMaxCnt.TabIndex = 5
        Me.lblMaxCnt.Text = "0"
        '
        'numudCnt
        '
        Me.numudCnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numudCnt.BackColor = System.Drawing.SystemColors.Info
        Me.numudCnt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numudCnt.Location = New System.Drawing.Point(15, 53)
        Me.numudCnt.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.numudCnt.Minimum = New Decimal(New Integer() {6, 0, 0, -2147483648})
        Me.numudCnt.Name = "numudCnt"
        Me.numudCnt.Size = New System.Drawing.Size(31, 18)
        Me.numudCnt.TabIndex = 4
        '
        'lblProductName
        '
        Me.lblProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductName.AutoEllipsis = True
        Me.lblProductName.Location = New System.Drawing.Point(6, 5)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(80, 45)
        Me.lblProductName.TabIndex = 3
        Me.lblProductName.Text = "Name of Products"
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Usc330GridCell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbxProduct)
        Me.Name = "Usc330GridCell"
        Me.Size = New System.Drawing.Size(91, 91)
        Me.gbxProduct.ResumeLayout(False)
        Me.pnlBackGround.ResumeLayout(False)
        Me.pnlBackGround.PerformLayout()
        CType(Me.numudCnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbxProduct As System.Windows.Forms.GroupBox
    Private WithEvents pnlBackGround As System.Windows.Forms.Panel
    Private WithEvents lblMaxCnt As System.Windows.Forms.Label
    Private WithEvents numudCnt As System.Windows.Forms.NumericUpDown
    Private WithEvents lblProductName As System.Windows.Forms.Label
    Private WithEvents lblSlash As System.Windows.Forms.Label

End Class
