<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLibros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLibros))
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Panel2 = New Panel()
        htbcBuscar = New TextBox()
        ibtnBusquedaAutor = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaPrecio = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterio = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaFechaPublicacion = New FontAwesome.Sharp.IconButton()
        htbcBuscarParent = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        ibtnBusquedaNombre = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaGenero = New FontAwesome.Sharp.IconButton()
        hnudcBuesquedaAño = New ReaLTaiizor.Controls.HopeNumericCustom()
        dgvDatos = New ReaLTaiizor.Controls.PoisonDataGridView()
        ibtnAgregar = New FontAwesome.Sharp.IconButton()
        pnlBarra = New Panel()
        lblBusquedaFechaPublicacionAño = New Label()
        lblBusquedaPrecioMaximo = New Label()
        hnudcPrecioMaximo = New ReaLTaiizor.Controls.HopeNumericCustom()
        lblBusquedaPrecioMinimo = New Label()
        hnudcPrecioMinimo = New ReaLTaiizor.Controls.HopeNumericCustom()
        pnlContenedorExportarAgregarEditarBorrar = New Panel()
        ibtnEditar = New FontAwesome.Sharp.IconButton()
        ibtnExportar = New FontAwesome.Sharp.IconButton()
        ibtnBorrar = New FontAwesome.Sharp.IconButton()
        pnlExportar = New Panel()
        ibtnExportarCSV = New FontAwesome.Sharp.IconButton()
        ibtnExportarXLSX = New FontAwesome.Sharp.IconButton()
        pnlContenedor = New Panel()
        pnlDatos = New Panel()
        Panel1 = New Panel()
        Panel6 = New Panel()
        htbcProveedor = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        hdtpFechaPublicacion = New ReaLTaiizor.Controls.HopeDatePicker()
        Panel3 = New Panel()
        ibtnGuardar = New FontAwesome.Sharp.IconButton()
        ibtnCancelar = New FontAwesome.Sharp.IconButton()
        hdtpFechaIngreso = New ReaLTaiizor.Controls.HopeDatePicker()
        htbcAutor = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcNombre = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcGenero = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcFormato = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcEditorial = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        hrtbcDescripcion = New ReaLTaiizor.Controls.HopeRichTextBoxCustom()
        hnudNumeroPaginas = New ReaLTaiizor.Controls.HopeNumeric()
        hnudStock = New ReaLTaiizor.Controls.HopeNumeric()
        hnudPrecio = New ReaLTaiizor.Controls.HopeNumeric()
        pdtpFechaIngreso = New ReaLTaiizor.Controls.PoisonDateTime()
        pdtpFechaPublicacion = New ReaLTaiizor.Controls.PoisonDateTime()
        Label12 = New Label()
        Label1 = New Label()
        Label11 = New Label()
        Label2 = New Label()
        Label10 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        pnlCriterioBusquedaMenu = New Panel()
        ibtnBusquedaCriterioPrecio = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioFechaPublicacion = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioGenero = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioAutor = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioNombre = New FontAwesome.Sharp.IconButton()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        pnlBarra.SuspendLayout()
        pnlContenedorExportarAgregarEditarBorrar.SuspendLayout()
        pnlExportar.SuspendLayout()
        pnlContenedor.SuspendLayout()
        pnlDatos.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        pnlCriterioBusquedaMenu.SuspendLayout()
        SuspendLayout()
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
        ' Panel2
        ' 
        Panel2.Controls.Add(htbcBuscar)
        Panel2.Controls.Add(ibtnBusquedaAutor)
        Panel2.Controls.Add(ibtnBusquedaPrecio)
        Panel2.Controls.Add(ibtnBusquedaCriterio)
        Panel2.Controls.Add(IconPictureBox1)
        Panel2.Controls.Add(ibtnBusquedaFechaPublicacion)
        Panel2.Controls.Add(htbcBuscarParent)
        Panel2.Controls.Add(ibtnBusquedaNombre)
        Panel2.Controls.Add(ibtnBusquedaGenero)
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
        ' ibtnBusquedaAutor
        ' 
        ibtnBusquedaAutor.Anchor = AnchorStyles.None
        ibtnBusquedaAutor.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaAutor.FlatAppearance.BorderSize = 0
        ibtnBusquedaAutor.FlatStyle = FlatStyle.Flat
        ibtnBusquedaAutor.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaAutor.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaAutor.IconChar = FontAwesome.Sharp.IconChar.ContactBook
        ibtnBusquedaAutor.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaAutor.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaAutor.IconSize = 25
        ibtnBusquedaAutor.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaAutor.Location = New Point(48, 14)
        ibtnBusquedaAutor.Name = "ibtnBusquedaAutor"
        ibtnBusquedaAutor.Size = New Size(107, 28)
        ibtnBusquedaAutor.TabIndex = 80
        ibtnBusquedaAutor.Text = "Autor"
        ibtnBusquedaAutor.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaAutor.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaAutor.UseVisualStyleBackColor = False
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
        ibtnBusquedaCriterio.Location = New Point(437, 15)
        ibtnBusquedaCriterio.Name = "ibtnBusquedaCriterio"
        ibtnBusquedaCriterio.Size = New Size(25, 25)
        ibtnBusquedaCriterio.TabIndex = 24
        ibtnBusquedaCriterio.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterio.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterio.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaFechaPublicacion
        ' 
        ibtnBusquedaFechaPublicacion.Anchor = AnchorStyles.None
        ibtnBusquedaFechaPublicacion.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaFechaPublicacion.FlatAppearance.BorderSize = 0
        ibtnBusquedaFechaPublicacion.FlatStyle = FlatStyle.Flat
        ibtnBusquedaFechaPublicacion.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaFechaPublicacion.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaFechaPublicacion.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        ibtnBusquedaFechaPublicacion.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaFechaPublicacion.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaFechaPublicacion.IconSize = 20
        ibtnBusquedaFechaPublicacion.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaFechaPublicacion.Location = New Point(48, 14)
        ibtnBusquedaFechaPublicacion.Name = "ibtnBusquedaFechaPublicacion"
        ibtnBusquedaFechaPublicacion.Size = New Size(107, 28)
        ibtnBusquedaFechaPublicacion.TabIndex = 82
        ibtnBusquedaFechaPublicacion.Text = "Publicación"
        ibtnBusquedaFechaPublicacion.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaFechaPublicacion.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaFechaPublicacion.UseVisualStyleBackColor = False
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
        ' ibtnBusquedaNombre
        ' 
        ibtnBusquedaNombre.Anchor = AnchorStyles.None
        ibtnBusquedaNombre.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaNombre.FlatAppearance.BorderSize = 0
        ibtnBusquedaNombre.FlatStyle = FlatStyle.Flat
        ibtnBusquedaNombre.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaNombre.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaNombre.IconChar = FontAwesome.Sharp.IconChar.Book
        ibtnBusquedaNombre.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaNombre.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaNombre.IconSize = 20
        ibtnBusquedaNombre.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaNombre.Location = New Point(48, 14)
        ibtnBusquedaNombre.Name = "ibtnBusquedaNombre"
        ibtnBusquedaNombre.Size = New Size(107, 28)
        ibtnBusquedaNombre.TabIndex = 79
        ibtnBusquedaNombre.Text = "Nombre"
        ibtnBusquedaNombre.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaNombre.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaNombre.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaGenero
        ' 
        ibtnBusquedaGenero.Anchor = AnchorStyles.None
        ibtnBusquedaGenero.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaGenero.FlatAppearance.BorderSize = 0
        ibtnBusquedaGenero.FlatStyle = FlatStyle.Flat
        ibtnBusquedaGenero.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaGenero.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaGenero.IconChar = FontAwesome.Sharp.IconChar.Bookmark
        ibtnBusquedaGenero.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaGenero.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaGenero.IconSize = 20
        ibtnBusquedaGenero.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaGenero.Location = New Point(48, 14)
        ibtnBusquedaGenero.Name = "ibtnBusquedaGenero"
        ibtnBusquedaGenero.Size = New Size(107, 28)
        ibtnBusquedaGenero.TabIndex = 81
        ibtnBusquedaGenero.Text = "Género"
        ibtnBusquedaGenero.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaGenero.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaGenero.UseVisualStyleBackColor = False
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
        dgvDatos.Size = New Size(867, 695)
        dgvDatos.TabIndex = 13
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
        ' pnlBarra
        ' 
        pnlBarra.BackColor = Color.White
        pnlBarra.Controls.Add(lblBusquedaFechaPublicacionAño)
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
        pnlBarra.TabIndex = 17
        ' 
        ' lblBusquedaFechaPublicacionAño
        ' 
        lblBusquedaFechaPublicacionAño.AutoSize = True
        lblBusquedaFechaPublicacionAño.BackColor = Color.Transparent
        lblBusquedaFechaPublicacionAño.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBusquedaFechaPublicacionAño.Location = New Point(516, -2)
        lblBusquedaFechaPublicacionAño.Name = "lblBusquedaFechaPublicacionAño"
        lblBusquedaFechaPublicacionAño.Size = New Size(29, 15)
        lblBusquedaFechaPublicacionAño.TabIndex = 92
        lblBusquedaFechaPublicacionAño.Text = "Año"
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
        pnlContenedor.TabIndex = 18
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
        Panel6.Controls.Add(htbcProveedor)
        Panel6.Controls.Add(hdtpFechaPublicacion)
        Panel6.Controls.Add(Panel3)
        Panel6.Controls.Add(hdtpFechaIngreso)
        Panel6.Controls.Add(htbcAutor)
        Panel6.Controls.Add(htbcNombre)
        Panel6.Controls.Add(htbcGenero)
        Panel6.Controls.Add(htbcFormato)
        Panel6.Controls.Add(htbcEditorial)
        Panel6.Controls.Add(hrtbcDescripcion)
        Panel6.Controls.Add(hnudNumeroPaginas)
        Panel6.Controls.Add(hnudStock)
        Panel6.Controls.Add(hnudPrecio)
        Panel6.Controls.Add(pdtpFechaIngreso)
        Panel6.Controls.Add(pdtpFechaPublicacion)
        Panel6.Controls.Add(Label12)
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(Label9)
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(Label5)
        Panel6.Location = New Point(10, 10)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(488, 825)
        Panel6.TabIndex = 43
        ' 
        ' htbcProveedor
        ' 
        htbcProveedor.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcProveedor.BaseColor = Color.White
        htbcProveedor.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcProveedor.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcProveedor.Font = New Font("Segoe UI", 12F)
        htbcProveedor.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcProveedor.Hint = ""
        htbcProveedor.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcProveedor.Location = New Point(190, 652)
        htbcProveedor.MaxLength = 32767
        htbcProveedor.Multiline = False
        htbcProveedor.Name = "htbcProveedor"
        htbcProveedor.PasswordChar = ChrW(0)
        htbcProveedor.ScrollBars = ScrollBars.None
        htbcProveedor.SelectedText = ""
        htbcProveedor.SelectionLength = 0
        htbcProveedor.SelectionStart = 0
        htbcProveedor.Size = New Size(250, 38)
        htbcProveedor.TabIndex = 76
        htbcProveedor.TabStop = False
        htbcProveedor.UseSystemPasswordChar = False
        ' 
        ' hdtpFechaPublicacion
        ' 
        hdtpFechaPublicacion.BackColor = Color.White
        hdtpFechaPublicacion.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        hdtpFechaPublicacion.Date = New Date(2024, 7, 8, 0, 0, 0, 0)
        hdtpFechaPublicacion.DayNames = "LMMJVSD"
        hdtpFechaPublicacion.DaysTextColor = Color.FromArgb(CByte(96), CByte(98), CByte(102))
        hdtpFechaPublicacion.DayTextColorA = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hdtpFechaPublicacion.DayTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hdtpFechaPublicacion.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hdtpFechaPublicacion.HeaderFormat = "{1} / {0}"
        hdtpFechaPublicacion.HeaderTextColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hdtpFechaPublicacion.HeadLineColor = Color.FromArgb(CByte(228), CByte(231), CByte(237))
        hdtpFechaPublicacion.HoverColor = Color.FromArgb(CByte(235), CByte(238), CByte(245))
        hdtpFechaPublicacion.Location = New Point(190, 314)
        hdtpFechaPublicacion.Name = "hdtpFechaPublicacion"
        hdtpFechaPublicacion.NMColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaPublicacion.NMHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaPublicacion.NYColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaPublicacion.NYHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaPublicacion.PMColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaPublicacion.PMHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaPublicacion.PYColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaPublicacion.PYHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaPublicacion.SelectedBackColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaPublicacion.SelectedTextColor = Color.White
        hdtpFechaPublicacion.Size = New Size(250, 270)
        hdtpFechaPublicacion.TabIndex = 65
        hdtpFechaPublicacion.Text = "dpFecha"
        hdtpFechaPublicacion.ValueTextColor = Color.FromArgb(CByte(43), CByte(133), CByte(228))
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
        ' hdtpFechaIngreso
        ' 
        hdtpFechaIngreso.BackColor = Color.White
        hdtpFechaIngreso.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        hdtpFechaIngreso.Date = New Date(2024, 7, 8, 0, 0, 0, 0)
        hdtpFechaIngreso.DayNames = "LMMJVSD"
        hdtpFechaIngreso.DaysTextColor = Color.FromArgb(CByte(96), CByte(98), CByte(102))
        hdtpFechaIngreso.DayTextColorA = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hdtpFechaIngreso.DayTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hdtpFechaIngreso.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hdtpFechaIngreso.HeaderFormat = "{1} / {0}"
        hdtpFechaIngreso.HeaderTextColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hdtpFechaIngreso.HeadLineColor = Color.FromArgb(CByte(228), CByte(231), CByte(237))
        hdtpFechaIngreso.HoverColor = Color.FromArgb(CByte(235), CByte(238), CByte(245))
        hdtpFechaIngreso.Location = New Point(190, 362)
        hdtpFechaIngreso.Name = "hdtpFechaIngreso"
        hdtpFechaIngreso.NMColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaIngreso.NMHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaIngreso.NYColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaIngreso.NYHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaIngreso.PMColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaIngreso.PMHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaIngreso.PYColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaIngreso.PYHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaIngreso.SelectedBackColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaIngreso.SelectedTextColor = Color.White
        hdtpFechaIngreso.Size = New Size(250, 270)
        hdtpFechaIngreso.TabIndex = 67
        hdtpFechaIngreso.Text = "dpFecha"
        hdtpFechaIngreso.ValueTextColor = Color.FromArgb(CByte(43), CByte(133), CByte(228))
        ' 
        ' htbcAutor
        ' 
        htbcAutor.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcAutor.BaseColor = Color.White
        htbcAutor.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcAutor.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcAutor.Font = New Font("Segoe UI", 12F)
        htbcAutor.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcAutor.Hint = ""
        htbcAutor.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcAutor.Location = New Point(190, 75)
        htbcAutor.MaxLength = 32767
        htbcAutor.Multiline = False
        htbcAutor.Name = "htbcAutor"
        htbcAutor.PasswordChar = ChrW(0)
        htbcAutor.ScrollBars = ScrollBars.None
        htbcAutor.SelectedText = ""
        htbcAutor.SelectionLength = 0
        htbcAutor.SelectionStart = 0
        htbcAutor.Size = New Size(250, 38)
        htbcAutor.TabIndex = 75
        htbcAutor.TabStop = False
        htbcAutor.UseSystemPasswordChar = False
        ' 
        ' htbcNombre
        ' 
        htbcNombre.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcNombre.BaseColor = Color.White
        htbcNombre.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcNombre.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcNombre.Font = New Font("Segoe UI", 12F)
        htbcNombre.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcNombre.Hint = ""
        htbcNombre.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcNombre.Location = New Point(190, 23)
        htbcNombre.MaxLength = 32767
        htbcNombre.Multiline = False
        htbcNombre.Name = "htbcNombre"
        htbcNombre.PasswordChar = ChrW(0)
        htbcNombre.ScrollBars = ScrollBars.None
        htbcNombre.SelectedText = ""
        htbcNombre.SelectionLength = 0
        htbcNombre.SelectionStart = 0
        htbcNombre.Size = New Size(250, 38)
        htbcNombre.TabIndex = 74
        htbcNombre.TabStop = False
        htbcNombre.UseSystemPasswordChar = False
        ' 
        ' htbcGenero
        ' 
        htbcGenero.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcGenero.BaseColor = Color.White
        htbcGenero.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcGenero.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcGenero.Font = New Font("Segoe UI", 12F)
        htbcGenero.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcGenero.Hint = ""
        htbcGenero.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcGenero.Location = New Point(190, 381)
        htbcGenero.MaxLength = 32767
        htbcGenero.Multiline = False
        htbcGenero.Name = "htbcGenero"
        htbcGenero.PasswordChar = ChrW(0)
        htbcGenero.ScrollBars = ScrollBars.None
        htbcGenero.SelectedText = ""
        htbcGenero.SelectionLength = 0
        htbcGenero.SelectionStart = 0
        htbcGenero.Size = New Size(250, 38)
        htbcGenero.TabIndex = 73
        htbcGenero.TabStop = False
        htbcGenero.UseSystemPasswordChar = False
        ' 
        ' htbcFormato
        ' 
        htbcFormato.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcFormato.BaseColor = Color.White
        htbcFormato.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcFormato.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcFormato.Font = New Font("Segoe UI", 12F)
        htbcFormato.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcFormato.Hint = ""
        htbcFormato.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcFormato.Location = New Point(190, 489)
        htbcFormato.MaxLength = 32767
        htbcFormato.Multiline = False
        htbcFormato.Name = "htbcFormato"
        htbcFormato.PasswordChar = ChrW(0)
        htbcFormato.ScrollBars = ScrollBars.None
        htbcFormato.SelectedText = ""
        htbcFormato.SelectionLength = 0
        htbcFormato.SelectionStart = 0
        htbcFormato.Size = New Size(250, 38)
        htbcFormato.TabIndex = 72
        htbcFormato.TabStop = False
        htbcFormato.UseSystemPasswordChar = False
        ' 
        ' htbcEditorial
        ' 
        htbcEditorial.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcEditorial.BaseColor = Color.White
        htbcEditorial.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcEditorial.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcEditorial.Font = New Font("Segoe UI", 12F)
        htbcEditorial.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcEditorial.Hint = ""
        htbcEditorial.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcEditorial.Location = New Point(190, 232)
        htbcEditorial.MaxLength = 32767
        htbcEditorial.Multiline = False
        htbcEditorial.Name = "htbcEditorial"
        htbcEditorial.PasswordChar = ChrW(0)
        htbcEditorial.ScrollBars = ScrollBars.None
        htbcEditorial.SelectedText = ""
        htbcEditorial.SelectionLength = 0
        htbcEditorial.SelectionStart = 0
        htbcEditorial.Size = New Size(250, 38)
        htbcEditorial.TabIndex = 68
        htbcEditorial.TabStop = False
        htbcEditorial.UseSystemPasswordChar = False
        ' 
        ' hrtbcDescripcion
        ' 
        hrtbcDescripcion.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        hrtbcDescripcion.CustomBackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        hrtbcDescripcion.CustomFillPathColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        hrtbcDescripcion.Font = New Font("Segoe UI", 12F)
        hrtbcDescripcion.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hrtbcDescripcion.Hint = ""
        hrtbcDescripcion.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hrtbcDescripcion.Location = New Point(190, 130)
        hrtbcDescripcion.MaximumSize = New Size(250, 85)
        hrtbcDescripcion.MaxLength = 32767
        hrtbcDescripcion.MinimumSize = New Size(250, 38)
        hrtbcDescripcion.Multiline = True
        hrtbcDescripcion.Name = "hrtbcDescripcion"
        hrtbcDescripcion.PasswordChar = ChrW(0)
        hrtbcDescripcion.ScrollBars = ScrollBars.None
        hrtbcDescripcion.SelectedText = ""
        hrtbcDescripcion.SelectionLength = 0
        hrtbcDescripcion.SelectionStart = 0
        hrtbcDescripcion.Size = New Size(250, 63)
        hrtbcDescripcion.TabIndex = 69
        hrtbcDescripcion.TabStop = False
        hrtbcDescripcion.UseSystemPasswordChar = False
        ' 
        ' hnudNumeroPaginas
        ' 
        hnudNumeroPaginas.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        hnudNumeroPaginas.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudNumeroPaginas.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudNumeroPaginas.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudNumeroPaginas.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudNumeroPaginas.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudNumeroPaginas.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudNumeroPaginas.EnterKey = True
        hnudNumeroPaginas.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudNumeroPaginas.ForeColor = Color.Black
        hnudNumeroPaginas.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudNumeroPaginas.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudNumeroPaginas.Location = New Point(190, 439)
        hnudNumeroPaginas.MaxNum = 10000F
        hnudNumeroPaginas.MinNum = 0F
        hnudNumeroPaginas.Name = "hnudNumeroPaginas"
        hnudNumeroPaginas.Precision = 0
        hnudNumeroPaginas.Size = New Size(250, 32)
        hnudNumeroPaginas.Step = 1F
        hnudNumeroPaginas.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.TopDown
        hnudNumeroPaginas.TabIndex = 70
        hnudNumeroPaginas.Text = "hnudNumeroPagina"
        hnudNumeroPaginas.ValueNumber = 0F
        ' 
        ' hnudStock
        ' 
        hnudStock.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        hnudStock.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudStock.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudStock.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudStock.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudStock.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudStock.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudStock.EnterKey = True
        hnudStock.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudStock.ForeColor = Color.Black
        hnudStock.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudStock.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudStock.Location = New Point(190, 600)
        hnudStock.MaxNum = 10000F
        hnudStock.MinNum = 0F
        hnudStock.Name = "hnudStock"
        hnudStock.Precision = 0
        hnudStock.Size = New Size(250, 32)
        hnudStock.Step = 1F
        hnudStock.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.TopDown
        hnudStock.TabIndex = 69
        hnudStock.Text = "hnudStock"
        hnudStock.ValueNumber = 0F
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
        hnudPrecio.EnterKey = True
        hnudPrecio.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudPrecio.ForeColor = Color.Black
        hnudPrecio.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudPrecio.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudPrecio.Location = New Point(190, 546)
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
        ' pdtpFechaIngreso
        ' 
        pdtpFechaIngreso.CalendarMonthBackground = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        pdtpFechaIngreso.Location = New Point(190, 333)
        pdtpFechaIngreso.MinimumSize = New Size(0, 29)
        pdtpFechaIngreso.Name = "pdtpFechaIngreso"
        pdtpFechaIngreso.Size = New Size(250, 29)
        pdtpFechaIngreso.TabIndex = 68
        ' 
        ' pdtpFechaPublicacion
        ' 
        pdtpFechaPublicacion.CalendarMonthBackground = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        pdtpFechaPublicacion.Location = New Point(190, 285)
        pdtpFechaPublicacion.MinimumSize = New Size(0, 29)
        pdtpFechaPublicacion.Name = "pdtpFechaPublicacion"
        pdtpFechaPublicacion.Size = New Size(250, 29)
        pdtpFechaPublicacion.TabIndex = 66
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(50, 663)
        Label12.Name = "Label12"
        Label12.Size = New Size(71, 17)
        Label12.TabIndex = 63
        Label12.Text = "Proveedor"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(49, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 17)
        Label1.TabIndex = 61
        Label1.Text = "Nombre"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(49, 499)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 17)
        Label11.TabIndex = 60
        Label11.Text = "Formato"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(49, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 17)
        Label2.TabIndex = 59
        Label2.Text = "Autor"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(49, 446)
        Label10.Name = "Label10"
        Label10.Size = New Size(129, 17)
        Label10.TabIndex = 52
        Label10.Text = "Número de páginas"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(49, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 17)
        Label3.TabIndex = 62
        Label3.Text = "Descripción"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(49, 391)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 17)
        Label9.TabIndex = 57
        Label9.Text = "Género"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(49, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 17)
        Label4.TabIndex = 56
        Label4.Text = "Editorial"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(50, 610)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 17)
        Label8.TabIndex = 55
        Label8.Text = "Stock"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(50, 556)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 17)
        Label7.TabIndex = 54
        Label7.Text = "Precio"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(49, 340)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 17)
        Label6.TabIndex = 53
        Label6.Text = "Fecha de ingreso"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(49, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 17)
        Label5.TabIndex = 58
        Label5.Text = "Fecha de publicación"
        ' 
        ' pnlCriterioBusquedaMenu
        ' 
        pnlCriterioBusquedaMenu.AutoScroll = True
        pnlCriterioBusquedaMenu.BackColor = Color.White
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioPrecio)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioFechaPublicacion)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioGenero)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioAutor)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioNombre)
        pnlCriterioBusquedaMenu.Location = New Point(48, 42)
        pnlCriterioBusquedaMenu.Name = "pnlCriterioBusquedaMenu"
        pnlCriterioBusquedaMenu.Size = New Size(107, 147)
        pnlCriterioBusquedaMenu.TabIndex = 25
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
        ibtnBusquedaCriterioPrecio.Location = New Point(0, 112)
        ibtnBusquedaCriterioPrecio.Name = "ibtnBusquedaCriterioPrecio"
        ibtnBusquedaCriterioPrecio.Size = New Size(107, 28)
        ibtnBusquedaCriterioPrecio.TabIndex = 47
        ibtnBusquedaCriterioPrecio.Text = "Precio"
        ibtnBusquedaCriterioPrecio.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioPrecio.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioPrecio.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioFechaPublicacion
        ' 
        ibtnBusquedaCriterioFechaPublicacion.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioFechaPublicacion.Dock = DockStyle.Top
        ibtnBusquedaCriterioFechaPublicacion.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioFechaPublicacion.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioFechaPublicacion.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioFechaPublicacion.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioFechaPublicacion.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        ibtnBusquedaCriterioFechaPublicacion.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioFechaPublicacion.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioFechaPublicacion.IconSize = 20
        ibtnBusquedaCriterioFechaPublicacion.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioFechaPublicacion.Location = New Point(0, 84)
        ibtnBusquedaCriterioFechaPublicacion.Name = "ibtnBusquedaCriterioFechaPublicacion"
        ibtnBusquedaCriterioFechaPublicacion.Size = New Size(107, 28)
        ibtnBusquedaCriterioFechaPublicacion.TabIndex = 46
        ibtnBusquedaCriterioFechaPublicacion.Text = "Publicación"
        ibtnBusquedaCriterioFechaPublicacion.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioFechaPublicacion.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioFechaPublicacion.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioGenero
        ' 
        ibtnBusquedaCriterioGenero.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioGenero.Dock = DockStyle.Top
        ibtnBusquedaCriterioGenero.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioGenero.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioGenero.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioGenero.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioGenero.IconChar = FontAwesome.Sharp.IconChar.Bookmark
        ibtnBusquedaCriterioGenero.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioGenero.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioGenero.IconSize = 20
        ibtnBusquedaCriterioGenero.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioGenero.Location = New Point(0, 56)
        ibtnBusquedaCriterioGenero.Name = "ibtnBusquedaCriterioGenero"
        ibtnBusquedaCriterioGenero.Size = New Size(107, 28)
        ibtnBusquedaCriterioGenero.TabIndex = 45
        ibtnBusquedaCriterioGenero.Text = "Género"
        ibtnBusquedaCriterioGenero.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioGenero.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioGenero.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioAutor
        ' 
        ibtnBusquedaCriterioAutor.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioAutor.Dock = DockStyle.Top
        ibtnBusquedaCriterioAutor.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioAutor.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioAutor.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioAutor.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioAutor.IconChar = FontAwesome.Sharp.IconChar.ContactBook
        ibtnBusquedaCriterioAutor.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioAutor.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioAutor.IconSize = 25
        ibtnBusquedaCriterioAutor.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioAutor.Location = New Point(0, 28)
        ibtnBusquedaCriterioAutor.Name = "ibtnBusquedaCriterioAutor"
        ibtnBusquedaCriterioAutor.Size = New Size(107, 28)
        ibtnBusquedaCriterioAutor.TabIndex = 44
        ibtnBusquedaCriterioAutor.Text = "Autor"
        ibtnBusquedaCriterioAutor.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioAutor.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioAutor.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioNombre
        ' 
        ibtnBusquedaCriterioNombre.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioNombre.Dock = DockStyle.Top
        ibtnBusquedaCriterioNombre.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioNombre.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioNombre.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioNombre.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioNombre.IconChar = FontAwesome.Sharp.IconChar.Book
        ibtnBusquedaCriterioNombre.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioNombre.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioNombre.IconSize = 20
        ibtnBusquedaCriterioNombre.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioNombre.Location = New Point(0, 0)
        ibtnBusquedaCriterioNombre.Name = "ibtnBusquedaCriterioNombre"
        ibtnBusquedaCriterioNombre.Size = New Size(107, 28)
        ibtnBusquedaCriterioNombre.TabIndex = 40
        ibtnBusquedaCriterioNombre.Text = "Nombre"
        ibtnBusquedaCriterioNombre.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioNombre.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioNombre.UseVisualStyleBackColor = False
        ' 
        ' FormLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1400, 900)
        ControlBox = False
        Controls.Add(pnlExportar)
        Controls.Add(pnlCriterioBusquedaMenu)
        Controls.Add(pnlContenedor)
        Controls.Add(pnlBarra)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormLibros"
        Text = "FormLibros"
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        pnlBarra.ResumeLayout(False)
        pnlBarra.PerformLayout()
        pnlContenedorExportarAgregarEditarBorrar.ResumeLayout(False)
        pnlExportar.ResumeLayout(False)
        pnlContenedor.ResumeLayout(False)
        pnlDatos.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel3.ResumeLayout(False)
        pnlCriterioBusquedaMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents test As DataGridViewTextBoxColumn
    Friend WithEvents dgvDatos As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents pnlBarra As Panel
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents ibtnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterio As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlCriterioBusquedaMenu As Panel
    Friend WithEvents btnCriterioBusquedaFechaPublicacion As Button
    Friend WithEvents btnCriterioBusquedaGenero As Button
    Friend WithEvents ibtnExportar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnExportarXLSX As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBorrar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlExportar As Panel
    Friend WithEvents pnlContenedorExportarAgregarEditarBorrar As Panel
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents hdtpFechaIngreso As ReaLTaiizor.Controls.HopeDatePicker
    Friend WithEvents pdtpFechaIngreso As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents hdtpFechaPublicacion As ReaLTaiizor.Controls.HopeDatePicker
    Friend WithEvents pdtpFechaPublicacion As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ibtnExportarCSV As FontAwesome.Sharp.IconButton
    Friend WithEvents hnudPrecio As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents hnudStock As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents hnudNumeroPaginas As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents htbcEditorial As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents hrtbcDescripcion As ReaLTaiizor.Controls.HopeRichTextBoxCustom
    Friend WithEvents htbcAutor As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcNombre As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcGenero As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcFormato As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents MaterialComboBox1 As ReaLTaiizor.Controls.MaterialComboBox
    Friend WithEvents ibtnBusquedaCriterioPrecio As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaFechaPublicacion As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCriterioBusquedaAutor As Button
    Friend WithEvents ibtnBusquedaCriterioFechaPublicacion As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioGenero As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioAutor As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioNombre As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaGenero As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaAutor As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaNombre As FontAwesome.Sharp.IconButton
    Friend WithEvents htbcBuscarParent As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents hnudPrecioMinimoo As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents hnudPrecioMaximoo As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents hnudPrecioMinimo2 As NumericUpDown
    Friend WithEvents hnudPrecioMaximo2 As NumericUpDown
    Friend WithEvents hnudPrecioMinimo As ReaLTaiizor.Controls.HopeNumericCustom
    Friend WithEvents hnudcPrecioMaximo As ReaLTaiizor.Controls.HopeNumericCustom
    Friend WithEvents hnudcPrecioMinimo As ReaLTaiizor.Controls.HopeNumericCustom
    Friend WithEvents ibtnBusquedaPrecio As FontAwesome.Sharp.IconButton
    Friend WithEvents htbcBuscar As TextBox
    Friend WithEvents hnudcBuesquedaAño As ReaLTaiizor.Controls.HopeNumericCustom
    Friend WithEvents lblBusquedaPrecioMaximo As Label
    Friend WithEvents lblBusquedaPrecioMinimo As Label
    Friend WithEvents lblBusquedaFechaPublicacionAño As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents htbcProveedor As ReaLTaiizor.Controls.HopeTextBoxCustom
End Class
