Imports System.IO
Public Class IV
    Private Sub prikaziSliku_Click() Handles prikaziSliku.Click
        'OpenFileDialog1.Multiselect = True
        If odaberi.ShowDialog() = DialogResult.OK Then
            okviraSlika.Load(odaberi.FileName)
            i = 0
            Me.Lista.Items.Clear()
            For Each slika As String In odaberi.FileNames
                Me.Lista.Items.Add(slika)
                i += 1
            Next
            prethodna.Enabled = True
            sljedeca.Enabled = True
            ponisti.Enabled = True
            'Me.okviraSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        End If
        If i > 0 Then
            Lista.SelectedIndex = 0
        Else
            Me.Lista.Items.Add("Folder je prazan")
        End If
    End Sub
    Private Sub ponisti_Click() Handles ponisti.Click
        prethodna.Enabled = False
        sljedeca.Enabled = False
        ponisti.Enabled = False

        Lista.Items.Clear()
        okviraSlika.Image = Nothing
    End Sub
    Private Sub izlaz_Click() Handles izlaz.Click
        Close()
    End Sub
    Dim i As Integer
    Private Sub sljedeca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sljedeca.Click
        Me.okviraSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Try
            If Lista.SelectedIndex < i Then
                Lista.SelectedIndex += 1
                okviraSlika.Load(Lista.SelectedItem)
            Else
                okviraSlika.Load(Lista.SelectedItem)
                'MsgBox("Ovo je zadnja slika", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            okviraSlika.Load(Lista.SelectedItem)
            'MsgBox("Nema više slika", MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub prethodna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prethodna.Click
        Me.okviraSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        If Lista.SelectedIndex > 0 Then
            Try
                Lista.SelectedIndex -= 1
                okviraSlika.Load(Lista.SelectedItem)
            Catch ex As Exception
                okviraSlika.Load(Lista.SelectedItem)
                'MsgBox("Nema dalje", MsgBoxStyle.OkOnly)
            End Try
        Else
            okviraSlika.Load(Lista.SelectedItem)
            'MsgBox("Prva slika", MsgBoxStyle.OkOnly)
        End If
    End Sub

End Class
