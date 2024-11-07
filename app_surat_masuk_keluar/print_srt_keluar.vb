Imports CrystalDecisions.CrystalReports.Engine
Public Class print_srt_keluar

    Private Sub print_srt_keluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m()
        Dim lap As New ReportDocument
        lap.Load("..\..\srt_keluar.rpt")
        lap.SetParameterValue("dari", cetak_laporan.DT1.Text)
        lap.SetParameterValue("sampai", cetak_laporan.DT2.Text)
        CrystalReportViewer1.ReportSource = lap
    End Sub
End Class