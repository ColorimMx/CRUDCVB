Imports System.Data
Imports System.Data.SqlClient

Public Class frmMenu

    Sub menus()

        Dim conexion As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")
        Dim menus As New SqlCommand("SELECT USUARIOS.ID, USUARIOS.NOMBRE, USUARIOS.APELLIDO_P, USUARIOS.APELLIDO_M, USUARIOS.USUARIO," +
                                    "USUARIOS.CONTRASENA, USUARIOS.ACCESO, MENUS.M_PROVEEDORES, MENUS.M_INVENTARIO," +
        "MENUS.M_BANCOS, MENUS.M_CLIENTES, MENUS.M_ACTIVO_FIJO, MENUS.M_CONTABILIDAD, MENUS.M_ADMINISTRADOR, " +
        "USUARIOS.DEPTO,USUARIOS.EMPRESA FROM USUARIOS INNER JOIN MENUS ON USUARIOS.ID = MENUS.ID WHERE USUARIO = @usuario", conexion)

        menus.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Module1.nombre


        Dim adapMenus As New SqlDataAdapter(menus)
        Dim table As New DataTable()
        adapMenus.Fill(table)

        '********************************************************************************************************

        'Asignacion Variables a tablas Menus
        Dim nombre = table.Rows(0)(1).ToString()
        Dim apellido_p = table.Rows(0)(2).ToString()
        Dim apellido_m = table.Rows(0)(3).ToString()
        Dim acceso = table.Rows(0)(6).ToString()
        Dim proveedores = table.Rows(0)(7).ToString()
        Dim inventario = table.Rows(0)(8).ToString()
        Dim bancos = table.Rows(0)(9).ToString()
        Dim clientes = table.Rows(0)(10).ToString()
        Dim activofij = table.Rows(0)(11).ToString()
        Dim contabilidad = table.Rows(0)(12).ToString()
        Dim administracion = table.Rows(0)(13).ToString()
        Dim dpto = table.Rows(0)(14).ToString()
        Dim empresa = table.Rows(0)(15).ToString()

        Module1.dptos = dpto

        If proveedores = True Then
            btnProv.Enabled = True
        Else
            btnProv.Enabled = False
        End If

        If inventario = True Then
            btnInvt.Enabled = True
        Else
            btnInvt.Enabled = False
        End If

        If bancos = True Then
            btnBanc.Enabled = True
        Else
            btnBanc.Enabled = False
        End If

        If clientes = True Then
            btnClie.Enabled = True
        Else
            btnClie.Enabled = False
        End If

        If activofij = True Then
            btnActF.Enabled = True
        Else
            btnActF.Enabled = False
        End If

        If contabilidad = True Then
            btnCont.Enabled = True
        Else
            btnCont.Enabled = False
        End If

        If administracion = True Then
            btnAdm.Enabled = True
        Else
            btnAdm.Enabled = False
        End If
    End Sub

    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Size = SystemInformation.PrimaryMonitorSize

        Me.MinimumSize = New Point(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Me.MaximumSize = New Point(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)

        Me.Width = My.Computer.Screen.Bounds.Width
        Me.Height = My.Computer.Screen.Bounds.Height

        menus()


        Me.BackColor = ColorTranslator.FromHtml("#c8f4ff")
        Me.pnlMenus.BackColor = ColorTranslator.FromHtml("#96c1cc") '616161
        Me.pnlTxt.BackColor = ColorTranslator.FromHtml("#67919b") '616161
        Me.pnlContenedor.BackColor = ColorTranslator.FromHtml("#c8f4ff") '#424242 #5e92f3

        Me.btnProv.Image = imgProv
        Me.btnProv.ImageAlign = ContentAlignment.TopCenter
        Me.btnProv.BackColor = ColorTranslator.FromHtml("#1EB980")
        Me.btnProv.Region = New Region(New Rectangle(3, 3, btnProv.Width - 6, btnProv.Height - 6))

        Me.btnInvt.Image = imgInvt
        Me.btnInvt.ImageAlign = ContentAlignment.TopCenter
        Me.btnInvt.BackColor = ColorTranslator.FromHtml("#045D56")
        Me.btnInvt.Region = New Region(New Rectangle(3, 3, btnInvt.Width - 6, btnInvt.Height - 6))

        Me.btnBanc.Image = imgBanc
        Me.btnBanc.ImageAlign = ContentAlignment.TopCenter
        Me.btnBanc.BackColor = ColorTranslator.FromHtml("#f73526")
        Me.btnBanc.Region = New Region(New Rectangle(3, 3, btnBanc.Width - 6, btnBanc.Height - 6))

        Me.btnClie.Image = imgClie
        Me.btnClie.ImageAlign = ContentAlignment.TopCenter
        Me.btnClie.BackColor = ColorTranslator.FromHtml("#f9aa33")
        Me.btnClie.Region = New Region(New Rectangle(3, 3, btnClie.Width - 6, btnClie.Height - 6))

        Me.btnActF.Image = imgActi
        Me.btnActF.ImageAlign = ContentAlignment.TopCenter
        Me.btnActF.BackColor = ColorTranslator.FromHtml("#7c2bcb")
        Me.btnActF.Region = New Region(New Rectangle(3, 3, btnActF.Width - 6, btnActF.Height - 6))

        Me.btnCont.Image = imgCont
        Me.btnCont.ImageAlign = ContentAlignment.TopCenter
        Me.btnCont.BackColor = ColorTranslator.FromHtml("#b15dfF")
        Me.btnCont.Region = New Region(New Rectangle(3, 3, btnCont.Width - 6, btnCont.Height - 6))

        Me.btnAdm.Image = imgAdmi
        Me.btnAdm.ImageAlign = ContentAlignment.TopCenter
        Me.btnAdm.BackColor = ColorTranslator.FromHtml("#f05545")
        Me.btnAdm.Region = New Region(New Rectangle(3, 3, btnAdm.Width - 6, btnAdm.Height - 6))

        Me.btnSalir.Image = imgSalir
        Me.btnSalir.ImageAlign = ContentAlignment.MiddleCenter
        Me.btnSalir.BackColor = ColorTranslator.FromHtml("#B71C1C")
        Me.btnSalir.Region = New Region(New Rectangle(3, 3, btnSalir.Width - 6, btnSalir.Height - 6))
    End Sub

    Private Sub btnProv_Click(sender As System.Object, e As System.EventArgs) Handles btnProv.Click
        Dim mProv As New clsPnlFrm
        mProv.AbrirFormPanel(frmProv1)
        Me.btnSalir.Visible = False

        Me.titulo.Text = "PROVEEDORES"

        Me.btnProv.Enabled = False
        Me.btnInvt.Enabled = True
        Me.btnBanc.Enabled = True
        Me.btnClie.Enabled = True
        Me.btnActF.Enabled = True
        Me.btnCont.Enabled = True
        Me.btnAdm.Enabled = True

    End Sub

    Private Sub btnInvt_Click(sender As System.Object, e As System.EventArgs) Handles btnInvt.Click
        Dim mInvt As New clsPnlFrm
        mInvt.AbrirFormPanel(frmInvt1)
        Me.btnSalir.Visible = False

        Me.titulo.Text = "INVENTARIOS"

        Me.btnProv.Enabled = True
        Me.btnInvt.Enabled = False
        Me.btnBanc.Enabled = True
        Me.btnClie.Enabled = True
        Me.btnActF.Enabled = True
        Me.btnCont.Enabled = True
        Me.btnAdm.Enabled = True

    End Sub

    Private Sub btnBanc_Click(sender As System.Object, e As System.EventArgs) Handles btnBanc.Click
        Dim mBanc As New clsPnlFrm
        mBanc.AbrirFormPanel(frmBanc1)
        Me.btnSalir.Visible = False

        Me.titulo.Text = "BANCOS"

        Me.btnProv.Enabled = True
        Me.btnInvt.Enabled = True
        Me.btnBanc.Enabled = False
        Me.btnClie.Enabled = True
        Me.btnActF.Enabled = True
        Me.btnCont.Enabled = True
        Me.btnAdm.Enabled = True

    End Sub

    Private Sub btnClie_Click(sender As System.Object, e As System.EventArgs) Handles btnClie.Click
        Dim mClie As New clsPnlFrm
        mClie.AbrirFormPanel(frmClie1)
        Me.btnSalir.Visible = False

        Me.titulo.Text = "CLIENTES"

        Me.btnProv.Enabled = True
        Me.btnInvt.Enabled = True
        Me.btnBanc.Enabled = True
        Me.btnClie.Enabled = False
        Me.btnActF.Enabled = True
        Me.btnCont.Enabled = True
        Me.btnAdm.Enabled = True

    End Sub

    Private Sub btnActF_Click(sender As System.Object, e As System.EventArgs) Handles btnActF.Click
        Dim mActf As New clsPnlFrm
        mActf.AbrirFormPanel(frmActF1)
        Me.btnSalir.Visible = False

        Me.titulo.Text = "ACTIVO FIJO"

        Me.btnProv.Enabled = True
        Me.btnInvt.Enabled = True
        Me.btnBanc.Enabled = True
        Me.btnClie.Enabled = True
        Me.btnActF.Enabled = False
        Me.btnCont.Enabled = True
        Me.btnAdm.Enabled = True
    End Sub

    Private Sub btnCont_Click(sender As System.Object, e As System.EventArgs) Handles btnCont.Click
        Dim mCont As New clsPnlFrm
        mCont.AbrirFormPanel(frmCont1)
        Me.btnSalir.Visible = False
        Me.titulo.Text = "CONTABILIDAD"

        Me.btnProv.Enabled = True
        Me.btnInvt.Enabled = True
        Me.btnBanc.Enabled = True
        Me.btnClie.Enabled = True
        Me.btnActF.Enabled = True
        Me.btnCont.Enabled = False
        Me.btnAdm.Enabled = True

    End Sub

    Private Sub btnAdm_Click(sender As System.Object, e As System.EventArgs) Handles btnAdm.Click
        Dim mAdmin As New clsPnlFrm
        mAdmin.AbrirFormPanel(frmAdmi1)
        Me.btnSalir.Visible = False

        Me.titulo.Text = "ADMINISTRADOR"

        Me.btnProv.Enabled = True
        Me.btnInvt.Enabled = True
        Me.btnBanc.Enabled = True
        Me.btnClie.Enabled = True
        Me.btnActF.Enabled = True
        Me.btnCont.Enabled = True
        Me.btnAdm.Enabled = False

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        closeapp()
    End Sub

End Class