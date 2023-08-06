using UjuziTek.Portal.Data;
using Models = UjuziTek.Portal.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    static void Main()
    {
        using (var ctx = new PortalDBContext())
        {
            var Curricula = new List<Models.Curriculum>();
            var Courses = new List<Models.Course>();
            var CurriculumLevels = new List<Models.CurriculumLevel>();
            var CurriculumOwners = new List<Models.CurriculumOwner>();

        };

    }
}