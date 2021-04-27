Imports System.Data.SqlClient
Imports System.IO

Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Commande1.picPlat.SizeMode = PictureBoxSizeMode.StretchImage
        Commande1.picBois.SizeMode = PictureBoxSizeMode.StretchImage
        Commande1.picDesr.SizeMode = PictureBoxSizeMode.StretchImage

        con.Open()


        qry = "select * from elements where type='plat'"
        cmd = New SqlCommand(qry, con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "elements")


        Commande1.CheListPlat_pnlCom.DataSource = ds.Tables("elements")
        Commande1.CheListPlat_pnlCom.DisplayMember = "nomElement"


        bs = New BindingSource
        bs.DataSource = ds.Tables("elements")


        Commande1.txtPrixPlat.DataBindings.Add("Text", bs, "prix")
        Commande1.picPlat.DataBindings.Add("Image", bs, "image", True)



        qry = "select * from elements where type='boisson'"
        cmd = New SqlCommand(qry, con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "elements")

        Commande1.CheListBoi_pnlCom.DataSource = ds.Tables("elements")
        Commande1.CheListBoi_pnlCom.DisplayMember = "nomElement"

        bs1 = New BindingSource
        bs1.DataSource = ds.Tables("elements")

        Commande1.txtPrixBois.DataBindings.Add("Text", bs1, "prix")
        Commande1.picBois.DataBindings.Add("Image", bs1, "image", True)



        qry = "select * from elements where type='dessert'"
        cmd = New SqlCommand(qry, con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "elements")

        Commande1.CheListDesrt_pnlCom.DataSource = ds.Tables("elements")
        Commande1.CheListDesrt_pnlCom.DisplayMember = "nomElement"

        bs2 = New BindingSource
        bs2.DataSource = ds.Tables("elements")


        Commande1.txtPrixDes.DataBindings.Add("Text", bs2, "prix")
        Commande1.picDesr.DataBindings.Add("Image", bs2, "image", True)





        con.Close()

    End Sub
End Class