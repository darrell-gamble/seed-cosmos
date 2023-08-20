using UjuziTek.Portal.Data;
using Models = UjuziTek.Portal.Models;
using Microsoft.EntityFrameworkCore;
using UjuziTek.Portal.Models;

internal class Program
{
    static void Main()
    {
        using (var ctx = new PortalDBContext())
        {
            var Levels = new List<CurriculumLevel>();
            var Curricula = new List<Models.Curriculum>();
            var Courses = new List<Models.Course>();
            var CurriculumLevels = new List<Models.CurriculumLevel>();
            var CurriculumOwners = new List<Models.CurriculumOwner>();

            // Levels?.Add(new CurriculumLevel()
            // { 

            // }); 
        };

    }
}