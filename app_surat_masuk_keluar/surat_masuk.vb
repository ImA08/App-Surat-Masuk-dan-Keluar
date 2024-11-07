Imports MySql.Data.MySqlClient
Public Class surat_masuk

    Sub awal()
        PDF.src = (TextBox6.Text)
        TextBox6.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Text = ""
        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        DateTimePicker1.Enabled = False

        Button1.Text = "TAMBAH"
        Button2.Text = "UBAH"
        Button3.Text = "BUANG"
        Button4.Text = "KELUAR"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

        dbkoneksi()
        da = New MySqlDataAdapter("select * from surat_masuk", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
        DataGridView1.ReadOnly = True
    End Sub

    Sub isi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub surat_masuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m()
        Call awal()
        TextBox1.MaxLength = 25
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "TAMBAH" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            isi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Pastikan semua data sudah terisi !", 0, "WARNING !")
            Else
                dbkoneksi()
                Dim simpan As String = "insert into surat_masuk values('" & TextBox1.Text &
                                        "','" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & TextBox2.Text &
                                        "','" & TextBox3.Text & "', '" & TextBox4.Text &
                                        "','" & TextBox5.Text & "', '" & MySqlHelper.EscapeString(TextBox6.Text) & "')"
                cmd = New MySqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambahkan !", 0, "WARNING !")
                awal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "UBAH" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            isi()
            If TextBox1.Text = "" Then
                MsgBox("Silahkan masukan no surat untuk mengubah data !", 0, "WARNING !")
            End If
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Pastikan semua data sudah terisi !", 0, "WARNING !")
            Else
                dbkoneksi()
                Dim simpan As String = "update surat_masuk set tgl_terima='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") &
                    "',terima_dari='" & TextBox2.Text & "',prihal='" & TextBox3.Text &
                    "',lampiran='" & TextBox4.Text & "',keterangan='" & TextBox5.Text & "',file='" & MySqlHelper.EscapeString(TextBox6.Text) & "' where no_surat='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diubah !", 0, "WARNING !")
                awal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "BUANG" Then
            Button3.Text = "HAPUS"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "BATAL"
            isi()
            If TextBox1.Text = "" Then
                MsgBox("Silahkan masukan no surat untuk menghapus data !", 0, "WARNING !")
            End If
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Pastikan semua data sudah terisi !")
            Else
                dbkoneksi()
                Dim simpan As String = "delete from surat_masuk where no_surat='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus !", 0, "WARNING !")
                awal()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "KELUAR" Then
            Close()
        Else
            awal()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            dbkoneksi()
            cmd = New MySqlCommand("select * from surat_masuk where no_surat='" & TextBox1.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                TextBox1.Text = dr.Item("no_surat")
                TextBox2.Text = dr.Item("terima_dari")
                DateTimePicker1.Text = dr.Item("tgl_terima")
                TextBox3.Text = dr.Item("prihal")
                TextBox4.Text = dr.Item("lampiran")
                TextBox5.Text = dr.Item("keterangan")
                TextBox6.Text = dr.Item("file")
                PDF.src = (TextBox6.Text)
            Else
                MsgBox("Data tidak tersedia !", 0, "WARNING !")
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.ShowDialog()
        TextBox6.Text = OpenFileDialog1.FileName
        PDF.src = (TextBox6.Text)
    End Sub
End Class