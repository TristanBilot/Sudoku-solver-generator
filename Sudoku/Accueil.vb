Imports System.IO

Public Class Accueil

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles label_choisirJoueur.Click

    End Sub


    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Dim msg = MsgBox("Etes-vous sûr de quitter ?", vbOKCancel)
        If msg = vbOK Then
            Me.Close() ' fermeture du formulaire
        End If
    End Sub

    Private Sub btn_jouer_Click(sender As Object, e As EventArgs) Handles btn_jouer.Click

        If ComboBox1.Text = "" Then ' si nom contient 0 carac
            ComboBox1.ForeColor = Color.FromArgb(218, 16, 16) 'couleur rouge car erreur
            MsgBox("Veuillez entrer un nom.")
            Return
        End If

        If ComboBox1.Text.Contains(" ") Then
            MsgBox("Votre nom ne doit pas posséder d'espaces.")
            Return
        End If

        ' --------------------------------------------
        ' SELECTION JOUEUR DEJA EXISTANT

        If Module_joueurs.nomExistant(ComboBox1.Text) Then ' si le nom existe dans le fichier
            Sudoku.session = ComboBox1.Text 'session ouverte avec le nom indiqué
            Me.Hide() 'cache la fenêtre d'accueil
            Sudoku.label_nom_joueur.Text = ComboBox1.Text
            Sudoku.Show() 'lance le jeu
            Sudoku.chargerSudoku()
        Else
            Module_joueurs.newJoueur(ComboBox1.Text)
            Sudoku.session = ComboBox1.Text 'session ouverte avec le nom indiqué
            Me.Hide() 'cache la fenêtre d'accueil
            Sudoku.label_nom_joueur.Text = ComboBox1.Text
            Sudoku.Show() 'lance le jeu
            Sudoku.chargerSudoku()
        End If

    End Sub


    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module_joueurs.chargerComboBox()
        Me.Size = New Size(400, 400)
    End Sub

    Private Sub btn_statistiques_Click(sender As Object, e As EventArgs) Handles btn_statistiques.Click

        If Module_joueurs.nomExistant(ComboBox1.Text) Then ' si le joueur existe
            Statistiques_general.Show()
            Me.Hide()
        Else
            MsgBox("Pas encore de sauvegarde pour ce joueur.", vbOKOnly)
        End If
    End Sub

End Class