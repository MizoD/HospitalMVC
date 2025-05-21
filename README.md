HospitalMVC
A simple ASP.NET Core MVC web application for managing hospital appointments.
Users can view doctors, and patients can book appointments with selected doctors through a user-friendly interface.

Features
Home page with hospital information

Doctor listing with specialties

Appointment booking form linked to doctors

Data stored in SQL Server via Entity Framework Core

Responsive layout using Bootstrap CSS

Technologies Used
ASP.NET Core MVC

Entity Framework Core

SQL Server

Bootstrap 5

C#

Getting Started
Prerequisites
.NET SDK 7.0+

SQL Server (or any EF Core compatible database)

Visual Studio 2022 / VS Code / Rider

Installation
Clone the repo

bash
Copy
Edit
git clone https://github.com/yourusername/HospitalMVC.git
cd HospitalMVC
Configure your database connection string in appsettings.json

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=HospitalDb;Trusted_Connection=True;"
}
Apply migrations and update database

bash
Copy
Edit
dotnet ef database update
Run the project

bash
Copy
Edit
dotnet run
Open browser at https://localhost:5001 or as specified

Usage
Navigate to the Doctors page to see available doctors.

Click Book an Appointment to schedule an appointment with the selected doctor.

Fill in patient details and submit to save the appointment.

Project Structure
Controllers/ - MVC controllers

Models/ - Entity models and database context

Views/ - Razor views and UI pages

wwwroot/ - Static files (CSS, JS, images)

Contribution
Feel free to fork the repo and submit pull requests.
Please open issues for bugs or feature requests.

License
This project is licensed under the MIT License.
