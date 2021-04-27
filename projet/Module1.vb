Imports System.Data.SqlClient

Module Module1

    Public con As New SqlConnection("Data Source=LAPTOP-MARIEM\MARIEMSQL;Initial Catalog=restau;Persist Security Info=True;User ID=sa;Integrated Security=True; MultipleActiveResultSets=true")
    Public cmd As SqlCommand
    Public ad As SqlDataAdapter
    Public ds As DataSet
    Public bs As BindingSource
    Public bs1 As BindingSource
    Public bs2 As BindingSource
    Public dr As SqlDataReader
    Public qry As String


End Module
