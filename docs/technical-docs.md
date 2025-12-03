# Documentación Técnica - Librarium

## 1. Introducción
**Librarium** es un sistema de gestión de inventario para librerías desarrollado en Visual Basic .NET con Windows Forms. El sistema permite administrar libros, clientes, proveedores y ventas, además de proporcionar un dashboard con estadísticas y reportes.

## 2. Casos de Uso
A continuación se presentan los diagramas de casos de uso del sistema.

### Contexto
![Contexto](img/use-case-context.svg)

### Requisitos
![Requisitos](img/use-case-requirements.svg)

## 3. Arquitectura del Sistema
El sistema sigue una arquitectura modular, aunque no estrictamente en capas separadas (como MVC), sí organiza el código en Clases, Módulos y Formularios.

### Componentes Principales
*   **Forms (Interfaz de Usuario)**: Contiene todos los formularios de la aplicación.
*   **Clases (Lógica y Datos)**: Contiene la lógica de negocio y el acceso a datos.
*   **Modules (Utilidades)**: Contiene funciones auxiliares y compartidas.

![Arquitectura Compacta](img/architecture-compact-diagram.svg)

## 4. Descripción de Clases Principales

### 4.1. Database (`Clases/Database.vb`)
Es la clase base para la interacción con la base de datos MySQL. Implementa la interfaz `IDatabase`.
*   **Responsabilidad**: Gestionar la conexión, y las operaciones CRUD (Create, Read, Update, Delete) genéricas.
*   **Métodos Clave**:
    *   `ConectarDatabase()`: Establece la conexión con MySQL.
    *   `InsertarRegistro(...)`: Inserta datos en una tabla especificada usando un `Hashtable`.
    *   `EditarRegistro(...)`: Actualiza un registro existente.
    *   `BorrarRegistro(...)`: Elimina un registro por ID.
    *   `CargarDataSetAdapter(...)`: Llena un DataSet para su uso en DataGridViews.

### 4.2. Dashboard (`Clases/Dashboard.vb`)
Hereda de `Database`. Gestiona la lógica de negocio para la pantalla principal de estadísticas.
*   **Responsabilidad**: Calcular y proveer datos estadísticos en tiempo real.
*   **Funcionalidades**:
    *   Cálculo de totales (clientes, libros, ventas, ingresos).
    *   Análisis de libros más vendidos.
    *   Generación de datos para gráficos de ventas e ingresos por fecha (agrupados por días, semanas, meses o años según el rango seleccionado).

### 4.3. Login (`Clases/Login.vb`)
Hereda de `Database`. Maneja la autenticación de usuarios.
*   **Seguridad**: Utiliza hash SHA-256 para verificar las contraseñas. Las contraseñas no se guardan en texto plano.
*   **Método `Login`**: Verifica credenciales y gestiona la apertura del formulario principal.

### 4.4. Módulo Controles (`Modules/Controles.vb`)
Módulo de utilidades estáticas para la manipulación de la interfaz gráfica.
*   **Funciones**:
    *   `CargarControles`: Mapea datos de una fila de DataGridView a los controles del formulario (TextBox, ComboBox, etc.).
    *   `VaciarControles`: Limpia los campos de un formulario.
    *   `validarEntradas`: Verifica que los campos obligatorios no estén vacíos.
    *   `ActivarBotones` / `DesactivarBotones`: Gestión del estado de los botones.

## 5. Base de Datos
El sistema utiliza **MySQL**. El script de creación se encuentra en `database/libreria.sql`.
*   **Tablas principales**: `libros`, `clientes`, `proveedores`, `ventas`, `login`.

![Diagrama Base de Datos](img/database-diagram.svg)

## 6. Requisitos del Sistema
*   **Lenguaje**: Visual Basic .NET
*   **Framework**: .NET Framework (versión compatible con WinForms)
*   **Base de Datos**: MySQL Server
*   **Librerías Externas**:
    *   `MySql.Data`: Conector de MySQL.
    *   `ReaLTaiizor` / `HopeCustom`: Controles de UI personalizados.
    *   `FontAwesome.Sharp`: Iconos.
    *   `ClosedXML`: Exportación a Excel.

## 7. Diagrama de Clases
El siguiente diagrama ilustra la relación entre las clases principales del sistema:

![Diagrama de Clases Completo](img/architecture-diagram.svg)
