Public Class ATTRIBUTION

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ATTRIBUTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RECHERCHE.Visible = False
        PARRAIN_TXT.Visible = False
        CEL_LBL.Visible = False
        NUMERO_LBL.Visible = False
        ProgressBar1.Visible = False
        ENREGISTRER_TXT.Visible = False

        ListV.Items.Clear()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub SPECIALITE_BOX_Cick(sender As Object, e As EventArgs) Handles SPECIALITE_BOX.Click
        PARRAIN_TXT.Visible = False
        CEL_LBL.Visible = False
        NUMERO_LBL.Visible = False
        ProgressBar1.Visible = False
        ENREGISTRER_TXT.Visible = False
        RECHERCHE.Visible = False
    End Sub
    Private Sub SPECIALITE_BOX_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles SPECIALITE_BOX.SelectedIndexChanged

        PARRAIN_TXT.Visible = False
        CEL_LBL.Visible = False
        NUMERO_LBL.Visible = False
        ProgressBar1.Visible = False
        ENREGISTRER_TXT.Visible = False

        titre_tab.Text = "LES ETUDIANTS EN " & SPECIALITE_BOX.SelectedItem
        ListV.Items.Clear()
        ListV.CheckBoxes = True
        ListV.FullRowSelect = True
        compt = 0
        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT *FROM etudiant WHERE filiere_et='" & SPECIALITE_BOX.SelectedItem & "' AND parrainer='NON' "
            dr = cmd.ExecuteReader


            ListV.View = View.Details
            ' ListV.BackColor = Color.AliceBlue
            ListV.Alignment = ListViewAlignment.SnapToGrid
            ListV.Columns.Add(" NOM", 200, HorizontalAlignment.Left)
            ListV.Columns.Add(" PRENOM", 200, HorizontalAlignment.Left)
            ListV.Columns.Add("  TELEPHONE ", 180, HorizontalAlignment.Left)

            While dr.Read
                Dim liv As New ListViewItem
                liv.Text = "     " & dr.GetString("nom_et")
                ' liv.Checked = False
                liv.SubItems.Add(dr.GetString("prenom_et"))
                liv.SubItems.Add(dr.GetString("telephone_et"))
                ListV.Items.Add(liv)
                compt = compt + 1

            End While

            If compt = 0 Then
                MsgBox("TOUS LES NOUVEAUX ONT EU UN PARRAIN")
            End If

            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try

    End Sub

    Private Sub PARRAIN_TXT_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListV.SelectedIndexChanged
        For Each element As ListViewItem In ListV.Items
            If element.Selected = True Then
                RECHERCHE.Enabled = True
                RECHERCHE.Visible = True

                If ENREGISTRER_TXT.Visible = True Then
                    RECHERCHE.Visible = True
                    ENREGISTRER_TXT.Visible = False
                    PARRAIN_TXT.Visible = False
                    CEL_LBL.Visible = False
                    NUMERO_LBL.Visible = False
                End If


                Try
                    CN.Open()
                    cmd1.Connection = CN
                    cmd1.CommandText = "select * from etudiant WHERE telephone_et='" & element.SubItems(2).Text & "'"
                    dr = cmd1.ExecuteReader

                    While dr.Read
                        NCE = dr.GetValue(0)
                    End While
                    CN.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                    CN.Close()

                End Try
                ' NCE = element.SubItems(2).Text
                ' PARRAIN_TXT.Visible = True
            End If
        Next
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RECHERCHE.Click


        Try
         

            If NCE = "vide" Then
                MsgBox("VEILLEZ SELECTIONNEZ UN ETUDIANT ")
            ElseIf NCE <> "VIDE" Then

                If SPECIALITE_BOX.SelectedItem = "PHYSIQUE CHIMIE" Then
                    Try

                        RECHERCHE.Enabled = False
                        ProgressBar1.Visible = True
                        Timer1.Start()


                        ' PARRAIN_TXT.Visible = True
                        CN.Open()
                        cmd1.Connection = CN
                        cmd1.CommandText = "select * from parrain WHERE parrain_ok='NON' AND (filiere_par='CHIMIE' OR filiere_par='PHYSIQUE' OR filiere_par='PHYSIQUE CHIMIE')"

                        dr = cmd1.ExecuteReader
                        compt = 0
                        While dr.Read
                            compt = compt + 1
                        End While
                        CN.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message)
                        CN.Close()

                    End Try

                    If compt = 0 Then
                        MsgBox("TOUS LES PARRAINS ONT EU UN NOUVEAU ETUDIANT ")
                    Else


                        Dim tab(compt) As String
                        Try
                            CN.Open()
                            cmd1.Connection = CN
                            cmd1.CommandText = "select * from parrain WHERE parrain_ok='NON' AND (filiere_par='CHIMIE' OR filiere_par='PHYSIQUE' OR filiere_par='PHYSIQUE CHIMIE')"
                            dr = cmd1.ExecuteReader
                            Dim i As Integer = 0
                            While dr.Read
                                tab(i) = dr.GetValue(0)
                                i = i + 1
                            End While

                            CN.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                            CN.Close()
                        End Try


                        'On déclare une variable Classe Random() et une variable Int
                        Dim random As New Random()
                        nbre = random.Next(0, compt)
                        '.Next permet de retourner un nombre aléatoire contenu dans la plage spécifiée entre parenthèses.
                        ' PARRAIN_TXT.Text = "LE NUMERO CHOISI EST " & tab(nbre)
                        NCE_PAR = tab(nbre)


                        Try
                            ' PARRAIN_TXT.Visible = True
                            CN.Open()
                            cmd1.Connection = CN
                            cmd1.CommandText = "select * from parrain WHERE nce_par='" & NCE_PAR & "'"
                            dr = cmd1.ExecuteReader
                            compt = 0
                            While dr.Read
                                PARRAIN_TXT.Text = dr.GetValue(1) & " " & dr.GetValue(2)
                                NUMERO_LBL.Text = dr.GetValue(5)
                            End While
                            ENREGISTRER_TXT.Visible = True
                            RECHERCHE.Visible = False
                            CN.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                            CN.Close()

                        End Try



                        ANNEE = Year(Now())
                        an2 = Int(ANNEE)
                        an1 = an2 - 1
                        ANNEE = an1.ToString & "-" & an2.ToString

                    End If








                    'SI FILIERE <> DE "PHYSIQUE CHIMIE"
                Else
                    Try

                        RECHERCHE.Enabled = False
                        ProgressBar1.Visible = True
                        Timer1.Start()


                        ' PARRAIN_TXT.Visible = True
                        CN.Open()
                        cmd1.Connection = CN
                        cmd1.CommandText = "select * from parrain WHERE parrain_ok='NON' AND (filiere_par<>'CHIMIE' AND filiere_par<>'PHYSIQUE' AND filiere_par<>'PHYSIQUE CHIMIE')"

                        dr = cmd1.ExecuteReader
                        compt = 0
                        While dr.Read
                            compt = compt + 1
                        End While
                        CN.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message)
                        CN.Close()

                    End Try

                    If compt = 0 Then
                        MsgBox("TOUS LES PARRAINS ONT EU UN NOUVEAU ETUDIANT ")
                    Else


                        Dim tab(compt) As String
                        Try
                            CN.Open()
                            cmd1.Connection = CN
                            cmd1.CommandText = "select * from parrain WHERE parrain_ok='NON' AND (filiere_par<>'CHIMIE' AND filiere_par<>'PHYSIQUE' AND filiere_par<>'PHYSIQUE CHIMIE')"
                            dr = cmd1.ExecuteReader
                            Dim i As Integer = 0
                            While dr.Read
                                tab(i) = dr.GetValue(0)
                                i = i + 1
                            End While

                            CN.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                            CN.Close()
                        End Try


                        'On déclare une variable Classe Random() et une variable Int
                        Dim random As New Random()
                        nbre = random.Next(0, compt)
                        '.Next permet de retourner un nombre aléatoire contenu dans la plage spécifiée entre parenthèses.
                        ' PARRAIN_TXT.Text = "LE NUMERO CHOISI EST " & tab(nbre)
                        NCE_PAR = tab(nbre)


                        Try
                            ' PARRAIN_TXT.Visible = True
                            CN.Open()
                            cmd1.Connection = CN
                            cmd1.CommandText = "select * from parrain WHERE nce_par='" & NCE_PAR & "'"
                            dr = cmd1.ExecuteReader
                            compt = 0
                            While dr.Read
                                PARRAIN_TXT.Text = dr.GetValue(1) & " " & dr.GetValue(2)
                                NUMERO_LBL.Text = dr.GetValue(5)
                            End While
                            ENREGISTRER_TXT.Visible = True
                            RECHERCHE.Visible = False
                            CN.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                            CN.Close()

                        End Try



                        ANNEE = Year(Now())
                        an2 = Int(ANNEE)
                        an1 = an2 - 1
                        ANNEE = an1.ToString & "-" & an2.ToString
                    End If


            End If



            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub ENREGISTRER_TXT_Click(sender As Object, e As EventArgs) Handles ENREGISTRER_TXT.Click
        Try
            CN.Open()
            cmd1.Connection = CN
            cmd1.CommandText = "INSERT INTO attribuer(nce_et,nce_par,annee) VALUE ('" & NCE & "','" & NCE_PAR & "','" & ANNEE & "')"
            dr = cmd1.ExecuteReader
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()
        End Try




        Try
            CN.Open()
            cmd1.Connection = CN
            cmd1.CommandText = "UPDATE parrain SET parrain_ok='OUI' WHERE nce_par='" & NCE_PAR & "'"
            dr = cmd1.ExecuteReader
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()
        End Try



        Try
            CN.Open()
            cmd1.Connection = CN
            cmd1.CommandText = "UPDATE etudiant  SET parrainer='OUI' WHERE nce_et='" & NCE & "'"
            dr = cmd1.ExecuteReader
            CN.Close()
            NCE = "vide"
        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()
        End Try

        MsgBox("PARRAINNAGE EFFECTUER AVEC SUCCES !!!")
        ENREGISTRER_TXT.Visible = False
        RECHERCHE.Enabled = True
        RECHERCHE.Visible = True
        PARRAIN_TXT.Visible = False



        PARRAIN_TXT.Visible = False
        NUMERO_LBL.Visible = False
        CEL_LBL.Visible = False
        ProgressBar1.Visible = False
        ENREGISTRER_TXT.Visible = False

        titre_tab.Text = "LES ETUDIANTS EN " & SPECIALITE_BOX.SelectedItem
        ListV.Items.Clear()
        ListV.CheckBoxes = True
        ListV.FullRowSelect = True
        compt = 0
        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT *FROM etudiant WHERE filiere_et='" & SPECIALITE_BOX.SelectedItem & "' AND parrainer='NON' "
            dr = cmd.ExecuteReader


            ListV.View = View.Details
            ' ListV.BackColor = Color.AliceBlue
            ListV.Alignment = ListViewAlignment.SnapToGrid
            ListV.Columns.Add(" NOM", 150, HorizontalAlignment.Left)
            ListV.Columns.Add("PRENOM", 200, HorizontalAlignment.Left)
            ListV.Columns.Add(" TELEPHONE ", 180, HorizontalAlignment.Left)

            While dr.Read
                Dim liv As New ListViewItem
                liv.Text = "     " & dr.GetString("nom_et")
                ' liv.Checked = False
                liv.SubItems.Add(dr.GetString("prenom_et"))
                liv.SubItems.Add(dr.GetString("telephone_et"))
                ListV.Items.Add(liv)
                compt = compt + 1

            End While

            If compt = 0 Then
                MsgBox("TOUS LES NOUVEAU ONTX EU UN PARRAIN ")
            End If

            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Visible = False
            PARRAIN_TXT.Visible = True
            ENREGISTRER_TXT.Visible = True
            CEL_LBL.Visible = True
            NUMERO_LBL.Visible = True
            Timer1.Stop()
            ProgressBar1.Value = 0

        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
            PARRAIN_TXT.Visible = False
            ENREGISTRER_TXT.Visible = False
            CEL_LBL.Visible = False
            NUMERO_LBL.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ACCUEIL.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()

    End Sub
End Class