# Librarium

Este proyecto es un sistema de inventario para gestionar librerías, desarrollado como Trabajo Final para la cátedra de teoría de **Programación II**, a cargo del Profesor Titular Mg. Ms. Lic. Marcelo Fabio Roldán y el Ayudante de Primera Gustavo Saavedra, correspondiente a la carrera Ingeniería en Sistemas de Información en la **Universidad Nacional de La Rioja**.

El sistema permite gestionar el stock de libros, ventas, clientes, proveedores, generar reportes, realizar búsquedas, y más.

## Instalación

Para instalar este sistema en tu computadora, sigue los siguientes pasos:

1. Descarga <a href="https://www.apachefriends.org/es/download.html">XAMPP</a>.

2. Configurar la base de datos:
   - Descarga el archivo `.sql` en <a href="https://github.com/leo01102/librarium/releases/tag/v1.0.0">GitHub releases</a>.
   - Abre el **Panel de Control de XAMPP** y asegúrate de que **Apache** y **MySQL** están corriendo.
   - Accede a **phpMyAdmin** haciendo click en el botón Admin que está al lado del botón Start de MySQL, o a través de tu navegador (normalmente en `http://localhost/phpmyadmin`).
   - Crea una nueva base de datos con el nombre `libreria.sql`.
   - Importa el archivo `.sql` descargado dentro de esta base de datos usando la opción "Importar" en phpMyAdmin.

3. Descarga e instala el ejecutable `Inventario.de.Libreria.exe` en <a href="https://github.com/leo01102/librarium/releases/tag/v1.0.0">GitHub releases</a>.

Si quieres hacerlo desde Visual Studio, sigue estos pasos:

1. Clona el repositorio:

   ```sh
   git clone https://github.com/leo01102/librarium.git
    ```
    
2. Asegúrate de tener instalados los siguientes paquetes NuGet:
    - `MySql.Data`
    - `ClosedXML`
    - `ReaLTaiizor`
    - `HopeCustom` (incluido en el repositorio en la carpeta `HopeCustom`)
    - `FontAwesome.Sharp`
3. Configura la base de datos MySQL utilizando el script de base de datos proporcionado en el directorio `/database/`.
4. Compila y ejecuta el proyecto en Visual Studio.

## Uso del sistema

Una vez instalado, sigue estos pasos para navegar por la aplicación:
1. Abre la aplicación con el **acceso directo** creado en el escritorio.
1. **Inicia sesión** con la cuenta por defecto que tiene por usuario y contraseña "admin". Una vez iniciada la sesión, puedes crear uno nuevo y borrar el usuario por defecto. Las contraseñas están encriptadas usando el algoritmo SHA-256.
2. Dentro del **Dashboard**, visualiza datos estadísticos en tiempo real sobre el stock, ventas, clientes y libros.
3. **Gestión de registros**
    - Agrega, edita y elimina registros de libros, clientes, ventas y proveedores.
    - Exporta registros a formatos XLSX o CSV.
4. Dentro del Dashboard, genera **reportes detallados** de stock, ventas y clientes.

## Características clave

- **Dashboard interactivo**: Visualización de estadísticas en tiempo real.
- **Gestión completa de inventario**: Inserta, edita y elimina registros de libros, clientes y ventas.
- **Exportación de datos**: Exporta información en formatos XLSX y CSV.
- **Seguridad**: Autenticación de usuarios y encriptación de contraseñas con SHA-256.
- **Escalabilidad**: Diseñado para manejar grandes volúmenes de datos sin comprometer el rendimiento.
- **Optimización**: Arquitectura modular implementada con principios de POO.

## Arquitectura del sistema

El sistema está diseñado usando una arquitectura modular basada en POO. Para ver los detalles técnicos, descripción de clases y diagrama de arquitectura, consulta la [Documentación Técnica](docs/technical-docs.md).

## Licencia

Este proyecto está bajo la Licencia MIT.

## Créditos

Desarrollado por:
- **Leonardo Rearte Caliva**
- **Joaquín Galvan Mora**
