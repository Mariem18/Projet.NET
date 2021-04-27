<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ajouter
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
        Me.pnlAj = New System.Windows.Forms.Panel()
        Me.CoBoxAj_pnlAj = New System.Windows.Forms.ComboBox()
        Me.btnImporter_pnlAj = New System.Windows.Forms.Button()
        Me.btnAj_pnlAj = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtprix_pnlAj = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pctAj_pnlAj = New System.Windows.Forms.PictureBox()
        Me.txtNm_pnlAj = New System.Windows.Forms.TextBox()
        Me.pnlAj.SuspendLayout()
        CType(Me.pctAj_pnlAj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAj
        '
        Me.pnlAj.BackColor = System.Drawing.Color.SeaGreen
        Me.pnlAj.Controls.Add(Me.CoBoxAj_pnlAj)
        Me.pnlAj.Controls.Add(Me.btnImporter_pnlAj)
        Me.pnlAj.Controls.Add(Me.btnAj_pnlAj)
        Me.pnlAj.Controls.Add(Me.Label10)
        Me.pnlAj.Controls.Add(Me.txtprix_pnlAj)
        Me.pnlAj.Controls.Add(Me.Label6)
        Me.pnlAj.Controls.Add(Me.Label7)
        Me.pnlAj.Controls.Add(Me.Label8)
        Me.pnlAj.Controls.Add(Me.pctAj_pnlAj)
        Me.pnlAj.Controls.Add(Me.txtNm_pnlAj)
        Me.pnlAj.Location = New System.Drawing.Point(0, 0)
        Me.pnlAj.Name = "pnlAj"
        Me.pnlAj.Size = New System.Drawing.Size(888, 573)
        Me.pnlAj.TabIndex = 53
        '
        'CoBoxAj_pnlAj
        '
        Me.CoBoxAj_pnlAj.FormattingEnabled = True
        Me.CoBoxAj_pnlAj.Items.AddRange(New Object() {"Plat", "Boisson", "Dessert"})
        Me.CoBoxAj_pnlAj.Location = New System.Drawing.Point(184, 203)
        Me.CoBoxAj_pnlAj.Name = "CoBoxAj_pnlAj"
        Me.CoBoxAj_pnlAj.Size = New System.Drawing.Size(207, 24)
        Me.CoBoxAj_pnlAj.TabIndex = 78
        '
        'btnImporter_pnlAj
        '
        Me.btnImporter_pnlAj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImporter_pnlAj.Location = New System.Drawing.Point(522, 294)
        Me.btnImporter_pnlAj.Name = "btnImporter_pnlAj"
        Me.btnImporter_pnlAj.Size = New System.Drawing.Size(240, 42)
        Me.btnImporter_pnlAj.TabIndex = 77
        Me.btnImporter_pnlAj.Text = "Importer une photo"
        Me.btnImporter_pnlAj.UseVisualStyleBackColor = True
        '
        'btnAj_pnlAj
        '
        Me.btnAj_pnlAj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAj_pnlAj.Location = New System.Drawing.Point(257, 399)
        Me.btnAj_pnlAj.Name = "btnAj_pnlAj"
        Me.btnAj_pnlAj.Size = New System.Drawing.Size(359, 51)
        Me.btnAj_pnlAj.TabIndex = 75
        Me.btnAj_pnlAj.Text = "Ajouter"
        Me.btnAj_pnlAj.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(425, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 25)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Image:"
        '
        'txtprix_pnlAj
        '
        Me.txtprix_pnlAj.Location = New System.Drawing.Point(184, 164)
        Me.txtprix_pnlAj.Name = "txtprix_pnlAj"
        Me.txtprix_pnlAj.Size = New System.Drawing.Size(207, 22)
        Me.txtprix_pnlAj.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(94, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 25)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Prix:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(94, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 25)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(94, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 25)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Nom:"
        '
        'pctAj_pnlAj
        '
        Me.pctAj_pnlAj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctAj_pnlAj.Location = New System.Drawing.Point(522, 82)
        Me.pctAj_pnlAj.Name = "pctAj_pnlAj"
        Me.pctAj_pnlAj.Size = New System.Drawing.Size(240, 201)
        Me.pctAj_pnlAj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAj_pnlAj.TabIndex = 68
        Me.pctAj_pnlAj.TabStop = False
        '
        'txtNm_pnlAj
        '
        Me.txtNm_pnlAj.Location = New System.Drawing.Point(184, 119)
        Me.txtNm_pnlAj.Name = "txtNm_pnlAj"
        Me.txtNm_pnlAj.Size = New System.Drawing.Size(207, 22)
        Me.txtNm_pnlAj.TabIndex = 66
        '
        'ajouter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlAj)
        Me.Name = "ajouter"
        Me.Size = New System.Drawing.Size(888, 573)
        Me.pnlAj.ResumeLayout(False)
        Me.pnlAj.PerformLayout()
        CType(Me.pctAj_pnlAj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAj As Panel
    Friend WithEvents CoBoxAj_pnlAj As ComboBox
    Friend WithEvents btnImporter_pnlAj As Button
    Friend WithEvents btnAj_pnlAj As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtprix_pnlAj As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pctAj_pnlAj As PictureBox
    Friend WithEvents txtNm_pnlAj As TextBox
End Class
