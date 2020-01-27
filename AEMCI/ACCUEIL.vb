Public Class ACCUEIL

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ENREGISTREMENT.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ENREGISTREMENT.titre.Text = "ENREGISTREMENT PARRAIN"
        ENREGISTREMENT.MENU1.Text = "FILIERE DU PARRAIN"
        ENREGISTREMENT.Show()
        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ATTRIBUTION.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LISTE_PARRAINT_ETUDIANT.Show()
        Me.Close()

    End Sub
End Class