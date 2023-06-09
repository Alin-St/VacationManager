# VacationManager

This application is used for managing vacation destinations for employees in a company.

## File structure

The main project is located in the folder "VacationDestinationManager" (containing the .sln file). This is a C# Windows Forms Application project built with Visual Studio.

The final build for the client is in the folder "Release - Vacation Destination Manager" (containing the .exe file). You can find the user manual in the same folder.

There folder "pictures" contains some sample pictures that can be used for demonstration purposes.

## Project structure

The project is divided into layers:

1. The Domain layer contains the domain objects and some utility methods.
2. The Repository layer contains the repositories used to save the data.
3. The Service layer contains services that provide access to the repositories, along with the required bussiness logic.
4. The UI layer containins the UI Forms.

Other files / folders that are not part of a specific layer:

* The Utility folder for various general-purpose functions / classes.
* The Program class contains the main entry point of the application.
* The ApplicationManager class contains the logic required to create the repositories and services. It also contins some methods for adding sample data used for testing.
