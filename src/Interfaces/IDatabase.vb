' Backend

Imports MySql.Data.MySqlClient

Public Interface IDatabase

    Function ConectarDatabase() As MySqlConnection
    Function CargarDataSetAdapter(conexion As MySqlConnection, tablaDataSet As String, query As String) As (DataSet, MySqlDataAdapter)
    Function CargarDataGridView(dSet As DataSet, tablaDataSet As String)
    Sub InsertarRegistro(tablaDatabase As String, tablaDataSet As String, datosFilas As Hashtable)
    Sub EditarRegistro(tablaDatabase As String, tablaDataSet As String, idFila As Integer, datosFilas As Hashtable)
    Function BorrarRegistro(tablaDatabase As String, tablaDataSet As String, id As Long, nombreCampoID As String) As Boolean
    Function GetMySqlDbType(t As Type) As MySqlDbType
    Function ObtenerId(nombre As String, tablaDatabase As String, campo As String) As Integer

End Interface