Imports System.Data.SqlClient

Module ModuleDB
    Public cn As New SqlConnection
    Public da As New SqlDataAdapter
    Public ds As New DataSet

    Public Sub koneksi()
        cn = New SqlConnection("Data Source=LAPTOP-15TTO25I\SQLEXPRESS;Initial Catalog=YoiKonaCafe;Integrated Security=True")
    End Sub
End Module
