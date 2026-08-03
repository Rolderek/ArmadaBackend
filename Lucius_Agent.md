# AGENTS.md

# Feladat

Olvasd be a Data/StarWarsArmadaCards.md fájlt, majd cseréld le
az AppDbContext.cs jelenlegi Card.HasData blokkját a teljes listára.

# Elvárt eredmény

- Ne módosíts más seed-adatokat.
- Ellenőrizd az ID-k egyediségét.
- Futtasd a buildet.
- A végén foglald össze a változtatásokat.

## Projekt

Implementáld ezt a markdown file-t ami implementálja a Star wars armda összes kártyáját és ellenőrizd hogy az AppDbContext.cs-ben lévő "protected override void OnModelCreating(ModelBuilder modelBuilder)" metódusban lévő adatok helyes e. 
Amennyiben nem frissítsd őket.
A file: 'C:\Users\resta\source\repos\ArmadaBackend\Data\StarWarsArmadaCards.md'

Technológiák:

- .NET SDK 9.0.17
- EntityFrameworkCore 9.0.18
- EntityFrameworkCore.SqlServer 9.0.18
- EntityFrameworkCore.Tools 9.0.18

A fő projekt:

- 'C:\Users\resta\source\repos\ArmadaBackend\ArmadaBackend.sln'

## Munkavégzési szabályok

- Módosítás előtt vizsgáld meg a kapcsolódó jelenlegi implementációt.
- Kövesd a repository meglévő szerkezetét és elnevezéseit.
- Ne végezz a feladathoz nem szükséges refaktorálást.
- Új production NuGet-csomag hozzáadása előtt jelezd az indokot és csak nagyon indokolt esetben használj újat.
- Titkot, jelszót vagy valódi connection stringet ne írj repository-fájlba.
- Felhasználói szövegek magyarul készüljenek.

## EF Core szabályok

- A meglévő DbContextet és entity-konfigurációs mintákat használd.
- Adatmodell-változáshoz EF Core migráció szükséges.
- A migrációk helye:
  `C:\Users\resta\source\repos\ArmadaBackend\Migrations`
- Már alkalmazott migrációt ne írj át.
- Production adatbázison ne futtass migrációt.
- Lekérdezésekhez használd az aszinkron EF Core API-kat.
- Olvasási műveletnél használj `AsNoTracking()`-et, ha nincs szükség módosításra.
- Kerüld az N+1 lekérdezéseket.
- Adatbázis-változáshoz készüljön teszt.

Migráció létrehozása:

```powershell
dotnet ef migrations add MigracioNeve `
  --project src/ArmadaBackend.sln `
  --output-dir Infrastructure/Persistence/Migrations