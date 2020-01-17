Imports System.Reflection


Public Class frmCont1_9_1

    Private Sub frmSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bColor = ColorTranslator.FromHtml("#b15dfF")
        Dim imgFondo As Object = imgFOpci

        Me.BackColor = ColorTranslator.FromHtml("#c8f4ff")
        Me.BackgroundImage = imgFondo

        Me.Button1.Region = New Region(New Rectangle(3, 3, Button1.Width - 6, Button1.Height - 6))
        Me.Button2.Region = New Region(New Rectangle(3, 3, Button2.Width - 6, Button2.Height - 6))
        Me.Button3.Region = New Region(New Rectangle(3, 3, Button3.Width - 6, Button3.Height - 6))
        Me.Button4.Region = New Region(New Rectangle(3, 3, Button4.Width - 6, Button4.Height - 6))
        Me.Button5.Region = New Region(New Rectangle(3, 3, Button5.Width - 6, Button5.Height - 6))
        Me.Button6.Region = New Region(New Rectangle(3, 3, Button6.Width - 6, Button6.Height - 6))
        Me.Button7.Region = New Region(New Rectangle(3, 3, Button7.Width - 6, Button7.Height - 6))
        Me.Button8.Region = New Region(New Rectangle(3, 3, Button8.Width - 6, Button8.Height - 6))
        Me.Button9.Region = New Region(New Rectangle(3, 3, Button9.Width - 6, Button9.Height - 6))
        Me.Button10.Region = New Region(New Rectangle(3, 3, Button10.Width - 6, Button10.Height - 6))

        Me.Button1.ImageAlign = ContentAlignment.TopCenter
        Me.Button2.ImageAlign = ContentAlignment.TopCenter
        Me.Button3.ImageAlign = ContentAlignment.TopCenter
        Me.Button4.ImageAlign = ContentAlignment.TopCenter
        Me.Button5.ImageAlign = ContentAlignment.TopCenter
        Me.Button6.ImageAlign = ContentAlignment.TopCenter
        Me.Button7.ImageAlign = ContentAlignment.TopCenter
        Me.Button8.ImageAlign = ContentAlignment.TopCenter
        Me.Button9.ImageAlign = ContentAlignment.TopCenter
        Me.Button10.ImageAlign = ContentAlignment.MiddleCenter

        Me.Button1.BackColor = bColor
        Me.Button2.BackColor = bColor
        Me.Button3.BackColor = bColor
        Me.Button4.BackColor = bColor
        Me.Button5.BackColor = bColor
        Me.Button6.BackColor = bColor
        Me.Button7.BackColor = bColor
        Me.Button8.BackColor = bColor
        Me.Button9.BackColor = bColor
        Me.Button10.BackColor = bColor

        Me.Button1.Image = imgCont7
        Me.Button2.Image = imgOpc
        Me.Button3.Image = imgOpc
        Me.Button4.Image = imgOpc
        Me.Button5.Image = imgOpc
        Me.Button6.Image = imgOpc
        Me.Button7.Image = imgOpc
        Me.Button8.Image = imgOpc
        Me.Button9.Image = imgOpc
        Me.Button10.Image = imgRegresar

        Me.Button1.Text = "Presupuesto"
        Me.Button2.Text = "Submenu 2"
        Me.Button3.Text = "Submenu 3"
        Me.Button4.Text = "Submenu 4"
        Me.Button5.Text = "Submenu 5"
        Me.Button6.Text = "Submenu 6"
        Me.Button7.Text = "Submenu 7"
        Me.Button8.Text = "Submenu 8"
        Me.Button9.Text = "Submenu 9"
        Me.Button10.Text = ""

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim mCont As New clsPnlFrm
        mCont.AbrirFormPanel(frmCont1)
        frmMenu.titulo.Text = "CONTABILIDAD"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub
End Class