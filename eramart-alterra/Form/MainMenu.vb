Public Class MainMenu
    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub OkToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub PraBayarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PraBayarToolStripMenuItem.Click
        PulsaPrabayar.Show()
        PulsaPrabayar.MdiParent = Me
    End Sub

    Private Sub PascaBayarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PascaBayarToolStripMenuItem.Click
        PulsaPasca.Show()
        PulsaPasca.MdiParent = Me
    End Sub

    Private Sub PaketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaketToolStripMenuItem.Click
        paket.Show()
        paket.MdiParent = Me
    End Sub

    Private Sub ListrikDanPLNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListrikDanPLNToolStripMenuItem.Click

    End Sub

    Private Sub PacaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacaToolStripMenuItem.Click
        PascabayarPLN.Show()
        PascabayarPLN.MdiParent = Me
    End Sub

    Private Sub PLNPrabayarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLNPrabayarToolStripMenuItem.Click
        PrabayarPLN.Show()
        PrabayarPLN.MdiParent = Me
    End Sub

    Private Sub InternetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InternetToolStripMenuItem.Click
        Internet.Show()
        Internet.MdiParent = Me
    End Sub

    Private Sub VoucherGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoucherGameToolStripMenuItem.Click
        Voucher.Show()
        Voucher.MdiParent = Me
    End Sub

    Private Sub EWalletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EWalletToolStripMenuItem.Click
        Wallet.Show()
        Wallet.MdiParent = Me
    End Sub

    Private Sub RiwayatTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiwayatTransaksiToolStripMenuItem.Click
        Riwayat.Show()
        Riwayat.MdiParent = Me
    End Sub
End Class