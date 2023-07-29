namespace UjuziTek.Portal.Models;
public class ProgramStatus
{
    public string ID { get; private init; } = Guid.NewGuid().ToString();
    public string Name { get; init; } = "";
    public string? Description { get; init; } = "";

    public ProgramStatus(string name, string? description)
    {
        Name = name;
        Description = description;
    }
    public List<Program>? Programs { get; set; } = new List<Program>();
}
