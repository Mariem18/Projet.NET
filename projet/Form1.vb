
Imports System.Data.SqlClient

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        con.Open()
        cmd = New SqlCommand("select * from admin ", con)
        dr = cmd.ExecuteReader
        dr.Read()


        If (TextBox1.Text = dr(0) And TextBox2.Text = dr(1)) Then
            con.Close()
            Form2.Show()
            Me.Hide()
        Else
            TextBox1.Clear()
            TextBox2.Clear()
            MsgBox("Le login ou le MDP n'est pas correct ", MsgBoxStyle.Critical, "FAM-Erreur")
            TextBox1.Focus()


        End If



    End Sub


End Class
