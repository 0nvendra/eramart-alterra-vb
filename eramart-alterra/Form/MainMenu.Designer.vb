<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PascaBayarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PraBayarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListrikDanPLNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoucherGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EWalletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayatTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLNPrabayarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ListrikDanPLNToolStripMenuItem, Me.InternetToolStripMenuItem, Me.VoucherGameToolStripMenuItem, Me.EWalletToolStripMenuItem, Me.RiwayatTransaksiToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PascaBayarToolStripMenuItem, Me.PraBayarToolStripMenuItem, Me.PaketToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'PascaBayarToolStripMenuItem
        '
        Me.PascaBayarToolStripMenuItem.Name = "PascaBayarToolStripMenuItem"
        resources.ApplyResources(Me.PascaBayarToolStripMenuItem, "PascaBayarToolStripMenuItem")
        '
        'PraBayarToolStripMenuItem
        '
        Me.PraBayarToolStripMenuItem.Name = "PraBayarToolStripMenuItem"
        resources.ApplyResources(Me.PraBayarToolStripMenuItem, "PraBayarToolStripMenuItem")
        '
        'PaketToolStripMenuItem
        '
        Me.PaketToolStripMenuItem.Name = "PaketToolStripMenuItem"
        resources.ApplyResources(Me.PaketToolStripMenuItem, "PaketToolStripMenuItem")
        '
        'ListrikDanPLNToolStripMenuItem
        '
        Me.ListrikDanPLNToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacaToolStripMenuItem, Me.PLNPrabayarToolStripMenuItem})
        Me.ListrikDanPLNToolStripMenuItem.Name = "ListrikDanPLNToolStripMenuItem"
        resources.ApplyResources(Me.ListrikDanPLNToolStripMenuItem, "ListrikDanPLNToolStripMenuItem")
        '
        'PacaToolStripMenuItem
        '
        Me.PacaToolStripMenuItem.Name = "PacaToolStripMenuItem"
        resources.ApplyResources(Me.PacaToolStripMenuItem, "PacaToolStripMenuItem")
        '
        'InternetToolStripMenuItem
        '
        Me.InternetToolStripMenuItem.Name = "InternetToolStripMenuItem"
        resources.ApplyResources(Me.InternetToolStripMenuItem, "InternetToolStripMenuItem")
        '
        'VoucherGameToolStripMenuItem
        '
        Me.VoucherGameToolStripMenuItem.Name = "VoucherGameToolStripMenuItem"
        resources.ApplyResources(Me.VoucherGameToolStripMenuItem, "VoucherGameToolStripMenuItem")
        '
        'EWalletToolStripMenuItem
        '
        Me.EWalletToolStripMenuItem.Name = "EWalletToolStripMenuItem"
        resources.ApplyResources(Me.EWalletToolStripMenuItem, "EWalletToolStripMenuItem")
        '
        'RiwayatTransaksiToolStripMenuItem
        '
        Me.RiwayatTransaksiToolStripMenuItem.Name = "RiwayatTransaksiToolStripMenuItem"
        resources.ApplyResources(Me.RiwayatTransaksiToolStripMenuItem, "RiwayatTransaksiToolStripMenuItem")
        '
        'PLNPrabayarToolStripMenuItem
        '
        Me.PLNPrabayarToolStripMenuItem.Name = "PLNPrabayarToolStripMenuItem"
        resources.ApplyResources(Me.PLNPrabayarToolStripMenuItem, "PLNPrabayarToolStripMenuItem")
        '
        'MainMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PascaBayarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PraBayarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListrikDanPLNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InternetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoucherGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EWalletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RiwayatTransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PLNPrabayarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
