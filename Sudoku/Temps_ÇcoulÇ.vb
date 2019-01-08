Public Class Temps_écoulé
    Private Sub btn_restart_temps_ecoule_Click(sender As Object, e As EventArgs) Handles btn_restart_temps_ecoule.Click
        Sudoku.rejouer()
        Me.Close()
    End Sub

    Private Sub btn_accueil_temps_ecoule_Click(sender As Object, e As EventArgs) Handles btn_accueil_temps_ecoule.Click
        Accueil.Show()
        Sudoku.Close()
        Me.Close()
        My.Computer.Audio.Stop()
    End Sub
End Class