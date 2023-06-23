# SelfImprovementStore-API

The SelfImprovementStore-API is a GraphQL API built using .NET Core. This API powers the backend of the Self Improvement Store, an online web shop that sells items aimed at helping people to improve themselves, like books on self-improvement, t-shirts with positive messages, and workout equipment.

## Features

- User Registration and Authentication
- Product Browsing and Management
- Order Management
- Shopping Cart Functionality
- Secure Payment Processing (coming soon)

## Technologies Used

- .NET Core
- ASP.NET Core Identity for Authentication
- Entity Framework Core with PostgreSQL for Data Access
- GraphQL for API Structure

## Getting Started

### Prerequisites

- .NET Core 3.1 or higher
- PostgreSQL 12 or higher

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/SelfImprovementStore-API.git
    ```

2. Navigate into the project directory and install the dependencies:

    ```bash
    cd SelfImprovementStore-API
    dotnet restore
    ```

3. Update the `appsettings.json` file with your PostgreSQL server details.

4. Run the migrations to create the database schema:

    ```bash
    dotnet ef database update
    ```

5. Run the project:

    ```bash
    dotnet run
    ```

## Testing

This project uses xUnit for testing. To run the tests, use the following command:

```bash
dotnet test
