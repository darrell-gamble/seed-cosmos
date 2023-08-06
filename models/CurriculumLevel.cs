
namespace UjuziTek.Portal.Models
{
    public class CurriculumLevel
    {
        public string ID { get; private init; } = Guid.NewGuid().ToString();
        public string Name { get; private init; } = "";
        public string? Description { get; private init; } = "";
        public string? ProgramTypeID { get; private init; } = "";

        public CurriculumLevel(string name, string programTypeID, string description)
        {
            ProgramTypeID = programTypeID;
            Name = name;
            Description = description;
        }
        public List<Curriculum>? Curricula { get; set; } = new List<Curriculum>();
    }
}