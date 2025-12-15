# 🎬 Miniproject MVC – Movie Web Application

Detta är ett mini-projekt byggt med **ASP.NET Core MVC** som en del av kursmomentet kring  
Model–View–Controller, Entity Framework och Identity.

Applikationen är en enkel **Movie Web Application** där användaren kan skapa, visa, redigera och ta bort filmer.

---

## 🚀 Funktioner

- Visa lista med filmer
- Skapa nya filmer
- Visa detaljer om en film
- Redigera befintliga filmer
- Ta bort filmer
- Validering av formulär (t.ex. rating och årtal)
- Databas via Entity Framework Core
- Repository-pattern för databaskommunikation
- ASP.NET Core Identity (Individual Accounts) för framtida inloggning och roller

---

## 🧱 Tekniker som används

- ASP.NET Core MVC  
- Entity Framework Core  
- SQL Server LocalDB  
- ASP.NET Core Identity  
- C#  
- Razor Views  
- Bootstrap (för layout)

---

## 🗂️ Projektstruktur (översikt)

- **Controllers** – MVC-controllers (t.ex. `MoviesController`)
- **Models** – Domänmodeller (t.ex. `Movie`)
- **Data** – `ApplicationDbContext` och databaskonfiguration
- **Repositories** – Repository-interface och implementation
- **Views** – Razor-vyer
- **wwwroot** – Statiska filer (bilder, CSS m.m.)

---

## 🗄️ Databas

Projektet använder **SQL Server LocalDB** för utveckling.

Connection string (utveckling):

