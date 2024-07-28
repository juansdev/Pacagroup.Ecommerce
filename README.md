<p align="center">
  <img src="https://simpleicons.org/icons/dotnet.svg" style="filter:invert(1);" width="100" alt="project-logo">
</p>
<p align="center">
    <h1 align="center">PACAGROUP ECOMMERCE</h1>
</p>
<p align="center">
    <em>¡Bienvenido a Pacagroup Ecommerce! Pacagroup Ecommerce permite un comercio electrónico eficiente y mantenible con el uso de DTOs (Objetos de Transferencia de Datos) claros y el despliegue optimizado de contenedores. ¡El poder de .NET 7.0 al alcance de tus manos! Construir, Innovar y Tener Éxito — Juntos en el Mercado Digital Mundial.</em>
</p>
<p align="center">
	<img src="https://img.shields.io/github/license/juansdev/Pacagroup.Ecommerce?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/juansdev/Pacagroup.Ecommerce?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/juansdev/Pacagroup.Ecommerce?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/juansdev/Pacagroup.Ecommerce?style=default&color=0080ff" alt="repo-language-count">
<p>
<p align="center">
	<!-- default option, no dependency badges. -->
</p>

<br><!-- TABLE OF CONTENTS -->
<details>
  <summary>Tabla de Contenidos</summary><br>

- [ Visión General](#-visión-general)
- [ Características](#-características)
- [ Estructura del Repositorio](#-estructura-del-repositorio)
- [ Módulos](#-módulos)
- [ Primeros Pasos](#-primeros-pasos)
    - [ Instalación](#-instalación)
    - [ Uso](#-uso)
</details>
<hr>

##  Visión General

El proyecto `Pacagroup.Ecommerce` es una solución de software de comercio electrónico de código abierto, diseñada para crear experiencias de compra en línea robustas y escalables. Su enfoque principal es proporcionar una plataforma versátil y fácil de usar, respaldada por una estructura bien arquitecturada. El código abarca varias capas de la arquitectura de la aplicación, como se muestra en archivos como `Pacagroup.Ecommerce.sln`, que alberga Objetos de Transferencia de Datos (DTOs) para una comunicación eficiente entre diferentes componentes. DTOs clave como `CategoryDto`, `CustomerDto`, `DiscountDto` y `UserDto` están meticulosamente definidos, garantizando un intercambio de datos fluido entre las capas de presentación, aplicación, infraestructura y posiblemente otras capas adicionales.

El proyecto aprovecha las tecnologías de contenedorización al construir y desplegar imágenes Docker a través del `Dockerfile`. Este enfoque garantiza entornos consistentes, minimizando problemas potenciales de dependencias en los entornos de desarrollo y producción. Con estas funcionalidades clave, el proyecto `Pacagroup.Ecommerce` ofrece una valiosa propuesta al promover la legibilidad del código, la mantenibilidad, la extensibilidad y la escalabilidad, permitiendo así una rápida adaptación a los requisitos de comercio electrónico en constante evolución.

---

##  Características

|    | Característica    | Descripción |
|----|-------------------|---------------------------------------------------------------|
| ⚙️  | Arquitectura     | ASP.NET Core con integración de Docker para compatibilidad multiplataforma, diseño orientado al dominio y separación de preocupaciones entre capas. Utiliza Objetos de Transferencia de Datos (DTOs) para un intercambio de datos eficiente. |
| 🔩 | Calidad del Código| Código en C# limpio, mantenible y bien estructurado, que sigue los estándares y directrices de codificación de Microsoft .NET. El uso de los principios SOLID promueve un diseño robusto y extensible. |
| 📄 | Documentación     | Mensajes de confirmación informativos, documentación detallada dentro del propio código fuente y archivos README.md específicos para cada submódulo, proporcionando instrucciones claras sobre cómo construir, integrar y usar cada componente de manera efectiva. |
| 🔌 | Integraciones     | Las dependencias externas incluyen ASP.NET Core para construir aplicaciones web y Docker para contenerizar la solución, mejorando la consistencia del despliegue. |
| 🧩 | Modularidad       | La base de código es altamente modular con proyectos separados para capas de aplicación, objetos de transferencia de datos y entidades de dominio. Cada módulo tiene su propia responsabilidad, promoviendo la mantenibilidad y escalabilidad. |
| ⚡️ | Rendimiento       | Bien optimizado para una ejecución eficiente utilizando procesamiento asíncrono, gestión adecuada de la memoria y técnicas de caché. La prueba de carga no está disponible en la información proporcionada. |
| 🛡️ | Seguridad         | Emplea comunicación segura entre componentes utilizando HTTPS y utiliza las características de seguridad integradas en .NET Core, como la inyección de dependencias para el control de acceso a datos y la protección. |
| 📦 | Dependencias      | Las bibliotecas externas incluyen ASP.NET Core, Docker, SDK de .NET 7.0 y varias bibliotecas comunes de .NET como System, Microsoft.EntityFrameworkCore, Json.NET, entre otras para funciones comunes. |

---

##  Estructura del Repositorio

```sh
└── Pacagroup.Ecommerce/
    ├── Dockerfile
    ├── Pacagroup.Ecommerce.Application.DTO
    │   ├── CategoryDto.cs
    │   ├── CustomerDto.cs
    │   ├── DiscountDto.cs
    │   ├── Enums
    │   ├── Pacagroup.Ecommerce.Application.DTO.csproj
    │   └── UserDto.cs
    ├── Pacagroup.Ecommerce.Application.Interface
    │   ├── Infrastructure
    │   ├── Pacagroup.Ecommerce.Application.Interface.csproj
    │   ├── Persistence
    │   ├── Presentation
    │   └── UseCases
    ├── Pacagroup.Ecommerce.Application.Main
    │   ├── Categories
    │   ├── Common
    │   ├── ConfigureServices.cs
    │   ├── Customers
    │   ├── Discounts
    │   ├── Pacagroup.Ecommerce.Application.UseCases.csproj
    │   └── Users
    ├── Pacagroup.Ecommerce.Application.Test
    │   ├── CustomWebApplicationFactory.cs
    │   ├── GlobalUsings.cs
    │   ├── Pacagroup.Ecommerce.Application.Test.csproj
    │   ├── UsersApplicationTest.cs
    │   └── appsettings.json
    ├── Pacagroup.Ecommerce.CrossSectional.Common
    │   ├── BaseError.cs
    │   ├── Pacagroup.Ecommerce.CrossSectional.Common.csproj
    │   ├── Response.cs
    │   ├── ResponseGeneric.cs
    │   └── ResponsePagination.cs
    ├── Pacagroup.Ecommerce.CrossSectional.Mapper
    │   ├── MapppingsProfile.cs
    │   └── Pacagroup.Ecommerce.CrossSectional.Mapper.csproj
    ├── Pacagroup.Ecommerce.Domain.Entity
    │   ├── Common
    │   ├── Entities
    │   ├── Enums
    │   ├── Events
    │   └── Pacagroup.Ecommerce.Domain.csproj
    ├── Pacagroup.Ecommerce.Infrastructure
    │   ├── ConfigureServices.cs
    │   ├── EventBus
    │   └── Pacagroup.Ecommerce.Infrastructure.csproj
    ├── Pacagroup.Ecommerce.Persistence
    │   ├── Configurations
    │   ├── ConfigureServices.cs
    │   ├── Contexts
    │   ├── Interceptor
    │   ├── Migrations
    │   ├── Mocks
    │   ├── Pacagroup.Ecommerce.Persistence.csproj
    │   └── Repositories
    ├── Pacagroup.Ecommerce.Services.WebApi
    │   ├── Controllers
    │   ├── Helpers
    │   ├── Modules
    │   ├── Pacagroup.Ecommerce.Services.WebApi.csproj
    │   ├── Program.cs
    │   ├── Properties
    │   ├── Services
    │   └── appsettings.Development.json
    └── Pacagroup.Ecommerce.sln
```

---

##  Módulos

<details closed><summary>.</summary>

| Archivo                                                                                                      | Resumen                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ---                                                                                                          | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [Pacagroup.Ecommerce.sln](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.sln) | Este archivo de código, ubicado en el directorio `Pacagroup.Ecommerce/Pacagroup.Ecommerce.Application.DTO`, es parte de una aplicación de comercio electrónico más grande en el repositorio principal titulado `Pacagroup.Ecommerce`. El propósito principal de este archivo de código es definir Objetos de Transferencia de Datos (DTOs) utilizados para la comunicación entre diferentes capas y componentes dentro de la arquitectura de la aplicación. Los DTOs clave definidos aquí incluyen `CategoryDto`, `CustomerDto`, `DiscountDto` y `UserDto`, que permiten un intercambio de datos limpio y eficiente entre las capas de presentación, aplicación, infraestructura y posiblemente otras capas de la aplicación. Estos DTOs sirven como objetos simples y ligeros que solo contienen propiedades relevantes para el transporte de datos. Al utilizar estos DTOs bien definidos, la aplicación de comercio electrónico adopta una arquitectura clara y mantenible. Esto facilita las interacciones eficientes entre componentes mientras los desacopla de detalles de implementación específicos de sus respectivas capas, promoviendo la legibilidad del código y mejorando la extensibilidad de la solución a medida que evolucionan los requisitos. |
| [Dockerfile](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Dockerfile)                          | Construye y despliega imágenes Docker para la aplicación Web API de Pacagroup Ecommerce. Esta acción encapsula las dependencias de.NET 7.0 del proyecto dentro de un contenedor, optimizando la consistencia del entorno a través de diversos escenarios de implementación.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity</summary>

| Archivo                                                                                                                                                                   | Resumen                                                                                                                                                                                                                                                                                                                                                                           |
| ---                                                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                             |
| [Pacagroup.Ecommerce.Domain.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Pacagroup.Ecommerce.Domain.csproj) | La arquitectura impulsada por el dominio de la solución de comercio electrónico de Pacagroup se centra en definir entidades comerciales principales. **Proporciona un plano para clases específicas del dominio y sus relaciones dentro del contexto de la aplicación para la plataforma Net8.0. **Implementa características esenciales que permiten una programación explícita y orientada a modelos para facilitar la construcción de una base de código robusta y mantenible. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity.Entities</summary>

| Archivo                                                                                                                              | Resumen                                                                                                                                                                                                                                                                                                                             |
| ---                                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                 |
| [Customer.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Entities/Customer.cs) | En la arquitectura de Pacagroup Ecommerce, esta clase `Customer` dentro de la carpeta Entities es responsable de definir la estructura de una entidad de cliente. Incluye detalles esenciales como CompanyName, ContactName, Address y ContactTitle, permitiendo un almacenamiento y recuperación eficientes de la información del cliente en el sistema. |
| [Discount.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Entities/Discount.cs) | Administra entidades de `Discount` para la aplicación de comercio electrónico. Cada descuento posee un Nombre, Descripción, valor porcentual y Estado (activo/inactivo). Forma parte de la capa de dominio, enfocándose en la lógica comercial principal, aprovechando la clase BaseAuditableEntity del módulo Common para características de auditabilidad. |
| [Category.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Entities/Category.cs) | El archivo `Category.cs` dentro del repositorio `Pacagroup.Ecommerce.Domain.Entity` define la entidad de categoría para la aplicación de comercio electrónico, conteniendo propiedades como CategoryName y Description. Esta estructura de datos es esencial para organizar grupos de productos en el sistema de la tienda. |
| [User.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Entities/User.cs)         | Administra Usuarios**-Esta clase de entidad de dominio .NET encapsula estructuras de datos de usuario, conteniendo información esencial como FirstName, LastName y Username para la autenticación dentro de la aplicación de comercio electrónico. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity.Enums</summary>

| Archivo                                                                                                                                        | Resumen                                                                                                                                                              |
| ---                                                                                                                                           | ---                                                                                                                                                                  |
| [DiscountStatus.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Enums/DiscountStatus.cs) | Este enum define dos estados (Inactivo, Activo) para la función de descuento de la aplicación de comercio electrónico, facilitando una gestión flexible y optimizada dentro del dominio. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity.Events</summary>

| Archivo                                                                                                                                                    | Resumen                                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                                                                             |
| [DiscountDeletedEvent.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Events/DiscountDeletedEvent.cs) | La clase `DiscountDeletedEvent`, ubicada en la carpeta de eventos de la entidad de dominio de Pacagroup.Ecommerce, sirve como una señal que indica que un descuento ha sido eliminado en el sistema. Este evento es instrumental para mantener la consistencia de la aplicación al permitir que otros módulos respondan adecuadamente al detectar tal ocurrencia. |
| [DiscountCreatedEvent.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Events/DiscountCreatedEvent.cs) | Genera eventos para la creación de descuentos dentro del modelo de dominio de comercio electrónico, proporcionando una estructura de datos para DiscountName, Description, Percentage y Status para facilitar flujos de trabajo optimizados en la aplicación.                                                                                                                                       |
| [DiscountUpdatedEvent.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Events/DiscountUpdatedEvent.cs) | Se activa con una actualización de descuento en el dominio de la aplicación de comercio electrónico de Pacagroup. La clase `DiscountUpdatedEvent` define un evento esencial para monitorear cambios, facilitando operaciones posteriores como notificaciones y análisis dentro de la arquitectura del sistema.                                                                              |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity.Common</summary>

| Archivo                                                                                                                                                  | Resumen                                                                                                                                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [BaseAuditableEntity.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Common/BaseAuditableEntity.cs) | En este archivo, se define una clase base de entidad auditable, mejorando las capacidades de seguimiento dentro del dominio de comercio electrónico de Pacagroup. La clase, llamada `BaseAuditableEntity`, hereda de `BaseEntity` y almacena información sobre las fechas de creación y modificación, así como los usuarios asociados. Esta característica fomenta la trazabilidad y transparencia en toda la aplicación, ayudando en los procesos de auditoría y depuración. |
| [BaseEntity.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Common/BaseEntity.cs)                   | Abstrae el campo esencial `Id` para todas las entidades en el modelo de dominio de Pacagroup Ecommerce, asegurando un seguimiento de datos consistente en todo el sistema.                                                                                                                                                                                                                                                                                       |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface</summary>

| Archivo                                                                                                                                                                                                       | Resumen                                                                                                                                                                                                                                                       |
| ---                                                                                                                                                                                                        | ---                                                                                                                                                                                                                                                           |
| [Pacagroup.Ecommerce.Application.Interface.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Pacagroup.Ecommerce.Application.Interface.csproj) | Compila interfaces de aplicación para la plataforma de comercio electrónico de Pacagroup, asegurando una comunicación fluida entre DTOs, funcionalidades compartidas y entidades de dominio dentro de la solución en general. Se alinea con el estándar .NET 8 para aprovechar las características avanzadas del framework. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface.Persistence</summary>

| Archivo                                                                                                                                                                   | Resumen                                                                                                                                                                                                                                                                                                                                                                           |
| ---                                                                                                                                                                    | ---                                                                                                                                                                                                                                                                                                                                                                               |
| [ICustomersRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/ICustomersRepository.cs)   | ICustomersRepository.cs actúa como una interfaz que abstrae el acceso a los datos del cliente dentro de la aplicación de comercio electrónico de Pacagroup, permitiendo una interacción consistente y eficiente entre las capas de la aplicación utilizando la entidad de dominio del Cliente.                                                                                                                                      |
| [ICategoriesRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/ICategoriesRepository.cs) | Este archivo **define** una interfaz `ICategoriesRepository` dentro de la capa de aplicación del repositorio, parte de la arquitectura de comercio electrónico en general. Su responsabilidad principal radica en manejar consultas para **recuperar todas las categorías** dentro del sistema de comercio electrónico, permitiendo una recuperación y accesibilidad de datos eficiente desde varias capas de la aplicación.                         |
| [IGenericRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/IGenericRepository.cs)       | El archivo proporcionado, `IGenericRepository.cs`, dentro de la carpeta `Persistence` de `Pacagroup.Ecommerce.Application.Interface` establece una interfaz que encapsula operaciones CRUD (Insertar, Actualizar, Eliminar) y funciones de recuperación (Obtener, Contar) para varias entidades de dominio en toda la aplicación de comercio electrónico, permitiendo desacoplar la aplicación de su base de datos. |
| [IDiscountRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/IDiscountRepository.cs)     | Gestiona las operaciones de datos para las entidades de descuento dentro de la capa de interfaz de la aplicación, proporcionando métodos para obtener registros de descuento individuales y múltiples. La `IDiscountRepository` abstrae las preocupaciones de persistencia, asegurando una interacción adecuada con la base de datos para este dominio específico.                                                                                      |
| [IUsersRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/IUsersRepository.cs)           | La interfaz de código proporcionada (`IUsersRepository`) dentro de la capa de aplicación define responsabilidades para manejar la autenticación de usuarios. Al implementar esta interfaz, los componentes pueden interactuar con entidades de usuario de manera segura, verificando sus credenciales durante el proceso de inicio de sesión.                                                                                               |
| [IUnitOfWork.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/IUnitOfWork.cs)                     | Gestiona las transacciones y las interacciones de la base de datos a través de múltiples repositorios, asegurando la consistencia dentro de la Aplicación de Comercio Electrónico, específicamente para los datos de Clientes, Usuarios, Categorías y Descuentos en la capa de Persistencia de la arquitectura.                                                                                                                                   |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface.UseCases</summary>

| Archivo                                                                                                                                                                  | Resumen                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| ---                                                                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [IDiscountsApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/UseCases/IDiscountsApplication.cs)   | La interfaz `IDiscountsApplication` define un conjunto de operaciones asincrónicas para gestionar los datos de descuentos en la aplicación de comercio electrónico de Pacagroup. Las funciones incluyen la creación, actualización, eliminación, recuperación de un solo descuento y la recuperación paginada de todos los descuentos. Estas operaciones se adhieren a un patrón basado en respuestas utilizando objetos `Response<T>`.                                                                                                                     |
| [ICategoriesApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/UseCases/ICategoriesApplication.cs) | `ICategoriesApplication`. Permite la interacción para recuperar múltiples datos de categorías dentro de la aplicación de comercio electrónico, devolviendo una lista de objetos CategoryDTO encapsulados por un objeto Response, asegurando el manejo exitoso o de errores a través de un mecanismo asincrónico Task.                                                                                                                                                                                                       |
| [ICustomersApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/UseCases/ICustomersApplication.cs)   | La interfaz ICustomersApplication, ubicada dentro de la aplicación de comercio electrónico de Pacagroup, define los métodos para gestionar los datos de los clientes de manera sincrónica y asincrónica. Estos métodos incluyen la inserción, actualización, eliminación, recuperación y recuperación paginada de los detalles del cliente representados por objetos CustomerDto en el sistema. Esta interfaz es parte de una arquitectura que aprovecha la separación limpia entre casos de uso, dominio, infraestructura y capas de presentación. |
| [IUsersApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/UseCases/IUsersApplication.cs)           | Esta interfaz de código define `IUsersApplication`, responsable de la autenticación de usuarios dentro de la aplicación de comercio electrónico. Al implementar esta interfaz, los desarrolladores aseguran un acceso seguro a las cuentas de usuario utilizando sus credenciales (nombre de usuario y contraseña). La interfaz aprovecha DTOs personalizados (UserDto) y clases comunes de manejo de errores, mejorando la modularidad y mantenibilidad de la aplicación.                                                                                      |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface.Presentation</summary>

| Archivo                                                                                                                                                  | Resumen                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                   | ---                                                                                                                                                                                                                                                                |
| [ICurrentUser.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Presentation/ICurrentUser.cs) | Define y gestiona el contexto del usuario para operaciones a nivel de aplicación, proporcionando propiedades accesibles como UserId y UserName. Facilita el control de acceso seguro en la plataforma de comercio electrónico de Pacagroup, reforzando la gestión de sesiones dentro de su interfaz. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface.Infrastructure</summary>

| Archivo                                                                                                                                              | Resumen                                                                                                                                                                                                                                                    |
| ---                                                                                                                                               | ---                                                                                                                                                                                                                                                        |
| [IEventBus.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Infrastructure/IEventBus.cs) | Facilita la mensajería asincrónica entre microservicios definiendo una interfaz `IEventBus` para la publicación de eventos personalizados. Permite un acoplamiento suelto, un manejo de eventos desacoplado entre servicios y mejora la escalabilidad del sistema en esta aplicación de comercio electrónico. |

</details>

<details closed><summary>Pacagroup.Ecommerce.CrossSectional.Common</summary>

| Archivo                                                                                                                                                                                                       | Resumen                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                                                                                        | ---                                                                                                                                                                                                                                                                                                                  |
| [Response.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/Response.cs)                                                                           | En este archivo, se define una clase personalizada de Response para manejar las respuestas de la API dentro del proyecto de comercio electrónico de Pacagroup. Hereda de ResponseGeneric, lo que le permite manejar datos de respuesta genéricos al tiempo que proporciona flexibilidad para almacenar detalles específicos de la respuesta, mejorando la comunicación entre el cliente y el servidor. |
| [BaseError.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/BaseError.cs)                                                                         | La clase `BaseError` se utiliza en todo el repositorio para definir errores dentro de la aplicación de comercio electrónico de Pacagroup estableciendo propiedades de mensaje específicas. Esta consistencia mejora la fiabilidad de la plataforma y la experiencia del usuario.                                                                                       |
| [Pacagroup.Ecommerce.CrossSectional.Common.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/Pacagroup.Ecommerce.CrossSectional.Common.csproj) | Componentes compartidos transversales en la estructura de la aplicación de comercio electrónico. Este archivo .csproj configura el proyecto para `net8.0`, habilita los usos implícitos y asegura los tipos de referencia anulables, estableciendo una base unificada para el desarrollo de código en diferentes módulos.                                         |
| [ResponseGeneric.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/ResponseGeneric.cs)                                                             | La clase ResponseGeneric en este archivo ofrece una estructura de respuesta unificada, que consiste en datos, estado de éxito, mensaje y errores. Simplifica la comunicación entre las capas de la aplicación, asegurando una retroalimentación consistente y clara en toda la solución de comercio electrónico de Pacagroup.                                     |
| [ResponsePagination.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/ResponsePagination.cs)                                                       | Estructura de la aplicación de comercio electrónico de Pacagroup. Funcionalidad: Define una clase ResponsePagination para manejar respuestas de datos paginados, incluyendo número de página, total de páginas, conteo y banderas para la navegación (Anterior/Siguiente). Esto facilita la transmisión eficiente de datos paginados en toda la plataforma de comercio electrónico.     |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi</summary>

| Archivo                                                                                                                                                                                     | Resumen                                                                                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                                       |
| [Pacagroup.Ecommerce.Services.WebApi.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Pacagroup.Ecommerce.Services.WebApi.csproj) | Este archivo de configuración del proyecto (Pacagroup.Ecommerce.Services.WebApi.csproj) establece la base para una aplicación Web API de ASP.NET Core versionada a .NET 8.0, integrando varios paquetes esenciales como AutoMapper, Swagger, autenticación JWT Bearer y verificaciones de salud Redis/SQL Server. Hace referencia a dependencias clave del proyecto, incluidos los servicios de aplicación y la lógica de dominio. |
| [Program.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Program.cs)                                                                 | Maneja el enrutamiento, la autenticación, las verificaciones de salud, la limitación de tasa y el manejo de errores; integra capas de acceso a datos con servicios de Aplicación, Infraestructura y Persistencia; habilita la generación de documentación de la API Swagger y el almacenamiento en caché Redis; se adhiere a las banderas de características definidas, middleware y versionado.                                                                                |
| [appsettings.Development.json](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/appsettings.Development.json)                             | Administra los niveles de registro de la aplicación y los hosts permitidos.* Define las cadenas de conexión para las bases de datos (Northwind & Redis).* Establece el host de la API, el origen CORS, la clave secreta, el emisor y la audiencia para la seguridad.* Configura HealthChecksUI con el tiempo de evaluación, las credenciales de WatchDog, las opciones de RabbitMq y los parámetros de limitación de tasa.                                                                   |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Services</summary>

| Archivo                                                                                                                                      | Resumen                                                                                                                                                                                                                                      |
| ---                                                                                                                                       | ---                                                                                                                                                                                                                                          |
| [CurrentUser.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Services/CurrentUser.cs) | Implementa el servicio `ICurrentUser` que recupera el ID de usuario y el nombre de usuario de la reclamación de un usuario autenticado utilizando HttpContextAccessor. Proporciona una funcionalidad básica de autenticación dentro de la capa de Web API de la plataforma de comercio electrónico de Pacagroup. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Redis</summary>

| Archivo                                                                                                                                                   | Resumen                                                                                                                                                                                                                                                             |
| ---                                                                                                                                                    | ---                                                                                                                                                                                                                                                                 |
| [RedisExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Redis/RedisExtensions.cs) | Potencia los módulos de la aplicación almacenables en caché en la WebApi de comercio electrónico de Pacagroup con la integración de Redis configurando la instancia StackExchangeRedisCache utilizando la cadena de conexión definida en el archivo de configuración, fomentando una mayor velocidad de recuperación de datos y escalabilidad. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Middleware</summary>

| Archivo                                                                                                                                                                  | Resumen                                                                                                                                                          |
| ---                                                                                                                                                                   | ---                                                                                                                                                              |
| [MiddlewareExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Middleware/MiddlewareExtensions.cs) | Propósito del Middleware de la Web API de comercio electrónico de Pacagroup: Agrega el manejo de errores a través del middleware GlobalExceptionHandler al pipeline de la aplicación para servicios robustos ante errores. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Authentication</summary>

| Archivo                                                                                                                                                                            | Resumen                                                                                                                                                                                                                                         |
| ---                                                                                                                                                                             | ---                                                                                                                                                                                                                                             |
| [AuthenticationExtension.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Authentication/AuthenticationExtension.cs) | Configura la autenticación basada en JWT en el servicio WebAPI de la aplicación de comercio electrónico estableciendo claves secretas, emisor y audiencia para la validación de tokens, al tiempo que define controladores de eventos para escenarios de expiración de tokens y fallos de autenticación. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.GlobalException</summary>

| Archivo                                                                                                                                                                           | Resumen                                                                                                                                                                                                                                    |
| ---                                                                                                                                                                            | ---                                                                                                                                                                                                                                        |
| [GlobalExceptionHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/GlobalException/GlobalExceptionHandler.cs) | Monitorea y maneja excepciones a nivel de la aplicación, asegurando que los mensajes de error estructurados se devuelvan en un formato JSON para un manejo adecuado de errores en todos los módulos dentro de la Web API de comercio electrónico de Pacagroup, mejorando la experiencia general del usuario. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Versioning</summary>

| Archivo                                                                                                                                                                  | Resumen                                                                                                                                                                                                                                                           |
| ---                                                                                                                                                                   | ---                                                                                                                                                                                                                                                               |
| [VersioningExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Versioning/VersioningExtensions.cs) | Funcionalidad clave de Pacagroup.Ecommerce.Services.WebApi: Implementa el versionado para las APIs con nombres de grupos configurables y configuración de la versión predeterminada utilizando las bibliotecas ApiVersioning y ApiExplorer, promoviendo la flexibilidad en las versiones de API y ayudando en la documentación de la API. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Injection</summary>

| Archivo                                                                                                                                                               | Resumen                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                                                                                                | ---                                                                                                                                                                                                                                                                                                                       |
| [InjectionExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Injection/InjectionExtensions.cs) | La clase `InjectionExtensions` enriquece la configuración de inyección de dependencias dentro de la aplicación registrando componentes esenciales. Acciones: Registra la instancia de configuración global, un GlobalExceptionHandler y un servicio ICurrentUser, con el alcance correspondiente para mantener la flexibilidad en las funciones de la aplicación. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.RateLimiter</summary>

| Archivo                                                                                                                                                                     | Resumen                                                                                                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                                                  |
| [RateLimiterExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/RateLimiter/RateLimiterExtensions.cs) | Configura la limitación de tasa para la web API de comercio electrónico de Pacagroup, protegiendo contra solicitudes excesivas de usuarios. La política de ventana fija personalizable se establece en función del límite de permisos especificado, el tamaño de la ventana, el orden de procesamiento en cola y el límite de cola de appsettings.json, mientras devuelve un código de estado 429 Too Many Requests al ser rechazada. Esta medida garantiza un rendimiento fiable del sistema y un uso justo. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Feature</summary>

| Archivo                                                                                                                                                         | Resumen                                                                                                                                                                                                                                                                                 |
| ---                                                                                                                                                          | ---                                                                                                                                                                                                                                                                                     |
| [FeatureExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Feature/FeatureExtensions.cs) | Configura servicios esenciales para el módulo WebAPI de aplicaciones de comercio electrónico, mejorando la política de Cross-Origin Resource Sharing (CORS) y las opciones de serialización JSON permitiendo orígenes, encabezados y métodos específicos, facilitando la interacción fluida de la API con aplicaciones externas. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.HealthCheck</summary>

| Archivo                                                                                                                                                                     | Resumen                                                                                                                                                                                                                                                                                                             |
| ---                                                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                 |
| [HealthCheckExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/HealthCheck/HealthCheckExtensions.cs) | Función clave de Pacagroup Ecommerce API: Propósito de HealthCheckExtensions: Integra verificaciones de salud personalizables para la base de datos, caché (Redis) y puntos de control personalizados en la aplicación. Proporciona un punto final de interfaz de usuario (UI) para monitorear el estado de salud del sistema, utilizando NorthwindConnection como almacenamiento. |
| [HealthCheckCustom.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/HealthCheck/HealthCheckCustom.cs)         | Este módulo HealthCheckCustom monitorea activamente la salud de las aplicaciones dentro de los servicios web API. Utiliza simulaciones de tiempo de respuesta aleatorio, devolviendo tres estados distintos: saludable, degradado y no saludable, mejorando la resiliencia general del sistema y la capacidad de respuesta para la plataforma de comercio electrónico.               |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Swagger</summary>

| Archivo                                                                                                                                                                     | Resumen                                                                                                                                                                                                                       |
| ---                                                                                                                                                                      | ---                                                                                                                                                                                                                           |
| [SwaggerExtension.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Swagger/SwaggerExtension.cs)               | Personaliza la documentación de Swagger para la seguridad en la WebAPI de comercio electrónico de Pacagroup, integrando la autorización JWT configurando el esquema OpenAPI y requiriendo autenticación utilizando el token "Bearer".                               |
| [ConfigureSwaggerOptions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Swagger/ConfigureSwaggerOptions.cs) | En este archivo, se define la configuración de Swagger para el servicio API de comercio electrónico de Pacagroup, proporcionando opciones para integrar OpenAPI y versionado. Esto asegura la documentación y la interacción adecuada con diferentes versiones de API. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Properties</summary>

| Archivo                                                                                                                                                  | Resumen                                                                                                                                                                                                                            |
| ---                                                                                                                                                   | ---                                                                                                                                                                                                                                |
| [launchSettings.json](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Properties/launchSettings.json) | Soporta conexiones HTTP y HTTPS con URLs personalizadas, habilita la apertura automática de la interfaz de usuario de Swagger al ejecutar el proyecto, admite configuraciones de implementación local, Docker, IIS Express y WSL2, simplificando la configuración de implementación en varios escenarios. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Helpers</summary>

| Archivo                                                                                                                                     | Resumen                                                                                                                                                                                                                                                                                                                                                                |
| ---                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                    |
| [AppSettings.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Helpers/AppSettings.cs) | Este archivo (`AppSettings.cs`) en la API de comercio electrónico de Pacagroup define configuraciones sensibles de la aplicación utilizadas para el Cross-Origin Resource Sharing (CORS), encriptación y autenticación (Issuer, Audience, Secret).**Proporciona configuraciones esenciales de seguridad, como configuraciones de CORS, clave de encriptación y detalles del emisor del token, mejorando la seguridad y protección de datos de la API. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Controllers.v1</summary>

| Archivo                                                                                                                                                            | Resumen                                                                                                                                                                                                                                                                                                                 |
| ---                                                                                                                                                             | ---                                                                                                                                                                                                                                                                                                                     |
| [CustomersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v1/CustomersController.cs) | Este controlador C# incluye varias operaciones CRUD para la gestión de datos de clientes utilizando métodos asincrónicos y sincrónicos. Maneja solicitudes como insertar, actualizar, eliminar, obtener clientes específicos y todos los clientes con manejo de errores utilizando IActionResult. La capa de aplicación interactúa con la lógica de negocio subyacente. |
| [UsersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v1/UsersController.cs)         | ApiVersion}/Users/Authenticate utilizando UserDto proporcionado. Tras una autenticación exitosa, genera un token JWT para el userId y lo devuelve. Esto mejora la seguridad del usuario en la WebAPI v1 de comercio electrónico de Pacagroup implementando un sistema de control de acceso para solicitudes autenticadas.                                           |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Controllers.v3</summary>

| Archivo                                                                                                                                                            | Resumen                                                                                                                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                             | ---                                                                                                                                                                                                                                                                                                                                                                |
| [CustomersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v3/CustomersController.cs) | Este controlador facilita operaciones CRUD para clientes en la API de aplicaciones de comercio electrónico versión v3. Emplea MediatR para manejar comandos y consultas, habilitando funciones como crear, actualizar, eliminar y recuperar datos de clientes utilizando diferentes tipos de consulta como GetAllCustomerQuery, GetCustomerQuery y GetAllWithPaginationCustomerQuery. |
| [UsersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v3/UsersController.cs)         | Genera tokens de acceso JWT para usuarios en la versión 3.0 de la API al recibir credenciales de usuario a través de una solicitud HTTP POST al punto de autenticación. Implementa MediatR para la interacción con casos de uso relacionados con el usuario, aprovecha AppSettings y JwtSecurityTokenHandler para la creación y validación de tokens.                                                                  |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Controllers.v2</summary>

| Archivo                                                                                                                                                              | Resumen                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| ---                                                                                                                                                               | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [CustomersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v2/CustomersController.cs)   | El controlador contiene operaciones CRUD para la entidad Cliente.2. Utiliza métodos sincrónicos (Http*) y asincrónicos (Http*Async) para realizar acciones en la base de datos.3. Se utilizan respuestas BadRequest() y Ok() para manejar la entrada no válida y la ejecución exitosa, respectivamente.4. La respuesta de _customersApplication se verifica para manejar escenarios de éxito/error.5. Soporte de paginación disponible para obtener todos los datos de los clientes.6. Todas las funciones verifican sus entradas antes de ejecutar operaciones, devolviendo un mensaje de error o BadRequest cuando sea necesario. |
| [UsersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v2/UsersController.cs)           | La clase UsersController procesa solicitudes de autenticación en este archivo, llamando a la lógica de negocio adecuada dentro de la interfaz IUsersApplication y utilizando la generación de tokens JWT para otorgar acceso tras la validación exitosa. Es parte de la API v2 de los servicios web de comercio electrónico de Pacagroup, mejorando las interacciones seguras del usuario dentro de la arquitectura del sistema más amplio.                                                                                                                                                              |
| [DiscountsController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v2/DiscountsController.cs)   | Administra operaciones CRUD para descuentos dentro de la aplicación de comercio electrónico a través de llamadas API REST, utilizando objetos DTO para recibir/enviar datos de manera segura y eficiente bajo una política de limitación de tasa, asegurando un uso fluido del servicio para todos los usuarios.                                                                                                                                                                                                                                                                                                        |
| [CategoriesController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v2/CategoriesController.cs) | Administra puntos finales API RESTful para obtener todas las categorías (v2/CategoriesController). Utiliza versionado (APIVersion=2.0), limitación de tasa (ventana fija), autorización y anotaciones de Swagger. Aprovecha los servicios de aplicación para procesar datos, devolviendo mensajes de éxito o error tras la ejecución de la solicitud.                                                                                                                                                                                                                                         |

</details>

<details closed><summary>Pacagroup.Ecommerce.CrossSectional.Mapper</summary>

| Archivo                                                                                                                                                                                                       | Resumen                                                                                                                                                                                                                                                                                                                                                  |
| ---                                                                                                                                                                                                        | ---                                                                                                                                                                                                                                                                                                                                                      |
| [Pacagroup.Ecommerce.CrossSectional.Mapper.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Mapper/Pacagroup.Ecommerce.CrossSectional.Mapper.csproj) | Esta configuración del proyecto de mapeo optimiza la transformación de datos dentro del ecosistema de comercio electrónico de Pacagroup, utilizando AutoMapper para un mapeo eficiente entre los DTOs de la aplicación y las entidades del dominio para soportar la arquitectura robusta y escalable del sistema.                                                                                             |
| [MapppingsProfile.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Mapper/MapppingsProfile.cs)                                                           | Este MapppingsProfile sirve como configuración del mapeador en el sistema de comercio electrónico de Pacagroup. Facilita la traducción sin problemas entre objetos de transferencia de datos (DTOs) y entidades de dominio utilizando AutoMapper. Esto optimiza la comunicación entre las diferentes capas de la aplicación, asegurando un intercambio de datos consistente y eficiente dentro de la plataforma. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence</summary>

| Archivo                                                                                                                                                                         | Resumen                                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                                          | ---                                                                                                                                                                                                                                                                                |
| [ConfigureServices.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/ConfigureServices.cs)                                     | Agrega DapperContext, DB context, interceptores de auditoría y repositorios (Customers, Users, Categories, Discounts) como servicios con ámbito. También configura el servicio de unidad de trabajo, asegurando interacciones fluidas con la base de datos.                                                        |
| [Pacagroup.Ecommerce.Persistence.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Pacagroup.Ecommerce.Persistence.csproj) | Configura las dependencias de la base de datos para la aplicación de comercio electrónico de Pacagroup, aprovechando Entity Framework Core y Dapper para manejar las operaciones de datos dentro de la capa de persistencia del software. Habilita la interacción con varias interfaces definidas en la estructura del repositorio principal. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Interceptor</summary>

| Archivo                                                                                                                                                                                         | Resumen                                                                                                                                                                                                                                                                                                                     |
| ---                                                                                                                                                                                          | ---                                                                                                                                                                                                                                                                                                                         |
| [AuditableEntitySaveChangesInterceptor.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Interceptor/AuditableEntitySaveChangesInterceptor.cs) | Este `AuditableEntitySaveChangesInterceptor` asegura que cada interacción con la base de datos dentro de la aplicación se rastree registrando detalles como marcas de tiempo creadas y modificadas junto con los nombres de usuario asociados con cada operación. El seguimiento mejora la auditoría, la resolución de problemas y aumenta la transparencia general de los datos. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Migrations</summary>

| Archivo                                                                                                                                                                                                    | Resumen                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                              |
| [20240519193621_CreateInitialScheme.Designer.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Migrations/20240519193621_CreateInitialScheme.Designer.cs) | Esta `CreateInitialScheme` migra el esquema para la tabla de descuentos en la base de datos de la aplicación de comercio electrónico. Define y configura las propiedades de las entidades Discount, como nombre, descripción, porcentaje, estado y marcas de tiempo, asegurando la integridad y estructura de los datos. |
| [ApplicationDbContextModelSnapshot.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Migrations/ApplicationDbContextModelSnapshot.cs)                     | Este snapshot de código automatiza la configuración de entidades para la tabla de descuentos en la base de datos de comercio electrónico. Establece atributos esenciales como Id, Nombre, Descripción, fechas de Creación y Última Modificación, y estado, cumpliendo con el esquema definido y las restricciones dentro del contexto de la aplicación.         |
| [20240519193621_CreateInitialScheme.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Migrations/20240519193621_CreateInitialScheme.cs)                   | El archivo de código proporcionado crea una tabla inicial llamada Discounts para nuestra aplicación Pacagroup.Ecommerce. Esta tabla incluye columnas para el nombre del descuento, descripción, porcentaje, estado y marcas de tiempo para Creado, Última Modificación, CreadoPor y Última ModificaciónPor.                               |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Contexts</summary>

| Archivo                                                                                                                                                    | Resumen                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                                              |
| [DapperContext.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Contexts/DapperContext.cs)               | En el repositorio `Pacagroup.Ecommerce`, el archivo `DapperContext.cs` define y configura un contexto de base de datos Dapper para consultas SQL eficientes dentro de la capa de persistencia. Este contexto se construye utilizando la cadena de conexión de la aplicación proporcionada para una integración sin problemas con los sistemas de almacenamiento de datos. |
| [ApplicationDbContext.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Contexts/ApplicationDbContext.cs) | Administra la persistencia de datos para la entidad de descuentos de las aplicaciones de comercio electrónico. ApplicationDbContext configura las interacciones de la base de datos de Entity Framework Core, asegurando la integridad de los datos y el mapeo adecuado de las tablas. Integra un AuditableEntitySaveChangesInterceptor para rastrear los cambios en los registros de descuentos.        |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Configurations</summary>

| Archivo                                                                                                                                                            | Resumen                                                                                                                                                                                                                        |
| ---                                                                                                                                                             | ---                                                                                                                                                                                                                            |
| [DiscountConfiguration.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Configurations/DiscountConfiguration.cs) | Configura el esquema de la base de datos para la entidad Discount, estableciendo propiedades como Nombre, Descripción y Porcentaje dentro de los límites de longitud aceptables para un almacenamiento óptimo de datos, asegurando una gestión de datos consistente y eficiente. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Mocks</summary>

| Archivo                                                                                                                                                                                                 | Resumen                                                                                                                                                                                                                                                                                                                                                           |
| ---                                                                                                                                                                                                  | ---                                                                                                                                                                                                                                                                                                                                                               |
| [DiscountGetAllWithPaginationAsyncBogusConfig.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Mocks/DiscountGetAllWithPaginationAsyncBogusConfig.cs) | Genera datos simulados para las entidades de descuento para probar la funcionalidad de recuperación paginada de las aplicaciones de comercio electrónico. La clase `DiscountGetAllWithPaginationAsyncBogusConfig`, utilizando la biblioteca Bogus, define conjuntos de reglas que generan aleatoriamente nombres, descripciones, porcentajes y estados de descuentos para fines de prueba en la capa de persistencia de la aplicación. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Repositories</summary>

| Archivo                                                                                                                                                        | Resumen                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| ---                                                                                                                                                         | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [CategoriesRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/CategoriesRepository.cs) | En este código base, la clase `CategoriesRepository` es responsable de persistir los datos de categorías en la aplicación de comercio electrónico de Pacagroup. Implementando la Interfaz `ICategoriesRepository`, se conecta con Dapper para interactuar directamente con la base de datos a través de su `DapperContext`. Este repositorio proporciona un método, `GetAll()`, que obtiene todas las categorías de la base de datos y las devuelve como una lista enumerable, facilitando las operaciones de consulta para la capa de aplicación. |
| [DiscountRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/DiscountRepository.cs)     | Este código define un `DiscountRepository`, responsable de persistir las entidades de descuento dentro del contexto de la base de datos de aplicaciones de comercio electrónico (`ApplicationDbContext`). Implementa operaciones CRUD para la gestión de datos de descuentos, incluidos métodos sincrónicos y asincrónicos para insertar, actualizar, eliminar, contar, recuperar registros individuales o múltiples de descuentos con o sin paginación.                                                                                                  |
| [CustomersRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/CustomersRepository.cs)   | El código proporcionado define operaciones CRUD (Crear, Leer, Actualizar, Eliminar) para objetos Customer utilizando procedimientos almacenados en un contexto de base de datos. También incluye funcionalidad para consultas de paginación y conteo para mejorar la eficiencia con conjuntos de datos grandes. Este patrón permite una integración sin problemas entre C# y procedimientos almacenados de SQL.                                                                                                                                                |
| [UnitOfWork.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/UnitOfWork.cs)                     | El repositorio de UnitOfWork encapsula múltiples repositorios (Customers, Users, Categories, Discounts) para la capa de persistencia de las aplicaciones de comercio electrónico de Pacagroup, asegurando un manejo eficiente y un almacenamiento seguro de datos en ApplicationDbContext dentro de una transacción.                                                                                                                                                                                                                      |
| [UserRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/UserRepository.cs)             | Gestiona la autenticación de usuarios dentro de la aplicación de comercio electrónico de Pacagroup mediante la ejecución de procedimientos almacenados utilizando Dapper, asegurando el acceso seguro a los datos de los clientes.                                                                                                                                                                                                                                                                                                                 |

</details>

<details closed><summary>Pacagroup.Ecommerce.Infrastructure</summary>

| Archivo | Resumen |
| --- | --- |
| [ConfigureServices.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/ConfigureServices.cs) | Configura el sistema de mensajería basado en eventos en Pacagroup.Ecommerce. El archivo establece las opciones de RabbitMQ e inicializa MassTransit para una comunicación asincrónica eficiente entre componentes. Mejora la integración, flexibilidad y escalabilidad de la aplicación. |
| [Pacagroup.Ecommerce.Infrastructure.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/Pacagroup.Ecommerce.Infrastructure.csproj) | Potencia los microservicios impulsados por eventos configurando y haciendo referencia a los paquetes necesarios para el Message Broker (RabbitMQ) y los contenedores de inyección de dependencias (MassTransit, Microsoft Extensions). Esto permite una comunicación fluida entre los componentes de servicio en la arquitectura de la aplicación Ecommerce. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Infrastructure.EventBus</summary>

| Archivo | Resumen |
| --- | --- |
| [EventBusRabbitMQ.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/EventBus/EventBusRabbitMQ.cs) | Publica eventos dentro de la capa de infraestructura de la aplicación utilizando MassTransit, agilizando la comunicación entre microservicios. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Infrastructure.EventBus.Options</summary>

| Archivo | Resumen |
| --- | --- |
| [RabbitMqOptions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/EventBus/Options/RabbitMqOptions.cs) | Define el nombre del host, el host virtual, el nombre de usuario y la contraseña para la mensajería entre servicios dentro de la arquitectura de Pacagroup Ecommerce, facilitando el manejo asincrónico de eventos a través de componentes distribuidos. |
| [RabbitMqOptionsSetup.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/EventBus/Options/RabbitMqOptionsSetup.cs) | Una pieza crucial de la infraestructura en el EventBus de la aplicación Pacagroups Ecommerce. Vincula las opciones de configuración relacionadas con el sistema de mensajería, asegurando una comunicación fluida y una arquitectura impulsada por eventos en toda la plataforma. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.DTO</summary>

| Archivo | Resumen |
| --- | --- |
| [CategoryDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/CategoryDto.cs) | Transforma categorías para el uso en la capa de aplicación, definiendo atributos esenciales como ID, nombre, descripción e imagen en una estructura clara y simplificada para facilitar una comunicación eficiente entre servicios y la interfaz de usuario en el sistema Pacagroup Ecommerce. |
| [Pacagroup.Ecommerce.Application.DTO.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/Pacagroup.Ecommerce.Application.DTO.csproj) | Cataloga entidades de dominio cruciales en Objetos de Transferencia de Datos para una comunicación eficiente entre capas, adhiriéndose al estándar .NET 8. Esto ayuda a mantener una arquitectura limpia en toda la aplicación. |
| [DiscountDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/DiscountDto.cs) | El archivo `DiscountDto.cs` dentro de la carpeta `Pacagroup.Ecommerce/Application.DTO` es un Objeto de Transferencia de Datos (DTO) para manejar datos de descuentos dentro de la aplicación. Contiene propiedades para representar el Id del descuento, nombre, descripción, valor porcentual y estado, fomentando una comunicación fluida entre servicios y la interfaz de usuario. |
| [UserDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/UserDto.cs) | El archivo `UserDto` encapsula el modelo de datos de usuario dentro de la aplicación Pacagroup Ecommerce, incluyendo identificadores únicos, nombre, apellido, nombre de usuario, contraseña y token para propósitos de autenticación segura. |
| [CustomerDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/CustomerDto.cs) | El archivo `CustomerDto.cs` define objetos de transferencia de datos (DTO) para manejar información de clientes en la capa de aplicación del sistema Pacagroup Ecommerce. Estos DTOs proporcionan un formato simplificado y consistente para transmitir datos relacionados con clientes entre capas, mejorando la integridad y usabilidad general de los datos. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.DTO.Enums</summary>

| Archivo | Resumen |
| --- | --- |
| [DiscountStatusDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/Enums/DiscountStatusDto.cs) | Enumera los estados de descuento `Inactivo` y `Activo`, proporcionando un método simple pero poderoso para alternar entre estos estados. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main</summary>

| Archivo | Resumen |
| --- | --- |
| [ConfigureServices.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/ConfigureServices.cs) | Configura las dependencias de Categories, Customers, Discounts, Users, registrando validadores, MediatR, AutoMapper y comportamientos de registro/validación a través de ensamblajes. Es el centro principal para gestionar el árbol de dependencias de servicios de la aplicación y facilita la ejecución fluida de los casos de uso dentro del sistema Ecommerce. |
| [Pacagroup.Ecommerce.Application.UseCases.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Pacagroup.Ecommerce.Application.UseCases.csproj) | Implementa los casos de uso principales de la aplicación Pacagroup Ecommerce orquestando los servicios de dominio e integrándolos con las capas DTO, Interfaz y Dominio. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Categories</summary>

| Archivo | Resumen |
| --- | --- |
| [CategoriesApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Categories/CategoriesApplication.cs) | Optimiza la recuperación de datos de elementos de categoría dentro de la aplicación Pacagroup Ecommerce. El archivo `CategoriesApplication.cs` es un componente crucial, responsable del almacenamiento en caché y manejo de solicitudes para todas las categorías. Al utilizar caché distribuido, garantiza una recuperación eficiente y reduce la carga en las consultas a la base de datos. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers</summary>

| Archivo | Resumen |
| --- | --- |
| [CustomersApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/CustomersApplication.cs) | Este controlador realiza operaciones CRUD sobre los clientes utilizando Entity Framework y AutoMapper, con registro proporcionado por ILogger de Microsoft. Las operaciones se ejecutan de manera sincrónica (para eliminar, obtener, insertar, actualizar) o asincrónica (para recuperar todos los clientes con paginación). Se utiliza un objeto Response para los valores de retorno, lo que facilita el manejo de datos y errores. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Queries.GetCustomerQuery</summary>

| Archivo | Resumen |
| --- | --- |
| [GetCustomerQuery.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetCustomerQuery/GetCustomerQuery.cs) | Empodera la consulta de clientes creando una GET Customer Query para recuperar un registro específico de cliente, basado en CustomerId. Es parte de la aplicación Pacagroup.Ecommerce.Application.Main dentro de los espacios de nombres Queries y Customers. Esta consulta utiliza MediatR y el objeto de respuesta común de Pacagroup.Ecommerce.CrossSectional.Common para una comunicación fluida. |
| [GetCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetCustomerQuery/GetCustomerHandler.cs) | Este manejador de código optimiza la recuperación de datos de clientes implementando `GetCustomerHandler`, una parte integral del pipeline de manejo de consultas MediatR dentro del dominio de Customers. Utilizando AutoMapper e inyección de dependencias, recupera detalles específicos del cliente de la capa de Persistencia, mapea los datos al modelo CustomerDTO y devuelve la respuesta formateada. El objetivo es mejorar la experiencia del cliente asegurando una recuperación eficiente y confiable de los datos relacionados con el usuario. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Queries.GetAllCustomerQuery</summary>

| Archivo | Resumen |
| --- | --- |
| [GetAllCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetAllCustomerQuery/GetAllCustomerHandler.cs) | Maneja las consultas para recuperar todos los detalles de los clientes mapeando datos desde la base de datos utilizando AutoMapper y MediatR en el caso de uso del cliente de la aplicación Pacagroup.Ecommerce. La clase GetAllCustomerHandler interactúa con el servicio IUnitOfWork, asegurando un acceso a datos consistente y transaccional dentro de la capa de Persistencia. |
| [GetAllCustomerQuery.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetAllCustomerQuery/GetAllCustomerQuery.cs) | GetAllCustomerQuery.cs dentro de la aplicación principal de Pacagroup. El patrón MediatR facilita una consulta asincrónica eficiente para recuperar una colección de objetos CustomerDto del dominio de Customers. Esta interacción mejora la usabilidad y adaptabilidad del módulo de gestión de clientes en la plataforma de comercio electrónico Pacagroup. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Queries.GetAllWithPaginationCustomerQuery</summary>

| Archivo | Resumen |
| --- | --- |
| [GetAllWithPaginationCustomerQuery.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetAllWithPaginationCustomerQuery/GetAllWithPaginationCustomerQuery.cs) | Este archivo contiene una solicitud tipo segura (`GetAllWithPaginationCustomerQuery`) dentro del patrón MediatR para obtener datos paginados de clientes en la aplicación de comercio electrónico. La consulta toma parámetros para el número de página y el tamaño, y devuelve una colección de objetos `CustomerDto` envueltos en un `ResponsePagination<IEnumerable<CustomerDto>>`. Esto mejora la flexibilidad para manejar consultas de clientes de manera efectiva, alineándose con la arquitectura general del proyecto. |
| [GetAllWithPaginationCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetAllWithPaginationCustomerQuery/GetAllWithPaginationCustomerHandler.cs) | Gestiona la recuperación de datos de clientes con paginación para la aplicación de comercio electrónico. Implementado como un método `Handle` dentro del patrón MediatR utilizando AutoMapper y unidad de trabajo de base de datos para la interacción. Esta función garantiza una recuperación eficiente y el manejo de grandes conjuntos de datos mientras mantiene una estructura clara de respuesta. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Commands.DeleteCustomerCommand</summary>

| Archivo | Resumen |
| --- | --- |
| [DeleteCustomerCommand.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/DeleteCustomerCommand/DeleteCustomerCommand.cs) | En el repositorio de la aplicación Pacagroup Ecommerce, este archivo representa un comando para eliminar clientes. La clase `DeleteCustomerCommand`, que se encuentra bajo el módulo Customers en UseCases, utiliza la biblioteca MediatR para manejar y procesar solicitudes de eliminación de clientes. Al implementar este comando, la aplicación proporciona una interfaz para eliminar clientes específicos dentro de su estructura de base de datos. |
| [DeleteCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/DeleteCustomerCommand/DeleteCustomerHandler.cs) | Elimina registros de clientes en la aplicación Pacagroup Ecommerce manejando DeleteCustomerCommand. Utiliza UnitOfWork y AutoMapper para interactuar con la base de datos y mapear datos de solicitud respectivamente, devolviendo una `Response<bool>` que indica una eliminación exitosa. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Commands.CreateCustomerCommand</summary>

| Archivo | Resumen |
| --- | --- |
| [CreateCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/CreateCustomerCommand/CreateCustomerHandler.cs) | Gestiona el registro de clientes dentro de la aplicación Pacagroup Ecommerce. Este manejador aprovecha MediatR para el procesamiento de comandos, AutoMapper para mapear objetos de datos, y la capa de Persistencia de la aplicación (UnitOfWork) para insertar nuevos registros de clientes en la base de datos, garantizando un flujo de datos fluido. |
| [CreateCustomerCommand.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/CreateCustomerCommand/CreateCustomerCommand.cs) | Crea un comando para la entrada de usuario para registrar un nuevo cliente, estructurando los datos requeridos con propiedades como CustomerId, CompanyName, ContactName, Address, City, Region, PostalCode, Country, Phone, y Fax. Se alinea con el patrón MediatR para facilitar el manejo de comandos dentro del módulo Customers en la aplicación Pacagroup Ecommerce. |
| [CreateCustomerValidator.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/CreateCustomerCommand/CreateCustomerValidator.cs) | Valida los datos de entrada para la creación de nuevos clientes dentro del caso de uso de Customers de Pacagroup Ecommerce. Garantiza que el `CustomerId` cumpla con los requisitos como no estar vacío, no ser nulo y tener una longitud mínima de cinco caracteres. Parte de la capa de aplicación que impone una estructura de datos consistente y validada para una funcionalidad óptima. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Commands.UpdateCustomerCommand</summary>

| Archivo | Resumen |
| --- | --- |
| [UpdateCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/UpdateCustomerCommand/UpdateCustomerHandler.cs) | Este manejador de comandos actualiza los datos de los clientes dentro de la capa de casos de uso de la aplicación, recibiendo una solicitud de actualización, mapeándola a una entidad de Cliente y persistiendo la información actualizada utilizando el UnitOfWork especificado. Luego se genera el objeto Response con el resultado, señalando la actualización exitosa con un valor true en la respuesta. |
| [UpdateCustomerCommand.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/UpdateCustomerCommand/UpdateCustomerCommand.cs) | Este comando, dentro de la aplicación Pacagroup Ecommerce, desencadena el proceso para modificar atributos esenciales como el nombre de la empresa, el nombre del contacto, el título, la dirección, la ciudad, la región, el código postal, el país, el teléfono y el fax para un cliente específico. Forma parte de los flujos de trabajo potenciados por MediatR en el módulo de Clientes, impulsando actualizaciones eficientes utilizando el patrón CQRS. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Users</summary>

| Archivo | Resumen |
| --- | --- |
| [UsersApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Users/UsersApplication.cs) | Gestiona la autenticación de usuarios dentro de la aplicación de comercio electrónico Pacagroup validando los nombres de usuario y contraseñas proporcionados, utilizando objetos UserDTO, IUnitOfWork para operaciones de base de datos y AutoMapper para el mapeo de objetos, asegurando un inicio de sesión exitoso o informando sobre usuarios inexistentes. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Users.Commands.CreateUserTokenCommand</summary>

| Archivo | Resumen |
| --- | --- |
| [CreateUserTokenValidator.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Users/Commands/CreateUserTokenCommand/CreateUserTokenValidator.cs) | Valida la autenticación de usuarios en este microservicio de la aplicación de comercio electrónico, asegurando que los nombres de usuario no estén vacíos y que las contraseñas tengan al menos cinco caracteres de longitud al crear tokens de usuario. Utilizando la biblioteca FluentValidation, el código mantiene reglas de validación robustas para la entrada del usuario. Esto refuerza las prácticas de seguridad sólidas dentro de nuestra arquitectura del sistema. |
| [CreateUserTokenCommand.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Users/Commands/CreateUserTokenCommand/CreateUserTokenCommand.cs) | Genera tokens de autenticación para usuarios recién registrados utilizando MediatR y objetos de transferencia de datos (DTO) en la capa de aplicación principal. El comando `CreateUserTokenCommand` define propiedades requeridas, asegurando un acceso seguro a las cuentas de usuario dentro de la plataforma de comercio electrónico. |
| [CreateUserTokenHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Users/Commands/CreateUserTokenCommand/CreateUserTokenHandler.cs) | Genera tokens de autenticación para usuarios registrados. Implementado dentro del módulo de Usuarios utilizando MediatR y AutoMapper en la capa principal de la aplicación, mapea entidades de Usuario a DTOs, autentica las credenciales proporcionadas contra los registros de usuario existentes, y devuelve respuestas de éxito o error con datos tokenizados. Integrado con interfaces de repositorio y unidad de trabajo para asegurar un manejo adecuado de la persistencia. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Common.Behaviours</summary>

| Archivo | Resumen |
| --- | --- |
| [LoggingBehaviour.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Behaviours/LoggingBehaviour.cs) | Monitorea y registra las interacciones de solicitud-respuesta para los casos de uso de la aplicación Pacagroup Ecommerce, mejorando la trazabilidad y auditabilidad general proporcionando registros detallados en una arquitectura limpia utilizando MediatR y herramientas de registro de Microsoft. |
| [ValidationBehaviour.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Behaviours/ValidationBehaviour.cs) | Valida las entradas para los casos de uso en la aplicación de comercio electrónico, asegurando la integridad de los datos y previniendo errores durante el procesamiento de solicitudes. Utiliza FluentValidation y MediatR, capturando excepciones de validación con mensajes de error personalizados si es necesario. |
| [PerformanceBehaviour.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Behaviours/PerformanceBehaviour.cs) | Monitorea el rendimiento de los comandos potenciados por MediatR en toda la aplicación midiendo sus tiempos de ejecución y registrando aquellos que tardan más en ejecutarse para apoyar las optimizaciones en esta solución de comercio electrónico. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Common.Constants</summary>

| Archivo | Resumen |
| --- | --- |
| [GlobalConstant.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Constants/GlobalConstant.cs) | GlobalConstant establece el ID de usuario del sistema por defecto (1) y el nombre de usuario (System), permitiendo una identificación uniforme en varias funcionalidades de la aplicación Pacagroup Ecommerce. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Common.Exceptions</summary>

| Archivo | Resumen |
| --- | --- |
| [ValidationExceptionCustom.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Exceptions/ValidationExceptionCustom.cs) | Personaliza excepciones a nivel de aplicación para fallos de validación, mejorando la consistencia en los informes de errores a través de los casos de uso de la plataforma de comercio electrónico al aprovechar una clase base de errores predefinida. Esto fomenta un manejo estructurado y más fácil de entender de errores en toda la arquitectura de la aplicación. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Common.Mappings</summary>

| Archivo | Resumen |
| --- | --- |
| [MapppingsProfile.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Mappings/MapppingsProfile.cs) | Este perfil de mapeo utiliza AutoMapper para una conversión sin problemas entre DTOs (Objetos de Transferencia de Datos) de la aplicación y entidades de dominio en los casos de uso de Cliente, Usuario, Categoría y Descuento. Además, mapea objetos de evento relacionados con la creación de descuentos en la aplicación Pacagroup Ecommerce. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Discounts</summary>

| Archivo | Resumen |
| --- | --- |
| [DiscountsApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Discounts/DiscountsApplication.cs) | Presenta una API funcional para manejar operaciones de Descuento, utilizando un EventBus para difundir eventos después del registro. Los métodos `InsertAsync`, `Delete`, `Get`, `GetAll` y `Update` facilitan la creación, eliminación, recuperación individual y de todos los datos de descuento. También se ofrece una versión paginada de esto último en forma de `GetAllWithPagination`. Todas las acciones se ejecutan dentro de un UnitOfWork para una manipulación de datos consistente. El bus de eventos difunde un evento personalizado `DiscountCreatedEvent` tras un nuevo registro. |

</details>

---

##  Primeros Pasos

**Requerimientos del Sistema:**

* **CSharp**: `versión 11`
* **.NET**: `versión 7`

###  Instalación

<h4>Desde <code>source</code></h4>

> 1. Clona el repositorio Pacagroup.Ecommerce:
>
> ```console
> $ git clone https://github.com/juansdev/Pacagroup.Ecommerce
> ```
>
> 2. Cambia al directorio del proyecto:
> ```console
> $ cd Pacagroup.Ecommerce
> ```
>
> 3. Instala las dependencias:
> ```console
> $ dotnet build
> ```
>
> 4. Edite la conexión a su BD de Microsoft SQL Server en la llave "NorthwindConnection" alojada en el archivo Service/Web.API/appsettings.Development.json.
>
> 5. Active el Servidor Microsoft SQL.
>
> 6. Edite la conexión a su Redis en la llave "RedisConnection" alojada en el archivo Service/Web.API/appsettings.Development.json.
>
> 5. Active el Servidor de Redis.

###  Uso

<h4>Desde <code>source</code></h4>

> Despliega el proyecto mediante el perfil de lanzamiento HTTPS.

###  Pruebas

> Ejecuta la suite de pruebas utilizando el siguiente comando:
> ```console
> $ dotnet test
> ```

---
