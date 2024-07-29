<p align="center">
  <img src="https://simpleicons.org/icons/dotnet.svg" style="filter:invert(1);" width="100" alt="project-logo">
</p>
<p align="center">
    <h1 align="center">PACAGROUP ECOMMERCE</h1>
</p>
<p align="center">
    <em>Welcome to Pacagroup Ecommerce!Pacagroup Ecommerce empowers efficient, maintainable e-commerce with the use of clear DTOs (Data Transfer Objects) and optimized container deployment. The power of.NET 7.0 at your fingertips! Build, Innovate, and Succeed — Together in the Worldwide Digital Marketplace.</em>
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
  <summary>Table of Contents</summary><br>

- [ Overview](#-overview)
- [ Features](#-features)
- [ Repository Structure](#-repository-structure)
- [ Modules](#-modules)
- [ Getting Started](#-getting-started)
  - [ Installation](#-installation)
  - [ Usage](#-usage)
</details>
<hr>

##  Overview

The `Pacagroup.Ecommerce` project is an open-source e-commerce software solution designed for creating robust and scalable online shopping experiences. Its primary focus lies in providing a versatile and user-friendly platform, underpinned by a well-architectured structure. The codebase spans across various layers of the application architecture, as showcased by the files like `Pacagroup.Ecommerce.sln` which houses Data Transfer Objects (DTOs) for efficient communication between different components. Key DTOs such as `CategoryDto`, `CustomerDto`, `DiscountDto`, and `UserDto` are meticulously defined, ensuring streamlined data exchange among the presentation, application, infrastructure layers, and possibly other tiers.The project leverages containerization technologies by building and deploying Docker images through the `Dockerfile`. This approach guarantees consistent environments while minimizing potential dependencies issues across development, staging, and production environments. With these core functionalities, the `Pacagroup.Ecommerce` project offers a valuable proposition of promoting code readability, maintainability, extensibility, and scalability, thereby enabling swift adaptation to evolving e-commerce requirements.

---

##  Features

|    |   Feature         | Description |
|----|-------------------|---------------------------------------------------------------|
| ⚙️  | Architecture     | ASP.NET Core with Docker integration for cross-platform compatibility, domain-driven design, and separation of concerns between layers. Uses Data Transfer Objects (DTOs) for efficient data exchange. |
| 🔩 | Code Quality      | Clean, maintainable, and well-structured C# code adhering to Microsoft .NET coding standards and guidelines. Use of SOLID principles promotes a robust, extensible design. |
| 📄 | Documentation    | Informative commit messages, detailed documentation within the source code itself, and specific README.md files for each submodule, providing clear instructions on how to build, integrate, and use each component effectively. |
| 🔌 | Integrations      | External dependencies include ASP.NET Core for building web applications and Docker to containerize the solution for improved deployment consistency. |
| 🧩 | Modularity        | The codebase is highly modular with separate projects for application layers, data transfer objects, and domain entities. Each module has its own responsibility, promoting maintainability and scalability. |
| ⚡️  | Performance       | Well-optimized for efficient execution using asynchronous processing, proper memory management, and caching techniques. Load testing not available in the provided information. |
| 🛡️ | Security          | Employs secure communication between components using HTTPS and utilizes .NET Core's built-in security features such as dependency injection for data access control and protection. |
| 📦 | Dependencies      | External libraries include ASP.NET Core, Docker, .NET 7.0 SDK, and several common .NET libraries such as System, Microsoft.EntityFrameworkCore, Json.NET, and others for common functions. |

---

##  Repository Structure

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

##  Modules

<details closed><summary>.</summary>

| File                                                                                                           | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| ---                                                                                                            | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [Pacagroup.Ecommerce.sln](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.sln) | This code file, located within the `Pacagroup.Ecommerce/Pacagroup.Ecommerce.Application.DTO` directory, is part of a larger e-commerce application in the parent repository titled `Pacagroup.Ecommerce`. The main purpose of this codefile is to define Data Transfer Objects (DTOs) used for communication between different layers and components within the application architecture.The key DTOs defined here include `CategoryDto`, `CustomerDto`, `DiscountDto`, and `UserDto`, which allow clean and efficient data exchange between the presentation, application, infrastructure, and possibly other layers of the application. These DTOs serve as lightweight, plain objects that only contain properties relevant to data transport.By using these well-defined DTOs, the e-commerce application adopts a clear, maintainable architecture. This facilitates efficient interactions between components while decoupling them from specific implementation details of their respective layers, promoting code readability, and improving extensibility of the solution as requirements evolve. |
| [Dockerfile](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Dockerfile)                           | Builds and deploys Docker images for the Pacagroup Ecommerce Web API application. This action encapsulates the projects.NET 7.0 dependencies within a container, optimizing environment consistency across diverse deployment scenarios.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity</summary>

| File                                                                                                                                                                 | Summary                                                                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                                                  | ---                                                                                                                                                                                                                                                                                                                                                                             |
| [Pacagroup.Ecommerce.Domain.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Pacagroup.Ecommerce.Domain.csproj) | The Domain-driven architecture of Pacagroup Ecommerce solution, focusing on defining core business entities. **Provides blueprintfor domain-specific classes and their relationships within the application context for Net8.0 platform. **Implements essential featuresenabling explicit, model-oriented programming to facilitate robust, maintainable codebase construction. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity.Entities</summary>

| File                                                                                                                              | Summary                                                                                                                                                                                                                                                                                                                           |
| ---                                                                                                                               | ---                                                                                                                                                                                                                                                                                                                               |
| [Customer.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Entities/Customer.cs) | In the Pacagroup Ecommerce architecture, this `Customer` class within the Entities folder is responsible for defining the structure of a customer entity. It includes essential details like CompanyName, ContactName, Address, and ContactTitle, enabling efficient storage and retrieval of customer information in the system. |
| [Discount.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Entities/Discount.cs) | Manages `Discount` entities for Ecommerce application. Each Discount possesses a Name, Description, Percentage value, and Status (active/inactive). Part of the Domain Layer focusing on core business logic, leveraging BaseAuditableEntity class from the Common module for auditability features.                              |
| [Category.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Entities/Category.cs) | The `Category.cs` file within the `Pacagroup.Ecommerce.Domain.Entity` repository defines the category entity for the eCommerce application, containing properties like CategoryName and Description. This data structure is essential for organizing product groups in the store system.                                          |
| [User.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Entities/User.cs)         | Manage Users**-This.NET domain entity class encapsulates User data structures, holding essential information like FirstName, LastName, and Username for authentication within the Ecommerce application.                                                                                                                          |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity.Enums</summary>

| File                                                                                                                                       | Summary                                                                                                                                                              |
| ---                                                                                                                                        | ---                                                                                                                                                                  |
| [DiscountStatus.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Enums/DiscountStatus.cs) | This enum defines two states (Inactive, Active) for the Ecommerce applications discount feature, facilitating flexible and streamlined management within the Domain. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity.Events</summary>

| File                                                                                                                                                    | Summary                                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                                                                             |
| [DiscountDeletedEvent.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Events/DiscountDeletedEvent.cs) | The `DiscountDeletedEvent` class, located within the Pacagroup.Ecommerce domain entitys events folder, serves as a signal indicating that a discount has been deleted in the system. This event is instrumental in maintaining the applications consistency by enabling other modules to respond accordingly upon detecting such an occurrence. |
| [DiscountCreatedEvent.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Events/DiscountCreatedEvent.cs) | Generates events for discount creation within the ecommerce domain model, providing data structure for DiscountName, Description, Percentage, and Status to facilitate streamlined application workflows.                                                                                                                                       |
| [DiscountUpdatedEvent.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Events/DiscountUpdatedEvent.cs) | Triggers on a Discount update in Pacagroups E-commerce application domain. The `DiscountUpdatedEvent` class defines an event essential for monitoring changes, facilitating downstream operations like notifications and analytics within the system architecture.                                                                              |

</details>

<details closed><summary>Pacagroup.Ecommerce.Domain.Entity.Common</summary>

| File                                                                                                                                                  | Summary                                                                                                                                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [BaseAuditableEntity.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Common/BaseAuditableEntity.cs) | In this file, a base auditable entity class is defined, enhancing tracking capabilities within Pacagroups e-commerce domain. The class, named `BaseAuditableEntity`, inherits from `BaseEntity` and stores information about the creation and modification dates, as well as the associated users. This feature fosters traceability and transparency across the entire application, aiding in auditing and debugging processes. |
| [BaseEntity.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Domain.Entity/Common/BaseEntity.cs)                   | Abstracts essential `Id` field for all entities in Pacagroup Ecommerces domain model, ensuring consistent data tracking across the system.                                                                                                                                                                                                                                                                                       |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface</summary>

| File                                                                                                                                                                                                       | Summary                                                                                                                                                                                                                                                       |
| ---                                                                                                                                                                                                        | ---                                                                                                                                                                                                                                                           |
| [Pacagroup.Ecommerce.Application.Interface.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Pacagroup.Ecommerce.Application.Interface.csproj) | Compiles application interfaces for Pacagroups eCommerce platform, ensuring seamless communication between DTOs, shared functionalities, and domain entities within the broader solution. Aligns with.NET 8 standard to leverage advanced framework features. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface.Persistence</summary>

| File                                                                                                                                                                   | Summary                                                                                                                                                                                                                                                                                                                                                                           |
| ---                                                                                                                                                                    | ---                                                                                                                                                                                                                                                                                                                                                                               |
| [ICustomersRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/ICustomersRepository.cs)   | ICustomersRepository.cs serves as an interface that abstracts access to customer data within the Pacagroup Ecommerce application, enabling consistent and efficient interaction between application layers using the Customer domain entity.                                                                                                                                      |
| [ICategoriesRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/ICategoriesRepository.cs) | This file **defines** an `ICategoriesRepository` interface within the application layer of the repository, part of the wider Ecommerce architecture. The main responsibility lies in handling queries for **retrieving all categories** within the ecommerce system, enabling efficient data retrieval and accessibility from various application layers.                         |
| [IGenericRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/IGenericRepository.cs)       | The provided file, `IGenericRepository.cs`, within the `Persistence` folder of `Pacagroup.Ecommerce.Application.Interface` lays out an interface that encapsulates CRUD operations (Insert, Update, Delete) and retrieval functions (Get, Count) for various domain entities throughout the e-commerce application, enabling decoupling between the application and its database. |
| [IDiscountRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/IDiscountRepository.cs)     | Manages data operations for discount entities within the application interface layer, providing methods for fetching single and multiple discount records. The `IDiscountRepository` abstracts Persistence concerns, ensuring proper interaction with the database for this specific domain.                                                                                      |
| [IUsersRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/IUsersRepository.cs)           | The provided code interface (`IUsersRepository`) within the application layer defines responsibilities for handling user authentication. By implementing this interface, components can interact with user entities securely, verifying their credentials during the login process.                                                                                               |
| [IUnitOfWork.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Persistence/IUnitOfWork.cs)                     | Manages database transactions and interactions across multiple repositories, ensuring consistency within the Ecommerce Application, specifically for Customers, Users, Categories, Discounts data in the Persistence layer of the architecture.                                                                                                                                   |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface.UseCases</summary>

| File                                                                                                                                                                  | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| ---                                                                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [IDiscountsApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/UseCases/IDiscountsApplication.cs)   | Interface `IDiscountsApplication` defines a set of asynchronous operations for managing discounts data in the Pacagroup Ecommerce Application. Functions include creation, updating, deletion, retrieval of a single discount, and paginated list retrieval of all discounts. These operations adhere to a response-driven pattern using `Response<T>` objects.                                                                                                                     |
| [ICategoriesApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/UseCases/ICategoriesApplication.cs) | ICategoriesApplication`. Enables interaction for retrieving multiple category data within the Ecommerce application, returning a list of CategoryDTO objects encapsulated by a Response object, ensuring successful or error handling through an asynchronous Task mechanism.                                                                                                                                                                                                       |
| [ICustomersApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/UseCases/ICustomersApplication.cs)   | The ICustomersApplication interface, located within Pacagroups e-commerce application, defines the methods for managing customer data synchronously and asynchronously. These methods include insertion, updating, deleting, retrieval, and paginated retrieval of customer details represented by CustomerDto objects in the system. This interface is part of an architecture that leverages clean separation between use cases, domain, infrastructure, and presentation layers. |
| [IUsersApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/UseCases/IUsersApplication.cs)           | This code interface defines `IUsersApplication`, responsible for user authentication within the e-commerce application. By implementing this interface, developers ensure secure access to user accounts using their credentials (user name and password). The interface leverages custom DTOs (UserDto) and common error-handling classes, enhancing the apps modularity and maintainability.                                                                                      |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface.Presentation</summary>

| File                                                                                                                                                  | Summary                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                   | ---                                                                                                                                                                                                                                                                |
| [ICurrentUser.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Presentation/ICurrentUser.cs) | Defines and manages** user context for application-level operations, providing accessible properties such as UserId and UserName. It facilitates secure access control across the Pacagroup Ecommerce platform, enforcing session management within its interface. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Interface.Infrastructure</summary>

| File                                                                                                                                              | Summary                                                                                                                                                                                                                                                    |
| ---                                                                                                                                               | ---                                                                                                                                                                                                                                                        |
| [IEventBus.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Interface/Infrastructure/IEventBus.cs) | Facilitates asynchronous messaging between microservices by defining an interface `IEventBus` for publishing custom events. Enables loose-coupling, decoupled event handling among services and enhances system scalability in this Ecommerce application. |

</details>

<details closed><summary>Pacagroup.Ecommerce.CrossSectional.Common</summary>

| File                                                                                                                                                                                                       | Summary                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                                                                                        | ---                                                                                                                                                                                                                                                                                                                  |
| [Response.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/Response.cs)                                                                           | In this file, a custom Response class is defined for handling API responses within the Pacagroup Ecommerce project. It inherits from ResponseGeneric, enabling it to handle generic response data while providing flexibility to store specific response details, enhancing communication between client and server. |
| [BaseError.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/BaseError.cs)                                                                         | BaseError` class is used across the repository for defining errors within the Pacagroup Ecommerce application by setting specific message properties. This consistency enhances the platforms reliability and user experience.                                                                                       |
| [Pacagroup.Ecommerce.CrossSectional.Common.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/Pacagroup.Ecommerce.CrossSectional.Common.csproj) | Cross-functional shared components in the eCommerce applications structure. This.csproj file sets up the project for `net8.0`, enables implicit usages, and ensures nullable reference types, establishing a unified baseline for code development across different modules.                                         |
| [ResponseGeneric.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/ResponseGeneric.cs)                                                             | ResponseGeneric class in this file offers a unified response structure, consisting of data, success status, message, and errors. It streamlines communication between application layers, ensuring consistent and clear feedback across the entire Pacagroup Ecommerce solution.                                     |
| [ResponsePagination.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Common/ResponsePagination.cs)                                                       | Pacagroup.Ecommerce application structure Functionality: Defines a ResponsePagination class to handle paginated data responses, including page number, total pages, count and flags for navigation (Previous/Next). This facilitates efficient paginated data transmission across the entire ecommerce platform.     |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi</summary>

| File                                                                                                                                                                                     | Summary                                                                                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                                       |
| [Pacagroup.Ecommerce.Services.WebApi.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Pacagroup.Ecommerce.Services.WebApi.csproj) | This project configuration file (Pacagroup.Ecommerce.Services.WebApi.csproj) sets up the foundation for an ASP.NET Core Web API application versioned to.NET 8.0, integrating several essential packages like AutoMapper, Swagger, JWT Bearer Authentication, and Redis/SQL Server health checks. It references key project dependencies including application services and domain logic. |
| [Program.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Program.cs)                                                                 | Handles routing, authentication, health checks, rate limiting, and error handling; integrates data access layers with Application, Infrastructure, and Persistence services; enables Swagger API documentation generation and Redis caching; adheres to defined feature flags, middleware, and versioning.                                                                                |
| [appsettings.Development.json](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/appsettings.Development.json)                             | Manages application logging levels and allowed hosts.* Defines connection strings for databases (Northwind & Redis).* Sets API host, origin CORS, secret key, issuer, and audience for security.* Configures HealthChecksUI with evaluation time, WatchDog credentials, RabbitMq options, and rate limiting parameters.                                                                   |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Services</summary>

| File                                                                                                                                      | Summary                                                                                                                                                                                                                                      |
| ---                                                                                                                                       | ---                                                                                                                                                                                                                                          |
| [CurrentUser.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Services/CurrentUser.cs) | Implements `ICurrentUser` service that retrieves the User ID and Username from an authenticated users claim using HttpContextAccessor. Provides basic authentication functionality within the Web API layer of Pacagroup Ecommerce platform. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Redis</summary>

| File                                                                                                                                                   | Summary                                                                                                                                                                                                                                                             |
| ---                                                                                                                                                    | ---                                                                                                                                                                                                                                                                 |
| [RedisExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Redis/RedisExtensions.cs) | Empowers the cacheable application modules in Pacagroup Ecommerce WebApi with Redis integration by configuring StackExchangeRedisCache instance using connection string defined in the configuration file, fostering improved data retrieval speed and scalability. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Middleware</summary>

| File                                                                                                                                                                  | Summary                                                                                                                                                          |
| ---                                                                                                                                                                   | ---                                                                                                                                                              |
| [MiddlewareExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Middleware/MiddlewareExtensions.cs) | Pacagroup Ecommerce Web API Middleware Purpose: Adds error handling via GlobalExceptionHandler middleware to the application pipeline for error-robust services. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Authentication</summary>

| File                                                                                                                                                                            | Summary                                                                                                                                                                                                                                         |
| ---                                                                                                                                                                             | ---                                                                                                                                                                                                                                             |
| [AuthenticationExtension.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Authentication/AuthenticationExtension.cs) | Configures JWT-based authentication in the eCommerce applications WebAPI service by setting up secret keys, issuer, and audience for token validation, while defining event handlers for token expiration and authentication failure scenarios. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.GlobalException</summary>

| File                                                                                                                                                                           | Summary                                                                                                                                                                                                                                    |
| ---                                                                                                                                                                            | ---                                                                                                                                                                                                                                        |
| [GlobalExceptionHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/GlobalException/GlobalExceptionHandler.cs) | Monitors and handles application-wide exceptions, ensuring structured error messages are returned in a JSON format for proper error handling across all modules within the Pacagroup Ecommerce Web API, improving overall user experience. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Versioning</summary>

| File                                                                                                                                                                  | Summary                                                                                                                                                                                                                                                           |
| ---                                                                                                                                                                   | ---                                                                                                                                                                                                                                                               |
| [VersioningExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Versioning/VersioningExtensions.cs) | Pacagroup.Ecommerce.Services.WebApi Key Functionality: Implements versioning for APIs with configurable group names and default version setting using ApiVersioning & ApiExplorer libraries, promoting flexibility in API versions and aids in API documentation. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Injection</summary>

| File                                                                                                                                                               | Summary                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                                                                                                | ---                                                                                                                                                                                                                                                                                                                       |
| [InjectionExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Injection/InjectionExtensions.cs) | The `InjectionExtensions` class enriches the dependency injection setup within the application by registering essential components. Actions: Registers the global configuration instance, a GlobalExceptionHandler, and an ICurrentUser service, scoped accordingly to maintain flexibility across application functions. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.RateLimiter</summary>

| File                                                                                                                                                                     | Summary                                                                                                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                                                  |
| [RateLimiterExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/RateLimiter/RateLimiterExtensions.cs) | Configures rate limiting for Pacagroup E-commerce web API, protecting against excessive user requests. The customizable fixed window policy is set based on specified permit limit, window size, queue processing order, and queue limit from appsettings.json, while returning a 429 Too Many Requests status code upon rejection. This measure ensures reliable system performance and fair usage. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Feature</summary>

| File                                                                                                                                                         | Summary                                                                                                                                                                                                                                                                                 |
| ---                                                                                                                                                          | ---                                                                                                                                                                                                                                                                                     |
| [FeatureExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Feature/FeatureExtensions.cs) | Configures essential services for the Ecommerce applications WebAPI module, enhancing Cross-Origin Resource Sharing (CORS) policy and JSON serialization options by allowing specified origins, headers, and methods, facilitating seamless API interaction with external applications. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.HealthCheck</summary>

| File                                                                                                                                                                     | Summary                                                                                                                                                                                                                                                                                                             |
| ---                                                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                 |
| [HealthCheckExtensions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/HealthCheck/HealthCheckExtensions.cs) | Pacagroup Ecommerce API Key Feature: HealthCheckExtensions Purpose: Integrates customizable health checks for database, cache (Redis), and custom checkpoints in the application. Provides a user interface (UI) endpoint for monitoring the health status of the system, utilizing NorthwindConnection as storage. |
| [HealthCheckCustom.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/HealthCheck/HealthCheckCustom.cs)         | This HealthCheckCustom module actively monitors the applications health within the web API services. It uses random response time simulations, returning three distinct statuses-healthy, degraded, and unhealthy, enhancing overall system resilience and responsiveness for the Ecommerce platform.               |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Modules.Swagger</summary>

| File                                                                                                                                                                     | Summary                                                                                                                                                                                                                       |
| ---                                                                                                                                                                      | ---                                                                                                                                                                                                                           |
| [SwaggerExtension.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Swagger/SwaggerExtension.cs)               | Customizes Swagger documentation for security in Pacagroups Ecommerce WebAPI, integrating JWT authorization by configuring the OpenAPI scheme and requiring authentication using Bearer" token.                               |
| [ConfigureSwaggerOptions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Modules/Swagger/ConfigureSwaggerOptions.cs) | In this file, Swagger configuration is defined for Pacagroups Ecommerce API service, providing options for integrating OpenAPI and versioning. This ensures documentation and proper interaction with different API versions. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Properties</summary>

| File                                                                                                                                                  | Summary                                                                                                                                                                                                                            |
| ---                                                                                                                                                   | ---                                                                                                                                                                                                                                |
| [launchSettings.json](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Properties/launchSettings.json) | Local, Docker, IIS Express, and WSL2. Enables auto-opening the Swagger UI upon project execution, Supports both HTTP and HTTPS connections with customized URLs, and simplifies deployment configuration across various scenarios. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Helpers</summary>

| File                                                                                                                                     | Summary                                                                                                                                                                                                                                                                                                                                                                |
| ---                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                    |
| [AppSettings.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Helpers/AppSettings.cs) | This file (`AppSettings.cs`) in the Pacagroup Ecommerce API defines sensitive application settings used for Cross-Origin Resource Sharing (CORS), encryption, and authentication (Issuer, Audience, Secret).**ProvidesEssential security configurations, such as CORS settings, encryption key, and token issuer details, enhancing APIs security and data protection. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Controllers.v1</summary>

| File                                                                                                                                                            | Summary                                                                                                                                                                                                                                                                                                                 |
| ---                                                                                                                                                             | ---                                                                                                                                                                                                                                                                                                                     |
| [CustomersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v1/CustomersController.cs) | This C# controller includes various CRUD operations for managing customer data using asynchronous and synchronous methods. It handles requests like insert, update, delete, get specific and all customers with error handling using IActionResult. The application layer interacts with the underlying business logic. |
| [UsersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v1/UsersController.cs)         | ApiVersion}/Users/Authenticate using provided UserDto. Upon successful authentication, generates a JWT token for the userId and returns it. This enhances user security in Pacagroup Ecommerce WebAPI v1 by implementing an access control system for authenticated requests.                                           |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Controllers.v3</summary>

| File                                                                                                                                                            | Summary                                                                                                                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                             | ---                                                                                                                                                                                                                                                                                                                                                                |
| [CustomersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v3/CustomersController.cs) | This controller facilitates CRUD operations for customers in the Ecommerce applications API version v3. It employs MediatR for handling commands and queries, enabling functions like creating, updating, deleting, and retrieving customer data using different query types such as GetAllCustomerQuery, GetCustomerQuery, and GetAllWithPaginationCustomerQuery. |
| [UsersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v3/UsersController.cs)         | Generates JWT access tokens for users in API version 3.0 upon receiving user credentials via HTTP POST request to the Authenticate endpoint. Implements MediatR for interaction with User-related Use Cases, leverages AppSettings and JwtSecurityTokenHandler for token creation and validation.                                                                  |

</details>

<details closed><summary>Pacagroup.Ecommerce.Services.WebApi.Controllers.v2</summary>

| File                                                                                                                                                              | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| ---                                                                                                                                                               | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [CustomersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v2/CustomersController.cs)   | Controller contains CRUD operations for Customer entity.2. Uses both synchronous (Http*) and asynchronous (Http*Async) methods for performing database actions.3. BadRequest() and Ok() responses used for handling invalid input and successful execution respectively.4. Response from _customersApplication is checked to handle success/error scenarios.5. Pagination support available for getting all customers data.6. All functions check their inputs before executing operations, returning error message or BadRequest when necessary. |
| [UsersController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v2/UsersController.cs)           | The UsersController class processes authentication requests in this file, calling appropriate business logic within the IUsersApplication interface and using JWT token generation to grant access upon successful validation. Its part of the v2 API of the Pacagroup Ecommerce services web application, enhancing secure user interactions within the larger system architecture.                                                                                                                                                              |
| [DiscountsController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v2/DiscountsController.cs)   | Manages CRUD operations for discounts within the e-commerce application via REST API calls, utilizing DTO objects to receive/send data securely and efficiently under a rate limiting policy, ensuring smooth service usage for all users.                                                                                                                                                                                                                                                                                                        |
| [CategoriesController.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Services.WebApi/Controllers/v2/CategoriesController.cs) | Manages RESTful API endpoints for fetching all categories (v2/CategoriesController). Uses versioning (APIVersion=2.0), rate limiting (fixedWindow), authorization, and Swagger annotations. Leverages Application Services for processing data, returns success or error messages upon request execution.                                                                                                                                                                                                                                         |

</details>

<details closed><summary>Pacagroup.Ecommerce.CrossSectional.Mapper</summary>

| File                                                                                                                                                                                                       | Summary                                                                                                                                                                                                                                                                                                                                                  |
| ---                                                                                                                                                                                                        | ---                                                                                                                                                                                                                                                                                                                                                      |
| [Pacagroup.Ecommerce.CrossSectional.Mapper.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Mapper/Pacagroup.Ecommerce.CrossSectional.Mapper.csproj) | This project mapper configuration streamlines data transformation within the Pacagroup Ecommerce ecosystem, utilizing AutoMapper for efficient mapping between application DTOs and domain entities to support the systems robust and scalable architecture.                                                                                             |
| [MapppingsProfile.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.CrossSectional.Mapper/MapppingsProfile.cs)                                                           | This MapppingsProfile serves as a mapper configuration in the Pacagroup Ecommerce system. It facilitates seamless translation between data transfer objects (DTOs) and domain entities by utilizing AutoMapper. This streamlines communication across different application layers, ensuring consistent and efficient data exchange within the platform. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence</summary>

| File                                                                                                                                                                         | Summary                                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                                          | ---                                                                                                                                                                                                                                                                                |
| [ConfigureServices.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/ConfigureServices.cs)                                     | Adds DapperContext, DB context, auditing interceptor, and repositories (Customers, Users, Categories, Discounts) as scoped services. Also sets up the unit of work service, ensuring smooth interactions with the database.                                                        |
| [Pacagroup.Ecommerce.Persistence.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Pacagroup.Ecommerce.Persistence.csproj) | Configures database dependencies for Pacagroups Ecommerce Application, leveraging Entity Framework Core and Dapper to handle data operations within the persistence layer of the software. Enables interaction with various interfaces defined in the parent repository structure. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Interceptor</summary>

| File                                                                                                                                                                                         | Summary                                                                                                                                                                                                                                                                                                                     |
| ---                                                                                                                                                                                          | ---                                                                                                                                                                                                                                                                                                                         |
| [AuditableEntitySaveChangesInterceptor.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Interceptor/AuditableEntitySaveChangesInterceptor.cs) | This `AuditableEntitySaveChangesInterceptor` ensures every database interaction within the application is traced by recording details such as created and modified timestamps along with usernames associated with each operation. The tracking improves auditing, troubleshooting, and enhances overall data transparency. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Migrations</summary>

| File                                                                                                                                                                                                    | Summary                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                              |
| [20240519193621_CreateInitialScheme.Designer.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Migrations/20240519193621_CreateInitialScheme.Designer.cs) | This `CreateInitialScheme` migrates the schema for the discounts table in the application database of an ecommerce project. It defines and configures the properties of Discount entities, such as name, description, percentage, status, and timestamps, ensuring data integrity and structure. |
| [ApplicationDbContextModelSnapshot.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Migrations/ApplicationDbContextModelSnapshot.cs)                     | This code snapshot automates entity configuration for the Discount table in the Ecommerce database. It establishes essential attributes like Id, Name, Description, Created & LastModified dates, and status, adhering to defined schema and constraints within the application context.         |
| [20240519193621_CreateInitialScheme.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Migrations/20240519193621_CreateInitialScheme.cs)                   | The provided code file creates an initial table called Discounts for our Pacagroup.Ecommerce application. This table includes columns for discount Name, Description, Percentage, Status, and timestamps for Created, LastModified, CreatedBy, and LastModifiedBy.                               |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Contexts</summary>

| File                                                                                                                                                    | Summary                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                                              |
| [DapperContext.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Contexts/DapperContext.cs)               | In the `Pacagroup.Ecommerce` repository, the `DapperContext.cs` file defines and configures a Dapper database context for efficient SQL queries within the persistence layer. This context is constructed using the provided application connection string for a seamless integration with data storage systems. |
| [ApplicationDbContext.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Contexts/ApplicationDbContext.cs) | Manages data persistence for the e-commerce applications discount entity. ApplicationDbContext configures Entity Framework Core database interactions, ensuring data integrity and proper table mapping. It integrates an AuditableEntitySaveChangesInterceptor to track changes in the discount records.        |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Configurations</summary>

| File                                                                                                                                                            | Summary                                                                                                                                                                                                                        |
| ---                                                                                                                                                             | ---                                                                                                                                                                                                                            |
| [DiscountConfiguration.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Configurations/DiscountConfiguration.cs) | Configures database schema for Discount entity, establishing properties such as Name, Description, and Percentage within acceptable length limits for optimal data storage, ensuring consistent and efficient data management. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Mocks</summary>

| File                                                                                                                                                                                                 | Summary                                                                                                                                                                                                                                                                                                                                                           |
| ---                                                                                                                                                                                                  | ---                                                                                                                                                                                                                                                                                                                                                               |
| [DiscountGetAllWithPaginationAsyncBogusConfig.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Mocks/DiscountGetAllWithPaginationAsyncBogusConfig.cs) | Generates mock data for discount entities to test the eCommerce applications paginated retrieval functionality. The `DiscountGetAllWithPaginationAsyncBogusConfig` class, using Bogus library, defines rule sets that randomly generate discount names, descriptions, percentages, and statuses for testing purposes in the persistence layer of the application. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Persistence.Repositories</summary>

| File                                                                                                                                                        | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| ---                                                                                                                                                         | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [CategoriesRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/CategoriesRepository.cs) | In this codebase, the `CategoriesRepository` class is responsible for persisting category data in the Pacagroup E-commerce application. Implementing the Interface `ICategoriesRepository`, it connects with Dapper to interact directly with the database through its `DapperContext`. This repository provides a method, `GetAll()`, which fetches all the categories from the database and returns them as an enumerable list, facilitating query operations for the application layer. |
| [DiscountRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/DiscountRepository.cs)     | This code defines a `DiscountRepository`, responsible for persisting discount entities within the Ecommerce applications database context (`ApplicationDbContext`). It implements CRUD operations for discount data management, including synchronous and asynchronous methods to insert, update, delete, count, retrieve single or multiple discount records with or without pagination.                                                                                                  |
| [CustomersRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/CustomersRepository.cs)   | The provided code defines CRUD operations (Create, Read, Update, Delete) for Customer objects using stored procedures in a database context. It also includes functionality for pagination and count queries to improve efficiency with large data sets. This pattern allows for seamless integration between C# and SQL stored procedures.                                                                                                                                                |
| [UnitOfWork.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/UnitOfWork.cs)                     | The UnitOfWork repository encapsulates multiple repositories (Customers, Users, Categories, Discounts) for the Pacagroup Ecommerce applications Persistence layer, ensuring efficient handling and safe storage of data in ApplicationDbContext within a transaction.                                                                                                                                                                                                                      |
| [UserRepository.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Persistence/Repositories/UserRepository.cs)             | Manages user authentication** within the Pacagroup Ecommerce application through the execution of stored procedures using Dapper, ensuring secure access to customer data.                                                                                                                                                                                                                                                                                                                 |

</details>

<details closed><summary>Pacagroup.Ecommerce.Infrastructure</summary>

| File                                                                                                                                                                                  | Summary                                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                                                   | ---                                                                                                                                                                                                                                                                                |
| [ConfigureServices.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/ConfigureServices.cs)                                           | Configures event-based messaging system in Pacagroup.Ecommerce. The file sets up RabbitMQ options and initializes MassTransit for efficient asynchronous communication across components. It streamlines integration, improving the applications flexibility and scalability.      |
| [Pacagroup.Ecommerce.Infrastructure.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/Pacagroup.Ecommerce.Infrastructure.csproj) | Empowers event-driven microservices by configuring and referencing necessary packages for Message Broker (RabbitMQ) and DI containers (MassTransit, Microsoft Extensions). This enables seamless communication among service components in the Ecommerce application architecture. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Infrastructure.EventBus</summary>

| File                                                                                                                                               | Summary                                                                                                                             |
| ---                                                                                                                                                | ---                                                                                                                                 |
| [EventBusRabbitMQ.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/EventBus/EventBusRabbitMQ.cs) | Publishes` events within the applications infrastructure layer using MassTransit, streamlining communication between microservices. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Infrastructure.EventBus.Options</summary>

| File                                                                                                                                                               | Summary                                                                                                                                                                                                                                |
| ---                                                                                                                                                                | ---                                                                                                                                                                                                                                    |
| [RabbitMqOptions.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/EventBus/Options/RabbitMqOptions.cs)           | Defines host name, virtual host, user name, and password for messaging between services within the Pacagroup Ecommerce architecture, facilitating asynchronous event handling across distributed components.                           |
| [RabbitMqOptionsSetup.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Infrastructure/EventBus/Options/RabbitMqOptionsSetup.cs) | A crucial infrastructure piece in the EventBus of Pacagroups Ecommerce application. It binds configuration options related to the messaging system, ensuring seamless communication and event-driven architecture across the platform. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.DTO</summary>

| File                                                                                                                                                                                     | Summary                                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                  |
| [CategoryDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/CategoryDto.cs)                                                         | Transforms categories for application layer usage, defining essential attributes such as ID, name, description, and image in a clear, streamlined structure to facilitate efficient communication between services and UI in the Pacagroup Ecommerce system.                                                                         |
| [Pacagroup.Ecommerce.Application.DTO.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/Pacagroup.Ecommerce.Application.DTO.csproj) | Catalogs crucial domain entities into Data Transfer Objects for efficient inter-layer communication, adhering to.NET 8 standard. This helps maintain clean architecture across the application.                                                                                                                                      |
| [DiscountDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/DiscountDto.cs)                                                         | The `DiscountDto.cs` file inside the `Pacagroup.Ecommerce/Application.DTO` folder is a Data Transfer Object (DTO) for handling discount data within the application. It contains properties to represent discount Id, name, description, percentage value, and status, fostering seamless communication between services and the UI. |
| [UserDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/UserDto.cs)                                                                 | The provided UserDto file encapsulates user data model within the Pacagroup E-commerce application, including unique identifiers, first name, last name, user name, password, and token for secure authentication purposes.                                                                                                          |
| [CustomerDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/CustomerDto.cs)                                                         | The `CustomerDto.cs` file defines data transfer objects (DTOs) for handling customer information in the application tier of the Pacagroup Ecommerce system. These DTOs provide a simplified, consistent format to transmit customer-related data between layers, enhancing overall data integrity and usability.                     |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.DTO.Enums</summary>

| File                                                                                                                                               | Summary                                                                                        |
| ---                                                                                                                                                | ---                                                                                            |
| [DiscountStatusDto.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.DTO/Enums/DiscountStatusDto.cs) | Inactive` and `Active`, providing a simple yet powerful method to toggle between these states. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main</summary>

| File                                                                                                                                                                                                | Summary                                                                                                                                                                                                                                                                   |
| ---                                                                                                                                                                                                 | ---                                                                                                                                                                                                                                                                       |
| [ConfigureServices.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/ConfigureServices.cs)                                                       | Categories, Customers, Discounts, Users, registering validators, MediatR, AutoMapper and log/validation behaviors across assemblies. Central hub for managing applications service dependency tree and facilitates smooth execution of use cases within Ecommerce system. |
| [Pacagroup.Ecommerce.Application.UseCases.csproj](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Pacagroup.Ecommerce.Application.UseCases.csproj) | MediatR, AutoMapper, FluentValidation, StackExchangeRedis **Implements:** Core use-cases of the Pacagroup Ecommerce application by orchestrating domain services and integrating them with the DTO, Interface, and Domain layers.                                         |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Categories</summary>

| File                                                                                                                                                             | Summary                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                                              | ---                                                                                                                                                                                                                                                                                                                             |
| [CategoriesApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Categories/CategoriesApplication.cs) | Streamlines data retrieval of category items within the Pacagroup Ecommerce application. The `CategoriesApplication.cs` file is a crucial component, responsible for caching and handling requests for all categories. By utilizing distributed cache, it ensures efficient retrieval and reduces the load on database queries. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers</summary>

| File                                                                                                                                                          | Summary                                                                                                                                                                                                                                                                                                                                                                                        |
| ---                                                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                                                                                            |
| [CustomersApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/CustomersApplication.cs) | This controller performs CRUD operations on customers using Entity Framework and AutoMapper, with logging provided by Microsofts ILogger. The operations are executed synchronously (for deleting, getting, inserting, updating) or asynchronously (for retrieving all customers with pagination). A Response object is used for return values, enabling the easy handling of data and errors. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Queries.GetCustomerQuery</summary>

| File                                                                                                                                                                               | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                                                | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [GetCustomerQuery.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetCustomerQuery/GetCustomerQuery.cs)     | Empowers customer query by creating a GET Customer Query for retrieving a specific Customer record, based on CustomerId. Its part of the Pacagroup.Ecommerce.Application.Main application within the Queries' and Customers namespaces. This query utilizes MediatR and the common response object from Pacagroup.Ecommerce.CrossSectional.Common for seamless communication.                                                                                                      |
| [GetCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetCustomerQuery/GetCustomerHandler.cs) | This code handler streamlines customer data retrieval by implementing `GetCustomerHandler`, an integral part of the MediatR query-handling pipeline within the Customers domain. Using AutoMapper and Dependency Injection, it fetches specific customer details from the Persistence layer, maps the data to the CustomerDTO model, and returns the formatted response. The aim is to enhance customer experience by ensuring efficient, reliable retrieval of user-related data. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Queries.GetAllCustomerQuery</summary>

| File                                                                                                                                                                                        | Summary                                                                                                                                                                                                                                                                                                                               |
| ---                                                                                                                                                                                         | ---                                                                                                                                                                                                                                                                                                                                   |
| [GetAllCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetAllCustomerQuery/GetAllCustomerHandler.cs) | Handles queries for retrieving all customer details by mapping data from the database using AutoMapper and MediatR in the Pacagroup.Ecommerce applications Customer Use Case. The GetAllCustomerHandler class interacts with the IUnitOfWork service, ensuring consistent, transactional data access within the Persistence layer.    |
| [GetAllCustomerQuery.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetAllCustomerQuery/GetAllCustomerQuery.cs)     | GetAllCustomerQuery.cs within Pacagroups main application. The MediatR pattern facilitates an efficient asynchronous query to retrieve a collection of CustomerDto objects from the Customer domain. This interaction enhances the usability and adaptability of the customer management module in the Pacagroup e-commerce platform. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Queries.GetAllWithPaginationCustomerQuery</summary>

| File                                                                                                                                                                                                                                  | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| ---                                                                                                                                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [GetAllWithPaginationCustomerQuery.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetAllWithPaginationCustomerQuery/GetAllWithPaginationCustomerQuery.cs)     | This file contains a type-safe request (`GetAllWithPaginationCustomerQuery`) within the MediatR pattern to fetch paginated customer data in the Ecommerce application. The query takes parameters for page number and size and returns a collection of `CustomerDto` objects wrapped in a `ResponsePagination<IEnumerable<CustomerDto>>`. This enhances flexibility for handling customer queries effectively, aligning with overall project architecture. |
| [GetAllWithPaginationCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Queries/GetAllWithPaginationCustomerQuery/GetAllWithPaginationCustomerHandler.cs) | Manages customer data retrieval with pagination for eCommerce application. Implemented as a `Handle` method within the MediatR pattern using AutoMapper and database unit-of-work for interaction. This feature ensures efficient retrieval and handling of large datasets while maintaining clear response structure.                                                                                                                                     |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Commands.DeleteCustomerCommand</summary>

| File                                                                                                                                                                                           | Summary                                                                                                                                                                                                                                                                                                                                                                                                    |
| ---                                                                                                                                                                                            | ---                                                                                                                                                                                                                                                                                                                                                                                                        |
| [DeleteCustomerCommand.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/DeleteCustomerCommand/DeleteCustomerCommand.cs) | In the Pacagroup Ecommerce application repository, this file represents a command for deleting customers. The `DeleteCustomerCommand` class, found under the Customers module in UseCases, utilizes the MediatR library to handle and process customer deletion requests. By implementing this command, the application provides an interface to remove specified customers within its database structure. |
| [DeleteCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/DeleteCustomerCommand/DeleteCustomerHandler.cs) | Deletes customer records in the Pacagroup Ecommerce application by handling DeleteCustomerCommand. Uses UnitOfWork and AutoMapper to interact with database and map request data respectively, returning a Response<bool> indicating successful deletion.                                                                                                                                                  |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Commands.CreateCustomerCommand</summary>

| File                                                                                                                                                                                               | Summary                                                                                                                                                                                                                                                                                                                                      |
| ---                                                                                                                                                                                                | ---                                                                                                                                                                                                                                                                                                                                          |
| [CreateCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/CreateCustomerCommand/CreateCustomerHandler.cs)     | Manages customer registration within the Pacagroup Ecommerce Application. This handler leverages MediatR for command processing, AutoMapper for mapping data objects, and the applications Persistence layer (UnitOfWork) to insert new customer records in the database, ensuring seamless data flow.                                       |
| [CreateCustomerCommand.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/CreateCustomerCommand/CreateCustomerCommand.cs)     | Creates command for user input to register new customer, structuring data required with properties such as CustomerId, CompanyName, ContactName, Address, City, Region, PostalCode, Country, Phone, and Fax. Aligns with MediatR pattern to facilitate handling commands within the Customers module in the Pacagroup Ecommerce Application. |
| [CreateCustomerValidator.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/CreateCustomerCommand/CreateCustomerValidator.cs) | Validates input data for new customer creation within Pacagroup Ecommerces Customers use case. Ensures the `CustomerId` meets requirements such as non-emptiness, non-null status and a minimum length of five characters. Part of the application layer enforcing consistent and validated data structure for optimal functionality.        |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Customers.Commands.UpdateCustomerCommand</summary>

| File                                                                                                                                                                                           | Summary                                                                                                                                                                                                                                                                                                                                                  |
| ---                                                                                                                                                                                            | ---                                                                                                                                                                                                                                                                                                                                                      |
| [UpdateCustomerHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/UpdateCustomerCommand/UpdateCustomerHandler.cs) | This command-handler updates customer data within the applications use case layer by receiving an update request, mapping it to a Customer entity, and persisting the updated information using the specified UnitOfWork. The Response object is then generated with the result, signaling the successful update upon a true response value.             |
| [UpdateCustomerCommand.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Customers/Commands/UpdateCustomerCommand/UpdateCustomerCommand.cs) | This command, within the Pacagroup Ecommerce application, triggers the process to modify essential attributes like company name, contact name, title, address, city, region, postal code, country, phone, and fax for a specific customer. Its part of MediatR-powered workflows under Customers module, driving efficient updates using a CQRS pattern. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Users</summary>

| File                                                                                                                                              | Summary                                                                                                                                                                                                                                                                                     |
| ---                                                                                                                                               | ---                                                                                                                                                                                                                                                                                         |
| [UsersApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Users/UsersApplication.cs) | Manages user authentication within the Pacagroup E-commerce application by validating provided usernames and passwords, utilizing UserDTO objects, IUnitOfWork for database operations, and AutoMapper for object mapping, ensuring successful login or informing about non-existent users. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Users.Commands.CreateUserTokenCommand</summary>

| File                                                                                                                                                                                              | Summary                                                                                                                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                                                               | ---                                                                                                                                                                                                                                                                                                                                                                                                              |
| [CreateUserTokenValidator.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Users/Commands/CreateUserTokenCommand/CreateUserTokenValidator.cs) | Validates user authentication in this Ecommerce applications microservice, ensuring usernames are non-empty and passwords are at least five characters long when creating user tokens. By utilizing the FluentValidation library, the code maintains robust validation rules for user input. This reinforces strong security practices within our system architecture.                                           |
| [CreateUserTokenCommand.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Users/Commands/CreateUserTokenCommand/CreateUserTokenCommand.cs)     | Generates** user authentication tokens for newly registered users using MediatR and data transfer objects (DTOs) in the core application layer. The `CreateUserTokenCommand` command defines required properties, ensuring secure access to user accounts within the e-commerce platform.                                                                                                                        |
| [CreateUserTokenHandler.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Users/Commands/CreateUserTokenCommand/CreateUserTokenHandler.cs)     | Generates authentication tokens for registered users. Implemented within the Users module using MediatR and AutoMapper in the main application layer, it maps User entities to DTOs, authenticates provided credentials against existing user records, and returns success or error responses with tokenized data. Integrated with repository and unit of work interfaces to ensure proper persistence handling. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Common.Behaviours</summary>

| File                                                                                                                                                                  | Summary                                                                                                                                                                                                                                                    |
| ---                                                                                                                                                                   | ---                                                                                                                                                                                                                                                        |
| [LoggingBehaviour.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Behaviours/LoggingBehaviour.cs)         | Monitors and logs request-response interactions for the Pacagroup Ecommerce applications use cases, enhancing the overall traceability and auditability by providing detailed logs in clean architecture manner using MediatR and Microsoft logging tools. |
| [ValidationBehaviour.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Behaviours/ValidationBehaviour.cs)   | Validates inputs for use cases in Ecommerce application, ensuring data integrity and preventing errors during request processing. Utilizes FluentValidation and MediatR, catching validation exceptions with custom error messaging if necessary.          |
| [PerformanceBehaviour.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Behaviours/PerformanceBehaviour.cs) | Monitors performance of MediatR-powered commands across the application by measuring their execution times and logging slow-running ones to support optimizations in this eCommerce solution.                                                              |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Common.Constants</summary>

| File                                                                                                                                                     | Summary                                                                                                                                                                           |
| ---                                                                                                                                                      | ---                                                                                                                                                                               |
| [GlobalConstant.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Constants/GlobalConstant.cs) | GlobalConstant establishes the default system user ID (1) and username (System), enabling uniform identification across various Pacagroup Ecommerces application functionalities. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Common.Exceptions</summary>

| File                                                                                                                                                                            | Summary                                                                                                                                                                                                                                                                                               |
| ---                                                                                                                                                                             | ---                                                                                                                                                                                                                                                                                                   |
| [ValidationExceptionCustom.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Exceptions/ValidationExceptionCustom.cs) | Customizes application-level exceptions for validation failures, enhancing error reporting consistency across the Ecommerce platforms use cases by leveraging a predefined base error class. This fosters structured and easier-to-understand error handling throughout the application architecture. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Common.Mappings</summary>

| File                                                                                                                                                        | Summary                                                                                                                                                                                                                                                                                             |
| ---                                                                                                                                                         | ---                                                                                                                                                                                                                                                                                                 |
| [MapppingsProfile.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Common/Mappings/MapppingsProfile.cs) | This Mapping Profile utilizes AutoMapper for seamless conversion between application DTOs (Data Transfer Objects) and domain Entities across Customer, User, Category, and Discount use cases. Additionally, it maps event objects related to discount creation in Pacagroup Ecommerce Application. |

</details>

<details closed><summary>Pacagroup.Ecommerce.Application.Main.Discounts</summary>

| File                                                                                                                                                          | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| ---                                                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [DiscountsApplication.cs](https://github.com/juansdev/Pacagroup.Ecommerce/blob/master/Pacagroup.Ecommerce.Application.Main/Discounts/DiscountsApplication.cs) | Functional API for handling Discount operations is presented, utilizing an EventBus to disseminate events post-registration. The methods `InsertAsync`, `Delete`, `Get`, `GetAll`, and `Update` facilitate creating, deleting, retrieving individual, and all discount data. A paginated version of the latter is also offered in the form of `GetAllWithPagination`. All actions are executed within a UnitOfWork for consistent data manipulation. The event bus disseminates a custom `DiscountCreatedEvent` following a new registration. |

</details>

---

##  Getting Started

**System Requirements:**

* **CSharp**: `version 11`
* **.NET**: `version 7`

###  Installation

<h4>From <code>source</code></h4>

> 1. Clone the Pacagroup.Ecommerce repository:
>
> ```console
> $ git clone https://github.com/juansdev/Pacagroup.Ecommerce
> ```
>
> 2. Change to the project directory:
> ```console
> $ cd Pacagroup.Ecommerce
> ```
>
> 3. Install the dependencies:
> ```console
> $ dotnet build
> ```
>
> 4. Edit the connection to your Microsoft SQL Server database in the "NorthwindConnection" key located in the Service/Web.API/appsettings.Development.json file.
>
> 5. Activate the Microsoft SQL Server.
>
> 6. Edit the connection to your Redis server in the "RedisConnection" key located in the Service/Web.API/appsettings.Development.json file.
>
> 7. Activate the Redis server.
>
> 8. Run the migrations using the command "update-database"

###  Usage

<h4>From <code>source</code></h4>

> Deploy the project using the HTTPS launch profile.

###  Tests

> Run the test suite using the command below:
> ```console
> $ dotnet test
> ```

---
