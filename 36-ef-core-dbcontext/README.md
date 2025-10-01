# 36: EF Core - DbContext en Models

In deze oefening leer je de basis van Entity Framework Core. Je gaat een `DbContext` opzetten en je eerste datamodel (entity) definiëren. We gebruiken een in-memory database voor de eenvoud en voor de tests.

## Opdracht

1.  **Maak een `Blog` model**: Creëer een class `Blog` in het `App` project met de volgende properties:
    *   `BlogId` (int)
    *   `Url` (string)

2.  **Maak een `BlogContext`**: Creëer een class `BlogContext` in het `App` project die overerft van `DbContext`.
    *   Voeg een `DbSet<Blog>` property toe met de naam `Blogs`.
    *   Voeg een constructor toe die `DbContextOptions<BlogContext>` accepteert en doorgeeft aan de base constructor.
    *   Override de `OnConfiguring` methode. Als de context nog niet geconfigureerd is, gebruik dan de in-memory database. Dit is handig voor de applicatie zelf, terwijl we in de tests de configuratie expliciet zullen meegeven.

3.  **Test je setup**: In het `App.Tests` project, schrijf een test die:
    *   Een `DbContextOptions` object aanmaakt voor de in-memory database.
    *   Een instantie van `BlogContext` aanmaakt met deze options.
    *   Een nieuw `Blog` object toevoegt aan de `Blogs` DbSet.
    *   `SaveChanges` aanroept.
    *   Verifieert dat het `Blog` object een `BlogId` heeft gekregen van de database.

## Vereisten

*   De `Blog` class moet de properties `BlogId` en `Url` hebben.
*   De `BlogContext` class moet overerven van `DbContext`.
*   De `BlogContext` moet een `DbSet<Blog>` property genaamd `Blogs` hebben.
*   De test moet succesvol een `Blog` kunnen toevoegen en opslaan in de in-memory database.

## NuGet Packages

Je hebt de volgende NuGet packages nodig:

*   In `App.csproj`:
    *   `Microsoft.EntityFrameworkCore`
*   In `App.Tests.csproj`:
    *   `Microsoft.EntityFrameworkCore.InMemory`
