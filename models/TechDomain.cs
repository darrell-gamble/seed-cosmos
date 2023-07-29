namespace UjuziTek.Portal.Models;

public class TechDomain
{
    public string ID { get; private init; } = Guid.NewGuid().ToString();
    public string Name { get; private set; } = "";
    public TechDomain(string name)
    {
        Name = name;
    }
    public List<Program>? Programs { get; set; } = new List<Program>();
}
