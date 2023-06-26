Imports System.Data.SqlClient

Public Class stock
    Public Sub koneksi_stock()
        ds.Clear()
        da = New SqlDataAdapter("select nama_menu, menu_type, harga, stock from tabelmenu", cn)
        da.Fill(ds, "xxx")
        GunaDataGridView1.DataSource = ds.Tables("xxx").DefaultView
    End Sub
    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ds.Clear()
        da = New SqlDataAdapter("select nama_menu, menu_type, harga, stock from tabelmenu", cn)
        da.Fill(ds, "xxx")
        GunaDataGridView1.DataSource = ds.Tables("xxx").DefaultView
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        tbx_namaMenu.Text = ""
        tbx_jenisMenu.Text = ""
        tbx_harga.Text = ""
        tbx_stok.Text = ""
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        da = New SqlDataAdapter("update tabelmenu set menu_type='" & tbx_jenisMenu.Text &
              "',harga='" & tbx_harga.Text & "',stock=" & tbx_stok.Text & " where nama_menu='" & tbx_namaMenu.Text & "'", cn)
        da.Fill(ds, "xxx")
        MsgBox("data berhasil diubah")
        ds.Clear()
        da = New SqlDataAdapter("select nama_menu, menu_type, harga, stock from tabelmenu", cn)
        da.Fill(ds, "xxx")
        GunaDataGridView1.DataSource = ds.Tables("xxx").DefaultView
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Process.Start("www.instagram.com/yoikona.id/")

    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        MenuUtama.update_stock()
        MenuUtama.update_harga()
        Me.Hide()
        MenuUtama.Show()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        History.koneksi_history()
        Me.Hide()
        History.Show()
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
End Class