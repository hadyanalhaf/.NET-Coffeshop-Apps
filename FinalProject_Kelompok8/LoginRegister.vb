Imports System.Data.SqlClient

Public Class LoginRegister
    Dim cek As Boolean
    Public id As String = ""
    Public username As String = ""
    Public status As String = ""

    Private Sub LoginRegister_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnl_login.Hide()
        koneksi()
    End Sub

    Sub control()
        tbx_sgnin_uname.Text = ""
        tbx_sgnin_pass.Text = ""
        tbx_sgnup_uname.Text = ""
        tbx_sgnup_pass.Text = ""
        tbx_sgnup_repass.Text = ""
    End Sub

    Private Sub lnk_signup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_signup.LinkClicked
        control()
        animasi.HideSync(pnl_signin)
        animasi.ShowSync(pnl_signup)
    End Sub

    Sub cek_akun()
        ds.Clear()
        da = New SqlDataAdapter("select username_staff, pass_staff, telp_staff from tabelstaff", cn)
        da.Fill(ds, "data_staff")
        Dim i As Integer = 0
        While i <= ds.Tables("data_staff").Rows.Count - 1 And cek = True
            If ds.Tables("data_staff").Rows(i).Item(0).ToString = tbx_sgnup_uname.Text Or ds.Tables("data_staff").Rows(i).Item(1).ToString = tbx_sgnup_pass.Text Or ds.Tables("data_staff").Rows(i).Item(2).ToString = tbx_signup_pnumber.Text Then
                cek = False
            Else
                i = i + 1
            End If
        End While

        ds.Clear()
        da = New SqlDataAdapter("select username_owner, pass_owner, telp_owner from tabelowner", cn)
        da.Fill(ds, "data_owner")
        Dim j As Integer = 0
        While j <= ds.Tables("data_owner").Rows.Count - 1 And cek = True
            If ds.Tables("data_owner").Rows(j).Item(0).ToString = tbx_sgnup_uname.Text Or ds.Tables("data_owner").Rows(j).Item(1).ToString = tbx_sgnup_pass.Text Or ds.Tables("data_owner").Rows(j).Item(2).ToString = tbx_signup_pnumber.Text Then
                cek = False
            Else
                j = j + 1
            End If
        End While
    End Sub

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        cek = False
        If tbx_sgnup_uname.Text <> "" And tbx_sgnup_pass.Text <> "" And tbx_sgnup_repass.Text <> "" And tbx_signup_pnumber.Text <> "" And tbx_sgnup_pass.Text = tbx_sgnup_repass.Text And cbx_user.Text <> "" Then
            cek = True
        Else
            cek = False
            MsgBox("Data tidak sesuai. Mohon periksa ulang !")
        End If

        If cek = True Then
            If cbx_user.Text = "STAFF" Then
                cek_akun()
                If cek = True Then
                    da = New SqlDataAdapter("insert into tabelstaff values ('" & tbx_sgnup_uname.Text & "','" & tbx_sgnup_pass.Text & "','" & tbx_signup_pnumber.Text & "')", cn)
                    da.Fill(ds, "data_staff")
                    animasi.HideSync(pnl_signup)
                    animasi.ShowSync(pnl_signin)
                Else
                    MsgBox("Data telah digunakan pada akun lain !")
                End If
            ElseIf cbx_user.Text = "OWNER" Then
                cek_akun()
                If cek = True Then
                    da = New SqlDataAdapter("insert into tabelowner values ('" & tbx_sgnup_uname.Text & "','" & tbx_sgnup_pass.Text & "','" & tbx_signup_pnumber.Text & "')", cn)
                    da.Fill(ds, "data_owner")
                    animasi.HideSync(pnl_signup)
                    animasi.ShowSync(pnl_signin)
                Else
                    MsgBox("Data telah digunakan pada akun lain !")
                End If
            End If
        End If
        control()
    End Sub

    Private Sub LinkLabel_SignIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_SignIn.LinkClicked
        control()
        animasi.HideSync(pnl_signup)
        animasi.ShowSync(pnl_signin)
    End Sub

    Private Sub cbx_hidepass_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_hidepass.CheckedChanged
        If cbx_hidepass.Checked Then
            tbx_sgnin_pass.PasswordChar = "•"
        Else
            tbx_sgnin_pass.PasswordChar = ""
        End If
    End Sub

    Private Sub btn_signin_Click(sender As Object, e As EventArgs) Handles btn_signin.Click
        cek = False
        If tbx_sgnin_uname.Text = "" Or tbx_sgnin_pass.Text = "" Then
            MsgBox("Username / password salah !")
        End If

        ds.Clear()
        da = New SqlDataAdapter("select username_staff, pass_staff, telp_staff from tabelstaff", cn)
        da.Fill(ds, "data_staff")
        Dim i As Integer = 0
        While i <= ds.Tables("data_staff").Rows.Count - 1
            If ds.Tables("data_staff").Rows(i).Item(0).ToString = tbx_sgnin_uname.Text And ds.Tables("data_staff").Rows(i).Item(1).ToString = tbx_sgnin_pass.Text Then
                cek = True
                status = "STAFF"
                username = tbx_sgnin_uname.Text

                Dim temp As String = ""
                ds.Clear()
                da = New SqlDataAdapter("select case when max(convert(varchar,substring(id_transaksi,4,10))) is null then 1 else max(convert(varchar,substring(id_transaksi,4,10)))+1 end from tabeltransaksi", cn)
                da.Fill(ds, "ds_id")
                id = ds.Tables("ds_id").Rows(0).Item(0)
                For z As Integer = 1 To 4 - id.Length
                    temp = temp & "0"
                Next
                id = "YKN" & temp & id
                da = New SqlDataAdapter("insert into tabeltransaksi (id_transaksi, username_staff) values ('" & id & "','" & tbx_sgnin_uname.Text & "')", cn)
                da.Fill(ds, "ds_id")

                MenuUtama.koneksi_MenuUtama()
                Me.Hide()
                MenuUtama.Show()
            Else
                i = i + 1
            End If
        End While

        ds.Clear()
        da = New SqlDataAdapter("select username_owner, pass_owner, telp_owner from tabelowner", cn)
        da.Fill(ds, "data_owner")
        Dim j As Integer = 0
        While j <= ds.Tables("data_owner").Rows.Count - 1
            If ds.Tables("data_owner").Rows(j).Item(0).ToString = tbx_sgnin_uname.Text And ds.Tables("data_owner").Rows(j).Item(1).ToString = tbx_sgnin_pass.Text Then
                cek = True
                status = "OWNER"
                username = tbx_sgnin_uname.Text

                stock.koneksi_stock()
                Me.Hide()
                stock.Show()
            Else
                j = j + 1
            End If
        End While

        If cek = False Then
            MsgBox("Username / password salah!")
        End If
        control()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        MenuCustomer.Show()
        Me.Hide()
        control()
    End Sub

    Private Sub btn_squad_Click(sender As Object, e As EventArgs) Handles btn_squad.Click
        pnl_login.Show()
    End Sub
End Class