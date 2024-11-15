# Appointment Management System for Clinic

This project is an API developed in **C#** with **ASP.NET Core**, using **Entity Framework** as ORM, **MySQL** as database and configuration through environment variables (`.env`). The main objective is to solve the problems related to appointment management in a private clinic, providing an efficient, organized and scalable technological solution.

---

## 🩺 **Project Objectives** **Project Objectives**
- Eliminate scheduling conflicts and duplicate appointments.
- Facilitate the management and visualization of physician schedules and availability.
- Provide a complete patient appointment history.
- Improve physician, patient and administrative staff experience when managing appointments.

---

## 🚀 **Key Features**.
1. **User and Role Management**:
   - Secure registration and authentication (with JWT tokens).
   - Roles: Administrator, Physician, Patient.
   - Restricted access according to role.

2. **Appointment Management**:
   - Avoid scheduling more than one appointment for the same doctor at the same time.
   - Real-time update of doctors' availability.
   - Appointment filtering by date, specialty or reason.
   - Record the reason for each appointment.
   - Add notes or comments to each appointment.
3. 3. **History and Follow-up**:
   - Display of patients' complete appointment history.
   - Clear and organized details of each past and future appointment.

4. **Notifications and Alerts**:
   - Warning in case of trying to schedule in a busy schedule.
   - Efficient handling of cancellations and rescheduling.

---

## 🛠️ **Technologies Used** **Backend**: ASP.NET Core (C#)
- Backend**: ASP.NET Core (C#)
- Database**: MySQL
- ORM**: Entity Framework Core
- Configuration**: `.env` files for environment variables
- Authentication**: JWT (JSON Web Tokens)

---

## ⚙️ **System Requirements**: **.NET SDK**: Version `.
- .NET SDK**: Version 7.0 or higher
- MySQL**: Version 8.0 or higher
- Node.js**: To manage the environment if frontend tools are required (optional)
- Package manager**: `NuGet`.
- Development tools**: Visual Studio / Visual Studio Code

---

## 📋 **Initial Configuration**.
### 1. Clone the Repository
```bash
git clone https://github.com/Z4pata/assestment-JuaJoseZapata.git
cd assestment-JuaJoseZapata
```

## 2. Configure the .env file

Create an .env file in the root directory with the following environment variables:
```bash
cp .env.example .env
```

## 3. Restore Dependencies

```bash
dotnet restore
```

## 4. Create the Database

Run the migrations to initialize the database:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 5. Run the Application
```bash
dotnet run
```

---

## 🧪 Main Endpoints
### Users

    POST /api/auth/register: New user registration.
    POST /api/auth/login: User authentication.

### Appointments

    GET /api/appointments: List appointments with filters (date, specialty, etc.).
    POST /api/appointments: Create a new appointment.
    PUT /api/appointments/{id}: Edit an existing appointment.
    DELETE /api/appointments/{id}: Cancel an appointment.

### Availability

    GET /api/doctors/{id}/availability: View availability of a doctor.

---

## 🧑‍💻 Contributions

### If you wish to contribute to the project:

    Create a fork of the repository.
    Work on a separate branch (feature/new-functionality).
    Make a pull request with your changes.
