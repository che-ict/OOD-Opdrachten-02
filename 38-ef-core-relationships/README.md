# 38: EF Core - Relaties

In deze oefening leer je hoe je relaties tussen je data modellen kunt definiëren. We zullen een one-to-many relatie opzetten tussen `Blog` en een nieuw model, `Post`.

## Opdracht

1.  **Modellen uitbreiden**: 
    *   Maak een nieuw `Post` model in het `App` project met de properties: `PostId` (int), `Title` (string), `Content` (string), `BlogId` (int), en een navigatieproperty `Blog` van het type `Blog`.
    *   Voeg aan de `Blog` class een navigatieproperty `Posts` toe van het type `List<Post>`.

2.  **DbContext aanpassen**:
    *   Voeg een `DbSet<Post>` property toe aan je `BlogContext` met de naam `Posts`.

3.  **Service uitbreiden**:
    *   Maak een `PostService` class. Deze service is verantwoordelijk voor alle interactie met de `Post` entiteiten.
    *   Implementeer een methode `AddPost(int blogId, string title, string content)` die een nieuwe post aan een specifieke blog toevoegt.
    *   Implementeer een methode `GetPostsForBlog(int blogId)` die alle posts voor een specifieke blog ophaalt.

4.  **Test je relaties**: Schrijf tests in het `App.Tests` project.
    *   Maak een test die een `Blog` toevoegt, vervolgens een `Post` aan die blog toevoegt, en verifieert dat de relatie correct is gelegd.
    *   Schrijf een test die een blog met meerdere posts ophaalt en controleert of alle posts correct worden geladen (gebruik `Include` in je query).

## Vereisten

*   Er moet een one-to-many relatie zijn tussen `Blog` en `Post`.
*   De `Blog` class moet een collectie van `Post` objecten hebben.
*   De `Post` class moet een referentie naar een `Blog` hebben.
*   De `PostService` moet posts kunnen toevoegen en ophalen per blog.
*   Tests moeten de correctheid van de relaties en de service methoden verifiëren.

