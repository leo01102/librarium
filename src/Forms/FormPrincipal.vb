' Frontend

#Region "Importaciones"

Imports System.Runtime.InteropServices ' usar librerías del sistema
Imports FontAwesome.Sharp ' iconos de FontAwesome

#End Region


Public Class FormPrincipal
    Inherits Formulario

#Region "FormPrincipal_Load1"

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' abrir el FormDashboard por defecto
        OpenChildForm(New FormDashboard)
        ' activar ibtnDashboard por defecto
        ActivateButton(ibtnDashboard, Color.FromArgb(15, 106, 255))
    End Sub

#End Region


#Region "Eventos"

    Private Sub ibtnDashboard_Click(sender As Object, e As EventArgs) Handles ibtnDashboard.Click
        ActivateButton(sender, Color.FromArgb(15, 106, 255))
        OpenChildForm(New FormDashboard)
    End Sub
    Private Sub ibtnLibros_Click(sender As Object, e As EventArgs) Handles ibtnLibros.Click
        ActivateButton(sender, Color.FromArgb(15, 106, 255))
        OpenChildForm(New FormLibros)
    End Sub
    Private Sub ibtnClientes_Click(sender As Object, e As EventArgs) Handles ibtnClientes.Click
        ActivateButton(sender, Color.FromArgb(15, 106, 255))
        OpenChildForm(New FormClientes)
    End Sub
    Private Sub ibtnProveedores_Click(sender As Object, e As EventArgs) Handles ibtnProveedores.Click
        ActivateButton(sender, Color.FromArgb(15, 106, 255))
        OpenChildForm(New FormProveedores)
    End Sub
    Private Sub ibtnVentas_Click(sender As Object, e As EventArgs) Handles ibtnVentas.Click
        ActivateButton(sender, Color.FromArgb(15, 106, 255))
        OpenChildForm(New FormVentas)
    End Sub
    Private Sub ibtnAjustes_Click(sender As Object, e As EventArgs) Handles ibtnAjustes.Click
        ActivateButton(sender, Color.FromArgb(15, 106, 255))
        OpenChildForm(New FormAjustes)
    End Sub

#End Region


#Region "ChildForm"

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    ' constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        pnlMenu.Controls.Add(leftBorderBtn)
        ' formulario
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub


    ' métodos
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            ' Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(244, 248, 255)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            'currentBtn.TextAlign = ContentAlignment.MiddleCenter
            'currentBtn.ImageAlign = ContentAlignment.MiddleRight
            'currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            ' Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            '' current Form icon
            'IconCurrentForm.IconChar = currentBtn.IconChar
            'IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.White
            currentBtn.ForeColor = Color.Gray
            currentBtn.IconColor = Color.Gray
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub


    Private currentChildForm As Form = Nothing
    Private Sub OpenChildForm(childForm As Form)
        ' si existe un formulario abierto, cerrarlo
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm ' guardar formulario abierto

        childForm.TopLevel = False ' formulario hijo no es de nivel superior (se comporta como un control)
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        pnlChildForm.Controls.Add(childForm) ' agregar formulario hijo como un control en pnlChildForm
        pnlChildForm.Tag = childForm ' asociar formulario con el panel contenedor

        childForm.BringToFront() ' evitar superposiciones
        childForm.Show() ' mostrar formulario hijo
    End Sub

#End Region


#Region "Mover formulario, cerrar, maximizar, minimizar"

    ' mover formulario
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub pnlBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    ' cerrar, maximizar, minimizar
    Private Sub ibtnCerrar_Click(sender As Object, e As EventArgs) Handles ibtnCerrar.Click
        Application.Exit()
    End Sub
    Private Sub ibtnMaximizar_Click(sender As Object, e As EventArgs) Handles ibtnMaximizar.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub ibtnMinimizar_Click(sender As Object, e As EventArgs) Handles ibtnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    ' remove transparent border in maximized state
    Private Sub FormPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

#End Region


End Class