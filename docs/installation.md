# Instalación y Configuración

## Requisitos Previos
*   Visual Studio 2022 (o versión compatible con .NET Framework 4.8 / .NET 8).
*   MySQL Server.
*   Git.

## Pasos de Instalación

1.  **Clonar el repositorio**:
    ```bash
    git clone https://github.com/leo01102/librarium.git
    ```
2.  **Restaurar paquetes NuGet**:
    *   Abre la solución `Librarium.sln` en Visual Studio.
    *   Haz clic derecho en la solución en el Explorador de Soluciones -> "Restaurar paquetes NuGet".
    *   Esto instalará las dependencias necesarias:
        *   `MySql.Data`
        *   `ClosedXML`
        *   `ReaLTaiizor`
        *   `HopeCustom` (incluido en el repositorio en la carpeta `HopeCustom`)
        *   `FontAwesome.Sharp`

3.  **Configurar la Base de Datos**:
    *   Localiza el script de base de datos en `database/libreria.sql`.
    *   Ejecuta este script en tu servidor MySQL para crear la base de datos `libreria` y las tablas necesarias.
    *   **Importante**: Verifica la cadena de conexión en `src/Clases/Database.vb` (o donde esté definida) para asegurarte de que coincida con tus credenciales de MySQL (usuario, contraseña, puerto).

4.  **Ejecutar la Aplicación**:
    *   Compila y ejecuta el proyecto en Visual Studio (F5).
