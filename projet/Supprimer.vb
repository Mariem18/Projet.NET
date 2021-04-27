Imports System.Data.SqlClient

Public Class supprimer
    Private Sub btnSp_pnlSp_Click(sender As Object, e As EventArgs) Handles btnSp_pnlSp.Click
        con.Open()

        cmd = New SqlCommand("delete from elements where nomElement=@nom and type=@type ", con)
        cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = txtNm_pnlSp.Text
        cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = CoBoxSup_pnlSp.Text


        If cmd.ExecuteNonQuery() = 1 Then

            MsgBox("L'èlement a été bien supprimé", MsgBoxStyle.OkOnly, "FAM-OK")

        Else
            MsgBox("Echec de suppression", MsgBoxStyle.Critical, "FAM-Erreur")

        End If


        txtNm_pnlSp.Clear()
        CoBoxSup_pnlSp.Text = Nothing

    End Sub
End Class
