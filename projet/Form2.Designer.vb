<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlPosition_pnlMenu = New System.Windows.Forms.Panel()
        Me.btnCommande_pnlMenu = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pct_pnlMenu = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnDeconx_pnlMenu = New System.Windows.Forms.Button()
        Me.btnMenu_pnlMenu = New System.Windows.Forms.Button()
        Me.btnSupprimer_pnlMenu = New System.Windows.Forms.Button()
        Me.btnModifier_pnlMenu = New System.Windows.Forms.Button()
        Me.btnAjouter_pnlMenu = New System.Windows.Forms.Button()
        Me.pnlMen = New System.Windows.Forms.Panel()
        Me.pnlPosition_pnlMen = New System.Windows.Forms.Panel()
        Me.btnDconx_pnlMen = New System.Windows.Forms.Button()
        Me.btnSupprimer_pnlMen = New System.Windows.Forms.Button()
        Me.btnModifier_pnlMen = New System.Windows.Forms.Button()
        Me.btnAjouter_pnlMen = New System.Windows.Forms.Button()
        Me.btnCommande_pnlMen = New System.Windows.Forms.Button()
        Me.btnMenu_pnlMen = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Supprimer1 = New projet.supprimer()
        Me.Modifier1 = New projet.modifier()
        Me.Ajouter1 = New projet.ajouter()
        Me.Menu2 = New projet.menu()
        Me.pnlMenu.SuspendLayout()
        CType(Me.pct_pnlMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMen.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 4
        '
        'pnlMenu
        '
        Me.pnlMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.pnlMenu.BackColor = System.Drawing.Color.Teal
        Me.pnlMenu.Controls.Add(Me.pnlPosition_pnlMenu)
        Me.pnlMenu.Controls.Add(Me.btnCommande_pnlMenu)
        Me.pnlMenu.Controls.Add(Me.Label11)
        Me.pnlMenu.Controls.Add(Me.pct_pnlMenu)
        Me.pnlMenu.Controls.Add(Me.Label12)
        Me.pnlMenu.Controls.Add(Me.btnDeconx_pnlMenu)
        Me.pnlMenu.Controls.Add(Me.btnMenu_pnlMenu)
        Me.pnlMenu.Controls.Add(Me.btnSupprimer_pnlMenu)
        Me.pnlMenu.Controls.Add(Me.btnModifier_pnlMenu)
        Me.pnlMenu.Controls.Add(Me.btnAjouter_pnlMenu)
        Me.pnlMenu.ForeColor = System.Drawing.Color.Snow
        Me.pnlMenu.Location = New System.Drawing.Point(1, -1)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(233, 713)
        Me.pnlMenu.TabIndex = 5
        '
        'pnlPosition_pnlMenu
        '
        Me.pnlPosition_pnlMenu.BackColor = System.Drawing.Color.SaddleBrown
        Me.pnlPosition_pnlMenu.Location = New System.Drawing.Point(0, 144)
        Me.pnlPosition_pnlMenu.Name = "pnlPosition_pnlMenu"
        Me.pnlPosition_pnlMenu.Size = New System.Drawing.Size(23, 51)
        Me.pnlPosition_pnlMenu.TabIndex = 7
        '
        'btnCommande_pnlMenu
        '
        Me.btnCommande_pnlMenu.BackColor = System.Drawing.Color.Teal
        Me.btnCommande_pnlMenu.FlatAppearance.BorderSize = 0
        Me.btnCommande_pnlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommande_pnlMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommande_pnlMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCommande_pnlMenu.Image = Global.projet.My.Resources.Resources.menu
        Me.btnCommande_pnlMenu.Location = New System.Drawing.Point(4, 216)
        Me.btnCommande_pnlMenu.Name = "btnCommande_pnlMenu"
        Me.btnCommande_pnlMenu.Size = New System.Drawing.Size(229, 50)
        Me.btnCommande_pnlMenu.TabIndex = 0
        Me.btnCommande_pnlMenu.Text = "Commande"
        Me.btnCommande_pnlMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCommande_pnlMenu.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Script MT Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(84, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Restaurant"
        '
        'pct_pnlMenu
        '
        Me.pct_pnlMenu.BackgroundImage = Global.projet.My.Resources.Resources.Graphicloads_Colorful_Long_Shadow_Restaurant
        Me.pct_pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pct_pnlMenu.Location = New System.Drawing.Point(3, 26)
        Me.pct_pnlMenu.Name = "pct_pnlMenu"
        Me.pct_pnlMenu.Size = New System.Drawing.Size(78, 69)
        Me.pct_pnlMenu.TabIndex = 0
        Me.pct_pnlMenu.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Script MT Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(87, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 29)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "FAM"
        '
        'btnDeconx_pnlMenu
        '
        Me.btnDeconx_pnlMenu.FlatAppearance.BorderSize = 0
        Me.btnDeconx_pnlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeconx_pnlMenu.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeconx_pnlMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeconx_pnlMenu.Image = Global.projet.My.Resources.Resources.logout__1_
        Me.btnDeconx_pnlMenu.Location = New System.Drawing.Point(0, 505)
        Me.btnDeconx_pnlMenu.Name = "btnDeconx_pnlMenu"
        Me.btnDeconx_pnlMenu.Size = New System.Drawing.Size(233, 50)
        Me.btnDeconx_pnlMenu.TabIndex = 11
        Me.btnDeconx_pnlMenu.Text = " Deconnexion"
        Me.btnDeconx_pnlMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeconx_pnlMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeconx_pnlMenu.UseVisualStyleBackColor = True
        '
        'btnMenu_pnlMenu
        '
        Me.btnMenu_pnlMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu_pnlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu_pnlMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu_pnlMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMenu_pnlMenu.Image = Global.projet.My.Resources.Resources.list
        Me.btnMenu_pnlMenu.Location = New System.Drawing.Point(-2, 144)
        Me.btnMenu_pnlMenu.Name = "btnMenu_pnlMenu"
        Me.btnMenu_pnlMenu.Size = New System.Drawing.Size(229, 51)
        Me.btnMenu_pnlMenu.TabIndex = 4
        Me.btnMenu_pnlMenu.Text = "     Menu"
        Me.btnMenu_pnlMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenu_pnlMenu.UseVisualStyleBackColor = True
        '
        'btnSupprimer_pnlMenu
        '
        Me.btnSupprimer_pnlMenu.FlatAppearance.BorderSize = 0
        Me.btnSupprimer_pnlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimer_pnlMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer_pnlMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSupprimer_pnlMenu.Image = Global.projet.My.Resources.Resources.garbage__2_
        Me.btnSupprimer_pnlMenu.Location = New System.Drawing.Point(-2, 426)
        Me.btnSupprimer_pnlMenu.Name = "btnSupprimer_pnlMenu"
        Me.btnSupprimer_pnlMenu.Size = New System.Drawing.Size(230, 51)
        Me.btnSupprimer_pnlMenu.TabIndex = 3
        Me.btnSupprimer_pnlMenu.Text = "Supprimer"
        Me.btnSupprimer_pnlMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSupprimer_pnlMenu.UseVisualStyleBackColor = True
        '
        'btnModifier_pnlMenu
        '
        Me.btnModifier_pnlMenu.FlatAppearance.BorderSize = 0
        Me.btnModifier_pnlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifier_pnlMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier_pnlMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnModifier_pnlMenu.Image = CType(resources.GetObject("btnModifier_pnlMenu.Image"), System.Drawing.Image)
        Me.btnModifier_pnlMenu.Location = New System.Drawing.Point(-2, 285)
        Me.btnModifier_pnlMenu.Name = "btnModifier_pnlMenu"
        Me.btnModifier_pnlMenu.Size = New System.Drawing.Size(229, 51)
        Me.btnModifier_pnlMenu.TabIndex = 2
        Me.btnModifier_pnlMenu.Text = "   Modifier"
        Me.btnModifier_pnlMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifier_pnlMenu.UseVisualStyleBackColor = True
        '
        'btnAjouter_pnlMenu
        '
        Me.btnAjouter_pnlMenu.FlatAppearance.BorderSize = 0
        Me.btnAjouter_pnlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter_pnlMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter_pnlMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAjouter_pnlMenu.Image = Global.projet.My.Resources.Resources.add
        Me.btnAjouter_pnlMenu.Location = New System.Drawing.Point(-2, 356)
        Me.btnAjouter_pnlMenu.Name = "btnAjouter_pnlMenu"
        Me.btnAjouter_pnlMenu.Size = New System.Drawing.Size(230, 50)
        Me.btnAjouter_pnlMenu.TabIndex = 1
        Me.btnAjouter_pnlMenu.Text = "    Ajouter"
        Me.btnAjouter_pnlMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjouter_pnlMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjouter_pnlMenu.UseVisualStyleBackColor = True
        '
        'pnlMen
        '
        Me.pnlMen.BackColor = System.Drawing.Color.SeaGreen
        Me.pnlMen.Controls.Add(Me.pnlPosition_pnlMen)
        Me.pnlMen.Controls.Add(Me.btnDconx_pnlMen)
        Me.pnlMen.Controls.Add(Me.btnSupprimer_pnlMen)
        Me.pnlMen.Controls.Add(Me.btnModifier_pnlMen)
        Me.pnlMen.Controls.Add(Me.btnAjouter_pnlMen)
        Me.pnlMen.Controls.Add(Me.btnCommande_pnlMen)
        Me.pnlMen.Controls.Add(Me.btnMenu_pnlMen)
        Me.pnlMen.Controls.Add(Me.Label3)
        Me.pnlMen.Controls.Add(Me.Label2)
        Me.pnlMen.Controls.Add(Me.PictureBox1)
        Me.pnlMen.Location = New System.Drawing.Point(0, 0)
        Me.pnlMen.Name = "pnlMen"
        Me.pnlMen.Size = New System.Drawing.Size(231, 734)
        Me.pnlMen.TabIndex = 0
        '
        'pnlPosition_pnlMen
        '
        Me.pnlPosition_pnlMen.BackColor = System.Drawing.Color.Sienna
        Me.pnlPosition_pnlMen.Location = New System.Drawing.Point(0, 186)
        Me.pnlPosition_pnlMen.Name = "pnlPosition_pnlMen"
        Me.pnlPosition_pnlMen.Size = New System.Drawing.Size(20, 45)
        Me.pnlPosition_pnlMen.TabIndex = 1
        '
        'btnDconx_pnlMen
        '
        Me.btnDconx_pnlMen.FlatAppearance.BorderSize = 0
        Me.btnDconx_pnlMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDconx_pnlMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDconx_pnlMen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDconx_pnlMen.Image = CType(resources.GetObject("btnDconx_pnlMen.Image"), System.Drawing.Image)
        Me.btnDconx_pnlMen.Location = New System.Drawing.Point(0, 587)
        Me.btnDconx_pnlMen.Name = "btnDconx_pnlMen"
        Me.btnDconx_pnlMen.Size = New System.Drawing.Size(231, 40)
        Me.btnDconx_pnlMen.TabIndex = 8
        Me.btnDconx_pnlMen.Text = "Deconnexion"
        Me.btnDconx_pnlMen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDconx_pnlMen.UseVisualStyleBackColor = True
        '
        'btnSupprimer_pnlMen
        '
        Me.btnSupprimer_pnlMen.FlatAppearance.BorderSize = 0
        Me.btnSupprimer_pnlMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimer_pnlMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer_pnlMen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSupprimer_pnlMen.Image = CType(resources.GetObject("btnSupprimer_pnlMen.Image"), System.Drawing.Image)
        Me.btnSupprimer_pnlMen.Location = New System.Drawing.Point(0, 426)
        Me.btnSupprimer_pnlMen.Name = "btnSupprimer_pnlMen"
        Me.btnSupprimer_pnlMen.Size = New System.Drawing.Size(231, 45)
        Me.btnSupprimer_pnlMen.TabIndex = 7
        Me.btnSupprimer_pnlMen.Text = " Supprimer"
        Me.btnSupprimer_pnlMen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSupprimer_pnlMen.UseVisualStyleBackColor = True
        '
        'btnModifier_pnlMen
        '
        Me.btnModifier_pnlMen.FlatAppearance.BorderSize = 0
        Me.btnModifier_pnlMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifier_pnlMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier_pnlMen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModifier_pnlMen.Image = CType(resources.GetObject("btnModifier_pnlMen.Image"), System.Drawing.Image)
        Me.btnModifier_pnlMen.Location = New System.Drawing.Point(0, 366)
        Me.btnModifier_pnlMen.Name = "btnModifier_pnlMen"
        Me.btnModifier_pnlMen.Size = New System.Drawing.Size(231, 45)
        Me.btnModifier_pnlMen.TabIndex = 6
        Me.btnModifier_pnlMen.Text = "  Modifier"
        Me.btnModifier_pnlMen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifier_pnlMen.UseVisualStyleBackColor = True
        '
        'btnAjouter_pnlMen
        '
        Me.btnAjouter_pnlMen.FlatAppearance.BorderSize = 0
        Me.btnAjouter_pnlMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter_pnlMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter_pnlMen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAjouter_pnlMen.Image = CType(resources.GetObject("btnAjouter_pnlMen.Image"), System.Drawing.Image)
        Me.btnAjouter_pnlMen.Location = New System.Drawing.Point(0, 306)
        Me.btnAjouter_pnlMen.Name = "btnAjouter_pnlMen"
        Me.btnAjouter_pnlMen.Size = New System.Drawing.Size(231, 45)
        Me.btnAjouter_pnlMen.TabIndex = 5
        Me.btnAjouter_pnlMen.Text = "  Ajouter"
        Me.btnAjouter_pnlMen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjouter_pnlMen.UseVisualStyleBackColor = True
        '
        'btnCommande_pnlMen
        '
        Me.btnCommande_pnlMen.FlatAppearance.BorderSize = 0
        Me.btnCommande_pnlMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommande_pnlMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommande_pnlMen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCommande_pnlMen.Image = CType(resources.GetObject("btnCommande_pnlMen.Image"), System.Drawing.Image)
        Me.btnCommande_pnlMen.Location = New System.Drawing.Point(0, 246)
        Me.btnCommande_pnlMen.Name = "btnCommande_pnlMen"
        Me.btnCommande_pnlMen.Size = New System.Drawing.Size(231, 45)
        Me.btnCommande_pnlMen.TabIndex = 4
        Me.btnCommande_pnlMen.Text = "Commande"
        Me.btnCommande_pnlMen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCommande_pnlMen.UseVisualStyleBackColor = True
        '
        'btnMenu_pnlMen
        '
        Me.btnMenu_pnlMen.FlatAppearance.BorderSize = 0
        Me.btnMenu_pnlMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu_pnlMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu_pnlMen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenu_pnlMen.Image = CType(resources.GetObject("btnMenu_pnlMen.Image"), System.Drawing.Image)
        Me.btnMenu_pnlMen.Location = New System.Drawing.Point(0, 186)
        Me.btnMenu_pnlMen.Name = "btnMenu_pnlMen"
        Me.btnMenu_pnlMen.Size = New System.Drawing.Size(231, 45)
        Me.btnMenu_pnlMen.TabIndex = 3
        Me.btnMenu_pnlMen.Text = "   Menu"
        Me.btnMenu_pnlMen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenu_pnlMen.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(66, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Restaurant"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(78, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FAM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.projet.My.Resources.Resources.Graphicloads_Colorful_Long_Shadow_Restaurant1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(11, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 49)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Supprimer1
        '
        Me.Supprimer1.Location = New System.Drawing.Point(281, 56)
        Me.Supprimer1.Name = "Supprimer1"
        Me.Supprimer1.Size = New System.Drawing.Size(888, 573)
        Me.Supprimer1.TabIndex = 12
        '
        'Modifier1
        '
        Me.Modifier1.Location = New System.Drawing.Point(281, 56)
        Me.Modifier1.Name = "Modifier1"
        Me.Modifier1.Size = New System.Drawing.Size(888, 573)
        Me.Modifier1.TabIndex = 11
        '
        'Ajouter1
        '
        Me.Ajouter1.Location = New System.Drawing.Point(281, 56)
        Me.Ajouter1.Name = "Ajouter1"
        Me.Ajouter1.Size = New System.Drawing.Size(888, 573)
        Me.Ajouter1.TabIndex = 10
        '
        'Menu2
        '
        Me.Menu2.Location = New System.Drawing.Point(281, 56)
        Me.Menu2.Name = "Menu2"
        Me.Menu2.Size = New System.Drawing.Size(887, 570)
        Me.Menu2.TabIndex = 9
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.projet.My.Resources.Resources._72245558_asian_food_served_on_white_wooden_table_top_view_space_for_text_chinese_and_vietnamese_cuisine_set_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1210, 687)
        Me.Controls.Add(Me.Supprimer1)
        Me.Controls.Add(Me.Modifier1)
        Me.Controls.Add(Me.Ajouter1)
        Me.Controls.Add(Me.Menu2)
        Me.Controls.Add(Me.pnlMen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "FAM"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.pct_pnlMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMen.ResumeLayout(False)
        Me.pnlMen.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMenu_pnlMenu As Button
    Friend WithEvents btnSupprimer_pnlMenu As Button
    Friend WithEvents btnModifier_pnlMenu As Button
    Friend WithEvents btnAjouter_pnlMenu As Button
    Friend WithEvents btnCommande_pnlMenu As Button
    Friend WithEvents pnlPosition_pnlMenu As Panel
    Friend WithEvents btnDeconx_pnlMenu As Button
    Friend WithEvents pct_pnlMenu As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents Menu1 As menu
    Friend WithEvents pnlMen As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDconx_pnlMen As Button
    Friend WithEvents btnSupprimer_pnlMen As Button
    Friend WithEvents btnModifier_pnlMen As Button
    Friend WithEvents btnAjouter_pnlMen As Button
    Friend WithEvents btnCommande_pnlMen As Button
    Friend WithEvents btnMenu_pnlMen As Button
    Friend WithEvents pnlPosition_pnlMen As Panel
    Friend WithEvents Menu2 As menu
    Friend WithEvents Ajouter1 As ajouter
    Friend WithEvents Modifier1 As modifier
    Friend WithEvents Supprimer1 As supprimer
End Class
