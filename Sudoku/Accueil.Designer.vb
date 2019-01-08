<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.label_choisirJoueur = New System.Windows.Forms.Label()
        Me.btn_statistiques = New System.Windows.Forms.Button()
        Me.btn_jouer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_quitter
        '
        Me.btn_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quitter.Font = New System.Drawing.Font("Consolas", 11.1!)
        Me.btn_quitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_quitter.Location = New System.Drawing.Point(130, 732)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(322, 80)
        Me.btn_quitter.TabIndex = 1
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 408)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(340, 39)
        Me.ComboBox1.TabIndex = 0
        '
        'label_choisirJoueur
        '
        Me.label_choisirJoueur.AutoSize = True
        Me.label_choisirJoueur.Font = New System.Drawing.Font("Consolas", 13.1!)
        Me.label_choisirJoueur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label_choisirJoueur.Location = New System.Drawing.Point(40, 306)
        Me.label_choisirJoueur.Name = "label_choisirJoueur"
        Me.label_choisirJoueur.Size = New System.Drawing.Size(502, 51)
        Me.label_choisirJoueur.TabIndex = 3
        Me.label_choisirJoueur.Text = "Choisissez un joueur"
        '
        'btn_statistiques
        '
        Me.btn_statistiques.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btn_statistiques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_statistiques.Font = New System.Drawing.Font("Consolas", 11.1!)
        Me.btn_statistiques.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_statistiques.Location = New System.Drawing.Point(637, 732)
        Me.btn_statistiques.Name = "btn_statistiques"
        Me.btn_statistiques.Size = New System.Drawing.Size(355, 91)
        Me.btn_statistiques.TabIndex = 1
        Me.btn_statistiques.Text = "Statistiques"
        Me.btn_statistiques.UseVisualStyleBackColor = False
        '
        'btn_jouer
        '
        Me.btn_jouer.BackColor = System.Drawing.Color.Green
        Me.btn_jouer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jouer.Font = New System.Drawing.Font("Consolas", 11.1!)
        Me.btn_jouer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_jouer.Location = New System.Drawing.Point(563, 408)
        Me.btn_jouer.Name = "btn_jouer"
        Me.btn_jouer.Size = New System.Drawing.Size(270, 80)
        Me.btn_jouer.TabIndex = 7
        Me.btn_jouer.Text = "Jouer"
        Me.btn_jouer.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(186, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(647, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1128, 888)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_jouer)
        Me.Controls.Add(Me.btn_statistiques)
        Me.Controls.Add(Me.label_choisirJoueur)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btn_quitter)
        Me.Name = "Accueil"
        Me.Text = "Magic Sudoku"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_quitter As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents label_choisirJoueur As Label
    Friend WithEvents btn_statistiques As Button
    Friend WithEvents btn_jouer As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
