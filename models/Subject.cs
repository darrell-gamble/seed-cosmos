namespace UjuziTek.Portal.Models;
public class Subject
{
    public string ID { get; private init; } = Guid.NewGuid().ToString();
    public string Name { get; private init; } = "";
    public string TopicID { get; private init; } = "";

    public Subject
        (
            string programID,
            string name,
            string topicID
        )
    {
        ID = programID;
        Name = name;
        TopicID = topicID;
    }
}