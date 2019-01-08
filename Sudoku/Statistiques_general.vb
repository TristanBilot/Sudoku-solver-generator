Imports System.IO

Public Class Statistiques_general
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_nom.SelectedIndexChanged
        list_nom.SelectedIndex = sender.selectedIndex
        list_score.SelectedIndex = sender.selectedIndex
    End Sub

    Private Sub Statistiques_general_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file As New StreamReader(Sudoku.chemin & "Joueurs.txt")
        While file.Peek >= 0
            list_nom.Items.Add(file.ReadLine.Split(" ")(0)) 'récupère le premier élément de chaque ligne
        End While
        file.Close()

        Dim reader As New StreamReader(Sudoku.chemin & "Joueurs.txt")
        Dim joueurs(nbJoueursInFile) As String
        Dim scores(nbJoueursInFile) As Integer
        Dim i As Integer = 0

        While reader.Peek >= 0
            joueurs(i) = reader.ReadLine
            i += 1
        End While
        reader.Close()

        For j As Integer = 0 To nbJoueursInFile() - 1
            If Not joueurs(j) = "" Then
                Dim reader2 As New StreamReader(Sudoku.chemin & "stat\" & joueurs(j) & ".txt")
                scores(j) = reader2.ReadLine.Split(" ")(0)
                reader2.Close()
            End If
        Next

        For j As Integer = 0 To nbJoueursInFile() - 1
            list_score.Items.Add(scores(j))
        Next

        Dim read As New StreamReader(Sudoku.chemin & "Joueurs.txt")
        While read.Peek >= 0
            ComboBox1.Items.Add(read.ReadLine.Split(" ")(0)) 'récupère le premier élément de chaque ligne
        End While
        read.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If list_nom.SelectedItem = "" Then
            MsgBox("Veuillez sélectionner un joueur.")
            Return
        End If
        Dim file As New StreamReader(Sudoku.chemin & "stat\" & list_nom.SelectedItem.ToString & ".txt")
        Dim tempsJeu As Integer
        Dim nbPartiesJouees As Integer
        Dim meilleurTemps As Integer

        While file.Peek >= 0
            Dim ligne As String = file.ReadLine

            tempsJeu = ligne.Split(" ")(0)
            nbPartiesJouees = ligne.Split(" ")(1)
            meilleurTemps = ligne.Split(" ")(2)

            Statistiques.label_nom.Text = list_nom.SelectedItem.ToString
            Statistiques.label_temps_jeu.Text = tempsJeu
            Statistiques.label_nb_parties.Text = nbPartiesJouees
            Statistiques.label_best_temps.Text = meilleurTemps

        End While

        file.Close()
        Statistiques.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub radio_score_CheckedChanged(sender As Object, e As EventArgs) Handles radio_score.Click
        If radio_score.Checked = False Then
            radio_score.Checked = True
            radio_nom.Checked = False
        End If
    End Sub

    Private Sub radio_nom_CheckedChanged(sender As Object, e As EventArgs) Handles radio_nom.Click

        If radio_nom.Checked = False Then
            radio_nom.Checked = True
        End If
    End Sub

    Private Sub radio_score_CheckedChanged_1(sender As Object, e As EventArgs) Handles radio_score.CheckedChanged
        For i As Integer = list_score.Items.Count - 1 To 1 Step -1
            For j As Integer = 0 To i - 1
                If list_score.Items(j) > list_score.Items(j + 1) Then
                    Dim tmp = list_score.Items(j), tmp2 = list_nom.Items(j)
                    list_score.Items.RemoveAt(j)
                    list_score.Items.Insert(j + 1, tmp)
                    list_nom.Items.RemoveAt(j)
                    list_nom.Items.Insert(j + 1, tmp2)

                End If
            Next
        Next

    End Sub

    Private Sub radio_nom_CheckedChanged_1(sender As Object, e As EventArgs) Handles radio_nom.CheckedChanged
        For i As Integer = list_score.Items.Count - 1 To 1 Step -1
            For j As Integer = 0 To i - 1
                If list_nom.Items(j) > list_nom.Items(j + 1) Then
                    Dim tmp = list_score.Items(j), tmp2 = list_nom.Items(j)
                    list_score.Items.RemoveAt(j)
                    list_score.Items.Insert(j + 1, tmp)
                    list_nom.Items.RemoveAt(j)
                    list_nom.Items.Insert(j + 1, tmp2)

                End If
            Next
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        For i As Integer = 0 To nbJoueursInFile() - 1
            If list_nom.Items(i).ToString = ComboBox1.Text Then
                list_nom.SetSelected(i, True)
            End If
        Next
    End Sub
End Class