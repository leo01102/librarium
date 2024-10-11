<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        pnlLogin = New Panel()
        ibtnCancelarLogin = New FontAwesome.Sharp.IconButton()
        hcbMostrarContrasena = New ReaLTaiizor.Controls.HopeCheckBox()
        Label2 = New Label()
        Label1 = New Label()
        htbcContrasena = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        ibtnLogin = New FontAwesome.Sharp.IconButton()
        htbcUsuario = New ReaLTaiizor.Controls.HopeTextBoxCustom()
        pnlLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.White
        pnlLogin.Controls.Add(ibtnCancelarLogin)
        pnlLogin.Controls.Add(hcbMostrarContrasena)
        pnlLogin.Controls.Add(Label2)
        pnlLogin.Controls.Add(Label1)
        pnlLogin.Controls.Add(htbcContrasena)
        pnlLogin.Controls.Add(ibtnLogin)
        pnlLogin.Controls.Add(htbcUsuario)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.Location = New Point(0, 0)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(700, 450)
        pnlLogin.TabIndex = 1
        ' 
        ' ibtnCancelarLogin
        ' 
        ibtnCancelarLogin.Anchor = AnchorStyles.None
        ibtnCancelarLogin.BackColor = Color.WhiteSmoke
        ibtnCancelarLogin.FlatAppearance.BorderSize = 0
        ibtnCancelarLogin.FlatStyle = FlatStyle.Flat
        ibtnCancelarLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnCancelarLogin.ForeColor = Color.DimGray
        ibtnCancelarLogin.IconChar = FontAwesome.Sharp.IconChar.Multiply
        ibtnCancelarLogin.IconColor = Color.DimGray
        ibtnCancelarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnCancelarLogin.IconSize = 30
        ibtnCancelarLogin.ImageAlign = ContentAlignment.MiddleLeft
        ibtnCancelarLogin.Location = New Point(254, 300)
        ibtnCancelarLogin.Name = "ibtnCancelarLogin"
        ibtnCancelarLogin.Size = New Size(100, 40)
        ibtnCancelarLogin.TabIndex = 81
        ibtnCancelarLogin.Text = "Salir"
        ibtnCancelarLogin.TextAlign = ContentAlignment.MiddleRight
        ibtnCancelarLogin.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnCancelarLogin.UseVisualStyleBackColor = False
        ' 
        ' hcbMostrarContrasena
        ' 
        hcbMostrarContrasena.AutoSize = True
        hcbMostrarContrasena.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasena.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        hcbMostrarContrasena.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        hcbMostrarContrasena.Enable = True
        hcbMostrarContrasena.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        hcbMostrarContrasena.EnabledStringColor = Color.FromArgb(CByte(153), CByte(153), CByte(153))
        hcbMostrarContrasena.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        hcbMostrarContrasena.Font = New Font("Segoe UI", 12F)
        hcbMostrarContrasena.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        hcbMostrarContrasena.Location = New Point(254, 250)
        hcbMostrarContrasena.Name = "hcbMostrarContrasena"
        hcbMostrarContrasena.Size = New Size(170, 20)
        hcbMostrarContrasena.TabIndex = 80
        hcbMostrarContrasena.Text = "Mostrar contraseña"
        hcbMostrarContrasena.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(154, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 79
        Label2.Text = "Contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(154, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 78
        Label1.Text = "Usuario"
        ' 
        ' htbcContrasena
        ' 
        htbcContrasena.BackColor = Color.WhiteSmoke
        htbcContrasena.BaseColor = Color.White
        htbcContrasena.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcContrasena.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcContrasena.Font = New Font("Segoe UI", 12F)
        htbcContrasena.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcContrasena.Hint = ""
        htbcContrasena.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcContrasena.Location = New Point(254, 200)
        htbcContrasena.MaxLength = 32767
        htbcContrasena.Multiline = False
        htbcContrasena.Name = "htbcContrasena"
        htbcContrasena.PasswordChar = ChrW(0)
        htbcContrasena.ScrollBars = ScrollBars.None
        htbcContrasena.SelectedText = ""
        htbcContrasena.SelectionLength = 0
        htbcContrasena.SelectionStart = 0
        htbcContrasena.Size = New Size(250, 38)
        htbcContrasena.TabIndex = 77
        htbcContrasena.TabStop = False
        htbcContrasena.UseSystemPasswordChar = True
        ' 
        ' ibtnLogin
        ' 
        ibtnLogin.Anchor = AnchorStyles.None
        ibtnLogin.BackColor = Color.FromArgb(CByte(224), CByte(241), CByte(251))
        ibtnLogin.FlatAppearance.BorderSize = 0
        ibtnLogin.FlatStyle = FlatStyle.Flat
        ibtnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnLogin.ForeColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnLogin.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket
        ibtnLogin.IconColor = Color.FromArgb(CByte(5), CByte(73), CByte(171))
        ibtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnLogin.IconSize = 30
        ibtnLogin.ImageAlign = ContentAlignment.MiddleLeft
        ibtnLogin.Location = New Point(404, 300)
        ibtnLogin.Name = "ibtnLogin"
        ibtnLogin.Size = New Size(100, 40)
        ibtnLogin.TabIndex = 76
        ibtnLogin.Text = "Login"
        ibtnLogin.TextAlign = ContentAlignment.MiddleRight
        ibtnLogin.TextImageRelation = TextImageRelation.ImageBeforeText
        ibtnLogin.UseVisualStyleBackColor = False
        ' 
        ' htbcUsuario
        ' 
        htbcUsuario.BackColor = Color.WhiteSmoke
        htbcUsuario.BaseColor = Color.White
        htbcUsuario.BorderColorA = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcUsuario.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        htbcUsuario.Font = New Font("Segoe UI", 12F)
        htbcUsuario.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        htbcUsuario.Hint = ""
        htbcUsuario.HoverBorderColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        htbcUsuario.Location = New Point(254, 132)
        htbcUsuario.MaxLength = 32767
        htbcUsuario.Multiline = False
        htbcUsuario.Name = "htbcUsuario"
        htbcUsuario.PasswordChar = ChrW(0)
        htbcUsuario.ScrollBars = ScrollBars.None
        htbcUsuario.SelectedText = ""
        htbcUsuario.SelectionLength = 0
        htbcUsuario.SelectionStart = 0
        htbcUsuario.Size = New Size(250, 38)
        htbcUsuario.TabIndex = 75
        htbcUsuario.TabStop = False
        htbcUsuario.UseSystemPasswordChar = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 450)
        Controls.Add(pnlLogin)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLogin"
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLogin As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents htbcContrasena As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents ibtnLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents htbcUsuario As ReaLTaiizor.Controls.HopeTextBoxCustom
    Friend WithEvents ibtnCancelarLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents hcbMostrarContrasena As ReaLTaiizor.Controls.HopeCheckBox
End Class
