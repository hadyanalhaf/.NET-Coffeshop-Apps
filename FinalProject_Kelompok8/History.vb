Imports System.Data.SqlClient

Public Class History
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Process.Start("www.instagram.com/yoikona.id/")
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        stock.koneksi_stock()
        Me.Hide()
        stock.Show()
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        Me.Hide()
        MenuUtama.Show()
    End Sub
    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Me.Hide()
        Promo.Show()
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        Me.Hide()
        Setting.Show()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        LoginRegister.Show()
        LoginRegister.pnl_login.Hide()
    End Sub

    Public Sub koneksi_history()
        ds.Clear()
        da = New SqlDataAdapter("select*from tabeltransaksi where tgl_transaksi <> ''", cn)
        da.Fill(ds, "histori_transaksi")
        GunaDataGridView1.DataSource = ds.Tables("histori_transaksi").DefaultView
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ds.Clear()
        da = New SqlDataAdapter("select*from tabeltransaksi where tgl_transaksi <> ''", cn)
        da.Fill(ds, "histori_transaksi")
        GunaDataGridView1.DataSource = ds.Tables("histori_transaksi").DefaultView
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs)
        pnl_search.Show()
        ds.Clear()
        da = New SqlDataAdapter("select *from tabelhistori where id_transaksi = '" & tbx_search.Text & "'", cn)
        da.Fill(ds, "search_histori")
        dgv_search.DataSource = ds.Tables("search_histori").DefaultView
        'pnl_search.Show()
    End Sub

    Private Sub btn_back_Click_1(sender As Object, e As EventArgs) Handles btn_back.Click
        tbx_search.Text = ""
        ds.Clear()
        da = New SqlDataAdapter("select*from tabeltransaksi where tgl_transaksi <> ''", cn)
        da.Fill(ds, "histori_transaksi")
        GunaDataGridView1.DataSource = ds.Tables("histori_transaksi").DefaultView
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        'ds.Clear()
        da = New SqlDataAdapter("select *from tabelhistori where id_transaksi = '" & tbx_search.Text & "'", cn)
        da.Fill(ds, "search_histori")
        dgv_search.DataSource = ds.Tables("search_histori").DefaultView
        'pnl_search.Show()
    End Sub
End Class