### Oefening 10: Meerdere Interfaces
**Concept:** Meerdere Interfaces Implementeren

**Opdracht:** Maak `ISerializable` (met `Serialize()`) en `IDeserializable` (met `Deserialize(string data)`). Maak een `JsonProcessor` klasse die beide implementeert en de data in een publieke eigenschap opslaat.

**Voorbeeld:**
```cs
var processor = new JsonProcessor();
processor.Deserialze("{\"Data\":\"Koekje\""); // De Data prop is nu 'Koekje'
processor.Serialize(); //returnt {"Data":"Koekje"}
```