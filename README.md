# proyecto-etps4-grupo13
Proyecto final Grupo 13, ETPS4

## Instalación

### Requisitos
- SQL Server 2018+
- Visual Studio 2022

### Paquetes utilizados en Desktop:
- Microsoft.Extensions.Configuration (7.0.0)
- Microsoft.Extensions.Hosting (7.0.1)
- ReportViewerCore.WinForms (15.1.17)
- System.Data.SqlClient (4.8.5)

### Paquetes utilizados en Web
- AspNetCore.Reporting (2.1.0)
- AspNetCoreHero.ToastNotification (1.1.0)
- Microsoft.AspNetCore.Identity.UI (6.0.16)
- Microsoft.EntityFrameworkCore.Design (6.0.16)
- Microsoft.Extensions.Identity.Core (6.0.16)
- System.CodeDom (6.0.0)
- System.Data.SqlClient (4.8.5)
- System.Security.Permissions (7.0.0)

### Pasos a seguir
- se debe de tener todo instalado los requisitos de software y haber cambiado la connection string de los archivos appsettings en ambos proyectos
- para crear la base de datos se debe de habilitar la Package Manager Console (Tools > Nuget Package Manager > Package Manager Console)
- en la parte superior de la consola, buscar el dropdown del "default project" y seleccionar "Proyecto.ETPS4.Grupo13.WebApi"
![image](https://github.com/nexthor/proyecto-etps4-grupo13/assets/10407896/7cb1ca76-610f-4173-9002-aee2f0ebf77f)

- en la parte superior de VS, seleccionar el proyecto a ejecutar "Proyecto.ETPS4.Grupo13.WebApi"
![image](https://github.com/nexthor/proyecto-etps4-grupo13/assets/10407896/f779c63f-77f6-4cc6-9e72-e92725539f8d)

- escribir en la consola: "update-database"
- si todo ha ido bien, las migraciones de la base de datos habrán sido ejecutadas correctamente y ya se tendrán varios datos creados por defecto
- ejecutar el proyecto "Desktop"
- probar el proyecto "Web"

Reportes para el proyecto Desktop ya están listos
![Imagen de WhatsApp 2023-05-09 a las 14 12 04](https://github.com/nexthor/proyecto-etps4-grupo13/assets/10407896/0505546c-15a2-4ecc-a999-69af86217755)


Se agregaron los reportes en el ambiente web
![Imagen de WhatsApp 2023-05-09 a las 16 13 30](https://github.com/nexthor/proyecto-etps4-grupo13/assets/10407896/3d23b5fc-92cc-46ee-8f83-8c322c4dba05)

![Imagen de WhatsApp 2023-05-09 a las 16 06 54](https://github.com/nexthor/proyecto-etps4-grupo13/assets/10407896/d27f2384-d536-47c8-8799-e7583c55aee5)
