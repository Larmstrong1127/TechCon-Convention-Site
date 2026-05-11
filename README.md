# TechCon 2024 Convention Site

A full-featured ASP.NET Core 3.1 MVC web application for managing a technology convention. Supports exhibitor company listings with booth assignments, special guest profiles, full CRUD operations, server-side validation, confirmation flows, and TempData flash messages — all backed by Entity Framework Core and SQLite.

**Developer:** Landon Armstrong
**GitHub:** [Larmstrong1127](https://github.com/Larmstrong1127)
**Email:** Landon.Armstrong@stmartin.edu

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core 3.1 MVC |
| Language | C# |
| Database | SQLite + Entity Framework Core 3.1 |
| Frontend | Razor Views, Bootstrap 4, Bootstrap Icons |

---

## Features

- **Exhibitor Management** — Full CRUD for companies attending the convention, including booth number assignments
- **Special Guest Tracking** — Add, edit, and manage keynote speakers and featured guests with name, title, company, and bio
- **Booth Uniqueness Validation** — Server-side validation prevents two companies from sharing the same booth number
- **Confirmation Flows** — Delete confirmation pages to prevent accidental data loss
- **TempData Flash Messages** — Success feedback displayed after every create, update, and delete action
- **Hero Landing Page** — Welcome page with feature cards and quick navigation to all sections
- **Responsive UI** — Bold orange/navy conference theme built with Bootstrap 4, works on mobile and desktop

---

## Project Structure

```
LandonWebsite06/
├── Controllers/
│   ├── HomeController.cs           # Hero landing page
│   ├── CompaniesController.cs      # Exhibitor CRUD and booth uniqueness validation
│   └── SpecialGuestController.cs   # Special guest CRUD
├── Models/
│   ├── Companies.cs                # Exhibitor entity (name, ID, booth number)
│   └── SpecialGuest.cs             # Guest entity (name, title, company, bio)
├── Data/
│   └── MyDBContext.cs              # EF Core DbContext with seed data
├── Views/
│   ├── Home/Index.cshtml           # Hero landing page with feature cards
│   ├── Companies/                  # ListAll, Add, Edit, Remove
│   └── SpecialGuest/               # ViewAll, Add, Edit, Delete
└── wwwroot/
    └── css/First.css               # Custom orange/navy convention theme
```

---

## Setup Instructions

### Prerequisites
- [.NET Core 3.1 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
- Visual Studio 2019+ or VS Code with the C# extension

### Run Locally

```bash
# Clone the repository
git clone https://github.com/Larmstrong1127/TechCon-Convention-Site.git
cd LandonWebsite06

# Restore NuGet packages
dotnet restore

# Run the application
dotnet run
```

Then open `http://localhost:5000` in your browser.

> **Note:** A SQLite database file (`Event.db`) will be created automatically on first run and seeded with sample exhibitor companies and special guests. This file is excluded from version control. To reset the data, delete `Event.db` and restart the application.

---

## Default Seed Data

**Exhibiting Companies**

| Company | Booth |
|---|---|
| Microsoft | 101 |
| Amazon Web Services | 102 |
| Google | 103 |
| NVIDIA | 104 |
| Epic Games | 105 |
| Intel | 106 |

**Special Guests**

| Guest | Title | Company |
|---|---|---|
| Dr. Sarah Chen | Director of AI Research | Microsoft |
| James Rodriguez | Chief Technology Officer | Amazon Web Services |
| Priya Patel | Lead Software Engineer | Google |
| Marcus Williams | Head of DevOps | NVIDIA |
| Dr. Emily Foster | Cybersecurity Advisor | CISA |
| Alex Thompson | Senior Game Developer | Epic Games |

---

## License

This project is for educational and portfolio purposes.

**Developer:** Landon Armstrong · [GitHub](https://github.com/Larmstrong1127)
