namespace CostEstimator;

public class Employee
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string Department { get; set; } = string.Empty;
    public required string Email { get; set; }
}
