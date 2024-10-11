Imports MySql.Data.MySqlClient

Public Class Ajustes
    Inherits Database


    ' constructor
    Public Sub New()
    End Sub


#Region "Métodos privados"

    ' hashear contraseña
    Private Function HashPassword(password As String) As String
        ' crear instancia del algoritmo SHA-256 para encriptar la contraseña
        Using sha256 As New System.Security.Cryptography.SHA256Managed()
            ' convertir la contraseña ingresada (password) a un arreglo de bytes y codificarlo con UTF8
            Dim bytePassword As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            ' computar el hash de los bytes de la contraseña (bytePassword)
            Dim byteHashedPassword As Byte() = sha256.ComputeHash(bytePassword)
            ' convertir el hash byteHashedPassword a una cadena en formato Base64, para almacenarlo en la BD
            Dim hasedPassword As String = Convert.ToBase64String(byteHashedPassword)
            ' devolver la contraseña hasheada
            Return hasedPassword
        End Using
    End Function

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

    ' crear un nuevo usuario en la BD
    Public Sub AgregarUsuario(usuario As String, contrasena As String)
        ' hashear la contraseña ingresada antes de almacenarla en la base de datos
        Dim contrasenaHashed As String = HashPassword(contrasena)
        ' consulta SQL para insertar el nuevo usuario y su contraseña hasheada en la tabla 'login'
        Dim query = "INSERT INTO login (usuario, contrasena) VALUES (@usu, @contr)"
        ' conectarse a la base de datos
        Using connection = ConectarDatabase()
            ' crear un nuevo comando SQL con la consulta y la conexión
            Using command As New MySqlCommand(query, connection)
                ' agregar el parámetro para el nombre y contraseña del usuario para prevenir inyecciones SQL
                command.Parameters.Add("@usu", MySqlDbType.VarChar).Value = usuario
                command.Parameters.Add("@contr", MySqlDbType.VarChar).Value = contrasenaHashed
                ' intentar ejecutar el comando SQL para insertar el nuevo usuario en la base de datos
                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Usuario creado exitosamente.", "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error al crear el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' eliminar un usuario de la BD
    Public Sub EliminarUsuario(usuario As String, contrasena As String)
        ' consulta SQL para obtener la contraseña hasheada del usuario
        Dim query As String = "SELECT contrasena FROM login WHERE usuario = @usu"
        ' inicializar en vacío a la variable de almacenamiento de la contraseña hasheada del usuario
        Dim hashedPassword As String = String.Empty
        ' conectarse a la base de datos
        Using connection = ConectarDatabase()
            ' crear un nuevo comando SQL con la consulta y la conexión
            Using command As New MySqlCommand(query, connection)
                ' agregar el parámetro para el nombre de usuario
                command.Parameters.Add("@usu", MySqlDbType.VarChar).Value = usuario
                ' ejecutar el comando y leer el resultado
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' iniciar lectura
                    If reader.Read() Then
                        ' obtener contraseña hasheada del usuario
                        hashedPassword = reader("contrasena").ToString()
                    Else
                        MessageBox.Show("Usuario no encontrado.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using
            End Using
        End Using
        ' antes de eliminar el usuario, verificar si la contraseña ingresada coincide con la contraseña hasheada almacenada
        If Not VerificarHashedPassword(hashedPassword, contrasena) Then
            MessageBox.Show("Contraseña incorrecta.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' eliminar el usuario de la base de datos
        Dim deleteQuery As String = "DELETE FROM login WHERE usuario = @usu" ' consulta SQL para eliminar el usuario de la BD
        ' conectarse a la BD
        Using connection = ConectarDatabase()
            ' crear un nuevo comando SQL para la eliminación del usuario
            Using command As New MySqlCommand(deleteQuery, connection)
                ' agregar el parámetro para el nombre de usuario
                command.Parameters.Add("@usu", MySqlDbType.VarChar).Value = usuario
                ' intentar ejecutar el comando para eliminar el usuario y obtener el número de filas afectadas para saber si se eliminó
                Try
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario eliminado exitosamente.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Usuario no encontrado.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' cambiar contraseña de un usuario en la BD
    Public Sub CambiarContrasena(usuario As String, contrasenaActual As String, contrasenaNueva As String)
        ' consulta SQL para obtener la contraseña hasheada actual del usuario
        Dim query As String = "SELECT contrasena FROM login WHERE usuario = @usu"
        ' conectarse a la BD
        Using connection = ConectarDatabase()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.Add("@usu", MySqlDbType.VarChar).Value = usuario
                ' ejecutar command y leer el resultado
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' obtener la contraseña hasheada actual del usuario desde el resultado de la consulta
                        Dim hashedPassword As String = reader("contrasena").ToString()
                        ' verificar la contraseña actual del usuario antes de cambiarla
                        If Not VerificarHashedPassword(hashedPassword, contrasenaActual) Then
                            MessageBox.Show("Contraseña actual incorrecta.", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    Else
                        MessageBox.Show("Usuario no encontrado.", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using
            End Using
        End Using
        ' hashear la nueva contraseña antes de almacenarla
        Dim hashedNuevaContrasena As String = HashPassword(contrasenaNueva)
        ' consulta SQL para actualizar la contraseña en la base de datos
        Dim updateQuery As String = "UPDATE login SET contrasena = @contr WHERE usuario = @usu"
        Using connection = ConectarDatabase()
            Using command As New MySqlCommand(updateQuery, connection)
                ' agregar los parámetros para el nombre de usuario y la nueva contraseña hasheada
                command.Parameters.Add("@usu", MySqlDbType.VarChar).Value = usuario
                command.Parameters.Add("@contr", MySqlDbType.VarChar).Value = hashedNuevaContrasena
                ' intentar ejecutar el comando de actualización y obtener el número de filas afectadas para saber si se cambió la contraseña
                Try
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Contraseña actualizada exitosamente.", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Usuario no encontrado.", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al cambiar la contraseña: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

#End Region

End Class