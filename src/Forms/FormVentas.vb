' Frontend

Imports FontAwesome.Sharp

Public Class FormVentas
    Inherits Formulario

#Region "Declaraciones"

    Private ventas As Ventas ' declarar una instancia de la clase Ventas
    Private tablaDatabase As String = "ventas"
    Private tablaDataSet As String = "TablaVentas"
    Private idFila As Integer

    Private vistaDatos As DataView

#End Region


    ' constructor
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ventas = New Ventas() ' inicializar la instancia de la clase Libros
    End Sub


#Region "Form Load1"

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' llamar subrutinas del metodo LoadData() de la clase Libros
        ventas.LoadData()
        ' inicializaciones
        dgvDatos.DataSource = ventas.dataView ' cargar DataGridView
        ' subrutinas
        ConfigurarDataGridView(dgvDatos) ' modificar DataGridView
        OcultarControles(hdtpFechaVenta) ' ocultar TimePickers
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos) ' ocultar paneles
        Cancelar() ' activar botones por defecto
    End Sub

#End Region


#Region "Diccionarios"

    Private datosFilasVentas As Hashtable
    Private controlesVentas As Dictionary(Of System.Windows.Forms.Control, String)
    Private idCliente As Integer
    Private idLibro As Integer

    Private Sub InicilizarDiccionarios()
        ' 1. diccionario para validar entradas, con el nombre del cotrol del formulario y el texto que aparecerá en pantalla
        controlesVentas = New Dictionary(Of System.Windows.Forms.Control, String) From {
            {htbcCliente, "cliente"},
            {htbcLibro, "libro"},
            {pdtpFechaVenta, "fecha de venta"},
            {hnudPrecio, "precio"},
            {hnudCantidad, "cantidad"}
        }

        ' 2. diccionario con los datos de las filas
        ' 2.1. obtener IDs
        idCliente = ObtenerId(htbcCliente.Text, "clientes", "CONCAT(nombre, ' ', apellido)") ' obtener ID del cliente
        idLibro = ObtenerId(htbcLibro.Text, "libros", "nombre") ' obtener ID del libro
        ' 2.2. variables locales
        Dim fechaVenta As Date = pdtpFechaVenta.Value
        Dim precio As Decimal = Math.Round(Convert.ToDecimal(hnudPrecio.ValueNumber), 2)
        Dim cantidad As Integer = hnudCantidad.ValueNumber
        datosFilasVentas = New Hashtable From {
            {"idCliente", idCliente},
            {"idLibro", idLibro},
            {"fechaVenta", fechaVenta},
            {"precio", precio},
            {"cantidad", cantidad}
        }
    End Sub

#End Region


#Region "DataGridView: carga de datos a los controles"

    ' 1. cargar datos de la tabla libros hacia los controles
    Private Sub CargarDatosVentas()
        Dim fila As DataGridViewRow = dgvDatos.CurrentRow
        idFila = fila.Cells(0).Value

        CargarControles(fila, ventas.controlesColumnasVentas, Me)
    End Sub

    ' mostrar datos seleccionados
    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Dim vistaDatos = ventas.dataView
        If vistaDatos.Count > 0 Then
            CargarDatosVentas()
        End If
    End Sub

    ' configurar DataGridView
    Public Sub ConfigurarDataGridView(dgv As System.Windows.Forms.DataGridView)
        With dgv
            ' 1. tamaño y ubicación
            .Size = New Size(1378, 825)
            .Location = New System.Drawing.Point(10, 10)
            ' 2. seleccionar por defecto la primera celda de la primera fila
            .CurrentCell = .Rows(0).Cells(1)
            ' 3. columnas
            ' 3.1. ancho
            .Columns(0).Width = 30 ' clave primaria ID con width más corto
            .Columns(3).Width = 200 ' ajustar AutoSizeColumnsMode en el diseñador a Fill
            ' 3.2. ocultar columnas de id, aunque se oculte, los id son necesarios para la subrutina CargarControles()
            .Columns("idCliente").Visible = False
            .Columns("idLibro").Visible = False
            .Columns("precio").Visible = False
            ' 3.3. ordenar según la id de menor a mayor
            If .Columns.Contains("id") Then
                .Sort(.Columns("id"), System.ComponentModel.ListSortDirection.Ascending)
            End If
            ' 3.4. nombre de cada columna
            .Columns("id").HeaderText = "ID"
            .Columns("idCliente").HeaderText = "ID Cliente"
            .Columns("nombreCompletoCliente").HeaderText = "Cliente (ID)"
            .Columns("idLibro").HeaderText = "ID Libro"
            .Columns("nombreLibro").HeaderText = "Libro"
            .Columns("fechaVenta").HeaderText = "Fecha de venta"
            .Columns("cantidad").HeaderText = "Cantidad"
            .Columns("precioTablaLibros").HeaderText = "Precio"
        End With
    End Sub

#End Region


#Region "Busqueda"

    Private Sub htbcBuscar_TextChanged(sender As Object, e As EventArgs) Handles htbcBuscar.TextChanged
        AplicarFiltro()
    End Sub
    Private Sub hnudcBuesquedaAño_ValueChanged(sender As Object, e As EventArgs) Handles hnudcBuesquedaAño.ValueChanged
        AplicarFiltro()
    End Sub

    Private criterioBusqueda As String = "nombreCompletoCliente" ' criterio por defecto
    Private Sub AplicarFiltro()
        Dim filtro As String = "nombreCompletoCliente LIKE '" & htbcBuscar.Text & "%'"

        Select Case criterioBusqueda
            Case "nombreCompletoCliente"
                filtro = "nombreCompletoCliente LIKE '" & htbcBuscar.Text & "%'"
            Case "nombreLibro"
                filtro = "nombreLibro LIKE '" & htbcBuscar.Text & "%'"
            Case "cantidad"
                filtro = "cantidad LIKE '" & htbcBuscar.Text & "%'"
            Case "fechaVenta"
                Dim año As Integer = hnudcBuesquedaAño.ValueNumber
                Dim fechaInicio As DateTime = New DateTime(año, 1, 1)
                Dim fechaFin As DateTime = fechaInicio.AddYears(1)
                filtro = "fechaVenta >= #" & fechaInicio.ToString("yyyy-MM-dd") & "# AND fechaVenta < #" & fechaFin.ToString("yyyy-MM-dd") & "#"
            Case "precio"
                filtro = "precio >= " & hnudcPrecioMinimo.ValueNumber.ToString() & " AND precio <= " & hnudcPrecioMaximo.ValueNumber.ToString()
        End Select

        Dim vistaDatos = ventas.dataView
        vistaDatos.RowFilter = filtro

        If vistaDatos.Count > 0 Then
            CargarDatosVentas()
        End If
    End Sub

#Region "Botones"

    Private Sub ibtnBusquedaCriterioCliente_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioCliente.Click
        criterioBusqueda = "nombreCompletoCliente"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaCliente)
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioLibro_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioLibro.Click
        criterioBusqueda = "nombreLibro"
        OcultarBusquedaCriterios() ' ocultar todo
        MostrarControles(ibtnBusquedaLibro) ' mostrar un control en particular
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioFechaVenta_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioFechaVenta.Click
        criterioBusqueda = "fechaVenta"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaFechaVenta, hnudcBuesquedaAño, lblBusquedaFechaVentaAño)
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioPrecio_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioPrecio.Click
        criterioBusqueda = "precio"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaPrecio, hnudcPrecioMinimo, hnudcPrecioMaximo, lblBusquedaPrecioMaximo, lblBusquedaPrecioMinimo)
        OcultarPanelesBusqueda()
    End Sub
    Private Sub hnudcPrecioMinimo_ValueChanged_1(sender As Object, e As EventArgs) Handles hnudcPrecioMinimo.ValueChanged
        AplicarFiltro()
    End Sub
    Private Sub hnudcPrecioMinimo_ValueChanged(sender As Object, e As EventArgs) Handles hnudcPrecioMaximo.ValueChanged
        AplicarFiltro()
    End Sub

#End Region

#Region "Mostrar, ocultar"

    ' mostrar
    Private Sub FormVentas_Load4(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim botonesBusquedaCriterios As IconButton() = {ibtnBusquedaCliente, ibtnBusquedaLibro, ibtnBusquedaFechaVenta, ibtnBusquedaPrecio}
        For Each boton As IconButton In botonesBusquedaCriterios
            boton.BringToFront()
        Next
    End Sub
    Private Sub ibtnBusqueda_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterio.Click, ibtnBusquedaCliente.Click, ibtnBusquedaLibro.Click, ibtnBusquedaFechaVenta.Click, ibtnBusquedaPrecio.Click
        MostrarControles(pnlCriterioBusquedaMenu) ' mostrar panel cada vez que se haga click en alguno de los ibtnBusquedaCriterio
    End Sub

    ' ocultar
    Private Sub FormVentas_Load3(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarBusquedaCriterios()
    End Sub
    Private Sub OcultarBusquedaCriterios()
        OcultarControles(ibtnBusquedaCliente, ibtnBusquedaFechaVenta, ibtnBusquedaPrecio, hnudcPrecioMinimo, hnudcPrecioMaximo, hnudcBuesquedaAño, lblBusquedaPrecioMaximo, lblBusquedaPrecioMinimo, lblBusquedaFechaVentaAño)
    End Sub
    Private Sub OcultarPanelesBusqueda()
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
    End Sub

#End Region

#End Region


#Region "Ventas"

    Private stockPrecioValido As Boolean
    Private Sub ValidarStockPrecio()
        Dim idLibro As Integer = ObtenerId(htbcLibro.Text, "libros", "nombre")
        Dim precio As Decimal = Math.Round(Convert.ToDecimal(hnudPrecio.ValueNumber), 2)
        Dim cantidad As Integer = hnudCantidad.ValueNumber
        stockPrecioValido = ventas.BuscarStockPrecio(idLibro, precio, cantidad)
    End Sub
    Private Sub CalcularTotalVenta()
        Dim precio As Decimal = Math.Round(Convert.ToDecimal(hnudPrecio.ValueNumber), 2)
        Dim cantidad As Integer = hnudCantidad.ValueNumber
        Dim totalVenta As Decimal = precio * cantidad
        htbcTotalVenta.Text = $"Total: $ {totalVenta}"
    End Sub
    Private Sub ibtnCalcularTotalVenta_Click(sender As Object, e As EventArgs) Handles ibtnCalcularTotalVenta.Click
        CalcularTotalVenta()
    End Sub

#End Region


#Region "Agregar, editar, guardar, borrar, cancelar"

    Private esNuevoRegistro As Boolean

    Private Sub ibtnAgregar_Click(sender As Object, e As EventArgs) Handles ibtnAgregar.Click
        esNuevoRegistro = True

        CalcularTotalVenta()
        VaciarControles(ventas.nombresControlesVentas, Me)
        DesactivarBotones(ibtnAgregar, ibtnEditar, ibtnBorrar, ibtnExportar)
        MostrarControles(pnlDatos)
    End Sub

    Private Sub ibtnEditar_Click(sender As Object, e As EventArgs) Handles ibtnEditar.Click
        esNuevoRegistro = False

        CalcularTotalVenta()
        DesactivarBotones(ibtnAgregar, ibtnEditar, ibtnBorrar, ibtnExportar)
        MostrarControles(pnlDatos)
    End Sub

    ' buscar precio del libro
    Private Sub ibtnBuscarStockPrecio_Click(sender As Object, e As EventArgs) Handles ibtnBuscarStockPrecio.Click
        ' obtener el nombre del libro desde el TextBox
        Dim nombreLibro = htbcLibro.Text.Trim
        ' obtener el precio y stock del libro usando la clase Ventas
        Dim resultado = ventas.ObtenerPrecioStockLibro(nombreLibro)
        Dim precioLibro = resultado.Item1
        Dim stockLibro = resultado.Item2
        ' asignar el precio al NumericUpDown si se encontró
        If precioLibro > 0 Then
            hnudPrecio.ValueNumber = Math.Round(precioLibro, 2)
            lblStock.Text = $"Stock: {stockLibro}" ' mostrar el stock en el label
        End If
    End Sub

    ' insertar nuevo registro (btnGuardar debe guardar un nuevo registro o guardar un registro editado)
    Private Sub ibtnGuardar_Click(sender As Object, e As EventArgs) Handles ibtnGuardar.Click
        ' diccionario y sub para validar entradas e insertar/editar registros
        InicilizarDiccionarios()
        ValidarStockPrecio()
        ' validar entradas
        If (Not validarEntradas(controlesVentas) OrElse idCliente = -1 OrElse idLibro = -1) OrElse Not stockPrecioValido Then
            Return
        End If
        ' insertar o editar registro
        If esNuevoRegistro Then
            ' cargar datos para el nuevo registro (fila)
            InsertarRegistro(tablaDatabase, tablaDataSet, datosFilasVentas)
            OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
        Else
            ' editar registro (fila) existente
            EditarRegistro(tablaDatabase, tablaDataSet, idFila, datosFilasVentas)
        End If
        ' llamadas de sub
        Cancelar()
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
    End Sub

    ' borrar registro seleccionado
    Private Sub ibtnBorrar_Click(sender As Object, e As EventArgs) Handles ibtnBorrar.Click
        BorrarRegistro(tablaDatabase, tablaDataSet, idFila, "id")
        Cancelar()
    End Sub

    Private Sub ibtnCancelar_Click(sender As Object, e As EventArgs) Handles ibtnCancelar.Click
        Cancelar()
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
    End Sub
    Private Sub Cancelar()
        ActivarBotones(ibtnAgregar, ibtnEditar, ibtnGuardar, ibtnBorrar, ibtnCancelar, ibtnExportar)
        CargarDatosVentas()
    End Sub

#End Region


#Region "Exportar"

    Private Sub ibtnExportar_Click(sender As Object, e As EventArgs) Handles ibtnExportar.Click
        MostrarControles(pnlExportar)
        ibtnExportarXLSX.BringToFront()
        ibtnExportarCSV.BringToFront()
    End Sub
    Private Sub ibtnExportarXLSX_Click(sender As Object, e As EventArgs) Handles ibtnExportarXLSX.Click
        ExportarDataGridViewXLSX(dgvDatos)
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
    End Sub
    Private Sub ibtnExportarCSV_Click(sender As Object, e As EventArgs) Handles ibtnExportarCSV.Click
        ExportarDataGridViewCSV(dgvDatos)
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
    End Sub

#Region "Actualizar posición submenu"

    Private Sub FormVentas_Load2(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Suscribirse al evento Resize del formulario
        AddHandler Me.Resize, AddressOf FormVentas_Resize

        ' Suscribirse al evento SizeChanged del panel contenedor
        AddHandler pnlContenedorExportarAgregarEditarBorrar.SizeChanged, AddressOf pnlContenedorExportarAgregarEditarBorrar_SizeChanged

        ' Ajustar la posición inicial del panel
        ActualizarPosicionSubmenu()
    End Sub

    Private Sub FormVentas_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' actualizar la posición del panel cuando el formulario cambia de tamaño
        ActualizarPosicionSubmenu()
    End Sub

    Private Sub pnlContenedorExportarAgregarEditarBorrar_SizeChanged(sender As Object, e As EventArgs) Handles pnlContenedorExportarAgregarEditarBorrar.SizeChanged
        ' Ajustar la posición del panel al cambiar el tamaño del panel contenedor
        ActualizarPosicionSubmenu()
    End Sub
    Private Sub ActualizarPosicionSubmenu()
        ' Calcular la nueva posición del botón de exportar en relación con el formulario
        Dim buttonLocationInForm As System.Drawing.Point = pnlContenedorExportarAgregarEditarBorrar.PointToScreen(ibtnExportar.Location)
        Dim newButtonLocation As System.Drawing.Point = Me.PointToClient(buttonLocationInForm)

        ' Ajustar la posición del panel justo debajo del botón de exportar
        pnlExportar.Location = New System.Drawing.Point(newButtonLocation.X, newButtonLocation.Y + ibtnExportar.Height)
    End Sub

#End Region

#End Region


#Region "Fechas"

#Region "Fecha venta"

    ' poison
    Private Sub pdtpFechaVenta_MouseHover(sender As Object, e As EventArgs) Handles pdtpFechaVenta.MouseHover
        If hdtpFechaVenta.Visible = False Then
            MostrarControles(hdtpFechaVenta)
            'Else
            '    hdtpFechaVenta.Visible = False
        End If
    End Sub
    Private Sub pdtpFechaVenta_MouseLeave(sender As Object, e As EventArgs) Handles pdtpFechaVenta.MouseLeave
        If hdtpFechaVenta.Visible = True Then
            WaitTimer.Start()
        End If
    End Sub

    ' hope
    Private Sub hdtpFechaVenta_onDateChanged(newDateTime As Date) Handles hdtpFechaVenta.onDateChanged
        pdtpFechaVenta.Value = newDateTime ' guardar en poison el valor seleccionado en hope
        OcultarControles(hdtpFechaVenta)
    End Sub
    Private Sub hdtpFechaVenta_MouseHover(sender As Object, e As EventArgs) Handles hdtpFechaVenta.MouseHover
        MostrarControles(hdtpFechaVenta)
        hdtpFechaVenta.BringToFront()
        WaitTimer.Stop() ' evitar que se oculte
    End Sub
    Private Sub hdtpFechaVenta_MouseLeave(sender As Object, e As EventArgs) Handles hdtpFechaVenta.MouseLeave
        If hdtpFechaVenta.Visible = True Then
            WaitTimer.Start()
            OcultarControles(hdtpFechaVenta)
        End If
    End Sub

#End Region

    Private WithEvents WaitTimer As New Timer With {.Interval = 700, .Enabled = False}
    Private Sub WaitTimerIngreso_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        WaitTimer.Stop()
        OcultarControles(hdtpFechaVenta)
    End Sub

#End Region


End Class