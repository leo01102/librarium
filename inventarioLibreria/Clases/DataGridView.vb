' Backend

Imports ClosedXML.Excel

Public Class DataGridView
    Implements IDataGridView


    ' exportar como XLSX (Excel)
    Public Sub ExportarDataGridViewXLSX(dgv As System.Windows.Forms.DataGridView) Implements IDataGridView.ExportarDataGridViewXLSX
        Try
            ' archivo
            Dim libroExcel As New XLWorkbook() ' crear nuevo libro de Excel
            Dim hojaExcel As IXLWorksheet = libroExcel.Worksheets.Add("Datos") ' agregarle al libro una hoja llamada "Datos"
            ' columnas
            For Each columna As DataGridViewColumn In dgv.Columns ' iterar columna a columna
                ' guardar encabezados de columnas del DataGridView en la primera fila del archivo Excel
                hojaExcel.Cell(1, columna.Index + 1).Value = columna.HeaderText ' en cada iteracion la fila es 1 y la columna incrementa en 1
            Next
            ' guardar datos de cada fila (del DataGridView) en el archivo Excel
            ' nota: los indices de filas y columnas en Excel comienzan en 1, pero los indices de filas y columnas en DataGridView comienzan en 0
            For filaIndice As Integer = 0 To dgv.Rows.Count - 1 ' iterar por fila, desde el primer índice (fila 0) hasta el ultimo indice (fila dgv.Rows.Count - 1)
                For columnaIndice As Integer = 0 To dgv.Columns.Count - 1 ' iterar por columna, desde el primer indice (columna 0) hasta la ultima (columna dgv.Columns.Count - 1)
                    ' obtener valor de la celda del DataGridView
                    Dim valorCelda As Object = dgv.Rows(filaIndice).Cells(columnaIndice).Value
                    ' convertir el valor a un tipo compatible con Excel y asignar como valor numérico
                    If valorCelda IsNot Nothing Then
                        If IsNumeric(valorCelda) Then ' si el valor de la celda es numerico
                            ' convertir el valor numérico a tipo Double y asignar a la celda de Excel
                            hojaExcel.Cell(filaIndice + 2, columnaIndice + 1).Value = Convert.ToDouble(valorCelda)
                            ' hojaExcel.Cell() permite acceder a una celda, indicando su fila y columna
                            ' filaIndice + 2 seleccionamos la fila dos filas despues de la fila actual (filaIndice) porque la fila 1 ya tiene encabezados. ejemplo: filaIndice = 0 (primera fila del DataGridView) debería mapearse a la fila 2 en Excel, por eso se usa filaIndice + 2; filaIndice = 1 (segunda fila del DataGridView) debería mapearse a la fila 3 en Excel, y así sucesivamente
                            ' columnaIndice + 1 seleccionamos la columna una columna despues de la actual (colimnaIndice) para ir incrementando la columna en cada iteracion
                        ElseIf TypeOf valorCelda Is Date Then
                            ' asignar el valor de tipo Date a la celda de Excel
                            hojaExcel.Cell(filaIndice + 2, columnaIndice + 1).Value = DirectCast(valorCelda, Date)
                        Else
                            ' convertir el valor a cadena de texto y asignar a la celda de Excel
                            hojaExcel.Cell(filaIndice + 2, columnaIndice + 1).Value = valorCelda.ToString()
                        End If
                    End If
                Next
            Next
            ' mostrar el cuadro de diálogo para guardar el archivo Excel
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx" ' filtro para mostrar solo archivos .xlsx
            saveFileDialog.FilterIndex = 1
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                libroExcel.SaveAs(saveFileDialog.FileName) ' guardar libro en la ruta seleccionada por el usuario
                MsgBox("Datos exportados exitosamente como archivo Excel.")
            End If
        Catch ex As Exception
            MsgBox("Error al exportar datos a Excel: " & ex.Message)
        End Try
    End Sub


    ' exportar como CSV
    Public Sub ExportarDataGridViewCSV(dgv As System.Windows.Forms.DataGridView) Implements IDataGridView.ExportarDataGridViewCSV
        Try
            ' crear nueva instancia 'sb' de la clase StringBuilder (para construir cadenas como contenido del archivo CSV)
            Dim sb As New System.Text.StringBuilder()
            ' guardar encabezados de columna de la BD en la primera linea del archivo CSV
            Dim headers = dgv.Columns.Cast(Of DataGridViewColumn)() ' se guarda en headers el valor (que fue convertido a tipo DataGridViewColumn con Cast) de cada columns de DataGridView
            sb.AppendLine( ' AppendLine agrega una nueva linea a sb
                String.Join( ' String.Join concatena en una cadena los elementos devueltos por headers.Select(), cada elemento separado por una ","
                    ",",
                    headers.Select( ' seleccionar headers para aplicarle el siguiente código:
                        Function(columna) """" & columna.HeaderText & """" ' función lambda (función anónima sin nombre) que convierte cada columna en una cadena donde cada header (de cada columna) está rodeado de comillas "
                    )
                )
            )
            ' iteración en cada fila de DataGridView
            For Each fila As DataGridViewRow In dgv.Rows ' recorrer cada fila de DataGridViewRow (DataGridViewRow.Rows devuelve el valor de cada fila)
                ' guardar los valores de las celdas de la fila actual en una linea del archivo CSV
                Dim celdas = fila.Cells.Cast(Of DataGridViewCell)() ' en celdas guardar la celda de la fila actual fila.Cells (esta fila fue convertida a tipo DataGridViewCell con Cast)
                sb.AppendLine(String.Join(",", celdas.Select(Function(cell) """" & cell.Value & """"))) ' hace lo mismo que la línea 61, pero aquí, con la función lambda, cada celda se convierte en una cadena rodeada de comillas
            Next
            ' cuadro de dialogo para guardar archivo CSV
            Dim dialogoExploradorArchivos As New SaveFileDialog()
            dialogoExploradorArchivos.Filter = "CSV files (*.csv)|*.csv" ' este texto es el aparece al lado de "Tipo: " (en la interfaz del explorador de archivos de Windows) al hacer click en el botón de exportar
            dialogoExploradorArchivos.FilterIndex = 1 ' indicar que el filtro seleccionado por default sea dialogoExploradorArchivos
            ' mostrar cuadro de diálogo y continuar si el usuario elige guardar
            If dialogoExploradorArchivos.ShowDialog() = DialogResult.OK Then
                System.IO.File.WriteAllText(dialogoExploradorArchivos.FileName, sb.ToString())
                MsgBox("Datos exportados exitosamente")
            End If
        Catch ex As Exception
            MsgBox("Error al exportar datos! Descripcion del error: " & ex.ToString)
        End Try
    End Sub


    ' exportar como PDF
    'Public Sub exportarDataGridViewPDF(dgv As DataGridView)
    '    Try
    '        ' Crear un documento PDF
    '        Dim document As New PdfDocument()
    '        Dim page As PdfPage = document.AddPage()
    '        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
    '        Dim font As XFont = New XFont("Arial", 10)
    '        ' Posiciones iniciales para escribir en la página
    '        Dim xPosition As Double = 10
    '        Dim yPosition As Double = 10
    '        Dim rowHeight As Double = font.Height + 5
    '        ' Títulos de las columnas
    '        For Each column As DataGridViewColumn In dgv.Columns
    '            gfx.DrawString(column.HeaderText, font, XBrushes.Black, New XRect(xPosition, yPosition, column.Width, rowHeight), XStringFormats.TopLeft)
    '            xPosition += column.Width
    '        Next
    '        yPosition += rowHeight
    '        ' Contenido de las celdas
    '        For Each row As DataGridViewRow In dgv.Rows
    '            xPosition = 10
    '            For Each cell As DataGridViewCell In row.Cells
    '                gfx.DrawString(cell.Value?.ToString(), font, XBrushes.Black, New XRect(xPosition, yPosition, cell.OwningColumn.Width, rowHeight), XStringFormats.TopLeft)
    '                xPosition += cell.OwningColumn.Width
    '            Next
    '            yPosition += rowHeight
    '        Next
    '        ' Guardar el documento PDF
    '        Dim saveFileDialog As New SaveFileDialog()
    '        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
    '        saveFileDialog.FilterIndex = 1
    '        If saveFileDialog.ShowDialog() = DialogResult.OK Then
    '            document.Save(saveFileDialog.FileName)
    '            MsgBox("Datos exportados exitosamente como archivo PDF.")
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error al exportar datos a PDF: " & ex.Message)
    '    End Try
    'End Sub

End Class