Public Class Promo
    Private Sub btn_logout_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

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

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        History.koneksi_history()
        Me.Hide()
        History.Show()
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        Me.Hide()
        Setting.Show()
    End Sub

    Private Sub btn_logout_Click_1(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        LoginRegister.Show()
        LoginRegister.pnl_login.Hide()
    End Sub
End Class