# Application Manager API

## Overview

The Application Manager API is a backend service designed to manage applications submitted by users. It provides endpoints to retrieve application data based on job control values and manage application data within a database.

## Features

- **Retrieve Applications**: Get application details based on job control values.
- **Manage Applications**: CRUD operations for managing application data.

## Technologies Used

- **Programming Languages**: C#, Python
- **Frameworks**: ASP.NET Core, Entity Framework Core
- **Database**: SQL Server
- **Tools**: Visual Studio, Python 3

## Getting Started

To run the Application Manager API locally, follow these steps:

1. **Clone the repository**:

2. **Set up the Database**:
- Ensure you have SQL Server installed.
- Update the `appsettings.json` with your database connection string.

3. **Run the API**:
- Open the solution in Visual Studio.
- Build and run the project.

4. **Access API Endpoints**:
- Use tools like Postman or curl to interact with the API endpoints.

## API Endpoints

- `GET /api/applications/{jobControl}`: Retrieve applications by job control value.
- Other endpoints as per your application requirements.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your proposed changes.
