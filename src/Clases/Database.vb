' Backend

Imports MySql.Data.MySqlClient

Public Class Database
    Implements IDatabase

    ' conexion a la BD
    Public ReadOnly connectionString As String
    ' constructor
    Public Sub New()
        connectionString = "Server=localhost; Database=libreria; Uid=root; Pwd=;"
    End Sub
    ' conectarse a la BD
    Public Function ConectarDatabase() As MySqlConnection Implements IDatabase.ConectarDatabase
        Dim conexion As MySqlConnection = Nothing
        Try
            conexion = New MySqlConnection(connectionString)
            conexion.Open()
            Return conexion
        Catch ex As MySqlException
            MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' devolver Nothing o lanzar una excepción según la lógica de tu aplicación
            Return Nothing
        End Try
    End Function

    ' cargar DataSet
    Public Function CargarDataSetAdapter(conexion As MySqlConnection, tablaDataSet As String, query As String) As (DataSet, MySqlDataAdapter) Implements IDatabase.CargarDataSetAdapter
        ' DataSet
        Dim dSet = New DataSet() ' crear una nueva instancia de DataSet
        dSet.Tables.Add(tablaDataSet) ' añadir una nueva tabla al DataSet con tablaDataSet
        ' DataAdapter
        Dim dAdapter = New MySqlDataAdapter() ' crear una nueva instancia de MySqlDataAdapter
        dAdapter.SelectCommand = New MySqlCommand(query, conexion) ' configurar comando SELECT del DataAdapter con query y conexion
        dAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey ' añadir clave primaria al DataSet si no tiene una
        dAdapter.Fill(dSet.Tables(tablaDataSet)) ' con .Fill tomar los datos obtenidos con .SelectCommand para insertarlos en la tabla dSet.Tables(tablaDataSet)

        Return (dSet, dAdapter)
    End Function

    ' cargar DataGridView
    Public Function CargarDataGridView(dSet As DataSet, tablaDataSet As String) Implements IDatabase.CargarDataGridView
        Dim dataView As DataView
        dataView = dSet.Tables(tablaDataSet).DefaultView ' inicializar dataView con la tabla tablaDataSet del DataSet dSet

        Return dataView
    End Function

    ' insertar registro: cargar datos para el nuevo registro (fila)
    Public Sub InsertarRegistro(tablaDatabase As String, tablaDataSet As String, datosFilas As Hashtable) Implements IDatabase.InsertarRegistro
        Using conexion = ConectarDatabase()
            ' cargar DataSet y DataAdapter
            Dim query As String = $"SELECT * FROM {tablaDatabase}"
            Dim dataSet As New DataSet()
            Dim dataAdapter As New MySqlDataAdapter(query, conexion)
            ' inicializar comando para insertar
            Dim updateCommand As New MySqlCommandBuilder(dataAdapter) ' crear comando de actualización para DataAdapter
            dataAdapter.InsertCommand = updateCommand.GetInsertCommand() ' inicializar .InsertCommand con .GetInsertCommand()
            ' cargar el DataSet
            dataAdapter.Fill(dataSet, tablaDataSet)
            ' crear una nueva fila
            Dim fila As DataRow = dataSet.Tables(tablaDataSet).NewRow()
            If fila Is Nothing Then
                MessageBox.Show($"Error al insertar registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            ' llenar la fila con los datos del diccionario datosFilas
            For Each key As String In datosFilas.Keys ' iterar sobre cada clave de datosFilas
                ' verificar si la columna existe en el DataSet
                If dataSet.Tables(tablaDataSet).Columns.Contains(key) Then ' si tablaDataSet contiene una columna con el nombre que almacena key, entonces ...
                    fila(key) = datosFilas(key) ' inicializar la fila con la clave key con el dato con la misma clave
                Else
                    MessageBox.Show($"La columna '{key}' no existe en el DataSet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next
            ' agregar fila al DataSet
            dataSet.Tables(tablaDataSet).Rows.Add(fila)
            ' guardar los cambios en la base de datos
            dataAdapter.Update(dataSet, tablaDataSet)
            ' volver a cargar la tabla del DataSet para obtener los últimos cambios de la BD
            dataSet.Tables(tablaDataSet).Clear()
            dataAdapter.Fill(dataSet, tablaDataSet)
        End Using
    End Sub

    ' editar registro (fila) existente
    Public Sub EditarRegistro(tablaDatabase As String, tablaDataSet As String, idFila As Integer, datosFilas As Hashtable) Implements IDatabase.EditarRegistro
        Using conexion = ConectarDatabase()
            ' cargar DataSet y DataAdapter
            Dim dataSet As New DataSet()
            Dim dataAdapter As New MySqlDataAdapter()
            Dim query As String = $"SELECT * FROM {tablaDatabase}"
            Dim resultadoTupla = CargarDataSetAdapter(conexion, tablaDataSet, query)
            dataSet = resultadoTupla.Item1 ' DataSet
            dataAdapter = resultadoTupla.Item2 ' MySqlDataAdapter
            ' seleccionar la fila del DataSet seleccionada por el usuario (idFila) para editarla
            Dim fila As DataRow = dataSet.Tables(tablaDataSet).Rows.Find(idFila)
            If fila IsNot Nothing Then
                ' rellenar la fila con su respectivo dato de datosFilas
                For Each key As String In datosFilas.Keys
                    fila(key) = datosFilas(key)
                Next
                ' crear comando para editar la fila de la base de datos
                Dim setClause As String = String.Join(", ", datosFilas.Keys.Cast(Of String).Select(Function(k) $"{k}=@{k}")) ' inicializar la cláusula SET para el comando SQL 'cmd'
                ' datosFilas.Keys : obtener las claves del Hashtable datosFilas
                ' Cast(Of String) : convertir datosFilas.Keys a tipo String
                ' Select(...) : Select() toma cada clave para convertirla con el formato "{k}=@{k}"
                ' Function(k) $"{k}=@{k}" : función lambda (sin nombre) que toma la clave 'k' y devuelve la cadena $"{k}=@{k}" donde 'k' es una clave de datosFilas y '@{k}' es el parámetro para el comando SQL. Ejemplo: si la clave es "nombre", la función devuelve "nombre=@nombre"
                ' String.Join(", ", ...) : concatenar la cadena ", " con la cadena "..."
                Dim cmd As String = $"UPDATE {tablaDatabase} SET {setClause} WHERE id=@id" ' comando SQL para actualizar la fila especificada en la tabla
                ' DataAdapter
                dataAdapter.UpdateCommand = New MySqlCommand(cmd, conexion) ' asignar el comando al DataAdapter
                For Each key As String In datosFilas.Keys
                    dataAdapter.UpdateCommand.Parameters.Add("@" & key, GetMySqlDbType(datosFilas(key).GetType()), 0, key) ' agregar los parámetros Parameters al comando de actualización
                Next
                dataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id") ' agregar el parámetro para el ID al comando de actualización
                dataAdapter.Update(dataSet.Tables(tablaDataSet)) ' guardar cambios en la base de datos
            Else
                Throw New Exception("Registro no encontrado.") ' manejar el caso en que la fila no se encuentre
            End If
        End Using
    End Sub

    ' borrar registro
    Public Function BorrarRegistro(tablaDatabase As String, tablaDataSet As String, id As Long, nombreCampoID As String) As Boolean Implements IDatabase.BorrarRegistro
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de borrar el registro?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If confirmacion = DialogResult.Yes Then
            Try
                Using conexion = ConectarDatabase()
                    ' cargar DataSet y DataAdapter
                    Dim dataSet As New DataSet()
                    Dim dataAdapter As New MySqlDataAdapter()
                    Dim query As String = $"SELECT * FROM {tablaDatabase}"
                    Dim resultadoTupla = CargarDataSetAdapter(conexion, tablaDataSet, query)
                    dataSet = resultadoTupla.Item1 ' DataSet
                    dataAdapter = resultadoTupla.Item2 ' MySqlDataAdapter
                    ' eliminar fila del DataSet
                    dataSet.Tables(tablaDataSet).Rows.Find(id).Delete()
                    ' eliminar fila de la base de datos a través del DataAdapter
                    dataAdapter.DeleteCommand = New MySqlCommand($"DELETE FROM {tablaDatabase} WHERE {nombreCampoID} = @id", conexion) ' definir comando SQL para eliminar el registro en la base de datos
                    dataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "id") ' agregar al comando SQL el parámetro identificador del registro a eliminar
                    dataAdapter.Update(dataSet.Tables(tablaDataSet)) ' aplicar cambios en el DataSet a la BD ejecutando el comando antes definido
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If
        Return False
    End Function

    ' entrada: tipo de dato Type en VB.NET. salida: tipo de dato MySqlDbType equivalente en MySQL
    Public Function GetMySqlDbType(t As Type) As MySqlDbType Implements IDatabase.GetMySqlDbType
        Select Case Type.GetTypeCode(t)
            Case TypeCode.String ' si el dato VB.NET es String, se devuelve su equivalente en MySQL que es VarChar
                Return MySqlDbType.VarChar
            Case TypeCode.DateTime
                Return MySqlDbType.Date
            Case TypeCode.Decimal
                Return MySqlDbType.Decimal
            Case TypeCode.Int32
                Return MySqlDbType.Int32
            Case Else
                Return MySqlDbType.VarChar ' por defecto
        End Select
    End Function

    ' obtener IDs
    Public Function ObtenerId(nombre As String, tablaDatabase As String, campo As String) As Integer Implements IDatabase.ObtenerId
        Dim id As Integer = -1
        ' eliminar el ID entre paréntesis si existe (solo existe cuando el campo se carga automáticamente)
        Dim indexParentesis As Integer = nombre.LastIndexOf("(") ' encontrar la posición del último paréntesis en el nombre
        Dim nombreSinId As String = nombre ' inicializar nombreSinId con el valor original de nombre
        If indexParentesis >= 0 Then ' si se encuentra un paréntesis en el nombre
            nombreSinId = nombre.Substring(0, indexParentesis).Trim() ' quitar el ID entre paréntesis y eliminar espacios en blanco
        End If
        ' hallar id
        Using conexion = ConectarDatabase()
            Dim query As String = $"SELECT id FROM {tablaDatabase} WHERE {campo} = @nombreCompleto"
            Using comando As New MySqlCommand(query, conexion) ' crear un comando SQL con la consulta y la conexión
                comando.Parameters.AddWithValue("@nombreCompleto", nombreSinId) ' agregar el parámetro para la consulta SQL con el valor del nombre sin ID
                Dim resultado = comando.ExecuteScalar() ' ejecutar la consulta y obtener el primer valor de la primera fila del resultado
                Dim idTemp As Integer ' variable temporal para almacenar el ID obtenido
                If resultado IsNot Nothing AndAlso Integer.TryParse(resultado.ToString(), idTemp) Then ' si resultado contiene un valor y ese valor es entero (se pudo convertir a entero éxitosamente y se guardó en idTemp)
                    id = idTemp ' asignar el valor convertido a la variable id
                End If
            End Using
        End Using
        ' verificar que se encontró la ID
        If id = -1 Then ' si id sigue siendo -1, no se encontró la id
            MessageBox.Show($"{nombre} no existe.{Environment.NewLine}Revise el nombre o creelo si es nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return id
    End Function

End Class