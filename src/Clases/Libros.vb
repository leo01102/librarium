Imports MySql.Data.MySqlClient

Public Class Libros
    Inherits Database

#Region "Atributos"

    ' campos
    Private tablaDatabase As String = "libros"
    Private tablaDataSet As String = "TablaLibros"
    ' propiedades
    Public Property dataSet As DataSet
    Public Property dataAdapter As MySqlDataAdapter
    Public Property dataView As DataView
    Public Property nombresControlesLibros As String()
    Public Property controlesColumnasLibros As New Dictionary(Of String, String)

#End Region


    ' constructor
    Public Sub New()
    End Sub


#Region "Métodos privados"

    ' cargar datos y DataView
    Private Sub CargarData()
        ' conexión a la base de datos, DataAdapter, DataSet
        Using conexion = ConectarDatabase()
            Dim query As String = $"SELECT l.id, l.nombre, l.autor, l.descripcion, l.editorial, l.fechaPublicacion, l.fechaIngreso, l.precio, l.stock, l.genero, l.numeroPaginas, l.formato, l.idProveedor, CONCAT(p.nombre, ' (', p.id, ')') AS nombreProveedor " &
                                  $"FROM {tablaDatabase} l " &
                                  $"INNER JOIN proveedores p ON l.idProveedor = p.id"
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
    Private Sub ControlesFormLibros()
        ' nombres de los controles
        nombresControlesLibros = {
            "htbcNombre",
            "htbcAutor",
            "hrtbcDescripcion",
            "htbcEditorial",
            "pdtpFechaPublicacion",
            "pdtpFechaIngreso",
            "hnudPrecio",
            "hnudStock",
            "htbcGenero",
            "hnudNumeroPaginas",
            "htbcFormato",
            "htbcProveedor"
        }
    End Sub

    Private Sub InicilizarDiccionarios()
        ' diccionario para cargar datos, con nombres de los controles del formulario y su respectiva columna en la base de datos
        controlesColumnasLibros = New Dictionary(Of String, String) From {
            {"htbcNombre", "nombre"},
            {"htbcAutor", "autor"},
            {"hrtbcDescripcion", "descripcion"},
            {"htbcEditorial", "editorial"},
            {"pdtpFechaPublicacion", "fechaPublicacion"},
            {"pdtpFechaIngreso", "fechaIngreso"},
            {"hnudCantidad", "cantidad"},
            {"hnudPrecio", "precio"},
            {"hnudStock", "stock"},
            {"htbcGenero", "genero"},
            {"hnudNumeroPaginas", "numeroPaginas"},
            {"htbcFormato", "formato"},
            {"htbcProveedor", "nombreProveedor"}
        }
    End Sub

#End Region


#Region "Métodos públicos"

    Public Sub LoadData()
        CargarData()
        ControlesFormLibros()
        InicilizarDiccionarios()
    End Sub

#End Region

End Class