
namespace UjuziTek.Portal.Models;
public class Course
{
    public string ID { get; private init; } = Guid.NewGuid().ToString();
    public string Name { get; private init; } = "";
    public string? Description { get; private init; } = "";
    public string? CurriculimID { get; private init; } = "";
    public Course(string courseID, string name, string curriculimID, string description)
    {
        ID = courseID;
        Name = name;
        Description = description;
        CurriculimID = curriculimID;
    }
    public List<Member>? Members { get; set; } = new List<Member>();
}
