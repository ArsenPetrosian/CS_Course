using System.Reflection;

namespace EmployeeManagementSystem
{
    internal class Program
    {
        public static void DisplayTypeInformation(Type type)
        {
            Console.WriteLine($"Type Information for {type.Name}:");
            Console.WriteLine("Properties:");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine($"Name: {prop.Name}, Type: {prop.PropertyType.Name}");
            }
            Console.WriteLine();
        }

        public static void ValidateSalaryAttributeUsage(Type type)
        {
            PropertyInfo? salaryProperty = type.GetProperty("Salary");
            if (salaryProperty != null)
            {
                var attributes = salaryProperty.GetCustomAttributes(typeof(SalaryValidationAttribute), true);
                if (attributes.Length > 0)
                {
                    var salaryAttribute = (SalaryValidationAttribute)attributes[0];
                    double minimumSalary = salaryAttribute.MinimumSalary;
                    double maximumSalary = salaryAttribute.MaximumSalary;

                    Employee emp = new Employee();
                    emp.Salary = 8000;

                    if (emp.Salary < minimumSalary || emp.Salary > maximumSalary)
                    {
                        Console.WriteLine("Salary is not within the specified range.");
                    }
                    else
                    {
                        Console.WriteLine("Salary is within the specified range.");
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            DisplayTypeInformation(typeof(Employee));

            ValidateSalaryAttributeUsage(typeof(Employee));
        }
    }
}
