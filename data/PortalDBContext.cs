using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UjuziTek.Portal.Models;

namespace UjuziTek.Portal.Data;
public class PortalDBContext : DbContext
{
    public DbSet<CurriculumOwner>? CurriculumOwners { get; set; }
    public DbSet<Curriculum>? Curricula { get; set; }
    public DbSet<CurriculumLevel>? CurriculumLevels { get; set; }
    public DbSet<Course>? Courses { get; set; }
    public DbSet<Member>? Members { get; set; }
    public DbSet<ProgramStatus>? ProgramStatuses { get; set; }
    public DbSet<ProgramType>? ProgramTypes { get; set; }
    public DbSet<UjuziTek.Portal.Models.Program>? Programs { get; set; }
    public DbSet<Subject>? Subjects { get; set; }
    public DbSet<TechDomain>? TechDomains { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseCosmos(
            "https://localhost:8081", // URI  => accountEndPoint
            "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==", // Primary Key => accountKey
            "UJUZITEKDB"); // databaseName => Azure Cosmos DB Account
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProgramType>()
            .ToContainer("ProgramTypes")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Programs);
            .HasMany(x => x.CurriculumLevels)
    
        modelBuilder.Entity<Program>()
            .ToContainer("Programs")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Curricula);
    
        modelBuilder.Entity<Curriculum>()
            .ToContainer("Curricula")
            .HasPartitionKey(e => e.ID);
    
        modelBuilder.Entity<CurriculumOwner>()
            .ToContainer("CurriculumOwners")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Curriculum);
    
        modelBuilder.Entity<CurriculumLevel>()
            .ToContainer("CurriculumLevels")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Curricula);
    
        modelBuilder.Entity<Course>()
            .ToContainer("Courses")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Members);
    
        modelBuilder.Entity<TechDomain>()
            .ToContainer("TechDomains")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Programs);
    
        modelBuilder.Entity<ProgramStatus>()
            .ToContainer("ProgramStatuses")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Programs);
    
        modelBuilder.Entity<Subject>()
            .ToContainer("Subjects")
            .HasPartitionKey(e => e.ID);
    
        modelBuilder.Entity<Member>()
            .ToContainer("Members")
            .HasPartitionKey(e => e.ID);
    
        modelBuilder.Entity<Topic>()
            .ToContainer("Topics")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Subjects);
    }
    
    
}
