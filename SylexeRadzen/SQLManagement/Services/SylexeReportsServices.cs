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
}

public class SylexeReportsServices : ISylexeReportsServices
{
    private SylexeDB dbContext;
    
    public SylexeReportsServices(SylexeDB dbContext)
    {
        this.dbContext = dbContext;
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