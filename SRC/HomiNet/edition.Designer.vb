Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class edition
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(edition))
        Me.PictureBox2 = New PictureBox
        Me.PictureBox1 = New PictureBox
        CType(Me.PictureBox2, ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = My.Resources.Resources._6134_tatice_Entravaux
        Me.PictureBox2.Location = New Point(86, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New Size(128, 128)
        Me.PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = My.Resources.Resources.excavatrice_overlord_divers
        Me.PictureBox1.Location = New Point(410, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(256, 256)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'edition
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New Size(752, 296)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "edition"
        Me.Text = "produit"
        CType(Me.PictureBox2, ISupportInitialize).EndInit()
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
