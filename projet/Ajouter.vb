Imports System.Data.SqlClient
Imports System.IO


Public Class ajouter
    Private Sub btnAj_pnlAj_Click(sender As Object, e As EventArgs) Handles btnAj_pnlAj.Click
        con.Open()


        cmd = New SqlCommand("insert into elements (nomElement,prix,type,image) values(@nom,@prix,@type,@img)  ", con)
        Dim ms As New MemoryStream
        pctAj_pnlAj.Image.Save(ms, pctAj_pnlAj.Image.RawFormat)


        cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = txtNm_pnlAj.Text
        cmd.Parameters.Add("@prix", SqlDbType.Int).Value = txtprix_pnlAj.Text
        cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = CoBoxAj_pnlAj.Text
        cmd.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()

        If cmd.ExecuteNonQuery() = 1 Then

            MsgBox("Ajouté avec succée", MsgBoxStyle.OkOnly, "FAM-OK")

        Else
            MsgBox("Echec d'ajout", MsgBoxStyle.Critical, "FAM-Erreur")

        End If


        txtNm_pnlAj.Clear()
        txtprix_pnlAj.Clear()
        CoBoxAj_pnlAj.Text = Nothing
        pctAj_pnlAj.Image = Nothing


        con.Close()


    End Sub

    Private Sub btnImporter_pnlAj_Click(sender As Object, e As EventArgs) Handles btnImporter_pnlAj.Click
        Dim dlg As New OpenFileDialog

        dlg.Filter = "choose image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            pctAj_pnlAj.Image = Image.FromFile(dlg.FileName)
        End If
    End Sub

    Private Sub pnlAj_Paint(sender As Object, e As PaintEventArgs) Handles pnlAj.Paint

    End Sub
End Class
