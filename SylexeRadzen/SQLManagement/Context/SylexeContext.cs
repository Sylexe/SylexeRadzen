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
                Id = 1, Name = "aquasec-trivy_0.34.0", Timestamp = "07-juillet-2023-11_29_29", Path = "aquasec-trivy_0.34.0-07-juillet-2023-11_29_29.json"
            }
        };
    }
}