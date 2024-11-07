Imports MySql.Data.MySqlClient
Public Class user

    Sub awal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        ComboBox1.Enabled = False

        Button1.Text = "TAMBAH"
        Button2.Text = "UBAH"
        Button3.Text = "BUANG"
        Button4.Text = "KELUAR"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

        dbkoneksi()
        da = New MySqlDataAdapter("select kd_user,nm_user,jekel,alamat,jabatan,telp from user", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
        DataGridView1.ReadOnly = True
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("PRIA")
        ComboBox1.Items.Add("WANITA")
    End Sub

    Sub isi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Private Sub user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call awal()
        m()
        TextBox1.MaxLength = 6
        TextBox5.MaxLength = 12
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "TAMBAH" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            isi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua data sudah terisi !")
                 Else
                dbkoneksi()
                Dim simpan As String = "insert into user values('" & TextBox1.Text &
                                        "','" & TextBox2.Text & "','" & ComboBox1.Text &
                                        "','" & TextBox3.Text & "', '" & TextBox4.Text &
                                        "','" & TextBox5.Text & "', '" & TextBox6.Text & "')"
                cmd = New MySqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambahkan !")
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "UBAH" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            isi()
            If TextBox1.Text = "" Then
                MsgBox("Silahkan masukan kode untuk mengubah data !")
            End If
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua data sudah terisi !")
            Else
                dbkoneksi()
                Dim simpan As String = "update user set nm_user='" & TextBox2.Text &
                    "',jekel='" & ComboBox1.Text & "',alamat='" & TextBox3.Text &
                    "',jabatan='" & TextBox4.Text & "',telp='" & TextBox5.Text &
                    "',password='" & TextBox6.Text & "' where kd_user='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diubah !")
                awal()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            dbkoneksi()
            cmd = New MySqlCommand("select * from user where kd_user='" & TextBox1.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                TextBox1.Text = dr.Item("kd_user")
                TextBox2.Text = dr.Item("nm_user")
                TextBox6.Text = dr.Item("password")
                ComboBox1.Text = dr.Item("jekel")
                TextBox3.Text = dr.Item("alamat")
                TextBox4.Text = dr.Item("jabatan")
                TextBox5.Text = dr.Item("telp")
            Else
                MsgBox("Data tidak tersedia !")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "BUANG" Then
            Button3.Text = "HAPUS"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "BATAL"
            isi()
            If TextBox1.Text = "" Then
                MsgBox("Silahkan masukan kode untuk menghapus data !")
            End If
        Else
            If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua data sudah terisi !")
            Else
                dbkoneksi()
                Dim hapus As String = "delete from user where kd_user='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diubah !")
                awal()
            End If
        End If
    End Sub
End Class