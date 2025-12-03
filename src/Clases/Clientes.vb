Imports MySql.Data.MySqlClient

Public Class Clientes
    Inherits Database


#Region "Atributos"

    ' campos
    Private tablaDatabase As String = "clientes"
    Private tablaDataSet As String = "TablaClientes"
    ' propiedades
    Public Property dataSet As DataSet
    Public Property dataAdapter As MySqlDataAdapter
    Public Property dataView As DataView
    Public Property nombresControlesClientes As String()
    Public Property controlesColumnasClientes As New Dictionary(Of String, String)

#End Region


    ' constructor
    Public Sub New()
    End Sub


#Region "Metodos privados"

    ' cargar datos y DataView
    Private Sub CargarData()
        ' conexión a la base de datos, DataAdapter, DataSet
        Using conexion = ConectarDatabase()
            Dim query As String = $"SELECT * FROM {tablaDatabase}"
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
    Private Sub ControlesFormClientes()
        ' nombres de los controles
        nombresControlesClientes = {
            "htbcNombre",
            "htbcApellido",
            "htbcEmail",
            "htbcTelefono",
            "pdtpFechaNacimiento",
            "pdtpFechaRegistro",
            "htbcCodigoPostal",
            "htbcProvincia",
            "htbcCiudad",
            "htbcDireccion"
        }
    End Sub
    ' diccionarios
    Private Sub InicilizarDiccionarios()
        ' diccionario para cargar datos, con nombres de los controles del formulario y su respectiva columna en la base de datos
        controlesColumnasClientes = New Dictionary(Of String, String) From {
            {"htbcNombre", "nombre"},
            {"htbcApellido", "apellido"},
            {"htbcEmail", "email"},
            {"htbcTelefono", "telefono"},
            {"pdtpFechaNacimiento", "fechaNacimiento"},
            {"pdtpFechaRegistro", "fechaRegistro"},
            {"htbcCodigoPostal", "codigoPostal"},
            {"htbcProvincia", "provincia"},
            {"htbcCiudad", "ciudad"},
            {"htbcDireccion", "direccion"}
        }
    End Sub

#End Region


#Region "Métodos públicos"

    Public Sub LoadData()
        CargarData()
        ControlesFormClientes()
        InicilizarDiccionarios()
    End Sub

#End Region

End Class