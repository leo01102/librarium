<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportes
    'Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportes))
        dtpFechaInicio = New ReaLTaiizor.Controls.PoisonDateTime()
        dtpFechaFin = New ReaLTaiizor.Controls.PoisonDateTime()
        hcbVentasPorDia = New ReaLTaiizor.Controls.HopeCheckBox()
        hcbLibrosMasVendidos = New ReaLTaiizor.Controls.HopeCheckBox()
        hcbMejoresClientes = New ReaLTaiizor.Controls.HopeCheckBox()
        hcbLibrosConBajoStock = New ReaLTaiizor.Controls.HopeCheckBox()
        ibtnExportarXLSX = New FontAwesome.Sharp.IconButton()
        ibtnExportarCSV = New FontAwesome.Sharp.IconButton()
        ibtnExportar = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        Label2 = New Label()
        hcbLibrosMasVendidosCantidad = New ReaLTaiizor.Controls.HopeCheckBox()
        hcbLibrosMasVendidosMonto = New ReaLTaiizor.Controls.HopeCheckBox()
        hcbMejoresClientesCantidad = New ReaLTaiizor.Controls.HopeCheckBox()
        hcbMejoresClientesMonto = New ReaLTaiizor.Controls.HopeCheckBox()
        dgvDatos = New ReaLTaiizor.Controls.PoisonDataGridView()
        hnudMejoresClientes = New ReaLTaiizor.Controls.HopeNumeric()
        hnudLibrosMasVendidos = New ReaLTaiizor.Controls.HopeNumeric()
        hnudLibrosConBajoStock = New ReaLTaiizor.Controls.HopeNumeric()
        ibtnEjecutarConsulta = New FontAwesome.Sharp.IconButton()
        ParrotGroupBox1 = New ReaLTaiizor.Controls.ParrotGroupBox()
        ParrotGroupBox2 = New ReaLTaiizor.Controls.ParrotGroupBox()
        pnlBar = New Panel()
        Label10 = New Label()
        Panel1 = New Panel()
        ibtnCerrar = New FontAwesome.Sharp.IconButton()
        ibtnMinimizar = New FontAwesome.Sharp.IconButton()
        ibtnMaximizar = New FontAwesome.Sharp.IconButton()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        ParrotGroupBox1.SuspendLayout()
        ParrotGroupBox2.SuspendLayout()
        pnlBar.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.CustomFormat = ""
        dtpFechaInicio.Location = New Point(285, 43)
        dtpFechaInicio.MinimumSize = New Size(0, 29)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(210, 29)
        dtpFechaInicio.TabIndex = 30
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Location = New Point(526, 43)
        dtpFechaFin.MinimumSize = New Size(0, 29)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(210, 29)
        dtpFechaFin.TabIndex = 31
        ' 
        ' hcbVentasPorDia
        ' 
        hcbVentasPorDia.AutoSize = True
        hcbVentasPorDia.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbVentasPorDia.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbVentasPorDia.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbVentasPorDia.Enable = True
        hcbVentasPorDia.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbVentasPorDia.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbVentasPorDia.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbVentasPorDia.Font = New Font("Segoe UI", 12F)
        hcbVentasPorDia.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbVentasPorDia.Location = New Point(35, 48)
        hcbVentasPorDia.Name = "hcbVentasPorDia"
        hcbVentasPorDia.Size = New Size(134, 20)
        hcbVentasPorDia.TabIndex = 32
        hcbVentasPorDia.Text = "Ventas por día"
        hcbVentasPorDia.UseVisualStyleBackColor = True
        ' 
        ' hcbLibrosMasVendidos
        ' 
        hcbLibrosMasVendidos.AutoSize = True
        hcbLibrosMasVendidos.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbLibrosMasVendidos.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbLibrosMasVendidos.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbLibrosMasVendidos.Enable = True
        hcbLibrosMasVendidos.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbLibrosMasVendidos.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbLibrosMasVendidos.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbLibrosMasVendidos.Font = New Font("Segoe UI", 12F)
        hcbLibrosMasVendidos.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbLibrosMasVendidos.Location = New Point(35, 96)
        hcbLibrosMasVendidos.Name = "hcbLibrosMasVendidos"
        hcbLibrosMasVendidos.Size = New Size(178, 20)
        hcbLibrosMasVendidos.TabIndex = 33
        hcbLibrosMasVendidos.Text = "Libros más vendidos"
        hcbLibrosMasVendidos.UseVisualStyleBackColor = True
        ' 
        ' hcbMejoresClientes
        ' 
        hcbMejoresClientes.AutoSize = True
        hcbMejoresClientes.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMejoresClientes.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbMejoresClientes.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbMejoresClientes.Enable = True
        hcbMejoresClientes.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMejoresClientes.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbMejoresClientes.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbMejoresClientes.Font = New Font("Segoe UI", 12F)
        hcbMejoresClientes.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbMejoresClientes.Location = New Point(35, 149)
        hcbMejoresClientes.Name = "hcbMejoresClientes"
        hcbMejoresClientes.Size = New Size(147, 20)
        hcbMejoresClientes.TabIndex = 34
        hcbMejoresClientes.Text = "Mejores clientes"
        hcbMejoresClientes.UseVisualStyleBackColor = True
        ' 
        ' hcbLibrosConBajoStock
        ' 
        hcbLibrosConBajoStock.AutoSize = True
        hcbLibrosConBajoStock.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbLibrosConBajoStock.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbLibrosConBajoStock.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbLibrosConBajoStock.Enable = True
        hcbLibrosConBajoStock.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbLibrosConBajoStock.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbLibrosConBajoStock.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbLibrosConBajoStock.Font = New Font("Segoe UI", 12F)
        hcbLibrosConBajoStock.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbLibrosConBajoStock.Location = New Point(35, 200)
        hcbLibrosConBajoStock.Name = "hcbLibrosConBajoStock"
        hcbLibrosConBajoStock.Size = New Size(189, 20)
        hcbLibrosConBajoStock.TabIndex = 35
        hcbLibrosConBajoStock.Text = "Libros con bajo stockk"
        hcbLibrosConBajoStock.UseVisualStyleBackColor = True
        ' 
        ' ibtnExportarXLSX
        ' 
        ibtnExportarXLSX.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnExportarXLSX.FlatAppearance.BorderSize = 0
        ibtnExportarXLSX.FlatStyle = FlatStyle.Flat
        ibtnExportarXLSX.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ibtnExportarXLSX.ForeColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ibtnExportarXLSX.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        ibtnExportarXLSX.IconColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ibtnExportarXLSX.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnExportarXLSX.IconSize = 30
        ibtnExportarXLSX.ImageAlign = ContentAlignment.MiddleLeft
        ibtnExportarXLSX.Location = New Point(19, 135)
        ibtnExportarXLSX.Name = "ibtnExportarXLSX"
        ibtnExportarXLSX.Size = New Size(115, 40)
        ibtnExportarXLSX.TabIndex = 36
        ibtnExportarXLSX.Text = "Excel"
        ibtnExportarXLSX.TextAlign = ContentAlignment.MiddleRight
        ibtnExportarXLSX.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnExportarXLSX.UseVisualStyleBackColor = False
        ' 
        ' ibtnExportarCSV
        ' 
        ibtnExportarCSV.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnExportarCSV.FlatAppearance.BorderSize = 0
        ibtnExportarCSV.FlatStyle = FlatStyle.Flat
        ibtnExportarCSV.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ibtnExportarCSV.ForeColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ibtnExportarCSV.IconChar = FontAwesome.Sharp.IconChar.FileCsv
        ibtnExportarCSV.IconColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ibtnExportarCSV.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnExportarCSV.IconSize = 30
        ibtnExportarCSV.ImageAlign = ContentAlignment.MiddleLeft
        ibtnExportarCSV.Location = New Point(19, 89)
        ibtnExportarCSV.Name = "ibtnExportarCSV"
        ibtnExportarCSV.Size = New Size(115, 40)
        ibtnExportarCSV.TabIndex = 37
        ibtnExportarCSV.Text = "CSV"
        ibtnExportarCSV.TextAlign = ContentAlignment.MiddleRight
        ibtnExportarCSV.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnExportarCSV.UseVisualStyleBackColor = False
        ' 
        ' ibtnExportar
        ' 
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
        ibtnExportar.Location = New Point(19, 43)
        ibtnExportar.Name = "ibtnExportar"
        ibtnExportar.Size = New Size(115, 40)
        ibtnExportar.TabIndex = 38
        ibtnExportar.Text = "Exportar"
        ibtnExportar.TextAlign = ContentAlignment.MiddleRight
        ibtnExportar.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnExportar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(285, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 39
        Label1.Text = "Desde"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(526, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 40
        Label2.Text = "Hasta"
        ' 
        ' hcbLibrosMasVendidosCantidad
        ' 
        hcbLibrosMasVendidosCantidad.AutoSize = True
        hcbLibrosMasVendidosCantidad.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbLibrosMasVendidosCantidad.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbLibrosMasVendidosCantidad.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbLibrosMasVendidosCantidad.Enable = True
        hcbLibrosMasVendidosCantidad.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbLibrosMasVendidosCantidad.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbLibrosMasVendidosCantidad.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbLibrosMasVendidosCantidad.Font = New Font("Segoe UI", 12F)
        hcbLibrosMasVendidosCantidad.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbLibrosMasVendidosCantidad.Location = New Point(526, 96)
        hcbLibrosMasVendidosCantidad.Name = "hcbLibrosMasVendidosCantidad"
        hcbLibrosMasVendidosCantidad.Size = New Size(97, 20)
        hcbLibrosMasVendidosCantidad.TabIndex = 41
        hcbLibrosMasVendidosCantidad.Text = "Cantidad"
        hcbLibrosMasVendidosCantidad.UseVisualStyleBackColor = True
        ' 
        ' hcbLibrosMasVendidosMonto
        ' 
        hcbLibrosMasVendidosMonto.AutoSize = True
        hcbLibrosMasVendidosMonto.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbLibrosMasVendidosMonto.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbLibrosMasVendidosMonto.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbLibrosMasVendidosMonto.Enable = True
        hcbLibrosMasVendidosMonto.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbLibrosMasVendidosMonto.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbLibrosMasVendidosMonto.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbLibrosMasVendidosMonto.Font = New Font("Segoe UI", 12F)
        hcbLibrosMasVendidosMonto.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbLibrosMasVendidosMonto.Location = New Point(655, 96)
        hcbLibrosMasVendidosMonto.Name = "hcbLibrosMasVendidosMonto"
        hcbLibrosMasVendidosMonto.Size = New Size(81, 20)
        hcbLibrosMasVendidosMonto.TabIndex = 42
        hcbLibrosMasVendidosMonto.Text = "Monto"
        hcbLibrosMasVendidosMonto.UseVisualStyleBackColor = True
        ' 
        ' hcbMejoresClientesCantidad
        ' 
        hcbMejoresClientesCantidad.AutoSize = True
        hcbMejoresClientesCantidad.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMejoresClientesCantidad.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbMejoresClientesCantidad.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbMejoresClientesCantidad.Enable = True
        hcbMejoresClientesCantidad.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMejoresClientesCantidad.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbMejoresClientesCantidad.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbMejoresClientesCantidad.Font = New Font("Segoe UI", 12F)
        hcbMejoresClientesCantidad.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbMejoresClientesCantidad.Location = New Point(526, 149)
        hcbMejoresClientesCantidad.Name = "hcbMejoresClientesCantidad"
        hcbMejoresClientesCantidad.Size = New Size(97, 20)
        hcbMejoresClientesCantidad.TabIndex = 41
        hcbMejoresClientesCantidad.Text = "Cantidad"
        hcbMejoresClientesCantidad.UseVisualStyleBackColor = True
        ' 
        ' hcbMejoresClientesMonto
        ' 
        hcbMejoresClientesMonto.AutoSize = True
        hcbMejoresClientesMonto.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMejoresClientesMonto.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbMejoresClientesMonto.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbMejoresClientesMonto.Enable = True
        hcbMejoresClientesMonto.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMejoresClientesMonto.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbMejoresClientesMonto.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbMejoresClientesMonto.Font = New Font("Segoe UI", 12F)
        hcbMejoresClientesMonto.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbMejoresClientesMonto.Location = New Point(655, 149)
        hcbMejoresClientesMonto.Name = "hcbMejoresClientesMonto"
        hcbMejoresClientesMonto.Size = New Size(81, 20)
        hcbMejoresClientesMonto.TabIndex = 42
        hcbMejoresClientesMonto.Text = "Monto"
        hcbMejoresClientesMonto.UseVisualStyleBackColor = True
        ' 
        ' dgvDatos
        ' 
        dgvDatos.AllowUserToAddRows = False
        dgvDatos.AllowUserToDeleteRows = False
        dgvDatos.AllowUserToOrderColumns = True
        dgvDatos.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(251))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(254), CByte(244), CByte(230))
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        dgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        dgvDatos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDatos.BackgroundColor = Color.White
        dgvDatos.BorderStyle = BorderStyle.None
        dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.White
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvDatos.ColumnHeadersHeight = 45
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(254), CByte(244), CByte(230))
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvDatos.DefaultCellStyle = DataGridViewCellStyle8
        dgvDatos.EnableHeadersVisualStyles = False
        dgvDatos.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        dgvDatos.GridColor = Color.White
        dgvDatos.Location = New Point(19, 338)
        dgvDatos.Margin = New Padding(10)
        dgvDatos.Name = "dgvDatos"
        dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        dgvDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgvDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dgvDatos.RowsDefaultCellStyle = DataGridViewCellStyle10
        dgvDatos.RowTemplate.Height = 35
        dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDatos.Size = New Size(962, 543)
        dgvDatos.TabIndex = 72
        ' 
        ' hnudMejoresClientes
        ' 
        hnudMejoresClientes.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        hnudMejoresClientes.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudMejoresClientes.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudMejoresClientes.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudMejoresClientes.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudMejoresClientes.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudMejoresClientes.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudMejoresClientes.EnterKey = True
        hnudMejoresClientes.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudMejoresClientes.ForeColor = Color.Black
        hnudMejoresClientes.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudMejoresClientes.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudMejoresClientes.Location = New Point(285, 141)
        hnudMejoresClientes.MaxNum = 10000F
        hnudMejoresClientes.MinNum = 1F
        hnudMejoresClientes.Name = "hnudMejoresClientes"
        hnudMejoresClientes.Precision = 0
        hnudMejoresClientes.Size = New Size(210, 32)
        hnudMejoresClientes.Step = 1F
        hnudMejoresClientes.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.TopDown
        hnudMejoresClientes.TabIndex = 73
        hnudMejoresClientes.ValueNumber = 1F
        ' 
        ' hnudLibrosMasVendidos
        ' 
        hnudLibrosMasVendidos.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        hnudLibrosMasVendidos.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudLibrosMasVendidos.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudLibrosMasVendidos.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudLibrosMasVendidos.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudLibrosMasVendidos.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudLibrosMasVendidos.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudLibrosMasVendidos.EnterKey = True
        hnudLibrosMasVendidos.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudLibrosMasVendidos.ForeColor = Color.Black
        hnudLibrosMasVendidos.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudLibrosMasVendidos.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudLibrosMasVendidos.Location = New Point(285, 90)
        hnudLibrosMasVendidos.MaxNum = 10000F
        hnudLibrosMasVendidos.MinNum = 1F
        hnudLibrosMasVendidos.Name = "hnudLibrosMasVendidos"
        hnudLibrosMasVendidos.Precision = 0
        hnudLibrosMasVendidos.Size = New Size(210, 32)
        hnudLibrosMasVendidos.Step = 1F
        hnudLibrosMasVendidos.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.TopDown
        hnudLibrosMasVendidos.TabIndex = 74
        hnudLibrosMasVendidos.ValueNumber = 1F
        ' 
        ' hnudLibrosConBajoStock
        ' 
        hnudLibrosConBajoStock.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(242))
        hnudLibrosConBajoStock.BaseColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        hnudLibrosConBajoStock.BorderColorA = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudLibrosConBajoStock.BorderColorB = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        hnudLibrosConBajoStock.BorderHoverColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudLibrosConBajoStock.ButtonTextColorA = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudLibrosConBajoStock.ButtonTextColorB = Color.FromArgb(CByte(144), CByte(147), CByte(153))
        hnudLibrosConBajoStock.EnterKey = True
        hnudLibrosConBajoStock.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hnudLibrosConBajoStock.ForeColor = Color.Black
        hnudLibrosConBajoStock.HoverButtonTextColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudLibrosConBajoStock.HoverButtonTextColorB = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hnudLibrosConBajoStock.Location = New Point(285, 193)
        hnudLibrosConBajoStock.MaxNum = 10000F
        hnudLibrosConBajoStock.MinNum = 1F
        hnudLibrosConBajoStock.Name = "hnudLibrosConBajoStock"
        hnudLibrosConBajoStock.Precision = 0
        hnudLibrosConBajoStock.Size = New Size(210, 32)
        hnudLibrosConBajoStock.Step = 1F
        hnudLibrosConBajoStock.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.TopDown
        hnudLibrosConBajoStock.TabIndex = 75
        hnudLibrosConBajoStock.Text = "hnudNumeroPagina"
        hnudLibrosConBajoStock.ValueNumber = 1F
        ' 
        ' ibtnEjecutarConsulta
        ' 
        ibtnEjecutarConsulta.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnEjecutarConsulta.FlatAppearance.BorderSize = 0
        ibtnEjecutarConsulta.FlatStyle = FlatStyle.Flat
        ibtnEjecutarConsulta.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnEjecutarConsulta.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnEjecutarConsulta.IconChar = FontAwesome.Sharp.IconChar.Terminal
        ibtnEjecutarConsulta.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnEjecutarConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnEjecutarConsulta.IconSize = 30
        ibtnEjecutarConsulta.ImageAlign = ContentAlignment.MiddleLeft
        ibtnEjecutarConsulta.Location = New Point(536, 189)
        ibtnEjecutarConsulta.Name = "ibtnEjecutarConsulta"
        ibtnEjecutarConsulta.Size = New Size(190, 40)
        ibtnEjecutarConsulta.TabIndex = 76
        ibtnEjecutarConsulta.Text = "Ejecutar consulta"
        ibtnEjecutarConsulta.TextAlign = ContentAlignment.MiddleRight
        ibtnEjecutarConsulta.UseVisualStyleBackColor = False
        ' 
        ' ParrotGroupBox1
        ' 
        ParrotGroupBox1.BorderColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ParrotGroupBox1.BorderWidth = 1
        ParrotGroupBox1.Controls.Add(ibtnExportar)
        ParrotGroupBox1.Controls.Add(ibtnExportarXLSX)
        ParrotGroupBox1.Controls.Add(ibtnExportarCSV)
        ParrotGroupBox1.Location = New Point(832, 90)
        ParrotGroupBox1.Name = "ParrotGroupBox1"
        ParrotGroupBox1.ShowText = True
        ParrotGroupBox1.Size = New Size(149, 204)
        ParrotGroupBox1.TabIndex = 77
        ParrotGroupBox1.TabStop = False
        ParrotGroupBox1.Text = "Exportación"
        ParrotGroupBox1.TextColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ' 
        ' ParrotGroupBox2
        ' 
        ParrotGroupBox2.BorderColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ParrotGroupBox2.BorderWidth = 1
        ParrotGroupBox2.Controls.Add(dtpFechaFin)
        ParrotGroupBox2.Controls.Add(ibtnEjecutarConsulta)
        ParrotGroupBox2.Controls.Add(dtpFechaInicio)
        ParrotGroupBox2.Controls.Add(hnudLibrosConBajoStock)
        ParrotGroupBox2.Controls.Add(hcbVentasPorDia)
        ParrotGroupBox2.Controls.Add(hnudLibrosMasVendidos)
        ParrotGroupBox2.Controls.Add(hcbLibrosMasVendidos)
        ParrotGroupBox2.Controls.Add(hnudMejoresClientes)
        ParrotGroupBox2.Controls.Add(hcbMejoresClientes)
        ParrotGroupBox2.Controls.Add(hcbLibrosConBajoStock)
        ParrotGroupBox2.Controls.Add(hcbMejoresClientesMonto)
        ParrotGroupBox2.Controls.Add(Label1)
        ParrotGroupBox2.Controls.Add(hcbMejoresClientesCantidad)
        ParrotGroupBox2.Controls.Add(Label2)
        ParrotGroupBox2.Controls.Add(hcbLibrosMasVendidosMonto)
        ParrotGroupBox2.Controls.Add(hcbLibrosMasVendidosCantidad)
        ParrotGroupBox2.Location = New Point(19, 65)
        ParrotGroupBox2.Name = "ParrotGroupBox2"
        ParrotGroupBox2.ShowText = True
        ParrotGroupBox2.Size = New Size(793, 250)
        ParrotGroupBox2.TabIndex = 78
        ParrotGroupBox2.TabStop = False
        ParrotGroupBox2.Text = "Consulta"
        ParrotGroupBox2.TextColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        ' 
        ' pnlBar
        ' 
        pnlBar.BackColor = SystemColors.Window
        pnlBar.Controls.Add(Label10)
        pnlBar.Controls.Add(Panel1)
        pnlBar.Dock = DockStyle.Top
        pnlBar.Location = New Point(0, 0)
        pnlBar.Name = "pnlBar"
        pnlBar.Size = New Size(1000, 45)
        pnlBar.TabIndex = 79
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Segoe UI Black", 23.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(19, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(155, 42)
        Label10.TabIndex = 29
        Label10.Text = "Reportes"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ibtnCerrar)
        Panel1.Controls.Add(ibtnMinimizar)
        Panel1.Controls.Add(ibtnMaximizar)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(865, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(135, 45)
        Panel1.TabIndex = 6
        ' 
        ' ibtnCerrar
        ' 
        ibtnCerrar.Dock = DockStyle.Right
        ibtnCerrar.FlatAppearance.BorderSize = 0
        ibtnCerrar.FlatStyle = FlatStyle.Flat
        ibtnCerrar.ForeColor = Color.Black
        ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Multiply
        ibtnCerrar.IconColor = Color.Gray
        ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnCerrar.IconSize = 24
        ibtnCerrar.Location = New Point(90, 0)
        ibtnCerrar.Name = "ibtnCerrar"
        ibtnCerrar.Size = New Size(45, 45)
        ibtnCerrar.TabIndex = 4
        ibtnCerrar.UseVisualStyleBackColor = True
        ' 
        ' ibtnMinimizar
        ' 
        ibtnMinimizar.Dock = DockStyle.Left
        ibtnMinimizar.FlatAppearance.BorderSize = 0
        ibtnMinimizar.FlatStyle = FlatStyle.Flat
        ibtnMinimizar.ForeColor = Color.Black
        ibtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus
        ibtnMinimizar.IconColor = Color.Gray
        ibtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnMinimizar.IconSize = 20
        ibtnMinimizar.Location = New Point(0, 0)
        ibtnMinimizar.Name = "ibtnMinimizar"
        ibtnMinimizar.Padding = New Padding(0, 10, 0, 0)
        ibtnMinimizar.Size = New Size(45, 45)
        ibtnMinimizar.TabIndex = 5
        ibtnMinimizar.UseVisualStyleBackColor = True
        ' 
        ' ibtnMaximizar
        ' 
        ibtnMaximizar.Dock = DockStyle.Fill
        ibtnMaximizar.FlatAppearance.BorderSize = 0
        ibtnMaximizar.FlatStyle = FlatStyle.Flat
        ibtnMaximizar.ForeColor = Color.Black
        ibtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.Square
        ibtnMaximizar.IconColor = Color.Gray
        ibtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnMaximizar.IconSize = 20
        ibtnMaximizar.Location = New Point(0, 0)
        ibtnMaximizar.Name = "ibtnMaximizar"
        ibtnMaximizar.Size = New Size(135, 45)
        ibtnMaximizar.TabIndex = 5
        ibtnMaximizar.UseVisualStyleBackColor = True
        ' 
        ' FormReportes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1000, 900)
        ControlBox = False
        Controls.Add(pnlBar)
        Controls.Add(ParrotGroupBox2)
        Controls.Add(ParrotGroupBox1)
        Controls.Add(dgvDatos)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormReportes"
        StartPosition = FormStartPosition.CenterScreen
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        ParrotGroupBox1.ResumeLayout(False)
        ParrotGroupBox1.PerformLayout()
        ParrotGroupBox2.ResumeLayout(False)
        ParrotGroupBox2.PerformLayout()
        pnlBar.ResumeLayout(False)
        pnlBar.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtpFechaInicio As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents dtpFechaFin As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents hcbVentasPorDia As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents hcbLibrosMasVendidos As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents hcbMejoresClientes As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents hcbLibrosConBajoStock As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents ibtnExportarXLSX As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnExportarCSV As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnExportar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents hcbLibrosMasVendidosCantidad As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents hcbLibrosMasVendidosMonto As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents hcbMejoresClientesCantidad As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents hcbMejoresClientesMonto As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents dgvDatos As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents hnudMejoresClientes As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents hnudLibrosMasVendidos As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents hnudLibrosConBajoStock As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents ibtnEjecutarConsulta As FontAwesome.Sharp.IconButton
    Friend WithEvents ParrotGroupBox1 As ReaLTaiizor.Controls.ParrotGroupBox
    Friend WithEvents ParrotGroupBox2 As ReaLTaiizor.Controls.ParrotGroupBox
    Friend WithEvents pnlBar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ibtnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
End Class
