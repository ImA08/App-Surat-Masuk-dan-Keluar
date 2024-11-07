Public Class Form1

    Sub awal()
        LogOutToolStripMenuItem.Visible = False
        KeluarToolStripMenuItem.Visible = True
        LogInToolStripMenuItem.Visible = True
        MasterToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m()
        Call awal()
        TanggalToolStripMenuItem.Text = Date.Now.ToString("dd MMM yyyy")
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        MsgBox("Log Out Telah Berhasil !")
        Call awal()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInToolStripMenuItem.Click
        login.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        JamToolStripMenuItem.Text = TimeOfDay
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataUserToolStripMenuItem.Click
        user.Show()
    End Sub

    Private Sub SuratMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuratMasukToolStripMenuItem.Click
        surat_masuk.Show()
    End Sub

    Private Sub SuratKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuratKeluarToolStripMenuItem.Click
        surat_keluar.Show()
    End Sub

    Private Sub SuratMasukToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuratMasukToolStripMenuItem1.Click
        cetak_laporan2.Show()
    End Sub

    Private Sub SuratKeluarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuratKeluarToolStripMenuItem1.Click
        cetak_laporan.Show()
    End Sub
End Class
