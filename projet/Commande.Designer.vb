<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class commande
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnCommande = New System.Windows.Forms.Button()
        Me.btnFacture = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GboxDesr_pnlCom = New System.Windows.Forms.GroupBox()
        Me.txtTotalDes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picDesr = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrixDes = New System.Windows.Forms.TextBox()
        Me.CheListDesrt_pnlCom = New System.Windows.Forms.CheckedListBox()
        Me.GboxBois_pnlCom = New System.Windows.Forms.GroupBox()
        Me.txtTotalBois = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picBois = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrixBois = New System.Windows.Forms.TextBox()
        Me.CheListBoi_pnlCom = New System.Windows.Forms.CheckedListBox()
        Me.GboxPlat_pnlCom = New System.Windows.Forms.GroupBox()
        Me.txtTotalPlat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.picPlat = New System.Windows.Forms.PictureBox()
        Me.txtPrixPlat = New System.Windows.Forms.TextBox()
        Me.CheListPlat_pnlCom = New System.Windows.Forms.CheckedListBox()
        Me.Panel3.SuspendLayout()
        Me.GboxDesr_pnlCom.SuspendLayout()
        CType(Me.picDesr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxBois_pnlCom.SuspendLayout()
        CType(Me.picBois, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxPlat_pnlCom.SuspendLayout()
        CType(Me.picPlat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.btnRetour)
        Me.Panel3.Controls.Add(Me.btnCommande)
        Me.Panel3.Controls.Add(Me.btnFacture)
        Me.Panel3.Controls.Add(Me.TextBox7)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.GboxDesr_pnlCom)
        Me.Panel3.Controls.Add(Me.GboxBois_pnlCom)
        Me.Panel3.Controls.Add(Me.GboxPlat_pnlCom)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(995, 739)
        Me.Panel3.TabIndex = 53
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(50, 615)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(183, 42)
        Me.btnRetour.TabIndex = 15
        Me.btnRetour.Text = "Retourner"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'btnCommande
        '
        Me.btnCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommande.Location = New System.Drawing.Point(737, 650)
        Me.btnCommande.Name = "btnCommande"
        Me.btnCommande.Size = New System.Drawing.Size(183, 42)
        Me.btnCommande.TabIndex = 14
        Me.btnCommande.Text = "Commander"
        Me.btnCommande.UseVisualStyleBackColor = True
        '
        'btnFacture
        '
        Me.btnFacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacture.Location = New System.Drawing.Point(390, 615)
        Me.btnFacture.Name = "btnFacture"
        Me.btnFacture.Size = New System.Drawing.Size(170, 42)
        Me.btnFacture.TabIndex = 13
        Me.btnFacture.Text = "La Facture"
        Me.btnFacture.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(737, 582)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(183, 22)
        Me.TextBox7.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Calligraphy", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(628, 582)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 24)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Total:"
        '
        'GboxDesr_pnlCom
        '
        Me.GboxDesr_pnlCom.Controls.Add(Me.txtTotalDes)
        Me.GboxDesr_pnlCom.Controls.Add(Me.Label4)
        Me.GboxDesr_pnlCom.Controls.Add(Me.picDesr)
        Me.GboxDesr_pnlCom.Controls.Add(Me.Label5)
        Me.GboxDesr_pnlCom.Controls.Add(Me.txtPrixDes)
        Me.GboxDesr_pnlCom.Controls.Add(Me.CheListDesrt_pnlCom)
        Me.GboxDesr_pnlCom.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GboxDesr_pnlCom.Location = New System.Drawing.Point(14, 376)
        Me.GboxDesr_pnlCom.Name = "GboxDesr_pnlCom"
        Me.GboxDesr_pnlCom.Size = New System.Drawing.Size(963, 166)
        Me.GboxDesr_pnlCom.TabIndex = 2
        Me.GboxDesr_pnlCom.TabStop = False
        Me.GboxDesr_pnlCom.Text = "Desserts"
        '
        'txtTotalDes
        '
        Me.txtTotalDes.Location = New System.Drawing.Point(723, 94)
        Me.txtTotalDes.Name = "txtTotalDes"
        Me.txtTotalDes.Size = New System.Drawing.Size(183, 28)
        Me.txtTotalDes.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(614, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total:"
        '
        'picDesr
        '
        Me.picDesr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDesr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDesr.Location = New System.Drawing.Point(411, 17)
        Me.picDesr.Name = "picDesr"
        Me.picDesr.Size = New System.Drawing.Size(111, 92)
        Me.picDesr.TabIndex = 8
        Me.picDesr.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(298, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Prix:"
        '
        'txtPrixDes
        '
        Me.txtPrixDes.Location = New System.Drawing.Point(376, 129)
        Me.txtPrixDes.Name = "txtPrixDes"
        Me.txtPrixDes.Size = New System.Drawing.Size(183, 28)
        Me.txtPrixDes.TabIndex = 6
        '
        'CheListDesrt_pnlCom
        '
        Me.CheListDesrt_pnlCom.FormattingEnabled = True
        Me.CheListDesrt_pnlCom.Location = New System.Drawing.Point(13, 28)
        Me.CheListDesrt_pnlCom.Name = "CheListDesrt_pnlCom"
        Me.CheListDesrt_pnlCom.Size = New System.Drawing.Size(279, 119)
        Me.CheListDesrt_pnlCom.TabIndex = 1
        '
        'GboxBois_pnlCom
        '
        Me.GboxBois_pnlCom.Controls.Add(Me.txtTotalBois)
        Me.GboxBois_pnlCom.Controls.Add(Me.Label2)
        Me.GboxBois_pnlCom.Controls.Add(Me.picBois)
        Me.GboxBois_pnlCom.Controls.Add(Me.Label3)
        Me.GboxBois_pnlCom.Controls.Add(Me.txtPrixBois)
        Me.GboxBois_pnlCom.Controls.Add(Me.CheListBoi_pnlCom)
        Me.GboxBois_pnlCom.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GboxBois_pnlCom.Location = New System.Drawing.Point(14, 190)
        Me.GboxBois_pnlCom.Name = "GboxBois_pnlCom"
        Me.GboxBois_pnlCom.Size = New System.Drawing.Size(958, 163)
        Me.GboxBois_pnlCom.TabIndex = 1
        Me.GboxBois_pnlCom.TabStop = False
        Me.GboxBois_pnlCom.Text = "Boissons"
        '
        'txtTotalBois
        '
        Me.txtTotalBois.Location = New System.Drawing.Point(723, 98)
        Me.txtTotalBois.Name = "txtTotalBois"
        Me.txtTotalBois.Size = New System.Drawing.Size(183, 28)
        Me.txtTotalBois.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(614, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Total:"
        '
        'picBois
        '
        Me.picBois.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBois.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBois.Location = New System.Drawing.Point(411, 17)
        Me.picBois.Name = "picBois"
        Me.picBois.Size = New System.Drawing.Size(111, 92)
        Me.picBois.TabIndex = 8
        Me.picBois.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Prix:"
        '
        'txtPrixBois
        '
        Me.txtPrixBois.Location = New System.Drawing.Point(376, 129)
        Me.txtPrixBois.Name = "txtPrixBois"
        Me.txtPrixBois.Size = New System.Drawing.Size(183, 28)
        Me.txtPrixBois.TabIndex = 6
        '
        'CheListBoi_pnlCom
        '
        Me.CheListBoi_pnlCom.FormattingEnabled = True
        Me.CheListBoi_pnlCom.Location = New System.Drawing.Point(13, 21)
        Me.CheListBoi_pnlCom.Name = "CheListBoi_pnlCom"
        Me.CheListBoi_pnlCom.Size = New System.Drawing.Size(279, 119)
        Me.CheListBoi_pnlCom.TabIndex = 1
        '
        'GboxPlat_pnlCom
        '
        Me.GboxPlat_pnlCom.Controls.Add(Me.txtTotalPlat)
        Me.GboxPlat_pnlCom.Controls.Add(Me.Label1)
        Me.GboxPlat_pnlCom.Controls.Add(Me.Label19)
        Me.GboxPlat_pnlCom.Controls.Add(Me.picPlat)
        Me.GboxPlat_pnlCom.Controls.Add(Me.txtPrixPlat)
        Me.GboxPlat_pnlCom.Controls.Add(Me.CheListPlat_pnlCom)
        Me.GboxPlat_pnlCom.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GboxPlat_pnlCom.Location = New System.Drawing.Point(14, 15)
        Me.GboxPlat_pnlCom.Name = "GboxPlat_pnlCom"
        Me.GboxPlat_pnlCom.Size = New System.Drawing.Size(958, 163)
        Me.GboxPlat_pnlCom.TabIndex = 0
        Me.GboxPlat_pnlCom.TabStop = False
        Me.GboxPlat_pnlCom.Text = "Plats"
        '
        'txtTotalPlat
        '
        Me.txtTotalPlat.Location = New System.Drawing.Point(723, 97)
        Me.txtTotalPlat.Name = "txtTotalPlat"
        Me.txtTotalPlat.Size = New System.Drawing.Size(183, 28)
        Me.txtTotalPlat.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(614, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Calligraphy", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(298, 119)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 23)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Prix:"
        '
        'picPlat
        '
        Me.picPlat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPlat.Location = New System.Drawing.Point(411, 22)
        Me.picPlat.Name = "picPlat"
        Me.picPlat.Size = New System.Drawing.Size(111, 92)
        Me.picPlat.TabIndex = 3
        Me.picPlat.TabStop = False
        '
        'txtPrixPlat
        '
        Me.txtPrixPlat.Location = New System.Drawing.Point(376, 120)
        Me.txtPrixPlat.Name = "txtPrixPlat"
        Me.txtPrixPlat.Size = New System.Drawing.Size(183, 28)
        Me.txtPrixPlat.TabIndex = 1
        '
        'CheListPlat_pnlCom
        '
        Me.CheListPlat_pnlCom.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheListPlat_pnlCom.FormattingEnabled = True
        Me.CheListPlat_pnlCom.Location = New System.Drawing.Point(13, 25)
        Me.CheListPlat_pnlCom.Name = "CheListPlat_pnlCom"
        Me.CheListPlat_pnlCom.Size = New System.Drawing.Size(279, 119)
        Me.CheListPlat_pnlCom.TabIndex = 0
        '
        'commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Name = "commande"
        Me.Size = New System.Drawing.Size(995, 739)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GboxDesr_pnlCom.ResumeLayout(False)
        Me.GboxDesr_pnlCom.PerformLayout()
        CType(Me.picDesr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxBois_pnlCom.ResumeLayout(False)
        Me.GboxBois_pnlCom.PerformLayout()
        CType(Me.picBois, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxPlat_pnlCom.ResumeLayout(False)
        Me.GboxPlat_pnlCom.PerformLayout()
        CType(Me.picPlat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents GboxDesr_pnlCom As GroupBox
    Friend WithEvents CheListDesrt_pnlCom As CheckedListBox
    Friend WithEvents GboxBois_pnlCom As GroupBox
    Friend WithEvents CheListBoi_pnlCom As CheckedListBox
    Friend WithEvents GboxPlat_pnlCom As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPrixPlat As TextBox
    Friend WithEvents CheListPlat_pnlCom As CheckedListBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txtTotalDes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents picDesr As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrixDes As TextBox
    Friend WithEvents txtTotalBois As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picBois As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrixBois As TextBox
    Friend WithEvents txtTotalPlat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picPlat As PictureBox
    Friend WithEvents btnCommande As Button
    Friend WithEvents btnFacture As Button
    Friend WithEvents btnRetour As Button
End Class
