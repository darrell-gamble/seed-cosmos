namespace UjuziTek.Portal.Models
{
    public class TechDomain
    {
        public string TechDomainID { get; private set; } = "";
        public string Name { get; private set; } = "";
        public TechDomain(string techDomainID, string name)
        {
            TechDomainID = techDomainID;
            Name = name;
        }
    }
}
