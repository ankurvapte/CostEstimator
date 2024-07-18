using Microsoft.EntityFrameworkCore;

namespace CostEstimator.EFCore.Infrastructure;

public class CostEstimatorEfCoreDbContext : DbContext
{
    public CostEstimatorEfCoreDbContext(DbContextOptions<CostEstimatorEfCoreDbContext> options) 
        : base(options)
    {
        
    }

    public DbSet<Employee> Employees { get; set; }
}