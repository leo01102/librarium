' Frontend

Imports System.Runtime.InteropServices

Public Class FormLogin
    Inherits Formulario

    Private login As Login ' declarar una instancia de la clase Ajustes

    ' constructor
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        login = New Login() ' inicializar la instancia de la clase Libros
    End Sub

    'Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'End Sub

    ' login
    Private Sub ibtnLogin_Click(sender As Object, e As EventArgs) Handles ibtnLogin.Click
        Dim usuario As String = htbcUsuario.Text
        Dim contrasena As String = htbcContrasena.Text
        login.Login(usuario, contrasena, Me)
    End Sub

    ' cancelar login (cerrar aplicación)
    Private Sub ibtnCancelarLogin_Click(sender As Object, e As EventArgs) Handles ibtnCancelarLogin.Click
        Me.Close() ' cerrar el formulario de inicio de sesión
    End Sub

    ' mostrar/ocultar contraseña
    Private Sub hcbMostrarContrasena_CheckedChanged(sender As Object, e As EventArgs) Handles hcbMostrarContrasena.CheckedChanged
        If htbcContrasena.UseSystemPasswordChar = True Then
            htbcContrasena.UseSystemPasswordChar = False ' ocultar contraseña
        Else
            htbcContrasena.UseSystemPasswordChar = True ' mostrar contraseña
        End If
    End Sub

    ' mover formulario
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub pnlLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlLogin.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

End Class