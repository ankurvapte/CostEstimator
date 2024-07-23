using CostEstimator.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CostEstimator.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly CostEstimatorDataContext _dbcontext;

    public IndexModel(ILogger<IndexModel> logger, CostEstimatorDataContext dbcontext)
    {
        _logger = logger;
        _dbcontext = dbcontext;

        _dbcontext.Employees.Add(new Employee
        {
            Name = "Ankur",
            Email = "aapte@vitaledge.com"
        });
        _dbcontext.SaveChanges();
    }

    public void OnGet()
    {

    }
}
