namespace UjuziTek.Portal.Models;
public class Topic
{
    public string ID { get; private init; } = Guid.NewGuid().ToString();
    public string Name { get; private init; } = "";

    public Topic(string name, List<Subject>? subjects)
    {
        Name = name;
        Subjects = subjects;
    }
    public List<Subject>? Subjects { get; set; } = new List<Subject>();
}
 