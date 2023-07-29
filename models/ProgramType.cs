
namespace UjuziTek.Portal.Models;
public class ProgramType
{
    public string ID { get; private init; } = Guid.NewGuid().ToString();
    public string Id { get; }
    public string Name { get; private set; } = "";
    public ProgramType(string id, string name)
    {
        Id = id;
        Name = name;
    }
    public List<Program>? Programs { get; set; } = new List<Program>();
}