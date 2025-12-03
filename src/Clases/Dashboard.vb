' backend
' importaciones
Imports MySql.Data.MySqlClient
Imports System.Globalization


#Region "Estructuras"

Public Structure IngresosPorFecha
    Public Property Fecha As String
    Public Property TotalIngresos As Decimal
End Structure

Public Structure VentasPorFecha
    Public Property Fecha As String
    Public Property CantidadVentas As Integer
End Structure

#End Region


Public Class Dashboard
    Inherits Database


#Region "Atributos"

    ' campos
    Private fechaInicio As Date
    Private fechaFin As Date
    Private numeroDias As Integer
    ' propiedades
    Public Property cantidadClientes As Integer
    Public Property cantidadProveedores As Integer
    Public Property cantidadLibros As Integer
    Public Property cantidadVentas As Integer
    Public Property cantidadIngresos As Decimal
    Public Property ListaLibrosMasVendidos As List(Of KeyValuePair(Of String, Integer))
    Public Property ListaCantidadVentas As List(Of VentasPorFecha)
    Public Property ListaIngresos As List(Of IngresosPorFecha)
    Public Property ListaIngresosSegunLibros As List(Of KeyValuePair(Of String, Decimal))
    Public Property IngresoPromedioPorVenta As Decimal

#End Region


    ' constructor
    Public Sub New()
    End Sub


#Region "metodos privados"

    Private Sub ObtenerTotales()
        Using conexion = ConectarDatabase()
            Using command = New MySqlCommand
                command.Connection = conexion
                ' total de clientes
                command.CommandText = "SELECT COUNT(id) FROM clientes" ' consultar el total de clientes en la BD
                cantidadClientes = CInt(command.ExecuteScalar()) ' obtener resultado de la consulta y convertirlo a entero

                ' total de proveedores
                command.CommandText = "SELECT COUNT(id) FROM proveedores"
                cantidadProveedores = CInt(command.ExecuteScalar())

                ' total de libros
                command.CommandText = "SELECT COUNT(id) FROM libros"
                cantidadLibros = CInt(command.ExecuteScalar())

                ' total de ventas
                command.CommandText = "SELECT COUNT(id) FROM ventas WHERE fechaVenta BETWEEN @fromDate AND @toDate"
                command.Parameters.Add("@fromDate", MySqlDbType.Date).Value = fechaInicio
                command.Parameters.Add("@toDate", MySqlDbType.Date).Value = fechaFin
                cantidadVentas = Convert.ToInt32(command.ExecuteScalar())

                ' total de ingresos
                command.CommandText = "SELECT SUM(precio) FROM ventas WHERE fechaVenta BETWEEN @fromDate2 AND @toDate2"
                command.Parameters.Add("@fromDate2", MySqlDbType.Date).Value = fechaInicio
                command.Parameters.Add("@toDate2", MySqlDbType.Date).Value = fechaFin
                cantidadIngresos = Convert.ToDecimal(command.ExecuteScalar())

                ' calcular ingreso promedio por venta
                If cantidadVentas > 0 Then
                    IngresoPromedioPorVenta = cantidadIngresos / cantidadVentas
                Else
                    IngresoPromedioPorVenta = 0 ' evitar división por cero
                End If
            End Using
        End Using
    End Sub

    Private Sub ObtenerAnalisisLibros()
        ' inicializar listas para almacenar los resultados
        ListaLibrosMasVendidos = New List(Of KeyValuePair(Of String, Integer))()
        ListaIngresosSegunLibros = New List(Of KeyValuePair(Of String, Decimal))()
        ' conectarse a la BD
        Using conexion = ConectarDatabase()
            Using command = New MySqlCommand
                Dim reader As MySqlDataReader
                command.Connection = conexion
                ' los cinco libros mas vendidos
                command.CommandText = "SELECT L.nombre, SUM(ventas.cantidad) AS C " &
                                      "FROM ventas " &
                                      "INNER JOIN libros L ON L.id = ventas.idLibro " &
                                      "WHERE fechaVenta BETWEEN @fromDate AND @toDate " &
                                      "GROUP BY L.nombre " &
                                      "ORDER BY C DESC " &
                                      "LIMIT 5"
                command.Parameters.Add("@fromDate", MySqlDbType.Date).Value = fechaInicio ' establecer el parámetro de fecha de inicio ingresado por el usuario
                command.Parameters.Add("@toDate", MySqlDbType.Date).Value = fechaFin ' establecer el parámetro de fecha de fin ingresado por el usuario
                reader = command.ExecuteReader() ' ejecutar la consulta y obtener un lector de datos
                While reader.Read() ' leer los resultados y agregarlos a la lista de libros más vendidos
                    ListaLibrosMasVendidos.Add(New KeyValuePair(Of String, Integer)(reader(0).ToString(), CInt(reader(1))))
                End While
                reader.Close() ' cerrar el lector de datos

                ' ingresos segun libros
                command.CommandText = "SELECT L.nombre, SUM(ventas.precio) AS Total " &
                                      "FROM ventas " &
                                      "INNER JOIN libros L ON L.id = ventas.idLibro " &
                                      "WHERE fechaVenta BETWEEN @fromDate2 AND @toDate2 " &
                                      "GROUP BY L.nombre " &
                                      "ORDER BY Total DESC"
                command.Parameters.Add("@fromDate2", MySqlDbType.Date).Value = fechaInicio ' establecer el parámetro de fecha de inicio para ingresos ingresado por el usuario
                command.Parameters.Add("@toDate2", MySqlDbType.Date).Value = fechaFin ' establecer el parámetro de fecha de fin para ingresos ingresado por el usuario
                reader = command.ExecuteReader() ' ejecutar la consulta y obtener un lector de datos
                While reader.Read() ' leer los resultados y agregarlos a la lista de ingresos según libros
                    ListaIngresosSegunLibros.Add(New KeyValuePair(Of String, Decimal)(reader(0).ToString(), CDec(reader(1))))
                End While
                reader.Close() ' cerrar el lector de datos
            End Using
        End Using
    End Sub

    Private Sub ObtenerVentasPorFecha()
        ' inicializar listas para almacenar los resultados
        ListaIngresos = New List(Of IngresosPorFecha)()
        ListaCantidadVentas = New List(Of VentasPorFecha)()
        ' conectarse a la BD
        Using conexion = ConectarDatabase()
            Using command = New MySqlCommand()
                Dim reader As MySqlDataReader
                command.Connection = conexion
                ' consulta SQL para obtener cantidad de ventas e ingresos por fecha
                command.CommandText = "SELECT fechaVenta AS Fecha, SUM(cantidad) AS TotalCantidad, SUM(precio) AS TotalIngresos " &
                                      "FROM ventas " &
                                      "WHERE fechaVenta BETWEEN @fromDate AND @toDate " &
                                      "GROUP BY fechaVenta"
                command.Parameters.Add("@fromDate", MySqlDbType.Date).Value = fechaInicio ' establecer el parámetro de fecha de inicio ingresado por el usuario
                command.Parameters.Add("@toDate", MySqlDbType.Date).Value = fechaFin ' establecer el parámetro de fecha de fin ingresado por el usuario
                ' ejecutar la consulta y obtener un lector de datos
                reader = command.ExecuteReader()

                ' inicializar una lista para almacenar ventas agrupadas por fecha (cada entrada contiene una fecha y una tupla con la cantidad de ventas y el total de ingresos)
                Dim ventasTable = New List(Of KeyValuePair(Of Date, Tuple(Of Integer, Decimal)))()

                ' leer los datos y agregarlos a la lista ventasTable
                While reader.Read()
                    Dim fecha As Date = CDate(reader("Fecha")) ' obtener la fecha de venta
                    Dim cantidadVentas As Integer = CInt(reader("TotalCantidad")) ' obtener la cantidad total de ventas
                    Dim totalIngresos As Decimal = CDec(reader("TotalIngresos")) ' obtener el total de ingresos
                    ' agregar a ventasTable
                    ventasTable.Add(New KeyValuePair(Of Date, Tuple(Of Integer, Decimal))(fecha, Tuple.Create(cantidadVentas, totalIngresos)))
                    ' crear una instancia de IngresosPorFecha y agregar a ListaIngresos
                    Dim ingresoPorFecha As New IngresosPorFecha With {
                        .Fecha = fecha.ToString("yyyy-MM-dd"),
                        .TotalIngresos = totalIngresos
                    }
                    ListaIngresos.Add(ingresoPorFecha) ' agregar a ListaIngresos
                End While
                reader.Close() ' cerrar el lector de datos

                ' calcular el número de días en el intervalo
                numeroDias = (fechaFin - fechaInicio).Days

                ' agrupar y llenar ListaCantidadVentas y ListaIngresos según el número de días en el intervalo
                Select Case numeroDias
                    Case <= 30 ' agrupar por día si el intervalo es de 30 días o menos
                        ListaCantidadVentas = (From item In ventasTable ' iterar sobre cada elemento en la colección ventasTable
                                               Group item By Key = item.Key.ToString("dd MMM") Into Group ' agrupar elementos de ventasTable por fecha, formateada como "dd MMM" (día y mes)
                                               Select New VentasPorFecha With { ' seleccionar una nueva instancia de VentasPorFecha para cada grupo
                                                   .Fecha = Key, ' asignar la fecha del grupo en formato "dd MMM"
                                                   .CantidadVentas = Group.Sum(Function(i) i.Value.Item1) ' calcular la suma de la cantidad de ventas para cada grupo, esto se hace con una función lambda (función anónima y sin nombre)
                                               }).ToList() ' convertir el resultado de la consulta en una lista
                        ListaIngresos = (From item In ventasTable
                                         Group item By Key = item.Key.ToString("dd MMM") Into Group
                                         Select New IngresosPorFecha With {
                                             .Fecha = Key,
                                             .TotalIngresos = Group.Sum(Function(i) i.Value.Item2)
                                         }).ToList()
                    Case <= 92 ' agrupar por semana si el intervalo es de hasta 3 meses
                        ListaCantidadVentas = (From item In ventasTable
                                               Let weekNumber = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(item.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                               Group item By Key = "Week " & weekNumber Into Group
                                               Select New VentasPorFecha With {
                                                   .Fecha = Key,
                                                   .CantidadVentas = Group.Sum(Function(i) i.Value.Item1)
                                               }).ToList()
                        ListaIngresos = (From item In ventasTable
                                         Let weekNumber = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(item.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                         Group item By Key = "Week " & weekNumber Into Group
                                         Select New IngresosPorFecha With {
                                             .Fecha = Key,
                                             .TotalIngresos = Group.Sum(Function(i) i.Value.Item2)
                                         }).ToList()
                    Case <= (365 * 2) ' agrupar por mes y año si el intervalo es de hasta 2 años
                        Dim isYear As Boolean = numeroDias <= 365
                        ListaCantidadVentas = (From item In ventasTable
                                               Group item By Key = item.Key.ToString("MMM yyyy") Into Group
                                               Select New VentasPorFecha With {
                                                   .Fecha = If(isYear, Key.Substring(0, Key.IndexOf(" ")), Key),
                                                   .CantidadVentas = Group.Sum(Function(i) i.Value.Item1)
                                               }).ToList()
                        ListaIngresos = (From item In ventasTable
                                         Group item By Key = item.Key.ToString("MMM yyyy") Into Group
                                         Select New IngresosPorFecha With {
                                             .Fecha = If(isYear, Key.Substring(0, Key.IndexOf(" ")), Key),
                                             .TotalIngresos = Group.Sum(Function(i) i.Value.Item2)
                                         }).ToList()
                    Case Else ' agrupar por año si el intervalo es mayor a 2 años
                        ListaCantidadVentas = (From item In ventasTable
                                               Group item By Key = item.Key.ToString("yyyy") Into Group
                                               Select New VentasPorFecha With {
                                                   .Fecha = Key,
                                                   .CantidadVentas = Group.Sum(Function(i) i.Value.Item1)
                                               }).ToList()
                        ListaIngresos = (From item In ventasTable
                                         Group item By Key = item.Key.ToString("yyyy") Into Group
                                         Select New IngresosPorFecha With {
                                             .Fecha = Key,
                                             .TotalIngresos = Group.Sum(Function(i) i.Value.Item2)
                                         }).ToList()
                End Select
            End Using
        End Using
    End Sub

#End Region


#Region "Métodos públicos"

    Public Function LoadData(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Boolean
        fechaFin = New Date(fechaFin.Year, fechaFin.Month, fechaFin.Day, fechaFin.Hour, fechaFin.Minute, 59)
        If fechaInicio <> Me.fechaInicio OrElse fechaFin <> Me.fechaFin Then
            Me.fechaInicio = fechaInicio
            Me.fechaFin = fechaFin
            Me.numeroDias = (fechaFin - fechaInicio).Days
            ObtenerTotales()
            ObtenerAnalisisLibros()
            ObtenerVentasPorFecha()
            Return True ' datos cambiados
        Else
            Return False ' datos no cambiados
        End If
    End Function

#End Region

End Class