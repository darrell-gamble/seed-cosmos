
namespace UjuziTek.Portal.Models
{
    public class Subject
    {
        public string ProgramID { get; private init; } = "";
        public string Name { get; private init; } = "";
        public string TopicID { get; private init; } = "";

        public Subject
            (
                string programID,
                string name,
                string topicID
            )
        {
            ProgramID = programID;
            Name = name;
            TopicID = topicID;
        }
    }
}