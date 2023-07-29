namespace UjuziTek.Portal.Models;
public class Member
{
    public string ID { get; private init; } = Guid.NewGuid().ToString();
    public string Name { get; private init; } = "";
    public string? Description { get; private init; } = "";
    public string? ForeignKeyID { get; private init; } = "";
    public Member(string memberID, string name, string foreignKeyID, string description)
    {
        ID = memberID;
        Name = name;
        Description = description;
        ForeignKeyID = foreignKeyID;
    }
    public List<Course>? Courses { get; set; } = new List<Course>();
}