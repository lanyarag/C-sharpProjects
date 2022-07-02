namespace employees
{
    public class Program
    {
        public static void Main()
        {
            Employee employee1 = new Employee("", 0);
            Employee employee2 = new Employee("", 0);

            employee1.CapName();
            employee1.CapWage();
            employee2.CapName();
            employee2.CapWage();



            double average = (employee1.Wage + employee2.Wage)/2;
            
            Console.WriteLine($"Name: {employee1.Name} | Salary: {employee1.Wage}");
            Console.WriteLine($"Name: {employee2.Name} | Salary: {employee2.Wage}");

            Console.WriteLine($"The averagy salary is {average}");
        }
    }
}