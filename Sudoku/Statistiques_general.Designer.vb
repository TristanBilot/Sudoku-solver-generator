<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Statistiques_general
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistiques_general))
        Me.label_nom = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.list_nom = New System.Windows.Forms.ListBox()
        Me.list_score = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.radio_score = New System.Windows.Forms.RadioButton()
        Me.radio_nom = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.comboBox_Joueur = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_nom
        '
        Me.label_nom.AutoSize = True
        Me.label_nom.Font = New System.Drawing.Font("Consolas", 13.1!)
        Me.label_nom.Location = New System.Drawing.Point(347, 152)
        Me.label_nom.Name = "label_nom"
        Me.label_nom.Size = New System.Drawing.Size(166, 51)
        Me.label_nom.TabIndex = 0
        Me.label_nom.Text = "Joueur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 13.1!)
        Me.Label2.Location = New System.Drawing.Point(618, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 51)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Meilleur score"
        '
        'list_nom
        '
        Me.list_nom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.list_nom.Font = New System.Drawing.Font("Consolas", 10.1!)
        Me.list_nom.FormattingEnabled = True
        Me.list_nom.ItemHeight = 40
        Me.list_nom.Location = New System.Drawing.Point(263, 247)
        Me.list_nom.Name = "list_nom"
        Me.list_nom.Size = New System.Drawing.Size(328, 204)
        Me.list_nom.TabIndex = 2
        '
        'list_score
        '
        Me.list_score.Cursor = System.Windows.Forms.Cursors.Hand
        Me.list_score.Font = New System.Drawing.Font("Consolas", 10.1!)
        Me.list_score.FormattingEnabled = True
        Me.list_score.ItemHeight = 40
        Me.list_score.Location = New System.Drawing.Point(666, 247)
        Me.list_score.Name = "list_score"
        Me.list_score.Size = New System.Drawing.Size(237, 204)
        Me.list_score.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Consolas", 11.1!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(586, 703)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(280, 108)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Détails"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Consolas", 11.1!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(157, 703)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(280, 108)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Retour"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'radio_score
        '
        Me.radio_score.AutoSize = True
        Me.radio_score.Font = New System.Drawing.Font("Consolas", 7.1!)
        Me.radio_score.Location = New System.Drawing.Point(263, 529)
        Me.radio_score.Name = "radio_score"
        Me.radio_score.Size = New System.Drawing.Size(361, 32)
        Me.radio_score.TabIndex = 6
        Me.radio_score.TabStop = True
        Me.radio_score.Text = "Trier par meilleur score"
        Me.radio_score.UseVisualStyleBackColor = True
        '
        'radio_nom
        '
        Me.radio_nom.AutoSize = True
        Me.radio_nom.Font = New System.Drawing.Font("Consolas", 7.1!)
        Me.radio_nom.Location = New System.Drawing.Point(694, 529)
        Me.radio_nom.Name = "radio_nom"
        Me.radio_nom.Size = New System.Drawing.Size(413, 32)
        Me.radio_nom.TabIndex = 7
        Me.radio_nom.TabStop = True
        Me.radio_nom.Text = "Trier par ordre alphabétique"
        Me.radio_nom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 56)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Statistiques"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(240, 619)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(322, 39)
        Me.ComboBox1.TabIndex = 9
        '
        'comboBox_Joueur
        '
        Me.comboBox_Joueur.AutoSize = True
        Me.comboBox_Joueur.Font = New System.Drawing.Font("Consolas", 9.1!)
        Me.comboBox_Joueur.Location = New System.Drawing.Point(589, 619)
        Me.comboBox_Joueur.Name = "comboBox_Joueur"
        Me.comboBox_Joueur.Size = New System.Drawing.Size(119, 37)
        Me.comboBox_Joueur.TabIndex = 10
        Me.comboBox_Joueur.Text = "Joueur"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 208)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 295)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Statistiques_general
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 877)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.comboBox_Joueur)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.list_score)
        Me.Controls.Add(Me.list_nom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radio_nom)
        Me.Controls.Add(Me.radio_score)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label_nom)
        Me.Name = "Statistiques_general"
        Me.Text = "Statistiques_general"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_nom As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents list_nom As ListBox
    Friend WithEvents list_score As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents radio_score As RadioButton
    Friend WithEvents radio_nom As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents comboBox_Joueur As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
