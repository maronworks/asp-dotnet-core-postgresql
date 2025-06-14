# 🧠 MyApi

**MyApi** is a lightweight, modular RESTful Web API built using **ASP.NET Core** and **PostgreSQL**. It features full CRUD functionality for a `User` entity, powered by **Entity Framework Core**. This project is ideal for learning how to integrate databases in .NET or for bootstrapping production-ready APIs.

![License](https://img.shields.io/badge/license-MIT-purple)
![Platform](https://img.shields.io/badge/platform-.NET--Core-blue)
![Database](https://img.shields.io/badge/database-PostgreSQL-316192?logo=postgresql)
![ORM](https://img.shields.io/badge/ORM-Entity%20Framework%20Core-green)
![API](https://img.shields.io/badge/API-RESTful-lightgrey)
![Status](https://img.shields.io/badge/status-Development-yellow)

---

## 🔗 Repository

GitHub: [https://github.com/ralphmarondev/asp-dotnet-core-postgresql](https://github.com/ralphmarondev/asp-dotnet-core-postgresql)

---

## ✨ Features

* ✅ Full CRUD operations for `User` model
* 🐘 PostgreSQL integration via EF Core
* 🔄 Auto migrations and schema sync
* 🧪 Easy testing with Postman or Swagger
* 🧩 Clean and extensible architecture

---

## 🛠️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/ralphmarondev/asp-dotnet-core-postgresql.git
cd asp-dotnet-core-postgresql
````

---

## 🗃️ Setting Up the Database

> Make sure **PostgreSQL** is installed and running.

### 1. Create the database

```sql
CREATE DATABASE myapi;
```

### 2. Update the connection string in `appsettings.json`

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=myapi;Username=postgres;Password=yourpassword"
}
```

Replace `yourpassword` with your actual PostgreSQL password.

---

## 📦 Installing Dependencies

Install the required packages:

```bash
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-ef
```

---

## 🚧 Running the App

### 1. Apply Migrations

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 2. Run the API

```bash
dotnet run
```

The app will be available at:

* `http://localhost:5000`
* `https://localhost:5001`

---

## 🧪 Testing with Postman

| Method   | URL                                   | Description       | Body                         |
| -------- | ------------------------------------- | ----------------- | ---------------------------- |
| `GET`    | `http://localhost:5000/api/user`      | Fetch all users   | —                            |
| `GET`    | `http://localhost:5000/api/user/{id}` | Fetch user by ID  | —                            |
| `POST`   | `http://localhost:5000/api/user`      | Create a user     | `{ "name": "Ralph Maron" }`  |
| `PUT`    | `http://localhost:5000/api/user/{id}` | Update user by ID | `{ "name": "Updated Name" }` |
| `DELETE` | `http://localhost:5000/api/user/{id}` | Delete user by ID | —                            |

**Headers to include**:
`Content-Type: application/json`

---

## 📄 License

This project is licensed under the **MIT License**.
See the [LICENSE](LICENSE.txt) file for full details.

---

## 👤 Author

**Ralph Maron Eda**
GitHub: [@ralphmarondev](https://github.com/ralphmarondev)

---

## 🤝 Contributing

Suggestions and contributions are welcome!
Feel free to fork the repo, submit issues, or open pull requests.
Let’s build clean and efficient backends together. ⚙️🚀
