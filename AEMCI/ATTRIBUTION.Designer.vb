<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ATTRIBUTION
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ATTRIBUTION))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.titre_tab = New System.Windows.Forms.Label()
        Me.SPECIALITE_BOX = New System.Windows.Forms.ComboBox()
        Me.RECHERCHE = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ENREGISTRER_TXT = New System.Windows.Forms.Button()
        Me.PARRAIN_TXT = New System.Windows.Forms.Label()
        Me.NUMERO_LBL = New System.Windows.Forms.Label()
        Me.CEL_LBL = New System.Windows.Forms.Label()
        Me.ListV = New System.Windows.Forms.ListView()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.AliceBlue
        Me.Label6.Font = New System.Drawing.Font("Ravie", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(80, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(925, 39)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "ATTRIBUTION  PARRAIN-NOUVEAU ETUDIANT "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(389, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "SPECIALITE"
        Me.Label1.UseWaitCursor = True
        '
        'titre_tab
        '
        Me.titre_tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titre_tab.AutoSize = True
        Me.titre_tab.BackColor = System.Drawing.Color.Transparent
        Me.titre_tab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre_tab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.titre_tab.Location = New System.Drawing.Point(33, 119)
        Me.titre_tab.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.titre_tab.Name = "titre_tab"
        Me.titre_tab.Size = New System.Drawing.Size(160, 24)
        Me.titre_tab.TabIndex = 129
        Me.titre_tab.Text = "                         "
        '
        'SPECIALITE_BOX
        '
        Me.SPECIALITE_BOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SPECIALITE_BOX.FormattingEnabled = True
        Me.SPECIALITE_BOX.Items.AddRange(New Object() {"MATHS INFO", "PHYSIQUE CHIMIE"})
        Me.SPECIALITE_BOX.Location = New System.Drawing.Point(536, 81)
        Me.SPECIALITE_BOX.Name = "SPECIALITE_BOX"
        Me.SPECIALITE_BOX.Size = New System.Drawing.Size(238, 28)
        Me.SPECIALITE_BOX.TabIndex = 130
        '
        'RECHERCHE
        '
        Me.RECHERCHE.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.RECHERCHE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RECHERCHE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RECHERCHE.ForeColor = System.Drawing.Color.Black
        Me.RECHERCHE.Location = New System.Drawing.Point(759, 353)
        Me.RECHERCHE.Name = "RECHERCHE"
        Me.RECHERCHE.Size = New System.Drawing.Size(203, 59)
        Me.RECHERCHE.TabIndex = 132
        Me.RECHERCHE.Text = "RECHERCHE PARRAIN"
        Me.RECHERCHE.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ProgressBar1.Location = New System.Drawing.Point(636, 198)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(374, 28)
        Me.ProgressBar1.TabIndex = 133
        '
        'Timer1
        '
        '
        'ENREGISTRER_TXT
        '
        Me.ENREGISTRER_TXT.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.ENREGISTRER_TXT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ENREGISTRER_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENREGISTRER_TXT.ForeColor = System.Drawing.Color.Black
        Me.ENREGISTRER_TXT.Location = New System.Drawing.Point(791, 353)
        Me.ENREGISTRER_TXT.Name = "ENREGISTRER_TXT"
        Me.ENREGISTRER_TXT.Size = New System.Drawing.Size(194, 58)
        Me.ENREGISTRER_TXT.TabIndex = 134
        Me.ENREGISTRER_TXT.Text = "ENREGISTRER"
        Me.ENREGISTRER_TXT.UseVisualStyleBackColor = False
        '
        'PARRAIN_TXT
        '
        Me.PARRAIN_TXT.AutoSize = True
        Me.PARRAIN_TXT.BackColor = System.Drawing.Color.Transparent
        Me.PARRAIN_TXT.Font = New System.Drawing.Font("Algerian", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PARRAIN_TXT.ForeColor = System.Drawing.Color.Blue
        Me.PARRAIN_TXT.Location = New System.Drawing.Point(565, 187)
        Me.PARRAIN_TXT.Name = "PARRAIN_TXT"
        Me.PARRAIN_TXT.Size = New System.Drawing.Size(209, 49)
        Me.PARRAIN_TXT.TabIndex = 135
        Me.PARRAIN_TXT.Text = "                 "
        '
        'NUMERO_LBL
        '
        Me.NUMERO_LBL.AutoSize = True
        Me.NUMERO_LBL.BackColor = System.Drawing.Color.Transparent
        Me.NUMERO_LBL.Font = New System.Drawing.Font("Algerian", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUMERO_LBL.ForeColor = System.Drawing.Color.Red
        Me.NUMERO_LBL.Location = New System.Drawing.Point(679, 257)
        Me.NUMERO_LBL.Name = "NUMERO_LBL"
        Me.NUMERO_LBL.Size = New System.Drawing.Size(170, 39)
        Me.NUMERO_LBL.TabIndex = 136
        Me.NUMERO_LBL.Text = "                 "
        '
        'CEL_LBL
        '
        Me.CEL_LBL.AutoSize = True
        Me.CEL_LBL.BackColor = System.Drawing.Color.Transparent
        Me.CEL_LBL.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEL_LBL.ForeColor = System.Drawing.Color.Black
        Me.CEL_LBL.Location = New System.Drawing.Point(578, 257)
        Me.CEL_LBL.Name = "CEL_LBL"
        Me.CEL_LBL.Size = New System.Drawing.Size(91, 32)
        Me.CEL_LBL.TabIndex = 137
        Me.CEL_LBL.Text = "CEL : "
        '
        'ListV
        '
        Me.ListV.BackColor = System.Drawing.Color.AliceBlue
        Me.ListV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListV.Location = New System.Drawing.Point(21, 170)
        Me.ListV.Name = "ListV"
        Me.ListV.Size = New System.Drawing.Size(518, 468)
        Me.ListV.TabIndex = 84
        Me.ListV.UseCompatibleStateImageBehavior = False
        '
        'Timer2
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 654)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 139
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(1061, 650)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 46)
        Me.Button2.TabIndex = 138
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ATTRIBUTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.BackgroundImage = Global.AEMCI.My.Resources.Resources.FOND2
        Me.ClientSize = New System.Drawing.Size(1185, 697)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CEL_LBL)
        Me.Controls.Add(Me.NUMERO_LBL)
        Me.Controls.Add(Me.PARRAIN_TXT)
        Me.Controls.Add(Me.ENREGISTRER_TXT)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.RECHERCHE)
        Me.Controls.Add(Me.SPECIALITE_BOX)
        Me.Controls.Add(Me.titre_tab)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListV)
        Me.Controls.Add(Me.Label6)
        Me.Name = "ATTRIBUTION"
        Me.Text = "ATTRIBUTION"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListV As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents titre_tab As System.Windows.Forms.Label
    Friend WithEvents SPECIALITE_BOX As System.Windows.Forms.ComboBox
    Protected WithEvents RECHERCHE As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Protected WithEvents ENREGISTRER_TXT As System.Windows.Forms.Button
    Friend WithEvents PARRAIN_TXT As System.Windows.Forms.Label
    Friend WithEvents NUMERO_LBL As System.Windows.Forms.Label
    Friend WithEvents CEL_LBL As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
