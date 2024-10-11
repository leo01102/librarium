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

#End Region

Public Class FormClientes
    Inherits Formulario


#Region "Declaraciones"

    Private clientes As Clientes ' declarar una instancia de la clase Clientes
    Private tablaDatabase As String = "clientes"
    Private tablaDataSet As String = "TablaClientes"
    Private idFila As Integer

    Private vistaDatos As DataView
    Private libreriaDataSet As DataSet ' DataSet
    Private clientesDataAdapter As MySqlDataAdapter ' DataAdapter

#End Region


    ' constructor
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        clientes = New Clientes() ' inicializar la instancia de la clase Clientes
    End Sub


#Region "Form Load1"

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' llamar subrutinas y funciones del metodo LoadData() de la clase Clientes
        clientes.LoadData()

        ' inicializaciones
        libreriaDataSet = clientes.dataSet ' DataSet
        clientesDataAdapter = clientes.dataAdapter ' DataAdapters
        dgvDatos.DataSource = clientes.dataView ' cargar DataGridView

        ' llamadas de subrutinas
        ConfigurarDataGridView(dgvDatos) ' modificar DataGridView
        OcultarControles(hdtpFechaNacimiento, hdtpFechaRegistro) ' ocultar timepickers
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos) ' ocultar paneles
        Cancelar() ' activar botones por defecto
    End Sub

#End Region


#Region "Diccionarios"

    Private controlesClientes As Dictionary(Of System.Windows.Forms.Control, String)
    Private datosFilasClientes As Hashtable
    Private Sub InicializarDiccionarios()
        ' diccionario para validar entradas, con el cotrol del formulario y el texto que aparecerá en pantalla
        controlesClientes = New Dictionary(Of System.Windows.Forms.Control, String) From {
            {htbcNombre, "nombre"},
            {htbcApellido, "apellido"},
            {htbcEmail, "email"},
            {htbcTelefono, "teléfono"},
            {pdtpFechaNacimiento, "fecha de nacimiento"},
            {pdtpFechaRegistro, "fecha de registro"},
            {htbcCodigoPostal, "código postal"},
            {htbcProvincia, "provincia"},
            {htbcCiudad, "ciudad"},
            {htbcDireccion, "dirección"}
        }
        ' datos de las filas
        Dim fechaNacimiento As Date = pdtpFechaNacimiento.Value
        Dim fechaRegistro As Date = pdtpFechaRegistro.Value
        datosFilasClientes = New Hashtable From {
            {"nombre", htbcNombre.Text},
            {"apellido", htbcApellido.Text},
            {"email", htbcEmail.Text},
            {"telefono", htbcTelefono.Text},
            {"fechaNacimiento", fechaNacimiento},
            {"fechaRegistro", fechaRegistro},
            {"codigoPostal", htbcCodigoPostal.Text},
            {"provincia", htbcProvincia.Text},
            {"ciudad", htbcCiudad.Text},
            {"direccion", htbcDireccion.Text}
        }
    End Sub

#End Region


#Region "DataGridView: carga de datos a los controles"
    ' 1. cargar datos de la tabla clientes hacia los controles
    Private Sub CargarDatosClientes()
        Dim fila As DataGridViewRow = dgvDatos.CurrentRow
        idFila = fila.Cells(0).Value

        CargarControles(fila, clientes.controlesColumnasClientes, Me)
    End Sub

    ' 2. mostrar datos seleccionados
    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Dim vistaDatos = clientes.dataView
        If vistaDatos.Count > 0 Then
            CargarDatosClientes()
        End If
    End Sub

    ' 3. Configurar DataGridView
    Public Sub ConfigurarDataGridView(dgv As System.Windows.Forms.DataGridView)
        dgv.Columns(0).Width = 30 ' clave con width más corto
        dgv.Columns(3).Width = 125 ' en DataGridView del diseño ir a una propiedad llamada AutoSizeColumsMode y cambiar None por Fill

        dgv.Size = New Size(1378, 825)
        dgv.Location = New Point(10, 10)

        dgv.CurrentCell = dgv.Rows(0).Cells(1) ' indicar que por defecto la primera celda (de la primera fila) quede seleccionada. en las propiedades de DataGridView ir a multiselect y colocarlo como False, luego en SelectedMode elegir FullRowSelect

        ' nombre de cada columna
        With dgv
            .Columns("id").HeaderText = "ID"
            .Columns("nombre").HeaderText = "Nombre"
            .Columns("apellido").HeaderText = "Apellido"
            .Columns("email").HeaderText = "Email"
            .Columns("telefono").HeaderText = "Teléfono"
            .Columns("direccion").HeaderText = "Dirección"
            .Columns("ciudad").HeaderText = "Ciudad"
            .Columns("provincia").HeaderText = "Provincia"
            .Columns("codigoPostal").HeaderText = "Código postal"
            .Columns("fechaNacimiento").HeaderText = "Fecha de nacimiento"
            .Columns("fechaRegistro").HeaderText = "Fecha de registro"
        End With
    End Sub

#End Region


#Region "Busqueda"

    Private Sub htbcBuscar_TextChanged(sender As Object, e As EventArgs) Handles htbcBuscar.TextChanged
        AplicarFiltro()
    End Sub

    Private criterioBusqueda As String = "nombre" ' criterio por defecto
    Private Sub AplicarFiltro()
        Dim filtro As String = "nombre LIKE '" & htbcBuscar.Text & "%'"

        Select Case criterioBusqueda
            Case "nombre"
                filtro = "nombre LIKE '" & htbcBuscar.Text & "%'"
            Case "apellido"
                filtro = "apellido LIKE '" & htbcBuscar.Text & "%'"
            Case "provincia"
                filtro = "provincia LIKE '" & htbcBuscar.Text & "%'"
            Case "ciudad"
                filtro = "ciudad LIKE '" & htbcBuscar.Text & "%'"
            Case "codigoPostal"
                filtro = "codigoPostal LIKE '" & htbcBuscar.Text & "%'"
        End Select

        Dim vistaDatos = clientes.dataView
        vistaDatos.RowFilter = filtro

        If vistaDatos.Count > 0 Then
            CargarDatosClientes()
        End If
    End Sub

#Region "Botones"

    Private Sub ibtnBusquedaCriterioNombre_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioNombre.Click
        criterioBusqueda = "nombre"
        OcultarBusquedaCriterios() ' ocultar todo
        MostrarControles(ibtnBusquedaNombre) ' mostrar un control en particular
        'ibtnBusquedaNombre.BringToFront()
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioApellido_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioApellido.Click
        criterioBusqueda = "apellido"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaApellido)
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioProvincia_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioProvincia.Click
        criterioBusqueda = "provincia"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaProvincia)
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioCiudad_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioCiudad.Click
        criterioBusqueda = "ciudad"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaCiudad)
        'ibtnBusquedaCiudad.BringToFront()
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioCodigoPostal_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioCodigoPostal.Click
        criterioBusqueda = "codigoPostal"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaCodigoPostal)
        OcultarPanelesBusqueda()
    End Sub

#End Region

#Region "Mostrar, ocultar"

    ' mostrar
    Private Sub FormClientes_Load4(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarControles(ibtnBusquedaNombre, ibtnBusquedaApellido, ibtnBusquedaCodigoPostal, ibtnBusquedaProvincia, ibtnBusquedaCiudad)
    End Sub
    Private Sub ibtnBusqueda_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterio.Click, ibtnBusquedaNombre.Click, ibtnBusquedaApellido.Click, ibtnBusquedaCodigoPostal.Click, ibtnBusquedaProvincia.Click, ibtnBusquedaCiudad.Click
        MostrarControles(pnlCriterioBusquedaMenu) ' mostrar panel cada vez que se haga click en alguno de los ibtnBusquedaCriterio
    End Sub

    ' ocultar
    Private Sub FormClientes_Load3(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarBusquedaCriterios()
    End Sub
    Private Sub OcultarBusquedaCriterios()
        OcultarControles(ibtnBusquedaApellido, ibtnBusquedaProvincia, ibtnBusquedaCodigoPostal)
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

        VaciarControles(clientes.nombresControlesClientes, Me)
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

        If Not validarEntradas(controlesClientes) Then
            Return
        End If

        If esNuevoRegistro Then ' cargar datos para el nuevo registro (fila)
            InsertarRegistro(tablaDatabase, tablaDataSet, datosFilasClientes)
            OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
        Else ' editar registro (fila) existente
            EditarRegistro(tablaDatabase, tablaDataSet, idFila, datosFilasClientes)
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
        CargarDatosClientes()
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

    Private Sub FormClientes_Load2(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Suscribirse al evento Resize del formulario
        AddHandler Me.Resize, AddressOf FormClientes_Resize

        ' Suscribirse al evento SizeChanged del panel contenedor
        AddHandler pnlContenedorExportarAgregarEditarBorrar.SizeChanged, AddressOf pnlContenedorExportarAgregarEditarBorrar_SizeChanged

        ' Ajustar la posición inicial del panel
        ActualizarPosicionSubmenu()
    End Sub

    Private Sub FormClientes_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

#Region "Fecha nacimiento"

    ' poison
    Private Sub pdtpFechaNacimiento_MouseHover(sender As Object, e As EventArgs) Handles pdtpFechaNacimiento.MouseHover
        If hdtpFechaNacimiento.Visible = False Then
            MostrarControles(hdtpFechaNacimiento)
            'Else
            '    hdtpFechaNacimiento.Visible = False
        End If
        pdtpFechaRegistro.SendToBack() ' evitar superposición con el DateTimePicker de la fecha de publicación
    End Sub
    Private Sub pdtpFechaNacimiento_MouseLeave(sender As Object, e As EventArgs) Handles pdtpFechaNacimiento.MouseLeave
        If hdtpFechaNacimiento.Visible = True Then
            WaitTimer.Start()
        End If
    End Sub

    ' hope
    Private Sub hdtpFechaNacimiento_onDateChanged(newDateTime As Date) Handles hdtpFechaNacimiento.onDateChanged
        pdtpFechaNacimiento.Value = newDateTime ' guardar en poison el valor seleccionado en hope
        OcultarControles(hdtpFechaNacimiento)
    End Sub
    Private Sub hdtpFechaNacimiento_MouseHover(sender As Object, e As EventArgs) Handles hdtpFechaNacimiento.MouseHover
        MostrarControles(hdtpFechaNacimiento)
        hdtpFechaNacimiento.BringToFront()
        WaitTimer.Stop() ' evitar que se oculte
    End Sub
    Private Sub hdtpFechaNacimiento_MouseLeave(sender As Object, e As EventArgs) Handles hdtpFechaNacimiento.MouseLeave
        If hdtpFechaNacimiento.Visible = True Then
            WaitTimer.Start()
            OcultarControles(hdtpFechaNacimiento)
        End If
    End Sub

#End Region

#Region "Fecha registro"

    ' poison
    Private Sub pdtpFechaRegistro_MouseHover(sender As Object, e As EventArgs) Handles pdtpFechaRegistro.MouseHover
        If hdtpFechaRegistro.Visible = False Then
            MostrarControles(hdtpFechaRegistro)
            'Else
            '    hdtpFechaRegistro.Visible = False
        End If
    End Sub
    Private Sub pdtpFechaRegistro_MouseLeave(sender As Object, e As EventArgs) Handles pdtpFechaRegistro.MouseLeave
        If hdtpFechaRegistro.Visible = True Then
            WaitTimer.Start()
        End If
    End Sub

    ' hope
    Private Sub hdtpFechaRegistro_onDateChanged(newDateTime As Date) Handles hdtpFechaRegistro.onDateChanged
        pdtpFechaRegistro.Value = newDateTime
        OcultarControles(hdtpFechaRegistro)
    End Sub
    Private Sub hdtpFechaRegistro_MouseHover(sender As Object, e As EventArgs) Handles hdtpFechaRegistro.MouseHover
        MostrarControles(hdtpFechaRegistro)
        hdtpFechaRegistro.BringToFront()
        WaitTimer.Stop() ' evitar que se oculte
    End Sub
    Private Sub hdtpFechaRegistro_MouseLeave(sender As Object, e As EventArgs) Handles hdtpFechaRegistro.MouseLeave
        WaitTimer.Start()
    End Sub

#End Region

    Private WithEvents WaitTimer As New Timer With {.Interval = 700, .Enabled = False}
    Private Sub WaitTimerRegistro_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        WaitTimer.Stop()
        OcultarControles(hdtpFechaRegistro, hdtpFechaNacimiento)
    End Sub

#End Region


End Class