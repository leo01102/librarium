<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAjustes
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
        Label2 = New Label()
        ibtnAgregarUsuario = New FontAwesome.Sharp.IconButton()
        ibtnEliminarUsuario = New FontAwesome.Sharp.IconButton()
        ibtnCambiarContrasena = New FontAwesome.Sharp.IconButton()
        hcbMostrarContrasenaNuevo = New ReaLTaiizor.Controls.HopeCheckBox()
        Label4 = New Label()
        Label5 = New Label()
        htbcNuevoContrasena = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        htbcNuevoUsuario = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        pnlAgregarUsuario = New Panel()
        Panel4 = New Panel()
        ibtnBusquedaCriterio = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel5 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        htbcCambiarContrasenaUsuario = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        Label10 = New Label()
        hcbMostrarContrasenaCambiarNueva = New ReaLTaiizor.Controls.HopeCheckBox()
        htbcCambiarContrasenaNueva = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        Panel10 = New Panel()
        Label7 = New Label()
        Label3 = New Label()
        hcbMostrarContrasenaCambiarActual = New ReaLTaiizor.Controls.HopeCheckBox()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        htbcCambiarContrasenaActual = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        Label6 = New Label()
        Panel9 = New Panel()
        Panel6 = New Panel()
        htbcEliminarUsuario = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        Label9 = New Label()
        hcbMostrarContrasenaEliminar = New ReaLTaiizor.Controls.HopeCheckBox()
        htbcEliminarUsuarioContrasena = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        Label8 = New Label()
        Panel11 = New Panel()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        pnlAgregarUsuario.SuspendLayout()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(100, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 30)
        Label2.TabIndex = 1
        Label2.Text = "Agregar usuario"
        ' 
        ' ibtnAgregarUsuario
        ' 
        ibtnAgregarUsuario.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnAgregarUsuario.FlatAppearance.BorderSize = 0
        ibtnAgregarUsuario.FlatStyle = FlatStyle.Flat
        ibtnAgregarUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnAgregarUsuario.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.Plus
        ibtnAgregarUsuario.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnAgregarUsuario.IconSize = 30
        ibtnAgregarUsuario.ImageAlign = ContentAlignment.MiddleLeft
        ibtnAgregarUsuario.Location = New Point(882, 209)
        ibtnAgregarUsuario.Name = "ibtnAgregarUsuario"
        ibtnAgregarUsuario.Size = New Size(115, 40)
        ibtnAgregarUsuario.TabIndex = 77
        ibtnAgregarUsuario.Text = "Agregar"
        ibtnAgregarUsuario.TextAlign = ContentAlignment.MiddleRight
        ibtnAgregarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnAgregarUsuario.UseVisualStyleBackColor = False
        ' 
        ' ibtnEliminarUsuario
        ' 
        ibtnEliminarUsuario.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnEliminarUsuario.FlatAppearance.BorderSize = 0
        ibtnEliminarUsuario.FlatStyle = FlatStyle.Flat
        ibtnEliminarUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnEliminarUsuario.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.Trash
        ibtnEliminarUsuario.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnEliminarUsuario.IconSize = 30
        ibtnEliminarUsuario.ImageAlign = ContentAlignment.MiddleLeft
        ibtnEliminarUsuario.Location = New Point(882, 209)
        ibtnEliminarUsuario.Name = "ibtnEliminarUsuario"
        ibtnEliminarUsuario.Size = New Size(115, 40)
        ibtnEliminarUsuario.TabIndex = 78
        ibtnEliminarUsuario.Text = "Eliminar"
        ibtnEliminarUsuario.TextAlign = ContentAlignment.MiddleRight
        ibtnEliminarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnEliminarUsuario.UseVisualStyleBackColor = False
        ' 
        ' ibtnCambiarContrasena
        ' 
        ibtnCambiarContrasena.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnCambiarContrasena.FlatAppearance.BorderSize = 0
        ibtnCambiarContrasena.FlatStyle = FlatStyle.Flat
        ibtnCambiarContrasena.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnCambiarContrasena.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnCambiarContrasena.IconChar = FontAwesome.Sharp.IconChar.Pen
        ibtnCambiarContrasena.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnCambiarContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnCambiarContrasena.IconSize = 30
        ibtnCambiarContrasena.ImageAlign = ContentAlignment.MiddleLeft
        ibtnCambiarContrasena.Location = New Point(882, 209)
        ibtnCambiarContrasena.Name = "ibtnCambiarContrasena"
        ibtnCambiarContrasena.Size = New Size(115, 40)
        ibtnCambiarContrasena.TabIndex = 79
        ibtnCambiarContrasena.Text = "Cambiar"
        ibtnCambiarContrasena.TextAlign = ContentAlignment.MiddleRight
        ibtnCambiarContrasena.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnCambiarContrasena.UseVisualStyleBackColor = False
        ' 
        ' hcbMostrarContrasenaNuevo
        ' 
        hcbMostrarContrasenaNuevo.AutoSize = True
        hcbMostrarContrasenaNuevo.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasenaNuevo.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbMostrarContrasenaNuevo.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbMostrarContrasenaNuevo.Enable = True
        hcbMostrarContrasenaNuevo.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasenaNuevo.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbMostrarContrasenaNuevo.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbMostrarContrasenaNuevo.Font = New Font("Segoe UI", 12F)
        hcbMostrarContrasenaNuevo.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbMostrarContrasenaNuevo.Location = New Point(747, 164)
        hcbMostrarContrasenaNuevo.Name = "hcbMostrarContrasenaNuevo"
        hcbMostrarContrasenaNuevo.Size = New Size(170, 20)
        hcbMostrarContrasenaNuevo.TabIndex = 85
        hcbMostrarContrasenaNuevo.Text = "Mostrar contraseña"
        hcbMostrarContrasenaNuevo.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(656, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 84
        Label4.Text = "Contraseña"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(244, 119)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 20)
        Label5.TabIndex = 83
        Label5.Text = "Usuario"
        ' 
        ' htbcNuevoContrasena
        ' 
        htbcNuevoContrasena.BackColor = Color.WhiteSmoke
        htbcNuevoContrasena.BaseColor = Color.White
        htbcNuevoContrasena.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcNuevoContrasena.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcNuevoContrasena.Font = New Font("Segoe UI", 12F)
        htbcNuevoContrasena.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcNuevoContrasena.Hint = ""
        htbcNuevoContrasena.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcNuevoContrasena.Location = New Point(747, 110)
        htbcNuevoContrasena.MaxLength = 32767
        htbcNuevoContrasena.Multiline = False
        htbcNuevoContrasena.Name = "htbcNuevoContrasena"
        htbcNuevoContrasena.PasswordChar = ChrW(0)
        htbcNuevoContrasena.ScrollBars = ScrollBars.None
        htbcNuevoContrasena.SelectedText = ""
        htbcNuevoContrasena.SelectionLength = 0
        htbcNuevoContrasena.SelectionStart = 0
        htbcNuevoContrasena.Size = New Size(250, 38)
        htbcNuevoContrasena.TabIndex = 82
        htbcNuevoContrasena.TabStop = False
        htbcNuevoContrasena.UseSystemPasswordChar = True
        ' 
        ' htbcNuevoUsuario
        ' 
        htbcNuevoUsuario.BackColor = Color.WhiteSmoke
        htbcNuevoUsuario.BaseColor = Color.White
        htbcNuevoUsuario.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcNuevoUsuario.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcNuevoUsuario.Font = New Font("Segoe UI", 12F)
        htbcNuevoUsuario.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcNuevoUsuario.Hint = ""
        htbcNuevoUsuario.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcNuevoUsuario.Location = New Point(309, 110)
        htbcNuevoUsuario.MaxLength = 32767
        htbcNuevoUsuario.Multiline = False
        htbcNuevoUsuario.Name = "htbcNuevoUsuario"
        htbcNuevoUsuario.PasswordChar = ChrW(0)
        htbcNuevoUsuario.ScrollBars = ScrollBars.None
        htbcNuevoUsuario.SelectedText = ""
        htbcNuevoUsuario.SelectionLength = 0
        htbcNuevoUsuario.SelectionStart = 0
        htbcNuevoUsuario.Size = New Size(250, 38)
        htbcNuevoUsuario.TabIndex = 81
        htbcNuevoUsuario.TabStop = False
        htbcNuevoUsuario.UseSystemPasswordChar = False
        ' 
        ' pnlAgregarUsuario
        ' 
        pnlAgregarUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlAgregarUsuario.BackColor = Color.White
        pnlAgregarUsuario.Controls.Add(Panel4)
        pnlAgregarUsuario.Controls.Add(ibtnBusquedaCriterio)
        pnlAgregarUsuario.Controls.Add(htbcNuevoUsuario)
        pnlAgregarUsuario.Controls.Add(ibtnAgregarUsuario)
        pnlAgregarUsuario.Controls.Add(htbcNuevoContrasena)
        pnlAgregarUsuario.Controls.Add(Label5)
        pnlAgregarUsuario.Controls.Add(Label4)
        pnlAgregarUsuario.Controls.Add(hcbMostrarContrasenaNuevo)
        pnlAgregarUsuario.Controls.Add(Label2)
        pnlAgregarUsuario.Location = New Point(10, 15)
        pnlAgregarUsuario.Margin = New Padding(15)
        pnlAgregarUsuario.Name = "pnlAgregarUsuario"
        pnlAgregarUsuario.Padding = New Padding(10)
        pnlAgregarUsuario.Size = New Size(1380, 280)
        pnlAgregarUsuario.TabIndex = 89
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        Panel4.Location = New Point(100, 80)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1200, 5)
        Panel4.TabIndex = 86
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
        ibtnBusquedaCriterio.Location = New Point(1607, 105)
        ibtnBusquedaCriterio.Name = "ibtnBusquedaCriterio"
        ibtnBusquedaCriterio.Size = New Size(25, 25)
        ibtnBusquedaCriterio.TabIndex = 24
        ibtnBusquedaCriterio.TextAlign = ContentAlignment.MiddleRight
        ibtnBusquedaCriterio.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnBusquedaCriterio.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = SystemColors.Control
        Panel1.Location = New Point(10, 295)
        Panel1.MaximumSize = New Size(0, 15)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1380, 15)
        Panel1.TabIndex = 87
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = SystemColors.Control
        Panel2.Location = New Point(0, 885)
        Panel2.MaximumSize = New Size(0, 15)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1400, 15)
        Panel2.TabIndex = 91
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = SystemColors.Control
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(10, 885)
        Panel3.TabIndex = 92
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.BackColor = SystemColors.Control
        Panel5.Location = New Point(1390, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(10, 885)
        Panel5.TabIndex = 93
        ' 
        ' Panel7
        ' 
        Panel7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel7.BackColor = SystemColors.Control
        Panel7.Location = New Point(10, 0)
        Panel7.MaximumSize = New Size(0, 15)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1380, 15)
        Panel7.TabIndex = 95
        ' 
        ' Panel8
        ' 
        Panel8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(htbcCambiarContrasenaUsuario)
        Panel8.Controls.Add(Label10)
        Panel8.Controls.Add(hcbMostrarContrasenaCambiarNueva)
        Panel8.Controls.Add(htbcCambiarContrasenaNueva)
        Panel8.Controls.Add(Panel10)
        Panel8.Controls.Add(Label7)
        Panel8.Controls.Add(Label3)
        Panel8.Controls.Add(hcbMostrarContrasenaCambiarActual)
        Panel8.Controls.Add(IconButton3)
        Panel8.Controls.Add(ibtnCambiarContrasena)
        Panel8.Controls.Add(htbcCambiarContrasenaActual)
        Panel8.Controls.Add(Label6)
        Panel8.Location = New Point(10, 310)
        Panel8.Margin = New Padding(15)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(10)
        Panel8.Size = New Size(1380, 280)
        Panel8.TabIndex = 96
        ' 
        ' htbcCambiarContrasenaUsuario
        ' 
        htbcCambiarContrasenaUsuario.BackColor = Color.WhiteSmoke
        htbcCambiarContrasenaUsuario.BaseColor = Color.White
        htbcCambiarContrasenaUsuario.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCambiarContrasenaUsuario.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCambiarContrasenaUsuario.Font = New Font("Segoe UI", 12F)
        htbcCambiarContrasenaUsuario.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcCambiarContrasenaUsuario.Hint = ""
        htbcCambiarContrasenaUsuario.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcCambiarContrasenaUsuario.Location = New Point(309, 117)
        htbcCambiarContrasenaUsuario.MaxLength = 32767
        htbcCambiarContrasenaUsuario.Multiline = False
        htbcCambiarContrasenaUsuario.Name = "htbcCambiarContrasenaUsuario"
        htbcCambiarContrasenaUsuario.PasswordChar = ChrW(0)
        htbcCambiarContrasenaUsuario.ScrollBars = ScrollBars.None
        htbcCambiarContrasenaUsuario.SelectedText = ""
        htbcCambiarContrasenaUsuario.SelectionLength = 0
        htbcCambiarContrasenaUsuario.SelectionStart = 0
        htbcCambiarContrasenaUsuario.Size = New Size(250, 38)
        htbcCambiarContrasenaUsuario.TabIndex = 93
        htbcCambiarContrasenaUsuario.TabStop = False
        htbcCambiarContrasenaUsuario.UseSystemPasswordChar = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(610, 127)
        Label10.Name = "Label10"
        Label10.Size = New Size(126, 20)
        Label10.TabIndex = 90
        Label10.Text = "Contraseña nueva"
        ' 
        ' hcbMostrarContrasenaCambiarNueva
        ' 
        hcbMostrarContrasenaCambiarNueva.AutoSize = True
        hcbMostrarContrasenaCambiarNueva.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasenaCambiarNueva.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbMostrarContrasenaCambiarNueva.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbMostrarContrasenaCambiarNueva.Enable = True
        hcbMostrarContrasenaCambiarNueva.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasenaCambiarNueva.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbMostrarContrasenaCambiarNueva.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbMostrarContrasenaCambiarNueva.Font = New Font("Segoe UI", 12F)
        hcbMostrarContrasenaCambiarNueva.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbMostrarContrasenaCambiarNueva.Location = New Point(747, 171)
        hcbMostrarContrasenaCambiarNueva.Name = "hcbMostrarContrasenaCambiarNueva"
        hcbMostrarContrasenaCambiarNueva.Size = New Size(170, 20)
        hcbMostrarContrasenaCambiarNueva.TabIndex = 92
        hcbMostrarContrasenaCambiarNueva.Text = "Mostrar contraseña"
        hcbMostrarContrasenaCambiarNueva.UseVisualStyleBackColor = True
        ' 
        ' htbcCambiarContrasenaNueva
        ' 
        htbcCambiarContrasenaNueva.BackColor = Color.WhiteSmoke
        htbcCambiarContrasenaNueva.BaseColor = Color.White
        htbcCambiarContrasenaNueva.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCambiarContrasenaNueva.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCambiarContrasenaNueva.Font = New Font("Segoe UI", 12F)
        htbcCambiarContrasenaNueva.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcCambiarContrasenaNueva.Hint = ""
        htbcCambiarContrasenaNueva.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcCambiarContrasenaNueva.Location = New Point(747, 117)
        htbcCambiarContrasenaNueva.MaxLength = 32767
        htbcCambiarContrasenaNueva.Multiline = False
        htbcCambiarContrasenaNueva.Name = "htbcCambiarContrasenaNueva"
        htbcCambiarContrasenaNueva.PasswordChar = ChrW(0)
        htbcCambiarContrasenaNueva.ScrollBars = ScrollBars.None
        htbcCambiarContrasenaNueva.SelectedText = ""
        htbcCambiarContrasenaNueva.SelectionLength = 0
        htbcCambiarContrasenaNueva.SelectionStart = 0
        htbcCambiarContrasenaNueva.Size = New Size(250, 38)
        htbcCambiarContrasenaNueva.TabIndex = 91
        htbcCambiarContrasenaNueva.TabStop = False
        htbcCambiarContrasenaNueva.UseSystemPasswordChar = True
        ' 
        ' Panel10
        ' 
        Panel10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel10.BackColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        Panel10.Location = New Point(100, 80)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(1200, 5)
        Panel10.TabIndex = 87
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(174, 192)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 20)
        Label7.TabIndex = 87
        Label7.Text = "Contraseña actual"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(242, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 20)
        Label3.TabIndex = 87
        Label3.Text = "Usuario"
        ' 
        ' hcbMostrarContrasenaCambiarActual
        ' 
        hcbMostrarContrasenaCambiarActual.AutoSize = True
        hcbMostrarContrasenaCambiarActual.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasenaCambiarActual.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbMostrarContrasenaCambiarActual.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbMostrarContrasenaCambiarActual.Enable = True
        hcbMostrarContrasenaCambiarActual.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasenaCambiarActual.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbMostrarContrasenaCambiarActual.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbMostrarContrasenaCambiarActual.Font = New Font("Segoe UI", 12F)
        hcbMostrarContrasenaCambiarActual.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbMostrarContrasenaCambiarActual.Location = New Point(309, 237)
        hcbMostrarContrasenaCambiarActual.Name = "hcbMostrarContrasenaCambiarActual"
        hcbMostrarContrasenaCambiarActual.Size = New Size(170, 20)
        hcbMostrarContrasenaCambiarActual.TabIndex = 89
        hcbMostrarContrasenaCambiarActual.Text = "Mostrar contraseña"
        hcbMostrarContrasenaCambiarActual.UseVisualStyleBackColor = True
        ' 
        ' IconButton3
        ' 
        IconButton3.Anchor = AnchorStyles.Right
        IconButton3.BackColor = Color.White
        IconButton3.FlatAppearance.BorderSize = 0
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.SortDown
        IconButton3.IconColor = Color.Black
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.IconSize = 24
        IconButton3.ImageAlign = ContentAlignment.BottomCenter
        IconButton3.Location = New Point(3042, 207)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(25, 25)
        IconButton3.TabIndex = 24
        IconButton3.TextAlign = ContentAlignment.MiddleRight
        IconButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton3.UseVisualStyleBackColor = False
        ' 
        ' htbcCambiarContrasenaActual
        ' 
        htbcCambiarContrasenaActual.BackColor = Color.WhiteSmoke
        htbcCambiarContrasenaActual.BaseColor = Color.White
        htbcCambiarContrasenaActual.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCambiarContrasenaActual.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcCambiarContrasenaActual.Font = New Font("Segoe UI", 12F)
        htbcCambiarContrasenaActual.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcCambiarContrasenaActual.Hint = ""
        htbcCambiarContrasenaActual.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcCambiarContrasenaActual.Location = New Point(309, 183)
        htbcCambiarContrasenaActual.MaxLength = 32767
        htbcCambiarContrasenaActual.Multiline = False
        htbcCambiarContrasenaActual.Name = "htbcCambiarContrasenaActual"
        htbcCambiarContrasenaActual.PasswordChar = ChrW(0)
        htbcCambiarContrasenaActual.ScrollBars = ScrollBars.None
        htbcCambiarContrasenaActual.SelectedText = ""
        htbcCambiarContrasenaActual.SelectionLength = 0
        htbcCambiarContrasenaActual.SelectionStart = 0
        htbcCambiarContrasenaActual.Size = New Size(250, 38)
        htbcCambiarContrasenaActual.TabIndex = 88
        htbcCambiarContrasenaActual.TabStop = False
        htbcCambiarContrasenaActual.UseSystemPasswordChar = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(100, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(198, 30)
        Label6.TabIndex = 0
        Label6.Text = "Cambiar contraseña"
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = SystemColors.Control
        Panel9.Location = New Point(10, 590)
        Panel9.MaximumSize = New Size(0, 15)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(1380, 15)
        Panel9.TabIndex = 97
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(htbcEliminarUsuario)
        Panel6.Controls.Add(Label9)
        Panel6.Controls.Add(hcbMostrarContrasenaEliminar)
        Panel6.Controls.Add(htbcEliminarUsuarioContrasena)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Panel11)
        Panel6.Controls.Add(IconButton2)
        Panel6.Controls.Add(ibtnEliminarUsuario)
        Panel6.Controls.Add(Label1)
        Panel6.Location = New Point(10, 605)
        Panel6.Margin = New Padding(15)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(10)
        Panel6.Size = New Size(1380, 280)
        Panel6.TabIndex = 98
        ' 
        ' htbcEliminarUsuario
        ' 
        htbcEliminarUsuario.BackColor = Color.WhiteSmoke
        htbcEliminarUsuario.BaseColor = Color.White
        htbcEliminarUsuario.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcEliminarUsuario.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcEliminarUsuario.Font = New Font("Segoe UI", 12F)
        htbcEliminarUsuario.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcEliminarUsuario.Hint = ""
        htbcEliminarUsuario.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcEliminarUsuario.Location = New Point(309, 117)
        htbcEliminarUsuario.MaxLength = 32767
        htbcEliminarUsuario.Multiline = False
        htbcEliminarUsuario.Name = "htbcEliminarUsuario"
        htbcEliminarUsuario.PasswordChar = ChrW(0)
        htbcEliminarUsuario.ScrollBars = ScrollBars.None
        htbcEliminarUsuario.SelectedText = ""
        htbcEliminarUsuario.SelectionLength = 0
        htbcEliminarUsuario.SelectionStart = 0
        htbcEliminarUsuario.Size = New Size(250, 38)
        htbcEliminarUsuario.TabIndex = 93
        htbcEliminarUsuario.TabStop = False
        htbcEliminarUsuario.UseSystemPasswordChar = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(656, 127)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 20)
        Label9.TabIndex = 90
        Label9.Text = "Contraseña"
        ' 
        ' hcbMostrarContrasenaEliminar
        ' 
        hcbMostrarContrasenaEliminar.AutoSize = True
        hcbMostrarContrasenaEliminar.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasenaEliminar.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbMostrarContrasenaEliminar.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbMostrarContrasenaEliminar.Enable = True
        hcbMostrarContrasenaEliminar.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasenaEliminar.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbMostrarContrasenaEliminar.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbMostrarContrasenaEliminar.Font = New Font("Segoe UI", 12F)
        hcbMostrarContrasenaEliminar.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbMostrarContrasenaEliminar.Location = New Point(747, 171)
        hcbMostrarContrasenaEliminar.Name = "hcbMostrarContrasenaEliminar"
        hcbMostrarContrasenaEliminar.Size = New Size(170, 20)
        hcbMostrarContrasenaEliminar.TabIndex = 92
        hcbMostrarContrasenaEliminar.Text = "Mostrar contraseña"
        hcbMostrarContrasenaEliminar.UseVisualStyleBackColor = True
        ' 
        ' htbcEliminarUsuarioContrasena
        ' 
        htbcEliminarUsuarioContrasena.BackColor = Color.WhiteSmoke
        htbcEliminarUsuarioContrasena.BaseColor = Color.White
        htbcEliminarUsuarioContrasena.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcEliminarUsuarioContrasena.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcEliminarUsuarioContrasena.Font = New Font("Segoe UI", 12F)
        htbcEliminarUsuarioContrasena.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcEliminarUsuarioContrasena.Hint = ""
        htbcEliminarUsuarioContrasena.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcEliminarUsuarioContrasena.Location = New Point(750, 117)
        htbcEliminarUsuarioContrasena.MaxLength = 32767
        htbcEliminarUsuarioContrasena.Multiline = False
        htbcEliminarUsuarioContrasena.Name = "htbcEliminarUsuarioContrasena"
        htbcEliminarUsuarioContrasena.PasswordChar = ChrW(0)
        htbcEliminarUsuarioContrasena.ScrollBars = ScrollBars.None
        htbcEliminarUsuarioContrasena.SelectedText = ""
        htbcEliminarUsuarioContrasena.SelectionLength = 0
        htbcEliminarUsuarioContrasena.SelectionStart = 0
        htbcEliminarUsuarioContrasena.Size = New Size(250, 38)
        htbcEliminarUsuarioContrasena.TabIndex = 91
        htbcEliminarUsuarioContrasena.TabStop = False
        htbcEliminarUsuarioContrasena.UseSystemPasswordChar = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(239, 129)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 20)
        Label8.TabIndex = 89
        Label8.Text = "Usuario"
        ' 
        ' Panel11
        ' 
        Panel11.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel11.BackColor = Color.FromArgb(CByte(16), CByte(29), CByte(64))
        Panel11.Location = New Point(100, 80)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(1200, 5)
        Panel11.TabIndex = 88
        ' 
        ' IconButton2
        ' 
        IconButton2.Anchor = AnchorStyles.Right
        IconButton2.BackColor = Color.White
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.SortDown
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 24
        IconButton2.ImageAlign = ContentAlignment.BottomCenter
        IconButton2.Location = New Point(3042, 221)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(25, 25)
        IconButton2.TabIndex = 24
        IconButton2.TextAlign = ContentAlignment.MiddleRight
        IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(100, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 30)
        Label1.TabIndex = 2
        Label1.Text = "Eliminar usuario"
        ' 
        ' FormAjustes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1400, 900)
        Controls.Add(Panel6)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(Panel1)
        Controls.Add(pnlAgregarUsuario)
        Controls.Add(Panel7)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAjustes"
        Text = "FormAjustes"
        pnlAgregarUsuario.ResumeLayout(False)
        pnlAgregarUsuario.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ibtnAgregarUsuario As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnEliminarUsuario As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnCambiarContrasena As FontAwesome.Sharp.IconButton
    Friend WithEvents hcbMostrarContrasenaNuevo As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents htbcNuevoContrasena As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcNuevoUsuario As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents pnlAgregarUsuario As Panel
    Friend WithEvents ibtnBusquedaCriterio As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents htbcCambiarContrasenaActual As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hcbMostrarContrasenaCambiarActual As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents hcbMostrarContrasenaEliminar As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents htbcEliminarUsuarioContrasena As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents Label10 As Label
    Friend WithEvents hcbMostrarContrasenaCambiarNueva As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents htbcCambiarContrasenaNueva As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcCambiarContrasenaUsuario As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents htbcEliminarUsuario As ReaLTaiizor.Controls.HopeTextBoxCustom
End Class
