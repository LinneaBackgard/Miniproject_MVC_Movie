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

Connection string (utveckling): Server=(localdb)\MSSQLLocalDB;Trusted_Connection=True;

ℹ️ Detta är en **lokal utvecklingsdatabas** som endast finns på den egna datorn.  
Den innehåller inga lösenord och inga externa servrar och är därför säker att ha i ett publikt GitHub-repo.

Databasen skapas och uppdateras via **Entity Framework migrations**.

---

## ⭐ Rating-fält

- Rating är av typen `decimal`
- Tillåtna värden: **0 – 10**
- Precision: **1 decimal** (t.ex. 7,5 eller 8,8)
- Validering sker både:
  - i modellen (DataAnnotations)
  - i databasen (HasPrecision)

---

## ▶️ Så kör du projektet

1. Klona repot
2. Öppna lösningen i Visual Studio
3. Kör migrations om databasen inte finns:
4. Starta projektet
5. Navigera till `/Movies` i webbläsaren

---

## 📌 Status

Detta är ett **utbildningsprojekt / mini-projekt**.

Fokus ligger på:
- förståelse för MVC-arkitektur
- Entity Framework Core
- Repository-pattern
- grundläggande validering
- tydlig och strukturerad kod

---

## 👤 Författare

Projektet är skapat som en del av kursarbete i **C# / ASP.NET Core MVC**.

