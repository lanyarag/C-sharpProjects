
namespace Employee2
{
    public class Employee
    {
        string Name;
        double GrossSalary;
        double Salary;
        double Tax;

        public void ReadData()
        {
            Console.WriteLine("What's your name?");
            Name = Console.ReadLine();
            Console.WriteLine("How much is your salary?");
            GrossSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("How much do you pay in tax?");
            Tax = double.Parse(Console.ReadLine()); 
            Salary = GrossSalary - Tax;
        }

        public void PrintData()
        {
            Console.WriteLine($"{Name}'s salary is {Salary}");
        }

        public void SalaryIncrease()
        {
            Console.WriteLine("How much will the salary increase (%)?");
            double Increase = double.Parse(Console.ReadLine());
            double Increase2 = Increase / 100;
            Salary = Salary + (GrossSalary * Increase2);
            Console.WriteLine($"With the {Increase}% increase, the salary will be {Salary}");
        }
    }
}
