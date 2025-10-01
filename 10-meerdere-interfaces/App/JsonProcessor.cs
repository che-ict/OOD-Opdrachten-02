namespace App;

public class JsonProcessor : ISerializable, IDeserializable
{
    public string Data { get; private set; }

    public string Serialize()
    {
        // TODO: Implement the Serialize method to return a JSON string representation of Data
        throw new NotImplementedException();
    }

    public void Deserialize(string data)
    {
        // TODO: Implement the Deserialize method to parse the input string and set the Data property
        throw new NotImplementedException();
    }
}
