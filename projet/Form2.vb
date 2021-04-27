Imports System.Data.SqlClient
Imports System.IO

Public Class Form2

    Private Sub btnDconx_Click(sender As Object, e As EventArgs) Handles btnDconx_pnlMen.Click
        Form1.Show()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Me.Close()

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnMenu_pnlMen.Click

        pnlPosition_pnlMen.Height = btnMenu_pnlMen.Height
        pnlPosition_pnlMen.Top = btnMenu_pnlMen.Top

        Menu2.BringToFront()


        con.Open()

        qry = "select * from elements ORDER BY id"
        cmd = New SqlCommand(qry, con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "elements")

        Menu2.LBox_pnlList.DataSource = ds.Tables("elements")
        Menu2.LBox_pnlList.DisplayMember = "nomElement"

        bs = New BindingSource
        bs.DataSource = ds.Tables("elements")

        Menu2.txtID_pnlList.DataBindings.Clear()
        Menu2.txtID_pnlList.DataBindings.Add("Text", bs, "id")
        Menu2.txtNom_pnlList.DataBindings.Clear()
        Menu2.txtNom_pnlList.DataBindings.Add("Text", bs, "nomElement")
        Menu2.txtPrix_pnlList.DataBindings.Clear()
        Menu2.txtPrix_pnlList.DataBindings.Add("Text", bs, "prix")
        Menu2.txtType_pnlList.DataBindings.Clear()
        Menu2.txtType_pnlList.DataBindings.Add("Text", bs, "type")
        Menu2.pctList_pnlList.DataBindings.Clear()
        Menu2.pctList_pnlList.DataBindings.Add("Image", bs, "image", True)

        Menu2.LBox_pnlList.SelectedIndex = 0


        con.Close()


    End Sub

    Private Sub btnCommande_pnlMen_Click(sender As Object, e As EventArgs) Handles btnCommande_pnlMen.Click


        Form3.Show()
        Me.Hide()


    End Sub

    Private Sub btnAjouter_pnlMen_Click(sender As Object, e As EventArgs) Handles btnAjouter_pnlMen.Click
        pnlPosition_pnlMen.Height = btnAjouter_pnlMen.Height
        pnlPosition_pnlMen.Top = btnAjouter_pnlMen.Top

        Ajouter1.BringToFront()
    End Sub

    Private Sub btnModifier_pnlMen_Click(sender As Object, e As EventArgs) Handles btnModifier_pnlMen.Click
        pnlPosition_pnlMen.Height = btnModifier_pnlMen.Height
        pnlPosition_pnlMen.Top = btnModifier_pnlMen.Top

        Modifier1.BringToFront()
    End Sub

    Private Sub btnSupprimer_pnlMen_Click(sender As Object, e As EventArgs) Handles btnSupprimer_pnlMen.Click

        pnlPosition_pnlMen.Height = btnSupprimer_pnlMen.Height
        pnlPosition_pnlMen.Top = btnSupprimer_pnlMen.Top

        Supprimer1.BringToFront()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu2.BringToFront()

        con.Open()

        qry = "select * from elements ORDER BY id"
        cmd = New SqlCommand(qry, con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "elements")

        Menu2.LBox_pnlList.DataSource = ds.Tables("elements")
        Menu2.LBox_pnlList.DisplayMember = "nomElement"

        bs = New BindingSource
        bs.DataSource = ds.Tables("elements")


        Menu2.txtID_pnlList.DataBindings.Add("Text", bs, "id")
        Menu2.txtNom_pnlList.DataBindings.Add("Text", bs, "nomElement")
        Menu2.txtPrix_pnlList.DataBindings.Add("Text", bs, "prix")
        Menu2.txtType_pnlList.DataBindings.Add("Text", bs, "type")
        Menu2.pctList_pnlList.DataBindings.Add("Image", bs, "image", True)

        Menu2.LBox_pnlList.SelectedIndex = 0


        con.Close()

    End Sub
End Class