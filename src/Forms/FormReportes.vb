Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports ReaLTaiizor.Controls

Public Class FormReportes
    Inherits Formulario
    'Inherits FormDashboard

    ' declaraciones
    Private cmd As MySqlCommand
    Private tablaResultado As DataTable
    Private dataReader As MySqlDataReader


    Private Sub ibtnEjecutarConsulta_Click(sender As Object, e As EventArgs) Handles ibtnEjecutarConsulta.Click
        Using conexion = ConectarDatabase() ' establecer conexión con la base de datos
            cmd = New MySqlCommand ' inicializar el comando SQL
            ' determinar la consulta SQL según la opción seleccionada
            Select Case True
                Case hcbVentasPorDia.Checked ' consulta para ventas por día
                    cmd.CommandText = "SELECT v.fechaVenta AS Fecha, SUM(v.cantidad * v.precio) AS Total " &
                                      "FROM ventas v " &
                                      "WHERE v.fechaVenta >= @fecha1 AND v.fechaVenta < @fecha2 " &
                                      "GROUP BY v.fechaVenta " &
                                      "ORDER BY v.fechaVenta ASC"
                    cmd.Parameters.AddWithValue("@fecha1", dtpFechaInicio.Value.Date)
                    cmd.Parameters.AddWithValue("@fecha2", dtpFechaFin.Value.Date.AddDays(1))
                Case hcbLibrosMasVendidos.Checked ' consulta para libros más vendidos
                    If hcbLibrosMasVendidosCantidad.Checked Then ' consulta por cantidad de ventas
                        cmd.CommandText = "SELECT v.idLibro AS id_libro, l.nombre AS nombre_libro, SUM(v.cantidad) AS cantidad_ventas " &
                                          "FROM ventas v " &
                                          "INNER JOIN libros l ON v.idLibro = l.id " &
                                          "GROUP BY v.idLibro " &
                                          "ORDER BY cantidad_ventas DESC " &
                                          "LIMIT @nro"
                    Else ' consulta por monto de ventas
                        cmd.CommandText = "SELECT v.idLibro AS id_libro, l.nombre AS nombre_libro, SUM(v.cantidad * v.precio) AS monto_ventas " &
                                          "FROM ventas v " &
                                          "INNER JOIN libros l ON v.idLibro = l.id " &
                                          "GROUP BY v.idLibro " &
                                          "ORDER BY monto_ventas DESC " &
                                          "LIMIT @nro"
                    End If
                    cmd.Parameters.AddWithValue("@nro", Convert.ToInt32(hnudLibrosMasVendidos.ValueNumber))
                Case hcbMejoresClientes.Checked ' consulta para mejores clientes
                    If hcbMejoresClientesCantidad.Checked Then ' consulta por cantidad de compras
                        cmd.CommandText = "SELECT v.idCliente AS id_cliente, CONCAT(c.nombre, ' ', c.apellido) AS nombre_completo, COUNT(v.idCliente) AS cantidad_compras " &
                                          "FROM ventas v " &
                                          "INNER JOIN clientes c ON v.idCliente = c.id " &
                                          "GROUP BY v.idCliente " &
                                          "ORDER BY cantidad_compras DESC " &
                                          "LIMIT @nro"
                    Else ' consulta por monto de compras
                        cmd.CommandText = "SELECT v.idCliente AS id_cliente, CONCAT(c.nombre, ' ', c.apellido) AS nombre_completo, SUM(v.cantidad * v.precio) AS monto_compras " &
                                          "FROM ventas v " &
                                          "INNER JOIN clientes c ON v.idCliente = c.id " &
                                          "GROUP BY v.idCliente " &
                                          "ORDER BY monto_compras DESC " &
                                          "LIMIT @nro"
                    End If
                    cmd.Parameters.AddWithValue("@nro", Convert.ToInt32(hnudMejoresClientes.ValueNumber))
                Case hcbLibrosConBajoStock.Checked ' consulta para libros con bajo stock
                    cmd.CommandText = "SELECT id, nombre, stock FROM libros WHERE stock <= @nro ORDER BY stock ASC"
                    cmd.Parameters.AddWithValue("@nro", Convert.ToInt32(hnudLibrosConBajoStock.ValueNumber))
                Case Else ' no se seleccionó ninguna opción
            End Select
            ' asignar la conexión al comando
            cmd.Connection = conexion
            ' inicializar o limpiar la tabla de resultados
            If tablaResultado Is Nothing Then
                tablaResultado = New DataTable
            Else
                ' eliminar clave primaria, si existe
                If tablaResultado.PrimaryKey.Length > 0 Then
                    tablaResultado.PrimaryKey = Nothing
                End If
                ' limpiar las filas y columnas de la tabla
                tablaResultado.Clear()
                tablaResultado.Columns.Clear()
            End If
            ' ejecutar la consulta y cargar los resultados
            dataReader = cmd.ExecuteReader
            ' verificar si se obtuvieron resultados
            If dataReader.HasRows Then
                tablaResultado.Load(dataReader) ' cargar los datos en la tabla
                ibtnExportar.Enabled = True
                ibtnExportarCSV.Enabled = True
                ibtnExportarXLSX.Enabled = True
            Else
                ibtnExportar.Enabled = False
                ibtnExportarCSV.Enabled = False
                ibtnExportarXLSX.Enabled = False
                MsgBox("Consulta sin resultados")
            End If
            dataReader.Close() ' cerrar el lector de datos
        End Using
        dgvDatos.DataSource = tablaResultado ' cargar DataGridView
        ConfigurarDataGridView()
    End Sub


#Region "subrutinas"

    Private Sub ConfigurarDataGridView()
        Select Case True
            ' nombre de cada columna
            Case hcbVentasPorDia.Checked
                With dgvDatos
                    .Columns("Fecha").HeaderText = "Fecha"
                    .Columns("Total").HeaderText = "Total en ventas"
                End With
            Case hcbLibrosMasVendidos.Checked
                With dgvDatos
                    .Columns("id_libro").HeaderText = "ID del libro"
                    .Columns("nombre_libro").HeaderText = "Nombre completo"
                    If hcbLibrosMasVendidosCantidad.Checked = True Then
                        .Columns("cantidad_ventas").HeaderText = "Cantidad de ventas"
                    Else
                        .Columns("monto_ventas").HeaderText = "Monto de ventas"
                    End If
                End With
            Case hcbMejoresClientes.Checked
                With dgvDatos
                    .Columns("id_cliente").HeaderText = "ID del cliente"
                    .Columns("nombre_completo").HeaderText = "Nombre completo"
                    If hcbMejoresClientesCantidad.Checked = True Then
                        .Columns("cantidad_compras").HeaderText = "Cantidad de compras"
                    Else
                        .Columns("monto_compras").HeaderText = "Monto de compras"
                    End If
                End With
            Case hcbLibrosConBajoStock.Checked
                With dgvDatos
                    .Columns("id").HeaderText = "ID del libro"
                    .Columns("nombre").HeaderText = "Nombre"
                    .Columns("stock").HeaderText = "Stock"
                End With
            Case Else
        End Select
    End Sub
    Private Sub ElegirConsulta()
        Dim fechaVentasControles As Control() = {dtpFechaInicio, dtpFechaFin}
        Dim productosControles As Control() = {hnudLibrosMasVendidos, hcbLibrosMasVendidosMonto, hcbLibrosMasVendidosCantidad}
        Dim clientesControles As Control() = {hnudMejoresClientes, hcbMejoresClientesMonto, hcbMejoresClientesCantidad}
        Dim stockControles As Control() = {hnudLibrosConBajoStock}
        For Each ctrl As Control In fechaVentasControles.Concat(productosControles).Concat(clientesControles).Concat(stockControles)
            ctrl.Enabled = False
        Next
        Select Case True
            Case hcbVentasPorDia.Checked
                HabilitarControles(fechaVentasControles)
            Case hcbLibrosMasVendidos.Checked
                HabilitarControles(productosControles)
            Case hcbMejoresClientes.Checked
                HabilitarControles(clientesControles)
            Case hcbLibrosConBajoStock.Checked
                HabilitarControles(stockControles)
            Case Else
        End Select
    End Sub
    Private Sub HabilitarControles(controles As Control())
        For Each ctrl As Control In controles
            ctrl.Enabled = True
        Next
    End Sub
    Private Sub ActivarCheckBoxes(ParamArray checkboxes As HopeCheckBox())
        For Each cb As HopeCheckBox In checkboxes
            cb.Enabled = True
        Next
    End Sub
    Private Sub DesactivarCheckBoxes(ParamArray checkboxes As HopeCheckBox())
        For Each cb As HopeCheckBox In checkboxes
            cb.Enabled = False
        Next
    End Sub
    Private Sub SeleccionarDeseleccionarCheckBox(currenCheckedBox As HopeCheckBox, ParamArray otherCheckBoxes As HopeCheckBox())
        If currenCheckedBox.Checked Then
            For Each checkBox In otherCheckBoxes
                checkBox.Checked = False
            Next
        End If
    End Sub

#End Region


#Region "CheckBoxes"

    ' seleccionar/deseleccionar consultas
    Private Sub hcbVentasPorDia_CheckedChanged(sender As Object, e As EventArgs) Handles hcbVentasPorDia.CheckedChanged
        ElegirConsulta()
        SeleccionarDeseleccionarCheckBox(sender, hcbLibrosMasVendidos, hcbMejoresClientes, hcbLibrosConBajoStock)
    End Sub
    Private Sub hcbLibrosMasVendidos_CheckedChanged(sender As Object, e As EventArgs) Handles hcbLibrosMasVendidos.CheckedChanged
        ElegirConsulta()
        SeleccionarDeseleccionarCheckBox(sender, hcbMejoresClientes, hcbVentasPorDia, hcbLibrosConBajoStock)
    End Sub
    Private Sub hcbMejoresClientes_CheckedChanged(sender As Object, e As EventArgs) Handles hcbMejoresClientes.CheckedChanged
        ElegirConsulta()
        SeleccionarDeseleccionarCheckBox(sender, hcbLibrosMasVendidos, hcbVentasPorDia, hcbLibrosConBajoStock)
    End Sub
    Private Sub hcbLibrosConBajoStock_CheckedChanged(sender As Object, e As EventArgs) Handles hcbLibrosConBajoStock.CheckedChanged
        ElegirConsulta()
        SeleccionarDeseleccionarCheckBox(sender, hcbVentasPorDia, hcbLibrosMasVendidos, hcbMejoresClientes)
    End Sub
    ' seleccionar/deseleccionar cantidad/monto
    Private Sub hcbLibrosMasVendidosCantidad_CheckedChanged(sender As Object, e As EventArgs) Handles hcbLibrosMasVendidosCantidad.CheckedChanged
        SeleccionarDeseleccionarCheckBox(sender, hcbLibrosMasVendidosMonto)
    End Sub
    Private Sub hcbLibrosMasVendidosMonto_CheckedChanged(sender As Object, e As EventArgs) Handles hcbLibrosMasVendidosMonto.CheckedChanged
        SeleccionarDeseleccionarCheckBox(sender, hcbLibrosMasVendidosCantidad)
    End Sub
    Private Sub hcbMejoresClientesCantidad_CheckedChanged(sender As Object, e As EventArgs) Handles hcbMejoresClientesCantidad.CheckedChanged
        SeleccionarDeseleccionarCheckBox(sender, hcbMejoresClientesMonto)
    End Sub
    Private Sub hcbMejoresClientesMonto_CheckedChanged(sender As Object, e As EventArgs) Handles hcbMejoresClientesMonto.CheckedChanged
        SeleccionarDeseleccionarCheckBox(sender, hcbMejoresClientesCantidad)
    End Sub

#End Region


#Region "Exportar"

    Private Sub ibtnExportarCSV_Click(sender As Object, e As EventArgs) Handles ibtnExportarCSV.Click
        ExportarDataGridViewCSV(dgvDatos)
    End Sub

    Private Sub ibtnExportarXLSX_Click(sender As Object, e As EventArgs) Handles ibtnExportarXLSX.Click
        ExportarDataGridViewXLSX(dgvDatos)
    End Sub

#End Region


#Region "Mover formulario, cerrar, maximizar, minimizar"

    ' mover formulario
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub pnlBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBar.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub

    ' cerrar, maximizar, minimizar
    Private Sub ibtnCerrar_Click(sender As Object, e As EventArgs) Handles ibtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub ibtnMaximizar_Click(sender As Object, e As EventArgs) Handles ibtnMaximizar.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub ibtnMinimizar_Click(sender As Object, e As EventArgs) Handles ibtnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    ' remove transparent border in maximized state
    Private Sub FormDashboardReportes_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

#End Region


End Class