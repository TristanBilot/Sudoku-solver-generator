<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistiques
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
        Me.label_nom = New System.Windows.Forms.Label()
        Me.label_temps_jeu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_nb_parties = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label_best_temps = New System.Windows.Forms.Label()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label_nom
        '
        Me.label_nom.AutoSize = True
        Me.label_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nom.Location = New System.Drawing.Point(69, 31)
        Me.label_nom.Name = "label_nom"
        Me.label_nom.Size = New System.Drawing.Size(0, 46)
        Me.label_nom.TabIndex = 0
        '
        'label_temps_jeu
        '
        Me.label_temps_jeu.AutoSize = True
        Me.label_temps_jeu.Location = New System.Drawing.Point(303, 157)
        Me.label_temps_jeu.Name = "label_temps_jeu"
        Me.label_temps_jeu.Size = New System.Drawing.Size(0, 32)
        Me.label_temps_jeu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Temps de jeu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre de parties jouées"
        '
        'label_nb_parties
        '
        Me.label_nb_parties.AutoSize = True
        Me.label_nb_parties.Location = New System.Drawing.Point(431, 240)
        Me.label_nb_parties.Name = "label_nb_parties"
        Me.label_nb_parties.Size = New System.Drawing.Size(0, 32)
        Me.label_nb_parties.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Meilleur temps"
        '
        'label_best_temps
        '
        Me.label_best_temps.AutoSize = True
        Me.label_best_temps.Location = New System.Drawing.Point(286, 323)
        Me.label_best_temps.Name = "label_best_temps"
        Me.label_best_temps.Size = New System.Drawing.Size(0, 32)
        Me.label_best_temps.TabIndex = 6
        '
        'btn_retour
        '
        Me.btn_retour.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_retour.ForeColor = System.Drawing.Color.White
        Me.btn_retour.Location = New System.Drawing.Point(270, 418)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(270, 80)
        Me.btn_retour.TabIndex = 9
        Me.btn_retour.Text = "Retour"
        Me.btn_retour.UseVisualStyleBackColor = False
        '
        'Statistiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 548)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.label_best_temps)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label_nb_parties)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_temps_jeu)
        Me.Controls.Add(Me.label_nom)
        Me.Name = "Statistiques"
        Me.Text = "Statistiques"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_nom As Label
    Friend WithEvents label_temps_jeu As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label_nb_parties As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label_best_temps As Label
    Friend WithEvents btn_retour As Button
End Class
