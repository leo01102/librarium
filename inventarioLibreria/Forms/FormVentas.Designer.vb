<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentas
    'Inherits System.Windows.Forms.Form
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
        pnlBarra = New Panel()
        lblBusquedaFechaVentaAño = New Label()
        hnudcBuesquedaAño = New ReaLTaiizor.Controls.HopeNumericCustom()
        lblBusquedaPrecioMaximo = New Label()
        hnudcPrecioMaximo = New ReaLTaiizor.Controls.HopeNumericCustom()
        lblBusquedaPrecioMinimo = New Label()
        hnudcPrecioMinimo = New ReaLTaiizor.Controls.HopeNumericCustom()
        pnlContenedorExportarAgregarEditarBorrar = New Panel()
        ibtnEditar = New FontAwesome.Sharp.IconButton()
        ibtnExportar = New FontAwesome.Sharp.IconButton()
        ibtnBorrar = New FontAwesome.Sharp.IconButton()
        ibtnAgregar = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        htbcBuscar = New TextBox()
        ibtnBusquedaCliente = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaPrecio = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterio = New FontAwesome.Sharp.IconButton()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        ibtnBusquedaFechaVenta = New FontAwesome.Sharp.IconButton()
        htbcBuscarParent = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        ibtnBusquedaLibro = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCantidad = New FontAwesome.Sharp.IconButton()
        pnlExportar = New Panel()
        ibtnExportarCSV = New FontAwesome.Sharp.IconButton()
        ibtnExportarXLSX = New FontAwesome.Sharp.IconButton()
        pnlContenedor = New Panel()
        dgvDatos = New ReaLTaiizor.Controls.PoisonDataGridView()
        pnlDatos = New Panel()
        Panel1 = New Panel()
        Panel6 = New Panel()
        htbcTotalVenta = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        ibtnCalcularTotalVenta = New FontAwesome.Sharp.IconButton()
        lblStock = New Label()
        ibtnBuscarStockPrecio = New FontAwesome.Sharp.IconButton()
        hdtpFechaVenta = New ReaLTaiizor.Controls.HopeDatePicker()
        Panel3 = New Panel()
        ibtnGuardar = New FontAwesome.Sharp.IconButton()
        ibtnCancelar = New FontAwesome.Sharp.IconButton()
        htbcLibro = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcCliente = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        hnudCantidad = New ReaLTaiizor.Controls.HopeNumeric()
        hnudPrecio = New ReaLTaiizor.Controls.HopeNumeric()
        pdtpFechaVenta = New ReaLTaiizor.Controls.PoisonDateTime()
        Label1 = New Label()
        Label2 = New Label()
        Label10 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        pnlCriterioBusquedaMenu = New Panel()
        ibtnBusquedaCriterioPrecio = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioFechaVenta = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioCliente = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioLibro = New FontAwesome.Sharp.IconButton()
        pnlBarra.SuspendLayout()
        pnlContenedorExportarAgregarEditarBorrar.SuspendLayout()
        Panel2.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlExportar.SuspendLayout()
        pnlContenedor.SuspendLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        pnlDatos.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        pnlCriterioBusquedaMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBarra
        ' 
        pnlBarra.BackColor = Color.White
        pnlBarra.Controls.Add(lblBusquedaFechaVentaAño)
        pnlBarra.Controls.Add(hnudcBuesquedaAño)
        pnlBarra.Controls.Add(lblBusquedaPrecioMaximo)
        pnlBarra.Controls.Add(hnudcPrecioMaximo)
        pnlBarra.Controls.Add(lblBusquedaPrecioMinimo)
        pnlBarra.Controls.Add(hnudcPrecioMinimo)
        pnlBarra.Controls.Add(pnlContenedorExportarAgregarEditarBorrar)
        pnlBarra.Controls.Add(Panel2)
        pnlBarra.Dock = DockStyle.Top
        pnlBarra.Location = New Point(0, 0)
        pnlBarra.Name = "pnlBarra"
        pnlBarra.Size = New Size(1400, 55)
        pnlBarra.TabIndex = 18
        ' 
        ' lblBusquedaFechaVentaAño
        ' 
        lblBusquedaFechaVentaAño.AutoSize = True
        lblBusquedaFechaVentaAño.BackColor = Color.Transparent
        lblBusquedaFechaVentaAño.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBusquedaFechaVentaAño.Location = New Point(516, -2)
        lblBusquedaFechaVentaAño.Name = "lblBusquedaFechaVentaAño"
        lblBusquedaFechaVentaAño.Size = New Size(29, 15)
        lblBusquedaFechaVentaAño.TabIndex = 92
        lblBusquedaFechaVentaAño.Text = "Año"
        ' 
        ' hnudcBuesquedaAño
        ' 
        hnudcBuesquedaAño.BackColor = Color.White
        hnudcBuesquedaAño.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudcBuesquedaAño.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudcBuesquedaAño.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudcBuesquedaAño.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudcBuesquedaAño.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudcBuesquedaAño.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudcBuesquedaAño.EnterKey = True
        hnudcBuesquedaAño.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudcBuesquedaAño.ForeColor = Color.Black
        hnudcBuesquedaAño.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudcBuesquedaAño.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudcBuesquedaAño.Location = New Point(484, 13)
        hnudcBuesquedaAño.MaxNum = 2100F
        hnudcBuesquedaAño.MinNum = 0F
        hnudcBuesquedaAño.Name = "hnudcBuesquedaAño"
        hnudcBuesquedaAño.Precision = 0
        hnudcBuesquedaAño.Size = New Size(92, 32)
        hnudcBuesquedaAño.Step = 1F
        hnudcBuesquedaAño.Style = ReaLTaiizor.Controls.HopeNumericCustom.NumericStyle.TopDown
        hnudcBuesquedaAño.TabIndex = 91
        hnudcBuesquedaAño.Text = "HopeNumericCustom1"
        hnudcBuesquedaAño.ValueNumber = 0F
        ' 
        ' lblBusquedaPrecioMaximo
        ' 
        lblBusquedaPrecioMaximo.AutoSize = True
        lblBusquedaPrecioMaximo.BackColor = Color.Transparent
        lblBusquedaPrecioMaximo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBusquedaPrecioMaximo.Location = New Point(588, -2)
        lblBusquedaPrecioMaximo.Name = "lblBusquedaPrecioMaximo"
        lblBusquedaPrecioMaximo.Size = New Size(90, 15)
        lblBusquedaPrecioMaximo.TabIndex = 41
        lblBusquedaPrecioMaximo.Text = "Precio máximo"
        ' 
        ' hnudcPrecioMaximo
        ' 
        hnudcPrecioMaximo.BackColor = Color.White
        hnudcPrecioMaximo.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudcPrecioMaximo.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudcPrecioMaximo.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudcPrecioMaximo.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudcPrecioMaximo.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudcPrecioMaximo.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudcPrecioMaximo.EnterKey = True
        hnudcPrecioMaximo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudcPrecioMaximo.ForeColor = Color.Black
        hnudcPrecioMaximo.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudcPrecioMaximo.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudcPrecioMaximo.Location = New Point(586, 13)
        hnudcPrecioMaximo.MaxNum = 1000000F
        hnudcPrecioMaximo.MinNum = 0F
        hnudcPrecioMaximo.Name = "hnudcPrecioMaximo"
        hnudcPrecioMaximo.Precision = 2
        hnudcPrecioMaximo.Size = New Size(90, 32)
        hnudcPrecioMaximo.Step = 1F
        hnudcPrecioMaximo.Style = ReaLTaiizor.Controls.HopeNumericCustom.NumericStyle.TopDown
        hnudcPrecioMaximo.TabIndex = 89
        hnudcPrecioMaximo.Text = "HopeNumericCustom1"
        hnudcPrecioMaximo.ValueNumber = 0F
        ' 
        ' lblBusquedaPrecioMinimo
        ' 
        lblBusquedaPrecioMinimo.AutoSize = True
        lblBusquedaPrecioMinimo.BackColor = Color.Transparent
        lblBusquedaPrecioMinimo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBusquedaPrecioMinimo.Location = New Point(486, -2)
        lblBusquedaPrecioMinimo.Name = "lblBusquedaPrecioMinimo"
        lblBusquedaPrecioMinimo.Size = New Size(87, 15)
        lblBusquedaPrecioMinimo.TabIndex = 40
        lblBusquedaPrecioMinimo.Text = "Precio mínimo"
        ' 
        ' hnudcPrecioMinimo
        ' 
        hnudcPrecioMinimo.BackColor = Color.White
        hnudcPrecioMinimo.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudcPrecioMinimo.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudcPrecioMinimo.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudcPrecioMinimo.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudcPrecioMinimo.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudcPrecioMinimo.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudcPrecioMinimo.EnterKey = True
        hnudcPrecioMinimo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudcPrecioMinimo.ForeColor = Color.Black
        hnudcPrecioMinimo.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudcPrecioMinimo.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudcPrecioMinimo.Location = New Point(484, 13)
        hnudcPrecioMinimo.MaxNum = 1000000F
        hnudcPrecioMinimo.MinNum = 0F
        hnudcPrecioMinimo.Name = "hnudcPrecioMinimo"
        hnudcPrecioMinimo.Precision = 2
        hnudcPrecioMinimo.Size = New Size(90, 32)
        hnudcPrecioMinimo.Step = 1F
        hnudcPrecioMinimo.Style = ReaLTaiizor.Controls.HopeNumericCustom.NumericStyle.TopDown
        hnudcPrecioMinimo.TabIndex = 90
        hnudcPrecioMinimo.Text = "HopeNumericCustom1"
        hnudcPrecioMinimo.ValueNumber = 0F
        ' 
        ' pnlContenedorExportarAgregarEditarBorrar
        ' 
        pnlContenedorExportarAgregarEditarBorrar.BackColor = Color.Transparent
        pnlContenedorExportarAgregarEditarBorrar.Controls.Add(ibtnEditar)
        pnlContenedorExportarAgregarEditarBorrar.Controls.Add(ibtnExportar)
        pnlContenedorExportarAgregarEditarBorrar.Controls.Add(ibtnBorrar)
        pnlContenedorExportarAgregarEditarBorrar.Controls.Add(ibtnAgregar)
        pnlContenedorExportarAgregarEditarBorrar.Dock = DockStyle.Right
        pnlContenedorExportarAgregarEditarBorrar.Location = New Point(890, 0)
        pnlContenedorExportarAgregarEditarBorrar.Name = "pnlContenedorExportarAgregarEditarBorrar"
        pnlContenedorExportarAgregarEditarBorrar.Size = New Size(510, 55)
        pnlContenedorExportarAgregarEditarBorrar.TabIndex = 36
        ' 
        ' ibtnEditar
        ' 
        ibtnEditar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ibtnEditar.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnEditar.FlatAppearance.BorderSize = 0
        ibtnEditar.FlatStyle = FlatStyle.Flat
        ibtnEditar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ibtnEditar.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen
        ibtnEditar.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnEditar.IconSize = 30
        ibtnEditar.ImageAlign = ContentAlignment.MiddleLeft
        ibtnEditar.Location = New Point(258, 7)
        ibtnEditar.Name = "ibtnEditar"
        ibtnEditar.Size = New Size(115, 40)
        ibtnEditar.TabIndex = 23
        ibtnEditar.Text = "Editar"
        ibtnEditar.TextAlign = ContentAlignment.MiddleRight
        ibtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnEditar.UseVisualStyleBackColor = False
        ' 
        ' ibtnExportar
        ' 
        ibtnExportar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ibtnExportar.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnExportar.FlatAppearance.BorderSize = 0
        ibtnExportar.FlatStyle = FlatStyle.Flat
        ibtnExportar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ibtnExportar.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnExportar.IconChar = FontAwesome.Sharp.IconChar.FileDownload
        ibtnExportar.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnExportar.IconSize = 30
        ibtnExportar.ImageAlign = ContentAlignment.MiddleLeft
        ibtnExportar.Location = New Point(17, 7)
        ibtnExportar.Name = "ibtnExportar"
        ibtnExportar.Size = New Size(115, 40)
        ibtnExportar.TabIndex = 27
        ibtnExportar.Text = "Exportar"
        ibtnExportar.TextAlign = ContentAlignment.MiddleRight
        ibtnExportar.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnExportar.UseVisualStyleBackColor = False
        ' 
        ' ibtnBorrar
        ' 
        ibtnBorrar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ibtnBorrar.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBorrar.FlatAppearance.BorderSize = 0
        ibtnBorrar.FlatStyle = FlatStyle.Flat
        ibtnBorrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ibtnBorrar.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash
        ibtnBorrar.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBorrar.IconSize = 30
        ibtnBorrar.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBorrar.Location = New Point(379, 7)
        ibtnBorrar.Name = "ibtnBorrar"
        ibtnBorrar.Size = New Size(115, 40)
        ibtnBorrar.TabIndex = 32
        ibtnBorrar.Text = "Borrar"
        ibtnBorrar.TextAlign = ContentAlignment.MiddleRight
        ibtnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBorrar.UseVisualStyleBackColor = False
        ' 
        ' ibtnAgregar
        ' 
        ibtnAgregar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ibtnAgregar.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnAgregar.FlatAppearance.BorderSize = 0
        ibtnAgregar.FlatStyle = FlatStyle.Flat
        ibtnAgregar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ibtnAgregar.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus
        ibtnAgregar.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnAgregar.IconSize = 30
        ibtnAgregar.ImageAlign = ContentAlignment.MiddleLeft
        ibtnAgregar.Location = New Point(137, 6)
        ibtnAgregar.Name = "ibtnAgregar"
        ibtnAgregar.Size = New Size(115, 40)
        ibtnAgregar.TabIndex = 16
        ibtnAgregar.Text = "Agregar"
        ibtnAgregar.TextAlign = ContentAlignment.MiddleRight
        ibtnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnAgregar.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(htbcBuscar)
        Panel2.Controls.Add(ibtnBusquedaCliente)
        Panel2.Controls.Add(ibtnBusquedaPrecio)
        Panel2.Controls.Add(ibtnBusquedaCriterio)
        Panel2.Controls.Add(IconPictureBox1)
        Panel2.Controls.Add(ibtnBusquedaFechaVenta)
        Panel2.Controls.Add(htbcBuscarParent)
        Panel2.Controls.Add(ibtnBusquedaLibro)
        Panel2.Controls.Add(ibtnBusquedaCantidad)
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(475, 55)
        Panel2.TabIndex = 8
        ' 
        ' htbcBuscar
        ' 
        htbcBuscar.BorderStyle = BorderStyle.None
        htbcBuscar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        htbcBuscar.Location = New Point(160, 19)
        htbcBuscar.Name = "htbcBuscar"
        htbcBuscar.Size = New Size(271, 18)
        htbcBuscar.TabIndex = 40
        ' 
        ' ibtnBusquedaCliente
        ' 
        ibtnBusquedaCliente.Anchor = AnchorStyles.None
        ibtnBusquedaCliente.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCliente.FlatAppearance.BorderSize = 0
        ibtnBusquedaCliente.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCliente.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCliente.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCliente.IconChar = FontAwesome.Sharp.IconChar.ContactBook
        ibtnBusquedaCliente.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCliente.IconSize = 25
        ibtnBusquedaCliente.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCliente.Location = New Point(48, 14)
        ibtnBusquedaCliente.Name = "ibtnBusquedaCliente"
        ibtnBusquedaCliente.Size = New Size(107, 28)
        ibtnBusquedaCliente.TabIndex = 80
        ibtnBusquedaCliente.Text = "Cliente"
        ibtnBusquedaCliente.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCliente.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCliente.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaPrecio
        ' 
        ibtnBusquedaPrecio.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaPrecio.FlatAppearance.BorderSize = 0
        ibtnBusquedaPrecio.FlatStyle = FlatStyle.Flat
        ibtnBusquedaPrecio.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaPrecio.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaPrecio.IconChar = FontAwesome.Sharp.IconChar.Usd
        ibtnBusquedaPrecio.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaPrecio.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaPrecio.IconSize = 19
        ibtnBusquedaPrecio.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaPrecio.Location = New Point(48, 14)
        ibtnBusquedaPrecio.Name = "ibtnBusquedaPrecio"
        ibtnBusquedaPrecio.Size = New Size(107, 28)
        ibtnBusquedaPrecio.TabIndex = 48
        ibtnBusquedaPrecio.Text = "Precio"
        ibtnBusquedaPrecio.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaPrecio.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaPrecio.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterio
        ' 
        ibtnBusquedaCriterio.Anchor = AnchorStyles.Right
        ibtnBusquedaCriterio.BackColor = Color.White
        ibtnBusquedaCriterio.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterio.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterio.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterio.IconChar = FontAwesome.Sharp.IconChar.SortDown
        ibtnBusquedaCriterio.IconColor = Color.Black
        ibtnBusquedaCriterio.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterio.IconSize = 24
        ibtnBusquedaCriterio.ImageAlign = ContentAlignment.BottomCenter
        ibtnBusquedaCriterio.Location = New Point(702, -8)
        ibtnBusquedaCriterio.Name = "ibtnBusquedaCriterio"
        ibtnBusquedaCriterio.Size = New Size(25, 25)
        ibtnBusquedaCriterio.TabIndex = 24
        ibtnBusquedaCriterio.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterio.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterio.UseVisualStyleBackColor = False
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.Transparent
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 29
        IconPictureBox1.Location = New Point(14, 15)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(31, 29)
        IconPictureBox1.TabIndex = 6
        IconPictureBox1.TabStop = False
        ' 
        ' ibtnBusquedaFechaVenta
        ' 
        ibtnBusquedaFechaVenta.Anchor = AnchorStyles.None
        ibtnBusquedaFechaVenta.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaFechaVenta.FlatAppearance.BorderSize = 0
        ibtnBusquedaFechaVenta.FlatStyle = FlatStyle.Flat
        ibtnBusquedaFechaVenta.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaFechaVenta.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaFechaVenta.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        ibtnBusquedaFechaVenta.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaFechaVenta.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaFechaVenta.IconSize = 20
        ibtnBusquedaFechaVenta.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaFechaVenta.Location = New Point(48, 14)
        ibtnBusquedaFechaVenta.Name = "ibtnBusquedaFechaVenta"
        ibtnBusquedaFechaVenta.Size = New Size(107, 28)
        ibtnBusquedaFechaVenta.TabIndex = 82
        ibtnBusquedaFechaVenta.Text = "Fecha"
        ibtnBusquedaFechaVenta.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaFechaVenta.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaFechaVenta.UseVisualStyleBackColor = False
        ' 
        ' htbcBuscarParent
        ' 
        htbcBuscarParent.BackColor = Color.White
        htbcBuscarParent.BaseColor = Color.White
        htbcBuscarParent.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcBuscarParent.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcBuscarParent.Font = New Font("Segoe UI", 12F)
        htbcBuscarParent.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcBuscarParent.Hint = ""
        htbcBuscarParent.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcBuscarParent.Location = New Point(10, 9)
        htbcBuscarParent.MaxLength = 32767
        htbcBuscarParent.Multiline = False
        htbcBuscarParent.Name = "htbcBuscarParent"
        htbcBuscarParent.PasswordChar = ChrW(0)
        htbcBuscarParent.ScrollBars = ScrollBars.None
        htbcBuscarParent.SelectedText = ""
        htbcBuscarParent.SelectionLength = 0
        htbcBuscarParent.SelectionStart = 0
        htbcBuscarParent.Size = New Size(458, 38)
        htbcBuscarParent.TabIndex = 78
        htbcBuscarParent.TabStop = False
        htbcBuscarParent.UseSystemPasswordChar = False
        ' 
        ' ibtnBusquedaLibro
        ' 
        ibtnBusquedaLibro.Anchor = AnchorStyles.None
        ibtnBusquedaLibro.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaLibro.FlatAppearance.BorderSize = 0
        ibtnBusquedaLibro.FlatStyle = FlatStyle.Flat
        ibtnBusquedaLibro.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaLibro.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaLibro.IconChar = FontAwesome.Sharp.IconChar.Book
        ibtnBusquedaLibro.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaLibro.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaLibro.IconSize = 20
        ibtnBusquedaLibro.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaLibro.Location = New Point(48, 14)
        ibtnBusquedaLibro.Name = "ibtnBusquedaLibro"
        ibtnBusquedaLibro.Size = New Size(107, 28)
        ibtnBusquedaLibro.TabIndex = 79
        ibtnBusquedaLibro.Text = "Libro"
        ibtnBusquedaLibro.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaLibro.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaLibro.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCantidad
        ' 
        ibtnBusquedaCantidad.Anchor = AnchorStyles.None
        ibtnBusquedaCantidad.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCantidad.FlatAppearance.BorderSize = 0
        ibtnBusquedaCantidad.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCantidad.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCantidad.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCantidad.IconChar = FontAwesome.Sharp.IconChar.Bookmark
        ibtnBusquedaCantidad.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCantidad.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCantidad.IconSize = 20
        ibtnBusquedaCantidad.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCantidad.Location = New Point(48, 14)
        ibtnBusquedaCantidad.Name = "ibtnBusquedaCantidad"
        ibtnBusquedaCantidad.Size = New Size(107, 28)
        ibtnBusquedaCantidad.TabIndex = 81
        ibtnBusquedaCantidad.Text = "Cantidad"
        ibtnBusquedaCantidad.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCantidad.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCantidad.UseVisualStyleBackColor = False
        ' 
        ' pnlExportar
        ' 
        pnlExportar.AutoScroll = True
        pnlExportar.BackColor = Color.White
        pnlExportar.Controls.Add(ibtnExportarCSV)
        pnlExportar.Controls.Add(ibtnExportarXLSX)
        pnlExportar.Location = New Point(907, 47)
        pnlExportar.Name = "pnlExportar"
        pnlExportar.Size = New Size(115, 85)
        pnlExportar.TabIndex = 35
        ' 
        ' ibtnExportarCSV
        ' 
        ibtnExportarCSV.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnExportarCSV.Dock = DockStyle.Top
        ibtnExportarCSV.FlatAppearance.BorderSize = 0
        ibtnExportarCSV.FlatStyle = FlatStyle.Flat
        ibtnExportarCSV.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ibtnExportarCSV.ForeColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ibtnExportarCSV.IconChar = FontAwesome.Sharp.IconChar.FileCsv
        ibtnExportarCSV.IconColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ibtnExportarCSV.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnExportarCSV.IconSize = 30
        ibtnExportarCSV.ImageAlign = ContentAlignment.MiddleLeft
        ibtnExportarCSV.Location = New Point(0, 40)
        ibtnExportarCSV.Name = "ibtnExportarCSV"
        ibtnExportarCSV.Size = New Size(115, 40)
        ibtnExportarCSV.TabIndex = 30
        ibtnExportarCSV.Text = "CSV"
        ibtnExportarCSV.TextAlign = ContentAlignment.MiddleRight
        ibtnExportarCSV.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnExportarCSV.UseVisualStyleBackColor = False
        ' 
        ' ibtnExportarXLSX
        ' 
        ibtnExportarXLSX.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnExportarXLSX.Dock = DockStyle.Top
        ibtnExportarXLSX.FlatAppearance.BorderSize = 0
        ibtnExportarXLSX.FlatStyle = FlatStyle.Flat
        ibtnExportarXLSX.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ibtnExportarXLSX.ForeColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ibtnExportarXLSX.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        ibtnExportarXLSX.IconColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ibtnExportarXLSX.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnExportarXLSX.IconSize = 30
        ibtnExportarXLSX.ImageAlign = ContentAlignment.MiddleLeft
        ibtnExportarXLSX.Location = New Point(0, 0)
        ibtnExportarXLSX.Name = "ibtnExportarXLSX"
        ibtnExportarXLSX.Size = New Size(115, 40)
        ibtnExportarXLSX.TabIndex = 29
        ibtnExportarXLSX.Text = "Excel"
        ibtnExportarXLSX.TextAlign = ContentAlignment.MiddleRight
        ibtnExportarXLSX.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnExportarXLSX.UseVisualStyleBackColor = False
        ' 
        ' pnlContenedor
        ' 
        pnlContenedor.BackColor = Color.WhiteSmoke
        pnlContenedor.Controls.Add(dgvDatos)
        pnlContenedor.Controls.Add(pnlDatos)
        pnlContenedor.Dock = DockStyle.Fill
        pnlContenedor.Location = New Point(0, 55)
        pnlContenedor.Margin = New Padding(10)
        pnlContenedor.Name = "pnlContenedor"
        pnlContenedor.Size = New Size(1400, 845)
        pnlContenedor.TabIndex = 19
        ' 
        ' dgvDatos
        ' 
        dgvDatos.AllowUserToAddRows = False
        dgvDatos.AllowUserToDeleteRows = False
        dgvDatos.AllowUserToOrderColumns = True
        dgvDatos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(251))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(254), CByte(244), CByte(230))
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        dgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvDatos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDatos.BackgroundColor = Color.White
        dgvDatos.BorderStyle = BorderStyle.None
        dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvDatos.ColumnHeadersHeight = 45
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(254), CByte(244), CByte(230))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvDatos.DefaultCellStyle = DataGridViewCellStyle3
        dgvDatos.EnableHeadersVisualStyles = False
        dgvDatos.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        dgvDatos.GridColor = Color.White
        dgvDatos.Location = New Point(10, 140)
        dgvDatos.Margin = New Padding(10)
        dgvDatos.Name = "dgvDatos"
        dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dgvDatos.RowsDefaultCellStyle = DataGridViewCellStyle5
        dgvDatos.RowTemplate.Height = 35
        dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDatos.Size = New Size(867, 640)
        dgvDatos.TabIndex = 13
        ' 
        ' pnlDatos
        ' 
        pnlDatos.AutoScroll = True
        pnlDatos.BackColor = Color.White
        pnlDatos.Controls.Add(Panel1)
        pnlDatos.Controls.Add(Panel6)
        pnlDatos.Dock = DockStyle.Right
        pnlDatos.Location = New Point(890, 0)
        pnlDatos.Margin = New Padding(50)
        pnlDatos.Name = "pnlDatos"
        pnlDatos.Padding = New Padding(10)
        pnlDatos.Size = New Size(510, 845)
        pnlDatos.TabIndex = 39
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2, 845)
        Panel1.TabIndex = 44
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel6.AutoScroll = True
        Panel6.Controls.Add(htbcTotalVenta)
        Panel6.Controls.Add(ibtnCalcularTotalVenta)
        Panel6.Controls.Add(lblStock)
        Panel6.Controls.Add(ibtnBuscarStockPrecio)
        Panel6.Controls.Add(hdtpFechaVenta)
        Panel6.Controls.Add(Panel3)
        Panel6.Controls.Add(htbcLibro)
        Panel6.Controls.Add(htbcCliente)
        Panel6.Controls.Add(hnudCantidad)
        Panel6.Controls.Add(hnudPrecio)
        Panel6.Controls.Add(pdtpFechaVenta)
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(Label5)
        Panel6.Location = New Point(10, 10)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(488, 825)
        Panel6.TabIndex = 43
        ' 
        ' htbcTotalVenta
        ' 
        htbcTotalVenta.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcTotalVenta.BaseColor = Color.White
        htbcTotalVenta.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcTotalVenta.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcTotalVenta.Enabled = False
        htbcTotalVenta.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        htbcTotalVenta.ForeColor = Color.Black
        htbcTotalVenta.Hint = ""
        htbcTotalVenta.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcTotalVenta.Location = New Point(190, 577)
        htbcTotalVenta.MaxLength = 32767
        htbcTotalVenta.Multiline = False
        htbcTotalVenta.Name = "htbcTotalVenta"
        htbcTotalVenta.PasswordChar = ChrW(0)
        htbcTotalVenta.ScrollBars = ScrollBars.None
        htbcTotalVenta.SelectedText = ""
        htbcTotalVenta.SelectionLength = 0
        htbcTotalVenta.SelectionStart = 0
        htbcTotalVenta.Size = New Size(250, 38)
        htbcTotalVenta.TabIndex = 82
        htbcTotalVenta.TabStop = False
        htbcTotalVenta.UseSystemPasswordChar = False
        ' 
        ' ibtnCalcularTotalVenta
        ' 
        ibtnCalcularTotalVenta.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnCalcularTotalVenta.FlatAppearance.BorderSize = 0
        ibtnCalcularTotalVenta.FlatStyle = FlatStyle.Flat
        ibtnCalcularTotalVenta.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnCalcularTotalVenta.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnCalcularTotalVenta.IconChar = FontAwesome.Sharp.IconChar.MoneyBills
        ibtnCalcularTotalVenta.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnCalcularTotalVenta.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnCalcularTotalVenta.IconSize = 26
        ibtnCalcularTotalVenta.Location = New Point(49, 577)
        ibtnCalcularTotalVenta.Name = "ibtnCalcularTotalVenta"
        ibtnCalcularTotalVenta.Size = New Size(135, 38)
        ibtnCalcularTotalVenta.TabIndex = 81
        ibtnCalcularTotalVenta.Text = "Calcular total"
        ibtnCalcularTotalVenta.TextAlign = ContentAlignment.MiddleRight
        ibtnCalcularTotalVenta.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnCalcularTotalVenta.UseVisualStyleBackColor = False
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.BackColor = Color.Transparent
        lblStock.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStock.Location = New Point(193, 386)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(45, 15)
        lblStock.TabIndex = 79
        lblStock.Text = "Stock: "
        ' 
        ' ibtnBuscarStockPrecio
        ' 
        ibtnBuscarStockPrecio.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBuscarStockPrecio.FlatAppearance.BorderSize = 0
        ibtnBuscarStockPrecio.FlatStyle = FlatStyle.Flat
        ibtnBuscarStockPrecio.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ibtnBuscarStockPrecio.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBuscarStockPrecio.IconChar = FontAwesome.Sharp.IconChar.Search
        ibtnBuscarStockPrecio.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBuscarStockPrecio.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBuscarStockPrecio.IconSize = 26
        ibtnBuscarStockPrecio.Location = New Point(402, 164)
        ibtnBuscarStockPrecio.Name = "ibtnBuscarStockPrecio"
        ibtnBuscarStockPrecio.Size = New Size(38, 38)
        ibtnBuscarStockPrecio.TabIndex = 77
        ibtnBuscarStockPrecio.TextAlign = ContentAlignment.MiddleRight
        ibtnBuscarStockPrecio.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBuscarStockPrecio.UseVisualStyleBackColor = False
        ' 
        ' hdtpFechaVenta
        ' 
        hdtpFechaVenta.BackColor = Color.White
        hdtpFechaVenta.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        hdtpFechaVenta.Date = New Date(2024, 7, 8, 0, 0, 0, 0)
        hdtpFechaVenta.DayNames = "LMMJVSD"
        hdtpFechaVenta.DaysTextColor = Color.FromArgb(CByte(96), CByte(98), CByte(102))
        hdtpFechaVenta.DayTextColorA = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hdtpFechaVenta.DayTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hdtpFechaVenta.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hdtpFechaVenta.HeaderFormat = "{1} / {0}"
        hdtpFechaVenta.HeaderTextColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hdtpFechaVenta.HeadLineColor = Color.FromArgb(CByte(228), CByte(231), CByte(237))
        hdtpFechaVenta.HoverColor = Color.FromArgb(CByte(235), CByte(238), CByte(245))
        hdtpFechaVenta.Location = New Point(190, 288)
        hdtpFechaVenta.Name = "hdtpFechaVenta"
        hdtpFechaVenta.NMColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaVenta.NMHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaVenta.NYColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaVenta.NYHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaVenta.PMColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaVenta.PMHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaVenta.PYColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaVenta.PYHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaVenta.SelectedBackColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaVenta.SelectedTextColor = Color.White
        hdtpFechaVenta.Size = New Size(250, 270)
        hdtpFechaVenta.TabIndex = 65
        hdtpFechaVenta.Text = "dpFecha"
        hdtpFechaVenta.ValueTextColor = Color.FromArgb(CByte(43), CByte(133), CByte(228))
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(ibtnGuardar)
        Panel3.Controls.Add(ibtnCancelar)
        Panel3.Location = New Point(16, 724)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(451, 72)
        Panel3.TabIndex = 32
        ' 
        ' ibtnGuardar
        ' 
        ibtnGuardar.Anchor = AnchorStyles.None
        ibtnGuardar.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnGuardar.FlatAppearance.BorderSize = 0
        ibtnGuardar.FlatStyle = FlatStyle.Flat
        ibtnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnGuardar.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileUpload
        ibtnGuardar.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnGuardar.IconSize = 30
        ibtnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        ibtnGuardar.Location = New Point(89, 15)
        ibtnGuardar.Margin = New Padding(3, 3, 3, 100)
        ibtnGuardar.Name = "ibtnGuardar"
        ibtnGuardar.Size = New Size(115, 46)
        ibtnGuardar.TabIndex = 31
        ibtnGuardar.Text = "Guardar"
        ibtnGuardar.TextAlign = ContentAlignment.MiddleRight
        ibtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnGuardar.UseVisualStyleBackColor = False
        ' 
        ' ibtnCancelar
        ' 
        ibtnCancelar.Anchor = AnchorStyles.None
        ibtnCancelar.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnCancelar.FlatAppearance.BorderSize = 0
        ibtnCancelar.FlatStyle = FlatStyle.Flat
        ibtnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnCancelar.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Multiply
        ibtnCancelar.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnCancelar.IconSize = 30
        ibtnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        ibtnCancelar.Location = New Point(251, 15)
        ibtnCancelar.Name = "ibtnCancelar"
        ibtnCancelar.Size = New Size(115, 46)
        ibtnCancelar.TabIndex = 30
        ibtnCancelar.Text = "Cancelar"
        ibtnCancelar.TextAlign = ContentAlignment.MiddleRight
        ibtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' htbcLibro
        ' 
        htbcLibro.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcLibro.BaseColor = Color.White
        htbcLibro.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcLibro.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcLibro.Font = New Font("Segoe UI", 12F)
        htbcLibro.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcLibro.Hint = ""
        htbcLibro.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcLibro.Location = New Point(190, 164)
        htbcLibro.MaxLength = 32767
        htbcLibro.Multiline = False
        htbcLibro.Name = "htbcLibro"
        htbcLibro.PasswordChar = ChrW(0)
        htbcLibro.ScrollBars = ScrollBars.None
        htbcLibro.SelectedText = ""
        htbcLibro.SelectionLength = 0
        htbcLibro.SelectionStart = 0
        htbcLibro.Size = New Size(206, 38)
        htbcLibro.TabIndex = 75
        htbcLibro.TabStop = False
        htbcLibro.UseSystemPasswordChar = False
        ' 
        ' htbcCliente
        ' 
        htbcCliente.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcCliente.BaseColor = Color.White
        htbcCliente.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCliente.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCliente.Font = New Font("Segoe UI", 12F)
        htbcCliente.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcCliente.Hint = ""
        htbcCliente.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcCliente.Location = New Point(190, 72)
        htbcCliente.MaxLength = 32767
        htbcCliente.Multiline = False
        htbcCliente.Name = "htbcCliente"
        htbcCliente.PasswordChar = ChrW(0)
        htbcCliente.ScrollBars = ScrollBars.None
        htbcCliente.SelectedText = ""
        htbcCliente.SelectionLength = 0
        htbcCliente.SelectionStart = 0
        htbcCliente.Size = New Size(250, 38)
        htbcCliente.TabIndex = 74
        htbcCliente.TabStop = False
        htbcCliente.UseSystemPasswordChar = False
        ' 
        ' hnudCantidad
        ' 
        hnudCantidad.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        hnudCantidad.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudCantidad.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudCantidad.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudCantidad.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudCantidad.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudCantidad.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudCantidad.EnterKey = True
        hnudCantidad.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudCantidad.ForeColor = Color.Black
        hnudCantidad.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudCantidad.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudCantidad.Location = New Point(190, 350)
        hnudCantidad.MaxNum = 10000F
        hnudCantidad.MinNum = 1F
        hnudCantidad.Name = "hnudCantidad"
        hnudCantidad.Precision = 0
        hnudCantidad.Size = New Size(250, 32)
        hnudCantidad.Step = 1F
        hnudCantidad.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.TopDown
        hnudCantidad.TabIndex = 70
        hnudCantidad.Text = "hnudNumeroPagina"
        hnudCantidad.ValueNumber = 1F
        ' 
        ' hnudPrecio
        ' 
        hnudPrecio.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        hnudPrecio.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudPrecio.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudPrecio.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudPrecio.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudPrecio.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudPrecio.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudPrecio.Enabled = False
        hnudPrecio.EnterKey = True
        hnudPrecio.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudPrecio.ForeColor = Color.Black
        hnudPrecio.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudPrecio.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudPrecio.Location = New Point(190, 454)
        hnudPrecio.MaxNum = 1000000F
        hnudPrecio.MinNum = 0F
        hnudPrecio.Name = "hnudPrecio"
        hnudPrecio.Precision = 2
        hnudPrecio.Size = New Size(250, 32)
        hnudPrecio.Step = 1F
        hnudPrecio.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.TopDown
        hnudPrecio.TabIndex = 44
        hnudPrecio.Text = "hnudPrecio"
        hnudPrecio.ValueNumber = 0F
        ' 
        ' pdtpFechaVenta
        ' 
        pdtpFechaVenta.CalendarMonthBackground = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        pdtpFechaVenta.Location = New Point(190, 259)
        pdtpFechaVenta.MinimumSize = New Size(0, 29)
        pdtpFechaVenta.Name = "pdtpFechaVenta"
        pdtpFechaVenta.Size = New Size(250, 29)
        pdtpFechaVenta.TabIndex = 66
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(49, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 17)
        Label1.TabIndex = 61
        Label1.Text = "Cliente"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(49, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 17)
        Label2.TabIndex = 59
        Label2.Text = "Libro"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(49, 357)
        Label10.Name = "Label10"
        Label10.Size = New Size(63, 17)
        Label10.TabIndex = 52
        Label10.Text = "Cantidad"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(50, 464)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 17)
        Label7.TabIndex = 54
        Label7.Text = "Precio"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(49, 266)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 17)
        Label5.TabIndex = 58
        Label5.Text = "Fecha de venta"
        ' 
        ' pnlCriterioBusquedaMenu
        ' 
        pnlCriterioBusquedaMenu.AutoScroll = True
        pnlCriterioBusquedaMenu.BackColor = Color.White
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioPrecio)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioFechaVenta)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioCliente)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioLibro)
        pnlCriterioBusquedaMenu.Location = New Point(48, 42)
        pnlCriterioBusquedaMenu.Name = "pnlCriterioBusquedaMenu"
        pnlCriterioBusquedaMenu.Size = New Size(107, 120)
        pnlCriterioBusquedaMenu.TabIndex = 41
        ' 
        ' ibtnBusquedaCriterioPrecio
        ' 
        ibtnBusquedaCriterioPrecio.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioPrecio.Dock = DockStyle.Top
        ibtnBusquedaCriterioPrecio.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioPrecio.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioPrecio.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioPrecio.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioPrecio.IconChar = FontAwesome.Sharp.IconChar.Usd
        ibtnBusquedaCriterioPrecio.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioPrecio.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioPrecio.IconSize = 19
        ibtnBusquedaCriterioPrecio.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioPrecio.Location = New Point(0, 84)
        ibtnBusquedaCriterioPrecio.Name = "ibtnBusquedaCriterioPrecio"
        ibtnBusquedaCriterioPrecio.Size = New Size(107, 28)
        ibtnBusquedaCriterioPrecio.TabIndex = 47
        ibtnBusquedaCriterioPrecio.Text = "Precio"
        ibtnBusquedaCriterioPrecio.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioPrecio.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioPrecio.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioFechaVenta
        ' 
        ibtnBusquedaCriterioFechaVenta.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioFechaVenta.Dock = DockStyle.Top
        ibtnBusquedaCriterioFechaVenta.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioFechaVenta.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioFechaVenta.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioFechaVenta.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioFechaVenta.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        ibtnBusquedaCriterioFechaVenta.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioFechaVenta.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioFechaVenta.IconSize = 20
        ibtnBusquedaCriterioFechaVenta.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioFechaVenta.Location = New Point(0, 56)
        ibtnBusquedaCriterioFechaVenta.Name = "ibtnBusquedaCriterioFechaVenta"
        ibtnBusquedaCriterioFechaVenta.Size = New Size(107, 28)
        ibtnBusquedaCriterioFechaVenta.TabIndex = 46
        ibtnBusquedaCriterioFechaVenta.Text = "Fecha"
        ibtnBusquedaCriterioFechaVenta.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioFechaVenta.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioFechaVenta.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioCliente
        ' 
        ibtnBusquedaCriterioCliente.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioCliente.Dock = DockStyle.Top
        ibtnBusquedaCriterioCliente.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioCliente.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioCliente.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioCliente.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioCliente.IconChar = FontAwesome.Sharp.IconChar.ContactBook
        ibtnBusquedaCriterioCliente.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioCliente.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioCliente.IconSize = 25
        ibtnBusquedaCriterioCliente.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioCliente.Location = New Point(0, 28)
        ibtnBusquedaCriterioCliente.Name = "ibtnBusquedaCriterioCliente"
        ibtnBusquedaCriterioCliente.Size = New Size(107, 28)
        ibtnBusquedaCriterioCliente.TabIndex = 44
        ibtnBusquedaCriterioCliente.Text = "Cliente"
        ibtnBusquedaCriterioCliente.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioCliente.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioCliente.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioLibro
        ' 
        ibtnBusquedaCriterioLibro.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioLibro.Dock = DockStyle.Top
        ibtnBusquedaCriterioLibro.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioLibro.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioLibro.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioLibro.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioLibro.IconChar = FontAwesome.Sharp.IconChar.Book
        ibtnBusquedaCriterioLibro.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioLibro.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioLibro.IconSize = 20
        ibtnBusquedaCriterioLibro.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioLibro.Location = New Point(0, 0)
        ibtnBusquedaCriterioLibro.Name = "ibtnBusquedaCriterioLibro"
        ibtnBusquedaCriterioLibro.Size = New Size(107, 28)
        ibtnBusquedaCriterioLibro.TabIndex = 40
        ibtnBusquedaCriterioLibro.Text = "Libro"
        ibtnBusquedaCriterioLibro.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioLibro.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioLibro.UseVisualStyleBackColor = False
        ' 
        ' FormVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(250), CByte(250))
        ClientSize = New Size(1400, 900)
        Controls.Add(pnlExportar)
        Controls.Add(pnlCriterioBusquedaMenu)
        Controls.Add(pnlContenedor)
        Controls.Add(pnlBarra)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormVentas"
        Text = "FormVentas"
        pnlBarra.ResumeLayout(False)
        pnlBarra.PerformLayout()
        pnlContenedorExportarAgregarEditarBorrar.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlExportar.ResumeLayout(False)
        pnlContenedor.ResumeLayout(False)
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        pnlDatos.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel3.ResumeLayout(False)
        pnlCriterioBusquedaMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBarra As Panel
    Friend WithEvents pnlExportar As Panel
    Friend WithEvents ibtnExportarCSV As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnExportarXLSX As FontAwesome.Sharp.IconButton
    Friend WithEvents lblBusquedaFechaVentaAño As Label
    Friend WithEvents hnudcBuesquedaAño As ReaLTaiizor.Controls.HopeNumericCustom
    Friend WithEvents lblBusquedaPrecioMaximo As Label
    Friend WithEvents hnudcPrecioMaximo As ReaLTaiizor.Controls.HopeNumericCustom
    Friend WithEvents lblBusquedaPrecioMinimo As Label
    Friend WithEvents hnudcPrecioMinimo As ReaLTaiizor.Controls.HopeNumericCustom
    Friend WithEvents pnlContenedorExportarAgregarEditarBorrar As Panel
    Friend WithEvents ibtnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnExportar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBorrar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents htbcBuscar As TextBox
    Friend WithEvents ibtnBusquedaCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaPrecio As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterio As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ibtnBusquedaFechaVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents htbcBuscarParent As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents ibtnBusquedaLibro As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCantidad As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents dgvDatos As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents hdtpFechaVenta As ReaLTaiizor.Controls.HopeDatePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ibtnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents htbcLibro As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcCliente As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents hnudCantidad As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents hnudPrecio As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents pdtpFechaVenta As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlCriterioBusquedaMenu As Panel
    Friend WithEvents ibtnBusquedaCriterioPrecio As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioFechaVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioLibro As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBuscarStockPrecio As FontAwesome.Sharp.IconButton
    Friend WithEvents lblStock As Label
    Friend WithEvents ibtnCalcularTotalVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents htbcTotalVenta As ReaLTaiizor.Controls.HopeTextBoxCustom
End Class
