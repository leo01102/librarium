' Frontend

Public Class FormAjustes
    Inherits Formulario

    Private ajustes As Ajustes ' declarar una instancia de la clase Ajustes

    ' constructor
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ajustes = New Ajustes() ' inicializar la instancia de la clase Libros
    End Sub


    ' subrutinas privadas
    Private Sub ibtnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles ibtnAgregarUsuario.Click
        Dim usuario As String = htbcNuevoUsuario.Text
        Dim contrasena As String = htbcNuevoContrasena.Text

        ajustes.AgregarUsuario(usuario, contrasena)
    End Sub
    Private Sub ibtnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles ibtnEliminarUsuario.Click
        Dim usuario As String = htbcEliminarUsuario.Text
        Dim contrasena As String = htbcEliminarUsuarioContrasena.Text

        ajustes.EliminarUsuario(usuario, contrasena)
    End Sub
    Private Sub ibtnCambiarContrasena_Click(sender As Object, e As EventArgs) Handles ibtnCambiarContrasena.Click
        Dim usuario As String = htbcCambiarContrasenaUsuario.Text
        Dim contrasenaActual As String = htbcCambiarContrasenaActual.Text
        Dim contrasenaNueva As String = htbcCambiarContrasenaNueva.Text

        ajustes.CambiarContrasena(usuario, contrasenaActual, contrasenaNueva)
    End Sub

    ' mostrar y ocultar contraseñas
    Private Sub hcbMostrarContrasenaNuevo_CheckedChanged(sender As Object, e As EventArgs) Handles hcbMostrarContrasenaNuevo.CheckedChanged
        If hcbMostrarContrasenaNuevo.Checked Then
            htbcNuevoContrasena.UseSystemPasswordChar = False ' mostrar contraseña
        Else
            htbcNuevoContrasena.UseSystemPasswordChar = True ' ocultar contraseña
        End If
    End Sub
    Private Sub hcbMostrarContrasenaCambiarActual_CheckedChanged(sender As Object, e As EventArgs) Handles hcbMostrarContrasenaCambiarActual.CheckedChanged
        If hcbMostrarContrasenaCambiarActual.Checked Then
            htbcCambiarContrasenaActual.UseSystemPasswordChar = False ' mostrar contraseña
        Else
            htbcCambiarContrasenaActual.UseSystemPasswordChar = True ' ocultar contraseña
        End If
    End Sub
    Private Sub hcbMostrarContrasenaCambiarNueva_CheckedChanged(sender As Object, e As EventArgs) Handles hcbMostrarContrasenaCambiarNueva.CheckedChanged
        If hcbMostrarContrasenaCambiarNueva.Checked Then
            htbcCambiarContrasenaNueva.UseSystemPasswordChar = False ' mostrar contraseña
        Else
            htbcCambiarContrasenaNueva.UseSystemPasswordChar = True ' ocultar contraseña
        End If
    End Sub
    Private Sub hcbMostrarContrasenaEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles hcbMostrarContrasenaEliminar.CheckedChanged
        If hcbMostrarContrasenaEliminar.Checked Then
            htbcEliminarUsuarioContrasena.UseSystemPasswordChar = False ' mostrar contraseña
        Else
            htbcEliminarUsuarioContrasena.UseSystemPasswordChar = True ' ocultar contraseña
        End If
    End Sub
End Class