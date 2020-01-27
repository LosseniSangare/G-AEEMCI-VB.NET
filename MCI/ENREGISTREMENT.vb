Public Class ENREGISTREMENT

  

    Private Sub MI_Click(sender As Object, e As EventArgs) Handles MI.Click
        niveau = "LICENCE 1"
        specialite = "MATHS INFO"
        MENU1.Text = "L1 MATHS INFO"
    End Sub

    Private Sub L2_INFO_Click(sender As Object, e As EventArgs) Handles L2_INFO.Click
        niveau = "LICENCE 2"
        specialite = "INFORMATIQUE"
        MENU1.Text = "L2 INFO"
    End Sub

    Private Sub L3_INFO_Click(sender As Object, e As EventArgs) Handles L3_INFO.Click
        niveau = "LICENCE 3"
        specialite = "INFORMATIQUE"
        MENU1.Text = "L3 INFO"
    End Sub

    Private Sub L1_PC_Click(sender As Object, e As EventArgs) Handles L1_PC.Click
        niveau = "LICENCE 1"
        specialite = "PHYSIQUE CHIMIE"
        MENU1.Text = "L1 PC"

    End Sub

    Private Sub L2_PC_Click(sender As Object, e As EventArgs) Handles L2_PC.Click
        niveau = "LICENCE 2"
        specialite = "PHYSIQUE CHIMIE"
        MENU1.Text = "L2 PC"

    End Sub

    Private Sub L2_MATHS_Click(sender As Object, e As EventArgs) Handles L2_MATHS.Click
        niveau = "LICENCE 2"
        specialite = "MATHEMATIQUES"
        MENU1.Text = "L2 MATHS"
    End Sub

    Private Sub L3_MATHS_Click(sender As Object, e As EventArgs) Handles L3_MATHS.Click
        niveau = "LICENCE 3"
        specialite = "MATHEMATIQUES"
        MENU1.Text = "L2 MATHS"
    End Sub

    Private Sub M1_GI_Click(sender As Object, e As EventArgs) Handles M1_GI.Click
        niveau = "MASTER 1"
        specialite = "GENIE INFORMATIQUE"
        MENU1.Text = "M1 GI"
    End Sub

    Private Sub M2_GI_Click(sender As Object, e As EventArgs) Handles M2_GI.Click
        niveau = "MASTER 2"
        specialite = "GENIE INFORMATIQUE"
        MENU1.Text = "M2 GI"
    End Sub

    Private Sub M1_MIAGE_Click(sender As Object, e As EventArgs) Handles M1_MIAGE.Click
        niveau = "MASTER 1"
        specialite = "MIAGE"
        MENU1.Text = "M1 MIAGE"
    End Sub

    Private Sub M2_MIAGE_Click(sender As Object, e As EventArgs) Handles M2_MIAGE.Click
        niveau = "MASTER 2"
        specialite = "MIAGE"
        MENU1.Text = "M2 MIAGE"
    End Sub

    Private Sub CHIMIE_Click(sender As Object, e As EventArgs) Handles CHIMIE.Click

    End Sub

    Private Sub L3_CH_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub L3_PH_Click(sender As Object, e As EventArgs)
        niveau = "LICENCE 3"
        specialite = "PHYSIQUE"
        MENU1.Text = "L3 PHYSIQUE"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub M2_CH_Click(sender As Object, e As EventArgs) Handles M2_CH.Click
        niveau = "MASTER 2"
        specialite = "CHIMIE"
        MENU1.Text = "M2 CHIMIE"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles titre.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (titre.Text = "ENREGISTRER NOUVEAU ETUDIANT") Then

            'ENREGISTREMENT ETUDIANT
            Try
                CN.Open()
                cmd.Connection = CN
                Dim parrainer As String = "NON"
                cmd.CommandText = "INSERT INTO etudiant (nce_et,nom_et,prenom_et,filiere_et,niveau_et, telephone_et,parrainer) VALUE ('" & NCE_TXT.Text & "','" & NOM_TXT.Text & "','" & PRENOMS_TXT.Text & "','" & specialite & "','" & niveau & "','" & TEL_TXT.Text & "','" & parrainer & "')"
                dr = cmd.ExecuteReader
                MsgBox("ETUDIANT " & NOM_TXT.Text & " " & PRENOMS_TXT.Text & " ENREGISTRE AVEC SUCCES !!!")
                CN.Close()
                MENU1.Text = "FILIERE D' ETUDAINT"
            Catch ex As Exception
                MsgBox(ex.Message)
                CN.Close()
            End Try
        Else
            'ENREGISTREMENT PARRAIN
  Try
                CN.Open()
                cmd.Connection = CN
                Dim parrainer As String = "NON"
                cmd.CommandText = "INSERT INTO parrain (nce_par,nom_par,prenom_par,filiere_par,niveau_par, telephone_par,parrain_ok) VALUE ('" & NCE_TXT.Text & "','" & NOM_TXT.Text & "','" & PRENOMS_TXT.Text & "','" & specialite & "','" & niveau & "','" & TEL_TXT.Text & "','" & parrainer & "')"
                dr = cmd.ExecuteReader
                MsgBox("PARRAIN " & NOM_TXT.Text & " " & PRENOMS_TXT.Text & " ENREGISTRE AVEC SUCCES !!!")
                CN.Close()
                MENU1.Text = "FILIERE DU PARRAIN"
            Catch ex As Exception
                MsgBox(ex.Message)
                CN.Close()
            End Try
        End If

        NCE_TXT.Text = ""
        NOM_TXT.Text = ""
        PRENOMS_TXT.Text = ""
        TEL_TXT.Text = ""


    End Sub


    Private Sub M1_MATHS_Click(sender As Object, e As EventArgs) Handles M1_MATHS.Click
        niveau = "MASTER 1"
        specialite = "MATHEMATIQUE"
        MENU1.Text = "M1 MATHS"

    End Sub

    Private Sub M2_MATHS_Click(sender As Object, e As EventArgs) Handles M2_MATHS.Click
        niveau = "MASTER 2"
        specialite = "MATHEMATIQUE"
        MENU1.Text = "M2 MATHS"
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ACCUEIL.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()

    End Sub

    Private Sub MIAGE_Click(sender As Object, e As EventArgs) Handles MIAGE.Click

    End Sub

    Private Sub L3_PH_Click_1(sender As Object, e As EventArgs) Handles L3_PH.Click
        niveau = "LICENCE 3"
        specialite = "PHYSIQUE"
        MENU1.Text = "L3 PHYSIQUE"
    End Sub

    Private Sub M1_PH_Click(sender As Object, e As EventArgs) Handles M1_PH.Click
        niveau = "MASTER 1"
        specialite = "PHYSIQUE"
        MENU1.Text = "M1 PHYSIQUE"
    End Sub

    Private Sub M2_PH_Click(sender As Object, e As EventArgs) Handles M2_PH.Click
        niveau = "MASTER 2"
        specialite = "PHYSIQUE"
        MENU1.Text = "M2 PHYSIQUE"
    End Sub

    Private Sub L3_CH_Click_1(sender As Object, e As EventArgs) Handles L3_CH.Click
        niveau = "LICENCE 3"
        specialite = "CHIMIE"
        MENU1.Text = "L3 CHIMIE"
    End Sub

    Private Sub M1_CH_Click(sender As Object, e As EventArgs) Handles M1_CH.Click
        niveau = "MASTER 1"
        specialite = "CHIMIE"
        MENU1.Text = "M1 CHIMIE"
    End Sub
End Class
