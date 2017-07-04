<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UscGridUnit
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
        Me.grbUnit = New System.Windows.Forms.GroupBox()
        Me.nudUnit = New System.Windows.Forms.NumericUpDown()
        Me.btnUnit = New System.Windows.Forms.Button()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.lblAlarms = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDelemiter = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.grbUnit.SuspendLayout()
        CType(Me.nudUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbUnit
        '
        Me.grbUnit.Controls.Add(Me.TextBox2)
        Me.grbUnit.Controls.Add(Me.lblDelemiter)
        Me.grbUnit.Controls.Add(Me.TextBox1)
        Me.grbUnit.Controls.Add(Me.lblAlarms)
        Me.grbUnit.Controls.Add(Me.nudUnit)
        Me.grbUnit.Controls.Add(Me.btnUnit)
        Me.grbUnit.Controls.Add(Me.cmbUnit)
        Me.grbUnit.Location = New System.Drawing.Point(3, 3)
        Me.grbUnit.Name = "grbUnit"
        Me.grbUnit.Size = New System.Drawing.Size(75, 109)
        Me.grbUnit.TabIndex = 5
        Me.grbUnit.TabStop = False
        Me.grbUnit.Text = "groupBox1"
        '
        'nudUnit
        '
        Me.nudUnit.Location = New System.Drawing.Point(5, 52)
        Me.nudUnit.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudUnit.Name = "nudUnit"
        Me.nudUnit.Size = New System.Drawing.Size(64, 20)
        Me.nudUnit.TabIndex = 3
        Me.nudUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnUnit
        '
        Me.btnUnit.BackColor = System.Drawing.Color.Red
        Me.btnUnit.FlatAppearance.BorderSize = 0
        Me.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnit.Location = New System.Drawing.Point(4, 14)
        Me.btnUnit.Name = "btnUnit"
        Me.btnUnit.Size = New System.Drawing.Size(65, 36)
        Me.btnUnit.TabIndex = 0
        Me.btnUnit.Text = "Not use"
        Me.btnUnit.UseVisualStyleBackColor = False
        '
        'cmbUnit
        '
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.DropDownWidth = 176
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(6, 24)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(63, 21)
        Me.cmbUnit.TabIndex = 1
        '
        'lblAlarms
        '
        Me.lblAlarms.AutoSize = True
        Me.lblAlarms.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAlarms.Location = New System.Drawing.Point(5, 75)
        Me.lblAlarms.Name = "lblAlarms"
        Me.lblAlarms.Size = New System.Drawing.Size(66, 13)
        Me.lblAlarms.TabIndex = 6
        Me.lblAlarms.Text = "Alarms 1/2"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(5, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(21, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDelemiter
        '
        Me.lblDelemiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDelemiter.Location = New System.Drawing.Point(29, 89)
        Me.lblDelemiter.Name = "lblDelemiter"
        Me.lblDelemiter.Size = New System.Drawing.Size(11, 20)
        Me.lblDelemiter.TabIndex = 8
        Me.lblDelemiter.Text = "/"
        Me.lblDelemiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(43, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(21, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'UscGridUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grbUnit)
        Me.Name = "UscGridUnit"
        Me.Size = New System.Drawing.Size(83, 112)
        Me.grbUnit.ResumeLayout(False)
        Me.grbUnit.PerformLayout()
        CType(Me.nudUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents grbUnit As System.Windows.Forms.GroupBox
    Private WithEvents nudUnit As System.Windows.Forms.NumericUpDown
    Private WithEvents btnUnit As System.Windows.Forms.Button
    Private WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblAlarms As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDelemiter As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
