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

Public Class FormProveedores
    Inherits Formulario


#Region "Declaraciones"

    Private proveedores As Proveedores ' declarar una instancia de la clase Proveedores
    Private tablaDatabase As String = "proveedores"
    Private tablaDataSet As String = "TablaProveedores"
    Private idFila As Integer

    Private vistaDatos As DataView
    Private libreriaDataSet As DataSet ' DataSet
    Private proveedoresDataAdapter As MySqlDataAdapter ' DataAdapter

#End Region


    ' constructor
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        proveedores = New Proveedores() ' inicializar la instancia de la clase Proveedores
    End Sub


#Region "Form Load1"

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' llamar subrutinas y funciones del metodo LoadData() de la clase Proveedores
        proveedores.LoadData()

        ' inicializaciones
        libreriaDataSet = proveedores.dataSet ' DataSet
        proveedoresDataAdapter = proveedores.dataAdapter ' DataAdapter
        dgvDatos.DataSource = proveedores.dataView ' cargar DataGridView

        ' subrutinas
        ConfigurarDataGridView(dgvDatos) ' modificar DataGridView
        CargarComboBoxProveedoresEstados() ' cargar el ComboBox de proveedores
        OcultarControles(hdtpFechaRegistro) ' ocultar TimePickers
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos) ' ocultar paneles
        Cancelar() ' activar botones por defecto
    End Sub

#End Region


#Region "DataGridView: carga de datos a los controles"

    ' 1. cargar datos de la tabla proveedores hacia los controles
    Private Sub CargarDatosClientes()
        Dim fila As DataGridViewRow = dgvDatos.CurrentRow
        idFila = fila.Cells(0).Value

        CargarControles(fila, proveedores.controlesColumnasProveedores, Me)
    End Sub

    ' 2. cargar datos de proveedores hacia el ComboBox
    Private Sub CargarComboBoxProveedoresEstados()
        ' crear una lista con todos los valores posibles del ENUM
        Dim estados As New List(Of String) From {"Activo", "Inactivo", "Suspendido"}

        ' Asignar los datos al ComboBox
        acbEstado.DataSource = estados
    End Sub

    ' 3. mostrar datos seleccionados
    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Dim vistaDatos = proveedores.dataView
        If vistaDatos.Count > 0 Then
            CargarDatosClientes()
        End If
    End Sub

    ' 4. configurar DataGridView
    Private Sub ConfigurarDataGridView(dgv As System.Windows.Forms.DataGridView)
        dgv.Columns(0).Width = 30 ' clave con width más corto
        'dgv.Columns(3).Width = 125 ' en DataGridView del diseño ir a una propiedad llamada AutoSizeColumsMode y cambiar None por Fill

        dgv.Size = New Size(1378, 825)
        dgv.Location = New Point(10, 10)

        dgv.CurrentCell = dgv.Rows(0).Cells(1) ' indicar que por defecto la primera celda (de la primera fila) quede seleccionada. en las propiedades de DataGridView ir a multiselect y colocarlo como False, luego en SelectedMode elegir FullRowSelect

        ' nombre de cada columna
        With dgv
            .Columns("id").HeaderText = "ID"
            .Columns("nombre").HeaderText = "Nombre"
            .Columns("contactoPrincipal").HeaderText = "Contacto principal"
            .Columns("estado").HeaderText = "Estado"
            .Columns("email").HeaderText = "Email"
            .Columns("telefono").HeaderText = "Teléfono"
            .Columns("fechaRegistro").HeaderText = "Fecha de registro"
            .Columns("codigoPostal").HeaderText = "Código postal"
            .Columns("provincia").HeaderText = "Provincia"
            .Columns("ciudad").HeaderText = "Ciudad"
            .Columns("direccion").HeaderText = "Dirección"
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
            Case "contactoPrincipal"
                filtro = "contactoPrincipal LIKE '" & htbcBuscar.Text & "%'"
            Case "provincia"
                filtro = "provincia LIKE '" & htbcBuscar.Text & "%'"
            Case "ciudad"
                filtro = "ciudad LIKE '" & htbcBuscar.Text & "%'"
            Case "codigoPostal"
                filtro = "codigoPostal LIKE '" & htbcBuscar.Text & "%'"
        End Select

        Dim vistaDatos = proveedores.dataView
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
        OcultarPanelesBusqueda()
    End Sub
    Private Sub ibtnBusquedaCriterioContactoPrincipal_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterioContactoPrincipal.Click
        criterioBusqueda = "contactoPrincipal"
        OcultarBusquedaCriterios()
        MostrarControles(ibtnBusquedaContactoPrincipal)
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
    Private Sub FormProveedores_Load4(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarControles(ibtnBusquedaNombre, ibtnBusquedaContactoPrincipal, ibtnBusquedaCodigoPostal, ibtnBusquedaProvincia, ibtnBusquedaCiudad)
    End Sub
    Private Sub ibtnBusqueda_Click(sender As Object, e As EventArgs) Handles ibtnBusquedaCriterio.Click, ibtnBusquedaNombre.Click, ibtnBusquedaContactoPrincipal.Click, ibtnBusquedaCodigoPostal.Click, ibtnBusquedaProvincia.Click, ibtnBusquedaCiudad.Click
        MostrarControles(pnlCriterioBusquedaMenu) ' mostrar panel cada vez que se haga click en alguno de los ibtnBusquedaCriterio
    End Sub

    ' ocultar
    'Private Sub FormProveedores_Load3(sender As Object, e As EventArgs) Handles MyBase.Load
    '    OcultarBusquedaCriterios()
    'End Sub
    Private Sub OcultarBusquedaCriterios()
        OcultarControles(ibtnBusquedaNombre, ibtnBusquedaContactoPrincipal, ibtnBusquedaCodigoPostal, ibtnBusquedaProvincia, ibtnBusquedaCiudad)
    End Sub
    Private Sub OcultarPanelesBusqueda()
        OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
    End Sub

#End Region

#End Region


#Region "Diccionarios"
    Private datosFilasProveedores As Hashtable
    Private controlesProveedores As Dictionary(Of System.Windows.Forms.Control, String)

    Private Sub InicilizarDiccionarios()
        ' diccionario para validar entradas, con el nombre del cotrol del formulario y el texto que aparecerá en pantalla
        controlesProveedores = New Dictionary(Of System.Windows.Forms.Control, String) From {
            {htbcNombre, "nombre"},
            {htbcContactoPrincipal, "contacto principal"},
            {acbEstado, "estado"},
            {htbcEmail, "email"},
            {htbcTelefono, "teléfono"},
            {pdtpFechaRegistro, "fecha de registro"},
            {htbcCodigoPostal, "código postal"},
            {htbcProvincia, "provincia"},
            {htbcCiudad, "ciudad"},
            {htbcDireccion, "dirección"}
        }
        ' diccionario con los datos de las filas
        Dim fechaRegistro As DateTime = pdtpFechaRegistro.Value
        datosFilasProveedores = New Hashtable From {
            {"nombre", htbcNombre.Text},
            {"contactoPrincipal", htbcContactoPrincipal.Text},
            {"estado", acbEstado.Text},
            {"email", htbcEmail.Text},
            {"telefono", htbcTelefono.Text},
            {"fechaRegistro", fechaRegistro},
            {"provincia", htbcProvincia.Text},
            {"ciudad", htbcCiudad.Text},
            {"direccion", htbcDireccion.Text},
            {"codigoPostal", htbcCodigoPostal.Text}
        }
    End Sub

#End Region


#Region "Agregar, editar, guardar, borrar, cancelar"

    Private esNuevoRegistro As Boolean

    Private Sub ibtnAgregar_Click(sender As Object, e As EventArgs) Handles ibtnAgregar.Click
        esNuevoRegistro = True

        VaciarControles(proveedores.nombresControlesProveedores, Me)
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

        InicilizarDiccionarios()

        If Not validarEntradas(controlesProveedores) Then
            Return
        End If

        If esNuevoRegistro Then ' cargar datos para el nuevo registro (fila)
            InsertarRegistro(tablaDatabase, tablaDataSet, datosFilasProveedores)
            OcultarControles(pnlCriterioBusquedaMenu, pnlExportar, pnlDatos)
        Else ' editar registro (fila) existente
            EditarRegistro(tablaDatabase, tablaDataSet, idFila, datosFilasProveedores)
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

    Private Sub FormProveedores_Load2(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Suscribirse al evento Resize del formulario
        AddHandler Me.Resize, AddressOf FormProveedores_Resize

        ' Suscribirse al evento SizeChanged del panel contenedor
        AddHandler pnlContenedorExportarAgregarEditarBorrar.SizeChanged, AddressOf pnlContenedorExportarAgregarEditarBorrar_SizeChanged

        ' Ajustar la posición inicial del panel
        ActualizarPosicionSubmenu()
    End Sub

    Private Sub FormProveedores_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

    ' Fecha registro

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


    Private WithEvents WaitTimer As New Timer With {.Interval = 700, .Enabled = False}
    Private Sub WaitTimerRegistro_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        WaitTimer.Stop()
        OcultarControles(hdtpFechaRegistro)
    End Sub

#End Region


End Class