<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Temps_écoulé
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Temps_écoulé))
        Me.btn_restart_temps_ecoule = New System.Windows.Forms.Button()
        Me.btn_accueil_temps_ecoule = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_restart_temps_ecoule
        '
        Me.btn_restart_temps_ecoule.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btn_restart_temps_ecoule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_restart_temps_ecoule.Font = New System.Drawing.Font("Consolas", 10.1!)
        Me.btn_restart_temps_ecoule.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_restart_temps_ecoule.Location = New System.Drawing.Point(78, 290)
        Me.btn_restart_temps_ecoule.Name = "btn_restart_temps_ecoule"
        Me.btn_restart_temps_ecoule.Size = New System.Drawing.Size(298, 75)
        Me.btn_restart_temps_ecoule.TabIndex = 0
        Me.btn_restart_temps_ecoule.Text = "Recommencer"
        Me.btn_restart_temps_ecoule.UseVisualStyleBackColor = False
        '
        'btn_accueil_temps_ecoule
        '
        Me.btn_accueil_temps_ecoule.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btn_accueil_temps_ecoule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_accueil_temps_ecoule.Font = New System.Drawing.Font("Consolas", 10.1!)
        Me.btn_accueil_temps_ecoule.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_accueil_temps_ecoule.Location = New System.Drawing.Point(422, 290)
        Me.btn_accueil_temps_ecoule.Name = "btn_accueil_temps_ecoule"
        Me.btn_accueil_temps_ecoule.Size = New System.Drawing.Size(271, 75)
        Me.btn_accueil_temps_ecoule.TabIndex = 1
        Me.btn_accueil_temps_ecoule.Text = "Accueil"
        Me.btn_accueil_temps_ecoule.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 51)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Le temps est écoulé !"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Temps_écoulé
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 464)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_accueil_temps_ecoule)
        Me.Controls.Add(Me.btn_restart_temps_ecoule)
        Me.Name = "Temps_écoulé"
        Me.Text = "Temps_écoulé"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_restart_temps_ecoule As Button
    Friend WithEvents btn_accueil_temps_ecoule As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
