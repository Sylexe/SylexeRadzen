using SylexeRadzen.SQLManagement.Definitions;
using Microsoft.EntityFrameworkCore;

namespace SylexeRadzen.SQLManagement.Context;


public class SylexeDB : DbContext
{
    public SylexeDB(DbContextOptions<SylexeDB> options) : base(options)
    {
    }
    
    public DbSet<SylexeReports> sylexeReports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SylexeReports>().HasData(GetSylexeReports());
        base.OnModelCreating(modelBuilder);
    }

    private List<SylexeReports> GetSylexeReports()
    {
        return new List<SylexeReports>
        {
            new SylexeReports
            {
                Id = 1, Name = "Aquasec", Timestamp = "aquasec-trivy_0.34.0-05-juillet-2023-14_36_55", Path = "rat.json"
            }
        };
    }
}