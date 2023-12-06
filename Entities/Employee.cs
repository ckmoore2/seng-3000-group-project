namespace FinalGroupProject.Entities;

public class Employee

[Table("Employees")]

{
    public int EmployeeId { get; set; }
    [MaxLength(50)]

    public string FirstName { get; set; }
    [MaxLength(50)]

    public string? LastName { get; set; }

}