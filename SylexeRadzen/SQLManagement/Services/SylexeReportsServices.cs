using SylexeRadzen.SQLManagement.Context;
using SylexeRadzen.SQLManagement.Definitions;
using Microsoft.EntityFrameworkCore;


namespace SylexeRadzen.SQLManagement.Services;

public interface ISylexeReportsServices
{
    Task<List<SylexeReports>> GetCategoriesAsync();
    Task<SylexeReports> AddCategoriesAsync(SylexeReports categories);
    Task<SylexeReports> UpdateCategoriesAsync(SylexeReports categories);
    Task DeleteCategoriesAsync(SylexeReports categories);
    string GetPathOfJson();
    void SetPathOfJson(string pathOfJson);
}

public class SylexeReportsServices : ISylexeReportsServices
{
    private SylexeDB dbContext;
    private string pathOfJson = "aquasec-trivy_0.34.0-07-juillet-2023-11_29_29.json";
    
    public SylexeReportsServices(SylexeDB dbContext)
    {
        this.dbContext = dbContext;
    }

    public string GetPathOfJson()
    {
        return this.pathOfJson;
    }
    public void SetPathOfJson(string path)
    {
        this.pathOfJson = path;
    }
    public async Task<List<SylexeReports>> GetCategoriesAsync()
    {
        return await dbContext.sylexeReports.ToListAsync();
    }
    
    public async Task<SylexeReports> AddCategoriesAsync(SylexeReports categories)
    {
        try
        {
            dbContext.sylexeReports.Add(categories);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        
        return categories;
    }
    
    public async Task<SylexeReports> UpdateCategoriesAsync(SylexeReports categories)
    {
        try
        {
            var CategoriesExist = dbContext.sylexeReports.FirstOrDefault(l => l.Id == categories.Id);
            if (CategoriesExist != null)
            {
                dbContext.Update(categories);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        
        return categories;
    }
    
    public async Task DeleteCategoriesAsync(SylexeReports categories)
    {
        try
        {
            dbContext.sylexeReports.Remove(categories);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
}