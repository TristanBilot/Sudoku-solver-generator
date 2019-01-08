<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sudoku
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sudoku))
        Me.btn_abandonner = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.label_timer = New System.Windows.Forms.Label()
        Me.btn_correction = New System.Windows.Forms.Button()
        Me.Button_nv_grille = New System.Windows.Forms.Button()
        Me.label_nom_joueur = New System.Windows.Forms.Label()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.info_enregis = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_abandonner
        '
        Me.btn_abandonner.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btn_abandonner.Font = New System.Drawing.Font("Consolas", 9.1!)
        Me.btn_abandonner.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_abandonner.Location = New System.Drawing.Point(51, 589)
        Me.btn_abandonner.Name = "btn_abandonner"
        Me.btn_abandonner.Size = New System.Drawing.Size(235, 97)
        Me.btn_abandonner.TabIndex = 2
        Me.btn_abandonner.Text = "Abandonner"
        Me.btn_abandonner.UseVisualStyleBackColor = False
        '
        'Timer
        '
        '
        'label_timer
        '
        Me.label_timer.AutoSize = True
        Me.label_timer.Font = New System.Drawing.Font("Consolas", 20.1!)
        Me.label_timer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_timer.Location = New System.Drawing.Point(854, 153)
        Me.label_timer.Name = "label_timer"
        Me.label_timer.Size = New System.Drawing.Size(200, 71)
        Me.label_timer.TabIndex = 4
        Me.label_timer.Text = "Timer"
        '
        'btn_correction
        '
        Me.btn_correction.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btn_correction.Font = New System.Drawing.Font("Consolas", 9.1!)
        Me.btn_correction.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_correction.Location = New System.Drawing.Point(834, 600)
        Me.btn_correction.Name = "btn_correction"
        Me.btn_correction.Size = New System.Drawing.Size(236, 75)
        Me.btn_correction.TabIndex = 6
        Me.btn_correction.Text = "Correction"
        Me.btn_correction.UseVisualStyleBackColor = False
        '
        'Button_nv_grille
        '
        Me.Button_nv_grille.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button_nv_grille.Font = New System.Drawing.Font("Consolas", 9.1!)
        Me.Button_nv_grille.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_nv_grille.Location = New System.Drawing.Point(811, 410)
        Me.Button_nv_grille.Name = "Button_nv_grille"
        Me.Button_nv_grille.Size = New System.Drawing.Size(292, 80)
        Me.Button_nv_grille.TabIndex = 7
        Me.Button_nv_grille.Text = "Nouvelle grille"
        Me.Button_nv_grille.UseVisualStyleBackColor = False
        '
        'label_nom_joueur
        '
        Me.label_nom_joueur.AutoSize = True
        Me.label_nom_joueur.Font = New System.Drawing.Font("Consolas", 13.1!)
        Me.label_nom_joueur.ForeColor = System.Drawing.Color.Black
        Me.label_nom_joueur.Location = New System.Drawing.Point(44, 49)
        Me.label_nom_joueur.Name = "label_nom_joueur"
        Me.label_nom_joueur.Size = New System.Drawing.Size(86, 47)
        Me.label_nom_joueur.TabIndex = 8
        Me.label_nom_joueur.Text = "Nom"
        '
        'btn_valider
        '
        Me.btn_valider.BackColor = System.Drawing.Color.Green
        Me.btn_valider.Font = New System.Drawing.Font("Consolas", 9.1!)
        Me.btn_valider.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_valider.Location = New System.Drawing.Point(351, 589)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(235, 97)
        Me.btn_valider.TabIndex = 10
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(782, 241)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(347, 544)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(971, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(117, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        Me.info_enregis.SetToolTip(Me.PictureBox2, "Enregistrer la partie")
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(811, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        Me.info_enregis.SetToolTip(Me.PictureBox3, "Reprendre dernière sauvegarde")
        '
        'info_enregis
        '
        Me.info_enregis.AutomaticDelay = 0
        Me.info_enregis.AutoPopDelay = 0
        Me.info_enregis.InitialDelay = 0
        Me.info_enregis.ReshowDelay = 0
        '
        'Sudoku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 755)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.label_nom_joueur)
        Me.Controls.Add(Me.Button_nv_grille)
        Me.Controls.Add(Me.btn_correction)
        Me.Controls.Add(Me.label_timer)
        Me.Controls.Add(Me.btn_abandonner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Sudoku"
        Me.Text = "Sudoku"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_abandonner As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents label_timer As Label
    Friend WithEvents btn_correction As Button
    Friend WithEvents Button_nv_grille As Button
    Friend WithEvents label_nom_joueur As Label
    Friend WithEvents btn_valider As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents info_enregis As ToolTip
End Class
