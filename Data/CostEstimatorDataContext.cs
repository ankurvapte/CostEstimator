using CostEstimator;
using Microsoft.EntityFrameworkCore;

public class CostEstimatorDataContext : DbContext
{
    public CostEstimatorDataContext(DbContextOptions<CostEstimatorDataContext> options)
        : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; }

}