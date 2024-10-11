' Backend

Imports FontAwesome.Sharp
Imports PdfSharp.BigGustave
Imports ReaLTaiizor.Controls

Module Controles

    ' cargar datos a los controles
    Public Sub CargarControles(fila As DataGridViewRow, controlesColumnasMapa As Dictionary(Of String, String), formulario As Form)
        For Each cntrl In controlesColumnasMapa ' iterar el diccionario control por control
            ' guardar la llave y el valor del diccionario por separado
            Dim controlNombre As String = cntrl.Key
            Dim columnaNombre As String = cntrl.Value
            ' buscar el nombre del control en el formulario dado
            Dim control As Control = formulario.Controls.Find(controlNombre, True).FirstOrDefault()
            ' cargar control con el valor de la fila dada
            If control IsNot Nothing Then ' si se encontró el control
                Dim valorCelda = fila.Cells(columnaNombre).Value ' obtener valor de la celda de la fila cuya columna tenga el nombre columnaNombre
                ' según el tipo de control
                Select Case True
                    Case TypeOf control Is HopeTextBoxCustom
                        ' convertir el control al tipo HopeTextBoxCustom
                        Dim tb As HopeTextBoxCustom = DirectCast(control, HopeTextBoxCustom)
                        ' si no es null, al texto del control asignarle el valor de la celda; de lo contrario, asignar una cadena vacía
                        tb.Text = If(valorCelda IsNot DBNull.Value, valorCelda.ToString(), String.Empty)
                    Case TypeOf control Is HopeRichTextBoxCustom
                        Dim tb As HopeRichTextBoxCustom = DirectCast(control, HopeRichTextBoxCustom)
                        tb.Text = If(valorCelda IsNot DBNull.Value, valorCelda.ToString(), String.Empty)
                    Case TypeOf control Is DateTimePicker
                        Dim dtp As DateTimePicker = DirectCast(control, DateTimePicker)
                        If valorCelda IsNot DBNull.Value AndAlso TypeOf valorCelda Is Date Then
                            dtp.Value = DirectCast(valorCelda, Date)
                        Else
                            dtp.Value = DateTime.Now ' o el valor predeterminado que desees
                        End If
                    Case TypeOf control Is ComboBox
                        Dim cb As ComboBox = DirectCast(control, ComboBox)
                        If valorCelda IsNot DBNull.Value Then
                            Dim idProveedor As Integer
                            If Integer.TryParse(valorCelda.ToString(), idProveedor) Then
                                cb.SelectedValue = idProveedor
                            Else
                                cb.SelectedIndex = -1 ' si no se puede parsear, establece como no seleccionado
                            End If
                        Else
                            cb.SelectedIndex = -1 ' si el valor es DBNull, establece como no seleccionado
                        End If
                    Case TypeOf control Is AloneComboBox
                        Dim cb As AloneComboBox = DirectCast(control, AloneComboBox)
                        If valorCelda IsNot DBNull.Value Then
                            Dim idProveedor As Integer
                            If Integer.TryParse(valorCelda.ToString(), idProveedor) Then
                                cb.SelectedValue = idProveedor
                            Else
                                cb.SelectedIndex = -1 ' si no se puede parsear, establece como no seleccionado
                            End If
                        Else
                            cb.SelectedIndex = -1 ' si el valor es DBNull, establece como no seleccionado
                        End If
                    Case TypeOf control Is HopeNumeric
                        Dim hn As HopeNumeric = DirectCast(control, HopeNumeric)
                        If valorCelda IsNot DBNull.Value AndAlso IsNumeric(valorCelda) Then
                            hn.ValueNumber = Convert.ToSingle(valorCelda)
                        Else
                            hn.ValueNumber = hn.MinNum ' o el valor predeterminado deseado
                        End If
                End Select
            End If
        Next
    End Sub


    ' vaciar controles
    Public Sub VaciarControles(nombresControles() As String, parentForm As Form)
        For Each nombreControl As String In nombresControles ' iterar el diccionario nombre por nombre
            nombreControl = nombreControl.Trim() ' eliminar espacios en blanco al inicio y al final del nombre del control, para evitar errores en la búsqueda
            ' intentar encontrar el control en el formulario dado
            Dim control As Control = parentForm.Controls.Find(nombreControl, True).FirstOrDefault()
            ' vaciar el control
            If control IsNot Nothing Then ' si el control se encontró
                ' TextBox
                If TypeOf control Is TextBox Then ' si el control es del tipo TextBox
                    CType(control, TextBox).Text = String.Empty ' convertir el control a tipo TextBox y asignarle una cadena vacía
                ElseIf TypeOf control Is HopeTextBox Then
                    CType(control, HopeTextBox).Text = String.Empty
                ElseIf TypeOf control Is HopeTextBoxCustom Then
                    CType(control, HopeTextBoxCustom).Text = String.Empty
                    ' RichTextBox
                ElseIf TypeOf control Is HopeRichTextBox Then
                    CType(control, HopeRichTextBox).Text = String.Empty
                ElseIf TypeOf control Is HopeRichTextBoxCustom Then
                    CType(control, HopeRichTextBoxCustom).Text = String.Empty
                    ' NumericUpDown
                ElseIf TypeOf control Is HopeNumeric Then
                    CType(control, HopeNumeric).ValueNumber = 0
                ElseIf TypeOf control Is HopeNumericCustom Then
                    CType(control, HopeNumericCustom).ValueNumber = 0
                    ' ComboBox
                ElseIf TypeOf control Is ComboBox Then
                    CType(control, ComboBox).SelectedIndex = -1
                ElseIf TypeOf control Is HopeComboBox Then
                    CType(control, HopeComboBox).SelectedIndex = -1
                ElseIf TypeOf control Is AloneComboBox Then
                    CType(control, AloneComboBox).SelectedIndex = -1
                ElseIf TypeOf control Is AloneComboBoxCustom Then
                    CType(control, AloneComboBoxCustom).SelectedIndex = -1
                    ' DateTimePicker
                ElseIf TypeOf control Is DateTimePicker Then
                    CType(control, DateTimePicker).Value = DateTime.Now
                ElseIf TypeOf control Is PoisonDateTime Then
                    CType(control, PoisonDateTime).Value = DateTime.Now
                End If
            End If
        Next
    End Sub


    Public Function validarEntradas(controlesDiccionario As Dictionary(Of System.Windows.Forms.Control, String)) As Boolean
        ' iterar par por par (par = key-value)
        For Each kvp As KeyValuePair(Of System.Windows.Forms.Control, String) In controlesDiccionario
            ' guardar el diccionario en variables distintas
            Dim control As System.Windows.Forms.Control = kvp.Key
            Dim nombreLegible As String = kvp.Value
            If control IsNot Nothing Then ' si el control existe
                Select Case True
                    Case TypeOf control Is System.Windows.Forms.TextBox ' si el control es tipo TextBox
                        ' convertir el control a tipo TextBox (para evitar errores) y guardarlo en una variable
                        Dim textBox As System.Windows.Forms.TextBox = DirectCast(control, System.Windows.Forms.TextBox)
                        ' si el control está vacío o si contiene un número (en lugar de texto)
                        If String.IsNullOrWhiteSpace(textBox.Text) OrElse textBox.Text = "-1" Then
                            MessageBox.Show($"El campo {nombreLegible} está vacío o su valor es inválido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                        End If
                    Case TypeOf control Is HopeTextBoxCustom
                        Dim hopeTextBox As HopeTextBoxCustom = DirectCast(control, HopeTextBoxCustom)
                        If String.IsNullOrWhiteSpace(hopeTextBox.Text) OrElse hopeTextBox.Text = "-1" Then
                            MessageBox.Show($"El campo {nombreLegible} está vacío o su valor es inválido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                        End If
                    Case TypeOf control Is HopeRichTextBoxCustom
                        Dim hopeRichTextBox As HopeRichTextBoxCustom = DirectCast(control, HopeRichTextBoxCustom)
                        If String.IsNullOrWhiteSpace(hopeRichTextBox.Text) OrElse hopeRichTextBox.Text = "-1" Then
                            MessageBox.Show($"El campo {nombreLegible} está vacío o su valor es inválido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                        End If
                    Case TypeOf control Is System.Windows.Forms.ComboBox
                        Dim comboBox As System.Windows.Forms.ComboBox = DirectCast(control, System.Windows.Forms.ComboBox)
                        If comboBox.SelectedIndex = -1 Then
                            MessageBox.Show($"El campo {nombreLegible} está vacío o su valor es inválido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                        End If
                    Case TypeOf control Is AloneComboBox
                        Dim aloneComboBox As AloneComboBox = DirectCast(control, AloneComboBox)
                        If aloneComboBox.SelectedIndex = -1 Then
                            MessageBox.Show($"El campo {nombreLegible} está vacío o su valor es inválido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                        End If
                End Select
            End If
        Next

        Return True
    End Function


#Region "Activar y desactivar controles"

    ' botones
    Public Sub ActivarBotones(ParamArray botones() As IconButton) ' permite parametros tipo array, tiene longitud variable (acepta la cantidad de parametros que se ingrese)
        For Each btn As IconButton In botones
            If btn IsNot Nothing Then
                btn.Enabled = True
            End If
        Next
    End Sub
    Public Sub DesactivarBotones(ParamArray botones() As IconButton)
        For Each btn As IconButton In botones
            If btn IsNot Nothing Then
                btn.Enabled = False
            End If
        Next
    End Sub
    ' TextBoxes
    Public Sub ActivarTextBox(ParamArray textBoxes() As Control)
        For Each tb As TextBox In textBoxes
            If tb IsNot Nothing Then
                tb.Enabled = True
            End If
        Next
    End Sub
    Public Sub DesactivarTextBox(ParamArray textBoxes() As Control)
        For Each tb As TextBox In textBoxes
            If tb IsNot Nothing Then
                tb.Enabled = False
            End If
        Next
    End Sub

#End Region


#Region "Mostrar y ocultar controles"

    ' ocultar
    Public Sub OcultarControles(ParamArray controles() As System.Windows.Forms.Control)
        For Each control As System.Windows.Forms.Control In controles
            If control IsNot Nothing Then
                control.Visible = False
            End If
        Next
    End Sub

    ' mostrar
    Public Sub MostrarControles(ParamArray controles() As System.Windows.Forms.Control)
        For Each control As System.Windows.Forms.Control In controles
            If control.Visible = False Then
                control.Visible = True ' mostrar
                control.BringToFront()
            End If
        Next
    End Sub

#End Region


End Module