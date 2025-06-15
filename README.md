# .NET 6 HRIS (Human Resource Information System)

![.NET Version](https://img.shields.io/badge/.NET-6.0-blueviolet?style=for-the-badge&logo=.net)
![Bootstrap 5](https://img.shields.io/badge/Bootstrap-5-purple?style=for-the-badge&logo=bootstrap)
![jQuery](https.img.shields.io/badge/jQuery-3.6-blue?style=for-the-badge&logo=jquery)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

A modern Human Resource Information System (HRIS) web application built using the MVC architecture with .NET 6. This application is designed to streamline and automate human resource management tasks.

## 📖 About The Project

This HRIS aims to be a centralized platform for the HR department to efficiently manage employee data, attendance, leave requests, payroll, and other HR processes. With a responsive interface powered by Bootstrap 5 and enhanced interactivity from jQuery, this application delivers an intuitive and modern user experience.

### ✨ Key Features

-   ✅ **Employee Management:** Manage complete employee profiles, from personal information to employment history.
-   ✅ **Attendance Management:** Track employee clock-in and clock-out times, and summarize attendance records.
-   ✅ **Leave Management:** An online leave request and approval process with a clear workflow.
-   ✅ **Payroll Management:** Automatic salary calculation based on components like base salary, benefits, and deductions.
-   ✅ **Employee Self-Service (ESS) Portal:** Employees can view their personal data, remaining leave balances, and payslips.
-   ✅ **Role-Based Access Control (RBAC):** A role-based authorization system to ensure data security and confidentiality.
-   ✅ **Reporting & Analytics:** Generate essential reports to aid in strategic decision-making.

## 🖼️ Screenshots

| Main Dashboard | Employee List |
| :--------------------------------------------------------------------------: | :----------------------------------------------------------------: |
| _(Replace with your dashboard screenshot)_ <br> ![Dashboard Screenshot](https://via.placeholder.com/400x250.png?text=Application+Dashboard) | _(Replace with your employee list screenshot)_ <br> ![Employee List Screenshot](https://via.placeholder.com/400x250.png?text=Employee+List) |

| Leave Request Form | Employee Profile Detail |
| :--------------------------------------------------------------------------: | :----------------------------------------------------------------: |
| _(Replace with your leave request form screenshot)_ <br> ![Leave Request Screenshot](https://via.placeholder.com/400x250.png?text=Leave+Request+Form) | _(Replace with your employee profile screenshot)_ <br> ![Employee Profile Screenshot](https://via.placeholder.com/400x250.png?text=Employee+Profile) |

## 🛠️ Tech Stack

Here is a list of the primary technologies that power this application:

### Backend
* **.NET 6**
* **ASP.NET Core 6 MVC**
* **Entity Framework Core 6** (for ORM)
* **SQL Server** (or any other EF Core compatible database)
* **ASP.NET Core Identity** (for authentication & authorization)

### Frontend
* **HTML5 & CSS3**
* **Bootstrap 5** (for responsive layout and UI components)
* **JavaScript (ES6)**
* **jQuery** (for DOM manipulation and AJAX)
* **AJAX** (for data operations without a full page refresh)

### Tools
* **Visual Studio 2022** / **Visual Studio Code**
* **Git**
* **SQL Server Management Studio (SSMS)**

## 🚀 Getting Started

Follow the steps below to get this project up and running on your local environment.

### Prerequisites

Make sure you have the following software installed on your development machine:
1.  **.NET 6 SDK:** [Download from the official Microsoft site](https://dotnet.microsoft.com/download/dotnet/6.0)
2.  **SQL Server:** The Express or Developer edition is sufficient. [Download here](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
3.  **Git:** [Download Git](https://git-scm.com/downloads)
4.  **IDE (Optional but recommended):**
    * Visual Studio 2022
    * Visual Studio Code with the C# extension

### ⚙️ Installation

1.  **Clone the Repository**
    Open your terminal or command prompt and run the following command:
    ```bash
    git clone [https://github.com/your-username/your-hris-repo.git](https://github.com/your-username/your-hris-repo.git)
    cd your-hris-repo
    ```

2.  **Configure the Database Connection**
    * Open the `appsettings.json` file in the project root.
    * Modify the `ConnectionStrings` section to match your local SQL Server configuration.
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=HRIS_Db;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False"
    }
    ```
    *Replace `YOUR_SERVER_NAME` with your SQL Server instance name (e.g., `.` or `(localdb)\\mssqllocaldb` or `YOUR-PC\\SQLEXPRESS`).*

3.  **Run Database Migrations**
    * This command will create the database and all necessary tables based on the Entity Framework Core models.
    * Open a terminal in the project directory and run:
    ```bash
    dotnet ef database update
    ```
    *If the `dotnet ef` command is not found, install it globally first: `dotnet tool install --global dotnet-ef`*

4.  **Seed Initial Data (Optional)**
    * If your project has a mechanism for seeding initial data (e.g., a default admin user), run the corresponding command. Otherwise, you can add data manually after the application is running.
    ```bash
    # Example if you have a custom seed command
    dotnet run --seed
    ```

5.  **Run the Application**
    * **Via Terminal:**
        ```bash
        dotnet run
        ```
    * **Via Visual Studio:**
        * Open the `.sln` file with Visual Studio.
        * Press `F5` or the "Run" (▶) button.

    The application will be running at `https://localhost:XXXX` and `http://localhost:YYYY`. Open a browser and navigate to one of these URLs.
