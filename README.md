# TechCon Convention Site

An ASP.NET Core MVC web application for managing a technology conference. Features exhibitor management, special guest tracking, booth uniqueness validation, an admin dashboard with full CRUD operations, confirmation flows, and TempData flash messages.

**Developer:** Landon Armstrong
**GitHub:** [Larmstrong1127](https://github.com/Larmstrong1127)
**Email:** Landon.Armstrong@stmartin.edu

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC |
| Language | C# |
| Database | SQLite + Entity Framework Core |
| Frontend | Razor Views, Bootstrap, Bootstrap Icons |

---

## Features

- **Exhibitor Management** — Full CRUD for companies attending the convention with booth number assignments
- **Special Guest Tracking** — Add, edit, and manage keynote speakers and featured guests with name, title, company, and bio
- **Booth Uniqueness Validation** — Server-side validation prevents two companies from sharing the same booth number
- **Admin Dashboard** — Central interface with quick access to all exhibitor and guest management actions
- **Confirmation Flows** — Delete confirmations to prevent accidental data loss
- **TempData Flash Messages** — Success feedback displayed after every create, update, and delete action
- **Hero Landing Page** — Welcome page with quick navigation links to all sections
- **Responsive UI** — Professional indigo/purple convention theme, mobile-friendly

---

## Project Structure

```
LandonWebsite06/
├── Controllers/
│   ├── HomeController.cs           # Hero landing page
│   ├── CompaniesController.cs      # Exhibitor CRUD and booth validation
│   └── SpecialGuestController.cs   # Special guest CRUD
├── Models/
│   ├── Companies.cs                # Exhibitor entity
│   └── SpecialGuest.cs             # Guest entity (name, title, company, bio)
├── Data/
│   └── MyDBContext.cs              # EF Core DbContext with seed data
├── Views/
│   ├── Home/Index.cshtml           # Hero landing page
│   ├── Companies/                  # ListAll, Add, Edit, Remove
│   └── SpecialGuest/               # ViewAll, Add, Edit, Delete
└── wwwroot/
    └── css/First.css               # Custom convention theme
```

---

## Setup Instructions

### Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2019+ or VS Code with the C# extension

### Run Locally

```bash
# Clone the repository
git clone https://github.com/Larmstrong1127/techcon-site.git
cd LandonWebsite06

# Restore NuGet packages
dotnet restore

# Run the application
dotnet run
```

Then open `http://localhost:5000` in your browser.

> **Note:** A SQLite database file (`Event.db`) will be created automatically on first run and seeded with sample exhibitor companies and special guests. This file is excluded from version control.

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
