<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratMasukToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratKeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TanggalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tekton Pro Ext", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogInToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.KeluarToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.JamToolStripMenuItem, Me.TanggalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuratMasukToolStripMenuItem, Me.SuratKeluarToolStripMenuItem, Me.DataUserToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(80, 22)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'SuratMasukToolStripMenuItem
        '
        Me.SuratMasukToolStripMenuItem.Name = "SuratMasukToolStripMenuItem"
        Me.SuratMasukToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SuratMasukToolStripMenuItem.Text = "Surat Masuk"
        '
        'SuratKeluarToolStripMenuItem
        '
        Me.SuratKeluarToolStripMenuItem.Name = "SuratKeluarToolStripMenuItem"
        Me.SuratKeluarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SuratKeluarToolStripMenuItem.Text = "Surat Keluar"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuratMasukToolStripMenuItem1, Me.SuratKeluarToolStripMenuItem1})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'SuratMasukToolStripMenuItem1
        '
        Me.SuratMasukToolStripMenuItem1.Name = "SuratMasukToolStripMenuItem1"
        Me.SuratMasukToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.SuratMasukToolStripMenuItem1.Text = "Surat Masuk"
        '
        'SuratKeluarToolStripMenuItem1
        '
        Me.SuratKeluarToolStripMenuItem1.Name = "SuratKeluarToolStripMenuItem1"
        Me.SuratKeluarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.SuratKeluarToolStripMenuItem1.Text = "Surat Keluar"
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(66, 22)
        Me.LogInToolStripMenuItem.Text = "Log In"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(83, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(70, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripMenuItem1.Text = " "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripMenuItem2.Text = " "
        '
        'JamToolStripMenuItem
        '
        Me.JamToolStripMenuItem.Name = "JamToolStripMenuItem"
        Me.JamToolStripMenuItem.Size = New System.Drawing.Size(55, 22)
        Me.JamToolStripMenuItem.Text = "Jam"
        '
        'TanggalToolStripMenuItem
        '
        Me.TanggalToolStripMenuItem.Name = "TanggalToolStripMenuItem"
        Me.TanggalToolStripMenuItem.Size = New System.Drawing.Size(81, 22)
        Me.TanggalToolStripMenuItem.Text = "Tanggal"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.app_surat_masuk_keluar.My.Resources.Resources._5_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(649, 281)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratMasukToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratKeluarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TanggalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
