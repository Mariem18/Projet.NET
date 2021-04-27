<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supprimer
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
        Me.pnlSp = New System.Windows.Forms.Panel()
        Me.CoBoxSup_pnlSp = New System.Windows.Forms.ComboBox()
        Me.btnSp_pnlSp = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNm_pnlSp = New System.Windows.Forms.TextBox()
        Me.pnlSp.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSp
        '
        Me.pnlSp.BackColor = System.Drawing.Color.SeaGreen
        Me.pnlSp.Controls.Add(Me.CoBoxSup_pnlSp)
        Me.pnlSp.Controls.Add(Me.btnSp_pnlSp)
        Me.pnlSp.Controls.Add(Me.Label14)
        Me.pnlSp.Controls.Add(Me.Label15)
        Me.pnlSp.Controls.Add(Me.txtNm_pnlSp)
        Me.pnlSp.Location = New System.Drawing.Point(0, 0)
        Me.pnlSp.Name = "pnlSp"
        Me.pnlSp.Size = New System.Drawing.Size(888, 573)
        Me.pnlSp.TabIndex = 53
        '
        'CoBoxSup_pnlSp
        '
        Me.CoBoxSup_pnlSp.FormattingEnabled = True
        Me.CoBoxSup_pnlSp.Items.AddRange(New Object() {"Plat", "Boisson", "Dessert"})
        Me.CoBoxSup_pnlSp.Location = New System.Drawing.Point(362, 220)
        Me.CoBoxSup_pnlSp.Name = "CoBoxSup_pnlSp"
        Me.CoBoxSup_pnlSp.Size = New System.Drawing.Size(243, 24)
        Me.CoBoxSup_pnlSp.TabIndex = 78
        '
        'btnSp_pnlSp
        '
        Me.btnSp_pnlSp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSp_pnlSp.Location = New System.Drawing.Point(264, 328)
        Me.btnSp_pnlSp.Name = "btnSp_pnlSp"
        Me.btnSp_pnlSp.Size = New System.Drawing.Size(359, 51)
        Me.btnSp_pnlSp.TabIndex = 75
        Me.btnSp_pnlSp.Text = "Supprimer"
        Me.btnSp_pnlSp.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(272, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 25)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Type:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(272, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 25)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Nom:"
        '
        'txtNm_pnlSp
        '
        Me.txtNm_pnlSp.Location = New System.Drawing.Point(362, 164)
        Me.txtNm_pnlSp.Name = "txtNm_pnlSp"
        Me.txtNm_pnlSp.Size = New System.Drawing.Size(243, 22)
        Me.txtNm_pnlSp.TabIndex = 66
        '
        'supprimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlSp)
        Me.Name = "supprimer"
        Me.Size = New System.Drawing.Size(888, 573)
        Me.pnlSp.ResumeLayout(False)
        Me.pnlSp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSp As Panel
    Friend WithEvents CoBoxSup_pnlSp As ComboBox
    Friend WithEvents btnSp_pnlSp As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNm_pnlSp As TextBox
End Class
