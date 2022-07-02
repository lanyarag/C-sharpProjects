
namespace employees
{
    public class Employee
    {
        public string Name { get; set; }
        public double Wage { get; set; }

        public Employee(string name, double wage)
        {
            Name = name;
            Wage = wage;
        }

        public string CapName()
        {
            Console.WriteLine("What's your name?");
            Name = Console.ReadLine();
            return Name;
        }
        public double CapWage()
        {
            Console.WriteLine("What's your salary?");
            Wage = double.Parse(Console.ReadLine());
            return Wage;
        }
    }
}
