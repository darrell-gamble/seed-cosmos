namespace UjuziTek.Portal.Models
{
    public class Program
    {
        public string ProgramID { get; private init; } = "";
        public string? Name { get; private init; } = "";
        public string? Description { get; private init; } = "";
        public string? ProgramTypeID { get; private init; } = "";
        public string? TechDomainID { get; private init; } = "";

        public Program
            (
                string programID,
                string name,
                string description,
                string programTypeID,
                string techDomainID
            )
        {
            ProgramID = programID;
            Name = name;
            Description = description;
            ProgramTypeID = programTypeID;
            TechDomainID = techDomainID;
        }
    }
}