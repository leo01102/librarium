Imports MySql.Data.MySqlClient

Public Class Login
    Inherits Database


    ' constructor
    Public Sub New()
    End Sub


#Region "Métodos privados"

    ' verificar si la contraseña ingresada coincide con el hash almacenado
    Private Function VerificarHashedPassword(hashedPasswordDb As String, passwordUser As String) As Boolean
        ' crear una instancia del algoritmo SHA256 para computar el hash de la contraseña
        Using sha256 As New System.Security.Cryptography.SHA256Managed()
            ' convertir la contraseña ingresada (passwordUser) a un arreglo de bytes y codificarlo con UTF8
            Dim byteUtf8EncodedPasswordUser As Byte() = System.Text.Encoding.UTF8.GetBytes(passwordUser)
            ' computar el hash de los bytes de la contraseña (byteUtf8EncodedPasswordUser)
            Dim byteHashedPasswordUser As Byte() = sha256.ComputeHash(byteUtf8EncodedPasswordUser)
            ' convertir el hash byteHashedPasswordUser a una cadena en formato Base64, para compararlo con el hash almacenado en la BD (hashedPasswordDb)
            Dim hashedPasswordUser As String = Convert.ToBase64String(byteHashedPasswordUser)
            ' comparar el hash calculado (hashedPasswordUser) con el hash almacenado (hashedPasswordDb) y devolver el resultado
            Return hashedPasswordUser = hashedPasswordDb
        End Using
    End Function
    ' nota: hashedPasswordDb es la contraseña ya hasheada almacenada en la BD. passwordUser es la contraseña ingresada por el usuario

#End Region


#Region "Métodos públicos"

    ' subrutina para iniciar sesión
    Public Sub Login(usuario As String, contrasena As String, formulario As Form)
        ' consulta SQL para obtener la contraseña hasheada del usuario
        Dim query As String = "SELECT contrasena FROM login WHERE usuario = @usu"
        ' crear la conexión y el comando con parámetros
        Using connection = ConectarDatabase()
            Using command As New MySqlCommand(query, connection)
                ' agregar parametros para prevenir inyecciones SQL, declarando la variable (parametro) @usu para encapsular su valor (nombre del usuario)
                command.Parameters.Add("@usu", MySqlDbType.VarChar).Value = usuario
                ' ejecutar el comando y leer el resultado
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim hashedPassword As String = reader("contrasena").ToString()
                        If VerificarHashedPassword(hashedPassword, contrasena) Then ' si la contraseña ingresada coincide con la almacenada
                            MessageBox.Show("Inicio de sesión exitoso.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim formPrincipal As New FormPrincipal() ' crear instancia del formulario principal y mostrarlo
                            formulario.Hide() ' ocultar el formulario de login
                            formPrincipal.ShowDialog() ' mostrar el formulario principal como diálogo modal
                            formulario.Close() ' cuando se cierre el formulario principal, cerrar también el formulario de login
                        Else
                            MessageBox.Show("El usuario o la contraseña son incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("El usuario o la contraseña son incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        End Using
    End Sub

#End Region

End Class