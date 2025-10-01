# 40: EF Core - Geavanceerd Queryen

In deze laatste EF Core oefening duiken we dieper in het queryen van data met LINQ. Je leert hoe je data kunt filteren, sorteren, en projecteren naar andere vormen.

## Opdracht

1.  **Project opzetten**: Kopieer de modellen (`Blog.cs`, `Post.cs`) en de `BlogContext.cs` van een van de vorige oefeningen.

2.  **Maak een `QueryService`**: Creëer een `QueryService` class in het `App` project. Deze service krijgt een `BlogContext` in de constructor.

3.  **Implementeer Query Methoden**:
    *   `GetBlogsOrderedByUrl()`: Haalt alle blogs op, gesorteerd op URL.
    *   `GetBlogsWithPosts()`: Haalt alle blogs op, inclusief hun gerelateerde posts (gebruik `Include`).
    *   `GetBlogsByUrlFragment(string fragment)`: Haalt alle blogs op waarvan de URL een bepaalde tekst bevat.
    *   `GetPostsWithBlogUrl()`: Dit is een voorbeeld van projectie. Haal alle posts op, maar retourneer een anoniem type (of een DTO als je dat wilt) met daarin de `Post.Title` en de `Blog.Url`.
    *   `GetPostCountPerBlog()`: Retourneer een lijst van objecten (anoniem of DTO) met `BlogUrl` en `NumberOfPosts`.

4.  **Test je queries**: Schrijf voor elke methode in `QueryService` een test in het `App.Tests` project. Zorg voor een goede set testdata zodat je de resultaten van je queries kunt verifiëren.
    *   Test of de blogs correct gesorteerd worden.
    *   Test of de `Include` correct werkt.
    *   Test of het filteren op URL fragment werkt.
    *   Test de projectie queries en controleer de structuur en data van de resultaten.

## Vereisten

*   De `QueryService` moet de verschillende query-methoden correct implementeren.
*   Elke methode moet worden getest om de correctheid van de query te valideren.
*   Gebruik LINQ-methodes zoals `OrderBy`, `Include`, `Where`, `Select`.

