Imports System.Data.SqlClient

Public Class Setting
    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        If LoginRegister.status = "STAFF" Then
            lbl_status.Text = "STAFF"
            ds.Clear()
            da = New SqlDataAdapter("select username_staff from tabelstaff where username_staff = '" & LoginRegister.username & "'", cn)
            da.Fill(ds, "username")
            lbl_nm_pengguna.Text = ds.Tables("username").Rows(0).Item(0)
            ds.Clear()
            da = New SqlDataAdapter("select telp_staff from tabelstaff where username_staff = '" & LoginRegister.username & "'", cn)
            da.Fill(ds, "telp")
            lbl_no_hp.Text = ds.Tables("telp").Rows(0).Item(0)
        Else
            lbl_status.Text = "OWNER"
            ds.Clear()
            da = New SqlDataAdapter("select username_owner from tabelowner where username_owner = '" & LoginRegister.username & "'", cn)
            da.Fill(ds, "username")
            lbl_nm_pengguna.Text = ds.Tables("username").Rows(0).Item(0)
            ds.Clear()
            da = New SqlDataAdapter("select telp_owner from tabelowner where username_owner = '" & LoginRegister.username & "'", cn)
            da.Fill(ds, "telp")
            lbl_no_hp.Text = ds.Tables("telp").Rows(0).Item(0)
        End If
    End Sub

    Sub control()
        tbx_konfirm_pass.Text = ""
        tbx_ubh_pass.Text = ""
        tbx_ubh_telp.Text = ""
    End Sub

    Private Sub btn_perbarui_data_akun_Click(sender As Object, e As EventArgs) Handles btn_perbarui_data_akun.Click
        If tbx_ubh_telp.Text <> "" And tbx_ubh_pass.Text <> "" And tbx_konfirm_pass.Text <> "" Then
            If tbx_konfirm_pass.Text = tbx_ubh_pass.Text Then
                If tbx_captcha.Text <> "4cz8JyAz" Then
                    MsgBox("Captcha salah")
                Else
                    If LoginRegister.status = "STAFF" Then
                        da = New SqlDataAdapter("update tabelstaff set telp_staff = '" & tbx_ubh_telp.Text & "',pass_staff = '" & tbx_ubh_pass.Text & "'", cn)
                        da.Fill(ds, "update_data")
                        ds.Clear()
                        da = New SqlDataAdapter("select username_staff from tabelstaff where username_staff = '" & LoginRegister.username & "'", cn)
                        da.Fill(ds, "username")
                        lbl_nm_pengguna.Text = ds.Tables("username").Rows(0).Item(0)
                        ds.Clear()
                        da = New SqlDataAdapter("select telp_staff from tabelstaff where username_staff = '" & LoginRegister.username & "'", cn)
                        da.Fill(ds, "telp")
                        lbl_no_hp.Text = ds.Tables("telp").Rows(0).Item(0)
                        transisi_ubh_data.HideSync(pnl_ubahdata)
                        control()
                    Else
                        da = New SqlDataAdapter("update tabelowner set telp_owner = '" & tbx_ubh_telp.Text & "',pass_owner = '" & tbx_ubh_pass.Text & "'", cn)
                        da.Fill(ds, "update_data")
                        ds.Clear()
                        da = New SqlDataAdapter("select username_owner from tabelowner where username_owner = '" & LoginRegister.username & "'", cn)
                        da.Fill(ds, "username")
                        lbl_nm_pengguna.Text = ds.Tables("username").Rows(0).Item(0)
                        ds.Clear()
                        da = New SqlDataAdapter("select telp_owner from tabelowner where username_owner = '" & LoginRegister.username & "'", cn)
                        da.Fill(ds, "telp")
                        lbl_no_hp.Text = ds.Tables("telp").Rows(0).Item(0)
                        transisi_ubh_data.HideSync(pnl_ubahdata)
                        control()
                    End If
                End If
            Else
                MsgBox("Password salah !")
            End If
        Else
            MsgBox("Mohon lengkapi data !")
        End If
    End Sub

    Private Sub btn_ubh_data_Click(sender As Object, e As EventArgs)
        transisi_ubh_data.ShowSync(pnl_ubahdata)
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Process.Start("www.instagram.com/yoikona.id/")

    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Me.Hide()
        stock.Show()
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        Me.Hide()
        MenuUtama.Show()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Hide()
        History.Show()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Me.Hide()
        Promo.Show()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        LoginRegister.Show()
        LoginRegister.pnl_login.Hide()
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        transisi_ubh_data.ShowSync(pnl_ubahdata)
    End Sub

    Private Sub btn_close_detailorder_Click(sender As Object, e As EventArgs) Handles btn_close_detailorder.Click
        transisi_bill.HideSync(pnl_ubahdata)
    End Sub
End Class