Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class MenuUtama

    Public subtotal As String = ""
    Public id_transaksi As String = LoginRegister.id
    Dim count As Integer = 0
    Public bayar As Integer = 0

    Private Sub GunaTileButton2_Click(sender As Object, e As EventArgs) Handles GunaTileButton2.Click
        anim2.HideSync(lbl_oos)
        anim2.HideSync(Pnl_freshdrink)
        anim2.HideSync(pnl_maincourse)
        anim2.ShowSync(Pnl_noncoffee)

    End Sub

    Private Sub GunaTileButton3_Click(sender As Object, e As EventArgs) Handles GunaTileButton3.Click
        anim2.HideSync(lbl_oos)
        anim2.HideSync(Pnl_noncoffee)
        anim2.HideSync(pnl_maincourse)
        anim2.ShowSync(Pnl_freshdrink)

    End Sub
    Public Sub update_harga()
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu= 'Mint Tea'", cn)
        da.Fill(ds, "harga mint tea")
        hrg_mintea.Text = "Rp" + CStr(ds.Tables("harga mint tea").Rows(0).Item(0)) + ",-"
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu= 'Strawberry Lemonade'", cn)
        da.Fill(ds, "harga Strawberry Lemonade")
        hrg_lemonade.Text = "Rp" + CStr(ds.Tables("harga Strawberry Lemonade").Rows(0).Item(0)) + ",-"
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu= 'Mango Series'", cn)
        da.Fill(ds, "harga Mango Series")
        hrg_mango.Text = "Rp" + CStr(ds.Tables("harga Mango Series").Rows(0).Item(0)) + ",-"
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu= 'Cotton Candy'", cn)
        da.Fill(ds, "harga Cotton Candy")
        hrg_cottoncandy.Text = "Rp" + CStr(ds.Tables("harga Cotton Candy").Rows(0).Item(0)) + ",-"
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu= 'Strawberry Shortcake'", cn)
        da.Fill(ds, "harga Strawberry Shortcake")
        hrg_shortcake.Text = "Rp" + CStr(ds.Tables("harga Strawberry Shortcake").Rows(0).Item(0)) + ",-"
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu= 'Matcha Latte'", cn)
        da.Fill(ds, "harga Matcha Latte")
        hrg_matchalatte.Text = "Rp" + CStr(ds.Tables("harga Matcha Latte").Rows(0).Item(0)) + ",-"
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu= 'Beef Mentai'", cn)
        da.Fill(ds, "harga Beef Mentai")
        hrg_mentai.Text = "Rp" + CStr(ds.Tables("harga Beef Mentai").Rows(0).Item(0)) + ",-"
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu= 'Katsudon Set'", cn)
        da.Fill(ds, "harga ks")
        hrg_babi.Text = "Rp" + CStr(ds.Tables("harga ks").Rows(0).Item(0)) + ",-"
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu= 'Chicken Pramesan'", cn)
        da.Fill(ds, "harga cp")
        hrg_pramesan.Text = "Rp" + CStr(ds.Tables("harga cp").Rows(0).Item(0)) + ",-"
    End Sub

    Public Sub update_stock()
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = 'Mint Tea'", cn)
        da.Fill(ds, "Stock Mint Tea")
        lbl_stock_minttea.Text = "stock : " + CStr(ds.Tables("Stock Mint Tea").Rows(0).Item(0))
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = 'Strawberry Lemonade'", cn)
        da.Fill(ds, "Stock Strawberry L")
        lbl_stock_strawberryL.Text = "stock : " + CStr(ds.Tables("Stock Strawberry L").Rows(0).Item(0))
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = 'Mango Series'", cn)
        da.Fill(ds, "Stock Mango S")
        lbl_stock_mangoS.Text = "stock : " + CStr(ds.Tables("Stock Mango S").Rows(0).Item(0))
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = 'Cotton Candy'", cn)
        da.Fill(ds, "Stock Cotton C")
        lbl_stock_cottoncandy.Text = "stock : " + CStr(ds.Tables("Stock Cotton C").Rows(0).Item(0))
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = 'Strawberry Shortcake'", cn)
        da.Fill(ds, "Stock Strawberry S")
        lbl_stock_strawberryS.Text = "stock : " + CStr(ds.Tables("Stock Strawberry S").Rows(0).Item(0))
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = 'Matcha Latte'", cn)
        da.Fill(ds, "Stock Matcha L")
        lbl_stock_matchaL.Text = "stock : " + CStr(ds.Tables("Stock Matcha L").Rows(0).Item(0))
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = 'Beef Mentai'", cn)
        da.Fill(ds, "Stock bm2")
        lbl_stkmentai.Text = "stock : " + CStr(ds.Tables("Stock bm2").Rows(0).Item(0))
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = 'Katsudon Set'", cn)
        da.Fill(ds, "Stock ks2")
        lbl_stkbabi.Text = "stock : " + CStr(ds.Tables("Stock ks2").Rows(0).Item(0))
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = 'Chicken Pramesan'", cn)
        da.Fill(ds, "Stock cs2")
        lbl_stkpramesan.Text = "stock : " + CStr(ds.Tables("Stock cs2").Rows(0).Item(0))
    End Sub

    Public Sub koneksi_MenuUtama()
        control()
        update_stock()
        update_harga()
        tbx_uname.Text = LoginRegister.username
    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        control()
        update_stock()
        update_harga()
        tbx_uname.Text = LoginRegister.username
    End Sub

    Sub print_bill()
        If rb_cash.Checked = True Then
            lbl_metode_bayar.Text = "Cash"
        ElseIf rb_debit.Checked = True Then
            lbl_metode_bayar.Text = "Debit"
        ElseIf rb_qris.Checked = True Then
            lbl_metode_bayar.Text = "QRIS"
        End If
        pnl_print_bill.Show()

        ds.Clear()
        da = New SqlDataAdapter("select nama_menu, convert (varchar,jml_beli) + 'x', sub_total from tabelhistori where id_transaksi = '" & LoginRegister.id & "'", cn)
        da.Fill(ds, "bill2")
        dgv_bill.DataSource = ds.Tables("bill2").DefaultView
        lbl_kode_bill.Text = LoginRegister.id
        lbl_nm_kasir.Text = LoginRegister.username
        lbl_nm_pembeli.Text = tbx_nm_customer.Text
        lbl_bill_jmlbayar.Text = bayar
        lbl_bill_kembali.Text = bayar - CInt(tbx_subtotal.Text)
    End Sub
    Public regDate As String = ""
    Public regMonth As String = ""
    Public regYear As String = ""
    Private Sub btn_print_bills_Click(sender As Object, e As EventArgs) Handles btn_print_bills.Click
        regDate = Format(Date.Now(), "dd")
        regMonth = Format(Date.Now(), "MMM")
        regYear = Format(Date.Now(), "yyyy")

        If tbx_subtotal.Text = "" Or tbx_subtotal.Text = "0" Then
            MsgBox("Pembelian belum ada !")
        Else
            If tbx_nm_customer.Text = "" Then
                MsgBox("Nama pelanggan belum terisi")
            Else
                If rb_cash.Checked = True Or rb_debit.Checked = True Or rb_qris.Checked = True Then
                    If tbx_kode_promo.Text = "XMAS2022" Then
                        lbl_tanggal.Text = regDate & " " & regMonth & " " & regYear
                        Dim total As Integer = 0
                        Dim diskon As Integer = 0
                        total = CInt(tbx_subtotal.Text)
                        diskon = 0.3 * total
                        total = total - diskon
                        lbl_bill_total.Text = total
                        print_bill()
                        anim2.ShowSync(pnl_print_bill)
                        lbl_diskon.Visible = True
                        lbl_diskon.Text = diskon
                        lbl_Rp_diskon.Visible = True
                        lbl_dskn.Visible = True
                    ElseIf tbx_kode_promo.Text = "" Then
                        lbl_tanggal.Text = regDate & " " & regMonth & " " & regYear
                        lbl_bill_total.Text = tbx_subtotal.Text
                        print_bill()
                        anim2.ShowSync(pnl_print_bill)
                    End If
                Else
                    MsgBox("Pilih metode pembayaran ! ")
                End If
            End If
        End If
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        LoginRegister.Show()
        LoginRegister.pnl_login.Hide()
    End Sub

    Private Sub btn_detailorder_Click(sender As Object, e As EventArgs) Handles btn_detail_order.Click
        'untuk update stok
        Dim stock As Integer
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = '" & lbl_nm_menu.Text & "'", cn)
        da.Fill(ds, "stock")
        stock = CInt(ds.Tables("stock").Rows(0).Item(0))
        stock = stock - count
        da = New SqlDataAdapter("update tabelmenu set stock = '" & stock & "' where nama_menu = '" & lbl_nm_menu.Text & "'", cn)
        da.Fill(ds, "stock")
        update_stock()

        'variabel untuk menyimpan data radio button
        Dim subtotal As Integer = 0
        Dim varian As String = ""
        Dim sugar As String = ""
        Dim topping As String = ""

        If rb_ice.Checked = True Then
            varian = "Ice"
        Else
            varian = "Hot"
        End If
        If rb_less_sugar.Checked = True Then
            sugar = "Less"
        Else
            sugar = "Normal"
        End If
        If rb_boba.Checked = True Then
            topping = "Boba"
        Else
            topping = "None"
        End If

        'untuk menampilkan detail order ke cart
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu = '" & lbl_nm_menu.Text & "'", cn)
        da.Fill(ds, "harga")
        subtotal = count * CInt(ds.Tables("harga").Rows(0).Item(0))
        da = New SqlDataAdapter("insert into tabelhistori (id_transaksi,nama_menu,varian,sugar,jml_beli,sub_total) values ('" & LoginRegister.id & "','" &
                                lbl_nm_menu.Text & "','" & varian & "','" & sugar & "','" & tbx_count.Text & "','" & subtotal & "')", cn)
        da.Fill(ds, "ds_histori")
        ds.Clear()
        da = New SqlDataAdapter("select nama_menu, convert (varchar,jml_beli) + 'x', sub_total from tabelhistori where id_transaksi = '" & LoginRegister.id & "'", cn)
        da.Fill(ds, "cart")
        dgv_cart.DataSource = ds.Tables("cart").DefaultView
        transisi_detailorder.HideSync(pnl_detailorder)
        count = 0
        tbx_count.Text = "0"
        rb_ice.Checked = True
        rb_hot.Checked = False
        rb_less_sugar.Checked = True
        rb_normal_sugar.Checked = False
        rb_boba.Checked = True
        rb_none.Checked = False
        da = New SqlDataAdapter("select sum(sub_total) from tabelhistori where id_transaksi='" & LoginRegister.id & "'", cn)
        da.Fill(ds, "subtotal")
        tbx_subtotal.Text = ds.Tables("subtotal").Rows(0).Item(0)
        'subtotal = tbx_subtotal.Text
    End Sub

    Private Sub btn_mint_tea_Click(sender As Object, e As EventArgs) Handles btn_mint_tea.Click
        lbl_nm_menu.Text = "Mint Tea"
        transisi_detailorder.HideSync(pnl_detail_order2)
        transisi_detailorder.ShowSync(pnl_detailorder)
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        count = count + 1
        tbx_count.Text = count
    End Sub

    Private Sub btn_kurang_Click(sender As Object, e As EventArgs) Handles btn_kurang.Click
        count = count - 1
        tbx_count.Text = count
    End Sub

    Private Sub btn_strawberry_L_Click(sender As Object, e As EventArgs) Handles btn_strawberry_L.Click
        lbl_nm_menu.Text = "Strawberry Lemonade"
        transisi_detailorder.HideSync(pnl_detail_order2)
        transisi_detailorder.ShowSync(pnl_detailorder)
    End Sub

    Private Sub btn_mango_series_Click(sender As Object, e As EventArgs) Handles btn_mango_series.Click
        lbl_nm_menu.Text = "Mango Series"
        transisi_detailorder.HideSync(pnl_detail_order2)
        transisi_detailorder.ShowSync(pnl_detailorder)
    End Sub

    Private Sub btn_cotton_candy_Click(sender As Object, e As EventArgs) Handles btn_cotton_candy.Click
        lbl_nm_menu.Text = "Cotton Candy"
        transisi_detailorder.HideSync(pnl_detail_order2)
        transisi_detailorder.ShowSync(pnl_detailorder)
    End Sub

    Private Sub btn_strawberryS_Click(sender As Object, e As EventArgs) Handles btn_strawberryS.Click
        lbl_nm_menu.Text = "Strawberry Shortcake"
        transisi_detailorder.HideSync(pnl_detail_order2)
        transisi_detailorder.ShowSync(pnl_detailorder)
    End Sub

    Private Sub btn_matchaL_Click(sender As Object, e As EventArgs) Handles btn_matchaL.Click
        lbl_nm_menu.Text = "Matcha Latte"
        transisi_detailorder.HideSync(pnl_detail_order2)
        transisi_detailorder.ShowSync(pnl_detailorder)
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        Me.Hide()
        Setting.Show()
    End Sub

    Private Sub btn_bayar_cash_Click(sender As Object, e As EventArgs) Handles btn_bayar_cash.Click
        If tbx_nominal.Text = "0" Then
            MsgBox("Masukkan nominal !")
        Else
            bayar = tbx_nominal.Text
        End If
        tbx_nominal.Text = ""
        Pnl_cash.Hide()
        GunaPanel7.Show()
    End Sub

    Private Sub btn_cash_Click(sender As Object, e As EventArgs) Handles btn_cash.Click
        Pnl_debit.Hide()
        Pnl_qris.Hide()
        GunaPanel7.Hide()
        Pnl_cash.Show()
    End Sub

    Private Sub btn_debit_Click(sender As Object, e As EventArgs) Handles btn_debit.Click
        GunaPanel7.Hide()
        Pnl_cash.Hide()
        Pnl_qris.Hide()
        Pnl_debit.Show()
    End Sub

    Private Sub btn_qris_Click(sender As Object, e As EventArgs) Handles btn_qris.Click
        Pnl_cash.Hide()
        Pnl_debit.Hide()
        GunaPanel7.Hide()
        Pnl_qris.Show()
    End Sub

    Public Sub control()
        rb_cash.Checked = False
        rb_debit.Checked = False
        rb_qris.Checked = False
    End Sub

    Private Sub btn_back_cash_Click(sender As Object, e As EventArgs) Handles btn_back_cash.Click
        tbx_nominal.Text = "0"
        control()
        Pnl_cash.Hide()
        GunaPanel7.Show()
    End Sub

    Private Sub btn_bayar_qris_Click(sender As Object, e As EventArgs) Handles btn_bayar_qris.Click
        If tbx_subtotal.Text = "" Then
            bayar = 0
        Else
            bayar = CInt(tbx_subtotal.Text)
        End If
        Pnl_qris.Hide()
        GunaPanel7.Show()
    End Sub

    Private Sub btn_back_qris_Click(sender As Object, e As EventArgs) Handles btn_back_qris.Click
        Pnl_qris.Hide()
        GunaPanel7.Show()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        History.koneksi_history()
        Me.Hide()
        History.Show()
    End Sub

    Private Sub btn_back_debit_Click(sender As Object, e As EventArgs) Handles btn_back_debit.Click
        Pnl_debit.Hide()
        GunaPanel7.Show()
    End Sub

    Private Sub btn_bayar_debit_Click(sender As Object, e As EventArgs) Handles btn_bayar_debit.Click
        If tbx_subtotal.Text = "" Then
            bayar = 0
        Else
            bayar = CInt(tbx_subtotal.Text)
        End If
        Pnl_debit.Hide()
        GunaPanel7.Show()

    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        'da = New SqlDataAdapter("update tabeltransaksi set nama_pembeli = '" & lbl_nm_pembeli.Text & "',total_biaya=" & lbl_bill_total.Text & ", jml_bayar = " & lbl_bill_jmlbayar.Text & ", jml_kembali = " & lbl_bill_kembali.Text & "where id_transaksi='" & LoginRegister.id & "';", cn)
        'da.Fill(ds, "tabel_transaksi")
        da = New SqlDataAdapter("update tabeltransaksi set nama_pembeli = '" & lbl_nm_pembeli.Text & "',total_biaya=" & lbl_bill_total.Text & ", jml_bayar = " & lbl_bill_jmlbayar.Text & ", jml_kembali = " & lbl_bill_kembali.Text & ", tgl_transaksi = '" & regDate & regMonth & regYear & "' where id_transaksi='" & LoginRegister.id & "';", cn)
        da.Fill(ds, "tabel_transaksi")

        Dim temp As String = ""
        ds.Clear()
        da = New SqlDataAdapter("select case when max(convert(varchar,substring(id_transaksi,4,10))) is null then 1 else max(convert(varchar,substring(id_transaksi,4,10)))+1 end from tabeltransaksi", cn)
        da.Fill(ds, "ds_id")
        LoginRegister.id = ds.Tables("ds_id").Rows(0).Item(0)
        For z As Integer = 1 To 4 - LoginRegister.id.Length
            temp = temp & "0"
        Next
        LoginRegister.id = "YKN" & temp & LoginRegister.id
        da = New SqlDataAdapter("insert into tabeltransaksi (id_transaksi, username_staff) values ('" & LoginRegister.id & "','" & LoginRegister.username & "')", cn)
        da.Fill(ds, "ds_id")

        tbx_subtotal.Text = ""
        control()
        tbx_kode_promo.Text = ""
        pnl_print_bill.Hide()
        tbx_nm_customer.Text = ""
        lbl_diskon.Visible = False
        lbl_Rp_diskon.Visible = False
        lbl_dskn.Visible = False
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        transisi_detailorder.HideSync(pnl_detailorder)
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        If LoginRegister.status = "OWNER" Then
            stock.koneksi_stock()
            Me.Hide()
            stock.Show()
        Else
            MsgBox("Form hanya bisa diakses oleh owner !")
        End If
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Me.Hide()
        Promo.Show()
    End Sub

    Private Sub GunaTileButton4_Click(sender As Object, e As EventArgs) Handles GunaTileButton4.Click
        anim2.HideSync(lbl_oos)
        anim2.HideSync(Pnl_freshdrink)
        anim2.HideSync(Pnl_noncoffee)
        anim2.ShowSync(pnl_maincourse)

    End Sub

    Private Sub GunaTileButton5_Click(sender As Object, e As EventArgs) Handles GunaTileButton5.Click
        anim2.HideSync(Pnl_freshdrink)
        anim2.HideSync(Pnl_noncoffee)
        anim2.HideSync(pnl_maincourse)
        anim2.ShowSync(lbl_oos)
    End Sub

    Private Sub GunaTileButton6_Click(sender As Object, e As EventArgs) Handles GunaTileButton6.Click
        anim2.HideSync(Pnl_freshdrink)
        anim2.HideSync(Pnl_noncoffee)
        anim2.HideSync(pnl_maincourse)
        anim2.ShowSync(lbl_oos)
    End Sub

    Private Sub GunaTileButton7_Click(sender As Object, e As EventArgs) Handles GunaTileButton7.Click
        anim2.HideSync(Pnl_freshdrink)
        anim2.HideSync(Pnl_noncoffee)
        anim2.HideSync(pnl_maincourse)
        anim2.ShowSync(lbl_oos)
    End Sub

    Private Sub btn_mentai_Click(sender As Object, e As EventArgs) Handles btn_mentai.Click
        lbl_nm_menu2.Text = "Beef Mentai"
        transisi_detailorder.HideSync(pnl_detailorder)
        transisi_detailorder.ShowSync(pnl_detail_order2)
    End Sub

    Private Sub btn_pramesan_Click(sender As Object, e As EventArgs) Handles btn_pramesan.Click
        lbl_nm_menu2.Text = "Chicken Pramesan"
        transisi_detailorder.HideSync(pnl_detailorder)
        transisi_detailorder.ShowSync(pnl_detail_order2)
    End Sub

    Private Sub btn_babi_Click(sender As Object, e As EventArgs) Handles btn_babi.Click
        lbl_nm_menu2.Text = "Katsudon Set"
        transisi_detailorder.HideSync(pnl_detailorder)
        transisi_detailorder.ShowSync(pnl_detail_order2)
    End Sub

    Private Sub btn_mainplus_Click(sender As Object, e As EventArgs) Handles btn_mainplus.Click
        count = count + 1
        tb_countmaincourse.Text = count
    End Sub

    Private Sub btn_mainminus_Click(sender As Object, e As EventArgs) Handles btn_mainminus.Click
        count = count - 1
        tb_countmaincourse.Text = count
    End Sub

    Private Sub BunifuButton14_Click(sender As Object, e As EventArgs) Handles BunifuButton14.Click
        'untuk update stok
        Dim stock As Integer
        ds.Clear()
        da = New SqlDataAdapter("select stock from tabelmenu where nama_menu = '" & lbl_nm_menu2.Text & "'", cn)
        da.Fill(ds, "stock")
        stock = CInt(ds.Tables("stock").Rows(0).Item(0))
        stock = stock - count
        da = New SqlDataAdapter("update tabelmenu set stock = '" & stock & "' where nama_menu = '" & lbl_nm_menu2.Text & "'", cn)
        da.Fill(ds, "stock")
        update_stock()

        'variabel untuk menyimpan data radio button
        Dim subtotal As Integer = 0

        'untuk menampilkan detail order ke cart
        ds.Clear()
        da = New SqlDataAdapter("select harga from tabelmenu where nama_menu = '" & lbl_nm_menu2.Text & "'", cn)
        da.Fill(ds, "harga")
        subtotal = count * CInt(ds.Tables("harga").Rows(0).Item(0))
        da = New SqlDataAdapter("insert into tabelhistori (id_transaksi,nama_menu,jml_beli,sub_total) values ('" & LoginRegister.id & "','" &
                                lbl_nm_menu2.Text & "','" & tb_countmaincourse.Text & "','" & subtotal & "')", cn)
        da.Fill(ds, "ds_histori")
        ds.Clear()
        da = New SqlDataAdapter("select nama_menu, convert (varchar,jml_beli) + 'x', sub_total from tabelhistori where id_transaksi = '" & LoginRegister.id & "'", cn)
        da.Fill(ds, "cart")
        dgv_cart.DataSource = ds.Tables("cart").DefaultView
        transisi_detailorder.HideSync(pnl_detailorder)
        count = 0
        tbx_count.Text = "0"
        da = New SqlDataAdapter("select sum(sub_total) from tabelhistori where id_transaksi='" & LoginRegister.id & "'", cn)
        da.Fill(ds, "subtotal")
        tbx_subtotal.Text = ds.Tables("subtotal").Rows(0).Item(0)
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Process.Start("www.instagram.com/yoikona.id/")
    End Sub

    Private Sub BunifuButton11_Click(sender As Object, e As EventArgs) Handles BunifuButton11.Click
        transisi_detailorder.HideSync(pnl_detail_order2)
    End Sub
End Class