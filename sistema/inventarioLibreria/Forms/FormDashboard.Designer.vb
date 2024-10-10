<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Panel1 = New Panel()
        IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        lblCantidadVentas = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        lblTotalIngresos = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        lblIngresoPromedioPorVenta = New Label()
        Label4 = New Label()
        chartIngresos = New DataVisualization.Charting.Chart()
        chartLibrosMasVendidos = New DataVisualization.Charting.Chart()
        IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        lblCantidadClientes = New Label()
        lblCantidadLibros = New Label()
        Label8 = New Label()
        lblCantidadProveedoresActivos = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        dgvDelet = New System.Windows.Forms.DataGridView()
        Label12 = New Label()
        btnEsteMes = New Button()
        btnFechaPersonalizada = New Button()
        btnOkFechaPersonalizada = New Button()
        Panel5 = New Panel()
        dgvIngresosSegunLibros = New ReaLTaiizor.Controls.PoisonDataGridView()
        Label13 = New Label()
        btnUltTreintaDias = New Button()
        btnUltSieteDias = New Button()
        chartCantidadVentas = New DataVisualization.Charting.Chart()
        Label9 = New Label()
        Panel9 = New Panel()
        Label11 = New Label()
        ibtnGenerarReportes = New Button()
        dtpFechaFin = New ReaLTaiizor.Controls.PoisonDateTime()
        dtpFechaInicio = New ReaLTaiizor.Controls.PoisonDateTime()
        Panel10 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        Panel11 = New Panel()
        Panel12 = New Panel()
        Panel13 = New Panel()
        Panel14 = New Panel()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(IconPictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartIngresos, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartLibrosMasVendidos, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDelet, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(dgvIngresosSegunLibros, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartCantidadVentas, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(IconPictureBox4)
        Panel1.Controls.Add(lblCantidadVentas)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(5)
        Panel1.Size = New Size(171, 80)
        Panel1.TabIndex = 8
        ' 
        ' IconPictureBox4
        ' 
        IconPictureBox4.BackColor = Color.Transparent
        IconPictureBox4.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        IconPictureBox4.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox4.IconSize = 40
        IconPictureBox4.Location = New Point(8, 28)
        IconPictureBox4.Name = "IconPictureBox4"
        IconPictureBox4.Size = New Size(40, 40)
        IconPictureBox4.TabIndex = 35
        IconPictureBox4.TabStop = False
        ' 
        ' lblCantidadVentas
        ' 
        lblCantidadVentas.AutoSize = True
        lblCantidadVentas.BackColor = Color.Transparent
        lblCantidadVentas.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold)
        lblCantidadVentas.Location = New Point(50, 20)
        lblCantidadVentas.Name = "lblCantidadVentas"
        lblCantidadVentas.Size = New Size(106, 50)
        lblCantidadVentas.TabIndex = 10
        lblCantidadVentas.Text = "1000"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 15)
        Label1.TabIndex = 9
        Label1.Text = "Cantidad de ventas"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(IconPictureBox5)
        Panel2.Controls.Add(lblTotalIngresos)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(184, 0)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(5)
        Panel2.Size = New Size(232, 80)
        Panel2.TabIndex = 11
        ' 
        ' IconPictureBox5
        ' 
        IconPictureBox5.BackColor = Color.Transparent
        IconPictureBox5.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.HandHoldingDollar
        IconPictureBox5.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox5.IconSize = 40
        IconPictureBox5.Location = New Point(8, 28)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(40, 40)
        IconPictureBox5.TabIndex = 36
        IconPictureBox5.TabStop = False
        ' 
        ' lblTotalIngresos
        ' 
        lblTotalIngresos.AutoSize = True
        lblTotalIngresos.BackColor = Color.Transparent
        lblTotalIngresos.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold)
        lblTotalIngresos.Location = New Point(50, 20)
        lblTotalIngresos.Name = "lblTotalIngresos"
        lblTotalIngresos.Size = New Size(179, 50)
        lblTotalIngresos.TabIndex = 10
        lblTotalIngresos.Text = "10000,00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 9
        Label3.Text = "Ingresos totales"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(IconPictureBox6)
        Panel3.Controls.Add(lblIngresoPromedioPorVenta)
        Panel3.Controls.Add(Label4)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(429, 0)
        Panel3.Margin = New Padding(0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(5)
        Panel3.Size = New Size(232, 80)
        Panel3.TabIndex = 12
        ' 
        ' IconPictureBox6
        ' 
        IconPictureBox6.BackColor = Color.Transparent
        IconPictureBox6.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.PiggyBank
        IconPictureBox6.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox6.IconSize = 40
        IconPictureBox6.Location = New Point(8, 28)
        IconPictureBox6.Name = "IconPictureBox6"
        IconPictureBox6.Size = New Size(40, 40)
        IconPictureBox6.TabIndex = 37
        IconPictureBox6.TabStop = False
        ' 
        ' lblIngresoPromedioPorVenta
        ' 
        lblIngresoPromedioPorVenta.AutoSize = True
        lblIngresoPromedioPorVenta.BackColor = Color.Transparent
        lblIngresoPromedioPorVenta.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold)
        lblIngresoPromedioPorVenta.Location = New Point(50, 20)
        lblIngresoPromedioPorVenta.Name = "lblIngresoPromedioPorVenta"
        lblIngresoPromedioPorVenta.Size = New Size(179, 50)
        lblIngresoPromedioPorVenta.TabIndex = 10
        lblIngresoPromedioPorVenta.Text = "10000,00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 15)
        Label4.TabIndex = 9
        Label4.Text = "Ingreso promedio por venta"
        ' 
        ' chartIngresos
        ' 
        chartIngresos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.LineColor = Color.Gray
        ChartArea1.AxisX.MajorGrid.LineColor = Color.Transparent
        ChartArea1.AxisX.MajorTickMark.LineColor = Color.LightGray
        ChartArea1.AxisX.MinorGrid.LineColor = Color.LightGray
        ChartArea1.AxisX.MinorTickMark.LineColor = Color.LightGray
        ChartArea1.AxisX.TitleFont = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChartArea1.AxisY.LineColor = Color.Transparent
        ChartArea1.AxisY.MajorGrid.LineColor = Color.LightGray
        ChartArea1.AxisY.MajorTickMark.LineColor = Color.Transparent
        ChartArea1.AxisY.MinorGrid.LineColor = Color.Transparent
        ChartArea1.AxisY.MinorTickMark.LineColor = Color.Transparent
        ChartArea1.AxisY.TitleFont = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChartArea1.BackColor = Color.White
        ChartArea1.Name = "ChartArea1"
        chartIngresos.ChartAreas.Add(ChartArea1)
        Legend1.Docking = DataVisualization.Charting.Docking.Top
        Legend1.Enabled = False
        Legend1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleFont = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chartIngresos.Legends.Add(Legend1)
        chartIngresos.Location = New Point(3, 18)
        chartIngresos.Name = "chartIngresos"
        Series1.BackGradientStyle = DataVisualization.Charting.GradientStyle.DiagonalRight
        Series1.BackSecondaryColor = Color.RoyalBlue
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.SplineArea
        Series1.Color = Color.DodgerBlue
        Series1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chartIngresos.Series.Add(Series1)
        chartIngresos.Size = New Size(939, 360)
        chartIngresos.TabIndex = 14
        Title1.Alignment = ContentAlignment.MiddleLeft
        Title1.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title1.Name = "Title1"
        Title1.Text = "    Ingresos"
        chartIngresos.Titles.Add(Title1)
        ' 
        ' chartLibrosMasVendidos
        ' 
        chartLibrosMasVendidos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ChartArea2.AxisX.TitleFont = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChartArea2.Name = "ChartArea1"
        chartLibrosMasVendidos.ChartAreas.Add(ChartArea2)
        Legend2.Docking = DataVisualization.Charting.Docking.Bottom
        Legend2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Legend2.TitleFont = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chartLibrosMasVendidos.Legends.Add(Legend2)
        chartLibrosMasVendidos.Location = New Point(961, 18)
        chartLibrosMasVendidos.Name = "chartLibrosMasVendidos"
        chartLibrosMasVendidos.Palette = DataVisualization.Charting.ChartColorPalette.None
        chartLibrosMasVendidos.PaletteCustomColors = New Color() {Color.RoyalBlue, Color.Navy, Color.FromArgb(CByte(128), CByte(128), CByte(255)), Color.FromArgb(CByte(255), CByte(128), CByte(255)), Color.Purple, Color.SteelBlue}
        Series2.BackSecondaryColor = Color.Indigo
        Series2.BorderColor = Color.White
        Series2.BorderWidth = 5
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Color = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Series2.Font = New Font("Microsoft Sans Serif", 12F)
        Series2.IsValueShownAsLabel = True
        Series2.LabelForeColor = Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        chartLibrosMasVendidos.Series.Add(Series2)
        chartLibrosMasVendidos.Size = New Size(406, 360)
        chartLibrosMasVendidos.TabIndex = 15
        chartLibrosMasVendidos.Text = "chartTopProducts"
        Title2.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title2.Name = "Title1"
        Title2.Text = "5 libros más vendidos"
        chartLibrosMasVendidos.Titles.Add(Title2)
        ' 
        ' IconPictureBox3
        ' 
        IconPictureBox3.BackColor = Color.Transparent
        IconPictureBox3.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        IconPictureBox3.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox3.IconSize = 40
        IconPictureBox3.Location = New Point(8, 32)
        IconPictureBox3.Name = "IconPictureBox3"
        IconPictureBox3.Size = New Size(40, 40)
        IconPictureBox3.TabIndex = 31
        IconPictureBox3.TabStop = False
        ' 
        ' IconPictureBox2
        ' 
        IconPictureBox2.BackColor = Color.Transparent
        IconPictureBox2.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking
        IconPictureBox2.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox2.IconSize = 40
        IconPictureBox2.Location = New Point(8, 28)
        IconPictureBox2.Name = "IconPictureBox2"
        IconPictureBox2.Size = New Size(40, 40)
        IconPictureBox2.TabIndex = 30
        IconPictureBox2.TabStop = False
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.Transparent
        IconPictureBox1.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User
        IconPictureBox1.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 40
        IconPictureBox1.Location = New Point(8, 28)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(40, 40)
        IconPictureBox1.TabIndex = 29
        IconPictureBox1.TabStop = False
        ' 
        ' lblCantidadClientes
        ' 
        lblCantidadClientes.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblCantidadClientes.AutoSize = True
        lblCantidadClientes.BackColor = Color.Transparent
        lblCantidadClientes.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold)
        lblCantidadClientes.Location = New Point(50, 20)
        lblCantidadClientes.Name = "lblCantidadClientes"
        lblCantidadClientes.Size = New Size(85, 50)
        lblCantidadClientes.TabIndex = 10
        lblCantidadClientes.Text = "100"
        ' 
        ' lblCantidadLibros
        ' 
        lblCantidadLibros.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblCantidadLibros.AutoSize = True
        lblCantidadLibros.BackColor = Color.Transparent
        lblCantidadLibros.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold)
        lblCantidadLibros.Location = New Point(50, 20)
        lblCantidadLibros.Name = "lblCantidadLibros"
        lblCantidadLibros.Size = New Size(85, 50)
        lblCantidadLibros.TabIndex = 15
        lblCantidadLibros.Text = "100"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(35, 5)
        Label8.Name = "Label8"
        Label8.Size = New Size(128, 15)
        Label8.TabIndex = 14
        Label8.Text = "Cantidad de productos"
        ' 
        ' lblCantidadProveedoresActivos
        ' 
        lblCantidadProveedoresActivos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblCantidadProveedoresActivos.AutoSize = True
        lblCantidadProveedoresActivos.BackColor = Color.Transparent
        lblCantidadProveedoresActivos.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold)
        lblCantidadProveedoresActivos.Location = New Point(50, 20)
        lblCantidadProveedoresActivos.Name = "lblCantidadProveedoresActivos"
        lblCantidadProveedoresActivos.Size = New Size(85, 50)
        lblCantidadProveedoresActivos.TabIndex = 13
        lblCantidadProveedoresActivos.Text = "100"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 5)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 15)
        Label7.TabIndex = 12
        Label7.Text = "Cantidad de proveedores activos"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 15)
        Label5.TabIndex = 9
        Label5.Text = "Cantidad de clientes"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 18F)
        Label6.Location = New Point(4, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 32)
        Label6.TabIndex = 11
        Label6.Text = "Conteos"
        ' 
        ' dgvDelet
        ' 
        dgvDelet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDelet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDelet.Location = New Point(0, 0)
        dgvDelet.Name = "dgvDelet"
        dgvDelet.Size = New Size(381, 300)
        dgvDelet.TabIndex = 12
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 20F)
        Label12.Location = New Point(0, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(240, 37)
        Label12.TabIndex = 11
        Label12.Text = "Productos en stock"
        ' 
        ' btnEsteMes
        ' 
        btnEsteMes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEsteMes.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        btnEsteMes.FlatAppearance.BorderSize = 0
        btnEsteMes.FlatStyle = FlatStyle.Flat
        btnEsteMes.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnEsteMes.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        btnEsteMes.Location = New Point(1278, 13)
        btnEsteMes.Name = "btnEsteMes"
        btnEsteMes.Size = New Size(100, 40)
        btnEsteMes.TabIndex = 17
        btnEsteMes.Text = "Mes"
        btnEsteMes.UseVisualStyleBackColor = False
        ' 
        ' btnFechaPersonalizada
        ' 
        btnFechaPersonalizada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnFechaPersonalizada.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        btnFechaPersonalizada.FlatAppearance.BorderSize = 0
        btnFechaPersonalizada.FlatStyle = FlatStyle.Flat
        btnFechaPersonalizada.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFechaPersonalizada.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        btnFechaPersonalizada.Location = New Point(896, 13)
        btnFechaPersonalizada.Name = "btnFechaPersonalizada"
        btnFechaPersonalizada.Size = New Size(130, 40)
        btnFechaPersonalizada.TabIndex = 21
        btnFechaPersonalizada.Text = "Personalizado"
        btnFechaPersonalizada.UseVisualStyleBackColor = False
        ' 
        ' btnOkFechaPersonalizada
        ' 
        btnOkFechaPersonalizada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOkFechaPersonalizada.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        btnOkFechaPersonalizada.FlatAppearance.BorderSize = 0
        btnOkFechaPersonalizada.FlatStyle = FlatStyle.Flat
        btnOkFechaPersonalizada.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnOkFechaPersonalizada.ForeColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        btnOkFechaPersonalizada.Location = New Point(846, 13)
        btnOkFechaPersonalizada.Name = "btnOkFechaPersonalizada"
        btnOkFechaPersonalizada.Size = New Size(40, 40)
        btnOkFechaPersonalizada.TabIndex = 22
        btnOkFechaPersonalizada.Text = "OK"
        btnOkFechaPersonalizada.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(dgvIngresosSegunLibros)
        Panel5.Controls.Add(Label13)
        Panel5.Location = New Point(0, 13)
        Panel5.Margin = New Padding(0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(5)
        Panel5.Size = New Size(616, 331)
        Panel5.TabIndex = 16
        ' 
        ' dgvIngresosSegunLibros
        ' 
        dgvIngresosSegunLibros.AllowUserToAddRows = False
        dgvIngresosSegunLibros.AllowUserToDeleteRows = False
        dgvIngresosSegunLibros.AllowUserToOrderColumns = True
        dgvIngresosSegunLibros.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(251))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(254), CByte(244), CByte(230))
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        dgvIngresosSegunLibros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvIngresosSegunLibros.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvIngresosSegunLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvIngresosSegunLibros.BackgroundColor = Color.WhiteSmoke
        dgvIngresosSegunLibros.BorderStyle = BorderStyle.None
        dgvIngresosSegunLibros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvIngresosSegunLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvIngresosSegunLibros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvIngresosSegunLibros.ColumnHeadersHeight = 45
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(254), CByte(244), CByte(230))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvIngresosSegunLibros.DefaultCellStyle = DataGridViewCellStyle3
        dgvIngresosSegunLibros.EnableHeadersVisualStyles = False
        dgvIngresosSegunLibros.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        dgvIngresosSegunLibros.GridColor = Color.White
        dgvIngresosSegunLibros.Location = New Point(15, 55)
        dgvIngresosSegunLibros.Margin = New Padding(10)
        dgvIngresosSegunLibros.Name = "dgvIngresosSegunLibros"
        dgvIngresosSegunLibros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvIngresosSegunLibros.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvIngresosSegunLibros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dgvIngresosSegunLibros.RowsDefaultCellStyle = DataGridViewCellStyle5
        dgvIngresosSegunLibros.RowTemplate.Height = 35
        dgvIngresosSegunLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvIngresosSegunLibros.Size = New Size(586, 261)
        dgvIngresosSegunLibros.TabIndex = 14
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(56, 13)
        Label13.Name = "Label13"
        Label13.Size = New Size(264, 32)
        Label13.TabIndex = 11
        Label13.Text = "Ingresos según libros"
        ' 
        ' btnUltTreintaDias
        ' 
        btnUltTreintaDias.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUltTreintaDias.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        btnUltTreintaDias.FlatAppearance.BorderSize = 0
        btnUltTreintaDias.FlatStyle = FlatStyle.Flat
        btnUltTreintaDias.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnUltTreintaDias.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        btnUltTreintaDias.Location = New Point(1162, 13)
        btnUltTreintaDias.Name = "btnUltTreintaDias"
        btnUltTreintaDias.Size = New Size(100, 40)
        btnUltTreintaDias.TabIndex = 23
        btnUltTreintaDias.Text = "Últ 30 días"
        btnUltTreintaDias.UseVisualStyleBackColor = False
        ' 
        ' btnUltSieteDias
        ' 
        btnUltSieteDias.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUltSieteDias.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        btnUltSieteDias.FlatAppearance.BorderSize = 0
        btnUltSieteDias.FlatStyle = FlatStyle.Flat
        btnUltSieteDias.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnUltSieteDias.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        btnUltSieteDias.Location = New Point(1046, 13)
        btnUltSieteDias.Name = "btnUltSieteDias"
        btnUltSieteDias.Size = New Size(100, 40)
        btnUltSieteDias.TabIndex = 24
        btnUltSieteDias.Text = "Últ 7 días"
        btnUltSieteDias.UseVisualStyleBackColor = False
        ' 
        ' chartCantidadVentas
        ' 
        chartCantidadVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ChartArea3.AxisX.LineColor = Color.LightGray
        ChartArea3.AxisX.MajorGrid.LineColor = Color.Transparent
        ChartArea3.AxisX.MajorTickMark.LineColor = Color.LightGray
        ChartArea3.AxisX.MinorGrid.LineColor = Color.Transparent
        ChartArea3.AxisX.MinorTickMark.LineColor = Color.Transparent
        ChartArea3.AxisY.LineColor = Color.Transparent
        ChartArea3.AxisY.MajorGrid.LineColor = Color.LightGray
        ChartArea3.AxisY.MajorTickMark.LineColor = Color.Transparent
        ChartArea3.AxisY.MinorGrid.LineColor = Color.LightGray
        ChartArea3.AxisY.MinorTickMark.LineColor = Color.LightGray
        ChartArea3.Name = "ChartArea1"
        chartCantidadVentas.ChartAreas.Add(ChartArea3)
        Legend3.Docking = DataVisualization.Charting.Docking.Top
        Legend3.Enabled = False
        Legend3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Legend3.TitleFont = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chartCantidadVentas.Legends.Add(Legend3)
        chartCantidadVentas.Location = New Point(632, 16)
        chartCantidadVentas.Name = "chartCantidadVentas"
        Series3.ChartArea = "ChartArea1"
        Series3.Color = Color.MidnightBlue
        Series3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series3.YValuesPerPoint = 4
        chartCantidadVentas.Series.Add(Series3)
        chartCantidadVentas.Size = New Size(735, 325)
        chartCantidadVentas.TabIndex = 26
        chartCantidadVentas.Text = "ChartCantidadVentas"
        Title3.Alignment = ContentAlignment.TopLeft
        Title3.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title3.Name = "Title1"
        Title3.Text = "      Cantidad de ventas"
        chartCantidadVentas.Titles.Add(Title3)
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 16F)
        Label9.Location = New Point(597, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(22, 30)
        Label9.TabIndex = 27
        Label9.Text = "-"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(Label11)
        Panel9.Controls.Add(ibtnGenerarReportes)
        Panel9.Controls.Add(dtpFechaFin)
        Panel9.Controls.Add(dtpFechaInicio)
        Panel9.Controls.Add(btnEsteMes)
        Panel9.Controls.Add(Label9)
        Panel9.Controls.Add(btnOkFechaPersonalizada)
        Panel9.Controls.Add(btnFechaPersonalizada)
        Panel9.Controls.Add(btnUltTreintaDias)
        Panel9.Controls.Add(btnUltSieteDias)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(1400, 65)
        Panel9.TabIndex = 29
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Font = New Font("Segoe UI Black", 23.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(15, 11)
        Label11.Name = "Label11"
        Label11.Size = New Size(184, 42)
        Label11.TabIndex = 32
        Label11.Text = "Dashboard"
        ' 
        ' ibtnGenerarReportes
        ' 
        ibtnGenerarReportes.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnGenerarReportes.FlatAppearance.BorderSize = 0
        ibtnGenerarReportes.FlatStyle = FlatStyle.Flat
        ibtnGenerarReportes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnGenerarReportes.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnGenerarReportes.Location = New Point(215, 13)
        ibtnGenerarReportes.Name = "ibtnGenerarReportes"
        ibtnGenerarReportes.Size = New Size(145, 40)
        ibtnGenerarReportes.TabIndex = 31
        ibtnGenerarReportes.Text = "Generar reportes"
        ibtnGenerarReportes.UseVisualStyleBackColor = False
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dtpFechaFin.Location = New Point(616, 19)
        dtpFechaFin.MinimumSize = New Size(0, 29)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(220, 29)
        dtpFechaFin.TabIndex = 30
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dtpFechaInicio.CustomFormat = ""
        dtpFechaInicio.Location = New Point(375, 19)
        dtpFechaInicio.MinimumSize = New Size(0, 29)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(220, 29)
        dtpFechaInicio.TabIndex = 29
        ' 
        ' Panel10
        ' 
        Panel10.AutoScroll = True
        Panel10.Controls.Add(TableLayoutPanel3)
        Panel10.Controls.Add(TableLayoutPanel2)
        Panel10.Controls.Add(TableLayoutPanel1)
        Panel10.Dock = DockStyle.Fill
        Panel10.Location = New Point(0, 65)
        Panel10.Name = "Panel10"
        Panel10.Padding = New Padding(15)
        Panel10.Size = New Size(1400, 835)
        Panel10.TabIndex = 30
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 1F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 54F))
        TableLayoutPanel3.Controls.Add(Panel5, 0, 1)
        TableLayoutPanel3.Controls.Add(chartCantidadVentas, 2, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(15, 476)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 4F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 96F))
        TableLayoutPanel3.Size = New Size(1370, 344)
        TableLayoutPanel3.TabIndex = 29
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 69F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 1F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.Controls.Add(chartLibrosMasVendidos, 2, 1)
        TableLayoutPanel2.Controls.Add(chartIngresos, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(15, 95)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 4F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 96F))
        TableLayoutPanel2.Size = New Size(1370, 381)
        TableLayoutPanel2.TabIndex = 28
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 1F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 1F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.5F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 4, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 6, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(15, 15)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1370, 80)
        TableLayoutPanel1.TabIndex = 27
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.WhiteSmoke
        TableLayoutPanel4.ColumnCount = 7
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0004988F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 0.249405816F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.000412F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 0.249405831F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.2504616F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 0.249405816F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.000412F))
        TableLayoutPanel4.Controls.Add(Panel11, 2, 0)
        TableLayoutPanel4.Controls.Add(Panel12, 4, 0)
        TableLayoutPanel4.Controls.Add(Panel13, 6, 0)
        TableLayoutPanel4.Controls.Add(Panel14, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(688, 0)
        TableLayoutPanel4.Margin = New Padding(0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(682, 80)
        TableLayoutPanel4.TabIndex = 13
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.Controls.Add(lblCantidadClientes)
        Panel11.Controls.Add(Label5)
        Panel11.Controls.Add(IconPictureBox1)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(103, 0)
        Panel11.Margin = New Padding(0)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(184, 80)
        Panel11.TabIndex = 33
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.White
        Panel12.Controls.Add(lblCantidadProveedoresActivos)
        Panel12.Controls.Add(Label7)
        Panel12.Controls.Add(IconPictureBox2)
        Panel12.Dock = DockStyle.Fill
        Panel12.Location = New Point(288, 0)
        Panel12.Margin = New Padding(0)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(206, 80)
        Panel12.TabIndex = 34
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.White
        Panel13.Controls.Add(lblCantidadLibros)
        Panel13.Controls.Add(Label8)
        Panel13.Controls.Add(IconPictureBox3)
        Panel13.Dock = DockStyle.Fill
        Panel13.Location = New Point(495, 0)
        Panel13.Margin = New Padding(0)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(187, 80)
        Panel13.TabIndex = 35
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.White
        Panel14.Controls.Add(Label2)
        Panel14.Controls.Add(Label6)
        Panel14.Dock = DockStyle.Fill
        Panel14.Location = New Point(0, 0)
        Panel14.Margin = New Padding(0)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(102, 80)
        Panel14.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.Location = New Point(4, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 32)
        Label2.TabIndex = 12
        Label2.Text = "totales"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1400, 900)
        ControlBox = False
        Controls.Add(Panel10)
        Controls.Add(Panel9)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormDashboard"
        Text = "FormDashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(IconPictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(chartIngresos, ComponentModel.ISupportInitialize).EndInit()
        CType(chartLibrosMasVendidos, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDelet, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(dgvIngresosSegunLibros, ComponentModel.ISupportInitialize).EndInit()
        CType(chartCantidadVentas, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCantidadVentas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotalIngresos As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblIngresoPromedioPorVenta As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chartIngresos As DataVisualization.Charting.Chart
    Friend WithEvents chartLibrosMasVendidos As DataVisualization.Charting.Chart
    Friend WithEvents lblCantidadLibros As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCantidadProveedoresActivos As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCantidadClientes As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvDelet As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEsteMes As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnFechaPersonalizada As System.Windows.Forms.Button
    Friend WithEvents btnOkFechaPersonalizada As System.Windows.Forms.Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents btnUltTreintaDias As Button
    Friend WithEvents btnUltSieteDias As Button
    Friend WithEvents chartCantidadVentas As DataVisualization.Charting.Chart
    Friend WithEvents Label9 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvIngresosSegunLibros As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents dtpFechaInicio As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents dtpFechaFin As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents ibtnGenerarReportes As Button
    Friend WithEvents Label11 As Label
End Class
