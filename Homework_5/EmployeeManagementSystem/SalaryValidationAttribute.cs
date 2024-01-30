namespace EmployeeManagementSystem
{
    public class SalaryValidationAttribute : Attribute
    {
        public double MinimumSalary { get; }
        public double MaximumSalary { get; }

        public SalaryValidationAttribute(double minimumSalary, double maximumSalary)
        {
            MinimumSalary = minimumSalary;
            MaximumSalary = maximumSalary;
        }
    }
}
