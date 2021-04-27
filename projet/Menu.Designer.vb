<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrix_pnlList = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pctList_pnlList = New System.Windows.Forms.PictureBox()
        Me.txtType_pnlList = New System.Windows.Forms.TextBox()
        Me.txtNom_pnlList = New System.Windows.Forms.TextBox()
        Me.txtID_pnlList = New System.Windows.Forms.TextBox()
        Me.LBox_pnlList = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctList_pnlList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SeaGreen
        Me.GroupBox1.Controls.Add(Me.txtPrix_pnlList)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.pctList_pnlList)
        Me.GroupBox1.Controls.Add(Me.txtType_pnlList)
        Me.GroupBox1.Controls.Add(Me.txtNom_pnlList)
        Me.GroupBox1.Controls.Add(Me.txtID_pnlList)
        Me.GroupBox1.Controls.Add(Me.LBox_pnlList)
        Me.GroupBox1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(888, 573)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'txtPrix_pnlList
        '
        Me.txtPrix_pnlList.Location = New System.Drawing.Point(393, 278)
        Me.txtPrix_pnlList.Name = "txtPrix_pnlList"
        Me.txtPrix_pnlList.Size = New System.Drawing.Size(184, 32)
        Me.txtPrix_pnlList.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Prix:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nom:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID:"
        '
        'pctList_pnlList
        '
        Me.pctList_pnlList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctList_pnlList.Location = New System.Drawing.Point(613, 173)
        Me.pctList_pnlList.Name = "pctList_pnlList"
        Me.pctList_pnlList.Size = New System.Drawing.Size(240, 194)
        Me.pctList_pnlList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctList_pnlList.TabIndex = 6
        Me.pctList_pnlList.TabStop = False
        '
        'txtType_pnlList
        '
        Me.txtType_pnlList.Location = New System.Drawing.Point(393, 319)
        Me.txtType_pnlList.Name = "txtType_pnlList"
        Me.txtType_pnlList.Size = New System.Drawing.Size(184, 32)
        Me.txtType_pnlList.TabIndex = 4
        '
        'txtNom_pnlList
        '
        Me.txtNom_pnlList.Location = New System.Drawing.Point(393, 233)
        Me.txtNom_pnlList.Name = "txtNom_pnlList"
        Me.txtNom_pnlList.Size = New System.Drawing.Size(184, 32)
        Me.txtNom_pnlList.TabIndex = 2
        '
        'txtID_pnlList
        '
        Me.txtID_pnlList.Location = New System.Drawing.Point(393, 190)
        Me.txtID_pnlList.Name = "txtID_pnlList"
        Me.txtID_pnlList.Size = New System.Drawing.Size(184, 32)
        Me.txtID_pnlList.TabIndex = 1
        '
        'LBox_pnlList
        '
        Me.LBox_pnlList.FormattingEnabled = True
        Me.LBox_pnlList.ItemHeight = 24
        Me.LBox_pnlList.Location = New System.Drawing.Point(21, 114)
        Me.LBox_pnlList.Name = "LBox_pnlList"
        Me.LBox_pnlList.Size = New System.Drawing.Size(258, 340)
        Me.LBox_pnlList.TabIndex = 0
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "menu"
        Me.Size = New System.Drawing.Size(888, 573)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctList_pnlList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrix_pnlList As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pctList_pnlList As PictureBox
    Friend WithEvents txtType_pnlList As TextBox
    Friend WithEvents txtNom_pnlList As TextBox
    Friend WithEvents txtID_pnlList As TextBox
    Friend WithEvents LBox_pnlList As ListBox
End Class
