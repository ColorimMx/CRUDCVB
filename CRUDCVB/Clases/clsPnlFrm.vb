Public Class clsPnlFrm
    'Sub AbrirFormPanel(Formhijo As Object)
    Sub AbrirFormPanel(frm As Form)
        If frmMenu.pnlContenedor.Controls.Count > 0 Then
            frmMenu.pnlContenedor.Controls.RemoveAt(0)
        End If
        frmMenu.pnlContenedor.Controls.Clear()

        frmMenu.titulo.Update()

        Dim fh As Form = frm
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        frmMenu.pnlContenedor.Controls.Add(fh)
        frmMenu.pnlContenedor.Tag = fh
        fh.Show()
        fh.Width = True

    End Sub

End Class
