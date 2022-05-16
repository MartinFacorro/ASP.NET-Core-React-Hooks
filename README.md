# ASP.NET-Core-React-Hooks #

Backend ASP.NET Core y Entity Framework.
Reportes en PDF.
FrontEnd trabajaremos con React Hooks, Redux y Material Design.

## Lista de elementos con los que se trabajara ##

* Visual Code y extensiones para .NET Core y C#
* SQL Server como motor de base de datos.
* Entity Framework Core para persistencia y creacion de transacciones en SQL Server
* Crear Procedimientos Almacenados en SQL Server y consumirlos en ASP.NET Core.
* Generar Reportes en PDF usando Entity Framework Core y ASP.NET Core
* Paginacion con ASP.NET Core y SQL Server
* Arquitectura del proyecto en multiples capas.
* Crear, Actualizar, Consultar data usando un Aplicacion desarrollada en capas.
* Crear procedimientos de seguridad con Core Identity
* Migracion de entidades desde Entity Framework hacia SQL Server
* Crear Login con Core Identity y React Hooks
* Crear Registro de nuevos usuarios con React Hooks
* JWT para manejar Tokens de seguridad.
* Documentar Web Services EndPoints con Swagger
* Creacion de proyectos SPA con React Hooks
* Implementar toda la estructura de  Redux  en tu App
* Implementar manejo de Consumers y Providers con React Context API
* React Hooks consumiendo Web Services EndPoints desde ASP.NET Core
* Subir todo tu proyecto ASP.Net Core y React Hooks a Microsoft Azure

### Visual Code y extensiones para .NET Core y C# ###

* **markdownlint** <https://marketplace.visualstudio.com/items?itemName=DavidAnson.vscode-markdownlint>
* **Auto Close Tag** <https://marketplace.visualstudio.com/items?itemName=formulahendry.auto-close-tag>
* **Auto Rename Tag** <https://marketplace.visualstudio.com/items?itemName=formulahendry.auto-rename-tag>
* **C#** <https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp>
* **C# Extensions** <https://marketplace.visualstudio.com/items?itemName=tdallau-csharpextensions.csharpextensions>
* **NuGet Package Manager** <https://marketplace.visualstudio.com/items?itemName=jmrog.vscode-nuget-package-manager>
* **Prettier - Code formatter** <https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode>
* **Material Icon them** <https://marketplace.visualstudio.com/items?itemName=PKief.material-icon-theme>
* **Dracula Official Theme** <https://marketplace.visualstudio.com/items?itemName=dracula-theme.theme-dracula>

### Entity Framework Core para persistencia y creacion de transacciones en SQL Server

Entity Framework permite traducir las sentencias SQL (modelo relacional) para llevarlo a un modelo de objetos.

Para que Curso (Curso.cs) pueda convertirse en entidad, debe estar dentro de un DbSet(representa una tabla).

DbContext representa a la base de datos con la que vamos a trabajar.

protegido : Solamente las clases que hereden estos metodos y propiedades tendran acceso.

Override:sobre escribiendo un metodo que previamente fue declarado por una clase padre(DbContext para este caso).

OnConfiguring crea la instancia hacia el servidor SQL SERVER.