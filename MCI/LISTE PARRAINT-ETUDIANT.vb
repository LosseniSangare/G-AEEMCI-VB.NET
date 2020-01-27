Public Class LISTE_PARRAINT_ETUDIANT

    Private Sub LISTE_PARRAINT_ETUDIANT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SPECIALITE_BOX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SPECIALITE_BOX.SelectedIndexChanged
        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT e.*,a.*,p.* FROM etudiant e,attribuer a, parrain p WHERE e.nce_et=a.nce_et "
            cmd.CommandText &= "AND e.filiere_et= '" & SPECIALITE_BOX.SelectedItem & "'AND p.nce_par=a.nce_par ORDER BY nom_et ASC"
            dr = cmd.ExecuteReader
            compt = 0


            ListV.View = View.Details
            ListV.BackColor = Color.AliceBlue
            ListV.Alignment = ListViewAlignment.SnapToGrid
            ListV.Columns.Add("NOMS ET PRENOMS ETUDIANTS  ", 300, HorizontalAlignment.Left)
            ListV.Columns.Add("CONTACTS ETUDIANTS", 300, HorizontalAlignment.Left)
            ListV.Columns.Add("   NOMS ET PRENOMS PARRAINS  ", 310, HorizontalAlignment.Left)
            ListV.Columns.Add("CONTACTS PARRAINS ", 210, HorizontalAlignment.Left)
            While dr.Read
                Dim liv As New ListViewItem
                liv.Text = dr.GetString("nom_et") & " " & dr.GetString("prenom_et")
                ' liv.Checked = False
                liv.SubItems.Add(dr.GetString("telephone_et"))
                liv.SubItems.Add(dr.GetString("nom_par") & " " & dr.GetString("prenom_par"))
                liv.SubItems.Add(dr.GetString("telephone_par"))
                ListV.Items.Add(liv)
                compt = compt + 1

            End While

            If compt = 0 Then
                MsgBox("LA LISTE EST VIDE")
            End If

            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ACCUEIL.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()

    End Sub
End Class