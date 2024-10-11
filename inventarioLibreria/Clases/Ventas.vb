Imports MySql.Data.MySqlClient
Imports ReaLTaiizor.Controls

Public Class Ventas
    Inherits Database


#Region "Atributos"

    ' campos
    Private tablaDatabase As String = "ventas"
    Private tablaDataSet As String = "TablaVentas"
    ' propiedades
    Public Property dataSet As DataSet
    Public Property dataAdapter As MySqlDataAdapter
    Public Property dataView As DataView
    Public Property nombresControlesVentas As String()
    Public Property controlesColumnasVentas As New Dictionary(Of String, String)
    Public Property precio As Decimal
    Public Property stock As Integer

#End Region


    ' constructor
    Public Sub New()
    End Sub


#Region "Métodos privados"

    ' cargar datos y DataView
    Private Sub CargarData()
        ' conexión a la base de datos, DataAdapter, DataSet
        Using conexion = ConectarDatabase()
            Dim query As String = $"SELECT v.id, CONCAT(c.nombre, ' ', c.apellido, ' (', c.id, ')') AS nombreCompletoCliente, v.idCliente, l.nombre AS nombreLibro, v.idLibro, v.fechaVenta, v.cantidad, v.precio, l.precio AS precioTablaLibros " &
                              $"FROM {tablaDatabase} v " &
                              $"INNER JOIN clientes c ON v.idCliente = c.id " &
                              $"INNER JOIN libros l ON v.idLibro = l.id"
            Dim resultadoTupla = CargarDataSetAdapter(conexion, tablaDataSet, query)
            dataSet = resultadoTupla.Item1 ' DataSet
            dataAdapter = resultadoTupla.Item2 ' MySqlDataAdapter
        End Using
        If dataSet Is Nothing OrElse dataAdapter Is Nothing Then
            MessageBox.Show("Error al cargar el DataSet o el DataAdapter.")
            Return
        End If

        ' DataView
        dataView = CargarDataGridView(dataSet, tablaDataSet)
    End Sub


    ' controles 
    ' para la validación de entradas
    Private Sub ControlesFormVentas()
        ' nombres de los controles
        nombresControlesVentas = {
            "htbcCliente",
            "htbcLibro",
            "pdtpFechaVenta",
            "hnudPrecio",
            "hnudCantidad"
        }
    End Sub
    ' diccionarios
    Private Sub InicilizarDiccionarios()
        ' diccionario para cargar datos, con nombres de los controles del formulario y su respectiva columna en la base de datos
        controlesColumnasVentas = New Dictionary(Of String, String) From {
            {"htbcCliente", "nombreCompletoCliente"},
            {"htbcLibro", "nombreLibro"},
            {"pdtpFechaVenta", "fechaVenta"},
            {"hnudPrecio", "precioTablaLibros"},
            {"hnudCantidad", "cantidad"}
        }
    End Sub


    Public Function BuscarStockPrecio(idLibro As Integer, precio As Decimal, cantidad As Integer) As Boolean
        ' variables locales para la validación
        Dim stockActual As Integer
        Dim precioLibro As Decimal
        ' conexión a la base de datos
        Using conexion = ConectarDatabase()
            ' consultar stock y precio del libro
            Dim queryStock As String = "SELECT stock, precio FROM libros WHERE id = @idLibro"
            Using cmd As New MySqlCommand(queryStock, conexion)
                cmd.Parameters.AddWithValue("@idLibro", idLibro)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    stockActual = reader.GetInt32("stock")
                    precioLibro = reader.GetDecimal("precio")
                End If
                reader.Close()
            End Using
            ' validar que la cantidad no supere el stock
            If cantidad > stockActual Then
                MessageBox.Show("La cantidad a vender excede el stock disponible del libro.", "Falta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            ' validar que el precio coincida
            If precio <> precioLibro Then
                MessageBox.Show("El precio de venta no coincide con el precio del libro.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End Using
        Return True ' True si la cantidad no supera el stock y el precio coincide
    End Function

#End Region


#Region "Métodos públicos"

    Public Function ObtenerPrecioStockLibro(nombreLibro As String) As (Decimal, Integer)
        precio = 0
        stock = 0
        ' obtener el ID del libro usando el nombre proporcionado
        Dim idLibro As Integer = ObtenerId(nombreLibro, "libros", "nombre")
        ' si se encontró el libro
        If idLibro > 0 Then
            Using conexion = ConectarDatabase()
                Dim query As String = "SELECT precio, stock FROM libros WHERE id = @idLibro"
                Using comando As New MySqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@idLibro", idLibro)
                    Dim reader = comando.ExecuteReader()
                    If reader.Read() Then
                        If Decimal.TryParse(reader("precio").ToString(), precio) AndAlso Integer.TryParse(reader("stock").ToString(), stock) Then
                            Return (precio, stock)
                        End If
                    End If
                End Using
            End Using
        End If
        ' si no se encuentra el libro
        MessageBox.Show($"No se encontró el libro {nombreLibro}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return (precio, stock)
    End Function


    Public Sub LoadData()
        CargarData()
        ControlesFormVentas()
        InicilizarDiccionarios()
    End Sub

#End Region


End Class