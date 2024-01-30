namespace EmployeeManagementSystem
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [SalaryValidation(1000, 10000)]
        public double Salary { get; set; }
    }
}
