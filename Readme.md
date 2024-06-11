# Exam .net project skeleton

This is a skeleton project for the exam in the course .net. The project is a simple web application that uses a database to store and display data. The project is built using ASP.NET Core and Entity Framework Core.

## Project Structure

The project has the following entities that must be implemented(delete the one that is not fitting for your project):
- One ( that represents an entity that can be stored in the database)
- Many ( that represents an entity that can be stored in the database and that is in a one-to-many relationship with the One entity)
- User ( that represents a user that can log in to the application)

The project has the following controllers that must be implemented(delete the one that is not fitting for your project):
- OneController ( that is responsible for handling requests related to the One entity)
- ManyController ( that is responsible for handling requests related to the Many entity)
- UserController ( that is responsible for handling requests related to the User entity)

## Authentication
Authentication is not implemented in the project. You can implement it using the built-in authentication system in ASP.NET Core or just store the user's username and password or id in a global variable.

# Creating and Running Migrations in .NET EF

To create and run migrations in .NET EF, follow these steps:

1. Open your command prompt or terminal.
2. Navigate to the root directory of your .NET project.
3. Run the following command to create a new migration:

    ```
    dotnet ef migrations add <MigrationName>
    ```

    Replace `<MigrationName>` with a descriptive name for your migration.

4. After running the command, EF will generate a new migration file in your project's migration folder. This file contains the necessary code to update your database schema.

5. To apply the migration and update the database, run the following command:

    ```
    dotnet ef database update
    ```

    This command will execute the migration and apply the changes to your database.

That's it! You have successfully created and run a migration using .NET EF.


# ExamFE - Angular

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 18.0.3.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.
