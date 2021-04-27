<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifier
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.pnlMd = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtId_pnlMd = New System.Windows.Forms.TextBox()
        Me.CoBoxType_pnlMd = New System.Windows.Forms.ComboBox()
        Me.btnImp_pnlMd = New System.Windows.Forms.Button()
        Me.btnMod_pnlMd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprix_pnlMd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pctMod_pnlMd = New System.Windows.Forms.PictureBox()
        Me.txtNom_pnlMd = New System.Windows.Forms.TextBox()
        Me.pnlMd.SuspendLayout()
        CType(Me.pctMod_pnlMd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMd
        '
        Me.pnlMd.BackColor = System.Drawing.Color.SeaGreen
        Me.pnlMd.Controls.Add(Me.Label18)
        Me.pnlMd.Controls.Add(Me.txtId_pnlMd)
        Me.pnlMd.Controls.Add(Me.CoBoxType_pnlMd)
        Me.pnlMd.Controls.Add(Me.btnImp_pnlMd)
        Me.pnlMd.Controls.Add(Me.btnMod_pnlMd)
        Me.pnlMd.Controls.Add(Me.Label9)
        Me.pnlMd.Controls.Add(Me.txtprix_pnlMd)
        Me.pnlMd.Controls.Add(Me.Label13)
        Me.pnlMd.Controls.Add(Me.Label16)
        Me.pnlMd.Controls.Add(Me.Label17)
        Me.pnlMd.Controls.Add(Me.pctMod_pnlMd)
        Me.pnlMd.Controls.Add(Me.txtNom_pnlMd)
        Me.pnlMd.Location = New System.Drawing.Point(0, 0)
        Me.pnlMd.Name = "pnlMd"
        Me.pnlMd.Size = New System.Drawing.Size(888, 573)
        Me.pnlMd.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(103, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 25)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "ID:"
        '
        'txtId_pnlMd
        '
        Me.txtId_pnlMd.Location = New System.Drawing.Point(270, 122)
        Me.txtId_pnlMd.Name = "txtId_pnlMd"
        Me.txtId_pnlMd.Size = New System.Drawing.Size(207, 22)
        Me.txtId_pnlMd.TabIndex = 79
        '
        'CoBoxType_pnlMd
        '
        Me.CoBoxType_pnlMd.FormattingEnabled = True
        Me.CoBoxType_pnlMd.Items.AddRange(New Object() {"Plat", "Boisson", "Dessert"})
        Me.CoBoxType_pnlMd.Location = New System.Drawing.Point(270, 248)
        Me.CoBoxType_pnlMd.Name = "CoBoxType_pnlMd"
        Me.CoBoxType_pnlMd.Size = New System.Drawing.Size(207, 24)
        Me.CoBoxType_pnlMd.TabIndex = 78
        '
        'btnImp_pnlMd
        '
        Me.btnImp_pnlMd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImp_pnlMd.Location = New System.Drawing.Point(554, 324)
        Me.btnImp_pnlMd.Name = "btnImp_pnlMd"
        Me.btnImp_pnlMd.Size = New System.Drawing.Size(240, 42)
        Me.btnImp_pnlMd.TabIndex = 77
        Me.btnImp_pnlMd.Text = "Importer une photo"
        Me.btnImp_pnlMd.UseVisualStyleBackColor = True
        '
        'btnMod_pnlMd
        '
        Me.btnMod_pnlMd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod_pnlMd.Location = New System.Drawing.Point(118, 435)
        Me.btnMod_pnlMd.Name = "btnMod_pnlMd"
        Me.btnMod_pnlMd.Size = New System.Drawing.Size(359, 51)
        Me.btnMod_pnlMd.TabIndex = 75
        Me.btnMod_pnlMd.Text = "Modifier"
        Me.btnMod_pnlMd.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(549, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 25)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "nouvelle image:"
        '
        'txtprix_pnlMd
        '
        Me.txtprix_pnlMd.Location = New System.Drawing.Point(270, 209)
        Me.txtprix_pnlMd.Name = "txtprix_pnlMd"
        Me.txtprix_pnlMd.Size = New System.Drawing.Size(207, 22)
        Me.txtprix_pnlMd.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(103, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 25)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Nouveau prix:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(103, 244)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 25)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Nouveau type:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(103, 161)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(152, 25)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Nouveau nom:"
        '
        'pctMod_pnlMd
        '
        Me.pctMod_pnlMd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctMod_pnlMd.Location = New System.Drawing.Point(554, 108)
        Me.pctMod_pnlMd.Name = "pctMod_pnlMd"
        Me.pctMod_pnlMd.Size = New System.Drawing.Size(240, 201)
        Me.pctMod_pnlMd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMod_pnlMd.TabIndex = 68
        Me.pctMod_pnlMd.TabStop = False
        '
        'txtNom_pnlMd
        '
        Me.txtNom_pnlMd.Location = New System.Drawing.Point(270, 165)
        Me.txtNom_pnlMd.Name = "txtNom_pnlMd"
        Me.txtNom_pnlMd.Size = New System.Drawing.Size(207, 22)
        Me.txtNom_pnlMd.TabIndex = 66
        '
        'modifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlMd)
        Me.Name = "modifier"
        Me.Size = New System.Drawing.Size(888, 573)
        Me.pnlMd.ResumeLayout(False)
        Me.pnlMd.PerformLayout()
        CType(Me.pctMod_pnlMd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMd As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents txtId_pnlMd As TextBox
    Friend WithEvents CoBoxType_pnlMd As ComboBox
    Friend WithEvents btnImp_pnlMd As Button
    Friend WithEvents btnMod_pnlMd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtprix_pnlMd As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents pctMod_pnlMd As PictureBox
    Friend WithEvents txtNom_pnlMd As TextBox
End Class
