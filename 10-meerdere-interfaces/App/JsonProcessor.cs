namespace App;

public class JsonProcessor : ISerializable, IDeserializable
{
    public string Data { get; private set; }
    public string Serialize() => $"{{'Data':'{Data}'}}";
    public void Deserialize(string data) { Data = "Geparsed"; }
}
