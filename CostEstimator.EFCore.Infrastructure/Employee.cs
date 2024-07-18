public class Employee
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int DepartmentId { get; set; }
    public string? Department { get; set; }
}