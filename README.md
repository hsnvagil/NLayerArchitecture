# NLayer Architecture Project

This repository contains an implementation of a multi-layered (NLayer) architecture built using ASP.NET Core. The architecture follows the separation of concerns principle, splitting the project into distinct layers for handling different concerns such as data access, business logic, and API presentation.

## Project Structure

The project is divided into the following layers:

1. **API Layer (Presentation Layer)**: Handles HTTP requests and responses. It serves as the entry point for the application, exposing RESTful endpoints and interacting with the application layer to process requests and return results.

2. **Business Layer (Application Layer)**: Contains the business logic and validation rules of the application. It coordinates interactions between the API layer and the data access layer.

3. **Data Access Layer (Persistence Layer)**: Manages data storage and retrieval using Entity Framework Core. It contains repositories that interact with the database and ensure data persistence.

## Features

- Clean architecture with clearly defined layers.
- Implementation of Entity Framework Core for data persistence.
- Dependency injection using constructor injection.
- AutoMapper integration for object mapping.
- FluentValidation for input validation.
- ASP.NET Core Web API for exposing RESTful endpoints.
- Repository and Unit of Work patterns for data access.

## Technologies Used

- **.NET 8**
- **Entity Framework Core**
- **AutoMapper**
- **FluentValidation**
- **SQL Server**
- **Dependency Injection**
- **Swagger UI** (for API documentation)

## Getting Started

### Prerequisites

Before running the project, ensure you have the following installed:

- [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/hsnvagil/NLayerArchitecture.git
   ```

2. Navigate to the project folder:

   ```bash
   cd NLayerArchitecture
   ```

3. Set up the database by updating the connection string in the `appsettings.Development.json` file of the API layer:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DB;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
   }
   ```

4. Run database migrations to set up the database:

   ```bash
   dotnet ef database update --project App.Repositories
   ```

5. Start the API project:

   ```bash
   dotnet run --project App.API
   ```

6. Visit `https://localhost:7229/swagger` to explore the API using Swagger UI.
