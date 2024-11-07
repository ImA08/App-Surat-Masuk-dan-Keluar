Imports MySql.Data.MySqlClient
Public Class login

    Sub terbuka()
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.LaporanToolStripMenuItem.Enabled = True
        Form1.LogOutToolStripMenuItem.Visible = True
        Form1.KeluarToolStripMenuItem.Visible = True
        Form1.LogInToolStripMenuItem.Visible = False
    End Sub

    Sub terbuka2()
        Form1.MasterToolStripMenuItem.Enabled = False
        Form1.LaporanToolStripMenuItem.Enabled = True
        Form1.LogOutToolStripMenuItem.Visible = True
        Form1.KeluarToolStripMenuItem.Visible = True
        Form1.LogInToolStripMenuItem.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dbkoneksi()

        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            Close()
            MsgBox("Login Berhasil !")
            terbuka()
        Else
            cmd = New MySqlCommand("select * from user where kd_user='" & TextBox1.Text & "'and password='" & TextBox2.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Close()
                MsgBox("Login Berhasil !")
                terbuka2()
            Else
                MsgBox("Kode Petugas atau Password Salah !")
            End If

        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m()
    End Sub
End Class