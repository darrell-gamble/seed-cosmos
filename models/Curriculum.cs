namespace UjuziTek.Portal.Models
{
    public class Curriculum
    {
        public string ID { get; private init; } = Guid.NewGuid().ToString();
        public string Name { get; private init; } = "";
        public string? Description { get; private init; } = "";
        public string? ProgramID { get; private init; } = "";
        public string CurriculumLevelID { get; set; } = "";
        public Curriculum(string curriculumLevelID, string name, string programID, string description)
        {
            CurriculumLevelID = curriculumLevelID;
            Name = name;
            Description = description;
            ProgramID = programID;
        }
        public List<Topic>? Topics { get; set; } = new List<Topic>();

        public List<Curriculum>? Curricula { get; set; } = new List<Curriculum>();
    }
}