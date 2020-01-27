<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ENREGISTREMENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ENREGISTREMENT))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.titre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NOM_TXT = New System.Windows.Forms.TextBox()
        Me.PRENOMS_TXT = New System.Windows.Forms.TextBox()
        Me.NCE_TXT = New System.Windows.Forms.TextBox()
        Me.TEL_TXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MENU1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI = New System.Windows.Forms.ToolStripMenuItem()
        Me.PC = New System.Windows.Forms.ToolStripMenuItem()
        Me.L1_PC = New System.Windows.Forms.ToolStripMenuItem()
        Me.L2_PC = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATHS = New System.Windows.Forms.ToolStripMenuItem()
        Me.L2_MATHS = New System.Windows.Forms.ToolStripMenuItem()
        Me.L3_MATHS = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1_MATHS = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2_MATHS = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.L2_INFO = New System.Windows.Forms.ToolStripMenuItem()
        Me.L3_INFO = New System.Windows.Forms.ToolStripMenuItem()
        Me.GI = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1_GI = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2_GI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIAGE = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1_MIAGE = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2_MIAGE = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHYSIQUE = New System.Windows.Forms.ToolStripMenuItem()
        Me.L3_PH = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1_PH = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2_PH = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHIMIE = New System.Windows.Forms.ToolStripMenuItem()
        Me.L3_CH = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1_CH = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2_CH = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(138, 284)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "NCE"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(114, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "PRENOMS"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(352, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 55)
        Me.Button1.TabIndex = 124
        Me.Button1.Text = "ENREGISTRER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'titre
        '
        Me.titre.AutoSize = True
        Me.titre.BackColor = System.Drawing.Color.Transparent
        Me.titre.Font = New System.Drawing.Font("Ravie", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.ForeColor = System.Drawing.Color.MediumBlue
        Me.titre.Location = New System.Drawing.Point(57, 20)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(826, 48)
        Me.titre.TabIndex = 123
        Me.titre.Text = "ENREGISTRER NOUVEAU ETUDIANT"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(138, 172)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "NOM"
        '
        'NOM_TXT
        '
        Me.NOM_TXT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NOM_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOM_TXT.Location = New System.Drawing.Point(250, 169)
        Me.NOM_TXT.Multiline = True
        Me.NOM_TXT.Name = "NOM_TXT"
        Me.NOM_TXT.Size = New System.Drawing.Size(415, 33)
        Me.NOM_TXT.TabIndex = 134
        '
        'PRENOMS_TXT
        '
        Me.PRENOMS_TXT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PRENOMS_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRENOMS_TXT.Location = New System.Drawing.Point(250, 228)
        Me.PRENOMS_TXT.Multiline = True
        Me.PRENOMS_TXT.Name = "PRENOMS_TXT"
        Me.PRENOMS_TXT.Size = New System.Drawing.Size(582, 33)
        Me.PRENOMS_TXT.TabIndex = 135
        '
        'NCE_TXT
        '
        Me.NCE_TXT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NCE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NCE_TXT.Location = New System.Drawing.Point(252, 284)
        Me.NCE_TXT.Multiline = True
        Me.NCE_TXT.Name = "NCE_TXT"
        Me.NCE_TXT.Size = New System.Drawing.Size(425, 33)
        Me.NCE_TXT.TabIndex = 136
        '
        'TEL_TXT
        '
        Me.TEL_TXT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEL_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEL_TXT.Location = New System.Drawing.Point(251, 334)
        Me.TEL_TXT.Multiline = True
        Me.TEL_TXT.Name = "TEL_TXT"
        Me.TEL_TXT.Size = New System.Drawing.Size(425, 33)
        Me.TEL_TXT.TabIndex = 139
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(102, 334)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 24)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "TELEPHONE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 440)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 126
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(877, 440)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 46)
        Me.Button2.TabIndex = 125
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENU1})
        Me.MenuStrip2.Location = New System.Drawing.Point(252, 105)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(334, 38)
        Me.MenuStrip2.TabIndex = 140
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MENU1
        '
        Me.MENU1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MENU1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI, Me.PC, Me.MATHS, Me.INFOS, Me.GI, Me.MIAGE, Me.PHYSIQUE, Me.CHIMIE})
        Me.MENU1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENU1.Name = "MENU1"
        Me.MENU1.Size = New System.Drawing.Size(234, 34)
        Me.MENU1.Text = "FILIERE D' ETUDAINT"
        '
        'MI
        '
        Me.MI.Name = "MI"
        Me.MI.Size = New System.Drawing.Size(269, 34)
        Me.MI.Text = "MATHS INFO"
        '
        'PC
        '
        Me.PC.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L1_PC, Me.L2_PC})
        Me.PC.Name = "PC"
        Me.PC.Size = New System.Drawing.Size(269, 34)
        Me.PC.Text = "PHYSIQUE CHIMIE"
        '
        'L1_PC
        '
        Me.L1_PC.Name = "L1_PC"
        Me.L1_PC.Size = New System.Drawing.Size(187, 34)
        Me.L1_PC.Text = "LICENCE 1"
        '
        'L2_PC
        '
        Me.L2_PC.Name = "L2_PC"
        Me.L2_PC.Size = New System.Drawing.Size(187, 34)
        Me.L2_PC.Text = "LICENCE 2"
        '
        'MATHS
        '
        Me.MATHS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L2_MATHS, Me.L3_MATHS, Me.M1_MATHS, Me.M2_MATHS})
        Me.MATHS.Name = "MATHS"
        Me.MATHS.Size = New System.Drawing.Size(269, 34)
        Me.MATHS.Text = "MATHS"
        '
        'L2_MATHS
        '
        Me.L2_MATHS.Name = "L2_MATHS"
        Me.L2_MATHS.Size = New System.Drawing.Size(188, 34)
        Me.L2_MATHS.Text = "LICENCE 2"
        '
        'L3_MATHS
        '
        Me.L3_MATHS.Name = "L3_MATHS"
        Me.L3_MATHS.Size = New System.Drawing.Size(188, 34)
        Me.L3_MATHS.Text = "LICENCE 3"
        '
        'M1_MATHS
        '
        Me.M1_MATHS.Name = "M1_MATHS"
        Me.M1_MATHS.Size = New System.Drawing.Size(188, 34)
        Me.M1_MATHS.Text = "MASTER 1"
        '
        'M2_MATHS
        '
        Me.M2_MATHS.Name = "M2_MATHS"
        Me.M2_MATHS.Size = New System.Drawing.Size(188, 34)
        Me.M2_MATHS.Text = "MASTER 2"
        '
        'INFOS
        '
        Me.INFOS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L2_INFO, Me.L3_INFO})
        Me.INFOS.Name = "INFOS"
        Me.INFOS.Size = New System.Drawing.Size(269, 34)
        Me.INFOS.Text = "INFOS"
        '
        'L2_INFO
        '
        Me.L2_INFO.Name = "L2_INFO"
        Me.L2_INFO.Size = New System.Drawing.Size(187, 34)
        Me.L2_INFO.Text = "LICENCE 2"
        '
        'L3_INFO
        '
        Me.L3_INFO.Name = "L3_INFO"
        Me.L3_INFO.Size = New System.Drawing.Size(187, 34)
        Me.L3_INFO.Text = "LICENCE 3"
        '
        'GI
        '
        Me.GI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M1_GI, Me.M2_GI})
        Me.GI.Name = "GI"
        Me.GI.Size = New System.Drawing.Size(269, 34)
        Me.GI.Text = "GENIE INFO"
        '
        'M1_GI
        '
        Me.M1_GI.Name = "M1_GI"
        Me.M1_GI.Size = New System.Drawing.Size(188, 34)
        Me.M1_GI.Text = "MASTER 1"
        '
        'M2_GI
        '
        Me.M2_GI.Name = "M2_GI"
        Me.M2_GI.Size = New System.Drawing.Size(188, 34)
        Me.M2_GI.Text = "MASTER 2"
        '
        'MIAGE
        '
        Me.MIAGE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M1_MIAGE, Me.M2_MIAGE})
        Me.MIAGE.Name = "MIAGE"
        Me.MIAGE.Size = New System.Drawing.Size(269, 34)
        Me.MIAGE.Text = "MIAGE"
        '
        'M1_MIAGE
        '
        Me.M1_MIAGE.Name = "M1_MIAGE"
        Me.M1_MIAGE.Size = New System.Drawing.Size(188, 34)
        Me.M1_MIAGE.Text = "MASTER 1"
        '
        'M2_MIAGE
        '
        Me.M2_MIAGE.Name = "M2_MIAGE"
        Me.M2_MIAGE.Size = New System.Drawing.Size(188, 34)
        Me.M2_MIAGE.Text = "MASTER 2"
        '
        'PHYSIQUE
        '
        Me.PHYSIQUE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L3_PH, Me.M1_PH, Me.M2_PH})
        Me.PHYSIQUE.Name = "PHYSIQUE"
        Me.PHYSIQUE.Size = New System.Drawing.Size(269, 34)
        Me.PHYSIQUE.Text = "PHYSIQUE"
        '
        'L3_PH
        '
        Me.L3_PH.Name = "L3_PH"
        Me.L3_PH.Size = New System.Drawing.Size(188, 34)
        Me.L3_PH.Text = "LICENCE 3"
        '
        'M1_PH
        '
        Me.M1_PH.Name = "M1_PH"
        Me.M1_PH.Size = New System.Drawing.Size(188, 34)
        Me.M1_PH.Text = "MASTER 1"
        '
        'M2_PH
        '
        Me.M2_PH.Name = "M2_PH"
        Me.M2_PH.Size = New System.Drawing.Size(188, 34)
        Me.M2_PH.Text = "MASTER 2"
        '
        'CHIMIE
        '
        Me.CHIMIE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L3_CH, Me.M1_CH, Me.M2_CH})
        Me.CHIMIE.Name = "CHIMIE"
        Me.CHIMIE.Size = New System.Drawing.Size(269, 34)
        Me.CHIMIE.Text = "CHIMIE"
        '
        'L3_CH
        '
        Me.L3_CH.Name = "L3_CH"
        Me.L3_CH.Size = New System.Drawing.Size(188, 34)
        Me.L3_CH.Text = "LICENCE 3"
        '
        'M1_CH
        '
        Me.M1_CH.Name = "M1_CH"
        Me.M1_CH.Size = New System.Drawing.Size(188, 34)
        Me.M1_CH.Text = "MASTER 1"
        '
        'M2_CH
        '
        Me.M2_CH.Name = "M2_CH"
        Me.M2_CH.Size = New System.Drawing.Size(188, 34)
        Me.M2_CH.Text = "MASTER 2"
        '
        'ENREGISTREMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AEMCI.My.Resources.Resources.FOND2
        Me.ClientSize = New System.Drawing.Size(944, 489)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.TEL_TXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NCE_TXT)
        Me.Controls.Add(Me.PRENOMS_TXT)
        Me.Controls.Add(Me.NOM_TXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.titre)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Location = New System.Drawing.Point(10, 10)
        Me.Name = "ENREGISTREMENT"
        Me.Text = "ENREGISTREMENT"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Protected WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents titre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NOM_TXT As System.Windows.Forms.TextBox
    Friend WithEvents PRENOMS_TXT As System.Windows.Forms.TextBox
    Friend WithEvents NCE_TXT As System.Windows.Forms.TextBox
    Friend WithEvents TEL_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents MENU1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L1_PC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L2_PC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MATHS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L2_MATHS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L3_MATHS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INFOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L2_INFO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L3_INFO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1_GI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2_GI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MIAGE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1_MIAGE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2_MIAGE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PHYSIQUE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L3_PH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1_PH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2_PH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHIMIE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L3_CH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1_CH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2_CH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1_MATHS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2_MATHS As System.Windows.Forms.ToolStripMenuItem
End Class
