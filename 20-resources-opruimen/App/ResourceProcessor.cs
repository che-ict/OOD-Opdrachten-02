using System.Collections.Generic;

namespace App;

public static class ResourceProcessor
{
    public static List<string> ProcessResource()
    {
        var log = new List<string>();
        log.Add("Resource geopend");
        try
        {
            log.Add("Data verwerkt");
            throw new Exception("Fout!");
        }
        catch (Exception)
        {
            log.Add("Fout afgehandeld");
        }
        finally
        {
            log.Add("Resource vrijgegeven");
        }
        return log;
    }
}
