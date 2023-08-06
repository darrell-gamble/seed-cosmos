using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models = UjuziTek.Portal.Models;

namespace UjuziTek.Portal.Data;
public class PortalDBContext : DbContext
{
    public DbSet<Models.CurriculumOwner>? CurriculumOwners { get; set; }
    public DbSet<Models.Curriculum>? Curricula { get; set; }
    public DbSet<Models.CurriculumLevel>? CurriculumLevels { get; set; }
    public DbSet<Models.Course>? Courses { get; set; }
    public DbSet<Models.Member>? Members { get; set; }
    public DbSet<Models.ProgramStatus>? ProgramStatuses { get; set; }
    public DbSet<Models.ProgramType>? ProgramTypes { get; set; }
    public DbSet<Models.Program>? Programs { get; set; }
    public DbSet<Models.Subject>? Subjects { get; set; }
    public DbSet<Models.TechDomain>? TechDomains { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseCosmos(
            "https://localhost:8081", // URI  => accountEndPoint
            "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==", // Primary Key => accountKey
            "UJUZITEKDB"); // databaseName => Azure Cosmos DB Account
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.ProgramType>()
            .ToContainer("ProgramTypes")
            .HasPartitionKey(e => e.ID)
            .OwnsMany(x => x.Programs);
            // .OwnsMany(x => x.CurriculumLevels);
    
        modelBuilder.Entity<Models.Program>()
            .ToContainer("Programs")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Curricula);
    
        modelBuilder.Entity<Models.Curriculum>()
            .ToContainer("Curricula")
            .HasPartitionKey(e => e.ID)
            .OwnsMany(x => x.Curricula);
    
        modelBuilder.Entity<Models.CurriculumOwner>()
            .ToContainer("CurriculumOwners")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Curricula);
    
        modelBuilder.Entity<Models.CurriculumLevel>()
            .ToContainer("CurriculumLevels")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Curricula);
    
        modelBuilder.Entity<Models.Course>()
            .ToContainer("Courses")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Members);
    
        modelBuilder.Entity<Models.TechDomain>()
            .ToContainer("TechDomains")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Programs);
    
        modelBuilder.Entity<Models.ProgramStatus>()
            .ToContainer("ProgramStatuses")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Programs);
    
        modelBuilder.Entity<Models.Subject>()
            .ToContainer("Subjects")
            .HasPartitionKey(e => e.ID);
    
        modelBuilder.Entity<Models.Member>()
            .ToContainer("Members")
            .HasPartitionKey(e => e.ID);
    
        modelBuilder.Entity<Models.Topic>()
            .ToContainer("Topics")
            .HasPartitionKey(e => e.ID)
            .HasMany(x => x.Subjects);
    }
    
    
}
