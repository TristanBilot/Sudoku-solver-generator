Imports System.IO

Module Module_joueurs
    Public Structure joueur
        Public nom As String
        Dim meilleurTemps As Integer
        Dim nbPartiesJouees As Integer
        Dim tempsJeu As Integer
    End Structure

    Dim nbJoueurs As Integer = 0
    Dim joueurs(20) As joueur
    Dim last As Integer = -1


    Public Sub newJoueur(nouveauNom As String)
        If nomExistant(nouveauNom) Then
            MsgBox("Le nom entré existe déjà.")
            Exit Sub
        Else
            last += 1
            joueurs(nbJoueurs).nom = nouveauNom
            joueurs(nbJoueurs).meilleurTemps = 0
            joueurs(nbJoueurs).nbPartiesJouees = 0
            joueurs(nbJoueurs).tempsJeu = 0

            insererJoueur(joueurs(last).nom)
            créerFichierStat(joueurs(last).nom)

            nbJoueurs += 1
        End If
    End Sub

    Public Function GetNomsJoueurs() As ArrayList
        Dim tab As ArrayList
        For Each j As joueur In joueurs
            tab.Add(j.nom)
        Next
        Return tab
    End Function

    Public Function getNbJoueurs() As Integer
        Dim file As New StreamReader(Sudoku.chemin & "Joueurs.txt")
        Dim nb = file.ReadLine
        file.Close()
        Return nb
    End Function

    Public Function nbJoueursInFile() As Integer
        Dim file As New StreamReader(Sudoku.chemin & "Joueurs.txt")
        Dim compteur As Integer = 0
        While file.Peek >= 0
            file.ReadLine()
            compteur += 1
        End While
        file.Close()
        Return compteur
    End Function

    Public Sub insererJoueur(nom As String)
        Dim ecrire_A_La_Suite As Boolean = True
        Dim file As New StreamWriter(Sudoku.chemin & "Joueurs.txt", ecrire_A_La_Suite)
        file.WriteLine(nom)
        file.Close()
    End Sub


    Public Sub créerFichierStat(nom As String)
        Dim ecrire_A_La_Suite As Boolean = False
        Dim file As New StreamWriter(Sudoku.chemin & "stat\" & nom & ".txt", ecrire_A_La_Suite)
        file.WriteLine(Sudoku.TEMPS_INITIAL & " 0 0")
        file.Close()
    End Sub

    Public Sub modifierMeilleurTemps(nom As String, score As Integer)
        Dim reader As New StreamReader(Sudoku.chemin & "stat\" & nom & ".txt")
        Dim ligne = reader.ReadLine
        Dim nbParties = ligne.Split(" ")(1)
        Dim tempsJeu = ligne.Split(" ")(2)

        reader.Close()

        Dim file As New StreamWriter(Sudoku.chemin & "stat\" & nom & ".txt", False)
        file.WriteLine(score & " " & nbParties & " " & tempsJeu)
        file.Close()
    End Sub

    Public Sub addNewPartie(nom As String)
        Dim reader As New StreamReader(Sudoku.chemin & "stat\" & nom & ".txt")
        Dim ligne = reader.ReadLine
        Dim bestTemps = ligne.Split(" ")(0)
        Dim nbParties = ligne.Split(" ")(1)
        Dim tempsJeu = ligne.Split(" ")(2)
        nbParties += 1
        reader.Close()

        Dim file As New StreamWriter(Sudoku.chemin & "stat\" & nom & ".txt", False)
        file.WriteLine(bestTemps & " " & nbParties & " " & tempsJeu)
        file.Close()
    End Sub

    Public Sub addTempsJeu(nom As String, newTemps As Integer)
        Dim reader As New StreamReader(Sudoku.chemin & "stat\" & nom & ".txt")
        Dim ligne = reader.ReadLine
        Dim bestTemps = ligne.Split(" ")(0)
        Dim nbParties = ligne.Split(" ")(1)
        Dim tempsJeu = ligne.Split(" ")(2)
        tempsJeu += newTemps
        reader.Close()

        Dim file As New StreamWriter(Sudoku.chemin & "stat\" & nom & ".txt", False)
        file.WriteLine(bestTemps & " " & nbParties & " " & tempsJeu)
        file.Close()
    End Sub

    Public Function meilleurTemps(nom As String)
        Dim reader As New StreamReader(Sudoku.chemin & "stat\" & nom & ".txt")
        Dim ligne = reader.ReadLine
        Dim temps = ligne.Split(" ")(0)
        reader.Close()

        Return temps
    End Function

    Public Function nbParties(nom As String)
        Dim reader As New StreamReader(Sudoku.chemin & "stat\" & nom & ".txt")
        Dim ligne = reader.ReadLine
        Dim nb = ligne.Split(" ")(1)
        reader.Close()
        Return nb
    End Function

    Public Function tempsJeu(nom As String)
        Dim reader As New StreamReader(Sudoku.chemin & "stat\" & nom & ".txt")
        Dim ligne = reader.ReadLine
        Dim temps = ligne.Split(" ")(2)
        reader.Close()
        Return temps
    End Function



    Public Function lire() As String
        Dim ligne As String = ""
        Dim file As New StreamReader(Sudoku.chemin & "Joueurs.txt")
        ligne = file.ReadLine()
        file.Close()
        Return ligne
    End Function

    Public Sub chargerComboBox()
        Dim file As New StreamReader(Sudoku.chemin & "Joueurs.txt")
        While file.Peek >= 0
            Accueil.ComboBox1.Items.Add(file.ReadLine.Split(" ")(0)) 'récupère le premier élément de chaque ligne
        End While
        file.Close()
    End Sub

    Public Function nomExistant(nom As String) As Boolean
        Dim file As New StreamReader(Sudoku.chemin & "Joueurs.txt")
        Dim currentName As String = ""
        While file.Peek >= 0
            currentName = file.ReadLine.Split(" ")(0)
            If currentName = nom Then 'si le mot de chaque ligne du fichier est égal au nom dans la comboBox
                file.Close()
                Return True
            End If
        End While
        file.Close()
        Return False
    End Function

    Public Function getBestPlayer() As String
        Dim file As New StreamReader(Sudoku.chemin & "Joueurs.txt")
        Dim joueurs(nbJoueursInFile) As String
        Dim scores(nbJoueursInFile) As Integer
        Dim i As Integer = 0

        While file.Peek >= 0
            joueurs(i) = file.ReadLine
            i += 1
        End While
        file.Close()

        For j As Integer = 0 To nbJoueursInFile() - 1
            If Not joueurs(j) = "" Then
                Dim reader As New StreamReader(Sudoku.chemin & "stat\" & joueurs(j) & ".txt")
                scores(j) = reader.ReadLine.Split(" ")(0)
                reader.Close()
            End If
        Next

        Dim max As Integer = scores(0)
        Dim bestJoueur As Integer
        For j As Integer = 1 To nbJoueursInFile()
            If scores(j) < max Then
                max = scores(j)
                bestJoueur = j
            End If
        Next

        Return joueurs(bestJoueur)
    End Function

    Public Function getBestScore() As Integer
        Dim player As String = getBestPlayer()
        Dim reader As New StreamReader(Sudoku.chemin & "stat\" & player & ".txt")
        Dim score = reader.ReadLine.Split(" ")(0)
        reader.Close()
        Return score

    End Function




End Module
