<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IV
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
        Me.okviraSlika = New System.Windows.Forms.PictureBox()
        Me.prikaziSliku = New System.Windows.Forms.Button()
        Me.ponisti = New System.Windows.Forms.Button()
        Me.izlaz = New System.Windows.Forms.Button()
        Me.odaberi = New System.Windows.Forms.OpenFileDialog()
        Me.Lista = New System.Windows.Forms.ListBox()
        Me.prethodna = New System.Windows.Forms.Button()
        Me.sljedeca = New System.Windows.Forms.Button()
        CType(Me.okviraSlika, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'okviraSlika
        '
        Me.okviraSlika.BackColor = System.Drawing.Color.DarkGray
        Me.okviraSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.okviraSlika.Location = New System.Drawing.Point(-4, 2)
        Me.okviraSlika.Name = "okviraSlika"
        Me.okviraSlika.Size = New System.Drawing.Size(851, 444)
        Me.okviraSlika.TabIndex = 0
        Me.okviraSlika.TabStop = False
        '
        'prikaziSliku
        '
        Me.prikaziSliku.BackColor = System.Drawing.Color.Gray
        Me.prikaziSliku.Location = New System.Drawing.Point(25, 452)
        Me.prikaziSliku.Name = "prikaziSliku"
        Me.prikaziSliku.Size = New System.Drawing.Size(90, 40)
        Me.prikaziSliku.TabIndex = 1
        Me.prikaziSliku.Text = "Odaberi "
        Me.prikaziSliku.UseVisualStyleBackColor = False
        '
        'ponisti
        '
        Me.ponisti.BackColor = System.Drawing.Color.Gray
        Me.ponisti.Enabled = False
        Me.ponisti.Location = New System.Drawing.Point(621, 452)
        Me.ponisti.Name = "ponisti"
        Me.ponisti.Size = New System.Drawing.Size(90, 40)
        Me.ponisti.TabIndex = 2
        Me.ponisti.Text = "Poništi"
        Me.ponisti.UseVisualStyleBackColor = False
        '
        'izlaz
        '
        Me.izlaz.BackColor = System.Drawing.Color.Gray
        Me.izlaz.Location = New System.Drawing.Point(724, 452)
        Me.izlaz.Name = "izlaz"
        Me.izlaz.Size = New System.Drawing.Size(90, 40)
        Me.izlaz.TabIndex = 3
        Me.izlaz.Text = "Izlaz"
        Me.izlaz.UseVisualStyleBackColor = False
        '
        'odaberi
        '
        Me.odaberi.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" &
    "s (*.*)|*.* "
        Me.odaberi.Multiselect = True
        Me.odaberi.Title = "Odaberi sliku"
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(694, 22)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(120, 95)
        Me.Lista.TabIndex = 4
        Me.Lista.Visible = False
        '
        'prethodna
        '
        Me.prethodna.BackColor = System.Drawing.Color.Gray
        Me.prethodna.Enabled = False
        Me.prethodna.Location = New System.Drawing.Point(281, 452)
        Me.prethodna.Name = "prethodna"
        Me.prethodna.Size = New System.Drawing.Size(90, 40)
        Me.prethodna.TabIndex = 5
        Me.prethodna.Text = "Prethodna"
        Me.prethodna.UseVisualStyleBackColor = False
        '
        'sljedeca
        '
        Me.sljedeca.BackColor = System.Drawing.Color.Gray
        Me.sljedeca.Enabled = False
        Me.sljedeca.Location = New System.Drawing.Point(392, 452)
        Me.sljedeca.Name = "sljedeca"
        Me.sljedeca.Size = New System.Drawing.Size(90, 40)
        Me.sljedeca.TabIndex = 6
        Me.sljedeca.Text = "Slijedeća"
        Me.sljedeca.UseVisualStyleBackColor = False
        '
        'IV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(844, 493)
        Me.Controls.Add(Me.sljedeca)
        Me.Controls.Add(Me.prethodna)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.izlaz)
        Me.Controls.Add(Me.ponisti)
        Me.Controls.Add(Me.prikaziSliku)
        Me.Controls.Add(Me.okviraSlika)
        Me.Name = "IV"
        Me.Text = "IViewer"
        CType(Me.okviraSlika, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents okviraSlika As PictureBox
    Friend WithEvents prikaziSliku As Button
    Friend WithEvents ponisti As Button
    Friend WithEvents izlaz As Button
    Friend WithEvents odaberi As OpenFileDialog
    Friend WithEvents Lista As ListBox
    Friend WithEvents prethodna As Button
    Friend WithEvents sljedeca As Button
End Class
