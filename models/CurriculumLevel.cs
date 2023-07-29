namespace UjuziTek.Portal.Models
{
    public class Curriculum
    {
        public string ID { get; private init; } = Guid.NewGuid().ToString();
        public string Name { get; private init; } = "";
        public string? Description { get; private init; } = "";
        public string? ProgramTypeID { get; private init; } = "";
        public Curriculum(string curriculumID, string name, string programTypeID, string description)
        {
            ID = curriculumID;
            Name = name;
            Description = description;
            ProgramTypeID = programTypeID;
        }
        public List<Topic>? Topics { get; set; } = new List<Topic>();
    }
}