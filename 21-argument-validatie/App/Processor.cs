namespace App;

public class Processor
{
    public void ProcessName(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }
    }
}
