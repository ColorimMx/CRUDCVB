Imports System.Reflection


Public Class frmActF1

    Private Sub frmSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim bColor = ColorTranslator.FromHtml("#7c2bcb")
        Dim imgFondo As Object = imgFActi

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

        Me.Button10.Image = imgSalir

        Me.Button1.Text = "ACTIVO 1"
        Me.Button2.Text = "ACTIVO 2"
        Me.Button3.Text = "ACTIVO 3"
        Me.Button4.Text = "ACTIVO 4"
        Me.Button5.Text = "ACTIVO 5"
        Me.Button6.Text = "ACTIVO 6"
        Me.Button7.Text = "ACTIVO 7"
        Me.Button8.Text = "ACTIVO 8"
        Me.Button9.Text = "ACTIVO 9"
        Me.Button10.Text = ""

    End Sub

End Class