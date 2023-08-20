
namespace UjuziTek.Portal.Models;

public class Program
{
    public string ID { get; private init; } = Guid.NewGuid().ToString();
    public string Name { get; private init; } = "";
    public string? Description { get; private init; } = "";
    public string? ProgramTypeID { get; private init; } = "";
    public string? TechDomainID { get; private init; } = "";

    public Program
        (
            string name,
            string description,
            string programTypeID,
            string techDomainID
        )
    {
        Name = name;
        Description = description;
        ProgramTypeID = programTypeID;
        TechDomainID = techDomainID;
    }

    public List<Curriculum>? Curricula { get; set; } = new List<Curriculum>();
        public List<CurriculumLevel>? CurriculumLevels { get; set; } = new List<CurriculumLevel>();
}