Public Class MainMenu
    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub PraBayarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PraBayarToolStripMenuItem.Click
        PulsaPrabayar.MdiParent = Me
        PulsaPrabayar.Show()
    End Sub

    Private Sub PascaBayarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PascaBayarToolStripMenuItem.Click
        PulsaPasca.MdiParent = Me
        PulsaPasca.Show()
    End Sub

    Private Sub PaketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaketToolStripMenuItem.Click
        paket.MdiParent = Me
        paket.Show()
    End Sub

    Private Sub PacaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacaToolStripMenuItem.Click
        PascabayarPLN.MdiParent = Me
        PascabayarPLN.Show()
    End Sub

    Private Sub PLNPrabayarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLNPrabayarToolStripMenuItem.Click
        PrabayarPLN.MdiParent = Me
        PrabayarPLN.Show()
    End Sub

    Private Sub InternetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InternetToolStripMenuItem.Click
        Internet.MdiParent = Me
        Internet.Show()
    End Sub

    Private Sub VoucherGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoucherGameToolStripMenuItem.Click
        Voucher.MdiParent = Me
        Voucher.Show()
    End Sub

    Private Sub EWalletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EWalletToolStripMenuItem.Click
        Wallet.MdiParent = Me
        Wallet.Show()
    End Sub

    Private Sub RiwayatTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiwayatTransaksiToolStripMenuItem.Click
        Riwayat.MdiParent = Me
        Riwayat.Show()
    End Sub
End Class