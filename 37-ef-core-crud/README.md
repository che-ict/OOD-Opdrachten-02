# 37: EF Core - CRUD Operaties

In deze oefening ga je de basis CRUD (Create, Read, Update, Delete) operaties implementeren met EF Core. Je bouwt voort op de vorige oefening door een `BlogService` te maken die de logica voor het beheren van blogs bevat.

## Opdracht

1.  **Neem de `Blog` en `BlogContext` over**: Kopieer de `Blog.cs` en `BlogContext.cs` files van de vorige oefening naar het `App` project.

2.  **Maak een `BlogService`**: Creëer een nieuwe class `BlogService` in het `App` project. Deze service is verantwoordelijk voor alle interactie met de `BlogContext`.
    *   De constructor van `BlogService` moet een `BlogContext` accepteren.
    *   Implementeer de volgende methoden:
        *   `AddBlog(string url)`: Voegt een nieuwe blog toe.
        *   `GetAllBlogs()`: Haalt alle blogs op.
        *   `GetBlog(int blogId)`: Haalt een specifieke blog op basis van ID.
        *   `UpdateBlogUrl(int blogId, string newUrl)`: Wijzigt de URL van een bestaande blog.
        *   `DeleteBlog(int blogId)`: Verwijdert een blog.

3.  **Test je service**: Schrijf tests in het `App.Tests` project voor elke methode in de `BlogService`. Gebruik een nieuwe in-memory database voor elke test om isolatie te garanderen.
    *   Test of je een blog kunt toevoegen en vervolgens kunt ophalen.
    *   Test of `GetAllBlogs` alle toegevoegde blogs retourneert.
    *   Test of je een blog kunt updaten.
    *   Test of je een blog kunt verwijderen.

## Vereisten

*   De `BlogService` moet de CRUD-methoden correct implementeren.
*   Elke publieke methode in `BlogService` moet getest worden.
*   Tests moeten onafhankelijk van elkaar zijn.

