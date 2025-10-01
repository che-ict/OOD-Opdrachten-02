# 39: EF Core - Migraties

In deze oefening leer je hoe je database migraties kunt gebruiken om je database schema te beheren. Hoewel we voor onze tests een in-memory database gebruiken (die geen migraties nodig heeft), is het beheren van schemawijzigingen met migraties een cruciaal onderdeel van het werken met 'echte' databases zoals SQL Server, PostgreSQL, of SQLite.

## Opdracht

1.  **Project opzetten**: Kopieer de modellen (`Blog.cs`, `Post.cs`) en de `BlogContext.cs` van de vorige oefening.

2.  **Installeer `dotnet-ef`**: Migraties worden beheerd met een command-line tool genaamd `dotnet-ef`. Installeer deze tool globaal als je dat nog niet hebt gedaan:
    ```bash
    dotnet tool install --global dotnet-ef
    ```

3.  **Voeg Design package toe**: Om migraties te kunnen gebruiken, heeft EF Core een 'design-time' package nodig. Voeg `Microsoft.EntityFrameworkCore.Design` toe aan je `App.csproj`.

4.  **Maak je eerste migratie**:
    *   Navigeer in je terminal naar de `App` directory.
    *   Voer het volgende commando uit om een migratie te maken die het schema voor `Blogs` en `Posts` aanmaakt:
        ```bash
        dotnet ef migrations add InitialCreate
        ```
    *   Bestudeer de gegenereerde migratie file in de nieuwe `Migrations` map.

5.  **Configureer een 'echte' database (optioneel, voor demonstratie)**:
    *   Pas de `OnConfiguring` methode in `BlogContext` aan om een `UseSqlite` te gebruiken als er geen andere provider is geconfigureerd. Voeg hiervoor de `Microsoft.EntityFrameworkCore.Sqlite` package toe.
        ```csharp
        optionsBuilder.UseSqlite("Data Source=blogging.db");
        ```

6.  **Pas de migratie toe (optioneel)**:
    *   Voer in de `App` directory het volgende commando uit om de migratie toe te passen en de database aan te maken/updaten:
        ```bash
        dotnet ef database update
        ```
    *   Je zult nu een `blogging.db` file zien verschijnen.

7.  **Tests**: De tests voor deze oefening blijven ongewijzigd en gebruiken nog steeds de in-memory database. Het doel is om de workflow van migraties te begrijpen.

## Vereisten

*   De `Microsoft.EntityFrameworkCore.Design` package moet zijn toegevoegd aan het `App` project.
*   Je moet succesvol een 'InitialCreate' migratie kunnen genereren.
*   De bestaande tests moeten nog steeds slagen met de in-memory database.

