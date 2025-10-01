### Oefening 1: De `Vehicle` Hiërarchie
**Concept:** Basis- en Afgeleide Klassen

**Opdracht:** Maak een basisklasse `Vehicle` met eigenschappen zoals `Speed` en `Color`. Maak twee afgeleide klassen, `Car` en `Motorcycle`, die overerven van `Vehicle`. Voeg een unieke eigenschap toe aan `Car` (bv. `NumberOfDoors`) en een unieke aan `Motorcycle` (bv. `HasSidecar`).

**Gebruiksvoorbeeld:**
```csharp
public class Vehicle
{
    public double Speed { get; set; }
    public string Color { get; set; }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
}

// Om te testen:
var myCar = new Car { Speed = 180, Color = "Red", NumberOfDoors = 4 };
var myBike = new Motorcycle { Speed = 120, Color = "Black", HasSidecar = false };
// Controleer in een unit test dat myCar.Speed == 180
// Controleer in een unit test dat myBike.HasSidecar == false
```