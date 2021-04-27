Imports System.Data.SqlClient
Imports System.IO


Public Class modifier
    Private Sub btnMod_pnlMd_Click(sender As Object, e As EventArgs) Handles btnMod_pnlMd.Click
        con.Open()

        cmd = New SqlCommand("update elements set nomElement=@nom, prix=@prix, type=@type, image=@img where id=@id ", con)
        Dim ms As New MemoryStream
        pctMod_pnlMd.Image.Save(ms, pctMod_pnlMd.Image.RawFormat)


        cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtId_pnlMd.Text
        cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = txtNom_pnlMd.Text
        cmd.Parameters.Add("@prix", SqlDbType.Int).Value = txtprix_pnlMd.Text
        cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = CoBoxType_pnlMd.Text
        cmd.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()


        If cmd.ExecuteNonQuery() = 1 Then

            MsgBox("Modifié avec succée", MsgBoxStyle.OkOnly, "FAM-OK")

        Else
            MsgBox("Echec de modification", MsgBoxStyle.Critical, "FAM-Erreur")

        End If


        txtId_pnlMd.Clear()
        txtNom_pnlMd.Clear()
        txtprix_pnlMd.Clear()
        CoBoxType_pnlMd.Text = Nothing
        pctMod_pnlMd.Image = Nothing


        con.Close()
    End Sub

    Private Sub btnImp_pnlMd_Click(sender As Object, e As EventArgs) Handles btnImp_pnlMd.Click
        Dim dlg As New OpenFileDialog

        dlg.Filter = "choose image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            pctMod_pnlMd.Image = Image.FromFile(dlg.FileName)
        End If

    End Sub
End Class
