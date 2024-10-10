<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProveedores))
        pnlBarra = New Panel()
        pnlContenedorExportarAgregarEditarBorrar = New Panel()
        ibtnEditar = New FontAwesome.Sharp.IconButton()
        ibtnExportar = New FontAwesome.Sharp.IconButton()
        ibtnBorrar = New FontAwesome.Sharp.IconButton()
        ibtnAgregar = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        ibtnBusquedaNombre = New FontAwesome.Sharp.IconButton()
        htbcBuscar = New TextBox()
        ibtnBusquedaCodigoPostal = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCiudad = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterio = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaContactoPrincipal = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaProvincia = New FontAwesome.Sharp.IconButton()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        htbcBuscarParent = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        pnlContenedor = New Panel()
        dgvDatos = New ReaLTaiizor.Controls.PoisonDataGridView()
        pnlDatos = New Panel()
        Panel1 = New Panel()
        Panel6 = New Panel()
        acbEstado = New ReaLTaiizor.Controls.AloneComboBox()
        Label5 = New Label()
        htbcCodigoPostal = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcCiudad = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcEmail = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        Panel3 = New Panel()
        ibtnGuardar = New FontAwesome.Sharp.IconButton()
        ibtnCancelar = New FontAwesome.Sharp.IconButton()
        hdtpFechaRegistro = New ReaLTaiizor.Controls.HopeDatePicker()
        htbcContactoPrincipal = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcNombre = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcProvincia = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcDireccion = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcTelefono = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        pdtpFechaRegistro = New ReaLTaiizor.Controls.PoisonDateTime()
        Label1 = New Label()
        Label11 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        pnlCriterioBusquedaMenu = New Panel()
        ibtnBusquedaCriterioCodigoPostal = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioCiudad = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioProvincia = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioContactoPrincipal = New FontAwesome.Sharp.IconButton()
        ibtnBusquedaCriterioNombre = New FontAwesome.Sharp.IconButton()
        pnlExportar = New Panel()
        ibtnExportarCSV = New FontAwesome.Sharp.IconButton()
        ibtnExportarXLSX = New FontAwesome.Sharp.IconButton()
        pnlBarra.SuspendLayout()
        pnlContenedorExportarAgregarEditarBorrar.SuspendLayout()
        Panel2.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlContenedor.SuspendLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        pnlDatos.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        pnlCriterioBusquedaMenu.SuspendLayout()
        pnlExportar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBarra
        ' 
        pnlBarra.BackColor = Color.White
        pnlBarra.Controls.Add(pnlContenedorExportarAgregarEditarBorrar)
        pnlBarra.Controls.Add(Panel2)
        pnlBarra.Dock = DockStyle.Top
        pnlBarra.Location = New Point(0, 0)
        pnlBarra.Name = "pnlBarra"
        pnlBarra.Size = New Size(1400, 55)
        pnlBarra.TabIndex = 19
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
        Panel2.Controls.Add(ibtnBusquedaNombre)
        Panel2.Controls.Add(htbcBuscar)
        Panel2.Controls.Add(ibtnBusquedaCodigoPostal)
        Panel2.Controls.Add(ibtnBusquedaCiudad)
        Panel2.Controls.Add(ibtnBusquedaCriterio)
        Panel2.Controls.Add(ibtnBusquedaContactoPrincipal)
        Panel2.Controls.Add(ibtnBusquedaProvincia)
        Panel2.Controls.Add(IconPictureBox1)
        Panel2.Controls.Add(htbcBuscarParent)
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(475, 55)
        Panel2.TabIndex = 8
        ' 
        ' ibtnBusquedaNombre
        ' 
        ibtnBusquedaNombre.Anchor = AnchorStyles.None
        ibtnBusquedaNombre.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaNombre.FlatAppearance.BorderSize = 0
        ibtnBusquedaNombre.FlatStyle = FlatStyle.Flat
        ibtnBusquedaNombre.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaNombre.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaNombre.IconChar = FontAwesome.Sharp.IconChar.User
        ibtnBusquedaNombre.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaNombre.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaNombre.IconSize = 20
        ibtnBusquedaNombre.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaNombre.Location = New Point(48, 14)
        ibtnBusquedaNombre.Name = "ibtnBusquedaNombre"
        ibtnBusquedaNombre.Size = New Size(107, 28)
        ibtnBusquedaNombre.TabIndex = 80
        ibtnBusquedaNombre.Text = "Nombre"
        ibtnBusquedaNombre.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaNombre.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaNombre.UseVisualStyleBackColor = False
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
        ' ibtnBusquedaCodigoPostal
        ' 
        ibtnBusquedaCodigoPostal.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCodigoPostal.FlatAppearance.BorderSize = 0
        ibtnBusquedaCodigoPostal.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCodigoPostal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCodigoPostal.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCodigoPostal.IconChar = FontAwesome.Sharp.IconChar.Envelope
        ibtnBusquedaCodigoPostal.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCodigoPostal.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCodigoPostal.IconSize = 19
        ibtnBusquedaCodigoPostal.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCodigoPostal.Location = New Point(48, 14)
        ibtnBusquedaCodigoPostal.Name = "ibtnBusquedaCodigoPostal"
        ibtnBusquedaCodigoPostal.Size = New Size(107, 28)
        ibtnBusquedaCodigoPostal.TabIndex = 48
        ibtnBusquedaCodigoPostal.Text = "C. postal"
        ibtnBusquedaCodigoPostal.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCodigoPostal.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCodigoPostal.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCiudad
        ' 
        ibtnBusquedaCiudad.Anchor = AnchorStyles.None
        ibtnBusquedaCiudad.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCiudad.FlatAppearance.BorderSize = 0
        ibtnBusquedaCiudad.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCiudad.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCiudad.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCiudad.IconChar = FontAwesome.Sharp.IconChar.City
        ibtnBusquedaCiudad.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCiudad.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCiudad.IconSize = 20
        ibtnBusquedaCiudad.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCiudad.Location = New Point(48, 14)
        ibtnBusquedaCiudad.Name = "ibtnBusquedaCiudad"
        ibtnBusquedaCiudad.Size = New Size(107, 28)
        ibtnBusquedaCiudad.TabIndex = 82
        ibtnBusquedaCiudad.Text = "Ciudad"
        ibtnBusquedaCiudad.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCiudad.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCiudad.UseVisualStyleBackColor = False
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
        ibtnBusquedaCriterio.Location = New Point(967, -31)
        ibtnBusquedaCriterio.Name = "ibtnBusquedaCriterio"
        ibtnBusquedaCriterio.Size = New Size(25, 25)
        ibtnBusquedaCriterio.TabIndex = 24
        ibtnBusquedaCriterio.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterio.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterio.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaContactoPrincipal
        ' 
        ibtnBusquedaContactoPrincipal.Anchor = AnchorStyles.None
        ibtnBusquedaContactoPrincipal.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaContactoPrincipal.FlatAppearance.BorderSize = 0
        ibtnBusquedaContactoPrincipal.FlatStyle = FlatStyle.Flat
        ibtnBusquedaContactoPrincipal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaContactoPrincipal.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaContactoPrincipal.IconChar = FontAwesome.Sharp.IconChar.ContactBook
        ibtnBusquedaContactoPrincipal.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaContactoPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaContactoPrincipal.IconSize = 25
        ibtnBusquedaContactoPrincipal.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaContactoPrincipal.Location = New Point(48, 14)
        ibtnBusquedaContactoPrincipal.Name = "ibtnBusquedaContactoPrincipal"
        ibtnBusquedaContactoPrincipal.Size = New Size(107, 28)
        ibtnBusquedaContactoPrincipal.TabIndex = 80
        ibtnBusquedaContactoPrincipal.Text = "Contacto"
        ibtnBusquedaContactoPrincipal.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaContactoPrincipal.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaContactoPrincipal.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaProvincia
        ' 
        ibtnBusquedaProvincia.Anchor = AnchorStyles.None
        ibtnBusquedaProvincia.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaProvincia.FlatAppearance.BorderSize = 0
        ibtnBusquedaProvincia.FlatStyle = FlatStyle.Flat
        ibtnBusquedaProvincia.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaProvincia.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaProvincia.IconChar = FontAwesome.Sharp.IconChar.Bookmark
        ibtnBusquedaProvincia.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaProvincia.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaProvincia.IconSize = 20
        ibtnBusquedaProvincia.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaProvincia.Location = New Point(48, 14)
        ibtnBusquedaProvincia.Name = "ibtnBusquedaProvincia"
        ibtnBusquedaProvincia.Size = New Size(107, 28)
        ibtnBusquedaProvincia.TabIndex = 81
        ibtnBusquedaProvincia.Text = "Provincia"
        ibtnBusquedaProvincia.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaProvincia.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaProvincia.UseVisualStyleBackColor = False
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
        pnlContenedor.TabIndex = 43
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
        Panel6.Controls.Add(acbEstado)
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(htbcCodigoPostal)
        Panel6.Controls.Add(htbcCiudad)
        Panel6.Controls.Add(htbcEmail)
        Panel6.Controls.Add(Panel3)
        Panel6.Controls.Add(hdtpFechaRegistro)
        Panel6.Controls.Add(htbcContactoPrincipal)
        Panel6.Controls.Add(htbcNombre)
        Panel6.Controls.Add(htbcProvincia)
        Panel6.Controls.Add(htbcDireccion)
        Panel6.Controls.Add(htbcTelefono)
        Panel6.Controls.Add(pdtpFechaRegistro)
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(Label9)
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(10, 10)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(488, 825)
        Panel6.TabIndex = 43
        ' 
        ' acbEstado
        ' 
        acbEstado.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        acbEstado.DrawMode = DrawMode.OwnerDrawFixed
        acbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        acbEstado.EnabledCalc = True
        acbEstado.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        acbEstado.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        acbEstado.FormattingEnabled = True
        acbEstado.ItemHeight = 24
        acbEstado.Location = New Point(190, 150)
        acbEstado.Name = "acbEstado"
        acbEstado.Size = New Size(250, 30)
        acbEstado.TabIndex = 81
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(50, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 17)
        Label5.TabIndex = 79
        Label5.Text = "Estado"
        ' 
        ' htbcCodigoPostal
        ' 
        htbcCodigoPostal.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcCodigoPostal.BaseColor = Color.White
        htbcCodigoPostal.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCodigoPostal.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCodigoPostal.Font = New Font("Segoe UI", 12F)
        htbcCodigoPostal.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcCodigoPostal.Hint = ""
        htbcCodigoPostal.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcCodigoPostal.Location = New Point(190, 402)
        htbcCodigoPostal.MaxLength = 32767
        htbcCodigoPostal.Multiline = False
        htbcCodigoPostal.Name = "htbcCodigoPostal"
        htbcCodigoPostal.PasswordChar = ChrW(0)
        htbcCodigoPostal.ScrollBars = ScrollBars.None
        htbcCodigoPostal.SelectedText = ""
        htbcCodigoPostal.SelectionLength = 0
        htbcCodigoPostal.SelectionStart = 0
        htbcCodigoPostal.Size = New Size(250, 38)
        htbcCodigoPostal.TabIndex = 78
        htbcCodigoPostal.TabStop = False
        htbcCodigoPostal.UseSystemPasswordChar = False
        ' 
        ' htbcCiudad
        ' 
        htbcCiudad.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcCiudad.BaseColor = Color.White
        htbcCiudad.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCiudad.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCiudad.Font = New Font("Segoe UI", 12F)
        htbcCiudad.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcCiudad.Hint = ""
        htbcCiudad.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcCiudad.Location = New Point(191, 536)
        htbcCiudad.MaxLength = 32767
        htbcCiudad.Multiline = False
        htbcCiudad.Name = "htbcCiudad"
        htbcCiudad.PasswordChar = ChrW(0)
        htbcCiudad.ScrollBars = ScrollBars.None
        htbcCiudad.SelectedText = ""
        htbcCiudad.SelectionLength = 0
        htbcCiudad.SelectionStart = 0
        htbcCiudad.Size = New Size(250, 38)
        htbcCiudad.TabIndex = 77
        htbcCiudad.TabStop = False
        htbcCiudad.UseSystemPasswordChar = False
        ' 
        ' htbcEmail
        ' 
        htbcEmail.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcEmail.BaseColor = Color.White
        htbcEmail.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcEmail.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcEmail.Font = New Font("Segoe UI", 12F)
        htbcEmail.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcEmail.Hint = ""
        htbcEmail.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcEmail.Location = New Point(190, 205)
        htbcEmail.MaxLength = 32767
        htbcEmail.Multiline = False
        htbcEmail.Name = "htbcEmail"
        htbcEmail.PasswordChar = ChrW(0)
        htbcEmail.ScrollBars = ScrollBars.None
        htbcEmail.SelectedText = ""
        htbcEmail.SelectionLength = 0
        htbcEmail.SelectionStart = 0
        htbcEmail.Size = New Size(250, 38)
        htbcEmail.TabIndex = 76
        htbcEmail.TabStop = False
        htbcEmail.UseSystemPasswordChar = False
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
        ' hdtpFechaRegistro
        ' 
        hdtpFechaRegistro.BackColor = Color.White
        hdtpFechaRegistro.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        hdtpFechaRegistro.Date = New Date(2024, 7, 8, 0, 0, 0, 0)
        hdtpFechaRegistro.DayNames = "LMMJVSD"
        hdtpFechaRegistro.DaysTextColor = Color.FromArgb(CByte(96), CByte(98), CByte(102))
        hdtpFechaRegistro.DayTextColorA = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hdtpFechaRegistro.DayTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hdtpFechaRegistro.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hdtpFechaRegistro.HeaderFormat = "{1} / {0}"
        hdtpFechaRegistro.HeaderTextColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hdtpFechaRegistro.HeadLineColor = Color.FromArgb(CByte(228), CByte(231), CByte(237))
        hdtpFechaRegistro.HoverColor = Color.FromArgb(CByte(235), CByte(238), CByte(245))
        hdtpFechaRegistro.Location = New Point(190, 362)
        hdtpFechaRegistro.Name = "hdtpFechaRegistro"
        hdtpFechaRegistro.NMColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaRegistro.NMHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaRegistro.NYColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaRegistro.NYHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaRegistro.PMColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaRegistro.PMHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaRegistro.PYColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hdtpFechaRegistro.PYHoverColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaRegistro.SelectedBackColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hdtpFechaRegistro.SelectedTextColor = Color.White
        hdtpFechaRegistro.Size = New Size(250, 270)
        hdtpFechaRegistro.TabIndex = 67
        hdtpFechaRegistro.Text = "dpFecha"
        hdtpFechaRegistro.ValueTextColor = Color.FromArgb(CByte(43), CByte(133), CByte(228))
        ' 
        ' htbcContactoPrincipal
        ' 
        htbcContactoPrincipal.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcContactoPrincipal.BaseColor = Color.White
        htbcContactoPrincipal.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcContactoPrincipal.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcContactoPrincipal.Font = New Font("Segoe UI", 12F)
        htbcContactoPrincipal.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcContactoPrincipal.Hint = ""
        htbcContactoPrincipal.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcContactoPrincipal.Location = New Point(190, 84)
        htbcContactoPrincipal.MaxLength = 32767
        htbcContactoPrincipal.Multiline = False
        htbcContactoPrincipal.Name = "htbcContactoPrincipal"
        htbcContactoPrincipal.PasswordChar = ChrW(0)
        htbcContactoPrincipal.ScrollBars = ScrollBars.None
        htbcContactoPrincipal.SelectedText = ""
        htbcContactoPrincipal.SelectionLength = 0
        htbcContactoPrincipal.SelectionStart = 0
        htbcContactoPrincipal.Size = New Size(250, 38)
        htbcContactoPrincipal.TabIndex = 75
        htbcContactoPrincipal.TabStop = False
        htbcContactoPrincipal.UseSystemPasswordChar = False
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
        ' htbcProvincia
        ' 
        htbcProvincia.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcProvincia.BaseColor = Color.White
        htbcProvincia.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcProvincia.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcProvincia.Font = New Font("Segoe UI", 12F)
        htbcProvincia.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcProvincia.Hint = ""
        htbcProvincia.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcProvincia.Location = New Point(191, 469)
        htbcProvincia.MaxLength = 32767
        htbcProvincia.Multiline = False
        htbcProvincia.Name = "htbcProvincia"
        htbcProvincia.PasswordChar = ChrW(0)
        htbcProvincia.ScrollBars = ScrollBars.None
        htbcProvincia.SelectedText = ""
        htbcProvincia.SelectionLength = 0
        htbcProvincia.SelectionStart = 0
        htbcProvincia.Size = New Size(250, 38)
        htbcProvincia.TabIndex = 73
        htbcProvincia.TabStop = False
        htbcProvincia.UseSystemPasswordChar = False
        ' 
        ' htbcDireccion
        ' 
        htbcDireccion.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcDireccion.BaseColor = Color.White
        htbcDireccion.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcDireccion.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcDireccion.Font = New Font("Segoe UI", 12F)
        htbcDireccion.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcDireccion.Hint = ""
        htbcDireccion.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcDireccion.Location = New Point(191, 598)
        htbcDireccion.MaxLength = 32767
        htbcDireccion.Multiline = False
        htbcDireccion.Name = "htbcDireccion"
        htbcDireccion.PasswordChar = ChrW(0)
        htbcDireccion.ScrollBars = ScrollBars.None
        htbcDireccion.SelectedText = ""
        htbcDireccion.SelectionLength = 0
        htbcDireccion.SelectionStart = 0
        htbcDireccion.Size = New Size(250, 38)
        htbcDireccion.TabIndex = 72
        htbcDireccion.TabStop = False
        htbcDireccion.UseSystemPasswordChar = False
        ' 
        ' htbcTelefono
        ' 
        htbcTelefono.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        htbcTelefono.BaseColor = Color.White
        htbcTelefono.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcTelefono.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcTelefono.Font = New Font("Segoe UI", 12F)
        htbcTelefono.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcTelefono.Hint = ""
        htbcTelefono.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcTelefono.Location = New Point(190, 268)
        htbcTelefono.MaxLength = 32767
        htbcTelefono.Multiline = False
        htbcTelefono.Name = "htbcTelefono"
        htbcTelefono.PasswordChar = ChrW(0)
        htbcTelefono.ScrollBars = ScrollBars.None
        htbcTelefono.SelectedText = ""
        htbcTelefono.SelectionLength = 0
        htbcTelefono.SelectionStart = 0
        htbcTelefono.Size = New Size(250, 38)
        htbcTelefono.TabIndex = 68
        htbcTelefono.TabStop = False
        htbcTelefono.UseSystemPasswordChar = False
        ' 
        ' pdtpFechaRegistro
        ' 
        pdtpFechaRegistro.CalendarMonthBackground = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        pdtpFechaRegistro.Location = New Point(190, 333)
        pdtpFechaRegistro.MinimumSize = New Size(0, 29)
        pdtpFechaRegistro.Name = "pdtpFechaRegistro"
        pdtpFechaRegistro.Size = New Size(250, 29)
        pdtpFechaRegistro.TabIndex = 68
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
        Label11.Location = New Point(50, 478)
        Label11.Name = "Label11"
        Label11.Size = New Size(65, 17)
        Label11.TabIndex = 60
        Label11.Text = "Provincia"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(49, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 17)
        Label2.TabIndex = 59
        Label2.Text = "Contacto principal"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(50, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 17)
        Label3.TabIndex = 62
        Label3.Text = "Email"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(50, 608)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 17)
        Label9.TabIndex = 57
        Label9.Text = "Dirección"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(49, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 17)
        Label4.TabIndex = 56
        Label4.Text = "Teléfono"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(50, 412)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 17)
        Label8.TabIndex = 55
        Label8.Text = "Código postal"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(51, 546)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 17)
        Label7.TabIndex = 54
        Label7.Text = "Ciudad"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(49, 340)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 17)
        Label6.TabIndex = 53
        Label6.Text = "Fecha de registro"
        ' 
        ' pnlCriterioBusquedaMenu
        ' 
        pnlCriterioBusquedaMenu.AutoScroll = True
        pnlCriterioBusquedaMenu.BackColor = Color.White
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioCodigoPostal)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioCiudad)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioProvincia)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioContactoPrincipal)
        pnlCriterioBusquedaMenu.Controls.Add(ibtnBusquedaCriterioNombre)
        pnlCriterioBusquedaMenu.Location = New Point(48, 42)
        pnlCriterioBusquedaMenu.Name = "pnlCriterioBusquedaMenu"
        pnlCriterioBusquedaMenu.Size = New Size(107, 147)
        pnlCriterioBusquedaMenu.TabIndex = 44
        ' 
        ' ibtnBusquedaCriterioCodigoPostal
        ' 
        ibtnBusquedaCriterioCodigoPostal.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioCodigoPostal.Dock = DockStyle.Top
        ibtnBusquedaCriterioCodigoPostal.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioCodigoPostal.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioCodigoPostal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioCodigoPostal.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioCodigoPostal.IconChar = FontAwesome.Sharp.IconChar.Envelope
        ibtnBusquedaCriterioCodigoPostal.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioCodigoPostal.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioCodigoPostal.IconSize = 19
        ibtnBusquedaCriterioCodigoPostal.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioCodigoPostal.Location = New Point(0, 112)
        ibtnBusquedaCriterioCodigoPostal.Name = "ibtnBusquedaCriterioCodigoPostal"
        ibtnBusquedaCriterioCodigoPostal.Size = New Size(107, 28)
        ibtnBusquedaCriterioCodigoPostal.TabIndex = 47
        ibtnBusquedaCriterioCodigoPostal.Text = "C. postal"
        ibtnBusquedaCriterioCodigoPostal.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioCodigoPostal.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioCodigoPostal.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioCiudad
        ' 
        ibtnBusquedaCriterioCiudad.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioCiudad.Dock = DockStyle.Top
        ibtnBusquedaCriterioCiudad.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioCiudad.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioCiudad.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioCiudad.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioCiudad.IconChar = FontAwesome.Sharp.IconChar.City
        ibtnBusquedaCriterioCiudad.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioCiudad.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioCiudad.IconSize = 20
        ibtnBusquedaCriterioCiudad.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioCiudad.Location = New Point(0, 84)
        ibtnBusquedaCriterioCiudad.Name = "ibtnBusquedaCriterioCiudad"
        ibtnBusquedaCriterioCiudad.Size = New Size(107, 28)
        ibtnBusquedaCriterioCiudad.TabIndex = 46
        ibtnBusquedaCriterioCiudad.Text = "Ciudad"
        ibtnBusquedaCriterioCiudad.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioCiudad.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioCiudad.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioProvincia
        ' 
        ibtnBusquedaCriterioProvincia.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioProvincia.Dock = DockStyle.Top
        ibtnBusquedaCriterioProvincia.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioProvincia.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioProvincia.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioProvincia.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioProvincia.IconChar = FontAwesome.Sharp.IconChar.Bookmark
        ibtnBusquedaCriterioProvincia.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioProvincia.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioProvincia.IconSize = 20
        ibtnBusquedaCriterioProvincia.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioProvincia.Location = New Point(0, 56)
        ibtnBusquedaCriterioProvincia.Name = "ibtnBusquedaCriterioProvincia"
        ibtnBusquedaCriterioProvincia.Size = New Size(107, 28)
        ibtnBusquedaCriterioProvincia.TabIndex = 45
        ibtnBusquedaCriterioProvincia.Text = "Provincia"
        ibtnBusquedaCriterioProvincia.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioProvincia.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioProvincia.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioContactoPrincipal
        ' 
        ibtnBusquedaCriterioContactoPrincipal.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioContactoPrincipal.Dock = DockStyle.Top
        ibtnBusquedaCriterioContactoPrincipal.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioContactoPrincipal.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioContactoPrincipal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioContactoPrincipal.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioContactoPrincipal.IconChar = FontAwesome.Sharp.IconChar.ContactBook
        ibtnBusquedaCriterioContactoPrincipal.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioContactoPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnBusquedaCriterioContactoPrincipal.IconSize = 25
        ibtnBusquedaCriterioContactoPrincipal.ImageAlign = ContentAlignment.MiddleLeft
        ibtnBusquedaCriterioContactoPrincipal.Location = New Point(0, 28)
        ibtnBusquedaCriterioContactoPrincipal.Name = "ibtnBusquedaCriterioContactoPrincipal"
        ibtnBusquedaCriterioContactoPrincipal.Size = New Size(107, 28)
        ibtnBusquedaCriterioContactoPrincipal.TabIndex = 44
        ibtnBusquedaCriterioContactoPrincipal.Text = "Contacto"
        ibtnBusquedaCriterioContactoPrincipal.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterioContactoPrincipal.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterioContactoPrincipal.UseVisualStyleBackColor = False
        ' 
        ' ibtnBusquedaCriterioNombre
        ' 
        ibtnBusquedaCriterioNombre.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnBusquedaCriterioNombre.Dock = DockStyle.Top
        ibtnBusquedaCriterioNombre.FlatAppearance.BorderSize = 0
        ibtnBusquedaCriterioNombre.FlatStyle = FlatStyle.Flat
        ibtnBusquedaCriterioNombre.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnBusquedaCriterioNombre.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnBusquedaCriterioNombre.IconChar = FontAwesome.Sharp.IconChar.User
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
        ' pnlExportar
        ' 
        pnlExportar.AutoScroll = True
        pnlExportar.BackColor = Color.White
        pnlExportar.Controls.Add(ibtnExportarCSV)
        pnlExportar.Controls.Add(ibtnExportarXLSX)
        pnlExportar.Location = New Point(907, 47)
        pnlExportar.Name = "pnlExportar"
        pnlExportar.Size = New Size(115, 85)
        pnlExportar.TabIndex = 45
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
        ' FormProveedores
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
        Name = "FormProveedores"
        Text = "FormProveedores"
        pnlBarra.ResumeLayout(False)
        pnlContenedorExportarAgregarEditarBorrar.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlContenedor.ResumeLayout(False)
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        pnlDatos.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel3.ResumeLayout(False)
        pnlCriterioBusquedaMenu.ResumeLayout(False)
        pnlExportar.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBarra As Panel
    Friend WithEvents pnlContenedorExportarAgregarEditarBorrar As Panel
    Friend WithEvents ibtnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnExportar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBorrar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ibtnBusquedaNombre As FontAwesome.Sharp.IconButton
    Friend WithEvents htbcBuscar As TextBox
    Friend WithEvents ibtnBusquedaCodigoPostal As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCiudad As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterio As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaContactoPrincipal As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaProvincia As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents htbcBuscarParent As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents dgvDatos As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents htbcCodigoPostal As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcCiudad As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcEmail As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ibtnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents hdtpFechaRegistro As ReaLTaiizor.Controls.HopeDatePicker
    Friend WithEvents htbcContactoPrincipal As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcNombre As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcProvincia As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcDireccion As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcTelefono As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents pdtpFechaRegistro As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlCriterioBusquedaMenu As Panel
    Friend WithEvents ibtnBusquedaCriterioCodigoPostal As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioCiudad As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioProvincia As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioContactoPrincipal As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnBusquedaCriterioNombre As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlExportar As Panel
    Friend WithEvents ibtnExportarCSV As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnExportarXLSX As FontAwesome.Sharp.IconButton
    Friend WithEvents htbcEstado As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents Label5 As Label
    Friend WithEvents acbEstado As ReaLTaiizor.Controls.AloneComboBox
End Class
