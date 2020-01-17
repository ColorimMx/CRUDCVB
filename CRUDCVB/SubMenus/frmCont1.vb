Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection


Public Class frmCont1

    Private Sub frmSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conf()

        Dim bColor = ColorTranslator.FromHtml("#b15dfF")
        Dim imgFondo As Object = imgFCont

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

        Me.Button1.Image = imgCont1
        Me.Button2.Image = imgCont2
        Me.Button3.Image = imgCont3
        Me.Button4.Image = imgCont4
        Me.Button5.Image = imgCont5
        Me.Button6.Image = imgCont6
        Me.Button7.Image = imgCont7
        Me.Button8.Image = imgCont8
        Me.Button9.Image = imgOpc
        Me.Button10.Image = imgSalir

        Me.Button1.Text = "Plan de Cuentas"
        Me.Button2.Text = "Diario Asientos"
        Me.Button3.Text = "Reporte"
        Me.Button4.Text = "Estados Financieros"
        Me.Button5.Text = "Fiscal"
        Me.Button6.Text = "Consultas Avanzadas"
        Me.Button7.Text = "Presupuesto Contable"
        Me.Button8.Text = "Analisis Cuentas"
        Me.Button9.Text = "Opiones"
        Me.Button10.Text = ""
    End Sub

    Sub conf()



        Dim conexion As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")
        Dim menus As New SqlCommand("SELECT USUARIOS.ID, USUARIOS.NOMBRE, USUARIOS.APELLIDO_P, USUARIOS.APELLIDO_M, USUARIOS.USUARIO, USUARIOS.ACCESO, M_CONTABILIDAD.CONT_1, " +
"M_CONTABILIDAD.CONT_2, M_CONTABILIDAD.CONT_3, M_CONTABILIDAD.CONT_4, M_CONTABILIDAD.CONT_5, M_CONTABILIDAD.CONT_6, M_CONTABILIDAD.CONT_7, " +
"M_CONTABILIDAD.CONT_8, M_CONTABILIDAD.CONT_9,M_CONTABILIDAD.CONT_7_7 FROM USUARIOS INNER JOIN M_CONTABILIDAD ON USUARIOS.ID = M_CONTABILIDAD.ID " +
"WHERE USUARIO = @usuario", conexion)

        menus.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Module1.nombre


        Dim adapMenus As New SqlDataAdapter(menus)
        Dim table As New DataTable()
        adapMenus.Fill(table)

        '********************************************************************************************************

        'Asignacion Variables a tablas Menus
        Dim nombre = table.Rows(0)(1).ToString()
        Dim apellido_p = table.Rows(0)(2).ToString()
        Dim apellido_m = table.Rows(0)(3).ToString()
        Dim acceso = table.Rows(0)(5).ToString()
        Dim mcon1 = table.Rows(0)(6).ToString()
        Dim mcon2 = table.Rows(0)(7).ToString()
        Dim mcon3 = table.Rows(0)(8).ToString()
        Dim mcon4 = table.Rows(0)(9).ToString()
        Dim mcon5 = table.Rows(0)(10).ToString()
        Dim mcon6 = table.Rows(0)(11).ToString()
        Dim mcon7 = table.Rows(0)(12).ToString()
        Dim mcon8 = table.Rows(0)(13).ToString()
        Dim mcon9 = table.Rows(0)(14).ToString()
        Dim mcon77 = table.Rows(0)(15).ToString()

        Module1.pre_com = mcon77

        If mcon1 = True Then
            Me.Button1.Enabled = True
        Else
            Me.Button1.Enabled = False
        End If

        If mcon2 = True Then
            Me.Button2.Enabled = True
        Else
            Me.Button2.Enabled = False
        End If

        If mcon3 = True Then
            Me.Button3.Enabled = True
        Else
            Me.Button3.Enabled = False
        End If

        If mcon4 = True Then
            Me.Button4.Enabled = True
        Else
            Me.Button4.Enabled = False
        End If

        If mcon5 = True Then
            Me.Button5.Enabled = True
        Else
            Me.Button5.Enabled = False
        End If

        If mcon6 = True Then
            Me.Button6.Enabled = True
        Else
            Me.Button6.Enabled = False
        End If

        If mcon7 = True Then
            Me.Button7.Enabled = True
        Else
            Me.Button7.Enabled = False
        End If

        If mcon8 = True Then
            Me.Button8.Enabled = True
        Else
            Me.Button8.Enabled = False
        End If

        If mcon9 = True Then
            Me.Button9.Enabled = True
        Else
            Me.Button9.Enabled = False
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        closeapp()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim mAdmin As New clsPnlFrm
        mAdmin.AbrirFormPanel(frmCont1_9_1)
        frmMenu.titulo.Text = "CONTABILIDAD/OPCIONES"
    End Sub
End Class