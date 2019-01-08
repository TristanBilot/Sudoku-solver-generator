Imports System.Timers
Imports System.IO

Public Class Sudoku

    ' plateau de 9x9 cases pour un plateau de sudoku
    Public plateau(0 To 8, 0 To 8) As TextBox
    Dim margeX As Integer = 0
    Dim margeY As Integer = 0
    Public session As String

    Dim random As New Random()
    Dim id As Integer ' nb aléatoire    

    Public TEMPS_INITIAL As Integer = 60
    ' Public secondes As Integer = Integer.Parse(difficulté.TextBoxSeconde.Text) 'timer
    Public secondes As Integer = TEMPS_INITIAL

    Dim orange As Color = Color.LightGray ' identificateur de case de base
    Dim red As Color = Color.Red
    Dim green As Color = Color.Green
    Dim white As Color = Color.GhostWhite
    Dim fontColor As Color = Color.White

    Public chemin As String = "..\..\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(chemin & "HarryPotter.wav", AudioPlayMode.BackgroundLoop)
        Me.Text = "SUDOKU : " & Accueil.ComboBox1.Text

        For i As Integer = 0 To 8  'parcourt toutes les cases (i = x, j = y)
            For j As Integer = 0 To 8
                plateau(i, j) = New TextBox ' intancie chaque cellule 
                plateau(i, j).Width = 20 'taille de chaque cellule
                plateau(i, j).Height = 20
                plateau(i, j).Text = "" ' initialisation
                plateau(i, j).Location = New Point(i * 20, j * 20)
                plateau(i, j).Tag = New Point(i, j)
                Me.Controls.Add(plateau(i, j)) 'ajoute et permet l'affichage du plateau
                plateau(i, j).MaxLength = 1 ' bloque l'écriture à 1 seul caractère

                plateau(i, j).TextAlign = Windows.Forms.HorizontalAlignment.Center
                AddHandler plateau(i, j).KeyPress, AddressOf txtBox_KeyPress 'bloquage des lettres
                'affichage en forme de régions
                AddHandler plateau(i, j).KeyPress, AddressOf TextBox_TextChanged

                margeX = 0
                margeY = 0

                If i > 2 Then
                    margeX = 4
                End If
                If i > 5 Then
                    margeX = 8
                End If
                If j > 2 Then
                    margeY = 4
                End If
                If j > 5 Then
                    margeY = 8
                End If
                Dim ecartX = 45 + i * 20 + margeX ' 45: marge gauche
                Dim ecartY = 60 + j * 20 + margeY
                plateau(i, j).Location = New Point(ecartX, ecartY)
            Next
        Next

        Timer.Interval = 1000
        Timer.Start()
        afficheHeure(sender, e)

        Module_joueurs.addNewPartie(label_nom_joueur.Text)



    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_abandonner.Click
        Dim msg = MsgBox("Etes-vous sûr de vouloir abandonner la partie ?", vbOKCancel)
        If vbOK Then
            My.Computer.Audio.Stop()
        End If
        Dim TEMPS = TEMPS_INITIAL - secondes
        If msg = vbOK Then
            Module_joueurs.addTempsJeu(label_nom_joueur.Text, TEMPS)
            Accueil.Show()
            Me.Close() ' fermeture du formulaire
        End If

    End Sub

    Public Sub rejouer()
        Me.Show()
        Me.chargerSudoku()
    End Sub

    Private Sub afficheHeure(sender As System.Object, e As System.EventArgs) _
        Handles Timer.Tick
        secondes -= 1 'incrémente le compteur chaque seconde
        label_timer.Text = secondes ' affiche dans le label
        If secondes = 0 Then 'fin du compteur OU PARTIE TERMINEE
            Timer.Stop()
            Temps_écoulé.Show() 'affiche fenêtre 
            Dim TEMPS As Integer = TEMPS_INITIAL - secondes 'temps réelement effectué


        End If

    End Sub

    Public Function sauvegarde_existe(nomJoueur As String) As Boolean
        Return System.IO.File.Exists(chemin & "sauvegardes\" & nomJoueur & ".txt")
    End Function

    Public Sub sauvegarde(nom As String)
        If Not System.IO.File.Exists(chemin & "sauvegardes\" & nom & ".txt") Then ' si le fichier n'existe pas
            Dim fs As FileStream = System.IO.File.Create(chemin & nom & ".txt") ' on le créer
            fs.Close()
        End If

        'Dim file As New StreamReader(chemin & nom & ".txt") ' ouverture
        'While file.Peek >= 0
        '    file.ReadLine() ' pour aller en fin de fichier
        'End While
        'file.Close()

        Dim ecriture As New StreamWriter(chemin & "sauvegardes\" & nom & ".txt") ' écriture
        Dim nombreJoué As String


        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If Not plateau(x, y).Text = "" And Not plateau(x, y).BackColor = orange Then ' METTRE LE AND NUMERO DEFINI DE BASE s'il y a un chiffre

                    nombreJoué = plateau(x, y).Text
                    ecriture.WriteLine(id & " " & nombreJoué & " " & x & " " & y & " " & secondes, True) ' ex : 1 8 8 : nb 1 a la pos (8,8)
                    ' laisser true pour écriture à la suite du fichier

                End If
            Next
        Next
        MsgBox("Votre jeu a bien été sauvegardé !")
        ecriture.Close()

    End Sub

    Private Sub recup_sauvegarde(nom As String)
        Dim id, nombre, x, y As String
        Dim file As New StreamReader(chemin & "sauvegardes\" & nom & ".txt")
        Dim ligne As String = file.ReadLine
        Dim temps As Integer

        id = ligne.Split(" ")(0)
        chargerSudoku(id) 'chargement du bon sudoku
        nombre = ligne.Split(" ")(1)
        x = ligne.Split(" ")(2)
        y = ligne.Split(" ")(3)
        temps = ligne.Split(" ")(4)
        secondes = temps

        plateau(x, y).Text = nombre 'chargement de la première ligne du fichier

        While file.Peek >= 0
            ligne = file.ReadLine
            nombre = ligne.Split(" ")(1)
            x = ligne.Split(" ")(2)
            y = ligne.Split(" ")(3)
            plateau(x, y).Text = nombre
        End While
        file.Close()
    End Sub

    Private Sub btn_sauvegarde_Click(sender As Object, e As EventArgs)
        sauvegarde(label_nom_joueur.Text) 'sauvegarde le joueur courant

    End Sub

    Public Sub chargerSudoku() 'chargement aléatoire de sudoku
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                plateau(x, y).Enabled = True
            Next
        Next
        Timer.Start()
        secondes = TEMPS_INITIAL

        id = random.Next(0, 4) + 1
        Dim file As New StreamReader(chemin & "Sudoku_a_resoudre\sudoku" & id & ".txt")
        While file.Peek >= 0
            For y As Integer = 0 To 8
                Dim ligneSplit As String() = file.ReadLine.Split(" ")
                For x As Integer = 0 To 8
                    If ligneSplit(x) <> 0 Then
                        plateau(x, y).Text = ligneSplit(x).ToString
                        plateau(x, y).BackColor = orange
                        plateau(x, y).ForeColor = fontColor
                        plateau(x, y).Enabled = False
                    Else
                        plateau(x, y).Text = ""
                        plateau(x, y).BackColor = white
                    End If

                Next
            Next
        End While
        file.Close()
    End Sub

    Public Sub chargerSudoku(id As Integer) 'chargement d'un sudoku précis (pour récup sauvegarde)
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                plateau(x, y).Enabled = True
            Next
        Next
        Dim file As New StreamReader(chemin & "Sudoku_a_resoudre\sudoku" & id & ".txt")
        While file.Peek >= 0
            For y As Integer = 0 To 8
                Dim ligneSplit As String() = file.ReadLine.Split(" ")
                For x As Integer = 0 To 8
                    If ligneSplit(x) <> 0 Then
                        plateau(x, y).Text = ligneSplit(x).ToString
                        plateau(x, y).BackColor = orange
                        plateau(x, y).Enabled = False
                    Else
                        plateau(x, y).Text = ""
                        plateau(x, y).BackColor = white
                    End If

                Next
            Next
        End While
        file.Close()
    End Sub

    Public Sub btn_Correction_Click(sender As Object, e As EventArgs) Handles btn_Correction.Click
        Dim file As New StreamReader(chemin & "Sudoku_Correction\correction" & id & ".txt")
        Timer.Stop()
        My.Computer.Audio.Stop()
        While file.Peek >= 0
            For y As Integer = 0 To 8
                Dim ligneSplit As String() = file.ReadLine.Split(" ")
                For x As Integer = 0 To 8
                    If ligneSplit(x) <> 0 Then
                        If plateau(x, y).Text <> ligneSplit(x) Then
                            plateau(x, y).BackColor = red
                        Else
                            plateau(x, y).BackColor = green
                        End If
                        plateau(x, y).Text = ligneSplit(x).ToString

                    End If
                Next
            Next
        End While
        file.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_nv_grille.Click
        chargerSudoku()
        Dim TEMPS = TEMPS_INITIAL - secondes
        Module_joueurs.addTempsJeu(label_nom_joueur.Text, TEMPS)
    End Sub

    Private Sub txtBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim coord_x = sender.tag.X
        Dim coord_y = sender.tag.Y
        If TypeOf sender Is TextBox Then
            For x As Integer = 0 To 8
                For y As Integer = 0 To 8
                    If Not verifLigneColonne(coord_x, coord_y) OrElse Not verifRegion(coord_x, coord_y) Then
                        plateau(coord_x, coord_y).ForeColor = red
                    Else
                        plateau(coord_x, coord_y).ForeColor = Color.Black
                    End If

                Next
            Next
        End If

    End Sub

    Private Sub btn_reprendre_Click(sender As Object, e As EventArgs)
        Dim nom As String = label_nom_joueur.Text
        If sauvegarde_existe(nom) Then
            Dim msg = MsgBox("Attention, en reprenant la dernière sauvegarde vous allez quitter la partie en cours.", vbOKCancel)
            If msg = vbOK Then
                recup_sauvegarde(nom)
                Dim TEMPS = TEMPS_INITIAL - secondes
                Module_joueurs.addTempsJeu(label_nom_joueur.Text, TEMPS)
                For x As Integer = 0 To 8
                    For y As Integer = 0 To 8
                        If Not plateau(x, y).BackColor = orange Then
                            plateau(x, y).Enabled = True
                        End If
                    Next
                Next
            End If

        Else
            MsgBox("Aucune sauvegarde n'existe pour ce joueur.", vbOKOnly)
        End If

    End Sub

    Public Function isGood() As Boolean
        ' return si le sudoku est correct
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8

                If plateau(i, j).Enabled Then
                    If Not verifLigneColonne(i, j) OrElse Not verifRegion(i, j) Then
                        plateau(i, j).BackColor = red

                    End If
                End If
            Next
        Next
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                If plateau(i, j).BackColor = red Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim nom As String = label_nom_joueur.Text
        Dim TEMPS = TEMPS_INITIAL - secondes
        Timer.Stop()
        My.Computer.Audio.Stop()
        If isGood() Then
            If TEMPS < Module_joueurs.meilleurTemps(nom) Then
                modifierMeilleurTemps(nom, TEMPS)
                MsgBox("Bravo, vous avez battu votre record !")
            Else
                MsgBox("Bravo, vous avez gagné ! Votre score est : " & TEMPS_INITIAL - secondes)
            End If
        Else
            MsgBox("Dommage, vous avez perdu :(")
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sauvegarde(label_nom_joueur.Text) 'sauvegarde le joueur courant
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim nom As String = label_nom_joueur.Text
        If sauvegarde_existe(nom) Then
            Dim msg = MsgBox("Attention, en reprenant la dernière sauvegarde vous allez quitter la partie en cours.", vbOKCancel)
            If msg = vbOK Then
                recup_sauvegarde(nom)
                Dim TEMPS = TEMPS_INITIAL - secondes
                Module_joueurs.addTempsJeu(label_nom_joueur.Text, TEMPS)
                For x As Integer = 0 To 8
                    For y As Integer = 0 To 8
                        If Not plateau(x, y).BackColor = orange Then
                            plateau(x, y).Enabled = True
                        End If
                    Next
                Next
            End If

        Else
            MsgBox("Aucune sauvegarde n'existe pour ce joueur.", vbOKOnly)
        End If
    End Sub

    Function verifRegion(i As Integer, j As Integer) As Boolean
        Dim di As Integer = If(i < 3, 0, If(i < 6, 3, 6))
        Dim dj As Integer = If(j < 3, 0, If(j < 6, 3, 6))

        For vi As Integer = di To di + 2
            For vj As Integer = dj To dj + 2
                If Not (vj = j And vi = i) AndAlso plateau(i, j).Text = plateau(vi, vj).Text Or plateau(i, j).Text = "" Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Function verifLigneColonne(i As Integer, j As Integer) As Boolean
        For x As Integer = 0 To 8
            If plateau(i, j).Text = plateau(x, j).Text AndAlso Not (x = i) Then
                Return False
            End If
            If Not (x = j) AndAlso plateau(i, j).Text = plateau(i, x).Text Then
                Return False
            End If
        Next
        Return True
    End Function


End Class
