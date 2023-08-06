namespace UjuziTek.Portal.Models;
public class CurriculumOwner
{
    public string ID { get; private init; } = Guid.NewGuid().ToString();
    public string Name { get; private init; } = "";
    public CurriculumOwner(string name)
    {
        Name = name;
    }
    public List<Curriculum>? Curricula { get; set; } = new List<Curriculum>();
}