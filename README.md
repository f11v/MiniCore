## Proyecto ASP.NET MVC: Filtrado por Fechas
Aquí tienes un proyecto práctico en ASP.NET MVC que te guiará en cómo filtrar y calcular datos según un rango de fechas específico. A continuación, te detallo los pasos para crearlo desde cero, además de proporcionarte enlaces útiles y formas de contacto.

# Requisitos
- Visual Studio 2019 o superior
- .NET Core 3.1 o superior
- SQL Server
# Instalación
Clona el repositorio en tu máquina local:
https://github.com/f11v/MiniCore.git

Abre el proyecto en Visual Studio.

Configura la cadena de conexión en appsettings.json para tu base de datos:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=nombre_de_tu_base_de_datos;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```
Restaura las dependencias y construye el proyecto:
```
dotnet restore
dotnet build
```

Aplica las migraciones para configurar la base de datos:
```
dotnet ef database update
```

Ejecuta la aplicación:
```
dotnet run
```

# Uso
Al iniciar la aplicación, se mostrará la lista de tareas filtradas por un rango de fechas predeterminado. Puedes cambiar el rango de fechas utilizando el formulario de filtrado.

# Filtrado por Fechas
En este proyecto ASP.NET MVC, puedes seleccionar fechas de inicio y fin en un formulario y luego hacer clic en "Filtrar" para actualizar la lista de tareas. Además, la aplicación calcula si una tarea está retrasada en relación con la fecha final seleccionada y muestra los días de retraso.

**Estructura del Proyecto:**

Controllers/TareasController.cs: Este controlador maneja la lógica detrás del filtrado de tareas y el cálculo de retrasos.

Models/Tarea.cs: Modelo que representa una tarea, utilizado para estructurar los datos de las tareas en la aplicación.

Views/Tareas/Index.cshtml: Vista principal que muestra la lista de tareas y presenta el formulario para seleccionar las fechas de inicio y fin, así como el botón de "Filtrar".

appsettings.json: Archivo de configuración donde se especifica la cadena de conexión de la base de datos y otras configuraciones importantes para la aplicación.

Este enfoque te permite gestionar y visualizar eficazmente las tareas dentro de un rango de fechas específico, proporcionando una funcionalidad crucial para el seguimiento y la gestión del trabajo en tu aplicación ASP.NET MVC.

# Video Tutorial
En este video se explica lo básico para crear un proyecto MVC .NET desde cero y adicionalmente se muestra cómo filtrar y calcular datos dentro de un rango de fechas.
