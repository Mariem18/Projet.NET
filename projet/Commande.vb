

Public Class commande


    Dim b As Integer
    Dim a As Integer


    Private Sub CheListPlat_pnlCom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheListPlat_pnlCom.SelectedIndexChanged


        If Not IsNothing(bs) Then
            bs.Position = CheListPlat_pnlCom.SelectedIndex
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Form3.Close()
        Form2.Show()

    End Sub


    Private Sub CheListBoi_pnlCom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheListBoi_pnlCom.SelectedIndexChanged

        If Not IsNothing(bs1) Then
            bs1.Position = CheListBoi_pnlCom.SelectedIndex
        End If

    End Sub

    Private Sub CheListDesrt_pnlCom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheListDesrt_pnlCom.SelectedIndexChanged

        If Not IsNothing(bs2) Then
            bs2.Position = CheListDesrt_pnlCom.SelectedIndex
        End If

    End Sub

    Private Sub CheListPlat_pnlCom_SelectedValueChanged(sender As Object, e As EventArgs) Handles CheListPlat_pnlCom.SelectedValueChanged


    End Sub

    Private Sub CheListBoi_pnlCom_SelectedValueChanged(sender As Object, e As EventArgs) Handles CheListBoi_pnlCom.SelectedValueChanged
        txtTotalBois.Text = txtPrixBois.Text
    End Sub

    Private Sub CheListDesrt_pnlCom_SelectedValueChanged(sender As Object, e As EventArgs) Handles CheListDesrt_pnlCom.SelectedValueChanged

        txtTotalDes.Text = txtPrixDes.Text

    End Sub

    Private Sub CheListPlat_pnlCom_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheListPlat_pnlCom.ItemCheck

        a = Integer.Parse(txtPrixPlat.Text)
        b = b + a
        txtTotalPlat.Text = ToString(b)



    End Sub

    Private Sub GboxPlat_pnlCom_Enter(sender As Object, e As EventArgs) Handles GboxPlat_pnlCom.Enter

    End Sub
End Class
