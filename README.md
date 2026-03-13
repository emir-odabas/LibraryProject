# LibraryProject 📚

A modern, clean architecture based Library Management System Web API. This project was recently upgraded to **.NET 9.0** and migrated to **PostgreSQL** for improved performance and scalability.

## 🚀 Features

- **Book Management**: Track inventory and details.
- **Member Tracking**: Manage students and writers.
- **Transaction Management**: Process borrowing and returning operations.
- **Security**: JWT-based authentication and role-based authorization.
- **Architecture**: N-Tier Architecture (Core, DataAccess, Business, Entities, WebAPI).

## 🛠 Tech Stack

- **Framework**: .NET 9.0 (C#)
- **Database**: PostgreSQL (Npgsql)
- **ORM**: Entity Framework Core
- **DI Container**: Autofac
- **Validation**: FluentValidation
- **Documentation**: Swagger/OpenAPI

## ⚙️ Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [PostgreSQL](https://www.postgresql.org/download/) (Service should be running on port 5432)

## 🔧 Setup & Installation

1. **Database Configuration**:
   The project uses a default PostgreSQL configuration in `LibraryContext.cs`:
   - **Host**: `localhost`
   - **Port**: `5432`
   - **Database**: `postgres`
   - **Username**: `postgres`
   - **Password**: `postgres`

2. **Automatic Schema Creation**:
   The application is configured to automatically create the required database schema upon the first successful run. No manual SQL migrations are needed for the initial setup.

3. **HTTPS Certificate** (Recommended):
   If you encounter certificate errors, run:
   ```powershell
   dotnet dev-certs https --trust
   ```

## 🏃 Running the Application

To start the Web API, navigate to the root directory and run:

```powershell
dotnet run --project WebAPI/WebAPI.csproj
```

The server will be available at:
- **API Base**: `http://localhost:5000`
- **Swagger UI**: `http://localhost:5000/swagger`

## 🧪 Testing the API

Once the application is running, you can test the health of the connection by visiting:
[http://localhost:5000/api/books/getall](http://localhost:5000/api/books/getall)
