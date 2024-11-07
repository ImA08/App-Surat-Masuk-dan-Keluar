Imports CrystalDecisions.CrystalReports.Engine
Public Class cetak_laporan2

    Private Sub cetak_laporan2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        print_srt_masuk.Show()
    End Sub
End Class