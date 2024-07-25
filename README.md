# Book E-commerce Management System

Welcome to the Book E-commerce Management System project! This README file will guide you through the structure, setup, and usage of the project. This application is developed using ASP.NET Core MVC and Entity Framework Core, providing a robust platform for managing book-related e-commerce operations.

## Project Overview

The Book E-commerce Management System is a comprehensive web application that includes the following key features:

- **User Authentication and Authorization**
- **Product Management (Books, Authors, Categories)**
- **Shopping Cart and Checkout Functionality**
- **Order Processing and Tracking**
- **Responsive Design with Bootstrap v5**
- **Filter Options**

## Features

### CRUD Operations
- Implement CRUD operations using Entity Framework for managing books, authors, and categories.

### User Authentication
- Integrate Identity Framework for user login and registration.
- Implement role-based authorization for different user roles.

### Shopping Cart and Orders
- Develop a shopping cart feature allowing users to add, update, and remove books.
- Implement checkout process and order tracking.
- Integrate Stripe payment gateway for seamless transactions.

### User Interface
- Design a responsive and user-friendly interface using Bootstrap v5.
- Implement custom tag helpers and view components for better UI management.

### Filter
- Filter functionalities to easily find orders.

### Reviews and Ratings
- Allow users to leave reviews and ratings for books.

## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET 8 SDK
- SQL Server Management Studio

### Installation

1. **Clone the repository**
   ```sh
   git clone https://github.com/krispyarena/book-hub.git
   cd book-hub
   ```

2. **Setup the Database**
   - Update the connection string in `appsettings.json` with your SQL Server instance.
   - Apply migrations to create the database schema.
     ```sh
     dotnet ef database update
     ```

3. **Run the Application**
   - Open the solution in Visual Studio.
   - Build the solution to restore dependencies.
   - Run the application.

### Usage

- Navigate to the application URL in your browser.
- Register a new user or login with existing credentials.
- Explore the various features such as adding books, managing categories, shopping cart, and placing orders.

## Deployment

### Deploying to Azure
- Follow the official [Microsoft Azure documentation](https://docs.microsoft.com/en-us/azure/app-service/quickstart-dotnetcore) to deploy the application to Azure.

### Deploying to IIS
- Follow the official [Microsoft IIS documentation](https://docs.microsoft.com/en-us/iis/publish/using-web-deploy/introduction-to-web-deploy) to deploy the application to IIS.

## Contributing

If you would like to contribute to this project, please fork the repository and create a pull request. We welcome all contributions that improve the project.

## Extra Resources

- **Link to Presentation** : [Project Presentation](https://docs.google.com/presentation/d/1In2ANDOU2W5o7ElWG1f_DY37xjNNG4iU/edit?usp=sharing&ouid=112179910766979724441&rtpof=true&sd=true)
- **Link to Report** : [Project Report](https://drive.google.com/file/d/1kWqqwgDkkwyKyNgX4NhkyF5lpr-WuHxv/view?usp=sharing)

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any inquiries or feedback, please contact at krispyarena@gmail.com or create an issue on this repository.
