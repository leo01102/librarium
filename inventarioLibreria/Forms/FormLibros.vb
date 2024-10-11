' Frontend

#Region "Importaciones"

Imports System.Runtime.InteropServices ' para usar librerías del sistema
Imports System.IO

Imports MySql.Data.MySqlClient ' para conectarse a la BD MySQL

Imports PdfSharp
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing

Imports ClosedXML.Excel ' para exportar como xlsx

Imports FontAwesome.Sharp ' iconos de FontAwesome
Imports K4os.Compression.LZ4.Streams
Imports Mysqlx
Imports ReaLTaiizor
Imports MahApps
Imports System.Data.Common
Imports Org.BouncyCastle.Asn1
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Mysqlx.XDevAPI.Common
Imports System.Windows.Controls
Imports ReaLTaiizor.Controls
Imports DocumentFormat.OpenXml.Office2010.Excel


#End Region

Public Class FormLibros
    Inherits Formulario


#Region "Declaraciones"

    Private libros As Libros ' declarar una instancia de la clase Libros
    Private tablaDatabase As String = "libros"
    Private tablaDataSet As String = "TablaLibros"
    Private idFila As Integer

    Private vistaDatos As DataView
    Private libreriaDataSet As DataSet ' DataSet
    Private librosDataAdapter As MySqlDataAdapter ' DataAdapter

#End Region


    ' constructor
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        libros = New Libros() ' inicializar la instancia de la clase Libros
    End Sub


#Region "Form Load1"

    Private Sub FormLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' llamar subrutinas y funciones del metodo LoadData() de la clase Libros
        libros.LoadData()

        ' inicializaciones
        libreriaDataSet = libros.dataSet ' DataSet
        librosDataAdapter = libros.dataAdapter ' DataAdapter
        dgvDatos.DataSource = libros.dataView ' cargar DataGridView

        ' subrutinas
        ConfigurarDataGridView(dgvDatos) ' modificar DataGridView
        OcultarControles(hdtpFechaPublicacion, hdtpFechaIngreso) ' ocultar TimePickers
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos) ' ocultar paneles
        Cancelar() ' activar botones por defecto
    End Sub

#End Region


#Region "Diccionarios"

    Private datosFilasLibros As Hashtable
    Private controlesLibros As Dictionary(Of System.Windows.Forms.Control, String)
    Private idProveedor As Integer

    Private Sub InicializarDiccionarios()
        ' diccionario para validar entradas, con el nombre del cotrol del formulario y el texto que aparecerá en pantalla
        ' primero las claves (keys) y luego el dato ingresado por los controles
        controlesLibros = New Dictionary(Of System.Windows.Forms.Control, String) From {
            {htbcNombre, "nombre"},
            {htbcAutor, "autor"},
            {hrtbcDescripcion, "descripción"},
            {htbcEditorial, "editorial"},
            {pdtpFechaPublicacion, "fecha de publicación"},
            {pdtpFechaIngreso, "fecha de ingreso"},
            {hnudPrecio, "precio"},
            {hnudStock, "stock"},
            {htbcGenero, "género"},
            {hnudNumeroPaginas, "número de páginas"},
            {htbcFormato, "formato"},
            {htbcProveedor, "proveedor"}
        }

        ' diccionario con los datos de las filas
        idProveedor = ObtenerId(htbcProveedor.Text, "proveedores", "nombre") ' obtener el ID del proveedor
        Dim fechaPublicacion As Date = pdtpFechaPublicacion.Value
        Dim fechaIngreso As Date = pdtpFechaIngreso.Value
        Dim precio As Decimal = Math.Round(Convert.ToDecimal(hnudPrecio.ValueNumber), 2)
        Dim stock As Integer = hnudStock.ValueNumber
        Dim numeroPaginas As Integer = hnudNumeroPaginas.ValueNumber
        ' primero las claves (keys) y luego el dato ingresado por los controles
        datosFilasLibros = New Hashtable From {
            {"nombre", htbcNombre.Text},
            {"autor", htbcAutor.Text},
            {"descripcion", hrtbcDescripcion.Text},
            {"editorial", htbcEditorial.Text},
            {"fechaPublicacion", fechaPublicacion},
            {"fechaIngreso", fechaIngreso},
            {"precio", precio},
            {"stock", stock},
            {"genero", htbcGenero.Text},
            {"numeroPaginas", numeroPaginas},
            {"formato", htbcFormato.Text},
            {"idProveedor", idProveedor}
        }
    End Sub



#End Region


#Region "DataGridView"
    ' 1. cargar datos a los controles
    ' 1.1. cargar datos de la tabla libros hacia los controles
    Private Sub CargarDatosLibros()
        Dim fila As DataGridViewRow = dgvDatos.CurrentRow
        idFila = fila.Cells(0).Value

        CargarControles(fila, libros.controlesColumnasLibros, Me)
    End Sub

    ' 2. mostrar datos seleccionados
    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Dim vistaDatos = libros.dataView
        If vistaDatos.Count > 0 Then
            CargarDatosLibros()
        End If
    End Sub

    ' 3. Configurar DataGridView
    Private Sub ConfigurarDataGridView(dgv As System.Windows.Forms.DataGridView)
        With dgv
            ' 1. tamaño y ubicación
            .Size = New Size(1378, 825)
            .Location = New Point(10, 10)
            ' 2. seleccionar por defecto la primera celda de la primera fila
            .CurrentCell = dgv.Rows(0).Cells(1)
            ' 3. columnas
            ' 3.1. ancho
            .Columns(0).Width = 30 ' clave con width más corto
            .Columns(3).Width = 125 ' en DataGridView del diseño ir a una propiedad llamada AutoSizeColumsMode y cambiar None por Fill
            ' 3.2. ocultar columnas de id, aunque se oculte, los id son necesarios para la subrutina CargarControles()
            .Columns("idProveedor").Visible = False
            ' 3.3. ordenar según la id de menor a mayor
            If .Columns.Contains("id") Then
                .Sort(.Columns("id"), System.ComponentModel.ListSortDirection.Ascending)
            End If
            ' 3.4. nombre de cada columna
            .Columns("id").HeaderText = "ID"
            .Columns("nombre").HeaderText = "Nombre"
            .Columns("autor").HeaderText = "Autor"
            .Columns("descripcion").HeaderText = "Descripción"
            .Columns("editorial").HeaderText = "Editorial"
            .Columns("fechaPublicacion").HeaderText = "Fecha de publicación"
            .Columns("fechaIngreso").HeaderText = "Fecha de ingreso"
            .Columns("precio").HeaderText = "Precio"
            .Columns("stock").HeaderText = "Stock"
            .Columns("genero").HeaderText = "Género"
            .Columns("numeroPaginas").HeaderText = "Cantidad de páginas"
            .Columns("formato").HeaderText = "Formato"
            .Columns("idProveedor").HeaderText = "ID proveedor"
            .Columns("nombreProveedor").HeaderText = "Proveedor (ID)"
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

    Private criterioBusqueda As String = "nombre" ' criterio por defecto
    Private Sub AplicarFiltro()
        Dim filtro As String = "nombre LIKE '" & htbcBuscar.Text & "%'"

        Select Case criterioBusqueda
            Case "nombre"
                filtro = "nombre LIKE '" & htbcBuscar.Text & "%'"
            Case "autor"
                filtro = "autor LIKE '" & htbcBuscar.Text & "%'"
            Case "genero"
                filtro = "genero LIKE '" & htbcBuscar.Text & "%'"
            Case "fechaPublicacion"
                Dim año As Integer = hnudcBuesquedaAño.ValueNumber
                Dim fechaInicio As Date = New Date(año, 1, 1)
                Dim fechaFin As Date = fechaInicio.AddYears(1)
                filtro = "fechaPublicacion >= #" & fechaInicio.ToString("yyyy-MM-dd") & "# AND fechaPublicacion < #" & fechaFin.ToString("yyyy-MM-dd") & "#"
            Case "precio"
                filtro = "precio >= " & hnudcPrecioMinimo.ValueNumber.ToString() & " AND precio <= " & hnudcPrecioMaximo.ValueNumber.ToString()
        End Select

        Dim vistaDatos = libros.dataView
        vistaDatos.RowFilter = filtro

        If vistaDatos.Count > 0 Then
            CargarDatosLibros()
        End If
    End Sub

#Region "Botones"

    Private Sub ibtnBusquedaCriterioNombre_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioNombre.Click
        criterioBusqueda = "nombre"
        OcultarBusquedaCriterios() ' ocultar todo
        MostrarControles(ibtnBusquedaNombre) ' mostrar un control en particular
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioAutor_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioAutor.Click
        criterioBusqueda = "autor"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaAutor)
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioGenero_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioGenero.Click
        criterioBusqueda = "genero"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaGenero)
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioFechaPublicacion_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioFechaPublicacion.Click
        criterioBusqueda = "fechaPublicacion"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaFechaPublicacion, hnudcBuesquedaAño, lblBusquedaFechaPublicacionAño)
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
    Private Sub FormLibros_Load4(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim botonesBusquedaCriterios As IconButton() = {ibtnBusquedaNombre, ibtnBusquedaAutor, ibtnBusquedaGenero, ibtnBusquedaFechaPublicacion, ibtnBusquedaPrecio}
        For Each boton As IconButton In botonesBusquedaCriterios
            boton.BringToFront()
        Next
    End Sub
    Private Sub ibtnBusqueda_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterio.Click, ibtnBusquedaNombre.Click, ibtnBusquedaAutor.Click, ibtnBusquedaGenero.Click, ibtnBusquedaFechaPublicacion.Click, ibtnBusquedaPrecio.Click
        MostrarControles(pnlCriterioBusquedaMenu) ' mostrar panel cada vez que se haga click en alguno de los ibtnBusquedaCriterio
    End Sub

    ' ocultar
    Private Sub FormLibros_Load3(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarBusquedaCriterios()
    End Sub
    Private Sub OcultarBusquedaCriterios()
        OcultarControles(ibtnBusquedaAutor, ibtnBusquedaGenero, ibtnBusquedaFechaPublicacion, ibtnBusquedaPrecio, hnudcPrecioMinimo, hnudcPrecioMaximo, hnudcBuesquedaAño, lblBusquedaPrecioMaximo, lblBusquedaPrecioMinimo, lblBusquedaFechaPublicacionAño)
    End Sub
    Private Sub OcultarPanelesBusqueda()
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
    End Sub

#End Region

#End Region


#Region "Agregar, editar, guardar, borrar, cancelar"

    Private esNuevoRegistro As Boolean

    Private Sub ibtnAgregar_Click(sender As Object, e As EventArgs) Handles ibtnAgregar.Click
        esNuevoRegistro = True

        VaciarControles(libros.nombresControlesLibros, Me)
        DesactivarBotones(ibtnAgregar, ibtnEditar, ibtnBorrar, ibtnExportar)
        MostrarControles(pnlDatos)
    End Sub

    Private Sub ibtnEditar_Click(sender As Object, e As EventArgs) Handles ibtnEditar.Click
        esNuevoRegistro = False

        DesactivarBotones(ibtnAgregar, ibtnEditar, ibtnBorrar, ibtnExportar)
        MostrarControles(pnlDatos)
    End Sub

    ' insertar nuevo registro (btnGuardar debe guardar un nuevo registro o guardar un registro editado)
    Private Sub ibtnGuardar_Click(sender As Object, e As EventArgs) Handles ibtnGuardar.Click
        InicializarDiccionarios()

        If Not validarEntradas(controlesLibros) OrElse idProveedor = -1 Then
            Return
        End If

        If esNuevoRegistro Then ' cargar datos para el nuevo registro (fila)
            InsertarRegistro(tablaDatabase, tablaDataSet, datosFilasLibros)
            OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
        Else ' editar registro (fila) existente
            EditarRegistro(tablaDatabase, tablaDataSet, idFila, datosFilasLibros)
        End If

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
        CargarDatosLibros()
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

    Private Sub FormLibros_Load2(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Suscribirse al evento Resize del formulario
        AddHandler Me.Resize, AddressOf FormLibros_Resize

        ' Suscribirse al evento SizeChanged del panel contenedor
        AddHandler pnlContenedorExportarAgregarEditarBorrar.SizeChanged, AddressOf pnlContenedorExportarAgregarEditarBorrar_SizeChanged

        ' Ajustar la posición inicial del panel
        ActualizarPosicionSubmenu()
    End Sub

    Private Sub FormLibros_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' actualizar la posición del panel cuando el formulario cambia de tamaño
        ActualizarPosicionSubmenu()
    End Sub

    Private Sub pnlContenedorExportarAgregarEditarBorrar_SizeChanged(sender As Object, e As EventArgs) Handles pnlContenedorExportarAgregarEditarBorrar.SizeChanged
        ' Ajustar la posición del panel al cambiar el tamaño del panel contenedor
        ActualizarPosicionSubmenu()
    End Sub
    Private Sub ActualizarPosicionSubmenu()
        ' Calcular la nueva posición del botón de exportar en relación con el formulario
        Dim buttonLocationInForm As Point = pnlContenedorExportarAgregarEditarBorrar.PointToScreen(ibtnExportar.Location)
        Dim newButtonLocation As Point = Me.PointToClient(buttonLocationInForm)

        ' Ajustar la posición del panel justo debajo del botón de exportar
        pnlExportar.Location = New Point(newButtonLocation.X, newButtonLocation.Y + ibtnExportar.Height)
    End Sub

#End Region

#End Region


#Region "Fechas"

#Region "Fecha publicación"

    ' poison
    Private Sub pdtpFechaPublicacion_MouseHover(sender As Object, e As EventArgs) Handles pdtpFechaPublicacion.MouseHover
        If hdtpFechaPublicacion.Visible = False Then
            MostrarControles(hdtpFechaPublicacion)
        End If
        pdtpFechaIngreso.SendToBack() ' evitar superposición con el DateTimePicker de la fecha de publicación
    End Sub
    Private Sub pdtpFechaPublicacion_MouseLeave(sender As Object, e As EventArgs) Handles pdtpFechaPublicacion.MouseLeave
        If hdtpFechaPublicacion.Visible = True Then
            WaitTimer.Start()
        End If
    End Sub

    ' hope
    Private Sub hdtpFechaPublicacion_onDateChanged(newDateTime As Date) Handles hdtpFechaPublicacion.onDateChanged
        pdtpFechaPublicacion.Value = newDateTime ' guardar en poison el valor seleccionado en hope
        OcultarControles(hdtpFechaPublicacion)
    End Sub
    Private Sub hdtpFechaPublicacion_MouseHover(sender As Object, e As EventArgs) Handles hdtpFechaPublicacion.MouseHover
        MostrarControles(hdtpFechaPublicacion)
        hdtpFechaPublicacion.BringToFront()
        WaitTimer.Stop() ' evitar que se oculte
    End Sub
    Private Sub hdtpFechaPublicacion_MouseLeave(sender As Object, e As EventArgs) Handles hdtpFechaPublicacion.MouseLeave
        If hdtpFechaPublicacion.Visible = True Then
            WaitTimer.Start()
            OcultarControles(hdtpFechaPublicacion)
        End If
    End Sub

#End Region

#Region "Fecha ingreso"

    ' poison
    Private Sub pdtpFechaIngreso_MouseHover(sender As Object, e As EventArgs) Handles pdtpFechaIngreso.MouseHover
        If hdtpFechaIngreso.Visible = False Then
            MostrarControles(hdtpFechaIngreso)
        End If
    End Sub
    Private Sub pdtpFechaIngreso_MouseLeave(sender As Object, e As EventArgs) Handles pdtpFechaIngreso.MouseLeave
        If hdtpFechaIngreso.Visible = True Then
            WaitTimer.Start()
        End If
    End Sub

    ' hope
    Private Sub hdtpFechaIngreso_onDateChanged(newDateTime As Date) Handles hdtpFechaIngreso.onDateChanged
        pdtpFechaIngreso.Value = newDateTime
        OcultarControles(hdtpFechaIngreso)
    End Sub
    Private Sub hdtpFechaIngreso_MouseHover(sender As Object, e As EventArgs) Handles hdtpFechaIngreso.MouseHover
        MostrarControles(hdtpFechaIngreso)
        hdtpFechaIngreso.BringToFront()
        WaitTimer.Stop() ' evitar que se oculte
    End Sub
    Private Sub hdtpFechaIngreso_MouseLeave(sender As Object, e As EventArgs) Handles hdtpFechaIngreso.MouseLeave
        WaitTimer.Start()
    End Sub

#End Region

    Private WithEvents WaitTimer As New Timer With {.Interval = 700, .Enabled = False}
    Private Sub WaitTimerIngreso_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        WaitTimer.Stop()
        OcultarControles(hdtpFechaIngreso, hdtpFechaPublicacion)
    End Sub

#End Region


End Class