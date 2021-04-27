Public Class menu


    Private Sub LBox_pnlList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBox_pnlList.SelectedIndexChanged

        If Not IsNothing(bs) Then
            bs.Position = LBox_pnlList.SelectedIndex
        End If

    End Sub

End Class
