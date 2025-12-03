<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    'Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        pnlBar = New Panel()
        Panel1 = New Panel()
        ibtnCerrar = New FontAwesome.Sharp.IconButton()
        ibtnMinimizar = New FontAwesome.Sharp.IconButton()
        ibtnMaximizar = New FontAwesome.Sharp.IconButton()
        pbIcono = New PictureBox()
        ibtnLibros = New FontAwesome.Sharp.IconButton()
        pnlMenu = New Panel()
        ibtnAjustes = New FontAwesome.Sharp.IconButton()
        ibtnDashboard = New FontAwesome.Sharp.IconButton()
        ibtnVentas = New FontAwesome.Sharp.IconButton()
        ibtnProveedores = New FontAwesome.Sharp.IconButton()
        ibtnClientes = New FontAwesome.Sharp.IconButton()
        pnlChildForm = New Panel()
        pnlBar.SuspendLayout()
        Panel1.SuspendLayout()
        CType(pbIcono, ComponentModel.ISupportInitialize).BeginInit()
        pnlMenu.SuspendLayout()
        pnlChildForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBar
        ' 
        pnlBar.BackColor = SystemColors.Window
        pnlBar.Controls.Add(Panel1)
        pnlBar.Dock = DockStyle.Top
        pnlBar.Location = New Point(0, 0)
        pnlBar.Name = "pnlBar"
        pnlBar.Size = New Size(1184, 45)
        pnlBar.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ibtnCerrar)
        Panel1.Controls.Add(ibtnMinimizar)
        Panel1.Controls.Add(ibtnMaximizar)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(1049, 0)
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
        ' pbIcono
        ' 
        pbIcono.Image = My.Resources.Resources.libro2_recortado_png
        pbIcono.Location = New Point(0, 0)
        pbIcono.Name = "pbIcono"
        pbIcono.Size = New Size(200, 75)
        pbIcono.SizeMode = PictureBoxSizeMode.Zoom
        pbIcono.TabIndex = 1
        pbIcono.TabStop = False
        ' 
        ' ibtnLibros
        ' 
        ibtnLibros.FlatAppearance.BorderSize = 0
        ibtnLibros.FlatStyle = FlatStyle.Flat
        ibtnLibros.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnLibros.ForeColor = SystemColors.GrayText
        ibtnLibros.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        ibtnLibros.IconColor = Color.Gray
        ibtnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnLibros.IconSize = 35
        ibtnLibros.ImageAlign = ContentAlignment.MiddleLeft
        ibtnLibros.Location = New Point(0, 147)
        ibtnLibros.Name = "ibtnLibros"
        ibtnLibros.Padding = New Padding(10, 0, 20, 0)
        ibtnLibros.Size = New Size(200, 60)
        ibtnLibros.TabIndex = 2
        ibtnLibros.Text = "Libros"
        ibtnLibros.TextAlign = ContentAlignment.MiddleRight
        ibtnLibros.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnLibros.UseVisualStyleBackColor = True
        ' 
        ' pnlMenu
        ' 
        pnlMenu.BackColor = SystemColors.Window
        pnlMenu.Controls.Add(pbIcono)
        pnlMenu.Controls.Add(ibtnAjustes)
        pnlMenu.Controls.Add(ibtnDashboard)
        pnlMenu.Controls.Add(ibtnVentas)
        pnlMenu.Controls.Add(ibtnProveedores)
        pnlMenu.Controls.Add(ibtnClientes)
        pnlMenu.Controls.Add(ibtnLibros)
        pnlMenu.Dock = DockStyle.Left
        pnlMenu.Location = New Point(0, 0)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(200, 884)
        pnlMenu.TabIndex = 3
        ' 
        ' ibtnAjustes
        ' 
        ibtnAjustes.Dock = DockStyle.Bottom
        ibtnAjustes.FlatAppearance.BorderSize = 0
        ibtnAjustes.FlatStyle = FlatStyle.Flat
        ibtnAjustes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnAjustes.ForeColor = SystemColors.GrayText
        ibtnAjustes.IconChar = FontAwesome.Sharp.IconChar.Gear
        ibtnAjustes.IconColor = Color.Gray
        ibtnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnAjustes.IconSize = 35
        ibtnAjustes.ImageAlign = ContentAlignment.MiddleLeft
        ibtnAjustes.Location = New Point(0, 824)
        ibtnAjustes.Name = "ibtnAjustes"
        ibtnAjustes.Padding = New Padding(10, 0, 20, 0)
        ibtnAjustes.Size = New Size(200, 60)
        ibtnAjustes.TabIndex = 7
        ibtnAjustes.Text = "Ajustes"
        ibtnAjustes.TextAlign = ContentAlignment.MiddleRight
        ibtnAjustes.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnAjustes.UseVisualStyleBackColor = True
        ' 
        ' ibtnDashboard
        ' 
        ibtnDashboard.FlatAppearance.BorderSize = 0
        ibtnDashboard.FlatStyle = FlatStyle.Flat
        ibtnDashboard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnDashboard.ForeColor = SystemColors.GrayText
        ibtnDashboard.IconChar = FontAwesome.Sharp.IconChar.GaugeHigh
        ibtnDashboard.IconColor = Color.Gray
        ibtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnDashboard.IconSize = 35
        ibtnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        ibtnDashboard.Location = New Point(0, 81)
        ibtnDashboard.Name = "ibtnDashboard"
        ibtnDashboard.Padding = New Padding(10, 0, 20, 0)
        ibtnDashboard.Size = New Size(200, 60)
        ibtnDashboard.TabIndex = 6
        ibtnDashboard.Text = "Dashboard"
        ibtnDashboard.TextAlign = ContentAlignment.MiddleRight
        ibtnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnDashboard.UseVisualStyleBackColor = True
        ' 
        ' ibtnVentas
        ' 
        ibtnVentas.FlatAppearance.BorderSize = 0
        ibtnVentas.FlatStyle = FlatStyle.Flat
        ibtnVentas.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnVentas.ForeColor = SystemColors.GrayText
        ibtnVentas.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        ibtnVentas.IconColor = Color.Gray
        ibtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnVentas.IconSize = 35
        ibtnVentas.ImageAlign = ContentAlignment.MiddleLeft
        ibtnVentas.Location = New Point(0, 279)
        ibtnVentas.Name = "ibtnVentas"
        ibtnVentas.Padding = New Padding(10, 0, 20, 0)
        ibtnVentas.Size = New Size(200, 60)
        ibtnVentas.TabIndex = 5
        ibtnVentas.Text = "Ventas"
        ibtnVentas.TextAlign = ContentAlignment.MiddleRight
        ibtnVentas.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnVentas.UseVisualStyleBackColor = True
        ' 
        ' ibtnProveedores
        ' 
        ibtnProveedores.FlatAppearance.BorderSize = 0
        ibtnProveedores.FlatStyle = FlatStyle.Flat
        ibtnProveedores.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnProveedores.ForeColor = SystemColors.GrayText
        ibtnProveedores.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking
        ibtnProveedores.IconColor = Color.Gray
        ibtnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnProveedores.IconSize = 35
        ibtnProveedores.ImageAlign = ContentAlignment.MiddleLeft
        ibtnProveedores.Location = New Point(0, 345)
        ibtnProveedores.Name = "ibtnProveedores"
        ibtnProveedores.Padding = New Padding(10, 0, 20, 0)
        ibtnProveedores.Size = New Size(200, 60)
        ibtnProveedores.TabIndex = 4
        ibtnProveedores.Text = "Proveedores"
        ibtnProveedores.TextAlign = ContentAlignment.MiddleRight
        ibtnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnProveedores.UseVisualStyleBackColor = True
        ' 
        ' ibtnClientes
        ' 
        ibtnClientes.FlatAppearance.BorderSize = 0
        ibtnClientes.FlatStyle = FlatStyle.Flat
        ibtnClientes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnClientes.ForeColor = SystemColors.GrayText
        ibtnClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup
        ibtnClientes.IconColor = Color.Gray
        ibtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnClientes.IconSize = 35
        ibtnClientes.ImageAlign = ContentAlignment.MiddleLeft
        ibtnClientes.Location = New Point(0, 213)
        ibtnClientes.Name = "ibtnClientes"
        ibtnClientes.Padding = New Padding(10, 0, 20, 0)
        ibtnClientes.Size = New Size(200, 60)
        ibtnClientes.TabIndex = 3
        ibtnClientes.Text = "Clientes"
        ibtnClientes.TextAlign = ContentAlignment.MiddleRight
        ibtnClientes.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnClientes.UseVisualStyleBackColor = True
        ' 
        ' pnlChildForm
        ' 
        pnlChildForm.BackColor = Color.FromArgb(CByte(245), CByte(250), CByte(250))
        pnlChildForm.Controls.Add(pnlBar)
        pnlChildForm.Dock = DockStyle.Fill
        pnlChildForm.Location = New Point(200, 0)
        pnlChildForm.Name = "pnlChildForm"
        pnlChildForm.Size = New Size(1184, 884)
        pnlChildForm.TabIndex = 4
        ' 
        ' FormPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(1384, 884)
        ControlBox = False
        Controls.Add(pnlChildForm)
        Controls.Add(pnlMenu)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        pnlBar.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(pbIcono, ComponentModel.ISupportInitialize).EndInit()
        pnlMenu.ResumeLayout(False)
        pnlChildForm.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlBar As Panel
    Friend WithEvents ibtnLibros As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents ibtnMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnProveedores As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnVentas As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlChildForm As Panel
    Friend WithEvents ibtnMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ibtnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnAjustes As FontAwesome.Sharp.IconButton
    Friend WithEvents pbIcono As PictureBox

End Class
