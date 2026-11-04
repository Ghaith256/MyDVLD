# DVLD: Driving and Vehicle License Department

DVLD is a Windows Forms desktop application that manages the work of a driving license department. It handles people, users, license applications, driving tests, and license classes. The project is written in C# on .NET 8 and stores its data in SQL Server.

## What the Application Does

- Manage people (add, update, search, show details, delete).
    
- Manage system users with login and password change.
    
- Manage application types and their fees.
    
- Create local driving license applications for a person.
    
- Schedule vision, written, and street tests for an application.
    
- Record test results (Pass or Fail).
    
- Manage license classes and test types.
    

## Technologies Used

- C# and .NET 8
    
- Windows Forms for the user interface
    
- SQL Server for the database
    
- ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataReader`) to communicate with the database.
    
- SunnyUI and FontAwesome.Sharp for some controls and icons.
    
- BCrypt.Net for hashing user passwords.
    
- xUnit for unit testing.
    

## Project Structure

The solution file is called `MyDVLD.sln`. It contains five projects, and each project has its own folder inside the solution folder.

|Project|Purpose|
|---|---|
|`DVLD_DTOs`|Simple classes that carry data between the layers.|
|`DVLD_DataAccess`|Runs SQL queries and communicates with the database.|
|`DVLD_Business`|Holds business rules and the objects used by the forms.|
|`DVLD_Presentation`|Contains the Windows Forms screens and user controls.|
|`DVLD_Test`|Contains unit tests for the Business layer.|

### DVLD_DTOs

This project contains the DTO classes. A DTO is a plain class with properties and no business logic.

Examples include:

- `PersonDTO`
    
- `UserDTO`
    
- `ApplicationDTO`
    
- `LicenseClassDTO`
    
- `TestAppointmentDTO`
    
- `TestDTO`
    

### DVLD_DataAccess

This project contains the classes whose names start with `cls` and end with `DataAccess`, for example:

- `clsPersonDataAccess`
    
- `clsUserDataAccess`
    

Each method in these classes opens a database connection, executes an SQL command, and returns the result.

This is the only project responsible for writing and executing SQL queries.

The class `clsDataAccessSettings` stores the connection string to the database. If your SQL Server name is different, change it there.

### DVLD_Business

This project contains the classes whose names start with `cls` and do not end with `DataAccess`, for example:

- `clsPersonBusiness`
    
- `clsApplicationBusiness`
    

Each class has a `Save()` method that decides whether to add a new record or update an existing one.

The forms communicate with these classes and never call the DataAccess classes directly.

### DVLD_Presentation

This project contains the forms that the user interacts with.

Forms are grouped by feature. The main folders are for:

- People
    
- Users
    
- Application Types
    
- Local Driving License Applications
    
- Tests
    
- Test Types
    
- Licenses
    
- Detained Licenses
    
- User Controls
    

Each form has two files:

- `.cs` — Contains the form's code.
    
- `.Designer.cs` — Contains the automatically generated designer code.
    

The designer file is created by Visual Studio, so you should not edit it manually.

The class `clsGlobal` stores the currently logged-in user in the property `CurrentUser`.

The startup project is `DVLD_Presentation`. The `Program.cs` file opens `Form1`, which is the main window containing buttons for accessing different parts of the system.

### DVLD_Test

This project contains the unit tests.

Each test class is named after the Business class it tests, for example:

- `clsPersonBusinessTests`
    
- `clsApplicationBusinessTests`
    
- `clsUserBusinessTests`
    

The tests create real records in the database and delete them when they finish.

## How the Four Tiers Work Together

The application is divided into four layers. Each layer has its own responsibility.

1. **Presentation:** The user interacts with the application by clicking buttons or entering information.
    
2. **Business:** Business rules are checked. For example, a person cannot have two active applications for the same license class.
    
3. **DataAccess:** SQL queries are executed against the database.
    
4. **Database:** SQL Server stores the application data in tables.
    

A typical data flow looks like this:

```
Form (Presentation)
       |
       v
Business Class
       |
       v
DataAccess Class
       |
       v
SQL Server Database

DTO objects carry data between the layers.
```

The DTO project is used by the layers to transfer data in a consistent structure.

## Requirements

- Windows 10 or Windows 11.
    
- Visual Studio 2022 with the **.NET desktop development** workload.
    
- .NET 8 SDK (usually installed with Visual Studio).
    
- SQL Server (Express or Developer edition is sufficient).
    
- SQL Server Management Studio (SSMS) to create and manage the database.
    

## Database Setup

1. Open SQL Server Management Studio and connect to your local SQL Server instance.
    
2. Create a new database named `DVLD`.
    
3. Create the tables used by the project. The main tables are:
    
    - `People`
        
    - `Users`
        
    - `Countries`
        
    - `ApplicationTypes`
        
    - `Applications`
        
    - `LicenseClasses`
        
    - `LocalDrivingLicenseApplications`
        
    - `TestTypes`
        
    - `TestAppointments`
        
    - `Tests`
        
    - `Drivers`
        
    - `Licenses`
        
    - `InternationalLicenses`
        
    - `DetainedLicenses`
        
4. Make sure the column names match the names used in the SQL queries inside `DVLD_DataAccess`.
    
    For example:
    
    - The `Users` table uses the column `UserName`.
        
    - The `Password` column must be long enough to store a BCrypt hash, which is approximately 60 characters.
        
5. Make sure the `Countries` table contains data because the people forms load their country list from it.
    

## Connection String

The connection string is located in the `clsDataAccessSettings` class inside the `DVLD_DataAccess` project.

The default connection string is:

```
Server=.;Database=DVLD;Integrated Security=True;TrustServerCertificate=True;
```

- `Server=.` means the SQL Server instance installed on your local computer.
    
- If your SQL Server instance has a different name, replace the dot with that name.
    

For example:

```
Server=DESKTOP-ABC123;Database=DVLD;Integrated Security=True;TrustServerCertificate=True;
```

## How to Run the Application

1. Open the `MyDVLD` folder.
    
2. Open `MyDVLD.sln` using Visual Studio.
    
3. Wait until Visual Studio restores the required NuGet packages. This usually happens automatically.
    
4. In Solution Explorer, right-click on `DVLD_Presentation` and choose **Set as Startup Project**.
    
5. Select **Build**, then **Rebuild Solution**, to make sure everything compiles successfully.
    
6. Press **F5** or click the green **Start** button to run the application.
    
7. The main window will open. Use its buttons to access the login form and other application screens.
    

## How to Run the Tests

There are two ways to run the tests.

### Option 1: Test Explorer in Visual Studio

1. Open the **Test** menu.
    
2. Select **Test Explorer**.
    
3. Click **Run All Tests**.
    
4. Green ticks indicate successful tests, while red crosses indicate failed tests.
    
5. Click any failed test to view its error message.
    

### Option 2: Terminal

1. Open the `MyDVLD` folder in a terminal. For example, type `cmd` in the folder's address bar and press Enter.
    
2. Execute the following command:
    

```
dotnet test
```

The output shows the total number of tests, including how many passed and how many failed.

**Important:** The tests use the same `DVLD` database as the application. Each test creates temporary records, such as people, users, or applications, and deletes them when finished.

If a test fails before its cleanup code runs, some temporary records may remain in the database.

You can remove these records using SQL queries in SQL Server Management Studio, or use a separate copy of the database for testing.

## Common Problems

|Problem|What to Check|
|---|---|
|The application cannot connect to the database.|Check the server name in `clsDataAccessSettings` and make sure SQL Server is running.|
|A form shows an error but no details.|Open Event Viewer, navigate to Windows Logs → Application, and look for errors with the source `DVLD_App`.|
|A save operation fails with a message about a username.|Check the length of the `Password` column in the `Users` table.|
|A list shows old data.|Close the form and open it again because the list is loaded when the form opens.|
|The build shows errors after a fresh download.|Make sure the NuGet packages are restored, then use **Rebuild Solution**.|

## Notes for Developers

- Keep all SQL queries inside `DVLD_DataAccess`.
    
- Keep all business rules inside `DVLD_Business`.
    
- Forms should communicate with Business classes and should never call DataAccess classes directly.
    
- Passwords must never be stored as plain text. They are hashed using BCrypt before being saved to the database.
