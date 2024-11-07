<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cetak_laporan
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DT2 = New System.Windows.Forms.DateTimePicker()
        Me.DT1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tekton Pro Ext", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(144, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 38)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DT2
        '
        Me.DT2.Font = New System.Drawing.Font("Tekton Pro Ext", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT2.Location = New System.Drawing.Point(193, 98)
        Me.DT2.Name = "DT2"
        Me.DT2.Size = New System.Drawing.Size(200, 22)
        Me.DT2.TabIndex = 28
        '
        'DT1
        '
        Me.DT1.Font = New System.Drawing.Font("Tekton Pro Ext", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT1.Location = New System.Drawing.Point(193, 59)
        Me.DT1.Name = "DT1"
        Me.DT1.Size = New System.Drawing.Size(200, 22)
        Me.DT1.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tekton Pro Ext", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(291, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 38)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Cetak Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tekton Pro Ext", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Sampai tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tekton Pro Ext", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Dari tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tekton Pro Ext", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Cetak berdasarkan tanggal :"
        '
        'cetak_laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 197)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DT2)
        Me.Controls.Add(Me.DT1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cetak_laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DT2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
