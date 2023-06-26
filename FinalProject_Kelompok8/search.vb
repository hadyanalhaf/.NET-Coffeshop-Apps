Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class search
    Private Sub dgv_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_search.CellContentClick

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
    End Sub

    Private Sub pnl_search_Click(sender As Object, e As EventArgs) Handles pnl_search.Click

    End Sub

    Private Sub search_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        ds.Clear()
        da = New SqlDataAdapter("select *from tabelhistori where id_transaksi = '" & History.tbx_search.Text & "'", cn)
        da.Fill(ds, "search_histori")
        dgv_search.DataSource = ds.Tables("search_histori").DefaultView
    End Sub
End Class