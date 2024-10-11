' Backend

Imports MySql.Data.MySqlClient

Public Class Formulario
    Inherits System.Windows.Forms.Form ' heredar "Form" a la clase Formulario, esto para evitar multiherencia al, por ejemplo, intentar heredar la clase Formulario en el formulario FormLibros, ya que FormLibros de por sí hereda de Form al ser un formulario
    Implements IDatabase, IDataGridView

    ' instancia de la clase Database para usar su funcionalidad
    Private _database As Database
    Private _dataGridView As DataGridView ' Instancia de la clase DataGridView

    ' constructor
    Public Sub New()
        _database = New Database()
        _dataGridView = New DataGridView()
    End Sub

    ' 1. implementación de los métodos de la interfaz IDatabase
    Protected Overloads Function ConectarDatabase() As MySqlConnection Implements IDatabase.ConectarDatabase
        Return _database.ConectarDatabase()
    End Function
    Protected Overloads Function CargarDataSetAdapter(conexion As MySqlConnection, tablaDataSet As String, query As String) As (DataSet, MySqlDataAdapter) Implements IDatabase.CargarDataSetAdapter
        Return _database.CargarDataSetAdapter(conexion, tablaDataSet, query)
    End Function
    Protected Overloads Function CargarDataGridView(dSet As DataSet, tablaDataSet As String) Implements IDatabase.CargarDataGridView
        Return _database.CargarDataGridView(dSet, tablaDataSet)
    End Function
    Protected Overloads Sub InsertarRegistro(tablaDatabase As String, tablaDataSet As String, datosFilas As Hashtable) Implements IDatabase.InsertarRegistro
        _database.InsertarRegistro(tablaDatabase, tablaDataSet, datosFilas)
    End Sub
    Protected Overloads Sub EditarRegistro(tablaDatabase As String, tablaDataSet As String, idFila As Integer, datosFilas As Hashtable) Implements IDatabase.EditarRegistro
        _database.EditarRegistro(tablaDatabase, tablaDataSet, idFila, datosFilas)
    End Sub
    Protected Overloads Function BorrarRegistro(tablaDatabase As String, tablaDataSet As String, id As Long, nombreCampoID As String) As Boolean Implements IDatabase.BorrarRegistro
        Return _database.BorrarRegistro(tablaDatabase, tablaDataSet, id, nombreCampoID)
    End Function
    Protected Overloads Function GetMySqlDbType(t As Type) As MySqlDbType Implements IDatabase.GetMySqlDbType
        Return _database.GetMySqlDbType(t)
    End Function
    Protected Overloads Function ObtenerId(nombre As String, tablaDatabase As String, campo As String) As Integer Implements IDatabase.ObtenerId
        Return _database.ObtenerId(nombre, tablaDatabase, campo)
    End Function


    ' 2. implementación de los métodos de la interfaz IDataGridView
    Protected Overloads Sub ExportarDataGridViewXLSX(dgv As System.Windows.Forms.DataGridView) Implements IDataGridView.ExportarDataGridViewXLSX
        _dataGridView.ExportarDataGridViewXLSX(dgv)
    End Sub
    Protected Overloads Sub ExportarDataGridViewCSV(dgv As System.Windows.Forms.DataGridView) Implements IDataGridView.ExportarDataGridViewCSV
        _dataGridView.ExportarDataGridViewCSV(dgv)
    End Sub
    ' Método adicional para exportar a PDF (comentado en la clase DataGridView)
    ' Protected Sub ExportarDataGridViewPDF(dgv As System.Windows.Forms.DataGridView) Implements IDataGridView.ExportarDataGridViewPDF
    ' End Sub

End Class