# QueueAPIDockerCompose

QueueAPIDockerCompose is a project that sets up a backend API with Docker Compose, connecting to SQL Server. It involves creating and configuring several databases required for the application to function properly.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Database Setup](#database-setup)
- [Configuration](#configuration)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Prerequisites

Before you begin, ensure you have the following installed and running:

- [Docker Desktop](https://www.docker.com/products/docker-desktop)
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/QueueAPIDockerCompose.git
   cd QueueAPIDockerCompose

2. Ensure Docker Desktop is running on your machine.

## Database Setup

You will need to create four empty databases: `QueueDb`, `CarDb`, `CronJobManagerDb`, and `ASPNETDb` in your SQL Server instance.

1. Open SQL Server Management Studio (SSMS) or use the `sqlcmd` command line.
2. Run the following SQL commands to create the databases:

   ```sql
   CREATE DATABASE QueueDb;
   CREATE DATABASE CarDb;
   CREATE DATABASE CronJobManagerDb;
   CREATE DATABASE ASPNETDb;


## Configuration

1. Update the connection strings in the `appsettings.json` file located in the root of the project.

2. Replace `localhost` with the name of your actual SQL Server instance:

   ```json
   {
     "ConnectionStrings": {
       "QueueDb": "Server=YOUR_SQL_SERVER_NAME;Database=QueueDb;Trusted_Connection=True;",
       "CarDb": "Server=YOUR_SQL_SERVER_NAME;Database=CarDb;Trusted_Connection=True;",
       "CronJobManagerDb": "Server=YOUR_SQL_SERVER_NAME;Database=CronJobManagerDb;Trusted_Connection=True;",
       "ASPNETDb": "Server=YOUR_SQL_SERVER_NAME;Database=ASPNETDb;Trusted_Connection=True;"
     }
   }
3. Save the changes to the `appsettings.json` file.

The API will be available at `http://localhost:5000`.

Ensure that Docker Desktop is running before executing the application.

## Contributing

If you'd like to contribute to this project, please fork the repository and use a feature branch. Pull requests are warmly welcome.
## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
