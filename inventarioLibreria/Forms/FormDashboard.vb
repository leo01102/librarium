' Frontend

Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting

Partial Public Class FormDashboard
    Inherits Formulario

    ' campos
    Private dashboard As Dashboard

    ' constructor
    Public Sub New()
        InitializeComponent()
        dtpFechaInicio.Value = Date.Today.AddDays(-7) ' por defecto ultimos 7 dias
        dtpFechaFin.Value = Date.Now

        dashboard = New Dashboard()
        LoadData()
    End Sub

    ' metodos privados
    Private Sub LoadData()
        Dim refreshData As Boolean = dashboard.LoadData(dtpFechaInicio.Value, dtpFechaFin.Value)
        If refreshData Then
            lblCantidadVentas.Text = dashboard.cantidadVentas.ToString()
            lblTotalIngresos.Text = "$ " & dashboard.cantidadIngresos.ToString()

            lblCantidadClientes.Text = dashboard.cantidadClientes.ToString()
            lblCantidadProveedoresActivos.Text = dashboard.cantidadProveedores.ToString()
            lblCantidadLibros.Text = dashboard.cantidadLibros.ToString()

            lblIngresoPromedioPorVenta.Text = dashboard.IngresoPromedioPorVenta.ToString("F2") ' F2 para mostrar el dato como double

            chartIngresos.Series("Series1").Points.Clear() ' limpiar cualquier serie existente
            chartIngresos.Series("Series1").ChartType = SeriesChartType.SplineArea ' configurar el tipo de gráfico de la serie predeterminada
            For Each ingreso In dashboard.ListaIngresos ' agregar datos desde listaIngresos
                Dim fecha As Date
                If Date.TryParse(ingreso.Fecha, fecha) Then
                    chartIngresos.Series("Series1").Points.AddXY(fecha, ingreso.TotalIngresos)
                Else
                    MessageBox.Show("Fecha no válida: " & ingreso.Fecha) ' si la fecha no es válida
                End If
            Next

            dgvIngresosSegunLibros.DataSource = dashboard.ListaIngresosSegunLibros
            dgvIngresosSegunLibros.Columns(0).HeaderText = "Libro"
            dgvIngresosSegunLibros.Columns(1).HeaderText = "Ingresos generados"

            chartLibrosMasVendidos.DataSource = dashboard.ListaLibrosMasVendidos
            chartLibrosMasVendidos.Series(0).XValueMember = "Key" ' nombre por defecto
            chartLibrosMasVendidos.Series(0).YValueMembers = "Value" ' nombre por defecto
            chartLibrosMasVendidos.DataBind()

            chartCantidadVentas.Series("Series1").Points.Clear() ' limpiar cualquier serie existente
            chartCantidadVentas.Series("Series1").ChartType = SeriesChartType.Column ' configurar el tipo de gráfico de la serie predeterminada
            For Each venta In dashboard.ListaCantidadVentas ' agregar datos desde listaIngresos
                Dim fecha As Date
                If Date.TryParse(venta.Fecha, fecha) Then
                    chartCantidadVentas.Series("Series1").Points.AddXY(fecha, venta.CantidadVentas)
                Else
                    MessageBox.Show("Fecha no válida: " & venta.Fecha) ' si la fecha no es válida
                End If
            Next
        End If
    End Sub


    Private Sub DisableCustomDates()
        dtpFechaInicio.Enabled = False
        dtpFechaFin.Enabled = False
        btnOkFechaPersonalizada.Visible = False
    End Sub

    Private Sub btnUltSieteDias_Click(sender As Object, e As EventArgs) Handles btnUltSieteDias.Click
        dtpFechaInicio.Value = Date.Today.AddDays(-7)
        dtpFechaFin.Value = Date.Now
        LoadData()
        DisableCustomDates()
    End Sub

    Private Sub btnUltTreintaDias_Click(sender As Object, e As EventArgs) Handles btnUltTreintaDias.Click
        dtpFechaInicio.Value = Date.Today.AddDays(-30)
        dtpFechaFin.Value = Date.Now
        LoadData()
        DisableCustomDates()
    End Sub

    Private Sub btnEsteMes_Click(sender As Object, e As EventArgs) Handles btnEsteMes.Click
        dtpFechaInicio.Value = New Date(Date.Today.Year, Date.Today.Month, 1)
        dtpFechaFin.Value = Date.Now
        LoadData()
        DisableCustomDates()
    End Sub

    Private Sub btnFechaPersonalizada_Click(sender As Object, e As EventArgs) Handles btnFechaPersonalizada.Click
        dtpFechaInicio.Enabled = True
        dtpFechaFin.Enabled = True
        btnOkFechaPersonalizada.Visible = True
    End Sub

    Private Sub btnOkFechaPersonalizada_Click(sender As Object, e As EventArgs) Handles btnOkFechaPersonalizada.Click
        LoadData()
    End Sub

    Private Sub ibtnGenerarReportes_Click(sender As Object, e As EventArgs) Handles ibtnGenerarReportes.Click
        FormReportes.Show()
    End Sub
End Class